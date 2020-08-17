using EmotionRecognition.Import;
using System;
using System.Runtime.InteropServices;

namespace EmotionRecognition.Wrapper
{
    public class Voice
    {
        private IntPtr voicePointer;

        public Voice(int sampleRate, int numberOfSamples)
        {
            voicePointer = VokaturiDDLImport.VokaturiVoice_create(Convert.ToDouble(sampleRate), numberOfSamples);
        }

        public void SetRelativePriorProbabilities(EmotionsProbabilities lastEmotionProbabilities)
        {
            VokaturiDDLImport.VokaturiVoice_setRelativePriorProbabilities(voicePointer, lastEmotionProbabilities.ToPointer());
        }

        public void Fill(short sample)
        {
            VokaturiDDLImport.VokaturiVoice_fill_int16value(voicePointer, sample);
        }

        public void Fill(int sample)
        {
            VokaturiDDLImport.VokaturiVoice_fill_int32value(voicePointer, sample);
        }

        public void Fill(float sample)
        {
            VokaturiDDLImport.VokaturiVoice_fill_float32value(voicePointer, sample);
        }
        public void Fill(double sample)
        {
            VokaturiDDLImport.VokaturiVoice_fill_float64value(voicePointer, sample);
        }

        public void Fill(short[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fill_int16array(voicePointer, samples.Length, samples);
        }

        public void Fill(int[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fill_int32array(voicePointer, samples.Length, samples);
        }

        public void Fill(float[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fill_float32array(voicePointer, samples.Length, samples);
        }

        public void Fill(double[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fill_float64array(voicePointer, samples.Length, samples);
        }




        public static void FillInterlacedStereo(Voice left, Voice right, int numberOfSamplesPerChannel, double[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fillInterlacedStereo_float64array(left.voicePointer, right.voicePointer, numberOfSamplesPerChannel, samples);
        }
        public static void FillInterlacedStereo(Voice left, Voice right, int numberOfSamplesPerChannel, float[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fillInterlacedStereo_float32array(left.voicePointer, right.voicePointer, numberOfSamplesPerChannel, samples);
        }
        public static void FillInterlacedStereo(Voice left, Voice right, int numberOfSamplesPerChannel, int[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fillInterlacedStereo_int32array(left.voicePointer, right.voicePointer, numberOfSamplesPerChannel, samples);
        }

        public static void FillInterlacedStereo(Voice left, Voice right, int numberOfSamplesPerChannel, short[] samples)
        {
            VokaturiDDLImport.VokaturiVoice_fillInterlacedStereo_int16array(left.voicePointer, right.voicePointer, numberOfSamplesPerChannel, samples);
        }

        public VoiceFeatureExtractionResult Extract()
        {
            return VoiceFeatureExtractor.Extract(voicePointer);
        }

        public void Reset()
        {
            VokaturiDDLImport.VokaturiVoice_reset(voicePointer);
        }

        ~Voice()
        {
            VokaturiDDLImport.VokaturiVoice_destroy(voicePointer);
        }
    }
}
