using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("728AB30E-217D-11DA-B2A4-000E7BBB2B09")]
[DefaultMember("ItemByIndex")]
public interface IX509Extensions : IEnumerable
{
	void _VtblGap1_3();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	void Add([In][MarshalAs(UnmanagedType.Interface)] CX509Extension pVal);
}
