using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messaging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationTemplateWrapper : NotificationTemplateBase
{
	private readonly NotificationTemplateBase template;

	private readonly NotificationTemplateBase parent;

	private bool recipientSetsInitialized;

	private List<NotificationRecipientSet> recipientSets;

	internal static NotificationTemplateWrapper gZRb1mDtsCSmFm8tjZh;

	public override NotificationTemplateFileInfo FileInfo => (NotificationTemplateFileInfo)JmVwkXDHQKndQTUo6g0(template);

	public override string Name => (string)aiJOkBDAdnsJDgjbCRg(template);

	public override string Channels
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					if (ChannelsTemplateBase != null)
					{
						return (string)Y6di6bDxNToaNf8qXeW(nnXNfJD7U9V70aZERNU(this));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override NotificationTemplateBase ChannelsTemplateBase
	{
		get
		{
			//Discarded unreachable code: IL_0074, IL_0083, IL_0093
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (Y6di6bDxNToaNf8qXeW(template) != null)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 2:
					if (parent != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 1:
					return parent.ChannelsTemplateBase;
				case 3:
					return (NotificationTemplateBase)nnXNfJD7U9V70aZERNU(template);
				}
			}
		}
	}

	public override List<NotificationRecipientSet> RecipientSets
	{
		get
		{
			if (!recipientSetsInitialized)
			{
				recipientSets = new List<NotificationRecipientSet>();
				if (parent != null && parent.RecipientSets != null)
				{
					recipientSets.AddRange(parent.RecipientSets.Select((NotificationRecipientSet rs) => (NotificationRecipientSet)_003C_003Ec.nhqv26flSLFrfALoZUUb(rs)));
				}
				if (template.RecipientSets != null)
				{
					foreach (NotificationRecipientSet recipientSet in template.RecipientSets)
					{
						_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
						CS_0024_003C_003E8__locals0.recipientSet = recipientSet;
						NotificationRecipientSet notificationRecipientSet = recipientSets.FirstOrDefault((NotificationRecipientSet s) => _003C_003Ec__DisplayClass10_0.uvp30Mfl8YVOMxIw9JRn(_003C_003Ec__DisplayClass10_0.A7OO7DflvJrWTCuGlILw(s), _003C_003Ec__DisplayClass10_0.A7OO7DflvJrWTCuGlILw(CS_0024_003C_003E8__locals0.recipientSet)));
						if (notificationRecipientSet != null && recipientSet.Clear)
						{
							recipientSets.Remove(notificationRecipientSet);
							notificationRecipientSet = null;
						}
						if (notificationRecipientSet == null)
						{
							recipientSets.Add(recipientSet.Clone());
						}
						else
						{
							notificationRecipientSet.Items.AddRange(recipientSet.Items);
						}
					}
				}
				if (RecipientSetsClear.HasValue && RecipientSetsClear.Value)
				{
					recipientSets.Clear();
				}
				recipientSetsInitialized = true;
			}
			return recipientSets;
		}
	}

	public override bool? RecipientSetsClear
	{
		get
		{
			if (template.RecipientSetsClear.HasValue)
			{
				return template.RecipientSetsClear.Value;
			}
			if (parent != null)
			{
				return parent.RecipientSetsClear;
			}
			return null;
		}
	}

	public override string URL
	{
		get
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (NfCVbiD03fyRCEDZq5b(this) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return null;
				default:
					return URLTemplateBase.URL;
				}
			}
		}
	}

	public override NotificationTemplateBase URLTemplateBase
	{
		get
		{
			//Discarded unreachable code: IL_008a, IL_0099
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return null;
				case 2:
					return template.URLTemplateBase;
				case 3:
					if (template.URL != null)
					{
						num2 = 2;
						continue;
					}
					break;
				}
				if (parent != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
			}
			return (NotificationTemplateBase)NfCVbiD03fyRCEDZq5b(parent);
		}
	}

	public override NotificationTemplateObject ObjectTemplate
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				default:
					if (parent == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj = MNvcQaDsDGvdbboAM6D(parent);
					break;
				case 1:
					obj = MNvcQaDsDGvdbboAM6D(template);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					return null;
				}
				break;
			}
			return (NotificationTemplateObject)obj;
		}
	}

	public NotificationTemplateWrapper(NotificationTemplateBase template, NotificationTemplateBase parent)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		DFke9bD6ByenHtvq6uV();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				this.parent = parent;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 2:
				this.template = template;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string GetAuthor(object notificationDataSource)
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 3;
		int num2 = num;
		NotificationTemplateBase authorTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			default:
				return authorTemplateBase.GetAuthor(notificationDataSource);
			case 3:
				authorTemplateBase = GetAuthorTemplateBase(notificationDataSource);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (authorTemplateBase != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public override bool IsAuthorOverride(object notificationDataSource)
	{
		int num = 2;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			default:
				return DAyUcZDyIqdbbEZpLAn(notificationTemplateBase, notificationDataSource);
			case 1:
				if (notificationTemplateBase == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				notificationTemplateBase = (NotificationTemplateBase)CyYTHnDmuUTdjAf58uc(this, notificationDataSource);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override NotificationTemplateBase GetAuthorTemplateBase(object notificationDataSource)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_00ee, IL_0119, IL_0128
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return null;
			case 2:
				return (NotificationTemplateBase)CyYTHnDmuUTdjAf58uc(parent, notificationDataSource);
			default:
				return (NotificationTemplateBase)CyYTHnDmuUTdjAf58uc(parent, notificationDataSource);
			case 1:
			case 4:
				if (rXhaNwDMQSJVJyhIMwl(template, notificationDataSource) != null)
				{
					return (NotificationTemplateBase)CyYTHnDmuUTdjAf58uc(template, notificationDataSource);
				}
				num2 = 6;
				break;
			case 7:
				return (NotificationTemplateBase)CyYTHnDmuUTdjAf58uc(template, notificationDataSource);
			case 6:
				if (parent != null)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 3:
				if (!parent.IsAuthorOverride(notificationDataSource))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 8:
				if (!DAyUcZDyIqdbbEZpLAn(template, notificationDataSource))
				{
					if (parent == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public override string GetSubject(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			default:
				return (string)hjxqjZD9r2BrE0GTC20(notificationTemplateBase, notificationDataSource);
			case 2:
				notificationTemplateBase = (NotificationTemplateBase)CT5qBKDJNw7599nY6rQ(this, notificationDataSource);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (notificationTemplateBase != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override bool IsSubjectOverride(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 3;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (notificationTemplateBase == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return notificationTemplateBase.IsSubjectOverride(notificationDataSource);
			default:
				return false;
			case 3:
				notificationTemplateBase = (NotificationTemplateBase)CT5qBKDJNw7599nY6rQ(this, notificationDataSource);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override NotificationTemplateBase GetSubjectTemplateBase(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0045, IL_009b, IL_00aa, IL_00ba, IL_00c9
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 4:
				return template.GetSubjectTemplateBase(notificationDataSource);
			case 8:
				if (!zQ7V7RDdIiat2kTGSRh(parent, notificationDataSource))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 7:
				return (NotificationTemplateBase)CT5qBKDJNw7599nY6rQ(parent, notificationDataSource);
			default:
				if (template.GetSubject(notificationDataSource) != null)
				{
					num2 = 4;
					continue;
				}
				break;
			case 1:
				return (NotificationTemplateBase)CT5qBKDJNw7599nY6rQ(template, notificationDataSource);
			case 5:
				if (parent != null)
				{
					num2 = 8;
					continue;
				}
				goto default;
			case 6:
				if (!zQ7V7RDdIiat2kTGSRh(template, notificationDataSource))
				{
					num2 = 5;
					continue;
				}
				goto case 1;
			case 3:
				break;
			}
			if (parent != null)
			{
				break;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
			{
				num2 = 2;
			}
		}
		return parent.GetSubjectTemplateBase(notificationDataSource);
	}

	public override string GetShortMessage(object notificationDataSource)
	{
		int num = 2;
		int num2 = num;
		NotificationTemplateBase shortMessageTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 2:
				shortMessageTemplateBase = GetShortMessageTemplateBase(notificationDataSource);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return null;
			case 1:
				if (shortMessageTemplateBase != null)
				{
					return (string)UnN9NeDlCEQ6X7wdH1V(shortMessageTemplateBase, notificationDataSource);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsShortMessageOverride(object notificationDataSource)
	{
		int num = 1;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return gF9BYvDgJJevlNukx7x(notificationTemplateBase, notificationDataSource);
			case 1:
				notificationTemplateBase = (NotificationTemplateBase)bEmKQLDrvcjrrdRaRhU(this, notificationDataSource);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (notificationTemplateBase == null)
			{
				return false;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
			{
				num2 = 0;
			}
		}
	}

	public override NotificationTemplateBase GetShortMessageTemplateBase(object notificationDataSource)
	{
		//Discarded unreachable code: IL_00c5, IL_00d4, IL_00e4
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (gF9BYvDgJJevlNukx7x(template, notificationDataSource))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 6;
						}
						break;
					}
					if (parent == null)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				default:
					return null;
				case 6:
					return (NotificationTemplateBase)bEmKQLDrvcjrrdRaRhU(template, notificationDataSource);
				case 1:
					if (!gF9BYvDgJJevlNukx7x(parent, notificationDataSource))
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 3:
					return (NotificationTemplateBase)bEmKQLDrvcjrrdRaRhU(parent, notificationDataSource);
				case 2:
				case 4:
					if (UnN9NeDlCEQ6X7wdH1V(template, notificationDataSource) != null)
					{
						return (NotificationTemplateBase)bEmKQLDrvcjrrdRaRhU(template, notificationDataSource);
					}
					goto end_IL_0012;
				case 5:
					if (parent != null)
					{
						return (NotificationTemplateBase)bEmKQLDrvcjrrdRaRhU(parent, notificationDataSource);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public override string GetFullMessage(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 3;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			default:
				return (string)qhBM25DjqgbnC3F42ZB(notificationTemplateBase, notificationDataSource);
			case 3:
				notificationTemplateBase = (NotificationTemplateBase)vp6S9gD592VXCfylMOM(this, notificationDataSource);
				num2 = 2;
				break;
			case 2:
				if (notificationTemplateBase != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public override bool IsFullMessageOverride(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 1;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				notificationTemplateBase = (NotificationTemplateBase)vp6S9gD592VXCfylMOM(this, notificationDataSource);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return ubrlpxDYEYKWcTo9sM0(notificationTemplateBase, notificationDataSource);
			case 3:
				return false;
			default:
				if (notificationTemplateBase == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public override NotificationTemplateBase GetFullMessageTemplateBase(object notificationDataSource)
	{
		//Discarded unreachable code: IL_00b2
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!ubrlpxDYEYKWcTo9sM0(template, notificationDataSource))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				return template.GetFullMessageTemplateBase(notificationDataSource);
			case 1:
				if (parent != null)
				{
					num2 = 4;
					break;
				}
				goto IL_0092;
			case 5:
				return (NotificationTemplateBase)vp6S9gD592VXCfylMOM(parent, notificationDataSource);
			case 4:
				if (parent.IsFullMessageOverride(notificationDataSource))
				{
					num2 = 5;
					break;
				}
				goto IL_0092;
			case 6:
				if (parent == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (NotificationTemplateBase)vp6S9gD592VXCfylMOM(parent, notificationDataSource);
			default:
				{
					return null;
				}
				IL_0092:
				if (template.GetFullMessage(notificationDataSource) == null)
				{
					num2 = 6;
					break;
				}
				return (NotificationTemplateBase)vp6S9gD592VXCfylMOM(template, notificationDataSource);
			}
		}
	}

	public override CustomMessage[] GetCustomMessages(object notificationDataSource)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 3:
				return (CustomMessage[])ej3kTUDU0MJPiSYGHMB(notificationTemplateBase, notificationDataSource);
			default:
				if (notificationTemplateBase != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				notificationTemplateBase = (NotificationTemplateBase)JR0XGLDLJlaCuS3RcLf(this, notificationDataSource);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override NotificationTemplateBase GetCustomMessagesTemplateBase(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0072
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (parent == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return (NotificationTemplateBase)JR0XGLDLJlaCuS3RcLf(parent, notificationDataSource);
			case 2:
				return null;
			default:
				return template.GetCustomMessagesTemplateBase(notificationDataSource);
			case 1:
				if (ej3kTUDU0MJPiSYGHMB(template, notificationDataSource) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override bool IsSendToAuthor(object notificationDataSource)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 3;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return LhWilqDct28WXJmG33f(notificationTemplateBase, notificationDataSource);
			default:
				return false;
			case 2:
				if (notificationTemplateBase == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				notificationTemplateBase = (NotificationTemplateBase)CT5qBKDJNw7599nY6rQ(this, notificationDataSource);
				num2 = 2;
				break;
			}
		}
	}

	public override bool CheckFilter(INotification notification)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!ae66octB3qJ2OXDdbSP(parent, notification))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_0059;
			case 3:
				return false;
			default:
				if (parent != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0059;
			case 1:
				{
					cVtkP7tFMjjAg4wKLRQ(notification, DqG4XwDziyluhlYWe8y(-1979251663 ^ -1979219393));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_0059:
				return ae66octB3qJ2OXDdbSP(template, notification);
			}
		}
	}

	internal static void DFke9bD6ByenHtvq6uV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nCdu4HDwQBoOBdSq7ip()
	{
		return gZRb1mDtsCSmFm8tjZh == null;
	}

	internal static NotificationTemplateWrapper TForZAD4O8CAPF8MsuX()
	{
		return gZRb1mDtsCSmFm8tjZh;
	}

	internal static object JmVwkXDHQKndQTUo6g0(object P_0)
	{
		return ((NotificationTemplateBase)P_0).FileInfo;
	}

	internal static object aiJOkBDAdnsJDgjbCRg(object P_0)
	{
		return ((NotificationTemplateBase)P_0).Name;
	}

	internal static object nnXNfJD7U9V70aZERNU(object P_0)
	{
		return ((NotificationTemplateBase)P_0).ChannelsTemplateBase;
	}

	internal static object Y6di6bDxNToaNf8qXeW(object P_0)
	{
		return ((NotificationTemplateBase)P_0).Channels;
	}

	internal static object NfCVbiD03fyRCEDZq5b(object P_0)
	{
		return ((NotificationTemplateBase)P_0).URLTemplateBase;
	}

	internal static object CyYTHnDmuUTdjAf58uc(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetAuthorTemplateBase(P_1);
	}

	internal static bool DAyUcZDyIqdbbEZpLAn(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).IsAuthorOverride(P_1);
	}

	internal static object rXhaNwDMQSJVJyhIMwl(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetAuthor(P_1);
	}

	internal static object CT5qBKDJNw7599nY6rQ(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetSubjectTemplateBase(P_1);
	}

	internal static object hjxqjZD9r2BrE0GTC20(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetSubject(P_1);
	}

	internal static bool zQ7V7RDdIiat2kTGSRh(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).IsSubjectOverride(P_1);
	}

	internal static object UnN9NeDlCEQ6X7wdH1V(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetShortMessage(P_1);
	}

	internal static object bEmKQLDrvcjrrdRaRhU(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetShortMessageTemplateBase(P_1);
	}

	internal static bool gF9BYvDgJJevlNukx7x(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).IsShortMessageOverride(P_1);
	}

	internal static object vp6S9gD592VXCfylMOM(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetFullMessageTemplateBase(P_1);
	}

	internal static object qhBM25DjqgbnC3F42ZB(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetFullMessage(P_1);
	}

	internal static bool ubrlpxDYEYKWcTo9sM0(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).IsFullMessageOverride(P_1);
	}

	internal static object JR0XGLDLJlaCuS3RcLf(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetCustomMessagesTemplateBase(P_1);
	}

	internal static object ej3kTUDU0MJPiSYGHMB(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).GetCustomMessages(P_1);
	}

	internal static object MNvcQaDsDGvdbboAM6D(object P_0)
	{
		return ((NotificationTemplateBase)P_0).ObjectTemplate;
	}

	internal static bool LhWilqDct28WXJmG33f(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).IsSendToAuthor(P_1);
	}

	internal static object DqG4XwDziyluhlYWe8y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void cVtkP7tFMjjAg4wKLRQ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool ae66octB3qJ2OXDdbSP(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).CheckFilter((INotification)P_1);
	}
}
