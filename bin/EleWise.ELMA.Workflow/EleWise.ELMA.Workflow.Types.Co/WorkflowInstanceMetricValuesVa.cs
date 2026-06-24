using System;
using System.Reflection;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Types.Container;

internal class WorkflowInstanceMetricValuesValueContainer : IPropertyDefaultValueContainer
{
	private class NestedValueContainer : IPropertyValueContainer<WorkflowInstanceMetricValues>, IPropertyValueContainer
	{
		private object value;

		internal static object KkAS3yZ9GyejwksQ7dW0;

		Type IPropertyValueContainer.PropertyType => TypeOf<WorkflowInstanceMetricValues>.Raw;

		WorkflowInstanceMetricValues IPropertyValueContainer<WorkflowInstanceMetricValues>.Get(object obj)
		{
			int num = 1;
			int num2 = num;
			WorkflowInstanceMetricValues workflowInstanceMetricValues = default(WorkflowInstanceMetricValues);
			object obj2;
			while (true)
			{
				switch (num2)
				{
				default:
					workflowInstanceMetricValues = (WorkflowInstanceMetricValues)(value = Vo8QUIZ9oWbmdOv3TCR0(obj));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj2 = value;
					if (obj2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					obj2 = workflowInstanceMetricValues;
					break;
				}
				break;
			}
			return (WorkflowInstanceMetricValues)obj2;
		}

		object IPropertyValueContainer.Get(object obj)
		{
			return ((IPropertyValueContainer<WorkflowInstanceMetricValues>)this).Get(obj);
		}

		void IPropertyValueContainer<WorkflowInstanceMetricValues>.Set(object obj, WorkflowInstanceMetricValues value)
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
			FFRhH7Z9FRsxUQlUboyS();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object Vo8QUIZ9oWbmdOv3TCR0(object P_0)
		{
			return WorkflowInstanceMetricValues.Load(P_0);
		}

		internal static bool i8n829Z97Ib5ZV9fb8on()
		{
			return KkAS3yZ9GyejwksQ7dW0 == null;
		}

		internal static NestedValueContainer JjekrFZ92xDXcFSSr49p()
		{
			return (NestedValueContainer)KkAS3yZ9GyejwksQ7dW0;
		}

		internal static void FFRhH7Z9FRsxUQlUboyS()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static WorkflowInstanceMetricValuesValueContainer JISjC4lnh6aeXK105Hf;

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		return new NestedValueContainer();
	}

	public WorkflowInstanceMetricValuesValueContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tdT174lfCblw3jDKZa8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void tdT174lfCblw3jDKZa8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool ppgGnElHvG0TtLhEwYA()
	{
		return JISjC4lnh6aeXK105Hf == null;
	}

	internal static WorkflowInstanceMetricValuesValueContainer wCwqdNlLyMpdDqXPr1T()
	{
		return JISjC4lnh6aeXK105Hf;
	}
}
