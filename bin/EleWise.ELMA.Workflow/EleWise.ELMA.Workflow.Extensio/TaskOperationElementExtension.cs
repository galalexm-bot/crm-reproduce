using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class TaskOperationElementExtension : IWorkflowRegulationOperationExtension
{
	internal static TaskOperationElementExtension ASBj7ZFdjnC4BZJvfDU;

	public bool CheckTypeElement(object obj)
	{
		return obj is TaskElement;
	}

	public void GetRegulationOperationFromElement(object obj, WorkflowProcessDTO process, ref Dictionary<Guid, string> numberElemArtDict, ref RegulationOperation regulationOperation)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_010a, IL_01c6, IL_024b, IL_033a, IL_0349, IL_0354, IL_041b, IL_046a, IL_047d, IL_04a8, IL_04b7, IL_04c8, IL_04d2, IL_056d, IL_057c, IL_05db, IL_05ee, IL_05fd
		int num = 14;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		string timeOfExecution = default(string);
		TaskElement taskElement = default(TaskElement);
		List<RegulationInputOutput>.Enumerator enumerator = default(List<RegulationInputOutput>.Enumerator);
		RegulationInputOutput current2 = default(RegulationInputOutput);
		RegulationInputOutput current = default(RegulationInputOutput);
		while (true)
		{
			object obj4;
			switch (num2)
			{
			default:
				return;
			case 2:
				timeSpan = z6KQ81FWKO3Bnyb79xj(CWUqCqFLqJriHWf89hV(_003C_003Ec__DisplayClass1_.usertaskElement));
				num2 = 10;
				continue;
			case 14:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 13;
				}
				continue;
			case 5:
				timeOfExecution = null;
				num2 = 18;
				continue;
			case 0:
				return;
			case 3:
				if (opy2wwF6YNgGIE8WJxc(taskElement) == null)
				{
					num2 = 22;
					continue;
				}
				goto case 25;
			case 18:
				if (_003C_003Ec__DisplayClass1_.usertaskElement != null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 6;
			case 1:
			{
				object obj5 = TiJiy9Fj6NlIZr6IGiL(0x246EEF98 ^ 0x246FCA08);
				object[] obj6 = new object[3]
				{
					((TimeOfExecution)CWUqCqFLqJriHWf89hV(_003C_003Ec__DisplayClass1_.usertaskElement)).Value.Days,
					z6KQ81FWKO3Bnyb79xj(_003C_003Ec__DisplayClass1_.usertaskElement.TimeOfExecution).Hours,
					null
				};
				timeSpan = ((TimeOfExecution)CWUqCqFLqJriHWf89hV(_003C_003Ec__DisplayClass1_.usertaskElement)).Value;
				obj6[2] = timeSpan.Minutes;
				obj4 = jNskQsFRL47QF6ig1wM(obj5, obj6);
				goto IL_0666;
			}
			case 7:
				if (ly3mr4FnP9g93sWxgxr(_003C_003Ec__DisplayClass1_.usertaskElement))
				{
					num2 = 20;
					continue;
				}
				goto case 17;
			case 17:
				if (km30wQFHiMqtXXRHp8M(_003C_003Ec__DisplayClass1_.usertaskElement))
				{
					num2 = 9;
					continue;
				}
				goto case 6;
			case 9:
			case 20:
				if (E14vQ1FffkeVOW1V3qJ(CWUqCqFLqJriHWf89hV(_003C_003Ec__DisplayClass1_.usertaskElement)) == TimeSetType.ContextVar)
				{
					num2 = 16;
					continue;
				}
				goto case 2;
			case 6:
			case 19:
				regulationOperation.TimeOfExecution = timeOfExecution;
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num2 = 11;
				}
				continue;
			case 11:
				enumerator = ((RegulationForTaskElement)opy2wwF6YNgGIE8WJxc(taskElement)).Outputs.GetEnumerator();
				num2 = 23;
				continue;
			case 16:
				timeOfExecution = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077842514), mPI9DUF9ylgxbcft9HZ(process.Context.Properties.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CGetRegulationOperationFromElement_003Eb__0)));
				num2 = 6;
				continue;
			case 15:
				if (taskElement == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 3;
				}
				continue;
			case 25:
				enumerator = ((RegulationForTaskElement)opy2wwF6YNgGIE8WJxc(taskElement)).Inputs.GetEnumerator();
				num2 = 4;
				continue;
			case 10:
				if (timeSpan.Days == 0)
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 1;
			case 13:
				taskElement = obj as TaskElement;
				num2 = 8;
				continue;
			case 4:
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
							{
								num5 = 2;
							}
							goto IL_0358;
						}
						goto IL_03a4;
						IL_03a4:
						current2 = enumerator.Current;
						num5 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
						{
							num5 = 0;
						}
						goto IL_0358;
						IL_0358:
						while (true)
						{
							switch (num5)
							{
							case 1:
								goto IL_03a4;
							case 6:
								regulationOperation.ExternalInputs.Add(current2);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
								{
									num5 = 0;
								}
								continue;
							case 2:
								if (tP4DkOFqg2EsfWJ5AiX(current2))
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
									{
										num5 = 6;
									}
									continue;
								}
								goto case 4;
							case 4:
								regulationOperation.InternalInputs.Add(current2);
								num5 = 3;
								continue;
							case 5:
								goto end_IL_037e;
							}
							break;
						}
						continue;
						end_IL_037e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 11;
			case 22:
				return;
			case 24:
				return;
			case 8:
				_003C_003Ec__DisplayClass1_.usertaskElement = obj as UserTaskElement;
				num2 = 5;
				continue;
			case 23:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							goto IL_04d6;
						}
						goto IL_052c;
						IL_04d6:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!current.IsExternal)
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 7:
								goto IL_052c;
							case 2:
								regulationOperation.ExternalOutputs.Add(current);
								num3 = 5;
								continue;
							case 3:
							case 4:
								regulationOperation.InternalOutputs.Add(current);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
								goto end_IL_0500;
							}
							break;
						}
						continue;
						IL_052c:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num3 = 1;
						}
						goto IL_04d6;
						continue;
						end_IL_0500:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 12:
			{
				object obj2 = TiJiy9Fj6NlIZr6IGiL(0x65B7F624 ^ 0x65B6D024);
				object[] obj3 = new object[2]
				{
					((TimeOfExecution)CWUqCqFLqJriHWf89hV(_003C_003Ec__DisplayClass1_.usertaskElement)).Value.Hours,
					null
				};
				timeSpan = z6KQ81FWKO3Bnyb79xj(CWUqCqFLqJriHWf89hV(_003C_003Ec__DisplayClass1_.usertaskElement));
				obj3[1] = timeSpan.Minutes;
				obj4 = jNskQsFRL47QF6ig1wM(obj2, obj3);
				goto IL_0666;
			}
			case 21:
				break;
				IL_0666:
				timeOfExecution = (string)obj4;
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 19;
				}
				continue;
			}
			regulationOperation.Description = (string)(taskElement.Regulation.MergedFields ? LnEWRFFTrHEnEWfDDhD(taskElement) : wwhcyjF34QriAoypw2S(opy2wwF6YNgGIE8WJxc(taskElement)));
			num2 = 24;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
			{
				num2 = 19;
			}
		}
	}

	public TaskOperationElementExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HaaMO1FQeN9OeKK5aB8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool miRuFOFu1HQI8Jw8IFo()
	{
		return ASBj7ZFdjnC4BZJvfDU == null;
	}

	internal static TaskOperationElementExtension QuO38RFD7KDwfHa76dF()
	{
		return ASBj7ZFdjnC4BZJvfDU;
	}

	internal static bool ly3mr4FnP9g93sWxgxr(object P_0)
	{
		return ((UserTaskElement)P_0).LimitByTime;
	}

	internal static bool km30wQFHiMqtXXRHp8M(object P_0)
	{
		return ((UserTaskElement)P_0).LimitByWorkLogTime;
	}

	internal static object CWUqCqFLqJriHWf89hV(object P_0)
	{
		return ((UserTaskElement)P_0).TimeOfExecution;
	}

	internal static TimeSetType E14vQ1FffkeVOW1V3qJ(object P_0)
	{
		return ((TimeOfExecution)P_0).ValueType;
	}

	internal static object mPI9DUF9ylgxbcft9HZ(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static TimeSpan z6KQ81FWKO3Bnyb79xj(object P_0)
	{
		return ((TimeOfExecution)P_0).Value;
	}

	internal static object TiJiy9Fj6NlIZr6IGiL(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jNskQsFRL47QF6ig1wM(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object opy2wwF6YNgGIE8WJxc(object P_0)
	{
		return ((TaskElement)P_0).Regulation;
	}

	internal static bool tP4DkOFqg2EsfWJ5AiX(object P_0)
	{
		return ((RegulationInputOutput)P_0).IsExternal;
	}

	internal static object wwhcyjF34QriAoypw2S(object P_0)
	{
		return ((RegulationForTaskElement)P_0).Description;
	}

	internal static object LnEWRFFTrHEnEWfDDhD(object P_0)
	{
		return ((Element)P_0).Description;
	}

	internal static void HaaMO1FQeN9OeKK5aB8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
