using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.CommonWorkflowActivity;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Catalogs;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Plugins;

public class CatalogEditActivity : CommonWorkflowActivity<CatalogEditElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object LU9LytvHVGSpBlPxVbMv;

		public Type ActivityType => t0NbptvH7nhSCkr9C602(typeof(CatalogEditActivity).TypeHandle);

		public Type DiagramElementType => t0NbptvH7nhSCkr9C602(typeof(CatalogEditElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			OKY4B5vH29Ynr7D9pr85();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type t0NbptvH7nhSCkr9C602(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void OKY4B5vH29Ynr7D9pr85()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool iic9rRvHAttJ3g5Xw03x()
		{
			return LU9LytvHVGSpBlPxVbMv == null;
		}

		internal static Info x9U99uvHGb7nHr6Z9xO0()
		{
			return (Info)LU9LytvHVGSpBlPxVbMv;
		}
	}

	private IMetadataRuntimeService metadataRuntimeService;

	internal static CatalogEditActivity t3L2E5ZgTrnOK0h9CmQw;

	protected override bool CanInduceIdle => true;

	public CatalogEditActivity(IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
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
				this.metadataRuntimeService = metadataRuntimeService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private DateTime? CalculateEndDateByLimit(IWorkflowInstance instance)
	{
		return CalculateEndDateByLimit(instance, null);
	}

	private DateTime? CalculateEndDateByLimit(IWorkflowInstance instance, IUser executor)
	{
		DateTime? result = null;
		if (base.Element.LimitByTime && base.Element.TimeOfExecution != null)
		{
			return base.Element.TimeOfExecution.Evaluate(instance, executor);
		}
		return result;
	}

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_017b, IL_018a, IL_02d0, IL_02e3, IL_02f2, IL_0457, IL_0466, IL_0509, IL_0518, IL_0694, IL_06a3
		int num = 13;
		Guid catlogType = default(Guid);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		ICatalogEditTask catalogEditTask = default(ICatalogEditTask);
		Guid uid = default(Guid);
		DateTime? dateTime = default(DateTime?);
		IMessageManager serviceNotNull = default(IMessageManager);
		List<IUser> executorsTasks = default(List<IUser>);
		IUser[] array = default(IUser[]);
		IEntity entity = default(IEntity);
		TextTemplateGenerator textTemplateGenerator = default(TextTemplateGenerator);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		int num3 = default(int);
		TextTemplateGenerator textTemplateGenerator2 = default(TextTemplateGenerator);
		NotificationElement.DataSource dataSource3 = default(NotificationElement.DataSource);
		NotificationElement.DataSource dataSource = default(NotificationElement.DataSource);
		IUser executor = default(IUser);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 49:
					catlogType = GetCatlogType(base.Element, (WorkflowInstanceContext)ruLQt6ZgA0JKZbRbyGMq(workflowInstance));
					num2 = 18;
					continue;
				case 51:
					mfSPd1ZBJYEIC0kYPbuO(catalogEditTask, workflowInstance);
					num2 = 25;
					continue;
				case 23:
					LVX1C3ZBZpqaZi9fS5N8(catalogEditTask, KD3r7DZBKSJS4GC5ykt5(base.Element));
					num2 = 37;
					continue;
				case 6:
					uid = base.Element.DocumentVars.First();
					num2 = 36;
					continue;
				case 22:
					catalogEditTask.EndDate = dateTime.Value;
					num2 = 17;
					continue;
				case 9:
				case 39:
					ContinueOnDefaultConnector(context);
					num2 = 28;
					continue;
				case 40:
				{
					IUser[] swimlaneExecutors = GetSwimlaneExecutors(context);
					serviceNotNull = Locator.GetServiceNotNull<IMessageManager>();
					executorsTasks = new List<IUser>();
					array = swimlaneExecutors;
					num2 = 37;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
					{
						num2 = 44;
					}
					continue;
				}
				case 37:
					dateTime = CalculateEndDateByLimit(workflowInstance);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
				case 42:
					if (!S7HFErZgzlsb49ul1VHh(base.Element))
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 7;
				case 16:
					if (entity == null)
					{
						num2 = 49;
						continue;
					}
					goto case 38;
				case 18:
					if (!yroBiKZgGDIGGrbeFVIt(catlogType, Guid.Empty))
					{
						num2 = 35;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 30;
				case 26:
					textTemplateGenerator = new TextTemplateGenerator((string)Lh1PT6Zg1dSm9kiGxA47(base.Element));
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 20;
					}
					continue;
				case 50:
					if (!sKLwFHZgS5mQUAIIVK0E(base.Element))
					{
						num2 = 19;
						continue;
					}
					goto case 26;
				case 45:
					CreateSheduleTask(workflowBookmark, workflowInstance);
					num = 41;
					break;
				case 41:
					return;
				case 34:
					if (K54WOwZgUZUWFdSG06RA(base.Element))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num2 = 6;
						}
						continue;
					}
					workflowBookmark = (IWorkflowBookmark)TWNRD8ZgaPaf6W0gjRF9(this, workflowInstance);
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
				case 33:
					if (num3 >= array.Length)
					{
						num2 = 45;
						continue;
					}
					goto case 46;
				case 4:
				case 19:
					FYK4JFZgw2OIfElbbRgu(catalogEditTask, VOC2tMZg4RpdnvPhcQFX(base.Element));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 27:
					if (qg8m5DZgepg09GoJfpRh(base.Element.DocumentVars) == 1)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 1;
				case 43:
					EgnfnAZgr66hl39lP06I(context, workflowBookmark.Uid.ToString(), new BookmarkCallback(OnTaskCompleted));
					num2 = 40;
					continue;
				case 48:
					LVX1C3ZBZpqaZi9fS5N8(catalogEditTask, ywIqllZgEfY8iw76o3B3(textTemplateGenerator2, dataSource3));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
				{
					NotificationElement.DataSource dataSource4 = new NotificationElement.DataSource();
					M4i1JYZghucnFtJvKr7Z(dataSource4, workflowInstance);
					dataSource4.Context = workflowInstance.Context;
					dataSource = dataSource4;
					num2 = 10;
					continue;
				}
				case 15:
				{
					NotificationElement.DataSource dataSource2 = new NotificationElement.DataSource();
					M4i1JYZghucnFtJvKr7Z(dataSource2, workflowInstance);
					jbsKb9ZBOA9rkp2tMdmg(dataSource2, workflowInstance.Context);
					dataSource3 = dataSource2;
					num2 = 48;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 30;
					}
					continue;
				}
				case 25:
					catalogEditTask.Save();
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					cZPsM0ZgIModv1u1OTgn(ruLQt6ZgA0JKZbRbyGMq(workflowInstance), entity.CastAsRealType(), cfXdjJZgioUwM2kbKhE4(base.Element.Map));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					return;
				case 46:
					executor = array[num3];
					num2 = 47;
					continue;
				case 31:
				case 52:
					num3++;
					num2 = 33;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					textTemplateGenerator2 = new TextTemplateGenerator((string)KD3r7DZBKSJS4GC5ykt5(base.Element));
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 2;
					}
					continue;
				case 24:
					lQwS3jZBlVKtjCOVQhLw(serviceNotNull, catalogEditTask, DefaultEntityActions.CreateGuid);
					num2 = 52;
					continue;
				case 36:
					propertyMetadata = GetProperty(workflowInstance, uid);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					nVcUHvZBvUW9A7cSvsuo((IWorkflowTaskBase)catalogEditTask, workflowBookmark);
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 12;
					}
					continue;
				case 11:
					if (dateTime.HasValue)
					{
						num2 = 22;
						continue;
					}
					goto case 17;
				case 29:
					E8IpDmZgojJLbphXFAFW(base.Element, workflowInstance, entity);
					num2 = 38;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 6;
					}
					continue;
				case 17:
					if (!AssignExecutor(catalogEditTask, executor, executorsTasks))
					{
						num2 = 31;
						continue;
					}
					goto case 21;
				case 10:
					FYK4JFZgw2OIfElbbRgu(catalogEditTask, ywIqllZgEfY8iw76o3B3(textTemplateGenerator, dataSource));
					num2 = 42;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 23;
					}
					continue;
				case 47:
					catalogEditTask = InterfaceActivator.Create<ICatalogEditTask>();
					num = 32;
					break;
				case 38:
					if (q3cmn8ZgFovfy83FuZFr(base.Element) == null)
					{
						num = 39;
						break;
					}
					goto case 2;
				case 12:
					workflowInstance = (IWorkflowInstance)UvpC1GZgkBMM1xr1eIxS(this, context);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 34;
					}
					continue;
				case 44:
					num3 = 0;
					num = 3;
					break;
				case 32:
					propertyMetadata = null;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 27;
					}
					continue;
				case 30:
					throw new ArgumentException(SR.T((string)lqGsfbZgCU1rwpcWnFLQ(-495296780 ^ -495393198)));
				case 35:
					entity = (IEntity)wFJmpBZg2FlJ7igXsjty(UW75jNZg7SLdt8HD99Iy(metadataRuntimeService, catlogType, true));
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
					{
						num2 = 11;
					}
					continue;
				case 13:
					HBmuh6ZgMhL0kEk7VmU8(context, lqGsfbZgCU1rwpcWnFLQ(-1638225214 ^ -1638230542));
					num2 = 12;
					continue;
				case 8:
					entity = (IEntity)IPM7RIZgVR1Di425nmDm(base.Element, workflowInstance);
					num2 = 16;
					continue;
				case 1:
					nCUoBSZgxhaw5enGfyI2(catalogEditTask, new ReferenceOnEntity
					{
						ObjectTypeUId = ((propertyMetadata != null) ? Qtk0a4ZgNamWXN3v5jXg(propertyMetadata) : Guid.Empty)
					});
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
					{
						num2 = 50;
					}
					continue;
				case 21:
					catalogEditTask.PlanWorkLog = ((JN9tZMZBY5NcJOumB5HE(base.Element) && dd9K33ZB8GgXZqhgYuyM(base.Element) != null) ? ((WorkLogTimeOfExecution)dd9K33ZB8GgXZqhgYuyM(base.Element)).Evaluate(workflowInstance, (IUser)UU2bwvZBsswNHn38sqno(catalogEditTask)) : null);
					num2 = 51;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	protected void OnTaskCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		//Discarded unreachable code: IL_0081, IL_0198, IL_01a2, IL_037f, IL_03b7, IL_03c6, IL_054b
		int num = 22;
		WorkflowTaskTerminateData workflowTaskTerminateData = default(WorkflowTaskTerminateData);
		WorkflowTaskExecuteData workflowTaskExecuteData = default(WorkflowTaskExecuteData);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		ICatalogEditTask catalogEditTask = default(ICatalogEditTask);
		IEnumerator<ITaskBase> enumerator = default(IEnumerator<ITaskBase>);
		ITaskBase current = default(ITaskBase);
		IEnumerable<IUser> recipientsForNotification = default(IEnumerable<IUser>);
		IUser second = default(IUser);
		IEnumerable<ITaskBase> tasks = default(IEnumerable<ITaskBase>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					EgnfnAZgr66hl39lP06I(context, mGQthPZBbyEPb2SwEfvX(PTKhW8ZBtBtxV3cZTme0(workflowTaskTerminateData)).ToString(), new BookmarkCallback(OnTaskCompleted));
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 2;
					}
					continue;
				case 21:
					workflowTaskExecuteData = state as WorkflowTaskExecuteData;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 15;
					}
					continue;
				case 17:
					if (um7h42ZBy9dvlU3Zxuhj(flowConnectorElement) == EventTrigger.Script)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 23;
				case 18:
					EF5rpLZB54Pg3BZ5bBP5(this, PTKhW8ZBtBtxV3cZTme0(workflowTaskTerminateData), workflowInstance, default(Guid));
					num2 = 16;
					continue;
				case 19:
					if (catalogEditTask != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 15:
					workflowTaskTerminateData = state as WorkflowTaskTerminateData;
					num2 = 3;
					continue;
				case 22:
					HBmuh6ZgMhL0kEk7VmU8(state, lqGsfbZgCU1rwpcWnFLQ(0x69063C81 ^ 0x69075D01));
					num2 = 21;
					continue;
				case 7:
					try
					{
						while (true)
						{
							IL_02bd:
							int num3;
							if (!gcQ1aMZBu9iBbupIkam3(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
								{
									num3 = 0;
								}
								goto IL_01a6;
							}
							goto IL_0330;
							IL_0330:
							current = enumerator.Current;
							num3 = 6;
							goto IL_01a6;
							IL_01a6:
							while (true)
							{
								switch (num3)
								{
								case 4:
								{
									IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
									EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, workflowInstance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772557672));
									entityActionEventArgs.ExtendedProperties[(string)lqGsfbZgCU1rwpcWnFLQ(-432000546 ^ -431982760)] = workflowInstance.Id;
									entityActionEventArgs.ExtendedProperties[(string)lqGsfbZgCU1rwpcWnFLQ(--1212129906 ^ 0x483FE4FC)] = workflowInstance.Name;
									entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667537969)] = qRV1TjZBB4xJPTtM6TmM(current);
									entityActionEventArgs.ExtendedProperties[(string)lqGsfbZgCU1rwpcWnFLQ(-683713632 ^ -683735656)] = OpgwvDZBcQFoAYEDkEr7(workflowInstance);
									entityActionEventArgs.ExtendedProperties[(string)lqGsfbZgCU1rwpcWnFLQ(0x65B7F624 ^ 0x65B69246)] = recipientsForNotification.ConcatIfNotNull(second);
									ta4evRZBPHeDXZbyKuU9(serviceNotNull2, entityActionEventArgs);
									num3 = 5;
									continue;
								}
								case 3:
									goto IL_02bd;
								case 2:
									current.Status = (TaskBaseStatus)eJ3dSoZBX1sh7Vh5fpyR();
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
									{
										num3 = 1;
									}
									continue;
								case 6:
									second = (IUser)xLYDaOZBgf05XrcVaEjF(this, current, flowConnectorElement);
									num3 = 4;
									continue;
								case 1:
									JG72GcZBdrqIbIfJmS8N(current);
									num3 = 3;
									continue;
								case 7:
									goto IL_0330;
								case 5:
									if (current.IsActive())
									{
										num3 = 2;
										continue;
									}
									goto IL_02bd;
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
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									Ikdu7hZBD9q5PThM8xMK(enumerator);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 12;
				case 16:
					return;
				case 23:
				{
					IActivityEscalationNotifyService serviceNotNull = Locator.GetServiceNotNull<IActivityEscalationNotifyService>();
					tasks = GetTasks(workflowTaskTerminateData.Bookmark);
					recipientsForNotification = serviceNotNull.GetRecipientsForNotification(new GetRecipientsParameters(this, workflowInstance, flowConnectorElement));
					num2 = 9;
					continue;
				}
				case 3:
					if (workflowTaskTerminateData != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						if (workflowTaskExecuteData == null)
						{
							return;
						}
						num2 = 20;
					}
					continue;
				case 13:
					OhZ9pjZB97J5KOHB9iFN(OXLhCNZBfYVfhQZF6DGA(), catalogEditTask);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					enumerator = tasks.GetEnumerator();
					num = 7;
					break;
				case 6:
					flowConnectorElement = ((ElementList)OF90XoZB0X7aUocZeMaU(base.Diagram))[workflowTaskTerminateData.ConnectorUid] as FlowConnectorElement;
					num = 17;
					break;
				case 8:
					if ((bool)base.WorkflowScriptingService.ExecuteScript(workflowInstance, (string)DCykIZZBmhYjUEDNDYEH(flowConnectorElement)))
					{
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 5:
					return;
				case 4:
					catalogEditTask.Status = (TaskBaseStatus)WXMY9qZBLONXJf4aOHt4();
					num2 = 14;
					continue;
				case 12:
					ContinueOnConnector(context, gHXNKcZBn5sw7j94yi7b(workflowTaskTerminateData));
					num2 = 11;
					continue;
				case 10:
					return;
				case 20:
					catalogEditTask = ((IWorkflowTaskBase)ePkUrKZBH56CxHeC7MfD(workflowTaskExecuteData)).CastAsRealType() as ICatalogEditTask;
					num2 = 19;
					continue;
				case 14:
					JG72GcZBdrqIbIfJmS8N(catalogEditTask);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 13;
					}
					continue;
				case 1:
					workflowInstance = (IWorkflowInstance)UvpC1GZgkBMM1xr1eIxS(this, context);
					num2 = 6;
					continue;
				default:
					ContinueOnConnector(context, CRkOWMZBW3HChuuoyO1m(workflowTaskExecuteData));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 10;
					}
					continue;
				case 11:
					return;
				}
				break;
			}
		}
	}

	public static Guid GetCatlogType(CommonEditEntityWorkflowElement element, WorkflowInstanceContext context)
	{
		return jUUyqcZBjeFIAGQ8CWZd(element, context);
	}

	protected virtual IEnumerable<ITaskBase> GetTasks(IWorkflowBookmark bookmark)
	{
		return Locator.GetServiceNotNull<WorkflowTaskBaseManager>().GetTasks(bookmark);
	}

	internal static bool hcrL7iZgQmjo1DuoXFXm()
	{
		return t3L2E5ZgTrnOK0h9CmQw == null;
	}

	internal static CatalogEditActivity dabYeRZgpLddGIE7JUkG()
	{
		return t3L2E5ZgTrnOK0h9CmQw;
	}

	internal static object lqGsfbZgCU1rwpcWnFLQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void HBmuh6ZgMhL0kEk7VmU8(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object UvpC1GZgkBMM1xr1eIxS(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static bool K54WOwZgUZUWFdSG06RA(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).SilentModeVar;
	}

	internal static object IPM7RIZgVR1Di425nmDm(object P_0, object P_1)
	{
		return ((CatalogEditElement)P_0).ExtractFromInstance((IWorkflowInstance)P_1);
	}

	internal static object ruLQt6ZgA0JKZbRbyGMq(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static bool yroBiKZgGDIGGrbeFVIt(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Type UW75jNZg7SLdt8HD99Iy(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUid(P_1, P_2);
	}

	internal static object wFJmpBZg2FlJ7igXsjty(Type P_0)
	{
		return InterfaceActivator.Create(P_0);
	}

	internal static void E8IpDmZgojJLbphXFAFW(object P_0, object P_1, object P_2)
	{
		((CatalogEditElement)P_0).SetToInstance((IWorkflowInstance)P_1, (IEntity)P_2);
	}

	internal static object q3cmn8ZgFovfy83FuZFr(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).Map;
	}

	internal static object cfXdjJZgioUwM2kbKhE4(object P_0)
	{
		return ((PropertyMap)P_0).Reverse();
	}

	internal static void cZPsM0ZgIModv1u1OTgn(object P_0, object P_1, object P_2)
	{
		PropertyMapHelper.Map(P_0, P_1, (PropertyMap)P_2);
	}

	internal static object TWNRD8ZgaPaf6W0gjRF9(object P_0, object P_1)
	{
		return ((BPMNActivity<CatalogEditElement>)P_0).CreateBookmark((IWorkflowInstance)P_1);
	}

	internal static object EgnfnAZgr66hl39lP06I(object P_0, object P_1, object P_2)
	{
		return ((NativeActivityContext)P_0).CreateBookmark((string)P_1, (BookmarkCallback)P_2);
	}

	internal static int qg8m5DZgepg09GoJfpRh(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static Guid Qtk0a4ZgNamWXN3v5jXg(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static void nCUoBSZgxhaw5enGfyI2(object P_0, object P_1)
	{
		((ICatalogEditTask)P_0).ObjectType = (ReferenceOnEntity)P_1;
	}

	internal static bool sKLwFHZgS5mQUAIIVK0E(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).FormingTemplateName;
	}

	internal static object Lh1PT6Zg1dSm9kiGxA47(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).TemplateName;
	}

	internal static void M4i1JYZghucnFtJvKr7Z(object P_0, object P_1)
	{
		((NotificationElement.DataSource)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static object ywIqllZgEfY8iw76o3B3(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate(P_1);
	}

	internal static void FYK4JFZgw2OIfElbbRgu(object P_0, object P_1)
	{
		((ITaskBase)P_0).Subject = (string)P_1;
	}

	internal static object VOC2tMZg4RpdnvPhcQFX(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool S7HFErZgzlsb49ul1VHh(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).FormingTemplateDescription;
	}

	internal static object KD3r7DZBKSJS4GC5ykt5(object P_0)
	{
		return ((Element)P_0).Description;
	}

	internal static void jbsKb9ZBOA9rkp2tMdmg(object P_0, object P_1)
	{
		((NotificationElement.DataSource)P_0).Context = P_1;
	}

	internal static void LVX1C3ZBZpqaZi9fS5N8(object P_0, object P_1)
	{
		((ITaskBase)P_0).Description = (string)P_1;
	}

	internal static void nVcUHvZBvUW9A7cSvsuo(object P_0, object P_1)
	{
		((IWorkflowTaskBase)P_0).WorkflowBookmark = (IWorkflowBookmark)P_1;
	}

	internal static bool JN9tZMZBY5NcJOumB5HE(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).LimitByWorkLogTime;
	}

	internal static object dd9K33ZB8GgXZqhgYuyM(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).WorkLogTimeOfExecution;
	}

	internal static object UU2bwvZBsswNHn38sqno(object P_0)
	{
		return ((ITaskBase)P_0).Executor;
	}

	internal static void mfSPd1ZBJYEIC0kYPbuO(object P_0, object P_1)
	{
		BPMNActivity<CatalogEditElement>.SettingEmulation((ITaskBase)P_0, (IWorkflowInstance)P_1);
	}

	internal static void lQwS3jZBlVKtjCOVQhLw(object P_0, object P_1, Guid P_2)
	{
		((IMessageManager)P_0).Delay((IEntity)P_1, P_2);
	}

	internal static object OF90XoZB0X7aUocZeMaU(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static EventTrigger um7h42ZBy9dvlU3Zxuhj(object P_0)
	{
		return ((FlowConnectorElement)P_0).Trigger;
	}

	internal static object DCykIZZBmhYjUEDNDYEH(object P_0)
	{
		return ((FlowConnectorElement)P_0).ScriprEscalation;
	}

	internal static object PTKhW8ZBtBtxV3cZTme0(object P_0)
	{
		return ((WorkflowTaskTerminateData)P_0).Bookmark;
	}

	internal static Guid mGQthPZBbyEPb2SwEfvX(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static void EF5rpLZB54Pg3BZ5bBP5(object P_0, object P_1, object P_2, Guid P_3)
	{
		((CommonWorkflowActivity<CatalogEditElement>)P_0).CreateSheduleTask((IWorkflowBookmark)P_1, (IWorkflowInstance)P_2, P_3);
	}

	internal static object xLYDaOZBgf05XrcVaEjF(object P_0, object P_1, object P_2)
	{
		return ((TaskActivity<CatalogEditElement>)P_0).GetCurrentExecutor((ITaskBase)P_1, (FlowConnectorElement)P_2);
	}

	internal static object qRV1TjZBB4xJPTtM6TmM(object P_0)
	{
		return ((ITaskBase)P_0).Subject;
	}

	internal static object OpgwvDZBcQFoAYEDkEr7(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static void ta4evRZBPHeDXZbyKuU9(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static object eJ3dSoZBX1sh7Vh5fpyR()
	{
		return TaskBaseStatus.WasClosed;
	}

	internal static void JG72GcZBdrqIbIfJmS8N(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool gcQ1aMZBu9iBbupIkam3(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Ikdu7hZBD9q5PThM8xMK(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid gHXNKcZBn5sw7j94yi7b(object P_0)
	{
		return ((WorkflowTaskTerminateData)P_0).ConnectorUid;
	}

	internal static object ePkUrKZBH56CxHeC7MfD(object P_0)
	{
		return ((WorkflowTaskExecuteData)P_0).Task;
	}

	internal static object WXMY9qZBLONXJf4aOHt4()
	{
		return TaskBaseStatus.Complete;
	}

	internal static object OXLhCNZBfYVfhQZF6DGA()
	{
		return CatalogEditTaskManager.Instance;
	}

	internal static void OhZ9pjZB97J5KOHB9iFN(object P_0, object P_1)
	{
		((CatalogEditTaskManager)P_0).Assign((ICatalogEditTask)P_1);
	}

	internal static Guid CRkOWMZBW3HChuuoyO1m(object P_0)
	{
		return ((WorkflowTaskExecuteData)P_0).ConnectorUid;
	}

	internal static Guid jUUyqcZBjeFIAGQ8CWZd(object P_0, object P_1)
	{
		return ((ICommonEditEntityWorkflowElement)P_0).GetEntityType((WorkflowInstanceContext)P_1);
	}
}
