using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.Deploy.Actors;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

internal sealed class ContinuedImporter
{
	private static readonly ILogger ImportLog;

	private readonly ContinuedImportState state;

	private readonly IRunImportParameters runImportParameters;

	private readonly IBLOBStore blobStore;

	private readonly IExportImportFileService fileService;

	private readonly IDeployManager deployManager;

	private readonly IConfigurationImportInternalFactory configurationImportInternalFactory;

	private static ContinuedImporter uNIkL6E7PLH8bkGtu9vY;

	public ContinuedImporter(ContinuedImportState state, IRunImportParameters runImportParameters, IBLOBStore blobStore, IExportImportFileService fileService, IDeployManager deployManager, IConfigurationImportInternalFactory configurationImportInternalFactory)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		UdJiXtE73WmWEDH70K3T();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.state = state;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				this.configurationImportInternalFactory = configurationImportInternalFactory;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 2;
				}
				break;
			case 6:
				this.deployManager = deployManager;
				num = 5;
				break;
			case 1:
				this.blobStore = blobStore;
				num = 3;
				break;
			case 3:
				this.fileService = fileService;
				num = 6;
				break;
			case 4:
				return;
			default:
				this.runImportParameters = runImportParameters;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public bool ExecuteImport()
	{
		//Discarded unreachable code: IL_00e4, IL_010c, IL_011b, IL_0126, IL_0171, IL_0180, IL_029f, IL_03a3, IL_03b6, IL_03c5, IL_0458, IL_0581, IL_0590, IL_05de, IL_05ed, IL_05fc, IL_060d, IL_0617, IL_06d6, IL_06e9, IL_06f8
		int num = 2;
		int num2 = num;
		List<IConfigImportSettings>.Enumerator enumerator = default(List<IConfigImportSettings>.Enumerator);
		List<IConfigImportSettings> list = default(List<IConfigImportSettings>);
		bool result = default(bool);
		IConfigImportSettings current2 = default(IConfigImportSettings);
		string text = default(string);
		DeployLogMessage deployLogMessage = default(DeployLogMessage);
		IConfigImportSettings current = default(IConfigImportSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 3:
				enumerator = list.GetEnumerator();
				num2 = 5;
				break;
			case 6:
				blobStore.Remove(ImportExecutorActor.StateKey);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				iSmIGYE7D7jiMwL5tQwD(ImportLog, ro9qKGE7pAhq6BRlWS4q(-1939377524 ^ -1939610596));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					iSmIGYE7D7jiMwL5tQwD(ImportLog, FggFlaE7a86HowvMXqOj(ro9qKGE7pAhq6BRlWS4q(-542721635 ^ -543019883), list.Count));
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						case 1:
							try
							{
								while (true)
								{
									IL_0284:
									int num6;
									if (!enumerator.MoveNext())
									{
										num6 = 7;
										goto IL_012a;
									}
									goto IL_01a2;
									IL_012a:
									while (true)
									{
										switch (num6)
										{
										case 12:
											return result;
										case 9:
											if (RunImportStep0(current2))
											{
												num6 = 10;
												continue;
											}
											goto case 5;
										case 11:
											break;
										case 6:
											fileService.DeleteFiles((string)oJRPcXE7wFmeMpC8HoKa(current2));
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
											{
												num6 = 3;
											}
											continue;
										default:
											result = false;
											num6 = 8;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
											{
												num6 = 12;
											}
											continue;
										case 8:
											blobStore.Save(ImportExecutorActor.StateKey, (byte[])AKGiwkE767lu2fHEWUQv(state));
											num6 = 4;
											continue;
										case 4:
											ImportLog.Info(ro9qKGE7pAhq6BRlWS4q(-1487388570 ^ -1487088152));
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
											{
												num6 = 0;
											}
											continue;
										case 1:
											state.SettingsList.Remove(current2);
											num6 = 6;
											continue;
										case 2:
										case 3:
											goto IL_0284;
										case 5:
											B2ADibE74qt13qCaL7Kh(state.LogMessages);
											num6 = 13;
											continue;
										case 10:
											iSmIGYE7D7jiMwL5tQwD(ImportLog, (string)ro9qKGE7pAhq6BRlWS4q(-629844702 ^ -630079374) + ((ElmaStoreComponentManifest)aqs3spE7t0AEUEE7Xv3P(current2))?.Title);
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
											{
												num6 = 1;
											}
											continue;
										case 13:
											state.LogMessages.AddRange(runImportParameters.LogMessages.Where((DeployLogMessage m) => _003C_003Ec.qxGMa38DEvPIsnSulZW4(m) != null));
											num6 = 8;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
											{
												num6 = 8;
											}
											continue;
										case 7:
											goto end_IL_0284;
										}
										break;
									}
									goto IL_01a2;
									IL_01a2:
									current2 = enumerator.Current;
									num6 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
									{
										num6 = 9;
									}
									goto IL_012a;
									continue;
									end_IL_0284:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
							break;
						case 2:
							CheckInstallPackages();
							num5 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num5 = 0;
							}
							continue;
						case 4:
							enumerator = list.GetEnumerator();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num5 = 1;
							}
							continue;
						case 3:
							goto end_IL_00e8;
						}
						ImportLog.Info(ro9qKGE7pAhq6BRlWS4q(0x103FE975 ^ 0x103B7CA1));
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num5 = 3;
						}
						continue;
						end_IL_00e8:
						break;
					}
				}
				catch (Exception ex)
				{
					int num8 = 7;
					while (true)
					{
						switch (num8)
						{
						default:
							runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, endProcess: true));
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num8 = 3;
							}
							continue;
						case 8:
							if (jsuR9tE7738aUNw1jm35(deployLogMessage) != DeployLogMessageType.Error)
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num8 = 2;
								}
								continue;
							}
							break;
						case 6:
							if (deployLogMessage == null)
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
								{
									num8 = 0;
								}
								continue;
							}
							goto case 5;
						case 7:
							text = SR.T((string)ro9qKGE7pAhq6BRlWS4q(0x12A5FAC7 ^ 0x12A16CCD), DePMQGE7H6UWnyYUDXm3(ex));
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
							{
								num8 = 1;
							}
							continue;
						case 1:
							deployLogMessage = runImportParameters.LogMessages.LastOrDefault();
							num8 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num8 = 0;
							}
							continue;
						case 5:
							if (!fB9VHlE7AxiPBFuBfj3J(deployLogMessage))
							{
								num8 = 9;
								continue;
							}
							goto case 8;
						case 3:
							break;
						case 4:
							goto end_IL_045c;
						}
						f6rnB1E7xm2lpoUHKlIH(Logger.Log, text, ex);
						num8 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num8 = 4;
						}
						continue;
						end_IL_045c:
						break;
					}
				}
				goto case 3;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 1;
							}
							goto IL_061b;
						}
						goto IL_0687;
						IL_0687:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num3 = 0;
						}
						goto IL_061b;
						IL_061b:
						while (true)
						{
							switch (num3)
							{
							default:
								sYDc0nE700urQt96wENZ(fileService, oJRPcXE7wFmeMpC8HoKa(current));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num3 = 3;
								}
								continue;
							case 3:
								break;
							case 2:
								goto IL_0687;
							case 1:
								goto end_IL_0661;
							}
							break;
						}
						continue;
						end_IL_0661:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 2:
				list = state.SettingsList.ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void CheckInstallPackages()
	{
		//Discarded unreachable code: IL_0094, IL_00cf, IL_00de
		int num = 3;
		PackageInstallInfo installInfo = default(PackageInstallInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					InstallPackages(installInfo);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					break;
				case 4:
					return;
				case 2:
					return;
				case 7:
					return;
				case 9:
					installInfo = (PackageInstallInfo)CHlN92E7m9OkX9J0wQMy(state);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (!state.NeedToInstallPackages)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				default:
					xnONcsE7yt52Du05U7vK(state, null);
					num2 = 6;
					continue;
				case 1:
					state.NeedToInstallPackages = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (state.PackageInstallInfo == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 9;
				}
				break;
			}
			B40DGJE7MY06uIhcQNLN(blobStore, ImportExecutorActor.StateKey, AKGiwkE767lu2fHEWUQv(state));
			num = 8;
		}
	}

	private DeployLogMessage GetLastImportMessage()
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 4;
		DeployLogMessage deployLogMessage = default(DeployLogMessage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					throw new InvalidOperationException((string)pG9D3cE793U9PP96wt2u(deployLogMessage));
				case 3:
					if (deployLogMessage == null)
					{
						goto end_IL_0012;
					}
					if (deployLogMessage.EndProcess)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				default:
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234076090)));
				case 1:
					if (jsuR9tE7738aUNw1jm35(deployLogMessage) != DeployLogMessageType.Error)
					{
						return deployLogMessage;
					}
					num2 = 2;
					break;
				case 5:
					throw new InvalidOperationException((string)IsZW8vE7JydepbHE9Spi(ro9qKGE7pAhq6BRlWS4q(-672123589 ^ -671833109)));
				case 4:
					deployLogMessage = runImportParameters.LogMessages.LastOrDefault();
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private bool RunImportStep0(IImportSettings settings)
	{
		int num = 3;
		int num2 = num;
		DeployLogMessage lastImportMessage = default(DeployLogMessage);
		while (true)
		{
			switch (num2)
			{
			case 2:
				iSmIGYE7D7jiMwL5tQwD(ImportLog, ro9qKGE7pAhq6BRlWS4q(-583745292 ^ -584034532));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				WGPrtYE7lh0pKWn5QkJo(pxOaIPE7do7JSaxqCfHo(configurationImportInternalFactory, settings), runImportParameters);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 6;
				}
				break;
			case 3:
				if (settings.ImportStep == 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					iSmIGYE7D7jiMwL5tQwD(ImportLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107747320));
					num2 = 5;
				}
				break;
			case 5:
				return RunImportStep1(settings, needRestart: false, null);
			default:
				return RunImportStep1(settings, JqxsXKE7gumetmNDL9of(lastImportMessage), (PackageInstallInfo)SqRdnSE75xNe0UafODAY(lastImportMessage));
			case 6:
				lastImportMessage = GetLastImportMessage();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				JnjmhFE7rnUE3w6gCg9r(settings, 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private bool RunImportStep1(IImportSettings settings, bool needRestart, PackageInstallInfo installInfo)
	{
		//Discarded unreachable code: IL_00f6, IL_0192, IL_0219
		int num = 9;
		DeployLogMessage lastImportMessage = default(DeployLogMessage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (settings.ImportStep == 1)
					{
						num2 = 8;
						continue;
					}
					iSmIGYE7D7jiMwL5tQwD(ImportLog, ro9qKGE7pAhq6BRlWS4q(-1837662597 ^ -1837897801));
					num2 = 4;
					continue;
				default:
					xnONcsE7yt52Du05U7vK(state, installInfo);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
				case 10:
					runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T((string)ro9qKGE7pAhq6BRlWS4q(0x34A6D230 ^ 0x34A24AB0)), endProcess: true, endStage: true, needRestart: true)
					{
						InstallInfo = installInfo
					});
					num = 11;
					break;
				case 3:
					if (!needRestart)
					{
						num2 = 13;
						continue;
					}
					goto case 6;
				case 14:
					JnjmhFE7rnUE3w6gCg9r(settings, 2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return RunImportStep2(settings, needRestart: false);
				case 12:
					lastImportMessage = GetLastImportMessage();
					num = 14;
					break;
				case 11:
					return false;
				case 13:
					WGPrtYE7lh0pKWn5QkJo(pxOaIPE7do7JSaxqCfHo(configurationImportInternalFactory, settings), runImportParameters);
					num2 = 12;
					continue;
				case 7:
					if (!installInfo.Operations.Any())
					{
						num2 = 10;
						continue;
					}
					goto case 15;
				case 15:
					if (KgOFOlE7jLUslceCFU0r(installInfo) != Guid.Empty)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 8:
					ImportLog.Info(ro9qKGE7pAhq6BRlWS4q(0x48A7E34A ^ 0x48A37B0E));
					num2 = 3;
					continue;
				case 2:
					Kluf68E7YyMhn2A71ry1(state, true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return RunImportStep2(settings, JqxsXKE7gumetmNDL9of(lastImportMessage));
				case 6:
					if (installInfo != null)
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	private void InstallPackages(PackageInstallInfo installInfo)
	{
		//Discarded unreachable code: IL_0160
		int num = 6;
		int num2 = num;
		string text = default(string);
		PackageOperationStatus packageOperationStatus = default(PackageOperationStatus);
		while (true)
		{
			switch (num2)
			{
			case 5:
				gcCbovE7LOoEqrnGGLfV(deployManager, installInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				iSmIGYE7D7jiMwL5tQwD(ImportLog, ro9qKGE7pAhq6BRlWS4q(0x53FA00CE ^ 0x53FE9AC6));
				num2 = 5;
				break;
			case 7:
				throw new InvalidOperationException(text);
			default:
				text = SR.T((string)ro9qKGE7pAhq6BRlWS4q(-138018305 ^ -138241075), vdy1egE7cXOrx64Hy1Na(packageOperationStatus));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 8:
				xvMFroE7zIrRJ7wkUvjg(1000);
				num2 = 4;
				break;
			case 10:
				iSmIGYE7D7jiMwL5tQwD(ImportLog, ro9qKGE7pAhq6BRlWS4q(0xE1229CF ^ 0xE16B349));
				num2 = 3;
				break;
			case 11:
				if (packageOperationStatus == null)
				{
					num2 = 8;
					break;
				}
				goto case 9;
			case 2:
				runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, text));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 7;
				}
				break;
			case 9:
				if (FCvA9fE7sgbC1yY3NO7r(packageOperationStatus) != PackageOperationStatusType.Error)
				{
					if (packageOperationStatus.Type == PackageOperationStatusType.Completed)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 8;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 4:
				packageOperationStatus = (PackageOperationStatus)JLHnNbE7U0y9DZPKId3G(deployManager, KgOFOlE7jLUslceCFU0r(installInfo));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private bool RunImportStep2(IImportSettings settings, bool needRestart)
	{
		//Discarded unreachable code: IL_013d, IL_014c, IL_0199, IL_01dd, IL_0215, IL_025e, IL_029e, IL_02ad, IL_02b9, IL_02c8
		int num = 4;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (ikTwQIExFIZIaS225uro(settings) == 2)
					{
						num2 = 3;
						continue;
					}
					break;
				case 2:
					GetLastImportMessage();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					goto end_IL_0012;
				case 3:
					ImportLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3136FBCE));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					iSmIGYE7D7jiMwL5tQwD(ImportLog, ro9qKGE7pAhq6BRlWS4q(0x3A5D5EF ^ 0x3A14F13));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return false;
				case 1:
					disposable = ELMAContext.CreateIsolated();
					num2 = 8;
					continue;
				case 9:
					if (!needRestart)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 8:
					try
					{
						CallContextSessionOwner callContextSessionOwner = (CallContextSessionOwner)NKAAPgExBPhRKjgjuMYe();
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								WGPrtYE7lh0pKWn5QkJo(pxOaIPE7do7JSaxqCfHo(configurationImportInternalFactory, settings), runImportParameters);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							finally
							{
								if (callContextSessionOwner != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											((IDisposable)callContextSessionOwner).Dispose();
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
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
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (disposable == null)
						{
							num6 = 2;
							goto IL_0262;
						}
						goto IL_0278;
						IL_0262:
						switch (num6)
						{
						default:
							goto end_IL_024d;
						case 1:
							break;
						case 2:
							goto end_IL_024d;
						case 0:
							goto end_IL_024d;
						}
						goto IL_0278;
						IL_0278:
						kfZJemExWGuM3F2mbpjG(disposable);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num6 = 0;
						}
						goto IL_0262;
						end_IL_024d:;
					}
					goto case 2;
				case 6:
					break;
				}
				return true;
				continue;
				end_IL_0012:
				break;
			}
			runImportParameters.LogMessages.Add(new DeployLogMessage(DeployLogMessageType.Warn, (string)IsZW8vE7JydepbHE9Spi(ro9qKGE7pAhq6BRlWS4q(0x4EA5403C ^ 0x4EA1DB78)), endProcess: true, endStage: true, needRestart: true));
			num = 7;
		}
	}

	static ContinuedImporter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ImportLog = (ILogger)tEBWHoExoBKAeaaJoOtY(ro9qKGE7pAhq6BRlWS4q(0x6DC147B0 ^ 0x6DC5C46E));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				UdJiXtE73WmWEDH70K3T();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void UdJiXtE73WmWEDH70K3T()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool RT3QsaE71u7K8yTuxpad()
	{
		return uNIkL6E7PLH8bkGtu9vY == null;
	}

	internal static ContinuedImporter m0HbVvE7Nv3Gv5dyQRVh()
	{
		return uNIkL6E7PLH8bkGtu9vY;
	}

	internal static object ro9qKGE7pAhq6BRlWS4q(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object FggFlaE7a86HowvMXqOj(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void iSmIGYE7D7jiMwL5tQwD(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object aqs3spE7t0AEUEE7Xv3P(object P_0)
	{
		return ((IConfigImportSettings)P_0).Manifest;
	}

	internal static object oJRPcXE7wFmeMpC8HoKa(object P_0)
	{
		return ((IConfigImportSettings)P_0).FileName;
	}

	internal static void B2ADibE74qt13qCaL7Kh(object P_0)
	{
		((List<DeployLogMessage>)P_0).Clear();
	}

	internal static object AKGiwkE767lu2fHEWUQv(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static object DePMQGE7H6UWnyYUDXm3(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool fB9VHlE7AxiPBFuBfj3J(object P_0)
	{
		return ((DeployLogMessage)P_0).EndProcess;
	}

	internal static DeployLogMessageType jsuR9tE7738aUNw1jm35(object P_0)
	{
		return ((DeployLogMessage)P_0).MessageType;
	}

	internal static void f6rnB1E7xm2lpoUHKlIH(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void sYDc0nE700urQt96wENZ(object P_0, object P_1)
	{
		((IExportImportFileService)P_0).DeleteFiles((string)P_1);
	}

	internal static object CHlN92E7m9OkX9J0wQMy(object P_0)
	{
		return ((ContinuedImportState)P_0).PackageInstallInfo;
	}

	internal static void xnONcsE7yt52Du05U7vK(object P_0, object P_1)
	{
		((ContinuedImportState)P_0).PackageInstallInfo = (PackageInstallInfo)P_1;
	}

	internal static void B40DGJE7MY06uIhcQNLN(object P_0, object P_1, object P_2)
	{
		((IBLOBStore)P_0).Save((string)P_1, (byte[])P_2);
	}

	internal static object IsZW8vE7JydepbHE9Spi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object pG9D3cE793U9PP96wt2u(object P_0)
	{
		return ((DeployLogMessage)P_0).MessageText;
	}

	internal static object pxOaIPE7do7JSaxqCfHo(object P_0, object P_1)
	{
		return ((IConfigurationImportInternalFactory)P_0).CreateImporter((IImportSettings)P_1);
	}

	internal static void WGPrtYE7lh0pKWn5QkJo(object P_0, object P_1)
	{
		((IConfigurationImporter)P_0).RunImport((IRunImportParameters)P_1);
	}

	internal static void JnjmhFE7rnUE3w6gCg9r(object P_0, int value)
	{
		((IImportSettings)P_0).ImportStep = value;
	}

	internal static bool JqxsXKE7gumetmNDL9of(object P_0)
	{
		return ((DeployLogMessage)P_0).NeedRestart;
	}

	internal static object SqRdnSE75xNe0UafODAY(object P_0)
	{
		return ((DeployLogMessage)P_0).InstallInfo;
	}

	internal static Guid KgOFOlE7jLUslceCFU0r(object P_0)
	{
		return ((PackageInstallInfo)P_0).UpdatingUid;
	}

	internal static void Kluf68E7YyMhn2A71ry1(object P_0, bool value)
	{
		((ContinuedImportState)P_0).NeedToInstallPackages = value;
	}

	internal static void gcCbovE7LOoEqrnGGLfV(object P_0, object P_1)
	{
		((IDeployManager)P_0).ExecutePackagesOperations((PackageInstallInfo)P_1);
	}

	internal static object JLHnNbE7U0y9DZPKId3G(object P_0, Guid uid)
	{
		return ((IDeployManager)P_0).GetUpdatePackagesOperationsStatus(uid);
	}

	internal static PackageOperationStatusType FCvA9fE7sgbC1yY3NO7r(object P_0)
	{
		return ((PackageOperationStatus)P_0).Type;
	}

	internal static object vdy1egE7cXOrx64Hy1Na(object P_0)
	{
		return ((PackageOperationStatus)P_0).Message;
	}

	internal static void xvMFroE7zIrRJ7wkUvjg(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static int ikTwQIExFIZIaS225uro(object P_0)
	{
		return ((IImportSettings)P_0).ImportStep;
	}

	internal static object NKAAPgExBPhRKjgjuMYe()
	{
		return CallContextSessionOwner.Create();
	}

	internal static void kfZJemExWGuM3F2mbpjG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object tEBWHoExoBKAeaaJoOtY(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
