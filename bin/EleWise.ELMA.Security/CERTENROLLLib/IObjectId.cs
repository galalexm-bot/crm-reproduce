using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[CompilerGenerated]
[Guid("728AB300-217D-11DA-B2A4-000E7BBB2B09")]
[TypeIdentifier]
public interface IObjectId
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	void InitializeFromName([In] CERTENROLL_OBJECTID Name);
}
