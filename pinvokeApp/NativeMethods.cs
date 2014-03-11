using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace pinvokeApp
{
	[StructLayout(LayoutKind.Sequential)]
	struct NativeStruct
	{
		public int    integer;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string name;
	}

	unsafe class NativeMethods
	{
		[DllImport("pinvokeLib.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool NativeStruct_Serialize1(
			ref NativeStruct hInstance,
			StringBuilder buffer,
			[MarshalAs(UnmanagedType.U4)]
			int bufferSize
		);

		[DllImport("pinvokeLib.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern bool NativeStruct_Serialize2(
			[MarshalAs(UnmanagedType.Struct)] NativeStruct instance,
			StringBuilder buffer,
			[MarshalAs(UnmanagedType.U4)] int bufferSize
		);

		public static string Serialize(NativeStruct nativeStruct, int function)
		{
			StringBuilder sb = new StringBuilder(256);

			switch (function)
			{
				case 1:
					NativeStruct copy = new NativeStruct();
					copy.integer = nativeStruct.integer;
					copy.name = nativeStruct.name;

					NativeMethods.NativeStruct_Serialize1(ref copy, sb, sb.Capacity);
					sb.Append("\r\nNew Int: " + copy.integer);
					break;
				case 2:
					NativeMethods.NativeStruct_Serialize2(nativeStruct, sb, sb.Capacity);
					sb.Append("\r\nNew Int: " + nativeStruct.integer);
					break;
			}

			return sb.ToString();
		}
	}

}
