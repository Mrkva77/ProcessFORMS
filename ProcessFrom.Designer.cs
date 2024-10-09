namespace KlasaProcess1
{
    partial class Form1
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
            this.buttonIExplorer = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonStartInfo = new System.Windows.Forms.Button();
            this.buttonExel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIExplorer
            // 
            this.buttonIExplorer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonIExplorer.Location = new System.Drawing.Point(12, 98);
            this.buttonIExplorer.Name = "buttonIExplorer";
            this.buttonIExplorer.Size = new System.Drawing.Size(254, 60);
            this.buttonIExplorer.TabIndex = 0;
            this.buttonIExplorer.Text = "Pokrenite internet Explorer";
            this.buttonIExplorer.UseVisualStyleBackColor = false;
            this.buttonIExplorer.Click += new System.EventHandler(this.buttonIExplorer_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonWord.Location = new System.Drawing.Point(12, 195);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(254, 60);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.Text = "Pokrenite Word";
            this.buttonWord.UseVisualStyleBackColor = false;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonStartInfo
            // 
            this.buttonStartInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStartInfo.Location = new System.Drawing.Point(373, 195);
            this.buttonStartInfo.Name = "buttonStartInfo";
            this.buttonStartInfo.Size = new System.Drawing.Size(254, 60);
            this.buttonStartInfo.TabIndex = 2;
            this.buttonStartInfo.Text = "Start Info";
            this.buttonStartInfo.UseVisualStyleBackColor = false;
            this.buttonStartInfo.Click += new System.EventHandler(this.buttonStartInfo_Click);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExel.Location = new System.Drawing.Point(373, 98);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Size = new System.Drawing.Size(254, 60);
            this.buttonExel.TabIndex = 3;
            this.buttonExel.Text = "Pokrenite Exel";
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 283);
            this.Controls.Add(this.buttonExel);
            this.Controls.Add(this.buttonStartInfo);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonIExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIExplorer;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonStartInfo;
        private System.Windows.Forms.Button buttonExel;
    }
}

