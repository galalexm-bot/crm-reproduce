using System;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Cache.ActorModel.Actors;
using EleWise.ELMA.Cache.ActorModel.Configuration;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache.ActorModel;

internal sealed class ActorModelCacheService : CacheService, IOptionsProvider
{
	private XmlObjectSerializer serializer;

	internal static ActorModelCacheService zbRHZUfXnQKy9weJsJcQ;

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CacheOptions Options
	{
		[CompilerGenerated]
		get
		{
			return _003COptions_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003COptions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public XmlObjectSerializer Serializer
	{
		get
		{
			int num = 2;
			int num2 = num;
			XmlObjectSerializer xmlObjectSerializer2;
			XmlObjectSerializer xmlObjectSerializer = default(XmlObjectSerializer);
			while (true)
			{
				switch (num2)
				{
				case 2:
					xmlObjectSerializer2 = serializer;
					if (xmlObjectSerializer2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					xmlObjectSerializer = (serializer = new NetDataContractSerializer());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					xmlObjectSerializer2 = xmlObjectSerializer;
					break;
				}
				break;
			}
			return xmlObjectSerializer2;
		}
	}

	public override bool IsDistributed => true;

	public override void Initialize(string name, NameValueCollection config)
	{
		//Discarded unreachable code: IL_00af
		int num = 2;
		int num2 = num;
		CacheOptions cacheOptions = default(CacheOptions);
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				G6oQfIfX1QvIHO8UtFWl(cacheOptions, (byte)result);
				num2 = 4;
				break;
			case 3:
			case 4:
				Options = cacheOptions;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (!int.TryParse((string)LQovO1fXPNOsVlDwUfH5(config, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317971526)), out result))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 2:
				eXeA4tfXeJXsgw3tdYZH(this, name, config);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				cacheOptions = new CacheOptions();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	protected override void ClearRegionInternal(string region)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				InvokeActor(_003C_003Ec__DisplayClass18_._003CClearRegionInternal_003Eb__0);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass18_.actor = GetActor();
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass18_.region = region;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected override bool ContainsInternal(string key, string region)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass19_.key = key;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass19_.actor = GetActor();
				num2 = 3;
				break;
			case 2:
				_003C_003Ec__DisplayClass19_.region = region;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				return InvokeActor(_003C_003Ec__DisplayClass19_._003CContainsInternal_003Eb__0);
			}
		}
	}

	protected override object GetValue(string key, string region)
	{
		//Discarded unreachable code: IL_0102, IL_0111
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		CacheResult cacheResult = default(CacheResult);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 6;
				break;
			case 6:
				_003C_003Ec__DisplayClass20_.key = key;
				num2 = 2;
				break;
			case 3:
				return null;
			case 4:
				return Deserialize(cacheResult.Value);
			case 5:
				cacheResult = InvokeActor(_003C_003Ec__DisplayClass20_._003CGetValue_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (cacheResult.Success)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 2:
				_003C_003Ec__DisplayClass20_.region = region;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass20_.actor = GetActor();
				num2 = 5;
				break;
			}
		}
	}

	protected override void InsertValue<T>(string key, object value, string region, TimeSpan cacheDuration, CacheItemRemovedCallback<T> onRemoveItemCallback)
	{
		_003C_003Ec__DisplayClass21_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0<T>();
		CS_0024_003C_003E8__locals0.key = key;
		CS_0024_003C_003E8__locals0.region = region;
		CS_0024_003C_003E8__locals0.cacheDuration = cacheDuration;
		CS_0024_003C_003E8__locals0.actor = GetActor();
		CS_0024_003C_003E8__locals0.serializedValue = Serialize(value);
		InvokeActor(() => CS_0024_003C_003E8__locals0.actor.Set(CS_0024_003C_003E8__locals0.key, CS_0024_003C_003E8__locals0.region, CS_0024_003C_003E8__locals0.serializedValue, CS_0024_003C_003E8__locals0.cacheDuration));
	}

	protected override void RemoveInternal(string key, string region)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass22_.key = key;
				num2 = 5;
				break;
			case 5:
				_003C_003Ec__DisplayClass22_.region = region;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
				num2 = 2;
				break;
			case 4:
				InvokeActor(_003C_003Ec__DisplayClass22_._003CRemoveInternal_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass22_.actor = GetActor();
				num2 = 4;
				break;
			}
		}
	}

	private IConsistentHashingCacheActor GetActor()
	{
		int num = 1;
		int num2 = num;
		Guid connectionUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				connectionUid = RuntimeApplication.ConnectionUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ActorModelRuntime.GetActor<IConsistentHashingCacheActor>(connectionUid);
			}
		}
	}

	private byte[] Serialize(object value)
	{
		//Discarded unreachable code: IL_005a, IL_0085, IL_0109, IL_0128, IL_0137, IL_0185, IL_01c5, IL_01d4, IL_01e0
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					GZipStream gZipStream = new GZipStream((Stream)xeGSM5fX3woMRlZVj3af(memoryStream), CompressionMode.Compress);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							UhPmHXfXpXpfEubjgQHS(Serializer, gZipStream, value);
							int num4 = 2;
							while (true)
							{
								switch (num4)
								{
								default:
									result = (byte[])cS3BvLfXDrN90fXTLcKq(memoryStream);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num4 = 1;
									}
									break;
								case 2:
									IdVcdufXaXcJII6gBJvf(gZipStream);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num4 = 0;
									}
									break;
								case 1:
									return result;
								}
							}
						}
						finally
						{
							int num5;
							if (gZipStream == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num5 = 0;
								}
								goto IL_010d;
							}
							goto IL_0142;
							IL_0142:
							h0LrPGfXtotieG46tUDt(gZipStream);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num5 = 1;
							}
							goto IL_010d;
							IL_010d:
							switch (num5)
							{
							default:
								goto end_IL_00e8;
							case 0:
								goto end_IL_00e8;
							case 2:
								break;
							case 1:
								goto end_IL_00e8;
							}
							goto IL_0142;
							end_IL_00e8:;
						}
					}
				}
				finally
				{
					int num6;
					if (memoryStream == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num6 = 0;
						}
						goto IL_0189;
					}
					goto IL_019f;
					IL_019f:
					h0LrPGfXtotieG46tUDt(memoryStream);
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num6 = 1;
					}
					goto IL_0189;
					IL_0189:
					switch (num6)
					{
					default:
						goto end_IL_0164;
					case 2:
						break;
					case 0:
						goto end_IL_0164;
					case 1:
						goto end_IL_0164;
					}
					goto IL_019f;
					end_IL_0164:;
				}
			case 2:
				memoryStream = (MemoryStream)SdQBsZfXNX6h2SepTTuk();
				num2 = 4;
				break;
			case 3:
				return result;
			case 1:
				value = CacheService.AssembleValue(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				result = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private object Deserialize(object value)
	{
		//Discarded unreachable code: IL_0078, IL_00b4, IL_00ec, IL_0145, IL_0175, IL_0184, IL_0190, IL_019f
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = (MemoryStream)u8s4uGfXwa3ahPY1JrCu(value as byte[], false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						result = eaqO2cfX445PbCiw1twl(Serializer, gZipStream);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num4 = 0;
						}
						return num4 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						if (gZipStream != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									h0LrPGfXtotieG46tUDt(gZipStream);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
			}
			finally
			{
				int num6;
				if (memoryStream == null)
				{
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num6 = 0;
					}
					goto IL_0149;
				}
				goto IL_015f;
				IL_015f:
				h0LrPGfXtotieG46tUDt(memoryStream);
				num6 = 2;
				goto IL_0149;
				IL_0149:
				switch (num6)
				{
				default:
					goto end_IL_0124;
				case 1:
					break;
				case 0:
					goto end_IL_0124;
				case 2:
					goto end_IL_0124;
				}
				goto IL_015f;
				end_IL_0124:;
			}
		}
	}

	private void InvokeActor(Func<Task> func)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.func = func;
		Task.Run(delegate
		{
			//Discarded unreachable code: IL_0074, IL_00ac, IL_00e4, IL_00f3
			int num = 1;
			int num2 = num;
			CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
			Task task = default(Task);
			while (true)
			{
				switch (num2)
				{
				case 1:
					callContextSessionOwner = CallContextSessionOwner.Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return task;
				default:
					try
					{
						task = _003C_003Ec__DisplayClass26_.func();
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => task, 
							_ => task, 
						};
					}
					finally
					{
						if (callContextSessionOwner != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									((IDisposable)callContextSessionOwner).Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
			}
		}).Wait();
	}

	private T InvokeActor<T>(Func<Task<T>> func)
	{
		_003C_003Ec__DisplayClass27_0<T> _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0<T>();
		_003C_003Ec__DisplayClass27_.func = func;
		return Task.Run(delegate
		{
			using (CallContextSessionOwner.Create())
			{
				return _003C_003Ec__DisplayClass27_.func();
			}
		}).Result;
	}

	public ActorModelCacheService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OAkLjTfX6X2eWMbBCMYa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hZ0GayfXOQ6fXBhhX1I5()
	{
		return zbRHZUfXnQKy9weJsJcQ == null;
	}

	internal static ActorModelCacheService tPYv41fX2mVfZRQqLRr0()
	{
		return zbRHZUfXnQKy9weJsJcQ;
	}

	internal static void eXeA4tfXeJXsgw3tdYZH(object P_0, object P_1, object P_2)
	{
		((ProviderBase)P_0).Initialize((string)P_1, (NameValueCollection)P_2);
	}

	internal static object LQovO1fXPNOsVlDwUfH5(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static void G6oQfIfX1QvIHO8UtFWl(object P_0, byte value)
	{
		((CacheOptions)P_0).ReplicaFactor = value;
	}

	internal static object SdQBsZfXNX6h2SepTTuk()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object xeGSM5fX3woMRlZVj3af(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static void UhPmHXfXpXpfEubjgQHS(object P_0, object P_1, object P_2)
	{
		((XmlObjectSerializer)P_0).WriteObject((Stream)P_1, P_2);
	}

	internal static void IdVcdufXaXcJII6gBJvf(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object cS3BvLfXDrN90fXTLcKq(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void h0LrPGfXtotieG46tUDt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object u8s4uGfXwa3ahPY1JrCu(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object eaqO2cfX445PbCiw1twl(object P_0, object P_1)
	{
		return ((XmlObjectSerializer)P_0).ReadObject((Stream)P_1);
	}

	internal static void OAkLjTfX6X2eWMbBCMYa()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
