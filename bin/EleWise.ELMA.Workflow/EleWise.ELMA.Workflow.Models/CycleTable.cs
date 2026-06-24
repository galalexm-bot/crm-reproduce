using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
public class CycleTable
{
	private List<TimeSpan> _dayStarts;

	private List<int> _daysOfMonth;

	private List<int> _daysOfWeek;

	private static CycleTable oJxZxNOHWNFLhtlGcpm8;

	[XmlIgnore]
	public List<TimeSpan> Times
	{
		get
		{
			return _dayStarts;
		}
		set
		{
			_dayStarts = value;
		}
	}

	public long[] TimesTicks
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_dayStarts != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return null;
				default:
					return _dayStarts.Select((TimeSpan d) => d.Ticks).ToArray();
				}
			}
		}
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
					_dayStarts = ((value != null) ? value.Select((long v) => new TimeSpan(v)).ToList() : new List<TimeSpan>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<int> DaysOfMonth
	{
		get
		{
			return _daysOfMonth;
		}
		set
		{
			_daysOfMonth = value;
		}
	}

	public List<int> DaysOfWeek
	{
		get
		{
			return _daysOfWeek;
		}
		set
		{
			_daysOfWeek = value;
		}
	}

	public CycleTable()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		l9Z2f1OH6mJPdPkx1nHK();
		_dayStarts = new List<TimeSpan>();
		_daysOfMonth = new List<int>();
		_daysOfWeek = new List<int>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WecDpmOHj90GILMAZZ1v()
	{
		return oJxZxNOHWNFLhtlGcpm8 == null;
	}

	internal static CycleTable l5ot43OHRa8MK3e7EU1Y()
	{
		return oJxZxNOHWNFLhtlGcpm8;
	}

	internal static void l9Z2f1OH6mJPdPkx1nHK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
