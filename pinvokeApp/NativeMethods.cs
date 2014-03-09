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
		[DllImport("pinvokeLib.dll"
			//, CallingConvention = CallingConvention.Cdecl
		)]
		public static extern uint GetStringLength(string s);
	}
}
