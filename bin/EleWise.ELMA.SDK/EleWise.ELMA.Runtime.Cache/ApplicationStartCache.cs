using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Cache;

public class ApplicationStartCache
{
	private static class Db
	{
		public static class Fields
		{
			public const string CacheData = "CacheData";
		}
	}

	private ITransformationProvider _transform;

	private Dictionary<string, AssemblyInfoCache> _assembliesByName;

	private Dictionary<Assembly, AssemblyInfoCache> _assemblies;

	internal static ApplicationStartCache XTuqPgWevgrjn9H7hgDH;

	public AssemblyInfoCache[] AssemblyInfos
	{
		get
		{
			return _assembliesByName.Values.ToArray();
		}
		set
		{
			//Discarded unreachable code: IL_0071, IL_00c0, IL_00cf
			int num = 7;
			AssemblyInfoCache assemblyInfoCache = default(AssemblyInfoCache);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 9:
						if (value == null)
						{
							num2 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 3;
					case 0:
						return;
					case 11:
						return;
					case 6:
						_assemblies.Clear();
						num = 9;
						break;
					case 2:
						assemblyInfoCache._owner = this;
						num = 10;
						break;
					case 8:
						assemblyInfoCache = value[num3];
						num2 = 5;
						continue;
					case 5:
						_assembliesByName[(string)XFd7SBWeuAOT36RMaqyD(assemblyInfoCache)] = assemblyInfoCache;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 2;
						}
						continue;
					case 7:
						_assembliesByName.Clear();
						num2 = 6;
						continue;
					case 10:
						num3++;
						num2 = 4;
						continue;
					case 3:
						num3 = 0;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
					case 4:
						if (num3 >= value.Length)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 8;
					}
					break;
				}
			}
		}
	}

	public string Mappings
	{
		[CompilerGenerated]
		get
		{
			return _003CMappings_003Ek__BackingField;
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
					_003CMappings_003Ek__BackingField = value;
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

	public List<string> InterceptorNames { get; set; }

	[DefaultValue(true)]
	public bool DynamicPublication
	{
		[CompilerGenerated]
		get
		{
			return _003CDynamicPublication_003Ek__BackingField;
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
					_003CDynamicPublication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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

	public ApplicationStartCache()
	{
		//Discarded unreachable code: IL_0056, IL_005b
		SingletonReader.JJCZtPuTvSt();
		DynamicPublication = true;
		_assembliesByName = new Dictionary<string, AssemblyInfoCache>();
		_assemblies = new Dictionary<Assembly, AssemblyInfoCache>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			InterceptorNames = new List<string>();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
			{
				num = 1;
			}
		}
	}

	public AssemblyInfoCache GetAssemblyInfo(Assembly assembly)
	{
		//Discarded unreachable code: IL_00df, IL_01ca, IL_024e, IL_025d, IL_02f2, IL_0301, IL_037c, IL_038b, IL_039a, IL_03e4, IL_03f3
		int num = 12;
		AssemblyInfoCache value = default(AssemblyInfoCache);
		Assembly assembly2 = default(Assembly);
		string key = default(string);
		AssemblyName assemblyName = default(AssemblyName);
		int num3 = default(int);
		AssemblyName[] array = default(AssemblyName[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (value != null)
					{
						num2 = 5;
						continue;
					}
					goto case 28;
				default:
					value = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (!a5Zh4OWeTJ5vWgbyKrvH(AssemblyInfoCache.EvaluateHashCode(assembly), value.HashCode))
					{
						num2 = 30;
						continue;
					}
					goto case 8;
				case 12:
					if (_assemblies.TryGetValue(assembly, out value))
					{
						num = 11;
						break;
					}
					goto case 35;
				case 3:
					if (GetAssemblyInfo(assembly2)._changed)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 25:
					if (sTVIcLWeqYxPsfnGbFYD(assembly2))
					{
						num2 = 4;
						continue;
					}
					goto case 29;
				case 16:
					if (!_assembliesByName.TryGetValue(key, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 9;
				case 26:
					value._changed = true;
					num2 = 14;
					continue;
				case 24:
					_assemblies[assembly] = value;
					num2 = 15;
					continue;
				case 17:
					value = new AssemblyInfoCache(this, assembly);
					num2 = 26;
					continue;
				case 7:
					value._changed = true;
					num2 = 24;
					continue;
				case 15:
					_assembliesByName[(string)XFd7SBWeuAOT36RMaqyD(value)] = value;
					num = 2;
					break;
				case 23:
					if (!(assembly2 != null))
					{
						num2 = 34;
						continue;
					}
					goto case 25;
				case 18:
					value = new AssemblyInfoCache(this, assembly);
					num2 = 7;
					continue;
				case 29:
					if (AbWBLoWeKiD6dJopMl1A(assembly2) == null)
					{
						num2 = 27;
						continue;
					}
					goto case 13;
				case 28:
				case 30:
					if (value == null)
					{
						num = 18;
						break;
					}
					goto case 24;
				case 32:
					if (!WRacW7WeiDtW6Yq9lwtf(Q2wX23WeSWBFxiMkAvfm(assemblyName), assembly.FullName))
					{
						num2 = 20;
						continue;
					}
					goto case 1;
				case 1:
				case 4:
				case 27:
				case 34:
					num3++;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					_assembliesByName[key] = value;
					num2 = 10;
					continue;
				case 20:
					assembly2 = ComponentManager.FindLoadedAssembly((string)xPsU9xWeRnXk0rdMronK(assemblyName), isFullName: false);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 4;
					}
					continue;
				case 33:
					num3 = 0;
					num2 = 31;
					continue;
				case 13:
					if (((ComponentManager)JlCDjbWeXQgIDLKv4ohG()).registrationData.Assemblies.Contains(assembly2))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 19:
				case 31:
					if (num3 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 21;
				case 35:
					key = (string)qqCOvkWeIi8lsGV44yAQ(assembly);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 16;
					}
					continue;
				case 2:
				case 11:
					return value;
				case 8:
					value = null;
					num2 = 28;
					continue;
				case 6:
					if (value != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 17;
				case 10:
				case 22:
					array = (AssemblyName[])CZ1P7wWeVvfH5emyHfHT(assembly);
					num = 33;
					break;
				case 21:
					assemblyName = array[num3];
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	public int GetInterceptorIndex(string name)
	{
		return InterceptorNames.IndexOf(name);
	}

	internal static void CreateDbStructures(ITransformationProvider transform, int version)
	{
		int num = 4;
		int num2 = num;
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 2:
				table = new Table
				{
					Name = (string)MS6xVJWekkF5lQJkg40L(-629844702 ^ -629711408),
					Columns = new List<Column>
					{
						new Column((string)MS6xVJWekkF5lQJkg40L(--1360331293 ^ 0x51170B35), DbType.Binary)
					}
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			default:
				transform.AddTable(table);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (version != 0)
				{
					return;
				}
				num2 = 3;
				break;
			case 3:
				if (bNk11qWenNTx0jHrPmpg(transform, MS6xVJWekkF5lQJkg40L(-2138160520 ^ -2138289526)))
				{
					return;
				}
				num2 = 2;
				break;
			}
		}
	}

	internal static ApplicationStartCache Load(ITransformationProvider transform)
	{
		//Discarded unreachable code: IL_009b, IL_00be, IL_00cd, IL_00fc, IL_0141, IL_0179, IL_01b1, IL_01c0, IL_01f1, IL_0210, IL_021f, IL_024c, IL_025b, IL_02ab, IL_0323, IL_0363, IL_0372, IL_037e, IL_038d
		int num = 6;
		int num2 = num;
		ApplicationStartCache applicationStartCache = default(ApplicationStartCache);
		IDataReader dataReader = default(IDataReader);
		MemoryStream stream = default(MemoryStream);
		DateTime now = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 5:
				applicationStartCache = null;
				num2 = 2;
				continue;
			case 8:
				return applicationStartCache;
			case 2:
				dataReader = transform.ExecuteQuery((string)MS6xVJWekkF5lQJkg40L(-882126494 ^ -882255780));
				num2 = 3;
				continue;
			case 3:
				try
				{
					int num3;
					if (!dataReader.Read())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num3 = 0;
						}
						goto IL_009f;
					}
					goto IL_0266;
					IL_0266:
					stream = dataReader.GetStream(0);
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num3 = 2;
					}
					goto IL_009f;
					IL_009f:
					switch (num3)
					{
					default:
						goto end_IL_0075;
					case 0:
						goto end_IL_0075;
					case 2:
						try
						{
							XmlReader xmlReader = (XmlReader)p9YIFLWeOawu0KAY0nXN(stream);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num4 = 1;
							}
							switch (num4)
							{
							case 1:
								try
								{
									applicationStartCache = (ApplicationStartCache)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<ApplicationStartCache>.Raw, xmlReader, useComponentManager: false);
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								finally
								{
									if (xmlReader != null)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												((IDisposable)xmlReader).Dispose();
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
												{
													num6 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								break;
							case 0:
								break;
							}
						}
						finally
						{
							int num7;
							if (stream == null)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num7 = 0;
								}
								goto IL_01f5;
							}
							goto IL_022a;
							IL_022a:
							d8LVP1We20yGMVqoN7xj(stream);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num7 = 2;
							}
							goto IL_01f5;
							IL_01f5:
							switch (num7)
							{
							default:
								goto end_IL_01d0;
							case 0:
								goto end_IL_01d0;
							case 1:
								break;
							case 2:
								goto end_IL_01d0;
							}
							goto IL_022a;
							end_IL_01d0:;
						}
						goto end_IL_0075;
					case 3:
						break;
					case 1:
						goto end_IL_0075;
					}
					goto IL_0266;
					end_IL_0075:;
				}
				catch (Exception ex)
				{
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num8 = 0;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							MACqkXWePWTj6gYbM0oq(aDKfHWWee9XZsPX1jJ6R(), MS6xVJWekkF5lQJkg40L(0x3630F361 ^ 0x3632FAC1), ex);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num8 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					int num9;
					if (dataReader == null)
					{
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num9 = 0;
						}
						goto IL_0327;
					}
					goto IL_033d;
					IL_033d:
					d8LVP1We20yGMVqoN7xj(dataReader);
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num9 = 1;
					}
					goto IL_0327;
					IL_0327:
					switch (num9)
					{
					default:
						goto end_IL_0302;
					case 2:
						break;
					case 0:
						goto end_IL_0302;
					case 1:
						goto end_IL_0302;
					}
					goto IL_033d;
					end_IL_0302:;
				}
				goto case 1;
			case 1:
				if (applicationStartCache == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 7:
				applicationStartCache = new ApplicationStartCache();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 4;
				}
				continue;
			case 6:
				now = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 5;
				}
				continue;
			default:
				RLufG0We3mTbQ9BTYSnb(aDKfHWWee9XZsPX1jJ6R(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A5EAAC) + (int)fUWkqOWeNlAvu4xZ0wjI(jZAV5EWe1Qnm8tOoOg4h(), now).TotalMilliseconds + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867138135));
				num2 = 8;
				continue;
			case 4:
				break;
			}
			applicationStartCache._transform = transform;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
			{
				num2 = 0;
			}
		}
	}

	internal void Save()
	{
		//Discarded unreachable code: IL_0073, IL_00f5, IL_0156, IL_0196, IL_01a5, IL_01b1, IL_01c0, IL_01ff, IL_026f, IL_027e
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		DateTime now = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 3:
				try
				{
					_transform.ExecuteNonQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309768802));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							try
							{
								yfFu1hWeaGIra8hSnQ49(_transform, MS6xVJWekkF5lQJkg40L(--1418440330 ^ 0x5489A678), new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B9BC16) }, new object[1]
								{
									new ParameterValue(DbType.Binary, memoryStream)
								});
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										vcErQ9WeDmM1gDDkn94p(_transform);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
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
							finally
							{
								int num5;
								if (memoryStream == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num5 = 0;
									}
									goto IL_015a;
								}
								goto IL_0170;
								IL_0170:
								d8LVP1We20yGMVqoN7xj(memoryStream);
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num5 = 1;
								}
								goto IL_015a;
								IL_015a:
								switch (num5)
								{
								default:
									goto end_IL_0135;
								case 1:
									break;
								case 0:
									goto end_IL_0135;
								case 2:
									goto end_IL_0135;
								}
								goto IL_0170;
								end_IL_0135:;
							}
							break;
						case 1:
							goto IL_01cb;
						case 0:
							break;
						}
						break;
						IL_01cb:
						memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(this, useComponentManager: false);
						num3 = 2;
					}
				}
				catch (Exception ex)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							MACqkXWePWTj6gYbM0oq(aDKfHWWee9XZsPX1jJ6R(), MS6xVJWekkF5lQJkg40L(0x4A1640F ^ 0x4A36E7F), ex);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num6 = 0;
							}
							continue;
						default:
							VV43vwWetBSgtabHjiq2(_transform);
							num6 = 2;
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				goto default;
			case 4:
				kPgAnwWepKRktsl5m3JW(_transform);
				num2 = 3;
				break;
			case 1:
				return;
			default:
				RLufG0We3mTbQ9BTYSnb(aDKfHWWee9XZsPX1jJ6R(), vjnJxVWewsvKTvnQlNqo(MS6xVJWekkF5lQJkg40L(-2107978722 ^ -2108111192), (int)fUWkqOWeNlAvu4xZ0wjI(jZAV5EWe1Qnm8tOoOg4h(), now).TotalMilliseconds, MS6xVJWekkF5lQJkg40L(-475857671 ^ -475821883)));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				if (_assembliesByName.Values.Any(delegate(AssemblyInfoCache a)
				{
					//Discarded unreachable code: IL_0052, IL_0061
					int num7 = 2;
					int num8 = num7;
					while (true)
					{
						switch (num8)
						{
						case 2:
							if (a._changed)
							{
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
								{
									num8 = 0;
								}
								break;
							}
							goto default;
						default:
							return a._typesChanged;
						case 1:
							return true;
						}
					}
				}))
				{
					now = DateTime.Now;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	internal static bool xCsHGuWe8C4D64dhTBGr()
	{
		return XTuqPgWevgrjn9H7hgDH == null;
	}

	internal static ApplicationStartCache rbmVXiWeZ0g8KwXWorMP()
	{
		return XTuqPgWevgrjn9H7hgDH;
	}

	internal static object XFd7SBWeuAOT36RMaqyD(object P_0)
	{
		return ((AssemblyInfoCache)P_0).AssemblyName;
	}

	internal static object qqCOvkWeIi8lsGV44yAQ(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object CZ1P7wWeVvfH5emyHfHT(object P_0)
	{
		return ((Assembly)P_0).GetReferencedAssemblies();
	}

	internal static object Q2wX23WeSWBFxiMkAvfm(object P_0)
	{
		return ((AssemblyName)P_0).FullName;
	}

	internal static bool WRacW7WeiDtW6Yq9lwtf(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object xPsU9xWeRnXk0rdMronK(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static bool sTVIcLWeqYxPsfnGbFYD(object P_0)
	{
		return ((Assembly)P_0).IsDynamic;
	}

	internal static object AbWBLoWeKiD6dJopMl1A(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static object JlCDjbWeXQgIDLKv4ohG()
	{
		return ComponentManager.Current;
	}

	internal static bool a5Zh4OWeTJ5vWgbyKrvH(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object MS6xVJWekkF5lQJkg40L(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bNk11qWenNTx0jHrPmpg(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static object p9YIFLWeOawu0KAY0nXN(object P_0)
	{
		return XmlReader.Create((Stream)P_0);
	}

	internal static void d8LVP1We20yGMVqoN7xj(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object aDKfHWWee9XZsPX1jJ6R()
	{
		return Logger.Log;
	}

	internal static void MACqkXWePWTj6gYbM0oq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static DateTime jZAV5EWe1Qnm8tOoOg4h()
	{
		return DateTime.Now;
	}

	internal static TimeSpan fUWkqOWeNlAvu4xZ0wjI(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void RLufG0We3mTbQ9BTYSnb(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void kPgAnwWepKRktsl5m3JW(object P_0)
	{
		((ITransformationProvider)P_0).BeginTransaction();
	}

	internal static int yfFu1hWeaGIra8hSnQ49(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static void vcErQ9WeDmM1gDDkn94p(object P_0)
	{
		((ITransformationProviderBase)P_0).CommitTransaction();
	}

	internal static void VV43vwWetBSgtabHjiq2(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static object vjnJxVWewsvKTvnQlNqo(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}
}
