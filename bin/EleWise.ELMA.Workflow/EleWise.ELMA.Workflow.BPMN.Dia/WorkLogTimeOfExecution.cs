using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
public class WorkLogTimeOfExecution
{
	internal static WorkLogTimeOfExecution s6xOCPZbOct2VgQ9uwOl;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool AcrossWorkLog
	{
		[CompilerGenerated]
		get
		{
			return _003CAcrossWorkLog_003Ek__BackingField;
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
					_003CAcrossWorkLog_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
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
				case 0:
					return;
				case 1:
					Value = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
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
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
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

	public WorkTime? Evaluate(IWorkflowInstance instance)
	{
		return Evaluate(instance, null);
	}

	public WorkTime? Evaluate(IWorkflowInstance instance, IUser executor)
	{
		Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11817576));
		Contract.ArgumentNotNull(instance.Context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11358CA6));
		TimeSpan? timeSpan = null;
		switch (ValueType)
		{
		case TimeSetType.ExactValue:
			timeSpan = Value;
			break;
		case TimeSetType.ContextVar:
		{
			PropertyMetadata propertyMetadata = ((PropertyUid != Guid.Empty) ? ((ClassMetadata)MetadataLoader.LoadMetadata(instance.Context.GetType())).Properties.FirstOrDefault((PropertyMetadata p) => n7SMJFZb8IB58mbHsg5G(p.Uid, PropertyUid)) : null);
			if (propertyMetadata != null)
			{
				object propertyValue = instance.Context.GetPropertyValue(PropertyUid);
				if (propertyValue != null && propertyMetadata.TypeUid == TimeSpanDescriptor.UID)
				{
					timeSpan = (TimeSpan)propertyValue;
				}
			}
			break;
		}
		}
		WorkTime? result = null;
		if (timeSpan.HasValue)
		{
			IProductionSchedule productionSchedule = Locator.GetServiceNotNull<IProductionCalendarService>().GetProductionSchedule(executor, instance, (executor == null) ? TZ.Server : executor.TimeZone.Settings);
			long num = 1440L;
			try
			{
				num = (long)Math.Floor(productionSchedule.GetWorkTimeInDay().TotalMinutes);
				if (num <= 0)
				{
					num = 1440L;
				}
			}
			catch (Exception)
			{
			}
			int days = timeSpan.Value.Days;
			int hours = timeSpan.Value.Hours;
			long minutes = timeSpan.Value.Minutes + hours * 60 + days * num;
			result = new WorkTime(minutes);
		}
		return result;
	}

	public WorkLogTimeOfExecution()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aWTn4SZbYecmDUrY1wpT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool u0J03xZbZxDThJIy4y3R()
	{
		return s6xOCPZbOct2VgQ9uwOl == null;
	}

	internal static WorkLogTimeOfExecution yrhEg0ZbvYTmVA4lXXdk()
	{
		return s6xOCPZbOct2VgQ9uwOl;
	}

	internal static void aWTn4SZbYecmDUrY1wpT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool n7SMJFZb8IB58mbHsg5G(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
