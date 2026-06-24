using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTADMINLib;

[ComImport]
[TypeIdentifier]
[Guid("9C735BE2-57A5-11D1-9BDB-00C04FB683FA")]
[CompilerGenerated]
public interface IEnumCERTVIEWCOLUMN
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	int Next();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743809)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetName();

	void _VtblGap1_4();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743814)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetValue([In] int Flags);
}
