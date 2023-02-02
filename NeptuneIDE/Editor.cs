using System;
using System.IO;
using System.Windows.Forms;
using Windows.Globalization;

namespace NeptuneIDE
{
    public partial class Editor : Form // moja żona mnie nie kocha 
    {
        public static string dirPath;
        public static string dirName;
        public static string filePath;
        public static string editorLanguage;
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            verText.Text = "Build // " + Program.ver;
            languageLabel.Text = "";

            Program.log("Editor ready.");
        }
        private void loadNodes()
        {
            Program.log("Beginning node update");
            projectTree.BeginUpdate();

            projectTree.Nodes.Add(dirName);
            Program.log("Created header node");

            Program.log("Adding file nodes");
            string[] files = Directory.GetFiles(dirPath);

            foreach (string file in files)
            {
                string file1 = Path.GetFileName(file);
                projectTree.Nodes[0].Nodes.Add(file1);
                Program.log("  Added child node : " + file1);
            }
            Program.log("Finished adding nodes");
            projectTree.EndUpdate();
            Program.log("Ended node update");
        }

        private void projectTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null) // if is header return
            {
                return;
            }
            Program.log("Child node clicked");
            Program.log("  Name : " + e.Node.Text);
            Program.log("Calling loadFile");
            loadFileFromTree(e.Node.Text);
        }

        private void loadFileFromTree(string file)
        {
            if (File.Exists(dirPath + @"\" + file))
            {
                Program.log("Loading in file");
                filePath = dirPath + @"\" + file;
                Program.log("  name : " + file);
                Program.log("  path : " + filePath);
                editorTextbox.Text = File.ReadAllText(filePath);
                Program.log("Pushed file to editorTextbox");
                loadedfileText.Text = filePath;
                Program.log("Set loadedfileText to filePath");

                SetHighlighting(filePath);
            }   
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                MessageBox.Show("No file loaded");
                return;
            }
            Program.log("Saving file");
            File.WriteAllText(filePath, editorTextbox.Text);
            Program.log("Wrote editorTextbox contents to file");
        }

        private void exitNeptuneIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.log("Exiting NeptuneIDE");
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Program.log("Opening openFileDialog");
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    Program.log("Set filePath to : " + filePath);
                    editorTextbox.Text = File.ReadAllText(filePath);

                    Program.log("Pushed file to editorTextbox");
                    loadedfileText.Text = filePath;

                    Program.log("Setting highlighting");
                    SetHighlighting(filePath);
                }      
            }
            catch (Exception ex)
            {
                Program.log("Could not open file");
                Program.log("Exception : " + ex);
            }
        }
        private void SetHighlighting(string path)
        {
            editorTextbox.Language = FastColoredTextBoxNS.Language.Custom;
            if (path.EndsWith(".cs"))
            {
                Program.log("Detected CSharp file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            if (path.EndsWith(".vb"))
            {
                Program.log("Detected VBasic file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.VB;
            }
            if (path.EndsWith(".html"))
            {
                Program.log("Detected HTML file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.HTML;
            }
            if (path.EndsWith(".xml"))
            {
                Program.log("Detected XML file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.XML;
            }
            if (path.EndsWith(".sql"))
            {
                Program.log("Detected SQL file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.SQL;
            }
            if (path.EndsWith(".php"))
            {
                Program.log("Detected PHP file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.PHP;
            }
            if (path.EndsWith(".js"))
            {
                Program.log("Detected Javascript file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.JS;
            }
            if (path.EndsWith(".lua"))
            {
                Program.log("Detected Lua file");
                editorTextbox.Language = FastColoredTextBoxNS.Language.Lua;
            }
            editorLanguage = editorTextbox.Language.ToString();
            languageLabel.Text = editorLanguage;

            editorTextbox.OnTextChanged();

            Program.SetFileRPC();
        }

        private void openDirectoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dirPath = dialog.SelectedPath;
                dirName = Path.GetDirectoryName(dirPath);
                
                loadNodes();
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            Stream myStream;

            saveFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = dirPath;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog1.FileName).Close();
                if (editorTextbox.Text.Length > 0) 
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.WriteLine(editorTextbox.Text);
                    sw.Close();
                }
            }
        }

        private void importFileIntoDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirPath == null)
            {
                MessageBox.Show("No directory loaded");
                return;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(dirPath, openFileDialog.FileName);
            }
        }
    }
}