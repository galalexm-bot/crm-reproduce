using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.KPI.Common.DTO.Managers;
using EleWise.ELMA.KPI.Common.DTO.Models;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Scales;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Mappings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[DisplayName("SR.M('Метрика/показатель процесса')")]
[BaseClass("{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
[InterfaceImplementation("EleWise.ELMA.KPI.Common.Interfaces.IScaleUser, EleWise.ELMA.KPI.Common")]
[InterfaceImplementation("EleWise.ELMA.KPI.Common.Interfaces.IScaleParamsWithPlanValue, EleWise.ELMA.KPI.Common")]
[Uid("A18C0521-AFE5-4945-8792-B9FB6F147246")]
[MetadataType(typeof(EntityMetadata))]
[Entity("ProcessMetric")]
[ClassMap(typeof(ProcessMetricMap))]
public class ProcessMetric : EntityPropertyMetadata, IScaleParamsWithPlanValue, IScaleParams, IScaleUser
{
	public new const string UID_S = "A18C0521-AFE5-4945-8792-B9FB6F147246";

	private static ProcessMetric lDN3x4OLpKoFvHZu07IU;

	[EnumSettings(FieldName = "Type")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "4b0e5f53-b2a1-46a3-89b8-1a9ded6ce860")]
	[Uid("{6303d725-9d4c-498c-9d28-e702dafe9f12}")]
	[EntityProperty]
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
				case 1:
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
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

	[EnumSettings(FieldName = "DataType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "8c8f9b62-bf88-43a1-8e36-f77c98b04d53")]
	[EntityProperty]
	[Uid("{13855d57-c70b-4a81-9ad4-72f096d41ed5}")]
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
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

	[Uid("{F089E66F-6D51-498A-A54A-E5BBB11C5C6F}")]
	[EntityProperty]
	[EnumSettings(FieldName = "TimeScale")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "c2b9855b-52e8-4deb-a78a-ca07185ceb1c")]
	public ProcessIndicatorTimeScale TimeScale
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeScale_003Ek__BackingField;
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
					_003CTimeScale_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[GuidSettings(FieldName = "TimeScaleContextVariableUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{5AFAE10A-A7BA-4615-8642-A6D6171CD1FE}")]
	[EntityProperty]
	public Guid? TimeScaleContextVariableUid { get; set; }

	[Uid("8eee0497-b1d1-436e-8006-b2de6b769637")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "PlanValue")]
	[EntityProperty]
	public double? PlanValue { get; set; }

	[EntityProperty]
	[EnumSettings(FieldName = "FactCalculationType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "3441022e-fe10-4904-a749-4306512ef0cf")]
	[Uid("{DB2AB062-D9B4-4A7B-BB10-CD6D6729200C}")]
	public ProcessIndicatorFactCalculationType FactCalculationType
	{
		[CompilerGenerated]
		get
		{
			return _003CFactCalculationType_003Ek__BackingField;
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
					_003CFactCalculationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{12F6D86B-B3DA-4A5C-A9B5-29072CC60E37}")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "FactMetricUid")]
	[EntityProperty]
	public Guid? FactMetricUid { get; set; }

	[EntityProperty]
	[EnumSettings(FieldName = "FactFormulaType")]
	[Uid("{A2D8C6F6-4AE5-4CD7-ABF5-9CF14A2563FC}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "6e3d4bc1-874c-44d1-aef9-31cf05e507fa")]
	public ProcessIndicatorFactFormulaType FactFormulaType
	{
		[CompilerGenerated]
		get
		{
			return _003CFactFormulaType_003Ek__BackingField;
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
					_003CFactFormulaType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[BoolSettings(FieldName = "Active")]
	[Uid("{C943CE40-328F-4CD3-9B2B-8A15812EFF32}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EnumSettings(FieldName = "ScaleType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "66489b46-226e-4afd-b57e-afd604a8904b")]
	[Uid("{D61C76CA-7D93-4252-9DF5-AA1F46614602}")]
	[EntityProperty]
	public ProcessIndicatorScaleType ScaleType
	{
		[CompilerGenerated]
		get
		{
			return _003CScaleType_003Ek__BackingField;
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
					_003CScaleType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
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

	[StringSettings(FieldName = "MinScaleValue")]
	[EntityProperty]
	[Uid("{C627323D-6702-410E-B3F0-6AD85E599359}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public string MinScaleValue
	{
		[CompilerGenerated]
		get
		{
			return _003CMinScaleValue_003Ek__BackingField;
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
					_003CMinScaleValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
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

	[StringSettings(FieldName = "MaxScaleValue")]
	[EntityProperty]
	[Uid("{3B98A2CA-2B15-419E-89FC-7AEA7CA03081}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public string MaxScaleValue
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxScaleValue_003Ek__BackingField;
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
					_003CMaxScaleValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
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

	[TimeSpanSettings(FieldName = "PlanValueDateTime")]
	[Uid("{E4F55F98-5D96-4C30-845A-02D5C703B59D}")]
	[Property("{C503AE0F-D260-4173-B52B-63E9158F3D7D}")]
	[XmlIgnore]
	[EntityProperty]
	public TimeSpan PlanValueDateTime
	{
		[CompilerGenerated]
		get
		{
			return _003CPlanValueDateTime_003Ek__BackingField;
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
					_003CPlanValueDateTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("PlanValueDateTime")]
	public long PlanValueDateTimeTicks
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan planValueDateTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					planValueDateTime = PlanValueDateTime;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return planValueDateTime.Ticks;
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
					PlanValueDateTime = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
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
	[XmlIgnore]
	[TimeSpanSettings(FieldName = "MinScaleValueDateTime")]
	[Property("{C503AE0F-D260-4173-B52B-63E9158F3D7D}")]
	[Uid("{A0ACF431-D407-4258-A1CF-F8DC4E0B7FCD}")]
	public TimeSpan MinScaleValueDateTime
	{
		[CompilerGenerated]
		get
		{
			return _003CMinScaleValueDateTime_003Ek__BackingField;
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
					_003CMinScaleValueDateTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("MinScaleValueDateTime")]
	public long MinScaleValueDateTimeTicks
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan minScaleValueDateTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					minScaleValueDateTime = MinScaleValueDateTime;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return minScaleValueDateTime.Ticks;
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
					MinScaleValueDateTime = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
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
	[XmlIgnore]
	[TimeSpanSettings(FieldName = "MaxScaleValueDateTime")]
	[Property("{C503AE0F-D260-4173-B52B-63E9158F3D7D}")]
	[Uid("{7B8BB176-41DC-4A5F-8287-E80B78D4FC15}")]
	public TimeSpan MaxScaleValueDateTime
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxScaleValueDateTime_003Ek__BackingField;
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
					_003CMaxScaleValueDateTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
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

	[Uid("{4c2ef103-a375-4358-b32a-4902653e939c}")]
	[EntityProperty]
	[EnumSettings(FieldName = "MetricType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "4ab08848-fd6f-4554-a896-c3596baaefb4")]
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
				case 0:
					return;
				case 1:
					_003CMetricType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "InstanceMetricUid")]
	[EntityProperty]
	[Uid("{60a25847-7f87-4180-a644-9ad8bdad0d64}")]
	public Guid? InstanceMetricUid { get; set; }

	[BoolSettings(FieldName = "UseFormula")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[EntityProperty]
	[Uid("{718c5eda-c789-4848-affd-a3effee7d7d0}")]
	public bool UseFormula
	{
		[CompilerGenerated]
		get
		{
			return _003CUseFormula_003Ek__BackingField;
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
					_003CUseFormula_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
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

	[EnumSettings(FieldName = "Formula")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1db6a3f5-b1d5-433e-b80c-803c2b7213fd")]
	[Uid("{665a07b1-d664-423e-86d3-3d25d100de66}")]
	[EntityProperty]
	public ProcessMetricTaskRepeatAction Formula
	{
		[CompilerGenerated]
		get
		{
			return _003CFormula_003Ek__BackingField;
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
					_003CFormula_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
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

	[Uid("{810c4683-b93b-4442-8c24-5c4485e49094}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "CalculateAfterProcess")]
	[EntityProperty]
	public bool CalculateAfterProcess
	{
		[CompilerGenerated]
		get
		{
			return _003CCalculateAfterProcess_003Ek__BackingField;
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
					_003CCalculateAfterProcess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
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
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{0a44908b-963a-44e4-a18d-7c91219c37a9}")]
	[StringSettings(FieldName = "ScriptFunctionName")]
	public string ScriptFunctionName
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptFunctionName_003Ek__BackingField;
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
					_003CScriptFunctionName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[DoubleSettings(FieldName = "MinValue")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[Uid("0039e367-60d3-4b4f-b900-a859e7d79eff")]
	public double? MinValue { get; set; }

	[Uid("6afe81d0-a977-4ce6-bca7-4a6d876fb373")]
	[EntityProperty]
	[DoubleSettings(FieldName = "MinCriticalValue")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? MinCriticalValue { get; set; }

	[Uid("e5fdd51b-ff25-4ecf-88b0-add9c3f88f17")]
	[EntityProperty]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MaxDeviation")]
	public double? MaxDeviation { get; set; }

	[Uid("6a00a4a0-00fa-46da-a1b3-086404203864")]
	[EntityProperty]
	[DoubleSettings(FieldName = "MaxCriticalValue")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? MaxCriticalValue { get; set; }

	[Uid("17cbba29-0c8b-44f9-9286-1aeea20993b1")]
	[EntityProperty]
	[DoubleSettings(FieldName = "MaxValue")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? MaxValue { get; set; }

	[Uid("14dab7b9-56ef-442d-b719-8748797f768c")]
	[EntityProperty]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "ScaleUid")]
	public Guid? ScaleUid { get; set; }

	[BoolSettings(FieldName = "CheckForIndication")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("C1F4D8B0-51E4-4C5A-8ECB-1DB9CA1498EB")]
	[EntityProperty]
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
				case 0:
					return;
				case 1:
					_003CCheckForIndication_003Ek__BackingField = value;
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

	[XmlElement("MaxScaleValueDateTime")]
	public long MaxScaleValueDateTimeTicks
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan maxScaleValueDateTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					maxScaleValueDateTime = MaxScaleValueDateTime;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return maxScaleValueDateTime.Ticks;
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
					MaxScaleValueDateTime = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
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

	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "UsePeriodicity")]
	[Uid("{F2810652-09AE-41FB-A577-43FAE83F7600}")]
	[EntityProperty]
	public bool UsePeriodicity
	{
		[CompilerGenerated]
		get
		{
			return _003CUsePeriodicity_003Ek__BackingField;
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
					_003CUsePeriodicity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
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
	[GuidSettings(FieldName = "PeriodicityUid")]
	[Uid("{437A2C97-BBEF-4850-83FF-E2044E7C1C21}")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	public Guid? PeriodicityUid { get; set; }

	[Uid("{F9877E11-A050-414D-AAB6-0F36F924863A}")]
	[EntityProperty]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "IsPersonal")]
	public bool IsPersonal
	{
		[CompilerGenerated]
		get
		{
			return _003CIsPersonal_003Ek__BackingField;
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
					_003CIsPersonal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[GuidSettings(FieldName = "ExecutorMetadataUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{E46A4A70-95A8-4997-B0F8-5112F60F609A}")]
	[EntityProperty]
	public Guid? ExecutorMetadataUid { get; set; }

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[EntityProperty]
	[Uid("CE2F60A3-7403-441B-AA63-3075A28D4730")]
	[DoubleSettings(FieldName = "MinPerformancee")]
	public double? MinPerformance { get; set; }

	[EntityProperty]
	[Uid("D6C90F17-E338-49C7-BDA4-2669187321E7")]
	[DoubleSettings(FieldName = "PlanPerformance")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? PlanPerformance { get; set; }

	[EntityProperty]
	[DoubleSettings(FieldName = "MinNormalValue")]
	[Uid("9E950F78-633D-4141-9ABE-A9A7733FC658")]
	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	public double? MinNormalValue { get; set; }

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[DoubleSettings(FieldName = "MaxNormalValue")]
	[Uid("814B6EB3-CD7F-4680-A471-B339B2691D1A")]
	[EntityProperty]
	public double? MaxNormalValue { get; set; }

	[Property("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}")]
	[EntityProperty]
	[Uid("0D8C9DAF-9BFE-49B2-AE5A-284019C3E68B")]
	[DoubleSettings(FieldName = "MaxPerformance")]
	public double? MaxPerformance { get; set; }

	[EntityProperty]
	[Uid("{3B7181BD-A030-4623-8F9F-B5EDBA4BC184}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[EnumSettings(FieldName = "MinValueType")]
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[Uid("{6B33C874-666E-4B8A-8CAE-B6884208FF29}")]
	[EnumSettings(FieldName = "MaxValueType")]
	[EntityProperty]
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[Uid("{2DA208C9-5B90-4AA2-87DC-57F16BE43ECA}")]
	[EntityProperty]
	[EnumSettings(FieldName = "MinNormalValueType")]
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
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
	[EntityProperty]
	[Uid("{F4FF9FC7-7E26-4173-A3FE-4F852C948E22}")]
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
				case 1:
					_003CMaxNormalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
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

	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
	[EnumSettings(FieldName = "MinCriticalValueType")]
	[EntityProperty]
	[Uid("{92D86CE7-8A65-4EF8-B377-7FB543DEF108}")]
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
				case 1:
					_003CMinCriticalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
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
	[EnumSettings(FieldName = "MaxCriticalValueType")]
	[Uid("{11FA7AE7-4974-4EA3-9E61-2EBE6649F5B8}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
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
				case 0:
					return;
				case 1:
					_003CMaxCriticalValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool CanUseScale()
	{
		return MetricType == ProcessMetricType.Indicator;
	}

	public IIndicatorScale GetScale()
	{
		int num = 2;
		int num2 = num;
		Guid? scaleUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				ScaleUid = rXGbOnOLk8CjA4BAsT3H(IncreaseIndicatorScale.Instance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!scaleUid.HasValue)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return (IIndicatorScale)gfrAwPOLUGytFCl9cJJ6(Locator.GetServiceNotNull<IndicatorScaleService>(), ScaleUid.Value);
			case 2:
				scaleUid = ScaleUid;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
				{
					num2 = 1;
				}
				break;
			}
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
			case 1:
				ScaleUid = scale.Id;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public string GetMetricTypeAsString()
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		ProcessMetricComputationType type = default(ProcessMetricComputationType);
		while (true)
		{
			switch (num2)
			{
			case 2:
				type = Type;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (type == ProcessMetricComputationType.Technical)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				return (string)HkGSSUOLVLReX5wm5PD3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25801974));
			default:
				return (string)slZbHxOLAWZIIGRhhtEh(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EA40ED), new object[1] { ProcessMetricDataTypeToString(DataType) });
			case 3:
				break;
			}
			if (type != ProcessMetricComputationType.Time)
			{
				break;
			}
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
			{
				num2 = 4;
			}
		}
		throw new Exception((string)slZbHxOLAWZIIGRhhtEh(ayOUOXOLGyImd5Gti64r(-130098986 ^ -130080364), new object[1] { PS8UUiOL2A3UMQUQ8c0t(TArEc2OL7iSmkWDyseMw(typeof(ProcessMetricComputationType).TypeHandle), Type) }));
	}

	public string GetCalcTypeAsString()
	{
		int num = 8;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (u9xBj1OLokbexKD8ZtlV(ScriptFunctionName))
					{
						num2 = 6;
						break;
					}
					goto default;
				case 2:
					if (!u9xBj1OLokbexKD8ZtlV(ScriptFunctionName))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 8:
					if (CalculateAfterProcess)
					{
						num2 = 7;
						break;
					}
					return (string)HkGSSUOLVLReX5wm5PD3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862447050));
				case 7:
					text = (string)HkGSSUOLVLReX5wm5PD3(ayOUOXOLGyImd5Gti64r(-45832783 ^ -45786077));
					num2 = 2;
					break;
				case 4:
					text = (string)SfogoXOLFIZee7epBNJm(text, slZbHxOLAWZIIGRhhtEh(ayOUOXOLGyImd5Gti64r(0x361628FF ^ 0x3617D12F), new object[1] { ScriptFunctionName }));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					text = (string)SfogoXOLFIZee7epBNJm(text, slZbHxOLAWZIIGRhhtEh(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420038577), new object[1] { ModelHelper.GetEnumDisplayName(Formula) }));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (UseFormula)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 3:
					if (!UseFormula)
					{
						num2 = 4;
						break;
					}
					goto case 1;
				default:
					return text;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override string ToString()
	{
		return Name;
	}

	private string ProcessMetricDataTypeToString(ProcessMetricDataType value)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (value)
				{
				case ProcessMetricDataType.Integer:
					goto IL_0077;
				case ProcessMetricDataType.Float:
					return (string)HkGSSUOLVLReX5wm5PD3(ayOUOXOLGyImd5Gti64r(-1638225214 ^ -1638182794));
				case ProcessMetricDataType.TimeSpan:
					return SR.T((string)ayOUOXOLGyImd5Gti64r(-682910880 ^ -682991182));
				case ProcessMetricDataType.DateTime:
					goto end_IL_0012;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				goto IL_0077;
				IL_0077:
				return (string)HkGSSUOLVLReX5wm5PD3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935216189));
				end_IL_0012:
				break;
			}
			break;
		}
		throw new Exception((string)slZbHxOLAWZIIGRhhtEh(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647750620), new object[1] { Enum.GetName(typeof(ProcessMetricDataType), DataType) }));
	}

	public PeriodicityDTO GetPeriodicity()
	{
		int num = 1;
		int num2 = num;
		Guid? periodicityUid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			default:
				if (periodicityUid.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				periodicityUid = PeriodicityUid;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return null;
			case 2:
				if (UsePeriodicity)
				{
					return (PeriodicityDTO)FcoFkmOLiTvM3GnFrJ0Z(Locator.GetServiceNotNull<IPeriodicityDTOManager>(), PeriodicityUid.Value);
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetPeriodicity(PeriodicityDTO periodicity)
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
				PeriodicityUid = (UsePeriodicity ? hcYMfMOLIYoo42hGB6Am(periodicity) : Guid.Empty);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ProcessMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		imM8q7OLa9sXsfDqAnXJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UdqdMjOLCXeTU1i21v7k()
	{
		return lDN3x4OLpKoFvHZu07IU == null;
	}

	internal static ProcessMetric tNcbbPOLMWif9o3dSccp()
	{
		return lDN3x4OLpKoFvHZu07IU;
	}

	internal static Guid rXGbOnOLk8CjA4BAsT3H(object P_0)
	{
		return ((IndicatorScaleBase)P_0).Id;
	}

	internal static object gfrAwPOLUGytFCl9cJJ6(object P_0, Guid P_1)
	{
		return ((IndicatorScaleService)P_0).Get(P_1);
	}

	internal static object HkGSSUOLVLReX5wm5PD3(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object slZbHxOLAWZIIGRhhtEh(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object ayOUOXOLGyImd5Gti64r(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type TArEc2OL7iSmkWDyseMw(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static object PS8UUiOL2A3UMQUQ8c0t(Type P_0, object P_1)
	{
		return Enum.GetName(P_0, P_1);
	}

	internal static bool u9xBj1OLokbexKD8ZtlV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object SfogoXOLFIZee7epBNJm(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object FcoFkmOLiTvM3GnFrJ0Z(object P_0, Guid P_1)
	{
		return ((IPeriodicityDTOManager)P_0).LoadOrNull(P_1);
	}

	internal static Guid hcYMfMOLIYoo42hGB6Am(object P_0)
	{
		return ((PeriodicityDTO)P_0).Id;
	}

	internal static void imM8q7OLa9sXsfDqAnXJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
