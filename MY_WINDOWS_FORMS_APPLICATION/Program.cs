namespace MY_WINDOWS_FORMS_APPLICATION
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			CultureForm startupForm = new CultureForm();

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				startupForm = null;
			}
			// **************************************************
		}
	}
}
