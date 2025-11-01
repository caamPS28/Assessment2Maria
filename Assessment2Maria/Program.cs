/*
 * C# Assessment 2 – Version Control Proof
 * Author: Maria Camila Parada
 * Date: 1 Nov 2025
 * Notes: DVCS via Git + GitHub from VS2022
 */
namespace Assessment2Maria
{
    internal static class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    }
}