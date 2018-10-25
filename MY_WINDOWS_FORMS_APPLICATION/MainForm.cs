namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			buttonSave.Text = Resources.Buttons.Save;
			buttonReset.Text = Resources.Buttons.Reset;

			labelAge.Text = Resources.Models.User.Age;
			labelFullName.Text = Resources.Models.General.FullName;
			labelEmailAddress.Text = Resources.Models.General.EmailAddress;

			string culture =
				System.Threading.Thread.CurrentThread.CurrentUICulture.Name
				.Substring(startIndex: 0, length: 2);

			switch (culture.ToUpper())
			{
				case "FA":
				case "AR":
				{
					RightToLeftLayout = true;
					RightToLeft = System.Windows.Forms.RightToLeft.Yes;

					break;
				}

				default:
				{
					RightToLeftLayout = false;
					RightToLeft = System.Windows.Forms.RightToLeft.No;

					break;
				}
			}
		}
	}
}
