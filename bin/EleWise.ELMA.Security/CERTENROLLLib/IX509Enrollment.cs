using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[Guid("728AB346-217D-11DA-B2A4-000E7BBB2B09")]
[TypeIdentifier]
[CompilerGenerated]
public interface IX509Enrollment
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	void Initialize([In] X509CertificateEnrollmentContext Context);

	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743810)]
	void InitializeFromRequest([In][MarshalAs(UnmanagedType.Interface)] IX509CertificateRequest pRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743811)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string CreateRequest([In] EncodingType Encoding = EncodingType.XCN_CRYPT_STRING_BASE64);

	void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	void InstallResponse([In] InstallResponseRestrictionFlags Restrictions, [In][MarshalAs(UnmanagedType.BStr)] string strResponse, [In] EncodingType Encoding, [In][MarshalAs(UnmanagedType.BStr)] string strPassword);
}
