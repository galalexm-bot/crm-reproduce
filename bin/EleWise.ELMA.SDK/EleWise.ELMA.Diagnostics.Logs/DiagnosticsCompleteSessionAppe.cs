using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Diagnostics.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Serialization;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Logs.Appenders;

internal sealed class DiagnosticsCompleteSessionAppender : IAppender
{
	private readonly object lockObject;

	private long nextClear;

	private List<CallContextInfo> contextInfo;

	private static readonly Type[] SupportedEventTypes;

	private static DiagnosticsCompleteSessionAppender wA8DLgESDktciDGer4KA;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	public string Directory
	{
		[CompilerGenerated]
		get
		{
			return _003CDirectory_003Ek__BackingField;
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
					_003CDirectory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
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

	public int ClearOlderHours
	{
		[CompilerGenerated]
		get
		{
			return _003CClearOlderHours_003Ek__BackingField;
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
					_003CClearOlderHours_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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

	public long QueueSize
	{
		[CompilerGenerated]
		get
		{
			return _003CQueueSize_003Ek__BackingField;
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
					_003CQueueSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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

	public DiagnosticsCompleteSessionAppender()
	{
		//Discarded unreachable code: IL_005e, IL_0063
		POTTO9ES4W1N3E3Jh6cH();
		lockObject = new object();
		nextClear = long.MinValue;
		contextInfo = new List<CallContextInfo>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
				ClearOlderHours = 0;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Close()
	{
		//Discarded unreachable code: IL_0041, IL_00ca, IL_00d9, IL_010a, IL_0129, IL_0138, IL_0155, IL_0164
		int num = 3;
		int num2 = num;
		object obj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 4:
							return;
						case 2:
							if (Uy6Bs5ES6pnSu9DGIxWm(contextInfo) <= 0)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num3 = 1;
								}
								break;
							}
							goto default;
						default:
							hHB3H7ESHj97PE0MPCMS(new WaitCallback(InternalSave), contextInfo);
							num3 = 3;
							break;
						case 3:
							contextInfo = new List<CallContextInfo>();
							num3 = 4;
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num4 = 1;
						}
						goto IL_010e;
					}
					goto IL_0143;
					IL_0143:
					UGYSfvESAVExIQ1VPsGF(obj);
					num4 = 2;
					goto IL_010e;
					IL_010e:
					switch (num4)
					{
					case 1:
						goto end_IL_00e9;
					case 2:
						goto end_IL_00e9;
					}
					goto IL_0143;
					end_IL_00e9:;
				}
			case 3:
				obj = lockObject;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void DoAppend(LoggingEvent loggingEvent)
	{
		//Discarded unreachable code: IL_00a3, IL_0194, IL_01d4, IL_01e3, IL_01ef, IL_025d, IL_026c, IL_0291
		int num = 7;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		object obj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
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
					if (SupportedEventTypes.Any(_003C_003Ec__DisplayClass18_._003CDoAppend_003Eb__0))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 8:
					return;
				case 2:
					obj = lockObject;
					num2 = 9;
					continue;
				case 4:
					return;
				case 5:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							default:
								hHB3H7ESHj97PE0MPCMS(new WaitCallback(InternalSave), contextInfo);
								num3 = 4;
								break;
							case 3:
								contextInfo.Add((CallContextInfo)dMomgtESxp2se9N6eX2H(_003C_003Ec__DisplayClass18_.@event));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 1;
								}
								break;
							case 1:
								if (Uy6Bs5ES6pnSu9DGIxWm(contextInfo) < QueueSize)
								{
									return;
								}
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num3 = 0;
								}
								break;
							case 4:
								contextInfo = new List<CallContextInfo>();
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					finally
					{
						int num4;
						if (!lockTaken)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num4 = 0;
							}
							goto IL_0198;
						}
						goto IL_01ae;
						IL_01ae:
						UGYSfvESAVExIQ1VPsGF(obj);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num4 = 1;
						}
						goto IL_0198;
						IL_0198:
						switch (num4)
						{
						default:
							goto end_IL_0173;
						case 2:
							break;
						case 0:
							goto end_IL_0173;
						case 1:
							goto end_IL_0173;
						}
						goto IL_01ae;
						end_IL_0173:;
					}
				case 6:
					_003C_003Ec__DisplayClass18_.@event = efQJBZES7DC1tB07E8yN(loggingEvent) as DiagnosticsEvent;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (_003C_003Ec__DisplayClass18_.@event == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					lockTaken = false;
					num2 = 5;
					continue;
				case 7:
					break;
				}
				break;
			}
			_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
			num = 6;
		}
	}

	private void InternalSave(object infoData)
	{
		//Discarded unreachable code: IL_00df, IL_020a, IL_0229, IL_0238, IL_025a, IL_0269, IL_029a, IL_02d2, IL_02e1, IL_058a, IL_05e6, IL_05f5, IL_0605, IL_0614
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		IEnumerable<CallContextInfo> enumerable = default(IEnumerable<CallContextInfo>);
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_1);
		DateTime dateTime = default(DateTime);
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0;
		FileStream fileStream = default(FileStream);
		long num5 = default(long);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (enumerable != null)
				{
					num2 = 4;
					break;
				}
				return;
			case 5:
				try
				{
					string text = (string)icGbpcES0TgBVgRMCS7h(Directory);
					int num3 = 3;
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 12:
							_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_1();
							num3 = 9;
							break;
						case 7:
							dateTime = minE3LES9WrRkoBdC1NF();
							num3 = 15;
							break;
						case 1:
							try
							{
								CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
								int num6 = 3;
								while (true)
								{
									switch (num6)
									{
									case 2:
										CS_0024_003C_003E8__locals0.zipStream = new ZipOutputStream((Stream)fileStream);
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
										{
											num6 = 0;
										}
										continue;
									case 3:
										CS_0024_003C_003E8__locals0._003C_003E4__this = this;
										num6 = 2;
										continue;
									default:
										try
										{
											CS_0024_003C_003E8__locals0.zipStream.SetLevel(5);
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												int num8;
												switch (num7)
												{
												default:
													enumerable.ForEach(delegate(CallContextInfo a)
													{
														//IL_0050: Unknown result type (might be due to invalid IL or missing references)
														//IL_0055: Unknown result type (might be due to invalid IL or missing references)
														//IL_0060: Expected O, but got Unknown
														//IL_0062: Expected O, but got Unknown
														int num12 = 4;
														int num13 = num12;
														ZipEntry val2 = default(ZipEntry);
														string text3 = default(string);
														while (true)
														{
															switch (num13)
															{
															default:
																return;
															case 4:
															{
																ZipEntry val = new ZipEntry((string)_003C_003Ec__DisplayClass19_0.hkPd7D8KgvcyUKYmdNL2(_003C_003Ec__DisplayClass19_0.e00x3Y8KrYaiUDWs9TKC(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE493F1)));
																_003C_003Ec__DisplayClass19_0.dhXsvE8K58bOMgBm9NP3((object)val, DateTime.Now);
																val2 = val;
																num13 = 3;
																break;
															}
															case 1:
																MemoryHelper.ActionWithMemoryBuffer<byte, (ZipOutputStream, string)>(Encoding.UTF8.GetByteCount(text3), (CS_0024_003C_003E8__locals0.zipStream, text3), CS_0024_003C_003E8__locals0._003C_003E4__this.InternalSaveWriteZipStream);
																num13 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
																{
																	num13 = 0;
																}
																break;
															case 3:
																CS_0024_003C_003E8__locals0.zipStream.PutNextEntry(val2);
																num13 = 2;
																break;
															case 2:
																text3 = ClassSerializationHelper.SerializeObjectByJsonNet(a, (IEnumerable<JsonConverter>)(object)new DiagnosticsMethodInfoConverter[1] { DiagnosticsMethodInfoConverter.Instance });
																num13 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
																{
																	num13 = 1;
																}
																break;
															case 0:
																return;
															}
														}
													});
													num8 = 3;
													goto IL_015f;
												case 3:
													GoC2a4ESgceir8Tk1Uox(CS_0024_003C_003E8__locals0.zipStream);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
													{
														num7 = 1;
													}
													continue;
												case 1:
													dEIHFBES5OTIk2L4kUu4(CS_0024_003C_003E8__locals0.zipStream);
													num8 = 2;
													goto IL_015f;
												case 2:
													break;
													IL_015f:
													num7 = num8;
													continue;
												}
												break;
											}
										}
										finally
										{
											int num9;
											if (CS_0024_003C_003E8__locals0.zipStream == null)
											{
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
												{
													num9 = 0;
												}
												goto IL_020e;
											}
											goto IL_0243;
											IL_0243:
											sTtEa4ESjSXKYJTNCyrY(CS_0024_003C_003E8__locals0.zipStream);
											num9 = 2;
											goto IL_020e;
											IL_020e:
											switch (num9)
											{
											default:
												goto end_IL_01e4;
											case 0:
												goto end_IL_01e4;
											case 1:
												break;
											case 2:
												goto end_IL_01e4;
											}
											goto IL_0243;
											end_IL_01e4:;
										}
										break;
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								if (fileStream != null)
								{
									int num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
									{
										num10 = 1;
									}
									while (true)
									{
										switch (num10)
										{
										case 1:
											sTtEa4ESjSXKYJTNCyrY(fileStream);
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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
							goto case 13;
						case 15:
							if (dateTime.Ticks >= num5)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num3 = 0;
								}
								break;
							}
							return;
						case 2:
							File.Delete(text2);
							num3 = 11;
							break;
						case 14:
						{
							string[] obj = new string[5]
							{
								(string)V8jcLvESMh9liOgDrBId(0x3C5338FF ^ 0x3C576A83),
								(string)mxcT8qESJyAuW8yPuFGF(),
								z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876066091),
								null,
								null
							};
							dateTime = minE3LES9WrRkoBdC1NF();
							obj[3] = (string)kR778bESd43VaJgEqFRP(dateTime.ToString((string)V8jcLvESMh9liOgDrBId(-1867198571 ^ -1867473609)), V8jcLvESMh9liOgDrBId(-1921202237 ^ -1921196793), V8jcLvESMh9liOgDrBId(0x7C1EE318 ^ 0x7C1EEF62));
							obj[4] = (string)V8jcLvESMh9liOgDrBId(-420743386 ^ -420834234);
							text2 = (string)dRLSe2ESl92KJaBK584H(text, string.Concat(obj));
							num3 = 10;
							break;
						}
						case 6:
							vHNakTESy570IM0oKsCb(text);
							num4 = 14;
							goto IL_005d;
						case 3:
							if (!sL5bWPESmQdC8Y78GAOE(text))
							{
								num3 = 6;
								break;
							}
							goto case 14;
						default:
						{
							ref long location = ref nextClear;
							dateTime = minE3LES9WrRkoBdC1NF().AddMinutes(10.0);
							if (Interlocked.Exchange(ref location, dateTime.Ticks) == num5)
							{
								num3 = 8;
								break;
							}
							return;
						}
						case 11:
							fileStream = File.Create(text2);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num3 = 1;
							}
							break;
						case 9:
						{
							_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_2 = _003C_003Ec__DisplayClass19_;
							dateTime = minE3LES9WrRkoBdC1NF();
							_003C_003Ec__DisplayClass19_2.older = dateTime.AddHours(-ClearOlderHours);
							num4 = 4;
							goto IL_005d;
						}
						case 13:
							num5 = nextClear;
							num3 = 7;
							break;
						case 10:
							if (Lwr6bjESrQhFxXUX99tO(text2))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 11;
						case 8:
							if (ClearOlderHours > 0)
							{
								num3 = 12;
								break;
							}
							return;
						case 4:
							new DirectoryInfo(text).EnumerateFileSystemInfos((string)CkDXTwESYOdiw6gQ9kL7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234058388), mxcT8qESJyAuW8yPuFGF(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87095623)), SearchOption.TopDirectoryOnly).Where(_003C_003Ec__DisplayClass19_._003CInternalSave_003Eb__1).ForEach(delegate(FileSystemInfo f)
							{
								f.Delete();
							});
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num3 = 5;
							}
							break;
						case 5:
							return;
							IL_005d:
							num3 = num4;
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						case 1:
							return;
						}
						QUZ6SYESsY88qp23Jb21(i3WjyIESLJ14i9aw7wHf(), yVcrklESUfvWdRmKSI5J(V8jcLvESMh9liOgDrBId(-195614443 ^ -195855413)), ex);
						num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num11 = 1;
						}
					}
				}
			case 0:
				return;
			case 4:
				num2 = 5;
				break;
			case 3:
				return;
			case 2:
				enumerable = infoData as IEnumerable<CallContextInfo>;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void InternalSaveWriteZipStream(byte[] buffer, int offset, int length, (ZipOutputStream, string) param)
	{
		var (val, text) = param;
		Encoding.UTF8.GetBytes(text, offset, text.Length, buffer, offset);
		((Stream)(object)val).Write(buffer, offset, length);
	}

	static DiagnosticsCompleteSessionAppender()
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
				SupportedEventTypes = new Type[4]
				{
					TypeOf<BackgroundThreadEndEvent>.Raw,
					TypeOf<BackgroundThreadErrorEvent>.Raw,
					TypeOf<WebRequestEndEvent>.Raw,
					TypeOf<WebRequestErrorEvent>.Raw
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				POTTO9ES4W1N3E3Jh6cH();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void POTTO9ES4W1N3E3Jh6cH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool LL7q2BEStFrljn7fnu7I()
	{
		return wA8DLgESDktciDGer4KA == null;
	}

	internal static DiagnosticsCompleteSessionAppender wP20jwESwSlwiwcHU22q()
	{
		return wA8DLgESDktciDGer4KA;
	}

	internal static int Uy6Bs5ES6pnSu9DGIxWm(object P_0)
	{
		return ((List<CallContextInfo>)P_0).Count;
	}

	internal static bool hHB3H7ESHj97PE0MPCMS(object P_0, object P_1)
	{
		return ThreadPool.QueueUserWorkItem((WaitCallback)P_0, P_1);
	}

	internal static void UGYSfvESAVExIQ1VPsGF(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object efQJBZES7DC1tB07E8yN(object P_0)
	{
		return ((LoggingEvent)P_0).get_MessageObject();
	}

	internal static object dMomgtESxp2se9N6eX2H(object P_0)
	{
		return ((DiagnosticsEvent)P_0).CallContextInfo;
	}

	internal static object icGbpcES0TgBVgRMCS7h(object P_0)
	{
		return SystemInfo.ConvertToFullPath((string)P_0);
	}

	internal static bool sL5bWPESmQdC8Y78GAOE(object P_0)
	{
		return System.IO.Directory.Exists((string)P_0);
	}

	internal static object vHNakTESy570IM0oKsCb(object P_0)
	{
		return System.IO.Directory.CreateDirectory((string)P_0);
	}

	internal static object V8jcLvESMh9liOgDrBId(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object mxcT8qESJyAuW8yPuFGF()
	{
		return Environment.MachineName;
	}

	internal static DateTime minE3LES9WrRkoBdC1NF()
	{
		return DateTime.Now;
	}

	internal static object kR778bESd43VaJgEqFRP(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object dRLSe2ESl92KJaBK584H(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool Lwr6bjESrQhFxXUX99tO(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void GoC2a4ESgceir8Tk1Uox(object P_0)
	{
		((DeflaterOutputStream)P_0).Finish();
	}

	internal static void dEIHFBES5OTIk2L4kUu4(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void sTtEa4ESjSXKYJTNCyrY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object CkDXTwESYOdiw6gQ9kL7(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object i3WjyIESLJ14i9aw7wHf()
	{
		return Logger.Log;
	}

	internal static object yVcrklESUfvWdRmKSI5J(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void QUZ6SYESsY88qp23Jb21(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
