using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Remoting;

public class ProxySettings
{
	private static IWebProxy defaultProxy;

	private static ProxySettings bUTo2NKdxP4egvGv9ON;

	public ProxyType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	public string Address
	{
		[CompilerGenerated]
		get
		{
			return _003CAddress_003Ek__BackingField;
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
					_003CAddress_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Port
	{
		[CompilerGenerated]
		get
		{
			return _003CPort_003Ek__BackingField;
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
					_003CPort_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string UserName
	{
		[CompilerGenerated]
		get
		{
			return _003CUserName_003Ek__BackingField;
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
					_003CUserName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return _003CPassword_003Ek__BackingField;
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
					_003CPassword_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	public bool UseExceptions
	{
		[CompilerGenerated]
		get
		{
			return _003CUseExceptions_003Ek__BackingField;
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
					_003CUseExceptions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
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

	public string Exceptions
	{
		[CompilerGenerated]
		get
		{
			return _003CExceptions_003Ek__BackingField;
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
					_003CExceptions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
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

	public bool Expect100Сontinue
	{
		[CompilerGenerated]
		get
		{
			return _003CExpect100Сontinue_003Ek__BackingField;
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
					_003CExpect100Сontinue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	public string ConfigFileName
	{
		get
		{
			//Discarded unreachable code: IL_0092, IL_00a1
			int num = 3;
			int num2 = num;
			string directoryName = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (directoryName != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return null;
				default:
					return (string)UQkDwiKU2GVAj1Cblba(directoryName, i6XIkgKLZoQXKXTxcpX(0x49E27B8A ^ 0x49E22F26));
				case 3:
					directoryName = Path.GetDirectoryName(((AppDomainSetup)EyJj4BKYnHF9bnLojOI(M32ZRnKjLu5L14icTna())).ConfigurationFile);
					num2 = 2;
					break;
				}
			}
		}
	}

	static ProxySettings()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				defaultProxy = (IWebProxy)wsJmSMK5UBVD9VtHZrk();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				B0H8SbKgZK7XHgfNGWO();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ProxySettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B0H8SbKgZK7XHgfNGWO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void LoadDefault()
	{
		//Discarded unreachable code: IL_00aa, IL_018e, IL_019d, IL_01ed, IL_0280, IL_028f, IL_029f, IL_02ae, IL_02be, IL_034b
		int num = 14;
		WebProxy webProxy = default(WebProxy);
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		FieldInfo field = default(FieldInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					Type = ProxyType.NotUse;
					num2 = 13;
					continue;
				case 6:
					return;
				case 24:
					Port = y3IdMFXBDghCV23fjxI(snoVPJKciiDBxelO0Yh(webProxy));
					num2 = 2;
					continue;
				case 9:
					Exceptions = stringBuilder.ToString();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 18;
					}
					continue;
				case 18:
					return;
				case 2:
				case 15:
					UseExceptions = qsEfJRXWlLcTJAJy7Ig(webProxy);
					num2 = 19;
					continue;
				case 8:
					num3++;
					num2 = 29;
					continue;
				case 28:
				case 29:
					if (num3 < ((Array)C7xsSyXb8S0QDZh9wFX(webProxy)).Length)
					{
						num2 = 17;
						continue;
					}
					goto case 9;
				case 19:
					if (webProxy.BypassList == null)
					{
						return;
					}
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 27;
					}
					continue;
				case 11:
					num3 = 0;
					num2 = 28;
					continue;
				case 22:
					webProxy = (WebProxy)G1MmsoKsUGKLPIZsVRt(field, defaultProxy);
					num2 = 7;
					continue;
				case 20:
					Address = (string)QvpWnpXF1yJpCrJJE5W(snoVPJKciiDBxelO0Yh(webProxy));
					num2 = 24;
					continue;
				case 25:
					return;
				case 1:
					webProxy = null;
					num = 10;
					break;
				default:
					if (num3 <= 0)
					{
						num2 = 16;
						continue;
					}
					goto case 23;
				case 13:
					if (defaultProxy != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 21;
				case 10:
					field = defaultProxy.GetType().GetField((string)i6XIkgKLZoQXKXTxcpX(0x42643203 ^ 0x426466CB), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 3;
					}
					continue;
				case 23:
					lSuEF4XoQFSYG5WoB9s(stringBuilder, i6XIkgKLZoQXKXTxcpX(-541731959 ^ -541751467));
					num2 = 4;
					continue;
				case 7:
				case 26:
					if (webProxy == null)
					{
						return;
					}
					num2 = 5;
					continue;
				case 21:
					Port = 8080;
					num2 = 25;
					continue;
				case 12:
					stringBuilder = new StringBuilder();
					num2 = 11;
					continue;
				case 5:
					if (!xmCMKMKzv0FdC6pkC02(snoVPJKciiDBxelO0Yh(webProxy), null))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 20;
				case 27:
					if (webProxy.BypassList.Length == 0)
					{
						num = 6;
						break;
					}
					goto case 12;
				case 3:
					if (!(field != null))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 22;
				case 4:
				case 16:
					lSuEF4XoQFSYG5WoB9s(stringBuilder, coLGJyXh3ocxUkmbidi(((string)((object[])C7xsSyXb8S0QDZh9wFX(webProxy))[num3]).Replace((string)i6XIkgKLZoQXKXTxcpX(-1459557599 ^ -1459555241), ""), i6XIkgKLZoQXKXTxcpX(0x7EC153F ^ 0x7EC41DD), ""));
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	public void Load()
	{
		//Discarded unreachable code: IL_01f3, IL_0202, IL_02ab, IL_02ba, IL_0316, IL_0338, IL_03b9, IL_03c8, IL_03d7, IL_03e6, IL_03f5, IL_045d, IL_049e, IL_0545, IL_0587, IL_0596, IL_05d0, IL_05df, IL_0615, IL_0654, IL_06c7, IL_06d6, IL_06e5, IL_06f5, IL_0704, IL_0714, IL_0764, IL_07af, IL_0843, IL_0852, IL_0865, IL_0874, IL_0884, IL_0893, IL_08a2, IL_08ce, IL_091f, IL_092e
		int num = 4;
		int num2 = num;
		string text = default(string);
		uint num4 = default(uint);
		XmlNode xmlNode2 = default(XmlNode);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					Kgio1LXEImOBXSw6Ttl(xmlDocument, ConfigFileName);
					XmlNode xmlNode = (XmlNode)sNnJ6GXf5Dde5SMMmUm(xmlDocument);
					int num3 = 2;
					while (true)
					{
						int num5;
						switch (num3)
						{
						case 37:
							return;
						case 19:
							throw new Exception((string)W4db9fXvkRxUmJG5Ebi(i6XIkgKLZoQXKXTxcpX(0xD3DEF7E ^ 0xD3DBA7C)));
						case 49:
							if (uetht4Xu67RbMXraJYk(text, i6XIkgKLZoQXKXTxcpX(-1751176224 ^ -1751155058)))
							{
								num3 = 61;
								continue;
							}
							goto default;
						case 32:
							if (!uetht4Xu67RbMXraJYk(text, i6XIkgKLZoQXKXTxcpX(0x53CACA3 ^ 0x53CF971)))
							{
								num3 = 7;
								continue;
							}
							goto case 5;
						case 17:
							if (!uetht4Xu67RbMXraJYk(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195593063)))
							{
								num3 = 64;
								continue;
							}
							goto case 58;
						case 24:
							if (num4 > 750979128)
							{
								num3 = 29;
								continue;
							}
							goto case 27;
						case 43:
							if (!uetht4Xu67RbMXraJYk(text, i6XIkgKLZoQXKXTxcpX(-1921202237 ^ -1921188059)))
							{
								num3 = 45;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
								{
									num3 = 10;
								}
								continue;
							}
							break;
						case 2:
						case 13:
							if (xmlNode == null)
							{
								num3 = 52;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 32;
								}
								continue;
							}
							goto case 66;
						case 30:
						case 47:
							if (xmlNode2 == null)
							{
								num3 = 37;
								continue;
							}
							goto case 46;
						case 41:
							if (uGRS0BXCRoxCfUpbg3e(bOC8VSXiDC8nM0Ixvj9(qc3sftX8yxhi5hvr5WK(xmlNode2)), ""))
							{
								num3 = 53;
								continue;
							}
							goto case 10;
						case 54:
							if (num4 != 4132699186u)
							{
								num3 = 34;
								continue;
							}
							goto case 56;
						case 25:
							num4 = oqEac0XZIewFDnbONGm(text);
							num3 = 39;
							continue;
						case 9:
							if (num4 != 3804576966u)
							{
								num3 = 55;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 49;
								}
								continue;
							}
							goto case 35;
						case 11:
							if (!(text == (string)i6XIkgKLZoQXKXTxcpX(0x3CE17B75 ^ 0x3CE12E9F)))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 23;
						case 42:
							if (num4 != 750979128)
							{
								num3 = 51;
								continue;
							}
							goto case 40;
						case 65:
							UseExceptions = fa98qXXqvrZSC2j9YEm(qc3sftX8yxhi5hvr5WK(xmlNode2));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num3 = 0;
							}
							continue;
						case 66:
							if (!uGRS0BXCRoxCfUpbg3e(F8VcC3XQIV2xNSdPAC8(xmlNode), i6XIkgKLZoQXKXTxcpX(-488881205 ^ -488892637)))
							{
								num3 = 62;
								continue;
							}
							goto case 20;
						case 53:
							Password = (string)NTA28lXR5sFeTcZGvuU(xmlNode2.InnerText);
							num3 = 28;
							continue;
						case 39:
							if (num4 > 2620727545u)
							{
								num3 = 38;
								continue;
							}
							goto case 24;
						case 31:
							if (num4 != 3512062061u)
							{
								num3 = 9;
								continue;
							}
							goto case 43;
						default:
							xmlNode2 = (XmlNode)DYYlBSXKd6Bx1QLjR5s(xmlNode2);
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num3 = 47;
							}
							continue;
						case 27:
							if (num4 != 106918010)
							{
								num3 = 36;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
								{
									num3 = 42;
								}
								continue;
							}
							goto case 11;
						case 57:
							if (num4 != 2620727545u)
							{
								num3 = 33;
								continue;
							}
							goto case 17;
						case 20:
							xmlNode = xmlNode.NextSibling;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
							{
								num3 = 13;
							}
							continue;
						case 23:
							Expect100Сontinue = fa98qXXqvrZSC2j9YEm(qc3sftX8yxhi5hvr5WK(xmlNode2));
							num3 = 8;
							continue;
						case 58:
							UserName = (string)qc3sftX8yxhi5hvr5WK(xmlNode2);
							num3 = 63;
							continue;
						case 56:
							if (!(text == (string)i6XIkgKLZoQXKXTxcpX(-1334993905 ^ -1334982213)))
							{
								num5 = 18;
								goto IL_0054;
							}
							goto case 65;
						case 5:
							Exceptions = (string)qc3sftX8yxhi5hvr5WK(xmlNode2);
							num3 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num3 = 14;
							}
							continue;
						case 46:
							if (qc3sftX8yxhi5hvr5WK(xmlNode2) != null)
							{
								num3 = 22;
								continue;
							}
							goto default;
						case 15:
						case 38:
							if (num4 > 3804576966u)
							{
								num5 = 60;
								goto IL_0054;
							}
							goto case 31;
						case 52:
						case 62:
							if (xmlNode != null)
							{
								xmlNode2 = (XmlNode)sNnJ6GXf5Dde5SMMmUm(xmlNode);
								num3 = 30;
								continue;
							}
							num3 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num3 = 10;
							}
							continue;
						case 12:
						case 61:
							Address = (string)qc3sftX8yxhi5hvr5WK(xmlNode2);
							num3 = 48;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num3 = 16;
							}
							continue;
						case 44:
							Port = CVPHPnXSfFXLG4XNEiV(xmlNode2.InnerText);
							num3 = 26;
							continue;
						case 36:
						case 60:
							if (num4 != 4091627583u)
							{
								num3 = 54;
								continue;
							}
							goto case 32;
						case 10:
							Password = "";
							num3 = 3;
							continue;
						case 6:
						case 29:
							if (num4 != 1879400691)
							{
								num3 = 57;
								continue;
							}
							goto case 49;
						case 40:
							if (!(text == (string)i6XIkgKLZoQXKXTxcpX(0x1A33FE36 ^ 0x1A33AB96)))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 41;
						case 35:
							if (!uetht4Xu67RbMXraJYk(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138171400)))
							{
								num3 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num3 = 21;
								}
								continue;
							}
							goto case 44;
						case 22:
							text = (string)F8VcC3XQIV2xNSdPAC8(xmlNode2);
							num3 = 25;
							continue;
						case 16:
							break;
							IL_0054:
							num3 = num5;
							continue;
						}
						Type = (ProxyType)g7vJJvXVMgE4wFatpd5(tkVsUXXI2mDFciihQQs(typeof(ProxyType).TypeHandle), xmlNode2.InnerText);
						num3 = 50;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 46;
						}
					}
				}
				catch (Exception exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							return;
						}
						Logger.Log.Error(i6XIkgKLZoQXKXTxcpX(-1822890472 ^ -1822904312), exception);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num6 = 1;
						}
					}
				}
			case 3:
				if (!O1qfaCXG8NeZuQNR9rB(ConfigFileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 0:
				return;
			case 4:
				LoadDefault();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			}
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
				return;
			case 0:
				return;
			case 1:
			{
				XmlDocument xmlDocument = new XmlDocument();
				if (O1qfaCXG8NeZuQNR9rB(ConfigFileName))
				{
					EytpswXX8IcuDGXeBVT(ConfigFileName);
				}
				XmlDeclaration xmlDeclaration = (XmlDeclaration)KBge4qXTI800W5igJV3(xmlDocument, i6XIkgKLZoQXKXTxcpX(0x1A33FE36 ^ 0x1A33A802), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812044688), null);
				yHQQqEXkQ9f0hdjk661(xmlDocument, xmlDeclaration);
				XmlElement xmlElement = xmlDocument.CreateElement((string)i6XIkgKLZoQXKXTxcpX(0x2ACE37D ^ 0x2ACB795));
				yHQQqEXkQ9f0hdjk661(xmlDocument, xmlElement);
				XmlNode xmlNode = xmlDocument.CreateElement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477145796));
				xmlNode.InnerText = Type.ToString();
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				xmlNode = (XmlNode)VL2Y08XnENwU1Oj2GGa(xmlDocument, i6XIkgKLZoQXKXTxcpX(0x1637C429 ^ 0x16379147));
				AHoY1qXObhO87CSqd6Q(xmlNode, Address);
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				xmlNode = (XmlNode)VL2Y08XnENwU1Oj2GGa(xmlDocument, i6XIkgKLZoQXKXTxcpX(-1852837372 ^ -1852856444));
				AHoY1qXObhO87CSqd6Q(xmlNode, Port.ToString());
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				xmlNode = (XmlNode)VL2Y08XnENwU1Oj2GGa(xmlDocument, i6XIkgKLZoQXKXTxcpX(0x3C5338FF ^ 0x3C536D73));
				xmlNode.InnerText = UserName;
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				xmlNode = xmlDocument.CreateElement((string)i6XIkgKLZoQXKXTxcpX(-2107978722 ^ -2107991618));
				AHoY1qXObhO87CSqd6Q(xmlNode, (!v1iYXBX2Q7URvEoUWh7(Password)) ? TW35l5XedWThrAKQIQv(Password) : "");
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				xmlNode = (XmlNode)VL2Y08XnENwU1Oj2GGa(xmlDocument, i6XIkgKLZoQXKXTxcpX(-882126494 ^ -882146090));
				AHoY1qXObhO87CSqd6Q(xmlNode, UseExceptions.ToString());
				xmlElement.AppendChild(xmlNode);
				xmlNode = (XmlNode)VL2Y08XnENwU1Oj2GGa(xmlDocument, i6XIkgKLZoQXKXTxcpX(0x7EC153F ^ 0x7EC40ED));
				AHoY1qXObhO87CSqd6Q(xmlNode, Exceptions);
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				xmlNode = (XmlNode)VL2Y08XnENwU1Oj2GGa(xmlDocument, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629866296));
				AHoY1qXObhO87CSqd6Q(xmlNode, Expect100Сontinue.ToString());
				yHQQqEXkQ9f0hdjk661(xmlElement, xmlNode);
				l5g1C9XPpg2HX7PpIaW(xmlDocument, ConfigFileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public IWebProxy GenerateProxy()
	{
		//Discarded unreachable code: IL_0112, IL_0133, IL_0142, IL_016a, IL_0358, IL_0367
		int num = 3;
		WebProxy webProxy = default(WebProxy);
		NetworkCredential networkCredential = default(NetworkCredential);
		List<string> list = default(List<string>);
		ProxyType type = default(ProxyType);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					GuQm7yXH60mbr9qGnLd(webProxy, networkCredential);
					num2 = 18;
					continue;
				case 10:
					sXY0chXtmMYPwtUNGfA(webProxy, PGtdWuXDadiS9dIMWnu(list));
					num2 = 17;
					continue;
				case 3:
					break;
				case 21:
					networkCredential = new NetworkCredential();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
					return webProxy;
				case 19:
					return null;
				case 2:
					if (type != ProxyType.UseDefault)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 17:
					GDFHDNXwX8Ekoq8IKhj(webProxy, false);
					num2 = 21;
					continue;
				case 11:
				case 14:
				case 20:
					if (num3 < list.Count)
					{
						num2 = 7;
						continue;
					}
					goto case 23;
				case 24:
					FC6hvtXpXnt0YRoBTR8(list, num3);
					num2 = 20;
					continue;
				case 22:
					if (Exceptions != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				case 13:
					webProxy.BypassProxyOnLocal = UseExceptions;
					num2 = 22;
					continue;
				case 9:
				case 25:
					num3++;
					num2 = 14;
					continue;
				case 18:
					eF9ssvXAhjQLU5MXP4l(Expect100Сontinue);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 14;
					}
					continue;
				default:
					return defaultProxy;
				case 1:
					list = new List<string>((IEnumerable<string>)DG1mJJXNx0uMHPtRYCo(Exceptions, vqxyZXX1Njc9vSKvUus(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE38955)), StringSplitOptions.RemoveEmptyEntries));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					bdy6WdX6IGOTc1QkY6h(networkCredential, Password);
					num2 = 8;
					continue;
				case 15:
					v1p7oxX42eLTcswc3Eb(networkCredential, UserName);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
				case 12:
					if (!p5cQOsX3vliWkgOCKC9(list[num3].Trim((char[])vqxyZXX1Njc9vSKvUus(i6XIkgKLZoQXKXTxcpX(-1886646897 ^ -1886626877))), string.Empty))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 24;
				case 23:
					if (iFh92JXaOJim7hg2HwJ(list) > 0)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 17;
				case 5:
					num3 = 0;
					num2 = 11;
					continue;
				case 6:
					if (type == ProxyType.Custom)
					{
						webProxy = new WebProxy(Address, Port);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 13;
						}
					}
					else
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 19;
						}
					}
					continue;
				}
				break;
			}
			type = Type;
			num = 2;
		}
	}

	internal static void B0H8SbKgZK7XHgfNGWO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object wsJmSMK5UBVD9VtHZrk()
	{
		return WebRequest.DefaultWebProxy;
	}

	internal static bool E7sRbuKl2ZZD0Zb0ZpZ()
	{
		return bUTo2NKdxP4egvGv9ON == null;
	}

	internal static ProxySettings nqXkW5KrB0vWw7LhLFS()
	{
		return bUTo2NKdxP4egvGv9ON;
	}

	internal static object M32ZRnKjLu5L14icTna()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object EyJj4BKYnHF9bnLojOI(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object i6XIkgKLZoQXKXTxcpX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object UQkDwiKU2GVAj1Cblba(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object G1MmsoKsUGKLPIZsVRt(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object snoVPJKciiDBxelO0Yh(object P_0)
	{
		return ((WebProxy)P_0).Address;
	}

	internal static bool xmCMKMKzv0FdC6pkC02(object P_0, object P_1)
	{
		return (Uri)P_0 != (Uri)P_1;
	}

	internal static object QvpWnpXF1yJpCrJJE5W(object P_0)
	{
		return ((Uri)P_0).Host;
	}

	internal static int y3IdMFXBDghCV23fjxI(object P_0)
	{
		return ((Uri)P_0).Port;
	}

	internal static bool qsEfJRXWlLcTJAJy7Ig(object P_0)
	{
		return ((WebProxy)P_0).BypassProxyOnLocal;
	}

	internal static object lSuEF4XoQFSYG5WoB9s(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object C7xsSyXb8S0QDZh9wFX(object P_0)
	{
		return ((WebProxy)P_0).BypassList;
	}

	internal static object coLGJyXh3ocxUkmbidi(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool O1qfaCXG8NeZuQNR9rB(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void Kgio1LXEImOBXSw6Ttl(object P_0, object P_1)
	{
		((XmlDocument)P_0).Load((string)P_1);
	}

	internal static object sNnJ6GXf5Dde5SMMmUm(object P_0)
	{
		return ((XmlNode)P_0).FirstChild;
	}

	internal static object F8VcC3XQIV2xNSdPAC8(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static bool uGRS0BXCRoxCfUpbg3e(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object W4db9fXvkRxUmJG5Ebi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object qc3sftX8yxhi5hvr5WK(object P_0)
	{
		return ((XmlNode)P_0).InnerText;
	}

	internal static uint oqEac0XZIewFDnbONGm(object P_0)
	{
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool uetht4Xu67RbMXraJYk(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type tkVsUXXI2mDFciihQQs(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static object g7vJJvXVMgE4wFatpd5(Type P_0, object P_1)
	{
		return Enum.Parse(P_0, (string)P_1);
	}

	internal static int CVPHPnXSfFXLG4XNEiV(object P_0)
	{
		return int.Parse((string)P_0);
	}

	internal static object bOC8VSXiDC8nM0Ixvj9(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object NTA28lXR5sFeTcZGvuU(object P_0)
	{
		return EncryptionHelper.DecryptPwd((string)P_0);
	}

	internal static bool fa98qXXqvrZSC2j9YEm(object P_0)
	{
		return Convert.ToBoolean((string)P_0);
	}

	internal static object DYYlBSXKd6Bx1QLjR5s(object P_0)
	{
		return ((XmlNode)P_0).NextSibling;
	}

	internal static void EytpswXX8IcuDGXeBVT(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object KBge4qXTI800W5igJV3(object P_0, object P_1, object P_2, object P_3)
	{
		return ((XmlDocument)P_0).CreateXmlDeclaration((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object yHQQqEXkQ9f0hdjk661(object P_0, object P_1)
	{
		return ((XmlNode)P_0).AppendChild((XmlNode)P_1);
	}

	internal static object VL2Y08XnENwU1Oj2GGa(object P_0, object P_1)
	{
		return ((XmlDocument)P_0).CreateElement((string)P_1);
	}

	internal static void AHoY1qXObhO87CSqd6Q(object P_0, object P_1)
	{
		((XmlNode)P_0).InnerText = (string)P_1;
	}

	internal static bool v1iYXBX2Q7URvEoUWh7(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object TW35l5XedWThrAKQIQv(object P_0)
	{
		return EncryptionHelper.EncryptPwd((string)P_0);
	}

	internal static void l5g1C9XPpg2HX7PpIaW(object P_0, object P_1)
	{
		((XmlDocument)P_0).Save((string)P_1);
	}

	internal static object vqxyZXX1Njc9vSKvUus(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object DG1mJJXNx0uMHPtRYCo(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static bool p5cQOsX3vliWkgOCKC9(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static void FC6hvtXpXnt0YRoBTR8(object P_0, int P_1)
	{
		((List<string>)P_0).RemoveAt(P_1);
	}

	internal static int iFh92JXaOJim7hg2HwJ(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object PGtdWuXDadiS9dIMWnu(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static void sXY0chXtmMYPwtUNGfA(object P_0, object P_1)
	{
		((WebProxy)P_0).BypassList = (string[])P_1;
	}

	internal static void GDFHDNXwX8Ekoq8IKhj(object P_0, bool P_1)
	{
		((WebProxy)P_0).UseDefaultCredentials = P_1;
	}

	internal static void v1p7oxX42eLTcswc3Eb(object P_0, object P_1)
	{
		((NetworkCredential)P_0).UserName = (string)P_1;
	}

	internal static void bdy6WdX6IGOTc1QkY6h(object P_0, object P_1)
	{
		((NetworkCredential)P_0).Password = (string)P_1;
	}

	internal static void GuQm7yXH60mbr9qGnLd(object P_0, object P_1)
	{
		((WebProxy)P_0).Credentials = (ICredentials)P_1;
	}

	internal static void eF9ssvXAhjQLU5MXP4l(bool P_0)
	{
		ServicePointManager.Expect100Continue = P_0;
	}
}
