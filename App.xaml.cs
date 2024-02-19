using System.IO;
using MediiProiectGym.Data;
using System;

namespace MediiProiectGym
{

    public partial class App : Application
    {
        static GymListDatabase database;
        public static GymListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   GymListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}