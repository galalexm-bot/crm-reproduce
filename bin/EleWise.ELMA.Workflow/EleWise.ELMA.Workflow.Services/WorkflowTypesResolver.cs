using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Component]
internal class WorkflowTypesResolver : ITypeResolver
{
	private readonly WorkflowInstanceContextService workflowInstanceContextService;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly ISessionProvider sessionProvider;

	private readonly IWorkflowMetadataLoaderService workflowMetadataLoaderService;

	internal static WorkflowTypesResolver koIF872iCtQUyjMuoMI;

	public WorkflowTypesResolver(WorkflowInstanceContextService workflowInstanceContextService, IMetadataRuntimeService metadataRuntimeService, ISessionProvider sessionProvider, IWorkflowMetadataLoaderService workflowMetadataLoaderService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 3;
				break;
			default:
				this.workflowInstanceContextService = workflowInstanceContextService;
				num = 2;
				break;
			case 4:
				this.workflowMetadataLoaderService = workflowMetadataLoaderService;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 3:
				this.sessionProvider = sessionProvider;
				num = 4;
				break;
			}
		}
	}

	public Type GetTypeByUid(Guid uid)
	{
		//Discarded unreachable code: IL_01b5, IL_01db, IL_01ea, IL_01fa, IL_0209, IL_0219, IL_0228, IL_02a8, IL_02b7, IL_0356, IL_0365, IL_0375, IL_0414
		int num = 10;
		IProcessHeader processHeader = default(IProcessHeader);
		IProcessContext processContext = default(IProcessContext);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		Type type2 = default(Type);
		Type instanceMetricValuesType = default(Type);
		Type processMetricValuesType = default(Type);
		ISession session = default(ISession);
		ICriterion val = default(ICriterion);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (processHeader == null)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 25;
				case 2:
					return null;
				default:
					if (processContext is ProcessInstanceMetricsContainer)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 5;
				case 22:
					if (workflowProcess == null)
					{
						num2 = 18;
						continue;
					}
					workflowInstanceContextService.GetInstanceContextAssembly(workflowProcess, out type2, out instanceMetricValuesType, out processMetricValuesType);
					num2 = 15;
					continue;
				case 18:
					processHeader = ((ICriteria)CNLcuX2SrmJurdQxmyG(xSfL3b2xIw4TlJHv2f7(session, InterfaceActivator.TypeOf<IProcessHeader>()), val)).List<IProcessHeader>().FirstOrDefault();
					num2 = 8;
					continue;
				case 14:
				case 21:
				case 29:
					workflowProcess = ((ICriteria)xSfL3b2xIw4TlJHv2f7(session, InterfaceActivator.TypeOf<IWorkflowProcess>())).Add(val).List<IWorkflowProcess>().FirstOrDefault();
					num2 = 22;
					continue;
				case 28:
					if (GFCST924bQ9mkE3xnMY(instanceMetricValuesType, null))
					{
						num = 23;
						break;
					}
					goto case 13;
				case 9:
					if (processContext != null)
					{
						num2 = 11;
						continue;
					}
					goto case 17;
				case 15:
					type = ru0qfc2hwjLm8Qq545X(metadataRuntimeService, uid, true);
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 24;
					}
					continue;
				case 30:
					if (!RtSH7M2EZuLfiNN6Q8c(type, null))
					{
						num2 = 4;
						continue;
					}
					goto case 6;
				case 13:
					if (!GFCST924bQ9mkE3xnMY(processMetricValuesType, null))
					{
						num2 = 7;
						continue;
					}
					goto case 20;
				case 5:
					if (!(processContext is ProcessMetricsContainer))
					{
						num = 27;
						break;
					}
					goto case 24;
				case 19:
				case 27:
					val = (ICriterion)(object)Restrictions.Eq((string)vdpsPG2NnduVle1VwfC(0x4FD00585 ^ 0x4FD0151D), (object)processContext);
					num2 = 14;
					continue;
				case 1:
				case 4:
					return type;
				case 23:
					metadataRuntimeService.RegisterType(instanceMetricValuesType, asEntity: false);
					num2 = 13;
					continue;
				case 20:
					MwJwj42wphOUa9F6VHj(metadataRuntimeService, processMetricValuesType, false);
					num2 = 26;
					continue;
				case 6:
					MwJwj42wphOUa9F6VHj(metadataRuntimeService, type2, false);
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 14;
					}
					continue;
				case 25:
					return a4plbX21NTajV0HAS85(workflowMetadataLoaderService, processHeader.Id, false);
				case 12:
					return null;
				case 24:
					val = (ICriterion)V5wARV2ehkMTlytXp6b(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111178065), processContext);
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 21;
					}
					continue;
				case 16:
					val = (ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647824954), (object)processContext);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 29;
					}
					continue;
				case 10:
					processContext = v2Y0Sh2rRMvJDwMFs4h(this, uid) as IProcessContext;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 9;
					}
					continue;
				case 17:
					return null;
				case 11:
					session = GetSession();
					num2 = 3;
					continue;
				case 3:
					if (session != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 7:
				case 26:
					type = pE90fp2z65CGFiL7Yat(metadataRuntimeService, uid, true);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private ISession GetSession()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (sessionProvider != null)
				{
					return sessionProvider.GetSession("");
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal virtual EntityMetadata FindRootMetadata(Guid uid)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_009f, IL_00ae, IL_00be, IL_00cd
		int num = 9;
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		ISession session = default(ISession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					tablePartMetadata = entityMetadata as TablePartMetadata;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 13;
					}
					break;
				case 5:
					return null;
				case 8:
					session = GetSession();
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					break;
				case 9:
					if (!AKNQPSoKyD5pRBJBkQ4(uid, Guid.Empty))
					{
						num2 = 8;
						break;
					}
					goto case 5;
				case 7:
				case 11:
					if (entityMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 12:
					tablePartMetadata = entityMetadata as TablePartMetadata;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
				case 13:
					if (tablePartMetadata == null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 2:
					if (tablePartMetadata.TablePartOwner == null)
					{
						num2 = 7;
						break;
					}
					goto case 10;
				case 4:
					return null;
				default:
					return entityMetadata.CastAsRealType();
				case 14:
					if (session == null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						entityMetadata = FindMetadata(uid, session);
						num2 = 3;
					}
					break;
				case 10:
					entityMetadata = (EntityMetadata)GmM63doOCUcukjVkJuI(tablePartMetadata);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 12;
					}
					break;
				case 6:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	private EntityMetadata FindMetadata(Guid uid, ISession session)
	{
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				entityMetadata = ((ICriteria)CNLcuX2SrmJurdQxmyG(session.CreateCriteria<EntityMetadata>(), V5wARV2ehkMTlytXp6b(vdpsPG2NnduVle1VwfC(-106528299 ^ -106510423), uid))).List<EntityMetadata>().FirstOrDefault();
				num2 = 2;
				continue;
			case 1:
				entityMetadata = entityMetadata.CastAsRealType();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return entityMetadata;
	}

	internal static bool S9GEmq2IHh4WrnZRIGY()
	{
		return koIF872iCtQUyjMuoMI == null;
	}

	internal static WorkflowTypesResolver JHb1Un2anPrwKJ2B5RN()
	{
		return koIF872iCtQUyjMuoMI;
	}

	internal static object v2Y0Sh2rRMvJDwMFs4h(object P_0, Guid uid)
	{
		return ((WorkflowTypesResolver)P_0).FindRootMetadata(uid);
	}

	internal static object V5wARV2ehkMTlytXp6b(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object vdpsPG2NnduVle1VwfC(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xSfL3b2xIw4TlJHv2f7(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static object CNLcuX2SrmJurdQxmyG(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static Type a4plbX21NTajV0HAS85(object P_0, long headerId, bool throwOnMissing)
	{
		return ((IWorkflowMetadataLoaderService)P_0).GetFullInstanceContextType(headerId, throwOnMissing);
	}

	internal static Type ru0qfc2hwjLm8Qq545X(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUidOrNull(P_1, P_2);
	}

	internal static bool RtSH7M2EZuLfiNN6Q8c(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void MwJwj42wphOUa9F6VHj(object P_0, Type P_1, bool P_2)
	{
		((IMetadataRuntimeService)P_0).RegisterType(P_1, P_2);
	}

	internal static bool GFCST924bQ9mkE3xnMY(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type pE90fp2z65CGFiL7Yat(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUid(P_1, P_2);
	}

	internal static bool AKNQPSoKyD5pRBJBkQ4(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object GmM63doOCUcukjVkJuI(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartOwner;
	}
}
