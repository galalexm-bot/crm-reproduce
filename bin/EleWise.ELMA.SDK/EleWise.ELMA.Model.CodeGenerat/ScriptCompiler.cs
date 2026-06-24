using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Projects;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Manager;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class ScriptCompiler : AssemblyBuilder
{
	protected class ScripModuleBinding
	{
		internal static ScripModuleBinding Hgx1MvvqMdAGT0DjBaDB;

		public IScriptModule Module
		{
			[CompilerGenerated]
			get
			{
				return _003CModule_003Ek__BackingField;
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
						_003CModule_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public RootCodeItem CodeItem
		{
			[CompilerGenerated]
			get
			{
				return _003CCodeItem_003Ek__BackingField;
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
						_003CCodeItem_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ScripModuleBinding(IScriptModule module)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			goj0JyvqdMYIuNn8shvc();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					Module = module;
					num = 2;
					break;
				case 2:
					CodeItem = null;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public ScripModuleBinding(IScriptModule module, RootCodeItem codeItem)
		{
			//Discarded unreachable code: IL_001e
			goj0JyvqdMYIuNn8shvc();
			base._002Ector();
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
				case 2:
					Module = module;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					CodeItem = codeItem;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void goj0JyvqdMYIuNn8shvc()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool ihkFUkvqJKyqKIGjmXCd()
		{
			return Hgx1MvvqMdAGT0DjBaDB == null;
		}

		internal static ScripModuleBinding b7ZBTKvq9H3eNrkDtpQ8()
		{
			return Hgx1MvvqMdAGT0DjBaDB;
		}
	}

	protected static readonly ILogger ScriptCompilerLogger;

	private readonly List<IScriptModule> modules;

	private IScriptModule singleModule;

	private List<ScriptCompileMessage> messages;

	private readonly IDictionary<string, ScripModuleBinding> moduleFileNames;

	private static ScriptCompiler F8VjoQhDTStnpiNWkkWb;

	public IExternalAssemblyDtoManager ExternalAssemblyDtoManager => Locator.GetServiceNotNull<IExternalAssemblyDtoManager>();

	internal IGlobalModulesReferenceService GlobalModulesReferenceService => Locator.GetServiceNotNull<IGlobalModulesReferenceService>();

	internal IRuntimeApplication RuntimeApplication => Locator.GetService<IRuntimeApplication>();

	public ScriptModule MainModule
	{
		[CompilerGenerated]
		get
		{
			return _003CMainModule_003Ek__BackingField;
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
					_003CMainModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IList<IScriptModule> Modules => modules;

	public ScriptCompiler()
	{
		//Discarded unreachable code: IL_004f, IL_0054
		SingletonReader.JJCZtPuTvSt();
		modules = new List<IScriptModule>();
		moduleFileNames = new Dictionary<string, ScripModuleBinding>((IEqualityComparer<string>)guF0XyhDOj0dfCNiUkvO());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ScriptCompiler(string assemblyName, IEnumerable<IScriptModule> modules)
	{
		SingletonReader.JJCZtPuTvSt();
		this.modules = new List<IScriptModule>();
		moduleFileNames = new Dictionary<string, ScripModuleBinding>(StringComparer.CurrentCultureIgnoreCase);
		base._002Ector();
		Contract.ArgumentNotNull(modules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103C99DD));
		Contract.ArgumentNotNull(assemblyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334904397));
		this.modules.AddRange(modules);
		base.AssemblyName = assemblyName;
	}

	public ScriptCompiler(IScriptModule module)
	{
		//Discarded unreachable code: IL_004f
		B4lpJ1hD2tyHvcfs8Lh3();
		modules = new List<IScriptModule>();
		moduleFileNames = new Dictionary<string, ScripModuleBinding>((IEqualityComparer<string>)guF0XyhDOj0dfCNiUkvO());
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				base.AssemblyName = module.AssemblyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 3:
				modules.Add(module);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num = 0;
				}
				break;
			default:
				singleModule = module;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 0;
				}
				break;
			case 2:
			{
				guHNXPhDeHXkEyVqP4U9(module, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE2ED51));
				int num2 = 3;
				num = num2;
				break;
			}
			}
		}
	}

	public void GenerateAssemblyInfoFile(Func<string, string> conversions = null)
	{
		string code = ModelProject.GenerateAssemblyInfoFile(conversions);
		AddSourceCodeWithName(code, GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099566611), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105128276)));
	}

	public override void AddSourceCode(string code)
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
				ecKf7nhD1trWLCLK7PJw(this, code, GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951420580), (string)CuLl61hDPEUhJkddGxbA(0x57A5235E ^ 0x57A43A10)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual ScriptCompileResult Compile()
	{
		//Discarded unreachable code: IL_00b4, IL_00c3, IL_00ce, IL_016b, IL_017a, IL_01ab, IL_01ca, IL_01d9, IL_0206, IL_0215, IL_0268, IL_02cb, IL_02fe, IL_030d, IL_041a, IL_042d, IL_043c, IL_04a5, IL_04b8, IL_04c7, IL_04fe, IL_050d, IL_0548, IL_0641, IL_0650, IL_0660, IL_0690, IL_06d0, IL_06df, IL_06eb, IL_0735, IL_0744, IL_074f, IL_0828, IL_08d2, IL_08e1, IL_08ec, IL_0a18, IL_0a2b, IL_0a61, IL_0a74, IL_0b4c, IL_0b5b, IL_0b66, IL_0c20, IL_0c58, IL_0c67, IL_0dba, IL_0df2, IL_0e01
		int num = 3;
		int num2 = num;
		bool lockTaken = default(bool);
		ScriptCompileResult result = default(ScriptCompileResult);
		ScriptCompiler scriptCompiler = default(ScriptCompiler);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current5 = default(string);
		List<IScriptModule> source = default(List<IScriptModule>);
		List<IScriptModule>.Enumerator enumerator2 = default(List<IScriptModule>.Enumerator);
		IScriptModule current = default(IScriptModule);
		List<ScriptWebReference>.Enumerator enumerator3 = default(List<ScriptWebReference>.Enumerator);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		IEnumerator<KeyValuePair<string, ScripModuleBinding>> enumerator5 = default(IEnumerator<KeyValuePair<string, ScripModuleBinding>>);
		KeyValuePair<string, ScripModuleBinding> current6 = default(KeyValuePair<string, ScripModuleBinding>);
		string sourceFileName = default(string);
		IScriptModule current4 = default(IScriptModule);
		List<RootCodeItem>.Enumerator enumerator4 = default(List<RootCodeItem>.Enumerator);
		RootCodeItem current3 = default(RootCodeItem);
		string current2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return result;
			case 3:
				scriptCompiler = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				continue;
			}
			try
			{
				Monitor.Enter(scriptCompiler, ref lockTaken);
				int num3 = 9;
				while (true)
				{
					int num12;
					switch (num3)
					{
					case 15:
						try
						{
							while (true)
							{
								int num17;
								if (!bAuZGchD3VI1bWVKJjdN(enumerator))
								{
									num17 = 5;
									goto IL_00d2;
								}
								goto IL_010a;
								IL_00d2:
								while (true)
								{
									switch (num17)
									{
									case 2:
									case 4:
										break;
									case 1:
										goto IL_010a;
									case 3:
										VyTuoshDawt9gedvimGT(this, current5);
										num17 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
										{
											num17 = 4;
										}
										continue;
									default:
										if (XWUSpFhDpoul6yariy1O(this, current5))
										{
											num17 = 2;
											continue;
										}
										goto case 3;
									case 5:
										goto end_IL_00f4;
									}
									break;
								}
								continue;
								IL_010a:
								current5 = enumerator.Current;
								num17 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num17 = 0;
								}
								goto IL_00d2;
								continue;
								end_IL_00f4:
								break;
							}
						}
						finally
						{
							int num18;
							if (enumerator == null)
							{
								num18 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num18 = 0;
								}
								goto IL_01af;
							}
							goto IL_01e4;
							IL_01e4:
							KdoeqkhDDBRxkgEia4aT(enumerator);
							num18 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num18 = 2;
							}
							goto IL_01af;
							IL_01af:
							switch (num18)
							{
							case 1:
								goto end_IL_018a;
							case 2:
								goto end_IL_018a;
							}
							goto IL_01e4;
							end_IL_018a:;
						}
						goto case 22;
					case 1:
						source = new List<IScriptModule> { MainModule };
						num3 = 18;
						break;
					case 9:
						if (MainModule == null)
						{
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num3 = 7;
							}
							break;
						}
						goto case 10;
					case 20:
						try
						{
							while (true)
							{
								IL_0447:
								int num4;
								if (!enumerator2.MoveNext())
								{
									num4 = 2;
									goto IL_027a;
								}
								goto IL_02d5;
								IL_027a:
								while (true)
								{
									switch (num4)
									{
									case 1:
										if (current.WebReferences == null)
										{
											num4 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto case 5;
									case 4:
										break;
									case 3:
										try
										{
											while (true)
											{
												int num5;
												if (!enumerator3.MoveNext())
												{
													num5 = 4;
													goto IL_031c;
												}
												goto IL_03a8;
												IL_031c:
												while (true)
												{
													switch (num5)
													{
													case 2:
														break;
													default:
														if (!MainModule.WebReferences.Any(_003C_003Ec__DisplayClass15_._003CCompile_003Eb__5))
														{
															num5 = 3;
															continue;
														}
														break;
													case 1:
														_003C_003Ec__DisplayClass15_.webReference = enumerator3.Current;
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
														{
															num5 = 0;
														}
														continue;
													case 5:
														goto IL_03a8;
													case 3:
													{
														MainModule.WebReferences.Add(_003C_003Ec__DisplayClass15_.webReference);
														int num6 = 2;
														num5 = num6;
														continue;
													}
													case 4:
														goto end_IL_033e;
													}
													break;
												}
												continue;
												IL_03a8:
												_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
												{
													num5 = 1;
												}
												goto IL_031c;
												continue;
												end_IL_033e:
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator3).Dispose();
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
											{
												num7 = 0;
											}
											switch (num7)
											{
											case 0:
												break;
											}
										}
										goto IL_0447;
									default:
										goto IL_0447;
									case 5:
									{
										enumerator3 = current.WebReferences.GetEnumerator();
										int num8 = 3;
										num4 = num8;
										continue;
									}
									case 2:
										goto end_IL_0447;
									}
									break;
								}
								goto IL_02d5;
								IL_02d5:
								current = enumerator2.Current;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num4 = 1;
								}
								goto IL_027a;
								continue;
								end_IL_0447:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num9 = 0;
							}
							switch (num9)
							{
							case 0:
								break;
							}
						}
						goto case 1;
					case 14:
						enumerator2 = modules.GetEnumerator();
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num3 = 20;
						}
						break;
					case 10:
						if (MainModule.WebReferences == null)
						{
							num3 = 11;
							break;
						}
						goto case 14;
					case 3:
						aUJTdOhDNfyZAb2EeEN2(this);
						num3 = 21;
						break;
					default:
						try
						{
							while (true)
							{
								int num19;
								if (!bAuZGchD3VI1bWVKJjdN(enumerator5))
								{
									num19 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num19 = 7;
									}
									goto IL_0556;
								}
								goto IL_060a;
								IL_060a:
								current6 = enumerator5.Current;
								num19 = 4;
								goto IL_0556;
								IL_0556:
								while (true)
								{
									switch (num19)
									{
									case 1:
									case 3:
										break;
									default:
										MdkOWChDAr9JHmjoMLeG(KsEdethDHEoLBEaQETnb(current6.Value), current6.Key);
										num19 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num19 = 3;
										}
										continue;
									case 2:
									case 5:
										F20aQJhDxDPhh40Cy7rg(yMq82vhD7x3sswpgrWkx(current6.Value), current6.Key);
										num19 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num19 = 1;
										}
										continue;
									case 6:
										goto IL_060a;
									case 4:
										if (current6.Value.CodeItem != null)
										{
											int num20 = 2;
											num19 = num20;
											continue;
										}
										goto default;
									case 7:
										goto end_IL_0580;
									}
									break;
								}
								continue;
								end_IL_0580:
								break;
							}
						}
						finally
						{
							int num21;
							if (enumerator5 == null)
							{
								num21 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num21 = 1;
								}
								goto IL_0694;
							}
							goto IL_06aa;
							IL_06aa:
							KdoeqkhDDBRxkgEia4aT(enumerator5);
							num21 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
							{
								num21 = 1;
							}
							goto IL_0694;
							IL_0694:
							switch (num21)
							{
							case 1:
								goto end_IL_066f;
							case 2:
								goto end_IL_066f;
							}
							goto IL_06aa;
							end_IL_066f:;
						}
						goto case 5;
					case 4:
						Build();
						num3 = 13;
						break;
					case 2:
						enumerator5 = moduleFileNames.GetEnumerator();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num3 = 0;
						}
						break;
					case 23:
						try
						{
							while (true)
							{
								int num13;
								if (!enumerator2.MoveNext())
								{
									num13 = 7;
									goto IL_0753;
								}
								goto IL_08b9;
								IL_0753:
								while (true)
								{
									switch (num13)
									{
									case 2:
										moduleFileNames[sourceFileName] = new ScripModuleBinding(current4);
										num13 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
										{
											num13 = 0;
										}
										continue;
									case 4:
										sourceFileName = GetSourceFileName((string)CuLl61hDPEUhJkddGxbA(-1837662597 ^ -1837887807), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103EF03B));
										num13 = 2;
										continue;
									case 3:
										enumerator4 = ((RootCodeItemCollection)b6MdLNhDwPLOugMXnKky(current4)).Items.GetEnumerator();
										num13 = 11;
										continue;
									case 1:
										ecKf7nhD1trWLCLK7PJw(this, C2MIXihDtG8GiCAALj20(current4), sourceFileName);
										num13 = 6;
										continue;
									case 9:
										if (current4.CodeItems.Items.Any())
										{
											num13 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
											{
												num13 = 3;
											}
											continue;
										}
										break;
									case 10:
										if (((RootCodeItemCollection)b6MdLNhDwPLOugMXnKky(current4)).Items == null)
										{
											num13 = 8;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
											{
												num13 = 0;
											}
											continue;
										}
										goto case 9;
									case 5:
									case 8:
										break;
									case 6:
										if (current4.CodeItems != null)
										{
											num13 = 10;
											continue;
										}
										break;
									default:
										goto IL_08b9;
									case 11:
										try
										{
											while (true)
											{
												IL_097e:
												int num14;
												if (!enumerator4.MoveNext())
												{
													num14 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
													{
														num14 = 0;
													}
													goto IL_08f0;
												}
												goto IL_0912;
												IL_0912:
												current3 = enumerator4.Current;
												num14 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
												{
													num14 = 1;
												}
												goto IL_08f0;
												IL_08f0:
												while (true)
												{
													switch (num14)
													{
													case 4:
														goto IL_0912;
													case 3:
														moduleFileNames[sourceFileName] = new ScripModuleBinding(current4, current3);
														num14 = 5;
														continue;
													case 5:
														ecKf7nhD1trWLCLK7PJw(this, VNCmBMhD498WNCygZjKR(current3), sourceFileName);
														num14 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
														{
															num14 = 1;
														}
														continue;
													case 1:
														goto IL_097e;
													case 2:
														sourceFileName = GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886421707), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F4345));
														num14 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
														{
															num14 = 3;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator4).Dispose();
											int num15 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
											{
												num15 = 0;
											}
											switch (num15)
											{
											case 0:
												break;
											}
										}
										break;
									case 7:
										goto end_IL_088d;
									}
									break;
								}
								continue;
								IL_08b9:
								current4 = enumerator2.Current;
								num13 = 4;
								goto IL_0753;
								continue;
								end_IL_088d:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
							int num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num16 = 0;
							}
							switch (num16)
							{
							case 0:
								break;
							}
						}
						goto case 16;
					case 11:
						MainModule.WebReferences = new List<ScriptWebReference>();
						num3 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num3 = 0;
						}
						break;
					case 16:
						messages = new List<ScriptCompileMessage>();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num3 = 4;
						}
						break;
					case 8:
					case 18:
						AddDefaultReferences();
						num3 = 3;
						break;
					case 7:
						enumerator2 = modules.GetEnumerator();
						num3 = 23;
						break;
					case 13:
						x8mDm9hD6miRu5u7vPY6(this);
						num12 = 2;
						goto IL_0040;
					case 5:
					{
						ScriptCompileResult scriptCompileResult = new ScriptCompileResult();
						xN1jPhhD0GIxk8HKogtP(scriptCompileResult, base.AssemblyRaw != null);
						scriptCompileResult.Messages = messages;
						result = scriptCompileResult;
						num3 = 19;
						break;
					}
					case 17:
						source = modules;
						num3 = 8;
						break;
					case 12:
						try
						{
							while (true)
							{
								int num10;
								if (!bAuZGchD3VI1bWVKJjdN(enumerator))
								{
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num10 = 0;
									}
									goto IL_0b6a;
								}
								goto IL_0bae;
								IL_0bae:
								current2 = enumerator.Current;
								num10 = 2;
								goto IL_0b6a;
								IL_0b6a:
								while (true)
								{
									switch (num10)
									{
									case 3:
										break;
									default:
										goto IL_0bae;
									case 4:
										AddGlobalReference(current2);
										num10 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num10 = 3;
										}
										continue;
									case 2:
										if (!AddReferenceByName(current2))
										{
											num10 = 4;
											continue;
										}
										break;
									case 1:
										goto end_IL_0b88;
									}
									break;
								}
								continue;
								end_IL_0b88:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num11 = 1;
								}
								while (true)
								{
									switch (num11)
									{
									case 1:
										enumerator.Dispose();
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
										{
											num11 = 0;
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
					case 21:
						enumerator = source.SelectMany((IScriptModule m) => ReferencesListHelper.GetReferences(m.References)).Distinct().GetEnumerator();
						num3 = 12;
						break;
					case 6:
						enumerator = source.SelectMany((IScriptModule m) => ReferencesListHelper.GetElmaReferences(m.ElmaReferences)).Distinct().GetEnumerator();
						num12 = 15;
						goto IL_0040;
					case 22:
						AddGlobalScriptModules((from r in source.Where((IScriptModule a) => a.GlobalScriptModules != null).SelectMany((IScriptModule a) => a.GlobalScriptModules)
							select r.Uid).ToHashSet());
						num3 = 7;
						break;
					case 19:
						{
							return result;
						}
						IL_0040:
						num3 = num12;
						break;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					int num22 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num22 = 0;
					}
					while (true)
					{
						switch (num22)
						{
						default:
							fns7rRhDmqLUGGTObpA7(scriptCompiler);
							num22 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num22 = 1;
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

	protected override void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		SaveSourceCodes();
		CS_0024_003C_003E8__locals0.errorMessages = new StringBuilder();
		messages.AddRange(diagnostics.Where(delegate(Diagnostic x)
		{
			int num3 = 2;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return x.Id != (string)_003C_003Ec.zeAgjGvqcFL2Fruk7vBv(0x3C5338FF ^ 0x3C569425);
				case 1:
					if (_003C_003Ec.WuCNdavqs2wXeyyMhOEa(x) != DiagnosticSeverity.Warning)
					{
						return false;
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					if (x.Severity != DiagnosticSeverity.Error)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num4 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}).Select(delegate(Diagnostic err, int i)
		{
			//Discarded unreachable code: IL_008a
			int num = 1;
			int num2 = num;
			ScripModuleBinding value = default(ScripModuleBinding);
			while (true)
			{
				switch (num2)
				{
				case 3:
					((StringBuilder)_003C_003Ec__DisplayClass19_0.UP1kbgvKbaNZmwKc9PWN(CS_0024_003C_003E8__locals0.errorMessages)).Append((object)err);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (!_003C_003Ec__DisplayClass19_0.gVHd6xvKo0eZ3lPEknE1(ScriptCompilerLogger))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					CS_0024_003C_003E8__locals0._003C_003E4__this.moduleFileNames.TryGetValue(((Location)_003C_003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo(err))?.FilePath ?? "", out value);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
				{
					ScriptCompileMessage scriptCompileMessage = new ScriptCompileMessage();
					_003C_003Ec__DisplayClass19_0.TJYFPQvKGYNa2xTOVy8b(scriptCompileMessage, i + 1);
					_003C_003Ec__DisplayClass19_0.sAANUFvKEfmZkAaEkAAB(scriptCompileMessage, (err.Severity == DiagnosticSeverity.Warning) ? ScriptCompileMessageType.Warning : ScriptCompileMessageType.Error);
					_003C_003Ec__DisplayClass19_0.sfYLhhvKQtK9MvHsaAd1(scriptCompileMessage, _003C_003Ec__DisplayClass19_0.f1RS8HvKfdLBUuvwh32e(err));
					_003C_003Ec__DisplayClass19_0.GT1elJvKvjFLKrW2rIaC(scriptCompileMessage, (err.Location != null) ? _003C_003Ec__DisplayClass19_0.XPKZS3vKCjFN3yGcm1Hv(_003C_003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo(err)) : 0);
					_003C_003Ec__DisplayClass19_0.JuXnM9vK80SWOntvdwfw(scriptCompileMessage, (_003C_003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo(err) != null) ? ((Location)_003C_003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo(err)).Character : 0);
					_003C_003Ec__DisplayClass19_0.VIbFM7vKI7oAvEvJlVTX(scriptCompileMessage, (value != null) ? _003C_003Ec__DisplayClass19_0.SIK3iQvKumjPRbecvW7e(_003C_003Ec__DisplayClass19_0.Q1Fgk4vKZrjJIkuKGIVs(value)) : Guid.Empty);
					scriptCompileMessage.ObjectUid = ((value != null) ? ((IScriptModule)_003C_003Ec__DisplayClass19_0.Q1Fgk4vKZrjJIkuKGIVs(value)).ObjectUid : Guid.Empty);
					_003C_003Ec__DisplayClass19_0.IxoL0gvKiPkjYC4Sg1tG(scriptCompileMessage, (value != null && _003C_003Ec__DisplayClass19_0.psJjnZvKVtZlgGgVklYo(value) != null) ? _003C_003Ec__DisplayClass19_0.CmpJ6HvKSXt86SP7x8pw(value.CodeItem) : Guid.Empty);
					return scriptCompileMessage;
				}
				}
			}
		}));
		if (ScriptCompilerLogger.IsErrorEnabled())
		{
			CS_0024_003C_003E8__locals0.errorMessages.AppendLine().Append(new StackTrace(3, fNeedFileInfo: true).ToString().TrimEnd());
			ScriptCompilerLogger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFC3E6A), CS_0024_003C_003E8__locals0.errorMessages));
		}
	}

	protected virtual void ProcessResults()
	{
		//Discarded unreachable code: IL_0032
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
			case 2:
				return;
			case 3:
			{
				ScriptModule obj = singleModule as ScriptModule;
				Rl2EkohDytQ0xGmqDhio(obj, base.AssemblyRaw);
				lNu1OUhDMstVd4O71Vly(obj, base.DebugRaw);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
				if (!(singleModule is ScriptModule))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private void AddGlobalScriptModules(ICollection<Guid> globalModulesReferenceUids)
	{
		if (globalModulesReferenceUids.Count == 0)
		{
			return;
		}
		if (RuntimeApplication != null)
		{
			_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
			CS_0024_003C_003E8__locals0.parameterSeparator = RuntimeApplication.TransformationProvider.ParameterSeparator;
			Dialect dialect = RuntimeApplication.TransformationProvider.Dialect;
			string text = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6C11FB).Substring(1));
			string text2 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210509041).Substring(1));
			string text3 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477167032));
			string text4 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51177C87));
			string text5 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138926426));
			string text6 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53C5A33));
			string text7 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12DF5F));
			string text8 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16367529));
			string sql = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234115098) + text8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822859360) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637C5781) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420902630) + text5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31301F56) + text4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123614284) + text6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487195798) + text5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EF7D98) + text7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541610541) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411333781) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70006001), globalModulesReferenceUids.Select((Guid _, int i) => string.Concat(CS_0024_003C_003E8__locals0.parameterSeparator, _003C_003Ec__DisplayClass25_0.MWHm59vKTYGstY302VA7(0x637E299B ^ 0x637EE343), i))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8316B8E);
			using IDataReader dataReader = RuntimeApplication.TransformationProvider.ExecuteQuery(sql, globalModulesReferenceUids.Select((Guid u, int i) => (u, i)).ToDictionary<(Guid, int), string, object>(((Guid uid, int index) p) => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5301F) + p.index, ((Guid uid, int index) p) => p.uid));
			while (dataReader.Read())
			{
				AddReference(dataReader.GetStream(0));
			}
			return;
		}
		foreach (Guid globalModulesReferenceUid in globalModulesReferenceUids)
		{
			string text9 = GlobalModulesReferenceService.CreateGlobalModuleAssembly(globalModulesReferenceUid);
			if (text9 != null)
			{
				AddReference(text9);
			}
		}
	}

	static ScriptCompiler()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ScriptCompilerLogger = (ILogger)oDNLkhhD9AK1oKCJKtCo(yDmXOahDJKnGIUyrpnYK(typeof(ScriptCompiler).TypeHandle));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				B4lpJ1hD2tyHvcfs8Lh3();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object guF0XyhDOj0dfCNiUkvO()
	{
		return StringComparer.CurrentCultureIgnoreCase;
	}

	internal static bool GbCcEfhDkiUy0cHepUA8()
	{
		return F8VjoQhDTStnpiNWkkWb == null;
	}

	internal static ScriptCompiler u1BHx5hDnpNd59SLMRds()
	{
		return F8VjoQhDTStnpiNWkkWb;
	}

	internal static void B4lpJ1hD2tyHvcfs8Lh3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void guHNXPhDeHXkEyVqP4U9(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object CuLl61hDPEUhJkddGxbA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ecKf7nhD1trWLCLK7PJw(object P_0, object P_1, object P_2)
	{
		((AssemblyBuilder)P_0).AddSourceCodeWithName((string)P_1, (string)P_2);
	}

	internal static void aUJTdOhDNfyZAb2EeEN2(object P_0)
	{
		((AssemblyBuilder)P_0).AddAllElmaReferences();
	}

	internal static bool bAuZGchD3VI1bWVKJjdN(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool XWUSpFhDpoul6yariy1O(object P_0, object P_1)
	{
		return ((AssemblyBuilder)P_0).AddReferenceByName((string)P_1);
	}

	internal static void VyTuoshDawt9gedvimGT(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddGlobalReference((string)P_1);
	}

	internal static void KdoeqkhDDBRxkgEia4aT(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object C2MIXihDtG8GiCAALj20(object P_0)
	{
		return ((IScriptModule)P_0).SourceCode;
	}

	internal static object b6MdLNhDwPLOugMXnKky(object P_0)
	{
		return ((IScriptModule)P_0).CodeItems;
	}

	internal static object VNCmBMhD498WNCygZjKR(object P_0)
	{
		return ((RootCodeItem)P_0).SourceCode;
	}

	internal static void x8mDm9hD6miRu5u7vPY6(object P_0)
	{
		((ScriptCompiler)P_0).ProcessResults();
	}

	internal static object KsEdethDHEoLBEaQETnb(object P_0)
	{
		return ((ScripModuleBinding)P_0).Module;
	}

	internal static void MdkOWChDAr9JHmjoMLeG(object P_0, object P_1)
	{
		((IScriptModule)P_0).CompiledFileName = (string)P_1;
	}

	internal static object yMq82vhD7x3sswpgrWkx(object P_0)
	{
		return ((ScripModuleBinding)P_0).CodeItem;
	}

	internal static void F20aQJhDxDPhh40Cy7rg(object P_0, object P_1)
	{
		((RootCodeItem)P_0).CompiledFileName = (string)P_1;
	}

	internal static void xN1jPhhD0GIxk8HKogtP(object P_0, bool value)
	{
		((ScriptCompileResult)P_0).Success = value;
	}

	internal static void fns7rRhDmqLUGGTObpA7(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void Rl2EkohDytQ0xGmqDhio(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyRaw = (byte[])P_1;
	}

	internal static void lNu1OUhDMstVd4O71Vly(object P_0, object P_1)
	{
		((ScriptModule)P_0).DebugRaw = (byte[])P_1;
	}

	internal static Type yDmXOahDJKnGIUyrpnYK(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object oDNLkhhD9AK1oKCJKtCo(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}
}
