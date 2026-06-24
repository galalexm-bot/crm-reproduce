using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server, EnableInterceptors = false, InjectProperties = false)]
internal sealed class WorkflowProcessPublicationService : IWorkflowProcessPublicationService
{
	private class ReferenceMap
	{
		private object classMetadata;

		private object referenceMap;

		private static readonly object EmptyReferenceMap;

		private static object c13HqDZ2gdeWNyE62oxD;

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Namespace
		{
			[CompilerGenerated]
			get
			{
				return _003CNamespace_003Ek__BackingField;
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
						_003CNamespace_003Ek__BackingField = value;
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

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyName_003Ek__BackingField;
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
						_003CPropertyName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid SubTypeUid
		{
			[CompilerGenerated]
			get
			{
				return _003CSubTypeUid_003Ek__BackingField;
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
						_003CSubTypeUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string RelationTableName
		{
			[CompilerGenerated]
			get
			{
				return _003CRelationTableName_003Ek__BackingField;
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
						_003CRelationTableName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public static explicit operator ClassMetadata(object referenceMap)
		{
			int num = 2;
			int num2 = num;
			ClassMetadata classMetadata = default(ClassMetadata);
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ClassMetadata obj2 = new ClassMetadata
					{
						Uid = n0vs0rZ2P9lSaO6RboiF(referenceMap)
					};
					Wxvbo0Z2dpKuw6HgWTVE(obj2, G2WWGIZ2XIVyTAmJ9KwN(referenceMap));
					KkOsNVZ2D1Nw57cQ6tjS(obj2, Sw6E31Z2u0bZvs1NDRpO(referenceMap));
					classMetadata = obj2;
					((ReferenceMap)referenceMap).classMetadata = obj2;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 2:
					obj = ((ReferenceMap)referenceMap).classMetadata;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					obj = classMetadata;
					break;
				}
				break;
			}
			return (ClassMetadata)obj;
		}

		public static explicit operator FindReferenceService.ReferenceMap(object referenceMap)
		{
			//Discarded unreachable code: IL_008d, IL_0174, IL_01b4, IL_01c3
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return (FindReferenceService.ReferenceMap)((ReferenceMap)referenceMap).referenceMap;
				case 1:
					if (((ReferenceMap)referenceMap).referenceMap == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					try
					{
						ClassMetadata classMetadata = gZHTEcZ2LAYbXQssa1x9(bQr1udZ2nYYDrXUK8ULj(), uJLic0Z2HkmU38d7TyAM(referenceMap), true) as ClassMetadata;
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
							{
								object obj;
								if (classMetadata != null)
								{
									obj = new FindReferenceService.ReferenceMap();
									Yp1EC6Z2fKy50mJH3J8J(obj, ((ReferenceMap)referenceMap).Uid);
									zDlJKUZ2jPI6uuth0gGF(obj, p4m1ybZ2WeVEEFliNx4c(((ReferenceMap)referenceMap).Namespace, As1axhZ29Uv79eEt8WEB(0x75BAD659 ^ 0x75BA9EA3), Sw6E31Z2u0bZvs1NDRpO(referenceMap)));
									((FindReferenceService.ReferenceMap)obj).ElementPropertyName = (string)y02CmuZ2RTmDG0whfiOb(referenceMap);
									mljjQZZ2quayTReZrOxS(obj, eH4WpLZ26fFucuQevQpH(referenceMap));
									((FindReferenceService.ReferenceMap)obj).ReferenceType = ((!KNXrqoZ2TJ8wlZlbMR0v(aDtaWVZ238pDq4Btb0fO(referenceMap))) ? FindReferenceService.ReferenceEnum.ManyToMany : FindReferenceService.ReferenceEnum.Simple);
									WFRuw6Z2QM1qE4kw6VJL(obj, classMetadata.FullTypeName);
								}
								else
								{
									obj = EmptyReferenceMap;
								}
								((ReferenceMap)referenceMap).referenceMap = obj;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							case 1:
								break;
							}
							break;
						}
					}
					catch (ObjectNotFoundException)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((ReferenceMap)referenceMap).referenceMap = EmptyReferenceMap;
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					break;
				case 3:
					break;
				}
				if (((ReferenceMap)referenceMap).referenceMap == EmptyReferenceMap)
				{
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
				{
					num2 = 2;
				}
			}
			return null;
		}

		public ReferenceMap()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			eT9Au8Z2p5Lp4GdHmgj4();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ReferenceMap()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					eT9Au8Z2p5Lp4GdHmgj4();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					EmptyReferenceMap = new FindReferenceService.ReferenceMap();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool lpB869Z2Byp3PPxTVceA()
		{
			return c13HqDZ2gdeWNyE62oxD == null;
		}

		internal static ReferenceMap tCK4pHZ2cmUfJxcpmhEo()
		{
			return (ReferenceMap)c13HqDZ2gdeWNyE62oxD;
		}

		internal static Guid n0vs0rZ2P9lSaO6RboiF(object P_0)
		{
			return ((ReferenceMap)P_0).Uid;
		}

		internal static object G2WWGIZ2XIVyTAmJ9KwN(object P_0)
		{
			return ((ReferenceMap)P_0).Namespace;
		}

		internal static void Wxvbo0Z2dpKuw6HgWTVE(object P_0, object P_1)
		{
			((ClassMetadata)P_0).Namespace = (string)P_1;
		}

		internal static object Sw6E31Z2u0bZvs1NDRpO(object P_0)
		{
			return ((ReferenceMap)P_0).Name;
		}

		internal static void KkOsNVZ2D1Nw57cQ6tjS(object P_0, object P_1)
		{
			((NamedMetadata)P_0).Name = (string)P_1;
		}

		internal static object bQr1udZ2nYYDrXUK8ULj()
		{
			return MetadataServiceContext.Service;
		}

		internal static Guid uJLic0Z2HkmU38d7TyAM(object P_0)
		{
			return ((ReferenceMap)P_0).SubTypeUid;
		}

		internal static object gZHTEcZ2LAYbXQssa1x9(object P_0, Guid P_1, bool P_2)
		{
			return ((IMetadataService)P_0).GetMetadata(P_1, P_2);
		}

		internal static void Yp1EC6Z2fKy50mJH3J8J(object P_0, Guid P_1)
		{
			((FindReferenceService.ReferenceMap)P_0).ElementEntityUid = P_1;
		}

		internal static object As1axhZ29Uv79eEt8WEB(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object p4m1ybZ2WeVEEFliNx4c(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static void zDlJKUZ2jPI6uuth0gGF(object P_0, object P_1)
		{
			((FindReferenceService.ReferenceMap)P_0).ElementEntityName = (string)P_1;
		}

		internal static object y02CmuZ2RTmDG0whfiOb(object P_0)
		{
			return ((ReferenceMap)P_0).PropertyName;
		}

		internal static Guid eH4WpLZ26fFucuQevQpH(object P_0)
		{
			return ((ReferenceMap)P_0).PropertyUid;
		}

		internal static void mljjQZZ2quayTReZrOxS(object P_0, Guid P_1)
		{
			((FindReferenceService.ReferenceMap)P_0).ElementPropertyUid = P_1;
		}

		internal static object aDtaWVZ238pDq4Btb0fO(object P_0)
		{
			return ((ReferenceMap)P_0).RelationTableName;
		}

		internal static bool KNXrqoZ2TJ8wlZlbMR0v(object P_0)
		{
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		internal static void WFRuw6Z2QM1qE4kw6VJL(object P_0, object P_1)
		{
			((FindReferenceService.ReferenceMap)P_0).ReferenceEntityName = (string)P_1;
		}

		internal static void eT9Au8Z2p5Lp4GdHmgj4()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Type = ComponentType.Server, Order = 100)]
	private class InitHandler : IInitHandler
	{
		private static object Coa5IIZ2CaLdJac4R34e;

		public void Init()
		{
		}

		public void InitComplete()
		{
			OEaZ9kZ2UGypcMihJMbq(Locator.GetServiceNotNull<WorkflowProcessPublicationService>());
		}

		public InitHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			b7Bf3EZ2VgT4l87L0lpF();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void OEaZ9kZ2UGypcMihJMbq(object P_0)
		{
			((WorkflowProcessPublicationService)P_0).InitComplete();
		}

		internal static void b7Bf3EZ2VgT4l87L0lpF()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool m9W96YZ2MJLcJulvEAgT()
		{
			return Coa5IIZ2CaLdJac4R34e == null;
		}

		internal static InitHandler b5ljltZ2k9AiN4dRDdhf()
		{
			return (InitHandler)Coa5IIZ2CaLdJac4R34e;
		}
	}

	private readonly IProcessHeaderManager processHeaderManager;

	private readonly IWorkflowProcessDTOManager workflowProcessDtoManager;

	private readonly FindReferenceService findReferenceService;

	private readonly ISessionProvider sessionProvider;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static WorkflowProcessPublicationService uCiLVdUvhuqH5p4TXmn;

	public WorkflowProcessPublicationService(IProcessHeaderManager processHeaderManager, IWorkflowProcessDTOManager workflowProcessDtoManager, FindReferenceService findReferenceService, ISessionProvider sessionProvider, IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IhJvZUUsRUD18fVRCO5();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.workflowProcessDtoManager = workflowProcessDtoManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num = 0;
				}
				break;
			case 5:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 2;
				break;
			case 3:
				this.processHeaderManager = processHeaderManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			default:
				this.findReferenceService = findReferenceService;
				num = 4;
				break;
			case 4:
				this.sessionProvider = sessionProvider;
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	public void Publish(IProcessHeader processHeader, string comment, bool generateDocumentation, bool isEmulation)
	{
		//Discarded unreachable code: IL_013c, IL_019c, IL_01e4
		int num = 8;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		long versionNumber = default(long);
		IEnumerable<EntityMetadata> source = default(IEnumerable<EntityMetadata>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				workflowProcess = processHeader.Current.CastAsRealType();
				num2 = 6;
				break;
			case 6:
				mTMjs6Utp3n6J5be2j2(WKq0BeUmc1cNpKoG85x(XKL13FUy6gm0ddHKgYS(workflowProcess.GetType())), workflowProcess, versionNumber, null, comment, isEmulation);
				num2 = 5;
				break;
			case 7:
				versionNumber = zX67swU0TK3aMxG9Moc(processHeaderManager, processHeader.Id);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			default:
				if (!generateDocumentation)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				qSyFArUlgbP7c2tCNcx(processHeader, ARItdaUJ3mxfGAysnTZ(-17847711 ^ -17888291));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				try
				{
					GenerationSettings generationSettings = new GenerationSettings();
					nxeQIiUBJVtjym5DCh3(generationSettings, ((IEntity<long>)JxeXaPUgOb5yfS8IJDe(workflowProcess.Header)).Id);
					GenerationSettings settings = generationSettings;
					int num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							workflowProcessDtoManager.Documentation(ref settings, isPublishing: true);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							((ILogger)qf3XogUcuDprLkt9ene()).Error(jsL9xaUPBo3fuPq209A(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
			case 5:
				source = new EntityMetadata[3]
				{
					(EntityMetadata)uF9RqlUbrKB0IpKtFTa(processHeader),
					(EntityMetadata)p5bDyCU5SFIgho3RVhr(processHeader),
					processHeader.ProcessMetrics
				}.Where((EntityMetadata m) => m != null);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				findReferenceService.AddMetadata(source.SelectRecursive((EntityMetadata m) => m.TableParts));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void InitComplete()
	{
		//Discarded unreachable code: IL_00f6, IL_01db, IL_0213, IL_026c, IL_028b, IL_029a, IL_02c7, IL_02d6
		int num = 1;
		int num2 = num;
		IStartInformation startInformation = default(IStartInformation);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		while (true)
		{
			switch (num2)
			{
			case 1:
				startInformation = (IStartInformation)UpRT1RUu4MQaqb786yM(UBSwM1UXAtY3ynjdMed(StartInformation.Current), in68m8UdZtgWNUqJ8ij(ARItdaUJ3mxfGAysnTZ(-197778752 ^ -197711198)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				IList<ReferenceMap> source = ((IQuery)lYOeVvUWCpNoFW8QXWx(di27SUUfVLjt5jEdOaC(h9FSfcULDSxOZ0S4yL4(Qu189HUHH484r45IiSt(IbuA3TUnnKCJppyNVVw(DU7LAxUDJiPSjTMwNTN(sessionProvider, string.Empty), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC7016E)), ARItdaUJ3mxfGAysnTZ(-1539486135 ^ -1539553545), Guid.Empty), false), 0), new AliasToBeanResultTransformer(nfeib9U9NrupeFs3xhl(typeof(ReferenceMap).TypeHandle)))).List<ReferenceMap>();
				int num3 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						metadataServiceContext = MetadataServiceContext.Extend(source.Select((ReferenceMap r) => (ClassMetadata)_003C_003Ec.LiAhA3Z2ow48sW3CRN4L(r)));
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num3 = 0;
						}
						continue;
					}
					try
					{
						findReferenceService.AddReferences(from r in source
							select (FindReferenceService.ReferenceMap)_003C_003Ec.DyP2hRZ2FnktCXOTCGIg(r) into r
							where r != null
							select r, Enumerable.Empty<FindReferenceService.ReferenceMap>());
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						if (metadataServiceContext != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									pa9A1KUjnY19aHUaDaP(metadataServiceContext);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
			}
			finally
			{
				int num6;
				if (startInformation == null)
				{
					num6 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num6 = 1;
					}
					goto IL_0270;
				}
				goto IL_02a5;
				IL_02a5:
				pa9A1KUjnY19aHUaDaP(startInformation);
				num6 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num6 = 2;
				}
				goto IL_0270;
				IL_0270:
				switch (num6)
				{
				case 1:
					goto end_IL_024b;
				case 2:
					goto end_IL_024b;
				}
				goto IL_02a5;
				end_IL_024b:;
			}
		}
	}

	internal static void IhJvZUUsRUD18fVRCO5()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool OAREDsUYfjlswuZqSmB()
	{
		return uCiLVdUvhuqH5p4TXmn == null;
	}

	internal static WorkflowProcessPublicationService o5IuFsU8S6xAjfr7kfK()
	{
		return uCiLVdUvhuqH5p4TXmn;
	}

	internal static object ARItdaUJ3mxfGAysnTZ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void qSyFArUlgbP7c2tCNcx(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static long zX67swU0TK3aMxG9Moc(object P_0, long headerId)
	{
		return ((IProcessHeaderManager)P_0).GetPublishingVersionNumber(headerId);
	}

	internal static Type XKL13FUy6gm0ddHKgYS(Type P_0)
	{
		return P_0.GetTypeWithoutProxy();
	}

	internal static object WKq0BeUmc1cNpKoG85x(Type processEntityType)
	{
		return WorkflowProcessManager.GetManager(processEntityType);
	}

	internal static void mTMjs6Utp3n6J5be2j2(object P_0, object P_1, long versionNumber, object P_3, object P_4, bool isEmulation)
	{
		((IWorkflowProcessManager)P_0).Publish((IWorkflowProcess)P_1, versionNumber, (IWorkflowProcess)P_3, (string)P_4, isEmulation);
	}

	internal static object uF9RqlUbrKB0IpKtFTa(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static object p5bDyCU5SFIgho3RVhr(object P_0)
	{
		return ((IProcessHeader)P_0).InstanceMetrics;
	}

	internal static object JxeXaPUgOb5yfS8IJDe(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static void nxeQIiUBJVtjym5DCh3(object P_0, long value)
	{
		((GenerationSettings)P_0).ProcessId = value;
	}

	internal static object qf3XogUcuDprLkt9ene()
	{
		return Logger.Log;
	}

	internal static object jsL9xaUPBo3fuPq209A(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static double UBSwM1UXAtY3ynjdMed(object P_0)
	{
		return ((IStartInformation)P_0).Percent;
	}

	internal static object in68m8UdZtgWNUqJ8ij(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object UpRT1RUu4MQaqb786yM(double P_0, object P_1)
	{
		return StartInformation.Operation(P_0, (string)P_1);
	}

	internal static object DU7LAxUDJiPSjTMwNTN(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object IbuA3TUnnKCJppyNVVw(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object Qu189HUHH484r45IiSt(object P_0, object P_1, Guid P_2)
	{
		return ((IQuery)P_0).SetGuid((string)P_1, P_2);
	}

	internal static object h9FSfcULDSxOZ0S4yL4(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object di27SUUfVLjt5jEdOaC(object P_0, int P_1)
	{
		return ((IQuery)P_0).SetTimeout(P_1);
	}

	internal static Type nfeib9U9NrupeFs3xhl(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object lYOeVvUWCpNoFW8QXWx(object P_0, object P_1)
	{
		return ((IQuery)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static void pa9A1KUjnY19aHUaDaP(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
