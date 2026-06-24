using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.PropertyHandlers;

[Component]
internal class PropertyHandlersActivation : IEntityActivationHandler
{
	private static PropertyHandlersActivation SX5wwLBLWSmEdswfdc3;

	public static void ActivateOnCreate(IEntity entity)
	{
		//Discarded unreachable code: IL_00d7, IL_0108
		int num = 5;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		IUser currentUser = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (entityMetadata == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
					{
						num2 = 7;
					}
					break;
				}
				propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.FirstOrDefault((PropertyHandlerInfo h) => _003C_003Ec.QxSmVIpllEsq3XooCh2G(_003C_003Ec.lqt1P4pl6C2sXBMu8Xta(h), CreationAuthorPropertyHandler.UID)) != null);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				entityMetadata = CqnaNoBal1gNPvwf5XO(entity.GetType(), true, true) as EntityMetadata;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
				num2 = 3;
				break;
			case 3:
				FQlb1ZB2dAxSuQttNGQ(entity, propertyMetadata.Uid, currentUser);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
				{
					num2 = 6;
				}
				break;
			case 0:
				return;
			case 1:
				if (propertyMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 2:
				return;
			case 6:
				return;
			case 8:
				if (ziJj07BwhPvBNxBW4aC(entity, DqfXcbBRmtVE32jQRQE(propertyMetadata)) != null)
				{
					num2 = 2;
					break;
				}
				goto case 9;
			case 7:
				return;
			}
		}
	}

	public void OnActivating(IEntity entity)
	{
		ActivateOnCreate(entity);
	}

	public void OnActivated(IEntity entity)
	{
	}

	public PropertyHandlersActivation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object CqnaNoBal1gNPvwf5XO(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static Guid DqfXcbBRmtVE32jQRQE(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object ziJj07BwhPvBNxBW4aC(object P_0, Guid P_1)
	{
		return ((IEntity)P_0).GetPropertyValue(P_1);
	}

	internal static void FQlb1ZB2dAxSuQttNGQ(object P_0, Guid P_1, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static bool hjKUP8Bj1wccJqNS3VX()
	{
		return SX5wwLBLWSmEdswfdc3 == null;
	}

	internal static PropertyHandlersActivation iUXBFxBHN3LckuFCvtd()
	{
		return SX5wwLBLWSmEdswfdc3;
	}
}
