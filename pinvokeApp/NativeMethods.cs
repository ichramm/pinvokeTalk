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
		[DllImport("pinvokeLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr NativeClass_New(string s);

		[DllImport("pinvokeLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NativeClass_Delete(IntPtr hInstance);

		[DllImport("pinvokeLib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool NativeClass_GetName(
			IntPtr hInstance,
			StringBuilder buffer,
			[MarshalAs(UnmanagedType.U4)] int bufferSize
		);
	}

	class MyNativeClass : IDisposable
	{
		IntPtr nativeInstance;

		public MyNativeClass(string name)
		{
			nativeInstance = NativeMethods.NativeClass_New(name);
		}

		public string Name
		{
			get
			{
				StringBuilder b = new StringBuilder(10);
				while (!NativeMethods.NativeClass_GetName(nativeInstance, b, b.Capacity))
				{
					b.Capacity *= 2;
				}

				return b.ToString();
			}
		}

		~MyNativeClass()
		{
			if (nativeInstance != IntPtr.Zero)
			{
				NativeMethods.NativeClass_Delete(nativeInstance);
				nativeInstance = IntPtr.Zero;
			}
		}

		public void Dispose()
		{
			NativeMethods.NativeClass_Delete(nativeInstance);
			nativeInstance = IntPtr.Zero;
		}
	}
}
