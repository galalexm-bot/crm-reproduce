using EleWise.ELMA.Packaging;
using NuGet;

namespace EleWise.ELMA.Extensions;

internal static class IStoreComponentInfoExtensions
{
	internal static IStoreComponentInfoExtensions bdg8UKGpOYyyDl7QIufV;

	public static bool CanBeInstalledOrUpdated(this IStoreComponentInfo componentInfo)
	{
		//Discarded unreachable code: IL_0035, IL_0048, IL_0057
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!ydthX7Gp1UpSqNuEImsk(GIOjXCGpPP5vnmjRmndR(componentInfo), null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				if (vEYmo1Gp32pBkrcHeK1P(OljFVRGpNjLNqndWxXi4(componentInfo), null))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				return vfnrkiGppTa7KUq7CU7t(componentInfo.InstalledVersion, OljFVRGpNjLNqndWxXi4(componentInfo));
			case 4:
				return true;
			}
		}
	}

	internal static object GIOjXCGpPP5vnmjRmndR(object P_0)
	{
		return ((IStoreComponentInfo)P_0).InstalledVersion;
	}

	internal static bool ydthX7Gp1UpSqNuEImsk(object P_0, object P_1)
	{
		return (SemanticVersion)P_0 == (SemanticVersion)P_1;
	}

	internal static object OljFVRGpNjLNqndWxXi4(object P_0)
	{
		return ((IStoreComponentInfo)P_0).LastVersion;
	}

	internal static bool vEYmo1Gp32pBkrcHeK1P(object P_0, object P_1)
	{
		return (SemanticVersion)P_0 != (SemanticVersion)P_1;
	}

	internal static bool vfnrkiGppTa7KUq7CU7t(object P_0, object P_1)
	{
		return (SemanticVersion)P_0 < (SemanticVersion)P_1;
	}

	internal static bool gHtrrxGp2dlgetE31wbv()
	{
		return bdg8UKGpOYyyDl7QIufV == null;
	}

	internal static IStoreComponentInfoExtensions sdypNwGpeNBWOjrBPWKG()
	{
		return bdg8UKGpOYyyDl7QIufV;
	}
}
