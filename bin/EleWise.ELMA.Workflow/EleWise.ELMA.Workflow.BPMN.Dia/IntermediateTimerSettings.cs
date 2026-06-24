using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public class IntermediateTimerSettings
{
	internal static IntermediateTimerSettings J4rDU3Z0CeXa1rVodYvc;

	public StartTimerType StartTimerType
	{
		[CompilerGenerated]
		get
		{
			return _003CStartTimerType_003Ek__BackingField;
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
					_003CStartTimerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSetType TimeSetType
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeSetType_003Ek__BackingField;
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
					_003CTimeSetType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
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

	public DateTime ExactTimeValue
	{
		[CompilerGenerated]
		get
		{
			return _003CExactTimeValue_003Ek__BackingField;
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
					_003CExactTimeValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public TimeSpan RelativeTimeValue
	{
		[CompilerGenerated]
		get
		{
			return _003CRelativeTimeValue_003Ek__BackingField;
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
					_003CRelativeTimeValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
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

	public long RelativeTimeValueTicks
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan relativeTimeValue = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				default:
					return relativeTimeValue.Ticks;
				case 1:
					relativeTimeValue = RelativeTimeValue;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 0;
					}
					break;
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
					RelativeTimeValue = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
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
					_003CPropertyUid_003Ek__BackingField = value;
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

	public EventCycleInterval CycleInterval
	{
		[CompilerGenerated]
		get
		{
			return _003CCycleInterval_003Ek__BackingField;
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
					_003CCycleInterval_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
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

	public CycleTable CycleTable
	{
		[CompilerGenerated]
		get
		{
			return _003CCycleTable_003Ek__BackingField;
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
					_003CCycleTable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
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

	public IntermediateTimerSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		osBb0mZ0Um7ygWt9i7XT();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				CycleTable = new CycleTable();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public DateTime? GetNextTimerExpiration(IWorkflowInstance instance)
	{
		_ = DateTime.Now;
		switch (StartTimerType)
		{
		case StartTimerType.ExactTime:
		{
			if (TimeSetType == TimeSetType.ExactValue)
			{
				return ExactTimeValue;
			}
			object propertyValue2 = instance.Context.GetPropertyValue(PropertyUid);
			if (!(propertyValue2 is DateTime))
			{
				if (!(propertyValue2 is DateTime?))
				{
					return null;
				}
				return (DateTime?)propertyValue2;
			}
			return (DateTime)propertyValue2;
		}
		case StartTimerType.RelativeTime:
		{
			if (TimeSetType == TimeSetType.ExactValue)
			{
				return DateTime.Now + RelativeTimeValue;
			}
			object propertyValue = instance.Context.GetPropertyValue(PropertyUid);
			TimeSpan? timeSpan = ((propertyValue is TimeSpan) ? new TimeSpan?((TimeSpan)propertyValue) : ((propertyValue is TimeSpan?) ? ((TimeSpan?)propertyValue) : null));
			if (!timeSpan.HasValue)
			{
				return null;
			}
			return DateTime.Now + timeSpan.Value;
		}
		case StartTimerType.СycleStart:
		{
			bool isNextDay;
			switch (CycleInterval)
			{
			case EventCycleInterval.Day:
			{
				TimeSpan nextTimeSpan = GetNextTimeSpan(fromCurrentDay: true, out isNextDay);
				if (isNextDay)
				{
					nextTimeSpan += new TimeSpan(1, 0, 0, 0);
				}
				return DateTime.Now.Date + nextTimeSpan;
			}
			case EventCycleInterval.Month:
			{
				DateTime date = DateTime.Now.Date;
				int num = 0;
				bool flag = true;
				while (!IsMonthDayInTable(date) && num < 33)
				{
					date += new TimeSpan(1, 0, 0, 0);
					num++;
					flag = false;
				}
				TimeSpan nextTimeSpan = GetNextTimeSpan(flag, out isNextDay);
				if (flag && isNextDay)
				{
					date += new TimeSpan(1, 0, 0, 0);
					while (!IsMonthDayInTable(date) && num < 33)
					{
						date += new TimeSpan(1, 0, 0, 0);
						num++;
					}
				}
				return date.Date + nextTimeSpan;
			}
			case EventCycleInterval.Week:
			{
				DateTime date = DateTime.Now.Date;
				int num = 0;
				bool flag = true;
				while (!IsDayInTable(date) && num < 8)
				{
					date += new TimeSpan(1, 0, 0, 0);
					num++;
					flag = false;
				}
				TimeSpan nextTimeSpan = GetNextTimeSpan(flag, out isNextDay);
				if (flag && isNextDay)
				{
					date += new TimeSpan(1, 0, 0, 0);
					while (!IsDayInTable(date) && num < 8)
					{
						date += new TimeSpan(1, 0, 0, 0);
						num++;
					}
				}
				return date.Date + nextTimeSpan;
			}
			default:
				return null;
			}
		}
		default:
			return null;
		}
	}

	private TimeSpan GetNextTimeSpan(bool fromCurrentDay, out bool isNextDay)
	{
		//Discarded unreachable code: IL_00e5, IL_00f4, IL_00ff, IL_018d, IL_01fc, IL_020f, IL_026c, IL_029c, IL_02a6, IL_0373, IL_0386
		int num = 2;
		bool flag = default(bool);
		DateTime dateTime = default(DateTime);
		TimeSpan timeOfDay = default(TimeSpan);
		TimeSpan timeSpan = default(TimeSpan);
		List<TimeSpan>.Enumerator enumerator = default(List<TimeSpan>.Enumerator);
		TimeSpan current2 = default(TimeSpan);
		TimeSpan current = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (flag)
					{
						num2 = 14;
						continue;
					}
					goto case 12;
				case 2:
					dateTime = dIaYRsZ0V0sWmqg0CZJw();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					timeOfDay = dateTime.TimeOfDay;
					num2 = 8;
					continue;
				case 9:
					if (fromCurrentDay)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 6:
					isNextDay = true;
					num2 = 3;
					continue;
				case 8:
					timeSpan = new TimeSpan(24, 0, 0);
					num2 = 13;
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_01ba:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 6;
								goto IL_0103;
							}
							goto IL_0197;
							IL_0103:
							while (true)
							{
								switch (num5)
								{
								case 2:
									flag = true;
									num5 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
									{
										num5 = 2;
									}
									continue;
								case 7:
									timeSpan = current2;
									num5 = 2;
									continue;
								case 1:
									if (!hPXjpUZ0An7Qkm1NsAYh(current2, timeOfDay))
									{
										num5 = 5;
										continue;
									}
									goto case 4;
								case 4:
									if (FdMxIeZ0G2kZmx4aCuDS(current2, timeSpan))
									{
										num5 = 7;
										continue;
									}
									goto IL_01ba;
								case 3:
								case 5:
									goto IL_01ba;
								case 6:
									goto end_IL_01ba;
								}
								break;
							}
							goto IL_0197;
							IL_0197:
							current2 = enumerator.Current;
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
							{
								num5 = 1;
							}
							goto IL_0103;
							continue;
							end_IL_01ba:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 12:
					timeSpan = new TimeSpan(24, 0, 0);
					num2 = 11;
					continue;
				case 11:
					enumerator = CycleTable.Times.GetEnumerator();
					num2 = 10;
					continue;
				case 3:
				case 14:
					return timeSpan;
				case 13:
					flag = false;
					num2 = 7;
					continue;
				case 7:
					isNextDay = false;
					num2 = 9;
					continue;
				case 10:
					try
					{
						while (true)
						{
							IL_0313:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_02aa;
							}
							goto IL_02f0;
							IL_02aa:
							while (true)
							{
								switch (num3)
								{
								case 1:
									if (FdMxIeZ0G2kZmx4aCuDS(current, timeSpan))
									{
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_0313;
								case 4:
									break;
								case 2:
									goto IL_0313;
								default:
									timeSpan = current;
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
									{
										num3 = 2;
									}
									continue;
								case 3:
									goto end_IL_0313;
								}
								break;
							}
							goto IL_02f0;
							IL_02f0:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
							{
								num3 = 1;
							}
							goto IL_02aa;
							continue;
							end_IL_0313:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				}
				break;
			}
			enumerator = CycleTable.Times.GetEnumerator();
			num = 4;
		}
	}

	private bool IsDayInTable(DateTime dt)
	{
		//Discarded unreachable code: IL_0033, IL_003d, IL_0081, IL_010e, IL_0121, IL_0130
		int num = 1;
		int num2 = num;
		List<int>.Enumerator enumerator = default(List<int>.Enumerator);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
							{
								num3 = 1;
							}
							goto IL_0041;
						}
						goto IL_00b1;
						IL_00b1:
						if ((enumerator.Current + 1) % 7 != (int)dt.DayOfWeek)
						{
							continue;
						}
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num3 = 1;
						}
						goto IL_0041;
						IL_0041:
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 1:
								result = true;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								break;
							case 4:
								goto IL_00b1;
							case 3:
								goto end_IL_008b;
							}
							break;
						}
						continue;
						end_IL_008b:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 1:
				enumerator = CycleTable.DaysOfWeek.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private bool IsMonthDayInTable(DateTime dt)
	{
		//Discarded unreachable code: IL_0037, IL_00b7, IL_00c6, IL_017d, IL_0190, IL_019f
		int num = 3;
		int num2 = num;
		List<int>.Enumerator enumerator = default(List<int>.Enumerator);
		int current = default(int);
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				try
				{
					while (true)
					{
						IL_0111:
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
							{
								num4 = 0;
							}
							goto IL_0049;
						}
						goto IL_00ee;
						IL_00ee:
						current = enumerator.Current;
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num4 = 0;
						}
						goto IL_0049;
						IL_0049:
						while (true)
						{
							switch (num4)
							{
							case 1:
								return result;
							case 2:
								if (current == 28)
								{
									num4 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
									{
										num4 = 3;
									}
									continue;
								}
								goto case 4;
							case 3:
								if (dt.Day != num3)
								{
									int num5 = 4;
									num4 = num5;
									continue;
								}
								goto case 6;
							case 6:
								result = true;
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
								{
									num4 = 0;
								}
								continue;
							case 7:
								goto IL_00ee;
							case 5:
								goto IL_0111;
							case 4:
								if (current + 1 == dt.Day)
								{
									num4 = 6;
									continue;
								}
								goto IL_0111;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 2:
				enumerator = CycleTable.DaysOfMonth.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				num3 = T8iwvxZ07pFSlrnKtE52(dt.Year, dt.Month);
				num2 = 2;
				break;
			}
		}
	}

	internal static void osBb0mZ0Um7ygWt9i7XT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool fVqsvxZ0MurkaJk7MvWk()
	{
		return J4rDU3Z0CeXa1rVodYvc == null;
	}

	internal static IntermediateTimerSettings VeoOjJZ0kAqtxQBsDy29()
	{
		return J4rDU3Z0CeXa1rVodYvc;
	}

	internal static DateTime dIaYRsZ0V0sWmqg0CZJw()
	{
		return DateTime.Now;
	}

	internal static bool hPXjpUZ0An7Qkm1NsAYh(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 > P_1;
	}

	internal static bool FdMxIeZ0G2kZmx4aCuDS(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 < P_1;
	}

	internal static int T8iwvxZ07pFSlrnKtE52(int P_0, int P_1)
	{
		return DateTime.DaysInMonth(P_0, P_1);
	}
}
