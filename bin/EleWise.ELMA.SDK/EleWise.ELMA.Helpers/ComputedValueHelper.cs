using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class ComputedValueHelper
{
	internal static ComputedValueHelper rc5aodh51XSdHKcrMRba;

	public static void SetCalculateScriptMethodName(IComputedValue computedValue, Guid metadataUid)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				return;
			default:
				g6Kd7kh5tocCvBZVlIVb(computedValue, GIZjG3h5DsHYpvpRr4v1(Vv1C2Ah5aXhDCNVQrjT3(computedValue), metadataUid));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!uryTLFh5ps3MTGcNRrhd(computedValue))
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	internal static bool IsCalculateScript(IComputedValue computedValue)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (ikIGmMh5wsoahfR8jUjR(computedValue) == ComputedValueType.CalculateScript)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				if (computedValue != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return !wigf2Wh54P2et9Fpu8bg(Vv1C2Ah5aXhDCNVQrjT3(computedValue));
			}
			break;
		}
		return false;
	}

	internal static string GenerateMethodName(string calculateScript, Guid metadataUid)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return string.Empty;
			case 1:
			{
				ScriptMethodInfo scriptMethodInfo = new ScriptMethodInfo();
				HdlpGUh5AD7L9rkwKGgF(scriptMethodInfo, string.Format((string)F7Gi2Ih56OjvWOfIkNS5(-309639236 ^ -309794996), ((string)W4sk7nh5HoyvPk8PfOrk(calculateScript)).GetDeterministicGuid()));
				scriptMethodInfo.CodeType = CodeType.Client;
				scriptMethodInfo.MetadataUid = metadataUid;
				return ScriptMethodInfoHelper.Serialize(scriptMethodInfo);
			}
			case 2:
				if (!string.IsNullOrWhiteSpace(calculateScript))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static bool uryTLFh5ps3MTGcNRrhd(object P_0)
	{
		return IsCalculateScript((IComputedValue)P_0);
	}

	internal static object Vv1C2Ah5aXhDCNVQrjT3(object P_0)
	{
		return ((IComputedValue)P_0).CalculateScript;
	}

	internal static object GIZjG3h5DsHYpvpRr4v1(object P_0, Guid metadataUid)
	{
		return GenerateMethodName((string)P_0, metadataUid);
	}

	internal static void g6Kd7kh5tocCvBZVlIVb(object P_0, object P_1)
	{
		((IComputedValue)P_0).MethodName = (string)P_1;
	}

	internal static bool VyCjRJh5NGPX8W1wC9eW()
	{
		return rc5aodh51XSdHKcrMRba == null;
	}

	internal static ComputedValueHelper Onip07h53wjdX5Gg642X()
	{
		return rc5aodh51XSdHKcrMRba;
	}

	internal static ComputedValueType ikIGmMh5wsoahfR8jUjR(object P_0)
	{
		return ((IComputedValue)P_0).ComputedValueType;
	}

	internal static bool wigf2Wh54P2et9Fpu8bg(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object F7Gi2Ih56OjvWOfIkNS5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object W4sk7nh5HoyvPk8PfOrk(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void HdlpGUh5AD7L9rkwKGgF(object P_0, object P_1)
	{
		((ScriptMethodInfo)P_0).Name = (string)P_1;
	}
}
