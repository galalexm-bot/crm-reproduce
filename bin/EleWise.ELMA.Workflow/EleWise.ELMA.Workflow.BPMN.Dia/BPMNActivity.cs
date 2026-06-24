using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;

public abstract class BPMNActivity<TElement> : WorkflowActivity<TElement>, IBPMNActivity, IActivityWithExceptionFlowsImpl, IWorkflowActivityImpl where TElement : BPMNFlowElement
{
	private static object dBMmMiZgKWpECBg8mOBM;

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
				case 0:
					return;
				case 1:
					_003CWorkflowScriptingService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	IElementWithExceptionFlows IActivityWithExceptionFlowsImpl.Element => base.Element;

	public EleWise.ELMA.Security.Models.IUser[] GetSwimlaneExecutors(IWorkflowInstance instance)
	{
		bool assignedToResponsible;
		return GetSwimlaneExecutors(instance, out assignedToResponsible);
	}

	public virtual EleWise.ELMA.Security.Models.IUser[] GetSwimlaneExecutors(IWorkflowInstance instance, out bool assignedToResponsible)
	{
		bool isLimitExceeded;
		return GetSwimlaneExecutors(instance, out assignedToResponsible, out isLimitExceeded);
	}

	public virtual EleWise.ELMA.Security.Models.IUser[] GetSwimlaneExecutors(IWorkflowInstance instance, out bool assignedToResponsible, out bool isLimitExceeded)
	{
		//Discarded unreachable code: IL_00db, IL_00ea, IL_023a, IL_026d, IL_02be, IL_0306, IL_0328, IL_0381
		int num = 23;
		List<EleWise.ELMA.Security.Models.IUser> list = default(List<EleWise.ELMA.Security.Models.IUser>);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		EleWise.ELMA.Security.Models.IUser user3 = default(EleWise.ELMA.Security.Models.IUser);
		SwimlaneElement swimlane = default(SwimlaneElement);
		while (true)
		{
			int num2 = num;
			EleWise.ELMA.Security.Models.IUser user4;
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 17:
					AddSwimlaneUserToList(list, user2);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (instance.Responsible == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						user2 = instance.Responsible;
						num2 = 7;
					}
					break;
				case 13:
					if (user3 == null)
					{
						num2 = 20;
						break;
					}
					user4 = user3;
					goto end_IL_0012;
				default:
					throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D1434), instance.InstanceName(), SR.T(instance.Process.Name), instance.Id));
				case 18:
					isLimitExceeded = false;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 9;
					}
					break;
				case 10:
					if (swimlane != null)
					{
						num2 = 14;
						break;
					}
					goto case 8;
				case 16:
					swimlane = GetSwimlane();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 10;
					}
					break;
				case 5:
					if (!((list.Count == 0) | isLimitExceeded))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
						{
							num2 = 21;
						}
						break;
					}
					goto case 3;
				case 4:
					assignedToResponsible = false;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 2;
					}
					break;
				case 9:
					list = new List<EleWise.ELMA.Security.Models.IUser>();
					num2 = 16;
					break;
				case 7:
					if (user2.Status == UserStatus.Blocked)
					{
						num2 = 12;
						break;
					}
					goto case 15;
				case 14:
					try
					{
						GetSwimlaneUsers(instance, swimlane, list);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642629203), exception);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
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
					goto case 8;
				case 8:
					isLimitExceeded = IsLimitExceeded(list);
					num2 = 5;
					break;
				case 22:
					Contract.NotNull(base.Diagram, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398670415));
					num2 = 4;
					break;
				case 20:
					user4 = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
					goto end_IL_0012;
				case 1:
				case 11:
					if (!isLimitExceeded)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 19;
				case 15:
					assignedToResponsible = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 1;
					}
					break;
				case 19:
					list.Clear();
					num2 = 17;
					break;
				case 23:
					Contract.NotNull(base.Element, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614DABE3));
					num2 = 22;
					break;
				case 12:
					user3 = UserManager.Instance.GetChiefByUser(user2).LastOrDefault((EleWise.ELMA.Security.Models.IUser a) => a.Status != UserStatus.Blocked);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				case 21:
					return list.OrderBy((EleWise.ELMA.Security.Models.IUser user) => user.Replacement != null).ToArray();
				}
				continue;
				end_IL_0012:
				break;
			}
			user2 = user4;
			num = 11;
		}
	}

	protected virtual SwimlaneElement GetSwimlane()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return base.Element.GetSwimlane(base.Diagram);
			case 1:
				Contract.NotNull(base.Element, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105777464));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Contract.NotNull(base.Diagram, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135694348));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual EleWise.ELMA.Security.Models.IUser[] GetSwimlaneExecutors(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 1:
				instance = GetInstance(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetSwimlaneExecutors(instance);
			}
		}
	}

	protected EleWise.ELMA.Security.Models.IUser[] GetSwimlaneExecutors(NativeActivityContext context, out bool assignedToResponsible)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 1:
				instance = GetInstance(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetSwimlaneExecutors(instance, out assignedToResponsible);
			}
		}
	}

	protected EleWise.ELMA.Security.Models.IUser[] GetSwimlaneExecutors(NativeActivityContext context, out bool assignedToResponsible, out bool isLimitExceeded)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 1:
				instance = GetInstance(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetSwimlaneExecutors(instance, out assignedToResponsible, out isLimitExceeded);
			}
		}
	}

	protected virtual IWorkflowBookmark CreateBookmark(IWorkflowInstance instance)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				IWorkflowBookmark workflowBookmark = InterfaceActivator.Create<IWorkflowBookmark>();
				workflowBookmark.Uid = Guid.NewGuid();
				workflowBookmark.Instance = instance;
				workflowBookmark.ElementUid = base.Element.Uid;
				workflowBookmark.Save();
				return workflowBookmark;
			}
			case 1:
				Contract.NotNull(base.Element, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430566039));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483FFB74));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void TrackConnector(NativeActivityContext context, Connector connector)
	{
		//Discarded unreachable code: IL_018f, IL_019e, IL_0249, IL_0341, IL_0350, IL_035b, IL_03f8, IL_0417, IL_0426, IL_0453, IL_04cf, IL_053b, IL_059d, IL_05ac, IL_05bc, IL_0600, IL_060f, IL_061a, IL_06b6, IL_06c9, IL_06d8, IL_07f6, IL_0805
		int num = 30;
		IWorkflowInstance instance3 = default(IWorkflowInstance);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		IWorkflowInstance instance2 = default(IWorkflowInstance);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		List<EleWise.ELMA.Security.Models.IUser> list = default(List<EleWise.ELMA.Security.Models.IUser>);
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		object propertyValue = default(object);
		IWorkflowInstance instance = default(IWorkflowInstance);
		IEnumerator<ISwimlaneChangedExecHandler> enumerator2 = default(IEnumerator<ISwimlaneChangedExecHandler>);
		BPMNFlowElement bPMNFlowElement2 = default(BPMNFlowElement);
		List<IWorkflowSwimlaneExecutor>.Enumerator enumerator = default(List<IWorkflowSwimlaneExecutor>.Enumerator);
		IWorkflowSwimlaneExecutor current = default(IWorkflowSwimlaneExecutor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					WorkflowScriptingService.ExecuteScript(instance3, _003C_003Ec__DisplayClass16_.endSwimlane.ScriptName);
					num2 = 10;
					continue;
				case 12:
					if (_003C_003Ec__DisplayClass16_.endSwimlane.SwimlaneType == SwimlaneType.DynamicScript)
					{
						num2 = 32;
						continue;
					}
					goto case 10;
				case 1:
					if (bPMNFlowElement is StartEventElement)
					{
						num2 = 41;
						continue;
					}
					return;
				case 41:
					instance2 = GetInstance(context);
					num2 = 50;
					continue;
				case 7:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 37;
					continue;
				case 5:
					base.TrackConnector(context, connector);
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 36;
					}
					continue;
				case 42:
					return;
				case 28:
					if (organizationItem == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 6;
				case 44:
					if (list.Count == 1)
					{
						num2 = 26;
						continue;
					}
					return;
				case 32:
					if (WorkflowScriptingService != null)
					{
						num2 = 2;
						continue;
					}
					goto case 10;
				case 27:
					if (swimlaneElement != _003C_003Ec__DisplayClass16_.endSwimlane)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 10;
				case 10:
					if (_003C_003Ec__DisplayClass16_.endSwimlane != null)
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num2 = 11;
						}
						continue;
					}
					return;
				case 14:
					return;
				case 43:
					if (propertyValue != null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 44;
				case 39:
					if (!(_003C_003Ec__DisplayClass16_.endSwimlane.ExecuterProperty != Guid.Empty))
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 33;
				case 40:
					if (_003C_003Ec__DisplayClass16_.endSwimlane != null)
					{
						num2 = 17;
						continue;
					}
					goto case 10;
				case 8:
					instance = GetInstance(context);
					num2 = 39;
					continue;
				case 25:
					organizationItem = OrganizationItemManager.LoadOrNull(_003C_003Ec__DisplayClass16_.endSwimlane.DepartmentId);
					num = 28;
					break;
				case 19:
					if (_003C_003Ec__DisplayClass16_.endSwimlane.ResetExecutorOnEnter)
					{
						num2 = 8;
						continue;
					}
					goto case 12;
				case 13:
					instance3 = GetInstance(context);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
								{
									num3 = 0;
								}
								goto IL_035f;
							}
							goto IL_0375;
							IL_0375:
							enumerator2.Current.Execute(instance2, swimlaneElement, _003C_003Ec__DisplayClass16_.endSwimlane, bPMNFlowElement, bPMNFlowElement2, list);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
							{
								num3 = 1;
							}
							goto IL_035f;
							IL_035f:
							switch (num3)
							{
							case 2:
								goto IL_0375;
							case 1:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator2 == null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
							{
								num4 = 0;
							}
							goto IL_03fc;
						}
						goto IL_0431;
						IL_0431:
						enumerator2.Dispose();
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
						{
							num4 = 1;
						}
						goto IL_03fc;
						IL_03fc:
						switch (num4)
						{
						default:
							goto end_IL_03d7;
						case 0:
							goto end_IL_03d7;
						case 2:
							break;
						case 1:
							goto end_IL_03d7;
						}
						goto IL_0431;
						end_IL_03d7:;
					}
					goto case 3;
				case 4:
					if (_003C_003Ec__DisplayClass16_.endSwimlane.WorkerDetectionType == WorkerDetectionType.WhoFirst)
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 12;
				case 30:
					Contract.ArgumentNotNull(context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCD1C90));
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 29;
					}
					continue;
				case 50:
					list = new List<EleWise.ELMA.Security.Models.IUser>();
					num2 = 9;
					continue;
				case 31:
					return;
				case 36:
					if (connector == null)
					{
						num2 = 42;
						continue;
					}
					goto case 7;
				case 29:
					Contract.ServiceNotNull(base.WorkflowRuntimeService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790205954));
					num2 = 5;
					continue;
				case 34:
					bPMNFlowElement2 = connector.EndElement as BPMNFlowElement;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 2;
					}
					continue;
				case 47:
					obj = null;
					goto IL_088a;
				case 11:
					if (bPMNFlowElement == null)
					{
						num2 = 47;
						continue;
					}
					obj = bPMNFlowElement.GetSwimlane(base.Diagram);
					goto IL_088a;
				case 24:
				case 46:
					if (_003C_003Ec__DisplayClass16_.endSwimlane.SwimlaneType == SwimlaneType.Dynamic)
					{
						num2 = 4;
						continue;
					}
					goto case 12;
				case 15:
					enumerator2 = ComponentManager.Current.GetExtensionPoints<ISwimlaneChangedExecHandler>().GetEnumerator();
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 20;
					}
					continue;
				case 38:
					propertyValue = instance2.Context.GetPropertyValue(_003C_003Ec__DisplayClass16_.endSwimlane.ExecuterProperty);
					num2 = 25;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 2;
					}
					continue;
				case 35:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 2;
								goto IL_061e;
							}
							goto IL_0677;
							IL_061e:
							while (true)
							{
								switch (num5)
								{
								case 3:
									((ICollection<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Remove(current);
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									goto IL_0677;
								case 2:
									goto end_IL_0638;
								}
								break;
							}
							continue;
							IL_0677:
							current = enumerator.Current;
							num5 = 3;
							goto IL_061e;
							continue;
							end_IL_0638:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 12;
				case 45:
					_ = _003C_003Ec__DisplayClass16_.endSwimlane.ExecuterProperty;
					num2 = 23;
					continue;
				case 21:
					return;
				case 49:
					return;
				case 33:
					instance.Context.SetPropertyValue(_003C_003Ec__DisplayClass16_.endSwimlane.ExecuterProperty, null);
					num2 = 18;
					continue;
				case 3:
					if (_003C_003Ec__DisplayClass16_.endSwimlane.SwimlaneType != 0)
					{
						return;
					}
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 30;
					}
					continue;
				case 6:
					if (organizationItem.ItemType != OrganizationItemType.Position)
					{
						return;
					}
					num2 = 43;
					continue;
				case 22:
					if (swimlaneElement != null)
					{
						num2 = 51;
						continue;
					}
					goto case 41;
				case 26:
					instance2.Context.SetPropertyValue(_003C_003Ec__DisplayClass16_.endSwimlane.ExecuterProperty, list.First());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 49;
					}
					continue;
				case 37:
					bPMNFlowElement = connector.StartElement as BPMNFlowElement;
					num2 = 34;
					continue;
				case 9:
					GetSwimlaneUsers(instance2, _003C_003Ec__DisplayClass16_.endSwimlane, list);
					num = 15;
					break;
				case 17:
					if (swimlaneElement == null)
					{
						num2 = 46;
						continue;
					}
					goto case 27;
				case 23:
					if (!(_003C_003Ec__DisplayClass16_.endSwimlane.ExecuterProperty != Guid.Empty))
					{
						num2 = 31;
						continue;
					}
					goto case 38;
				case 2:
					if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass16_.endSwimlane.ScriptName))
					{
						num2 = 13;
						continue;
					}
					goto case 10;
				case 51:
					if (swimlaneElement == _003C_003Ec__DisplayClass16_.endSwimlane)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 41;
				case 48:
					_003C_003Ec__DisplayClass16_.endSwimlane = bPMNFlowElement2?.GetSwimlane(base.Diagram);
					num2 = 40;
					continue;
				case 16:
				case 18:
					{
						enumerator = ((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(_003C_003Ec__DisplayClass16_._003CTrackConnector_003Eb__0).ToList().GetEnumerator();
						num = 35;
						break;
					}
					IL_088a:
					swimlaneElement = (SwimlaneElement)obj;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 48;
					}
					continue;
				}
				break;
			}
		}
	}

	protected virtual void SaveExecutor(NativeActivityContext context, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_006c
		int num = 7;
		int num2 = num;
		SwimlaneElement swimlane = default(SwimlaneElement);
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 6:
				Contract.ServiceNotNull(base.WorkflowRuntimeService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667480645));
				num2 = 4;
				break;
			case 2:
				if (swimlane != null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 7:
				Contract.ArgumentNotNull(context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F575A));
				num2 = 6;
				break;
			default:
				swimlane = GetSwimlane();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 3:
				Locator.GetServiceNotNull<WorkflowInstanceManager>().SaveSwimlaneExecutor(instance, swimlane, user);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				instance = GetInstance(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public static void SettingEmulation(ITaskBase task, IWorkflowInstance instance)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				((IWorkflowTaskBase)task).ExecutorIsEmulation = task.Executor;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (instance.IsEmulation)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 1:
				return;
			default:
				task.Executor = instance.Initiator;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				((IWorkflowTaskBase)task).IsEmulation = true;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected bool IsLimitExceeded(ICollection<EleWise.ELMA.Security.Models.IUser> users)
	{
		Contract.ArgumentNotNull(users, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C648B5D));
		int setting = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB03DD8), int.MaxValue);
		return users.Count > setting;
	}

	protected void AddSwimlaneUserToList<T>(T entity, Expression<Func<T, object>> expr, List<EleWise.ELMA.Security.Models.IUser> users, EleWise.ELMA.Security.Models.IUser user, SwimlaneElement swimlane = null) where T : IEntity
	{
		ReplacementManager.AddUserNotBlockToList(entity, expr, users, user, swimlane?.DenyReplacement ?? false);
	}

	protected void AddSwimlaneUserToList(List<EleWise.ELMA.Security.Models.IUser> users, EleWise.ELMA.Security.Models.IUser user)
	{
		if (user != null && user.Status != UserStatus.Blocked)
		{
			users.Add(user);
		}
	}

	private void GetSwimlaneUsers(IWorkflowInstance instance, SwimlaneElement swimlane, List<EleWise.ELMA.Security.Models.IUser> users)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.swimlane = swimlane;
		Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA09D2));
		Contract.ArgumentNotNull(instance.Context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x1842BE79));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.swimlane, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130072146));
		Contract.ArgumentNotNull(users, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657668903));
		Contract.ServiceNotNull(OrganizationItemManager, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -451960219));
		if ((CS_0024_003C_003E8__locals0.swimlane.SwimlaneType == SwimlaneType.Dynamic && CS_0024_003C_003E8__locals0.swimlane.WorkerDetectionType == WorkerDetectionType.UseSelector) || CS_0024_003C_003E8__locals0.swimlane.SwimlaneType == SwimlaneType.DynamicScript)
		{
			EleWise.ELMA.Security.Models.IUser propertyValue = instance.Context.GetPropertyValue<EleWise.ELMA.Security.Models.IUser>(CS_0024_003C_003E8__locals0.swimlane.ExecuterProperty);
			if (propertyValue != null)
			{
				AddSwimlaneUserToList(users, propertyValue);
			}
			if (users.Any())
			{
				return;
			}
		}
		if (!instance.IsEmulation)
		{
			IEnumerable<IWorkflowSwimlaneExecutor> enumerable = ((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(delegate(IWorkflowSwimlaneExecutor se)
			{
				//Discarded unreachable code: IL_0063, IL_0072, IL_00e2
				int num = 5;
				Guid? swimlaneUid = default(Guid?);
				Guid uid = default(Guid);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							if (swimlaneUid.HasValue)
							{
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 2;
						case 2:
							return false;
						default:
							if (swimlaneUid.HasValue)
							{
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
								{
									num2 = 6;
								}
								continue;
							}
							goto case 1;
						case 1:
							return true;
						case 6:
							return swimlaneUid.GetValueOrDefault() == uid;
						case 4:
							uid = CS_0024_003C_003E8__locals0.swimlane.Uid;
							num2 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
							{
								num2 = 3;
							}
							continue;
						case 5:
							break;
						}
						break;
					}
					swimlaneUid = se.SwimlaneUid;
					num = 4;
				}
			});
			if (enumerable.Any())
			{
				foreach (IWorkflowSwimlaneExecutor item in enumerable)
				{
					AddSwimlaneUserToList(users, item.User);
				}
			}
			if (users.Count > 0)
			{
				return;
			}
		}
		switch (CS_0024_003C_003E8__locals0.swimlane.SwimlaneType)
		{
		case SwimlaneType.Static:
		{
			IOrganizationItem organizationItem = OrganizationItemManager.LoadOrNull(CS_0024_003C_003E8__locals0.swimlane.DepartmentId);
			if (organizationItem == null)
			{
				break;
			}
			switch (organizationItem.ItemType)
			{
			case OrganizationItemType.Position:
				AddSwimlaneUserToList(users, organizationItem.User);
				break;
			case OrganizationItemType.EmployeeGroup:
				if (organizationItem.Users == null)
				{
					break;
				}
				{
					foreach (EleWise.ELMA.Security.Models.IUser item2 in ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)organizationItem.Users).Where((EleWise.ELMA.Security.Models.IUser a) => a.Status != UserStatus.Blocked))
					{
						AddSwimlaneUserToList(users, item2);
					}
					break;
				}
			}
			break;
		}
		case SwimlaneType.Dynamic:
		case SwimlaneType.DynamicScript:
		{
			if (CS_0024_003C_003E8__locals0.swimlane.ExecuterProperty == Guid.Empty)
			{
				break;
			}
			PropertyMetadata propertyMetadata = ((EntityMetadata)MetadataLoader.LoadMetadata(instance.Context.GetType())).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.swimlane.ExecuterProperty);
			if (propertyMetadata == null)
			{
				break;
			}
			if (CS_0024_003C_003E8__locals0.swimlane.SwimlaneType == SwimlaneType.DynamicScript || CS_0024_003C_003E8__locals0.swimlane.WorkerDetectionType == WorkerDetectionType.UseSelector)
			{
				EleWise.ELMA.Security.Models.IUser propertyValue2 = instance.Context.GetPropertyValue<EleWise.ELMA.Security.Models.IUser>(CS_0024_003C_003E8__locals0.swimlane.ExecuterProperty);
				AddSwimlaneUserToList(users, propertyValue2);
				break;
			}
			EntityUserSettings propertySettings = instance.Context.GetPropertySettings<EntityUserSettings>(propertyMetadata.Uid);
			if (propertySettings == null || propertySettings.Workers == null)
			{
				break;
			}
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.Workers = Worker.PrepareForFilter(propertySettings.Workers, instance.Context);
			{
				foreach (EleWise.ELMA.Security.Models.IUser item3 in Locator.GetServiceNotNull<UserManager>().Find(userFilter, null))
				{
					AddSwimlaneUserToList(users, item3);
				}
				break;
			}
		}
		}
	}

	EleWise.ELMA.Security.Models.IUser[] IActivityWithExceptionFlowsImpl.GetSwimlaneExecutors(NativeActivityContext context, out bool assignedToResponsible)
	{
		return GetSwimlaneExecutors(context, out assignedToResponsible);
	}

	protected BPMNActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jtEmywZgOI08SUDuN359()
	{
		return dBMmMiZgKWpECBg8mOBM == null;
	}

	internal static object lNOddrZgZxxjCx8T0oTM()
	{
		return dBMmMiZgKWpECBg8mOBM;
	}
}
