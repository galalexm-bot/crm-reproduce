using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

internal class FolderPreviewUpdateHandler : DbUpdateHandler
{
	private static FolderPreviewUpdateHandler uyN9W0G2FBpvlYosjxuS;

	public IFolderPreviewService FolderPreviewService
	{
		[CompilerGenerated]
		get
		{
			return _003CFolderPreviewService_003Ek__BackingField;
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
					_003CFolderPreviewService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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

	public override Guid ProviderUid => Guid.Empty;

	public override bool HasChanges => false;

	public override bool NeedRecreateConstraints => false;

	public override void OnComplete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				base.OnComplete();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				yR2iHqG2oFxuRog0UXru((ThreadStart)delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							new BackgroundTask(delegate
							{
								//Discarded unreachable code: IL_00e8, IL_011a, IL_0129, IL_0134, IL_020a, IL_023d, IL_0293, IL_0303, IL_0316
								int num5 = 4;
								int num6 = num5;
								List<string> list = default(List<string>);
								List<string>.Enumerator enumerator = default(List<string>.Enumerator);
								string current = default(string);
								string text = default(string);
								while (true)
								{
									Guid result;
									switch (num6)
									{
									default:
										return;
									case 3:
										if (list.Count == 0)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
											{
												num6 = 0;
											}
										}
										else
										{
											result = Guid.Empty;
											num6 = 5;
										}
										break;
									case 0:
										return;
									case 2:
										return;
									case 7:
										enumerator = list.GetEnumerator();
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
										{
											num6 = 1;
										}
										break;
									case 5:
										if (!Guid.TryParse((string)y0c5AhG2CBZg3jSYyy04(list[0].Replace((string)GE8xE4G2QAmrbR8qoD4N(list[0]), ""), 1), out result))
										{
											return;
										}
										num6 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
										{
											num6 = 1;
										}
										break;
									case 6:
										return;
									case 4:
										list = Directory.EnumerateDirectories((string)WO3lPdG2fHY1X9hqPPFF(FolderPreviewService)).ToList();
										num6 = 3;
										break;
									case 1:
										try
										{
											while (true)
											{
												int num7;
												if (!enumerator.MoveNext())
												{
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
													{
														num7 = 0;
													}
													goto IL_0138;
												}
												goto IL_029d;
												IL_029d:
												current = enumerator.Current;
												num7 = 2;
												goto IL_0138;
												IL_0138:
												while (true)
												{
													switch (num7)
													{
													case 1:
														return;
													case 2:
														text = current.Replace((string)GE8xE4G2QAmrbR8qoD4N(current), "");
														num7 = 3;
														continue;
													case 7:
														break;
													case 6:
														text = text.Substring(1);
														num7 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
														{
															num7 = 0;
														}
														continue;
													case 3:
														if (text[0] == Path.DirectorySeparatorChar)
														{
															num7 = 6;
															continue;
														}
														goto default;
													case 5:
														try
														{
															oJoHNiG28tfS9RMGJNON(current, true);
															int num8 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
															{
																num8 = 0;
															}
															switch (num8)
															{
															case 0:
																break;
															}
														}
														catch (Exception ex)
														{
															int num9 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
															{
																num9 = 1;
															}
															while (true)
															{
																switch (num9)
																{
																case 1:
																	ew9uvnG2uhOdEFKhsM1B(zanvfOG2ZSetTXx3OT2j(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088280382)), ex);
																	num9 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
																	{
																		num9 = 0;
																	}
																	continue;
																case 0:
																	break;
																}
																break;
															}
														}
														break;
													case 4:
														goto IL_029d;
													default:
														if (KMAdcTG2vi555XJnZ58u(text) > 2)
														{
															num7 = 4;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
															{
																num7 = 5;
															}
															continue;
														}
														break;
													}
													break;
												}
											}
										}
										finally
										{
											((IDisposable)enumerator).Dispose();
											int num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
											{
												num10 = 0;
											}
											switch (num10)
											{
											case 0:
												break;
											}
										}
									}
								}
							}, TnlapZG2hCviYT89Q4KB(typeof(FolderPreviewService).TypeHandle), (string)s6F1w4G2EXpcKQDwDiwj(p3DiZEG2GvUc2YaelPQb(-1146510045 ^ -1146468807)), (string)s6F1w4G2EXpcKQDwDiwj(p3DiZEG2GvUc2YaelPQb(-576149596 ^ -575978306))).Execute();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public FolderPreviewUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nGZoiNG2bAOgKQcNwhO0();
		base._002Ector();
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
	}

	internal static bool DG56vWG2BNQLArklAjCb()
	{
		return uyN9W0G2FBpvlYosjxuS == null;
	}

	internal static FolderPreviewUpdateHandler k4QMj9G2WNyrqxYbN4Kp()
	{
		return uyN9W0G2FBpvlYosjxuS;
	}

	internal static bool yR2iHqG2oFxuRog0UXru(object P_0)
	{
		return ThreadStarter.QueueThread((ThreadStart)P_0);
	}

	internal static void nGZoiNG2bAOgKQcNwhO0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type TnlapZG2hCviYT89Q4KB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object p3DiZEG2GvUc2YaelPQb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object s6F1w4G2EXpcKQDwDiwj(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object WO3lPdG2fHY1X9hqPPFF(object P_0)
	{
		return ((IFolderPreviewService)P_0).PreviewsPath;
	}

	internal static object GE8xE4G2QAmrbR8qoD4N(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object y0c5AhG2CBZg3jSYyy04(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static int KMAdcTG2vi555XJnZ58u(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static void oJoHNiG28tfS9RMGJNON(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static object zanvfOG2ZSetTXx3OT2j()
	{
		return Logger.Log;
	}

	internal static void ew9uvnG2uhOdEFKhsM1B(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
