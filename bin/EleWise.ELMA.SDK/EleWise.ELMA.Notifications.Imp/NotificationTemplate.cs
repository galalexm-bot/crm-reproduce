using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using EleWise.ELMA.Messaging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationTemplate : NotificationTemplateBase
{
	private readonly NotificationTemplateFileInfo fileInfo;

	private readonly string name;

	private readonly string parentName;

	private readonly string defaultName;

	private bool defaultLoaded;

	private NotificationTemplate @default;

	private readonly NotificationTemplateFilter filter;

	private readonly string channels;

	private readonly List<NotificationRecipientSet> recipientSets;

	private readonly bool? recipientSetsClear;

	private readonly string url;

	private readonly string subject;

	private readonly string author;

	private readonly NotificationTemplateFilterCondition authorOverrideCondition;

	private readonly string shortMessage;

	private readonly NotificationTemplateFilterCondition shortMessageOverrideCondition;

	private readonly string fullMessage;

	private readonly NotificationTemplateFilterCondition fullMessageOverrideCondition;

	private readonly NotificationTemplateObject objectTemplate;

	private readonly NotificationTemplateFilterCondition sendToAuthorCondition;

	private readonly NotificationTemplateFilterCondition subjectOverrideCondition;

	private CustomMessage[] customMessages;

	private static NotificationTemplate pWHfCG6vgsOMj2LAVxi;

	public override NotificationTemplateFileInfo FileInfo => fileInfo;

	public override string Name => name;

	public string ParentName => parentName;

	public NotificationTemplate Default
	{
		get
		{
			//Discarded unreachable code: IL_00d9, IL_00e8
			int num = 2;
			string text = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					default:
						goto end_IL_0012;
					case 2:
						if (!defaultLoaded)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 3;
					case 6:
						defaultLoaded = true;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 3;
						}
						continue;
					case 1:
						if (!(defaultName == string.Empty))
						{
							num2 = 5;
							continue;
						}
						goto case 4;
					case 3:
						return @default;
					case 4:
						return null;
					case 5:
						obj = defaultName;
						if (obj != null)
						{
							break;
						}
						num2 = 7;
						continue;
					case 7:
						obj = u5wFYi6uInyKWCPklIB(fileInfo);
						break;
					}
					text = (string)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				@default = (NotificationTemplate)BaekG26IYe8evL7wF7c(fileInfo.Loader, fileInfo, text);
				num = 6;
			}
		}
	}

	public NotificationTemplateFilter Filter => filter;

	public override string Channels => channels;

	public override NotificationTemplateBase ChannelsTemplateBase => this;

	public override List<NotificationRecipientSet> RecipientSets => recipientSets;

	public override string URL => url;

	public override bool? RecipientSetsClear => recipientSetsClear;

	public override NotificationTemplateBase URLTemplateBase => this;

	public override NotificationTemplateObject ObjectTemplate => objectTemplate;

	public override string GetAuthor(object notificationDataSource)
	{
		return author;
	}

	public override bool IsAuthorOverride(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (authorOverrideCondition == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return authorOverrideCondition.Evaluate(notificationDataSource);
			case 1:
				return false;
			}
		}
	}

	public override NotificationTemplateBase GetAuthorTemplateBase(object notificationDataSource)
	{
		return this;
	}

	public override string GetSubject(object notificationDataSource)
	{
		return subject;
	}

	public override bool IsSubjectOverride(object notificationDataSource)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (subjectOverrideCondition != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return Phh5qK6VoLwye2APyNN(subjectOverrideCondition, notificationDataSource);
			}
		}
	}

	public override NotificationTemplateBase GetSubjectTemplateBase(object notificationDataSource)
	{
		return this;
	}

	public override string GetShortMessage(object notificationDataSource)
	{
		return shortMessage;
	}

	public override bool IsShortMessageOverride(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (shortMessageOverrideCondition == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return Phh5qK6VoLwye2APyNN(shortMessageOverrideCondition, notificationDataSource);
			default:
				return false;
			}
		}
	}

	public override NotificationTemplateBase GetShortMessageTemplateBase(object notificationDataSource)
	{
		return this;
	}

	public override string GetFullMessage(object notificationDataSource)
	{
		return fullMessage;
	}

	public override bool IsFullMessageOverride(object notificationDataSource)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (fullMessageOverrideCondition != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return Phh5qK6VoLwye2APyNN(fullMessageOverrideCondition, notificationDataSource);
			}
		}
	}

	public override NotificationTemplateBase GetFullMessageTemplateBase(object notificationDataSource)
	{
		return this;
	}

	public void SetCustomMessages(CustomMessage[] customMessages)
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
				this.customMessages = customMessages;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override CustomMessage[] GetCustomMessages(object notificationDataSource)
	{
		return customMessages;
	}

	public override NotificationTemplateBase GetCustomMessagesTemplateBase(object notificationDataSource)
	{
		return this;
	}

	public override bool IsSendToAuthor(object notificationDataSource)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return sendToAuthorCondition.Evaluate(notificationDataSource);
			default:
				return false;
			case 1:
				if (sendToAuthorCondition == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override bool CheckFilter(INotification notification)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_00f1, IL_0100, IL_0110, IL_011f
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (FjLGxS6iOGT47xSbnSL(notification.TemplateName, wXoS7N6SFZul9iJZCDJ(this), StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (wXoS7N6SFZul9iJZCDJ(this) == null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 6:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A7711B9));
			case 7:
				if (notification != null)
				{
					if (notification.TemplateName == null)
					{
						num2 = 2;
						break;
					}
					goto case 4;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
			case 3:
				return false;
			default:
				return ckqAyD6R2dCkqtIJBVd(Filter, notification);
			}
		}
	}

	public NotificationTemplate(NotificationTemplateFileInfo fileInfo, XmlElement node)
	{
		//Discarded unreachable code: IL_001a, IL_0212, IL_0221, IL_0230, IL_028c, IL_0377, IL_0449, IL_0458, IL_0468, IL_04b2, IL_059b, IL_05d9, IL_05e8, IL_05f7, IL_0686, IL_0695, IL_06a4, IL_06b4, IL_06eb, IL_06fa, IL_0709, IL_0719, IL_0752, IL_0863, IL_0872, IL_0898, IL_08a7, IL_08b6, IL_08c6, IL_08d5, IL_091c, IL_092b, IL_0977, IL_0986, IL_0a45, IL_0a54, IL_0a64, IL_0aab, IL_0b19, IL_0b69, IL_0b7c, IL_0b8b, IL_0b9b, IL_0c01, IL_0c10, IL_0c77, IL_0cb1, IL_0cc4, IL_0cd3, IL_0d46, IL_0d55, IL_0d65, IL_0d74, IL_0dac, IL_0e30, IL_0e3f, IL_0e61, IL_0eb4, IL_0f09, IL_0f70, IL_0ff8, IL_1030, IL_103f, IL_104e, IL_105d
		q7lFrW6qsNb2usSglRX();
		base._002Ector();
		int num = 99;
		uint num3 = default(uint);
		XmlNode xmlNode = default(XmlNode);
		string text = default(string);
		string text2 = default(string);
		NotificationRecipientSet item = default(NotificationRecipientSet);
		XmlElement xmlElement = default(XmlElement);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 66:
				if (num3 != 1969840958)
				{
					num = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num = 96;
					}
					break;
				}
				goto case 86;
			case 87:
				if (num3 <= 3788036667u)
				{
					num = 98;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num = 27;
					}
					break;
				}
				goto case 12;
			case 71:
				if (uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(0x6A81B9B4 ^ 0x6A8128E4)) == null)
				{
					num = 29;
					break;
				}
				goto case 31;
			case 113:
				if (!ARDVLK616D3WjOshe5D(text, DWl5a36Xr7CtEvgbIZg(0x31326106 ^ 0x3132F16C)))
				{
					num = 75;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num = 85;
					}
					break;
				}
				goto case 52;
			case 63:
				if (ARDVLK616D3WjOshe5D(text, DWl5a36Xr7CtEvgbIZg(0x3A5D5EF ^ 0x3A544CD)))
				{
					num2 = 109;
					goto IL_001f;
				}
				goto default;
			case 112:
				subject = text2;
				num = 71;
				break;
			case 60:
				text2 = (string)KeQr8x6OC2WAo6dVJUV(xmlNode);
				num = 17;
				break;
			case 79:
			case 90:
				recipientSetsClear = Q4hbj763Er8vTrFKXDl(text2);
				num2 = 15;
				goto IL_001f;
			case 69:
				fullMessageOverrideCondition = new NotificationTemplateFilterCondition((string)Vywpw06ktZHyA521CEn(((XmlAttributeCollection)JMwum76K3nshCLQ6ISr(xmlNode))[(string)DWl5a36Xr7CtEvgbIZg(-541731959 ^ -541768999)]));
				num = 61;
				break;
			case 102:
				if (text == (string)DWl5a36Xr7CtEvgbIZg(0x8317432 ^ 0x831E474))
				{
					num = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num = 1;
					}
					break;
				}
				goto default;
			case 119:
				if (uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(node), DWl5a36Xr7CtEvgbIZg(-218496594 ^ -218460872)) == null)
				{
					num = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num = 36;
					}
					break;
				}
				goto case 97;
			case 78:
			case 100:
				if (num3 != 1418384879)
				{
					num = 66;
					break;
				}
				goto case 105;
			case 23:
				if (zPT8sg6paJOpt7MXkKf(Vywpw06ktZHyA521CEn(((XmlAttributeCollection)JMwum76K3nshCLQ6ISr(xmlNode))[(string)DWl5a36Xr7CtEvgbIZg(0x3630F361 ^ 0x36306231)])))
				{
					num = 114;
					break;
				}
				goto case 69;
			case 86:
				if (!(text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889488660)))
				{
					goto default;
				}
				num = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 34;
				}
				break;
			case 34:
			case 108:
				url = text2;
				num = 32;
				break;
			case 101:
				channels = text2;
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num = 24;
				}
				break;
			case 94:
				if (uMyuMZ6TgLRMDT5qQeO(xmlNode.Attributes, DWl5a36Xr7CtEvgbIZg(-105199646 ^ -105228622)) == null)
				{
					num = 8;
					break;
				}
				goto case 92;
			case 38:
				if (((XmlAttributeCollection)JMwum76K3nshCLQ6ISr(node))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998535430)] != null)
				{
					num = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num = 22;
					}
					break;
				}
				goto case 73;
			case 95:
				if (!ARDVLK616D3WjOshe5D(text, DWl5a36Xr7CtEvgbIZg(0x7459E02 ^ 0x7450E54)))
				{
					num2 = 75;
					goto IL_001f;
				}
				goto case 101;
			case 31:
				if (!string.IsNullOrWhiteSpace((string)Vywpw06ktZHyA521CEn(xmlNode.Attributes[(string)DWl5a36Xr7CtEvgbIZg(0x57A5235E ^ 0x57A5B20E)])))
				{
					num = 40;
					break;
				}
				goto default;
			case 70:
				if (!(text == (string)DWl5a36Xr7CtEvgbIZg(-210725949 ^ -210763059)))
				{
					num = 111;
					break;
				}
				goto case 84;
			case 52:
				item = new NotificationRecipientSet(xmlElement);
				num = 62;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 58;
				}
				break;
			case 17:
				text = (string)iZHM9P6e4s1R9IYeFWQ(G5Xirq62iXhfCLnfAqo(xmlNode));
				num = 102;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num = 118;
				}
				break;
			case 56:
				if (ARDVLK616D3WjOshe5D(text, DWl5a36Xr7CtEvgbIZg(-1487388570 ^ -1487351600)))
				{
					num = 93;
					break;
				}
				goto default;
			case 6:
				if (uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(-234299632 ^ -234336704)) == null)
				{
					num2 = 67;
					goto IL_001f;
				}
				goto case 23;
			case 115:
				if (num3 > 931238212)
				{
					num = 100;
					break;
				}
				goto case 37;
			case 83:
				if (zPT8sg6paJOpt7MXkKf(Vywpw06ktZHyA521CEn(uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(-583745292 ^ -583773788)))))
				{
					num = 82;
					break;
				}
				goto case 103;
			case 18:
				if (!(text == (string)DWl5a36Xr7CtEvgbIZg(-542721635 ^ -542758749)))
				{
					num = 81;
					break;
				}
				goto case 64;
			case 92:
				if (zPT8sg6paJOpt7MXkKf(Vywpw06ktZHyA521CEn(uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(0x4DC2B14D ^ 0x4DC2201D)))))
				{
					num = 19;
					break;
				}
				goto case 48;
			case 99:
				this.fileInfo = fileInfo;
				num = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 46;
				}
				break;
			case 39:
				if (num3 != 3788036667u)
				{
					num = 16;
					break;
				}
				goto case 58;
			case 40:
				subjectOverrideCondition = new NotificationTemplateFilterCondition((string)Vywpw06ktZHyA521CEn(uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(-210725949 ^ -210763117))));
				num = 74;
				break;
			case 12:
				if (num3 != 3873537942u)
				{
					num = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num = 47;
					}
					break;
				}
				goto case 56;
			case 98:
				if (num3 != 2374511479u)
				{
					num = 21;
					break;
				}
				goto case 70;
			case 105:
				if (!ARDVLK616D3WjOshe5D(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC85F9)))
				{
					num = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num = 19;
					}
					break;
				}
				goto case 112;
			case 91:
				return;
			case 58:
				if (ARDVLK616D3WjOshe5D(text, DWl5a36Xr7CtEvgbIZg(0x35C0467B ^ 0x35C0D68F)))
				{
					num = 44;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num = 32;
					}
					break;
				}
				goto default;
			case 62:
				recipientSets.Add(item);
				num = 42;
				break;
			case 57:
				if (uMyuMZ6TgLRMDT5qQeO(xmlNode.Attributes, DWl5a36Xr7CtEvgbIZg(0x61EC0CB8 ^ 0x61EC9DE8)) != null)
				{
					num = 83;
					break;
				}
				goto default;
			case 9:
			case 11:
			case 72:
				if (xmlNode == null)
				{
					return;
				}
				num = 45;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 26;
				}
				break;
			case 68:
				sendToAuthorCondition = new NotificationTemplateFilterCondition(text2);
				num = 117;
				break;
			case 41:
			case 45:
				xmlElement = xmlNode as XmlElement;
				num = 30;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			case 103:
				shortMessageOverrideCondition = new NotificationTemplateFilterCondition((string)Vywpw06ktZHyA521CEn(uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(-1459557599 ^ -1459586447))));
				num = 2;
				break;
			case 27:
				parentName = (string)Vywpw06ktZHyA521CEn(uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(node), DWl5a36Xr7CtEvgbIZg(-541731959 ^ -541768769)));
				num = 119;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num = 87;
				}
				break;
			case 55:
				if (num3 != 931238212)
				{
					num2 = 20;
					goto IL_001f;
				}
				goto case 18;
			case 37:
				if (num3 != 290803319)
				{
					num2 = 25;
					goto IL_001f;
				}
				goto case 102;
			case 118:
				num3 = OsAgAt6P9nT0lu4d4c6(text);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 5;
				}
				break;
			case 59:
				xmlNode = xmlNode.NextSibling;
				num = 9;
				break;
			case 35:
				recipientSets = new List<NotificationRecipientSet>();
				num = 38;
				break;
			case 97:
				defaultName = (string)Vywpw06ktZHyA521CEn(uMyuMZ6TgLRMDT5qQeO(node.Attributes, DWl5a36Xr7CtEvgbIZg(0xE1229CF ^ 0xE12A559)));
				num = 4;
				break;
			case 7:
			case 54:
				TiEMn46N8lasLxEawpd(filter, xmlElement);
				num = 76;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 70;
				}
				break;
			case 96:
				if (num3 != 2180989045u)
				{
					num = 106;
					break;
				}
				goto case 95;
			case 30:
				if (xmlElement == null)
				{
					num = 59;
					break;
				}
				goto case 60;
			case 116:
				if (!ARDVLK616D3WjOshe5D(text, DWl5a36Xr7CtEvgbIZg(-629844702 ^ -629815900)))
				{
					goto default;
				}
				num = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num = 90;
				}
				break;
			case 64:
				if (string.IsNullOrWhiteSpace(text2))
				{
					num = 50;
					break;
				}
				goto case 10;
			case 13:
			case 88:
				shortMessage = text2;
				num = 57;
				break;
			case 25:
				if (num3 != 510073957)
				{
					num = 55;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num = 33;
					}
					break;
				}
				goto case 116;
			case 84:
				objectTemplate = new NotificationTemplateObject(xmlElement);
				num = 107;
				break;
			case 44:
			case 51:
				fullMessage = text2;
				num = 6;
				break;
			case 10:
				customMessages = new CustomMessage[0];
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 0;
				}
				break;
			case 93:
			case 110:
				author = text2;
				num = 94;
				break;
			case 73:
				if (((XmlAttributeCollection)JMwum76K3nshCLQ6ISr(node))[(string)DWl5a36Xr7CtEvgbIZg(0x6DC147B0 ^ 0x6DC1D786)] != null)
				{
					num = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num = 11;
					}
					break;
				}
				goto case 119;
			case 22:
				name = ((XmlAttributeCollection)JMwum76K3nshCLQ6ISr(node))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76DA74E)].Value;
				num = 55;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 73;
				}
				break;
			case 48:
				authorOverrideCondition = new NotificationTemplateFilterCondition(((XmlNode)uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(xmlNode), DWl5a36Xr7CtEvgbIZg(0x26FFCB59 ^ 0x26FF5A09))).Value);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num = 77;
				}
				break;
			case 4:
			case 36:
				xmlNode = (XmlNode)FXogur6n5iCuPJMyoZ8(node);
				num = 11;
				break;
			case 65:
			case 109:
				if (string.IsNullOrWhiteSpace(text2))
				{
					num = 43;
					break;
				}
				goto case 68;
			case 5:
				if (num3 <= 2180989045u)
				{
					num = 115;
					break;
				}
				goto case 87;
			case 28:
				if (!ARDVLK616D3WjOshe5D(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767757533)))
				{
					goto default;
				}
				num = 88;
				break;
			case 47:
				if (num3 != 3988852052u)
				{
					num = 89;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num = 21;
					}
					break;
				}
				goto case 28;
			default:
				xmlNode = (XmlNode)Uk5j5H6aLshix5DU1MR(xmlNode);
				num = 72;
				break;
			case 21:
				if (num3 != 2631317565u)
				{
					num = 39;
					break;
				}
				goto case 63;
			case 89:
				if (num3 != 4003449272u)
				{
					num = 53;
					break;
				}
				goto case 113;
			case 46:
				{
					filter = new NotificationTemplateFilter();
					num2 = 35;
					goto IL_001f;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	public static string GetContentAndTrim(XmlNode node)
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_0135, IL_0144, IL_024b, IL_025a, IL_02be, IL_02cd
		int num = 7;
		int num2 = num;
		string text = default(string);
		XmlNodeType nodeType = default(XmlNodeType);
		string[] source = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 18:
				if (node.FirstChild != null)
				{
					num2 = 13;
					break;
				}
				goto case 16;
			case 22:
				return text;
			default:
				if (FjLGxS6iOGT47xSbnSL(((XmlNode)uMyuMZ6TgLRMDT5qQeO(JMwum76K3nshCLQ6ISr(node), DWl5a36Xr7CtEvgbIZg(0xE1229CF ^ 0xE12B8AB))).Value, DWl5a36Xr7CtEvgbIZg(--1333735954 ^ 0x4F7F2808), StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 22;
					break;
				}
				goto IL_00b2;
			case 7:
				if (node == null)
				{
					num2 = 6;
					break;
				}
				goto case 8;
			case 11:
				if (nodeType != XmlNodeType.CDATA)
				{
					num2 = 19;
					break;
				}
				goto case 15;
			case 10:
				if (Ux9OXU6t15wr8cMBf8y(node) != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 17:
				text = (string)Ux9OXU6t15wr8cMBf8y(node);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 20;
				}
				break;
			case 8:
				if (mIl1gV6DunvJj8ljYQ8(node) == null)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			case 6:
			case 9:
				return string.Empty;
			case 5:
				if (r8k5uG6wF1bysJKrCAZ(node.ChildNodes) == 1)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 18;
					}
					break;
				}
				goto case 16;
			case 16:
				text = (string)mIl1gV6DunvJj8ljYQ8(node);
				num2 = 3;
				break;
			case 13:
				nodeType = ((XmlNode)FXogur6n5iCuPJMyoZ8(node)).NodeType;
				num2 = 19;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 21;
				}
				break;
			case 14:
				source = (string[])pPkmQc66st1bIOj8RLC(text, new string[1] { (string)DWl5a36Xr7CtEvgbIZg(0x103FE975 ^ 0x103F8A4B) }, StringSplitOptions.None);
				num2 = 4;
				break;
			case 15:
				text = (string)Ux9OXU6t15wr8cMBf8y(FXogur6n5iCuPJMyoZ8(node));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			case 3:
			case 12:
			case 20:
				if (uMyuMZ6TgLRMDT5qQeO(node.Attributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740309840)) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00b2;
			case 21:
				if (nodeType != XmlNodeType.Text)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 17;
			case 1:
			case 19:
				text = (string)mIl1gV6DunvJj8ljYQ8(node);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 12;
				}
				break;
			case 4:
				{
					return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633489045), source.Select((string s) => (string)_003C_003Ec.tdMx54fr0T5i3odb5RNa(s, _003C_003Ec.M4PUpDfrxivkdA7eH7QE(_003C_003Ec.Q22wZ7fr760fqUsIMjx5(0x5DD55050 ^ 0x5DD5061C)))));
				}
				IL_00b2:
				text = text.Trim((char[])TjU5XS64iOcYJlVKNI2(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852857272)));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 14;
				}
				break;
			}
		}
	}

	internal static object u5wFYi6uInyKWCPklIB(object P_0)
	{
		return ((NotificationTemplateFileInfo)P_0).DefaultName;
	}

	internal static object BaekG26IYe8evL7wF7c(object P_0, object P_1, object P_2)
	{
		return ((NotificationTemplateLoader)P_0).GetDefaultTemplate((NotificationTemplateFileInfo)P_1, (string)P_2);
	}

	internal static bool P3VCxW68A7RExh9iNVN()
	{
		return pWHfCG6vgsOMj2LAVxi == null;
	}

	internal static NotificationTemplate rXqYW06ZHKu5tZxR9WN()
	{
		return pWHfCG6vgsOMj2LAVxi;
	}

	internal static bool Phh5qK6VoLwye2APyNN(object P_0, object P_1)
	{
		return ((NotificationTemplateFilterCondition)P_0).Evaluate(P_1);
	}

	internal static object wXoS7N6SFZul9iJZCDJ(object P_0)
	{
		return ((NotificationTemplateBase)P_0).Name;
	}

	internal static bool FjLGxS6iOGT47xSbnSL(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static bool ckqAyD6R2dCkqtIJBVd(object P_0, object P_1)
	{
		return ((NotificationTemplateFilter)P_0).Check((INotification)P_1);
	}

	internal static void q7lFrW6qsNb2usSglRX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object JMwum76K3nshCLQ6ISr(object P_0)
	{
		return ((XmlNode)P_0).Attributes;
	}

	internal static object DWl5a36Xr7CtEvgbIZg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object uMyuMZ6TgLRMDT5qQeO(object P_0, object P_1)
	{
		return ((XmlAttributeCollection)P_0)[(string)P_1];
	}

	internal static object Vywpw06ktZHyA521CEn(object P_0)
	{
		return ((XmlNode)P_0).Value;
	}

	internal static object FXogur6n5iCuPJMyoZ8(object P_0)
	{
		return ((XmlNode)P_0).FirstChild;
	}

	internal static object KeQr8x6OC2WAo6dVJUV(object P_0)
	{
		return GetContentAndTrim((XmlNode)P_0);
	}

	internal static object G5Xirq62iXhfCLnfAqo(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static object iZHM9P6e4s1R9IYeFWQ(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static uint OsAgAt6P9nT0lu4d4c6(object P_0)
	{
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool ARDVLK616D3WjOshe5D(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void TiEMn46N8lasLxEawpd(object P_0, object P_1)
	{
		((NotificationTemplateFilter)P_0).Parse((XmlElement)P_1);
	}

	internal static bool Q4hbj763Er8vTrFKXDl(object P_0)
	{
		return Convert.ToBoolean((string)P_0);
	}

	internal static bool zPT8sg6paJOpt7MXkKf(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Uk5j5H6aLshix5DU1MR(object P_0)
	{
		return ((XmlNode)P_0).NextSibling;
	}

	internal static object mIl1gV6DunvJj8ljYQ8(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static object Ux9OXU6t15wr8cMBf8y(object P_0)
	{
		return ((XmlNode)P_0).InnerText;
	}

	internal static int r8k5uG6wF1bysJKrCAZ(object P_0)
	{
		return ((XmlNodeList)P_0).Count;
	}

	internal static object TjU5XS64iOcYJlVKNI2(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object pPkmQc66st1bIOj8RLC(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}
}
