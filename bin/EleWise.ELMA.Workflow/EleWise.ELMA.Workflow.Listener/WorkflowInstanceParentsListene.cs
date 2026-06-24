using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowInstanceParentsListener : PostFlushEventListener
{
	private readonly ITransformationProvider transformationProvider;

	private static WorkflowInstanceParentsListener NycPgTRB777yYaLPtlt;

	public WorkflowInstanceParentsListener(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RqPh7HRX66XLOim3Rl4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.transformationProvider = transformationProvider;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
			{
				num = 1;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_011a, IL_0150
		int num = 3;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				return;
			case 6:
				return;
			case 4:
				EAFRBaRDA50Rq2hwXjk(transformationProvider, QixJ2DRuN9Lwh5t0nqH(-768800937 ^ -768777469), new string[2]
				{
					(string)QixJ2DRuN9Lwh5t0nqH(0x37E97159 ^ 0x37E937E9),
					(string)QixJ2DRuN9Lwh5t0nqH(0x4FD00585 ^ 0x4FD0618F)
				}, new object[2] { workflowInstance.Id, workflowInstance.Id });
				num2 = 7;
				continue;
			case 3:
				base.OnPostInsert(@event);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				if (workflowInstance == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 7:
				if (Kn9GC9RnaAHUv7w7cUv(workflowInstance) == null)
				{
					num2 = 6;
					continue;
				}
				break;
			case 2:
				workflowInstance = Dv1uHcRdbra53kx12Wf(@event) as IWorkflowInstance;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				break;
			}
			transformationProvider.Insert((string)QixJ2DRuN9Lwh5t0nqH(-1895853023 ^ -1895829387), new string[3]
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122761745),
				(string)QixJ2DRuN9Lwh5t0nqH(-768800937 ^ -768777379),
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D42D2F)
			}, (string)YStVA6R9tKiIil3O6s0(QixJ2DRuN9Lwh5t0nqH(-801808857 ^ -801775361), rnw8BRRL7lA4IJkqPZ0(zYP3jiRHWfjmiOj2oie(transformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4943A554)), MUT5cnRfBLZgi1oC0MQ(transformationProvider)), string.Format((string)QixJ2DRuN9Lwh5t0nqH(0x2269BD32 ^ 0x2269022A), rnw8BRRL7lA4IJkqPZ0(zYP3jiRHWfjmiOj2oie(transformationProvider), QixJ2DRuN9Lwh5t0nqH(0x5DB28AD2 ^ 0x5DB2EE86)), rnw8BRRL7lA4IJkqPZ0(transformationProvider.Dialect, QixJ2DRuN9Lwh5t0nqH(0x17F0C5A2 ^ 0x17F0A1A8)), transformationProvider.ParameterSeparator), isNeedInsertId: false, new Dictionary<string, object>
			{
				{
					(string)QixJ2DRuN9Lwh5t0nqH(-351369538 ^ -351389200),
					((IEntity<long>)Kn9GC9RnaAHUv7w7cUv(workflowInstance)).Id
				},
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657539769),
					workflowInstance.Id
				},
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D4F6CB),
					(LKQO7JRjI0EMoBE3kZv(u1e4thRWIiRiLGlF5DY(workflowInstance.Process)) != null) ? 1 : 0
				}
			});
			num2 = 5;
		}
	}

	internal static void RqPh7HRX66XLOim3Rl4()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool lghrdXRc0y7w6BprI59()
	{
		return NycPgTRB777yYaLPtlt == null;
	}

	internal static WorkflowInstanceParentsListener hKhmLKRPmmSehf8ChSY()
	{
		return NycPgTRB777yYaLPtlt;
	}

	internal static object Dv1uHcRdbra53kx12Wf(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object QixJ2DRuN9Lwh5t0nqH(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int EAFRBaRDA50Rq2hwXjk(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static object Kn9GC9RnaAHUv7w7cUv(object P_0)
	{
		return ((IWorkflowInstance)P_0).ParentInstance;
	}

	internal static object zYP3jiRHWfjmiOj2oie(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object rnw8BRRL7lA4IJkqPZ0(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object MUT5cnRfBLZgi1oC0MQ(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object YStVA6R9tKiIil3O6s0(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object u1e4thRWIiRiLGlF5DY(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object LKQO7JRjI0EMoBE3kZv(object P_0)
	{
		return ((IProcessHeader)P_0).Parent;
	}
}
