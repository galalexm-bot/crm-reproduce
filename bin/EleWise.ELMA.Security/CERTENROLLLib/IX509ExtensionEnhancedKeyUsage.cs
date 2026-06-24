using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[TypeIdentifier]
[Guid("728AB310-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
public interface IX509ExtensionEnhancedKeyUsage : IX509Extension
{
	void _VtblGap1_5();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610809344)]
	void InitializeEncode([In][MarshalAs(UnmanagedType.Interface)] CObjectIds pValue);
}
