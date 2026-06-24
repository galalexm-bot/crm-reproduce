using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class ProcessHeaderEventListener : PostFlushEventListener
{
	internal static ProcessHeaderEventListener F4drOt0OWuu5Hpgf5U4;

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1
		int num = 5;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		IProcessHeaderAccess processHeaderAccess = default(IProcessHeaderAccess);
		while (true)
		{
			switch (num2)
			{
			case 7:
				ot1ejS081pttFgfIfm7(processHeader);
				num2 = 6;
				break;
			case 1:
			case 6:
				processHeaderAccess = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IProcessHeaderAccess;
				num2 = 3;
				break;
			case 5:
				processHeader = mFKXCV0YPPRisZqtVsm(@event) as IProcessHeader;
				num2 = 4;
				break;
			case 4:
				if (processHeader == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 2:
				return;
			case 3:
				if (processHeaderAccess == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				fSV4yJ0JQQBCHa9daTM(eC5nqa0sgydVJxkBgGF(processHeaderAccess));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00c1
		int num = 7;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		IProcessHeaderAccess processHeaderAccess = default(IProcessHeaderAccess);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (processHeader != null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			case 4:
				fSV4yJ0JQQBCHa9daTM(processHeader);
				num2 = 2;
				continue;
			case 2:
				processHeaderAccess = mFKXCV0YPPRisZqtVsm(@event) as IProcessHeaderAccess;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				processHeader = mFKXCV0YPPRisZqtVsm(@event) as IProcessHeader;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				return;
			case 3:
				if (processHeaderAccess == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 5:
				break;
			case 0:
				return;
			}
			fSV4yJ0JQQBCHa9daTM(eC5nqa0sgydVJxkBgGF(processHeaderAccess));
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
			{
				num2 = 0;
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		int num = 2;
		int num2 = num;
		IProcessHeaderAccess processHeaderAccess = default(IProcessHeaderAccess);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				processHeaderAccess = mFKXCV0YPPRisZqtVsm(@event) as IProcessHeaderAccess;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				fSV4yJ0JQQBCHa9daTM(processHeaderAccess.ProcessHeader);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (processHeaderAccess == null)
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	private static void RefreshPermissionCache(object header)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_00d6, IL_00e9, IL_0146, IL_0155
		int num = 3;
		int num2 = num;
		List<IProcessHeaderPermission>.Enumerator enumerator = default(List<IProcessHeaderPermission>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
							{
								num3 = 1;
							}
							goto IL_0058;
						}
						goto IL_0094;
						IL_0094:
						sXc8PO0le3hTd9Ngjib(enumerator.Current);
						num3 = 2;
						goto IL_0058;
						IL_0058:
						switch (num3)
						{
						case 2:
							break;
						default:
							goto IL_0094;
						case 1:
							goto end_IL_006e;
						}
						continue;
						end_IL_006e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 0:
				return;
			case 2:
				enumerator = ProcessHeaderManager.Instance.GetPermissions((IProcessHeader)header).GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				ot1ejS081pttFgfIfm7(header);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (header == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private static void CreatePermissionCache(object header)
	{
		//Discarded unreachable code: IL_009b, IL_016c, IL_017b, IL_01cd, IL_01dc, IL_01e7, IL_031c, IL_035c, IL_036b, IL_0377, IL_04c7, IL_052e, IL_053d, IL_060a, IL_0674, IL_071d, IL_073c, IL_074b, IL_0778, IL_0787
		int num = 3;
		int num2 = num;
		IBPMNProcess iBPMNProcess = default(IBPMNProcess);
		IEnumerator<IProcessHeaderAccess> enumerator = default(IEnumerator<IProcessHeaderAccess>);
		IProcessHeaderAccess current = default(IProcessHeaderAccess);
		Guid? permissionRole = default(Guid?);
		IEnumerator<IResponsibilityMatrixItem> enumerator2 = default(IEnumerator<IResponsibilityMatrixItem>);
		IResponsibilityMatrixItem current2 = default(IResponsibilityMatrixItem);
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (((IProcessHeader)header).Published == null)
				{
					num2 = 6;
					continue;
				}
				iBPMNProcess = ((IWorkflowProcess)nGAM2K00YVPiweVNMV4(header)).CastAsRealType() as IBPMNProcess;
				num2 = 4;
				continue;
			case 5:
				return;
			case 3:
				if (header != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 4:
				if (iBPMNProcess != null)
				{
					enumerator = ((IEnumerable<IProcessHeaderAccess>)((IProcessHeader)header).AccessSettings).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 5;
				}
				continue;
			case 6:
				return;
			case 1:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!zfO6gE0WFFf2K5GuYW0(enumerator))
					{
						num3 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num3 = 20;
						}
						goto IL_00a9;
					}
					goto IL_0506;
					IL_0506:
					current = enumerator.Current;
					num3 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num3 = 5;
					}
					goto IL_00a9;
					IL_00a9:
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 21:
							if (q6SjAo0yZPcZ015L9wW(permissionRole.Value, a3FlMA0mQfAiESMsXp0(CommonRoleTypes.OrganizationItem)))
							{
								num3 = 6;
								continue;
							}
							goto case 10;
						case 5:
							permissionRole = current.PermissionRole;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
							{
								num3 = 1;
							}
							continue;
						case 7:
						case 9:
							permissionRole = current.PermissionRole;
							num4 = 19;
							goto IL_00a5;
						case 10:
							permissionRole = current.PermissionRole;
							num4 = 12;
							goto IL_00a5;
						case 18:
							permissionRole = current.PermissionRole;
							num3 = 3;
							continue;
						case 15:
							try
							{
								while (true)
								{
									int num5;
									if (!enumerator2.MoveNext())
									{
										num5 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
										{
											num5 = 1;
										}
										goto IL_01eb;
									}
									goto IL_02d3;
									IL_02d3:
									current2 = enumerator2.Current;
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
									{
										num5 = 3;
									}
									goto IL_01eb;
									IL_01eb:
									while (true)
									{
										switch (num5)
										{
										case 3:
										{
											InstanceOf<IProcessHeaderPermission> instanceOf3 = new InstanceOf<IProcessHeaderPermission>();
											E2vJR80bR1fWG3oT6DC(instanceOf3.New, tkHLm90ub51IRWglXXr(current2));
											f2Ojk50nSitTeOOj9rD(instanceOf3.New, X2RcT60DRMnWmp7YHCN(current2));
											instanceOf3.New.OrganizationItemPosition = (IOrganizationItem)c5RKYF0HjcjePXyHWOH(current2);
											XFZvAx0BkW2cYTg3nj2(instanceOf3.New, e9iDc40fqHaRsJO4ef0(current));
											instanceOf3.New.PermissionRole = a3FlMA0mQfAiESMsXp0(WorkflowRoleTypes.ProcessCurator);
											QL2Z5Y0cFa3qHa6JB80(instanceOf3.New, header);
											IProcessHeaderPermission new3 = instanceOf3.New;
											new3.UserSecuritySetCacheId = TKK0Gd0XmPoZdrL10Ul(new3);
											hItIYg0dAVur8JV2pYC(new3);
											num5 = 2;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
											{
												num5 = 2;
											}
											continue;
										}
										case 2:
											break;
										default:
											goto IL_02d3;
										case 1:
											goto end_IL_02ad;
										}
										break;
									}
									continue;
									end_IL_02ad:
									break;
								}
							}
							finally
							{
								int num6;
								if (enumerator2 == null)
								{
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
									{
										num6 = 0;
									}
									goto IL_0320;
								}
								goto IL_0336;
								IL_0336:
								UeSVOX09NQlPFxn88t8(enumerator2);
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
								{
									num6 = 1;
								}
								goto IL_0320;
								IL_0320:
								switch (num6)
								{
								default:
									goto end_IL_02fb;
								case 2:
									break;
								case 0:
									goto end_IL_02fb;
								case 1:
									goto end_IL_02fb;
								}
								goto IL_0336;
								end_IL_02fb:;
							}
							break;
						case 6:
						case 11:
						case 23:
						{
							InstanceOf<IProcessHeaderPermission> instanceOf2 = new InstanceOf<IProcessHeaderPermission>();
							E2vJR80bR1fWG3oT6DC(instanceOf2.New, dyFHBx0t7gAZFDjiZty(current));
							instanceOf2.New.OrganizationItem = (IOrganizationItem)McPsmZ0519r7QId7W2j(current);
							instanceOf2.New.OrganizationItemPosition = (IOrganizationItem)VcltgM0gH0wkrDF91K7(current);
							XFZvAx0BkW2cYTg3nj2(instanceOf2.New, current.PermissionId);
							QL2Z5Y0cFa3qHa6JB80(instanceOf2.New, header);
							instanceOf2.New.User = (EleWise.ELMA.Security.Models.IUser)AhbvFr0POlURBqYPVcf(current);
							IProcessHeaderPermission new2 = instanceOf2.New;
							new2.UserSecuritySetCacheId = TKK0Gd0XmPoZdrL10Ul(new2);
							hItIYg0dAVur8JV2pYC(new2);
							num3 = 13;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num3 = 4;
							}
							continue;
						}
						case 13:
						case 17:
						case 25:
						case 26:
							break;
						case 16:
							if (responsibilityMatrixItem == null)
							{
								num3 = 25;
								continue;
							}
							goto case 8;
						case 19:
							if (permissionRole.Value == WorkflowRoleTypes.ProcessCurator.UID)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						case 12:
							if (!(permissionRole.Value == a3FlMA0mQfAiESMsXp0(WorkflowRoleTypes.ProcessOwner)))
							{
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto case 2;
						case 3:
							if (permissionRole.Value == a3FlMA0mQfAiESMsXp0(CommonRoleTypes.Group))
							{
								num3 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
								{
									num3 = 11;
								}
								continue;
							}
							goto case 4;
						case 22:
							goto IL_0506;
						case 8:
						{
							InstanceOf<IProcessHeaderPermission> instanceOf = new InstanceOf<IProcessHeaderPermission>();
							E2vJR80bR1fWG3oT6DC(instanceOf.New, tkHLm90ub51IRWglXXr(responsibilityMatrixItem));
							f2Ojk50nSitTeOOj9rD(instanceOf.New, X2RcT60DRMnWmp7YHCN(responsibilityMatrixItem));
							R81V330L8RyExbA2Vc6(instanceOf.New, c5RKYF0HjcjePXyHWOH(responsibilityMatrixItem));
							instanceOf.New.PermissionId = e9iDc40fqHaRsJO4ef0(current);
							instanceOf.New.PermissionRole = WorkflowRoleTypes.ProcessOwner.UID;
							instanceOf.New.ProcessHeader = (IProcessHeader)header;
							IProcessHeaderPermission @new = instanceOf.New;
							@new.UserSecuritySetCacheId = TKK0Gd0XmPoZdrL10Ul(@new);
							hItIYg0dAVur8JV2pYC(@new);
							num3 = 17;
							continue;
						}
						case 1:
							if (!permissionRole.HasValue)
							{
								num3 = 23;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
								{
									num3 = 10;
								}
								continue;
							}
							goto case 14;
						case 14:
							permissionRole = current.PermissionRole;
							num3 = 24;
							continue;
						case 4:
							permissionRole = current.PermissionRole;
							num3 = 21;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
							{
								num3 = 4;
							}
							continue;
						case 24:
							if (!q6SjAo0yZPcZ015L9wW(permissionRole.Value, CommonRoleTypes.User.UID))
							{
								num3 = 18;
								continue;
							}
							goto case 6;
						case 2:
							responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).FirstOrDefault((IResponsibilityMatrixItem m) => _003C_003Ec.Ut9048ZWyG3qfn0ogcrn(m) == ResponsibilityLevel.Owner);
							num3 = 16;
							continue;
						default:
							enumerator2 = ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).Where((IResponsibilityMatrixItem m) => m.IsCurator).GetEnumerator();
							num3 = 15;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
							{
								num3 = 12;
							}
							continue;
						case 20:
							return;
							IL_00a5:
							num3 = num4;
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				int num7;
				if (enumerator == null)
				{
					num7 = 2;
					goto IL_0721;
				}
				goto IL_0756;
				IL_0721:
				switch (num7)
				{
				case 2:
					goto end_IL_070c;
				case 1:
					goto end_IL_070c;
				}
				goto IL_0756;
				IL_0756:
				UeSVOX09NQlPFxn88t8(enumerator);
				num7 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num7 = 1;
				}
				goto IL_0721;
				end_IL_070c:;
			}
		}
	}

	private static IUserGroup GetGroupFromItem(object item)
	{
		//Discarded unreachable code: IL_00b9
		int num = 1;
		int num2 = num;
		long? workerId = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 4:
				workerId = ((IResponsibilityMatrixItem)item).WorkerId;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (workerId.HasValue)
				{
					num2 = 3;
					continue;
				}
				break;
			case 1:
				if (!q6SjAo0yZPcZ015L9wW(((IResponsibilityMatrixItem)item).WorkerType, InterfaceActivator.UID<IUserGroup>(loadImplementation: false)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 3:
				return ((AbstractNHEntityManager<IUserGroup, long>)GOFScN0jwnKkcaf7c0t()).Load(((IResponsibilityMatrixItem)item).WorkerId.Value);
			}
			break;
		}
		return null;
	}

	private static IOrganizationItem GetOrganizationFromItem(object item)
	{
		//Discarded unreachable code: IL_00bb, IL_00ca, IL_00da, IL_00e9
		int num = 6;
		int num2 = num;
		long? workerId = default(long?);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj = dwsJj006hWrBXQwW5vr();
				workerId = ((IResponsibilityMatrixItem)item).WorkerId;
				organizationItem = ((AbstractNHEntityManager<IOrganizationItem, long>)obj).LoadOrNull(workerId.Value);
				num2 = 7;
				break;
			}
			case 4:
				if (workerId.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
			case 8:
				return organizationItem;
			case 2:
				return null;
			case 5:
				workerId = ((IResponsibilityMatrixItem)item).WorkerId;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				if (QQsf0v0ReLtsrgPugVI(item) == InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false))
				{
					num2 = 5;
					break;
				}
				goto case 2;
			default:
				if (AllebE0qHXndWOvyRAt(organizationItem) == OrganizationItemType.EmployeeGroup)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 9:
				if (AllebE0qHXndWOvyRAt(organizationItem) == OrganizationItemType.Department)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 7:
				if (organizationItem == null)
				{
					num2 = 2;
					break;
				}
				goto case 9;
			}
		}
	}

	private static IOrganizationItem GetOrganizationPositionFromItem(object item)
	{
		//Discarded unreachable code: IL_00d7, IL_00e6, IL_012e
		int num = 1;
		int num2 = num;
		IOrganizationItem organizationItem = default(IOrganizationItem);
		long? workerId = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return organizationItem;
			default:
				return null;
			case 8:
				workerId = ((IResponsibilityMatrixItem)item).WorkerId;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (workerId.HasValue)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 1:
				if (!q6SjAo0yZPcZ015L9wW(QQsf0v0ReLtsrgPugVI(item), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 6:
			{
				OrganizationItemManager instance = OrganizationItemManager.Instance;
				workerId = ((IResponsibilityMatrixItem)item).WorkerId;
				organizationItem = instance.LoadOrNull(workerId.Value);
				num2 = 3;
				break;
			}
			case 3:
				if (organizationItem == null)
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 7:
				if (AllebE0qHXndWOvyRAt(organizationItem) == OrganizationItemType.Position)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static long CalcSetId(IProcessHeaderPermission permission)
	{
		//Discarded unreachable code: IL_0041, IL_008a, IL_00bf, IL_00ce
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return dqntnP0MeKYSFOHJLDR(((IEntity<long>)DSqSm40CSDocqLmYII6(permission)).Id);
			default:
				return f6PSHd0TEoo8I2Bwt8v(permission.User.Id);
			case 6:
				if (M4Zsow0QZZjhP82k7Ct(permission) == null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 3:
				return YN9aAW0UI2E8buWgoeO(permission.OrganizationItemPosition.Id);
			case 1:
				return 0L;
			case 7:
				if (ogGFBx03IlUSOVxO5Jd(permission) == null)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 4:
				return RIljrb0pc9sVlSWBj5u(permission.Group.Id);
			case 2:
				if (DSqSm40CSDocqLmYII6(permission) == null)
				{
					if (KJ9Muk0kZ8KYrpBVsMl(permission) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				}
				num2 = 5;
				break;
			}
		}
	}

	public ProcessHeaderEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QSYiAs0VaMcVFYoowgv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object mFKXCV0YPPRisZqtVsm(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void ot1ejS081pttFgfIfm7(object P_0)
	{
		CreatePermissionCache(P_0);
	}

	internal static object eC5nqa0sgydVJxkBgGF(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).ProcessHeader;
	}

	internal static void fSV4yJ0JQQBCHa9daTM(object P_0)
	{
		RefreshPermissionCache(P_0);
	}

	internal static bool mjlQZX0Z0SpxyrvZiSU()
	{
		return F4drOt0OWuu5Hpgf5U4 == null;
	}

	internal static ProcessHeaderEventListener tZC2A40v5swcSXo6I8x()
	{
		return F4drOt0OWuu5Hpgf5U4;
	}

	internal static void sXc8PO0le3hTd9Ngjib(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object nGAM2K00YVPiweVNMV4(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static bool q6SjAo0yZPcZ015L9wW(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid a3FlMA0mQfAiESMsXp0(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static object dyFHBx0t7gAZFDjiZty(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).Group;
	}

	internal static void E2vJR80bR1fWG3oT6DC(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).Group = (IUserGroup)P_1;
	}

	internal static object McPsmZ0519r7QId7W2j(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).OrganizationItem;
	}

	internal static object VcltgM0gH0wkrDF91K7(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).OrganizationItemPosition;
	}

	internal static void XFZvAx0BkW2cYTg3nj2(object P_0, Guid value)
	{
		((IProcessHeaderPermission)P_0).PermissionId = value;
	}

	internal static void QL2Z5Y0cFa3qHa6JB80(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).ProcessHeader = (IProcessHeader)P_1;
	}

	internal static object AhbvFr0POlURBqYPVcf(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).User;
	}

	internal static long TKK0Gd0XmPoZdrL10Ul(object P_0)
	{
		return CalcSetId((IProcessHeaderPermission)P_0);
	}

	internal static void hItIYg0dAVur8JV2pYC(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object tkHLm90ub51IRWglXXr(object P_0)
	{
		return GetGroupFromItem(P_0);
	}

	internal static object X2RcT60DRMnWmp7YHCN(object P_0)
	{
		return GetOrganizationFromItem(P_0);
	}

	internal static void f2Ojk50nSitTeOOj9rD(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).OrganizationItem = (IOrganizationItem)P_1;
	}

	internal static object c5RKYF0HjcjePXyHWOH(object P_0)
	{
		return GetOrganizationPositionFromItem(P_0);
	}

	internal static void R81V330L8RyExbA2Vc6(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).OrganizationItemPosition = (IOrganizationItem)P_1;
	}

	internal static Guid e9iDc40fqHaRsJO4ef0(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).PermissionId;
	}

	internal static void UeSVOX09NQlPFxn88t8(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool zfO6gE0WFFf2K5GuYW0(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object GOFScN0jwnKkcaf7c0t()
	{
		return UserGroupManager.Instance;
	}

	internal static Guid QQsf0v0ReLtsrgPugVI(object P_0)
	{
		return ((IResponsibilityMatrixItem)P_0).WorkerType;
	}

	internal static object dwsJj006hWrBXQwW5vr()
	{
		return OrganizationItemManager.Instance;
	}

	internal static OrganizationItemType AllebE0qHXndWOvyRAt(object P_0)
	{
		return ((IOrganizationItem)P_0).ItemType;
	}

	internal static object ogGFBx03IlUSOVxO5Jd(object P_0)
	{
		return ((IProcessHeaderPermission)P_0).User;
	}

	internal static long f6PSHd0TEoo8I2Bwt8v(long P_0)
	{
		return UserSecuritySetHelper.GetUserMask(P_0);
	}

	internal static object M4Zsow0QZZjhP82k7Ct(object P_0)
	{
		return ((IProcessHeaderPermission)P_0).Group;
	}

	internal static long RIljrb0pc9sVlSWBj5u(long P_0)
	{
		return UserSecuritySetHelper.GetGroupMask(P_0);
	}

	internal static object DSqSm40CSDocqLmYII6(object P_0)
	{
		return ((IProcessHeaderPermission)P_0).OrganizationItem;
	}

	internal static long dqntnP0MeKYSFOHJLDR(long P_0)
	{
		return UserSecuritySetHelper.GetOrganizationItemMask(P_0);
	}

	internal static object KJ9Muk0kZ8KYrpBVsMl(object P_0)
	{
		return ((IProcessHeaderPermission)P_0).OrganizationItemPosition;
	}

	internal static long YN9aAW0UI2E8buWgoeO(long P_0)
	{
		return UserSecuritySetHelper.GetPostMask(P_0);
	}

	internal static void QSYiAs0VaMcVFYoowgv()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
