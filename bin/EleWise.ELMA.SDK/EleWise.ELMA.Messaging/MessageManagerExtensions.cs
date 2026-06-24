using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messaging;

public static class MessageManagerExtensions
{
	internal static MessageManagerExtensions n5JpSZhmy2XqMfZo2VGJ;

	public static void Delay(this IMessageManager messageManager, IEntity entity, Guid actionUid)
	{
		//Discarded unreachable code: IL_0041, IL_00e1, IL_00f0
		int num = 6;
		int num2 = num;
		UidAttribute attribute = default(UidAttribute);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 4:
				IWFdoDhmlBDYVQb7lm6a(messageManager, wIfv0fhm9l3myoWTKOgu(attribute), VDQ9Owhmd445UHRv8dpn(entity).ToString(), actionUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (attribute == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 5:
				if (entity == null)
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 7:
				attribute = AttributeHelper<UidAttribute>.GetAttribute(entity.CastAsRealType().GetType(), inherited: true);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 0:
				return;
			case 6:
				if (messageManager == null)
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	internal static Guid wIfv0fhm9l3myoWTKOgu(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static object VDQ9Owhmd445UHRv8dpn(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void IWFdoDhmlBDYVQb7lm6a(object P_0, Guid objectUid, object P_2, Guid actionUid)
	{
		((IMessageManager)P_0).Delay(objectUid, (string)P_2, actionUid);
	}

	internal static bool IhJICehmMRrMwbyCXLnp()
	{
		return n5JpSZhmy2XqMfZo2VGJ == null;
	}

	internal static MessageManagerExtensions XBxuqMhmJ6CBVVpI9kGM()
	{
		return n5JpSZhmy2XqMfZo2VGJ;
	}
}
