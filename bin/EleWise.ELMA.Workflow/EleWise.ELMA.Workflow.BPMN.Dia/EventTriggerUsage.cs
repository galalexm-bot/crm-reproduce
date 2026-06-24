using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public static class EventTriggerUsage
{
	public static List<EventTrigger> GetTriggers(Func<TriggerUsageAttribute, bool> f)
	{
		List<EventTrigger> list = new List<EventTrigger>();
		foreach (EventTrigger value in Enum.GetValues(typeof(EventTrigger)))
		{
			if (value == EventTrigger.Metric)
			{
				continue;
			}
			if (f == null)
			{
				list.Add(value);
				continue;
			}
			TriggerUsageAttribute attribute = AttributeHelper<TriggerUsageAttribute>.GetAttribute(typeof(EventTrigger).GetMember(value.ToString())[0], inherited: true);
			if (attribute != null && f(attribute))
			{
				list.Add(value);
			}
		}
		return list;
	}

	public static List<EventTrigger> GetTriggers(EventType eventType)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.eventType = eventType;
		return GetTriggers(delegate(TriggerUsageAttribute f)
		{
			//Discarded unreachable code: IL_00c7, IL_00d6, IL_00e6
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (_003C_003Ec__DisplayClass1_.eventType == EventType.Intermediate)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 4;
				case 4:
					if (_003C_003Ec__DisplayClass1_.eventType != EventType.End)
					{
						return false;
					}
					num2 = 6;
					break;
				case 7:
					if (!_003C_003Ec__DisplayClass1_0.TTAXYFvuupgG6dTkJNNu(f))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 3:
					if (f.Intermediate)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 4;
				case 6:
					return _003C_003Ec__DisplayClass1_0.jLWkiLvuDv70u8Lqvg6C(f);
				case 5:
					return true;
				case 2:
					if (_003C_003Ec__DisplayClass1_.eventType != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				}
			}
		});
	}
}
