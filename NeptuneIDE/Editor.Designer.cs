namespace NeptuneIDE
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.projectTree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.verText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.languageLabel = new System.Windows.Forms.Label();
            this.loadedfileText = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileIntoDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neptuneIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNeptuneIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitNeptuneIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorTextbox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.projectTree);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 635);
            this.panel1.TabIndex = 0;
            // 
            // projectTree
            // 
            this.projectTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.projectTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.projectTree.ForeColor = System.Drawing.SystemColors.Control;
            this.projectTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.projectTree.Location = new System.Drawing.Point(3, 3);
            this.projectTree.Name = "projectTree";
            this.projectTree.Size = new System.Drawing.Size(166, 629);
            this.projectTree.TabIndex = 0;
            this.projectTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projectTree_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 71);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.verText);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 65);
            this.panel3.TabIndex = 1;
            // 
            // verText
            // 
            this.verText.AutoSize = true;
            this.verText.Location = new System.Drawing.Point(67, 23);
            this.verText.Name = "verText";
            this.verText.Size = new System.Drawing.Size(85, 15);
            this.verText.TabIndex = 2;
            this.verText.Text = "Build // 0.0b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "NeptuneIDE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeptuneIDE.Properties.Resources.neptuneide_logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.languageLabel);
            this.panel4.Controls.Add(this.loadedfileText);
            this.panel4.Controls.Add(this.menuStrip);
            this.panel4.Location = new System.Drawing.Point(192, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 71);
            this.panel4.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(850, 53);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.languageLabel.Size = new System.Drawing.Size(61, 15);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "lang here";
            // 
            // loadedfileText
            // 
            this.loadedfileText.AutoSize = true;
            this.loadedfileText.Location = new System.Drawing.Point(3, 53);
            this.loadedfileText.Name = "loadedfileText";
            this.loadedfileText.Size = new System.Drawing.Size(91, 15);
            this.loadedfileText.TabIndex = 3;
            this.loadedfileText.Text = "No file loaded";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.menuStrip.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.neptuneIDEToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(914, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.createToolStripMenuItem,
            this.saveChangesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveChangesToolStripMenuItem.Text = "Save changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem1,
            this.openDirectoryToolStripMenuItem,
            this.importFileIntoDirectoryToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // openDirectoryToolStripMenuItem1
            // 
            this.openDirectoryToolStripMenuItem1.Name = "openDirectoryToolStripMenuItem1";
            this.openDirectoryToolStripMenuItem1.Size = new System.Drawing.Size(230, 22);
            this.openDirectoryToolStripMenuItem1.Text = "Open directory";
            this.openDirectoryToolStripMenuItem1.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem1_Click);
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open directory in explorer";
            // 
            // importFileIntoDirectoryToolStripMenuItem
            // 
            this.importFileIntoDirectoryToolStripMenuItem.Name = "importFileIntoDirectoryToolStripMenuItem";
            this.importFileIntoDirectoryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.importFileIntoDirectoryToolStripMenuItem.Text = "Import file into directory";
            this.importFileIntoDirectoryToolStripMenuItem.Click += new System.EventHandler(this.importFileIntoDirectoryToolStripMenuItem_Click);
            // 
            // neptuneIDEToolStripMenuItem
            // 
            this.neptuneIDEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutNeptuneIDEToolStripMenuItem,
            this.exitNeptuneIDEToolStripMenuItem});
            this.neptuneIDEToolStripMenuItem.Name = "neptuneIDEToolStripMenuItem";
            this.neptuneIDEToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.neptuneIDEToolStripMenuItem.Text = "NeptuneIDE";
            // 
            // aboutNeptuneIDEToolStripMenuItem
            // 
            this.aboutNeptuneIDEToolStripMenuItem.Name = "aboutNeptuneIDEToolStripMenuItem";
            this.aboutNeptuneIDEToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutNeptuneIDEToolStripMenuItem.Text = "About NeptuneIDE";
            // 
            // exitNeptuneIDEToolStripMenuItem
            // 
            this.exitNeptuneIDEToolStripMenuItem.Name = "exitNeptuneIDEToolStripMenuItem";
            this.exitNeptuneIDEToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitNeptuneIDEToolStripMenuItem.Text = "Exit NeptuneIDE";
            this.exitNeptuneIDEToolStripMenuItem.Click += new System.EventHandler(this.exitNeptuneIDEToolStripMenuItem_Click);
            // 
            // editorTextbox
            // 
            this.editorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTextbox.AutoCompleteBrackets = true;
            this.editorTextbox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorTextbox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.editorTextbox.AutoScrollMinSize = new System.Drawing.Size(259, 45);
            this.editorTextbox.BackBrush = null;
            this.editorTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.editorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorTextbox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.editorTextbox.CharHeight = 15;
            this.editorTextbox.CharWidth = 8;
            this.editorTextbox.CommentPrefix = "--";
            this.editorTextbox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorTextbox.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editorTextbox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.editorTextbox.IsReplaceMode = false;
            this.editorTextbox.Language = FastColoredTextBoxNS.Language.Lua;
            this.editorTextbox.LeftBracket = '(';
            this.editorTextbox.LeftBracket2 = '{';
            this.editorTextbox.LineNumberColor = System.Drawing.Color.MintCream;
            this.editorTextbox.Location = new System.Drawing.Point(192, 82);
            this.editorTextbox.Name = "editorTextbox";
            this.editorTextbox.Paddings = new System.Windows.Forms.Padding(0);
            this.editorTextbox.RightBracket = ')';
            this.editorTextbox.RightBracket2 = '}';
            this.editorTextbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorTextbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorTextbox.ServiceColors")));
            this.editorTextbox.Size = new System.Drawing.Size(911, 632);
            this.editorTextbox.TabIndex = 4;
            this.editorTextbox.Text = "Load an file to start editing\r\n\r\nFile > Open file";
            this.editorTextbox.Zoom = 100;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1111, 729);
            this.Controls.Add(this.editorTextbox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "NeptuneIDE // Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorTextbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private MenuStrip menuStrip;
        private Label label1;
        private Label verText;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem directoryToolStripMenuItem;
        private ToolStripMenuItem neptuneIDEToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem openDirectoryToolStripMenuItem;
        private ToolStripMenuItem importFileIntoDirectoryToolStripMenuItem;
        private Label loadedfileText;
        public TreeView projectTree;
        private ToolStripMenuItem saveChangesToolStripMenuItem;
        private ToolStripMenuItem aboutNeptuneIDEToolStripMenuItem;
        private ToolStripMenuItem exitNeptuneIDEToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem openDirectoryToolStripMenuItem1;
        public Label languageLabel;
        public FastColoredTextBoxNS.FastColoredTextBox editorTextbox;
    }
}