using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[Guid("728AB30F-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
[TypeIdentifier]
public interface IX509ExtensionKeyUsage : IX509Extension
{
	void _VtblGap1_5();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610809344)]
	void InitializeEncode([In] X509KeyUsageFlags UsageFlags);
}
