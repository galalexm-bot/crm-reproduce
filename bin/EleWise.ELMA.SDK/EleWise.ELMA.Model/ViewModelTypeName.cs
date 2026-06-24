using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model;

public sealed class ViewModelTypeName
{
	private static IList<string> assemblyNames;

	private static Dictionary<string, ICollection<string>> ambiguousTypes;

	private static ViewModelTypeName QU91FpWgFVLR1E6TYVSO;

	private static Dictionary<string, ICollection<string>> AmbiguousTypes
	{
		get
		{
			if (ambiguousTypes == null)
			{
				ambiguousTypes = (from t in (from a in AppDomain.CurrentDomain.GetAssemblies()
						join n in assemblyNames on (string)_003C_003Ec.leQpNIQz7f6N20vm3vKF(_003C_003Ec.c0gAsCQzAeXKC1s2ATM7(a)) equals n
						select a).SelectMany(delegate(Assembly a)
					{
						try
						{
							return a.GetTypes();
						}
						catch (ReflectionTypeLoadException ex)
						{
							return ex.Types;
						}
					}).Where(delegate(Type t)
					{
						//Discarded unreachable code: IL_003d, IL_009e, IL_00ad, IL_00bc, IL_00cd, IL_00f2, IL_0134, IL_016c, IL_017b
						bool result = default(bool);
						switch (1)
						{
						default:
							return result;
						case 1:
							try
							{
								int num;
								if (t.Namespace == null)
								{
									num = 2;
									goto IL_0041;
								}
								goto IL_005f;
								IL_00f7:
								int num2 = 0;
								goto IL_00f8;
								IL_005f:
								if (_003C_003Ec.QPCoX4Qz0eAjAAjYyrfe(t.Namespace, _003C_003Ec.gfoQrIQzxtoUWVTLoYUG(0x7EC153F ^ 0x7EF4BE3)))
								{
									num = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num = 0;
									}
									goto IL_0041;
								}
								goto IL_00d2;
								IL_0041:
								switch (num)
								{
								default:
									return result;
								case 0:
									return result;
								case 1:
									break;
								case 4:
									goto IL_00c7;
								case 3:
									goto IL_00d2;
								case 2:
									goto IL_00f7;
								}
								goto IL_005f;
								IL_00c7:
								num2 = 1;
								goto IL_00f8;
								IL_00d2:
								num2 = (t.Namespace.StartsWith((string)_003C_003Ec.gfoQrIQzxtoUWVTLoYUG(-1638402543 ^ -1638767229)) ? 1 : 0);
								goto IL_00f8;
								IL_00f8:
								result = (byte)num2 != 0;
								num = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num = 0;
								}
								goto IL_0041;
							}
							catch
							{
								int num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num3 = 0;
								}
								while (true)
								{
									switch (num3)
									{
									default:
										return result;
									case 0:
										return result;
									case 1:
										result = false;
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num3 = 0;
										}
										break;
									}
								}
							}
						}
					})
					group t by (string)_003C_003Ec.qpwYK2QzmmUR8A8kqx49(t)).ToDictionary((Func<IGrouping<string, Type>, string>)((IGrouping<string, Type> g) => g.Key), (Func<IGrouping<string, Type>, ICollection<string>>)((IGrouping<string, Type> g) => g.Select((Type t) => t.Namespace).ToArray()));
			}
			return ambiguousTypes;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
				case 1:
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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

	public ViewModelTypeName(string name, string @namespace, bool isNullable = false, bool isEnumerable = false)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_00f2, IL_0101, IL_013d
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 6;
		ICollection<string> value = default(ICollection<string>);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 9:
				Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C27C07) + Name + (string)l2yIDsWgoeDMGMMDv3ti(-1217523399 ^ -1217503495);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 5;
				}
				break;
			case 1:
				Namespace = (string)IOwfU6WghVABKTDvv72K(new string[5]
				{
					name,
					(string)l2yIDsWgoeDMGMMDv3ti(0x571EA399 ^ 0x571F0705),
					@namespace,
					(string)l2yIDsWgoeDMGMMDv3ti(0x103FE975 ^ 0x103FF3B1),
					name
				});
				num = 2;
				break;
			case 3:
			case 5:
				if (AmbiguousTypes.TryGetValue(name, out value))
				{
					num = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num = 8;
					}
					break;
				}
				goto case 4;
			case 2:
				return;
			case 4:
				Namespace = @namespace;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 7:
				if (!isEnumerable)
				{
					num = 3;
					break;
				}
				goto case 9;
			case 8:
				if (value.Contains(@namespace))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num = 4;
					}
					break;
				}
				goto case 1;
			case 6:
				Name = (string)(isNullable ? KmsqvLWgbrjmTNMdWrMh(name, l2yIDsWgoeDMGMMDv3ti(-289714582 ^ -289712608)) : name);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 7;
				}
				break;
			}
		}
	}

	static ViewModelTypeName()
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
				assemblyNames = new string[19]
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A4E8A8),
					(string)l2yIDsWgoeDMGMMDv3ti(-1998538950 ^ -1998418538),
					(string)l2yIDsWgoeDMGMMDv3ti(-740338220 ^ -740402294),
					(string)l2yIDsWgoeDMGMMDv3ti(-812025778 ^ -812058520),
					(string)l2yIDsWgoeDMGMMDv3ti(-234299632 ^ -234250066),
					(string)l2yIDsWgoeDMGMMDv3ti(0x2ACE37D ^ 0x2AED9B3),
					(string)l2yIDsWgoeDMGMMDv3ti(0xA592A41 ^ 0xA5B10A9),
					(string)l2yIDsWgoeDMGMMDv3ti(-2138160520 ^ -2138062206),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F75D9A),
					(string)l2yIDsWgoeDMGMMDv3ti(-398663332 ^ -398630614),
					(string)l2yIDsWgoeDMGMMDv3ti(-477139494 ^ -477276524),
					(string)l2yIDsWgoeDMGMMDv3ti(0x7459E02 ^ 0x747A57E),
					(string)l2yIDsWgoeDMGMMDv3ti(-538519530 ^ -538647630),
					(string)l2yIDsWgoeDMGMMDv3ti(-672123589 ^ -672002305),
					(string)l2yIDsWgoeDMGMMDv3ti(0x4D1C1EE4 ^ 0x4D1E250C),
					(string)l2yIDsWgoeDMGMMDv3ti(-2107978722 ^ -2108100596),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108100532),
					(string)l2yIDsWgoeDMGMMDv3ti(0x4D1C1EE4 ^ 0x4D1D9E5C),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5B16C9)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				lwJJUeWgGixgN3beSed4();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object l2yIDsWgoeDMGMMDv3ti(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object KmsqvLWgbrjmTNMdWrMh(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object IOwfU6WghVABKTDvv72K(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool GgfSlPWgB381RoQsQs5A()
	{
		return QU91FpWgFVLR1E6TYVSO == null;
	}

	internal static ViewModelTypeName ARkh9TWgWJNRU4W0j3UY()
	{
		return QU91FpWgFVLR1E6TYVSO;
	}

	internal static void lwJJUeWgGixgN3beSed4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
