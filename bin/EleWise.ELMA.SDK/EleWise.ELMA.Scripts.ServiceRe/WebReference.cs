using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Xml.Schema;
using System.Xml.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Tools.ServiceModel.SvcUtil;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts.ServiceReference;

public class WebReference
{
	private List<ScriptProjectItem> items;

	private string url;

	private string relativePath;

	private DiscoveryClientProtocol protocol;

	private string webReferencesDirectory;

	private string proxyNamespace;

	private string name;

	private string projectDirPath;

	private MetadataSet metadata;

	private static WebReference TK6Q9tBz91jKJcMu74O8;

	public string WebReferencesDirectory => webReferencesDirectory;

	public string Directory => Path.Combine(projectDirPath, relativePath);

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnNameChanged();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	public string ProxyNamespace
	{
		get
		{
			return proxyNamespace;
		}
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
					proxyNamespace = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
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

	public List<ScriptProjectItem> Items
	{
		get
		{
			if (items == null)
			{
				items = CreateProjectItems();
			}
			return items;
		}
	}

	public string WebProxyFileName => GetFullProxyFileName();

	public DiscoveryClientProtocol Protocol => protocol;

	public string Url => url;

	public WebReference(string url, string name, string proxyNamespace, DiscoveryClientProtocol protocol, string projectDirPath, MetadataSet metadata)
	{
		//Discarded unreachable code: IL_008a
		SingletonReader.JJCZtPuTvSt();
		this.url = string.Empty;
		relativePath = string.Empty;
		webReferencesDirectory = string.Empty;
		this.proxyNamespace = string.Empty;
		this.name = string.Empty;
		this.projectDirPath = string.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
				this.proxyNamespace = proxyNamespace;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.name = name;
				num = 3;
				break;
			case 5:
				this.metadata = metadata;
				num = 7;
				break;
			case 4:
				return;
			default:
				this.url = url;
				num = 6;
				break;
			case 3:
				GetRelativePath();
				num2 = 4;
				goto IL_008f;
			case 6:
				this.projectDirPath = projectDirPath;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num = 5;
				}
				break;
			case 7:
				{
					this.protocol = protocol;
					num2 = 2;
					goto IL_008f;
				}
				IL_008f:
				num = num2;
				break;
			}
		}
	}

	public static bool IsValidNamespace(string ns)
	{
		//Discarded unreachable code: IL_004e, IL_00a1, IL_00b8, IL_00c7
		int num = 1;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					OP9OohBzr4gIMu3Vuk5E(new CodeNamespace(ns));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = true;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				catch (ArgumentException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 1:
				if (ns.Length > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		return false;
	}

	public static bool IsValidReferenceName(string name)
	{
		//Discarded unreachable code: IL_0035
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (K7JCnoBzgUI7jDx5ZFXR(name) > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					if (ContainsInvalidDirectoryChar(name))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 4;
				case 4:
					return true;
				case 2:
					break;
				default:
					if (RK35xjBz5ayFQnW0gkoO(name, '\\') != -1)
					{
						break;
					}
					goto end_IL_0012;
				}
				return false;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static string GetReferenceName(string webReferenceFolder, string name)
	{
		//Discarded unreachable code: IL_0049, IL_010f
		int num = 7;
		int num3 = default(int);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					num3 = 1;
					num2 = 6;
					continue;
				case 6:
					text2 = name;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
				case 9:
					text2 = (string)KqUWBrBzY6N7MdrFsIu4(name, num3.ToString());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return text2;
				case 4:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 8:
					text = (string)WXRCgsBzjv4uTT95Ellg(webReferenceFolder, name);
					num2 = 3;
					continue;
				default:
					if (WhOwGLBzLcUO13mhXRxV(text))
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				}
				break;
			}
			text = (string)WXRCgsBzjv4uTT95Ellg(webReferenceFolder, text2);
			num = 4;
		}
	}

	public void Save()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				CheckDocumentsNames();
				num2 = 3;
				break;
			case 1:
				System.IO.Directory.CreateDirectory(Directory);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				zWv9VuBzsQUVf8413FJ2(protocol, Directory, qm7fbjBzUtxaUbQ7Db7n(-234299632 ^ -234267174));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				GenerateWebProxy();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			}
		}
	}

	internal void Save(bool useSvcUtil)
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				CheckDocumentsNames();
				num2 = 2;
				break;
			case 6:
				return;
			case 5:
				System.IO.Directory.CreateDirectory(Directory);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				return;
			case 2:
				if (!useSvcUtil)
				{
					GenerateWebProxy();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 3;
					}
				}
				break;
			case 1:
				RunSvcUtil();
				num2 = 6;
				break;
			case 3:
				zWv9VuBzsQUVf8413FJ2(protocol, Directory, qm7fbjBzUtxaUbQ7Db7n(-1978478350 ^ -1978445256));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 1;
				}
				break;
			default:
				zWv9VuBzsQUVf8413FJ2(protocol, Directory, qm7fbjBzUtxaUbQ7Db7n(0x7E6E5A0B ^ 0x7E6FD8C1));
				num2 = 7;
				break;
			}
		}
	}

	public string GetFullProxyFileName()
	{
		return (string)WXRCgsBzjv4uTT95Ellg(projectDirPath, GetProxyFileName());
	}

	private void CheckDocumentsNames()
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_0050, IL_015d, IL_0180, IL_018f, IL_01cd
		int num = 2;
		IEnumerator enumerator = default(IEnumerator);
		NamedItem namedItem = default(NamedItem);
		Regex regex = default(Regex);
		string str = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!gnJE1oWFGBUpTUSAyVpe(enumerator))
							{
								num3 = 3;
								goto IL_0054;
							}
							goto IL_010d;
							IL_0054:
							while (true)
							{
								switch (num3)
								{
								case 5:
									if (!XNoa7UWFolZ9IirPkw93(Vpx2w4WFWh5i06FoCY8E(namedItem)))
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
										{
											num3 = 1;
										}
										continue;
									}
									break;
								case 1:
									fixcwBWFhqaD5RivFbIb(namedItem, vbVl8NWFbgCfkeEdfKJj(regex, Vpx2w4WFWh5i06FoCY8E(namedItem), qm7fbjBzUtxaUbQ7Db7n(-561074844 ^ -561077986)));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									if (namedItem != null)
									{
										num3 = 5;
										continue;
									}
									break;
								case 4:
									goto IL_010d;
								case 3:
									return;
								}
								break;
							}
							continue;
							IL_010d:
							namedItem = RaM337WFBkKQYA3ibetf(enumerator) as NamedItem;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 2;
							}
							goto IL_0054;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 0:
								break;
							case 2:
								disposable.Dispose();
								num4 = 3;
								continue;
							case 1:
								if (disposable == null)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 2;
							case 3:
								break;
							}
							break;
						}
					}
				case 1:
					break;
				case 3:
					enumerator = (IEnumerator)IBNxlAWFFSKWwENKL7Ia(clRitvBzzu6Cveq96dIR(bJvaoTBzc8aUtBbaaUsV(protocol)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				case 2:
					str = new string(Path.GetInvalidFileNameChars());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			regex = new Regex(string.Format((string)qm7fbjBzUtxaUbQ7Db7n(0x1A33FE36 ^ 0x1A3324B4), Regex.Escape(str)));
			num = 3;
		}
	}

	private void RunSvcUtil()
	{
		//Discarded unreachable code: IL_01dc, IL_01e6, IL_01f5, IL_022c, IL_023b, IL_0246, IL_0318, IL_032b, IL_03d0, IL_0579
		int num = 3;
		int num2 = num;
		List<string> list = default(List<string>);
		List<string> list2 = default(List<string>);
		string text = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		string text2 = default(string);
		string contents = default(string);
		string text3 = default(string);
		string text4 = default(string);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 6:
				if (!XNoa7UWFolZ9IirPkw93(SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F31FB00))))
				{
					num2 = 20;
					continue;
				}
				goto case 17;
			case 17:
				if (kALaXQWFv2qy240XHn8B(list) > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 18;
			case 11:
				list2 = new List<string>
				{
					(string)qm7fbjBzUtxaUbQ7Db7n(-583745292 ^ -583711804),
					(string)KqUWBrBzY6N7MdrFsIu4(qm7fbjBzUtxaUbQ7Db7n(0x7C1EE318 ^ 0x7C1F605A), Directory),
					(string)QIrjpqWFQTrMancgpWgx(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638501027), Directory, qm7fbjBzUtxaUbQ7Db7n(0x12441CA4 ^ 0x12459FF2)),
					(string)KqUWBrBzY6N7MdrFsIu4(qm7fbjBzUtxaUbQ7Db7n(-1921202237 ^ -1921170249), proxyNamespace),
					(string)qm7fbjBzUtxaUbQ7Db7n(0x7E6E5A0B ^ 0x7E6FD989),
					(string)qm7fbjBzUtxaUbQ7Db7n(0x3C5338FF ^ 0x3C52BB75),
					(string)qm7fbjBzUtxaUbQ7Db7n(-1334993905 ^ -1335091303) + Directory + (string)qm7fbjBzUtxaUbQ7Db7n(0x3630F361 ^ 0x363170CB)
				};
				num2 = 6;
				continue;
			case 19:
				return;
			case 13:
				obj2 = "";
				goto IL_05b1;
			case 16:
				if (TkPvAdWFiG0ZOrENl1HN(text))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 12:
				try
				{
					while (true)
					{
						IL_02b9:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_024a;
						}
						goto IL_0268;
						IL_024a:
						while (true)
						{
							switch (num3)
							{
							case 2:
								list.Add((string)WdZAjkWFfo38XVbooRtR(qm7fbjBzUtxaUbQ7Db7n(-1824388195 ^ -1824359675), Directory, current));
								num3 = 4;
								continue;
							case 4:
								goto IL_02b9;
							case 1:
								if (((IEnumerable<FileInfo>)sLEaRQWFE0b8i37c746E(directoryInfo, current)).Any())
								{
									num3 = 2;
									continue;
								}
								goto IL_02b9;
							case 3:
								goto end_IL_02b9;
							}
							break;
						}
						goto IL_0268;
						IL_0268:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num3 = 0;
						}
						goto IL_024a;
						continue;
						end_IL_02b9:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 11;
			case 8:
				if (File.Exists(text2))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 15;
					}
					continue;
				}
				goto case 13;
			case 4:
				XFhMZrWFICU6hD7a228e(Dhy27eWFubMeHeMw8ln5(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867727452), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921216799), list2)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				list2.AddRange(list);
				num2 = 18;
				continue;
			case 7:
				text = (string)WXRCgsBzjv4uTT95Ellg(Directory, qm7fbjBzUtxaUbQ7Db7n(-1123633026 ^ -1123553886));
				num2 = 16;
				continue;
			case 10:
				contents = (string)o4kGfJWFR9P45yDjIUI7(Locator.GetServiceNotNull<ServiceReferenceHelper>(), text3, text4, url);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 14;
				}
				continue;
			default:
				throw new Exception((string)lwTiEtWFVlob1EmKZsqm(qm7fbjBzUtxaUbQ7Db7n(-1824388195 ^ -1824288995)));
			case 2:
			{
				List<string> obj3 = new List<string>
				{
					(string)qm7fbjBzUtxaUbQ7Db7n(-1317790512 ^ -1317691848),
					(string)qm7fbjBzUtxaUbQ7Db7n(-812025778 ^ -812057930),
					(string)qm7fbjBzUtxaUbQ7Db7n(-475857671 ^ -475824129),
					(string)qm7fbjBzUtxaUbQ7Db7n(0x1ECE530A ^ 0x1ECFD014)
				};
				directoryInfo = new DirectoryInfo(Directory);
				enumerator = obj3.GetEnumerator();
				num2 = 12;
				continue;
			}
			case 20:
				list2.AddRange((IEnumerable<string>)i4faCCWFC8aDg2rhlaFk(SR.GetSetting((string)qm7fbjBzUtxaUbQ7Db7n(-643786247 ^ -643753393)), new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 15;
				}
				continue;
			case 18:
				if (bfRmRwWFZlfLumqCZ3Ij(FrZD03WF8h8NbAAq72JZ(list2)) == 0)
				{
					text2 = (string)WXRCgsBzjv4uTT95Ellg(Directory, qm7fbjBzUtxaUbQ7Db7n(0x53CACA3 ^ 0x53D2985));
					num2 = 8;
				}
				else
				{
					num2 = 4;
				}
				continue;
			case 3:
				list = new List<string>();
				num2 = 2;
				continue;
			case 5:
				obj = "";
				break;
			case 14:
				File.WriteAllText(Path.Combine(Directory, (string)qm7fbjBzUtxaUbQ7Db7n(-867826612 ^ -867729046)), contents);
				num2 = 19;
				continue;
			case 15:
				obj2 = y81rBEWFS1OS3Tin0n4P(text2);
				goto IL_05b1;
			case 9:
				{
					obj = y81rBEWFS1OS3Tin0n4P(text);
					break;
				}
				IL_05b1:
				text3 = (string)obj2;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 3;
				}
				continue;
			}
			text4 = (string)obj;
			num2 = 10;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
			{
				num2 = 1;
			}
		}
	}

	private ServiceDescriptionCollection GetServiceDescriptionCollection(DiscoveryClientProtocol protocol)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_00d1, IL_0137, IL_019c, IL_01ab, IL_01b7, IL_01c6
		int num = 1;
		int num2 = num;
		IDictionaryEnumerator enumerator = default(IDictionaryEnumerator);
		ContractReference contractReference = default(ContractReference);
		DictionaryEntry dictionaryEntry = default(DictionaryEntry);
		ServiceDescriptionCollection serviceDescriptionCollection = default(ServiceDescriptionCollection);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					while (true)
					{
						int num4;
						if (!gnJE1oWFGBUpTUSAyVpe(enumerator))
						{
							int num3 = 5;
							num4 = num3;
							goto IL_0050;
						}
						goto IL_0107;
						IL_0050:
						while (true)
						{
							switch (num4)
							{
							case 4:
								contractReference = dictionaryEntry.Value as ContractReference;
								num4 = 3;
								continue;
							case 6:
								if (contractReference == null)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 7;
							case 7:
								zyyFA5WFXGlk3bhsO1yc(serviceDescriptionCollection, CHU2GFWFKsKNu9SU1uLi(contractReference));
								num4 = 2;
								continue;
							case 3:
								_ = dictionaryEntry.Value;
								num4 = 6;
								continue;
							case 1:
								goto IL_0107;
							case 5:
								return serviceDescriptionCollection;
							}
							break;
						}
						continue;
						IL_0107:
						dictionaryEntry = (DictionaryEntry)RaM337WFBkKQYA3ibetf(enumerator);
						num4 = 4;
						goto IL_0050;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 3;
					while (true)
					{
						switch (num5)
						{
						default:
							H5LVm2WFTPe2xL6ZPAGD(disposable);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num5 = 2;
							}
							continue;
						case 3:
							if (disposable == null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num5 = 1;
								}
								continue;
							}
							goto default;
						case 1:
							break;
						case 2:
							break;
						}
						break;
					}
				}
			case 1:
				serviceDescriptionCollection = new ServiceDescriptionCollection();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return serviceDescriptionCollection;
			default:
				enumerator = ((DictionaryBase)eo2jxTWFqi2xYoa1AUqu(protocol)).GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private XmlSchemas GetXmlSchemas(DiscoveryClientProtocol protocol)
	{
		//Discarded unreachable code: IL_0053, IL_0062, IL_006d, IL_009c, IL_00ab, IL_017e, IL_01db, IL_01ea
		int num = 3;
		int num2 = num;
		XmlSchemas xmlSchemas = default(XmlSchemas);
		IDictionaryEnumerator dictionaryEnumerator = default(IDictionaryEnumerator);
		DictionaryEntry dictionaryEntry = default(DictionaryEntry);
		SchemaReference schemaReference = default(SchemaReference);
		while (true)
		{
			switch (num2)
			{
			case 3:
				xmlSchemas = new XmlSchemas();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				dictionaryEnumerator = (IDictionaryEnumerator)LE5gPXWFk26a4ndsjVq1(protocol.References);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return xmlSchemas;
			}
			try
			{
				while (true)
				{
					IL_00ef:
					int num3;
					if (!gnJE1oWFGBUpTUSAyVpe(dictionaryEnumerator))
					{
						num3 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num3 = 2;
						}
						goto IL_0071;
					}
					goto IL_00c7;
					IL_00c7:
					dictionaryEntry = (DictionaryEntry)RaM337WFBkKQYA3ibetf(dictionaryEnumerator);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num3 = 4;
					}
					goto IL_0071;
					IL_0071:
					while (true)
					{
						switch (num3)
						{
						case 2:
							if (schemaReference == null)
							{
								num3 = 5;
								continue;
							}
							goto case 3;
						case 1:
							break;
						default:
							goto IL_00ef;
						case 3:
							txadjZWFOo6ik9SoKq4n(xmlSchemas, cKk8vBWFnRRCo05ZLSBk(schemaReference));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							schemaReference = dictionaryEntry.Value as SchemaReference;
							num3 = 2;
							continue;
						case 6:
							return xmlSchemas;
						}
						break;
					}
					goto IL_00c7;
				}
			}
			finally
			{
				IDisposable disposable = dictionaryEnumerator as IDisposable;
				int num4 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 2:
						if (disposable != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num4 = 0;
							}
							continue;
						}
						break;
					default:
						H5LVm2WFTPe2xL6ZPAGD(disposable);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 1;
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

	private void GenerateWebProxy()
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
				OgspLDWF2vdlF6329MFp(proxyNamespace, GetFullProxyFileName(), GetServiceDescriptionCollection(protocol), GetXmlSchemas(protocol));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void GenerateWebProxy(object proxyNamespace, object fileName, object serviceDescriptions, object schemas)
	{
		//Discarded unreachable code: IL_0133, IL_0142, IL_014d, IL_01fa, IL_024f, IL_025a, IL_02cb, IL_02da, IL_02e5, IL_0351, IL_0360, IL_036b, IL_039b, IL_03aa, IL_03b5, IL_0421, IL_04af, IL_050c, IL_051b, IL_0594, IL_05a2, IL_062a, IL_0664, IL_0673, IL_067e, IL_06b1, IL_07b2, IL_07f6, IL_0805, IL_0832, IL_0917, IL_0974, IL_0983, IL_09d9, IL_09e8, IL_09f3, IL_0ae9, IL_0b46, IL_0b78, IL_0bd5, IL_0c1d, IL_0c6a, IL_0c9c, IL_0ce9, IL_0cf8, IL_0d1a, IL_0d29, IL_0d34, IL_0dcd, IL_0e01, IL_0e10, IL_0e3d, IL_0e4c
		int num = 11;
		ServiceDescriptionImporter serviceDescriptionImporter = default(ServiceDescriptionImporter);
		CodeNamespace codeNamespace = default(CodeNamespace);
		CodeCompileUnit codeCompileUnit = default(CodeCompileUnit);
		IEnumerator enumerator = default(IEnumerator);
		StreamWriter streamWriter = default(StreamWriter);
		XmlSchema xmlSchema = default(XmlSchema);
		IEnumerator enumerator2 = default(IEnumerator);
		IEnumerator enumerator3 = default(IEnumerator);
		CodeAttributeDeclaration codeAttributeDeclaration3 = default(CodeAttributeDeclaration);
		CodeTypeDeclaration codeTypeDeclaration = default(CodeTypeDeclaration);
		CodeTypeMember codeTypeMember = default(CodeTypeMember);
		IEnumerator enumerator4 = default(IEnumerator);
		CodeAttributeDeclaration codeAttributeDeclaration2 = default(CodeAttributeDeclaration);
		IEnumerator enumerator5 = default(IEnumerator);
		CodeFieldReferenceExpression codeFieldReferenceExpression = default(CodeFieldReferenceExpression);
		CodeTypeReferenceExpression codeTypeReferenceExpression = default(CodeTypeReferenceExpression);
		CodeAttributeDeclaration codeAttributeDeclaration = default(CodeAttributeDeclaration);
		System.Web.Services.Description.ServiceDescription serviceDescription = default(System.Web.Services.Description.ServiceDescription);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					serviceDescriptionImporter.Import(codeNamespace, codeCompileUnit);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					return;
				case 10:
					enumerator = ((CollectionBase)serviceDescriptions).GetEnumerator();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					codeNamespace = new CodeNamespace((string)proxyNamespace);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
				{
					object obj = qm5NbHWF0tiqCBFc4PrE(qm7fbjBzUtxaUbQ7Db7n(0x4D1C1EE4 ^ 0x4D1D9B94));
					streamWriter = new StreamWriter((string)fileName);
					CodeGeneratorOptions codeGeneratorOptions = new CodeGeneratorOptions();
					mfUavdWFmNZmTCGjou1O(codeGeneratorOptions, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4C3865));
					qJEa3nWFyXST0FyJNHmX(obj, codeCompileUnit, streamWriter, codeGeneratorOptions);
					num2 = 2;
					continue;
				}
				case 5:
					enumerator = (IEnumerator)aYoEhOWFPnuVI9NMYtey(codeCompileUnit.Namespaces);
					num2 = 12;
					continue;
				case 3:
					try
					{
						while (true)
						{
							IL_0193:
							int num20;
							if (!enumerator.MoveNext())
							{
								num20 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num20 = 1;
								}
								goto IL_0151;
							}
							goto IL_016b;
							IL_016b:
							xmlSchema = (XmlSchema)RaM337WFBkKQYA3ibetf(enumerator);
							num20 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num20 = 0;
							}
							goto IL_0151;
							IL_0151:
							while (true)
							{
								switch (num20)
								{
								case 2:
									break;
								case 3:
									goto IL_0193;
								default:
									txadjZWFOo6ik9SoKq4n(serviceDescriptionImporter.Schemas, xmlSchema);
									num20 = 3;
									continue;
								case 1:
									goto end_IL_0193;
								}
								break;
							}
							goto IL_016b;
							continue;
							end_IL_0193:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num21 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num21 = 1;
						}
						while (true)
						{
							switch (num21)
							{
							case 2:
								H5LVm2WFTPe2xL6ZPAGD(disposable);
								num21 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num21 = 0;
								}
								continue;
							case 1:
								if (disposable == null)
								{
									num21 = 3;
									continue;
								}
								goto case 2;
							case 3:
								break;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 4;
				case 11:
					break;
				case 8:
					q019EYWF16Nh32UTIaXO(codeCompileUnit.Namespaces, codeNamespace);
					num2 = 6;
					continue;
				case 2:
					streamWriter.Close();
					num2 = 9;
					continue;
				case 1:
					enumerator = (IEnumerator)aYoEhOWFPnuVI9NMYtey(schemas);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					try
					{
						while (true)
						{
							int num5;
							if (!gnJE1oWFGBUpTUSAyVpe(enumerator))
							{
								num5 = 2;
								goto IL_02e9;
							}
							goto IL_0303;
							IL_02e9:
							switch (num5)
							{
							case 3:
								continue;
							case 1:
								try
								{
									while (true)
									{
										IL_0bdf:
										int num6;
										if (!gnJE1oWFGBUpTUSAyVpe(enumerator2))
										{
											num6 = 4;
											goto IL_036f;
										}
										goto IL_0526;
										IL_036f:
										while (true)
										{
											switch (num6)
											{
											case 5:
												try
												{
													while (true)
													{
														int num16;
														if (!gnJE1oWFGBUpTUSAyVpe(enumerator3))
														{
															num16 = 4;
															goto IL_03b9;
														}
														goto IL_0441;
														IL_03b9:
														while (true)
														{
															switch (num16)
															{
															case 5:
																if (NoA0KrWFpWWF9ZEVH8jX(kmVusIWF3Pn9etev4BlS(codeAttributeDeclaration3), qm7fbjBzUtxaUbQ7Db7n(0x1DE3DD89 ^ 0x1DE258CB)))
																{
																	num16 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
																	{
																		num16 = 1;
																	}
																	continue;
																}
																goto case 2;
															case 1:
															case 3:
																break;
															default:
																goto IL_0441;
															case 2:
																XbR2HnWFDve8DA2Trpe8(codeAttributeDeclaration3, ErCUhrWFa0irej5HwO9K(qm7fbjBzUtxaUbQ7Db7n(-2138160520 ^ -2138061010), codeAttributeDeclaration3.Name));
																num16 = 3;
																continue;
															case 4:
																goto end_IL_042b;
															}
															break;
														}
														continue;
														IL_0441:
														codeAttributeDeclaration3 = (CodeAttributeDeclaration)RaM337WFBkKQYA3ibetf(enumerator3);
														num16 = 3;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
														{
															num16 = 5;
														}
														goto IL_03b9;
														continue;
														end_IL_042b:
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator3 as IDisposable;
													int num17 = 2;
													while (true)
													{
														switch (num17)
														{
														case 1:
															H5LVm2WFTPe2xL6ZPAGD(disposable);
															num17 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
															{
																num17 = 0;
															}
															continue;
														case 2:
															if (disposable != null)
															{
																num17 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
																{
																	num17 = 1;
																}
																continue;
															}
															break;
														case 0:
															break;
														}
														break;
													}
												}
												goto case 2;
											case 1:
												break;
											case 2:
												enumerator3 = ((CollectionBase)GNEpSpWFtSVrZ6r2YQIW(codeTypeDeclaration)).GetEnumerator();
												num6 = 6;
												continue;
											default:
												enumerator3 = (IEnumerator)aYoEhOWFPnuVI9NMYtey(RP49jbWFNDVhJiAms8Nt(codeTypeDeclaration));
												num6 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
												{
													num6 = 0;
												}
												continue;
											case 6:
												try
												{
													while (true)
													{
														int num7;
														if (!enumerator3.MoveNext())
														{
															num7 = 5;
															goto IL_05a6;
														}
														goto IL_09bb;
														IL_05a6:
														while (true)
														{
															switch (num7)
															{
															case 1:
																if (codeTypeMember is CodeMemberMethod)
																{
																	num7 = 6;
																	continue;
																}
																break;
															case 3:
																break;
															case 2:
																enumerator4 = (IEnumerator)aYoEhOWFPnuVI9NMYtey(codeTypeMember.CustomAttributes);
																num7 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
																{
																	num7 = 0;
																}
																continue;
															default:
																try
																{
																	while (true)
																	{
																		IL_08d9:
																		int num10;
																		if (!gnJE1oWFGBUpTUSAyVpe(enumerator4))
																		{
																			num10 = 0;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
																			{
																				num10 = 1;
																			}
																			goto IL_0638;
																		}
																		goto IL_0868;
																		IL_0868:
																		codeAttributeDeclaration2 = (CodeAttributeDeclaration)RaM337WFBkKQYA3ibetf(enumerator4);
																		int num11 = 4;
																		num10 = num11;
																		goto IL_0638;
																		IL_0638:
																		while (true)
																		{
																			switch (num10)
																			{
																			default:
																				try
																				{
																					while (true)
																					{
																						IL_06bb:
																						int num12;
																						if (!gnJE1oWFGBUpTUSAyVpe(enumerator5))
																						{
																							num12 = 0;
																							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
																							{
																								num12 = 0;
																							}
																							goto IL_0682;
																						}
																						goto IL_0768;
																						IL_0768:
																						codeFieldReferenceExpression = sOTxxjWF4fbhvVlPxlhH((CodeAttributeArgument)RaM337WFBkKQYA3ibetf(enumerator5)) as CodeFieldReferenceExpression;
																						num12 = 5;
																						goto IL_0682;
																						IL_0682:
																						while (true)
																						{
																							switch (num12)
																							{
																							case 3:
																							case 4:
																								goto IL_06bb;
																							case 2:
																								codeTypeReferenceExpression = HuhHG0WF6xDBDnTqPA0D(codeFieldReferenceExpression) as CodeTypeReferenceExpression;
																								num12 = 6;
																								continue;
																							case 5:
																								if (codeFieldReferenceExpression != null)
																								{
																									num12 = 2;
																									continue;
																								}
																								goto IL_06bb;
																							case 7:
																								CVm5MwWF7Fw3tmgRs3pj(HbXSfdWFHCpvssLsXjpI(codeTypeReferenceExpression), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7F349), mksp0uWFARLJ5KE0FMSt(codeTypeReferenceExpression.Type)));
																								num12 = 3;
																								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
																								{
																									num12 = 3;
																								}
																								continue;
																							case 6:
																								if (codeTypeReferenceExpression == null)
																								{
																									num12 = 4;
																									continue;
																								}
																								goto case 7;
																							case 1:
																								goto IL_0768;
																							case 0:
																								break;
																							}
																							break;
																						}
																						break;
																					}
																				}
																				finally
																				{
																					IDisposable disposable = enumerator5 as IDisposable;
																					int num13 = 1;
																					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
																					{
																						num13 = 1;
																					}
																					while (true)
																					{
																						switch (num13)
																						{
																						default:
																							goto end_IL_07b6;
																						case 1:
																							if (disposable == null)
																							{
																								num13 = 0;
																								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
																								{
																									num13 = 0;
																								}
																								continue;
																							}
																							break;
																						case 0:
																							goto end_IL_07b6;
																						case 2:
																							break;
																						case 3:
																							goto end_IL_07b6;
																						}
																						disposable.Dispose();
																						num13 = 2;
																						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
																						{
																							num13 = 3;
																						}
																						continue;
																						end_IL_07b6:
																						break;
																					}
																				}
																				goto IL_08d9;
																			case 4:
																				if (!NoA0KrWFpWWF9ZEVH8jX(kmVusIWF3Pn9etev4BlS(codeAttributeDeclaration2), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16655451)))
																				{
																					num10 = 5;
																					continue;
																				}
																				goto case 6;
																			case 3:
																				break;
																			case 6:
																				enumerator5 = (IEnumerator)aYoEhOWFPnuVI9NMYtey(zA9sXmWFwbmtFxvrYG1l(codeAttributeDeclaration2));
																				num10 = 0;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
																				{
																					num10 = 0;
																				}
																				continue;
																			case 5:
																				XbR2HnWFDve8DA2Trpe8(codeAttributeDeclaration2, ErCUhrWFa0irej5HwO9K(qm7fbjBzUtxaUbQ7Db7n(-867826612 ^ -867729126), kmVusIWF3Pn9etev4BlS(codeAttributeDeclaration2)));
																				num10 = 6;
																				continue;
																			case 2:
																				goto IL_08d9;
																			case 1:
																				goto end_IL_08d9;
																			}
																			break;
																		}
																		goto IL_0868;
																		continue;
																		end_IL_08d9:
																		break;
																	}
																}
																finally
																{
																	IDisposable disposable = enumerator4 as IDisposable;
																	int num14 = 2;
																	while (true)
																	{
																		switch (num14)
																		{
																		default:
																			H5LVm2WFTPe2xL6ZPAGD(disposable);
																			num14 = 1;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
																			{
																				num14 = 1;
																			}
																			continue;
																		case 2:
																			if (disposable != null)
																			{
																				num14 = 0;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
																				{
																					num14 = 0;
																				}
																				continue;
																			}
																			break;
																		case 1:
																			break;
																		}
																		break;
																	}
																}
																goto case 1;
															case 6:
																enumerator4 = (IEnumerator)aYoEhOWFPnuVI9NMYtey(wmxtDfWFxRxaHxlmdMRb((CodeMemberMethod)codeTypeMember));
																num7 = 4;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
																{
																	num7 = 4;
																}
																continue;
															case 7:
																goto IL_09bb;
															case 4:
																try
																{
																	while (true)
																	{
																		IL_0a40:
																		int num8;
																		if (!gnJE1oWFGBUpTUSAyVpe(enumerator4))
																		{
																			num8 = 0;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
																			{
																				num8 = 0;
																			}
																			goto IL_09f7;
																		}
																		goto IL_0aa9;
																		IL_0aa9:
																		codeAttributeDeclaration = (CodeAttributeDeclaration)RaM337WFBkKQYA3ibetf(enumerator4);
																		num8 = 2;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
																		{
																			num8 = 0;
																		}
																		goto IL_09f7;
																		IL_09f7:
																		while (true)
																		{
																			switch (num8)
																			{
																			case 2:
																				if (!codeAttributeDeclaration.Name.StartsWith((string)qm7fbjBzUtxaUbQ7Db7n(0x3CE17B75 ^ 0x3CE0FE37)))
																				{
																					num8 = 3;
																					continue;
																				}
																				goto IL_0a40;
																			case 4:
																				goto IL_0a40;
																			case 3:
																				XbR2HnWFDve8DA2Trpe8(codeAttributeDeclaration, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36317637), codeAttributeDeclaration.Name));
																				num8 = 4;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
																				{
																					num8 = 3;
																				}
																				continue;
																			case 1:
																				goto IL_0aa9;
																			case 0:
																				break;
																			}
																			break;
																		}
																		break;
																	}
																}
																finally
																{
																	IDisposable disposable = enumerator4 as IDisposable;
																	int num9 = 2;
																	while (true)
																	{
																		switch (num9)
																		{
																		default:
																			H5LVm2WFTPe2xL6ZPAGD(disposable);
																			num9 = 1;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
																			{
																				num9 = 1;
																			}
																			continue;
																		case 2:
																			if (disposable != null)
																			{
																				num9 = 0;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
																				{
																					num9 = 0;
																				}
																				continue;
																			}
																			break;
																		case 1:
																			break;
																		}
																		break;
																	}
																}
																break;
															case 5:
																goto end_IL_05e6;
															}
															break;
														}
														continue;
														IL_09bb:
														codeTypeMember = (CodeTypeMember)RaM337WFBkKQYA3ibetf(enumerator3);
														num7 = 2;
														goto IL_05a6;
														continue;
														end_IL_05e6:
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator3 as IDisposable;
													int num15 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
													{
														num15 = 0;
													}
													while (true)
													{
														switch (num15)
														{
														case 1:
															H5LVm2WFTPe2xL6ZPAGD(disposable);
															num15 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
															{
																num15 = 2;
															}
															continue;
														default:
															if (disposable != null)
															{
																num15 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
																{
																	num15 = 0;
																}
																continue;
															}
															break;
														case 2:
															break;
														}
														break;
													}
												}
												goto IL_0bdf;
											case 3:
												goto IL_0bdf;
											case 4:
												goto end_IL_0bdf;
											}
											break;
										}
										goto IL_0526;
										IL_0526:
										codeTypeDeclaration = (CodeTypeDeclaration)enumerator2.Current;
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
										{
											num6 = 0;
										}
										goto IL_036f;
										continue;
										end_IL_0bdf:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator2 as IDisposable;
									int num18 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
									{
										num18 = 0;
									}
									while (true)
									{
										switch (num18)
										{
										default:
											H5LVm2WFTPe2xL6ZPAGD(disposable);
											num18 = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num18 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
												{
													num18 = 0;
												}
												continue;
											}
											break;
										case 2:
											break;
										}
										break;
									}
								}
								continue;
							case 2:
								goto end_IL_0335;
							}
							goto IL_0303;
							IL_0303:
							enumerator2 = ((CodeNamespace)RaM337WFBkKQYA3ibetf(enumerator)).Types.GetEnumerator();
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num5 = 1;
							}
							goto IL_02e9;
							continue;
							end_IL_0335:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num19 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num19 = 1;
						}
						while (true)
						{
							switch (num19)
							{
							case 1:
								if (disposable != null)
								{
									num19 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num19 = 0;
									}
									continue;
								}
								break;
							default:
								disposable.Dispose();
								num19 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 13;
				default:
					codeCompileUnit = new CodeCompileUnit();
					num2 = 8;
					continue;
				case 7:
					try
					{
						while (true)
						{
							IL_0d7f:
							int num3;
							if (!gnJE1oWFGBUpTUSAyVpe(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
								{
									num3 = 0;
								}
								goto IL_0d38;
							}
							goto IL_0d52;
							IL_0d52:
							serviceDescription = (System.Web.Services.Description.ServiceDescription)enumerator.Current;
							num3 = 2;
							goto IL_0d38;
							IL_0d38:
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_0d52;
								case 2:
									psV3DjWFewiA44pRXv6c(serviceDescriptionImporter, serviceDescription, null, null);
									num3 = 3;
									continue;
								case 3:
									goto IL_0d7f;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num4 = 2;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								goto end_IL_0dd1;
							case 2:
								if (disposable == null)
								{
									num4 = 3;
									continue;
								}
								break;
							case 3:
								goto end_IL_0dd1;
							case 1:
								break;
							case 0:
								goto end_IL_0dd1;
							}
							H5LVm2WFTPe2xL6ZPAGD(disposable);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num4 = 0;
							}
							continue;
							end_IL_0dd1:
							break;
						}
					}
					goto case 1;
				}
				break;
			}
			serviceDescriptionImporter = new ServiceDescriptionImporter();
			num = 10;
		}
	}

	private string GetProxyFileName()
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)WXRCgsBzjv4uTT95Ellg(relativePath, text);
			case 1:
				text = (string)KqUWBrBzY6N7MdrFsIu4(qm7fbjBzUtxaUbQ7Db7n(0x7EC153F ^ 0x7ED9047), qm7fbjBzUtxaUbQ7Db7n(0x26FFCB59 ^ 0x26FED217));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void OnNameChanged()
	{
		//Discarded unreachable code: IL_0036, IL_0045
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				return;
			case 1:
				items = CreateProjectItems();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				GetRelativePath();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (items == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private void GetRelativePath()
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
				webReferencesDirectory = (string)WXRCgsBzjv4uTT95Ellg(projectDirPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138859914));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				relativePath = (string)WXRCgsBzjv4uTT95Ellg(qm7fbjBzUtxaUbQ7Db7n(0x76DD48E ^ 0x76C5100), name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private List<ScriptProjectItem> CreateProjectItems()
	{
		items = new List<ScriptProjectItem>();
		ScriptProjectItem scriptProjectItem = new ScriptProjectItem();
		scriptProjectItem.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099653927);
		scriptProjectItem.Include = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345454486);
		items.Add(scriptProjectItem);
		ScriptProjectItem scriptProjectItem2 = new ScriptProjectItem();
		scriptProjectItem2.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A757E0);
		scriptProjectItem2.Include = url;
		scriptProjectItem2.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7F3ED),
			Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606685424)
		});
		scriptProjectItem2.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767686169),
			Value = url
		});
		scriptProjectItem2.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD4D66A),
			Value = relativePath
		});
		scriptProjectItem2.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812057086),
			Value = relativePath
		});
		items.Add(scriptProjectItem2);
		foreach (DictionaryEntry reference in protocol.References)
		{
			if (reference.Value is DiscoveryReference discoveryReference)
			{
				string defaultFilename = discoveryReference.DefaultFilename;
				ScriptProjectItem scriptProjectItem3 = new ScriptProjectItem();
				scriptProjectItem3.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC3372F);
				if (defaultFilename != null && !defaultFilename.IsNullOrEmpty())
				{
					scriptProjectItem3.Include = Path.Combine(relativePath, defaultFilename);
				}
				items.Add(scriptProjectItem3);
			}
		}
		ScriptProjectItem scriptProjectItem4 = new ScriptProjectItem();
		scriptProjectItem4.Include = GetProxyFileName();
		scriptProjectItem4.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345453654);
		scriptProjectItem4.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F4E036),
			Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3366264)
		});
		scriptProjectItem4.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC0C12E),
			Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12459A36)
		});
		scriptProjectItem4.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1636429F),
			Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088403182)
		});
		items.Add(scriptProjectItem4);
		ScriptProjectItem scriptProjectItem5 = new ScriptProjectItem();
		scriptProjectItem5.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979284909);
		scriptProjectItem5.Include = Path.Combine(relativePath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A4A194));
		scriptProjectItem5.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC0C164),
			Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088402126)
		});
		scriptProjectItem5.Metadata.Add(new MetadataItem
		{
			Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345453870),
			Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29353915)
		});
		items.Add(scriptProjectItem5);
		ScriptProjectItem scriptProjectItem6 = new ScriptProjectItem();
		scriptProjectItem6.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606686108);
		scriptProjectItem6.Include = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4DFBF9);
		items.Add(scriptProjectItem6);
		foreach (ScriptProjectItem item in items.ToList())
		{
			string path = Path.Combine(projectDirPath, item.Include);
			if (File.Exists(path))
			{
				item.FileContent = File.ReadAllText(path, Encoding.UTF8);
			}
		}
		return items;
	}

	private static bool ContainsInvalidDirectoryChar(object item)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass44_.item = (string)item;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return ((IEnumerable<char>)nsrPByWFMS6HTm1WbDLB()).Any(_003C_003Ec__DisplayClass44_._003CContainsInvalidDirectoryChar_003Eb__0);
			}
		}
	}

	internal static bool EcMZTHBzdptdmlbjNRis()
	{
		return TK6Q9tBz91jKJcMu74O8 == null;
	}

	internal static WebReference OlsbwOBzlyOqbIyYauZ7()
	{
		return TK6Q9tBz91jKJcMu74O8;
	}

	internal static void OP9OohBzr4gIMu3Vuk5E(object P_0)
	{
		CodeGenerator.ValidateIdentifiers((CodeObject)P_0);
	}

	internal static int K7JCnoBzgUI7jDx5ZFXR(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static int RK35xjBz5ayFQnW0gkoO(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object WXRCgsBzjv4uTT95Ellg(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object KqUWBrBzY6N7MdrFsIu4(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool WhOwGLBzLcUO13mhXRxV(object P_0)
	{
		return System.IO.Directory.Exists((string)P_0);
	}

	internal static object qm7fbjBzUtxaUbQ7Db7n(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zWv9VuBzsQUVf8413FJ2(object P_0, object P_1, object P_2)
	{
		return ((DiscoveryClientProtocol)P_0).WriteAll((string)P_1, (string)P_2);
	}

	internal static object bJvaoTBzc8aUtBbaaUsV(object P_0)
	{
		return ((DiscoveryClientProtocol)P_0).Documents;
	}

	internal static object clRitvBzzu6Cveq96dIR(object P_0)
	{
		return ((DiscoveryClientDocumentCollection)P_0).Values;
	}

	internal static object IBNxlAWFFSKWwENKL7Ia(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object RaM337WFBkKQYA3ibetf(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object Vpx2w4WFWh5i06FoCY8E(object P_0)
	{
		return ((NamedItem)P_0).Name;
	}

	internal static bool XNoa7UWFolZ9IirPkw93(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object vbVl8NWFbgCfkeEdfKJj(object P_0, object P_1, object P_2)
	{
		return ((Regex)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void fixcwBWFhqaD5RivFbIb(object P_0, object P_1)
	{
		((NamedItem)P_0).Name = (string)P_1;
	}

	internal static bool gnJE1oWFGBUpTUSAyVpe(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object sLEaRQWFE0b8i37c746E(object P_0, object P_1)
	{
		return ((DirectoryInfo)P_0).GetFiles((string)P_1);
	}

	internal static object WdZAjkWFfo38XVbooRtR(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object QIrjpqWFQTrMancgpWgx(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object i4faCCWFC8aDg2rhlaFk(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static int kALaXQWFv2qy240XHn8B(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object FrZD03WF8h8NbAAq72JZ(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static int bfRmRwWFZlfLumqCZ3Ij(object P_0)
	{
		return Tool.Main((string[])P_0);
	}

	internal static object Dhy27eWFubMeHeMw8ln5()
	{
		return Logger.Log;
	}

	internal static void XFhMZrWFICU6hD7a228e(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object lwTiEtWFVlob1EmKZsqm(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object y81rBEWFS1OS3Tin0n4P(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}

	internal static bool TkPvAdWFiG0ZOrENl1HN(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object o4kGfJWFR9P45yDjIUI7(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ServiceReferenceHelper)P_0).EditSourceCode((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object eo2jxTWFqi2xYoa1AUqu(object P_0)
	{
		return ((DiscoveryClientProtocol)P_0).References;
	}

	internal static object CHU2GFWFKsKNu9SU1uLi(object P_0)
	{
		return ((ContractReference)P_0).Contract;
	}

	internal static int zyyFA5WFXGlk3bhsO1yc(object P_0, object P_1)
	{
		return ((ServiceDescriptionCollection)P_0).Add((System.Web.Services.Description.ServiceDescription)P_1);
	}

	internal static void H5LVm2WFTPe2xL6ZPAGD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object LE5gPXWFk26a4ndsjVq1(object P_0)
	{
		return ((DictionaryBase)P_0).GetEnumerator();
	}

	internal static object cKk8vBWFnRRCo05ZLSBk(object P_0)
	{
		return ((SchemaReference)P_0).Schema;
	}

	internal static int txadjZWFOo6ik9SoKq4n(object P_0, object P_1)
	{
		return ((XmlSchemas)P_0).Add((XmlSchema)P_1);
	}

	internal static void OgspLDWF2vdlF6329MFp(object P_0, object P_1, object P_2, object P_3)
	{
		GenerateWebProxy(P_0, P_1, P_2, P_3);
	}

	internal static void psV3DjWFewiA44pRXv6c(object P_0, object P_1, object P_2, object P_3)
	{
		((ServiceDescriptionImporter)P_0).AddServiceDescription((System.Web.Services.Description.ServiceDescription)P_1, (string)P_2, (string)P_3);
	}

	internal static object aYoEhOWFPnuVI9NMYtey(object P_0)
	{
		return ((CollectionBase)P_0).GetEnumerator();
	}

	internal static int q019EYWF16Nh32UTIaXO(object P_0, object P_1)
	{
		return ((CodeNamespaceCollection)P_0).Add((CodeNamespace)P_1);
	}

	internal static object RP49jbWFNDVhJiAms8Nt(object P_0)
	{
		return ((CodeTypeMember)P_0).CustomAttributes;
	}

	internal static object kmVusIWF3Pn9etev4BlS(object P_0)
	{
		return ((CodeAttributeDeclaration)P_0).Name;
	}

	internal static bool NoA0KrWFpWWF9ZEVH8jX(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object ErCUhrWFa0irej5HwO9K(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void XbR2HnWFDve8DA2Trpe8(object P_0, object P_1)
	{
		((CodeAttributeDeclaration)P_0).Name = (string)P_1;
	}

	internal static object GNEpSpWFtSVrZ6r2YQIW(object P_0)
	{
		return ((CodeTypeDeclaration)P_0).Members;
	}

	internal static object zA9sXmWFwbmtFxvrYG1l(object P_0)
	{
		return ((CodeAttributeDeclaration)P_0).Arguments;
	}

	internal static object sOTxxjWF4fbhvVlPxlhH(object P_0)
	{
		return ((CodeAttributeArgument)P_0).Value;
	}

	internal static object HuhHG0WF6xDBDnTqPA0D(object P_0)
	{
		return ((CodeFieldReferenceExpression)P_0).TargetObject;
	}

	internal static object HbXSfdWFHCpvssLsXjpI(object P_0)
	{
		return ((CodeTypeReferenceExpression)P_0).Type;
	}

	internal static object mksp0uWFARLJ5KE0FMSt(object P_0)
	{
		return ((CodeTypeReference)P_0).BaseType;
	}

	internal static void CVm5MwWF7Fw3tmgRs3pj(object P_0, object P_1)
	{
		((CodeTypeReference)P_0).BaseType = (string)P_1;
	}

	internal static object wmxtDfWFxRxaHxlmdMRb(object P_0)
	{
		return ((CodeMemberMethod)P_0).ReturnTypeCustomAttributes;
	}

	internal static object qm5NbHWF0tiqCBFc4PrE(object P_0)
	{
		return CodeDomProvider.CreateProvider((string)P_0);
	}

	internal static void mfUavdWFmNZmTCGjou1O(object P_0, object P_1)
	{
		((CodeGeneratorOptions)P_0).BracingStyle = (string)P_1;
	}

	internal static void qJEa3nWFyXST0FyJNHmX(object P_0, object P_1, object P_2, object P_3)
	{
		((CodeDomProvider)P_0).GenerateCodeFromCompileUnit((CodeCompileUnit)P_1, (TextWriter)P_2, (CodeGeneratorOptions)P_3);
	}

	internal static object nsrPByWFMS6HTm1WbDLB()
	{
		return Path.GetInvalidPathChars();
	}
}
