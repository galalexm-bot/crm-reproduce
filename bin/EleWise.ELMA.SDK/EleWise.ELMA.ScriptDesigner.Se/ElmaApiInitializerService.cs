using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.Services;

[Service(Type = ComponentType.Server)]
internal class ElmaApiInitializerService
{
	private static readonly Guid moduleUid;

	private byte[] zippedTree;

	private bool initializing;

	private Exception initException;

	private object initApiTreeLockObj;

	internal static ElmaApiInitializerService DWqw0xV7X9Km4mg9cdR;

	public bool IsApiTreeInitialized()
	{
		//Discarded unreachable code: IL_004e
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (initializing)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 1:
			case 4:
				return false;
			case 5:
				ThreadStarter.QueueThread((ThreadStart)delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							new BackgroundTask(delegate
							{
								Init();
							}, typeof(ElmaApiInitializerService), (string)Ne0SfYVmUgj56fl5dDO(0x6DC147B0 ^ 0x6DC10918), (string)Ne0SfYVmUgj56fl5dDO(0x20261A4F ^ 0x202654E7)).Execute();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (zippedTree == null)
				{
					num2 = 2;
					break;
				}
				goto IL_005e;
			case 2:
				{
					if (initException == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_005e;
				}
				IL_005e:
				return true;
			}
		}
	}

	public virtual byte[] GetZippedApiTree()
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00c7
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw initException;
			case 4:
				Init();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				return zippedTree;
			case 1:
				if (zippedTree == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return zippedTree;
			default:
				if (initException == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	private void Init()
	{
		//Discarded unreachable code: IL_007f, IL_00b7, IL_00d9, IL_00e8, IL_0398, IL_03d9, IL_0411, IL_0451, IL_0460, IL_046c, IL_047b, IL_04ac, IL_04cb, IL_04da, IL_0507, IL_0699, IL_06bd, IL_06fd, IL_070c, IL_0718, IL_073d, IL_0774, IL_0783
		int num = 6;
		object obj = default(object);
		bool lockTaken = default(bool);
		string text = default(string);
		SHA1 sHA = default(SHA1);
		Assembly assembly = default(Assembly);
		byte[] buffer = default(byte[]);
		string bLOB = default(string);
		string path = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 4;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 6:
								if (initException == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num3 = 2;
									}
									break;
								}
								return;
							case 1:
							case 2:
							{
								int num13 = 3;
								num3 = num13;
								break;
							}
							case 5:
								return;
							case 4:
								if (zippedTree != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
									{
										num3 = 0;
									}
									break;
								}
								goto case 6;
							case 3:
								try
								{
									initializing = true;
									int num4 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
									{
										num4 = 9;
									}
									while (true)
									{
										switch (num4)
										{
										case 8:
											text = null;
											num4 = 15;
											break;
										case 14:
											((IBLOBDataManager)fkU1lqVYWqy76O84usJ()).SetBLOB(moduleUid, (string)Ne0SfYVmUgj56fl5dDO(0x12A5FAC7 ^ 0x12A5B7E9), text);
											num4 = 5;
											break;
										case 18:
											sHA = (SHA1)J9mTsuVJT5nPkQwB6da();
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
											{
												num4 = 2;
											}
											break;
										case 16:
											if (assembly == null)
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
												{
													num4 = 1;
												}
											}
											else
											{
												buffer = ClassSerializationHelper.SerializeObjectByXmlToBytes(ss9QCxV5c4CMWo6YYc0(assembly));
												num4 = 6;
											}
											break;
										case 11:
											if (text != null)
											{
												num4 = 17;
												break;
											}
											goto case 4;
										case 17:
											if (bLOB != null)
											{
												num4 = 10;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
												{
													num4 = 7;
												}
												break;
											}
											goto case 4;
										case 10:
											if (wZyTv5VrBSa9k1uvbRH(bLOB, text))
											{
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
												{
													num4 = 0;
												}
												break;
											}
											goto case 4;
										case 7:
											assembly = (Assembly)hEc8wKVgqQvmrtpUvJR(Ne0SfYVmUgj56fl5dDO(--1360331293 ^ 0x51150833));
											num4 = 16;
											break;
										case 9:
											bLOB = DataAccessManager.BLOBManager.GetBLOB<string>(moduleUid, (string)Ne0SfYVmUgj56fl5dDO(-1876063057 ^ -1876049535));
											num4 = 8;
											break;
										default:
										{
											zippedTree = DataAccessManager.BLOBManager.GetBLOB<byte[]>(moduleUid, (string)Ne0SfYVmUgj56fl5dDO(0x307E9FD1 ^ 0x307ED26F));
											int num9 = 4;
											num4 = num9;
											break;
										}
										case 15:
											path = (string)noLluXVMcxJNZty6yZD(noLluXVMcxJNZty6yZD(((ComponentManager)julgr2VyMXOmLtUeIWJ()).WorkDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DBC91)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70022515));
											num4 = 12;
											break;
										case 13:
											if (!Xp6imhVj6BTKdEQOi7F(text))
											{
												num4 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
												{
													num4 = 2;
												}
												break;
											}
											return;
										case 12:
											if (File.Exists(path))
											{
												num4 = 18;
												break;
											}
											goto case 11;
										case 3:
											try
											{
												FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
												int num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
												{
													num5 = 0;
												}
												switch (num5)
												{
												default:
													try
													{
														text = (string)FTHmQCVdpdAAXNhPYxT(HmQ6N2V9qaxFI81fl2v(sHA, fileStream));
														int num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
														{
															num6 = 0;
														}
														switch (num6)
														{
														case 0:
															break;
														}
													}
													finally
													{
														int num7;
														if (fileStream == null)
														{
															num7 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
															{
																num7 = 0;
															}
															goto IL_0415;
														}
														goto IL_042b;
														IL_042b:
														JQf7p9VlOfP5QbSLyS8(fileStream);
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
														{
															num7 = 2;
														}
														goto IL_0415;
														IL_0415:
														switch (num7)
														{
														default:
															goto end_IL_03f0;
														case 1:
															break;
														case 0:
															goto end_IL_03f0;
														case 2:
															goto end_IL_03f0;
														}
														goto IL_042b;
														end_IL_03f0:;
													}
													break;
												case 1:
													break;
												}
											}
											finally
											{
												int num8;
												if (sHA == null)
												{
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
													{
														num8 = 0;
													}
													goto IL_04b0;
												}
												goto IL_04e5;
												IL_04e5:
												JQf7p9VlOfP5QbSLyS8(sHA);
												num8 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
												{
													num8 = 1;
												}
												goto IL_04b0;
												IL_04b0:
												switch (num8)
												{
												default:
													goto end_IL_048b;
												case 0:
													goto end_IL_048b;
												case 2:
													break;
												case 1:
													goto end_IL_048b;
												}
												goto IL_04e5;
												end_IL_048b:;
											}
											goto case 11;
										case 2:
											((IBLOBDataManager)fkU1lqVYWqy76O84usJ()).SetBLOB(moduleUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309655038), zippedTree);
											num4 = 14;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
											{
												num4 = 3;
											}
											break;
										case 1:
											throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886633877), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBBF10)));
										case 4:
											if (zippedTree == null)
											{
												num4 = 7;
												break;
											}
											return;
										case 6:
											zippedTree = buffer.Zip();
											num4 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
											{
												num4 = 13;
											}
											break;
										case 5:
											return;
										}
									}
								}
								catch (Exception ex)
								{
									int num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num10 = 0;
									}
									while (true)
									{
										switch (num10)
										{
										default:
										{
											bqUhmwVUfyGj7ogpeM5(pIEGX7VL7bDtqAwPDf3(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCF418), ex);
											int num11 = 2;
											num10 = num11;
											break;
										}
										case 2:
											initException = ex;
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
											{
												num10 = 1;
											}
											break;
										case 1:
											return;
										}
									}
								}
								finally
								{
									initializing = false;
									int num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num12 = 0;
									}
									switch (num12)
									{
									case 0:
										break;
									}
								}
							}
						}
					}
					finally
					{
						int num14;
						if (!lockTaken)
						{
							num14 = 2;
							goto IL_06c1;
						}
						goto IL_06d7;
						IL_06c1:
						switch (num14)
						{
						case 2:
							goto end_IL_06ac;
						case 1:
							goto end_IL_06ac;
						}
						goto IL_06d7;
						IL_06d7:
						OiltYkVsCw2B6I5gkEU(obj);
						num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num14 = 1;
						}
						goto IL_06c1;
						end_IL_06ac:;
					}
				case 4:
					goto end_IL_0012;
				case 3:
					return;
				case 6:
					if (zippedTree != null)
					{
						num2 = 5;
						continue;
					}
					break;
				case 2:
					return;
				case 5:
					return;
				default:
					obj = initApiTreeLockObj;
					num2 = 4;
					continue;
				case 1:
					break;
				}
				if (initException != null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			lockTaken = false;
			num = 7;
		}
	}

	public ElmaApiInitializerService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		z6VuxBVcEvxJFjMft3T();
		initApiTreeLockObj = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ElmaApiInitializerService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				moduleUid = new Guid((string)Ne0SfYVmUgj56fl5dDO(0x20261A4F ^ 0x20265413));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool FTCNcNVxXIEojJSToTw()
	{
		return DWqw0xV7X9Km4mg9cdR == null;
	}

	internal static ElmaApiInitializerService JRq5TXV0aNtkM53amQM()
	{
		return DWqw0xV7X9Km4mg9cdR;
	}

	internal static object Ne0SfYVmUgj56fl5dDO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object julgr2VyMXOmLtUeIWJ()
	{
		return ComponentManager.Current;
	}

	internal static object noLluXVMcxJNZty6yZD(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object J9mTsuVJT5nPkQwB6da()
	{
		return SHA1.Create();
	}

	internal static object HmQ6N2V9qaxFI81fl2v(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static object FTHmQCVdpdAAXNhPYxT(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static void JQf7p9VlOfP5QbSLyS8(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool wZyTv5VrBSa9k1uvbRH(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object hEc8wKVgqQvmrtpUvJR(object P_0)
	{
		return Assembly.Load((string)P_0);
	}

	internal static object ss9QCxV5c4CMWo6YYc0(object P_0)
	{
		return DynamicAssemblyResolver.GetElmaApiFullTree((Assembly)P_0);
	}

	internal static bool Xp6imhVj6BTKdEQOi7F(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object fkU1lqVYWqy76O84usJ()
	{
		return DataAccessManager.BLOBManager;
	}

	internal static object pIEGX7VL7bDtqAwPDf3()
	{
		return Logger.Log;
	}

	internal static void bqUhmwVUfyGj7ogpeM5(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void OiltYkVsCw2B6I5gkEU(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void z6VuxBVcEvxJFjMft3T()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
