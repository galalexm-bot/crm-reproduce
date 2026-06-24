using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Logs.Appenders;

internal sealed class DiagnosticsActiveSessionAppender : IAppender, IOptionHandler
{
	private Task workerTask;

	private static BlockingCollection<DiagnosticsEvent> eventQueue;

	private static string sessionDirectory;

	private static readonly Type[] StartEventTypes;

	private static readonly Type IgnoredEventType;

	private static readonly Type[] EndEventTypes;

	private static DiagnosticsActiveSessionAppender wUCSNAESFGkY4BInsxrT;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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

	public void Close()
	{
		//Discarded unreachable code: IL_005e
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				workerTask.Wait();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 2:
				PBkf7UESbCkXYGhlkqUr(workerTask);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				Y8Mk9AESogCT6bVM0JWG(eventQueue);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 4:
				if (eventQueue == null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			}
		}
	}

	public void DoAppend(LoggingEvent loggingEvent)
	{
		//Discarded unreachable code: IL_010f, IL_011e, IL_012d
		int num = 5;
		int num2 = num;
		DiagnosticsEvent diagnosticsEvent = default(DiagnosticsEvent);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 7:
				return;
			default:
				if (!eventQueue.TryAdd(diagnosticsEvent))
				{
					num2 = 2;
					continue;
				}
				return;
			case 2:
				CqiHnpESf498DKNdXGZa(YK8qe0ESGmcf2BfxN2mE(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108403868), BHQmymESEUX8Uq53xpLI(diagnosticsEvent)));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 6;
				}
				continue;
			case 5:
				diagnosticsEvent = rdCVw0EShElBmTB0fiGB(loggingEvent) as DiagnosticsEvent;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				if (diagnosticsEvent == null)
				{
					num2 = 7;
					continue;
				}
				break;
			case 3:
				break;
			case 6:
				return;
			}
			if (IgnoredEventType.IsInstanceOfType(diagnosticsEvent))
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
			{
				num2 = 0;
			}
		}
	}

	public void ActivateOptions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				sessionDirectory = (string)nNue31ESQFDpX65tvQJ3(Directory);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				workerTask = ((TaskFactory)vBXLfIESCfDquBbGhpYJ()).StartNew((Action)EventQueueWoker, TaskCreationOptions.LongRunning);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				eventQueue = new BlockingCollection<DiagnosticsEvent>();
				num2 = 3;
				break;
			case 0:
				return;
			}
		}
	}

	private static void EventQueueWoker()
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_0078, IL_010a, IL_0167, IL_01c3, IL_01d2, IL_021f, IL_0232, IL_028b, IL_02a7, IL_02b6, IL_02c1, IL_0360, IL_0459, IL_05f0, IL_0610, IL_06f0, IL_0725, IL_0755, IL_0810, IL_0850, IL_085f, IL_086b, IL_087a, IL_08a6, IL_091e, IL_095e, IL_096d, IL_0979
		int num = 2;
		int num2 = num;
		Dictionary<long, FileStream>.Enumerator enumerator = default(Dictionary<long, FileStream>.Enumerator);
		KeyValuePair<long, FileStream> current = default(KeyValuePair<long, FileStream>);
		BlockingCollection<DiagnosticsEvent> blockingCollection = default(BlockingCollection<DiagnosticsEvent>);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		string text2 = default(string);
		FileStream fileStream = default(FileStream);
		Dictionary<long, FileStream> dictionary = default(Dictionary<long, FileStream>);
		FileStream value2 = default(FileStream);
		FileStream value = default(FileStream);
		string text = default(string);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				eventQueue = null;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num3 = 3;
							}
							goto IL_007c;
						}
						goto IL_00c0;
						IL_00c0:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num3 = 0;
						}
						goto IL_007c;
						IL_007c:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 1:
								goto IL_00c0;
							case 4:
								try
								{
									current.Value.Close();
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											cmAiMbESkAJ2c9t0un5a(current.Value);
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								catch (Exception exception)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											((ILogger)YK8qe0ESGmcf2BfxN2mE()).Error(T5WBJVES3vY0b7553YfR(BtaSqDESVCGSIespQv1J(-1426094279 ^ -1426336481)), exception);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
											{
												num5 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								break;
							default:
								if (current.Value != null)
								{
									num3 = 4;
									continue;
								}
								break;
							case 3:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			case 1:
				blockingCollection = eventQueue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				try
				{
					IEnumerator<DiagnosticsEvent> enumerator2 = eventQueue.GetConsumingEnumerable().GetEnumerator();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					default:
						try
						{
							while (true)
							{
								int num8;
								if (!EKddO3ES1jOeNXbsdNj7(enumerator2))
								{
									num8 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num8 = 1;
									}
									goto IL_02c5;
								}
								goto IL_072f;
								IL_072f:
								_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num8 = 1;
								}
								goto IL_02c5;
								IL_02c5:
								while (true)
								{
									object obj;
									switch (num8)
									{
									case 3:
										diagnosticsCallInfoEvent = _003C_003Ec__DisplayClass12_.@event as IDiagnosticsCallInfoEvent;
										num8 = 19;
										continue;
									case 24:
										MemoryHelper.ActionWithMemoryBuffer<byte, (FileStream, string)>(((Encoding)cYQ4K1ESKjaVRgiWiZfj()).GetByteCount(text2), (fileStream, text2), WriteFileAction);
										num8 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
										{
											num8 = 9;
										}
										continue;
									case 15:
									case 32:
										if (!dictionary.TryGetValue(_003C_003Ec__DisplayClass12_.@event.CallContextInfoId, out value2))
										{
											num8 = 16;
											continue;
										}
										goto case 6;
									case 12:
										if (value != null)
										{
											num8 = 14;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
											{
												num8 = 34;
											}
											continue;
										}
										break;
									case 27:
										text2 = (string)Grwi3hESqKTsNPl0BN8u(BHQmymESEUX8Uq53xpLI(_003C_003Ec__DisplayClass12_.@event), Environment.NewLine);
										num8 = 24;
										continue;
									case 11:
									case 16:
									case 20:
									case 21:
									case 22:
										break;
									case 25:
										obj = "";
										goto IL_07ce;
									case 33:
										text = (string)nKc9qlESPbwkw5DvBsLM(text, BHQmymESEUX8Uq53xpLI(_003C_003Ec__DisplayClass12_.@event), Environment.NewLine);
										num8 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
										{
											num8 = 14;
										}
										continue;
									case 7:
										if (!LjIq39ESnFw7iSIw2ABe(name))
										{
											num8 = 13;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
											{
												num8 = 21;
											}
											continue;
										}
										goto case 4;
									case 29:
										if (dictionary.TryGetValue(CRrimEESS2acMmvZnSLk(_003C_003Ec__DisplayClass12_.@event), out value))
										{
											num8 = 12;
											continue;
										}
										break;
									case 28:
										dictionary.Add(CRrimEESS2acMmvZnSLk(_003C_003Ec__DisplayClass12_.@event), fileStream);
										num8 = 18;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num8 = 27;
										}
										continue;
									case 1:
										_003C_003Ec__DisplayClass12_.@event = enumerator2.Current;
										num8 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
										{
											num8 = 13;
										}
										continue;
									case 6:
										if (value2 != null)
										{
											num8 = 3;
											continue;
										}
										break;
									case 31:
										cmAiMbESkAJ2c9t0un5a(value);
										num8 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
										{
											num8 = 2;
										}
										continue;
									case 8:
										tRMUTHES8GdBU8lX3KLy(sessionDirectory);
										num8 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
										{
											num8 = 5;
										}
										continue;
									case 10:
										dictionary.Remove(CRrimEESS2acMmvZnSLk(_003C_003Ec__DisplayClass12_.@event));
										num8 = 30;
										continue;
									case 34:
										name = value.Name;
										num8 = 10;
										continue;
									case 23:
										MemoryHelper.ActionWithMemoryBuffer<byte, (FileStream, string)>(((Encoding)cYQ4K1ESKjaVRgiWiZfj()).GetByteCount(text), (value2, text), WriteFileAction);
										num8 = 18;
										continue;
									case 4:
										To2xpJESODNe1xmsqj9l(name);
										num8 = 20;
										continue;
									case 14:
										if (!StartEventTypes.Any(_003C_003Ec__DisplayClass12_._003CEventQueueWoker_003Eb__0))
										{
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num8 = 0;
											}
											continue;
										}
										goto case 17;
									case 5:
										fileStream = new FileStream((string)EmLiUcESR4fhjeIXIkdU(sessionDirectory, nRUQXFESiAWuURCR0hsM(new object[4]
										{
											sVYPngESu3fOHYcla9fy(C5s5wAESZN5HUsDCZtcC(_003C_003Ec__DisplayClass12_.@event)),
											wJUCtWESI0pt0YWtnFNN().ToString((string)BtaSqDESVCGSIespQv1J(-105199646 ^ -104950272)),
											CRrimEESS2acMmvZnSLk(_003C_003Ec__DisplayClass12_.@event),
											BtaSqDESVCGSIespQv1J(-195614443 ^ -195855601)
										})), FileMode.Append, FileAccess.Write);
										num8 = 28;
										continue;
									case 18:
										FnTGmaESX83YqN40ZWY9(value2);
										num8 = 11;
										continue;
									default:
										if (!EndEventTypes.Any(_003C_003Ec__DisplayClass12_._003CEventQueueWoker_003Eb__1))
										{
											num8 = 32;
											continue;
										}
										goto case 29;
									case 26:
										goto IL_072f;
									case 9:
										FnTGmaESX83YqN40ZWY9(fileStream);
										num8 = 22;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num8 = 10;
										}
										continue;
									case 17:
										if (!HQOiddESvbhgKJIfb4DC(sessionDirectory))
										{
											num8 = 8;
											continue;
										}
										goto case 5;
									case 30:
										Ok8Qp9ESTtx9AGhGNxdp(value);
										num8 = 31;
										continue;
									case 19:
										if (diagnosticsCallInfoEvent == null)
										{
											num8 = 25;
											continue;
										}
										obj = new string(' ', R0mCMUESe7kaM1AYI7b7(QiLKEtES2BJloX1EAGy2(diagnosticsCallInfoEvent)));
										goto IL_07ce;
									case 2:
										goto end_IL_0429;
										IL_07ce:
										text = (string)obj;
										num8 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
										{
											num8 = 33;
										}
										continue;
									}
									break;
								}
								continue;
								end_IL_0429:
								break;
							}
						}
						finally
						{
							int num9;
							if (enumerator2 == null)
							{
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
								{
									num9 = 0;
								}
								goto IL_0814;
							}
							goto IL_082a;
							IL_082a:
							O0dFY5ESNwaMMZml0Ocf(enumerator2);
							num9 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num9 = 2;
							}
							goto IL_0814;
							IL_0814:
							switch (num9)
							{
							default:
								goto end_IL_07ef;
							case 1:
								break;
							case 0:
								goto end_IL_07ef;
							case 2:
								goto end_IL_07ef;
							}
							goto IL_082a;
							end_IL_07ef:;
						}
						break;
					case 1:
						break;
					}
				}
				catch (Exception exception2)
				{
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num10 = 0;
					}
					while (true)
					{
						switch (num10)
						{
						default:
							((ILogger)YK8qe0ESGmcf2BfxN2mE()).Error(T5WBJVES3vY0b7553YfR(BtaSqDESVCGSIespQv1J(-1767720453 ^ -1767445539)), exception2);
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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
				finally
				{
					int num11;
					if (blockingCollection == null)
					{
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num11 = 0;
						}
						goto IL_0922;
					}
					goto IL_0938;
					IL_0938:
					O0dFY5ESNwaMMZml0Ocf(blockingCollection);
					num11 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num11 = 1;
					}
					goto IL_0922;
					IL_0922:
					switch (num11)
					{
					default:
						goto end_IL_08fd;
					case 2:
						break;
					case 0:
						goto end_IL_08fd;
					case 1:
						goto end_IL_08fd;
					}
					goto IL_0938;
					end_IL_08fd:;
				}
				goto case 5;
			case 2:
				dictionary = new Dictionary<long, FileStream>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				enumerator = dictionary.GetEnumerator();
				num2 = 6;
				break;
			}
		}
	}

	private static void WriteFileAction(object buffer, int offset, int length, (FileStream, string) param)
	{
		var (fileStream, text) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		fileStream.Write((byte[])buffer, offset, length);
	}

	private static int CallInfoDepth(object callInfo)
	{
		//Discarded unreachable code: IL_0039
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				if (jBB7QfESplg1frjaVmcI(callInfo) == null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 4:
				num3++;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return num3;
			case 5:
				callInfo = jBB7QfESplg1frjaVmcI(callInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DiagnosticsActiveSessionAppender()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DiagnosticsActiveSessionAppender()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				IgnoredEventType = TypeOf<WebRequestAuthorizedEvent>.Raw;
				num2 = 4;
				break;
			case 1:
				xNKRyAESakfs5cfsUCc1();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			default:
				StartEventTypes = new Type[2]
				{
					TypeOf<BackgroundThreadStartEvent>.Raw,
					TypeOf<WebRequestStartEvent>.Raw
				};
				num2 = 3;
				break;
			case 4:
				EndEventTypes = new Type[4]
				{
					TypeOf<BackgroundThreadEndEvent>.Raw,
					TypeOf<BackgroundThreadErrorEvent>.Raw,
					TypeOf<WebRequestEndEvent>.Raw,
					TypeOf<WebRequestErrorEvent>.Raw
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool LTo8MdESBx1ID2JC50m6()
	{
		return wUCSNAESFGkY4BInsxrT == null;
	}

	internal static DiagnosticsActiveSessionAppender o2KIIwESWsiOsfnmQJ7w()
	{
		return wUCSNAESFGkY4BInsxrT;
	}

	internal static void Y8Mk9AESogCT6bVM0JWG(object P_0)
	{
		((BlockingCollection<DiagnosticsEvent>)P_0).CompleteAdding();
	}

	internal static void PBkf7UESbCkXYGhlkqUr(object P_0)
	{
		((Task)P_0).Dispose();
	}

	internal static object rdCVw0EShElBmTB0fiGB(object P_0)
	{
		return ((LoggingEvent)P_0).get_MessageObject();
	}

	internal static object YK8qe0ESGmcf2BfxN2mE()
	{
		return Logger.Log;
	}

	internal static object BHQmymESEUX8Uq53xpLI(object P_0)
	{
		return ((DiagnosticsEvent)P_0).Message;
	}

	internal static void CqiHnpESf498DKNdXGZa(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object nNue31ESQFDpX65tvQJ3(object P_0)
	{
		return SystemInfo.ConvertToFullPath((string)P_0);
	}

	internal static object vBXLfIESCfDquBbGhpYJ()
	{
		return Task.Factory;
	}

	internal static bool HQOiddESvbhgKJIfb4DC(object P_0)
	{
		return System.IO.Directory.Exists((string)P_0);
	}

	internal static object tRMUTHES8GdBU8lX3KLy(object P_0)
	{
		return System.IO.Directory.CreateDirectory((string)P_0);
	}

	internal static object C5s5wAESZN5HUsDCZtcC(object P_0)
	{
		return ((DiagnosticsEvent)P_0).CallContextInfo;
	}

	internal static object sVYPngESu3fOHYcla9fy(object P_0)
	{
		return ((CallContextInfo)P_0).ServerHostName;
	}

	internal static DateTime wJUCtWESI0pt0YWtnFNN()
	{
		return DateTime.Now;
	}

	internal static object BtaSqDESVCGSIespQv1J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long CRrimEESS2acMmvZnSLk(object P_0)
	{
		return ((DiagnosticsEvent)P_0).CallContextInfoId;
	}

	internal static object nRUQXFESiAWuURCR0hsM(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object EmLiUcESR4fhjeIXIkdU(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object Grwi3hESqKTsNPl0BN8u(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object cYQ4K1ESKjaVRgiWiZfj()
	{
		return Encoding.UTF8;
	}

	internal static void FnTGmaESX83YqN40ZWY9(object P_0)
	{
		((Stream)P_0).Flush();
	}

	internal static void Ok8Qp9ESTtx9AGhGNxdp(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void cmAiMbESkAJ2c9t0un5a(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static bool LjIq39ESnFw7iSIw2ABe(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void To2xpJESODNe1xmsqj9l(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object QiLKEtES2BJloX1EAGy2(object P_0)
	{
		return ((IDiagnosticsCallInfoEvent)P_0).Info;
	}

	internal static int R0mCMUESe7kaM1AYI7b7(object P_0)
	{
		return CallInfoDepth(P_0);
	}

	internal static object nKc9qlESPbwkw5DvBsLM(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool EKddO3ES1jOeNXbsdNj7(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void O0dFY5ESNwaMMZml0Ocf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object T5WBJVES3vY0b7553YfR(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object jBB7QfESplg1frjaVmcI(object P_0)
	{
		return ((AbstractCallInfo)P_0).ParentCall;
	}

	internal static void xNKRyAESakfs5cfsUCc1()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
