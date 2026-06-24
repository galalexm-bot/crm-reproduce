using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

[Service(Type = ComponentType.Server)]
public class DbUpdateMarkerService
{
	internal static class Structure
	{
		public static class Fields
		{
			public const string ModuleUid = "ModuleUid";

			public const string MarkerName = "MarkerName";

			public const string MarkerValue = "MarkerValue";

			public const string CreationDate = "CreationDate";

			public const string ChangeDate = "ChangeDate";
		}

		public const string TableName = "DB_MARKER";
	}

	private ConcurrentDictionary<KeyValuePair<Guid, string>, string> cache;

	private static DbUpdateMarkerService PFrkKoWZ3HyFBZme17SH;

	public ITransformationProvider Transform
	{
		[CompilerGenerated]
		get
		{
			return _003CTransform_003Ek__BackingField;
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
					_003CTransform_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string GetMarker(Guid moduleUid, string markerName)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0086, IL_00eb, IL_0123
		int num = 5;
		IDataReader dataReader = default(IDataReader);
		string value = default(string);
		KeyValuePair<Guid, string> key = default(KeyValuePair<Guid, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					try
					{
						if (!Lr8pS9WZtlnZigjFhICh(dataReader))
						{
							break;
						}
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								value = (string)dNVlvMWZwOdib8jNsM9e(dataReader, 0);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (dataReader != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									dataReader.Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				case 2:
					return value;
				case 5:
					Contract.ServiceNotNull(Transform, (string)nSlGLmWZDK6dqOHpaHsR(-1633514411 ^ -1633470837));
					num2 = 4;
					continue;
				case 3:
					return value;
				default:
					goto end_IL_0012;
				case 4:
					key = new KeyValuePair<Guid, string>(moduleUid, markerName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (!cache.TryGetValue(key, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 6:
					dataReader = Transform.ExecuteQuery((string)nSlGLmWZDK6dqOHpaHsR(0x1FFEF86A ^ 0x1FFF429E), new Dictionary<string, object>
					{
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886538207),
							moduleUid
						},
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852945984),
							markerName
						}
					});
					num2 = 7;
					continue;
				case 8:
					break;
				}
				cache[key] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			value = null;
			num = 6;
		}
	}

	public void SetMarker(Guid moduleUid, string markerName, string value)
	{
		//Discarded unreachable code: IL_009f
		int num = 5;
		int num2 = num;
		KeyValuePair<Guid, string> key = default(KeyValuePair<Guid, string>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				cache[key] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				UKmRGGWZ4yuNZPdZ7Zuu(Transform, nSlGLmWZDK6dqOHpaHsR(-1824388195 ^ -1824280253));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 2;
				}
				continue;
			case 0:
				return;
			case 6:
				Transform.Update((string)nSlGLmWZDK6dqOHpaHsR(0x8317432 ^ 0x830C8A2), new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDD0694) }, new object[1] { value }, (string)nSlGLmWZDK6dqOHpaHsR(-606654180 ^ -606695972), new Dictionary<string, object>
				{
					{
						(string)nSlGLmWZDK6dqOHpaHsR(-345420348 ^ -345442710),
						moduleUid
					},
					{
						(string)nSlGLmWZDK6dqOHpaHsR(0x26FFCB59 ^ 0x26FE709D),
						markerName
					}
				});
				num2 = 3;
				continue;
			case 4:
				if (VvfNbNWZ6xOKwUvk9Zxk(Transform.ExecuteScalar((string)nSlGLmWZDK6dqOHpaHsR(-35995181 ^ -35948017), new Dictionary<string, object>
				{
					{
						(string)nSlGLmWZDK6dqOHpaHsR(-97972138 ^ -97997832),
						moduleUid
					},
					{
						(string)nSlGLmWZDK6dqOHpaHsR(-1638402543 ^ -1638511147),
						markerName
					}
				})) > 0)
				{
					num2 = 6;
					continue;
				}
				break;
			case 2:
			case 3:
				key = new KeyValuePair<Guid, string>(moduleUid, markerName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				break;
			}
			Transform.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870803289), new string[1] { (string)nSlGLmWZDK6dqOHpaHsR(-1765851862 ^ -1765899892) }, new object[1] { value }, (string)nSlGLmWZDK6dqOHpaHsR(-675505729 ^ -675469953), new Dictionary<string, object>
			{
				{
					(string)nSlGLmWZDK6dqOHpaHsR(-477139494 ^ -477178252),
					moduleUid
				},
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A608E7A),
					markerName
				}
			});
			num2 = 2;
		}
	}

	public DbUpdateMarkerService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		mTbt6pWZHjwTcmOYf39V();
		cache = new ConcurrentDictionary<KeyValuePair<Guid, string>, string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NR7CbLWZpQMlbDWI92F1()
	{
		return PFrkKoWZ3HyFBZme17SH == null;
	}

	internal static DbUpdateMarkerService USqaauWZaPRBESgj8lKS()
	{
		return PFrkKoWZ3HyFBZme17SH;
	}

	internal static object nSlGLmWZDK6dqOHpaHsR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Lr8pS9WZtlnZigjFhICh(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static object dNVlvMWZwOdib8jNsM9e(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static void UKmRGGWZ4yuNZPdZ7Zuu(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static int VvfNbNWZ6xOKwUvk9Zxk(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static void mTbt6pWZHjwTcmOYf39V()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
