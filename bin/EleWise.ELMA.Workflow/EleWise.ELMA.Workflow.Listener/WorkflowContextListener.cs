using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowContextListener : PostFlushEventListener
{
	private IWorkflowChangedHandler _workflowChangedHandler;

	private static WorkflowContextListener QWRk9o38SbafQGqljwX;

	private IWorkflowChangedHandler WorkflowChangedHandler
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_workflowChangedHandler = Locator.GetService<IWorkflowChangedHandler>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					if (_workflowChangedHandler == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return _workflowChangedHandler;
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0124, IL_0133
		int num = 5;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (workflowInstance == null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 6;
					}
				}
				else
				{
					AuditWorkflowChanged(workflowInstance);
					num2 = 2;
				}
				break;
			case 5:
				if (!(MetadataLoader.LoadMetadata(zVSiEy3lp1vlZx2Lrba(@event).GetType()) is ProcessContext))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 6:
				throw new TransactionRollbackException(SR.T((string)DGFOxk3yGNqjPbqrZFD(-1108877388 ^ -1108922376), DGFOxk3yGNqjPbqrZFD(-1895853023 ^ -1895838581)));
			default:
				workflowInstance = (IWorkflowInstance)TSWJDI30SRor4JFXa0q(zVSiEy3lp1vlZx2Lrba(@event));
				num2 = 3;
				break;
			case 1:
				return;
			case 4:
				return;
			case 2:
				((WorkflowInstanceManager)rCO7n83m0Zf3fd8UJbG()).ContextUpdated(workflowInstance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void AuditWorkflowChanged(IWorkflowInstance pInstance)
	{
		//Discarded unreachable code: IL_007c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				WorkflowChangedHandler.WorkflowChanged(pInstance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (WorkflowChangedHandler == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	public WorkflowContextListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		V3UeJB3twnWvDrQijG1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object zVSiEy3lp1vlZx2Lrba(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object TSWJDI30SRor4JFXa0q(object P_0)
	{
		return WorkflowMetricValueChangedListener.GetWorkflowInstance(P_0);
	}

	internal static object DGFOxk3yGNqjPbqrZFD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rCO7n83m0Zf3fd8UJbG()
	{
		return WorkflowInstanceManager.Instance;
	}

	internal static bool OuJ8C83s1PglMmVHYgu()
	{
		return QWRk9o38SbafQGqljwX == null;
	}

	internal static WorkflowContextListener TbjyeU3J2LumI9tK5Dw()
	{
		return QWRk9o38SbafQGqljwX;
	}

	internal static void V3UeJB3twnWvDrQijG1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
