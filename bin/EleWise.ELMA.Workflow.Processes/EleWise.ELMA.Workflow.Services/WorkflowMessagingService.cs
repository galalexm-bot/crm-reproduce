using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server)]
public class WorkflowMessagingService : IWorkflowMessagingService
{
	public const string WorkflowMessagingServiceDescription = "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно получить информацию об активынх точках останова экземпляров процессов \r\n    /// //на операции \"Ожидание сообщения\" и отправлять сообщения в процессы\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.WorkflowMessaging;\r\n    /// \r\n    /// //Чтобы получить информацию об активных точках останова экземпляров процессов на операции \"Ожидание сообщения\" используйте следующие функции:\r\n    /// //1.GetActiveMessageBookmarkInfos(instanceList) - проверяет только по процессам, записанным в переменную\r\n    /// var info = services.GetActiveMessageBookmarkInfos(instanceList);\r\n    /// \r\n    /// //2.GetActiveMessageBookmarkInfos(instanceList, allowSubInstances) - проверяет с учётом подпроцессов\r\n    /// var info = services.GetActiveMessageBookmarkInfos(instanceList, allowSubInstances);\r\n    /// \r\n    /// //Чтобы отправить сообщение, используйте следующие функции:\r\n    /// //1.SendMessage(messageType, data) - отправить сообщение\r\n    /// var sendResult = service.SendMessage(messageType, data);\r\n    /// \r\n    /// //2.SendMessage(instance, messageType, data) - отправить сообщение в указанный экземпляр\r\n    /// var sendResult = service.SendMessage(instance, messageType, data);\r\n    /// </code>')";

	private static readonly ILogger logger;

	private static readonly string F_Id;

	private static readonly string F_Bookmark_Instance;

	private static readonly string F_Bookmark_ElementUid;

	private static readonly string F_Instance_Status;

	private static readonly string F_WMB_Status;

	private static readonly string F_WMB_Bookmark;

	private static readonly string F_WMB_CreationDate;

	private static readonly string F_WMB_MessageType;

	private static readonly string F_WMB_ControlParameterValue;

	private static readonly string F_WMBI_Instance;

	private static readonly string F_WMBI_CreationDate;

	private static readonly string F_WMBI_ElementUid;

	private static readonly string F_WMBI_MessageType;

	private static readonly string F_WMBI_ControlParameterValue;

	private static readonly string F_WMI_MessageType;

	private static readonly string F_WMI_DestinationInstace;

	private static WorkflowMessagingService ooWbkjotmBLbvWAMvBW;

	public IWorkflowRuntimeService WorkflowRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowRuntimeService_003Ek__BackingField;
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
					_003CWorkflowRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMessageItemManager WorkflowMessageItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMessageItemManager_003Ek__BackingField;
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
					_003CWorkflowMessageItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
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

	public IWorkflowQueueService WorkflowQueueService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowQueueService_003Ek__BackingField;
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
					_003CWorkflowQueueService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowScriptingService WorkflowScriptingService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowScriptingService_003Ek__BackingField;
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
					_003CWorkflowScriptingService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
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

	public WorkflowQueueItemManager WorkflowQueueItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowQueueItemManager_003Ek__BackingField;
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
					_003CWorkflowQueueItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMessageBookmarkManager WorkflowMessageBookmarkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMessageBookmarkManager_003Ek__BackingField;
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
					_003CWorkflowMessageBookmarkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
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

	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	[Transaction]
	public virtual WorkflowMessageSendResult SendMessage(IWorkflowMessageType messageType, WebData data)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return SendMessage(null, messageType, data);
			case 1:
				Contract.ArgumentNotNull(messageType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-402075023 ^ -402066569));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	public virtual WorkflowMessageSendResult SendMessage(IWorkflowInstance instance, IWorkflowMessageType messageType, WebData data)
	{
		//Discarded unreachable code: IL_00ea, IL_00f9, IL_0108
		int num = 7;
		IWorkflowMessageItem workflowMessageItem = default(IWorkflowMessageItem);
		WorkflowMessageSendResult result = default(WorkflowMessageSendResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (!messageType.ReliableDelivery)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 6:
					break;
				case 11:
					workflowMessageItem = (IWorkflowMessageItem)Xr4CPJoMi58w2Xkx8Qd(WorkflowMessageItemManager, instance, messageType, data);
					num2 = 8;
					continue;
				case 7:
					PCpfNvoqZerHbFK5JTW(messageType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1756425685 ^ -1756417235));
					num2 = 6;
					continue;
				case 10:
					workflowMessageItem = null;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					result = null;
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
					{
						num2 = 5;
					}
					continue;
				default:
					result = InitialDelivery(instance, messageType, data);
					num2 = 4;
					continue;
				case 3:
					result = (WorkflowMessageSendResult)G7X4tJoYI12HIZjyqaL(this, instance, messageType, workflowMessageItem);
					num2 = 12;
					continue;
				case 4:
				case 12:
					return result;
				case 8:
					UXguPjoaudpSyJoGOnN(logger, x5PXhOoVgAcMaGN2a8O(0x2C9503E1 ^ 0x2C952215), new object[1] { workflowMessageItem.Id });
					num2 = 3;
					continue;
				case 5:
					logger.DebugFormat((string)x5PXhOoVgAcMaGN2a8O(0x7AADECE0 ^ 0x7AADCDC0), messageType.Id, nvqvWSoDWdeqDhMjDRl(messageType), (instance != null) ? svaa2joKJk2DpL73k92(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32F3F75 ^ 0x32F1E9F), instance.Id.ToString()) : x5PXhOoVgAcMaGN2a8O(-1969850261 ^ -1969858123), data.ToString());
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			JVqOWwoQUHYE7N3dbIs(WorkflowRuntimeService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-408604271 ^ -408604211));
			num = 10;
		}
	}

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	public IList<WorkflowMessageBookmarkInfo> GetActiveMessageBookmarkInfos(IEnumerable<IWorkflowInstance> instanceList)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365449958 ^ -1365458570));
		return GetActiveMessageBookmarkInfos(instanceList, allowSubInstances: false);
	}

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	public IList<WorkflowMessageBookmarkInfo> GetActiveMessageBookmarkInfos(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-193507406 ^ -193499682));
		ICriteria val = Locator.GetServiceNotNull<ISessionProvider>().GetSession("").CreateCriteria(InterfaceActivator.TypeOf<IWorkflowMessageBookmark>())
			.CreateAlias(F_WMB_Bookmark, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x148F9F60 ^ 0x148FBDE8), (JoinType)0)
			.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x19163E7B ^ 0x19161CEB) + F_Bookmark_Instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179265198 ^ -179272760))
			.Add((ICriterion)(object)Restrictions.Eq(F_WMB_Status, (object)WorkflowMessageBookmarkStatus.Awaiting));
		if (!allowSubInstances)
		{
			val.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-193507406 ^ -193499870) + F_Bookmark_Instance, (ICollection)instanceList.ToList()));
		}
		else
		{
			ICriterion val2 = WorkflowInstanceManager.Instance.CreateChildInstancesCriterion(instanceList, startFromRoot: false, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-444713948 ^ -444721536));
			val.Add(val2);
		}
		return val.SetProjection((IProjection[])(object)new IProjection[6]
		{
			Projections.Alias((IProjection)(object)Projections.Property(F_Id), F_Id),
			Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-408604271 ^ -408612095) + F_Bookmark_Instance), F_WMBI_Instance),
			Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1535001335 ^ -1535008871) + F_WMBI_ElementUid), F_Bookmark_ElementUid),
			Projections.Alias((IProjection)(object)Projections.Property(F_WMB_CreationDate), F_WMBI_CreationDate),
			Projections.Alias((IProjection)(object)Projections.Property(F_WMB_MessageType), F_WMBI_MessageType),
			Projections.Alias((IProjection)(object)Projections.Property(F_WMB_ControlParameterValue), F_WMBI_ControlParameterValue)
		}).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(WorkflowMessageBookmarkInfo))).List<WorkflowMessageBookmarkInfo>();
	}

	[Transaction]
	public virtual WorkflowMessageQueueInfo ProcessMessageQueue()
	{
		int num = 1;
		int num2 = num;
		int value = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				value = WorkflowMessageItemManager.DeleteStaleMessages();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				WorkflowMessageQueueInfo workflowMessageQueueInfo = new WorkflowMessageQueueInfo();
				rJvqfIoPBqjqKi4QHGD(workflowMessageQueueInfo, UL8rvxovrBMry95lSV2(WorkflowMessageItemManager));
				IZns28o9TUPesvlmkIs(workflowMessageQueueInfo, fy1O8Go4DGg6hIvd5TP(WorkflowMessageItemManager));
				K3JKR2oTSkgiwFpQvlO(workflowMessageQueueInfo, value);
				return workflowMessageQueueInfo;
			}
			}
		}
	}

	[Transaction]
	protected virtual WorkflowMessageSendResult InitialDelivery(IWorkflowMessageItem message)
	{
		return InitialDelivery((IWorkflowInstance)gL1cl6ocnKLg9oQijuc(message), (IWorkflowMessageType)AMVTiwoNOf5sT0XO6cX(message), r335dCodw920eGWexTC(message) as WebData, message);
	}

	[Transaction]
	protected virtual WorkflowMessageSendResult InitialDelivery(IWorkflowInstance instance, IWorkflowMessageType messageType, WebData data, IWorkflowMessageItem message = null)
	{
		int num = 3;
		int num2 = num;
		IList<IWorkflowMessageBookmark> awaitingMessageBookmarks = default(IList<IWorkflowMessageBookmark>);
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				awaitingMessageBookmarks = WorkflowMessageBookmarkManager.GetAwaitingMessageBookmarks(instance, messageType, _003C_003Ec__DisplayClass35_.data);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Ec__DisplayClass35_.data = data;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass35_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				WorkflowMessageSendResult workflowMessageSendResult = new WorkflowMessageSendResult();
				lsfEhWojmIS0beAGFY0(workflowMessageSendResult, 0);
				lsfEhWojmIS0beAGFY0(workflowMessageSendResult, awaitingMessageBookmarks.Select(_003C_003Ec__DisplayClass35_._003CInitialDelivery_003Eb__0).Count((bool r) => r));
				return workflowMessageSendResult;
			}
			}
		}
	}

	[Transaction]
	protected virtual WorkflowMessageSendResult DoReliableDelivery(IWorkflowInstance instance, IWorkflowMessageType messageType, IWorkflowMessageItem message)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		IList<IWorkflowMessageBookmark> awaitingMessageBookmarks = default(IList<IWorkflowMessageBookmark>);
		WorkflowMessageSendResult workflowMessageSendResult2 = default(WorkflowMessageSendResult);
		IEnumerable<IWorkflowQueueItem> source = default(IEnumerable<IWorkflowQueueItem>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				_003C_003Ec__DisplayClass36_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 9:
				_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass36_.instance = instance;
				num2 = 11;
				break;
			case 5:
				UXguPjoaudpSyJoGOnN(logger, x5PXhOoVgAcMaGN2a8O(-901337984 ^ -901345332), new object[1] { QlltEcoSPcKRkEeEC6L(awaitingMessageBookmarks) });
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
				{
					num2 = 12;
				}
				break;
			case 11:
			{
				WorkflowMessageSendResult workflowMessageSendResult = new WorkflowMessageSendResult();
				lsfEhWojmIS0beAGFY0(workflowMessageSendResult, 0);
				workflowMessageSendResult2 = workflowMessageSendResult;
				num2 = 6;
				break;
			}
			case 13:
				return workflowMessageSendResult2;
			case 1:
				return workflowMessageSendResult2;
			case 2:
				UXguPjoaudpSyJoGOnN(logger, x5PXhOoVgAcMaGN2a8O(0xB863F17 ^ 0xB861DA3), new object[2]
				{
					_003C_003Ec__DisplayClass36_.instance.Id,
					messageType.Id
				});
				num2 = 4;
				break;
			default:
				workflowMessageSendResult2.ReceivedCount = source.Count();
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
				{
					num2 = 7;
				}
				break;
			case 10:
				awaitingMessageBookmarks = WorkflowMessageBookmarkManager.GetAwaitingMessageBookmarks(_003C_003Ec__DisplayClass36_.instance, messageType, _003C_003Ec__DisplayClass36_.data);
				num2 = 5;
				break;
			case 4:
				_003C_003Ec__DisplayClass36_.data = r335dCodw920eGWexTC(message) as WebData;
				num2 = 10;
				break;
			case 7:
				UXguPjoaudpSyJoGOnN(logger, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882646278 ^ -882654890), new object[1] { sNOf14okNHYtCUsUPAy(workflowMessageSendResult2) });
				num2 = 13;
				break;
			case 6:
				if (nvqvWSoDWdeqDhMjDRl(AMVTiwoNOf5sT0XO6cX(message)))
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 12:
				source = from qi in awaitingMessageBookmarks.Select(_003C_003Ec__DisplayClass36_._003CDoReliableDelivery_003Eb__0)
					where qi != null
					select qi;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual IWorkflowQueueItem QueueActivity(IWorkflowInstance instance, IWorkflowBookmark bookmark)
	{
		return (IWorkflowQueueItem)eNga4MobQhpqfETQGqr(this, instance, bookmark, null, null);
	}

	protected virtual IWorkflowQueueItem QueueActivity(IWorkflowInstance instance, IWorkflowBookmark bookmark, WebData data, IWorkflowMessageBookmark messageBookmark)
	{
		//Discarded unreachable code: IL_0279, IL_0288, IL_03b8, IL_0415, IL_0434, IL_0443, IL_0460, IL_04d6, IL_04e5, IL_0556, IL_0565, IL_061c, IL_062b
		int num = 18;
		Element element = default(Element);
		object obj = default(object);
		MessageReceiveElement messageReceiveElement = default(MessageReceiveElement);
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = default(_003C_003Ec__DisplayClass38_0);
		IWorkflowQueueItem workflowQueueItem2 = default(IWorkflowQueueItem);
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (element == null)
					{
						num2 = 19;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
						{
							num2 = 30;
						}
						continue;
					}
					if (messageBookmark == null)
					{
						num = 4;
						break;
					}
					goto case 26;
				case 26:
					if (data != null)
					{
						num2 = 29;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 1;
				case 14:
					if ((bool)obj)
					{
						num2 = 9;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 10;
				case 15:
					obj = WorkflowScriptingService.ExecuteScript(instance, (string)Om9N4lo6UswbJsttiKI(fuqro0oO0G0jBXaguPB(messageReceiveElement)), new Dictionary<string, object>
					{
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE6AF0C2 ^ 0xE6AD53C),
							data
						},
						{
							(string)x5PXhOoVgAcMaGN2a8O(0x4CBDA8D5 ^ 0x4CBD89D3),
							m4bkPbo02nuXyf8LbHK(messageBookmark)
						}
					});
					num2 = 28;
					continue;
				case 30:
					UXguPjoaudpSyJoGOnN(logger, x5PXhOoVgAcMaGN2a8O(0x20C96B1E ^ 0x20C94EB6), Array.Empty<object>());
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
					{
						num2 = 20;
					}
					continue;
				case 22:
					workflowQueueItem = null;
					num2 = 21;
					continue;
				case 16:
					if (fuqro0oO0G0jBXaguPB(messageReceiveElement) != null)
					{
						num2 = 25;
						continue;
					}
					goto case 1;
				case 3:
					if (workflowQueueItem != null)
					{
						num = 31;
						break;
					}
					if (x5J8ugop1gfSZYLniD6(instance) != WorkflowInstanceStatus.Running)
					{
						num2 = 24;
						continue;
					}
					element = ((IEnumerable<Element>)JXx9iWoyfTR6JKfVcbK(cpA13jonZgiKaNRpZSt(of3prGoGibWlBeM6hfP(instance)))).FirstOrDefault(_003C_003Ec__DisplayClass38_._003CQueueActivity_003Eb__0);
					num2 = 12;
					continue;
				case 10:
					return null;
				case 1:
				case 4:
				case 9:
				case 19:
					workflowQueueItem2 = (IWorkflowQueueItem)hcgj6VoHpNSRG741Qf0(WorkflowQueueItemManager, instance, element, true);
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					_003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
					{
						num2 = 11;
					}
					continue;
				case 28:
					if (obj == null)
					{
						num2 = 19;
						continue;
					}
					goto case 8;
				case 24:
					UXguPjoaudpSyJoGOnN(logger, x5PXhOoVgAcMaGN2a8O(-1329217772 ^ -1329227222), new object[1] { instance.Id });
					num2 = 6;
					continue;
				case 5:
					SEu6dhoiPuU85cwEsoL(workflowQueueItem2, AkggofoeqoXJnptS76Y(_003C_003Ec__DisplayClass38_.bookmark));
					num = 27;
					break;
				case 2:
					logger.DebugFormat((string)x5PXhOoVgAcMaGN2a8O(-1947292726 ^ -1947300416), workflowQueueItem2.Id, eaadf6oAkmG2hgHnrRk(workflowQueueItem2));
					num2 = 13;
					continue;
				case 7:
					if (messageReceiveElement != null)
					{
						num2 = 16;
						continue;
					}
					goto case 1;
				case 27:
					z5YZLOouZR7Ze4jK6Cn(workflowQueueItem2);
					num2 = 11;
					continue;
				default:
					return null;
				case 31:
					UXguPjoaudpSyJoGOnN(logger, x5PXhOoVgAcMaGN2a8O(0x27475F40 ^ 0x27477BEA), new object[1] { eaadf6oAkmG2hgHnrRk(workflowQueueItem) });
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
					try
					{
						workflowQueueItem = AbstractNHEntityManager<IWorkflowQueueItem, long>.Instance.LoadOrNull(_003C_003Ec__DisplayClass38_.bookmark.Uid);
						int num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								unitOfWork.Commit();
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (unitOfWork == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
							{
								num4 = 0;
							}
							goto IL_0419;
						}
						goto IL_044e;
						IL_044e:
						IMD2FUomgJbjX70I66l(unitOfWork);
						num4 = 2;
						goto IL_0419;
						IL_0419:
						switch (num4)
						{
						default:
							goto end_IL_03f4;
						case 0:
							goto end_IL_03f4;
						case 1:
							break;
						case 2:
							goto end_IL_03f4;
						}
						goto IL_044e;
						end_IL_03f4:;
					}
					goto case 3;
				case 17:
					_003C_003Ec__DisplayClass38_.bookmark = bookmark;
					num2 = 25;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
					{
						num2 = 32;
					}
					continue;
				case 21:
					unitOfWork = (IUnitOfWork)YoOfZ4oUklFm7QBZcB8(UnitOfWorkManager, string.Empty, true, IsolationLevel.ReadUncommitted);
					num2 = 23;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
					{
						num2 = 21;
					}
					continue;
				case 29:
					messageReceiveElement = element as MessageReceiveElement;
					num2 = 7;
					continue;
				case 11:
					WorkflowQueueService.ProcessItemAsyncAfterCommit(workflowQueueItem2);
					num2 = 2;
					continue;
				case 13:
					return workflowQueueItem2;
				case 6:
					return null;
				case 20:
					return null;
				case 25:
					if (oumMrBoROnZZDGpspd1(Om9N4lo6UswbJsttiKI(fuqro0oO0G0jBXaguPB(messageReceiveElement))))
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 32:
					logger.DebugFormat((string)x5PXhOoVgAcMaGN2a8O(-869419654 ^ -869428886), instance.Id);
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
					{
						num2 = 22;
					}
					continue;
				case 8:
					if (mPoQNyoWO8xZK4Hb7Rx(obj.GetType(), wbUIMYoBLI77Gc54eeX(typeof(bool).TypeHandle)))
					{
						num = 14;
						break;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	protected virtual bool ProcessMessageBookmark(IWorkflowMessageBookmark messageBookmark, WebData data)
	{
		//Discarded unreachable code: IL_009b, IL_00de, IL_01db
		int num = 9;
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		object obj = default(object);
		MessageReceiveElement messageReceiveElement = default(MessageReceiveElement);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		WorkflowMessageExecuteData data2 = default(WorkflowMessageExecuteData);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
					{
						num2 = 6;
					}
					continue;
				case 13:
					if (obj == null)
					{
						num = 10;
						break;
					}
					goto case 12;
				case 7:
					messageReceiveElement = ((IEnumerable<Element>)JXx9iWoyfTR6JKfVcbK(((IWorkflowProcess)of3prGoGibWlBeM6hfP(workflowInstance)).Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass39_._003CProcessMessageBookmark_003Eb__0) as MessageReceiveElement;
					num2 = 14;
					continue;
				case 12:
					if (!mPoQNyoWO8xZK4Hb7Rx(obj.GetType(), wbUIMYoBLI77Gc54eeX(typeof(bool).TypeHandle)))
					{
						num2 = 6;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 11;
				default:
					return false;
				case 4:
				case 6:
				case 10:
					data2 = new WorkflowMessageExecuteData(_003C_003Ec__DisplayClass39_.messageBookmark, data);
					num2 = 15;
					continue;
				case 8:
					_003C_003Ec__DisplayClass39_.messageBookmark = messageBookmark;
					num2 = 5;
					continue;
				case 11:
					if (!(bool)obj)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 16:
					return true;
				case 2:
					obj = Locator.GetServiceNotNull<IWorkflowScriptingService>().ExecuteScript(workflowInstance, (string)Om9N4lo6UswbJsttiKI(fuqro0oO0G0jBXaguPB(messageReceiveElement)), new Dictionary<string, object>
					{
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-282877824 ^ -282884738),
							data
						},
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E58FEAF ^ 0x4E58DFA9),
							m4bkPbo02nuXyf8LbHK(_003C_003Ec__DisplayClass39_.messageBookmark)
						}
					});
					num2 = 13;
					continue;
				case 14:
					if (messageReceiveElement != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 15:
					WorkflowRuntimeService.Execute(data2);
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					workflowInstance = (IWorkflowInstance)GRdqD4ofiXkTTnrhHuV(dWtsYNoldgyvuePZucg(_003C_003Ec__DisplayClass39_.messageBookmark));
					num2 = 7;
					continue;
				case 3:
					if (oumMrBoROnZZDGpspd1(Om9N4lo6UswbJsttiKI(fuqro0oO0G0jBXaguPB(messageReceiveElement))))
					{
						num = 4;
						break;
					}
					goto case 2;
				case 1:
					if (fuqro0oO0G0jBXaguPB(messageReceiveElement) != null)
					{
						num2 = 3;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	public WorkflowMessagingService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yxh1cBoLtLJMGsFWAO7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowMessagingService()
	{
		int num = 25;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					F_WMBI_ControlParameterValue = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowMessageBookmarkInfo, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 10;
					continue;
				case 30:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(typeof(IWorkflowMessageBookmark), x5PXhOoVgAcMaGN2a8O(0x6C324F5C ^ 0x6C32698C));
					num2 = 23;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
					{
						num2 = 16;
					}
					continue;
				case 6:
					parameterExpression = Expression.Parameter(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowBookmark).TypeHandle), (string)x5PXhOoVgAcMaGN2a8O(--192118127 ^ 0xB735BBF));
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					F_WMBI_CreationDate = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowMessageBookmarkInfo, object>>((Expression)mkboyLo74ThDykoIJBS(bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wbUIMYoBLI77Gc54eeX(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 != 0)
					{
						num2 = 28;
					}
					continue;
				case 8:
					F_Bookmark_ElementUid = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>(Expression.Convert((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wbUIMYoBLI77Gc54eeX(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 9;
					continue;
				case 14:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(typeof(WorkflowMessageBookmarkInfo), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x234241C0 ^ 0x23426710));
					num2 = 11;
					continue;
				case 25:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
					{
						num2 = 24;
					}
					continue;
				case 32:
					F_WMI_DestinationInstace = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
					{
						num2 = 21;
					}
					continue;
				case 5:
					F_Bookmark_Instance = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>(Expression.Property(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num = 4;
					break;
				case 33:
					F_Id = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)mkboyLo74ThDykoIJBS(bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 6;
					}
					continue;
				case 28:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(WorkflowMessageBookmarkInfo).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-254800515 ^ -254792787));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
					{
						num2 = 2;
					}
					continue;
				case 34:
					F_WMI_MessageType = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageItem, object>>((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 29;
					continue;
				case 27:
					parameterExpression = Expression.Parameter(wbUIMYoBLI77Gc54eeX(typeof(WorkflowMessageBookmarkInfo).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x82E000E ^ 0x82E26DE));
					num2 = 22;
					continue;
				case 20:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(typeof(IWorkflowMessageBookmark), x5PXhOoVgAcMaGN2a8O(--286570904 ^ 0x11149F48));
					num2 = 15;
					continue;
				case 3:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowMessageBookmark).TypeHandle), x5PXhOoVgAcMaGN2a8O(-1363339545 ^ -1363333065));
					num2 = 16;
					continue;
				case 19:
					F_WMB_Status = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)mkboyLo74ThDykoIJBS(bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wbUIMYoBLI77Gc54eeX(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 30;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					F_WMBI_Instance = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowMessageBookmarkInfo, object>>((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					F_WMB_MessageType = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 20;
					continue;
				case 29:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowMessageItem).TypeHandle), x5PXhOoVgAcMaGN2a8O(-1737696342 ^ -1737687686));
					num2 = 32;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
					{
						num2 = 23;
					}
					continue;
				case 13:
					F_WMB_CreationDate = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)mkboyLo74ThDykoIJBS(bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wbUIMYoBLI77Gc54eeX(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num = 3;
					break;
				case 24:
					logger = Logger.GetLogger((string)x5PXhOoVgAcMaGN2a8O(-92270799 ^ -92264043));
					num2 = 7;
					continue;
				case 2:
					F_WMBI_ElementUid = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowMessageBookmarkInfo, object>>((Expression)mkboyLo74ThDykoIJBS(bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
					{
						num2 = 9;
					}
					continue;
				case 26:
					F_WMBI_MessageType = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowMessageBookmarkInfo, object>>((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 != 0)
					{
						num2 = 14;
					}
					continue;
				case 21:
					return;
				case 4:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowBookmark).TypeHandle), x5PXhOoVgAcMaGN2a8O(-2038986505 ^ -2038976985));
					num2 = 8;
					continue;
				default:
					parameterExpression = Expression.Parameter(wbUIMYoBLI77Gc54eeX(typeof(WorkflowMessageBookmarkInfo).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481963761));
					num2 = 18;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 != 0)
					{
						num2 = 16;
					}
					continue;
				case 9:
					parameterExpression = Expression.Parameter(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowInstance).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2144947971 ^ -2144954835));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 != 0)
					{
						num2 = 31;
					}
					continue;
				case 10:
					parameterExpression = Expression.Parameter(typeof(IWorkflowMessageItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFAE81C9 ^ 0xFAEA719));
					num2 = 34;
					continue;
				case 12:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(WorkflowMessageBookmarkInfo).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C9503E1 ^ 0x2C952531));
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
					{
						num2 = 26;
					}
					continue;
				case 31:
					F_Instance_Status = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>((Expression)mkboyLo74ThDykoIJBS(bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wbUIMYoBLI77Gc54eeX(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 17;
					continue;
				case 1:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowMessageBookmark).TypeHandle), x5PXhOoVgAcMaGN2a8O(-1329217772 ^ -1329227324));
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(wbUIMYoBLI77Gc54eeX(typeof(IWorkflowMessageBookmark).TypeHandle), x5PXhOoVgAcMaGN2a8O(-746011232 ^ -746003600));
					num2 = 33;
					continue;
				case 17:
					parameterExpression = (ParameterExpression)x9np8eoJGuZMvh4MKgE(typeof(IWorkflowMessageBookmark), x5PXhOoVgAcMaGN2a8O(0x3C126B81 ^ 0x3C124D51));
					num2 = 19;
					continue;
				case 15:
					F_WMB_ControlParameterValue = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)bYApk5oruwI3YfEbVO6(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
					{
						num2 = 27;
					}
					continue;
				case 23:
					F_WMB_Bookmark = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>(Expression.Property(parameterExpression, (MethodInfo)RpFhjco5Vc36AN4HRnp((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool bOr6xeosF3h7S2C7Oya()
	{
		return ooWbkjotmBLbvWAMvBW == null;
	}

	internal static WorkflowMessagingService w2tG7io2TU555fWXBMn()
	{
		return ooWbkjotmBLbvWAMvBW;
	}

	internal static void PCpfNvoqZerHbFK5JTW(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void JVqOWwoQUHYE7N3dbIs(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object x5PXhOoVgAcMaGN2a8O(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nvqvWSoDWdeqDhMjDRl(object P_0)
	{
		return ((IWorkflowMessageType)P_0).ReliableDelivery;
	}

	internal static object svaa2joKJk2DpL73k92(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Xr4CPJoMi58w2Xkx8Qd(object P_0, object P_1, object P_2, object P_3)
	{
		return ((WorkflowMessageItemManager)P_0).CreateMessage((IWorkflowInstance)P_1, (IWorkflowMessageType)P_2, P_3);
	}

	internal static void UXguPjoaudpSyJoGOnN(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).DebugFormat((string)P_1, (object[])P_2);
	}

	internal static object G7X4tJoYI12HIZjyqaL(object P_0, object P_1, object P_2, object P_3)
	{
		return ((WorkflowMessagingService)P_0).DoReliableDelivery((IWorkflowInstance)P_1, (IWorkflowMessageType)P_2, (IWorkflowMessageItem)P_3);
	}

	internal static int UL8rvxovrBMry95lSV2(object P_0)
	{
		return ((WorkflowMessageItemManager)P_0).GetTotalMessagesInQueue();
	}

	internal static void rJvqfIoPBqjqKi4QHGD(object P_0, int value)
	{
		((WorkflowMessageQueueInfo)P_0).MessagesCount = value;
	}

	internal static int fy1O8Go4DGg6hIvd5TP(object P_0)
	{
		return ((WorkflowMessageItemManager)P_0).GetTotalReliableReceivers();
	}

	internal static void IZns28o9TUPesvlmkIs(object P_0, int value)
	{
		((WorkflowMessageQueueInfo)P_0).ReceiversCount = value;
	}

	internal static void K3JKR2oTSkgiwFpQvlO(object P_0, int value)
	{
		((WorkflowMessageQueueInfo)P_0).StaleCount = value;
	}

	internal static object gL1cl6ocnKLg9oQijuc(object P_0)
	{
		return ((IWorkflowMessageItem)P_0).DestinationWorkflowInstance;
	}

	internal static object AMVTiwoNOf5sT0XO6cX(object P_0)
	{
		return ((IWorkflowMessageItem)P_0).MessageType;
	}

	internal static object r335dCodw920eGWexTC(object P_0)
	{
		return ((IWorkflowMessageItem)P_0).MessageData;
	}

	internal static void lsfEhWojmIS0beAGFY0(object P_0, int value)
	{
		((WorkflowMessageSendResult)P_0).ReceivedCount = value;
	}

	internal static int QlltEcoSPcKRkEeEC6L(object P_0)
	{
		return ((ICollection<IWorkflowMessageBookmark>)P_0).Count;
	}

	internal static int sNOf14okNHYtCUsUPAy(object P_0)
	{
		return ((WorkflowMessageSendResult)P_0).ReceivedCount;
	}

	internal static object eNga4MobQhpqfETQGqr(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((WorkflowMessagingService)P_0).QueueActivity((IWorkflowInstance)P_1, (IWorkflowBookmark)P_2, (WebData)P_3, (IWorkflowMessageBookmark)P_4);
	}

	internal static object YoOfZ4oUklFm7QBZcB8(object P_0, object P_1, bool P_2, IsolationLevel P_3)
	{
		return ((IUnitOfWorkManager)P_0).Create((string)P_1, P_2, P_3);
	}

	internal static void IMD2FUomgJbjX70I66l(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid eaadf6oAkmG2hgHnrRk(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Uid;
	}

	internal static WorkflowInstanceStatus x5J8ugop1gfSZYLniD6(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object of3prGoGibWlBeM6hfP(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object cpA13jonZgiKaNRpZSt(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object JXx9iWoyfTR6JKfVcbK(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object fuqro0oO0G0jBXaguPB(object P_0)
	{
		return ((MessageReceiveElement)P_0).MessageProcessCondition;
	}

	internal static object Om9N4lo6UswbJsttiKI(object P_0)
	{
		return ((Condition)P_0).ScriptName;
	}

	internal static bool oumMrBoROnZZDGpspd1(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object m4bkPbo02nuXyf8LbHK(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).MessageType;
	}

	internal static Type wbUIMYoBLI77Gc54eeX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool mPoQNyoWO8xZK4Hb7Rx(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object hcgj6VoHpNSRG741Qf0(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((WorkflowQueueItemManager)P_0).CreateQueueItem((IWorkflowInstance)P_1, (Element)P_2, P_3);
	}

	internal static Guid AkggofoeqoXJnptS76Y(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static void SEu6dhoiPuU85cwEsoL(object P_0, Guid P_1)
	{
		((IWorkflowQueueItem)P_0).Uid = P_1;
	}

	internal static void z5YZLOouZR7Ze4jK6Cn(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object dWtsYNoldgyvuePZucg(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Bookmark;
	}

	internal static object GRdqD4ofiXkTTnrhHuV(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static void yxh1cBoLtLJMGsFWAO7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object x9np8eoJGuZMvh4MKgE(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object bYApk5oruwI3YfEbVO6(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object mkboyLo74ThDykoIJBS(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object RpFhjco5Vc36AN4HRnp(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}
}
