using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

[Component(Order = 50)]
public class FilesImportExtension : ConfigImportExtension
{
	private string shouldReadDocuments;

	private readonly IAdditionalFilesService additionalFilesService;

	internal static FilesImportExtension lnfcjuEmEMY47Cnt1iLT;

	public FilesImportExtension(IAdditionalFilesService additionalFilesService)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		r2dYaBEmCNZlUeM4t7h0();
		shouldReadDocuments = (string)X3q3jJEm8EwQW6t9YDs4(BdOPWmEmv1oM1QSYDT8J(0x48A7E34A ^ 0x48A34AD0));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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
			this.additionalFilesService = additionalFilesService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num = 1;
			}
		}
	}

	public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0147, IL_017f, IL_018e, IL_01bf, IL_01ce, IL_024e, IL_02ce, IL_02fa, IL_0309
		int num = 5;
		IEnumerator<DeploySystemMessage> enumerator = default(IEnumerator<DeploySystemMessage>);
		DeploySystemMessage current = default(DeploySystemMessage);
		string text = default(string);
		string text2 = default(string);
		IEnumerable<DeploySystemMessage> enumerable = default(IEnumerable<DeploySystemMessage>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj3;
				object obj;
				switch (num2)
				{
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 1;
								}
								goto IL_0098;
							}
							goto IL_00d8;
							IL_00d8:
							current = enumerator.Current;
							int num4 = 3;
							num3 = num4;
							goto IL_0098;
							IL_0098:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									goto IL_00d8;
								case 3:
									parameters.Messages.Add(new TestImportMessages(TestImportMessagesType.InfoCommon, (string)d3lfh8EmqiAGjZpjQtFL(current)));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num3 = 2;
									}
									continue;
								case 1:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									enumerator.Dispose();
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 2:
					return;
				case 4:
					return;
				case 7:
					return;
				case 14:
					return;
				case 18:
					return;
				default:
					parameters.Messages.Add(new TestImportMessages(TestImportMessagesType.InfoCommon, shouldReadDocuments));
					num2 = 9;
					continue;
				case 16:
					Directory.CreateDirectory(text);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 20;
					}
					continue;
				case 20:
					FileUtils.CopyDirectory(text2, text);
					num2 = 19;
					continue;
				case 13:
					if (Directory.Exists(text))
					{
						num2 = 11;
						continue;
					}
					goto case 16;
				case 5:
					if (parameters.Manifest == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 8:
					if (!enumerable.Any())
					{
						num2 = 18;
						continue;
					}
					goto default;
				case 3:
					if (AjYxbjEmuiR6m6lhMk2P(WGEFoWEmZtMQCGQlaIXb(parameters)))
					{
						num2 = 17;
						continue;
					}
					obj3 = Path.Combine(parameters.ServerFolderName, (string)BdOPWmEmv1oM1QSYDT8J(0x7247028A ^ 0x72437CC4));
					goto IL_036b;
				case 21:
					text = (string)OWHkQlEmSdx7NFMN6UZB(additionalFilesService, sW5Wh8EmVZPPjBMpGC4x(parameters));
					num2 = 13;
					continue;
				case 9:
					enumerator = enumerable.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					obj3 = null;
					goto IL_036b;
				case 11:
					maxSqDEmitUnebfGxfoJ(text, true);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 14;
					}
					continue;
				case 12:
					if (AjYxbjEmuiR6m6lhMk2P(text2))
					{
						return;
					}
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 15;
					}
					continue;
				case 15:
					if (!rlxEIPEmIl8APf9ZqenK(text2))
					{
						num2 = 2;
						continue;
					}
					goto case 21;
				case 19:
				{
					ConfigImportSettings obj2 = cxK67QEmRWrOsfjGR30r(parameters) as ConfigImportSettings;
					if (obj2 == null)
					{
						num = 6;
						break;
					}
					obj = obj2.Manifest;
					goto IL_03a7;
				}
				case 6:
					obj = null;
					goto IL_03a7;
				case 10:
					{
						enumerable = parameters.SystemMessages.Where((DeploySystemMessage m) => (string)_003C_003Ec.CiLWVM8DNkRYGrjrE1ZH(m) == (string)_003C_003Ec.moa8dc8D3AKyrOtsmYaD(-289714582 ^ -289413970));
						num = 8;
						break;
					}
					IL_03a7:
					if (obj == null)
					{
						num2 = 14;
						continue;
					}
					goto case 10;
					IL_036b:
					text2 = (string)obj3;
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	public override void OnPostReadPackets(PostReadPacketsParameters parameters)
	{
		//Discarded unreachable code: IL_008c, IL_009b, IL_00e7, IL_00f6, IL_0106, IL_0209
		int num = 16;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					return;
				case 4:
					return;
				case 7:
					return;
				case 11:
					return;
				case 16:
					if (n3mmJbEmKBVx71yZDuAI(parameters) != 2)
					{
						return;
					}
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 15;
					}
					continue;
				case 10:
					if (AjYxbjEmuiR6m6lhMk2P(text))
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 12:
					_ = ((ElmaStoreComponentManifest)rjnO34EmX74OkyjsSWbj(parameters)).Id;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					obj = null;
					break;
				case 2:
					if (!rlxEIPEmIl8APf9ZqenK(text))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 3;
				case 15:
					if (rjnO34EmX74OkyjsSWbj(parameters) == null)
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 8;
					}
					continue;
				case 13:
					parameters.SystemMessages.Add(new DeploySystemMessage((string)BdOPWmEmv1oM1QSYDT8J(-70037984 ^ -69737182), parameters.Manifest.HelpFileName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					if (AjYxbjEmuiR6m6lhMk2P(XhYB43EmTMhrlddrbCcb(parameters)))
					{
						num2 = 14;
						continue;
					}
					obj = qgkmgZEmk7K2K8NFHwom(XhYB43EmTMhrlddrbCcb(parameters), BdOPWmEmv1oM1QSYDT8J(-1765851862 ^ -1766112412));
					break;
				case 5:
					G9Nq1yEmn1fo75FLOjT2(rjnO34EmX74OkyjsSWbj(parameters));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					if (string.IsNullOrEmpty((string)G9Nq1yEmn1fo75FLOjT2(rjnO34EmX74OkyjsSWbj(parameters))))
					{
						goto end_IL_0012;
					}
					goto case 5;
				default:
					if (string.IsNullOrEmpty(((ElmaStoreComponentManifest)rjnO34EmX74OkyjsSWbj(parameters)).HelpFileName))
					{
						num2 = 11;
						continue;
					}
					goto case 13;
				case 6:
				case 9:
					parameters.SystemMessages.Add(new DeploySystemMessage(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A659F7A), (string)iXkkFyEmOM23a5QWnvoe(additionalFilesService, parameters.Manifest)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				text = (string)obj;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 10;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	public override void OnImportSuccessfull(ImportSuccessfullParameters parameters)
	{
		//Discarded unreachable code: IL_0098, IL_00a7, IL_00b2, IL_0151, IL_0191, IL_01a0, IL_01ac
		int num = 4;
		IEnumerator<DeploySystemMessage> enumerator = default(IEnumerator<DeploySystemMessage>);
		IEnumerable<DeploySystemMessage> enumerable = default(IEnumerable<DeploySystemMessage>);
		DeploySystemMessage current = default(DeploySystemMessage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
				{
					ConfigImportSettings obj2 = FT3RmBEm2vs1c86c1ijT(parameters) as ConfigImportSettings;
					if (obj2 == null)
					{
						num2 = 3;
						continue;
					}
					obj = obj2.Manifest;
					goto IL_01e2;
				}
				case 7:
					enumerator = enumerable.GetEnumerator();
					num2 = 2;
					continue;
				case 6:
					return;
				case 5:
					if (!enumerable.Any())
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!pvZsqUEmeRykuFTun5Tw(enumerator))
							{
								num3 = 2;
								goto IL_00b6;
							}
							goto IL_00e6;
							IL_00b6:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return;
								case 1:
									goto IL_00e6;
								case 3:
									parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string)d3lfh8EmqiAGjZpjQtFL(current)));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
							continue;
							IL_00e6:
							current = enumerator.Current;
							num3 = 3;
							goto IL_00b6;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num4 = 0;
							}
							goto IL_0155;
						}
						goto IL_016b;
						IL_016b:
						N3r1UEEmPrxE6LaVEVJg(enumerator);
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num4 = 2;
						}
						goto IL_0155;
						IL_0155:
						switch (num4)
						{
						case 1:
							goto end_IL_0130;
						case 2:
							goto end_IL_0130;
						}
						goto IL_016b;
						end_IL_0130:;
					}
				default:
					parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, shouldReadDocuments));
					num2 = 7;
					continue;
				case 3:
					obj = null;
					goto IL_01e2;
				case 1:
					{
						enumerable = parameters.SystemMessages.Where((DeploySystemMessage m) => _003C_003Ec.ILLH6Q8DpQw6lm1LJbiE(_003C_003Ec.CiLWVM8DNkRYGrjrE1ZH(m), _003C_003Ec.moa8dc8D3AKyrOtsmYaD(-289714582 ^ -289413970)));
						num = 5;
						break;
					}
					IL_01e2:
					if (obj == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void r2dYaBEmCNZlUeM4t7h0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object BdOPWmEmv1oM1QSYDT8J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object X3q3jJEm8EwQW6t9YDs4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool HSbCbYEmfe4S9y7C0lf1()
	{
		return lnfcjuEmEMY47Cnt1iLT == null;
	}

	internal static FilesImportExtension KlLkqnEmQZ1YWRQHtPtI()
	{
		return lnfcjuEmEMY47Cnt1iLT;
	}

	internal static object WGEFoWEmZtMQCGQlaIXb(object P_0)
	{
		return ((TestImportExtensionParameters)P_0).ServerFolderName;
	}

	internal static bool AjYxbjEmuiR6m6lhMk2P(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool rlxEIPEmIl8APf9ZqenK(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object sW5Wh8EmVZPPjBMpGC4x(object P_0)
	{
		return ((TestImportExtensionParameters)P_0).Manifest;
	}

	internal static object OWHkQlEmSdx7NFMN6UZB(object P_0, object P_1)
	{
		return ((IAdditionalFilesService)P_0).GetStoreAdditionalFilesPath((ElmaStoreComponentManifest)P_1);
	}

	internal static void maxSqDEmitUnebfGxfoJ(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static object cxK67QEmRWrOsfjGR30r(object P_0)
	{
		return ((PostCompleteTestImportParameters)P_0).ImportSettings;
	}

	internal static object d3lfh8EmqiAGjZpjQtFL(object P_0)
	{
		return ((DeploySystemMessage)P_0).Value;
	}

	internal static int n3mmJbEmKBVx71yZDuAI(object P_0)
	{
		return ((ImportExtensionParameters)P_0).ImportStep;
	}

	internal static object rjnO34EmX74OkyjsSWbj(object P_0)
	{
		return ((ImportExtensionParameters)P_0).Manifest;
	}

	internal static object XhYB43EmTMhrlddrbCcb(object P_0)
	{
		return ((ImportExtensionParameters)P_0).ServerFolderName;
	}

	internal static object qgkmgZEmk7K2K8NFHwom(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object G9Nq1yEmn1fo75FLOjT2(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Title;
	}

	internal static object iXkkFyEmOM23a5QWnvoe(object P_0, object P_1)
	{
		return ((IAdditionalFilesService)P_0).GetStoreAdditionalFilesPathMessage((ElmaStoreComponentManifest)P_1);
	}

	internal static object FT3RmBEm2vs1c86c1ijT(object P_0)
	{
		return ((ImportSuccessfullParameters)P_0).ImportSettings;
	}

	internal static bool pvZsqUEmeRykuFTun5Tw(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void N3r1UEEmPrxE6LaVEVJg(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
