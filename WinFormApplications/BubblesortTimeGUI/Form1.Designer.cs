namespace BubblesortTimeGUI
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
            this.components = new System.ComponentModel.Container();
            this.unorderedArrayList = new System.Windows.Forms.ListBox();
            this.orderedArrayList = new System.Windows.Forms.ListBox();
            this.timeCalculationList = new System.Windows.Forms.ListBox();
            this.graphForMiliseconds = new ScottPlot.FormsPlot();
            this.iterations_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unorderedArrayList
            // 
            this.unorderedArrayList.FormattingEnabled = true;
            this.unorderedArrayList.ItemHeight = 15;
            this.unorderedArrayList.Location = new System.Drawing.Point(13, 50);
            this.unorderedArrayList.Name = "unorderedArrayList";
            this.unorderedArrayList.Size = new System.Drawing.Size(241, 469);
            this.unorderedArrayList.TabIndex = 0;
            // 
            // orderedArrayList
            // 
            this.orderedArrayList.FormattingEnabled = true;
            this.orderedArrayList.ItemHeight = 15;
            this.orderedArrayList.Location = new System.Drawing.Point(260, 50);
            this.orderedArrayList.Name = "orderedArrayList";
            this.orderedArrayList.Size = new System.Drawing.Size(189, 469);
            this.orderedArrayList.TabIndex = 0;
            // 
            // timeCalculationList
            // 
            this.timeCalculationList.FormattingEnabled = true;
            this.timeCalculationList.ItemHeight = 15;
            this.timeCalculationList.Location = new System.Drawing.Point(455, 50);
            this.timeCalculationList.Name = "timeCalculationList";
            this.timeCalculationList.Size = new System.Drawing.Size(189, 469);
            this.timeCalculationList.TabIndex = 0;
            // 
            // graphForMiliseconds
            // 
            this.graphForMiliseconds.Location = new System.Drawing.Point(651, 115);
            this.graphForMiliseconds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graphForMiliseconds.Name = "graphForMiliseconds";
            this.graphForMiliseconds.Size = new System.Drawing.Size(583, 404);
            this.graphForMiliseconds.TabIndex = 1;
            // 
            // iterations_txtbox
            // 
            this.iterations_txtbox.Location = new System.Drawing.Point(13, 24);
            this.iterations_txtbox.Name = "iterations_txtbox";
            this.iterations_txtbox.Size = new System.Drawing.Size(100, 23);
            this.iterations_txtbox.TabIndex = 2;
            this.iterations_txtbox.Text = "Iterations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "# of calculations";
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(119, 23);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(83, 23);
            this.calculate_btn.TabIndex = 4;
            this.calculate_btn.Text = "Start";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 527);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterations_txtbox);
            this.Controls.Add(this.graphForMiliseconds);
            this.Controls.Add(this.timeCalculationList);
            this.Controls.Add(this.orderedArrayList);
            this.Controls.Add(this.unorderedArrayList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox unorderedArrayList;
        private System.Windows.Forms.ListBox orderedArrayList;
        private System.Windows.Forms.ListBox timeCalculationList;
        private ScottPlot.FormsPlot graphForMiliseconds;
        private System.Windows.Forms.TextBox iterations_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate_btn;
    }
}

