using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_desktop_client.Views.Suggestions
{
    public partial class PNL : MaterialSkin.Controls.MaterialForm
    {
        private Random Random;

        private bool unzipped = false;

        public PNL()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink400, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey50, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            Random = new Random();

            //UnZipFiles();
            OpenVideo();
        }

        private void UnZipFiles()
        {
            if (!unzipped)
            {
                string directory = FindProjectDirectory();
                var fullDirectory = directory + "/Views/Suggestions/Relaxation";
                var files = Directory.GetFiles(fullDirectory);
                if (files.Length == 1)
                    ZipFile.ExtractToDirectory(files[0], fullDirectory);

                unzipped = true;
            }
        }

        private void OpenVideo()
        {
            string directory = FindProjectDirectory();
            var files = Directory.GetFiles(directory + "/Views/Suggestions/Relaxation");
            var randomIndex = Random.Next(0, files.Length);
            Process.Start(files[randomIndex]);
        }


        private string FindProjectDirectory()
        {
            var rootDirectory = "";
            if (Assembly.GetEntryAssembly() != null)
                rootDirectory = Assembly.GetEntryAssembly().GetName().Name;
            else
                rootDirectory = Assembly.GetExecutingAssembly().GetName().Name;

            var environment = Environment.CurrentDirectory;

            var actual = new DirectoryInfo(environment);
            while (actual.Name.CompareTo(rootDirectory) != 0)
            {
                actual = actual.Parent;
                if (actual == null)
                    throw new DirectoryNotFoundException("Cannot find the project root");
            }
            return actual.FullName;
        }
    }
}
