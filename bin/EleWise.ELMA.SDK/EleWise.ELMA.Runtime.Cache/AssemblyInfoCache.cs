using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Cache;

public class AssemblyInfoCache
{
	internal bool _changed;

	internal bool _typesChanged;

	internal ApplicationStartCache _owner;

	private static readonly Dictionary<Assembly, string> AssemblyHashes;

	private readonly Dictionary<string, TypeInfoCache> typesByName;

	private readonly Dictionary<Type, TypeInfoCache> types;

	private static AssemblyInfoCache tOFVXyWe4AiLlMxI349F;

	public string AssemblyName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
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
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string HashCode
	{
		[CompilerGenerated]
		get
		{
			return _003CHashCode_003Ek__BackingField;
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
					_003CHashCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
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

	public bool? IsComponentAssembly { get; set; }

	public TypeInfoCache[] TypeInfos
	{
		get
		{
			return typesByName.Values.ToArray();
		}
		set
		{
			//Discarded unreachable code: IL_0065, IL_00d9, IL_00ec, IL_00fb
			int num = 6;
			int num3 = default(int);
			TypeInfoCache typeInfoCache = default(TypeInfoCache);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 12:
						num3++;
						num2 = 2;
						break;
					case 8:
					case 9:
						typeInfoCache = value[num3];
						num2 = 11;
						break;
					case 11:
						typesByName[typeInfoCache.TypeName] = typeInfoCache;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 0;
						}
						break;
					case 6:
						fR5V4mWeAgm6yZhgZsq5(typesByName);
						num2 = 5;
						break;
					default:
						typeInfoCache._owner = this;
						num2 = 12;
						break;
					case 4:
						return;
					case 3:
						return;
					case 1:
						num3 = 0;
						num2 = 7;
						break;
					case 10:
						if (value == null)
						{
							goto end_IL_0012;
						}
						goto case 1;
					case 5:
						oqgNcYWe7rPQGZqYxyMr(types);
						num2 = 10;
						break;
					case 2:
					case 7:
						if (num3 >= value.Length)
						{
							return;
						}
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 8;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
		}
	}

	public AssemblyInfoCache()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		typesByName = new Dictionary<string, TypeInfoCache>();
		types = new Dictionary<Type, TypeInfoCache>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public AssemblyInfoCache(ApplicationStartCache owner, Assembly assembly)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		WsfuMkWexmKChycNN8b1();
		typesByName = new Dictionary<string, TypeInfoCache>();
		types = new Dictionary<Type, TypeInfoCache>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				HashCode = EvaluateHashCode(assembly);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			case 1:
				AssemblyName = ComponentManager.GetAssemblyShortName(assembly);
				num = 3;
				break;
			default:
				_owner = owner;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static string EvaluateHashCode(Assembly assembly)
	{
		//Discarded unreachable code: IL_00b0, IL_0115, IL_0124, IL_0189, IL_01c1, IL_01f9, IL_02a5, IL_02b4, IL_02c3
		int num = 5;
		string value = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					return value;
				case 4:
					memoryStream = (MemoryStream)kxjPTBWe0pNAnh99I0l1(assembly);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
					if (E6kM2qWeM4KXH8b4UeOZ(Y2tCxoWeyfqdZwY6kUje(assembly)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 12;
				case 12:
					if (BOThlpWeJeLmtGpgVU5v(Y2tCxoWeyfqdZwY6kUje(assembly)))
					{
						num2 = 10;
						continue;
					}
					goto case 2;
				case 8:
					hLxhASWelDvYklQ8EXmn(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return value;
				case 6:
					AssemblyHashes[assembly] = value;
					num2 = 9;
					continue;
				case 5:
					if (!AssemblyHashes.TryGetValue(assembly, out value))
					{
						num2 = 4;
						continue;
					}
					goto case 14;
				case 7:
					try
					{
						value = (string)jGk87nWedJdL3YBpq2Oh(fileStream);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (fileStream != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									((IDisposable)fileStream).Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
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
					goto case 6;
				case 1:
					if (cJKl0jWem6Z4EmTjYpXU(assembly))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 3;
				case 11:
					if (memoryStream == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 2:
				case 13:
				case 15:
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939507074), EnPkgGWe96XliKFMCuOj(assembly)));
				case 10:
					fileStream = new FileStream(assembly.Location, FileMode.Open, FileAccess.Read);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			value = (string)jGk87nWedJdL3YBpq2Oh(memoryStream);
			num = 6;
		}
	}

	internal static string EvaluateHashCode(byte[] asmRaw)
	{
		//Discarded unreachable code: IL_004d, IL_00c9, IL_0109, IL_0118, IL_0124, IL_0133
		int num = 1;
		int num2 = num;
		string result = default(string);
		SHA1 sHA = default(SHA1);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				sHA = SHA1.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				byte[] array = (byte[])AAYImvWer37nRZUTKMkn(sHA, asmRaw);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						result = (string)yqbtOnWe5pKeYXGwqpB7(asmRaw.Length, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939374346), afKpf6WegdgNeR3K9uTL(array));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num3 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			finally
			{
				int num4;
				if (sHA == null)
				{
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num4 = 1;
					}
					goto IL_00cd;
				}
				goto IL_00e3;
				IL_00e3:
				GCsBbWWejLEM7fNHX7FG(sHA);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num4 = 1;
				}
				goto IL_00cd;
				IL_00cd:
				switch (num4)
				{
				case 2:
					goto end_IL_00a8;
				case 1:
					goto end_IL_00a8;
				}
				goto IL_00e3;
				end_IL_00a8:;
			}
		}
	}

	internal static string EvaluateHashCode(Stream assemblyStream)
	{
		//Discarded unreachable code: IL_006e, IL_00ed, IL_0125, IL_0134
		int num = 1;
		int num2 = num;
		SHA1 sHA = default(SHA1);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sHA = (SHA1)queUw2WeYY7WcV8YLX7K();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				byte[] array = (byte[])hF1PPwWeLL5OQDq8NSMp(sHA, assemblyStream);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						result = (string)yqbtOnWe5pKeYXGwqpB7(assemblyStream.Length, vY5l1cWeUPmVWHqw89KG(0x42643203 ^ 0x42643E79), afKpf6WegdgNeR3K9uTL(array));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num3 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			finally
			{
				if (sHA != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((IDisposable)sHA).Dispose();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
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
		}
	}

	public TypeInfoCache GetTypeInfo(Type type)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6
		int num = 5;
		int num2 = num;
		string fullName = default(string);
		TypeInfoCache value = default(TypeInfoCache);
		while (true)
		{
			switch (num2)
			{
			case 6:
				fullName = type.FullName;
				num2 = 8;
				break;
			case 5:
				if (types.TryGetValue(type, out value))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			default:
				value = new TypeInfoCache(this, type);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
			case 4:
				return value;
			case 8:
				if (!typesByName.TryGetValue(fullName, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 1:
				typesByName[fullName] = value;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				types[type] = value;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_typesChanged = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static AssemblyInfoCache()
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
				AssemblyHashes = new Dictionary<Assembly, string>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool vwqgWyWe6nFjJBKjF8gH()
	{
		return tOFVXyWe4AiLlMxI349F == null;
	}

	internal static AssemblyInfoCache ly2QBtWeHxdJiMIetsLP()
	{
		return tOFVXyWe4AiLlMxI349F;
	}

	internal static void fR5V4mWeAgm6yZhgZsq5(object P_0)
	{
		((Dictionary<string, TypeInfoCache>)P_0).Clear();
	}

	internal static void oqgNcYWe7rPQGZqYxyMr(object P_0)
	{
		((Dictionary<Type, TypeInfoCache>)P_0).Clear();
	}

	internal static void WsfuMkWexmKChycNN8b1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object kxjPTBWe0pNAnh99I0l1(object P_0)
	{
		return ComponentManager.GetLoadedAssemblyRawAsStream((Assembly)P_0);
	}

	internal static bool cJKl0jWem6Z4EmTjYpXU(object P_0)
	{
		return ((Assembly)P_0).IsDynamic;
	}

	internal static object Y2tCxoWeyfqdZwY6kUje(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool E6kM2qWeM4KXH8b4UeOZ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool BOThlpWeJeLmtGpgVU5v(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object EnPkgGWe96XliKFMCuOj(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object jGk87nWedJdL3YBpq2Oh(object P_0)
	{
		return EvaluateHashCode((Stream)P_0);
	}

	internal static long hLxhASWelDvYklQ8EXmn(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object AAYImvWer37nRZUTKMkn(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object afKpf6WegdgNeR3K9uTL(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static object yqbtOnWe5pKeYXGwqpB7(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static void GCsBbWWejLEM7fNHX7FG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object queUw2WeYY7WcV8YLX7K()
	{
		return SHA1.Create();
	}

	internal static object hF1PPwWeLL5OQDq8NSMp(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static object vY5l1cWeUPmVWHqw89KG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
