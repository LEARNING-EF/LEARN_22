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
			this.persianButton = new System.Windows.Forms.Button();
			this.englishButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// persianButton
			// 
			this.persianButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.persianButton.Location = new System.Drawing.Point(18, 18);
			this.persianButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.persianButton.Name = "persianButton";
			this.persianButton.Size = new System.Drawing.Size(267, 35);
			this.persianButton.TabIndex = 0;
			this.persianButton.Text = "فارسی";
			this.persianButton.UseVisualStyleBackColor = true;
			this.persianButton.Click += new System.EventHandler(this.PersianButton_Click);
			// 
			// englishButton
			// 
			this.englishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.englishButton.Location = new System.Drawing.Point(18, 63);
			this.englishButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.englishButton.Name = "englishButton";
			this.englishButton.Size = new System.Drawing.Size(267, 35);
			this.englishButton.TabIndex = 1;
			this.englishButton.Text = "English";
			this.englishButton.UseVisualStyleBackColor = true;
			this.englishButton.Click += new System.EventHandler(this.EnglishButton_Click);
			// 
			// CultureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 115);
			this.Controls.Add(this.englishButton);
			this.Controls.Add(this.persianButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CultureForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button persianButton;
		private System.Windows.Forms.Button englishButton;
	}
}
