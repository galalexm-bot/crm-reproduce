using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Configuration;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class AssemblyBuilder : IDisposable
{
	private class SourceCode
	{
		private static object FSwYltviWfZ28hZwxa5B;

		public string FileName
		{
			[CompilerGenerated]
			get
			{
				return _003CFileName_003Ek__BackingField;
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
						_003CFileName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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

		public string Code
		{
			[CompilerGenerated]
			get
			{
				return _003CCode_003Ek__BackingField;
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
						_003CCode_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public SourceCode()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			qOwDYovihAl724m30Zaa();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool jXOTYJviohQ5YjwgTyEB()
		{
			return FSwYltviWfZ28hZwxa5B == null;
		}

		internal static SourceCode O30gT9vibuyu3OFwg98c()
		{
			return (SourceCode)FSwYltviWfZ28hZwxa5B;
		}

		internal static void qOwDYovihAl724m30Zaa()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private IRuntimeApplication runtimeApplication;

	private IEnumerable<IReferenceProvider> referenceProviders;

	private readonly Lazy<string> tempDir;

	private readonly ISet<string> fileNames;

	private HashSet<string> _references;

	private HashSet<Assembly> _referencedAssemblies;

	private readonly List<MemoryStream> referencedAssemblyRaws;

	private HashSet<string> _referenceNames;

	private List<SourceCode> _sourceCodes;

	private Dictionary<string, byte[]> _embeddedResources;

	private byte[] assemblyRaw;

	private MemoryStream assemblyRawStream;

	private byte[] documentationRaw;

	private MemoryStream documentationRawStream;

	private byte[] debugRaw;

	private MemoryStream debugRawStream;

	private static HashSet<string> elmaAssemblies;

	private List<DiagnosticAnalyzer> analyzers;

	private bool disposed;

	private static ConcurrentDictionary<string, Tuple<DateTime, long, MetadataReference>> fileReferences;

	private static AssemblyBuilder FBF21fhpGakSivTQiG7a;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private IRuntimeApplication RuntimeApplication
	{
		get
		{
			int num = 2;
			int num2 = num;
			IRuntimeApplication obj;
			IRuntimeApplication runtimeApplication = default(IRuntimeApplication);
			while (true)
			{
				switch (num2)
				{
				case 2:
					obj = this.runtimeApplication;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					runtimeApplication = (this.runtimeApplication = (Bhi4xshpQcIFE0dawrt2() ? Locator.GetService<IRuntimeApplication>() : null));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = runtimeApplication;
					break;
				}
				break;
			}
			return obj;
		}
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
					runtimeApplication = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private IEnumerable<IReferenceProvider> ReferenceProviders
	{
		get
		{
			return referenceProviders ?? (referenceProviders = ComponentManager.Current.GetExtensionPoints<IReferenceProvider>());
		}
		set
		{
			referenceProviders = value;
		}
	}

	public byte[] PublicKey
	{
		[CompilerGenerated]
		get
		{
			return _003CPublicKey_003Ek__BackingField;
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
					_003CPublicKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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

	public CancellationToken CancellationToken
	{
		[CompilerGenerated]
		get
		{
			return _003CCancellationToken_003Ek__BackingField;
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
					_003CCancellationToken_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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

	internal IEnumerable<MemoryStream> ReferencedAssemblyRaws => referencedAssemblyRaws;

	public byte[] AssemblyRaw
	{
		get
		{
			int num = 1;
			int num2 = num;
			byte[] array2;
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 1:
					array2 = assemblyRaw;
					if (array2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
				{
					MemoryStream memoryStream = assemblyRawStream;
					array = (assemblyRaw = (byte[])((memoryStream != null) ? VxBKmdhpACqRNCBMIACQ(memoryStream) : null));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 2:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
		}
	}

	public MemoryStream AssemblyRawStream
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return assemblyRawStream;
				case 1:
				{
					MemoryStream memoryStream = assemblyRawStream;
					if (memoryStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						break;
					}
					memoryStream.Seek(0L, SeekOrigin.Begin);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 2;
					}
					break;
				}
				}
			}
		}
	}

	public byte[] DocumentationRaw
	{
		get
		{
			int num = 1;
			int num2 = num;
			byte[] array2;
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 1:
					array2 = documentationRaw;
					if (array2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
				{
					MemoryStream memoryStream = documentationRawStream;
					array = (documentationRaw = (byte[])((memoryStream != null) ? VxBKmdhpACqRNCBMIACQ(memoryStream) : null));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 2:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
		}
	}

	public MemoryStream DocumentationRawStream
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return documentationRawStream;
				case 1:
				{
					MemoryStream memoryStream = documentationRawStream;
					if (memoryStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					}
					memoryStream.Seek(0L, SeekOrigin.Begin);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 2;
					}
					break;
				}
				}
			}
		}
	}

	public byte[] DebugRaw
	{
		get
		{
			int num = 1;
			int num2 = num;
			byte[] array2;
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 1:
					array2 = debugRaw;
					if (array2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
				{
					MemoryStream memoryStream = debugRawStream;
					array = (debugRaw = (byte[])((memoryStream != null) ? VxBKmdhpACqRNCBMIACQ(memoryStream) : null));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 2:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
		}
	}

	public MemoryStream DebugRawStream
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return debugRawStream;
				case 2:
				{
					MemoryStream memoryStream = debugRawStream;
					if (memoryStream == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						break;
					}
					xBAygdhp7pAtxIrWK85t(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}
	}

	public virtual void AddDefaultReferences()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				AddDefaultReferencesFromConfig((string)zbGPnmhpCXXdX5PMmcRs(-1822890472 ^ -1822716444));
				num2 = 3;
				break;
			case 2:
				return;
			case 1:
				AddReferences(ReferenceProviders);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				AddDefaultReferencesFromElmaConfig((string)zbGPnmhpCXXdX5PMmcRs(0x7459E02 ^ 0x746F5FE));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void AddAllElmaReferences()
	{
		//Discarded unreachable code: IL_010a, IL_0150, IL_0160, IL_016f, IL_017a, IL_020a, IL_0219, IL_0275, IL_0285, IL_0294, IL_029f, IL_0338, IL_0357, IL_0383, IL_03bd, IL_03d0, IL_041a, IL_0429, IL_0438, IL_04be, IL_04cd, IL_058a
		int num = 12;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		List<string> list = default(List<string>);
		string text2 = default(string);
		Assembly assembly = default(Assembly);
		Assembly[] array = default(Assembly[]);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					enumerator = list.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					text2 = (string)MaYP2bhp8cx97MPpo7xA(ComponentManager.Current.WorkDirectory, zbGPnmhpCXXdX5PMmcRs(-629844702 ^ -629930678));
					num2 = 27;
					continue;
				case 28:
					assembly = array[num3];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					if (ComponentManager.Initialized)
					{
						num2 = 11;
						continue;
					}
					goto case 10;
				case 25:
					list.Add(text2);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_024a:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num4 = 0;
								}
								goto IL_017e;
							}
							goto IL_01a8;
							IL_01a8:
							current = enumerator.Current;
							num4 = 2;
							goto IL_017e;
							IL_017e:
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 3:
									break;
								case 5:
								case 6:
									enumerator2 = Directory.GetFiles(current, (string)zbGPnmhpCXXdX5PMmcRs(0x637E299B ^ 0x637F6D5D)).Union((IEnumerable<string>)T5ifyghpu0dcVG05lFSD(current, zbGPnmhpCXXdX5PMmcRs(-889460160 ^ -889682338))).GetEnumerator();
									num4 = 4;
									continue;
								case 2:
									if (KkRhd5hpZ1I3J3MHNqyj(current))
									{
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
										{
											num4 = 4;
										}
										continue;
									}
									return;
								case 7:
									goto IL_024a;
								case 0:
									return;
								case 4:
									try
									{
										while (true)
										{
											int num5;
											if (!PnTAsShpV09df55rTsxZ(enumerator2))
											{
												num5 = 3;
												goto IL_02a3;
											}
											goto IL_02d3;
											IL_02a3:
											while (true)
											{
												switch (num5)
												{
												case 1:
													goto IL_02d3;
												case 2:
													elmaAssemblies.Add((string)gFClR1hpIWkaN4XtN9bi(current2));
													num5 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
													{
														num5 = 0;
													}
													continue;
												case 3:
													goto end_IL_02bd;
												}
												break;
											}
											continue;
											IL_02d3:
											current2 = enumerator2.Current;
											num5 = 2;
											goto IL_02a3;
											continue;
											end_IL_02bd:
											break;
										}
									}
									finally
									{
										int num6;
										if (enumerator2 == null)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
											{
												num6 = 0;
											}
											goto IL_033c;
										}
										goto IL_0361;
										IL_0361:
										tAM9WjhpS4bs2XrbYpaA(enumerator2);
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
										{
											num6 = 1;
										}
										goto IL_033c;
										IL_033c:
										switch (num6)
										{
										default:
											goto end_IL_0317;
										case 0:
											goto end_IL_0317;
										case 2:
											break;
										case 1:
											goto end_IL_0317;
										}
										goto IL_0361;
										end_IL_0317:;
									}
									goto IL_024a;
								case 1:
									goto end_IL_024a;
								}
								break;
							}
							goto IL_01a8;
							continue;
							end_IL_024a:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 4:
					if (!fV1oR4hpR9MOMp7OQ1IU(assembly))
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 17:
					return;
				default:
					if (elmaAssemblies == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 13;
				case 6:
					if (!WtO2JnhpXsH8jk2KuwEN(FMevcAhpK1GuqjdF9Dhs(assembly)))
					{
						num2 = 23;
						continue;
					}
					goto case 5;
				case 21:
					elmaAssemblies = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
					num2 = 16;
					continue;
				case 14:
					g1EFALhpk1151nQsQa8W(this, assembly.Location);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 22;
					}
					continue;
				case 16:
					list = ((IEnumerable<string>)PXrSMFhpv8D5FZMSTYg0(ComponentManager.Current)).ToList();
					num2 = 15;
					continue;
				case 10:
				case 18:
					array = (Assembly[])X1rYLshpi5ZdVKpXe57J();
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 8;
					}
					continue;
				case 27:
					if (KkRhd5hpZ1I3J3MHNqyj(text2))
					{
						num = 25;
						break;
					}
					goto case 19;
				case 2:
					if (!XojJMYhpTAWEvMubFfZs(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E271A4)))
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 20:
					num3 = 0;
					num = 24;
					break;
				case 5:
				case 7:
				case 8:
				case 22:
				case 26:
					num3++;
					num2 = 9;
					continue;
				case 9:
				case 24:
					if (num3 >= array.Length)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 28;
				case 13:
					if (!elmaAssemblies.Contains(text))
					{
						num2 = 7;
						continue;
					}
					goto case 14;
				case 11:
					if (elmaAssemblies != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 21;
				case 23:
					if (!XojJMYhpTAWEvMubFfZs(text, zbGPnmhpCXXdX5PMmcRs(-35995181 ^ -35992649)))
					{
						num = 26;
						break;
					}
					goto case 2;
				case 3:
					text = (string)GsyvvZhpqMSCTx5M7UZ1(assembly);
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public void AddAllAssembliesWithLocation()
	{
		//Discarded unreachable code: IL_00ab, IL_0135
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		Assembly[] array = default(Assembly[]);
		string text = default(string);
		Assembly assembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = 0;
				num2 = 8;
				break;
			case 4:
			case 6:
				num3++;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 10;
				}
				break;
			case 8:
			case 10:
				if (num3 >= array.Length)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 13;
			case 5:
				text = (string)GsyvvZhpqMSCTx5M7UZ1(assembly);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				array = (Assembly[])X1rYLshpi5ZdVKpXe57J();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (text != (string)zbGPnmhpCXXdX5PMmcRs(--1867379187 ^ 0x6F4DFBDD))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 13:
				assembly = array[num3];
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 12;
				}
				break;
			case 11:
				if (WtO2JnhpXsH8jk2KuwEN(FMevcAhpK1GuqjdF9Dhs(assembly)))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 3:
				if (text != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026102B))
				{
					num2 = 9;
					break;
				}
				goto case 4;
			case 12:
				if (!fV1oR4hpR9MOMp7OQ1IU(assembly))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			default:
				g1EFALhpk1151nQsQa8W(this, assembly.Location);
				num2 = 6;
				break;
			case 7:
				return;
			}
		}
	}

	public virtual void AddSourceCode(string code)
	{
		//Discarded unreachable code: IL_0087
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
			{
				List<SourceCode> sourceCodes = _sourceCodes;
				SourceCode sourceCode = new SourceCode();
				AtuYfHhpnoNr4OUmiQZF(sourceCode, code);
				sourceCodes.Add(sourceCode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				if (WtO2JnhpXsH8jk2KuwEN(code))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 1:
				return;
			case 0:
				return;
			}
		}
	}

	public virtual void AddSourceCodeFile(string fileName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				fileNames.Add(fileName);
				num2 = 3;
				break;
			case 1:
			{
				List<SourceCode> sourceCodes = _sourceCodes;
				SourceCode sourceCode = new SourceCode();
				lyqwZEhpOX3wSviCpqwS(sourceCode, fileName);
				sourceCodes.Add(sourceCode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				return;
			case 2:
				if (WtO2JnhpXsH8jk2KuwEN(fileName))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void AddSourceCodeWithName(string code, string fileName)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					fileNames.Add(fileName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					if (!string.IsNullOrEmpty(code))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					return;
				}
				break;
			}
			List<SourceCode> sourceCodes = _sourceCodes;
			SourceCode sourceCode = new SourceCode();
			AtuYfHhpnoNr4OUmiQZF(sourceCode, code);
			sourceCode.FileName = fileName;
			sourceCodes.Add(sourceCode);
			num = 3;
		}
	}

	public virtual string GetSourceCodeHash()
	{
		//Discarded unreachable code: IL_007c, IL_012a, IL_0139, IL_0144, IL_01ef, IL_0202, IL_0223, IL_0232, IL_023d, IL_02e8, IL_02fb, IL_0468, IL_04a0, IL_04f9, IL_0542, IL_0582, IL_0591, IL_059d, IL_05ac
		int num = 3;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		List<SourceCode>.Enumerator enumerator = default(List<SourceCode>.Enumerator);
		SourceCode current2 = default(SourceCode);
		SourceCode current = default(SourceCode);
		SHA1 sHA = default(SHA1);
		List<SourceCode> list = default(List<SourceCode>);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return result;
			case 4:
				memoryStream = (MemoryStream)LWLbrHhp27nEGXQBPLgD();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					StreamWriter streamWriter = new StreamWriter(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							HhGlyqhpPCf1DgHFeE9Z(streamWriter, rpKnaVhpebLllViSqwR9(_sourceCodes.Count(), zbGPnmhpCXXdX5PMmcRs(0x61EC0CB8 ^ 0x61EC11EA)));
							int num4 = 2;
							while (true)
							{
								switch (num4)
								{
								case 9:
									memoryStream.Seek(0L, SeekOrigin.Begin);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num4 = 1;
									}
									break;
								case 6:
									try
									{
										while (true)
										{
											int num9;
											if (!enumerator.MoveNext())
											{
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
												{
													num9 = 1;
												}
												goto IL_0148;
											}
											goto IL_01b0;
											IL_01b0:
											current2 = enumerator.Current;
											num9 = 3;
											goto IL_0148;
											IL_0148:
											while (true)
											{
												switch (num9)
												{
												case 2:
													break;
												case 3:
													mDdUyGhp1vF0Fm0yjT5K(streamWriter, current2.ToString());
													num9 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
													{
														num9 = 2;
													}
													continue;
												default:
													goto IL_01b0;
												case 1:
													goto end_IL_0162;
												}
												break;
											}
											continue;
											end_IL_0162:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator).Dispose();
										int num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
										{
											num10 = 0;
										}
										switch (num10)
										{
										case 0:
											break;
										}
									}
									goto case 8;
								case 10:
									streamWriter.Flush();
									num4 = 9;
									break;
								case 5:
									try
									{
										while (true)
										{
											IL_0296:
											int num7;
											if (!enumerator.MoveNext())
											{
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
												{
													num7 = 1;
												}
												goto IL_0241;
											}
											goto IL_025b;
											IL_025b:
											current = enumerator.Current;
											num7 = 3;
											goto IL_0241;
											IL_0241:
											while (true)
											{
												switch (num7)
												{
												case 3:
													mDdUyGhp1vF0Fm0yjT5K(streamWriter, current.ToString());
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
													{
														num7 = 2;
													}
													continue;
												case 2:
													goto IL_0296;
												case 1:
													goto end_IL_0296;
												}
												break;
											}
											goto IL_025b;
											continue;
											end_IL_0296:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator).Dispose();
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									goto case 10;
								case 1:
									sHA = (SHA1)d4MPmQhp3ohNjSFAvZvf();
									num4 = 3;
									break;
								case 4:
								{
									enumerator = _sourceCodes.GetEnumerator();
									int num11 = 6;
									num4 = num11;
									break;
								}
								case 8:
									HhGlyqhpPCf1DgHFeE9Z(streamWriter, rpKnaVhpebLllViSqwR9(SiBTN5hpNDTPBWELCoT7(list), zbGPnmhpCXXdX5PMmcRs(-740338220 ^ -740341626)));
									num4 = 7;
									break;
								default:
									enumerator = list.GetEnumerator();
									num4 = 5;
									break;
								case 2:
									HhGlyqhpPCf1DgHFeE9Z(streamWriter, string.Concat(_sourceCodes.Sum((SourceCode s) => _003C_003Ec.vvZF7AviIkinCTaI8ZtT(_003C_003Ec.jH7qB6viCvjisCIndC8h(s))), zbGPnmhpCXXdX5PMmcRs(-2107978722 ^ -2107977396)));
									num4 = 4;
									break;
								case 7:
									HhGlyqhpPCf1DgHFeE9Z(streamWriter, rpKnaVhpebLllViSqwR9(list.Sum((SourceCode source) => _003C_003Ec.vvZF7AviIkinCTaI8ZtT(_003C_003Ec.jH7qB6viCvjisCIndC8h(source))), zbGPnmhpCXXdX5PMmcRs(0x53CB464B ^ 0x53CB5B19)));
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
									{
										num4 = 0;
									}
									break;
								case 3:
									try
									{
										result = (string)mDj3pOhppkfNiqAxXp2H(sHA.ComputeHash(memoryStream));
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
										{
											num5 = 0;
										}
										return num5 switch
										{
											0 => result, 
											_ => result, 
										};
									}
									finally
									{
										if (sHA != null)
										{
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													tAM9WjhpS4bs2XrbYpaA(sHA);
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
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
								}
							}
						}
						finally
						{
							if (streamWriter != null)
							{
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
								{
									num12 = 0;
								}
								while (true)
								{
									switch (num12)
									{
									default:
										tAM9WjhpS4bs2XrbYpaA(streamWriter);
										num12 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
										{
											num12 = 1;
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
				finally
				{
					int num13;
					if (memoryStream == null)
					{
						num13 = 2;
						goto IL_0546;
					}
					goto IL_055c;
					IL_0546:
					switch (num13)
					{
					case 2:
						goto end_IL_0531;
					case 1:
						goto end_IL_0531;
					}
					goto IL_055c;
					IL_055c:
					((IDisposable)memoryStream).Dispose();
					num13 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num13 = 1;
					}
					goto IL_0546;
					end_IL_0531:;
				}
			case 3:
				_sourceCodes.Where((SourceCode sc) => _003C_003Ec.jH7qB6viCvjisCIndC8h(sc) == null).ForEach(delegate(SourceCode sc)
				{
					int num14 = 1;
					int num15 = num14;
					while (true)
					{
						switch (num15)
						{
						default:
							return;
						case 1:
							_003C_003Ec.ysyXBOviZPiKVVVncZts(sc, _003C_003Ec.DfunG7vi8ixkcySeWGK2(_003C_003Ec.JK6rvWvivKknSqA7LAFt(sc), Encoding.UTF8));
							num15 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num15 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 2;
				break;
			case 2:
				_sourceCodes.Sort((SourceCode l, SourceCode r) => _003C_003Ec.JtQ5LOviuOQ7n4UeYZ7Z(_003C_003Ec.jH7qB6viCvjisCIndC8h(l), r.Code));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				list = (from resource in _embeddedResources
					select new SourceCode
					{
						FileName = resource.Key,
						Code = Convert.ToBase64String(resource.Value)
					} into r
					orderby r.Code
					select r).ToList();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public virtual void AddReference(string assemblyFileName)
	{
		int num = 2;
		int num2 = num;
		string fileName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (_referenceNames.Add(fileName))
				{
					num2 = 3;
					break;
				}
				return;
			case 2:
				SFDpObhparY6r5PkKhqe(assemblyFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766043386));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return;
			case 1:
				Contract.ArgumentNotNullOrEmpty(assemblyFileName, (string)zbGPnmhpCXXdX5PMmcRs(-1876063057 ^ -1875976061));
				num2 = 4;
				break;
			case 3:
				_references.Add(assemblyFileName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				fileName = Path.GetFileName(assemblyFileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void AddGlobalReference(string assemblyName)
	{
		//Discarded unreachable code: IL_007f, IL_00a9
		int num = 1;
		int num2 = num;
		while (true)
		{
			string text;
			switch (num2)
			{
			case 2:
				return;
			case 4:
				return;
			default:
				if (!wHor53hptiKJhrZvo2kk(assemblyName, zbGPnmhpCXXdX5PMmcRs(-218496594 ^ -218413804), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 6;
					continue;
				}
				text = assemblyName;
				break;
			case 3:
				if (!_referenceNames.Add(assemblyName))
				{
					num2 = 4;
					continue;
				}
				goto case 5;
			case 6:
				text = assemblyName + (string)zbGPnmhpCXXdX5PMmcRs(-16752921 ^ -16704931);
				break;
			case 5:
				_references.Add((string)MaYP2bhp8cx97MPpo7xA(AssemblyReferenceHelper.GlobalAssemblyLocation, assemblyName));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				Np39euhpDEdOiQXpDEJu(assemblyName, zbGPnmhpCXXdX5PMmcRs(0x68BBB53E ^ 0x68B8D082));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			}
			assemblyName = text;
			num2 = 3;
		}
	}

	public virtual void AddReference(Assembly assembly)
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
				_referencedAssemblies.Add(assembly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SFDpObhparY6r5PkKhqe(assembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E5CF5));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void AddReference(byte[] assemblyRaw)
	{
		//Discarded unreachable code: IL_0053
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				if (assemblyRaw == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = QkdShyhpw7kQu19SBJul(assemblyRaw, false);
				break;
			case 2:
				return;
			default:
				obj = null;
				break;
			case 3:
				J7S20Jhp4Qlf8NYYJIq0(this, memoryStream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 2;
				}
				continue;
			}
			memoryStream = (MemoryStream)obj;
			num2 = 3;
		}
	}

	public virtual void AddReference(MemoryStream assemblyRaw)
	{
		//Discarded unreachable code: IL_0074, IL_00b7
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (assemblyRaw == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			case 4:
				if (assemblyRaw.Length <= 0)
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				return;
			case 1:
				SFDpObhparY6r5PkKhqe(assemblyRaw, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269D339A));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 6:
				return;
			case 5:
				break;
			}
			referencedAssemblyRaws.Add(assemblyRaw);
			num2 = 6;
		}
	}

	public virtual bool AddReferenceByName(string assemblyName)
	{
		//Discarded unreachable code: IL_00f8, IL_0129, IL_0138, IL_01ba
		int num = 7;
		MemoryStream memoryStream = default(MemoryStream);
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 3:
					J7S20Jhp4Qlf8NYYJIq0(this, memoryStream);
					num = 14;
					break;
				case 7:
					_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
					num2 = 6;
					continue;
				case 10:
					if (memoryStream != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 2:
					if (assembly == null)
					{
						num = 8;
						break;
					}
					if (!assembly.IsDynamic)
					{
						num2 = 9;
						continue;
					}
					goto case 11;
				case 13:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass34_.assemblyName, (string)zbGPnmhpCXXdX5PMmcRs(0x638095EB ^ 0x6383F057));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass34_.assemblyName = assemblyName;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
				case 9:
					GnS7jRhpHwlMLeubvpMe(this, assembly);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					assembly = ComponentManager.GetAssemblies().FirstOrDefault(_003C_003Ec__DisplayClass34_._003CAddReferenceByName_003Eb__0);
					num2 = 2;
					continue;
				case 1:
				case 14:
					return true;
				case 11:
					memoryStream = (MemoryStream)nWqb3Ehp61P9GWtxWXxx(assembly);
					num2 = 10;
					continue;
				case 8:
					return false;
				case 5:
					Np39euhpDEdOiQXpDEJu(_003C_003Ec__DisplayClass34_.assemblyName, zbGPnmhpCXXdX5PMmcRs(-1870892489 ^ -1870719093));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	public virtual void AddEmbeddedResource(string name, byte[] data)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				SFDpObhparY6r5PkKhqe(data, zbGPnmhpCXXdX5PMmcRs(-2138160520 ^ -2138079352));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				SFDpObhparY6r5PkKhqe(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475860753));
				num2 = 2;
				break;
			case 2:
				Np39euhpDEdOiQXpDEJu(name, zbGPnmhpCXXdX5PMmcRs(-1123633026 ^ -1123634072));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_embeddedResources.Add(name, data);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected virtual void AddDefaultGlobalReferences()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				YX7XXrhpxZ74lBQPeMux(this, zbGPnmhpCXXdX5PMmcRs(0x49E27B8A ^ 0x49E04112));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				YX7XXrhpxZ74lBQPeMux(this, zbGPnmhpCXXdX5PMmcRs(0x3630F361 ^ 0x3632C63B));
				num2 = 3;
				break;
			case 2:
				AddGlobalReference((string)zbGPnmhpCXXdX5PMmcRs(-1426094279 ^ -1426214375));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public void AddAnalyzers(params DiagnosticAnalyzer[] analyzers)
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
				this.analyzers.AddRange(analyzers);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetSourceFileName(string prefix = "Source", string extension = ".cs")
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				num3 = 1;
				num2 = 3;
				break;
			case 2:
			case 3:
				text = prefix + num3++ + extension;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return Path.Combine(tempDir.Value, text);
			default:
				if (!fileNames.Add(text))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	public virtual byte[] Build(bool pdb = true, bool doc = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				MemoryStream memoryStream = BuildToStream(pdb, doc);
				if (memoryStream == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (byte[])VxBKmdhpACqRNCBMIACQ(memoryStream);
			}
			default:
				return null;
			}
		}
	}

	public virtual MemoryStream BuildToStream(bool pdb = true, bool doc = true)
	{
		//Discarded unreachable code: IL_00a5, IL_00af, IL_0117, IL_0126, IL_014d, IL_015c, IL_0218, IL_0227, IL_025e, IL_0271
		int num = 5;
		int num2 = num;
		EmitResult emitResult = default(EmitResult);
		HashSet<Assembly>.Enumerator enumerator = default(HashSet<Assembly>.Enumerator);
		MemoryStream memoryStream = default(MemoryStream);
		Assembly current = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 5:
				sOF4DLhp0vaQjBNtjOLJ(AssemblyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307F2F81));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 2;
				}
				break;
			case 9:
				if (!tT6g06hpyD6t80BMYbmD(emitResult))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return AssemblyRawStream;
			case 6:
				try
				{
					while (true)
					{
						IL_01fd:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 9;
							goto IL_00b3;
						}
						goto IL_01da;
						IL_00b3:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 3:
								if ((memoryStream = (MemoryStream)nWqb3Ehp61P9GWtxWXxx(current)) == null)
								{
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto case 7;
							case 1:
								g1EFALhpk1151nQsQa8W(this, FMevcAhpK1GuqjdF9Dhs(current));
								num3 = 5;
								continue;
							case 7:
								AddReference(memoryStream);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								if (fV1oR4hpR9MOMp7OQ1IU(current))
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 6;
							case 6:
								if (!WtO2JnhpXsH8jk2KuwEN(FMevcAhpK1GuqjdF9Dhs(current)))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 2;
							case 10:
								break;
							default:
								goto IL_01fd;
							case 9:
								goto end_IL_01fd;
							}
							break;
						}
						goto IL_01da;
						IL_01da:
						current = enumerator.Current;
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num3 = 1;
						}
						goto IL_00b3;
						continue;
						end_IL_01fd:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 4:
				enVqImhpmKIHWOPhiBpS(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				enumerator = _referencedAssemblies.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				return null;
			case 1:
				ProcessErrors(emitResult.Diagnostics);
				num2 = 8;
				break;
			default:
				emitResult = Compile(AssemblyName, _sourceCodes, _references, referencedAssemblyRaws, _embeddedResources, pdb, doc, out assemblyRawStream, out debugRawStream, out documentationRawStream, analyzers, PublicKey, CancellationToken);
				num2 = 9;
				break;
			case 7:
				_sourceCodes.Where((SourceCode sc) => _003C_003Ec.jH7qB6viCvjisCIndC8h(sc) == null).ForEach(delegate(SourceCode sc)
				{
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.ysyXBOviZPiKVVVncZts(sc, _003C_003Ec.DfunG7vi8ixkcySeWGK2(_003C_003Ec.JK6rvWvivKknSqA7LAFt(sc), Encoding.UTF8));
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num6 = 0;
							}
							break;
						}
					}
				});
				num2 = 3;
				break;
			case 3:
				_sourceCodes.Where((SourceCode sc) => _003C_003Ec.JK6rvWvivKknSqA7LAFt(sc) == null).ForEach(delegate(SourceCode sc)
				{
					int num7 = 1;
					int num8 = num7;
					while (true)
					{
						switch (num8)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							lyqwZEhpOX3wSviCpqwS(sc, GetSourceFileName((string)zbGPnmhpCXXdX5PMmcRs(-1852837372 ^ -1853055288), (string)zbGPnmhpCXXdX5PMmcRs(-1767720453 ^ -1767661387)));
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num8 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void SaveSourceCodes()
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00bc, IL_00cb, IL_00db, IL_00ea, IL_01b6, IL_01c9, IL_01d8
		int num = 1;
		int num2 = num;
		List<SourceCode>.Enumerator enumerator = default(List<SourceCode>.Enumerator);
		SourceCode current = default(SourceCode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = _sourceCodes.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num3 = 3;
						}
						goto IL_003c;
					}
					goto IL_0167;
					IL_0167:
					current = enumerator.Current;
					num3 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num3 = 2;
					}
					goto IL_003c;
					IL_003c:
					while (true)
					{
						switch (num3)
						{
						case 6:
						case 7:
							Y2r5RBhpdvXO5ElyQSfB(hmHV7xhpMSSghQjMegQh(current), current.Code, Dlo9JZhp9pw2vNNx89ar());
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num3 = 1;
							}
							continue;
						case 5:
							if (NNyJywhpJSNrqyxOLZmO(hmHV7xhpMSSghQjMegQh(current)))
							{
								num3 = 2;
								continue;
							}
							goto default;
						case 3:
							Directory.CreateDirectory(Path.GetDirectoryName((string)hmHV7xhpMSSghQjMegQh(current)));
							num3 = 7;
							continue;
						default:
							if (Directory.Exists(Path.GetDirectoryName((string)hmHV7xhpMSSghQjMegQh(current))))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 3;
						case 1:
						case 2:
							break;
						case 4:
							goto IL_0167;
						case 8:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
	{
		SaveSourceCodes();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998333104)));
		foreach (Diagnostic item in diagnostics.Where((Diagnostic x) => x.Severity == DiagnosticSeverity.Error))
		{
			stringBuilder.AppendLine();
			stringBuilder.Append(item);
		}
		throw new Exception(stringBuilder.ToString());
	}

	[Obsolete("Использовать не рекомендуется, используйте AddReferences(IEnumerable<IReferenceProviderBase>)", false)]
	protected void AddDefaultReferences<T>() where T : IReferenceProviderBase
	{
		if (ComponentManager.Initialized)
		{
			IEnumerable<T> extensionPoints = ComponentManager.Current.GetExtensionPoints<T>();
			AddReferences(extensionPoints.Cast<IReferenceProviderBase>());
		}
	}

	protected void AddReferences(IEnumerable<IReferenceProviderBase> providers)
	{
		foreach (IReferenceProviderBase provider in providers)
		{
			string[] defaultReferences = provider.GetDefaultReferences();
			if (defaultReferences == null)
			{
				continue;
			}
			string[] array = defaultReferences;
			foreach (string text in array)
			{
				if (Path.IsPathRooted(text))
				{
					AddReference(text);
				}
				else
				{
					AddReferenceByName(text);
				}
			}
		}
	}

	protected void AddDefaultReferencesFromConfig(AssemblyBuilderSection configSection)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0074, IL_0130, IL_013f, IL_0172, IL_01bf, IL_01f6
		int num = 2;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		Assembly assembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (configSection == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (Y9IkLKhpl1xSq3l2kRNP(configSection) == null)
				{
					num2 = 5;
					continue;
				}
				goto case 3;
			case 4:
				return;
			case 5:
				return;
			case 3:
				enumerator = ((ConfigurationElementCollection)Y9IkLKhpl1xSq3l2kRNP(configSection)).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				throw new ArgumentNullException((string)zbGPnmhpCXXdX5PMmcRs(0x20261A4F ^ 0x202576E1));
			}
			try
			{
				while (true)
				{
					IL_00e3:
					int num3;
					if (!PnTAsShpV09df55rTsxZ(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num3 = 0;
						}
						goto IL_0078;
					}
					goto IL_00b1;
					IL_00b1:
					assembly = Assembly.Load((string)vGAJCshpgs4Cduh3J3Vx((AssemblyInfo)uFUYnqhprO3O2WJRrUrT(enumerator)));
					num3 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num3 = 4;
					}
					goto IL_0078;
					IL_0078:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 4:
							if (!X0q8Ughp5itH2g28fD4y(assembly, null))
							{
								num3 = 5;
								continue;
							}
							goto case 3;
						case 2:
							break;
						case 1:
						case 5:
							goto IL_00e3;
						case 3:
							AddReference(assembly);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
					goto IL_00b1;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						if (disposable != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num4 = 1;
							}
							continue;
						}
						break;
					case 1:
						tAM9WjhpS4bs2XrbYpaA(disposable);
						num4 = 2;
						continue;
					case 2:
						break;
					}
					break;
				}
			}
		}
	}

	protected void AddDefaultReferencesFromConfig(string sectionName)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		AssemblyBuilderSection assemblyBuilderSection = default(AssemblyBuilderSection);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				AddDefaultReferencesFromConfig(assemblyBuilderSection);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (assemblyBuilderSection == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				return;
			case 4:
				assemblyBuilderSection = S2SnaYhpjGdR3c5JooAP(sectionName) as AssemblyBuilderSection;
				num2 = 3;
				break;
			}
		}
	}

	protected void AddDefaultReferencesFromElmaConfig(string sectionName)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 3;
		AssemblyBuilderSection assemblyBuilderSection = default(AssemblyBuilderSection);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					AddDefaultReferencesFromConfig(assemblyBuilderSection);
					num2 = 6;
					continue;
				case 6:
					return;
				case 7:
					if (assemblyBuilderSection == null)
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
				{
					IRuntimeApplication obj2 = RuntimeApplication;
					if (obj2 == null)
					{
						num2 = 2;
						continue;
					}
					object obj3 = C8ZkElhpYTpwWKwH2jXO(obj2);
					if (obj3 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = ((RuntimeConfiguration)obj3).Config;
					break;
				}
				case 1:
					return;
				case 5:
					goto end_IL_0012;
				case 2:
					obj = null;
					break;
				default:
					obj = null;
					break;
				}
				if (obj == null)
				{
					return;
				}
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			assemblyBuilderSection = aLM9FhhpUYZ0J86CJJPu(BmnkcohpLe8s92Cki1O6(runtimeApplication.Configuration), sectionName) as AssemblyBuilderSection;
			num = 7;
		}
	}

	private static EmitResult Compile(object assemblyName, IEnumerable<SourceCode> sourceCodes, IEnumerable<string> referencePaths, IEnumerable<MemoryStream> referencedAssemblyRaws, IEnumerable<KeyValuePair<string, byte[]>> embeddedResources, bool pdb, bool doc, out MemoryStream peRaw, out MemoryStream pdbRaw, out MemoryStream docRaw, List<DiagnosticAnalyzer> analyzers, object publicKey, CancellationToken cancellationToken)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		IEnumerable<SyntaxTree> enumerable = sourceCodes.Select(delegate(SourceCode sourceCode)
		{
			object obj2 = _003C_003Ec.jH7qB6viCvjisCIndC8h(sourceCode);
			Encoding encoding = (Encoding)_003C_003Ec.uKRiZTviVwXx2US4GxjU();
			string fileName = sourceCode.FileName;
			return SyntaxFactory.ParseSyntaxTree((string)obj2, (ParseOptions)_003C_003Ec.u5h6MKviSN4GtvmyIdh3(), fileName, encoding, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken));
		});
		MetadataReference[] array = (referencePaths ?? Enumerable.Empty<string>()).Select<string, MetadataReference>(GetMetadataReference).Concat((referencedAssemblyRaws ?? Enumerable.Empty<MemoryStream>()).Select<MemoryStream, MetadataReference>(AssemblyBuilder.GetMetadataReference)).ToArray();
		AssemblyIdentityComparer @default = (AssemblyIdentityComparer)(object)DesktopAssemblyIdentityComparer.get_Default();
		CSharpCompilationOptions val = new CSharpCompilationOptions((OutputKind)2, false, (string)null, (string)null, (string)null, (IEnumerable<string>)null, (OptimizationLevel)((!pdb) ? 1 : 0), false, false, (string)null, (string)null, default(System.Collections.Immutable.ImmutableArray<byte>), (bool?)null, (Platform)0, (ReportDiagnostic)0, 4, (IEnumerable<KeyValuePair<string, ReportDiagnostic>>)null, true, false, (XmlReferenceResolver)null, (SourceReferenceResolver)null, (MetadataReferenceResolver)null, @default, (StrongNameProvider)null, false, (MetadataImportOptions)0, (NullableContextOptions)0);
		if (publicKey != null && ((Array)publicKey).Length != 0)
		{
			val = val.WithPublicSign(true).WithCryptoPublicKey(System.Collections.Immutable.ImmutableArray.ToImmutableArray<byte>((IEnumerable<byte>)publicKey));
		}
		CSharpCompilation val2 = CSharpCompilation.Create((string)assemblyName, enumerable, (IEnumerable<MetadataReference>)array, val);
		if (analyzers.Count > 0)
		{
			System.Collections.Immutable.ImmutableArray<Diagnostic> result = DiagnosticAnalyzerExtensions.WithAnalyzers((Compilation)(object)val2, System.Collections.Immutable.ImmutableArray.Create<DiagnosticAnalyzer>(analyzers.ToArray()), (AnalyzerOptions)null, default(CancellationToken)).GetAllDiagnosticsAsync().GetAwaiter()
				.GetResult();
			if (ImmutableArrayExtensions.Any<Diagnostic>(result, (Func<Diagnostic, bool>)((Diagnostic d) => (int)_003C_003Ec.W5ddYVviiO0kQFx3oEVM(d) == 3)))
			{
				peRaw = null;
				pdbRaw = null;
				docRaw = null;
				return EmitResult.ErrorResult(CastDiagnostics((IEnumerable<Diagnostic>)(object)result));
			}
		}
		IEnumerable<ResourceDescription> enumerable2 = embeddedResources?.Select((Func<KeyValuePair<string, byte[]>, ResourceDescription>)delegate(KeyValuePair<string, byte[]> manifestResource)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			_003C_003Ec__DisplayClass78_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass78_0();
			CS_0024_003C_003E8__locals0.manifestResource = manifestResource;
			return new ResourceDescription(CS_0024_003C_003E8__locals0.manifestResource.Key, (Func<Stream>)(() => (Stream)_003C_003Ec__DisplayClass78_0.jAme2hvi6q6vtgFeM6MO(CS_0024_003C_003E8__locals0.manifestResource.Value, false)), true);
		});
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		MemoryStream memoryStream3 = null;
		try
		{
			memoryStream = MemoryHelper.GetMemoryStream();
			memoryStream2 = MemoryHelper.GetMemoryStream();
			memoryStream3 = MemoryHelper.GetMemoryStream();
			EmitResult val3 = ((Compilation)val2).Emit((Stream)memoryStream, (Stream)(pdb ? memoryStream2 : null), (Stream)(doc ? memoryStream3 : null), (Stream)null, enumerable2, (EmitOptions)null, (IMethodSymbol)null, (Stream)null, (IEnumerable<EmbeddedText>)null, (Stream)null, cancellationToken);
			if (!val3.get_Success())
			{
				peRaw = null;
				pdbRaw = null;
				docRaw = null;
				return EmitResult.ErrorResult(CastDiagnostics((IEnumerable<Diagnostic>)(object)val3.get_Diagnostics()));
			}
			peRaw = memoryStream;
			if (pdb && memoryStream2.Length > 0)
			{
				pdbRaw = memoryStream2;
			}
			else
			{
				pdbRaw = null;
				memoryStream2.Dispose();
			}
			if (doc && memoryStream3.Length > 0)
			{
				docRaw = memoryStream3;
			}
			else
			{
				docRaw = null;
				memoryStream3.Dispose();
			}
			return EmitResult.SuccessResult(CastDiagnostics((IEnumerable<Diagnostic>)(object)val3.get_Diagnostics()));
		}
		catch
		{
			memoryStream?.Dispose();
			memoryStream2?.Dispose();
			memoryStream3?.Dispose();
			throw;
		}
	}

	private static IEnumerable<Diagnostic> CastDiagnostics(IEnumerable<Diagnostic> diagnostics)
	{
		return diagnostics.Select(delegate(Diagnostic d)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected I4, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			FileLinePositionSpan? val2 = default(FileLinePositionSpan?);
			FileLinePositionSpan? val = default(FileLinePositionSpan?);
			while (true)
			{
				FileLinePositionSpan? val3;
				switch (num2)
				{
				default:
					val2 = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
				{
					object obj4 = _003C_003Ec.uUvUiuviRSFLvMIOMpcS(d);
					if (obj4 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 0;
						}
						break;
					}
					val3 = _003C_003Ec.K3NVyiviqHaYZY8vSUox(obj4);
					goto IL_008b;
				}
				case 2:
					val3 = val2;
					goto IL_008b;
				case 3:
					{
						Diagnostic diagnostic = new Diagnostic();
						_003C_003Ec.Yqcx8eviKeaWrejK5pBX(diagnostic, (DiagnosticSeverity)d.get_Severity());
						_003C_003Ec.y72n4wviXc5qGUENPUbU(diagnostic, d.get_Id());
						Location location = new Location();
						object obj;
						FileLinePositionSpan valueOrDefault;
						if (!val.HasValue)
						{
							obj = null;
						}
						else
						{
							valueOrDefault = val.GetValueOrDefault();
							obj = ((FileLinePositionSpan)(ref valueOrDefault)).get_Path();
						}
						if (obj == null)
						{
							if (d == null)
							{
								obj = null;
							}
							else
							{
								object obj2 = _003C_003Ec.uUvUiuviRSFLvMIOMpcS(d);
								if (obj2 == null)
								{
									obj = null;
								}
								else
								{
									object obj3 = _003C_003Ec.kOW3ijviTSIdWF40DqVX(obj2);
									obj = ((obj3 != null) ? ((SyntaxTree)obj3).get_FilePath() : null);
								}
							}
						}
						_003C_003Ec.mGK2lDvik0OWWYDGf50e(location, obj);
						int character;
						LinePosition startLinePosition;
						if (!val.HasValue)
						{
							character = 0;
						}
						else
						{
							valueOrDefault = val.GetValueOrDefault();
							startLinePosition = ((FileLinePositionSpan)(ref valueOrDefault)).get_StartLinePosition();
							character = ((LinePosition)(ref startLinePosition)).get_Character() + 1;
						}
						location.Character = character;
						int value;
						if (!val.HasValue)
						{
							value = 0;
						}
						else
						{
							valueOrDefault = val.GetValueOrDefault();
							startLinePosition = ((FileLinePositionSpan)(ref valueOrDefault)).get_StartLinePosition();
							value = ((LinePosition)(ref startLinePosition)).get_Line() + 1;
						}
						_003C_003Ec.BOvMx4vinA7yarxexieg(location, value);
						_003C_003Ec.XcaOWXviOJPCwicJi9mT(diagnostic, location);
						diagnostic.Message = (string)_003C_003Ec.tB9WFWvi2VQLXiFuQG4C(d, null);
						return diagnostic;
					}
					IL_008b:
					val = val3;
					num2 = 3;
					break;
				}
			}
		}).ToArray();
	}

	private static MetadataReference GetMetadataReference(object path)
	{
		//Discarded unreachable code: IL_0073, IL_01da
		int num = 2;
		_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = default(_003C_003Ec__DisplayClass81_0);
		Tuple<DateTime, long, MetadataReference> value = default(Tuple<DateTime, long, MetadataReference>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass81_.path = (string)path;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (value.Item2 != SFQKLLhaFR6VfGiP11Ja(_003C_003Ec__DisplayClass81_.info))
					{
						num2 = 9;
						continue;
					}
					goto case 6;
				case 2:
					_003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (!oCHJy6hpsyRsmX9pBnMr(_003C_003Ec__DisplayClass81_.path, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867942700)))
					{
						num2 = 5;
						continue;
					}
					goto case 8;
				case 10:
					if (P4jjMIhpz7io0nBvkwuU(value.Item1, gAtxGxhpcdEEYFU9fefq(_003C_003Ec__DisplayClass81_.info)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 6:
					return value.Item3;
				case 8:
					_003C_003Ec__DisplayClass81_.path = (string)zbGPnmhpCXXdX5PMmcRs(-97972138 ^ -97834290);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
				case 11:
					_003C_003Ec__DisplayClass81_.info = new FileInfo(_003C_003Ec__DisplayClass81_.path);
					num2 = 7;
					continue;
				case 7:
					if (fileReferences.TryGetValue(_003C_003Ec__DisplayClass81_.path, out value))
					{
						num2 = 10;
						continue;
					}
					break;
				}
				break;
			}
			value = fileReferences.AddOrUpdate(_003C_003Ec__DisplayClass81_.path, _003C_003Ec__DisplayClass81_._003CGetMetadataReference_003Eb__0, _003C_003Ec__DisplayClass81_._003CGetMetadataReference_003Eb__1);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static MetadataReference GetMetadataReference(object referenceRaw)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				xBAygdhp7pAtxIrWK85t(referenceRaw, 0L, SeekOrigin.Begin);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				object result = RmhfRNhaWlOlYJjKybPA(MshxW3haBykmHeEUTsWq(referenceRaw), default(MetadataReferenceProperties), null, null);
				((Stream)referenceRaw).Seek(0L, SeekOrigin.Begin);
				return (MetadataReference)result;
			}
			}
		}
	}

	~AssemblyBuilder()
	{
		//Discarded unreachable code: IL_0046, IL_007d, IL_0090, IL_009f
		switch (1)
		{
		case 1:
			try
			{
				URnqoghaooGYEj9TVItL(this, false);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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
			finally
			{
				base.Finalize();
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		case 0:
			break;
		}
	}

	public void Dispose()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				GC.SuppressFinalize(this);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				URnqoghaooGYEj9TVItL(this, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0059, IL_0063, IL_0124, IL_0137
		int num = 4;
		int num2 = num;
		List<MemoryStream>.Enumerator enumerator = default(List<MemoryStream>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 1;
							}
							goto IL_0067;
						}
						goto IL_00a7;
						IL_00a7:
						MemoryStream current = enumerator.Current;
						if (current == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							DXGPSdhabjdBx46DaQg6(current);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num3 = 3;
							}
						}
						goto IL_0067;
						IL_0067:
						switch (num3)
						{
						case 2:
							goto IL_00a7;
						case 1:
							goto end_IL_0081;
						}
						continue;
						end_IL_0081:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 0:
				return;
			case 3:
				enumerator = referencedAssemblyRaws.GetEnumerator();
				num2 = 2;
				break;
			case 5:
				disposed = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 4:
				if (disposed)
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	public AssemblyBuilder()
	{
		//Discarded unreachable code: IL_00f0, IL_00f5
		zMrEe2hahbyXPPNXZI1k();
		tempDir = new Lazy<string>(() => (string)_003C_003Ec.BGTOUOvieajh7AGA8BIl());
		fileNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		_references = new HashSet<string>((IEqualityComparer<string>)xCWhUXhaG0nNCH33cJxE());
		_referencedAssemblies = new HashSet<Assembly>();
		referencedAssemblyRaws = new List<MemoryStream>();
		_referenceNames = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
		_sourceCodes = new List<SourceCode>();
		_embeddedResources = new Dictionary<string, byte[]>();
		analyzers = new List<DiagnosticAnalyzer>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AssemblyBuilder()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				fileReferences = new ConcurrentDictionary<string, Tuple<DateTime, long, MetadataReference>>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				zMrEe2hahbyXPPNXZI1k();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool GKZQA7hpEvQJHeuGDYMl()
	{
		return FBF21fhpGakSivTQiG7a == null;
	}

	internal static AssemblyBuilder mpTQbxhpfyMkb1jvKyP7()
	{
		return FBF21fhpGakSivTQiG7a;
	}

	internal static bool Bhi4xshpQcIFE0dawrt2()
	{
		return Locator.Initialized;
	}

	internal static object zbGPnmhpCXXdX5PMmcRs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object PXrSMFhpv8D5FZMSTYg0(object P_0)
	{
		return ((ComponentManager)P_0).AssemblyPaths;
	}

	internal static object MaYP2bhp8cx97MPpo7xA(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool KkRhd5hpZ1I3J3MHNqyj(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object T5ifyghpu0dcVG05lFSD(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object gFClR1hpIWkaN4XtN9bi(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static bool PnTAsShpV09df55rTsxZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void tAM9WjhpS4bs2XrbYpaA(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object X1rYLshpi5ZdVKpXe57J()
	{
		return ComponentManager.GetAssemblies();
	}

	internal static bool fV1oR4hpR9MOMp7OQ1IU(object P_0)
	{
		return ((Assembly)P_0).IsDynamic;
	}

	internal static object GsyvvZhpqMSCTx5M7UZ1(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object FMevcAhpK1GuqjdF9Dhs(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool WtO2JnhpXsH8jk2KuwEN(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool XojJMYhpTAWEvMubFfZs(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void g1EFALhpk1151nQsQa8W(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((string)P_1);
	}

	internal static void AtuYfHhpnoNr4OUmiQZF(object P_0, object P_1)
	{
		((SourceCode)P_0).Code = (string)P_1;
	}

	internal static void lyqwZEhpOX3wSviCpqwS(object P_0, object P_1)
	{
		((SourceCode)P_0).FileName = (string)P_1;
	}

	internal static object LWLbrHhp27nEGXQBPLgD()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object rpKnaVhpebLllViSqwR9(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void HhGlyqhpPCf1DgHFeE9Z(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void mDdUyGhp1vF0Fm0yjT5K(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static int SiBTN5hpNDTPBWELCoT7(object P_0)
	{
		return ((List<SourceCode>)P_0).Count;
	}

	internal static object d4MPmQhp3ohNjSFAvZvf()
	{
		return SHA1.Create();
	}

	internal static object mDj3pOhppkfNiqAxXp2H(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static void SFDpObhparY6r5PkKhqe(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void Np39euhpDEdOiQXpDEJu(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool wHor53hptiKJhrZvo2kk(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	internal static object QkdShyhpw7kQu19SBJul(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static void J7S20Jhp4Qlf8NYYJIq0(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((MemoryStream)P_1);
	}

	internal static object nWqb3Ehp61P9GWtxWXxx(object P_0)
	{
		return ComponentManager.GetLoadedAssemblyRawAsStream((Assembly)P_0);
	}

	internal static void GnS7jRhpHwlMLeubvpMe(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((Assembly)P_1);
	}

	internal static object VxBKmdhpACqRNCBMIACQ(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static long xBAygdhp7pAtxIrWK85t(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void YX7XXrhpxZ74lBQPeMux(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddGlobalReference((string)P_1);
	}

	internal static void sOF4DLhp0vaQjBNtjOLJ(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static void enVqImhpmKIHWOPhiBpS(object P_0)
	{
		((AssemblyBuilder)P_0).AddDefaultGlobalReferences();
	}

	internal static bool tT6g06hpyD6t80BMYbmD(object P_0)
	{
		return ((EmitResult)P_0).Success;
	}

	internal static object hmHV7xhpMSSghQjMegQh(object P_0)
	{
		return ((SourceCode)P_0).FileName;
	}

	internal static bool NNyJywhpJSNrqyxOLZmO(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object Dlo9JZhp9pw2vNNx89ar()
	{
		return Encoding.UTF8;
	}

	internal static void Y2r5RBhpdvXO5ElyQSfB(object P_0, object P_1, object P_2)
	{
		File.WriteAllText((string)P_0, (string)P_1, (Encoding)P_2);
	}

	internal static object Y9IkLKhpl1xSq3l2kRNP(object P_0)
	{
		return ((AssemblyBuilderSection)P_0).Assemblies;
	}

	internal static object uFUYnqhprO3O2WJRrUrT(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object vGAJCshpgs4Cduh3J3Vx(object P_0)
	{
		return ((AssemblyInfo)P_0).Assembly;
	}

	internal static bool X0q8Ughp5itH2g28fD4y(object P_0, object P_1)
	{
		return (Assembly)P_0 != (Assembly)P_1;
	}

	internal static object S2SnaYhpjGdR3c5JooAP(object P_0)
	{
		return ConfigurationManager.GetSection((string)P_0);
	}

	internal static object C8ZkElhpYTpwWKwH2jXO(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object BmnkcohpLe8s92Cki1O6(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object aLM9FhhpUYZ0J86CJJPu(object P_0, object P_1)
	{
		return ((System.Configuration.Configuration)P_0).GetSection((string)P_1);
	}

	internal static bool oCHJy6hpsyRsmX9pBnMr(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static DateTime gAtxGxhpcdEEYFU9fefq(object P_0)
	{
		return ((FileSystemInfo)P_0).LastWriteTime;
	}

	internal static bool P4jjMIhpz7io0nBvkwuU(DateTime P_0, DateTime P_1)
	{
		return P_0 != P_1;
	}

	internal static long SFQKLLhaFR6VfGiP11Ja(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static object MshxW3haBykmHeEUTsWq(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static object RmhfRNhaWlOlYJjKybPA(object P_0, MetadataReferenceProperties P_1, object P_2, object P_3)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return MetadataReference.CreateFromStream((Stream)P_0, P_1, (DocumentationProvider)P_2, (string)P_3);
	}

	internal static void URnqoghaooGYEj9TVItL(object P_0, bool disposing)
	{
		((AssemblyBuilder)P_0).Dispose(disposing);
	}

	internal static void DXGPSdhabjdBx46DaQg6(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static void zMrEe2hahbyXPPNXZI1k()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object xCWhUXhaG0nNCH33cJxE()
	{
		return StringComparer.InvariantCultureIgnoreCase;
	}
}
