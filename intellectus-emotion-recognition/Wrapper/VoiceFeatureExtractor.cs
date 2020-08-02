using EmotionRecognition.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmotionRecognition.Wrapper
{
    class VoiceFeatureExtractor
    {

        internal static VoiceFeatureExtractionResult Extract(IntPtr voice)
        {
            var qualityPointer = ExtractionQuality.CreatePointer();
            var probabilitiesPointer = EmotionsProbabilities.CreatePointer();

            VokaturiDDLImport.VokaturiVoice_extract(voice, qualityPointer, probabilitiesPointer);

            var quality = ExtractionQuality.FromPointer(qualityPointer);
            var probabilities = EmotionsProbabilities.FromPointer(probabilitiesPointer);
            return new VoiceFeatureExtractionResult(quality, probabilities);
        }

    }
}
