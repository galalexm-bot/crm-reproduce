using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Mappings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[BaseClass("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
[Entity("ProcessMetricsContainer")]
[DisplayName(typeof(__Resources_ProcessMetricsCollection), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[Uid("123D7DBE-3668-4CE1-8250-434C1E6F3A32")]
[ClassMap(typeof(ProcessMetricsContainerMap))]
public class ProcessMetricsContainer : EntityMetadata, IProcessContext, IEntityMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		private static Info pptFVlv8HC16qfX9XwI9;

		public string Name => (string)Dr4LVBv8W6KPyiU9jwFu(hqKQ6Jv89wFlTopLTpHO(-398691253 ^ -398618097));

		public string Description => string.Empty;

		public Type MetadataType => typeof(ProcessMetricsContainer);

		public Type GeneratorType => eeY1xKv8jtalp9HIRJur(typeof(ProcessMetricsGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object hqKQ6Jv89wFlTopLTpHO(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Dr4LVBv8W6KPyiU9jwFu(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool BY2BPuv8LoIbNGUtmEiK()
		{
			return pptFVlv8HC16qfX9XwI9 == null;
		}

		internal static Info rukvxNv8fMB6XYpc6O7h()
		{
			return pptFVlv8HC16qfX9XwI9;
		}

		internal static Type eeY1xKv8jtalp9HIRJur(RuntimeTypeHandle P_0)
		{
			return System.Type.GetTypeFromHandle(P_0);
		}
	}

	public new const string UID_S = "123D7DBE-3668-4CE1-8250-434C1E6F3A32";

	private static Guid _UID;

	internal static ProcessMetricsContainer KgspDNOfvytgcELlsdfp;

	public override Guid TypeUid
	{
		get
		{
			return _UID;
		}
		set
		{
		}
	}

	[XmlElement("AssemblyName")]
	[StringSettings(FieldName = "AssemblyName")]
	[Uid("{DD47E56B-B35B-45B2-B1C8-E4BCC1713C26}")]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string AssemblyName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
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
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("AssemblyRaw", IsNullable = true)]
	[EntityProperty]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[Uid("{8014D933-8065-47B3-8AA4-14EDD8E2F435}")]
	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	public virtual byte[] AssemblyRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyRaw_003Ek__BackingField;
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
					_003CAssemblyRaw_003Ek__BackingField = value;
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

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		ProcessMetric processMetric = new ProcessMetric();
		Sd6tEqOfsyeDFAsljMMv(processMetric, Guid.NewGuid());
		return processMetric;
	}

	public ProcessMetricsContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
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

	static ProcessMetricsContainer()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				iZ6IdKOfJaVmSx7IUryR();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B73EA));
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

	internal static bool JnKGTIOfYS9U3wVRrr8f()
	{
		return KgspDNOfvytgcELlsdfp == null;
	}

	internal static ProcessMetricsContainer lFs4FCOf8otypYrXQS8r()
	{
		return KgspDNOfvytgcELlsdfp;
	}

	internal static void Sd6tEqOfsyeDFAsljMMv(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static void iZ6IdKOfJaVmSx7IUryR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
