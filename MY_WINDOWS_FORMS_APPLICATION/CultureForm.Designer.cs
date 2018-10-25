namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class CultureForm
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
			this.buttonPersian = new System.Windows.Forms.Button();
			this.buttonEnglish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonPersian
			// 
			this.buttonPersian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPersian.Location = new System.Drawing.Point(12, 12);
			this.buttonPersian.Name = "buttonPersian";
			this.buttonPersian.Size = new System.Drawing.Size(178, 23);
			this.buttonPersian.TabIndex = 0;
			this.buttonPersian.Text = "فارسی";
			this.buttonPersian.UseVisualStyleBackColor = true;
			this.buttonPersian.Click += new System.EventHandler(this.buttonPersian_Click);
			// 
			// buttonEnglish
			// 
			this.buttonEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEnglish.Location = new System.Drawing.Point(12, 41);
			this.buttonEnglish.Name = "buttonEnglish";
			this.buttonEnglish.Size = new System.Drawing.Size(178, 23);
			this.buttonEnglish.TabIndex = 1;
			this.buttonEnglish.Text = "English";
			this.buttonEnglish.UseVisualStyleBackColor = true;
			this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
			// 
			// CultureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(202, 75);
			this.Controls.Add(this.buttonEnglish);
			this.Controls.Add(this.buttonPersian);
			this.Name = "CultureForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonPersian;
		private System.Windows.Forms.Button buttonEnglish;
	}
}
