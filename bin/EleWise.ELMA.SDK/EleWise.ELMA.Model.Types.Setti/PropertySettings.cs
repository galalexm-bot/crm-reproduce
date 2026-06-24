using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class PropertySettings : TypeSettings
{
	private static PropertySettings ITqbPDocKCaVM2jkKgge;

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Restart)]
	public Guid EntityTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityTypeUid_003Ek__BackingField;
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
					_003CEntityTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("EntityTypeUid")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue("")]
	public string EntityTypeUidStr
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 1;
			int num2 = num;
			Guid entityTypeUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return "";
				default:
					entityTypeUid = EntityTypeUid;
					num2 = 3;
					break;
				case 1:
					if (xi1whsocnybSbsmoU6kL(EntityTypeUid, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return entityTypeUid.ToString();
				}
			}
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
				case 0:
					return;
				case 1:
					EntityTypeUid = ((!fTW7ekocOr3LLnRaOe2g(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[XmlIgnore]
	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
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
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
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

	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("PropertyUid")]
	[DefaultValue("")]
	public string PropertyUidStr
	{
		get
		{
			int num = 1;
			int num2 = num;
			Guid propertyUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return propertyUid.ToString();
				case 1:
					if (!(PropertyUid != Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						break;
					}
					propertyUid = PropertyUid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					break;
				default:
					return "";
				}
			}
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
				case 0:
					return;
				case 1:
					PropertyUid = ((!fTW7ekocOr3LLnRaOe2g(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Guid ProjectionPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CProjectionPropertyUid_003Ek__BackingField;
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
					_003CProjectionPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("ProjectionPropertyUid")]
	public string ProjectionPropertyStr
	{
		get
		{
			int num = 2;
			int num2 = num;
			Guid projectionPropertyUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return "";
				case 2:
					if (xi1whsocnybSbsmoU6kL(ProjectionPropertyUid, Guid.Empty))
					{
						projectionPropertyUid = ProjectionPropertyUid;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 0;
						}
					}
					break;
				default:
					return projectionPropertyUid.ToString();
				}
			}
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
				case 0:
					return;
				case 1:
					ProjectionPropertyUid = ((!fTW7ekocOr3LLnRaOe2g(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected PropertySettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PropertySettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uWht8xockdZxSRA3BoL6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zSQbVUocXgKyGEqOVKZi()
	{
		return ITqbPDocKCaVM2jkKgge == null;
	}

	internal static PropertySettings Hb36NqocTQiMIy5jhh6r()
	{
		return ITqbPDocKCaVM2jkKgge;
	}

	internal static void uWht8xockdZxSRA3BoL6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xi1whsocnybSbsmoU6kL(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool fTW7ekocOr3LLnRaOe2g(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
