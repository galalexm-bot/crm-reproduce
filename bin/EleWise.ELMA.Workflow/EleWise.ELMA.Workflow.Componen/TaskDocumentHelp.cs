using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 100)]
public class TaskDocumentHelp : IDocumentHelp
{
	private static TaskDocumentHelp k2ljo5OyZHDQXb4jZrAc;

	public bool CheckType(Guid typeUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return typeUid == InterfaceActivator.UID<IWorkflowTask>(loadImplementation: false);
			case 1:
				if (typeUid == InterfaceActivator.UID<IWorkflowTask>())
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IDocument ResolveDocument(ClassMetadata metadata, ITaskBase task)
	{
		//Discarded unreachable code: IL_01db, IL_021f, IL_0257
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		_003C_003Ec__DisplayClass1_1 CS_0024_003C_003E8__locals0;
		IDocument result = default(IDocument);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass1_.registrationElement = ((IEnumerable)uKiU7JOylbdXcDbITWqZ(HhaR1aOyJOOjPOM66dsg(((IWorkflowInstance)wnJE4POysrYuR4Re47Bw(jxG4P8Oy8fMYwYpgRgok((IWorkflowTaskBase)_003C_003Ec__DisplayClass1_.task))).Process))).OfType<UserTaskElement>().FirstOrDefault(_003C_003Ec__DisplayClass1_._003CResolveDocument_003Eb__0);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				if (_003C_003Ec__DisplayClass1_.registrationElement != null)
				{
					num2 = 5;
					continue;
				}
				break;
			case 5:
				if (_003C_003Ec__DisplayClass1_.registrationElement.TaskHelpId > 0)
				{
					num2 = 3;
					continue;
				}
				break;
			default:
				_003C_003Ec__DisplayClass1_.task = task;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_1();
					int num3 = 5;
					while (true)
					{
						switch (num3)
						{
						case 3:
							result = null;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							result = CS_0024_003C_003E8__locals0.document.CastAsRealType();
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
							{
								num3 = 0;
							}
							break;
						case 7:
							CS_0024_003C_003E8__locals0.document = null;
							num3 = 4;
							break;
						case 4:
							Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
							{
								int num6 = 1;
								int num7 = num6;
								while (true)
								{
									switch (num7)
									{
									default:
										return;
									case 1:
										CS_0024_003C_003E8__locals0.document = DocumentManager.Instance.LoadOrNull(_003C_003Ec__DisplayClass1_1.DlP0ryvOWReHnJWsMWGn(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.registrationElement));
										num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
										{
											num7 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num3 = 6;
							break;
						case 5:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass1_;
							num3 = 7;
							break;
						case 6:
							if (CS_0024_003C_003E8__locals0.document != null)
							{
								int num4 = 2;
								num3 = num4;
								break;
							}
							goto case 3;
						default:
							return result;
						case 0:
							return result;
						case 1:
							return result;
						}
					}
				}
				catch (Exception)
				{
					int num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							result = null;
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
							{
								num5 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
			case 4:
				break;
			}
			break;
		}
		return null;
	}

	public string GetDescription(ClassMetadata metadata, ITaskBase task)
	{
		return (string)OxQosaOy0ycBX0c5qWLg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801839133));
	}

	public TaskDocumentHelp()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KDjySnOyy2cplMX1CufQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool J3bPIuOyvttjlww2Jin2()
	{
		return k2ljo5OyZHDQXb4jZrAc == null;
	}

	internal static TaskDocumentHelp iLCmpxOyYU6yPaCi1uxh()
	{
		return k2ljo5OyZHDQXb4jZrAc;
	}

	internal static object jxG4P8Oy8fMYwYpgRgok(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object wnJE4POysrYuR4Re47Bw(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object HhaR1aOyJOOjPOM66dsg(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object uKiU7JOylbdXcDbITWqZ(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object OxQosaOy0ycBX0c5qWLg(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void KDjySnOyy2cplMX1CufQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
