using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTADMINLib;

[ComImport]
[TypeIdentifier]
[Guid("D594B282-8851-4B61-9C66-3EDADF848863")]
[CompilerGenerated]
public interface ICertView2 : ICertView
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743808)]
	void OpenConnection([In][MarshalAs(UnmanagedType.BStr)] string strConfig);

	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743810)]
	int GetColumnCount([In] int fResultColumn);

	void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743812)]
	void SetResultColumnCount([In] int cResultColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	void SetResultColumn([In] int ColumnIndex);

	void _VtblGap3_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743815)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumCERTVIEWROW OpenView();
}
