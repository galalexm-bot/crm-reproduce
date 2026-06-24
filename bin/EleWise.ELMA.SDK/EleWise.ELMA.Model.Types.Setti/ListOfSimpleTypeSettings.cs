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
public class ListOfSimpleTypeSettings : SimpleTypeSettings
{
	private static ListOfSimpleTypeSettings RZWmqUozwOvjKK9jEy8s;

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Restart)]
	public Guid SimpleTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSimpleTypeUid_003Ek__BackingField;
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
					_003CSimpleTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue("")]
	[XmlElement("SimpleTypeUid")]
	public string SimpleTypeUidStr
	{
		get
		{
			int num = 2;
			int num2 = num;
			Guid simpleTypeUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return "";
				case 2:
					if (w1PnZcozAISN8vm1KGCO(SimpleTypeUid, Guid.Empty))
					{
						simpleTypeUid = SimpleTypeUid;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
					}
					break;
				default:
					return simpleTypeUid.ToString();
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
					SimpleTypeUid = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ListOfSimpleTypeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BOLrqgozHMvx0mYwd7Yq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ListOfSimpleTypeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		BOLrqgozHMvx0mYwd7Yq();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool Equals(SimpleTypeSettings other)
	{
		int num = 1;
		int num2 = num;
		ListOfSimpleTypeSettings listOfSimpleTypeSettings = default(ListOfSimpleTypeSettings);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return false;
			case 1:
				listOfSimpleTypeSettings = other as ListOfSimpleTypeSettings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return base.Equals(other);
			case 2:
				return true;
			case 5:
				return zUJvGSoz7GpVErSU42Nt(listOfSimpleTypeSettings.SimpleTypeUid, SimpleTypeUid);
			}
			if (listOfSimpleTypeSettings != null)
			{
				if (listOfSimpleTypeSettings != null)
				{
					if (this == listOfSimpleTypeSettings)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (!base.Equals(other))
					{
						return false;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 2;
					}
				}
			}
			else
			{
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 2:
				return true;
			case 1:
				return false;
			default:
				return Equals((ListOfSimpleTypeSettings)obj);
			case 4:
				if (obj != null)
				{
					if (this == obj)
					{
						num2 = 2;
						break;
					}
					if (!(obj.GetType() != GetType()))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		_ = SimpleTypeUid;
		return hashCode ^ (SimpleTypeUid.GetHashCode() * 67);
	}

	internal static void BOLrqgozHMvx0mYwd7Yq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool dgvn7roz4ZKHWQi2Q7Li()
	{
		return RZWmqUozwOvjKK9jEy8s == null;
	}

	internal static ListOfSimpleTypeSettings xXL3pUoz6v1Q3tOtiEU0()
	{
		return RZWmqUozwOvjKK9jEy8s;
	}

	internal static bool w1PnZcozAISN8vm1KGCO(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool zUJvGSoz7GpVErSU42Nt(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
