using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Persister.Entity;

namespace EleWise.ELMA.Model.PropertyHandlers;

[Component]
public class CalculateScriptChangePropertyIgnoreProvider : IChangePropertyHandlerIgnoreProvider
{
	internal static CalculateScriptChangePropertyIgnoreProvider JqA4WqWsVOoSo43xF4dA;

	public bool CheckType(Guid typeUid)
	{
		return MetadataLoader.LoadMetadata(typeUid) is IEntity;
	}

	bool IChangePropertyHandlerIgnoreProvider.Ignore(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00a8, IL_00ec, IL_00fb, IL_010b, IL_013f, IL_01e9
		int num = 12;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		int[] array2 = default(int[]);
		int num4 = default(int);
		int[] array = default(int[]);
		int num3 = default(int);
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (propertyMetadata != null)
					{
						num2 = 14;
						continue;
					}
					goto case 19;
				case 10:
					if (array2.Length != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 15;
				case 7:
					return true;
				case 12:
					array2 = (int[])YgCw77WsTjVLFxnbTGMg(iR5IoIWsRKWxV9ZNFWwL(@event), @event.get_State(), vVLb7VWsqiGt3j4HMedv(@event), qjd235WsK3JIYW1iQSco(@event), IKtMwaWsXv0U4tS42D66(@event));
					num = 11;
					break;
				case 5:
					num4 = array[num3];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (entityMetadata != null)
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 11:
					if (array2 == null)
					{
						num2 = 20;
						continue;
					}
					goto case 10;
				case 17:
					propertyMetadata = entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CEleWise_002EELMA_002EModel_002EPropertyHandlers_002EIChangePropertyHandlerIgnoreProvider_002EIgnore_003Eb__0);
					num2 = 2;
					continue;
				case 18:
					_003C_003Ec__DisplayClass1_.propertyName = ((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames()[num4];
					num2 = 17;
					continue;
				case 15:
				case 20:
					return false;
				case 9:
					entityMetadata = MetadataLoader.LoadMetadata(qjd235WsK3JIYW1iQSco(@event).GetType()) as EntityMetadata;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					num3 = 0;
					num = 8;
					break;
				case 3:
					return false;
				case 6:
					array = array2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					continue;
				case 19:
					return false;
				case 16:
					num3++;
					num2 = 13;
					continue;
				default:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 18;
					continue;
				case 8:
				case 13:
					if (num3 >= array.Length)
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 14:
					if (!mt0duKWsnQX16sofuuYr(NOItk7WskmeKVq4mBhrp(propertyMetadata)))
					{
						num2 = 16;
						continue;
					}
					goto case 19;
				}
				break;
			}
		}
	}

	public CalculateScriptChangePropertyIgnoreProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YiDp2QWsODAKomslYtXK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DpWnKiWsSYlwK45U4h7O()
	{
		return JqA4WqWsVOoSo43xF4dA == null;
	}

	internal static CalculateScriptChangePropertyIgnoreProvider B47f1rWsiA3D9NI8wPS8()
	{
		return JqA4WqWsVOoSo43xF4dA;
	}

	internal static object iR5IoIWsRKWxV9ZNFWwL(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object vVLb7VWsqiGt3j4HMedv(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static object qjd235WsK3JIYW1iQSco(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object IKtMwaWsXv0U4tS42D66(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static object YgCw77WsTjVLFxnbTGMg(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((IEntityPersister)P_0).FindDirty((object[])P_1, (object[])P_2, P_3, (ISessionImplementor)P_4);
	}

	internal static object NOItk7WskmeKVq4mBhrp(object P_0)
	{
		return ((PropertyMetadata)P_0).CalculateScript;
	}

	internal static bool mt0duKWsnQX16sofuuYr(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void YiDp2QWsODAKomslYtXK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
