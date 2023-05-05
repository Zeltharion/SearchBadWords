using System.Text;
using System.Text.RegularExpressions;
using ApplicationContext = SearchBadWords.Model.ApplicationContext;

namespace SearchBadWords
{
    public partial class MainForm : Form
    {
        List<string> words = null;
        List<Statistics> listStatistics = null;
        List<TopWords> listTopWords = null;
        ApplicationContext db = null;

        string pathFoundFiles = @"D:\for copy\";

        public MainForm()
        {
            InitializeComponent();
            db = new ApplicationContext();
            Task task = Task.Run(() => FillDriveNodes());
            toolTip1.SetToolTip(this.button_SaveIn, "Click and select a folder");
        }

        private void FillDriveNodes()
        {
            treeView_Directories.Nodes.Clear();

            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.Name != @"C:\")
                    {
                        TreeNode driveNode = new TreeNode(drive.Name);
                        driveNode.Tag = drive;
                        GetChildNode(driveNode, drive.Name);
                        UpdateTreeView(driveNode);
                    }
                }
            }
            catch (Exception) { }
        }

        private void GetChildNode(TreeNode treeNode, string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                if (directories.Length == 0) return;
                foreach (string dir in directories)
                {
                    TreeNode directoryNode = new();
                    directoryNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    directoryNode.Tag = dir;
                    GetChildNode(directoryNode, dir);
                    treeNode.Nodes.Add(directoryNode);
                }
            }
            catch (Exception) { }
        }

        private void UpdateTreeView(TreeNode threeNode)
        {
            if (treeView_Directories.InvokeRequired)
                treeView_Directories.Invoke(new Action<TreeNode>(UpdateTreeView), threeNode);
            else
                treeView_Directories.Nodes.Add(threeNode);
        }

        private void UpdateList(string text)
        {
            if (listBox_Files.InvokeRequired)
                listBox_Files.Invoke(new Action<string>(UpdateList), text);
            else
                listBox_Files.Items.Add(text);
        }

        private void UpdateLable(string text)
        {
            if (label_CurrentFile.InvokeRequired)
                label_CurrentFile.Invoke(new Action<string>(UpdateLable), text);
            else
                label_CurrentFile.Text = text;
        }

        private void UpdateProgressBar(int value)
        {
            if (progressBar_Files.InvokeRequired)
                progressBar_Files.Invoke(new Action<int>(UpdateProgressBar), value);
            else
                progressBar_Files.Value += value;
        }

        private void UpdateButton(bool b)
        {
            if (button_Statistics.InvokeRequired)
                button_Statistics.Invoke(new Action<bool>(UpdateButton), b);
            else
                button_Statistics.Visible = b;
        }

        private string FullTextInString(string[] str)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Count(); i++)
            {
                sb.AppendLine(str[i]);
            }
            return sb.ToString();
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            words = new List<string>();
            FilterForm filterForm = new FilterForm(words);
            filterForm.Show();
        }

        private void button_Statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(listStatistics);
            statisticsForm.Show();
        }

        private void button_SaveIn_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = treeView_Directories.SelectedNode;
            pathFoundFiles = treeNode.FullPath;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (treeView_Directories.SelectedNode != null)
            {
                progressBar_Files.Value = 0;
                listBox_Files.Items.Clear();
                button_Statistics.Visible = true;
                progressBar_Files.Visible = true;
                label_CurrentFile.Visible = true;

                TreeNode treeNode = treeView_Directories.SelectedNode;
                DirectoryInfo di = new DirectoryInfo(treeNode.FullPath);

                Task taskSearch = Task.Run(() =>
                {
                    listStatistics = new List<Statistics>();
                    listTopWords = new List<TopWords>();

                    Search(di);

                    if (listStatistics.Count > 0)
                        UpdateButton(true);

                    Task task = Task.Run(() =>
                    {
                        try
                        {
                            db.Statistics.AddRange(listStatistics);
                            db.TopWords.AddRange(listTopWords);
                            db.SaveChanges();
                        }
                        catch (Exception) { }
                    });
                });
            }
        }

        private void button_SaveIn_MouseEnter(object sender, EventArgs e)
        {
            label_PathSave.Text = pathFoundFiles;
        }

        private void button_SaveIn_MouseLeave(object sender, EventArgs e)
        {
            label_PathSave.Text = "";
        }

        private void Search(DirectoryInfo di)
        {
            try
            {
                DirectoryInfo[] directories = di.GetDirectories();

                foreach (DirectoryInfo dir in directories)
                    Search(dir);

                if (directories.Count() == 0 || di.GetFiles().Count() > 0)
                {
                    if ((di.GetFiles().Count() / 2 * 100) < 100)
                        UpdateProgressBar(di.GetFiles().Count() / 2 * 100);
                    else
                        UpdateProgressBar(100);

                    FileInfo[] files = di.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        bool IsFind = false;
                        int countWordsFound = 0;
                        FileInfo fi = null;

                        string[] str = File.ReadAllLines(file.FullName);
                        UpdateLable(file.FullName);

                        foreach (string word in words)
                        {
                            IsFind = false;

                            for (int i = 0; i < str.Count(); i++)
                            {
                                if (Regex.IsMatch(str[i], word))
                                {
                                    str[i] = str[i].Replace(word, "*******");
                                    string[] wordsStr = str[i].Split(new char[] { ' ', '!', ',', '?' }, StringSplitOptions.RemoveEmptyEntries);
                                    countWordsFound += wordsStr.Where(w => w == "*******").Count();
                                    IsFind = true;
                                }
                            }

                            if (IsFind)
                            {
                                fi = new FileInfo(file.FullName);
                                UpdateList(file.FullName);
                                File.Copy(fi.FullName, pathFoundFiles + fi.Name, true);

                                listStatistics.Add(new Statistics(word, file.FullName, (int)fi.Length, countWordsFound, countWordsFound));
                                listTopWords.Add(new TopWords(word, countWordsFound));

                                if (!Directory.Exists(pathFoundFiles + "newFiles\\"))
                                    Directory.CreateDirectory(pathFoundFiles + "newFiles");

                                using (FileStream fs = new FileStream(pathFoundFiles + "newFiles\\" + Path.GetFileNameWithoutExtension(file.Name) + DateTime.Now.Second + ".txt", FileMode.OpenOrCreate))
                                {
                                    byte[] bytes = Encoding.ASCII.GetBytes(FullTextInString(str));
                                    fs.Write(bytes, 0, bytes.Length);
                                }
                            }
                        }
                    }
                    return;
                }
            }
            catch (Exception) { }
        }

    }
}