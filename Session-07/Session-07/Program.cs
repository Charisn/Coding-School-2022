namespace Session_07
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {

            Application.SetCompatibleTextRenderingDefault(false);   
            ApplicationConfiguration.Initialize();
            Application.Run(new XtraForm());



            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();


        }
    }
}