using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component(Order = 20)]
internal class ComponentMetadataImportExtension : ComponentMetadataImportExtension<ComponentMetadata>
{
	[Component(Order = 2400)]
	private sealed class ComponentConfigImportExtension : ConfigImportExtension
	{
		private readonly object componentMetadataItemHeaderManager;

		private readonly object componentMetadataItemManager;

		private readonly object securityService;

		private readonly object actorContextService;

		private readonly object featureFlagService;

		private static object AyrMjE86xk1k3nvSQXTH;

		private ICollection<DeployLogMessage> DeployLogMessages
		{
			get
			{
				if (!((IActorContextService)actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138827326), out object value))
				{
					((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E685C31), value = new List<DeployLogMessage>());
				}
				return (ICollection<DeployLogMessage>)value;
			}
		}

		private bool SecondRuntimeEnabled => ((IFeatureFlagService)featureFlagService).Enabled((string)UsFXtm86jM3ftqbQteMs(0x3630F361 ^ 0x36305D6B), defaultEnabled: false);

		public ComponentConfigImportExtension(IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IComponentMetadataItemManager componentMetadataItemManager, ISecurityService securityService, IActorContextService actorContextService, IFeatureFlagService featureFlagService)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			eoyFLj86yEPqc3abyOoS();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 5:
					this.featureFlagService = featureFlagService;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num = 1;
					}
					break;
				default:
					this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
					num = 4;
					break;
				case 4:
					this.componentMetadataItemManager = componentMetadataItemManager;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				case 3:
					this.actorContextService = actorContextService;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num = 5;
					}
					break;
				case 2:
					this.securityService = securityService;
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num = 3;
					}
					break;
				}
			}
		}

		public override void OnPostReadPackets(PostReadPacketsParameters parameters)
		{
			//Discarded unreachable code: IL_0092, IL_00a1, IL_012c, IL_0164, IL_02fc, IL_030b, IL_0316, IL_03a5, IL_03b4, IL_03e1, IL_03f0
			int num = 1;
			ICollection<Guid> importHeaders = default(ICollection<Guid>);
			IEnumerator<ComponentMetadataItemHeader> enumerator = default(IEnumerator<ComponentMetadataItemHeader>);
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
			Guid[] array = default(Guid[]);
			List<KeyValuePair<string, string>> list = default(List<KeyValuePair<string, string>>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (LxT2Ra8696RqBB4eafxM(importHeaders) > 0)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 6;
					case 15:
						return;
					case 14:
						try
						{
							while (true)
							{
								int num6;
								if (!oAI85h86r72dQZAVG0ae(enumerator))
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
									{
										num6 = 0;
									}
									goto IL_00b0;
								}
								goto IL_00ec;
								IL_00ec:
								Wpnhd186lZTHcULEVpnB(enumerator.Current);
								int num7 = 2;
								num6 = num7;
								goto IL_00b0;
								IL_00b0:
								switch (num6)
								{
								case 2:
									continue;
								case 1:
									goto IL_00ec;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
								{
									num8 = 1;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										V3no4Y86gNkANfyT5FfG(enumerator);
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
										{
											num8 = 0;
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
					case 8:
						if (Xtb1VI86MQW9jP4fTS69(_003C_003Ec__DisplayClass6_.parameters) == 1)
						{
							num2 = 4;
							continue;
						}
						goto case 6;
					case 4:
						if (nlP3ko86J9xUrTBgRqkP(_003C_003Ec__DisplayClass6_.parameters.HeaderIds) != 0)
						{
							num2 = 17;
							continue;
						}
						goto case 5;
					case 1:
						_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						continue;
					case 13:
						enumerator = Publish(importHeaders, _003C_003Ec__DisplayClass6_.parameters.Messages, (string)dL6M0U86deB2cK1rbXFw(_003C_003Ec__DisplayClass6_.parameters)).GetEnumerator();
						num2 = 14;
						continue;
					default:
						_003C_003Ec__DisplayClass6_.parameters = parameters;
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 4;
						}
						continue;
					case 12:
						if (array.Length == 0)
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 9;
						}
						continue;
					case 6:
					case 17:
						if (Xtb1VI86MQW9jP4fTS69(_003C_003Ec__DisplayClass6_.parameters) != 2)
						{
							return;
						}
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 10;
						}
						continue;
					case 10:
						break;
					case 9:
						enumerator = Publish(array, _003C_003Ec__DisplayClass6_.parameters.Messages, (string)dL6M0U86deB2cK1rbXFw(_003C_003Ec__DisplayClass6_.parameters)).GetEnumerator();
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						importHeaders = ComponentMetadataImportExtension<ComponentMetadata>.GetImportHeaders((IActorContextService)actorContextService);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						try
						{
							while (true)
							{
								int num3;
								if (!oAI85h86r72dQZAVG0ae(enumerator))
								{
									num3 = 2;
									goto IL_031a;
								}
								goto IL_0330;
								IL_031a:
								switch (num3)
								{
								case 1:
									continue;
								case 2:
									goto end_IL_0356;
								}
								goto IL_0330;
								IL_0330:
								Wpnhd186lZTHcULEVpnB(enumerator.Current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num3 = 1;
								}
								goto IL_031a;
								continue;
								end_IL_0356:
								break;
							}
						}
						finally
						{
							int num5;
							if (enumerator == null)
							{
								int num4 = 2;
								num5 = num4;
								goto IL_038a;
							}
							goto IL_03bf;
							IL_038a:
							switch (num5)
							{
							default:
								goto end_IL_0371;
							case 2:
								goto end_IL_0371;
							case 1:
								break;
							case 0:
								goto end_IL_0371;
							}
							goto IL_03bf;
							IL_03bf:
							enumerator.Dispose();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
							{
								num5 = 0;
							}
							goto IL_038a;
							end_IL_0371:;
						}
						break;
					case 7:
						SetPromisedDependenciesKey(importHeaders);
						num2 = 13;
						continue;
					case 16:
						list = _003C_003Ec__DisplayClass6_.parameters.ServiceData.Where((KeyValuePair<string, string> m) => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AAD779))).ToList();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 11;
						}
						continue;
					case 11:
						array = list.Select((KeyValuePair<string, string> record) => new Guid(record.Value)).ToArray();
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				}
				list.ForEach(_003C_003Ec__DisplayClass6_._003COnPostReadPackets_003Eb__2);
				num = 15;
			}
		}

		public override void OnPrePublish(PrePublishParameters parameters)
		{
			//Discarded unreachable code: IL_00a6, IL_00b5
			int num = 2;
			ICollection<Guid> importHeaders = default(ICollection<Guid>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						SetPromisedDependenciesKey(importHeaders);
						num2 = 4;
						continue;
					case 4:
						return;
					case 5:
						SetPromisedDependenciesKey(parameters.ServiceData);
						num2 = 3;
						continue;
					case 2:
						importHeaders = ComponentMetadataImportExtension<ComponentMetadata>.GetImportHeaders((IActorContextService)actorContextService);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						if (LxT2Ra8696RqBB4eafxM(importHeaders) <= 0)
						{
							break;
						}
						goto default;
					case 3:
						return;
					}
					break;
				}
				num = 5;
			}
		}

		public override void OnPostPublish(PostPublishParameters parameters)
		{
			//Discarded unreachable code: IL_005d, IL_006c
			int num = 4;
			int num2 = num;
			ICollection<DeployLogMessage> deployLogMessages = default(ICollection<DeployLogMessage>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (ybD8ta865h6cfMheQpo8(deployLogMessages) <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 0:
					return;
				case 1:
					return;
				case 4:
					deployLogMessages = DeployLogMessages;
					num2 = 3;
					continue;
				case 2:
					break;
				}
				parameters.Messages.AddRange(deployLogMessages);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
			}
		}

		public IEnumerable<ComponentMetadataItemHeader> Publish(IEnumerable<Guid> headerUids, ICollection<DeployLogMessage> messages = null, string treeUid = null)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.headerUids = headerUids;
			CS_0024_003C_003E8__locals0.messages = messages;
			CS_0024_003C_003E8__locals0.treeUid = treeUid;
			CS_0024_003C_003E8__locals0.messages = CS_0024_003C_003E8__locals0.messages ?? DeployLogMessages;
			CS_0024_003C_003E8__locals0.result = new List<ComponentMetadataItemHeader>();
			((ISecurityService)securityService).RunWithElevatedPrivilegies((Action)delegate
			{
				//Discarded unreachable code: IL_00ad, IL_0177, IL_0186, IL_0197, IL_01a6, IL_01b1, IL_02ae, IL_02bd, IL_0346, IL_045f, IL_048f, IL_04c7, IL_04d6
				int num = 1;
				int num2 = num;
				IEnumerable<ComponentMetadataItemHeader> enumerable = default(IEnumerable<ComponentMetadataItemHeader>);
				IEnumerator<ComponentMetadataItemHeader> enumerator = default(IEnumerator<ComponentMetadataItemHeader>);
				string text3 = default(string);
				ComponentMetadataItemHeader current = default(ComponentMetadataItemHeader);
				string text = default(string);
				string text2 = default(string);
				while (true)
				{
					switch (num2)
					{
					case 1:
						enumerable = Enumerable.Empty<ComponentMetadataItemHeader>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 4:
						enumerator = enumerable.GetEnumerator();
						num2 = 3;
						break;
					default:
						try
						{
							enumerable = ((IComponentMetadataItemHeaderManager)CS_0024_003C_003E8__locals0._003C_003E4__this.componentMetadataItemHeaderManager).SortByDependencies((IEnumerable<ComponentMetadataItemHeader>)((IComponentMetadataItemHeaderManager)CS_0024_003C_003E8__locals0._003C_003E4__this.componentMetadataItemHeaderManager).FindByIdArray(CS_0024_003C_003E8__locals0.headerUids.ToArray()));
							int num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num8 = 0;
							}
							switch (num8)
							{
							case 0:
								break;
							}
						}
						catch (Exception ex2)
						{
							int num9 = 2;
							int num10 = num9;
							while (true)
							{
								switch (num10)
								{
								case 2:
									text3 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x1039DD5B), ex2);
									num10 = 3;
									continue;
								case 3:
									_003C_003Ec__DisplayClass9_0.vSaEcbZPENoeNOmC8CvO(ImportLog, text3);
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
									{
										num10 = 0;
									}
									continue;
								default:
									CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text3, endProcess: false));
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num10 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						goto case 4;
					case 3:
						try
						{
							while (true)
							{
								int num3;
								if (!_003C_003Ec__DisplayClass9_0.Q604pDZPuwRZPgyEMCDp(enumerator))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
									{
										num3 = 0;
									}
									goto IL_01b5;
								}
								goto IL_01cf;
								IL_01cf:
								current = enumerator.Current;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num3 = 3;
								}
								goto IL_01b5;
								IL_01b5:
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									break;
								case 2:
									continue;
								case 3:
									try
									{
										int num4;
										if (!CS_0024_003C_003E8__locals0._003C_003E4__this.Publish(current, CS_0024_003C_003E8__locals0.messages))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
											{
												num4 = 0;
											}
											goto IL_024f;
										}
										goto IL_030e;
										IL_030e:
										CS_0024_003C_003E8__locals0.result.Add(current);
										num4 = 4;
										goto IL_024f;
										IL_024f:
										while (true)
										{
											switch (num4)
											{
											default:
												goto end_IL_024f;
											case 1:
												_003C_003Ec__DisplayClass9_0.Wxu4ATZPQpsXOh3ElYI1(ImportLog, text);
												num4 = 5;
												continue;
											case 5:
											{
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Info, text, endProcess: false));
												int num5 = 3;
												num4 = num5;
												continue;
											}
											case 0:
												goto end_IL_024f;
											case 4:
												text = SR.T((string)_003C_003Ec__DisplayClass9_0.jCrmvAZPfEagS2vmD3oY(-1876063057 ^ -1876183037), current.Uid);
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
												{
													num4 = 1;
												}
												continue;
											case 2:
												break;
											case 3:
												goto end_IL_024f;
											}
											goto IL_030e;
											continue;
											end_IL_024f:
											break;
										}
									}
									catch (Exception ex)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											case 2:
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text2, endProcess: false));
												num6 = 4;
												continue;
											case 4:
												_003C_003Ec__DisplayClass9_0.khBloLZP85gAIxtYhqb7(ImportLog, text2, ex);
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
												{
													num6 = 1;
												}
												continue;
											default:
												text2 = SR.T((string)_003C_003Ec__DisplayClass9_0.jCrmvAZPfEagS2vmD3oY(-561074844 ^ -561473468), _003C_003Ec__DisplayClass9_0.gTsEXeZPCHI2tpo5Aehs(current), _003C_003Ec__DisplayClass9_0.bm548lZPvnyuCrMjM9E4(ex));
												num6 = 2;
												continue;
											case 3:
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, _003C_003Ec__DisplayClass9_0.gTsEXeZPCHI2tpo5Aehs(current), CS_0024_003C_003E8__locals0.treeUid));
												num6 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
												{
													num6 = 0;
												}
												continue;
											case 1:
												if (!_003C_003Ec__DisplayClass9_0.AM9IAVZPZkdJMBuxJJwi(CS_0024_003C_003E8__locals0.treeUid))
												{
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
													{
														num6 = 3;
													}
													continue;
												}
												break;
											case 5:
												break;
											}
											break;
										}
									}
									continue;
								}
								goto IL_01cf;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										_003C_003Ec__DisplayClass9_0.DlhO2YZPIyapH5rsNnw5(enumerator);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
										{
											num7 = 1;
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
			});
			return CS_0024_003C_003E8__locals0.result;
		}

		private bool Publish(ComponentMetadataItemHeader header, ICollection<DeployLogMessage> messages)
		{
			if (!(header.Draft?.Metadata is ComponentMetadata))
			{
				string text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x63782CD7), header.DisplayName);
				ImportLog.Error(text);
				messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, endProcess: false));
				return false;
			}
			UIMetadataPublishResult uIMetadataPublishResult = ((IComponentMetadataItemManager)componentMetadataItemManager).Publish(header.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE142C01), forEmulation: false);
			if (uIMetadataPublishResult.Errors.Count != 0)
			{
				string text2 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4A7EC3), header.DisplayName);
				ImportLog.Error(text2);
				messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text2, endProcess: false));
				string message = ValidationErrorHelper.GetMessage(uIMetadataPublishResult.Errors.ToArray());
				ImportLog.Error(message);
				messages.Add(new DeployLogMessage(DeployLogMessageType.Error, message, endProcess: false));
				return false;
			}
			return true;
		}

		public override void OnPreStartTest(PreStartTestImportParameters parameters)
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
					SetPromisedDependenciesKey(parameters.ServiceData);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		private void SetPromisedDependenciesKey(IDictionary<string, string> serviceData)
		{
			Guid result;
			IEnumerable<Guid> promisedDependenciesKey = from p in serviceData.Where((KeyValuePair<string, string> m) => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629972698))).ToList()
				select (!Guid.TryParse(p.Value, out result)) ? Guid.Empty : result into u
				where _003C_003Ec.jSW6p7ZPW6laZ080Elwi(u, Guid.Empty)
				select u;
			if (SetPromisedDependenciesKey(promisedDependenciesKey) && SecondRuntimeEnabled)
			{
				((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978504650), (object)string.Empty);
				serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3674D)] = string.Empty;
			}
		}

		private bool SetPromisedDependenciesKey(IEnumerable<Guid> importHeaders)
		{
			bool result = false;
			foreach (Guid importHeader in importHeaders)
			{
				string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146528047), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420805392), importHeader);
				((IActorContextService)actorContextService).Set(key, (object)importHeader);
				result = true;
			}
			return result;
		}

		internal static void eoyFLj86yEPqc3abyOoS()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool t3Sv17860PslyNV7FBZH()
		{
			return AyrMjE86xk1k3nvSQXTH == null;
		}

		internal static ComponentConfigImportExtension Iqu8Dq86md8Aj6G2xfeQ()
		{
			return (ComponentConfigImportExtension)AyrMjE86xk1k3nvSQXTH;
		}

		internal static int Xtb1VI86MQW9jP4fTS69(object P_0)
		{
			return ((ImportExtensionParameters)P_0).ImportStep;
		}

		internal static int nlP3ko86J9xUrTBgRqkP(object P_0)
		{
			return ((List<long>)P_0).Count;
		}

		internal static int LxT2Ra8696RqBB4eafxM(object P_0)
		{
			return ((ICollection<Guid>)P_0).Count;
		}

		internal static object dL6M0U86deB2cK1rbXFw(object P_0)
		{
			return ((ImportExtensionParameters)P_0).TreeUid;
		}

		internal static void Wpnhd186lZTHcULEVpnB(object P_0)
		{
			((Entity<long>)P_0).Refresh();
		}

		internal static bool oAI85h86r72dQZAVG0ae(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void V3no4Y86gNkANfyT5FfG(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static int ybD8ta865h6cfMheQpo8(object P_0)
		{
			return ((ICollection<DeployLogMessage>)P_0).Count;
		}

		internal static object UsFXtm86jM3ftqbQteMs(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	[Component(Order = -70)]
	private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
	{
		private readonly object actorContextService;

		private readonly ILazy<ComponentConfigImportExtension> componentConfigImportExtension;

		public ModelAssemblyBuilderHandler(IActorContextService actorContextService, ILazy<ComponentConfigImportExtension> componentConfigImportExtension)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.actorContextService = actorContextService;
			this.componentConfigImportExtension = componentConfigImportExtension;
		}

		public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
		{
			ICollection<Guid> importHeaders = ComponentMetadataImportExtension<ComponentMetadata>.GetImportHeaders((IActorContextService)actorContextService);
			if (importHeaders.Count > 0)
			{
				componentConfigImportExtension.Value.Publish(importHeaders);
			}
		}

		public void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata)
		{
		}

		public void AfterAll(IEnumerable<AbstractMetadata> publishMetadataList, IEnumerable<ScriptModule> scriptModules, IEnumerable<ScriptModule> clientScriptModules)
		{
		}
	}

	[Component]
	internal class ComponentMetadataImport : MetadataImport
	{
		private static ComponentMetadataImport tRC0rs86s2tsaQXw1YZm;

		public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
		{
			//Discarded unreachable code: IL_00ac
			int num = 2;
			int num2 = num;
			ComponentMetadata componentMetadata = default(ComponentMetadata);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					fakeManifest.GetOrCreateChapterByUid(ComponentExportConsts.ExportExtensionUid).GetOrCreateItemByUid(IKDtjK8HF0W7PwslxLB5(componentMetadata), componentMetadata.DisplayName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 3:
					return;
				case 1:
					if ((componentMetadata = namedMd as ComponentMetadata) == null)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				case 2:
					if (fakeManifest == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public ComponentMetadataImport()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			pChiWY8HBIqI9VUJtWGg();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Guid IKDtjK8HF0W7PwslxLB5(object P_0)
		{
			return ((AbstractMetadata)P_0).Uid;
		}

		internal static bool YxrKNM86crY4VygIAVMa()
		{
			return tRC0rs86s2tsaQXw1YZm == null;
		}

		internal static ComponentMetadataImport sJLbQD86zaHweU3QMax2()
		{
			return tRC0rs86s2tsaQXw1YZm;
		}

		internal static void pChiWY8HBIqI9VUJtWGg()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly ILogger ImportLog;

	private static ComponentMetadataImportExtension jEwQAQE9UG3TqO5cFvH6;

	public ComponentMetadataImportExtension(IComponentMetadataItemManager componentMetadataItemManager, IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IMetadataItemGroupUIManager metadataItemGroupUIManager, DataClassMetadataImportExtension dataClassMetadataImportExtension, IActorContextService actorContextService, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_0033, IL_0038
		nO0T01E9zkKuesjybqhJ();
		base._002Ector(componentMetadataItemManager, componentMetadataItemHeaderManager, metadataItemGroupUIManager, dataClassMetadataImportExtension, actorContextService, featureFlagService);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ComponentMetadataImportExtension()
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
				ImportLog = (ILogger)MhKR8QEdFlvYYShdwRyR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AF2736));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				nO0T01E9zkKuesjybqhJ();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void nO0T01E9zkKuesjybqhJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nBUrBdE9sLBVNeQFQuW6()
	{
		return jEwQAQE9UG3TqO5cFvH6 == null;
	}

	internal static ComponentMetadataImportExtension VZc1D7E9cvn9tZBTD7A1()
	{
		return jEwQAQE9UG3TqO5cFvH6;
	}

	internal static object MhKR8QEdFlvYYShdwRyR(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
internal abstract class ComponentMetadataImportExtension<T> : NamedMetadataImportExtension<T> where T : ComponentMetadata
{
	private static readonly ILogger ImportLog;

	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	private readonly IMetadataItemGroupUIManager metadataItemGroupUIManager;

	private readonly DataClassMetadataImportExtension dataClassMetadataImportExtension;

	private readonly IActorContextService actorContextService;

	private readonly IFeatureFlagService featureFlagService;

	private static object wUGbMBEdBynYJvQIJnNF;

	private bool SecondRuntimeEnabled => featureFlagService.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210747959), defaultEnabled: false);

	public ComponentMetadataImportExtension(IComponentMetadataItemManager componentMetadataItemManager, IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IMetadataItemGroupUIManager metadataItemGroupUIManager, DataClassMetadataImportExtension dataClassMetadataImportExtension, IActorContextService actorContextService, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				this.featureFlagService = featureFlagService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 4:
				this.componentMetadataItemManager = componentMetadataItemManager;
				num = 6;
				break;
			default:
				this.metadataItemGroupUIManager = metadataItemGroupUIManager;
				num = 2;
				break;
			case 2:
				this.dataClassMetadataImportExtension = dataClassMetadataImportExtension;
				num = 3;
				break;
			case 3:
				this.actorContextService = actorContextService;
				num = 5;
				break;
			}
		}
	}

	protected override bool TestMetadata(T mdMerged, ReadMetadataParameters parameters, bool isTestRead)
	{
		if (!SecondRuntimeEnabled)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576189956), mdMerged.DisplayName)));
			return false;
		}
		return base.TestMetadata(mdMerged, parameters, isTestRead);
	}

	protected override bool CheckMetadata(T mdImported, T mdDraft, ReadMetadataParameters parameters)
	{
		if (!SecondRuntimeEnabled)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487344066), mdImported.DisplayName)));
			return false;
		}
		return base.CheckMetadata(mdImported, mdDraft, parameters);
	}

	protected override void CheckNewMetadata(T mdImported, bool isTestRead, ReadMetadataParameters parameters)
	{
		base.CheckNewMetadata(mdImported, isTestRead, parameters);
		foreach (DataClassMetadata dataClass in mdImported.DataClasses)
		{
			dataClassMetadataImportExtension.CheckNewMetadata(dataClass, parameters, isTestRead);
		}
	}

	protected override void MergeMetadata(T mdImported, T mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
		List<DataClassMetadata> list = mdDraft.DataClasses.ToList();
		using (List<DataClassMetadata>.Enumerator enumerator = mdImported.DataClasses.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
				CS_0024_003C_003E8__locals0.dataClassImported = enumerator.Current;
				DataClassMetadata dataClassMetadata;
				try
				{
					dataClassMetadata = list.SingleOrDefault((DataClassMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.dataClassImported.Uid);
				}
				catch (InvalidOperationException)
				{
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A2BCF9), mdDraft.Name, CS_0024_003C_003E8__locals0.dataClassImported.Uid)));
					continue;
				}
				if (dataClassMetadata != null && CS_0024_003C_003E8__locals0.dataClassImported.Name != dataClassMetadata.Name)
				{
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69792627), mdDraft.Name, CS_0024_003C_003E8__locals0.dataClassImported.Uid, dataClassMetadata.Uid, mdDraft.DisplayName, CS_0024_003C_003E8__locals0.dataClassImported.DisplayName, dataClassMetadata.DisplayName, CS_0024_003C_003E8__locals0.dataClassImported.Name, dataClassMetadata.Name)));
				}
				if (dataClassMetadata == null)
				{
					try
					{
						dataClassMetadata = list.SingleOrDefault((DataClassMetadata dc) => dc.Name == CS_0024_003C_003E8__locals0.dataClassImported.Name);
					}
					catch (InvalidOperationException)
					{
						continue;
					}
					if (dataClassMetadata != null)
					{
						parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69792627), mdDraft.Name, CS_0024_003C_003E8__locals0.dataClassImported.Uid, dataClassMetadata.Uid, mdDraft.DisplayName, CS_0024_003C_003E8__locals0.dataClassImported.DisplayName, dataClassMetadata.DisplayName, CS_0024_003C_003E8__locals0.dataClassImported.Name, dataClassMetadata.Name)));
					}
				}
				if (dataClassMetadata != null)
				{
					dataClassMetadataImportExtension.MergeMetadata(CS_0024_003C_003E8__locals0.dataClassImported, dataClassMetadata, parameters, isTestRead);
					parameters.MergeReplace.SetUidReplaceMD(CS_0024_003C_003E8__locals0.dataClassImported.Uid, dataClassMetadata.Uid);
					CS_0024_003C_003E8__locals0.dataClassImported.Uid = dataClassMetadata.Uid;
					list.Remove(dataClassMetadata);
					list.Add(CS_0024_003C_003E8__locals0.dataClassImported);
				}
				else
				{
					dataClassMetadataImportExtension.CheckNewMetadata(CS_0024_003C_003E8__locals0.dataClassImported, parameters, isTestRead);
					list.Add(CS_0024_003C_003E8__locals0.dataClassImported);
				}
			}
		}
		mdDraft.DataClasses = list;
		if (isTestRead)
		{
			return;
		}
		mdDraft.Content = mdImported.Content;
		using (List<Implementation>.Enumerator enumerator2 = mdImported.Implementations.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass11_1();
				CS_0024_003C_003E8__locals1.implementation = enumerator2.Current;
				Implementation implementation = mdDraft.Implementations.FirstOrDefault(delegate(Implementation i)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							if (!(i.PointId == CS_0024_003C_003E8__locals1.implementation.PointId))
							{
								return false;
							}
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							return i.TypeUid == CS_0024_003C_003E8__locals1.implementation.TypeUid;
						}
					}
				});
				if (implementation == null)
				{
					mdDraft.Implementations.Add(CS_0024_003C_003E8__locals1.implementation);
				}
				else
				{
					implementation.InputPropertyUid = CS_0024_003C_003E8__locals1.implementation.InputPropertyUid;
				}
			}
		}
		using (List<ImplementationForm>.Enumerator enumerator3 = mdImported.ImplementationForms.GetEnumerator())
		{
			while (enumerator3.MoveNext())
			{
				_003C_003Ec__DisplayClass11_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass11_2();
				CS_0024_003C_003E8__locals2.implementationForm = enumerator3.Current;
				if (mdDraft.ImplementationForms.All(delegate(ImplementationForm f)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (!(f.ModuleUid != CS_0024_003C_003E8__locals2.implementationForm.ModuleUid))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num2 = 2;
								}
								break;
							}
							goto IL_0074;
						case 2:
							return f.ViewType != CS_0024_003C_003E8__locals2.implementationForm.ViewType;
						case 1:
							{
								if (!(f.MetadataUid != CS_0024_003C_003E8__locals2.implementationForm.MetadataUid))
								{
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
									{
										num2 = 0;
									}
									break;
								}
								goto IL_0074;
							}
							IL_0074:
							return true;
						}
					}
				}))
				{
					mdDraft.ImplementationForms.Add(CS_0024_003C_003E8__locals2.implementationForm);
				}
			}
		}
		mdDraft.UserDefinedListInfos = mdImported.UserDefinedListInfos;
	}

	protected override void SaveMetadata(T mdMerged, ReadMetadataParameters parameters)
	{
		ComponentMetadataItem componentMetadataItem = componentMetadataItemHeaderManager.LoadOrNull(mdMerged.Uid)?.Draft;
		if (componentMetadataItem == null)
		{
			componentMetadataItem = componentMetadataItemManager.Create(mdMerged.GetMetadataTypeUid(), mdMerged.ModuleUid, Guid.Empty, mdMerged.DisplayName);
			componentMetadataItem.Header.Name = mdMerged.Name;
			componentMetadataItem.Header.Description = mdMerged.Description;
			componentMetadataItem.Header.Uid = mdMerged.Uid;
			componentMetadataItem.ScriptModule.Delete();
			componentMetadataItem.ScriptModule = null;
			componentMetadataItem.ClientScriptModule.Delete();
			componentMetadataItem.ClientScriptModule = null;
		}
		componentMetadataItem.Metadata = mdMerged;
		ComponentMetadataItem metadataItem = componentMetadataItem;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ComponentMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6838F));
		SetScriptModule(metadataItem, Expression.Lambda<Func<ComponentMetadataItem, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), parameters);
		ComponentMetadataItem metadataItem2 = componentMetadataItem;
		parameterExpression = Expression.Parameter(typeof(ComponentMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108016242));
		SetScriptModule(metadataItem2, Expression.Lambda<Func<ComponentMetadataItem, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), parameters);
		string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538831742) + mdMerged.Uid;
		if (parameters.ServiceData.TryGetValue(key, out var value) && Guid.TryParse(value, out var result))
		{
			MetadataItemGroupUI metadataItemGroupUI = metadataItemGroupUIManager.LoadOrNull(result);
			if (metadataItemGroupUI != null)
			{
				componentMetadataItem.Header.Group = metadataItemGroupUI;
			}
		}
		Type type = (ImportLog.IsInfoEnabled() ? mdMerged.GetType() : null);
		ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751390432), type.Name, componentMetadataItem.Uid);
		componentMetadataItem.Save();
		ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477388592), type.Name, componentMetadataItem.Uid);
		parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561355588), mdMerged.Uid, mdMerged.DisplayName, mdMerged.Name), endProcess: false));
		GetImportHeaders(actorContextService).Add(componentMetadataItem.Header.Uid);
		EntityMetadataDependencyService.GetPromisedMetadataDependencies(actorContextService).Add(mdMerged);
	}

	protected static ICollection<Guid> GetImportHeaders(IActorContextService actorContextService)
	{
		if (!actorContextService.TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345145196), out var value))
		{
			actorContextService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868038372), value = new List<Guid>());
		}
		return (ICollection<Guid>)value;
	}

	static ComponentMetadataImportExtension()
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
				ImportLog = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E6F854));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool bvIObLEdWK5Sb6x7jHTk()
	{
		return wUGbMBEdBynYJvQIJnNF == null;
	}

	internal static object T14qUcEdoZYkZgssOjXL()
	{
		return wUGbMBEdBynYJvQIJnNF;
	}
}
