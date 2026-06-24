using System;
using System.Activities;
using System.Activities.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server)]
public class WorkflowRuntimeService : IWorkflowRuntimeService
{
	private static readonly ILogger WorkflowLog;

	private static WorkflowRuntimeService suYeFM7Cl7ghrAXqAYF;

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		protected get
		{
			return _003CSessionProvider_003Ek__BackingField;
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
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

	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
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

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public OrganizationItemManager OrganizationItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003COrganizationItemManager_003Ek__BackingField;
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
					_003COrganizationItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
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

	public IContextBoundVariableService ContextBoundVariableService
	{
		[CompilerGenerated]
		get
		{
			return _003CContextBoundVariableService_003Ek__BackingField;
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
					_003CContextBoundVariableService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
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

	public WorkflowQueueItemManager QueueItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CQueueItemManager_003Ek__BackingField;
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
					_003CQueueItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowTrackingItemManager WorkflowTrackingItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowTrackingItemManager_003Ek__BackingField;
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
					_003CWorkflowTrackingItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
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

	public IBackgroundOperationService BackgroundOperationService
	{
		[CompilerGenerated]
		get
		{
			return _003CBackgroundOperationService_003Ek__BackingField;
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
					_003CBackgroundOperationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
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
				case 1:
					_003CWorkflowMetadataLoaderService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
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

	public IExternalWorkflowRuntimeService ExternalWorkflowRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CExternalWorkflowRuntimeService_003Ek__BackingField;
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
					_003CExternalWorkflowRuntimeService_003Ek__BackingField = value;
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

	internal IEnumerable<IWorkflowExecuteDataHandler> WorkflowExecuteDataHandlers => Locator.GetServiceNotNull<IEnumerable<IWorkflowExecuteDataHandler>>();

	protected internal ISession Session => (ISession)I6AY2H2WvZBWIvQlp5F(SessionProvider, "");

	[Transaction]
	public virtual IWorkflowExecutingContext CreateExecutingContext(IWorkflowInstance instance)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				WBdQgO7VrC1r8nGio4y(ContextBoundVariableService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431936208));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (IWorkflowExecutingContext)MRWD9g7A1M0wO7XV3Bl(this, instance, ContextBoundVariableService, BackgroundOperationService);
			case 2:
				Contract.ArgumentNotNull(instance, (string)LmTIdk7U5XPU3WjX2Q5(-432000546 ^ -431986472));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void Run(IWorkflowInstance instance)
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
				YUgYcP7Gu979wCWUKbD(this, instance, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void Run(IWorkflowInstance instance, bool InitiatorSwimlaneUser)
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
				Glw2XL77SrE27lV36Sr(this, instance, InitiatorSwimlaneUser, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void Run(IWorkflowInstance instance, bool InitiatorSwimlaneUser, bool IsEmulation)
	{
		//Discarded unreachable code: IL_0063, IL_0203, IL_024d, IL_02ba, IL_02c9, IL_0400, IL_041f, IL_042e, IL_045b, IL_046a, IL_067c, IL_06ca, IL_072f, IL_0812, IL_098a, IL_0999, IL_0a8b, IL_0abb, IL_0b4d, IL_0b76, IL_0b85, IL_0c0b, IL_0c4f, IL_0c7b, IL_0cb3, IL_0cc2
		int num = 3;
		int num2 = num;
		DateTime start = default(DateTime);
		IWorkflowExecutingContext workflowExecutingContext = default(IWorkflowExecutingContext);
		bool flag2 = default(bool);
		IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator = default(IEnumerator<EleWise.ELMA.Security.Models.IUser>);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		EleWise.ELMA.Security.Models.IUser current = default(EleWise.ELMA.Security.Models.IUser);
		bool flag = default(bool);
		SwimlaneElement swimlaneElement2 = default(SwimlaneElement);
		PropertyMetadata titleProperty = default(PropertyMetadata);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		IWorkflowSwimlaneExecutor workflowSwimlaneExecutor = default(IWorkflowSwimlaneExecutor);
		EleWise.ELMA.Security.Models.IUser value = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				start = jNeakG7IlQBSqApJdZa();
				num2 = 5;
				break;
			case 4:
				EAg3SP7FcSTiBsbXJEe(instance);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				if (ExternalWorkflowRuntimeService != null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 3:
				Contract.ArgumentNotNull(instance, (string)LmTIdk7U5XPU3WjX2Q5(-720457373 ^ -720443291));
				num2 = 2;
				break;
			case 8:
				return;
			case 6:
				sJ9Xii7iUmoaAnxWFpV(WorkflowMetadataLoaderService, instance.Process);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				workflowExecutingContext = (IWorkflowExecutingContext)FtyaFR7axpuvpQl36DE(this, instance);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 11;
				}
				break;
			case 7:
				Session.Flush();
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				try
				{
					StartEventElement startEventElement = ((IWorkflowProcess)LcY07l72bJiuO0JbQx1(instance)).Diagram.GetStartElement() as StartEventElement;
					int num3 = 8;
					while (true)
					{
						switch (num3)
						{
						case 11:
							return;
						case 34:
							if (flag2)
							{
								int num10 = 11;
								num3 = num10;
								break;
							}
							goto case 14;
						case 37:
							DWlWVR7r6cSrJBXQ6af(instance, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
							num3 = 31;
							break;
						case 33:
							num3 = 30;
							break;
						case 17:
						case 29:
						case 35:
							if (instance.Initiator == null)
							{
								num3 = 22;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
								{
									num3 = 20;
								}
								break;
							}
							goto case 7;
						case 20:
							throw new InvalidOperationException(SR.T((string)LmTIdk7U5XPU3WjX2Q5(-360662087 ^ -360601967)));
						case 18:
							try
							{
								while (true)
								{
									IL_039c:
									int num7;
									if (!sGnY3B2vm7It1NhiWt4(enumerator))
									{
										num7 = 2;
										goto IL_02d8;
									}
									goto IL_0306;
									IL_02d8:
									while (true)
									{
										int num8;
										switch (num7)
										{
										case 6:
											break;
										default:
											Glw2XL77SrE27lV36Sr(this, workflowInstance, InitiatorSwimlaneUser, IsEmulation);
											num8 = 7;
											goto IL_02d4;
										case 8:
											workflowInstance = InterfaceActivator.Create<IWorkflowInstance>();
											num7 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
											{
												num7 = 0;
											}
											continue;
										case 4:
											DWlWVR7r6cSrJBXQ6af(workflowInstance, current);
											num7 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
											{
												num7 = 0;
											}
											continue;
										case 1:
											l0OFI02ZNMvdE86Z9BB(workflowInstance, instance.Process);
											num7 = 4;
											continue;
										case 3:
											goto IL_039c;
										case 7:
											flag2 = true;
											num7 = 3;
											continue;
										case 5:
											if (current.Status == UserStatus.Blocked)
											{
												goto IL_039c;
											}
											num8 = 8;
											goto IL_02d4;
										case 2:
											goto end_IL_039c;
											IL_02d4:
											num7 = num8;
											continue;
										}
										break;
									}
									goto IL_0306;
									IL_0306:
									current = enumerator.Current;
									num7 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
									{
										num7 = 0;
									}
									goto IL_02d8;
									continue;
									end_IL_039c:
									break;
								}
							}
							finally
							{
								int num9;
								if (enumerator == null)
								{
									num9 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
									{
										num9 = 0;
									}
									goto IL_0404;
								}
								goto IL_0439;
								IL_0439:
								J37RX22YqCn0gbVjcY3(enumerator);
								num9 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
								{
									num9 = 1;
								}
								goto IL_0404;
								IL_0404:
								switch (num9)
								{
								case 1:
									goto end_IL_03df;
								case 2:
									goto end_IL_03df;
								}
								goto IL_0439;
								end_IL_03df:;
							}
							goto case 34;
						case 8:
							if (instance.Initiator == null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 31;
						case 6:
							throw new InvalidOperationException((string)dF5NkT7wARidCemFruB(LmTIdk7U5XPU3WjX2Q5(0x246EEF98 ^ 0x246FF0CE)));
						case 25:
							flag = false;
							num3 = 12;
							break;
						case 22:
							if (startEventElement != null)
							{
								if (startEventElement.Trigger != EventTrigger.Timer)
								{
									num3 = 23;
									break;
								}
								swimlaneElement2 = (SwimlaneElement)m8kbcD7zLFrCYOIWTm7(startEventElement, JyAj9k74QXobs6MRsMW(LcY07l72bJiuO0JbQx1(instance)));
								num3 = 26;
							}
							else
							{
								num3 = 20;
							}
							break;
						case 2:
							if (YEhjRL7SYhAAIBKaV8i(KY15dv7xLRqdYxUndJ0(titleProperty), StringDescriptor.UID))
							{
								num3 = 13;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
								{
									num3 = 24;
								}
								break;
							}
							goto case 17;
						case 9:
							if (organizationItem.Users != null)
							{
								num3 = 27;
								break;
							}
							goto case 14;
						case 31:
							if (instance.ParentInstance != null)
							{
								num3 = 29;
								break;
							}
							goto case 28;
						case 1:
							if (!InitiatorSwimlaneUser)
							{
								num3 = 37;
								break;
							}
							goto case 31;
						case 26:
							if (swimlaneElement2 != null)
							{
								num3 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
								{
									num3 = 36;
								}
								break;
							}
							goto case 16;
						case 14:
							throw new InvalidOperationException((string)teYC482sMquBE4th2EH(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43992571), new object[1] { L0KMiQ28tcwnahfmycR(organizationItem) }));
						case 13:
							DWlWVR7r6cSrJBXQ6af(instance, E0t0Ak2OYoc9V2MpTdY(organizationItem));
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
							{
								num3 = 7;
							}
							break;
						case 3:
							if (organizationItem == null)
							{
								num3 = 10;
								break;
							}
							if (E0t0Ak2OYoc9V2MpTdY(organizationItem) != null)
							{
								num3 = 13;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
								{
									num3 = 9;
								}
								break;
							}
							goto case 9;
						case 27:
							flag2 = false;
							num3 = 15;
							break;
						case 23:
							throw new InvalidOperationException((string)dF5NkT7wARidCemFruB(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452196291)));
						case 10:
							throw new InvalidOperationException((string)dF5NkT7wARidCemFruB(LmTIdk7U5XPU3WjX2Q5(0x56A753C9 ^ 0x56A64DBD)));
						case 15:
							enumerator = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)organizationItem.Users).GetEnumerator();
							num3 = 18;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
							{
								num3 = 9;
							}
							break;
						case 32:
							throw new InvalidOperationException((string)dF5NkT7wARidCemFruB(LmTIdk7U5XPU3WjX2Q5(-360662087 ^ -360602179)));
						default:
							if (n7U0Tm7N653aAu7MPRl(instance.Process.NamingScheme) == InstanceNamingScheme.SchemeType.Standart)
							{
								num3 = 21;
								break;
							}
							goto case 17;
						case 24:
							yTj8SJ7EoNmPXSDG826(vEwYmg71YLEatiEdS3L(instance), HcKftD7hIr5yh9n1hcs(titleProperty), JA3LXW7eSl6EfXgZQUv(instance));
							num3 = 35;
							break;
						case 7:
							if (instance.Initiator != null)
							{
								num3 = 25;
								break;
							}
							goto case 6;
						case 21:
							titleProperty = ((EntityMetadata)MetadataLoader.LoadMetadata(instance.Context.GetType())).GetTitleProperty();
							num3 = 19;
							break;
						case 28:
							if (JA3LXW7eSl6EfXgZQUv(instance) == null)
							{
								num3 = 17;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
								{
									num3 = 5;
								}
								break;
							}
							goto case 5;
						case 4:
							CMwr9Y20gqGLWwY9bJF(AuthenticationService, XjZDKb2lXBI6a9A3Oaa(instance));
							num3 = 33;
							break;
						case 19:
							if (titleProperty != null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 17;
						case 16:
							throw new InvalidOperationException((string)dF5NkT7wARidCemFruB(LmTIdk7U5XPU3WjX2Q5(0x5F534A5C ^ 0x5F5257C8)));
						case 36:
							if (swimlaneElement2.SwimlaneType == SwimlaneType.Static)
							{
								organizationItem = OrganizationItemManager.LoadOrNull(hCk1SA2K3YUiD3FEVCo(swimlaneElement2));
								num3 = 3;
							}
							else
							{
								num3 = 32;
							}
							break;
						case 12:
							if (shphNX2JYZMmUpkjmXN(AuthenticationService) == null)
							{
								num3 = 4;
								break;
							}
							goto case 33;
						case 5:
							if (((IWorkflowProcess)LcY07l72bJiuO0JbQx1(instance)).NamingScheme != null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 21;
						case 30:
							try
							{
								int num4;
								if (instance.Responsible == null)
								{
									num4 = 2;
									goto IL_0860;
								}
								goto IL_0a3a;
								IL_0860:
								while (true)
								{
									int num5;
									switch (num4)
									{
									case 1:
										return;
									case 4:
										user = kd6rD225KYcGH3Rllrq(instance.Context, HtDQgA2tc4SsCyQf4dD(swimlaneElement)) as EleWise.ELMA.Security.Models.IUser;
										num4 = 25;
										continue;
									case 15:
										if (instance.IsEmulation)
										{
											num4 = 4;
											continue;
										}
										goto case 24;
									case 5:
										jnsOes2gDdAs5RRagDa(workflowExecutingContext);
										num4 = 22;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
										{
											num4 = 16;
										}
										continue;
									case 9:
										workflowSwimlaneExecutor.User = (EleWise.ELMA.Security.Models.IUser)XjZDKb2lXBI6a9A3Oaa(instance);
										num4 = 19;
										continue;
									case 2:
										instance.Responsible = instance.Initiator;
										num4 = 10;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
										{
											num4 = 13;
										}
										continue;
									case 6:
										if (startEventElement != null)
										{
											num4 = 27;
											continue;
										}
										goto case 7;
									case 3:
										workflowSwimlaneExecutor = InterfaceActivator.Create<IWorkflowSwimlaneExecutor>();
										num4 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
										{
											num4 = 12;
										}
										continue;
									case 25:
										if (user == null)
										{
											num4 = 24;
											continue;
										}
										goto case 20;
									case 16:
										instance.Status = WorkflowInstanceStatus.Running;
										num4 = 6;
										continue;
									case 18:
										swimlaneElement = (SwimlaneElement)m8kbcD7zLFrCYOIWTm7(startEventElement, JyAj9k74QXobs6MRsMW(instance.Process));
										num4 = 10;
										continue;
									default:
										if (!J4ZPKu2bIgXJkUWJvgN(HtDQgA2tc4SsCyQf4dD(swimlaneElement), Guid.Empty))
										{
											num4 = 11;
											continue;
										}
										goto case 28;
									case 27:
										if (DK0DvO2yRWcs8tgJL6q(instance) != null)
										{
											num4 = 7;
											continue;
										}
										goto case 18;
									case 13:
										break;
									case 21:
										workflowSwimlaneExecutor.WorkflowInstance = instance;
										num4 = 7;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
										{
											num4 = 9;
										}
										continue;
									case 10:
										if (swimlaneElement == null)
										{
											num4 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
											{
												num4 = 8;
											}
											continue;
										}
										goto case 3;
									case 7:
									case 8:
									case 11:
									case 17:
										EAg3SP7FcSTiBsbXJEe(instance);
										num4 = 14;
										continue;
									case 12:
										workflowSwimlaneExecutor.SwimlaneUid = mJmLmy2m8ZaThWd9QjY(swimlaneElement);
										num4 = 21;
										continue;
									case 24:
									case 26:
										((Entity<long>)vEwYmg71YLEatiEdS3L(instance)).SetPropertyValue(swimlaneElement.ExecuterProperty, (object)value);
										num4 = 17;
										continue;
									case 14:
										if (IsEmulation)
										{
											num4 = 23;
											continue;
										}
										goto case 5;
									case 19:
										instance.SwimlaneExecutors.Add(workflowSwimlaneExecutor);
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
										{
											num4 = 0;
										}
										continue;
									case 28:
										value = (EleWise.ELMA.Security.Models.IUser)XjZDKb2lXBI6a9A3Oaa(instance);
										num5 = 15;
										goto IL_085c;
									case 20:
										value = user;
										num5 = 26;
										goto IL_085c;
									case 22:
									case 23:
										{
											Husa5g2B9gaZTlPsv2c(WorkflowLog, FormatLogMessage(LmTIdk7U5XPU3WjX2Q5(0x101D10F ^ 0x100CEDD), instance, start));
											num4 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
											{
												num4 = 1;
											}
											continue;
										}
										IL_085c:
										num4 = num5;
										continue;
									}
									break;
								}
								goto IL_0a3a;
								IL_0a3a:
								instance.StartDate = jNeakG7IlQBSqApJdZa();
								num4 = 5;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
								{
									num4 = 16;
								}
								goto IL_0860;
							}
							finally
							{
								int num6;
								if (!flag)
								{
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
									{
										num6 = 0;
									}
									goto IL_0c0f;
								}
								goto IL_0c25;
								IL_0c25:
								nusmnH2cCag8tVusGxi(AuthenticationService);
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
								{
									num6 = 1;
								}
								goto IL_0c0f;
								IL_0c0f:
								switch (num6)
								{
								default:
									goto end_IL_0bea;
								case 2:
									break;
								case 0:
									goto end_IL_0bea;
								case 1:
									goto end_IL_0bea;
								}
								goto IL_0c25;
								end_IL_0bea:;
							}
						}
					}
				}
				finally
				{
					if (workflowExecutingContext != null)
					{
						int num11 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								J37RX22YqCn0gbVjcY3(workflowExecutingContext);
								num11 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
								{
									num11 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				TsrDr77ouWX321Pke5V(LcY07l72bJiuO0JbQx1(instance), LmTIdk7U5XPU3WjX2Q5(0x1145BED7 ^ 0x11451AED));
				num2 = 9;
				break;
			case 10:
				if (ExternalWorkflowRuntimeService.TryRun(instance, InitiatorSwimlaneUser, IsEmulation))
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void Terminate(IWorkflowInstance instance, string reason)
	{
		//Discarded unreachable code: IL_006f, IL_00ee, IL_011e, IL_012d, IL_0139, IL_017d, IL_01e5
		int num = 6;
		int num2 = num;
		IWorkflowExecutingContext workflowExecutingContext = default(IWorkflowExecutingContext);
		DateTime start = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 5:
				TsrDr77ouWX321Pke5V(LcY07l72bJiuO0JbQx1(instance), LmTIdk7U5XPU3WjX2Q5(0x51EF0063 ^ 0x51EFA459));
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 3;
				}
				continue;
			case 4:
				DyArbc2Pc8JaG3Uc0Db(Session);
				num2 = 9;
				continue;
			case 2:
				return;
			case 6:
				TsrDr77ouWX321Pke5V(instance, LmTIdk7U5XPU3WjX2Q5(-947937941 ^ -947927955));
				num2 = 5;
				continue;
			case 8:
				workflowExecutingContext = (IWorkflowExecutingContext)FtyaFR7axpuvpQl36DE(this, instance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				if (!Neh8qY2XIVIIZHnhWZ3(ExternalWorkflowRuntimeService, instance, reason))
				{
					num2 = 3;
					continue;
				}
				return;
			case 10:
				EAg3SP7FcSTiBsbXJEe(instance);
				num2 = 4;
				continue;
			case 7:
				return;
			case 1:
			case 3:
				start = jNeakG7IlQBSqApJdZa();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 8;
				}
				continue;
			case 11:
				if (ExternalWorkflowRuntimeService == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 10;
			}
			try
			{
				WagMRc2daJOyFXFFZqO(workflowExecutingContext, reason);
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					Husa5g2B9gaZTlPsv2c(WorkflowLog, FormatLogMessage(LmTIdk7U5XPU3WjX2Q5(0x5F800F5B ^ 0x5F8110AB), instance, start));
					num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				int num4;
				if (workflowExecutingContext == null)
				{
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num4 = 1;
					}
					goto IL_00f2;
				}
				goto IL_0108;
				IL_0108:
				J37RX22YqCn0gbVjcY3(workflowExecutingContext);
				num4 = 2;
				goto IL_00f2;
				IL_00f2:
				switch (num4)
				{
				case 1:
					goto end_IL_00cd;
				case 2:
					goto end_IL_00cd;
				}
				goto IL_0108;
				end_IL_00cd:;
			}
		}
	}

	public void Execute(IWorkflowExecuteData data)
	{
		//Discarded unreachable code: IL_0117, IL_014f, IL_016e, IL_019e, IL_01ad, IL_0276, IL_02a3, IL_02dd, IL_02ec, IL_0324, IL_0333
		int num = 11;
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		IWorkflowExecuteDataHandler workflowExecuteDataHandler = default(IWorkflowExecuteDataHandler);
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = default(_003C_003Ec__DisplayClass49_0);
		ActivityExecutionContextHelper.IItemSetter itemSetter = default(ActivityExecutionContextHelper.IItemSetter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 14:
					if (dictionary == null)
					{
						num2 = 5;
						continue;
					}
					goto case 16;
				case 17:
					workflowExecuteDataHandler = WorkflowExecuteDataHandlers.FirstOrDefault(_003C_003Ec__DisplayClass49_._003CExecute_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 8;
					}
					continue;
				case 15:
					if (!ExternalWorkflowRuntimeService.TryExecute((IWorkflowBookmark)x5xRVh2DuVrBwjY8Vou(_003C_003Ec__DisplayClass49_.data), workflowExecuteDataHandler.TypeName, dictionary))
					{
						num2 = 2;
						continue;
					}
					return;
				case 4:
					try
					{
						Execute((IWorkflowInstance)MVCWHJ2naQcC9TR4Yco(x5xRVh2DuVrBwjY8Vou(_003C_003Ec__DisplayClass49_.data)), _003C_003Ec__DisplayClass49_._003CExecute_003Eb__1);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num4;
						if (itemSetter == null)
						{
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
							{
								num4 = 1;
							}
							goto IL_0153;
						}
						goto IL_017c;
						IL_017c:
						J37RX22YqCn0gbVjcY3(itemSetter);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num4 = 0;
						}
						goto IL_0153;
						IL_0153:
						switch (num4)
						{
						default:
							goto end_IL_012e;
						case 1:
							goto end_IL_012e;
						case 2:
							break;
						case 0:
							goto end_IL_012e;
						}
						goto IL_017c;
						end_IL_012e:;
					}
				case 7:
					return;
				case 2:
				case 5:
				case 13:
					itemSetter = ActivityExecutionContextHelper.SetBookmark(_003C_003Ec__DisplayClass49_.data.Bookmark);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass49_._003C_003E4__this = this;
					num2 = 12;
					continue;
				case 10:
					_003C_003Ec__DisplayClass49_.data = data;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					if (ExternalWorkflowRuntimeService == null)
					{
						num2 = 13;
						continue;
					}
					goto case 17;
				case 8:
					if (workflowExecuteDataHandler == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
						{
							num2 = 8;
						}
						continue;
					}
					obj = workflowExecuteDataHandler.ConvertData(_003C_003Ec__DisplayClass49_.data);
					break;
				case 6:
					goto end_IL_0012;
				case 9:
					obj = null;
					break;
				case 1:
					EAg3SP7FcSTiBsbXJEe(((IWorkflowBookmark)x5xRVh2DuVrBwjY8Vou(_003C_003Ec__DisplayClass49_.data)).Instance);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 6;
					}
					continue;
				case 16:
					if (pTWkUE2um050bs0E1dD(dictionary) > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 3:
					return;
				}
				dictionary = (Dictionary<string, string>)obj;
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			DyArbc2Pc8JaG3Uc0Db(Session);
			num = 15;
		}
	}

	protected internal void Execute(IWorkflowInstance instance, Action action)
	{
		//Discarded unreachable code: IL_009d, IL_01f5, IL_0204, IL_030b, IL_031a, IL_032a, IL_0339, IL_0410, IL_0423
		int num = 13;
		int num2 = num;
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = default(_003C_003Ec__DisplayClass50_0);
		WorkflowTaskSettings settings = default(WorkflowTaskSettings);
		bool flag = default(bool);
		while (true)
		{
			int num6;
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass50_.notificationManager = Locator.GetService<INotificationManager>();
				num2 = 20;
				continue;
			case 18:
				num2 = 4;
				continue;
			default:
				num6 = (UHE1D92LSFIwhfeZn66(settings) ? 1 : 0);
				break;
			case 19:
				return;
			case 12:
				_003C_003Ec__DisplayClass50_._003C_003E4__this = this;
				num2 = 7;
				continue;
			case 5:
				if (_003C_003Ec__DisplayClass50_.notificationManager != null)
				{
					num2 = 8;
					continue;
				}
				goto case 18;
			case 17:
				_003C_003Ec__DisplayClass50_.currentUser = (EleWise.ELMA.Security.Models.IUser)AuthenticationService.GetCurrentUser();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass50_.responsible = (EleWise.ELMA.Security.Models.IUser)JKc4P92H4AXLLei29oY(instance);
				num2 = 10;
				continue;
			case 16:
				_003C_003Ec__DisplayClass50_.addedToForceSendCurrentUser = _003C_003Ec__DisplayClass50_.notificationManager.AddUserToForceSendList(_003C_003Ec__DisplayClass50_.currentUser);
				num2 = 18;
				continue;
			case 6:
				_003C_003Ec__DisplayClass50_.addedToForceSendCurrentUser = false;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 2;
				}
				continue;
			case 11:
				_003C_003Ec__DisplayClass50_.addedToForceSendResponsible = d2caFO2f85BPwFL913v(_003C_003Ec__DisplayClass50_.notificationManager, _003C_003Ec__DisplayClass50_.responsible);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				continue;
			case 15:
				if (settings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				num6 = 1;
				break;
			case 8:
				if (_003C_003Ec__DisplayClass50_.responsible == null)
				{
					num2 = 9;
					continue;
				}
				goto case 11;
			case 10:
				settings = Locator.GetServiceNotNull<WorkflowTaskSettingsModule>().Settings;
				num2 = 15;
				continue;
			case 1:
			case 9:
				if (_003C_003Ec__DisplayClass50_.currentUser != null)
				{
					num2 = 16;
					continue;
				}
				goto case 18;
			case 13:
				_003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 2;
				}
				continue;
			case 14:
				WorkflowMetadataLoaderService.CheckOrLoadMetadata(instance.Process);
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 10;
				}
				continue;
			case 7:
				_003C_003Ec__DisplayClass50_.action = action;
				num2 = 14;
				continue;
			case 4:
				try
				{
					int num3;
					if (!flag)
					{
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
						{
							num3 = 6;
						}
						goto IL_0293;
					}
					goto IL_03c0;
					IL_03c0:
					if (_003C_003Ec__DisplayClass50_.responsible == null)
					{
						int num4 = 5;
						num3 = num4;
					}
					else if (WOFHgJ293DASMxWKiif(_003C_003Ec__DisplayClass50_.responsible) == UserStatus.Blocked)
					{
						num3 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num3 = 3;
						}
					}
					else
					{
						SecurityService.RunByUser(_003C_003Ec__DisplayClass50_.responsible, _003C_003Ec__DisplayClass50_._003CExecute_003Eb__0);
						num3 = 4;
					}
					goto IL_0293;
					IL_0293:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 4:
							return;
						case 5:
							throw new InvalidOperationException(SR.T((string)LmTIdk7U5XPU3WjX2Q5(-539998957 ^ -539925243)));
						case 3:
							throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246FCFEA)));
						case 2:
						case 6:
							SecurityService.RunWithElevatedPrivilegies(_003C_003Ec__DisplayClass50_._003CExecute_003Eb__1);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					goto IL_03c0;
				}
				finally
				{
					Locator.GetServiceNotNull<IUnitOfWorkManager>().RegisterPostCommitAction(_003C_003Ec__DisplayClass50_._003CExecute_003Eb__2);
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 20:
				_003C_003Ec__DisplayClass50_.addedToForceSendResponsible = false;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
				{
					num2 = 6;
				}
				continue;
			}
			flag = (byte)num6 != 0;
			num2 = 5;
		}
	}

	protected internal void ExecuteQueueItem(IWorkflowQueueItem queueItem)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = default(_003C_003Ec__DisplayClass53_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				_003C_003Ec__DisplayClass53_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Ec__DisplayClass53_.queueItem = queueItem;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				Execute(_003C_003Ec__DisplayClass53_.queueItem.Instance, _003C_003Ec__DisplayClass53_._003CExecuteQueueItem_003Eb__0);
				num2 = 3;
				break;
			}
		}
	}

	[Transaction]
	protected virtual void ExecuteInternal(IWorkflowExecuteData data)
	{
		//Discarded unreachable code: IL_00bf, IL_0130, IL_01b7, IL_02d8, IL_0380, IL_03dd, IL_0415, IL_0424
		int num = 8;
		int num2 = num;
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = default(_003C_003Ec__DisplayClass54_0);
		IWorkflowExecutingContext workflowExecutingContext = default(IWorkflowExecutingContext);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IBPMNActivity iBPMNActivity = default(IBPMNActivity);
		EleWise.ELMA.Security.Models.IUser[] array = default(EleWise.ELMA.Security.Models.IUser[]);
		WorkflowActivity workflowActivity = default(WorkflowActivity);
		DateTime now = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass54_.bookmark = (IWorkflowBookmark)x5xRVh2DuVrBwjY8Vou(data);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				TsrDr77ouWX321Pke5V(data, LmTIdk7U5XPU3WjX2Q5(-539998957 ^ -539953875));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				workflowExecutingContext = (IWorkflowExecutingContext)FtyaFR7axpuvpQl36DE(this, workflowInstance);
				num2 = 2;
				break;
			case 2:
				try
				{
					bool flag = false;
					int num3 = 6;
					while (true)
					{
						switch (num3)
						{
						case 6:
							if (shphNX2JYZMmUpkjmXN(AuthenticationService) == null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
								{
									num3 = 3;
								}
								break;
							}
							goto default;
						case 8:
							if (iBPMNActivity == null)
							{
								num3 = 7;
								break;
							}
							array = (EleWise.ELMA.Security.Models.IUser[])QpMxt32qxaougM9goLH(iBPMNActivity, workflowInstance);
							num3 = 5;
							break;
						case 2:
							if (array.Any())
							{
								num3 = 4;
								break;
							}
							goto case 1;
						case 3:
							workflowActivity = ((BPMNRootActivity)((WorkflowInstance)QqmiMb2jAIEcF4rYnOZ(workflowExecutingContext)).WorkflowDefinition).Activities.First(_003C_003Ec__DisplayClass54_._003CExecuteInternal_003Eb__0);
							num3 = 12;
							break;
						case 11:
							flag = true;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
							{
								num3 = 0;
							}
							break;
						case 7:
							throw new InvalidOperationException(SR.T((string)LmTIdk7U5XPU3WjX2Q5(0x56A753C9 ^ 0x56A6733D), JudapG26SETwTE5FERm(pajcvk2RJaFyhuwyZPc(typeof(IBPMNActivity).TypeHandle))));
						case 12:
							iBPMNActivity = workflowActivity as IBPMNActivity;
							num3 = 8;
							break;
						default:
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
							{
								num3 = 10;
							}
							break;
						case 1:
						case 9:
							throw new InvalidOperationException(SR.T((string)LmTIdk7U5XPU3WjX2Q5(-1574607501 ^ -1574681363), DTmsCa232ZH3oTZ9e14(workflowActivity)));
						case 4:
							CMwr9Y20gqGLWwY9bJF(AuthenticationService, array.First());
							num3 = 11;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
							{
								num3 = 8;
							}
							break;
						case 5:
							if (array == null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 2;
						case 10:
							try
							{
								workflowExecutingContext.ResumeBookmark(eMTr5i2TOCBdMfvRTA2(_003C_003Ec__DisplayClass54_.bookmark), data);
								int num4 = 2;
								while (true)
								{
									switch (num4)
									{
									case 2:
										DyArbc2Pc8JaG3Uc0Db(Session);
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
										{
											num4 = 0;
										}
										break;
									default:
										WorkflowLog.Debug(FormatLogMessage(LmTIdk7U5XPU3WjX2Q5(-1028861977 ^ -1028788815), workflowInstance, now, data.ToString()));
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
										{
											num4 = 0;
										}
										break;
									case 1:
										return;
									}
								}
							}
							finally
							{
								if (flag)
								{
									int num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											AuthenticationService.SignOut();
											num5 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						}
					}
				}
				finally
				{
					if (workflowExecutingContext != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								J37RX22YqCn0gbVjcY3(workflowExecutingContext);
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 1:
				workflowInstance = (IWorkflowInstance)MVCWHJ2naQcC9TR4Yco(_003C_003Ec__DisplayClass54_.bookmark);
				num2 = 4;
				break;
			default:
				TsrDr77ouWX321Pke5V(data.Bookmark, LmTIdk7U5XPU3WjX2Q5(-683713632 ^ -683771018));
				num2 = 5;
				break;
			case 8:
				_003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				now = DateTime.Now;
				num2 = 6;
				break;
			case 3:
				return;
			}
		}
	}

	[Transaction]
	protected internal virtual void ExecuteQueueItemInternal(IWorkflowQueueItem queueItem)
	{
		//Discarded unreachable code: IL_015b, IL_017b, IL_0247, IL_029a, IL_02a9, IL_03c1, IL_0467, IL_0486, IL_0495, IL_04e7, IL_0540, IL_0580, IL_058b, IL_059a
		int num = 3;
		DateTime start = default(DateTime);
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = default(_003C_003Ec__DisplayClass55_0);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowExecutingContext workflowExecutingContext = default(IWorkflowExecutingContext);
		IBPMNActivity iBPMNActivity = default(IBPMNActivity);
		WorkflowActivity workflowActivity = default(WorkflowActivity);
		EleWise.ELMA.Security.Models.IUser[] array = default(EleWise.ELMA.Security.Models.IUser[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					start = jNeakG7IlQBSqApJdZa();
					num2 = 9;
					continue;
				case 0:
					return;
				case 8:
					TsrDr77ouWX321Pke5V(_003C_003Ec__DisplayClass55_.queueItem, LmTIdk7U5XPU3WjX2Q5(-790221436 ^ -790177178));
					num2 = 5;
					continue;
				case 4:
					G6Rf7a2Mi48hiTwy6W9(dVeOVJ2CYJ5sAip1yn4(), LmTIdk7U5XPU3WjX2Q5(0x361628FF ^ 0x36170A6F), new object[1] { workflowInstance.Id });
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					TsrDr77ouWX321Pke5V(HHY0Vi2QgNP0VbGyraj(_003C_003Ec__DisplayClass55_.queueItem), LmTIdk7U5XPU3WjX2Q5(-1542190822 ^ -1542116494));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					workflowExecutingContext = (IWorkflowExecutingContext)FtyaFR7axpuvpQl36DE(this, workflowInstance);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 9;
					}
					continue;
				case 10:
					try
					{
						ActivityExecutionContextHelper.IItemSetter itemSetter = (ActivityExecutionContextHelper.IItemSetter)cWPEGf2kiAYxr4vUpSa(_003C_003Ec__DisplayClass55_.queueItem);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								bool flag = false;
								int num4 = 11;
								while (true)
								{
									switch (num4)
									{
									case 10:
										throw new InvalidOperationException((string)teYC482sMquBE4th2EH(LmTIdk7U5XPU3WjX2Q5(-763667953 ^ -763725061), new object[1] { JudapG26SETwTE5FERm(pajcvk2RJaFyhuwyZPc(typeof(IBPMNActivity).TypeHandle)) }));
									case 11:
										if (shphNX2JYZMmUpkjmXN(AuthenticationService) == null)
										{
											num4 = 8;
											break;
										}
										goto case 12;
									case 9:
										iBPMNActivity = workflowActivity as IBPMNActivity;
										num4 = 4;
										break;
									case 8:
										workflowActivity = ((BPMNRootActivity)viieJ92UrjSBtud6Y8j(QqmiMb2jAIEcF4rYnOZ(workflowExecutingContext))).Activities.First(_003C_003Ec__DisplayClass55_._003CExecuteQueueItemInternal_003Eb__0);
										num4 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
										{
											num4 = 9;
										}
										break;
									default:
										flag = true;
										num4 = 12;
										break;
									case 12:
										num4 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
										{
											num4 = 0;
										}
										break;
									case 4:
										if (iBPMNActivity != null)
										{
											array = (EleWise.ELMA.Security.Models.IUser[])QpMxt32qxaougM9goLH(iBPMNActivity, workflowInstance);
											num4 = 4;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
											{
												num4 = 5;
											}
										}
										else
										{
											num4 = 10;
										}
										break;
									case 1:
										if (array.Any())
										{
											num4 = 6;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
											{
												num4 = 0;
											}
											break;
										}
										goto case 3;
									case 3:
									case 7:
										throw new InvalidOperationException((string)teYC482sMquBE4th2EH(LmTIdk7U5XPU3WjX2Q5(-1001967776 ^ -1002041602), new object[1] { DTmsCa232ZH3oTZ9e14(workflowActivity) }));
									case 6:
										CMwr9Y20gqGLWwY9bJF(AuthenticationService, array.First());
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
										{
											num4 = 0;
										}
										break;
									case 5:
										if (array == null)
										{
											num4 = 7;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
											{
												num4 = 4;
											}
											break;
										}
										goto case 1;
									case 2:
										try
										{
											KB4UbW2Arw2aPo2Q4GZ(workflowExecutingContext, DQkMTC2V9bkZ4o09iP1(_003C_003Ec__DisplayClass55_.queueItem), _003C_003Ec__DisplayClass55_.queueItem);
											int num5 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
											{
												num5 = 0;
											}
											while (true)
											{
												switch (num5)
												{
												case 1:
													return;
												}
												WorkflowLog.Debug(FormatLogMessage(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122818443), workflowInstance, start, (string)mmsOnj2GM6nYeclcCon(LmTIdk7U5XPU3WjX2Q5(0x2269BD32 ^ 0x22690BAC), _003C_003Ec__DisplayClass55_.queueItem.Id)));
												num5 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
												{
													num5 = 0;
												}
											}
										}
										finally
										{
											int num6;
											if (!flag)
											{
												num6 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
												{
													num6 = 0;
												}
												goto IL_046b;
											}
											goto IL_04a0;
											IL_04a0:
											AuthenticationService.SignOut();
											num6 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
											{
												num6 = 1;
											}
											goto IL_046b;
											IL_046b:
											switch (num6)
											{
											default:
												goto end_IL_0446;
											case 0:
												goto end_IL_0446;
											case 2:
												break;
											case 1:
												goto end_IL_0446;
											}
											goto IL_04a0;
											end_IL_0446:;
										}
									}
								}
							}
							finally
							{
								if (itemSetter != null)
								{
									int num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										default:
											itemSetter.Dispose();
											num7 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
											{
												num7 = 0;
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
						int num8;
						if (workflowExecutingContext == null)
						{
							num8 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
							{
								num8 = 1;
							}
							goto IL_0544;
						}
						goto IL_055a;
						IL_055a:
						workflowExecutingContext.Dispose();
						num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num8 = 0;
						}
						goto IL_0544;
						IL_0544:
						switch (num8)
						{
						default:
							goto end_IL_051f;
						case 2:
							break;
						case 1:
							goto end_IL_051f;
						case 0:
							goto end_IL_051f;
						}
						goto IL_055a;
						end_IL_051f:;
					}
				case 11:
					if (Ko36Jy2pjEgmbiEEeDK(workflowInstance) != WorkflowInstanceStatus.Running)
					{
						num2 = 4;
						continue;
					}
					sJ9Xii7iUmoaAnxWFpV(WorkflowMetadataLoaderService, LcY07l72bJiuO0JbQx1(workflowInstance));
					num2 = 6;
					continue;
				case 9:
					workflowInstance = (IWorkflowInstance)HHY0Vi2QgNP0VbGyraj(_003C_003Ec__DisplayClass55_.queueItem);
					num = 11;
					break;
				case 2:
					_003C_003Ec__DisplayClass55_.queueItem = queueItem;
					num = 8;
					break;
				case 1:
					return;
				case 3:
					_003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private static string FormatLogMessage(object name, object instance, DateTime start, string message = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				TsrDr77ouWX321Pke5V(instance, LmTIdk7U5XPU3WjX2Q5(0x6F6D7B44 ^ 0x6F6D2242));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)Tog7cF2oTUNvlaCbLeL(new object[9]
				{
					name,
					LmTIdk7U5XPU3WjX2Q5(0x4FD00585 ^ 0x4FD126D7),
					SR.T(((IWorkflowProcess)LcY07l72bJiuO0JbQx1(instance)).Name),
					LmTIdk7U5XPU3WjX2Q5(-865213812 ^ -865228282),
					JA3LXW7eSl6EfXgZQUv(instance),
					LmTIdk7U5XPU3WjX2Q5(-947937941 ^ -947995085),
					(!string.IsNullOrEmpty(message)) ? u1FQ1b27PNL8lUu9MSG(message, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148438571)) : "",
					(int)WhVJUG22UR2ufn2nXNQ(jNeakG7IlQBSqApJdZa(), start).TotalMilliseconds,
					LmTIdk7U5XPU3WjX2Q5(0x614CF569 ^ 0x614DD607)
				});
			}
		}
	}

	public WorkflowRuntimeService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowRuntimeService()
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
			case 1:
				WorkflowLog = Logger.GetLogger((string)LmTIdk7U5XPU3WjX2Q5(0x6871CA ^ 0x6952B2));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AFy81K2FSqmi4AnbHrW();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool WMXCt87MOqdTpcw7caM()
	{
		return suYeFM7Cl7ghrAXqAYF == null;
	}

	internal static WorkflowRuntimeService tgXf1U7kSx2bYAEgS23()
	{
		return suYeFM7Cl7ghrAXqAYF;
	}

	internal static object LmTIdk7U5XPU3WjX2Q5(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WBdQgO7VrC1r8nGio4y(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object MRWD9g7A1M0wO7XV3Bl(object P_0, object P_1, object P_2, object P_3)
	{
		return WorkflowExecutingContext.Create((WorkflowRuntimeService)P_0, (IWorkflowInstance)P_1, (IContextBoundVariableService)P_2, (IBackgroundOperationService)P_3);
	}

	internal static void YUgYcP7Gu979wCWUKbD(object P_0, object P_1, bool InitiatorSwimlaneUser)
	{
		((WorkflowRuntimeService)P_0).Run((IWorkflowInstance)P_1, InitiatorSwimlaneUser);
	}

	internal static void Glw2XL77SrE27lV36Sr(object P_0, object P_1, bool InitiatorSwimlaneUser, bool IsEmulation)
	{
		((WorkflowRuntimeService)P_0).Run((IWorkflowInstance)P_1, InitiatorSwimlaneUser, IsEmulation);
	}

	internal static object LcY07l72bJiuO0JbQx1(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static void TsrDr77ouWX321Pke5V(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void EAg3SP7FcSTiBsbXJEe(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void sJ9Xii7iUmoaAnxWFpV(object P_0, object P_1)
	{
		((IWorkflowMetadataLoaderService)P_0).CheckOrLoadMetadata((IWorkflowProcess)P_1);
	}

	internal static DateTime jNeakG7IlQBSqApJdZa()
	{
		return DateTime.Now;
	}

	internal static object FtyaFR7axpuvpQl36DE(object P_0, object P_1)
	{
		return ((WorkflowRuntimeService)P_0).CreateExecutingContext((IWorkflowInstance)P_1);
	}

	internal static void DWlWVR7r6cSrJBXQ6af(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Initiator = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object JA3LXW7eSl6EfXgZQUv(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static InstanceNamingScheme.SchemeType n7U0Tm7N653aAu7MPRl(object P_0)
	{
		return ((InstanceNamingScheme)P_0).Type;
	}

	internal static Guid KY15dv7xLRqdYxUndJ0(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool YEhjRL7SYhAAIBKaV8i(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object vEwYmg71YLEatiEdS3L(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static Guid HcKftD7hIr5yh9n1hcs(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void yTj8SJ7EoNmPXSDG826(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static object dF5NkT7wARidCemFruB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JyAj9k74QXobs6MRsMW(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object m8kbcD7zLFrCYOIWTm7(object P_0, object P_1)
	{
		return ((BPMNFlowElement)P_0).GetSwimlane((Diagram)P_1);
	}

	internal static long hCk1SA2K3YUiD3FEVCo(object P_0)
	{
		return ((SwimlaneElement)P_0).DepartmentId;
	}

	internal static object E0t0Ak2OYoc9V2MpTdY(object P_0)
	{
		return ((IOrganizationItem)P_0).User;
	}

	internal static void l0OFI02ZNMvdE86Z9BB(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
	}

	internal static bool sGnY3B2vm7It1NhiWt4(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void J37RX22YqCn0gbVjcY3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object L0KMiQ28tcwnahfmycR(object P_0)
	{
		return ((IOrganizationItem)P_0).Name;
	}

	internal static object teYC482sMquBE4th2EH(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object shphNX2JYZMmUpkjmXN(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object XjZDKb2lXBI6a9A3Oaa(object P_0)
	{
		return ((IWorkflowInstance)P_0).Initiator;
	}

	internal static void CMwr9Y20gqGLWwY9bJF(object P_0, object P_1)
	{
		((IAuthenticationService)P_0).SetAuthenticatedUserForRequest((EleWise.ELMA.Security.IUser)P_1);
	}

	internal static object DK0DvO2yRWcs8tgJL6q(object P_0)
	{
		return ((IWorkflowInstance)P_0).ParentInstance;
	}

	internal static Guid mJmLmy2m8ZaThWd9QjY(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static Guid HtDQgA2tc4SsCyQf4dD(object P_0)
	{
		return ((SwimlaneElement)P_0).ExecuterProperty;
	}

	internal static bool J4ZPKu2bIgXJkUWJvgN(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object kd6rD225KYcGH3Rllrq(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static void jnsOes2gDdAs5RRagDa(object P_0)
	{
		((IWorkflowExecutingContext)P_0).Run();
	}

	internal static void Husa5g2B9gaZTlPsv2c(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void nusmnH2cCag8tVusGxi(object P_0)
	{
		((IAuthenticationService)P_0).SignOut();
	}

	internal static void DyArbc2Pc8JaG3Uc0Db(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static bool Neh8qY2XIVIIZHnhWZ3(object P_0, object P_1, object P_2)
	{
		return ((IExternalWorkflowRuntimeService)P_0).TryTerminate((IWorkflowInstance)P_1, (string)P_2);
	}

	internal static void WagMRc2daJOyFXFFZqO(object P_0, object P_1)
	{
		((IWorkflowExecutingContext)P_0).Terminate((string)P_1);
	}

	internal static int pTWkUE2um050bs0E1dD(object P_0)
	{
		return ((Dictionary<string, string>)P_0).Count;
	}

	internal static object x5xRVh2DuVrBwjY8Vou(object P_0)
	{
		return ((IWorkflowExecuteData)P_0).Bookmark;
	}

	internal static object MVCWHJ2naQcC9TR4Yco(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object JKc4P92H4AXLLei29oY(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}

	internal static bool UHE1D92LSFIwhfeZn66(object P_0)
	{
		return ((WorkflowTaskSettings)P_0).ExecuteByResponsible;
	}

	internal static bool d2caFO2f85BPwFL913v(object P_0, object P_1)
	{
		return ((INotificationManager)P_0).AddUserToForceSendList((EleWise.ELMA.Security.IUser)P_1);
	}

	internal static UserStatus WOFHgJ293DASMxWKiif(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static object I6AY2H2WvZBWIvQlp5F(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object QqmiMb2jAIEcF4rYnOZ(object P_0)
	{
		return ((IWorkflowExecutingContext)P_0).Application;
	}

	internal static Type pajcvk2RJaFyhuwyZPc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object JudapG26SETwTE5FERm(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object QpMxt32qxaougM9goLH(object P_0, object P_1)
	{
		return ((IBPMNActivity)P_0).GetSwimlaneExecutors((IWorkflowInstance)P_1);
	}

	internal static object DTmsCa232ZH3oTZ9e14(object P_0)
	{
		return ((Activity)P_0).DisplayName;
	}

	internal static Guid eMTr5i2TOCBdMfvRTA2(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static object HHY0Vi2QgNP0VbGyraj(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Instance;
	}

	internal static WorkflowInstanceStatus Ko36Jy2pjEgmbiEEeDK(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object dVeOVJ2CYJ5sAip1yn4()
	{
		return Logger.Log;
	}

	internal static void G6Rf7a2Mi48hiTwy6W9(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).WarnFormat((string)P_1, (object[])P_2);
	}

	internal static object cWPEGf2kiAYxr4vUpSa(object P_0)
	{
		return ActivityExecutionContextHelper.SetQueueItem((IWorkflowQueueItem)P_0);
	}

	internal static object viieJ92UrjSBtud6Y8j(object P_0)
	{
		return ((WorkflowInstance)P_0).WorkflowDefinition;
	}

	internal static Guid DQkMTC2V9bkZ4o09iP1(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Uid;
	}

	internal static void KB4UbW2Arw2aPo2Q4GZ(object P_0, Guid bookmarkUid, object P_2)
	{
		((IWorkflowExecutingContext)P_0).ResumeBookmark(bookmarkUid, P_2);
	}

	internal static object mmsOnj2GM6nYeclcCon(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object u1FQ1b27PNL8lUu9MSG(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static TimeSpan WhVJUG22UR2ufn2nXNQ(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object Tog7cF2oTUNvlaCbLeL(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static void AFy81K2FSqmi4AnbHrW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
