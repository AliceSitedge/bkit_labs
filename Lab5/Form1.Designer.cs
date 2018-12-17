namespace Lab5
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
            this.buttonApproxSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelApproxSearchTime = new System.Windows.Forms.Label();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(17, 16);
            this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(175, 75);
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
            this.label2.Location = new System.Drawing.Point(220, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(363, 66);
            this.textBoxSearchWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(265, 22);
            this.textBoxSearchWord.TabIndex = 4;
            // 
            // buttonApproxSearch
            // 
            this.buttonApproxSearch.Location = new System.Drawing.Point(17, 128);
            this.buttonApproxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApproxSearch.Name = "buttonApproxSearch";
            this.buttonApproxSearch.Size = new System.Drawing.Size(175, 64);
            this.buttonApproxSearch.TabIndex = 5;
            this.buttonApproxSearch.Text = "Нечеткий поиск";
            this.buttonApproxSearch.UseVisualStyleBackColor = true;
            this.buttonApproxSearch.Click += new System.EventHandler(this.buttonApproxSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска слова:";
            // 
            // labelApproxSearchTime
            // 
            this.labelApproxSearchTime.AutoSize = true;
            this.labelApproxSearchTime.Location = new System.Drawing.Point(381, 128);
            this.labelApproxSearchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApproxSearchTime.Name = "labelApproxSearchTime";
            this.labelApproxSearchTime.Size = new System.Drawing.Size(0, 17);
            this.labelApproxSearchTime.TabIndex = 7;
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.ItemHeight = 16;
            this.listBoxSearchResult.Location = new System.Drawing.Point(17, 225);
            this.listBoxSearchResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(611, 180);
            this.listBoxSearchResult.TabIndex = 8;
            this.listBoxSearchResult.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchResult_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Максимальное расстояние:";
            // 
            // textBoxMaxDistance
            // 
            this.textBoxMaxDistance.Location = new System.Drawing.Point(427, 172);
            this.textBoxMaxDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaxDistance.Name = "textBoxMaxDistance";
            this.textBoxMaxDistance.Size = new System.Drawing.Size(201, 22);
            this.textBoxMaxDistance.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 421);
            this.Controls.Add(this.textBoxMaxDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.labelApproxSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonApproxSearch);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button buttonApproxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelApproxSearchTime;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxDistance;
    }
}

