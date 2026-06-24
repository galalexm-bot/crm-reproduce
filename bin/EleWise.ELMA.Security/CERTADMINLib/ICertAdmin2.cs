using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTADMINLib;

[ComImport]
[TypeIdentifier]
[Guid("F7C3AC41-B8CE-4FB4-AA58-3D1DC0E36B39")]
[CompilerGenerated]
public interface ICertAdmin2 : ICertAdmin
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	int IsValidCertificate([In][MarshalAs(UnmanagedType.BStr)] string strConfig, [In][MarshalAs(UnmanagedType.BStr)] string strSerialNumber);
}
