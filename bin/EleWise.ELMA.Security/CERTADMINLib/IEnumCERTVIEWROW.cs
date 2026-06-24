using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTADMINLib;

[ComImport]
[TypeIdentifier]
[Guid("D1157F4C-5AF2-11D1-9BDC-00C04FB683FA")]
[CompilerGenerated]
public interface IEnumCERTVIEWROW
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	int Next();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumCERTVIEWCOLUMN EnumCertViewColumn();

	void _VtblGap1_3();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	void Reset();
}
