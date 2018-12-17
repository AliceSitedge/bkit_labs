namespace Lab4
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelReadTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.buttonStrictSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStrictSearchTime = new System.Windows.Forms.Label();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(17, 16);
            this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(175, 28);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Чтение из файла";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла:";
            // 
            // labelReadTime
            // 
            this.labelReadTime.AutoSize = true;
            this.labelReadTime.Location = new System.Drawing.Point(415, 22);
            this.labelReadTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReadTime.Name = "labelReadTime";
            this.labelReadTime.Size = new System.Drawing.Size(0, 17);
            this.labelReadTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(215, 82);
            this.textBoxSearchWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(392, 22);
            this.textBoxSearchWord.TabIndex = 4;
            this.textBoxSearchWord.TextChanged += new System.EventHandler(this.textBoxSearchWord_TextChanged);
            // 
            // buttonStrictSearch
            // 
            this.buttonStrictSearch.Location = new System.Drawing.Point(17, 139);
            this.buttonStrictSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStrictSearch.Name = "buttonStrictSearch";
            this.buttonStrictSearch.Size = new System.Drawing.Size(175, 28);
            this.buttonStrictSearch.TabIndex = 5;
            this.buttonStrictSearch.Text = "Четкий поиск";
            this.buttonStrictSearch.UseVisualStyleBackColor = true;
            this.buttonStrictSearch.Click += new System.EventHandler(this.buttonStrictSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска слова:";
            // 
            // labelStrictSearchTime
            // 
            this.labelStrictSearchTime.AutoSize = true;
            this.labelStrictSearchTime.Location = new System.Drawing.Point(381, 145);
            this.labelStrictSearchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrictSearchTime.Name = "labelStrictSearchTime";
            this.labelStrictSearchTime.Size = new System.Drawing.Size(0, 17);
            this.labelStrictSearchTime.TabIndex = 7;
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.ItemHeight = 16;
            this.listBoxSearchResult.Location = new System.Drawing.Point(20, 188);
            this.listBoxSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(587, 180);
            this.listBoxSearchResult.TabIndex = 8;
            this.listBoxSearchResult.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchResult_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.labelStrictSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStrictSearch);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(661, 432);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelReadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.Button buttonStrictSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStrictSearchTime;
        private System.Windows.Forms.ListBox listBoxSearchResult;
    }
}

