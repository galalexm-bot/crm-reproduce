using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.PropertyHandlers;

[Component]
public class PropertyHandlersListener : EntityEventsListener
{
	private IContextBoundVariableService contextBoundVariableService;

	internal static PropertyHandlersListener jFvjLrBPp18SCslwvQc;

	public PropertyHandlersListener(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IWp922BUw7AvnB8646M();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.contextBoundVariableService = contextBoundVariableService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		int num = 6;
		int num2 = num;
		int num3 = default(int);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		object propertyValue = default(object);
		IEntity entity = default(IEntity);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return false;
			case 11:
				num3 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), (string)lOxdIgBtpmAOLwphs13(propertyMetadata));
				num2 = 7;
				break;
			case 10:
				throw new InvalidOperationException((string)V6EPrABOBHRV1gChwj8(Y1nRYnBhLRLreA9wOuI(0x6A79A716 ^ 0x6A79E00C), new object[1] { propertyMetadata.Name }));
			case 9:
				entityMetadata = MetadataLoader.LoadMetadata(((AbstractPreDatabaseOperationEvent)@event).get_Entity().GetType()) as EntityMetadata;
				num2 = 3;
				break;
			case 3:
				if (entityMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
					{
						num2 = 2;
					}
					break;
				}
				propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.FirstOrDefault((PropertyHandlerInfo h) => _003C_003Ec.DrEREnpluiwvE4RbPHk7(h) == CreationAuthorPropertyHandler.UID) != null);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (propertyMetadata != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto default;
			case 8:
				propertyValue = entity.GetPropertyValue(WnDCaxBKfhxADDmrb5s(propertyMetadata));
				num2 = 11;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				entity = hheiI9BocKs0s1nKo3o(@event) as IEntity;
				num2 = 5;
				break;
			case 5:
				if (entity != null)
				{
					rbGECWBJg3JYoVLyPU4(entity);
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 7:
				if (num3 >= 0)
				{
					((object[])a6MlYnBq5IZiT7tcInR(@event))[num3] = propertyValue;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
					{
						num2 = 10;
					}
				}
				break;
			default:
				return false;
			case 2:
				return false;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00f2, IL_0101, IL_0127, IL_0136, IL_01ee
		int num = 12;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		int num3 = default(int);
		IEntity entity = default(IEntity);
		IUser currentUser = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 17:
					if (!((ComponentManager)T43Th4BG9t4ZKPJWvsF()).GetExtensionPoints<IChangePropertyHandlerIgnoreProvider>().Where(_003C_003Ec__DisplayClass3_._003COnPreUpdate_003Eb__2).Select(_003C_003Ec__DisplayClass3_._003COnPreUpdate_003Eb__3)
						.ToList()
						.Contains(item: true))
					{
						num2 = 14;
						break;
					}
					goto case 10;
				case 16:
					if (propertyMetadata != null)
					{
						num2 = 17;
						break;
					}
					goto default;
				case 8:
					_003C_003Ec__DisplayClass3_.metadata = FJggVxBc8PqQIfAQTKS(((AbstractPreDatabaseOperationEvent)_003C_003Ec__DisplayClass3_.@event).get_Entity().GetType(), true, true) as EntityMetadata;
					num2 = 4;
					break;
				case 15:
					if (_003C_003Ec__DisplayClass3_.metadata == null)
					{
						num2 = 13;
						break;
					}
					goto case 3;
				case 6:
					num3 = Array.IndexOf((string[])JWnQ4BBE3UhhgQ4YEOD(Ti8PXkB0kg85f136ekg(_003C_003Ec__DisplayClass3_.@event)), propertyMetadata.Name);
					num2 = 2;
					break;
				case 4:
					entity = hheiI9BocKs0s1nKo3o(_003C_003Ec__DisplayClass3_.@event) as IEntity;
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
					{
						num2 = 8;
					}
					break;
				case 10:
					return false;
				case 14:
					currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					m8WmQoBFIIlhPe4T0GS(entity, WnDCaxBKfhxADDmrb5s(propertyMetadata), currentUser);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
					{
						num2 = 4;
					}
					break;
				case 5:
					throw new InvalidOperationException((string)V6EPrABOBHRV1gChwj8(Y1nRYnBhLRLreA9wOuI(-1943394692 ^ -1943379610), new object[1] { propertyMetadata.Name }));
				case 7:
					_003C_003Ec__DisplayClass3_.@event.get_State()[num3] = currentUser;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
					{
						num2 = 0;
					}
					break;
				case 11:
					_003C_003Ec__DisplayClass3_.@event = @event;
					num2 = 8;
					break;
				case 2:
					if (num3 >= 0)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 3:
					if (entity == null)
					{
						num2 = 9;
						break;
					}
					propertyMetadata = _003C_003Ec__DisplayClass3_.metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.FirstOrDefault((PropertyHandlerInfo h) => _003C_003Ec.wy7srQplmo1uoGy7NOGX(_003C_003Ec.DrEREnpluiwvE4RbPHk7(h), ChangeAuthorPropertyHandler.UID)) != null);
					num2 = 16;
					break;
				case 12:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 11;
					break;
				case 9:
				case 13:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00c8, IL_00d7, IL_0227, IL_0236, IL_02ae, IL_035a, IL_0369, IL_03aa
		int num = 20;
		IUserGroup userGroup = default(IUserGroup);
		UntypedISetProxy untypedISetProxy = default(UntypedISetProxy);
		UntypedISetProxy untypedISetProxy2 = default(UntypedISetProxy);
		uint? maxGroupUsersCount = default(uint?);
		UntypedISetProxy untypedISetProxy3 = default(UntypedISetProxy);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					throw new LicenseException((string)V6EPrABOBHRV1gChwj8(Y1nRYnBhLRLreA9wOuI(0x487E82CC ^ 0x487ECB5C), new object[1] { koJKLZBINXJN9jh0wxq(userGroup) }));
				case 9:
					return;
				case 11:
					return;
				case 12:
					return;
				case 14:
					if (untypedISetProxy != null)
					{
						num2 = 5;
						continue;
					}
					goto IL_01ed;
				case 16:
					if (userGroup == null)
					{
						num2 = 12;
						continue;
					}
					goto case 22;
				case 10:
					if (mL0OcMBY1rZWm6WwBWg(untypedISetProxy2) > maxGroupUsersCount.Value)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 20:
					base.OnPreUpdateCollection(@event);
					num2 = 19;
					continue;
				case 19:
					if (EMRFwfBDdvj09iMOewN(@event) != null)
					{
						num2 = 21;
						continue;
					}
					goto default;
				case 2:
					untypedISetProxy2 = new UntypedISetProxy(EMRFwfBDdvj09iMOewN(@event));
					num2 = 23;
					continue;
				case 13:
					throw new LicenseException(SR.T((string)Y1nRYnBhLRLreA9wOuI(-1278809262 ^ -1278825342), koJKLZBINXJN9jh0wxq(userGroup), maxGroupUsersCount.Value));
				case 4:
					if ((string)lxcit6BsBp1bPlerrIM(((AbstractCollectionEvent)@event).get_Collection()) == (string)Y1nRYnBhLRLreA9wOuI(0x6AA79E0 ^ 0x6AA31B0))
					{
						num2 = 3;
						continue;
					}
					goto IL_01ed;
				case 15:
					throw new LicenseException((string)V6EPrABOBHRV1gChwj8(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163239804), new object[1] { koJKLZBINXJN9jh0wxq(userGroup) }));
				case 17:
					return;
				case 23:
					if (untypedISetProxy2 == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 18:
					if (untypedISetProxy3.Count <= 0)
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 22:
					maxGroupUsersCount = ((UserGroupManager)tTmqEuBMKpEs77urx1R()).GetMaxGroupUsersCount(userGroup);
					num2 = 8;
					continue;
				case 6:
					if (untypedISetProxy3 == null)
					{
						num2 = 11;
						continue;
					}
					goto case 18;
				case 3:
					untypedISetProxy = new UntypedISetProxy(EMRFwfBDdvj09iMOewN(@event));
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					if (!maxGroupUsersCount.HasValue)
					{
						return;
					}
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
					{
						num2 = 24;
					}
					continue;
				case 7:
					untypedISetProxy3 = new UntypedISetProxy(EMRFwfBDdvj09iMOewN(@event));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num2 = 6;
					}
					continue;
				case 24:
					if (lxcit6BsBp1bPlerrIM(EMRFwfBDdvj09iMOewN(@event)) != null)
					{
						if ((string)lxcit6BsBp1bPlerrIM(EMRFwfBDdvj09iMOewN(@event)) == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x2121AB8D))
						{
							num2 = 2;
							continue;
						}
						goto case 4;
					}
					num2 = 17;
					continue;
				case 5:
					if (fZ75HpB4wra4XbNTsIi(untypedISetProxy) > 0)
					{
						num2 = 15;
						continue;
					}
					goto IL_01ed;
				default:
					obj = null;
					break;
				case 21:
					{
						obj = ((IPersistentCollection)EMRFwfBDdvj09iMOewN(@event)).get_Owner() as IUserGroup;
						break;
					}
					IL_01ed:
					if (!jQEqWVBV4O188TlWO2R(((IPersistentCollection)EMRFwfBDdvj09iMOewN(@event)).get_Role(), Y1nRYnBhLRLreA9wOuI(0x5EE4A7B ^ 0x5EE0349)))
					{
						return;
					}
					num2 = 7;
					continue;
				}
				userGroup = (IUserGroup)obj;
				num2 = 16;
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	internal static void IWp922BUw7AvnB8646M()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool wRlJM9BvxRauu5lsZrJ()
	{
		return jFvjLrBPp18SCslwvQc == null;
	}

	internal static PropertyHandlersListener qOoA6RBCGPMD5TgHNil()
	{
		return jFvjLrBPp18SCslwvQc;
	}

	internal static object hheiI9BocKs0s1nKo3o(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void rbGECWBJg3JYoVLyPU4(object P_0)
	{
		PropertyHandlersActivation.ActivateOnCreate((IEntity)P_0);
	}

	internal static Guid WnDCaxBKfhxADDmrb5s(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object lOxdIgBtpmAOLwphs13(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object Y1nRYnBhLRLreA9wOuI(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object V6EPrABOBHRV1gChwj8(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object a6MlYnBq5IZiT7tcInR(object P_0)
	{
		return ((PreInsertEvent)P_0).get_State();
	}

	internal static object FJggVxBc8PqQIfAQTKS(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object T43Th4BG9t4ZKPJWvsF()
	{
		return ComponentManager.Current;
	}

	internal static void m8WmQoBFIIlhPe4T0GS(object P_0, Guid P_1, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static object Ti8PXkB0kg85f136ekg(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object JWnQ4BBE3UhhgQ4YEOD(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object EMRFwfBDdvj09iMOewN(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_Collection();
	}

	internal static object tTmqEuBMKpEs77urx1R()
	{
		return UserGroupManager.Instance;
	}

	internal static object lxcit6BsBp1bPlerrIM(object P_0)
	{
		return ((IPersistentCollection)P_0).get_Role();
	}

	internal static int mL0OcMBY1rZWm6WwBWg(object P_0)
	{
		return UserGroupManager.GetLicensedGroupUsers((IEnumerable)P_0);
	}

	internal static object koJKLZBINXJN9jh0wxq(object P_0)
	{
		return ((IUserGroup)P_0).Name;
	}

	internal static int fZ75HpB4wra4XbNTsIi(object P_0)
	{
		return ((UntypedISetProxy)P_0).Count;
	}

	internal static bool jQEqWVBV4O188TlWO2R(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
