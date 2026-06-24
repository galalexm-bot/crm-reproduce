using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.PropertyHandlers;

[Component]
internal class PropertyHandlersListener : EntityEventsListener
{
	private IContextBoundVariableService contextBoundVariableService;

	private static PropertyHandlersListener p0AKX9WsJ5pWaDlIEHZi;

	public PropertyHandlersListener(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CJbfLdWslRUQ83gtHhds();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.contextBoundVariableService = contextBoundVariableService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
			{
				num = 1;
			}
		}
	}

	private static void ActivateOnInsertProperties(object @event, object eventState, object entity, object metadata)
	{
		int num = 9;
		int num3 = default(int);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		object obj = default(object);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		object propertyValue = default(object);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			List<PropertyMetadata> properties;
			Func<PropertyMetadata, bool> predicate;
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = Array.IndexOf((string[])SlTi02Wsg3sR0OeaX7CZ(VnLW1SWsrhD18fMvHRdZ(@event)), (string)JxaknEWsLPHQLZLvnslZ(propertyMetadata));
					num2 = 12;
					continue;
				case 7:
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE19E47), JxaknEWsLPHQLZLvnslZ(propertyMetadata)));
				case 10:
					obj = LR3hv9WsjiUG5rLoQqlf(entity, XM05CHWs5PmhiworumVZ(propertyMetadata2));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (propertyMetadata2 != null)
					{
						num2 = 2;
						continue;
					}
					break;
				case 1:
					if (num3 >= 0)
					{
						((object[])eventState)[num3] = propertyValue;
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 2:
					num4 = Array.IndexOf((string[])SlTi02Wsg3sR0OeaX7CZ(VnLW1SWsrhD18fMvHRdZ(@event)), propertyMetadata2.Name);
					num2 = 10;
					continue;
				case 6:
					if (propertyMetadata != null)
					{
						num2 = 5;
						continue;
					}
					return;
				case 11:
					return;
				case 12:
					propertyValue = ((IEntity)entity).GetPropertyValue(XM05CHWs5PmhiworumVZ(propertyMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					throw new InvalidOperationException(SR.T((string)MfewUIWsYUuRhYg9QBTj(-740338220 ^ -740485606), JxaknEWsLPHQLZLvnslZ(propertyMetadata2)));
				default:
					if (num4 >= 0)
					{
						((object[])eventState)[num4] = obj;
						num2 = 3;
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 9:
					properties = ((ClassMetadata)metadata).Properties;
					predicate = delegate(PropertyMetadata p)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 1:
								if (!_003C_003Ec.btai9tCWNqwtG7NgeUbL(p.Name, _003C_003Ec.nnIc8OCW16kOmZTRVoMl(0x61EC0CB8 ^ 0x61EC632A)))
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
									{
										num6 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return _003C_003Ec.olArjKCW3R3AdjjEtene(p);
							default:
								return false;
							}
						}
					};
					goto end_IL_0012;
				case 3:
					break;
				}
				propertyMetadata = ((ClassMetadata)metadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.FirstOrDefault((PropertyHandlerInfo h) => _003C_003Ec.y7TIuVCWavcYltFsyRZd(_003C_003Ec.cM9SNgCWp2DdiA6PE3wD(h), CreationDatePropertyHandler.UID)) != null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 6;
				}
				continue;
				end_IL_0012:
				break;
			}
			propertyMetadata2 = properties.FirstOrDefault(predicate);
			num = 8;
		}
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		int num = 5;
		int num2 = num;
		IEntity entity = default(IEntity);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 5:
				entity = N5UycLWsUfXwDUdP4yJv(@event) as IEntity;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (entityMetadata == null)
				{
					num2 = 6;
					break;
				}
				krwRV6WszhGM2j7ge18r(@event, l1UHLBWscGfLMjeDybAO(@event), entity, entityMetadata);
				num2 = 3;
				break;
			case 2:
				return false;
			case 6:
				return false;
			default:
				entityMetadata = MetadataLoader.LoadMetadata(((AbstractPreDatabaseOperationEvent)@event).get_Entity().GetType()) as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (entity != null)
				{
					o0RAiwWssEltsYnLgjXY(entity);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 2;
					}
				}
				break;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00a0, IL_00af, IL_00bf, IL_012e, IL_013d
		int num = 10;
		IEntity entity = default(IEntity);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		DateTime now = default(DateTime);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					bx6r9tWcBekiSjXLlhje(entity, XM05CHWs5PmhiworumVZ(propertyMetadata), now);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num = 9;
					break;
				case 16:
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217637641), propertyMetadata.Name));
				case 11:
					_003C_003Ec__DisplayClass4_.@event.get_State()[num3] = now;
					num2 = 5;
					continue;
				case 12:
					return false;
				case 15:
					if (entity != null)
					{
						_003C_003Ec__DisplayClass4_.metadata = MetadataLoader.LoadMetadata(N5UycLWsUfXwDUdP4yJv(_003C_003Ec__DisplayClass4_.@event).GetType()) as EntityMetadata;
						num2 = 19;
						continue;
					}
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass4_.@event = @event;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					entity = N5UycLWsUfXwDUdP4yJv(_003C_003Ec__DisplayClass4_.@event) as IEntity;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					if (num3 >= 0)
					{
						num2 = 11;
						continue;
					}
					goto case 16;
				case 19:
					if (_003C_003Ec__DisplayClass4_.metadata != null)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				case 2:
					return false;
				case 3:
					ActivateOnInsertProperties(_003C_003Ec__DisplayClass4_.@event, _003C_003Ec__DisplayClass4_.@event.get_State(), entity, _003C_003Ec__DisplayClass4_.metadata);
					num2 = 17;
					continue;
				case 13:
					if (!((ComponentManager)He5W8VWcF7loaOYqlR94()).GetExtensionPoints<IChangePropertyHandlerIgnoreProvider>().Where(_003C_003Ec__DisplayClass4_._003COnPreUpdate_003Eb__2).Select(_003C_003Ec__DisplayClass4_._003COnPreUpdate_003Eb__3)
						.ToList()
						.Contains(item: true))
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				case 8:
					if (propertyMetadata == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 13;
				case 6:
					num3 = Array.IndexOf((string[])SlTi02Wsg3sR0OeaX7CZ(VnLW1SWsrhD18fMvHRdZ(_003C_003Ec__DisplayClass4_.@event)), (string)JxaknEWsLPHQLZLvnslZ(propertyMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				case 18:
					return false;
				case 7:
					return false;
				case 14:
					now = DateTime.Now;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 4;
					}
					continue;
				case 17:
					propertyMetadata = _003C_003Ec__DisplayClass4_.metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.FirstOrDefault((PropertyHandlerInfo h) => _003C_003Ec.y7TIuVCWavcYltFsyRZd(_003C_003Ec.cM9SNgCWp2DdiA6PE3wD(h), ChangeDatePropertyHandler.UID)) != null);
					num = 8;
					break;
				}
				break;
			}
		}
	}

	internal static void CJbfLdWslRUQ83gtHhds()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool WEXTrdWs9UQ5K2dOoA2M()
	{
		return p0AKX9WsJ5pWaDlIEHZi == null;
	}

	internal static PropertyHandlersListener xXJ6TFWsdOnZqUGpmgBH()
	{
		return p0AKX9WsJ5pWaDlIEHZi;
	}

	internal static object VnLW1SWsrhD18fMvHRdZ(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object SlTi02Wsg3sR0OeaX7CZ(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static Guid XM05CHWs5PmhiworumVZ(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object LR3hv9WsjiUG5rLoQqlf(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static object MfewUIWsYUuRhYg9QBTj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JxaknEWsLPHQLZLvnslZ(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object N5UycLWsUfXwDUdP4yJv(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void o0RAiwWssEltsYnLgjXY(object P_0)
	{
		PropertyHandlersActivation.ActivateOnCreate((IEntity)P_0);
	}

	internal static object l1UHLBWscGfLMjeDybAO(object P_0)
	{
		return ((PreInsertEvent)P_0).get_State();
	}

	internal static void krwRV6WszhGM2j7ge18r(object P_0, object P_1, object P_2, object P_3)
	{
		ActivateOnInsertProperties(P_0, P_1, P_2, P_3);
	}

	internal static object He5W8VWcF7loaOYqlR94()
	{
		return ComponentManager.Current;
	}

	internal static void bx6r9tWcBekiSjXLlhje(object P_0, Guid propertyUid, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(propertyUid, P_2);
	}
}
