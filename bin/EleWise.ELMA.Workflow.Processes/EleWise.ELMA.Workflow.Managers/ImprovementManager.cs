using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class ImprovementManager
{
	internal static ImprovementManager r4WhsNMmY9u9V4svZBx;

	public static IEnumerable<IWorkflowInstance> GetInstancesByImprovedProcessHeaders(IEnumerable<long> values, FetchOptions fetchOptions)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		ImprovementProcessSettingsManager instance = ImprovementProcessSettingsManager.Instance;
		InstanceOf<IImprovementProcessSettingsFilter> instanceOf = new InstanceOf<IImprovementProcessSettingsFilter>();
		instanceOf.New.Default = true;
		IImprovementProcessSettings improvementProcessSettings = instance.Find(instanceOf.New, new FetchOptions(0, 1)).FirstOrDefault();
		if (improvementProcessSettings == null)
		{
			return new IWorkflowInstance[0];
		}
		IPropertyMetadata fullInstanceContextPropertyMetadata = WorkflowInstanceContextService.Instance.GetFullInstanceContextPropertyMetadata(improvementProcessSettings.Header, improvementProcessSettings.ProcessHeaderContextVar);
		if (fullInstanceContextPropertyMetadata == null)
		{
			return new IWorkflowInstance[0];
		}
		string name = fullInstanceContextPropertyMetadata.Name;
		IWorkflowInstanceFilter workflowInstanceFilter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
		workflowInstanceFilter.ProcessHeader = improvementProcessSettings.Header;
		return WorkflowInstanceManager.Instance.CreateContextFilterCriteria(workflowInstanceFilter, fetchOptions).Add((ICriterion)(object)Restrictions.In(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-133069941 ^ -133046991), name), (ICollection)values.ToArray())).AddOrder(new Order(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66914DC5 ^ 0x6691131B), false))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-408604271 ^ -408588667)) })
			.List<IWorkflowInstance>();
	}

	public static int GetInstancesByImprovedProcessHeadersCount(IEnumerable<long> values)
	{
		ImprovementProcessSettingsManager instance = ImprovementProcessSettingsManager.Instance;
		InstanceOf<IImprovementProcessSettingsFilter> instanceOf = new InstanceOf<IImprovementProcessSettingsFilter>();
		instanceOf.New.Default = true;
		IImprovementProcessSettings improvementProcessSettings = instance.Find(instanceOf.New, new FetchOptions(0, 1)).FirstOrDefault();
		if (improvementProcessSettings == null)
		{
			return 0;
		}
		IPropertyMetadata fullInstanceContextPropertyMetadata = WorkflowInstanceContextService.Instance.GetFullInstanceContextPropertyMetadata(improvementProcessSettings.Header, improvementProcessSettings.ProcessHeaderContextVar);
		if (fullInstanceContextPropertyMetadata == null)
		{
			return 0;
		}
		string name = fullInstanceContextPropertyMetadata.Name;
		IWorkflowInstanceFilter workflowInstanceFilter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
		workflowInstanceFilter.ProcessHeader = improvementProcessSettings.Header;
		return WorkflowInstanceManager.Instance.CreateContextFilterCriteria(workflowInstanceFilter, FetchOptions.All).Add((ICriterion)(object)Restrictions.In(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97750002 ^ -97768780), name), (ICollection)values.ToArray())).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count((IProjection)(object)Projections.Id()) })
			.UniqueResult<int>();
	}

	public ImprovementManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lprqZIMABCb2i8KsL3I()
	{
		return r4WhsNMmY9u9V4svZBx == null;
	}

	internal static ImprovementManager TtomJBMpLYE0aQm2Dms()
	{
		return r4WhsNMmY9u9V4svZBx;
	}
}
