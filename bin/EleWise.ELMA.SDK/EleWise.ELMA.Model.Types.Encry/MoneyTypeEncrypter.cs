using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class MoneyTypeEncrypter : BaseTypeEncrypter
{
	private static MoneyTypeEncrypter melx6SoL3MsR8KB4N8TO;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (propertyMetadata2 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return yC6JVNoLtfVZC8NE1wqJ(zYV4PsoLDtrT1aVKMu3Q(propertyMetadata2), MoneyDescriptor.UID);
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_004f
		int num = 3;
		int num2 = num;
		Money? money = default(Money?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (LIVRb4oLwWZUAvqo0vI2((PropertyMetadata)propertyMetadata))
				{
					num2 = 2;
					break;
				}
				return ClassSerializationHelper.SerializeObjectByXml(new MoneyWrapper((Money)obj));
			default:
				return ClassSerializationHelper.SerializeObjectByXml(new MoneyWrapper(money.Value));
			case 4:
				return string.Empty;
			case 1:
				money = (Money?)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (yDFnfeoL4emH5H3O4m9E(obj))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 3:
				return null;
			case 1:
				return KQZSoJoL6r79BDoTqsR3(ClassSerializationHelper.DeserializeObjectByXml<MoneyWrapper>(obj));
			case 2:
				if (!((PropertyMetadata)propertyMetadata).Nullable)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public MoneyTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mqJ0V1oLHw9280bsTYav();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid zYV4PsoLDtrT1aVKMu3Q(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool yC6JVNoLtfVZC8NE1wqJ(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool YfRCDZoLpiXolxSpSYKf()
	{
		return melx6SoL3MsR8KB4N8TO == null;
	}

	internal static MoneyTypeEncrypter bfj8FeoLadCMIKCpU4Qw()
	{
		return melx6SoL3MsR8KB4N8TO;
	}

	internal static bool LIVRb4oLwWZUAvqo0vI2(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool yDFnfeoL4emH5H3O4m9E(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Money KQZSoJoL6r79BDoTqsR3(object P_0)
	{
		return ((MoneyWrapper)P_0).Value;
	}

	internal static void mqJ0V1oLHw9280bsTYav()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
