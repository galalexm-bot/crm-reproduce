using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
public class StartProcessSchedulerJobExecutor : ISchedulerTaskJobExecutor
{
	internal static StartProcessSchedulerJobExecutor SRLoj6tUnHyKYkDFsGO;

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
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

	public IWorkflowRuntimeService WorkflowRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowRuntimeService_003Ek__BackingField;
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
					_003CWorkflowRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool CanExecute(ISchedulerTaskJob job)
	{
		return job is IStartProcessSchedulerJob;
	}

	public JobResult Do(ISchedulerTaskJob job, DateTime dateToRun)
	{
		//Discarded unreachable code: IL_0072, IL_0270
		int num = 2;
		IStartProcessSchedulerJob startProcessSchedulerJob = default(IStartProcessSchedulerJob);
		JobResult jobResult = default(JobResult);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (startProcessSchedulerJob != null)
					{
						num = 14;
						break;
					}
					goto case 9;
				case 1:
					startProcessSchedulerJob = job as IStartProcessSchedulerJob;
					num2 = 11;
					continue;
				case 4:
					return jobResult;
				case 10:
					jobResult.Status = JobStatus.Fail;
					num = 4;
					break;
				case 9:
					return null;
				case 14:
					if (TI68GCt221MJ5QKE5Rm(startProcessSchedulerJob) == null)
					{
						num2 = 5;
						continue;
					}
					if (ElWSIgti5FlY9vGqIiy(startProcessSchedulerJob.ProcessHeader) == null)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 3;
				case 6:
					xEp58rteyH1I3sn9df1(workflowInstance, ElWSIgti5FlY9vGqIiy(TI68GCt221MJ5QKE5Rm(startProcessSchedulerJob)));
					num = 8;
					break;
				case 5:
				{
					JobResult jobResult3 = new JobResult();
					aZjvnAtoTDBrW1p7gXW(jobResult3, SR.T((string)ha1ITLtGl1ivjbewFu4(0x12F686A ^ 0x12F2CC0)));
					K43ccWtFqjw2N65DXIf(jobResult3, JobStatus.Fail);
					return jobResult3;
				}
				case 2:
					Y2COBtt71Ib0785HeuH(WorkflowRuntimeService, ha1ITLtGl1ivjbewFu4(0x101D10F ^ 0x1019575));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					WLHhQEtNxdpR4sFWXrV(WorkflowRuntimeService, workflowInstance);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					if (((IProcessHeader)TI68GCt221MJ5QKE5Rm(startProcessSchedulerJob)).Status == WorkflowProcessStatus.Published)
					{
						workflowInstance = InterfaceActivator.Create<IWorkflowInstance>();
						num = 6;
						break;
					}
					num2 = 13;
					continue;
				case 7:
				{
					JobResult jobResult2 = new JobResult();
					aZjvnAtoTDBrW1p7gXW(jobResult2, M9FrIwtag6wRWgUnW1c(ha1ITLtGl1ivjbewFu4(0x1C663DA1 ^ 0x1C667829)));
					K43ccWtFqjw2N65DXIf(jobResult2, JobStatus.Success);
					return jobResult2;
				}
				case 12:
				case 13:
					jobResult = new JobResult();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					aZjvnAtoTDBrW1p7gXW(jobResult, kKOQ70trXW7C0sZsY94(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1019401), new object[1] { M9FrIwtag6wRWgUnW1c(h4I8prtIPTXome1uw4o(TI68GCt221MJ5QKE5Rm(startProcessSchedulerJob))) }));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 10;
					}
					continue;
				}
				break;
			}
		}
	}

	public StartProcessSchedulerJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AWpTp6txd777LY7PYMN();
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

	internal static bool dkMqvdtVMqEb0scjKpY()
	{
		return SRLoj6tUnHyKYkDFsGO == null;
	}

	internal static StartProcessSchedulerJobExecutor KVqcORtAckoUmWUjGd4()
	{
		return SRLoj6tUnHyKYkDFsGO;
	}

	internal static object ha1ITLtGl1ivjbewFu4(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Y2COBtt71Ib0785HeuH(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object TI68GCt221MJ5QKE5Rm(object P_0)
	{
		return ((IStartProcessSchedulerJob)P_0).ProcessHeader;
	}

	internal static void aZjvnAtoTDBrW1p7gXW(object P_0, object P_1)
	{
		((JobResult)P_0).Information = (string)P_1;
	}

	internal static void K43ccWtFqjw2N65DXIf(object P_0, JobStatus P_1)
	{
		((JobResult)P_0).Status = P_1;
	}

	internal static object ElWSIgti5FlY9vGqIiy(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object h4I8prtIPTXome1uw4o(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object M9FrIwtag6wRWgUnW1c(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object kKOQ70trXW7C0sZsY94(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void xEp58rteyH1I3sn9df1(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
	}

	internal static void WLHhQEtNxdpR4sFWXrV(object P_0, object P_1)
	{
		((IWorkflowRuntimeService)P_0).Run((IWorkflowInstance)P_1);
	}

	internal static void AWpTp6txd777LY7PYMN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
