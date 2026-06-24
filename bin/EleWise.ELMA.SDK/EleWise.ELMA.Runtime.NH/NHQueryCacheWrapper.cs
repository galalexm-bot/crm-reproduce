using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Cache.Entry;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Impl;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class NHQueryCacheWrapper : IQueryCache
{
	private static readonly ILogger Log;

	private readonly UpdateTimestampsCache updateTimestampsCache;

	private readonly ICache queryCache;

	private readonly string regionName;

	internal static NHQueryCacheWrapper FKZKokWNrM8GV7NG5Mx8;

	public ICache Cache => queryCache;

	public string RegionName => regionName;

	public Task ClearAsync(CancellationToken cancellationToken)
	{
		return (Task)Hc4O0iWNj4o9dJGPidcg(Cache, cancellationToken);
	}

	[AsyncStateMachine(typeof(_003CPutAsync_003Ed__1))]
	public Task<bool> PutAsync(QueryKey key, ICacheAssembler[] returnTypes, IList result, bool isNaturalKeyLookup, ISessionImplementor session, CancellationToken cancellationToken)
	{
		_003CPutAsync_003Ed__1 stateMachine = default(_003CPutAsync_003Ed__1);
		stateMachine._003C_003E4__this = this;
		stateMachine.key = key;
		stateMachine.returnTypes = returnTypes;
		stateMachine.result = result;
		stateMachine.isNaturalKeyLookup = isNaturalKeyLookup;
		stateMachine.session = session;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetAsync_003Ed__2))]
	public Task<IList> GetAsync(QueryKey key, ICacheAssembler[] returnTypes, bool isNaturalKeyLookup, ISet<string> spaces, ISessionImplementor session, CancellationToken cancellationToken)
	{
		_003CGetAsync_003Ed__2 stateMachine = default(_003CGetAsync_003Ed__2);
		stateMachine._003C_003E4__this = this;
		stateMachine.key = key;
		stateMachine.returnTypes = returnTypes;
		stateMachine.isNaturalKeyLookup = isNaturalKeyLookup;
		stateMachine.spaces = spaces;
		stateMachine.session = session;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IList>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IList> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public NHQueryCacheWrapper(string regionName, UpdateTimestampsCache updateTimestampsCache, Settings settings, IDictionary<string, string> props)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.updateTimestampsCache = updateTimestampsCache;
		if (string.IsNullOrWhiteSpace(regionName))
		{
			regionName = typeof(NHQueryCacheWrapper).FullName;
		}
		string cacheRegionPrefix = settings.get_CacheRegionPrefix();
		if (!string.IsNullOrEmpty(cacheRegionPrefix))
		{
			regionName = cacheRegionPrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105194202) + regionName;
		}
		this.regionName = regionName;
		queryCache = settings.get_CacheProvider().BuildCache(this.regionName, props);
	}

	public void Clear()
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
				jIlRdSWNYv4Drv2n0Fhe(Cache);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool Put(QueryKey key, ICacheAssembler[] returnTypes, IList result, bool isNaturalKeyLookup, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_010b, IL_011a, IL_016f, IL_01a2, IL_01e9, IL_01f8, IL_0207, IL_0333, IL_0342, IL_04c1, IL_04d0
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		int num = 17;
		object obj2 = default(object);
		INHibernateProxy val3 = default(INHibernateProxy);
		IList list = default(IList);
		ICacheAssembler val4 = default(ICacheAssembler);
		int num3 = default(int);
		object state = default(object);
		IEntityPersister val = default(IEntityPersister);
		CacheEntry val2 = default(CacheEntry);
		EntityEntry entry = default(EntityEntry);
		object id = default(object);
		long num4 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 19:
					obj2 = PPNwx7W3bmZ4eHbTwxyx(O3grlwW3B9h9207aF0IV(val3), session);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 7;
					}
					break;
				case 13:
					return true;
				case 20:
					AxQOqnW3osALQhXB9NbV(list, AVyBVyW38rBSS5x3kRMj(val4, obj2, session, null));
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 32;
					}
					break;
				case 3:
				case 8:
					if (num3 >= YtcfaZWNLlYO6xAZTMEV(result))
					{
						goto end_IL_0012;
					}
					goto case 28;
				case 9:
					state = r5vMG9W3vYWIOtU1hVr4(val.get_CacheEntryStructure(), val2);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 33;
					}
					break;
				case 28:
					obj2 = lEBFLuWNz0CyR3rhFtiQ(result, num3);
					num2 = 18;
					break;
				case 26:
				case 30:
				case 32:
				case 35:
					num3++;
					num2 = 3;
					break;
				case 27:
					if (entry == null)
					{
						num2 = 22;
						break;
					}
					val = (IEntityPersister)uR9xlAW3GyDsW3mJp5Am(entry);
					num2 = 11;
					break;
				case 15:
					AxQOqnW3osALQhXB9NbV(list, VkmsihW3ZxTyE2nVJlvv((object[])obj2, returnTypes, null, session, null));
					num2 = 26;
					break;
				case 10:
					Log.DebugFormat((string)fyaIIDWNceGKuI2TCOlK(-2138160520 ^ -2138287876), regionName, key);
					num2 = 6;
					break;
				case 5:
					queryCache.Put((object)key, (object)list);
					num2 = 13;
					break;
				case 17:
					if (isNaturalKeyLookup)
					{
						num2 = 16;
						break;
					}
					goto case 34;
				case 14:
					if (obj2 is IEntity)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 29;
						}
						break;
					}
					goto case 20;
				case 11:
					id = JmuDEeW3EwECkYfvTYGt(entry);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 8;
					}
					break;
				case 6:
					list = new List<object>(YtcfaZWNLlYO6xAZTMEV(result) + 1) { num4 };
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					break;
				case 24:
					return false;
				case 34:
					num4 = eeOXoWWNUxBs6Ydtg59X(session);
					num2 = 31;
					break;
				case 33:
					AxQOqnW3osALQhXB9NbV(list, new NHEntityCacheEntry(id, state, obj2.GetType().FullName));
					num2 = 35;
					break;
				case 22:
					return false;
				default:
					val4 = returnTypes[0];
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 13;
					}
					break;
				case 21:
					if (!yBD3E9W3W79QWCyZjaKM(O3grlwW3B9h9207aF0IV(val3)))
					{
						num2 = 19;
						break;
					}
					goto case 23;
				case 25:
					val3 = (INHibernateProxy)obj2;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 21;
					}
					break;
				case 29:
					if (!iUfpAbW3FwyivbhvvEvv(obj2))
					{
						num2 = 2;
						break;
					}
					goto case 25;
				case 2:
				case 7:
					entry = ((IPersistenceContext)K3hs71W3hqJ2Hb4SBW6N(session)).GetEntry(obj2);
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 27;
					}
					break;
				case 1:
					num3 = 0;
					num2 = 8;
					break;
				case 23:
					AxQOqnW3osALQhXB9NbV(list, val4.Disassemble(obj2, session, (object)null));
					num2 = 30;
					break;
				case 18:
					if (returnTypes.Length == 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 15;
				case 16:
					if (YtcfaZWNLlYO6xAZTMEV(result) != 0)
					{
						num2 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 24;
				case 31:
					if (USiLLQWNs4vV7Q6spGgu(Log))
					{
						num2 = 10;
						break;
					}
					goto case 6;
				case 12:
				{
					object[] loadedState = entry.get_LoadedState();
					object obj = sSXioFW3fZA5flwxPD1N(loadedState, val);
					val2 = (CacheEntry)cuI3PpW3CQeRXpQ1UBhD(loadedState, val, LW8ZI8W3Qk5qBnFPwqiD(entry), obj, session, obj2);
					num2 = 9;
					break;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public IList Get(QueryKey key, ICacheAssembler[] returnTypes, bool isNaturalKeyLookup, ISet<string> spaces, ISessionImplementor session)
	{
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		if (Log.IsDebugEnabled())
		{
			Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477266172), regionName, key);
		}
		IList list = (IList)queryCache.Get((object)key);
		if (list == null)
		{
			Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889587448), key);
			return null;
		}
		long timestamp = (long)list[0];
		if (Log.IsDebugEnabled())
		{
			Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765986678), StringHelper.CollectionToString((IEnumerable)(ICollection)spaces));
		}
		if (!isNaturalKeyLookup && !IsUpToDate(spaces, timestamp))
		{
			if (Log.IsDebugEnabled())
			{
				Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F772B6), key);
			}
			return null;
		}
		if (Log.IsDebugEnabled())
		{
			Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FDDF3F), key);
		}
		for (int i = 1; i < list.Count; i++)
		{
			object obj = list[i];
			if (returnTypes.Length == 1)
			{
				ICacheAssembler val = returnTypes[0];
				if (!(val is ManyToOneType) || !(obj is NHEntityCacheEntry))
				{
					val.BeforeAssemble(obj, session);
				}
			}
			else
			{
				TypeHelper.BeforeAssemble((object[])obj, returnTypes, session);
			}
		}
		IList list2 = new List<object>(list.Count - 1);
		for (int j = 1; j < list.Count; j++)
		{
			try
			{
				object obj2 = list[j];
				if (returnTypes.Length == 1)
				{
					ICacheAssembler val2 = returnTypes[0];
					if (val2 is ManyToOneType)
					{
						if (obj2 is NHEntityCacheEntry nHEntityCacheEntry)
						{
							ISessionFactoryImplementor factory = session.get_Factory();
							IEntityPersister entityPersister = factory.GetEntityPersister(nHEntityCacheEntry.ClassName);
							EntityKey val3 = new EntityKey(nHEntityCacheEntry.Id, entityPersister);
							if (session.get_PersistenceContext().ContainsEntity(val3))
							{
								list2.Add(val2.Assemble(nHEntityCacheEntry.Id, session, (object)null));
								continue;
							}
							CacheEntry val4 = (CacheEntry)entityPersister.get_CacheEntryStructure().Destructure(nHEntityCacheEntry.State, factory);
							if (entityPersister.get_EntityMetamodel().get_SubclassEntityNames().Contains(val4.get_Subclass()))
							{
								LoadEvent @event = new LoadEvent(nHEntityCacheEntry.Id, nHEntityCacheEntry.ClassName, false, (IEventSource)session);
								object value = AssembleCacheEntry(val4, nHEntityCacheEntry.Id, entityPersister, @event);
								list2.Add(value);
							}
						}
						else
						{
							list2.Add(val2.Assemble(obj2, session, (object)null));
						}
					}
					else
					{
						list2.Add(val2.Assemble(obj2, session, (object)null));
					}
				}
				else
				{
					list2.Add(TypeHelper.Assemble((object[])obj2, returnTypes, session, (object)null));
				}
			}
			catch (UnresolvableObjectException)
			{
				if (isNaturalKeyLookup)
				{
					Log.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103DFDCD));
					queryCache.Remove((object)key);
					return null;
				}
				throw;
			}
		}
		return list2;
	}

	public void Destroy()
	{
		//Discarded unreachable code: IL_004b, IL_007e, IL_00da, IL_00e9
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				QiiI3JW3ugIDfuTUMWiJ(queryCache);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					cLoOx2W3VNxwUs2LvD2X(Log, cr2kfZW3IVoMh3Pji9M7(fyaIIDWNceGKuI2TCOlK(-1921202237 ^ -1921068341), regionName), ex);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	private object AssembleCacheEntry(CacheEntry entry, object id, IEntityPersister persister, LoadEvent @event)
	{
		//Discarded unreachable code: IL_0179, IL_0188, IL_019b, IL_01aa, IL_01df, IL_01ee
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		int num = 9;
		object[] array2 = default(object[]);
		IType[] array = default(IType[]);
		IEntityPersister val2 = default(IEntityPersister);
		IEventSource val = default(IEventSource);
		PostLoadEvent val4 = default(PostLoadEvent);
		object obj2 = default(object);
		object obj3 = default(object);
		int num3 = default(int);
		IPostLoadEventListener[] postLoadEventListeners = default(IPostLoadEventListener[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 19:
					G2PLF1W3efATdLyTtp84(array2, array, val2.get_PropertyUpdateability(), array2, val);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 10;
					}
					continue;
				default:
					JUAsjaW3pt20cyF27kZU(val4, obj2);
					num2 = 15;
					continue;
				case 2:
					afZYYxW31D8tISSw42EA(Log, sLqqx0W3Pj9OrWjdIVA9(fyaIIDWNceGKuI2TCOlK(-138018305 ^ -138144677), obj3));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 18;
					}
					continue;
				case 10:
					BxKiKPW3nd6AgKZHIoHH((object)new EntityKey(id, val2), obj2, val2, LockMode.None, ElpPfTW3Tx3e5bHLNypt(entry), sf0nUTW3kjGLUBf0roRY(entry), val);
					num2 = 12;
					continue;
				case 11:
					WUiCZcW3DOdkLmnISrPk(val4, persister);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					array2 = (object[])HP9wgaW32brgTXE9BdRE(entry, obj2, id, val2, ((ISessionImplementor)val).get_Interceptor(), val);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 18;
					}
					continue;
				case 6:
					return obj2;
				case 7:
				case 21:
					if (num3 < postLoadEventListeners.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 22:
					num3 = 0;
					num2 = 21;
					continue;
				case 4:
					val4 = new PostLoadEvent(val);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
				case 18:
				{
					IPersistenceContext persistenceContext = ((ISessionImplementor)val).get_PersistenceContext();
					persistenceContext.AddEntry(obj2, (Status)0, array2, (object)null, id, obj3, LockMode.None, true, val2, false, ElpPfTW3Tx3e5bHLNypt(entry));
					krbABYW3NajU6UB2Otdm(val2, obj2, entry.get_AreLazyPropertiesUnfetched(), val);
					ocY9BYW336Il4YaJxcel(persistenceContext);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 5:
					goto end_IL_0012;
				case 1:
				case 3:
					s6H8uwW3wceraGrpipBX(postLoadEventListeners[num3], val4);
					num2 = 20;
					continue;
				case 15:
					r72nEMW3aOLn9MhE1AB0(val4, id);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 11;
					}
					continue;
				case 16:
					if (!USiLLQWNs4vV7Q6spGgu(Log))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 2;
				case 20:
					num3++;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 5;
					}
					continue;
				case 13:
					obj3 = sSXioFW3fZA5flwxPD1N(array2, val2);
					num2 = 16;
					continue;
				case 12:
					array = (IType[])r04ipjW3OT20HQBymRX9(val2);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
				{
					obj = LV9XRhW3SHrk9pHO6lST(@event);
					val = (IEventSource)PlIrg7W3i2tYF8igTdIj(@event);
					ISessionFactoryImplementor val3 = (ISessionFactoryImplementor)Rpi4HVW3RZx9qsgDVTSv(val);
					if (USiLLQWNs4vV7Q6spGgu(Log))
					{
						Log.Debug(cr2kfZW3IVoMh3Pji9M7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740474722), MFUrOFW3qU6NfVACvGKw(persister, id, val3)));
					}
					val2 = (IEntityPersister)qQTPFcW3KoMGsVWdVmX6(val3, entry.get_Subclass());
					if (obj != null)
					{
						break;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 8:
					obj = nSs51eW3XwxeJlWYdRwX(val, val2, id);
					break;
				}
				obj2 = obj;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			postLoadEventListeners = ((EventListeners)ktGbcGW3tNciswSF6FST(val)).get_PostLoadEventListeners();
			num = 22;
		}
	}

	protected virtual bool IsUpToDate(ISet<string> spaces, long timestamp)
	{
		return updateTimestampsCache.IsUpToDate(spaces, timestamp);
	}

	static NHQueryCacheWrapper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Log = (ILogger)nUwFDGW3HKmKnmn8meta(VWKb3mW36AGyDS0Yd0gh(typeof(NHQueryCacheWrapper).TypeHandle));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				oruf2HW34intjM4L4lbX();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object Hc4O0iWNj4o9dJGPidcg(object P_0, CancellationToken P_1)
	{
		return ((ICache)P_0).ClearAsync(P_1);
	}

	internal static bool cx9SNOWNgYi7Hi8EfQUS()
	{
		return FKZKokWNrM8GV7NG5Mx8 == null;
	}

	internal static NHQueryCacheWrapper rrerspWN5bM6mCmx138O()
	{
		return FKZKokWNrM8GV7NG5Mx8;
	}

	internal static void jIlRdSWNYv4Drv2n0Fhe(object P_0)
	{
		((ICache)P_0).Clear();
	}

	internal static int YtcfaZWNLlYO6xAZTMEV(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static long eeOXoWWNUxBs6Ydtg59X(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Timestamp();
	}

	internal static bool USiLLQWNs4vV7Q6spGgu(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object fyaIIDWNceGKuI2TCOlK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lEBFLuWNz0CyR3rhFtiQ(object P_0, int P_1)
	{
		return ((IList)P_0)[P_1];
	}

	internal static bool iUfpAbW3FwyivbhvvEvv(object P_0)
	{
		return NHibernateProxyHelper.IsProxy(P_0);
	}

	internal static object O3grlwW3B9h9207aF0IV(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static bool yBD3E9W3W79QWCyZjaKM(object P_0)
	{
		return ((ILazyInitializer)P_0).get_IsUninitialized();
	}

	internal static int AxQOqnW3osALQhXB9NbV(object P_0, object P_1)
	{
		return ((IList)P_0).Add(P_1);
	}

	internal static object PPNwx7W3bmZ4eHbTwxyx(object P_0, object P_1)
	{
		return ((ILazyInitializer)P_0).GetImplementation((ISessionImplementor)P_1);
	}

	internal static object K3hs71W3hqJ2Hb4SBW6N(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object uR9xlAW3GyDsW3mJp5Am(object P_0)
	{
		return ((EntityEntry)P_0).get_Persister();
	}

	internal static object JmuDEeW3EwECkYfvTYGt(object P_0)
	{
		return ((EntityEntry)P_0).get_Id();
	}

	internal static object sSXioFW3fZA5flwxPD1N(object P_0, object P_1)
	{
		return Versioning.GetVersion((object[])P_0, (IEntityPersister)P_1);
	}

	internal static bool LW8ZI8W3Qk5qBnFPwqiD(object P_0)
	{
		return ((EntityEntry)P_0).get_LoadedWithLazyPropertiesUnfetched();
	}

	internal static object cuI3PpW3CQeRXpQ1UBhD(object P_0, object P_1, bool P_2, object P_3, object P_4, object P_5)
	{
		return CacheEntry.Create((object[])P_0, (IEntityPersister)P_1, P_2, P_3, (ISessionImplementor)P_4, P_5);
	}

	internal static object r5vMG9W3vYWIOtU1hVr4(object P_0, object P_1)
	{
		return ((ICacheEntryStructure)P_0).Structure(P_1);
	}

	internal static object AVyBVyW38rBSS5x3kRMj(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ICacheAssembler)P_0).Disassemble(P_1, (ISessionImplementor)P_2, P_3);
	}

	internal static object VkmsihW3ZxTyE2nVJlvv(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return TypeHelper.Disassemble((object[])P_0, (ICacheAssembler[])P_1, (bool[])P_2, (ISessionImplementor)P_3, P_4);
	}

	internal static void QiiI3JW3ugIDfuTUMWiJ(object P_0)
	{
		((ICache)P_0).Destroy();
	}

	internal static object cr2kfZW3IVoMh3Pji9M7(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void cLoOx2W3VNxwUs2LvD2X(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object LV9XRhW3SHrk9pHO6lST(object P_0)
	{
		return ((LoadEvent)P_0).get_InstanceToLoad();
	}

	internal static object PlIrg7W3i2tYF8igTdIj(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static object Rpi4HVW3RZx9qsgDVTSv(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Factory();
	}

	internal static object MFUrOFW3qU6NfVACvGKw(object P_0, object P_1, object P_2)
	{
		return MessageHelper.InfoString((IEntityPersister)P_0, P_1, (ISessionFactoryImplementor)P_2);
	}

	internal static object qQTPFcW3KoMGsVWdVmX6(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
	}

	internal static object nSs51eW3XwxeJlWYdRwX(object P_0, object P_1, object P_2)
	{
		return ((IEventSource)P_0).Instantiate((IEntityPersister)P_1, P_2);
	}

	internal static bool ElpPfTW3Tx3e5bHLNypt(object P_0)
	{
		return ((CacheEntry)P_0).get_AreLazyPropertiesUnfetched();
	}

	internal static object sf0nUTW3kjGLUBf0roRY(object P_0)
	{
		return ((CacheEntry)P_0).get_Version();
	}

	internal static void BxKiKPW3nd6AgKZHIoHH(object P_0, object P_1, object P_2, object P_3, bool P_4, object P_5, object P_6)
	{
		TwoPhaseLoad.AddUninitializedCachedEntity((EntityKey)P_0, P_1, (IEntityPersister)P_2, (LockMode)P_3, P_4, P_5, (ISessionImplementor)P_6);
	}

	internal static object r04ipjW3OT20HQBymRX9(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyTypes();
	}

	internal static object HP9wgaW32brgTXE9BdRE(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		return ((CacheEntry)P_0).Assemble(P_1, P_2, (IEntityPersister)P_3, (IInterceptor)P_4, (ISessionImplementor)P_5);
	}

	internal static void G2PLF1W3efATdLyTtp84(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		TypeHelper.DeepCopy((object[])P_0, (IType[])P_1, (bool[])P_2, (object[])P_3, (ISessionImplementor)P_4);
	}

	internal static object sLqqx0W3Pj9OrWjdIVA9(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void afZYYxW31D8tISSw42EA(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void krbABYW3NajU6UB2Otdm(object P_0, object P_1, bool P_2, object P_3)
	{
		((IEntityPersister)P_0).AfterInitialize(P_1, P_2, (ISessionImplementor)P_3);
	}

	internal static void ocY9BYW336Il4YaJxcel(object P_0)
	{
		((IPersistenceContext)P_0).InitializeNonLazyCollections();
	}

	internal static void JUAsjaW3pt20cyF27kZU(object P_0, object P_1)
	{
		((PostLoadEvent)P_0).set_Entity(P_1);
	}

	internal static void r72nEMW3aOLn9MhE1AB0(object P_0, object P_1)
	{
		((PostLoadEvent)P_0).set_Id(P_1);
	}

	internal static void WUiCZcW3DOdkLmnISrPk(object P_0, object P_1)
	{
		((PostLoadEvent)P_0).set_Persister((IEntityPersister)P_1);
	}

	internal static object ktGbcGW3tNciswSF6FST(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Listeners();
	}

	internal static void s6H8uwW3wceraGrpipBX(object P_0, object P_1)
	{
		((IPostLoadEventListener)P_0).OnPostLoad((PostLoadEvent)P_1);
	}

	internal static void oruf2HW34intjM4L4lbX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type VWKb3mW36AGyDS0Yd0gh(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nUwFDGW3HKmKnmn8meta(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}
}
