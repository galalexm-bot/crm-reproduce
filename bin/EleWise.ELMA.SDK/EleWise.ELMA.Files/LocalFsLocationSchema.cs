using System;
using System.IO;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

public class LocalFsLocationSchema : ILocationSchema
{
	private readonly string filesPath;

	private readonly string tempPath;

	private readonly string previewsPath;

	internal static LocalFsLocationSchema H2xdYeGXnsNJqb9nymyy;

	public LocalFsLocationSchema(string filesPath, string tempPath, string previewsPath)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.tempPath = tempPath;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				this.previewsPath = previewsPath;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.filesPath = filesPath;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Uri MapPersistentLocation(SystemFile systemFile)
	{
		return new Uri((string)I54lljGXpngwrjdBwrHw(filesPath, Pl8Ip2GX3Q6Xqr2AieK3(OATvYAGXeKYuIOFnGtm8(systemFile), lv2kO5GXNvv44J2ZbY94(T6fimhGX12DPvVQSaWpt(PtKxjEGXP9AMlKh5Eu3J(systemFile))))));
	}

	public Uri MapPreviewLocation(string uid, string contentPath)
	{
		throw new NotImplementedException();
	}

	public Uri MapTempLocation(string uid, string extension)
	{
		return new Uri(GetTempFileName(extension));
	}

	public Uri CreateNewTempLocation(string extension = null)
	{
		return new Uri(GetTempFileName(extension));
	}

	public Uri RemapTempLocationFor(Uri location)
	{
		throw new NotSupportedException((string)AP2Up3GXDv1S1E8Moj3L(nvmXncGXaKOWbifEqvww(-521266112 ^ -521289180)));
	}

	private string GetTempFileName(string extension)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_0118, IL_0127
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 2:
				if (bx00NjGXwu3vGt1Wagb3(tempPath))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 3;
			case 4:
				extension = (string)nvmXncGXaKOWbifEqvww(0x103FE975 ^ 0x103E8AA3);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				extension = (string)nvmXncGXaKOWbifEqvww(-1459557599 ^ -1459555867) + extension;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Directory.CreateDirectory(tempPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)I54lljGXpngwrjdBwrHw(tempPath, UTTKsBGX4VCv1DJ5Tti1(Guid.NewGuid().ToString((string)nvmXncGXaKOWbifEqvww(-289714582 ^ -289688542)), extension));
			case 5:
				if (string.IsNullOrEmpty(extension))
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 7:
				if (!uCj8G3GXtj8V86aydYjl(extension, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123638598)))
				{
					num2 = 6;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static bool TK71sYGXOv6bj8K1aS9C()
	{
		return H2xdYeGXnsNJqb9nymyy == null;
	}

	internal static LocalFsLocationSchema g9b5SQGX2yCfUutCgoZp()
	{
		return H2xdYeGXnsNJqb9nymyy;
	}

	internal static int OATvYAGXeKYuIOFnGtm8(object P_0)
	{
		return ((SystemFile)P_0).Id;
	}

	internal static object PtKxjEGXP9AMlKh5Eu3J(object P_0)
	{
		return ((SystemFile)P_0).Name;
	}

	internal static object T6fimhGX12DPvVQSaWpt(object P_0)
	{
		return ((string)P_0).ReplaceInvalidFileNameChars();
	}

	internal static object lv2kO5GXNvv44J2ZbY94(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object Pl8Ip2GX3Q6Xqr2AieK3(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object I54lljGXpngwrjdBwrHw(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object nvmXncGXaKOWbifEqvww(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AP2Up3GXDv1S1E8Moj3L(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool uCj8G3GXtj8V86aydYjl(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool bx00NjGXwu3vGt1Wagb3(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object UTTKsBGX4VCv1DJ5Tti1(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
