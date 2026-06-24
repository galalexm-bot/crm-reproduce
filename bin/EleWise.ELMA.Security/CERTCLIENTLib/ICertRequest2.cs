using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTCLIENTLib;

[ComImport]
[CompilerGenerated]
[Guid("A4772988-4A85-4FA9-824E-B5CF5C16405A")]
[TypeIdentifier]
public interface ICertRequest2 : ICertRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	int Submit([In] int Flags, [In][MarshalAs(UnmanagedType.BStr)] string strRequest, [In][MarshalAs(UnmanagedType.BStr)] string strAttributes, [In][MarshalAs(UnmanagedType.BStr)] string strConfig);

	void _VtblGap1_4();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetCACertificate([In] int fExchangeCertificate, [In][MarshalAs(UnmanagedType.BStr)] string strConfig, [In] int Flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743814)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetCertificate([In] int Flags);
}
