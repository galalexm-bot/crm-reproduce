using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

[Service]
public class PoolBasedSettingsService
{
	private class KeedValue
	{
		public readonly List<object> objects;

		public readonly int version;

		internal static object irNr83QLAuPDmsAuHqL8;

		public KeedValue(KeedValue keedValue)
		{
			//Discarded unreachable code: IL_0036, IL_003b
			Nk68RcQL0DbitxDd4Xj3();
			this._002Ector(keedValue.version, keedValue.objects);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public KeedValue(int version, List<object> objects)
		{
			SingletonReader.JJCZtPuTvSt();
			this.objects = new List<object>();
			base._002Ector();
			this.version = version;
			this.objects = objects;
		}

		internal static void Nk68RcQL0DbitxDd4Xj3()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool sgMq7yQL7nQl2qIc1mbn()
		{
			return irNr83QLAuPDmsAuHqL8 == null;
		}

		internal static KeedValue cYmcYaQLx799bbDYMhXf()
		{
			return (KeedValue)irNr83QLAuPDmsAuHqL8;
		}
	}

	private class PooledObjectsHolder
	{
		public List<Tuple<object, int, string>> objects;

		private static object fcO7rZQLmAAnkpN4yvJV;

		public PooledObjectsHolder()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			V39XirQLJT7mTGpFRl6A();
			objects = new List<Tuple<object, int, string>>();
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

		internal static void V39XirQLJT7mTGpFRl6A()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool bKTDvCQLyYtGiN729AJN()
		{
			return fcO7rZQLmAAnkpN4yvJV == null;
		}

		internal static PooledObjectsHolder WlIw0GQLMb7F3QuIDUbD()
		{
			return (PooledObjectsHolder)fcO7rZQLmAAnkpN4yvJV;
		}
	}

	private static readonly ILogger Log;

	private readonly IBLOBStore blobStore;

	private readonly IContextBoundVariableService contextObjects;

	internal static PoolBasedSettingsService cU8eDkWJVq1YY705RgnJ;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PoolBasedSettingsService(IBLOBStore blobStore, IContextBoundVariableService contextObjects)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ybs5JAWJRao9KoJZwY4E();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				this.contextObjects = contextObjects;
				num = 2;
				break;
			case 1:
				this.blobStore = blobStore;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 3;
				}
				break;
			case 2:
				Logger = NullLogger.Instance;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public object GetObject(string key)
	{
		//Discarded unreachable code: IL_00a7, IL_00d9, IL_0111, IL_0120
		int num = 3;
		byte[] array = default(byte[]);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (key != null)
					{
						array = (byte[])YeugXbWJK4chgFnEcxGA(blobStore, key);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 2:
					throw new ArgumentNullException((string)Umr92CWJq8o3ukbjEPv8(-882126494 ^ -882202942));
				case 1:
					try
					{
						obj = DeserializeObject(array);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => obj, 
							_ => obj, 
						};
					}
					catch (Exception)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								obj = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num4 = 0;
								}
								break;
							default:
								return obj;
							case 0:
								return obj;
							}
						}
					}
				default:
					if (array != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					break;
				}
				return null;
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	private object DeserializeObject(byte[] bytes)
	{
		//Discarded unreachable code: IL_0047, IL_007a, IL_009d, IL_0114, IL_0123
		switch (1)
		{
		case 1:
			try
			{
				object result = ClassSerializationHelper.DeserializeObject(bytes);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => result, 
					_ => result, 
				};
			}
			catch (SerializationException exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 2:
						Logger.Error(exception, (string)MOq1VUWJXswHjI1V6wkZ(Umr92CWJq8o3ukbjEPv8(0x4EA5403C ^ 0x4EA770A4)));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						break;
					default:
						if (!Logger.IsErrorEnabled())
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 2;
					case 1:
					case 3:
						throw;
					}
				}
			}
		default:
		{
			object result = default(object);
			return result;
		}
		}
	}

	public void SetObject(string key, object value)
	{
		int num = 3;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				array = ClassSerializationHelper.SerializeObject(value);
				num2 = 2;
				continue;
			case 4:
				p9YWa9WJncvXdInjOZcX(Log, kSJnk5WJkxrudI8OcFXS(Umr92CWJq8o3ukbjEPv8(-1317790512 ^ -1317655522), key));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (HNHdL3WJTjfPmbGIDyaU(Log, LogLevel.Debug))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 1:
				break;
			case 0:
				return;
			}
			roa6RAWJONnV1QETUCmG(blobStore, key, array);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num2 = 0;
			}
		}
	}

	public void Release(string key, object value)
	{
	}

	public void Release()
	{
	}

	private void Release(object value, int version, string key)
	{
	}

	public void RemoveObject(string s)
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
				W4cV7yWJ2WC5P44KkxtF(blobStore, s);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static PoolBasedSettingsService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Ybs5JAWJRao9KoJZwY4E();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Log = (ILogger)Tm6SEvWJPgagt7wKv676(EYWQqfWJeYEB02wKK0IM(typeof(PoolBasedSettingsService).TypeHandle));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool V2FoIVWJSNbvEIxNPo9m()
	{
		return cU8eDkWJVq1YY705RgnJ == null;
	}

	internal static PoolBasedSettingsService QZYOSeWJicCuoFSdnruM()
	{
		return cU8eDkWJVq1YY705RgnJ;
	}

	internal static void Ybs5JAWJRao9KoJZwY4E()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Umr92CWJq8o3ukbjEPv8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YeugXbWJK4chgFnEcxGA(object P_0, object P_1)
	{
		return ((IBLOBStore)P_0).LoadOrNull((string)P_1);
	}

	internal static object MOq1VUWJXswHjI1V6wkZ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool HNHdL3WJTjfPmbGIDyaU(object P_0, LogLevel level)
	{
		return ((ILogger)P_0).IsEnabled(level);
	}

	internal static object kSJnk5WJkxrudI8OcFXS(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void p9YWa9WJncvXdInjOZcX(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void roa6RAWJONnV1QETUCmG(object P_0, object P_1, object P_2)
	{
		((IBLOBStore)P_0).Save((string)P_1, (byte[])P_2);
	}

	internal static void W4cV7yWJ2WC5P44KkxtF(object P_0, object P_1)
	{
		((IBLOBStore)P_0).Remove((string)P_1);
	}

	internal static Type EYWQqfWJeYEB02wKK0IM(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Tm6SEvWJPgagt7wKv676(Type componentType)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger(componentType);
	}
}
