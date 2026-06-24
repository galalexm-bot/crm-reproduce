using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Cache.ActorModel.Configuration;
using EleWise.ELMA.Cache.ActorModel.Partitioning;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache.ActorModel.Actors;

internal sealed class ConsistentHashingCacheActor : Actor, IConsistentHashingCacheActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private static MembershipTable membershipTable;

	private static readonly MemoryCache Cache;

	private readonly CacheOptions options;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly ILogger logger;

	private readonly string localNode;

	internal static ConsistentHashingCacheActor SJTOjKfTZekBARWk63ch;

	public ConsistentHashingCacheActor(ICacheService cacheService, IActorModelRuntime actorModelRuntime, IRuntimeApplication runtimeApplication, ILoggerFactory loggerFactory)
	{
		//Discarded unreachable code: IL_001a, IL_00a6, IL_00b5
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				logger = (ILogger)oTEKtpfTSWJqafBO2H5g(loggerFactory, sulmmyfTV2CVDgW17vN9(typeof(ServerInstanceActor).TypeHandle));
				int num2 = 7;
				num = num2;
				break;
			}
			case 3:
				return;
			case 6:
				return;
			default:
				membershipTable = new MembershipTable(localNode);
				num = 6;
				break;
			case 4:
				if (membershipTable != null)
				{
					num = 3;
					break;
				}
				goto default;
			case 2:
				this.actorModelRuntime = actorModelRuntime;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 1;
				}
				break;
			case 5:
				localNode = WjpriqfTRBi8fMB3cVeF(runtimeApplication).ToString();
				num = 4;
				break;
			case 7:
			{
				IOptionsProvider obj = cacheService as IOptionsProvider;
				options = (CacheOptions)(((obj != null) ? sgleEofTi1vRs6MwjPQr(obj) : null) ?? new CacheOptions());
				num = 5;
				break;
			}
			}
		}
	}

	[AsyncStateMachine(typeof(_003CClearRegion_003Ed__8))]
	public Task ClearRegion(string region, bool forward = true)
	{
		int num = 7;
		_003CClearRegion_003Ed__8 stateMachine = default(_003CClearRegion_003Ed__8);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					stateMachine.region = region;
					num2 = 3;
					continue;
				case 1:
					stateMachine._003C_003E1__state = -1;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					stateMachine._003C_003Et__builder = n4pwGWfTquFvcIurGRQB();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 5;
					continue;
				case 3:
					break;
				case 7:
					stateMachine._003C_003E4__this = this;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			stateMachine.forward = forward;
			num = 4;
		}
	}

	[AsyncStateMachine(typeof(_003CContains_003Ed__9))]
	public Task<bool> Contains(string key, string region)
	{
		_003CContains_003Ed__9 stateMachine = default(_003CContains_003Ed__9);
		stateMachine._003C_003E4__this = this;
		stateMachine.key = key;
		stateMachine.region = region;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGet_003Ed__10))]
	public Task<CacheResult> Get(string key, string region)
	{
		_003CGet_003Ed__10 stateMachine = default(_003CGet_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine.key = key;
		stateMachine.region = region;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CacheResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<CacheResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRemove_003Ed__11))]
	public Task Remove(string key, string region, bool replica = false)
	{
		int num = 1;
		int num2 = num;
		_003CRemove_003Ed__11 stateMachine = default(_003CRemove_003Ed__11);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 7;
				break;
			case 2:
				stateMachine.replica = replica;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			default:
				stateMachine.key = key;
				num2 = 6;
				break;
			case 4:
				stateMachine._003C_003Et__builder = n4pwGWfTquFvcIurGRQB();
				num2 = 3;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				stateMachine.region = region;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 8;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CSet_003Ed__12))]
	public Task Set(string key, string region, byte[] value, TimeSpan duration, bool replica = false)
	{
		int num = 5;
		_003CSet_003Ed__12 stateMachine = default(_003CSet_003Ed__12);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					stateMachine.duration = duration;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					stateMachine.replica = replica;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					stateMachine.region = region;
					num2 = 9;
					continue;
				case 3:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					stateMachine.value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					stateMachine._003C_003E1__state = -1;
					num2 = 3;
					continue;
				case 10:
					stateMachine._003C_003Et__builder = n4pwGWfTquFvcIurGRQB();
					num2 = 7;
					continue;
				case 6:
					return stateMachine._003C_003Et__builder.Task;
				case 5:
					stateMachine._003C_003E4__this = this;
					num2 = 4;
					continue;
				case 4:
					break;
				}
				break;
			}
			stateMachine.key = key;
			num = 8;
		}
	}

	[AsyncStateMachine(typeof(_003CAccept_003Ed__13))]
	public Task Accept((string key, string region, byte[] value, TimeSpan duration)[] entries, bool replica = false)
	{
		int num = 3;
		_003CAccept_003Ed__13 stateMachine = default(_003CAccept_003Ed__13);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					stateMachine.replica = replica;
					num = 7;
					break;
				case 6:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return stateMachine._003C_003Et__builder.Task;
				case 2:
					stateMachine.entries = entries;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					stateMachine._003C_003Et__builder = n4pwGWfTquFvcIurGRQB();
					num2 = 5;
					continue;
				case 5:
					stateMachine._003C_003E1__state = -1;
					num = 6;
					break;
				case 1:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 4;
					continue;
				case 3:
					stateMachine._003C_003E4__this = this;
					num = 2;
					break;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CUpdateMembershipTable_003Ed__14))]
	public Task UpdateMembershipTable(string node, bool added)
	{
		int num = 2;
		int num2 = num;
		_003CUpdateMembershipTable_003Ed__14 stateMachine = default(_003CUpdateMembershipTable_003Ed__14);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num2 = 7;
				break;
			case 1:
				stateMachine.node = node;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine.added = added;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				stateMachine._003C_003Et__builder = n4pwGWfTquFvcIurGRQB();
				num2 = 4;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CDistributeKeys_003Ed__15))]
	private Task DistributeKeys(string remoteNode, (double start, double end)[] keyAngles)
	{
		int num = 5;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CDistributeKeys_003Ed__15 stateMachine = default(_003CDistributeKeys_003Ed__15);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = n4pwGWfTquFvcIurGRQB();
				num2 = 2;
				break;
			case 7:
				stateMachine.keyAngles = keyAngles;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine.remoteNode = remoteNode;
				num2 = 7;
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CDistributeKeyCopies_003Ed__16))]
	private Task DistributeKeyCopies((double start, double end)[] keyAngles)
	{
		int num = 3;
		_003CDistributeKeyCopies_003Ed__16 stateMachine = default(_003CDistributeKeyCopies_003Ed__16);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 6:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					stateMachine.keyAngles = keyAngles;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 4;
					continue;
				default:
					stateMachine._003C_003E1__state = -1;
					num2 = 5;
					continue;
				case 3:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					continue;
				}
				break;
			}
			_003C_003Et__builder.Start(ref stateMachine);
			num = 6;
		}
	}

	private CacheEntry[] GetEntriesForDistribution((double start, double end)[] keyAngles)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass17_.keyAngles = keyAngles;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Cache.Select((KeyValuePair<string, object> p) => (CacheEntry)p.Value).Where(_003C_003Ec__DisplayClass17_._003CGetEntriesForDistribution_003Eb__1).ToArray();
			}
		}
	}

	private (string key, string region, byte[] value, TimeSpan duration)[] ConvertEntriesForDistribution(CacheEntry[] entries)
	{
		return entries.Select((CacheEntry e) => (ExtractKey(e.Key), ExtractRegion(e.Key), e.Value, e.Expiration - DateTime.UtcNow)).ToArray();
	}

	private void AddToCache(string key, byte[] value, TimeSpan duration)
	{
		int num = 4;
		double angle = default(double);
		uint hash = default(uint);
		CacheEntry cacheEntry = default(CacheEntry);
		CacheItemPolicy cacheItemPolicy2 = default(CacheItemPolicy);
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					angle = R8sTbefTXELplyT0lCEs(hash);
					num = 7;
					break;
				default:
					hash = key.ToHash();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					xoBNkOfTku7W3jAhWVJc(Cache, key, cacheEntry, cacheItemPolicy2, null);
					num2 = 2;
					continue;
				case 5:
				{
					CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
					ePGVYafTTeB0pjceuExn(cacheItemPolicy, dateTime2);
					cacheItemPolicy2 = cacheItemPolicy;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 2:
					return;
				case 3:
					dateTime2 = dateTime.Add(duration);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					cacheEntry = new CacheEntry(key, value, hash, angle, dateTime2);
					num = 5;
					break;
				case 4:
					dateTime = oQQeHsfTK7nvDS4BPa4O();
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	private string GetCacheKey(string key, string region)
	{
		//Discarded unreachable code: IL_002e, IL_005d, IL_006c
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = region;
				break;
			case 1:
				if (g5Be7efTnNZ3I3WYSgYX(region))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			default:
				text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633171013);
				break;
			}
			break;
		}
		return (string)eWYoZ3fT2fXAWbPyoFYS(text, GtkNSVfTOrA8gryjDEdI(-1123633026 ^ -1123555012), key);
	}

	private string ExtractKey(string key)
	{
		return (string)((object[])YY0EBrfTeYN72OJMuLS7(key, new char[1] { ':' }))[1];
	}

	private string ExtractRegion(string key)
	{
		//Discarded unreachable code: IL_00a3
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				return text;
			default:
				if (!(text == (string)GtkNSVfTOrA8gryjDEdI(0x8317432 ^ 0x83431DC)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				text = (string)((object[])YY0EBrfTeYN72OJMuLS7(key, new char[1] { ':' }))[0];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			}
			text = string.Empty;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
			{
				num2 = 4;
			}
		}
	}

	private string CacheEntriesToString((string key, string region, byte[] value, TimeSpan duration)[] data)
	{
		return string.Join((string)GtkNSVfTOrA8gryjDEdI(-1870892489 ^ -1870889419), data.Select(((string key, string region, byte[] value, TimeSpan duration) x) => GetCacheKey(x.key, x.region) ?? ""));
	}

	private string KeyAnglesToString((double start, double end)[] keyAngles)
	{
		return string.Join((string)GtkNSVfTOrA8gryjDEdI(0x4EA5403C ^ 0x4EA54C3E), keyAngles.Select(((double start, double end) r) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70139725), r.start, r.end)));
	}

	static ConsistentHashingCacheActor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				H6wkLmfTP5xxljDOhrW6();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Cache = new MemoryCache(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA00630));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static Type sulmmyfTV2CVDgW17vN9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object oTEKtpfTSWJqafBO2H5g(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static object sgleEofTi1vRs6MwjPQr(object P_0)
	{
		return ((IOptionsProvider)P_0).Options;
	}

	internal static Guid WjpriqfTRBi8fMB3cVeF(object P_0)
	{
		return ((IRuntimeApplication)P_0).ConnectionUid;
	}

	internal static bool dUsvuofTu7fRGajHUgAq()
	{
		return SJTOjKfTZekBARWk63ch == null;
	}

	internal static ConsistentHashingCacheActor fEhw6SfTIrbFoPl1aFnJ()
	{
		return SJTOjKfTZekBARWk63ch;
	}

	internal static AsyncTaskMethodBuilder n4pwGWfTquFvcIurGRQB()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static DateTime oQQeHsfTK7nvDS4BPa4O()
	{
		return DateTime.UtcNow;
	}

	internal static double R8sTbefTXELplyT0lCEs(uint hash)
	{
		return hash.ToAngle();
	}

	internal static void ePGVYafTTeB0pjceuExn(object P_0, DateTimeOffset P_1)
	{
		((CacheItemPolicy)P_0).AbsoluteExpiration = P_1;
	}

	internal static void xoBNkOfTku7W3jAhWVJc(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((ObjectCache)P_0).Set((string)P_1, P_2, (CacheItemPolicy)P_3, (string)P_4);
	}

	internal static bool g5Be7efTnNZ3I3WYSgYX(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object GtkNSVfTOrA8gryjDEdI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object eWYoZ3fT2fXAWbPyoFYS(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object YY0EBrfTeYN72OJMuLS7(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void H6wkLmfTP5xxljDOhrW6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
