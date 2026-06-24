using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization.DTO;

public class LocalizationLoader : DTOManager, ILocalizationLoader, IConfigurationService
{
	private static LocalizationLoader kHDkskGfHvtB6v0KbgLg;

	public virtual byte[] Execute(LocalizationLoadSettings settings)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0094, IL_0163, IL_0176, IL_0236, IL_0240, IL_02b4, IL_02c3, IL_03ed, IL_040c, IL_041b, IL_0448, IL_0457
		int num = 10;
		int num2 = num;
		IEnumerator<ILocalizationFileResolver> enumerator = default(IEnumerator<ILocalizationFileResolver>);
		Dictionary<string, List<PoLineDescriptor>> dictionary = default(Dictionary<string, List<PoLineDescriptor>>);
		Dictionary<string, List<PoLineDescriptor>>.Enumerator enumerator2 = default(Dictionary<string, List<PoLineDescriptor>>.Enumerator);
		KeyValuePair<string, List<PoLineDescriptor>> current2 = default(KeyValuePair<string, List<PoLineDescriptor>>);
		string text2 = default(string);
		string text = default(string);
		ILocalizationFileResolver current = default(ILocalizationFileResolver);
		List<PoLineDescriptor> list2 = default(List<PoLineDescriptor>);
		IEnumerable<PoLineDescriptor> collection = default(IEnumerable<PoLineDescriptor>);
		while (true)
		{
			switch (num2)
			{
			case 9:
				enumerator = ((ComponentManager)iGmbS9Gfx8RkWtVO66rc()).GetExtensionPoints<ILocalizationFileResolver>().GetEnumerator();
				num2 = 6;
				break;
			case 10:
				dictionary = new Dictionary<string, List<PoLineDescriptor>>();
				num2 = 9;
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_00c5:
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 3;
							goto IL_0098;
						}
						goto IL_00b2;
						IL_0098:
						while (true)
						{
							switch (num5)
							{
							case 1:
								goto IL_00c5;
							case 2:
							{
								LocalizationFile localizationFile = new LocalizationFile();
								NMRUQ8Gflj24CGEBxQl2(localizationFile, vpPeQYGfduXIORcngn8W(-1767720453 ^ -1767644253));
								sCcUIrGfrJ5n8boDRYxX(localizationFile, current2.Key);
								localizationFile.Resources = new ConcurrentBag<PoLineDescriptor>(current2.Value);
								localizationFile.SaveToFile(text2);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num5 = 1;
								}
								continue;
							}
							case 3:
								goto end_IL_00c5;
							}
							break;
						}
						goto IL_00b2;
						IL_00b2:
						current2 = enumerator2.Current;
						num5 = 2;
						goto IL_0098;
						continue;
						end_IL_00c5:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 5:
				text = (string)q6SKvWGfgygwlnrXZmj3(text2, vpPeQYGfduXIORcngn8W(0x61EC0CB8 ^ 0x61ED6FD8));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				text2 = (string)FHW2wxGfM8iIxQkUPd4o();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				enumerator2 = dictionary.GetEnumerator();
				num2 = 2;
				break;
			case 3:
				tXbGFgGf9DUea4W1msaR(text2);
				num2 = 7;
				break;
			case 4:
				return (byte[])VWydQkGfj0Njp0SyF0lP(text);
			case 8:
				if (!igj7QfGfJO1ndaBYnSHh(text2))
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 1:
				fwhQeFGf5dIG97clsx1V(Locator.GetServiceNotNull<IZipService>(), text, text2);
				num2 = 4;
				break;
			case 6:
				try
				{
					while (true)
					{
						IL_031c:
						int num3;
						if (!d8nTEQGfmSV8g7JTGf1V(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num3 = 0;
							}
							goto IL_0244;
						}
						goto IL_035c;
						IL_035c:
						current = enumerator.Current;
						num3 = 2;
						goto IL_0244;
						IL_0244:
						while (true)
						{
							List<PoLineDescriptor> list;
							switch (num3)
							{
							case 9:
								if (!dictionary.ContainsKey((string)GZRjwbGf0lvdCtHoRum2(current)))
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 6;
							case 5:
							case 8:
								list2 = new List<PoLineDescriptor>();
								num3 = 10;
								continue;
							case 10:
								dictionary.Add((string)GZRjwbGf0lvdCtHoRum2(current), list2);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								collection = current.CollectResources(settings);
								num3 = 9;
								continue;
							case 3:
								goto IL_031c;
							case 4:
								dictionary[(string)GZRjwbGf0lvdCtHoRum2(current)] = list2;
								num3 = 3;
								continue;
							case 12:
								goto IL_035c;
							case 1:
							case 11:
								list2.AddRange(collection);
								num3 = 4;
								continue;
							case 6:
								list = dictionary[current.FileName];
								if (list != null)
								{
									goto IL_03bb;
								}
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num3 = 7;
								}
								continue;
							case 7:
								list = new List<PoLineDescriptor>();
								goto IL_03bb;
							case 0:
								break;
								IL_03bb:
								list2 = list;
								num3 = 11;
								continue;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num4 = 2;
						}
						goto IL_03f1;
					}
					goto IL_0426;
					IL_0426:
					o1FhqqGfy0GTFeuyiTXN(enumerator);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num4 = 1;
					}
					goto IL_03f1;
					IL_03f1:
					switch (num4)
					{
					case 2:
						goto end_IL_03cc;
					case 1:
						goto end_IL_03cc;
					}
					goto IL_0426;
					end_IL_03cc:;
				}
				goto default;
			}
		}
	}

	public LocalizationLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object iGmbS9Gfx8RkWtVO66rc()
	{
		return ComponentManager.Current;
	}

	internal static object GZRjwbGf0lvdCtHoRum2(object P_0)
	{
		return ((ILocalizationFileResolver)P_0).FileName;
	}

	internal static bool d8nTEQGfmSV8g7JTGf1V(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void o1FhqqGfy0GTFeuyiTXN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object FHW2wxGfM8iIxQkUPd4o()
	{
		return IOExtensions.GetTempFileNameWithoutExtension();
	}

	internal static bool igj7QfGfJO1ndaBYnSHh(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object tXbGFgGf9DUea4W1msaR(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object vpPeQYGfduXIORcngn8W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void NMRUQ8Gflj24CGEBxQl2(object P_0, object P_1)
	{
		((LocalizationFile)P_0).LocalizationName = (string)P_1;
	}

	internal static void sCcUIrGfrJ5n8boDRYxX(object P_0, object P_1)
	{
		((LocalizationFile)P_0).Name = (string)P_1;
	}

	internal static object q6SKvWGfgygwlnrXZmj3(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object fwhQeFGf5dIG97clsx1V(object P_0, object P_1, object P_2)
	{
		return ((IZipService)P_0).CreateZipFolder((string)P_1, (string)P_2);
	}

	internal static object VWydQkGfj0Njp0SyF0lP(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static bool Sf1VSxGfAac4JH3VNNNx()
	{
		return kHDkskGfHvtB6v0KbgLg == null;
	}

	internal static LocalizationLoader TyhSM9Gf7QWT4VkhhS3A()
	{
		return kHDkskGfHvtB6v0KbgLg;
	}
}
