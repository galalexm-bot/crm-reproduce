using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[Guid("728AB342-217D-11DA-B2A4-000E7BBB2B09")]
[TypeIdentifier]
[CompilerGenerated]
public interface IX509CertificateRequestPkcs10 : IX509CertificateRequest
{
	[DispId(1610809357)]
	CX500DistinguishedName Subject
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809357)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809357)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(1610809366)]
	CX509Extensions X509Extensions
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610809366)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743809)]
	void Encode();

	void _VtblGap2_24();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610809345)]
	void InitializeFromPrivateKey([In] X509CertificateEnrollmentContext Context, [In][MarshalAs(UnmanagedType.Interface)] CX509PrivateKey pPrivateKey, [In][MarshalAs(UnmanagedType.BStr)] string strTemplateName);

	void _VtblGap3_11();

	void _VtblGap4_7();
}
