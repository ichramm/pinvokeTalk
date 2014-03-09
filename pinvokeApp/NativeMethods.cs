using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace pinvokeApp
{
	class NativeMethods
	{
		// Default: Should be ANSI
		[DllImport("pinvokeLib.dll"
			, CallingConvention = CallingConvention.Cdecl
			, EntryPoint = "GetStringLength"
		)]
		public static extern uint GetStringLength1(string s);

		// Unicode
		[DllImport("pinvokeLib.dll"
			, CallingConvention = CallingConvention.Cdecl
			, EntryPoint = "GetStringLength"
			, CharSet           = CharSet.Unicode
		)]
		public static extern uint GetStringLength2(string s);

		// Mixed
		[DllImport("pinvokeLib.dll"
			, CallingConvention = CallingConvention.Cdecl
			, CharSet           = CharSet.Unicode
			, EntryPoint        = "GetStringLengthA"
		)]
		public static extern uint GetStringLengthCrazy1(string s);

		[DllImport("pinvokeLib.dll"
			, CallingConvention = CallingConvention.Cdecl
			, EntryPoint = "GetStringLengthW"
		)]
		public static extern uint GetStringLengthCrazy2(string s);
	}
}
