using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests
{
    class SoundBank
    {
        private string projectDirectory, pathToSoundBank, pathToTemp;
        private List<string> sounds;


        public SoundBank()
        {
            projectDirectory = FindProjectDirectory();
            pathToSoundBank = projectDirectory + SoundBankRelativeLocation;
            pathToTemp = projectDirectory + TempFolderRelativeLocation;

            if (!Directory.Exists(pathToSoundBank))
                Directory.CreateDirectory(pathToSoundBank);

            if (!Directory.Exists(pathToTemp))
                Directory.CreateDirectory(pathToTemp);

            sounds = new List<string>(Directory.EnumerateFiles(PathToSoundBank));
            if (sounds.Count == 0)
                throw new FileNotFoundException("Sound bank is empty");
        }

        private string FindProjectDirectory()
        {
            var rootDirectory = Assembly.GetExecutingAssembly().GetName().Name;
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


        public string PathToSoundBank => pathToSoundBank;
        public string PathToTemp => pathToTemp;

        public List<string> SoundFiles => sounds;

        private static string SoundBankRelativeLocation = "/Bank/";

        private static string TempFolderRelativeLocation = "/Temp/";

        private static SoundBank instance;

        public static SoundBank Instance
        {
            get
            {
                if (instance == null)
                    instance = new SoundBank();
                return instance;
            }
        }


    }
}
