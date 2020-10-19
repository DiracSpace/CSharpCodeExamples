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
            this.txtTextInput = new System.Windows.Forms.TextBox();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startProgramBtn
            // 
            this.startProgramBtn.Location = new System.Drawing.Point(651, 12);
            this.startProgramBtn.Name = "startProgramBtn";
            this.startProgramBtn.Size = new System.Drawing.Size(106, 28);
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
            this.lvInformation.Location = new System.Drawing.Point(12, 82);
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
            // txtTextInput
            // 
            this.txtTextInput.Location = new System.Drawing.Point(220, 82);
            this.txtTextInput.Multiline = true;
            this.txtTextInput.Name = "txtTextInput";
            this.txtTextInput.Size = new System.Drawing.Size(537, 177);
            this.txtTextInput.TabIndex = 3;
            // 
            // txtOutputText
            // 
            this.txtOutputText.Location = new System.Drawing.Point(220, 265);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.Size = new System.Drawing.Size(537, 198);
            this.txtOutputText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 475);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.txtTextInput);
            this.Controls.Add(this.lvInformation);
            this.Controls.Add(this.startProgramBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startProgramBtn;
        private System.Windows.Forms.ListView lvInformation;
        private System.Windows.Forms.ColumnHeader chLetter;
        private System.Windows.Forms.ColumnHeader chFrequency;
        private System.Windows.Forms.TextBox txtTextInput;
        private System.Windows.Forms.TextBox txtOutputText;
    }
}

