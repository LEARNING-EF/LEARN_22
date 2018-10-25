namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.labelAge = new System.Windows.Forms.Label();
			this.labelFullName = new System.Windows.Forms.Label();
			this.labelEmailAddress = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(138, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(138, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(183, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(138, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(183, 20);
			this.textBox3.TabIndex = 2;
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(12, 15);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(26, 13);
			this.labelAge.TabIndex = 3;
			this.labelAge.Text = "Age";
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.Location = new System.Drawing.Point(12, 41);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(54, 13);
			this.labelFullName.TabIndex = 4;
			this.labelFullName.Text = "Full Name";
			// 
			// labelEmailAddress
			// 
			this.labelEmailAddress.AutoSize = true;
			this.labelEmailAddress.Location = new System.Drawing.Point(12, 67);
			this.labelEmailAddress.Name = "labelEmailAddress";
			this.labelEmailAddress.Size = new System.Drawing.Size(73, 13);
			this.labelEmailAddress.TabIndex = 5;
			this.labelEmailAddress.Text = "Email Address";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(138, 90);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(219, 90);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 7;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 261);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelEmailAddress);
			this.Controls.Add(this.labelFullName);
			this.Controls.Add(this.labelAge);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.Label labelEmailAddress;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonReset;
	}
}
