using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Workflow.Extensions;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 500)]
[Obsolete("Больше не используется")]
internal class FilterWorkflowInstanceCriteriaBuilder : IFilterWorkflowInstanceCriteriaBuilder
{
	internal static FilterWorkflowInstanceCriteriaBuilder IMk4WSO5esleatlxAyTV;

	public IEnumerable<Guid> EntityTypeUids => null;

	public Type EntityType => SanOnTO5SOt2xNtQpJYB(typeof(IEntity<long>).TypeHandle);

	public void GetInstancesByEntityAddCriteria(ICriteria criteria, List<Guid> baseClassesUids)
	{
		criteria.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772582252), (object)EntityDescriptor.UID), (ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x6907BF67), (ICollection)baseClassesUids)));
	}

	public FilterWorkflowInstanceCriteriaBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zW3FAbO51jD1tm8cMmse();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type SanOnTO5SOt2xNtQpJYB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void zW3FAbO51jD1tm8cMmse()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool BhxrvyO5NhJw6v5m3XXI()
	{
		return IMk4WSO5esleatlxAyTV == null;
	}

	internal static FilterWorkflowInstanceCriteriaBuilder tAXjeQO5xFCRQvXw7n7d()
	{
		return IMk4WSO5esleatlxAyTV;
	}
}
