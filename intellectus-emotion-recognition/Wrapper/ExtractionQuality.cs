using intellectus_emotion_recognition.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmotionRecognition.Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct ExtractionQuality
	{
		int valid;   // 1 = "there were voiced frames, so that the measurements are valid"; 0 = "no voiced frames found"
		int num_frames_analyzed;
		int num_frames_lost;

		public IntPtr ToPointer(bool deleteOld = false)
		{
			var pointer = StructConverter.ConvertToPointer(this, deleteOld);
			return pointer;
		}

		public static IntPtr CreatePointer()
        {
			return StructConverter.CreatePointer(typeof(ExtractionQuality));
        }
		public static ExtractionQuality FromPointer(IntPtr pointer)
		{
			return StructConverter.FromPointer<ExtractionQuality>(pointer);
		}

	}
}
