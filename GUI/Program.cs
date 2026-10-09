using ServiceLager;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  Programmets startpunkt
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            BookSwapRegister register = new BookSwapRegister();
            register.FyllMedExempelData();

            Application.Run(new Form1());

        }
    }
}