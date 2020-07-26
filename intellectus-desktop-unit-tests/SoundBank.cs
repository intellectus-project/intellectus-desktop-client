using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            var enviroment = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
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
