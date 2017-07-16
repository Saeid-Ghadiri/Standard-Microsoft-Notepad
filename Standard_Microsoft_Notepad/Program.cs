namespace Standard_Microsoft_Notepad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            #region Service Apllication
            // **************************************************
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            // **************************************************
            #endregion / Service Apllication

            #region Application.Run
            // **************************************************
            MainForm startupForm = new MainForm();

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
            #endregion / Application.Run
        }
    }
}
