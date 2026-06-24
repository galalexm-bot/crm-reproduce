using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CERTENROLLLib;

[ComImport]
[CompilerGenerated]
[Guid("728AB30C-217D-11DA-B2A4-000E7BBB2B09")]
[TypeIdentifier]
public interface IX509PrivateKey
{
	[DispId(1610743828)]
	X509ProviderType ProviderType
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743828)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743828)]
		[param: In]
		set;
	}

	[DispId(1610743834)]
	X509KeySpec KeySpec
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743834)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743834)]
		[param: In]
		set;
	}

	void _VtblGap1_20();

	void _VtblGap2_4();
}
