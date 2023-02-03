namespace NeptuneIDE
{
    partial class DebugMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cleardirButton = new System.Windows.Forms.Button();
            this.cleardirnameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debug Menu";
            // 
            // cleardirButton
            // 
            this.cleardirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleardirButton.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cleardirButton.Location = new System.Drawing.Point(12, 63);
            this.cleardirButton.Name = "cleardirButton";
            this.cleardirButton.Size = new System.Drawing.Size(132, 33);
            this.cleardirButton.TabIndex = 1;
            this.cleardirButton.Text = "Clear dirPath";
            this.cleardirButton.UseVisualStyleBackColor = true;
            this.cleardirButton.Click += new System.EventHandler(this.cleardirButton_Click);
            // 
            // cleardirnameButton
            // 
            this.cleardirnameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleardirnameButton.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cleardirnameButton.Location = new System.Drawing.Point(12, 102);
            this.cleardirnameButton.Name = "cleardirnameButton";
            this.cleardirnameButton.Size = new System.Drawing.Size(132, 33);
            this.cleardirnameButton.TabIndex = 2;
            this.cleardirnameButton.Text = "Clear dirName";
            this.cleardirnameButton.UseVisualStyleBackColor = true;
            this.cleardirnameButton.Click += new System.EventHandler(this.cleardirnameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Using this will cause instability";
            // 
            // DebugMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(408, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cleardirnameButton);
            this.Controls.Add(this.cleardirButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DebugMenu";
            this.Text = "NeptuneIDE // Debug Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button cleardirButton;
        private Button cleardirnameButton;
        private Label label2;
    }
}