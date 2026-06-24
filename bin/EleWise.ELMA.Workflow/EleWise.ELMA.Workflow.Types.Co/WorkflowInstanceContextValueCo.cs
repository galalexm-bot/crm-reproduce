using System;
using System.Reflection;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Types.Container;

internal class WorkflowInstanceContextValueContainer : IPropertyDefaultValueContainer
{
	private class NestedValueContainer : IPropertyValueContainer<WorkflowInstanceContext>, IPropertyValueContainer
	{
		private object value;

		internal static object h2HRGbZ9irJgqIascl7y;

		Type IPropertyValueContainer.PropertyType => TypeOf<WorkflowInstanceContext>.Raw;

		WorkflowInstanceContext IPropertyValueContainer<WorkflowInstanceContext>.Get(object obj)
		{
			int num = 2;
			int num2 = num;
			WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
			object obj2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					workflowInstanceContext = (WorkflowInstanceContext)(value = M1pCksZ9rJSWwIh2EejK(obj));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj2 = value;
					if (obj2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj2 = workflowInstanceContext;
					break;
				}
				break;
			}
			return (WorkflowInstanceContext)obj2;
		}

		object IPropertyValueContainer.Get(object obj)
		{
			return ((IPropertyValueContainer<WorkflowInstanceContext>)this).Get(obj);
		}

		void IPropertyValueContainer<WorkflowInstanceContext>.Set(object obj, WorkflowInstanceContext value)
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
					this.value = WorkflowInstanceContext.Check(obj, value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		void IPropertyValueContainer.Set(object obj, object value)
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
					((IPropertyValueContainer<WorkflowInstanceContext>)this).Set(obj, (WorkflowInstanceContext)value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public NestedValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			c2BHF0Z9ePcXKgRA08nh();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object M1pCksZ9rJSWwIh2EejK(object P_0)
		{
			return WorkflowInstanceContext.Load(P_0);
		}

		internal static bool k2DraJZ9I3HTiLYdCCk6()
		{
			return h2HRGbZ9irJgqIascl7y == null;
		}

		internal static NestedValueContainer veJjASZ9aOiTM9Imlt2M()
		{
			return (NestedValueContainer)h2HRGbZ9irJgqIascl7y;
		}

		internal static void c2BHF0Z9ePcXKgRA08nh()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static WorkflowInstanceContextValueContainer v8TgWil9BWcN8Xl6APH;

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		return new NestedValueContainer();
	}

	public WorkflowInstanceContextValueContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B5p1ZflRl6l9TOyNGNG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void B5p1ZflRl6l9TOyNGNG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool F6eRcPlW7OiRN5kgtL2()
	{
		return v8TgWil9BWcN8Xl6APH == null;
	}

	internal static WorkflowInstanceContextValueContainer yW8ia1lja9SQPvjXcjh()
	{
		return v8TgWil9BWcN8Xl6APH;
	}
}
