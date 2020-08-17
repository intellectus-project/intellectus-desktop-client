using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmotionRecognition.Import
{
    public class VokaturiDDLImport
    {
        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern IntPtr VokaturiVoice_create(double sampleRate, int bufferLength);

        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif        
        public static extern void VokaturiVoice_setRelativePriorProbabilities(IntPtr voice, IntPtr lastEmotionProbabilities);


        #region Fill Methods

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_float64array(IntPtr voice, int num_samples, double[] samples);

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_float32array(IntPtr voice, int num_samples, float[] samples);

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_int32array(IntPtr voice, int num_samples, int[] samples);

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_int16array(IntPtr voice, int num_samples, short[] samples);
        
            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_float64value(IntPtr voice, double sample);

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_float32value(IntPtr voice, float sample);

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_int32value(IntPtr voice, int sample);

            #if EXECWIN64
                [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
            #else
                [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
            #endif
            public static extern void VokaturiVoice_fill_int16value(IntPtr voice, int sample);

        #endregion


        #region Stereo Fill Methods

        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern void VokaturiVoice_fillInterlacedStereo_float64array(IntPtr left, IntPtr right, int num_samples_per_channel, double[] samples);

        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern void VokaturiVoice_fillInterlacedStereo_float32array(IntPtr left, IntPtr right, int num_samples_per_channel, float[] samples);

        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern void VokaturiVoice_fillInterlacedStereo_int32array(IntPtr left, IntPtr right, int num_samples_per_channel, int[] samples);
        
        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif   
        public static extern void VokaturiVoice_fillInterlacedStereo_int16array(IntPtr left, IntPtr right, int num_samples_per_channel, short[] samples);

        #endregion


        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern void VokaturiVoice_extract(IntPtr voice, IntPtr quality, IntPtr emotionProbabilities);
        

        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern void VokaturiVoice_destroy(IntPtr voice);


        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern void VokaturiVoice_reset(IntPtr voice);


        #if EXECWIN64
            [DllImport("OpenVokaturi-3-4-win64.dll", CallingConvention = CallingConvention.Cdecl)]
        #else
            [DllImport("OpenVokaturi-3-4-win32.dll", CallingConvention = CallingConvention.Cdecl)]
        #endif
        public static extern IntPtr Vokaturi_versionAndLicense();

    }
}
