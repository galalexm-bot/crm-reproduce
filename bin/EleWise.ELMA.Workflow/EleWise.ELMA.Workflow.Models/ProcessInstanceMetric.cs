using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Scales;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Mappings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[InterfaceImplementation("EleWise.ELMA.KPI.Common.Interfaces.IScaleUser, EleWise.ELMA.KPI.Common")]
[InterfaceImplementation("EleWise.ELMA.KPI.Common.Interfaces.IScaleParamsWithPlanValue, EleWise.ELMA.KPI.Common")]
[MetadataType(typeof(EntityMetadata))]
[Uid("dfd0a9e5-53b3-4aeb-ac43-51401f1435c9")]
[Entity("ProcessInstanceMetric")]
[ClassMap(typeof(ProcessInstanceMetricMap))]
[DisplayName("SR.M('Метрика/показатель экземпляра процесса')")]
[BaseClass("{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
public class ProcessInstanceMetric : EntityPropertyMetadata, IScaleParamsWithPlanValue, IScaleParams, IScaleUser
{
	public new const string UID_S = "dfd0a9e5-53b3-4aeb-ac43-51401f1435c9";

	internal static ProcessInstanceMetric kwxw2GOfPnXN6pdEKVHZ;

	[EntityProperty]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "4b0e5f53-b2a1-46a3-89b8-1a9ded6ce860")]
	[Uid("{F6381395-3327-4FC1-8BEB-07501E3C7215}")]
	[EnumSettings(FieldName = "Type")]
	public ProcessMetricComputationType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[Uid("{F98FA9D4-022C-42FE-B0B1-772A22BB7A94}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "8c8f9b62-bf88-43a1-8e36-f77c98b04d53")]
	[EnumSettings(FieldName = "DataType")]
	public ProcessMetricDataType DataType
	{
		[CompilerGenerated]
		get
		{
			return _003CDataType_003Ek__BackingField;
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
					_003CDataType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
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

	[EntityProperty]
	[EnumSettings(FieldName = "TMCalculationType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "52e4bb16-2190-4600-9039-729cb98161d8")]
	[Uid("{8D6E4A1F-C797-424F-94DB-3CBFE78B52D7}")]
	public ProcessMetricTimeCalculationType TimeMetricCalculationType
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeMetricCalculationType_003Ek__BackingField;
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
					_003CTimeMetricCalculationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[Uid("{94DA602E-CB9D-4084-AE45-40165E1944FB}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1db6a3f5-b1d5-433e-b80c-803c2b7213fd")]
	[EnumSettings(FieldName = "TMTaskRepeatAction")]
	public ProcessMetricTaskRepeatAction TimeMetricProcessTaskRepeatAction
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeMetricProcessTaskRepeatAction_003Ek__BackingField;
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
					_003CTimeMetricProcessTaskRepeatAction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
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

	[Uid("{CCEFF412-79B3-4B6E-8B3F-2990F30BD35D}")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "SelectedProcessTaskUid")]
	[EntityProperty]
	public Guid? SelectedProcessTaskUid { get; set; }

	[EntityProperty]
	[BoolSettings(FieldName = "Active")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("{A602E5B2-1D61-4910-B17A-65BED5C30B39}")]
	public bool Active
	{
		[CompilerGenerated]
		get
		{
			return _003CActive_003Ek__BackingField;
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
					_003CActive_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{F4F6B19F-4DB1-4307-B76C-9F7F468E7235}")]
	[EntityProperty]
	[GuidSettings(FieldName = "StartStageUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	public Guid? StartStageUid { get; set; }

	[GuidSettings(FieldName = "EndStageUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[EntityProperty]
	[Uid("{20F7F274-6FA0-4940-A55D-24D587BFADA1}")]
	public Guid? EndStageUid { get; set; }

	[EnumSettings(FieldName = "StageCalculationType")]
	[Uid("{DD715AFA-3840-4EEB-BA82-026665474B1B}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "3bca5ce2-4e3b-4168-ad6d-986c8937169d")]
	[EntityProperty]
	public ProcessMetricStageCalculationType StageCalculationType
	{
		[CompilerGenerated]
		get
		{
			return _003CStageCalculationType_003Ek__BackingField;
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
					_003CStageCalculationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
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

	[Uid("{13008c36-0c96-46c3-ad51-f413bb6ae831}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "4ab08848-fd6f-4554-a896-c3596baaefb4")]
	[EnumSettings(FieldName = "MetricType")]
	[EntityProperty]
	public ProcessMetricType MetricType
	{
		[CompilerGenerated]
		get
		{
			return _003CMetricType_003Ek__BackingField;
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
					_003CMetricType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
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

	[EntityProperty]
	[Uid("9c0f8bdc-bc25-4770-8f1e-734d6b1591f2")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MinValue")]
	public double? MinValue { get; set; }

	[DoubleSettings(FieldName = "MinCriticalValue")]
	[EntityProperty]
	[Uid("c75fc142-91ec-40ea-9f56-c27f47b07397")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? MinCriticalValue { get; set; }

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[Uid("17dc56e8-4c1a-4d16-b167-c9356b3bcda0")]
	[DoubleSettings(FieldName = "MaxDeviation")]
	[EntityProperty]
	public double? MaxDeviation { get; set; }

	[EntityProperty]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[Uid("362f3e65-7284-476d-9822-cbd9d569252b")]
	[DoubleSettings(FieldName = "MaxCriticalValue")]
	public double? MaxCriticalValue { get; set; }

	[Uid("f765a479-496f-42e9-857b-892ae11aa22f")]
	[EntityProperty]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MaxValue")]
	public double? MaxValue { get; set; }

	[EntityProperty]
	[Uid("2e671b22-9cd0-4161-a940-ffa00b1c52a3")]
	[DoubleSettings(FieldName = "PlanValue")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? PlanValue { get; set; }

	[Uid("fb72b17e-eef9-4840-a8c8-e4a68857f74a")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[EntityProperty]
	[GuidSettings(FieldName = "ScaleUid")]
	public Guid? ScaleUid { get; set; }

	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("1ec95c4b-9dda-4b17-8df3-ee78823cc761")]
	[BoolSettings(FieldName = "UseWorkCalendar")]
	[EntityProperty]
	public bool UseWorkCalendar
	{
		[CompilerGenerated]
		get
		{
			return _003CUseWorkCalendar_003Ek__BackingField;
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
					_003CUseWorkCalendar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
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

	[EntityProperty]
	[Uid("0C29DD79-C329-433E-9F5C-745CFD6B1DA8")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "CheckForIndication")]
	public bool CheckForIndication
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckForIndication_003Ek__BackingField;
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
					_003CCheckForIndication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
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

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[Uid("E020B7AE-B87C-47BC-97A5-619A58F9D908")]
	[DoubleSettings(FieldName = "MinPerformancee")]
	[EntityProperty]
	public double? MinPerformance { get; set; }

	[EntityProperty]
	[Uid("76119A2F-604C-4ED1-B4BC-3DE5A86AC2E3")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "PlanPerformance")]
	public double? PlanPerformance { get; set; }

	[EntityProperty]
	[Uid("FB1BC434-08BA-4DB4-BD8F-7D2011F79630")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MinNormalValue")]
	public double? MinNormalValue { get; set; }

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MaxNormalValue")]
	[EntityProperty]
	[Uid("50FDE2AD-557F-4CA0-9F42-D236E6E33300")]
	public double? MaxNormalValue { get; set; }

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MaxPerformance")]
	[Uid("79744BF6-720E-4C0F-899A-C93BE92EA49B")]
	[EntityProperty]
	public double? MaxPerformance { get; set; }

	[EnumSettings(FieldName = "MinValueType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[EntityProperty]
	[Uid("{3E412170-911C-42D2-8DA1-ED900DC28EBF}")]
	public ScaleValueType MinValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CMinValueType_003Ek__BackingField;
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
					_003CMinValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{3788F15E-C25F-4CBF-8A35-70D27AADE5B4}")]
	[EntityProperty]
	[EnumSettings(FieldName = "MaxValueType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	public ScaleValueType MaxValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxValueType_003Ek__BackingField;
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
					_003CMaxValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[EnumSettings(FieldName = "MinNormalValueType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[Uid("{C6D37940-1BFA-4374-A55C-8DCE32369038}")]
	public ScaleValueType MinNormalValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CMinNormalValueType_003Ek__BackingField;
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
					_003CMinNormalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
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

	[EnumSettings(FieldName = "MaxNormalValueType")]
	[Uid("{C1D08466-60C3-442E-9C6E-EF2425AA51BF}")]
	[EntityProperty]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	public ScaleValueType MaxNormalValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxNormalValueType_003Ek__BackingField;
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
					_003CMaxNormalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[EnumSettings(FieldName = "MinCriticalValueType")]
	[Uid("{C6E1B691-E1EC-47B0-B8AF-92891712A199}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	public ScaleValueType MinCriticalValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CMinCriticalValueType_003Ek__BackingField;
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
					_003CMinCriticalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[Uid("{B3831529-4F3A-4157-9374-6D5252C3CE6D}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[EnumSettings(FieldName = "MaxCriticalValueType")]
	public ScaleValueType MaxCriticalValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxCriticalValueType_003Ek__BackingField;
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
					_003CMaxCriticalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
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

	public ProcessInstanceMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			CheckForIndication = true;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
			{
				num = 1;
			}
		}
	}

	public bool CanUseScale()
	{
		return MetricType == ProcessMetricType.Indicator;
	}

	public IIndicatorScale GetScale()
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		Guid? scaleUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 4:
					return (IIndicatorScale)t2lUgsOfDj3B5kpZgDEY(Locator.GetServiceNotNull<IndicatorScaleService>(), ScaleUid.Value);
				case 2:
					if (scaleUid.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					scaleUid = ScaleUid;
					num2 = 2;
					continue;
				}
				break;
			}
			ScaleUid = nE9Oq3OfuyC5vnHqdeqT(IncreaseIndicatorScale.Instance);
			num = 4;
		}
	}

	public void SetScale(IIndicatorScale scale)
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
				ScaleUid = scale.Id;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetMetricTypeAsString()
	{
		int num = 3;
		int num2 = num;
		ProcessMetricComputationType type = default(ProcessMetricComputationType);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (type != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return SR.T((string)xfiW7POfnAJCVypHxK7x(-25709590 ^ -25801996), ProcessMetricDataTypeToString(DataType));
			case 1:
				return SR.T((string)xfiW7POfnAJCVypHxK7x(0x614274E3 ^ 0x61438C03));
			case 3:
				type = Type;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			if (type == ProcessMetricComputationType.Time)
			{
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			throw new Exception((string)aGXjGbOffbT4wK01dTnM(xfiW7POfnAJCVypHxK7x(-1498811449 ^ -1498936699), new object[1] { sL0CXNOfLTkY1tEY4Bqi(kMKZR0OfHCH9v8aVBMfM(typeof(ProcessMetricComputationType).TypeHandle), Type) }));
		}
	}

	public override string ToString()
	{
		return Name;
	}

	private string ProcessMetricDataTypeToString(ProcessMetricDataType value)
	{
		//Discarded unreachable code: IL_00e3, IL_00f2
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				switch (value)
				{
				case ProcessMetricDataType.Integer:
					goto IL_0058;
				case ProcessMetricDataType.Float:
					return SR.T((string)xfiW7POfnAJCVypHxK7x(-2057730233 ^ -2057798157));
				case ProcessMetricDataType.TimeSpan:
					return (string)zDBmO0Of9fCmSeobvJRI(xfiW7POfnAJCVypHxK7x(-949717965 ^ -949645599));
				case ProcessMetricDataType.DateTime:
					goto end_IL_0012;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				goto IL_0058;
			case 1:
				break;
				IL_0058:
				return SR.T((string)xfiW7POfnAJCVypHxK7x(-1214182792 ^ -1214189342));
				end_IL_0012:
				break;
			}
			break;
		}
		throw new Exception((string)aGXjGbOffbT4wK01dTnM(xfiW7POfnAJCVypHxK7x(0x101D10F ^ 0x1002BF5), new object[1] { sL0CXNOfLTkY1tEY4Bqi(kMKZR0OfHCH9v8aVBMfM(typeof(ProcessMetricDataType).TypeHandle), DataType) }));
	}

	public string GetCalcTypeAsString()
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		ProcessMetricTimeCalculationType timeMetricCalculationType = default(ProcessMetricTimeCalculationType);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Type != ProcessMetricComputationType.Time)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					timeMetricCalculationType = TimeMetricCalculationType;
					num2 = 4;
				}
				break;
			default:
				return null;
			case 4:
				switch (timeMetricCalculationType)
				{
				default:
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 2;
					}
					goto end_IL_0012;
				case ProcessMetricTimeCalculationType.BuisnessProcessExecutionTime:
					break;
				case ProcessMetricTimeCalculationType.StageExecutionTime:
					return (string)zDBmO0Of9fCmSeobvJRI(xfiW7POfnAJCVypHxK7x(-14356676 ^ -14347356));
				case ProcessMetricTimeCalculationType.TaskExecutionTime:
					return SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22345928));
				}
				goto case 3;
			case 3:
				return (string)zDBmO0Of9fCmSeobvJRI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801856909));
			case 2:
				{
					throw new Exception((string)aGXjGbOffbT4wK01dTnM(xfiW7POfnAJCVypHxK7x(-432000546 ^ -431895260), new object[1] { sL0CXNOfLTkY1tEY4Bqi(kMKZR0OfHCH9v8aVBMfM(typeof(ProcessMetricTimeCalculationType).TypeHandle), DataType) }));
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static bool nCUAWVOfXC6c8tj2OLp9()
	{
		return kwxw2GOfPnXN6pdEKVHZ == null;
	}

	internal static ProcessInstanceMetric plWIPEOfdwfplvumrJdw()
	{
		return kwxw2GOfPnXN6pdEKVHZ;
	}

	internal static Guid nE9Oq3OfuyC5vnHqdeqT(object P_0)
	{
		return ((IndicatorScaleBase)P_0).Id;
	}

	internal static object t2lUgsOfDj3B5kpZgDEY(object P_0, Guid P_1)
	{
		return ((IndicatorScaleService)P_0).Get(P_1);
	}

	internal static object xfiW7POfnAJCVypHxK7x(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type kMKZR0OfHCH9v8aVBMfM(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static object sL0CXNOfLTkY1tEY4Bqi(Type P_0, object P_1)
	{
		return Enum.GetName(P_0, P_1);
	}

	internal static object aGXjGbOffbT4wK01dTnM(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object zDBmO0Of9fCmSeobvJRI(object P_0)
	{
		return SR.T((string)P_0);
	}
}
