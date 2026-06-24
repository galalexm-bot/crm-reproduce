using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class SessionFactoryHolder
{
	private class FreeObject
	{
		private static object ojT4t1QlxQcCUpOMMZwZ;

		public bool Closed
		{
			[CompilerGenerated]
			get
			{
				return _003CClosed_003Ek__BackingField;
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
						_003CClosed_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

		public List<string> Regions { get; set; }

		public FreeObject()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ArLY1BQlylEqhQABrPTh();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool YTGEhOQl0TPjLxfrhGmb()
		{
			return ojT4t1QlxQcCUpOMMZwZ == null;
		}

		internal static FreeObject HyvDieQlm9Qe82w95KvU()
		{
			return (FreeObject)ojT4t1QlxQcCUpOMMZwZ;
		}

		internal static void ArLY1BQlylEqhQABrPTh()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private ILogger logger;

	private ISessionFactory sessionFactory;

	private Configuration configuration;

	private Timer checkSessionFactoryTimer;

	private readonly PublishCacheContext.Local<FreeObject> freeObject;

	private readonly List<(WeakReference<FreeObject> sessionFactory, IList<string> regions)> freeObjects;

	private readonly ContextVars.Local<bool> isPublication;

	private List<NHManagerRegisterParams> registerParams;

	private static SessionFactoryHolder KFeOlYW6Xw17mCqEX2Mw;

	public ISessionFactory SessionFactory
	{
		get
		{
			return sessionFactory;
		}
		set
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
					sessionFactory = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					WDUppGW6P4k01IRLKRdC(value, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106499406));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Configuration Configuration
	{
		get
		{
			return (Configuration)(object)configuration;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					WDUppGW6P4k01IRLKRdC(value, YeW5bJW6e0wXh80ohxQX(0x6DC147B0 ^ 0x6DC10EC6));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					configuration = (Configuration)(object)value;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SessionFactoryHolder(Configuration configuration)
	{
		//Discarded unreachable code: IL_0054, IL_0059
		E9UNGUW6nTvHG2rnaIdH();
		logger = (ILogger)fgK3cmW62JS2q2V0k0nh(Ck0ZTBW6Okdv8D9TotVx(typeof(SessionFactoryHolder).TypeHandle));
		freeObjects = new List<(WeakReference<FreeObject>, IList<string>)>();
		isPublication = new ContextVars.Local<bool>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			default:
				this.configuration = (Configuration)(object)configuration;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				WDUppGW6P4k01IRLKRdC(configuration, YeW5bJW6e0wXh80ohxQX(0x63ABA4E8 ^ 0x63AA67EA));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				freeObject = new PublishCacheContext.Local<FreeObject>(PublicationStart, PublicationEnd, PublicationEnd, SessionFactoryClear);
				num = 3;
				break;
			}
		}
	}

	internal void CreateSessionFactory()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				Eu5Gn5W63IQZjOoTr2FI(W9i5EbW6NTRsY28SiRmb(sessionFactory), true);
				num2 = 4;
				break;
			case 4:
				jfqOuaW61i8oQyKjRyZ6(logger, YeW5bJW6e0wXh80ohxQX(-541731959 ^ -541593507));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				sessionFactory = configuration.BuildSessionFactory();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				jfqOuaW61i8oQyKjRyZ6(logger, YeW5bJW6e0wXh80ohxQX(-1217523399 ^ -1217645921));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void UpdateConfiguration(NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_005d, IL_008b, IL_014c, IL_01ae, IL_01bd, IL_0218, IL_0227, IL_02a3, IL_02db, IL_02ea, IL_036e, IL_03e0, IL_042f, IL_0492
		int num = 6;
		int num2 = num;
		List<(WeakReference<FreeObject>, IList<string>)> list4 = default(List<(WeakReference<FreeObject>, IList<string>)>);
		bool lockTaken = default(bool);
		List<string> list = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 10:
				try
				{
					Monitor.Enter(list4, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 7:
						case 11:
							AT0A8QW6tZF8o7DFqtFB(NHCacheWrapper.DisableCache(list));
							num3 = 3;
							continue;
						case 1:
						case 5:
							if (!logger.IsInfoEnabled())
							{
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
								{
									num3 = 6;
								}
								continue;
							}
							break;
						case 4:
						case 9:
						{
							List<(WeakReference<FreeObject> sessionFactory, IList<string> regions)> list5 = freeObjects;
							PublishCacheContext.Local<FreeObject> local = freeObject;
							FreeObject obj = new FreeObject
							{
								Regions = list
							};
							FreeObject target = obj;
							local.Value = obj;
							list5.Add((new WeakReference<FreeObject>(target), list));
							num3 = 5;
							continue;
						}
						case 6:
							checkSessionFactoryTimer = new Timer(CheckSessionFactory, null, NXqLuAW6w8BcecJia4Hs(1.0), NXqLuAW6w8BcecJia4Hs(1.0));
							num3 = 10;
							continue;
						case 3:
							if (checkSessionFactoryTimer == null)
							{
								num3 = 6;
								continue;
							}
							goto end_IL_008f;
						default:
							if (freeObject.Value == null)
							{
								num3 = 9;
								continue;
							}
							goto case 8;
						case 8:
							freeObject.Value.Regions.AddRange(list);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							break;
						case 10:
							goto end_IL_008f;
						}
						logger.InfoFormat((string)YeW5bJW6e0wXh80ohxQX(0x68BBB53E ^ 0x68B99182), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106516538), list));
						num3 = 11;
						continue;
						end_IL_008f:
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								NfNCFDW64svkyUcJYy0Z(list4);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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
				goto case 4;
			case 12:
				return;
			case 5:
				if (isPublication.Value)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (isPublication.Value)
				{
					num2 = 7;
					break;
				}
				goto case 9;
			case 14:
				try
				{
					configuration.UpdateSessionFactory(SessionFactory, parameters.CreateModelMapper(), list);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							logger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3632D723));
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num5 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							throw;
						}
						SoE66XW6D9gj8VJ9dtv3(logger, YeW5bJW6e0wXh80ohxQX(-1876063057 ^ -1875924947), ex);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num6 = 1;
						}
					}
				}
				goto case 3;
			case 9:
			{
				List<NHManagerRegisterParams> list2 = registerParams;
				if (list2 == null)
				{
					num2 = 13;
					break;
				}
				list2.Add(parameters);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 8;
				}
				break;
			}
			default:
			{
				List<NHManagerRegisterParams> list3 = Interlocked.Exchange(ref registerParams, null);
				list3.ForEach(parameters.Add);
				v5lQ5rW6aQlqfJxdVkqV(list3);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 3:
				list4 = freeObjects;
				num2 = 2;
				break;
			case 2:
				lockTaken = false;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 10;
				}
				break;
			case 6:
				if (!YngqrkW6pWTB2bQC8tum(parameters))
				{
					return;
				}
				num2 = 5;
				break;
			case 1:
				jfqOuaW61i8oQyKjRyZ6(logger, YeW5bJW6e0wXh80ohxQX(0x571EA399 ^ 0x571C878D));
				num2 = 11;
				break;
			case 8:
				return;
			case 11:
				list = new List<string>();
				num2 = 14;
				break;
			case 13:
				return;
			}
		}
	}

	private FreeObject PublicationStart(FreeObject _)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				Interlocked.Exchange(ref registerParams, new List<NHManagerRegisterParams>());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				isPublication.Value = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return null;
			}
		}
	}

	private void PublicationEnd(FreeObject _)
	{
		int num = 2;
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
			case 3:
				isPublication.Value = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				List<NHManagerRegisterParams> list = Interlocked.Exchange(ref registerParams, null);
				if (list == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					list.Clear();
					num2 = 3;
				}
				break;
			}
			}
		}
	}

	private void SessionFactoryClear(FreeObject freeObject)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (freeObject != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 1:
					sp021FW66tA3A6GrTAYU(freeObject, true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			ThreadStarter.QueueThread(CheckSessionFactory, checkSessionFactoryTimer);
			num = 3;
		}
	}

	private void CheckSessionFactory(object sender)
	{
		//Discarded unreachable code: IL_0050, IL_0182, IL_0191, IL_0245, IL_027d, IL_028c
		int num = 3;
		int num2 = num;
		List<(WeakReference<FreeObject>, IList<string>)> list = default(List<(WeakReference<FreeObject>, IList<string>)>);
		bool lockTaken = default(bool);
		_003C_003Ec__DisplayClass20_1 _003C_003Ec__DisplayClass20_2 = default(_003C_003Ec__DisplayClass20_1);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					Monitor.Enter(list, ref lockTaken);
					int num3 = 5;
					while (true)
					{
						switch (num3)
						{
						case 1:
							L4EfA2W6HHYjL5Zix3I6(checkSessionFactoryTimer);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num3 = 0;
							}
							continue;
						case 9:
							_003C_003Ec__DisplayClass20_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass20_;
							num3 = 8;
							continue;
						default:
							freeObjects.RemoveAll(_003C_003Ec__DisplayClass20_2._003CCheckSessionFactory_003Eb__0);
							num3 = 12;
							continue;
						case 12:
							if (freeObjects.Count != 0)
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto case 1;
						case 4:
							GC.Collect();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num3 = 1;
							}
							continue;
						case 7:
						case 10:
							if (_003C_003Ec__DisplayClass20_2.needCollect)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							break;
						case 6:
							checkSessionFactoryTimer = null;
							num3 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num3 = 9;
							}
							continue;
						case 8:
							_003C_003Ec__DisplayClass20_2.needCollect = false;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num3 = 0;
							}
							continue;
						case 11:
							_003C_003Ec__DisplayClass20_2 = new _003C_003Ec__DisplayClass20_1();
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num3 = 9;
							}
							continue;
						case 2:
							jfqOuaW61i8oQyKjRyZ6(logger, YeW5bJW6e0wXh80ohxQX(0x20261A4F ^ 0x20243EA7));
							num3 = 4;
							continue;
						case 5:
							if (checkSessionFactoryTimer != null)
							{
								num3 = 11;
								continue;
							}
							break;
						case 3:
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								NfNCFDW64svkyUcJYy0Z(list);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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
				goto case 5;
			case 1:
				lockTaken = false;
				num2 = 4;
				break;
			default:
				list = freeObjects;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 2;
				break;
			case 6:
				return;
			case 5:
				NHCacheWrapper.EnableCache(_003C_003Ec__DisplayClass20_.enableRegions).Wait();
				num2 = 6;
				break;
			case 2:
				_003C_003Ec__DisplayClass20_._003C_003E4__this = this;
				num2 = 7;
				break;
			case 7:
				_003C_003Ec__DisplayClass20_.enableRegions = new List<string>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void E9UNGUW6nTvHG2rnaIdH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type Ck0ZTBW6Okdv8D9TotVx(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object fgK3cmW62JS2q2V0k0nh(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static object YeW5bJW6e0wXh80ohxQX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WDUppGW6P4k01IRLKRdC(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool cgZcOXW6T10CQGj4jgIo()
	{
		return KFeOlYW6Xw17mCqEX2Mw == null;
	}

	internal static SessionFactoryHolder h46EhFW6k0QmBx8jFkSL()
	{
		return KFeOlYW6Xw17mCqEX2Mw;
	}

	internal static void jfqOuaW61i8oQyKjRyZ6(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object W9i5EbW6NTRsY28SiRmb(object P_0)
	{
		return ((ISessionFactory)P_0).get_Statistics();
	}

	internal static void Eu5Gn5W63IQZjOoTr2FI(object P_0, bool P_1)
	{
		((IStatistics)P_0).set_IsStatisticsEnabled(P_1);
	}

	internal static bool YngqrkW6pWTB2bQC8tum(object P_0)
	{
		return ((NHManagerRegisterParams)P_0).HasItems;
	}

	internal static void v5lQ5rW6aQlqfJxdVkqV(object P_0)
	{
		((List<NHManagerRegisterParams>)P_0).Clear();
	}

	internal static void SoE66XW6D9gj8VJ9dtv3(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void AT0A8QW6tZF8o7DFqtFB(object P_0)
	{
		((Task)P_0).Wait();
	}

	internal static TimeSpan NXqLuAW6w8BcecJia4Hs(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static void NfNCFDW64svkyUcJYy0Z(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void sp021FW66tA3A6GrTAYU(object P_0, bool value)
	{
		((FreeObject)P_0).Closed = value;
	}

	internal static void L4EfA2W6HHYjL5Zix3I6(object P_0)
	{
		((Timer)P_0).Dispose();
	}
}
