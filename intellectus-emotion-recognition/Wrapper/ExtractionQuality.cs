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

		internal ExtractionQuality(int paramValid, int numFrames, int numFramesLost)
        {
			valid = paramValid;
			num_frames_analyzed = numFrames;
			num_frames_lost = numFramesLost;
        }

		internal void Add(ExtractionQuality other)
        {
			valid = (valid * other.valid);
			num_frames_analyzed += other.num_frames_analyzed;
			num_frames_lost += other.num_frames_lost;
        }

		internal void Divide(int number)
		{
			num_frames_analyzed = num_frames_analyzed / number;
			num_frames_lost = num_frames_lost / number;
		}

		internal IntPtr ToPointer(bool deleteOld = false)
		{
			var pointer = StructConverter.ConvertToPointer(this, deleteOld);
			return pointer;
		}

		internal static IntPtr CreatePointer()
        {
			return StructConverter.CreatePointer(typeof(ExtractionQuality));
        }
		internal static ExtractionQuality FromPointer(IntPtr pointer)
		{
			return StructConverter.FromPointer<ExtractionQuality>(pointer);
		}

	}
}
