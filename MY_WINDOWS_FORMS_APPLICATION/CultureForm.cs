namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class CultureForm : System.Windows.Forms.Form
	{
		public CultureForm()
		{
			InitializeComponent();
		}

		private void PersianButton_Click(object sender, System.EventArgs e)
		{
			System.Globalization.CultureInfo cultureInfo =
				new System.Globalization.CultureInfo(name: "fa-IR");

			System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

			Hide();

			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void EnglishButton_Click(object sender, System.EventArgs e)
		{
			System.Globalization.CultureInfo cultureInfo =
				new System.Globalization.CultureInfo(name: "en-US");

			System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

			Hide();

			MainForm mainForm = new MainForm();
			mainForm.Show();
		}
	}
}
