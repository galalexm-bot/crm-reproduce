using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public class NotificationActivity : NotificationBaseActivity
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object DrfejnvfCO41lZrbwuqJ;

		public Type ActivityType => JStcKHvfUowUyXb0l8pf(typeof(NotificationActivity).TypeHandle);

		public Type DiagramElementType => JStcKHvfUowUyXb0l8pf(typeof(NotificationElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			q1gUcHvfVKswthRGMBKq();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type JStcKHvfUowUyXb0l8pf(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void q1gUcHvfVKswthRGMBKq()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool lPq7LDvfMLnVnsQHXN0K()
		{
			return DrfejnvfCO41lZrbwuqJ == null;
		}

		internal static Info eu8JixvfkHAUvZn9LLuE()
		{
			return (Info)DrfejnvfCO41lZrbwuqJ;
		}
	}

	private static NotificationActivity wcNfS2ZXRBX2kwT26Q9B;

	protected override void ExecuteNotificationTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0177, IL_0187, IL_0232, IL_0241, IL_04ac, IL_052b, IL_053a, IL_05e9, IL_0629, IL_0638, IL_0644, IL_0674, IL_0683, IL_0694, IL_06e6, IL_0779, IL_0876, IL_0889, IL_08bf, IL_08ce, IL_08d9, IL_0a54, IL_0a73, IL_0a9f, IL_0aae
		int num = 15;
		List<IUser> list = default(List<IUser>);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		List<IUser> list3 = default(List<IUser>);
		MessageTemplate messageTemplate = default(MessageTemplate);
		IEnumerator<int> enumerator = default(IEnumerator<int>);
		int current3 = default(int);
		IMessage message3 = default(IMessage);
		NotificationElement.DataSource dataSource = default(NotificationElement.DataSource);
		List<BinaryFile> files = default(List<BinaryFile>);
		Dictionary<int, IMessage> dictionary = default(Dictionary<int, IMessage>);
		string text = default(string);
		List<IUser> list2 = default(List<IUser>);
		List<IUser>.Enumerator enumerator3 = default(List<IUser>.Enumerator);
		IUser current2 = default(IUser);
		DateTime? endReplacement = default(DateTime?);
		bool? duplicateMessage = default(bool?);
		DateTime today = default(DateTime);
		IEnumerator<IGrouping<int, IUser>> enumerator2 = default(IEnumerator<IGrouping<int, IUser>>);
		IGrouping<int, IUser> current = default(IGrouping<int, IUser>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 18:
					list = GetRecipients(workflowInstance).OfType<IUser>().Union(GetExecutor(context)).ToList();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					list3 = new List<IUser>();
					num = 9;
					break;
				case 10:
				case 19:
					ContinueOnDefaultConnector(context);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 13:
					if (!YT7hCjZXQXeSf7q28HZs(lUHIi7ZXTt7D5T6pCWIk(messageTemplate)))
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 8;
				case 3:
					return;
				case 11:
					workflowInstance = (IWorkflowInstance)XAeYsnZXpBFBjpOye6SN(this, context);
					num2 = 18;
					continue;
				case 2:
					if (!list.Any())
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 20;
				case 15:
					messageTemplate = (MessageTemplate)gXfqd8ZX38Pn56Zl1pS5(base.Element);
					num = 14;
					break;
				case 14:
					if (messageTemplate != null)
					{
						num2 = 13;
						continue;
					}
					goto case 8;
				case 17:
					try
					{
						while (true)
						{
							int num8;
							if (!enumerator.MoveNext())
							{
								num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
								{
									num8 = 1;
								}
								goto IL_0195;
							}
							goto IL_0513;
							IL_0513:
							current3 = enumerator.Current;
							num8 = 17;
							goto IL_0195;
							IL_0195:
							while (true)
							{
								object obj;
								switch (num8)
								{
								case 20:
									break;
								case 25:
									Ep9DkNZXiabS9glMr3Aa(message3, Generate((string)lUHIi7ZXTt7D5T6pCWIk(messageTemplate), dataSource, current3));
									num8 = 15;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
									{
										num8 = 16;
									}
									continue;
								case 24:
									hX0vyEZXAKKdDquONNuf(message3, null);
									num8 = 12;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
									{
										num8 = 12;
									}
									continue;
								case 18:
									files = GetFiles(workflowInstance);
									num8 = 2;
									continue;
								case 11:
									if (YT7hCjZXQXeSf7q28HZs(PDQMU1ZXeeUQ94JOvbBU(messageTemplate)))
									{
										num8 = 9;
										continue;
									}
									goto case 23;
								case 9:
								case 10:
									dictionary.Add(current3, message3);
									num8 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
									{
										num8 = 20;
									}
									continue;
								case 12:
									message3.ObjectUid = InterfaceActivator.UID<IWorkflowInstance>();
									num8 = 14;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
									{
										num8 = 13;
									}
									continue;
								case 19:
									if (!string.IsNullOrEmpty(text))
									{
										num8 = 8;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
										{
											num8 = 22;
										}
										continue;
									}
									goto case 11;
								case 17:
								{
									NotificationElement.DataSource obj2 = new NotificationElement.DataSource
									{
										Instance = workflowInstance
									};
									MnDSKyZXUTt5brhD4pRU(obj2, h5EjSIZXk4brI1i47oD0(workflowInstance));
									dataSource = obj2;
									num8 = 15;
									continue;
								}
								case 6:
									if (YT7hCjZXQXeSf7q28HZs(fTI2iDZXrNdNHDf7dZmB(messageTemplate)))
									{
										num8 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
										{
											num8 = 2;
										}
										continue;
									}
									goto default;
								case 16:
									if (!string.IsNullOrEmpty((string)TxVO6iZXI7chJi3mXdcK(messageTemplate)))
									{
										num8 = 8;
										continue;
									}
									goto case 6;
								case 15:
									message3 = (IMessage)LO2m53ZXVev58McHFU2Q(Locator.GetServiceNotNull<IMessageManager>());
									num8 = 24;
									continue;
								case 21:
									message3.FullMessageHtml = Generate((string)h9uNHdZXxVZ9gk2LCSeH(PDQMU1ZXeeUQ94JOvbBU(messageTemplate)), dataSource, current3, TemplateRenderMode.HTML);
									num8 = 10;
									continue;
								case 14:
									message3.ActionUid = vkOhEdZXGx9WgRpknKOO();
									num8 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
									{
										num8 = 7;
									}
									continue;
								case 5:
									AawGqWZXSwBGYFb2nhvG(message3, Generate((string)h9uNHdZXxVZ9gk2LCSeH(text), dataSource, current3, TemplateRenderMode.HTML));
									num8 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
									{
										num8 = 11;
									}
									continue;
								case 22:
									xpxsqyZXN65HPKG552G6(message3, Generate(text, dataSource, current3));
									num8 = 5;
									continue;
								case 23:
									RdXhpwZX1vqwmou0LwBC(message3, Generate((string)PDQMU1ZXeeUQ94JOvbBU(messageTemplate), dataSource, current3));
									num8 = 21;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
									{
										num8 = 4;
									}
									continue;
								default:
									obj = fTI2iDZXrNdNHDf7dZmB(messageTemplate);
									goto IL_05b7;
								case 7:
									oFSUTuZX7eMeY4MQddXb(message3, workflowInstance.Id.ToString(CultureInfo.InvariantCulture));
									num8 = 18;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
									{
										num8 = 3;
									}
									continue;
								case 3:
									O32yqEZXFCdidWm1WNMf(message3, SlcsptZXoekFHGmYyioD(base.Element));
									num8 = 25;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
									{
										num8 = 7;
									}
									continue;
								case 13:
									goto IL_0513;
								case 8:
									AraaGfZXaosje917XXhO(message3, Generate((string)TxVO6iZXI7chJi3mXdcK(messageTemplate), dataSource, current3));
									num8 = 6;
									continue;
								case 2:
								{
									SQOgJGZX24v0bFQ5wvnJ(message3, files.Select((BinaryFile f) => (string)_003C_003Ec.QyLaqavfiF3ZwJajWRix(f)).ToArray());
									int num9 = 3;
									num8 = num9;
									continue;
								}
								case 4:
									obj = PDQMU1ZXeeUQ94JOvbBU(messageTemplate);
									goto IL_05b7;
								case 1:
									goto end_IL_0207;
									IL_05b7:
									text = (string)obj;
									num8 = 19;
									continue;
								}
								break;
							}
							continue;
							end_IL_0207:
							break;
						}
					}
					finally
					{
						int num10;
						if (enumerator == null)
						{
							num10 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
							{
								num10 = 1;
							}
							goto IL_05ed;
						}
						goto IL_0603;
						IL_0603:
						enumerator.Dispose();
						num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
						{
							num10 = 0;
						}
						goto IL_05ed;
						IL_05ed:
						switch (num10)
						{
						default:
							goto end_IL_05c8;
						case 2:
							break;
						case 1:
							goto end_IL_05c8;
						case 0:
							goto end_IL_05c8;
						}
						goto IL_0603;
						end_IL_05c8:;
					}
					goto case 5;
				case 9:
					list2 = new List<IUser>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator3.MoveNext())
							{
								num5 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
								{
									num5 = 1;
								}
								goto IL_06a2;
							}
							goto IL_07f0;
							IL_07f0:
							current2 = enumerator3.Current;
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
							{
								num5 = 0;
							}
							goto IL_06a2;
							IL_06a2:
							while (true)
							{
								switch (num5)
								{
								case 8:
									endReplacement = current2.EndReplacement;
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									if (fB6I7RZXC7AqgbI4vECA(current2) != null)
									{
										num5 = 8;
										continue;
									}
									goto end_IL_06a2;
								case 6:
									list2.Add(current2);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
									{
										num5 = 4;
									}
									continue;
								case 5:
									if (!duplicateMessage.HasValue)
									{
										num5 = 2;
										continue;
									}
									if (duplicateMessage.GetValueOrDefault())
									{
										goto case 4;
									}
									goto case 2;
								case 10:
									break;
								case 11:
									duplicateMessage = current2.DuplicateMessage;
									num5 = 5;
									continue;
								case 9:
								case 12:
									goto end_IL_06a2;
								default:
									today = DateTime.Today;
									num5 = 10;
									continue;
								case 4:
									list3.Add((IUser)r4cY52ZXM1k1q7nJF4OH(current2));
									num5 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
									{
										num5 = 1;
									}
									continue;
								case 3:
									goto IL_07f0;
								case 2:
									num5 = 6;
									continue;
								case 7:
									goto end_IL_0791;
								}
								if (!endReplacement.HasValue)
								{
									num5 = 12;
									continue;
								}
								if (!(endReplacement.GetValueOrDefault() >= today))
								{
									break;
								}
								int num6 = 11;
								num5 = num6;
								continue;
								end_IL_06a2:
								break;
							}
							continue;
							end_IL_0791:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 16:
					list.AddRange(list3);
					num2 = 6;
					continue;
				case 1:
					enumerator3 = list.GetEnumerator();
					num2 = 12;
					continue;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!bh22uuZdJBpOomqFWdkc(enumerator2))
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
								{
									num3 = 0;
								}
								goto IL_08dd;
							}
							goto IL_091d;
							IL_091d:
							current = enumerator2.Current;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
							{
								num3 = 0;
							}
							goto IL_08dd;
							IL_08dd:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 3:
									goto IL_091d;
								default:
								{
									IMessageManager serviceNotNull = Locator.GetServiceNotNull<IMessageManager>();
									IMessage message = dictionary[current.Key];
									IMessage message2 = (IMessage)LO2m53ZXVev58McHFU2Q(serviceNotNull);
									message2.Author = null;
									message2.ObjectUid = message.ObjectUid;
									message2.ActionUid = message.ActionUid;
									oFSUTuZX7eMeY4MQddXb(message2, SeTKTGZXhC3l4D6FwWNH(message));
									SQOgJGZX24v0bFQ5wvnJ(message2, SRW49hZXEkyDUSmEILZt(message));
									O32yqEZXFCdidWm1WNMf(message2, VpTYMKZXwe5D5jTLwxmv(message));
									message2.Subject = (string)cDfLg9ZX4jE10b2p6Qh0(message);
									AraaGfZXaosje917XXhO(message2, xFAx0TZXzLsdsdVB3d8d(message));
									xpxsqyZXN65HPKG552G6(message2, sDSYMCZdK1Te35BKaQBg(message));
									AawGqWZXSwBGYFb2nhvG(message2, jJ1KHaZdOMjpo970gFuc(message));
									RdXhpwZX1vqwmou0LwBC(message2, SjX9jhZdZh1HuIEhLbPT(message));
									qlPwu2ZdYkEFPntBiAAQ(message2, aHvyJYZdvlsvB4DH47cs(message));
									QVyBXJZd8kTMajVHguQ7(message2, current.ToList());
									rikPwpZdsvr9JK24itVi(serviceNotNull, message2);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								case 1:
									goto end_IL_08f7;
								}
								break;
							}
							continue;
							end_IL_08f7:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator2 == null)
						{
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
							{
								num4 = 1;
							}
							goto IL_0a58;
						}
						goto IL_0a7d;
						IL_0a7d:
						aKLhftZdlQaVkTrMyUc3(enumerator2);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num4 = 0;
						}
						goto IL_0a58;
						IL_0a58:
						switch (num4)
						{
						default:
							goto end_IL_0a33;
						case 1:
							goto end_IL_0a33;
						case 2:
							break;
						case 0:
							goto end_IL_0a33;
						}
						goto IL_0a7d;
						end_IL_0a33:;
					}
					goto case 10;
				case 8:
					ContinueOnDefaultConnector(context);
					num = 3;
					break;
				case 6:
					list = list.Distinct((IUser u1, IUser u2) => u1.Id == u2.Id).Except(list2).ToList();
					num2 = 2;
					continue;
				case 20:
				{
					IEnumerable<int> source = list.Select((IUser u) => _003C_003Ec.uViw5mvfFS8nkelchHlu(_003C_003Ec.IlHVE1vfo4uq4Wkd78A1(u)));
					dictionary = new Dictionary<int, IMessage>();
					enumerator = source.Distinct().GetEnumerator();
					num2 = 17;
					continue;
				}
				case 5:
					enumerator2 = (from u in list
						group u by _003C_003Ec.uViw5mvfFS8nkelchHlu(_003C_003Ec.IlHVE1vfo4uq4Wkd78A1(u))).GetEnumerator();
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	private static string ConvertTextToHtml(object text)
	{
		return (string)fNDbi4ZdmoUEfp0vS4RO(JqlYn2ZdyEEG4qtGtwVY(MTHMedZd07oVyilT2fGL(text), true, true));
	}

	private void CloneMessage(IMessage source, IMessage target)
	{
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					target.ObjectUid = source.ObjectUid;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					qlPwu2ZdYkEFPntBiAAQ(target, aHvyJYZdvlsvB4DH47cs(source));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
					{
						num2 = 9;
					}
					continue;
				case 10:
					AraaGfZXaosje917XXhO(target, xFAx0TZXzLsdsdVB3d8d(source));
					num2 = 8;
					continue;
				case 4:
					target.ActionUid = source.ActionUid;
					num2 = 6;
					continue;
				case 7:
					RdXhpwZX1vqwmou0LwBC(target, SjX9jhZdZh1HuIEhLbPT(source));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return;
				default:
					AawGqWZXSwBGYFb2nhvG(target, jJ1KHaZdOMjpo970gFuc(source));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					break;
				case 1:
					O32yqEZXFCdidWm1WNMf(target, VpTYMKZXwe5D5jTLwxmv(source));
					num2 = 3;
					continue;
				case 8:
					target.ShortMessageText = source.ShortMessageText;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					target.AttachmentIds = (string[])((SRW49hZXEkyDUSmEILZt(source) != null) ? hOPe9uZdt6ghGyNXXmVv(new List<string>((IEnumerable<string>)SRW49hZXEkyDUSmEILZt(source))) : null);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			Ep9DkNZXiabS9glMr3Aa(target, cDfLg9ZX4jE10b2p6Qh0(source));
			num = 10;
		}
	}

	public NotificationActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object gXfqd8ZX38Pn56Zl1pS5(object P_0)
	{
		return ((NotificationBaseElement)P_0).NotificationTemplate;
	}

	internal static object lUHIi7ZXTt7D5T6pCWIk(object P_0)
	{
		return ((MessageTemplate)P_0).Subject;
	}

	internal static bool YT7hCjZXQXeSf7q28HZs(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object XAeYsnZXpBFBjpOye6SN(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static object fB6I7RZXC7AqgbI4vECA(object P_0)
	{
		return ((IUser)P_0).Replacement;
	}

	internal static object r4cY52ZXM1k1q7nJF4OH(object P_0)
	{
		return ((IUser)P_0).ReplacementUser;
	}

	internal static object h5EjSIZXk4brI1i47oD0(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static void MnDSKyZXUTt5brhD4pRU(object P_0, object P_1)
	{
		((NotificationElement.DataSource)P_0).Context = P_1;
	}

	internal static object LO2m53ZXVev58McHFU2Q(object P_0)
	{
		return ((IMessageManager)P_0).Create();
	}

	internal static void hX0vyEZXAKKdDquONNuf(object P_0, object P_1)
	{
		((IMessage)P_0).Author = P_1;
	}

	internal static Guid vkOhEdZXGx9WgRpknKOO()
	{
		return WorkflowInstanceActions.NotificationGuid;
	}

	internal static void oFSUTuZX7eMeY4MQddXb(object P_0, object P_1)
	{
		((IMessage)P_0).ObjectId = (string)P_1;
	}

	internal static void SQOgJGZX24v0bFQ5wvnJ(object P_0, object P_1)
	{
		((IMessage)P_0).AttachmentIds = (string[])P_1;
	}

	internal static bool SlcsptZXoekFHGmYyioD(object P_0)
	{
		return ((NotificationBaseElement)P_0).AttachmentsBySingleFile;
	}

	internal static void O32yqEZXFCdidWm1WNMf(object P_0, bool P_1)
	{
		((IMessage)P_0).AttachmentsBySingleFile = P_1;
	}

	internal static void Ep9DkNZXiabS9glMr3Aa(object P_0, object P_1)
	{
		((IMessage)P_0).Subject = (string)P_1;
	}

	internal static object TxVO6iZXI7chJi3mXdcK(object P_0)
	{
		return ((MessageTemplate)P_0).URL;
	}

	internal static void AraaGfZXaosje917XXhO(object P_0, object P_1)
	{
		((IMessage)P_0).URL = (string)P_1;
	}

	internal static object fTI2iDZXrNdNHDf7dZmB(object P_0)
	{
		return ((MessageTemplate)P_0).ShortMessage;
	}

	internal static object PDQMU1ZXeeUQ94JOvbBU(object P_0)
	{
		return ((MessageTemplate)P_0).FullMessage;
	}

	internal static void xpxsqyZXN65HPKG552G6(object P_0, object P_1)
	{
		((IMessage)P_0).ShortMessageText = (string)P_1;
	}

	internal static object h9uNHdZXxVZ9gk2LCSeH(object P_0)
	{
		return ConvertTextToHtml(P_0);
	}

	internal static void AawGqWZXSwBGYFb2nhvG(object P_0, object P_1)
	{
		((IMessage)P_0).ShortMessageHtml = (string)P_1;
	}

	internal static void RdXhpwZX1vqwmou0LwBC(object P_0, object P_1)
	{
		((IMessage)P_0).FullMessageText = (string)P_1;
	}

	internal static object SeTKTGZXhC3l4D6FwWNH(object P_0)
	{
		return ((IMessage)P_0).ObjectId;
	}

	internal static object SRW49hZXEkyDUSmEILZt(object P_0)
	{
		return ((IMessage)P_0).AttachmentIds;
	}

	internal static bool VpTYMKZXwe5D5jTLwxmv(object P_0)
	{
		return ((IMessage)P_0).AttachmentsBySingleFile;
	}

	internal static object cDfLg9ZX4jE10b2p6Qh0(object P_0)
	{
		return ((IMessage)P_0).Subject;
	}

	internal static object xFAx0TZXzLsdsdVB3d8d(object P_0)
	{
		return ((IMessage)P_0).URL;
	}

	internal static object sDSYMCZdK1Te35BKaQBg(object P_0)
	{
		return ((IMessage)P_0).ShortMessageText;
	}

	internal static object jJ1KHaZdOMjpo970gFuc(object P_0)
	{
		return ((IMessage)P_0).ShortMessageHtml;
	}

	internal static object SjX9jhZdZh1HuIEhLbPT(object P_0)
	{
		return ((IMessage)P_0).FullMessageText;
	}

	internal static object aHvyJYZdvlsvB4DH47cs(object P_0)
	{
		return ((IMessage)P_0).FullMessageHtml;
	}

	internal static void qlPwu2ZdYkEFPntBiAAQ(object P_0, object P_1)
	{
		((IMessage)P_0).FullMessageHtml = (string)P_1;
	}

	internal static void QVyBXJZd8kTMajVHguQ7(object P_0, object P_1)
	{
		((IMessage)P_0).Recipient = P_1;
	}

	internal static void rikPwpZdsvr9JK24itVi(object P_0, object P_1)
	{
		((IMessageManager)P_0).Send((IMessageBase)P_1);
	}

	internal static bool bh22uuZdJBpOomqFWdkc(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void aKLhftZdlQaVkTrMyUc3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool jhtBJNZX6wDNHZBTStgX()
	{
		return wcNfS2ZXRBX2kwT26Q9B == null;
	}

	internal static NotificationActivity HdIX6bZXq9bGcSLToh9Y()
	{
		return wcNfS2ZXRBX2kwT26Q9B;
	}

	internal static object MTHMedZd07oVyilT2fGL(object P_0)
	{
		return ElmaGeneratorFormatProvider.FormatTextTagBracket((string)P_0);
	}

	internal static object JqlYn2ZdyEEG4qtGtwVY(object P_0, bool P_1, bool P_2)
	{
		return ElmaGeneratorFormatProvider.FormatTextToLink((string)P_0, P_1, P_2);
	}

	internal static object fNDbi4ZdmoUEfp0vS4RO(object P_0)
	{
		return ((string)P_0).Nl2Br();
	}

	internal static object hOPe9uZdt6ghGyNXXmVv(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}
}
