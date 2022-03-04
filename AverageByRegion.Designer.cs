
namespace Lab_1
{
    partial class AverageByRegion
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
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxEntriesRegion1 = new System.Windows.Forms.TextBox();
            this.labelOverallAverage = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEntriesRegion2 = new System.Windows.Forms.TextBox();
            this.textBoxEntriesRegion3 = new System.Windows.Forms.TextBox();
            this.labelAverageRegion1 = new System.Windows.Forms.Label();
            this.labelAverageRegion2 = new System.Windows.Forms.Label();
            this.labelAverageRegion3 = new System.Windows.Forms.Label();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.AutoSize = true;
            this.labelUnitsPrompt.Location = new System.Drawing.Point(48, 34);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(49, 20);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Cases:";
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(103, 34);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(125, 27);
            this.textBoxUnits.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxUnits, "Enter the day\'s number of units shipped");
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(430, 34);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(47, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // textBoxEntriesRegion1
            // 
            this.textBoxEntriesRegion1.BackColor = System.Drawing.Color.White;
            this.textBoxEntriesRegion1.Location = new System.Drawing.Point(23, 130);
            this.textBoxEntriesRegion1.Multiline = true;
            this.textBoxEntriesRegion1.Name = "textBoxEntriesRegion1";
            this.textBoxEntriesRegion1.ReadOnly = true;
            this.textBoxEntriesRegion1.Size = new System.Drawing.Size(125, 183);
            this.textBoxEntriesRegion1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxEntriesRegion1, "Display the units shipped for each day");
            // 
            // labelOverallAverage
            // 
            this.labelOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOverallAverage.Location = new System.Drawing.Point(23, 395);
            this.labelOverallAverage.Name = "labelOverallAverage";
            this.labelOverallAverage.Size = new System.Drawing.Size(443, 26);
            this.labelOverallAverage.TabIndex = 12;
            this.labelOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelOverallAverage, "Display the calculated average units shipped");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(34, 437);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Click to enter the current units shipped ");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(210, 437);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(358, 437);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxEntriesRegion2
            // 
            this.textBoxEntriesRegion2.BackColor = System.Drawing.Color.White;
            this.textBoxEntriesRegion2.Location = new System.Drawing.Point(179, 130);
            this.textBoxEntriesRegion2.Multiline = true;
            this.textBoxEntriesRegion2.Name = "textBoxEntriesRegion2";
            this.textBoxEntriesRegion2.ReadOnly = true;
            this.textBoxEntriesRegion2.Size = new System.Drawing.Size(125, 183);
            this.textBoxEntriesRegion2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxEntriesRegion2, "Display the units shipped for each day");
            // 
            // textBoxEntriesRegion3
            // 
            this.textBoxEntriesRegion3.BackColor = System.Drawing.Color.White;
            this.textBoxEntriesRegion3.Location = new System.Drawing.Point(341, 130);
            this.textBoxEntriesRegion3.Multiline = true;
            this.textBoxEntriesRegion3.Name = "textBoxEntriesRegion3";
            this.textBoxEntriesRegion3.ReadOnly = true;
            this.textBoxEntriesRegion3.Size = new System.Drawing.Size(125, 183);
            this.textBoxEntriesRegion3.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxEntriesRegion3, "Display the units shipped for each day");
            // 
            // labelAverageRegion1
            // 
            this.labelAverageRegion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageRegion1.Location = new System.Drawing.Point(23, 342);
            this.labelAverageRegion1.Name = "labelAverageRegion1";
            this.labelAverageRegion1.Size = new System.Drawing.Size(125, 26);
            this.labelAverageRegion1.TabIndex = 5;
            this.labelAverageRegion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageRegion1, "Display the calculated average units shipped");
            // 
            // labelAverageRegion2
            // 
            this.labelAverageRegion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageRegion2.Location = new System.Drawing.Point(179, 342);
            this.labelAverageRegion2.Name = "labelAverageRegion2";
            this.labelAverageRegion2.Size = new System.Drawing.Size(125, 26);
            this.labelAverageRegion2.TabIndex = 8;
            this.labelAverageRegion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageRegion2, "Display the calculated average units shipped");
            // 
            // labelAverageRegion3
            // 
            this.labelAverageRegion3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageRegion3.Location = new System.Drawing.Point(341, 342);
            this.labelAverageRegion3.Name = "labelAverageRegion3";
            this.labelAverageRegion3.Size = new System.Drawing.Size(125, 26);
            this.labelAverageRegion3.TabIndex = 11;
            this.labelAverageRegion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageRegion3, "Display the calculated average units shipped");
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Location = new System.Drawing.Point(57, 92);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(71, 20);
            this.labelRegion1.TabIndex = 3;
            this.labelRegion1.Text = "Region &1:";
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(215, 92);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(68, 20);
            this.labelRegion2.TabIndex = 6;
            this.labelRegion2.Text = "Region &2";
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(384, 92);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(68, 20);
            this.labelRegion3.TabIndex = 9;
            this.labelRegion3.Text = "Region &3";
            // 
            // AverageByRegion
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(489, 474);
            this.Controls.Add(this.labelAverageRegion3);
            this.Controls.Add(this.labelAverageRegion2);
            this.Controls.Add(this.labelAverageRegion1);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.textBoxEntriesRegion3);
            this.Controls.Add(this.textBoxEntriesRegion2);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelOverallAverage);
            this.Controls.Add(this.textBoxEntriesRegion1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageByRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxEntriesRegion1;
        private System.Windows.Forms.Label labelOverallAverage;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.TextBox textBoxEntriesRegion2;
        private System.Windows.Forms.TextBox textBoxEntriesRegion3;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.Label labelAverageRegion1;
        private System.Windows.Forms.Label labelAverageRegion2;
        private System.Windows.Forms.Label labelAverageRegion3;
    }
}

