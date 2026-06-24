using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

public class CryptoProviderSettingsBase : GlobalSettingsBase
{
	private List<CertificationAuthorityInfo> _infos;

	private static CryptoProviderSettingsBase fJFHO8f0eApolAcq6pT;

	[IgnoreDataMember]
	public List<CertificationAuthorityInfo> Infos
	{
		get
		{
			return _infos;
		}
		set
		{
			_infos = value;
		}
	}

	[DisplayName(typeof(CryptoProviderSettingsBase_SR), "CheckAlgorithm")]
	public bool CheckAlgorithm
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckAlgorithm_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CCheckAlgorithm_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName(typeof(CryptoProviderSettingsBase_SR), "SerializedInfos")]
	public string SerializedInfos
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_infos == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
						{
							num2 = 0;
						}
						break;
					}
					return (string)iWuqhlfsZIp5btD3kZg(_infos);
				default:
					return string.Empty;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_004e, IL_005d
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						_infos = new List<CertificationAuthorityInfo>();
						num = 2;
						break;
					case 2:
						return;
					case 3:
						_infos = ClassSerializationHelper.DeserializeObjectByJson<List<CertificationAuthorityInfo>>(value);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						return;
					case 4:
						if (!iWPQNCfYMWHk1Yhgshb(value))
						{
							num = 3;
							break;
						}
						goto default;
					}
					break;
				}
			}
		}
	}

	public CryptoProviderSettingsBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LbcQevfMxYtBnx4Ge9J();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			_infos = new List<CertificationAuthorityInfo>();
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
			{
				num = 1;
			}
		}
	}

	internal static void LbcQevfMxYtBnx4Ge9J()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool CeAVnPfEyetu5iZXMq9()
	{
		return fJFHO8f0eApolAcq6pT == null;
	}

	internal static CryptoProviderSettingsBase vmQPuqfDQeTbX3aZ4TW()
	{
		return fJFHO8f0eApolAcq6pT;
	}

	internal static object iWuqhlfsZIp5btD3kZg(object P_0)
	{
		return ClassSerializationHelper.SerializeObjectByJson(P_0);
	}

	internal static bool iWPQNCfYMWHk1Yhgshb(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
