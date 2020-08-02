using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_emotion_recognition.Import
{
    static class StructConverter
    {

        public static IntPtr ConvertToPointer(object structure, bool deleteObject = false)
        {
            // Initialize unmanged memory to hold the struct.
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf(structure));

            // Copy the struct to unmanaged memory.
            Marshal.StructureToPtr(structure, pointer, deleteObject);

            return pointer;
        }

        public static IntPtr CreatePointer(Type type)
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf(type));
            return pointer;
        }

        public static T FromPointer<T>(IntPtr pointer)
        {
            return (T)Marshal.PtrToStructure(pointer, typeof(T));
        }
    }

}
