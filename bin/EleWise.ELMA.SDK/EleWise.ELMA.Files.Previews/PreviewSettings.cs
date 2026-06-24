using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

public class PreviewSettings : GlobalSettingsBase
{
	private List<CreatorInfo> _infos;

	private static PreviewSettings JFU79TGNGVNxNDpJ6iph;

	[HiddenInput(DisplayValue = false)]
	public List<CreatorInfo> Infos
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return string.Join((string)DdYZY9GNQmNtIBN71idG(0x6A81B9B4 ^ 0x6A81ED68), _infos.Select((CreatorInfo v) => ClassSerializationHelper.SerializeObjectByXml(v)));
				default:
					return string.Empty;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			string[] source = default(string[]);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (EkMQ8sGNCu7S9uSYGqrK(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						break;
					}
					source = (string[])a4yXkCGNvT0BB9Raswf4(value, new string[1] { (string)DdYZY9GNQmNtIBN71idG(-2138160520 ^ -2138171740) }, StringSplitOptions.RemoveEmptyEntries);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 2:
					return;
				default:
					_infos = new List<CreatorInfo>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					_infos = source.Select((string v) => ClassSerializationHelper.DeserializeObjectByXml<CreatorInfo>(v)).ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}
	}

	public PreviewSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_infos = new List<CreatorInfo>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void InitInfos()
	{
		int num = 1;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass7_.creators = ((ComponentManager)NO2RtPGN8Us7UhJwGobs()).GetExtensionPoints<IFilePreviewCreator>().ToList();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 3:
					Infos.RemoveAll(_003C_003Ec__DisplayClass7_._003CInitInfos_003Eb__1);
					num2 = 5;
					continue;
				case 5:
					return;
				default:
					_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass7_.creators.ForEach(_003C_003Ec__DisplayClass7_._003CInitInfos_003Eb__0);
			num = 3;
		}
	}

	internal static bool PUP4ZhGNEyK6tZ1wWRw8()
	{
		return JFU79TGNGVNxNDpJ6iph == null;
	}

	internal static PreviewSettings T1VymdGNfCeNvouIuIbl()
	{
		return JFU79TGNGVNxNDpJ6iph;
	}

	internal static object DdYZY9GNQmNtIBN71idG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool EkMQ8sGNCu7S9uSYGqrK(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object a4yXkCGNvT0BB9Raswf4(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object NO2RtPGN8Us7UhJwGobs()
	{
		return ComponentManager.Current;
	}
}
