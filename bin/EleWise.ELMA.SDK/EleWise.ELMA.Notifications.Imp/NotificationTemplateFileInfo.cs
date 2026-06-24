using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationTemplateFileInfo
{
	private NotificationTemplateLoader loader;

	private string name;

	private XmlDocument document;

	private XmlNode root;

	private List<NotificationTemplate> templates;

	private List<NotificationTemplate> defaultTemplates;

	private List<NotificationPartialTemplate> partials;

	private List<NotificationPartialExtensionTemplate> extensionTemplates;

	private Version version;

	private List<CustomMessage> customMessages;

	internal static NotificationTemplateFileInfo p9YlqMwXIwjxnXwuKZ5;

	public NotificationTemplateLoader Loader => loader;

	public string Name => name;

	public XmlDocument Document => document;

	public Version Version
	{
		get
		{
			return version;
		}
		set
		{
			//Discarded unreachable code: IL_00ad, IL_00bc
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					LaDpmdwDTuMLX939wKf((XmlElement)root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D7D87), value.ToString());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					version = value;
					num2 = 3;
					break;
				case 0:
					return;
				case 2:
					return;
				case 3:
					if (root == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 1;
				}
			}
		}
	}

	public string DefaultName
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultName_003Ek__BackingField;
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
					_003CDefaultName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<NotificationTemplate> Templates => templates;

	public IEnumerable<NotificationTemplate> DefaultTemplates => defaultTemplates;

	public IEnumerable<NotificationPartialExtensionTemplate> ExtensionTemplates => extensionTemplates;

	public IEnumerable<NotificationPartialTemplate> Partials => partials;

	public IEnumerable<CustomMessage> CustomMessages => customMessages;

	public NotificationTemplateFileInfo(string name, XmlDocument document)
	{
		//Discarded unreachable code: IL_001a, IL_007e, IL_008d, IL_00dd, IL_0191, IL_0206, IL_0272, IL_0281
		IqvZ1hwnU3GJuNHnNeW();
		base._002Ector();
		int num = 17;
		string text = default(string);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				this.name = name;
				num2 = 7;
				goto IL_001f;
			case 16:
				if (R8sYQuwa849IwgYL247(text))
				{
					num = 11;
					continue;
				}
				goto case 6;
			case 5:
			case 8:
				if (root != null)
				{
					num = 2;
					continue;
				}
				goto case 3;
			case 14:
				return;
			case 4:
				throw new Exception((string)cPrr6Tw2cS9f9Bbv8oo(0x2A7797B7 ^ 0x2A771C41));
			case 15:
				if (EywJe6w34y5o8qyECtB(TEqe2fwNs33OmiKKm7e(root), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099717341)) == null)
				{
					num = 14;
					continue;
				}
				break;
			case 13:
				root = document.FirstChild;
				num2 = 8;
				goto IL_001f;
			case 9:
				nT8vvnwOj8Ic6cZ1dOy(document, cPrr6Tw2cS9f9Bbv8oo(0x269E5FCA ^ 0x269ED40E));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 1;
				}
				continue;
			case 11:
				return;
			case 12:
				return;
			case 7:
				this.document = document;
				num = 13;
				continue;
			case 17:
				nT8vvnwOj8Ic6cZ1dOy(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F56AA0));
				num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 8;
				}
				continue;
			default:
				root = (XmlNode)Y4lAexweILcKq3aI85K(root);
				num = 5;
				continue;
			case 3:
				if (root != null)
				{
					num = 15;
					continue;
				}
				goto case 4;
			case 2:
				if (utJJkww1HSRU0FTRmwJ(((string)JZ7DRWwPIEyFxjePSbc(root)).ToUpper(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767755229)))
				{
					num = 10;
					continue;
				}
				goto case 3;
			case 6:
				Version.TryParse(text, out version);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 12;
				}
				continue;
			case 18:
				break;
				IL_001f:
				num = num2;
				continue;
			}
			text = (string)KO3SOxwpqsFsWtDyWZd(((XmlAttributeCollection)TEqe2fwNs33OmiKKm7e(root))[(string)cPrr6Tw2cS9f9Bbv8oo(0x3A5D5EF ^ 0x3A5599B)]);
			num = 16;
		}
	}

	public void LoadTemplates(NotificationTemplateLoader loader)
	{
		//Discarded unreachable code: IL_010d, IL_011c, IL_0179, IL_018c, IL_01f2, IL_0201, IL_0262, IL_0271, IL_0469, IL_0478, IL_0487, IL_0497, IL_04a6, IL_0550, IL_0584, IL_05ed, IL_0733, IL_0762, IL_0771, IL_0782, IL_07e0, IL_07ef, IL_085e, IL_08a6, IL_08b9
		int num = 3;
		NotificationTemplate item = default(NotificationTemplate);
		XmlElement xmlElement = default(XmlElement);
		string text = default(string);
		string text3 = default(string);
		string text2 = default(string);
		XmlNode xmlNode = default(XmlNode);
		string text5 = default(string);
		NotificationTemplate item2 = default(NotificationTemplate);
		string[] source = default(string[]);
		string text4 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string[] array;
				object obj2;
				object obj;
				switch (num2)
				{
				case 4:
				case 28:
					item = new NotificationTemplate(this, xmlElement);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 6;
					}
					continue;
				case 32:
				{
					List<NotificationPartialTemplate> list2 = partials;
					NotificationPartialTemplate notificationPartialTemplate = new NotificationPartialTemplate();
					SBoQIUw6bMRrfaHm4lc(notificationPartialTemplate, text);
					We1dowwHJ2kcrFEiRXq(notificationPartialTemplate, text3);
					list2.Add(notificationPartialTemplate);
					num2 = 38;
					continue;
				}
				case 24:
					if (!xTtyqSwwRhSxOeHirb3(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97936148)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 44;
				case 20:
					if (xmlElement != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 17;
				case 31:
					if (!xTtyqSwwRhSxOeHirb3(iODRKGwtXA02rIJDXCn(((XmlAttributeCollection)TEqe2fwNs33OmiKKm7e(xmlNode))[(string)cPrr6Tw2cS9f9Bbv8oo(-234299632 ^ -234335734)].Value), cPrr6Tw2cS9f9Bbv8oo(-289714582 ^ -289713052)))
					{
						num2 = 50;
						continue;
					}
					goto case 4;
				case 37:
				case 51:
					xmlElement = xmlNode as XmlElement;
					num2 = 20;
					continue;
				case 53:
					if (text5 == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					array = (from s in (IEnumerable<string>)k6ZS7mw7b7S4pbclfSX(text5, eRaw0JwATdpbejsXXPU(cPrr6Tw2cS9f9Bbv8oo(0x7C1EE318 ^ 0x7C1EB7C4)))
						select (string)_003C_003Ec.UbVOEdfldvvRUXlMlTHC(s, _003C_003Ec.CIr1uUfl9pykKDMfyVwH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A98A4D))) into s
						where s != ""
						select s).ToArray();
					goto IL_09b7;
				case 36:
					defaultTemplates.Add(item2);
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 33;
					}
					continue;
				case 11:
					xmlNode = root.FirstChild;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 55;
					}
					continue;
				case 48:
					templates = new List<NotificationTemplate>();
					num2 = 19;
					continue;
				case 49:
					extensionTemplates.Add(new NotificationPartialExtensionTemplate
					{
						Zones = source.ToList(),
						Content = text4
					});
					num2 = 26;
					continue;
				case 22:
					if (string.IsNullOrEmpty(text3))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 32;
				case 2:
					this.loader = loader;
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 9;
					}
					continue;
				case 13:
					return;
				case 3:
					nT8vvnwOj8Ic6cZ1dOy(loader, cPrr6Tw2cS9f9Bbv8oo(-606654180 ^ -606618214));
					num2 = 2;
					continue;
				case 18:
				case 35:
					if (EywJe6w34y5o8qyECtB(xmlNode.Attributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740304690)) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 31;
				case 43:
					defaultTemplates = new List<NotificationTemplate>();
					num = 42;
					break;
				case 30:
					DefaultName = (string)KO3SOxwpqsFsWtDyWZd(EywJe6w34y5o8qyECtB(TEqe2fwNs33OmiKKm7e(root), cPrr6Tw2cS9f9Bbv8oo(-29254301 ^ -29289995)));
					num2 = 11;
					continue;
				case 16:
					if (EywJe6w34y5o8qyECtB(TEqe2fwNs33OmiKKm7e(xmlNode), cPrr6Tw2cS9f9Bbv8oo(0x42643203 ^ 0x4264BF2F)) == null)
					{
						num2 = 41;
						continue;
					}
					obj2 = KO3SOxwpqsFsWtDyWZd(EywJe6w34y5o8qyECtB(TEqe2fwNs33OmiKKm7e(xmlNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F5EB9A)));
					goto IL_0928;
				case 7:
					if (R8sYQuwa849IwgYL247(text4))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 49;
				case 21:
					if (text2 == (string)cPrr6Tw2cS9f9Bbv8oo(0x1A33FE36 ^ 0x1A337838))
					{
						num2 = 35;
						continue;
					}
					goto case 24;
				case 10:
					text3 = (string)z2o3Bkw4B7qoQ9X274T(xmlNode);
					num2 = 58;
					continue;
				case 23:
					if (EywJe6w34y5o8qyECtB(TEqe2fwNs33OmiKKm7e(root), cPrr6Tw2cS9f9Bbv8oo(-672123589 ^ -672089683)) != null)
					{
						num2 = 30;
						continue;
					}
					goto case 11;
				case 42:
					customMessages = new List<CustomMessage>();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 23;
					}
					continue;
				case 9:
				case 34:
					if (xmlNode.Attributes[(string)cPrr6Tw2cS9f9Bbv8oo(-1426094279 ^ -1426126333)] == null)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 29;
				case 47:
					text4 = (string)z2o3Bkw4B7qoQ9X274T(xmlNode);
					num2 = 7;
					continue;
				case 5:
					array = new string[0];
					goto IL_09b7;
				case 29:
				{
					List<CustomMessage> list = customMessages;
					CustomMessage obj3 = new CustomMessage
					{
						Key = new Pair<string, string>(((XmlNode)EywJe6w34y5o8qyECtB(xmlNode.Attributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583774770))).Value, ((XmlNode)QOcmk5wxk856tFpw8o2(xmlNode)).Attributes[(string)cPrr6Tw2cS9f9Bbv8oo(-70007027 ^ -70011699)].Value)
					};
					HCy2uLw0DwQNUh0eId9(obj3, ((XmlNode)QOcmk5wxk856tFpw8o2(xmlNode)).InnerText);
					list.Add(obj3);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 54:
					if (!(text2 == (string)cPrr6Tw2cS9f9Bbv8oo(-643786247 ^ -643820279)))
					{
						goto case 1;
					}
					num2 = 9;
					continue;
				case 17:
					xmlNode = (XmlNode)Y4lAexweILcKq3aI85K(xmlNode);
					num2 = 12;
					continue;
				case 12:
				case 55:
				case 56:
					if (xmlNode == null)
					{
						return;
					}
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 51;
					}
					continue;
				case 25:
					if (!xTtyqSwwRhSxOeHirb3(text2, cPrr6Tw2cS9f9Bbv8oo(-398663332 ^ -398692976)))
					{
						num2 = 54;
						continue;
					}
					goto case 16;
				case 14:
					if (!xTtyqSwwRhSxOeHirb3(text2, cPrr6Tw2cS9f9Bbv8oo(0x12441CA4 ^ 0x1244900C)))
					{
						num2 = 21;
						continue;
					}
					goto case 39;
				case 41:
					obj2 = null;
					goto IL_0928;
				case 19:
					extensionTemplates = new List<NotificationPartialExtensionTemplate>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				case 45:
					obj = null;
					goto IL_08e5;
				case 6:
					templates.Add(item);
					num2 = 40;
					continue;
				case 46:
				case 57:
					text2 = (string)iODRKGwtXA02rIJDXCn(JZ7DRWwPIEyFxjePSbc(xmlElement));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					partials = new List<NotificationPartialTemplate>();
					num2 = 43;
					continue;
				case 39:
					item2 = new NotificationTemplate(this, xmlElement);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 29;
					}
					continue;
				case 44:
					if (((XmlAttributeCollection)TEqe2fwNs33OmiKKm7e(xmlNode))[(string)cPrr6Tw2cS9f9Bbv8oo(0xE1229CF ^ 0xE125A0F)] == null)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 45;
						}
						continue;
					}
					obj = KO3SOxwpqsFsWtDyWZd(EywJe6w34y5o8qyECtB(xmlNode.Attributes, cPrr6Tw2cS9f9Bbv8oo(-16752921 ^ -16765657)));
					goto IL_08e5;
				case 1:
				case 8:
				case 15:
				case 26:
				case 27:
				case 33:
				case 38:
				case 40:
				case 50:
				case 52:
					xmlNode = (XmlNode)Y4lAexweILcKq3aI85K(xmlNode);
					num2 = 56;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 33;
					}
					continue;
				case 58:
					{
						if (!R8sYQuwa849IwgYL247(text))
						{
							num2 = 22;
							continue;
						}
						goto case 1;
					}
					IL_08e5:
					text = (string)obj;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 8;
					}
					continue;
					IL_09b7:
					source = array;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 47;
					}
					continue;
					IL_0928:
					text5 = (string)obj2;
					num = 53;
					break;
				}
				break;
			}
		}
	}

	internal static void IqvZ1hwnU3GJuNHnNeW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void nT8vvnwOj8Ic6cZ1dOy(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object cPrr6Tw2cS9f9Bbv8oo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Y4lAexweILcKq3aI85K(object P_0)
	{
		return ((XmlNode)P_0).NextSibling;
	}

	internal static object JZ7DRWwPIEyFxjePSbc(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static bool utJJkww1HSRU0FTRmwJ(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object TEqe2fwNs33OmiKKm7e(object P_0)
	{
		return ((XmlNode)P_0).Attributes;
	}

	internal static object EywJe6w34y5o8qyECtB(object P_0, object P_1)
	{
		return ((XmlAttributeCollection)P_0)[(string)P_1];
	}

	internal static object KO3SOxwpqsFsWtDyWZd(object P_0)
	{
		return ((XmlNode)P_0).Value;
	}

	internal static bool R8sYQuwa849IwgYL247(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool rEmh9pwTq1IsTBeBjXY()
	{
		return p9YlqMwXIwjxnXwuKZ5 == null;
	}

	internal static NotificationTemplateFileInfo OH34OVwk1XwouHxh0DY()
	{
		return p9YlqMwXIwjxnXwuKZ5;
	}

	internal static void LaDpmdwDTuMLX939wKf(object P_0, object P_1, object P_2)
	{
		((XmlElement)P_0).SetAttribute((string)P_1, (string)P_2);
	}

	internal static object iODRKGwtXA02rIJDXCn(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool xTtyqSwwRhSxOeHirb3(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object z2o3Bkw4B7qoQ9X274T(object P_0)
	{
		return NotificationTemplate.GetContentAndTrim((XmlNode)P_0);
	}

	internal static void SBoQIUw6bMRrfaHm4lc(object P_0, object P_1)
	{
		((NotificationPartialTemplate)P_0).Name = (string)P_1;
	}

	internal static void We1dowwHJ2kcrFEiRXq(object P_0, object P_1)
	{
		((NotificationPartialTemplate)P_0).Content = (string)P_1;
	}

	internal static object eRaw0JwATdpbejsXXPU(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object k6ZS7mw7b7S4pbclfSX(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object QOcmk5wxk856tFpw8o2(object P_0)
	{
		return ((XmlNode)P_0).FirstChild;
	}

	internal static void HCy2uLw0DwQNUh0eId9(object P_0, object P_1)
	{
		((CustomMessage)P_0).Content = (string)P_1;
	}
}
