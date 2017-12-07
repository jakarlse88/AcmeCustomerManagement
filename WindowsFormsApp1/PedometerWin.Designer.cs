namespace WindowsFormsApp1
{
	partial class PedometerWin
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
			this.label2 = new System.Windows.Forms.Label();
			this.GoalTextBox = new System.Windows.Forms.TextBox();
			this.StepsTextBox = new System.Windows.Forms.TextBox();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Step goal for today";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Steps taken today";
			// 
			// GoalTextBox
			// 
			this.GoalTextBox.Location = new System.Drawing.Point(245, 59);
			this.GoalTextBox.Name = "GoalTextBox";
			this.GoalTextBox.Size = new System.Drawing.Size(220, 22);
			this.GoalTextBox.TabIndex = 2;
			// 
			// StepsTextBox
			// 
			this.StepsTextBox.Location = new System.Drawing.Point(245, 99);
			this.StepsTextBox.Name = "StepsTextBox";
			this.StepsTextBox.Size = new System.Drawing.Size(220, 22);
			this.StepsTextBox.TabIndex = 3;
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(518, 59);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(120, 62);
			this.CalculateButton.TabIndex = 4;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Location = new System.Drawing.Point(72, 177);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ResultLabel.Size = new System.Drawing.Size(0, 17);
			this.ResultLabel.TabIndex = 5;
			this.ResultLabel.Click += new System.EventHandler(this.label3_Click);
			// 
			// PedometerWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 186);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.StepsTextBox);
			this.Controls.Add(this.GoalTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PedometerWin";
			this.Text = "Pedometer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox GoalTextBox;
		private System.Windows.Forms.TextBox StepsTextBox;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.Label ResultLabel;
	}
}