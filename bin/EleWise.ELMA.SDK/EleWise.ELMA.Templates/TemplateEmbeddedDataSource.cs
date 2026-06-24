using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates;

[Component]
public abstract class TemplateEmbeddedDataSource : ITemplateDataSource
{
	private static List<string> templateExtList;

	internal static TemplateEmbeddedDataSource ThyjesB1SHrDXghsPfIj;

	protected virtual string Namespace => uhUlLXB1K7WqRw4eBDeh(this).Namespace;

	private bool IsTemplate(string fileName)
	{
		//Discarded unreachable code: IL_0059, IL_0063, IL_0092, IL_00a1, IL_00b0, IL_0154, IL_0167, IL_0176
		int num = 2;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		bool result = default(bool);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 2:
				enumerator = templateExtList.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0112:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0067;
						}
						goto IL_00ff;
						IL_0067:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return result;
							default:
								result = true;
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								if (!Gfa1LcB1qmKuYo9yHR6i(fileName, current))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto default;
							case 2:
								break;
							case 1:
							case 4:
								goto IL_0112;
							case 3:
								goto end_IL_0112;
							}
							break;
						}
						goto IL_00ff;
						IL_00ff:
						current = enumerator.Current;
						num3 = 5;
						goto IL_0067;
						continue;
						end_IL_0112:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			}
		}
	}

	public IEnumerable<TemplateFileInfo> GetFiles()
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.ns = Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FFD19D);
		Assembly assembly = GetType().Assembly;
		IEnumerable<string> enumerable = assembly.GetManifestResourceNames().Where(delegate(string n)
		{
			//Discarded unreachable code: IL_0067, IL_0076
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return CS_0024_003C_003E8__locals0._003C_003E4__this.IsTemplate(n);
				case 1:
					return false;
				case 2:
					if (!_003C_003Ec__DisplayClass2_0.MENt0JQq56DMLWylvApo(n, CS_0024_003C_003E8__locals0.ns))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		});
		List<TemplateFileInfo> list = new List<TemplateFileInfo>();
		foreach (string item3 in enumerable)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item3.Substring(CS_0024_003C_003E8__locals0.ns.Length));
			string extension = Path.GetExtension(item3.Substring(CS_0024_003C_003E8__locals0.ns.Length));
			TemplateFileInfo item = new TemplateFileInfo
			{
				Assembly = assembly,
				FullName = item3,
				Name = fileNameWithoutExtension,
				Extension = extension
			};
			list.Add(item);
		}
		foreach (CultureInfo cultureName in SR.GetCultureNames())
		{
			if (cultureName.Name.Equals(SR.KeyCultureInfo.Name, StringComparison.OrdinalIgnoreCase))
			{
				continue;
			}
			string path = Path.Combine(SR.GetCultureDir(cultureName), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710575994));
			if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path);
				foreach (string text in files)
				{
					string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(text);
					string extension2 = Path.GetExtension(text);
					TemplateFileInfo item2 = new TemplateFileInfo
					{
						Name = fileNameWithoutExtension2,
						Extension = extension2,
						FullPath = text,
						CultureName = cultureName.Name
					};
					list.Add(item2);
				}
			}
		}
		return list;
	}

	protected TemplateEmbeddedDataSource()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dxU6CWB1Xt1IvGZADPA7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TemplateEmbeddedDataSource()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				templateExtList = new List<string>
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA40098),
					(string)deAKdfB1TpYnuHYFLCdb(0x3A6135BE ^ 0x3A60750E),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710493580),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459508245),
					(string)deAKdfB1TpYnuHYFLCdb(-1459557599 ^ -1459508231),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FBC5C)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool Gfa1LcB1qmKuYo9yHR6i(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static bool UJInvXB1imEIbknyuCOg()
	{
		return ThyjesB1SHrDXghsPfIj == null;
	}

	internal static TemplateEmbeddedDataSource xlly6HB1RLgxi19cjDrD()
	{
		return ThyjesB1SHrDXghsPfIj;
	}

	internal static Type uhUlLXB1K7WqRw4eBDeh(object P_0)
	{
		return P_0.GetType();
	}

	internal static void dxU6CWB1Xt1IvGZADPA7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object deAKdfB1TpYnuHYFLCdb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
