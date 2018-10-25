namespace MY_WINDOWS_FORMS_APPLICATION.Infrastructure
{
	public partial class BaseForm : System.Windows.Forms.Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		private void BaseForm_Load(object sender, System.EventArgs e)
		{
			if (DesignMode == false)
			{
				string strCurrentCultureName =
					System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToUpper().Substring(0, 2);

				switch (strCurrentCultureName)
				{
					case "AR":
					case "FA":
					{
						RightToLeftLayout = true;
						Font = new System.Drawing.Font("Tahoma", 8);
						RightToLeft = System.Windows.Forms.RightToLeft.Yes;

						break;
					}

					default:
					{
						RightToLeftLayout = false;
						Font = new System.Drawing.Font("Verdana", 8);
						RightToLeft = System.Windows.Forms.RightToLeft.No;

						break;
					}
				}
			}
		}
	}
}
