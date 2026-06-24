using System;
using System.Globalization;
using System.Resources;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Type = ComponentType.Server)]
internal class ImproveProcessImport : IModuleContainerEvents
{
	private readonly IConfigurationImportFactory configurationImportFactory;

	private static ImproveProcessImport w9kk43NkNQTlls3SwrM;

	public ImproveProcessImport(IConfigurationImportFactory configurationImportFactory)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zlrfybNmCsT4dSlU62r();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 != 0)
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
			case 1:
				this.configurationImportFactory = configurationImportFactory;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void ImportProcess()
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
				OgPKoXNAlnnB4VQ92Ig(Locator.GetServiceNotNull<ISecurityService>(), (Action)delegate
				{
					//Discarded unreachable code: IL_0039, IL_0048, IL_0159, IL_018c, IL_01f4, IL_0241, IL_0250, IL_0356, IL_0389, IL_03eb, IL_03fa, IL_04e6, IL_0537, IL_0546
					int num3 = 5;
					string @string = default(string);
					IProcessHeader processHeader = default(IProcessHeader);
					string name = default(string);
					SystemImportSettings systemImportSettings = default(SystemImportSettings);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 5:
								if (Locator.GetService<ProcessHeaderManager>() != null)
								{
									num4 = 4;
									continue;
								}
								return;
							case 0:
								return;
							case 4:
								if (((AbstractNHEntityManager<IProcessHeader, long>)FD8XeeNpvFNVkRC0anG()).LoadOrNull(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x604C9214 ^ 0x604CA478))) == null)
								{
									num4 = 2;
									continue;
								}
								break;
							case 3:
								return;
							case 1:
								return;
							case 2:
								try
								{
									CultureInfo cultureInfo = (CultureInfo)tuDjnbN67fSWB86Z2RQ(NCoddYNG3qQSugukpVl(), hXIylRNO5nipZASZbE2(vXqnISNyOhPH5ZCuX1I(IKpH0bNnPFAxY6yF2uw())));
									int num5 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										case 7:
											return;
										case 6:
											if (UZxZJbNB72gi1T3gjr1(@string))
											{
												num5 = 7;
												continue;
											}
											goto case 9;
										default:
											try
											{
												r1PRJ4Nll8LQ09kpRm3(FD8XeeNpvFNVkRC0anG(), processHeader, null);
												int num7 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
												{
													num7 = 0;
												}
												switch (num7)
												{
												case 0:
													break;
												}
											}
											catch (Exception exception)
											{
												int num8 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 != 0)
												{
													num8 = 0;
												}
												while (true)
												{
													switch (num8)
													{
													default:
														Logger.Log.Error(RlAuatNukbw8rwcwrbq(-869419654 ^ -869413916), exception);
														num8 = 1;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
														{
															num8 = 0;
														}
														break;
													case 1:
														throw new Exception((string)RlAuatNukbw8rwcwrbq(-711228462 ^ -711197364));
													}
												}
											}
											goto case 2;
										case 1:
											name = (string)d37an7NRumhPMgosyCM(NCoddYNG3qQSugukpVl(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C126B81 ^ 0x3C1215FF), hXIylRNO5nipZASZbE2(cultureInfo));
											num5 = 5;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 != 0)
											{
												num5 = 0;
											}
											continue;
										case 2:
											num5 = 3;
											continue;
										case 8:
											processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)FD8XeeNpvFNVkRC0anG()).LoadOrNull(new Guid((string)RlAuatNukbw8rwcwrbq(--286570904 ^ 0x11148FF4)));
											num5 = 10;
											continue;
										case 5:
											@string = ((ResourceManager)dObdlcN0cKQdTEco6x0()).GetString(name);
											num5 = 6;
											continue;
										case 3:
											try
											{
												IImprovementProcessSettings improvementProcessSettings = ((AbstractNHEntityManager<IImprovementProcessSettings, long>)d7rPE7Nf6QNtuGeyDpX()).Create();
												improvementProcessSettings.Default = true;
												nWDiDxNL5CfV4v45ePG(improvementProcessSettings, processHeader);
												improvementProcessSettings.ProcessHeaderContextVar = new Guid((string)RlAuatNukbw8rwcwrbq(-882646278 ^ -882664426));
												zY6McgNJ189hJnRfBhg(improvementProcessSettings, new Guid((string)RlAuatNukbw8rwcwrbq(-802458460 ^ -802485348)));
												EiqE2TNrPNFLRXDSkcS(improvementProcessSettings, new Guid((string)RlAuatNukbw8rwcwrbq(-416187968 ^ -416217532)));
												improvementProcessSettings.DescriptionContextVar = new Guid((string)RlAuatNukbw8rwcwrbq(-1803374629 ^ -1803366389));
												improvementProcessSettings.Save();
												int num9 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
												{
													num9 = 0;
												}
												switch (num9)
												{
												case 0:
													break;
												}
												return;
											}
											catch (Exception ex)
											{
												int num10 = 1;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
												{
													num10 = 0;
												}
												while (true)
												{
													switch (num10)
													{
													case 1:
														f4IJ9EN5NTLSMOcOj6N(F9ShHcN7aVcMu8OHc8R(), RlAuatNukbw8rwcwrbq(-769877317 ^ -769910105), ex);
														num10 = 0;
														if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
														{
															num10 = 0;
														}
														break;
													default:
														throw new Exception((string)RlAuatNukbw8rwcwrbq(0x242A8D1D ^ 0x242A0D01));
													}
												}
											}
										case 10:
											if (processHeader != null)
											{
												num5 = 0;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
												{
													num5 = 0;
												}
												continue;
											}
											break;
										case 9:
										{
											systemImportSettings = new SystemImportSettings(@string);
											int num6 = 4;
											num5 = num6;
											continue;
										}
										case 4:
											xKSax6Nip9mi0QBc2nD(eRyK1VNWqxmFqYO7odT(configurationImportFactory, systemImportSettings), new RunImportParameters(((IIdentified)(yhqwNENHsDxVxW4mbex(Locator.GetServiceNotNull<IAuthenticationService>()) ?? ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)iPxqp6NeVoC0Gg8Xu3n()).LoadOrNull(SecurityConstants.AdminUserUid)))?.GetId() as long?));
											num5 = 8;
											continue;
										case 11:
											break;
										}
										break;
									}
									throw new Exception(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C21F94 ^ 0x1C29FEA));
								}
								catch (Exception ex2)
								{
									int num11 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb != 0)
									{
										num11 = 1;
									}
									while (true)
									{
										switch (num11)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											f4IJ9EN5NTLSMOcOj6N(F9ShHcN7aVcMu8OHc8R(), RlAuatNukbw8rwcwrbq(-802458460 ^ -802425838), ex2);
											num11 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
											{
												num11 = 0;
											}
											break;
										}
									}
								}
							}
							break;
						}
						num3 = 3;
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Activated()
	{
		ImportProcess();
	}

	public void Terminating()
	{
	}

	internal static void zlrfybNmCsT4dSlU62r()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool TyIQHkNbiDt68GHTEa5()
	{
		return w9kk43NkNQTlls3SwrM == null;
	}

	internal static ImproveProcessImport YOmUo4NUCvhFyCfcxSg()
	{
		return w9kk43NkNQTlls3SwrM;
	}

	internal static void OgPKoXNAlnnB4VQ92Ig(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunBySystemUser((Action)P_1);
	}

	internal static object FD8XeeNpvFNVkRC0anG()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object NCoddYNG3qQSugukpVl()
	{
		return SR.LanguagesMap;
	}

	internal static object IKpH0bNnPFAxY6yF2uw()
	{
		return Thread.CurrentThread;
	}

	internal static object vXqnISNyOhPH5ZCuX1I(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object hXIylRNO5nipZASZbE2(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object tuDjnbN67fSWB86Z2RQ(object P_0, object P_1)
	{
		return ((LanguagesMap)P_0).GetBaseCultureInfo((string)P_1);
	}

	internal static object d37an7NRumhPMgosyCM(object P_0, object P_1, object P_2)
	{
		return ((LanguagesMap)P_0).GetResourceName((string)P_1, (string)P_2);
	}

	internal static object dObdlcN0cKQdTEco6x0()
	{
		return Resources.ResourceManager;
	}

	internal static bool UZxZJbNB72gi1T3gjr1(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object eRyK1VNWqxmFqYO7odT(object P_0, object P_1)
	{
		return ((IConfigurationImportFactory)P_0).CreateImporter((IImportSettings)P_1);
	}

	internal static object yhqwNENHsDxVxW4mbex(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object iPxqp6NeVoC0Gg8Xu3n()
	{
		return UserManager.Instance;
	}

	internal static void xKSax6Nip9mi0QBc2nD(object P_0, object P_1)
	{
		((IConfigurationImporter)P_0).RunImport((IRunImportParameters)P_1);
	}

	internal static object RlAuatNukbw8rwcwrbq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void r1PRJ4Nll8LQ09kpRm3(object P_0, object P_1, object P_2)
	{
		((ProcessHeaderManager)P_0).Publish((IProcessHeader)P_1, (string)P_2);
	}

	internal static object d7rPE7Nf6QNtuGeyDpX()
	{
		return ImprovementProcessSettingsManager.Instance;
	}

	internal static void nWDiDxNL5CfV4v45ePG(object P_0, object P_1)
	{
		((IImprovementProcessSettings)P_0).Header = (IProcessHeader)P_1;
	}

	internal static void zY6McgNJ189hJnRfBhg(object P_0, Guid value)
	{
		((IImprovementProcessSettings)P_0).WorkflowInstanceContextVar = value;
	}

	internal static void EiqE2TNrPNFLRXDSkcS(object P_0, Guid value)
	{
		((IImprovementProcessSettings)P_0).TaskContextVar = value;
	}

	internal static object F9ShHcN7aVcMu8OHc8R()
	{
		return Logger.Log;
	}

	internal static void f4IJ9EN5NTLSMOcOj6N(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
