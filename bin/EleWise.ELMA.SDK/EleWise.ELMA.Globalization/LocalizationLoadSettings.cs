using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class LocalizationLoadSettings
{
	public SerializableDictionary<Guid, object> CustomSettings;

	private static LocalizationLoadSettings b6CUdVGbERqgInDxCBYA;

	public string Folder
	{
		[CompilerGenerated]
		get
		{
			return _003CFolder_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CFolder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LocalizationLoadSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SnKMaaGbChrOjQEeX3HC();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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
				PrepareCustomSettings();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void PrepareCustomSettings()
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_008c, IL_00f3, IL_0102, IL_010d, IL_01af, IL_020b, IL_021e, IL_022d, IL_025e, IL_0296, IL_02a5
		int num = 3;
		int num2 = num;
		IEnumerator<ILocalizationLoadCustomSettings> enumerator = default(IEnumerator<ILocalizationLoadCustomSettings>);
		Dictionary<Guid, object>.Enumerator enumerator2 = default(Dictionary<Guid, object>.Enumerator);
		KeyValuePair<Guid, object> current = default(KeyValuePair<Guid, object>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				CustomSettings = new SerializableDictionary<Guid, object>();
				num2 = 2;
				continue;
			case 2:
				enumerator = ((ComponentManager)I1GeEvGbvki2RNqKE25t()).GetExtensionPoints<ILocalizationLoadCustomSettings>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!lGyfPZGb8CJn3JJpvHL4(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num3 = 0;
						}
						goto IL_0090;
					}
					goto IL_00aa;
					IL_00aa:
					enumerator2 = enumerator.Current.GetNewSettingObj().GetEnumerator();
					num3 = 3;
					goto IL_0090;
					IL_0090:
					switch (num3)
					{
					default:
						return;
					case 1:
						break;
					case 2:
						continue;
					case 3:
						try
						{
							while (true)
							{
								IL_01b9:
								int num4;
								if (!enumerator2.MoveNext())
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num4 = 2;
									}
									goto IL_0111;
								}
								goto IL_0164;
								IL_0164:
								current = enumerator2.Current;
								num4 = 5;
								goto IL_0111;
								IL_0111:
								while (true)
								{
									switch (num4)
									{
									case 5:
										if (CustomSettings.ContainsKey(current.Key))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto case 4;
									case 4:
										CustomSettings.Add(current.Key, current.Value);
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
										{
											num4 = 3;
										}
										continue;
									case 1:
									case 3:
										goto IL_01b9;
									case 2:
										goto end_IL_01b9;
									}
									break;
								}
								goto IL_0164;
								continue;
								end_IL_01b9:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
						continue;
					case 0:
						return;
					}
					goto IL_00aa;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							enumerator.Dispose();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num6 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	internal static void SnKMaaGbChrOjQEeX3HC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool U5DIKKGbfYJfh6wsv0Ff()
	{
		return b6CUdVGbERqgInDxCBYA == null;
	}

	internal static LocalizationLoadSettings aFVmw0GbQwHMe7odlK7t()
	{
		return b6CUdVGbERqgInDxCBYA;
	}

	internal static object I1GeEvGbvki2RNqKE25t()
	{
		return ComponentManager.Current;
	}

	internal static bool lGyfPZGb8CJn3JJpvHL4(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
