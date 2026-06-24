using System;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowTaskExecuteData : IWorkflowExecuteData
{
	private readonly IWorkflowTaskBase _task;

	private readonly Guid _connectorUid;

	private IUser _executor;

	internal static WorkflowTaskExecuteData dDHq24ORPmEslNHr9ggB;

	public IWorkflowTaskBase Task => _task;

	public Guid ConnectorUid => _connectorUid;

	public IWorkflowBookmark Bookmark => (IWorkflowBookmark)ENP2bqORHY298nU5fC4F(_task);

	public IUser Executor => _executor;

	public WorkflowTaskExecuteData(IWorkflowTaskBase task, Guid connectorUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		Sv62VJORuSTE2BjwcVSE();
		this._002Ector(task, connectorUid, null);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowTaskExecuteData(IWorkflowTaskBase task, Guid connectorUid, IUser executor)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		Sv62VJORuSTE2BjwcVSE();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
				XGcqXOORnCCIj0TGrdPc(task.WorkflowBookmark, gTh7YdORD6P0Xr2fbYmG(0x34EA50D4 ^ 0x34E85DC8));
				num = 5;
				break;
			case 5:
				_task = task;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num = 0;
				}
				break;
			default:
				_executor = executor;
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(task, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947924767));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				_connectorUid = connectorUid;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)nBM9YeORLSl6ysAawc28(_task);
	}

	internal static void Sv62VJORuSTE2BjwcVSE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool CUhGyYORXb33pM7f5Cas()
	{
		return dDHq24ORPmEslNHr9ggB == null;
	}

	internal static WorkflowTaskExecuteData FMApdAORdL9iUly0tbvm()
	{
		return dDHq24ORPmEslNHr9ggB;
	}

	internal static object gTh7YdORD6P0Xr2fbYmG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XGcqXOORnCCIj0TGrdPc(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object ENP2bqORHY298nU5fC4F(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object nBM9YeORLSl6ysAawc28(object P_0)
	{
		return ((ITaskBase)P_0).Subject;
	}
}
