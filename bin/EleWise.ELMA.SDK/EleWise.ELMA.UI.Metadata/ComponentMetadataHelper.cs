using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

public static class ComponentMetadataHelper
{
	private static ComponentMetadataHelper ji301KBbD4gw8vmtCKYp;

	public static string ClientAssemblyName(ComponentMetadata metadata, string version = null)
	{
		return (string)eG9AN4BbAaXOt4Au4Hh4(EaVTeOBbHV8R9GV0g903(VObwLjBb4qLfSgdo6wmC(0x3A5D5EF ^ 0x3A53F4D), ClJ2IsBb6iHUJM7OGNAF(metadata), VObwLjBb4qLfSgdo6wmC(-1852837372 ^ -1852834178), version ?? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751138000)), '.', '_');
	}

	public static string ServerAssemblyName(ComponentMetadata metadata)
	{
		return (string)VObwLjBb4qLfSgdo6wmC(--1418440330 ^ 0x548B4428) + (string)ClJ2IsBb6iHUJM7OGNAF(metadata);
	}

	internal static object VObwLjBb4qLfSgdo6wmC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ClJ2IsBb6iHUJM7OGNAF(object P_0)
	{
		return ((ComponentMetadata)P_0).FullTypeName;
	}

	internal static object EaVTeOBbHV8R9GV0g903(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object eG9AN4BbAaXOt4Au4Hh4(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static bool zNvun1BbtBLsjUlYc8AX()
	{
		return ji301KBbD4gw8vmtCKYp == null;
	}

	internal static ComponentMetadataHelper UURMo9Bbw8COXdUOMKlh()
	{
		return ji301KBbD4gw8vmtCKYp;
	}
}
