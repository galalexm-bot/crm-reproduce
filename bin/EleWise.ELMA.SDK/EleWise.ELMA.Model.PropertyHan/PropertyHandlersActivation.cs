using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.PropertyHandlers;

[Component]
internal class PropertyHandlersActivation : IEntityActivationHandler
{
	internal static PropertyHandlersActivation cHX4xXWstCm1JxECSxVl;

	public static void ActivateOnCreate(IEntity entity)
	{
		//Discarded unreachable code: IL_00b4, IL_00c3, IL_00d5, IL_00df, IL_00ee, IL_0124, IL_012e, IL_018a, IL_01d9, IL_01e8, IL_024d
		int num = 7;
		EntityMetadata entityMetadata = default(EntityMetadata);
		DateTime? dateTime2 = default(DateTime?);
		DateTime minValue = default(DateTime);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		Guid? guid2 = default(Guid?);
		Guid? guid = default(Guid?);
		DateTime? dateTime = default(DateTime?);
		Guid empty = default(Guid);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (entityMetadata != null)
					{
						num2 = 19;
						continue;
					}
					return;
				case 15:
					if (!dateTime2.HasValue)
					{
						num2 = 18;
						continue;
					}
					if (cDwu59WsxL23CAcxxc8W(dateTime2.GetValueOrDefault(), minValue))
					{
						goto case 18;
					}
					goto case 4;
				case 24:
					return;
				case 14:
					return;
				case 5:
				case 10:
					entity.SetPropertyValue(VYBfL7Ws6o0OixthlOxl(propertyMetadata), wQJf8YWs748TAItewD8r());
					num = 2;
					break;
				case 9:
					guid2 = guid;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					guid = (Guid?)H3YV0tWsHOGbEEVbuHHF(entity, VYBfL7Ws6o0OixthlOxl(propertyMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					continue;
				case 25:
					if (dateTime.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 18;
				case 3:
					dateTime2 = dateTime;
					num2 = 13;
					continue;
				case 23:
					if (propertyMetadata != null)
					{
						num2 = 11;
						continue;
					}
					goto case 2;
				case 21:
					empty = Guid.Empty;
					num2 = 8;
					continue;
				case 7:
					entityMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
					num = 6;
					break;
				case 13:
					minValue = DateTime.MinValue;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 22;
					}
					continue;
				case 18:
				case 20:
					lh5e3bWsmQM0HyMyrYk6(entity, VYBfL7Ws6o0OixthlOxl(propertyMetadata2), qd3N5UWs08HThvM1TX9r());
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 14;
					}
					continue;
				default:
					if (!guid.HasValue)
					{
						num2 = 10;
						continue;
					}
					goto case 9;
				case 8:
					if (guid2.HasValue)
					{
						if (!guid2.HasValue)
						{
							num2 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num2 = 8;
							}
							continue;
						}
						if (MCREc7WsAF2urTdHbRTo(guid2.GetValueOrDefault(), empty))
						{
							goto case 16;
						}
						goto case 2;
					}
					num2 = 12;
					continue;
				case 22:
					if (dateTime2.HasValue)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 4;
				case 26:
					dateTime = (DateTime?)H3YV0tWsHOGbEEVbuHHF(entity, VYBfL7Ws6o0OixthlOxl(propertyMetadata2));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 25;
					}
					continue;
				case 17:
					if (propertyMetadata2 == null)
					{
						return;
					}
					num2 = 26;
					continue;
				case 1:
					return;
				case 19:
					propertyMetadata = entityMetadata.Properties.FirstOrDefault(delegate(PropertyMetadata p)
					{
						//Discarded unreachable code: IL_0076, IL_0085
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								return _003C_003Ec.bHUl2hCWkjJIwLq6pEq5(p);
							default:
								return false;
							case 1:
								if (!_003C_003Ec.VJIoFjCWTKJLfbpjNqek(_003C_003Ec.cchH9ACWKSQKo196kOHe(p), _003C_003Ec.TdtLKVCWXDPr2T3qQaIM(-1979251663 ^ -1979225181)))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					});
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 3;
					}
					continue;
				case 16:
					num2 = 5;
					continue;
				case 2:
				case 12:
					propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.FirstOrDefault((PropertyHandlerInfo h) => _003C_003Ec.YkjGhVCWnnQqWX01b13q(h) == CreationDatePropertyHandler.UID) != null);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 17;
					}
					continue;
				case 4:
					num2 = 24;
					continue;
				}
				break;
			}
		}
	}

	public void OnActivating(IEntity entity)
	{
		dCPkdYWsyk0E6VC3DyP7(entity);
	}

	public void OnActivated(IEntity entity)
	{
	}

	public PropertyHandlersActivation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		c6h96bWsMSjE6QOfNEDQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid VYBfL7Ws6o0OixthlOxl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object H3YV0tWsHOGbEEVbuHHF(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static bool MCREc7WsAF2urTdHbRTo(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid wQJf8YWs748TAItewD8r()
	{
		return Guid.NewGuid();
	}

	internal static bool cDwu59WsxL23CAcxxc8W(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static DateTime qd3N5UWs08HThvM1TX9r()
	{
		return DateTime.Now;
	}

	internal static void lh5e3bWsmQM0HyMyrYk6(object P_0, Guid propertyUid, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(propertyUid, P_2);
	}

	internal static bool aL4rCbWswUMDO6LP57Li()
	{
		return cHX4xXWstCm1JxECSxVl == null;
	}

	internal static PropertyHandlersActivation yxecLwWs4LvPSFNY3nWW()
	{
		return cHX4xXWstCm1JxECSxVl;
	}

	internal static void dCPkdYWsyk0E6VC3DyP7(object P_0)
	{
		ActivateOnCreate((IEntity)P_0);
	}

	internal static void c6h96bWsMSjE6QOfNEDQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
