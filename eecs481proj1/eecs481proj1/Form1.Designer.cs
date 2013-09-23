namespace eecs481proj1
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.blocker = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.firstLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.secondLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.thirdLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.blocker,
            this.firstLine,
            this.secondLine,
            this.thirdLine});
            this.shapeContainer1.Size = new System.Drawing.Size(612, 540);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // blocker
            // 
            this.blocker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blocker.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.blocker.Location = new System.Drawing.Point(553, 210);
            this.blocker.Name = "blocker";
            this.blocker.Size = new System.Drawing.Size(11, 69);
            // 
            // firstLine
            // 
            this.firstLine.BorderColor = System.Drawing.Color.Yellow;
            this.firstLine.Name = "firstLine";
            this.firstLine.X1 = 584;
            this.firstLine.X2 = 585;
            this.firstLine.Y1 = 4;
            this.firstLine.Y2 = 529;
            // 
            // secondLine
            // 
            this.secondLine.BorderColor = System.Drawing.Color.OrangeRed;
            this.secondLine.Name = "secondLine";
            this.secondLine.X1 = 592;
            this.secondLine.X2 = 593;
            this.secondLine.Y1 = 4;
            this.secondLine.Y2 = 529;
            // 
            // thirdLine
            // 
            this.thirdLine.BorderColor = System.Drawing.Color.Red;
            this.thirdLine.Name = "thirdLine";
            this.thirdLine.X1 = 598;
            this.thirdLine.X2 = 599;
            this.thirdLine.Y1 = 4;
            this.thirdLine.Y2 = 529;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape firstLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape secondLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape thirdLine;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape blocker;
        private System.Windows.Forms.Button button1;
    }
}

