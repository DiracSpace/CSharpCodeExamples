namespace HuffmanCompressionAlgorithm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startProgramBtn = new System.Windows.Forms.Button();
            this.lvInformation = new System.Windows.Forms.ListView();
            this.chLetter = new System.Windows.Forms.ColumnHeader();
            this.chFrequency = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // startProgramBtn
            // 
            this.startProgramBtn.Location = new System.Drawing.Point(220, 102);
            this.startProgramBtn.Name = "startProgramBtn";
            this.startProgramBtn.Size = new System.Drawing.Size(75, 23);
            this.startProgramBtn.TabIndex = 1;
            this.startProgramBtn.Text = "Start";
            this.startProgramBtn.UseVisualStyleBackColor = true;
            this.startProgramBtn.Click += new System.EventHandler(this.startProgramBtn_Click);
            // 
            // lvInformation
            // 
            this.lvInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLetter,
            this.chFrequency});
            this.lvInformation.HideSelection = false;
            this.lvInformation.Location = new System.Drawing.Point(13, 13);
            this.lvInformation.Name = "lvInformation";
            this.lvInformation.Size = new System.Drawing.Size(201, 381);
            this.lvInformation.TabIndex = 2;
            this.lvInformation.UseCompatibleStateImageBehavior = false;
            this.lvInformation.View = System.Windows.Forms.View.Details;
            // 
            // chLetter
            // 
            this.chLetter.Text = "Letter";
            this.chLetter.Width = 90;
            // 
            // chFrequency
            // 
            this.chFrequency.Text = "Frequency";
            this.chFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFrequency.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 406);
            this.Controls.Add(this.lvInformation);
            this.Controls.Add(this.startProgramBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startProgramBtn;
        private System.Windows.Forms.ListView lvInformation;
        private System.Windows.Forms.ColumnHeader chLetter;
        private System.Windows.Forms.ColumnHeader chFrequency;
    }
}

