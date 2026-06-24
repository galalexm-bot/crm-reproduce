using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CatalogEditTaskManager : TaskBaseManager<ICatalogEditTask>
{
	internal static CatalogEditTaskManager vGNtdkBtak3uy5GdJgQ;

	public new static CatalogEditTaskManager Instance => Locator.GetServiceNotNull<CatalogEditTaskManager>();

	public WorkflowTaskBaseManager WorkflowTaskBaseManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowTaskBaseManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CWorkflowTaskBaseManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Transaction]
	public virtual void Assign(ICatalogEditTask task)
	{
		//Discarded unreachable code: IL_0046, IL_0055, IL_0060, IL_00fd, IL_0110, IL_011f, IL_0203, IL_0212
		int num = 6;
		int num2 = num;
		List<IWorkflowTaskBase>.Enumerator enumerator = default(List<IWorkflowTaskBase>.Enumerator);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
							{
								num3 = 2;
							}
							goto IL_0064;
						}
						goto IL_00a0;
						IL_00a0:
						IWorkflowTaskBase current = enumerator.Current;
						k8vqWjBcYCUPPpWZ8px(current, CWsCRfBBE5TONXGK8C9());
						current.Save();
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
						{
							num3 = 0;
						}
						goto IL_0064;
						IL_0064:
						switch (num3)
						{
						case 1:
							goto IL_00a0;
						case 2:
							goto end_IL_007a;
						}
						continue;
						end_IL_007a:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 8;
			case 3:
				return;
			case 8:
				CMNGaCBPVwK8mqNFysP(WorkflowTaskBaseManager, workflowTaskBase);
				num2 = 3;
				break;
			default:
				if (workflowTaskBase != null)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 1:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790208498));
			case 4:
				enumerator = WorkflowTaskBaseManager.GetTasks((IWorkflowBookmark)YJAKANBgryQT83k4lfK(workflowTaskBase)).Where(_003C_003Ec__DisplayClass6_._003CAssign_003Eb__0).ToList()
					.GetEnumerator();
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass6_.task = task;
				num2 = 2;
				break;
			case 6:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 5;
				break;
			case 2:
				workflowTaskBase = _003C_003Ec__DisplayClass6_.task as IWorkflowTaskBase;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	[ActionMethod("e49a86f0-5c45-4db1-945a-6d0e20bde148")]
	public override ICatalogEditTask StartWork(long taskId, bool alertCoexecuters = true, ICommentActionModel actionModel = null)
	{
		int num = 2;
		int num2 = num;
		ICatalogEditTask catalogEditTask = default(ICatalogEditTask);
		while (true)
		{
			switch (num2)
			{
			case 2:
				catalogEditTask = Load(taskId);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				qTT6OcBXDFnTCPqlGEd(this, catalogEditTask);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return base.StartWork(taskId, alertCoexecuters, actionModel);
			}
		}
	}

	public CatalogEditTaskManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jWUblSBdBIvXdycb1Nw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool uRMD39BbILokOg0FYab()
	{
		return vGNtdkBtak3uy5GdJgQ == null;
	}

	internal static CatalogEditTaskManager UkfsaqB5BWNj2dpXXbX()
	{
		return vGNtdkBtak3uy5GdJgQ;
	}

	internal static object YJAKANBgryQT83k4lfK(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object CWsCRfBBE5TONXGK8C9()
	{
		return TaskBaseStatus.WasClosed;
	}

	internal static void k8vqWjBcYCUPPpWZ8px(object P_0, object P_1)
	{
		((ITaskBase)P_0).Status = (TaskBaseStatus)P_1;
	}

	internal static void CMNGaCBPVwK8mqNFysP(object P_0, object P_1)
	{
		((WorkflowTaskBaseManager)P_0).SaveSwimlaneExecutor((IWorkflowTaskBase)P_1);
	}

	internal static void qTT6OcBXDFnTCPqlGEd(object P_0, object P_1)
	{
		((CatalogEditTaskManager)P_0).Assign((ICatalogEditTask)P_1);
	}

	internal static void jWUblSBdBIvXdycb1Nw()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
