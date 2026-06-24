using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
public class TimeOfExecution
{
	private static TimeOfExecution okoUm8Z5ZsFJbLXH2Zk6;

	public TimeSetType ValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CValueType_003Ek__BackingField;
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
					_003CValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public TimeSpan Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long ValueTicks
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan value = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					value = Value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return value.Ticks;
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
				case 1:
					Value = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Remind
	{
		[CompilerGenerated]
		get
		{
			return _003CRemind_003Ek__BackingField;
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
					_003CRemind_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int RemindTime
	{
		[CompilerGenerated]
		get
		{
			return _003CRemindTime_003Ek__BackingField;
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
					_003CRemindTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
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

	public TimespanType RemindTimeType
	{
		[CompilerGenerated]
		get
		{
			return _003CRemindTimeType_003Ek__BackingField;
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
					_003CRemindTimeType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
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

	public List<Recipient> Recipients { get; set; }

	public TimeOfExecution()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		C8NR9eZ58r0RKnsVhaxk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Recipients = new List<Recipient>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public DateTime? Evaluate(IWorkflowInstance instance)
	{
		return Evaluate(instance, null);
	}

	public DateTime? Evaluate(IWorkflowInstance instance, IUser executor)
	{
		Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F53135A));
		Contract.ArgumentNotNull(instance.Context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246FB1FE));
		TimeSpan? timeSpan = null;
		DateTime? result = null;
		switch (ValueType)
		{
		case TimeSetType.ExactValue:
			timeSpan = Value;
			break;
		case TimeSetType.ContextVar:
		{
			PropertyMetadata propertyMetadata = ((PropertyUid != Guid.Empty) ? ((ClassMetadata)MetadataLoader.LoadMetadata(instance.Context.GetType())).Properties.FirstOrDefault((PropertyMetadata p) => yctymwZ5spK4SaKn8AWO(p.Uid, PropertyUid)) : null);
			if (propertyMetadata == null)
			{
				break;
			}
			object propertyValue = instance.Context.GetPropertyValue(PropertyUid);
			if (propertyValue == null)
			{
				break;
			}
			if (propertyMetadata.TypeUid == TimeSpanDescriptor.UID)
			{
				timeSpan = (TimeSpan)propertyValue;
			}
			else
			{
				if (!(propertyMetadata.TypeUid == DateTimeDescriptor.UID))
				{
					break;
				}
				DateTimeSettings dateTimeSettings = (DateTimeSettings)propertyMetadata.Settings;
				if (dateTimeSettings.ShowDate)
				{
					result = (DateTime)propertyValue;
					if (!dateTimeSettings.ShowTime)
					{
						result = result.Value.Date.AddDays(1.0).AddSeconds(-10.0);
					}
				}
			}
			break;
		}
		}
		if (timeSpan.HasValue)
		{
			IProductionSchedule productionSchedule = Locator.GetServiceNotNull<IProductionCalendarService>().GetProductionSchedule(executor, instance, (executor == null) ? TZ.Server : executor.TimeZone.Settings);
			result = productionSchedule.EvalTargetTime(DateTime.Now, timeSpan.Value);
		}
		return result;
	}

	internal static void C8NR9eZ58r0RKnsVhaxk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool du4m5pZ5vOTkl3QSjIlf()
	{
		return okoUm8Z5ZsFJbLXH2Zk6 == null;
	}

	internal static TimeOfExecution lg1D43Z5YPMYoqKow4mr()
	{
		return okoUm8Z5ZsFJbLXH2Zk6;
	}

	internal static bool yctymwZ5spK4SaKn8AWO(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
