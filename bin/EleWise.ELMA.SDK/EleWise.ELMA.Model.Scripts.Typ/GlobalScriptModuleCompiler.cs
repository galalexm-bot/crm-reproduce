using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Types;

public class GlobalScriptModuleCompiler : ScriptCompiler
{
	private readonly IDictionary<string, ProjectItem> projectItems;

	private List<ScriptCompileMessage> messages;

	internal static GlobalScriptModuleCompiler cEDaXYbTzIt8f2Kp7YDX;

	internal new IGlobalModulesReferenceService GlobalModulesReferenceService => Locator.GetServiceNotNull<IGlobalModulesReferenceService>();

	public GlobalScriptModuleManager GlobalScriptModuleManager => Locator.GetServiceNotNull<GlobalScriptModuleManager>();

	public ProjectInfo GlobalScriptProject
	{
		[CompilerGenerated]
		get
		{
			return _003CGlobalScriptProject_003Ek__BackingField;
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
					_003CGlobalScriptProject_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
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

	public IGlobalScriptModule GlobalScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CGlobalScriptModule_003Ek__BackingField;
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
					_003CGlobalScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public GlobalScriptModuleCompiler(ScriptModule module, IGlobalScriptModule globalScriptModule)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		mHkWxvbkWPwb3AiCn8uB();
		projectItems = new Dictionary<string, ProjectItem>(StringComparer.InvariantCultureIgnoreCase);
		base._002Ector(module);
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				AddReferenceByName((string)jOWg8Mbko8K9m7gD74Hn(0x6A81B9B4 ^ 0x6A817332));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				GlobalScriptModule = globalScriptModule;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				return;
			case 5:
				GlobalScriptProject = P0mpvtbkh1ktapve61IK(globalScriptModule) as ProjectInfo;
				num = 2;
				break;
			case 4:
				dyvlaObkbVbFZZchUKRm(this, jOWg8Mbko8K9m7gD74Hn(-1939377524 ^ -1939375896));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				AddReferenceByName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643787817));
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	public override ScriptCompileResult Compile()
	{
		//Discarded unreachable code: IL_0178, IL_0188, IL_0197, IL_01a2, IL_025c, IL_0294, IL_02a3, IL_02b7, IL_02c6, IL_02d1, IL_037b, IL_03bb, IL_03c6, IL_04dc, IL_060b, IL_061a, IL_0625, IL_0672, IL_0681, IL_0724, IL_0737, IL_0746, IL_0756, IL_0765, IL_08a5, IL_08dd, IL_08ec
		int num = 2;
		int num2 = num;
		ScriptCompileResult result = default(ScriptCompileResult);
		bool lockTaken = default(bool);
		GlobalScriptModuleCompiler globalScriptModuleCompiler = default(GlobalScriptModuleCompiler);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current3 = default(string);
		IEnumerator<KeyValuePair<string, ProjectItem>> enumerator3 = default(IEnumerator<KeyValuePair<string, ProjectItem>>);
		KeyValuePair<string, ProjectItem> current2 = default(KeyValuePair<string, ProjectItem>);
		string directoryName = default(string);
		IList<IScriptModule> list2 = default(IList<IScriptModule>);
		List<AssemblyReference>.Enumerator enumerator = default(List<AssemblyReference>.Enumerator);
		string text = default(string);
		AssemblyReference current = default(AssemblyReference);
		IList<IScriptModule> source = default(IList<IScriptModule>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 1:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				globalScriptModuleCompiler = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(globalScriptModuleCompiler, ref lockTaken);
				int num3 = 5;
				while (true)
				{
					int num4;
					IList<IScriptModule> list;
					switch (num3)
					{
					case 25:
						return result;
					case 10:
						Jc3bmPbkVv1TwGHrOVy1(projectItems);
						num3 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num3 = 28;
						}
						break;
					case 15:
						iDdYvQbkXm131BdAGYM6(GlobalScriptModule);
						num3 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num3 = 23;
						}
						break;
					case 13:
						if (NvhRUVbkvufGjNSYUNxk(directoryInfo))
						{
							num3 = 22;
							break;
						}
						goto case 24;
					case 26:
						VjV5PZbkQuZNpgcxrVyg(this);
						num3 = 6;
						break;
					case 4:
						try
						{
							while (true)
							{
								IL_01fe:
								int num9;
								if (!L1gEaGbkEcgdG10WtDfR(enumerator2))
								{
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
									{
										num9 = 1;
									}
									goto IL_01a6;
								}
								goto IL_01c4;
								IL_01c4:
								current3 = enumerator2.Current;
								num9 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num9 = 4;
								}
								goto IL_01a6;
								IL_01a6:
								while (true)
								{
									switch (num9)
									{
									case 4:
										if (!dyvlaObkbVbFZZchUKRm(this, current3))
										{
											num9 = 2;
											continue;
										}
										goto IL_01fe;
									case 3:
										goto IL_01fe;
									case 2:
										XA15rRbkGMvfdo2o9KuF(this, current3);
										num9 = 3;
										continue;
									case 1:
										goto end_IL_01fe;
									}
									break;
								}
								goto IL_01c4;
								continue;
								end_IL_01fe:
								break;
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								int num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num10 = 1;
								}
								while (true)
								{
									switch (num10)
									{
									case 1:
										U9XACkbkfmWfY6SmAcOL(enumerator2);
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
										{
											num10 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 26;
					case 18:
						try
						{
							while (true)
							{
								int num7;
								if (!enumerator3.MoveNext())
								{
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num7 = 1;
									}
									goto IL_02d5;
								}
								goto IL_0332;
								IL_0332:
								current2 = enumerator3.Current;
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num7 = 0;
								}
								goto IL_02d5;
								IL_02d5:
								while (true)
								{
									switch (num7)
									{
									default:
										current2.Value.CompiledFileName = current2.Key;
										num7 = 2;
										continue;
									case 2:
										break;
									case 3:
										goto IL_0332;
									case 1:
										goto end_IL_030c;
									}
									break;
								}
								continue;
								end_IL_030c:
								break;
							}
						}
						finally
						{
							int num8;
							if (enumerator3 == null)
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num8 = 0;
								}
								goto IL_037f;
							}
							goto IL_0395;
							IL_0395:
							enumerator3.Dispose();
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num8 = 1;
							}
							goto IL_037f;
							IL_037f:
							switch (num8)
							{
							default:
								goto end_IL_035a;
							case 2:
								break;
							case 0:
								goto end_IL_035a;
							case 1:
								goto end_IL_035a;
							}
							goto IL_0395;
							end_IL_035a:;
						}
						goto case 20;
					case 3:
						IOi8v6bkKeoBbWiAH0bH((ProjectInfo)P0mpvtbkh1ktapve61IK(GlobalScriptModule), directoryName);
						num3 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num3 = 15;
						}
						break;
					case 12:
						AddSources(GlobalScriptProject.Items, directoryName);
						num3 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num3 = 29;
						}
						break;
					case 1:
						base.AssemblyName = (string)PjtwMTbkSFvsZTb8KbG2(base.Modules[0]);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num3 = 7;
						}
						break;
					case 29:
						AddSourceCode((string)jOWg8Mbko8K9m7gD74Hn(0x53CACA3 ^ 0x53E6925));
						num4 = 21;
						goto IL_007d;
					case 7:
					case 11:
						directoryName = Path.GetDirectoryName(GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289727430), string.Empty));
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num3 = 0;
						}
						break;
					case 5:
						if (base.MainModule == null)
						{
							num3 = 17;
							break;
						}
						goto default;
					case 16:
						list = list2;
						goto IL_07e7;
					case 28:
						if (!th4l1Cbkiog4AVfv63Be(PjtwMTbkSFvsZTb8KbG2(base.Modules[0])))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num3 = 11;
							}
							break;
						}
						goto case 8;
					default:
						list2 = new List<IScriptModule> { base.MainModule };
						num3 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num3 = 16;
						}
						break;
					case 20:
					{
						ScriptCompileResult scriptCompileResult = new ScriptCompileResult();
						ueZXKfbkk1Xjkc2lkTyC(scriptCompileResult, base.AssemblyRaw != null);
						scriptCompileResult.Messages = messages;
						result = scriptCompileResult;
						num3 = 25;
						break;
					}
					case 21:
						Build();
						num3 = 14;
						break;
					case 14:
						WYuHEjbkTAsddP7rHpUv(this);
						num3 = 27;
						break;
					case 27:
						enumerator3 = projectItems.GetEnumerator();
						num3 = 18;
						break;
					case 6:
						directoryInfo = new DirectoryInfo((string)ACoSGdbkCmLFE2s4SRBY());
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num3 = 13;
						}
						break;
					case 24:
						MtOg1dbk8CofwNejcEaa(directoryInfo);
						num3 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num3 = 4;
						}
						break;
					case 23:
						messages = new List<ScriptCompileMessage>();
						num3 = 12;
						break;
					case 9:
						try
						{
							while (true)
							{
								IL_06c0:
								int num5;
								if (!enumerator.MoveNext())
								{
									num5 = 6;
									goto IL_0629;
								}
								goto IL_06ad;
								IL_0629:
								while (true)
								{
									switch (num5)
									{
									case 3:
										text = (string)HktK7PbkuVOTq9jsOrXx(GlobalModulesReferenceService, IA2pNlbkZxJXsMUv7NMi(current));
										num5 = 5;
										continue;
									case 5:
										if (text == null)
										{
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
											{
												num5 = 4;
											}
											continue;
										}
										goto default;
									case 1:
										break;
									case 2:
									case 4:
										goto IL_06c0;
									default:
										pHWHoIbkI9ywxw1R5jah(this, text);
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
										{
											num5 = 0;
										}
										continue;
									case 6:
										goto end_IL_06c0;
									}
									break;
								}
								goto IL_06ad;
								IL_06ad:
								current = enumerator.Current;
								num5 = 3;
								goto IL_0629;
								continue;
								end_IL_06c0:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
						goto case 10;
					case 8:
						Jjv7RAbkqEfUyE3HQdC1(base.Modules[0], xHTnRJbkRwoFCmx80ttm(jOWg8Mbko8K9m7gD74Hn(0x63ABA4E8 ^ 0x63A961B4), base.Modules[0].Uid.ToString((string)jOWg8Mbko8K9m7gD74Hn(0x17ADCCD8 ^ 0x17AD3690))));
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num3 = 1;
						}
						break;
					case 17:
						list = base.Modules;
						goto IL_07e7;
					case 2:
						enumerator2 = source.SelectMany((IScriptModule m) => (m.References == null) ? new List<string>() : (from s in m.References.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D8052).ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
							select (string)_003C_003Ec.s7IXUIC3Sj0eWncn0q03(s)).ToList()).Distinct().GetEnumerator();
						num4 = 4;
						goto IL_007d;
					case 19:
					case 22:
						{
							enumerator = source.SelectMany((IScriptModule a) => a.GlobalScriptModules).ToList().GetEnumerator();
							num3 = 9;
							break;
						}
						IL_07e7:
						source = list;
						num3 = 2;
						break;
						IL_007d:
						num3 = num4;
						break;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					int num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							WUCxwwbknWUgb36yg9Py(globalScriptModuleCompiler);
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num11 = 1;
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

	public void DeleteDirectory(string targetDir)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba, IL_017f, IL_01b0, IL_01c0, IL_01cf
		int num = 16;
		int num3 = default(int);
		string targetDir2 = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num3++;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					DeleteDirectory(targetDir2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					File.SetAttributes(targetDir, FileAttributes.Normal);
					num2 = 15;
					continue;
				case 10:
				case 14:
					break;
				case 7:
					FTUbLCbkP8dDJYmEGUyW(targetDir, false);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					num3 = 0;
					num2 = 12;
					continue;
				case 3:
					array = array2;
					num2 = 9;
					continue;
				case 15:
				{
					string[] files = Directory.GetFiles(targetDir);
					array2 = (string[])bALlkfbkOS6fWrHXUDrY(targetDir);
					array = files;
					num2 = 17;
					continue;
				}
				case 2:
				case 4:
					if (num3 < array.Length)
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				case 1:
				case 12:
					if (num3 < array.Length)
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 9:
					num3 = 0;
					num2 = 2;
					continue;
				case 5:
					return;
				case 6:
				case 13:
				{
					string obj = array[num3];
					UA6KbJbk2hFpnXQBLOG4(obj, FileAttributes.Normal);
					YMxYJibkeqInpx4W45vp(obj);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				}
				break;
			}
			targetDir2 = array[num3];
			num = 11;
		}
	}

	protected override void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
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
				case 2:
					if (_003C_003Ec.LYnaRaC3iqdu0sNWYf2v(x) != DiagnosticSeverity.Error)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 1;
						}
						break;
					}
					goto default;
				case 1:
					if (_003C_003Ec.LYnaRaC3iqdu0sNWYf2v(x) != DiagnosticSeverity.Warning)
					{
						return false;
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num4 = 0;
					}
					break;
				default:
					return x.Id != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97731444);
				}
			}
		}).Select(delegate(Diagnostic err, int i)
		{
			//Discarded unreachable code: IL_0046, IL_0055
			int num = 5;
			int num2 = num;
			ProjectItem value = default(ProjectItem);
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 4:
					value = null;
					num2 = 3;
					break;
				case 5:
					if (!_003C_003Ec__DisplayClass15_0.MAmXO1C3TXHG4yRsNDye(ScriptCompiler.ScriptCompilerLogger))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto default;
				case 3:
					CS_0024_003C_003E8__locals0._003C_003E4__this.projectItems.TryGetValue((string)_003C_003Ec__DisplayClass15_0.rtMkMhC3OfiO0apK7sms(_003C_003Ec__DisplayClass15_0.ULXNC9C3nYlwnHknUXI7(err)), out value);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 2;
					}
					break;
				default:
					_003C_003Ec__DisplayClass15_0.pUtaXnC3kF02IIbhWkZd(CS_0024_003C_003E8__locals0.errorMessages.AppendLine(), err);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
				{
					ScriptCompileMessage scriptCompileMessage = new ScriptCompileMessage();
					_003C_003Ec__DisplayClass15_0.LPeBA3C32e4EI6GdC53o(scriptCompileMessage, i + 1);
					_003C_003Ec__DisplayClass15_0.JVjgsqC3PIRCUJ7HcoVW(scriptCompileMessage, (_003C_003Ec__DisplayClass15_0.sRJgluC3etbDMivbPjKT(err) == DiagnosticSeverity.Warning) ? ScriptCompileMessageType.Warning : ScriptCompileMessageType.Error);
					_003C_003Ec__DisplayClass15_0.n6f93kC31q7efpYdMWY3(scriptCompileMessage, err.Message);
					scriptCompileMessage.Line = ((Location)_003C_003Ec__DisplayClass15_0.ULXNC9C3nYlwnHknUXI7(err)).Line;
					_003C_003Ec__DisplayClass15_0.OZqlodC33rGYBUJT4HGw(scriptCompileMessage, _003C_003Ec__DisplayClass15_0.VwhXKBC3NcqenQrY4RXd(err.Location));
					scriptCompileMessage.ModuleUid = ((value != null) ? _003C_003Ec__DisplayClass15_0.bVnM1CC3pGjnDYECXl5n(value) : Guid.Empty);
					return scriptCompileMessage;
				}
				}
			}
		}));
		if (ScriptCompiler.ScriptCompilerLogger.IsErrorEnabled())
		{
			CS_0024_003C_003E8__locals0.errorMessages.AppendLine().Append(new StackTrace(3, fNeedFileInfo: true).ToString().TrimEnd());
			ScriptCompiler.ScriptCompilerLogger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87453065), CS_0024_003C_003E8__locals0.errorMessages));
		}
	}

	private void AddSources(IEnumerable<ProjectItem> items, string folderName)
	{
		foreach (ProjectItem item in items)
		{
			if (item.GetType() == typeof(ProjectItem))
			{
				string text = Path.Combine(folderName, item.FileName);
				projectItems[text] = item;
				AddSourceCodeWithName(item.Code, text);
			}
			else if (item is ProjectFolderItem projectFolderItem)
			{
				AddSources(projectFolderItem.Items, Path.Combine(folderName, projectFolderItem.Name));
			}
		}
	}

	internal static void mHkWxvbkWPwb3AiCn8uB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object jOWg8Mbko8K9m7gD74Hn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool dyvlaObkbVbFZZchUKRm(object P_0, object P_1)
	{
		return ((AssemblyBuilder)P_0).AddReferenceByName((string)P_1);
	}

	internal static object P0mpvtbkh1ktapve61IK(object P_0)
	{
		return ((IGlobalScriptModule)P_0).Items;
	}

	internal static bool zGm5JcbkFg1EpVK7tRfb()
	{
		return cEDaXYbTzIt8f2Kp7YDX == null;
	}

	internal static GlobalScriptModuleCompiler neixPfbkB4J60qZqpkfj()
	{
		return cEDaXYbTzIt8f2Kp7YDX;
	}

	internal static void XA15rRbkGMvfdo2o9KuF(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddGlobalReference((string)P_1);
	}

	internal static bool L1gEaGbkEcgdG10WtDfR(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void U9XACkbkfmWfY6SmAcOL(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void VjV5PZbkQuZNpgcxrVyg(object P_0)
	{
		((AssemblyBuilder)P_0).AddAllElmaReferences();
	}

	internal static object ACoSGdbkCmLFE2s4SRBY()
	{
		return AssemblyReferenceHelper.ExternalAssemblyLocation;
	}

	internal static bool NvhRUVbkvufGjNSYUNxk(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static void MtOg1dbk8CofwNejcEaa(object P_0)
	{
		((DirectoryInfo)P_0).Create();
	}

	internal static Guid IA2pNlbkZxJXsMUv7NMi(object P_0)
	{
		return ((AssemblyReference)P_0).Uid;
	}

	internal static object HktK7PbkuVOTq9jsOrXx(object P_0, Guid globalModuleHeaderUid)
	{
		return ((IGlobalModulesReferenceService)P_0).CreateGlobalModuleAssembly(globalModuleHeaderUid);
	}

	internal static void pHWHoIbkI9ywxw1R5jah(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((string)P_1);
	}

	internal static void Jc3bmPbkVv1TwGHrOVy1(object P_0)
	{
		((ICollection<KeyValuePair<string, ProjectItem>>)P_0).Clear();
	}

	internal static object PjtwMTbkSFvsZTb8KbG2(object P_0)
	{
		return ((IScriptModule)P_0).AssemblyName;
	}

	internal static bool th4l1Cbkiog4AVfv63Be(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object xHTnRJbkRwoFCmx80ttm(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void Jjv7RAbkqEfUyE3HQdC1(object P_0, object P_1)
	{
		((IScriptModule)P_0).AssemblyName = (string)P_1;
	}

	internal static void IOi8v6bkKeoBbWiAH0bH(object P_0, object P_1)
	{
		((ProjectInfo)P_0).CompiledFolderPath = (string)P_1;
	}

	internal static void iDdYvQbkXm131BdAGYM6(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void WYuHEjbkTAsddP7rHpUv(object P_0)
	{
		((ScriptCompiler)P_0).ProcessResults();
	}

	internal static void ueZXKfbkk1Xjkc2lkTyC(object P_0, bool value)
	{
		((ScriptCompileResult)P_0).Success = value;
	}

	internal static void WUCxwwbknWUgb36yg9Py(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object bALlkfbkOS6fWrHXUDrY(object P_0)
	{
		return Directory.GetDirectories((string)P_0);
	}

	internal static void UA6KbJbk2hFpnXQBLOG4(object P_0, FileAttributes P_1)
	{
		File.SetAttributes((string)P_0, P_1);
	}

	internal static void YMxYJibkeqInpx4W45vp(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void FTUbLCbkP8dDJYmEGUyW(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}
}
