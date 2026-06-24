using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
public class PropertyDescription
{
	private static PropertyDescription rYQKwJb7DPqxRR7iwoFw;

	[DataMember]
	[XmlElement("PropertyUid")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
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

	[DataMember]
	[XmlElement("ClassUid")]
	public Guid ClassUid
	{
		[CompilerGenerated]
		get
		{
			return _003CClassUid_003Ek__BackingField;
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
					_003CClassUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)kE9OHVb74xtww5hDuJKc(this);
			case 2:
				return (string)kE9OHVb74xtww5hDuJKc(this);
			case 3:
				if (propertyMetadata == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 5;
					}
					break;
				}
				return propertyMetadata.ToString();
			case 5:
				return base.ToString();
			case 4:
				if (classMetadata != null)
				{
					propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => H7yrcfb7HrBym3aUnESB(usayJwb76H3ZZUyUbMyN(p), PropertyUid));
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (Locator.GetService<IMetadataRuntimeService>() != null)
				{
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(ClassUid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public PropertyDescription()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool w9yYl8b7tE1tDaJBWuhL()
	{
		return rYQKwJb7DPqxRR7iwoFw == null;
	}

	internal static PropertyDescription t2eBv2b7wXR7XBQZHmdE()
	{
		return rYQKwJb7DPqxRR7iwoFw;
	}

	internal static object kE9OHVb74xtww5hDuJKc(object P_0)
	{
		return P_0.ToString();
	}

	internal static Guid usayJwb76H3ZZUyUbMyN(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool H7yrcfb7HrBym3aUnESB(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
