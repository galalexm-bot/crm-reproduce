using System;
using System.Reflection;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Types.Container;

internal class WorkflowProcessMetricValuesValueContainer : IPropertyDefaultValueContainer
{
	private class NestedValueContainer : IPropertyValueContainer<WorkflowProcessMetricValues>, IPropertyValueContainer
	{
		private object value;

		internal static object Q8h0qCZ9MVyXXZgVa4MS;

		Type IPropertyValueContainer.PropertyType => TypeOf<WorkflowProcessMetricValues>.Raw;

		WorkflowProcessMetricValues IPropertyValueContainer<WorkflowProcessMetricValues>.Get(object obj)
		{
			int num = 1;
			int num2 = num;
			WorkflowProcessMetricValues workflowProcessMetricValues = default(WorkflowProcessMetricValues);
			object obj2;
			while (true)
			{
				switch (num2)
				{
				default:
					workflowProcessMetricValues = (WorkflowProcessMetricValues)(value = zVXD1AZ9V3STnnJ2AIaK(obj));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj2 = value;
					if (obj2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj2 = workflowProcessMetricValues;
					break;
				}
				break;
			}
			return (WorkflowProcessMetricValues)obj2;
		}

		object IPropertyValueContainer.Get(object obj)
		{
			return ((IPropertyValueContainer<WorkflowProcessMetricValues>)this).Get(obj);
		}

		void IPropertyValueContainer<WorkflowProcessMetricValues>.Set(object obj, WorkflowProcessMetricValues value)
		{
			throw new NotImplementedException();
		}

		void IPropertyValueContainer.Set(object obj, object value)
		{
			throw new NotImplementedException();
		}

		public NestedValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			uhZN2FZ9AlfPo1vxjqMv();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object zVXD1AZ9V3STnnJ2AIaK(object P_0)
		{
			return WorkflowProcessMetricValues.Load(P_0);
		}

		internal static bool MTuc2sZ9khAEt2Ws8w63()
		{
			return Q8h0qCZ9MVyXXZgVa4MS == null;
		}

		internal static NestedValueContainer d42hkvZ9UOiOcQ79EtRB()
		{
			return (NestedValueContainer)Q8h0qCZ9MVyXXZgVa4MS;
		}

		internal static void uhZN2FZ9AlfPo1vxjqMv()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static WorkflowProcessMetricValuesValueContainer QwnZf0lX1UZDk8JiGJw;

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		return new NestedValueContainer();
	}

	public WorkflowProcessMetricValuesValueContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sAxWxLlDTaP24kMfWNC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void sAxWxLlDTaP24kMfWNC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool uXl8mPldDWjQsMU9aBP()
	{
		return QwnZf0lX1UZDk8JiGJw == null;
	}

	internal static WorkflowProcessMetricValuesValueContainer eEsQ3HluoKLJvmIQ1MN()
	{
		return QwnZf0lX1UZDk8JiGJw;
	}
}
