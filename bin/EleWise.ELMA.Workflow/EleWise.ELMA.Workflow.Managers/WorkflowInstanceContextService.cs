using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Service)]
[Service]
public class WorkflowInstanceContextService : NHManager
{
	private class ProcessTypesInfo
	{
		internal static object wchSXSZporTWD3OOM0ia;

		public Assembly Assembly
		{
			[CompilerGenerated]
			get
			{
				return _003CAssembly_003Ek__BackingField;
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
						_003CAssembly_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
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

		public Type ContextType
		{
			[CompilerGenerated]
			get
			{
				return _003CContextType_003Ek__BackingField;
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
						_003CContextType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
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

		public Type InstanceMetricValuesType
		{
			[CompilerGenerated]
			get
			{
				return _003CInstanceMetricValuesType_003Ek__BackingField;
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
						_003CInstanceMetricValuesType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Type ProcessMetricValuesType
		{
			[CompilerGenerated]
			get
			{
				return _003CProcessMetricValuesType_003Ek__BackingField;
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
						_003CProcessMetricValuesType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ProcessTypesInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			rrVHtDZpIhc0GMpc8UqU();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool JYUCGuZpFwqXyHKIauwC()
		{
			return wchSXSZporTWD3OOM0ia == null;
		}

		internal static ProcessTypesInfo FJ7ctmZpietZcu5qlSsY()
		{
			return (ProcessTypesInfo)wchSXSZporTWD3OOM0ia;
		}

		internal static void rrVHtDZpIhc0GMpc8UqU()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	protected const string ProcessIdKey = "WorkflowProcessIdBy_";

	private ConcurrentDictionary<long, ProcessTypesInfo> _loadedContextTypesInfo;

	private Func<long, EntityMetadata> getInstanceMetricValuesMetadata;

	private Func<long, EntityMetadata> getProcessMetricValuesMetadata;

	private Func<long, EntityMetadata> getFullProcessMetricValuesMetadata;

	private static WorkflowInstanceContextService nfX3gsLFfZ3Gk6HfNBS;

	public IMetadataRuntimeService MetadataRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataRuntimeService_003Ek__BackingField;
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
					_003CMetadataRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
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

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
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

	public ICacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMemoryCacheService MemoryCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CMemoryCacheService_003Ek__BackingField;
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
					_003CMemoryCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowMetadataLoaderService WorkflowMetadataLoaderService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMetadataLoaderService_003Ek__BackingField;
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
					_003CWorkflowMetadataLoaderService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static WorkflowInstanceContextService Instance => Locator.GetServiceNotNull<WorkflowInstanceContextService>();

	public long? GetHeaderIdByFullMetadataUid(Guid metadataUid)
	{
		return WorkflowMetadataLoaderService.GetHeaderIdByFullMetadataUid(metadataUid);
	}

	public virtual Type GetInstanceContextType(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				GetInstanceContextAssembly(process, out type);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return type;
			}
		}
	}

	public virtual Type GetInstanceContextType(long processId)
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return type;
			case 1:
			{
				GetInstanceContextAssembly(processId, out type, out var _, out var _);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public virtual EntityMetadata GetInstanceContextMetadata(IWorkflowProcess process)
	{
		return (EntityMetadata)gD3LCmLry5upBkmNkTS(kyrEgfLaNWIR1uoAPQ1(this, process), true, true);
	}

	public virtual EntityMetadata GetInstanceContextMetadata(long processId)
	{
		return (EntityMetadata)MetadataLoader.LoadMetadata(EIW3BaLe6JnIjFEEaA6(this, processId));
	}

	public virtual EntityMetadata GetInstanceContextMetadata(WorkflowInstanceContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(context, (string)updjZALND0Iv1Pu2apF(0x74AB4717 ^ 0x74AB7827));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (EntityMetadata)gD3LCmLry5upBkmNkTS(context.CastAsRealType().GetType(), true, true);
			}
		}
	}

	public virtual IPropertyMetadata GetInstanceContextPropertyMetadata(IWorkflowProcess process, Guid propertyUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ((EntityMetadata)hv3bjkLxs7VJiB2VJvq(this, process)).GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass32_._003CGetInstanceContextPropertyMetadata_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass32_.propertyUid = propertyUid;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual IPropertyMetadata GetInstanceContextPropertyMetadata(long processId, Guid propertyUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = default(_003C_003Ec__DisplayClass33_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass33_.propertyUid = propertyUid;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ((EntityMetadata)VdYmsILSmNgsX4BCHbo(this, processId)).GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass33_._003CGetInstanceContextPropertyMetadata_003Eb__0);
			}
		}
	}

	public virtual IPropertyMetadata GetInstanceContextPropertyMetadata(WorkflowInstanceContext context, Guid propertyUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass34_.propertyUid = propertyUid;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ((EntityMetadata)kgxBthL1ikD2481hmgH(this, context)).GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass34_._003CGetInstanceContextPropertyMetadata_003Eb__0);
			}
		}
	}

	public virtual Type GetInstanceContextFilterType(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_00c5, IL_00d4
		int num = 6;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 6:
				Contract.ArgumentNotNull(process, (string)updjZALND0Iv1Pu2apF(-1776305410 ^ -1776309620));
				num2 = 5;
				break;
			case 4:
			{
				Type type2;
				Assembly instanceContextAssembly = GetInstanceContextAssembly(process, out type2);
				string name = (string)YBi4M5LwNZpwC4HqAXK(WCRd07LE2NKrOP9jEB4((EntityMetadata)MetadataLoader.LoadMetadata(type2)), updjZALND0Iv1Pu2apF(-10408775 ^ -10385229));
				type = instanceContextAssembly.GetType(name);
				num2 = 2;
				break;
			}
			case 1:
				return null;
			case 3:
				return type;
			default:
				if (type.GetReflectionProperties().Length != 0)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 5:
				z0uRGCLhxQ5r6fhYndK(MetadataRuntimeService, updjZALND0Iv1Pu2apF(0x141C968 ^ 0x1416AB2));
				num2 = 4;
				break;
			case 2:
				if (HKvWBrL4Yru0nImejDh(type, null))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual Type GetFullInstanceContextType(IWorkflowProcess process)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return hqZYYifOt0NYmpbxXWe(WorkflowMetadataLoaderService, ((IEntity<long>)NyHjUIfKQK0AKYHMFPn(process)).Id, false);
			case 2:
				IAmXQBLzcI17wLFmo8F(process, updjZALND0Iv1Pu2apF(0x246EEF98 ^ 0x246EFFEA));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(NyHjUIfKQK0AKYHMFPn(process), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452087485));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual Type GetFullInstanceContextType(IProcessHeader header)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				IAmXQBLzcI17wLFmo8F(header, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD06CBB));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return hqZYYifOt0NYmpbxXWe(WorkflowMetadataLoaderService, header.Id, true);
			}
		}
	}

	public virtual EntityMetadata GetFullInstanceContextMetadata(IProcessHeader header)
	{
		return (EntityMetadata)gD3LCmLry5upBkmNkTS(Gvg4sPfZ7xHbaxJMKC3(this, header), true, true);
	}

	public virtual EntityMetadata GetFullInstanceContextMetadata(long headerId)
	{
		return (EntityMetadata)gD3LCmLry5upBkmNkTS(hqZYYifOt0NYmpbxXWe(WorkflowMetadataLoaderService, headerId, true), true, true);
	}

	public virtual IPropertyMetadata GetFullInstanceContextPropertyMetadata(IProcessHeader header, Guid propertyUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ((EntityMetadata)TrsnBkfvy3WLjYjeSMC(this, header)).GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass40_._003CGetFullInstanceContextPropertyMetadata_003Eb__0);
			default:
				_003C_003Ec__DisplayClass40_.propertyUid = propertyUid;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IPropertyMetadata GetFullInstanceContextPropertyMetadata(long headerId, Guid propertyUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = default(_003C_003Ec__DisplayClass41_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ((EntityMetadata)Lbq0nwfYlxovd5lYvIn(this, headerId)).GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass41_._003CGetFullInstanceContextPropertyMetadata_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass41_.propertyUid = propertyUid;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual WorkflowInstanceContext LoadWorkflowInstanceContext(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0108
		int num = 1;
		int num2 = num;
		PropertyInfo property = default(PropertyInfo);
		WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
		Type type = default(Type);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				IAmXQBLzcI17wLFmo8F(instance, updjZALND0Iv1Pu2apF(-452127399 ^ -452113313));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				property = workflowInstanceContext.GetType().GetProperty((string)updjZALND0Iv1Pu2apF(-684210684 ^ -684220754));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				if (yf3vXPf0t7eeVMUe2bI(property, null))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 3;
			case 3:
			case 10:
				return workflowInstanceContext;
			case 2:
				type = uQWHxEfsjptaGmalf2L(this, UxC8ulf8eEPcekjr6Fi(instance));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 9;
				}
				break;
			case 6:
				if (num3 > 0)
				{
					num2 = 10;
					break;
				}
				goto case 5;
			case 4:
				workflowInstanceContext = (WorkflowInstanceContext)r8WcMwflDC02NMsGU4p(kyrEgfLaNWIR1uoAPQ1(this, UxC8ulf8eEPcekjr6Fi(instance)), new object[2] { num3, type });
				num2 = 6;
				break;
			case 9:
				num3 = zJFPiWfJDXPdq968H9S(this, type, instance);
				num2 = 4;
				break;
			default:
				IAmXQBLzcI17wLFmo8F(instance.Process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EFA459));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				hQ5kG6fyRrQIUxMr6l3(property, workflowInstanceContext, instance, null);
				num2 = 3;
				break;
			}
		}
	}

	public virtual WorkflowInstanceContext CheckWorkflowInstanceContext(IWorkflowInstance instance, WorkflowInstanceContext context)
	{
		//Discarded unreachable code: IL_0097
		int num = 3;
		int num2 = num;
		PropertyInfo property = default(PropertyInfo);
		Type instanceContextType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 9:
				throw new InvalidOperationException((string)dAq7vcfmUeTVabxTstC(updjZALND0Iv1Pu2apF(-1895853023 ^ -1895878529)));
			case 1:
				property = context.GetType().GetProperty((string)updjZALND0Iv1Pu2apF(0x350C0E8 ^ 0x3509842));
				num2 = 8;
				break;
			case 8:
				if (yf3vXPf0t7eeVMUe2bI(property, null))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				return context;
			case 6:
				if (!HKvWBrL4Yru0nImejDh(context.CastAsRealType().GetType(), instanceContextType))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			default:
				hQ5kG6fyRrQIUxMr6l3(property, context, instance, null);
				num2 = 4;
				break;
			case 2:
				IAmXQBLzcI17wLFmo8F(UxC8ulf8eEPcekjr6Fi(instance), updjZALND0Iv1Pu2apF(0x101D10F ^ 0x1017535));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (context == null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					instanceContextType = GetInstanceContextType((IWorkflowProcess)UxC8ulf8eEPcekjr6Fi(instance));
					num2 = 6;
				}
				break;
			case 5:
				return null;
			case 3:
				IAmXQBLzcI17wLFmo8F(instance, updjZALND0Iv1Pu2apF(-1430645277 ^ -1430631195));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual WorkflowInstanceContext LoadWorkflowInstanceContext(Type contextType, long id)
	{
		//Discarded unreachable code: IL_0130, IL_013f, IL_0289, IL_0293, IL_02a2, IL_02b1
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		IWorkflowProcess workflowProcess2 = default(IWorkflowProcess);
		long? processIdFromCache = default(long?);
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		string key = default(string);
		while (true)
		{
			IWorkflowProcess workflowProcess;
			switch (num2)
			{
			case 4:
			case 8:
				type = uQWHxEfsjptaGmalf2L(this, workflowProcess2);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 9;
				}
				continue;
			default:
				if (!processIdFromCache.HasValue)
				{
					num2 = 3;
					continue;
				}
				workflowProcess = WorkflowProcessManager.Load(processIdFromCache.Value);
				break;
			case 1:
				_003C_003Ec__DisplayClass44_.metadata = (IMetadata)gD3LCmLry5upBkmNkTS(contextType, true, true);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 5;
				}
				continue;
			case 10:
				if (_003C_003Ec__DisplayClass44_.metadata != null)
				{
					num2 = 12;
					continue;
				}
				goto case 5;
			case 9:
				return (WorkflowInstanceContext)Activator.CreateInstance(contextType, id, type);
			case 7:
				if (workflowProcess2 != null)
				{
					num2 = 6;
					continue;
				}
				goto case 11;
			case 14:
				SaveProcessIdToCache(key, workflowProcess2.Id);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 4;
				}
				continue;
			case 5:
				throw new MetadataException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22388952), contextType.FullName));
			case 12:
				key = string.Concat(updjZALND0Iv1Pu2apF(0x1C663DA1 ^ 0x1C669895), my7TT6ft4vBcx7kr0ii(_003C_003Ec__DisplayClass44_.metadata));
				num2 = 13;
				continue;
			case 13:
				processIdFromCache = GetProcessIdFromCache(key);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
			{
				WorkflowProcessManager workflowProcessManager = WorkflowProcessManager;
				ParameterExpression parameterExpression = Expression.Parameter(TsHOqdfbG0wv39F0IFy(typeof(IWorkflowProcess).TypeHandle), (string)updjZALND0Iv1Pu2apF(-763667953 ^ -763625663));
				workflowProcess = workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>((Expression)QsCwPNfXNtwfUW49Ypo(fkJeZtfgguqObISFeYO(fkJeZtfgguqObISFeYO(parameterExpression, (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property((Expression)Y0wJNSfPkfWmL3vQMbR(WSAx4pfBD0yue35Ysp1(_003C_003Ec__DisplayClass44_, TsHOqdfbG0wv39F0IFy(typeof(_003C_003Ec__DisplayClass44_0).TypeHandle)), gcXjmWfcrnSlwBb12IK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				break;
			}
			case 2:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num2 = 0;
				}
				continue;
			case 11:
				throw new MetadataException(SR.T((string)updjZALND0Iv1Pu2apF(-2122743969 ^ -2122720757), my7TT6ft4vBcx7kr0ii(_003C_003Ec__DisplayClass44_.metadata)));
			case 6:
				if (processIdFromCache.HasValue)
				{
					num2 = 8;
					continue;
				}
				goto case 14;
			}
			workflowProcess2 = workflowProcess;
			num2 = 7;
		}
	}

	public virtual Type GetInstanceMetricValuesType(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		Type instanceMetricValuesType = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return instanceMetricValuesType;
			case 1:
			{
				GetInstanceContextAssembly(process, out var _, out instanceMetricValuesType, out var _);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public virtual EntityMetadata GetInstanceMetricValuesMetadata(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return getInstanceMetricValuesMetadata(process.Id);
			default:
				z0uRGCLhxQ5r6fhYndK(MemoryCacheService, updjZALND0Iv1Pu2apF(0x350C0E8 ^ 0x3506530));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				IAmXQBLzcI17wLFmo8F(process, updjZALND0Iv1Pu2apF(0x438A0E43 ^ 0x438A1E31));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual Type GetFullInstanceMetricValuesType(IWorkflowProcess process)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(NyHjUIfKQK0AKYHMFPn(process), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F53EE46));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD304CB0));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return TpZBi9fdLjEGXdGYkUi(WorkflowMetadataLoaderService, ((IEntity<long>)NyHjUIfKQK0AKYHMFPn(process)).Id);
			}
		}
	}

	public virtual WorkflowInstanceMetricValues LoadWorkflowInstanceMetricValues(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_00dc, IL_00eb, IL_0124
		int num = 9;
		PropertyInfo property = default(PropertyInfo);
		WorkflowInstanceMetricValues workflowInstanceMetricValues = default(WorkflowInstanceMetricValues);
		long num3 = default(long);
		Type fullInstanceMetricValuesType = default(Type);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					property.SetValue(workflowInstanceMetricValues, instance, null);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
					return null;
				case 2:
					num3 = zJFPiWfJDXPdq968H9S(this, fullInstanceMetricValuesType, instance);
					num2 = 12;
					continue;
				case 10:
					fullInstanceMetricValuesType = GetFullInstanceMetricValuesType(instance.Process);
					num2 = 13;
					continue;
				case 8:
					IAmXQBLzcI17wLFmo8F(UxC8ulf8eEPcekjr6Fi(instance), updjZALND0Iv1Pu2apF(0x1AF6F1F2 ^ 0x1AF655C8));
					num2 = 10;
					continue;
				default:
					property = workflowInstanceMetricValues.GetType().GetProperty((string)updjZALND0Iv1Pu2apF(--296112178 ^ 0x11A60898));
					num2 = 7;
					continue;
				case 3:
					return null;
				case 14:
					if (!L12nWJfu5udEHDPEjZm(type, null))
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 4:
				case 6:
					return workflowInstanceMetricValues;
				case 9:
					break;
				case 1:
					if (num3 <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 7:
					if (!(property != null))
					{
						num2 = 4;
						continue;
					}
					goto case 5;
				case 13:
					if (!L12nWJfu5udEHDPEjZm(fullInstanceMetricValuesType, null))
					{
						type = s38gtgfDWU6yZrb2cS1(this, UxC8ulf8eEPcekjr6Fi(instance));
						num2 = 14;
						continue;
					}
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					workflowInstanceMetricValues = (WorkflowInstanceMetricValues)Activator.CreateInstance(type, num3, fullInstanceMetricValuesType);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			IAmXQBLzcI17wLFmo8F(instance, updjZALND0Iv1Pu2apF(-642713667 ^ -642732357));
			num = 8;
		}
	}

	public virtual WorkflowInstanceMetricValues LoadWorkflowInstanceMetricValues(Type metricValuesType, long id)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0197, IL_0260, IL_026f, IL_02c0
		int num = 5;
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = default(_003C_003Ec__DisplayClass49_0);
		long? processIdFromCache = default(long?);
		string key = default(string);
		IWorkflowProcess workflowProcess2 = default(IWorkflowProcess);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IWorkflowProcess workflowProcess;
				switch (num2)
				{
				case 3:
					throw new MetadataException((string)TiA3Y9fnSy6VrSDDWwH(updjZALND0Iv1Pu2apF(-45832783 ^ -45874277), new object[1] { my7TT6ft4vBcx7kr0ii(_003C_003Ec__DisplayClass49_.metadata) }));
				case 11:
					if (processIdFromCache.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto end_IL_0012;
				case 7:
					if (_003C_003Ec__DisplayClass49_.metadata == null)
					{
						num2 = 8;
						continue;
					}
					key = (string)TfyqXkfH3SwFEQa6a10(updjZALND0Iv1Pu2apF(0x7AC609FE ^ 0x7AC6AFFE), my7TT6ft4vBcx7kr0ii(_003C_003Ec__DisplayClass49_.metadata));
					num2 = 12;
					continue;
				case 1:
				{
					WorkflowProcessManager workflowProcessManager = WorkflowProcessManager;
					ParameterExpression parameterExpression = (ParameterExpression)XQFHoHfLnbxAoc8xHRN(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574584259));
					workflowProcess = workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>((Expression)QsCwPNfXNtwfUW49Ypo(fkJeZtfgguqObISFeYO(fkJeZtfgguqObISFeYO(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), fkJeZtfgguqObISFeYO(Expression.Field((Expression)WSAx4pfBD0yue35Ysp1(_003C_003Ec__DisplayClass49_, TsHOqdfbG0wv39F0IFy(typeof(_003C_003Ec__DisplayClass49_0).TypeHandle)), (FieldInfo)gcXjmWfcrnSlwBb12IK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
					break;
				}
				default:
					if (processIdFromCache.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 1;
				case 8:
					throw new MetadataException((string)TiA3Y9fnSy6VrSDDWwH(updjZALND0Iv1Pu2apF(0x614274E3 ^ 0x6142D03B), new object[1] { metricValuesType.FullName }));
				case 14:
					if (workflowProcess2 != null)
					{
						num2 = 11;
						continue;
					}
					goto case 3;
				case 9:
					return (WorkflowInstanceMetricValues)r8WcMwflDC02NMsGU4p(metricValuesType, new object[2] { id, type });
				case 2:
					goto end_IL_0012;
				case 12:
					processIdFromCache = GetProcessIdFromCache(key);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
				case 10:
					type = uQWHxEfsjptaGmalf2L(this, workflowProcess2);
					num2 = 9;
					continue;
				case 4:
					_003C_003Ec__DisplayClass49_.metadata = (IMetadata)gD3LCmLry5upBkmNkTS(metricValuesType, true, true);
					num2 = 7;
					continue;
				case 5:
					_003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
					num2 = 4;
					continue;
				case 13:
					workflowProcess = WorkflowProcessManager.Load(processIdFromCache.Value);
					break;
				}
				workflowProcess2 = workflowProcess;
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			SaveProcessIdToCache(key, workflowProcess2.Id);
			num = 10;
		}
	}

	public virtual Type GetProcessMetricValuesType(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		Type processMetricValuesType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				GetInstanceContextAssembly(process, out var _, out var _, out processMetricValuesType);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				return processMetricValuesType;
			}
		}
	}

	public virtual EntityMetadata GetProcessMetricValuesMetadata(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				z0uRGCLhxQ5r6fhYndK(MemoryCacheService, updjZALND0Iv1Pu2apF(0x213F6477 ^ 0x213FC1AF));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				IAmXQBLzcI17wLFmo8F(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145AEA5));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return getProcessMetricValuesMetadata(process.Id);
			}
		}
	}

	public virtual Type GetFullProcessMetricValuesType(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA73299C));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				IAmXQBLzcI17wLFmo8F(NyHjUIfKQK0AKYHMFPn(process), updjZALND0Iv1Pu2apF(-2057730233 ^ -2057755811));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return WorkflowMetadataLoaderService.GetFullProcessMetricValuesType(((IEntity<long>)NyHjUIfKQK0AKYHMFPn(process)).Id);
			}
		}
	}

	public virtual Type GetFullProcessMetricValuesType(IProcessHeader header)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return dMOYr1ffpmVhD1gF3ul(WorkflowMetadataLoaderService, header.Id);
			case 1:
				Contract.ArgumentNotNull(header, (string)updjZALND0Iv1Pu2apF(0x34EA50D4 ^ 0x34EA39EA));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual EntityMetadata GetFullProcessMetricValuesMetadata(IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				IAmXQBLzcI17wLFmo8F(process, updjZALND0Iv1Pu2apF(--727842433 ^ 0x2B61EEF3));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetFullProcessMetricValuesMetadata(process.Header);
			}
		}
	}

	public virtual EntityMetadata GetFullProcessMetricValuesMetadata(IProcessHeader header)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				IAmXQBLzcI17wLFmo8F(header, updjZALND0Iv1Pu2apF(-1001967776 ^ -1001961890));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return getFullProcessMetricValuesMetadata(header.Id);
			default:
				Contract.ServiceNotNull(MemoryCacheService, (string)updjZALND0Iv1Pu2apF(0x141C968 ^ 0x1416CB0));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual WorkflowProcessMetricValues LoadWorkflowProcessMetricValues(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_00f0, IL_00ff
		int num = 1;
		int num2 = num;
		Type fullProcessMetricValuesType = default(Type);
		Type type = default(Type);
		long fullProcessMetricsId = default(long);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (!L12nWJfu5udEHDPEjZm(fullProcessMetricValuesType, null))
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 2:
				return null;
			case 6:
				type = N0Kai3f92jHgl7ZSSmc(this, process);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				return null;
			case 5:
				if (!L12nWJfu5udEHDPEjZm(type, null))
				{
					fullProcessMetricsId = GetFullProcessMetricsId(fullProcessMetricValuesType);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25713768));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return (WorkflowProcessMetricValues)Activator.CreateInstance(type, fullProcessMetricsId, fullProcessMetricValuesType);
			default:
				fullProcessMetricValuesType = GetFullProcessMetricValuesType(process);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public virtual WorkflowProcessMetricValues LoadWorkflowProcessMetricValues(Type metricValuesType, long id)
	{
		//Discarded unreachable code: IL_015c, IL_016b, IL_0297, IL_0311, IL_0320
		int num = 5;
		int num2 = num;
		string key = default(string);
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = default(_003C_003Ec__DisplayClass57_0);
		IWorkflowProcess workflowProcess2 = default(IWorkflowProcess);
		long? processIdFromCache = default(long?);
		Type type = default(Type);
		while (true)
		{
			IWorkflowProcess workflowProcess;
			switch (num2)
			{
			case 11:
				throw new MetadataException((string)TiA3Y9fnSy6VrSDDWwH(updjZALND0Iv1Pu2apF(0x1C7F6FED ^ 0x1C7FCB35), new object[1] { metricValuesType.FullName }));
			case 13:
				key = (string)TfyqXkfH3SwFEQa6a10(updjZALND0Iv1Pu2apF(-2077784392 ^ -2077810592), my7TT6ft4vBcx7kr0ii(_003C_003Ec__DisplayClass57_.metadata));
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 10;
				}
				continue;
			case 5:
				_003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
				num2 = 4;
				continue;
			case 3:
				if (workflowProcess2 == null)
				{
					num2 = 9;
					continue;
				}
				if (processIdFromCache.HasValue)
				{
					num2 = 6;
					continue;
				}
				goto default;
			case 9:
				throw new MetadataException((string)TiA3Y9fnSy6VrSDDWwH(updjZALND0Iv1Pu2apF(-720457373 ^ -720497053), new object[1] { my7TT6ft4vBcx7kr0ii(_003C_003Ec__DisplayClass57_.metadata) }));
			case 10:
				processIdFromCache = GetProcessIdFromCache(key);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass57_.metadata = (IMetadata)gD3LCmLry5upBkmNkTS(metricValuesType, true, true);
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 7;
				}
				continue;
			case 1:
				return (WorkflowProcessMetricValues)r8WcMwflDC02NMsGU4p(metricValuesType, new object[2] { id, type });
			default:
				SaveProcessIdToCache(key, workflowProcess2.Id);
				num2 = 7;
				continue;
			case 8:
			{
				WorkflowProcessManager workflowProcessManager = WorkflowProcessManager;
				ParameterExpression parameterExpression = Expression.Parameter(TsHOqdfbG0wv39F0IFy(typeof(IWorkflowProcess).TypeHandle), (string)updjZALND0Iv1Pu2apF(-29981480 ^ -30006890));
				workflowProcess = workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>((Expression)QsCwPNfXNtwfUW49Ypo(fkJeZtfgguqObISFeYO(fkJeZtfgguqObISFeYO(parameterExpression, (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), fkJeZtfgguqObISFeYO(Y0wJNSfPkfWmL3vQMbR(WSAx4pfBD0yue35Ysp1(_003C_003Ec__DisplayClass57_, typeof(_003C_003Ec__DisplayClass57_0)), gcXjmWfcrnSlwBb12IK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				break;
			}
			case 6:
			case 7:
				type = uQWHxEfsjptaGmalf2L(this, workflowProcess2);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				if (_003C_003Ec__DisplayClass57_.metadata != null)
				{
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 11;
			case 2:
				if (!processIdFromCache.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 8;
					}
					continue;
				}
				workflowProcess = WorkflowProcessManager.Load(processIdFromCache.Value);
				break;
			}
			workflowProcess2 = workflowProcess;
			num2 = 3;
		}
	}

	protected virtual long GetFullInstanceContextId(Type fullContextType, IWorkflowInstance workflowInstance)
	{
		int num = 3;
		int num2 = num;
		IList<long> list = default(IList<long>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (HA0sSBfTEeiPs6wTVNH(list) <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return list[0];
			default:
				return 0L;
			case 2:
				return 0L;
			case 3:
				if (!EntityManager<IWorkflowInstance>.Instance.IsNew(workflowInstance))
				{
					list = ((ICriteria)aJs7rBf33AYrEH7IPuh(zRH8Djf6pDE6TKPuGXd(voo3RSfjXmw0dDvN6wT(oBVE73fWwUMVsWRobCl(this), fullContextType), zKN5QXfRMdwFfxp8K1B(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539500317), workflowInstance)), new IProjection[1] { (IProjection)tJbxbBfqx9JOZvw1spy(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776288648)) })).List<long>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual long GetFullProcessMetricsId(Type fullContextType)
	{
		int num = 2;
		int num2 = num;
		long? num3 = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!num3.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 0;
					}
					break;
				}
				return num3.Value;
			default:
				return 0L;
			case 2:
				num3 = ((ICriteria)aJs7rBf33AYrEH7IPuh(((ISession)oBVE73fWwUMVsWRobCl(this)).CreateCriteria(fullContextType), new IProjection[1] { (IProjection)Projections.Min((string)updjZALND0Iv1Pu2apF(-1516552726 ^ -1516536980)) })).UniqueResult<long?>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual Assembly GetInstanceContextAssembly(IWorkflowProcess process, out Type type)
	{
		Type instanceMetricValuesType;
		Type processMetricValuesType;
		return GetInstanceContextAssembly(process, out type, out instanceMetricValuesType, out processMetricValuesType);
	}

	protected virtual Assembly GetInstanceContextAssembly(long processId, out Type type, out Type instanceMetricValuesType, out Type processMetricValuesType)
	{
		int num = 2;
		ProcessTypesInfo value = default(ProcessTypesInfo);
		IWorkflowProcess process = default(IWorkflowProcess);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					instanceMetricValuesType = value.InstanceMetricValuesType;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					return (Assembly)XyU60RfCBonFEfvFEM4(value);
				case 1:
					type = pLsSWbfQodQbYYVHLF4(value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return GetInstanceContextAssembly(process, out type, out instanceMetricValuesType, out processMetricValuesType);
				case 2:
					if (!_loadedContextTypesInfo.TryGetValue(processId, out value))
					{
						process = WorkflowProcessManager.Load(processId);
						num2 = 3;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				}
				break;
			}
			processMetricValuesType = vOXIuJfp0Okg3hPAfYx(value);
			num = 4;
		}
	}

	protected internal virtual Assembly GetInstanceContextAssembly(IWorkflowProcess process, out Type type, out Type instanceMetricValuesType, out Type processMetricValuesType)
	{
		//Discarded unreachable code: IL_015b, IL_016a, IL_023f, IL_024e, IL_02a8, IL_02c6, IL_03fe, IL_040d, IL_0446, IL_0465, IL_0474, IL_04a1, IL_04b0, IL_04bf, IL_067e, IL_068d, IL_06f2, IL_086f, IL_08af, IL_08be, IL_08ca, IL_09c7, IL_09d6, IL_09e6, IL_09f5
		int num = 42;
		ProcessTypesInfo value = default(ProcessTypesInfo);
		ProcessContext processContext = default(ProcessContext);
		ConcurrentDictionary<long, ProcessTypesInfo> loadedContextTypesInfo = default(ConcurrentDictionary<long, ProcessTypesInfo>);
		bool lockTaken = default(bool);
		Assembly assembly = default(Assembly);
		Assembly assembly2 = default(Assembly);
		WorkflowInstanceContextService obj = default(WorkflowInstanceContextService);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					processMetricValuesType = vOXIuJfp0Okg3hPAfYx(value);
					num2 = 14;
					continue;
				case 28:
					throw new MetadataException((string)DnYCoNf1qVmSEUxcXKM(dAq7vcfmUeTVabxTstC(updjZALND0Iv1Pu2apF(0x2269BD32 ^ 0x226914BE)), dAq7vcfmUeTVabxTstC(BYJMglfxoRXNPOPLZjp(process)), wFveOmf7gQI5Q893e5T(processContext), WCRd07LE2NKrOP9jEB4(qCfX7KfEBmeUNu2khdY(process))));
				case 39:
					loadedContextTypesInfo = _loadedContextTypesInfo;
					num2 = 32;
					continue;
				case 27:
					if (qCfX7KfEBmeUNu2khdY(process) != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 39;
				case 25:
					if (oudvQVfk0AVsSBgvoqn(process) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 41:
					z0uRGCLhxQ5r6fhYndK(MetadataRuntimeService, updjZALND0Iv1Pu2apF(0x12F686A ^ 0x12FCBB0));
					num2 = 30;
					continue;
				case 36:
					if (processContext.AssemblyRaw.Length == 0)
					{
						num2 = 9;
						continue;
					}
					break;
				case 1:
					lockTaken = false;
					num2 = 16;
					continue;
				case 24:
					throw new MetadataException((string)DnYCoNf1qVmSEUxcXKM(dAq7vcfmUeTVabxTstC(updjZALND0Iv1Pu2apF(-1600060848 ^ -1600017762)), dAq7vcfmUeTVabxTstC(BYJMglfxoRXNPOPLZjp(process)), wFveOmf7gQI5Q893e5T(processContext), ((ClassMetadata)L4RCyffhg3oI4vZBqi1(process)).FullTypeName));
				case 21:
				case 40:
					processMetricValuesType = null;
					num2 = 27;
					continue;
				case 7:
				case 9:
					assembly = assembly2;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 3;
					}
					continue;
				case 23:
					if (string.IsNullOrEmpty(((ClassMetadata)L4RCyffhg3oI4vZBqi1(process)).TypeName))
					{
						num2 = 40;
						continue;
					}
					goto case 38;
				case 32:
					lockTaken = false;
					num2 = 12;
					continue;
				case 12:
					try
					{
						Monitor.Enter(loadedContextTypesInfo, ref lockTaken);
						int num5 = 8;
						while (true)
						{
							switch (num5)
							{
							case 2:
								sYjmdAfzaUkFleBnY1M(MetadataRuntimeService, type, false);
								num5 = 3;
								break;
							default:
							{
								ConcurrentDictionary<long, ProcessTypesInfo> loadedContextTypesInfo2 = _loadedContextTypesInfo;
								long id = process.Id;
								ProcessTypesInfo processTypesInfo = new ProcessTypesInfo();
								r7akgf9KS6pHFUmqwDB(processTypesInfo, assembly);
								jUf1Rw9O7tjtA4tYn7q(processTypesInfo, type);
								TDw2vX9ZlT5dRVqyq20(processTypesInfo, instanceMetricValuesType);
								NC3YQG9v4doZ3pM1PmD(processTypesInfo, processMetricValuesType);
								loadedContextTypesInfo2[id] = processTypesInfo;
								num5 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
								{
									num5 = 5;
								}
								break;
							}
							case 1:
								sYjmdAfzaUkFleBnY1M(MetadataRuntimeService, processMetricValuesType, false);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
								{
									num5 = 0;
								}
								break;
							case 4:
							case 7:
								if (processMetricValuesType != null)
								{
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
									{
										num5 = 1;
									}
									break;
								}
								goto default;
							case 3:
								if (!HKvWBrL4Yru0nImejDh(instanceMetricValuesType, null))
								{
									num5 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
									{
										num5 = 0;
									}
									break;
								}
								goto case 5;
							case 8:
								if (!_loadedContextTypesInfo.ContainsKey(process.Id))
								{
									num5 = 2;
									break;
								}
								return assembly;
							case 5:
								sYjmdAfzaUkFleBnY1M(MetadataRuntimeService, instanceMetricValuesType, false);
								num5 = 7;
								break;
							case 6:
								return assembly;
							}
						}
					}
					finally
					{
						int num6;
						if (!lockTaken)
						{
							num6 = 2;
							goto IL_044a;
						}
						goto IL_047f;
						IL_044a:
						switch (num6)
						{
						case 2:
							goto end_IL_0435;
						case 1:
							goto end_IL_0435;
						}
						goto IL_047f;
						IL_047f:
						dLr8XK9Yi7rLrXjFads(loadedContextTypesInfo);
						num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num6 = 1;
						}
						goto IL_044a;
						end_IL_0435:;
					}
				case 3:
					if (!L12nWJfu5udEHDPEjZm(instanceMetricValuesType, null))
					{
						num2 = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 24;
				case 17:
					obj = this;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (L12nWJfu5udEHDPEjZm(type, null))
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
						{
							num2 = 26;
						}
					}
					else
					{
						instanceMetricValuesType = null;
						num2 = 13;
					}
					continue;
				case 5:
					if (!jPnRjHf4brCXRsctXBA(YV2XYIfwUWVBhCs8lVH(process.ProcessMetrics)))
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 39;
				case 30:
					if (_loadedContextTypesInfo.TryGetValue(process.Id, out value))
					{
						num2 = 2;
						continue;
					}
					assembly2 = null;
					num2 = 25;
					continue;
				case 37:
					assembly = null;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 33;
					}
					continue;
				case 11:
					if (!oKYHTJfGpPV0JdmgeQl(assembly, null))
					{
						num2 = 8;
						continue;
					}
					goto case 17;
				case 31:
					return assembly;
				case 13:
					if (process.InstanceMetrics != null)
					{
						num2 = 23;
						continue;
					}
					goto case 21;
				case 6:
					processContext = (ProcessContext)vQMNowfU1NX1ywPlOPY(process);
					num2 = 37;
					continue;
				case 29:
					break;
				case 10:
					instanceMetricValuesType = lZInEvfMqSrSSHo2k4D(value);
					num2 = 19;
					continue;
				case 35:
					if (!L12nWJfu5udEHDPEjZm(processMetricValuesType, null))
					{
						num2 = 39;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 28;
				case 8:
				case 15:
				case 18:
					if (!oKYHTJfGpPV0JdmgeQl(assembly, null))
					{
						num2 = 34;
						continue;
					}
					goto case 22;
				case 42:
					IAmXQBLzcI17wLFmo8F(process, updjZALND0Iv1Pu2apF(-360662087 ^ -360666165));
					num2 = 41;
					continue;
				case 26:
					throw new MetadataException((string)DnYCoNf1qVmSEUxcXKM(SR.T((string)updjZALND0Iv1Pu2apF(-452127399 ^ -452084371)), dAq7vcfmUeTVabxTstC(BYJMglfxoRXNPOPLZjp(process)), wFveOmf7gQI5Q893e5T(processContext), processContext.FullTypeName));
				case 16:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 5;
						while (true)
						{
							switch (num3)
							{
							case 5:
								assembly = (Assembly)cSUpgFfAVvUcd46YFWE(wFveOmf7gQI5Q893e5T(processContext), false);
								num3 = 2;
								continue;
							default:
								text = (string)jNmNHOfFBRCxIp2qXGs(r5S40XfocM02NjPB2FK(AhJ4sUf2rFF6PxpWr3i()), updjZALND0Iv1Pu2apF(-1716458555 ^ -1716499373), updjZALND0Iv1Pu2apF(-1895853023 ^ -1895884391));
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								if (oKYHTJfGpPV0JdmgeQl(assembly, null))
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 4:
								assembly = (Assembly)T6uYNnfNEi19Z7wPxiD(processContext.AssemblyRaw);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
							{
								object obj2 = t26sE5fi2xRNkJ0URjL(text, YBi4M5LwNZpwC4HqAXK(wFveOmf7gQI5Q893e5T(processContext), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC7A33)));
								if (!wWxAowfIn9W9WAP7vAZ(text))
								{
									kLWWA9fahfVFcZXhA8Z(text);
								}
								zXmjFFfe6fTwVJdmYeG(obj2, esfP6KfVZAREkvACnf1(processContext), v9bLYCfrtshsHJFOhbu(1.0), 10);
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
								{
									num3 = 4;
								}
								continue;
							}
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (!lockTaken)
						{
							num4 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
							{
								num4 = 2;
							}
							goto IL_0873;
						}
						goto IL_0889;
						IL_0889:
						Monitor.Exit(obj);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num4 = 0;
						}
						goto IL_0873;
						IL_0873:
						switch (num4)
						{
						default:
							goto end_IL_084e;
						case 1:
							break;
						case 2:
							goto end_IL_084e;
						case 0:
							goto end_IL_084e;
						}
						goto IL_0889;
						end_IL_084e:;
					}
					goto case 8;
				case 22:
					throw new InvalidOperationException((string)TiA3Y9fnSy6VrSDDWwH(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135700018), new object[1] { dAq7vcfmUeTVabxTstC(BYJMglfxoRXNPOPLZjp(process)) }));
				case 34:
					type = tultkAfSYrx9mscEcRo(assembly, processContext.FullTypeName);
					num2 = 4;
					continue;
				case 2:
					type = pLsSWbfQodQbYYVHLF4(value);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 10;
					}
					continue;
				case 38:
					instanceMetricValuesType = tultkAfSYrx9mscEcRo(assembly, WCRd07LE2NKrOP9jEB4(L4RCyffhg3oI4vZBqi1(process)));
					num2 = 3;
					continue;
				case 33:
					if (esfP6KfVZAREkvACnf1(processContext) == null)
					{
						num2 = 7;
						continue;
					}
					goto case 36;
				default:
				{
					assembly2 = GetInstanceContextAssembly((IWorkflowProcess)oudvQVfk0AVsSBgvoqn(process), out var _);
					num2 = 6;
					continue;
				}
				case 14:
					return (Assembly)XyU60RfCBonFEfvFEM4(value);
				case 20:
					processMetricValuesType = assembly.GetType(((ClassMetadata)qCfX7KfEBmeUNu2khdY(process)).FullTypeName);
					num2 = 35;
					continue;
				}
				break;
			}
			assembly = (Assembly)cSUpgFfAVvUcd46YFWE(processContext.AssemblyName, false);
			num = 11;
		}
	}

	protected void SaveProcessIdToCache(string key, long id)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				CacheService.Insert((string)YBi4M5LwNZpwC4HqAXK(updjZALND0Iv1Pu2apF(0x628167BE ^ 0x6281CD8C), key), id);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (CacheService == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected long? GetProcessIdFromCache(string key)
	{
		if (CacheService != null)
		{
			return CacheService.Get<long?>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30003478) + key);
		}
		return null;
	}

	protected override void InitInternal()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					ParameterExpression parameterExpression = Expression.Parameter(TsHOqdfbG0wv39F0IFy(typeof(long).TypeHandle), (string)updjZALND0Iv1Pu2apF(-1430645277 ^ -1430613825));
					ConstantExpression instance = Expression.Constant(this, TsHOqdfbG0wv39F0IFy(typeof(WorkflowInstanceContextService).TypeHandle));
					MethodInfo method = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
					Expression[] obj7 = new Expression[2] { parameterExpression, null };
					ParameterExpression parameterExpression2 = (ParameterExpression)XQFHoHfLnbxAoc8xHRN(TsHOqdfbG0wv39F0IFy(typeof(IProcessHeader).TypeHandle), updjZALND0Iv1Pu2apF(0x5F800F5B ^ 0x5F8082A3));
					obj7[1] = Expression.Lambda<Func<IProcessHeader, EntityMetadata>>(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 });
					getFullProcessMetricValuesMetadata = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<long, EntityMetadata>>(Expression.Call(instance, method, obj7), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 3:
					break;
				case 4:
				{
					ParameterExpression parameterExpression = (ParameterExpression)XQFHoHfLnbxAoc8xHRN(TsHOqdfbG0wv39F0IFy(typeof(long).TypeHandle), updjZALND0Iv1Pu2apF(0x7AC609FE ^ 0x7AC68CA2));
					object obj4 = WSAx4pfBD0yue35Ysp1(this, TsHOqdfbG0wv39F0IFy(typeof(WorkflowInstanceContextService).TypeHandle));
					MethodInfo obj5 = (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
					Expression[] obj6 = new Expression[2] { parameterExpression, null };
					ParameterExpression parameterExpression2 = (ParameterExpression)XQFHoHfLnbxAoc8xHRN(TsHOqdfbG0wv39F0IFy(typeof(IWorkflowProcess).TypeHandle), updjZALND0Iv1Pu2apF(-1430645277 ^ -1430644135));
					obj6[1] = Expression.Lambda<Func<IWorkflowProcess, EntityMetadata>>((Expression)fkJeZtfgguqObISFeYO(parameterExpression2, (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 });
					getProcessMetricValuesMetadata = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<long, EntityMetadata>>((Expression)kabA2p9sHayrh5NB2CI(obj4, obj5, obj6), new ParameterExpression[1] { parameterExpression }));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 2:
				{
					ParameterExpression parameterExpression = (ParameterExpression)XQFHoHfLnbxAoc8xHRN(TsHOqdfbG0wv39F0IFy(typeof(long).TypeHandle), updjZALND0Iv1Pu2apF(0x141C968 ^ 0x1414C34));
					object obj = WSAx4pfBD0yue35Ysp1(this, TsHOqdfbG0wv39F0IFy(typeof(WorkflowInstanceContextService).TypeHandle));
					MethodInfo obj2 = (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
					Expression[] obj3 = new Expression[2] { parameterExpression, null };
					ParameterExpression parameterExpression2 = (ParameterExpression)XQFHoHfLnbxAoc8xHRN(TsHOqdfbG0wv39F0IFy(typeof(IWorkflowProcess).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B6666));
					obj3[1] = Expression.Lambda<Func<IWorkflowProcess, EntityMetadata>>((Expression)fkJeZtfgguqObISFeYO(parameterExpression2, (MethodInfo)W3GKqOf5pilZrD1ekWC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 });
					getInstanceMetricValuesMetadata = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<long, EntityMetadata>>((Expression)kabA2p9sHayrh5NB2CI(obj, obj2, obj3), new ParameterExpression[1] { parameterExpression }));
					num2 = 4;
					continue;
				}
				case 0:
					return;
				}
				break;
			}
			ao8jHZ98BC9DwCuqeJx(this);
			num = 2;
		}
	}

	private EntityMetadata GetWorkflowMetricMetadata(long processId, Func<IWorkflowProcess, EntityMetadata> getMetrics)
	{
		IWorkflowProcess workflowProcess = WorkflowProcessManager.Load(processId);
		if (workflowProcess == null)
		{
			return null;
		}
		EntityMetadata entityMetadata = getMetrics(workflowProcess);
		if (entityMetadata == null)
		{
			return null;
		}
		entityMetadata.Properties = ((IEnumerable)entityMetadata.EntityProperties).Cast<PropertyMetadata>().ToList();
		return ClassSerializationHelper.CloneObjectByXml(entityMetadata);
	}

	private EntityMetadata GetHeaderMetricMetadata(long headerId, Func<IProcessHeader, EntityMetadata> getMetrics)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Load(headerId);
		if (processHeader == null)
		{
			return null;
		}
		EntityMetadata entityMetadata = getMetrics(processHeader);
		if (entityMetadata == null)
		{
			return null;
		}
		entityMetadata.Properties = ((IEnumerable)entityMetadata.EntityProperties).Cast<PropertyMetadata>().ToList();
		return ClassSerializationHelper.CloneObjectByXml(entityMetadata);
	}

	public WorkflowInstanceContextService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		pDPEqX9J0G4ekGW4Jye();
		_loadedContextTypesInfo = new ConcurrentDictionary<long, ProcessTypesInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool GohRrGLiiaBRBfinWJN()
	{
		return nfX3gsLFfZ3Gk6HfNBS == null;
	}

	internal static WorkflowInstanceContextService SR7B9ALIk6uPqYpqZ00()
	{
		return nfX3gsLFfZ3Gk6HfNBS;
	}

	internal static Type kyrEgfLaNWIR1uoAPQ1(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextType((IWorkflowProcess)P_1);
	}

	internal static object gD3LCmLry5upBkmNkTS(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static Type EIW3BaLe6JnIjFEEaA6(object P_0, long processId)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextType(processId);
	}

	internal static object updjZALND0Iv1Pu2apF(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hv3bjkLxs7VJiB2VJvq(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextMetadata((IWorkflowProcess)P_1);
	}

	internal static object VdYmsILSmNgsX4BCHbo(object P_0, long processId)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextMetadata(processId);
	}

	internal static object kgxBthL1ikD2481hmgH(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextMetadata((WorkflowInstanceContext)P_1);
	}

	internal static void z0uRGCLhxQ5r6fhYndK(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object WCRd07LE2NKrOP9jEB4(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object YBi4M5LwNZpwC4HqAXK(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool HKvWBrL4Yru0nImejDh(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static void IAmXQBLzcI17wLFmo8F(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object NyHjUIfKQK0AKYHMFPn(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static Type hqZYYifOt0NYmpbxXWe(object P_0, long headerId, bool throwOnMissing)
	{
		return ((IWorkflowMetadataLoaderService)P_0).GetFullInstanceContextType(headerId, throwOnMissing);
	}

	internal static Type Gvg4sPfZ7xHbaxJMKC3(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceContextType((IProcessHeader)P_1);
	}

	internal static object TrsnBkfvy3WLjYjeSMC(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceContextMetadata((IProcessHeader)P_1);
	}

	internal static object Lbq0nwfYlxovd5lYvIn(object P_0, long headerId)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceContextMetadata(headerId);
	}

	internal static object UxC8ulf8eEPcekjr6Fi(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static Type uQWHxEfsjptaGmalf2L(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceContextType((IWorkflowProcess)P_1);
	}

	internal static long zJFPiWfJDXPdq968H9S(object P_0, Type fullContextType, object P_2)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceContextId(fullContextType, (IWorkflowInstance)P_2);
	}

	internal static object r8WcMwflDC02NMsGU4p(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static bool yf3vXPf0t7eeVMUe2bI(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static void hQ5kG6fyRrQIUxMr6l3(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object dAq7vcfmUeTVabxTstC(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Guid my7TT6ft4vBcx7kr0ii(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static Type TsHOqdfbG0wv39F0IFy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object W3GKqOf5pilZrD1ekWC(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object fkJeZtfgguqObISFeYO(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object WSAx4pfBD0yue35Ysp1(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object gcXjmWfcrnSlwBb12IK(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object Y0wJNSfPkfWmL3vQMbR(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object QsCwPNfXNtwfUW49Ypo(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static Type TpZBi9fdLjEGXdGYkUi(object P_0, long headerId)
	{
		return ((IWorkflowMetadataLoaderService)P_0).GetFullInstanceMetricValuesType(headerId);
	}

	internal static bool L12nWJfu5udEHDPEjZm(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type s38gtgfDWU6yZrb2cS1(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceMetricValuesType((IWorkflowProcess)P_1);
	}

	internal static object TiA3Y9fnSy6VrSDDWwH(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object TfyqXkfH3SwFEQa6a10(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object XQFHoHfLnbxAoc8xHRN(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static Type dMOYr1ffpmVhD1gF3ul(object P_0, long headerId)
	{
		return ((IWorkflowMetadataLoaderService)P_0).GetFullProcessMetricValuesType(headerId);
	}

	internal static Type N0Kai3f92jHgl7ZSSmc(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetProcessMetricValuesType((IWorkflowProcess)P_1);
	}

	internal static object oBVE73fWwUMVsWRobCl(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object voo3RSfjXmw0dDvN6wT(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static object zKN5QXfRMdwFfxp8K1B(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object zRH8Djf6pDE6TKPuGXd(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object tJbxbBfqx9JOZvw1spy(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object aJs7rBf33AYrEH7IPuh(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static int HA0sSBfTEeiPs6wTVNH(object P_0)
	{
		return ((ICollection<long>)P_0).Count;
	}

	internal static Type pLsSWbfQodQbYYVHLF4(object P_0)
	{
		return ((ProcessTypesInfo)P_0).ContextType;
	}

	internal static Type vOXIuJfp0Okg3hPAfYx(object P_0)
	{
		return ((ProcessTypesInfo)P_0).ProcessMetricValuesType;
	}

	internal static object XyU60RfCBonFEfvFEM4(object P_0)
	{
		return ((ProcessTypesInfo)P_0).Assembly;
	}

	internal static Type lZInEvfMqSrSSHo2k4D(object P_0)
	{
		return ((ProcessTypesInfo)P_0).InstanceMetricValuesType;
	}

	internal static object oudvQVfk0AVsSBgvoqn(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object vQMNowfU1NX1ywPlOPY(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static object esfP6KfVZAREkvACnf1(object P_0)
	{
		return ((ProcessContext)P_0).AssemblyRaw;
	}

	internal static object cSUpgFfAVvUcd46YFWE(object P_0, bool P_1)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, P_1);
	}

	internal static bool oKYHTJfGpPV0JdmgeQl(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object wFveOmf7gQI5Q893e5T(object P_0)
	{
		return ((ProcessContext)P_0).AssemblyName;
	}

	internal static object AhJ4sUf2rFF6PxpWr3i()
	{
		return ComponentManager.Current;
	}

	internal static object r5S40XfocM02NjPB2FK(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static object jNmNHOfFBRCxIp2qXGs(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object t26sE5fi2xRNkJ0URjL(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool wWxAowfIn9W9WAP7vAZ(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object kLWWA9fahfVFcZXhA8Z(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static TimeSpan v9bLYCfrtshsHJFOhbu(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static void zXmjFFfe6fTwVJdmYeG(object P_0, object P_1, TimeSpan P_2, int P_3)
	{
		IOExtensions.WriteAllBytesWithAttempts((string)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static object T6uYNnfNEi19Z7wPxiD(object P_0)
	{
		return ComponentManager.LoadAssembly((byte[])P_0);
	}

	internal static object BYJMglfxoRXNPOPLZjp(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static Type tultkAfSYrx9mscEcRo(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static object DnYCoNf1qVmSEUxcXKM(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object L4RCyffhg3oI4vZBqi1(object P_0)
	{
		return ((IWorkflowProcess)P_0).InstanceMetrics;
	}

	internal static object qCfX7KfEBmeUNu2khdY(object P_0)
	{
		return ((IWorkflowProcess)P_0).ProcessMetrics;
	}

	internal static object YV2XYIfwUWVBhCs8lVH(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static bool jPnRjHf4brCXRsctXBA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void sYjmdAfzaUkFleBnY1M(object P_0, Type P_1, bool P_2)
	{
		((IMetadataRuntimeService)P_0).RegisterType(P_1, P_2);
	}

	internal static void r7akgf9KS6pHFUmqwDB(object P_0, object P_1)
	{
		((ProcessTypesInfo)P_0).Assembly = (Assembly)P_1;
	}

	internal static void jUf1Rw9O7tjtA4tYn7q(object P_0, Type value)
	{
		((ProcessTypesInfo)P_0).ContextType = value;
	}

	internal static void TDw2vX9ZlT5dRVqyq20(object P_0, Type value)
	{
		((ProcessTypesInfo)P_0).InstanceMetricValuesType = value;
	}

	internal static void NC3YQG9v4doZ3pM1PmD(object P_0, Type value)
	{
		((ProcessTypesInfo)P_0).ProcessMetricValuesType = value;
	}

	internal static void dLr8XK9Yi7rLrXjFads(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void ao8jHZ98BC9DwCuqeJx(object P_0)
	{
		((NHManager)P_0).InitInternal();
	}

	internal static object kabA2p9sHayrh5NB2CI(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}

	internal static void pDPEqX9J0G4ekGW4Jye()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
