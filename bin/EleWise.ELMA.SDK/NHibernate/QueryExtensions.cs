using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;

namespace NHibernate;

public static class QueryExtensions
{
	internal static QueryExtensions icow5EBYSieRB7jrr0D;

	public static int ExecuteUpdate(this IQuery query, bool cleanUpCache)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return lwdmD7Bc5L1rvcCXBRY(query);
			case 1:
				throw new ArgumentNullException((string)HZuN7nBs4Tyh6VjnHxF(-1939377524 ^ -1939375186));
			case 2:
				if (query != null)
				{
					query.set_CleanUpCache(cleanUpCache);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public static IQuery CleanUpCache(this IQuery query, bool cleanUpCache = true)
	{
		//Discarded unreachable code: IL_0033, IL_0042
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return query;
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA09EC));
			case 2:
				query.set_CleanUpCache(cleanUpCache);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (query != null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	public static void CleanUpCache(this ISession session, params Type[] affectedTypes)
	{
		//Discarded unreachable code: IL_00b9, IL_00c8, IL_00d3, IL_0186, IL_01b9, IL_0227, IL_0236, IL_02d4, IL_02e3, IL_02ef, IL_0348, IL_035b, IL_036a, IL_0427
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		int num = 2;
		Action action = default(Action);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		IUnitOfWorkManager serviceNotNull = default(IUnitOfWorkManager);
		List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
		Type current = default(Type);
		ISet<string> collectionRolesByEntityParticipant = default(ISet<string>);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 14:
					action = _003C_003Ec__DisplayClass2_._003CCleanUpCache_003Eb__0;
					num2 = 5;
					continue;
				case 13:
					if (N8utNWWoR2Pqrp6XNYb(serviceNotNull, ""))
					{
						num2 = 10;
						continue;
					}
					return;
				case 10:
					bb1is3WbymTkCS6Vjne(serviceNotNull, action);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num3 = 0;
								}
								goto IL_00d7;
							}
							goto IL_02f9;
							IL_02f9:
							current = enumerator.Current;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 3;
							}
							goto IL_00d7;
							IL_00d7:
							while (true)
							{
								switch (num3)
								{
								case 3:
									collectionRolesByEntityParticipant = ((ISessionFactoryImplementor)HIjpUZBzZTiOFAhEHBq((object)(ISessionImplementor)_003C_003Ec__DisplayClass2_.session)).GetCollectionRolesByEntityParticipant(current.FullName);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
									{
										num3 = 0;
									}
									continue;
								default:
									if (collectionRolesByEntityParticipant == null)
									{
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto case 7;
								case 4:
								case 5:
									break;
								case 7:
									enumerator2 = collectionRolesByEntityParticipant.GetEnumerator();
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
									{
										num3 = 6;
									}
									continue;
								case 6:
									try
									{
										while (true)
										{
											int num4;
											if (!triOxOWFC7PsjBGMwFX(enumerator2))
											{
												num4 = 2;
												goto IL_01c7;
											}
											goto IL_01ff;
											IL_01c7:
											while (true)
											{
												switch (num4)
												{
												case 3:
												case 5:
													break;
												case 4:
													goto IL_01ff;
												case 1:
													_003C_003Ec__DisplayClass2_.collectionRoles.Add(current2);
													num4 = 3;
													continue;
												default:
													if (_003C_003Ec__DisplayClass2_.collectionRoles.Contains(current2))
													{
														int num5 = 5;
														num4 = num5;
														continue;
													}
													goto case 1;
												case 2:
													goto end_IL_01e9;
												}
												break;
											}
											continue;
											IL_01ff:
											current2 = enumerator2.Current;
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
											{
												num4 = 0;
											}
											goto IL_01c7;
											continue;
											end_IL_01e9:
											break;
										}
									}
									finally
									{
										int num7;
										if (enumerator2 == null)
										{
											int num6 = 2;
											num7 = num6;
											goto IL_0298;
										}
										goto IL_02ae;
										IL_0298:
										switch (num7)
										{
										case 2:
											goto end_IL_027f;
										case 1:
											goto end_IL_027f;
										}
										goto IL_02ae;
										IL_02ae:
										m8XcWbWBbyggBcRFKq6(enumerator2);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
										{
											num7 = 1;
										}
										goto IL_0298;
										end_IL_027f:;
									}
									break;
								case 1:
									goto IL_02f9;
								case 2:
									goto end_IL_015b;
								}
								break;
							}
							continue;
							end_IL_015b:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				case 0:
					return;
				case 5:
					olwMJ0WWEOa78OwxfDR(action);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
					enumerator = _003C_003Ec__DisplayClass2_.types.GetEnumerator();
					num2 = 12;
					continue;
				case 6:
					break;
				case 1:
					_003C_003Ec__DisplayClass2_.session = session;
					num2 = 15;
					continue;
				case 15:
					if (_003C_003Ec__DisplayClass2_.session == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						if (affectedTypes == null)
						{
							return;
						}
						num2 = 9;
					}
					continue;
				case 9:
					if (affectedTypes.Length != 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 8:
					return;
				case 4:
					_003C_003Ec__DisplayClass2_.types = affectedTypes.Select(InterfaceActivator.TypeOf).ToList();
					num2 = 6;
					continue;
				case 2:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					throw new ArgumentNullException((string)HZuN7nBs4Tyh6VjnHxF(-70007027 ^ -70005187));
				case 7:
					serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 13;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass2_.collectionRoles = new List<string>();
			num = 11;
		}
	}

	public static void CleanUpCache(this ISession session, IEntity entity)
	{
		//Discarded unreachable code: IL_0097
		int num = 9;
		IUnitOfWorkManager serviceNotNull = default(IUnitOfWorkManager);
		Action action = default(Action);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 0:
					return;
				case 7:
					return;
				case 3:
					serviceNotNull.RegisterPostCommitAction(action);
					num2 = 7;
					continue;
				case 10:
					serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					action = _003C_003Ec__DisplayClass3_._003CCleanUpCache_003Eb__0;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 8;
					}
					continue;
				case 1:
					if (!N8utNWWoR2Pqrp6XNYb(serviceNotNull, ""))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 11:
					if (entity != null)
					{
						_003C_003Ec__DisplayClass3_.type = s0JvZuWhKYttlPTurne(entity.CastAsRealType().GetType());
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 2;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass3_.session = session;
					num2 = 11;
					continue;
				case 5:
					break;
				case 4:
					_003C_003Ec__DisplayClass3_.id = SHpVcmWGAGqWnSZBYgy(entity);
					num2 = 6;
					continue;
				}
				break;
			}
			olwMJ0WWEOa78OwxfDR(action);
			num = 10;
		}
	}

	public static void CleanUpCollectionsCache(this ISession session, params string[] collectionRoles)
	{
		//Discarded unreachable code: IL_008f, IL_0102, IL_019c
		int num = 13;
		int num2 = num;
		Action action = default(Action);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		IUnitOfWorkManager serviceNotNull = default(IUnitOfWorkManager);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				olwMJ0WWEOa78OwxfDR(action);
				num2 = 5;
				break;
			case 13:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 14:
				return;
			case 2:
				if (!N8utNWWoR2Pqrp6XNYb(serviceNotNull, ""))
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 4;
			case 4:
				serviceNotNull.RegisterPostCommitAction(action);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass4_.session = session;
				num2 = 10;
				break;
			case 11:
				return;
			case 9:
				throw new ArgumentNullException((string)HZuN7nBs4Tyh6VjnHxF(-488881205 ^ -488879365));
			case 6:
				if (_003C_003Ec__DisplayClass4_.collectionRoles == null)
				{
					num2 = 14;
					break;
				}
				goto case 3;
			case 12:
				_003C_003Ec__DisplayClass4_.collectionRoles = collectionRoles;
				num2 = 7;
				break;
			case 5:
				serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 8:
				return;
			case 3:
				if (_003C_003Ec__DisplayClass4_.collectionRoles.Length != 0)
				{
					action = _003C_003Ec__DisplayClass4_._003CCleanUpCollectionsCache_003Eb__0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 8;
				}
				break;
			case 10:
				if (_003C_003Ec__DisplayClass4_.session != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 9;
			}
		}
	}

	public static void SetStatistics(this SessionFactoryImpl sessionFactory, StatisticsImpl statistics)
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
				kZ3fJRWEAYG4epbUAai(sessionFactory, statistics);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object HZuN7nBs4Tyh6VjnHxF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int lwdmD7Bc5L1rvcCXBRY(object P_0)
	{
		return ((IQuery)P_0).ExecuteUpdate();
	}

	internal static bool JWEUDwBL5QuLAwVdcVK()
	{
		return icow5EBYSieRB7jrr0D == null;
	}

	internal static QueryExtensions p3pwjFBUFARfVNeBARX()
	{
		return icow5EBYSieRB7jrr0D;
	}

	internal static object HIjpUZBzZTiOFAhEHBq(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Factory();
	}

	internal static bool triOxOWFC7PsjBGMwFX(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void m8XcWbWBbyggBcRFKq6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void olwMJ0WWEOa78OwxfDR(object P_0)
	{
		P_0();
	}

	internal static bool N8utNWWoR2Pqrp6XNYb(object P_0, object P_1)
	{
		return ((IUnitOfWorkManager)P_0).HasActiveTransaction((string)P_1);
	}

	internal static void bb1is3WbymTkCS6Vjne(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}

	internal static Type s0JvZuWhKYttlPTurne(Type t)
	{
		return InterfaceActivator.TypeOf(t);
	}

	internal static object SHpVcmWGAGqWnSZBYgy(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void kZ3fJRWEAYG4epbUAai(object P_0, object P_1)
	{
		((SessionFactoryImpl)P_0).SetStatistics((StatisticsImpl)P_1);
	}
}
