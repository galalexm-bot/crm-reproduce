using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[CompilerGenerated]
[DefaultMember("ItemByIndex")]
[Guid("728AB301-217D-11DA-B2A4-000E7BBB2B09")]
[TypeIdentifier]
public interface IObjectIds : IEnumerable
{
	void _VtblGap1_3();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	void Add([In][MarshalAs(UnmanagedType.Interface)] CObjectId pVal);
}
