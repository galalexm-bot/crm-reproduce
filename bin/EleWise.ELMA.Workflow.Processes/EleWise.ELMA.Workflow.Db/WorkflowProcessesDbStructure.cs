using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Db;

public class WorkflowProcessesDbStructure : DbStructureExtension
{
	internal static WorkflowProcessesDbStructure KYsFCSF2FCAo5ACrkRI;

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[2]
	{
		typeof(SecurityDbStructure),
		N9tsSfFVT8SAN2ibKop(typeof(WorkflowDbStructure).TypeHandle)
	};

	public void RenameMonitorProcessActionFilter()
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_00e7, IL_00f6
		int num = 7;
		int num2 = num;
		IFilterActionLink filterActionLink = default(IFilterActionLink);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (filterActionLink == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 0:
				return;
			case 7:
				filterActionLink = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(WorkflowConstants.MonitorProcessesActionFilter);
				num2 = 6;
				break;
			case 3:
				if (!LOkME1FKcYEZhUKdTYn(Cxl1R7FD6tsudaLMM2b(filterActionLink), WorkflowConstants.MyMonitorProcessName))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				Ffm4xBFaWJvMYc3plZe(filterActionLink, j1NVOlFMGUndrovsF13(WorkflowConstants.MyMonitorProcessName));
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 5:
				dfMGkVFYCIerVUIWjcn(filterActionLink);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void CreateSystemActionFilters()
	{
		//Discarded unreachable code: IL_022d, IL_0272
		int num = 10;
		IFilterActionLink filterActionLink2 = default(IFilterActionLink);
		IFilterActionLink filterActionLink = default(IFilterActionLink);
		IUserGroup group = default(IUserGroup);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					((FilterDefaultManager)RpCQ4RFTLouPmVFSJ3Y()).SaveSystemDefaultFilter((IFilter)filterActionLink2);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
					if (filterActionLink2 != null)
					{
						num2 = 11;
						continue;
					}
					break;
				case 12:
				{
					InstanceOf<IFilterActionLink> instanceOf = new InstanceOf<IFilterActionLink>();
					kcygueFvZQtsc0TZqOH(instanceOf.New, FilterType.SystemFilter);
					bjCayHFckAoyWguj93R(instanceOf.New, WorkflowConstants.MonitorProcessesActionFilter);
					Ffm4xBFaWJvMYc3plZe(instanceOf.New, j1NVOlFMGUndrovsF13(WorkflowConstants.MyMonitorProcessName));
					instanceOf.New.Description = (string)j1NVOlFMGUndrovsF13(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x242A8D1D ^ 0x242ABE5D));
					IFilterActionLink @new = instanceOf.New;
					ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
					fmBDW9F4Z63ACbJG87l(referenceOnEntityType, InterfaceActivator.UID<IWorkflowInstance>());
					USCJ20F9QmrghTuWj7u(@new, referenceOnEntityType);
					instanceOf.New.Code = WorkflowConstants.MonitorFilterCode;
					KkXZNbFNm0BFSDXIWnO(instanceOf.New, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1059430085 ^ 0x3F25AC53));
					CFeboRFdF3BSiJfTaZq(instanceOf.New, PaqFxuFPViejQpE31DV(0x688CC33F ^ 0x688CF085));
					instanceOf.New.Weight = 0L;
					filterActionLink = instanceOf.New;
					num2 = 4;
					continue;
				}
				case 4:
					SetAllToReadFilter(filterActionLink, group);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					filterActionLink2 = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(WorkflowConstants.MyProcessesActionFilter);
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
				case 11:
					filterActionLink = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(WorkflowConstants.MonitorProcessesActionFilter);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					dfMGkVFYCIerVUIWjcn(filterActionLink);
					num2 = 6;
					continue;
				case 15:
					dfMGkVFYCIerVUIWjcn(filterActionLink2);
					num2 = 3;
					continue;
				case 6:
					FilterDefaultManager.Instance.SaveSystemDefaultFilter(filterActionLink);
					num2 = 7;
					continue;
				case 2:
					return;
				case 13:
					SetAllToReadFilter(filterActionLink2, group);
					num2 = 15;
					continue;
				case 7:
					return;
				case 10:
					group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
					num2 = 9;
					continue;
				case 14:
					break;
				case 1:
					if (filterActionLink != null)
					{
						num2 = 2;
						continue;
					}
					goto case 12;
				}
				break;
			}
			InstanceOf<IFilterActionLink> instanceOf2 = new InstanceOf<IFilterActionLink>();
			kcygueFvZQtsc0TZqOH(instanceOf2.New, FilterType.SystemFilter);
			instanceOf2.New.Uid = WorkflowConstants.MyProcessesActionFilter;
			instanceOf2.New.Name = (string)j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(-275456087 ^ -275452541));
			instanceOf2.New.Description = (string)j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(-474638327 ^ -474633649));
			IFilterActionLink new2 = instanceOf2.New;
			ReferenceOnEntityType referenceOnEntityType2 = new ReferenceOnEntityType();
			fmBDW9F4Z63ACbJG87l(referenceOnEntityType2, InterfaceActivator.UID<IWorkflowInstance>());
			USCJ20F9QmrghTuWj7u(new2, referenceOnEntityType2);
			instanceOf2.New.Code = WorkflowConstants.MyProcessesFilterCode;
			instanceOf2.New.ActionTypeProviderId = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1737696342 ^ -1737692868);
			instanceOf2.New.ActionId = (string)PaqFxuFPViejQpE31DV(-1633140121 ^ -1633128273);
			instanceOf2.New.Weight = 0L;
			filterActionLink2 = instanceOf2.New;
			num = 13;
		}
	}

	public void CreateFullMonitorActionFilter()
	{
		//Discarded unreachable code: IL_01c0, IL_01cf
		int num = 7;
		IFilterActionLink filterActionLink = default(IFilterActionLink);
		IUserGroup group = default(IUserGroup);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 7:
					filterActionLink = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(WorkflowConstants.FullMonitorProcessesActionFilter);
					num2 = 6;
					continue;
				case 5:
					dfMGkVFYCIerVUIWjcn(filterActionLink);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
				{
					InstanceOf<IFilterActionLink> instanceOf = new InstanceOf<IFilterActionLink>();
					kcygueFvZQtsc0TZqOH(instanceOf.New, FilterType.SystemFilter);
					bjCayHFckAoyWguj93R(instanceOf.New, WorkflowConstants.FullMonitorProcessesActionFilter);
					Ffm4xBFaWJvMYc3plZe(instanceOf.New, j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(-1164596236 ^ -1164596852)));
					Sw0EWkFjjRDMMFcRrJv(instanceOf.New, j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(-1411073168 ^ -1411084468)));
					USCJ20F9QmrghTuWj7u(instanceOf.New, new ReferenceOnEntityType
					{
						TypeUid = InterfaceActivator.UID<IWorkflowInstance>()
					});
					instanceOf.New.Code = WorkflowConstants.MonitorFilterCode;
					KkXZNbFNm0BFSDXIWnO(instanceOf.New, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1843608060 ^ -1843596142));
					instanceOf.New.ActionId = (string)PaqFxuFPViejQpE31DV(-1843608060 ^ -1843596616);
					instanceOf.New.Weight = 5L;
					filterActionLink = instanceOf.New;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 4:
					group = UserGroupManager.Instance.LoadOrNull(BaseWorkflowConstants.FullMonitorGroupId);
					num2 = 2;
					continue;
				case 6:
					if (filterActionLink != null)
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 1:
					return;
				case 3:
					return;
				}
				break;
			}
			SetAllToReadFilter(filterActionLink, group, edit: true, full: true);
			num = 5;
		}
	}

	public void CreateImprovementUserGroups()
	{
		//Discarded unreachable code: IL_0095, IL_00ca, IL_0208, IL_0217, IL_02d8, IL_02f7, IL_0306, IL_0323, IL_0425
		int num = 28;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IUserGroup userGroup2 = default(IUserGroup);
		GroupPermissionManager serviceNotNull = default(GroupPermissionManager);
		IEnumerator<IUserGroup> enumerator = default(IEnumerator<IUserGroup>);
		IUserGroup userGroup = default(IUserGroup);
		IUserGroup userGroup3 = default(IUserGroup);
		IUserGroup current = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num = 21;
					break;
				case 27:
					if (userGroup2 != null)
					{
						num2 = 6;
						continue;
					}
					goto case 24;
				case 12:
					dfMGkVFYCIerVUIWjcn(userGroup2);
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
					{
						num2 = 14;
					}
					continue;
				case 23:
					return;
				case 9:
					serviceNotNull = Locator.GetServiceNotNull<GroupPermissionManager>();
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					if (userGroup2 != null)
					{
						num = 18;
						break;
					}
					goto case 11;
				case 14:
				case 18:
					ufRgXmFeWPp8FupnJYm(F7SlvQFH0ijWtVL2ZHg(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num2 = 23;
					continue;
				case 16:
					enumerator = serviceNotNull.GetGroupsByPermission(WorkflowProcessesPermissionProvider.ImprovementAccessPermission).GetEnumerator();
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					if (userGroup == null)
					{
						num2 = 15;
						continue;
					}
					goto case 7;
				case 15:
				case 19:
					userGroup2.Save();
					num = 20;
					break;
				case 7:
					userGroup2.Groups.Add(userGroup);
					num2 = 19;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
					{
						num2 = 19;
					}
					continue;
				case 6:
				case 20:
					userGroup2 = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).LoadOrNull(WorkflowConstants.ImprovementAllProcessesGroupId);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					if (userGroup3 != null)
					{
						num2 = 25;
						continue;
					}
					goto case 12;
				case 3:
					try
					{
						while (true)
						{
							IL_0257:
							int num3;
							if (!pNPqhhFWOPfuD829NFs(enumerator))
							{
								num3 = 3;
								goto IL_0226;
							}
							goto IL_0244;
							IL_0226:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto IL_0257;
								case 2:
									serviceNotNull.RemovePermission(current, WorkflowProcessesPermissionProvider.ImprovementAccessPermission);
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
									{
										num3 = 0;
									}
									continue;
								case 4:
								{
									userGroup2.Groups.Add(current);
									int num4 = 2;
									num3 = num4;
									continue;
								}
								case 3:
									goto end_IL_0257;
								}
								break;
							}
							goto IL_0244;
							IL_0244:
							current = enumerator.Current;
							num3 = 4;
							goto IL_0226;
							continue;
							end_IL_0257:
							break;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
							{
								num5 = 1;
							}
							goto IL_02dc;
						}
						goto IL_0311;
						IL_0311:
						enumerator.Dispose();
						num5 = 2;
						goto IL_02dc;
						IL_02dc:
						switch (num5)
						{
						case 1:
							goto end_IL_02b7;
						case 2:
							goto end_IL_02b7;
						}
						goto IL_0311;
						end_IL_02b7:;
					}
					goto case 12;
				default:
				{
					IEntityManager<IAssignedRoleStereotype> instance = EntityManager<IAssignedRoleStereotype>.Instance;
					_003C_003Ec__DisplayClass7_.hasStereotype = false;
					ParameterExpression parameterExpression = (ParameterExpression)rNPiQrFO2hZ3oxgq0Dp(N9tsSfFVT8SAN2ibKop(typeof(IAssignedRoleStereotype).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x148F9F60 ^ 0x148FAAD4));
					instance.Find(Expression.Lambda<Func<IAssignedRoleStereotype, bool>>((Expression)KWblRoFBbrdbdouaovE(TixrAaF6SnMRHEb3Cjw(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), XllVo5F0lpCFcAbXMbf(TixrAaF6SnMRHEb3Cjw(Expression.Field(null, (FieldInfo)uah1KmFRvenKP58rGPK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), N9tsSfFVT8SAN2ibKop(typeof(Guid?).TypeHandle)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ToList().ForEach(_003C_003Ec__DisplayClass7_._003CCreateImprovementUserGroups_003Eb__1);
					num2 = 22;
					continue;
				}
				case 21:
					user2 = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
					{
						num2 = 10;
					}
					continue;
				case 22:
					if (_003C_003Ec__DisplayClass7_.hasStereotype)
					{
						num2 = 9;
						continue;
					}
					goto case 5;
				case 28:
					userGroup2 = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).LoadOrNull(WorkflowConstants.ImprovementProcessesGroupId);
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
					{
						num2 = 27;
					}
					continue;
				case 4:
					throw new InvalidOperationException((string)via5WqFbJWqjmwVprua(PaqFxuFPViejQpE31DV(0x60E50EF5 ^ 0x60E53BB3), new object[1] { SecurityConstants.AdminUserUid }));
				case 5:
					userGroup3 = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).LoadOrNull(SecurityConstants.AdminGroupUid);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 17;
					}
					continue;
				case 25:
					userGroup2.Groups.Add(userGroup3);
					num2 = 12;
					continue;
				case 13:
					throw new InvalidOperationException((string)via5WqFbJWqjmwVprua(PaqFxuFPViejQpE31DV(0x604C9214 ^ 0x604CA752), new object[1] { SecurityConstants.AdminUserUid }));
				case 24:
					user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)S8x1EpFkCiBmgAU1tLm()).LoadOrNull(SecurityConstants.AdminUserUid);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					if (user2 != null)
					{
						InstanceOf<IUserGroup> instanceOf2 = new InstanceOf<IUserGroup>();
						instanceOf2.New.Name = (string)UGixUyFUJ8FHNUQHsYn(WorkflowConstants.ImprovementAllProcessesGroupDescriptor);
						vWV4DtFp0C22kGNwZq8(instanceOf2.New, mtAFPdFANRZKBdwO1Rm(WorkflowConstants.ImprovementAllProcessesGroupDescriptor));
						yOigxxFG6OidfGooKVQ(instanceOf2.New, user2);
						Fj3eT9FniSHTFEFQsky(instanceOf2.New, WorkflowConstants.ImprovementAllProcessesGroupId);
						eM64uBFy9JHuwXs0NuG(instanceOf2.New, true);
						userGroup2 = instanceOf2.New;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 2:
					if (user != null)
					{
						InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
						pCmJXUFm5KH4gbKWDOy(instanceOf.New, UGixUyFUJ8FHNUQHsYn(WorkflowConstants.ImprovementProcessesGroupDescriptor));
						vWV4DtFp0C22kGNwZq8(instanceOf.New, mtAFPdFANRZKBdwO1Rm(WorkflowConstants.ImprovementProcessesGroupDescriptor));
						yOigxxFG6OidfGooKVQ(instanceOf.New, user);
						Fj3eT9FniSHTFEFQsky(instanceOf.New, WorkflowConstants.ImprovementProcessesGroupId);
						eM64uBFy9JHuwXs0NuG(instanceOf.New, true);
						userGroup2 = instanceOf.New;
						num2 = 26;
					}
					else
					{
						num2 = 11;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 != 0)
						{
							num2 = 13;
						}
					}
					continue;
				case 26:
					userGroup = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).LoadOrNull(SecurityConstants.AllUsersGroupUid);
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	public void UpdateProcessImprovementMajor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				DeleteProcessImprovementFilters();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				RenameProcessImprovementFilters();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void DeleteProcessImprovementFilters()
	{
		//Discarded unreachable code: IL_00ba
		int num = 2;
		int num2 = num;
		IFilterActionLink filterActionLink2 = default(IFilterActionLink);
		IFilterActionLink filterActionLink = default(IFilterActionLink);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (filterActionLink2 == null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 2:
				filterActionLink = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(WorkflowConstants.ImprovementProcessesActionFilter);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				filterActionLink2 = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(WorkflowConstants.ImprovementAllProcessesActionFilter);
				num2 = 6;
				continue;
			case 1:
				if (filterActionLink != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto default;
			case 3:
				return;
			case 5:
				return;
			case 7:
				filterActionLink.Delete();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				break;
			}
			LIYWK7FiGDW5vPaZqkq(filterActionLink2);
			num2 = 5;
		}
	}

	private void RenameProcessImprovementFilters()
	{
		//Discarded unreachable code: IL_00f1, IL_0100
		int num = 5;
		int num2 = num;
		IFilter filter = default(IFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (LOkME1FKcYEZhUKdTYn(Cxl1R7FD6tsudaLMM2b(filter), e0cEJmFu54GxdrrvaiJ()))
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				filter.Name = (string)e0cEJmFu54GxdrrvaiJ();
				num2 = 3;
				break;
			case 4:
				if (filter == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 5:
				filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.CurrentImprovements);
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 != 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			case 3:
				dfMGkVFYCIerVUIWjcn(filter);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CreateImprovementActionFilters()
	{
		int num = 6;
		int num2 = num;
		IFilter filter2 = default(IFilter);
		IUserGroup group = default(IUserGroup);
		IFilter filter = default(IFilter);
		while (true)
		{
			switch (num2)
			{
			case 11:
				return;
			case 4:
				SetAllToReadFilter(filter2, group);
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
				{
					num2 = 9;
				}
				break;
			case 2:
				dfMGkVFYCIerVUIWjcn(filter);
				num2 = 11;
				break;
			case 7:
				SetAllToReadFilter(filter, group);
				num2 = 2;
				break;
			case 5:
				filter2 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.MyImprovements);
				num2 = 8;
				break;
			default:
			{
				InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
				kcygueFvZQtsc0TZqOH(instanceOf.New, FilterType.SystemFilter);
				bjCayHFckAoyWguj93R(instanceOf.New, WorkflowConstants.MyImprovements);
				instanceOf.New.Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3907FE5 ^ 0x3904A5F));
				USCJ20F9QmrghTuWj7u(instanceOf.New, new ReferenceOnEntityType
				{
					TypeUid = InterfaceActivator.UID<IWorkflowInstance>()
				});
				instanceOf.New.UseDefaultSettings = true;
				instanceOf.New.Code = WorkflowConstants.ImprovementFilterCode;
				IFilter @new = instanceOf.New;
				InstanceOf<IWorkflowInstanceFilter> instanceOf2 = new InstanceOf<IWorkflowInstanceFilter>();
				instanceOf2.New.PermissionId = Puq7MGFlTQiwaKMhj2U(WorkflowProcessesPermissionProvider.ImprovementModulePermission);
				instanceOf2.New.CurrentExecuterRole = OfaRfSFf1ON0UF9xY2c(WorkflowRoleTypes.Initiator);
				vNwZM9FJcIMXvxPYB48(@new, VQa6N5FLgATHLwSSmx2(instanceOf2.New, null));
				instanceOf.New.Weight = 1L;
				filter2 = instanceOf.New;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
				{
					num2 = 4;
				}
				break;
			}
			case 9:
				dfMGkVFYCIerVUIWjcn(filter2);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.CurrentImprovements);
				num2 = 10;
				break;
			case 8:
				if (filter2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
			{
				InstanceOf<IFilter> instanceOf3 = new InstanceOf<IFilter>();
				kcygueFvZQtsc0TZqOH(instanceOf3.New, FilterType.SystemFilter);
				bjCayHFckAoyWguj93R(instanceOf3.New, WorkflowConstants.CurrentImprovements);
				instanceOf3.New.Name = (string)e0cEJmFu54GxdrrvaiJ();
				IFilter new2 = instanceOf3.New;
				ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
				fmBDW9F4Z63ACbJG87l(referenceOnEntityType, InterfaceActivator.UID<IWorkflowInstance>());
				new2.ObjectsType = referenceOnEntityType;
				O49DenFrOMee2yq374m(instanceOf3.New, true);
				instanceOf3.New.Code = WorkflowConstants.ImprovementFilterCode;
				IFilter new3 = instanceOf3.New;
				InstanceOf<IWorkflowInstanceFilter> instanceOf4 = new InstanceOf<IWorkflowInstanceFilter>();
				instanceOf4.New.PermissionId = Puq7MGFlTQiwaKMhj2U(WorkflowProcessesPermissionProvider.ImprovementAccessPermission);
				instanceOf4.New.GeneralStatus = WorkflowInstanceGeneralStatus.Current;
				vNwZM9FJcIMXvxPYB48(new3, VQa6N5FLgATHLwSSmx2(instanceOf4.New, null));
				instanceOf3.New.Weight = 4L;
				filter = instanceOf3.New;
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 6:
				group = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).Load(SecurityConstants.AllUsersGroupUid);
				num2 = 5;
				break;
			case 10:
				if (filter != null)
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	public void CreateDefaultMyProcessesFiltersForAllUsers()
	{
		//Discarded unreachable code: IL_02f0, IL_044c
		int num = 2;
		IFilter filter3 = default(IFilter);
		IFilter filter2 = default(IFilter);
		IUserGroup group = default(IUserGroup);
		IFilter filter = default(IFilter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
				case 10:
					filter3 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.CreatedByInstances);
					num2 = 15;
					continue;
				case 14:
					filter2.Save();
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
					{
						num2 = 15;
					}
					continue;
				case 16:
				{
					InstanceOf<IFilter> instanceOf3 = new InstanceOf<IFilter>();
					kcygueFvZQtsc0TZqOH(instanceOf3.New, FilterType.SystemFilter);
					bjCayHFckAoyWguj93R(instanceOf3.New, WorkflowConstants.CreatedByInstances);
					Ffm4xBFaWJvMYc3plZe(instanceOf3.New, j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(-1386102027 ^ -1386088673)));
					instanceOf3.New.Code = WorkflowConstants.MyProcessesFilterCode;
					IFilter new3 = instanceOf3.New;
					ReferenceOnEntityType referenceOnEntityType2 = new ReferenceOnEntityType();
					fmBDW9F4Z63ACbJG87l(referenceOnEntityType2, InterfaceActivator.UID<IWorkflowInstance>());
					USCJ20F9QmrghTuWj7u(new3, referenceOnEntityType2);
					O49DenFrOMee2yq374m(instanceOf3.New, true);
					IFilter new4 = instanceOf3.New;
					InstanceOf<IWorkflowInstanceFilter> instanceOf4 = new InstanceOf<IWorkflowInstanceFilter>();
					instanceOf4.New.CurrentExecuterRole = OfaRfSFf1ON0UF9xY2c(WorkflowRoleTypes.Initiator);
					instanceOf4.New.GeneralStatus = WorkflowInstanceGeneralStatus.Current;
					vNwZM9FJcIMXvxPYB48(new4, VQa6N5FLgATHLwSSmx2(instanceOf4.New, null));
					instanceOf3.New.Weight = 5L;
					filter3 = instanceOf3.New;
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				case 13:
					SetAllToReadFilter(filter2, group);
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 != 0)
					{
						num2 = 14;
					}
					continue;
				case 9:
					dfMGkVFYCIerVUIWjcn(filter3);
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b != 0)
					{
						num2 = 11;
					}
					continue;
				case 15:
					if (filter3 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 16;
				case 5:
				{
					InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
					kcygueFvZQtsc0TZqOH(instanceOf.New, FilterType.SystemFilter);
					bjCayHFckAoyWguj93R(instanceOf.New, WorkflowConstants.CreatedByAllInstances);
					Ffm4xBFaWJvMYc3plZe(instanceOf.New, j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(0x1C21F94 ^ 0x1C2298E)));
					instanceOf.New.Code = WorkflowConstants.MyProcessesFilterCode;
					IFilter @new = instanceOf.New;
					ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
					fmBDW9F4Z63ACbJG87l(referenceOnEntityType, InterfaceActivator.UID<IWorkflowInstance>());
					USCJ20F9QmrghTuWj7u(@new, referenceOnEntityType);
					O49DenFrOMee2yq374m(instanceOf.New, true);
					IFilter new2 = instanceOf.New;
					InstanceOf<IWorkflowInstanceFilter> instanceOf2 = new InstanceOf<IWorkflowInstanceFilter>();
					instanceOf2.New.CurrentExecuterRole = OfaRfSFf1ON0UF9xY2c(WorkflowRoleTypes.Initiator);
					vNwZM9FJcIMXvxPYB48(new2, VQa6N5FLgATHLwSSmx2(instanceOf2.New, null));
					instanceOf.New.Weight = 10L;
					filter2 = instanceOf.New;
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 11:
					SetAllToReadFilter(filter, group);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
				{
					InstanceOf<IFilter> instanceOf5 = new InstanceOf<IFilter>();
					kcygueFvZQtsc0TZqOH(instanceOf5.New, FilterType.SystemFilter);
					bjCayHFckAoyWguj93R(instanceOf5.New, WorkflowConstants.CurrentInstances);
					Ffm4xBFaWJvMYc3plZe(instanceOf5.New, j1NVOlFMGUndrovsF13(PaqFxuFPViejQpE31DV(0x138E9AEB ^ 0x138EAF33)));
					IFilter new5 = instanceOf5.New;
					ReferenceOnEntityType referenceOnEntityType3 = new ReferenceOnEntityType();
					fmBDW9F4Z63ACbJG87l(referenceOnEntityType3, InterfaceActivator.UID<IWorkflowInstance>());
					USCJ20F9QmrghTuWj7u(new5, referenceOnEntityType3);
					O49DenFrOMee2yq374m(instanceOf5.New, true);
					instanceOf5.New.Code = WorkflowConstants.MyProcessesFilterCode;
					IFilter new6 = instanceOf5.New;
					InstanceOf<IWorkflowInstanceFilter> instanceOf6 = new InstanceOf<IWorkflowInstanceFilter>();
					instanceOf6.New.PermissionId = Puq7MGFlTQiwaKMhj2U(WorkflowPermissionProvider.MyProcessesPermission);
					instanceOf6.New.GeneralStatus = WorkflowInstanceGeneralStatus.Current;
					vNwZM9FJcIMXvxPYB48(new6, VQa6N5FLgATHLwSSmx2(instanceOf6.New, null));
					instanceOf5.New.Weight = 1L;
					filter = instanceOf5.New;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 1:
					filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.CurrentInstances);
					num2 = 6;
					continue;
				case 3:
					break;
				case 17:
					return;
				case 18:
					if (filter2 != null)
					{
						return;
					}
					num2 = 5;
					continue;
				case 7:
					SetAllToReadFilter(filter3, group);
					num2 = 9;
					continue;
				case 2:
					group = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).Load(SecurityConstants.AllUsersGroupUid);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					filter2 = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.CreatedByAllInstances);
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
					{
						num2 = 18;
					}
					continue;
				case 6:
					if (filter != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			dfMGkVFYCIerVUIWjcn(filter);
			num = 10;
		}
	}

	public void CreateSystemMyResponsibilityFilterForAllUsers()
	{
		//Discarded unreachable code: IL_016a
		int num = 3;
		int num2 = num;
		IFilter filter = default(IFilter);
		IUserGroup group = default(IUserGroup);
		while (true)
		{
			switch (num2)
			{
			case 6:
			{
				InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
				kcygueFvZQtsc0TZqOH(instanceOf.New, FilterType.SystemFilter);
				instanceOf.New.Uid = WorkflowConstants.MyResponsibilityInstances;
				Ffm4xBFaWJvMYc3plZe(instanceOf.New, j1NVOlFMGUndrovsF13(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3907FE5 ^ 0x39049A7)));
				instanceOf.New.Code = WorkflowConstants.MyProcessesFilterCode;
				USCJ20F9QmrghTuWj7u(instanceOf.New, new ReferenceOnEntityType
				{
					TypeUid = InterfaceActivator.UID<IWorkflowInstance>()
				});
				O49DenFrOMee2yq374m(instanceOf.New, true);
				IFilter @new = instanceOf.New;
				InstanceOf<IWorkflowInstanceFilter> instanceOf2 = new InstanceOf<IWorkflowInstanceFilter>();
				instanceOf2.New.CurrentExecuterRole = OfaRfSFf1ON0UF9xY2c(WorkflowRoleTypes.ResponsibleForInstance);
				instanceOf2.New.GeneralStatus = WorkflowInstanceGeneralStatus.Current;
				vNwZM9FJcIMXvxPYB48(@new, VQa6N5FLgATHLwSSmx2(instanceOf2.New, null));
				instanceOf.New.Weight = 15L;
				filter = instanceOf.New;
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
				{
					num2 = 4;
				}
				break;
			}
			case 2:
				filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.MyResponsibilityInstances);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 1:
				dfMGkVFYCIerVUIWjcn(filter);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				SetAllToReadFilter(filter, group);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				return;
			case 3:
				group = ((AbstractNHEntityManager<IUserGroup, long>)k5qDpPFSb3t5RReA5BJ()).Load(SecurityConstants.AllUsersGroupUid);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (filter != null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			}
		}
	}

	private void SetAllToReadFilter(IFilter filter, IUserGroup group, bool edit = false, bool full = false)
	{
		//Discarded unreachable code: IL_014b, IL_015a, IL_0169
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				ISet<IFilterPermission> permissions3 = filter.Permissions;
				InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
				SXjKZ5F7WPkyh2PL34G(instanceOf3.New, filter);
				CoTAx1F5D7g77c064io(instanceOf3.New, Puq7MGFlTQiwaKMhj2U(EleWise.ELMA.Common.PermissionProvider.FilterEditPermission));
				gYkEsUF1qhhOHq6AIwP(instanceOf3.New, CommonRoleTypes.Group.Id);
				e8HBKQFZqpG80TkVUST(instanceOf3.New, group);
				instanceOf3.New.UserSecuritySetCacheId = QGimpmFISWyllGiWlXG(group.Id);
				permissions3.Add(instanceOf3.New);
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
				{
					num2 = 5;
				}
				break;
			}
			case 6:
			{
				ISet<IFilterPermission> permissions2 = filter.Permissions;
				InstanceOf<IFilterPermission> instanceOf2 = new InstanceOf<IFilterPermission>();
				instanceOf2.New.Filter = filter;
				CoTAx1F5D7g77c064io(instanceOf2.New, Puq7MGFlTQiwaKMhj2U(EleWise.ELMA.Common.PermissionProvider.FilterFullAccessPermission));
				gYkEsUF1qhhOHq6AIwP(instanceOf2.New, CommonRoleTypes.Group.Id);
				e8HBKQFZqpG80TkVUST(instanceOf2.New, group);
				instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
				permissions2.Add(instanceOf2.New);
				num2 = 2;
				break;
			}
			case 7:
				return;
			case 2:
				return;
			case 4:
			{
				ISet<IFilterPermission> permissions = filter.Permissions;
				InstanceOf<IFilterPermission> instanceOf = new InstanceOf<IFilterPermission>();
				SXjKZ5F7WPkyh2PL34G(instanceOf.New, filter);
				CoTAx1F5D7g77c064io(instanceOf.New, Puq7MGFlTQiwaKMhj2U(EleWise.ELMA.Common.PermissionProvider.FilterViewPermission));
				gYkEsUF1qhhOHq6AIwP(instanceOf.New, rmaPNWFgRDdwf8jJffr(CommonRoleTypes.Group));
				instanceOf.New.Group = group;
				instanceOf.New.UserSecuritySetCacheId = QGimpmFISWyllGiWlXG(group.Id);
				permissions.Add(instanceOf.New);
				num2 = 3;
				break;
			}
			default:
				if (!full)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 3:
				if (!edit)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public void ImproveProcessDisableHandRun2()
	{
		//Discarded unreachable code: IL_0061, IL_0104, IL_015b, IL_016a
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				IProcessHeader processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)GxeyujFziF4T7M4a5I8()).LoadOrNull(new Guid((string)PaqFxuFPViejQpE31DV(-949720076 ^ -949723752)));
				int num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						dfMGkVFYCIerVUIWjcn(processHeader);
						num = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
						{
							num = 1;
						}
						continue;
					case 3:
						Fw9CEE8EgJhs5vhuBc3(processHeader, WorkflowProcessRunAvailability.DeniedForUsers);
						num = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
						{
							num = 1;
						}
						continue;
					}
					if (processHeader == null)
					{
						return;
					}
					num = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 != 0)
					{
						num = 2;
					}
				}
			}
			catch (Exception exception)
			{
				int num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						((ILogger)n2GN9k8CofJnenoaqrN()).Error(PaqFxuFPViejQpE31DV(-1197637235 ^ -1197623499), exception);
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public void UpdateMyProcessStartFilters()
	{
		int num = 1;
		int num2 = num;
		IFilter filter = default(IFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				if (filter != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 2:
				return;
			case 3:
				((FilterDefaultManager)RpCQ4RFTLouPmVFSJ3Y()).SaveSystemDefaultFilter(filter);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(WorkflowConstants.CreatedByAllInstances);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RecreateMonitorAllCache1()
	{
		vNbCIw8X826d6emruak(MonitorCacheItemManager.Instance);
	}

	public void RecreateMonitorAllCacheCountByUsers1()
	{
		VsYgWh8o4WiIwL5b0u6(ProcessesWorkflowInstanceManager.Instance);
	}

	public void OptimizeMonitorCacheActions()
	{
		sDlKB88hFS6XiNXsvld(xl0yiF837oOa0yfEQaX());
	}

	public void UpdateCustomActivity()
	{
		//Discarded unreachable code: IL_005f, IL_00e8, IL_00f7, IL_0102, IL_01cb, IL_020b, IL_021a, IL_0226, IL_0235, IL_0300, IL_031f, IL_034f, IL_035e
		int num = 1;
		int num2 = num;
		IEnumerator<ICustomActivityHeader> enumerator = default(IEnumerator<ICustomActivityHeader>);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		IEnumerator<ICustomActivity> enumerator2 = default(IEnumerator<ICustomActivity>);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = CustomActivityHeaderManager.Instance.Find(FetchOptions.All).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num4;
					if (!pNPqhhFWOPfuD829NFs(enumerator))
					{
						int num3 = 5;
						num4 = num3;
						goto IL_006d;
					}
					goto IL_00a9;
					IL_006d:
					while (true)
					{
						switch (num4)
						{
						case 5:
							return;
						case 1:
							break;
						case 3:
							goto IL_00a9;
						default:
							_003C_003Ec__DisplayClass20_.header = enumerator.Current;
							num4 = 4;
							continue;
						case 2:
							try
							{
								while (true)
								{
									IL_016f:
									int num6;
									if (!pNPqhhFWOPfuD829NFs(enumerator2))
									{
										num6 = 1;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d != 0)
										{
											num6 = 1;
										}
										goto IL_0106;
									}
									goto IL_0120;
									IL_0120:
									ICustomActivity current = enumerator2.Current;
									WxwLhi8w85EPsAgkMqS(current, DateTime.Now);
									mMsB1N8tYGTYE6YEqsV(current, UserManager.Instance.Load(SecurityConstants.AdminUserUid));
									R3aHGJ8s0xLwu7RKeFH(current, num5);
									current.Save();
									num6 = 2;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
									{
										num6 = 2;
									}
									goto IL_0106;
									IL_0106:
									while (true)
									{
										switch (num6)
										{
										case 3:
											goto IL_016f;
										case 2:
											num5++;
											num6 = 3;
											continue;
										case 1:
											goto end_IL_016f;
										}
										break;
									}
									goto IL_0120;
									continue;
									end_IL_016f:
									break;
								}
							}
							finally
							{
								int num7;
								if (enumerator2 == null)
								{
									num7 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
									{
										num7 = 1;
									}
									goto IL_01cf;
								}
								goto IL_01e5;
								IL_01e5:
								X7JbLh820L1yPBIUcXf(enumerator2);
								num7 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
								{
									num7 = 0;
								}
								goto IL_01cf;
								IL_01cf:
								switch (num7)
								{
								default:
									goto end_IL_01aa;
								case 2:
									break;
								case 1:
									goto end_IL_01aa;
								case 0:
									goto end_IL_01aa;
								}
								goto IL_01e5;
								end_IL_01aa:;
							}
							break;
						case 4:
						{
							object obj = foEWDv8xkR0TfKyt5L0();
							ParameterExpression parameterExpression = (ParameterExpression)rNPiQrFO2hZ3oxgq0Dp(N9tsSfFVT8SAN2ibKop(typeof(ICustomActivity).TypeHandle), PaqFxuFPViejQpE31DV(0x3F8E27D0 ^ 0x3F8E10CE));
							ICollection<ICustomActivity> collection = ((AbstractNHEntityManager<ICustomActivity, long>)obj).Find(Expression.Lambda<Func<ICustomActivity, bool>>(Expression.Equal((Expression)TixrAaF6SnMRHEb3Cjw(parameterExpression, (MethodInfo)YiYdki8FaZaebBnyesN((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)wU0qrD88l03UYoJwT62(Expression.Constant(_003C_003Ec__DisplayClass20_, typeof(_003C_003Ec__DisplayClass20_0)), uah1KmFRvenKP58rGPK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
							num5 = 0;
							enumerator2 = collection.GetEnumerator();
							num4 = 2;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
							{
								num4 = 0;
							}
							continue;
						}
						}
						break;
					}
					continue;
					IL_00a9:
					_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
					num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 != 0)
					{
						num4 = 0;
					}
					goto IL_006d;
				}
			}
			finally
			{
				int num8;
				if (enumerator == null)
				{
					num8 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
					{
						num8 = 1;
					}
					goto IL_0304;
				}
				goto IL_032d;
				IL_032d:
				X7JbLh820L1yPBIUcXf(enumerator);
				num8 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
				{
					num8 = 0;
				}
				goto IL_0304;
				IL_0304:
				switch (num8)
				{
				default:
					goto end_IL_02df;
				case 1:
					goto end_IL_02df;
				case 2:
					break;
				case 0:
					goto end_IL_02df;
				}
				goto IL_032d;
				end_IL_02df:;
			}
		}
	}

	internal void UpdateWorkflowMessageBookmarkStatus()
	{
		int num = 1;
		int num2 = num;
		string[] columns = default(string[]);
		object[] values = default(object[]);
		string where = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				((ITransformationProvider)QxR7UM8QQNIUMjOMLc7(this)).Update((string)PaqFxuFPViejQpE31DV(-1587393812 ^ -1587383660), columns, values, where, (Dictionary<string, object>)null);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			default:
				values = new object[1] { 2 };
				num2 = 3;
				break;
			case 3:
				where = (string)TfrUmR8KO6soOrfsiMu(PaqFxuFPViejQpE31DV(-361150192 ^ -361136604), new object[8]
				{
					((Dialect)GVcNh28qFm2us928OPa(base.Transformation)).QuoteIfNeeded((string)PaqFxuFPViejQpE31DV(0xE108112 ^ 0xE10B6E8)),
					base.Transformation.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-193507406 ^ -193497168), (string)PaqFxuFPViejQpE31DV(0x51F798FE ^ 0x51F7A0D8)),
					wXpd458VkpafRhwKoLi(QxR7UM8QQNIUMjOMLc7(this), PaqFxuFPViejQpE31DV(-901337984 ^ -901344084), PaqFxuFPViejQpE31DV(0x48FD6D2E ^ 0x48FD4BFE)),
					U0RYp28DGj41c4mjmRe(GVcNh28qFm2us928OPa(base.Transformation), PaqFxuFPViejQpE31DV(0xB84E87 ^ 0xB876D7)),
					U0RYp28DGj41c4mjmRe(GVcNh28qFm2us928OPa(base.Transformation), PaqFxuFPViejQpE31DV(-1164596236 ^ -1164600112)),
					((Dialect)GVcNh28qFm2us928OPa(base.Transformation)).QuoteIfNeeded((string)PaqFxuFPViejQpE31DV(-711228462 ^ -711214154)),
					string.Join((string)PaqFxuFPViejQpE31DV(-1365449958 ^ -1365458066), new int[2] { 4, 3 }),
					0
				});
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				columns = new string[1] { (string)PaqFxuFPViejQpE31DV(0x33BD2188 ^ 0x33BD16AC) };
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void RemovePreviouslyDeliveredMessages()
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_00ac, IL_0109, IL_01da, IL_020e, IL_0246, IL_0255
		int num = 3;
		int num2 = num;
		Filter filter = default(Filter);
		IEnumerator<IWorkflowMessageItem> enumerator = default(IEnumerator<IWorkflowMessageItem>);
		IWorkflowMessageItem current = default(IWorkflowMessageItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
			{
				Filter filter2 = new Filter();
				PxSI848MWY0M1Z2W3Dt(filter2, PaqFxuFPViejQpE31DV(-680549150 ^ -680551352));
				filter = filter2;
				num2 = 2;
				continue;
			}
			case 2:
				enumerator = AbstractNHEntityManager<IWorkflowMessageItem, long>.Instance.Find(filter, (FetchOptions)aq07d08aAGH7fSVfLLQ()).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!pNPqhhFWOPfuD829NFs(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
						{
							num3 = 1;
						}
						goto IL_00b0;
					}
					goto IL_014f;
					IL_014f:
					current = enumerator.Current;
					num3 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
					{
						num3 = 8;
					}
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						default:
							jd76Ld8YXy28UHS99bA(current, null);
							num3 = 6;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
							{
								num3 = 6;
							}
							continue;
						case 3:
						case 9:
							break;
						case 8:
							if (current.ReceiverUids != null)
							{
								num3 = 5;
								continue;
							}
							break;
						case 2:
							goto IL_014f;
						case 5:
							if ((current.ReceiverUids as List<Guid>).Count <= 0)
							{
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 4;
						case 4:
							LIYWK7FiGDW5vPaZqkq(current);
							num3 = 9;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
							{
								num3 = 7;
							}
							continue;
						case 6:
							dfMGkVFYCIerVUIWjcn(current);
							num3 = 3;
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							X7JbLh820L1yPBIUcXf(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
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
		}
	}

	public WorkflowProcessesDbStructure()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BPFx2C8vRL0W8IpAYZN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type N9tsSfFVT8SAN2ibKop(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool IapSeKFqdg4O8NMNyqP()
	{
		return KYsFCSF2FCAo5ACrkRI == null;
	}

	internal static WorkflowProcessesDbStructure ic8GhKFQnHnBaBVl26R()
	{
		return KYsFCSF2FCAo5ACrkRI;
	}

	internal static object Cxl1R7FD6tsudaLMM2b(object P_0)
	{
		return ((IFilter)P_0).Name;
	}

	internal static bool LOkME1FKcYEZhUKdTYn(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object j1NVOlFMGUndrovsF13(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void Ffm4xBFaWJvMYc3plZe(object P_0, object P_1)
	{
		((IFilter)P_0).Name = (string)P_1;
	}

	internal static void dfMGkVFYCIerVUIWjcn(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void kcygueFvZQtsc0TZqOH(object P_0, FilterType P_1)
	{
		((IFilter)P_0).FilterType = P_1;
	}

	internal static object PaqFxuFPViejQpE31DV(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void fmBDW9F4Z63ACbJG87l(object P_0, Guid P_1)
	{
		((ReferenceOnEntityType)P_0).TypeUid = P_1;
	}

	internal static void USCJ20F9QmrghTuWj7u(object P_0, object P_1)
	{
		((IFilter)P_0).ObjectsType = (ReferenceOnEntityType)P_1;
	}

	internal static object RpCQ4RFTLouPmVFSJ3Y()
	{
		return FilterDefaultManager.Instance;
	}

	internal static void bjCayHFckAoyWguj93R(object P_0, Guid P_1)
	{
		((IFilter)P_0).Uid = P_1;
	}

	internal static void KkXZNbFNm0BFSDXIWnO(object P_0, object P_1)
	{
		((IFilterActionLink)P_0).ActionTypeProviderId = (string)P_1;
	}

	internal static void CFeboRFdF3BSiJfTaZq(object P_0, object P_1)
	{
		((IFilterActionLink)P_0).ActionId = (string)P_1;
	}

	internal static void Sw0EWkFjjRDMMFcRrJv(object P_0, object P_1)
	{
		((IFilterActionLink)P_0).Description = (string)P_1;
	}

	internal static object k5qDpPFSb3t5RReA5BJ()
	{
		return UserGroupManager.Instance;
	}

	internal static object S8x1EpFkCiBmgAU1tLm()
	{
		return UserManager.Instance;
	}

	internal static object via5WqFbJWqjmwVprua(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object UGixUyFUJ8FHNUQHsYn(object P_0)
	{
		return ((GroupDescriptor)P_0).Name;
	}

	internal static void pCmJXUFm5KH4gbKWDOy(object P_0, object P_1)
	{
		((IUserGroup)P_0).Name = (string)P_1;
	}

	internal static object mtAFPdFANRZKBdwO1Rm(object P_0)
	{
		return ((GroupDescriptor)P_0).Description;
	}

	internal static void vWV4DtFp0C22kGNwZq8(object P_0, object P_1)
	{
		((IUserGroup)P_0).Description = (string)P_1;
	}

	internal static void yOigxxFG6OidfGooKVQ(object P_0, object P_1)
	{
		((IUserGroup)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void Fj3eT9FniSHTFEFQsky(object P_0, Guid P_1)
	{
		((IUserGroup)P_0).Uid = P_1;
	}

	internal static void eM64uBFy9JHuwXs0NuG(object P_0, bool P_1)
	{
		((IUserGroup)P_0).IsSystem = P_1;
	}

	internal static object rNPiQrFO2hZ3oxgq0Dp(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object TixrAaF6SnMRHEb3Cjw(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object uah1KmFRvenKP58rGPK(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object XllVo5F0lpCFcAbXMbf(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object KWblRoFBbrdbdouaovE(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static bool pNPqhhFWOPfuD829NFs(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object F7SlvQFH0ijWtVL2ZHg(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void ufRgXmFeWPp8FupnJYm(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static void LIYWK7FiGDW5vPaZqkq(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object e0cEJmFu54GxdrrvaiJ()
	{
		return WorkflowConstants.CurrentImprovementName;
	}

	internal static Guid Puq7MGFlTQiwaKMhj2U(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static Guid OfaRfSFf1ON0UF9xY2c(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static object VQa6N5FLgATHLwSSmx2(object P_0, object P_1)
	{
		return UniversalFilterSaver.Pack((IEntityFilter)P_0, (ITypeWrapperResolver)P_1);
	}

	internal static void vNwZM9FJcIMXvxPYB48(object P_0, object P_1)
	{
		((IFilter)P_0).FilterFields = P_1;
	}

	internal static void O49DenFrOMee2yq374m(object P_0, bool P_1)
	{
		((IFilter)P_0).UseDefaultSettings = P_1;
	}

	internal static void SXjKZ5F7WPkyh2PL34G(object P_0, object P_1)
	{
		((IFilterPermission)P_0).Filter = (IFilter)P_1;
	}

	internal static void CoTAx1F5D7g77c064io(object P_0, Guid P_1)
	{
		((IFilterPermission)P_0).PermissionId = P_1;
	}

	internal static Guid rmaPNWFgRDdwf8jJffr(object P_0)
	{
		return ((PermissionRoleType)P_0).Id;
	}

	internal static void gYkEsUF1qhhOHq6AIwP(object P_0, Guid P_1)
	{
		((IInstanceSettingsPermissionHolder)P_0).TypeRoleId = P_1;
	}

	internal static long QGimpmFISWyllGiWlXG(long P_0)
	{
		return UserSecuritySetHelper.GetGroupMask(P_0);
	}

	internal static void e8HBKQFZqpG80TkVUST(object P_0, object P_1)
	{
		((IFilterPermission)P_0).Group = (IUserGroup)P_1;
	}

	internal static object GxeyujFziF4T7M4a5I8()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static void Fw9CEE8EgJhs5vhuBc3(object P_0, WorkflowProcessRunAvailability P_1)
	{
		((IProcessHeader)P_0).RunAvailability = P_1;
	}

	internal static object n2GN9k8CofJnenoaqrN()
	{
		return Logger.Log;
	}

	internal static void vNbCIw8X826d6emruak(object P_0)
	{
		((MonitorCacheItemManager)P_0).RecreateCache();
	}

	internal static void VsYgWh8o4WiIwL5b0u6(object P_0)
	{
		((ProcessesWorkflowInstanceManager)P_0).RecreateCacheByUsers();
	}

	internal static object xl0yiF837oOa0yfEQaX()
	{
		return MonitorUpdateActionQueueItemManager.Instance;
	}

	internal static void sDlKB88hFS6XiNXsvld(object P_0)
	{
		((MonitorUpdateActionQueueItemManager)P_0).OptimizeCacheActions();
	}

	internal static object foEWDv8xkR0TfKyt5L0()
	{
		return CustomActivityManager.Instance;
	}

	internal static object YiYdki8FaZaebBnyesN(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object wU0qrD88l03UYoJwT62(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static void WxwLhi8w85EPsAgkMqS(object P_0, DateTime value)
	{
		((ICustomActivity)P_0).CreationDate = value;
	}

	internal static void mMsB1N8tYGTYE6YEqsV(object P_0, object P_1)
	{
		((ICustomActivity)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void R3aHGJ8s0xLwu7RKeFH(object P_0, long value)
	{
		((ICustomActivity)P_0).VersionNumber = value;
	}

	internal static void X7JbLh820L1yPBIUcXf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object GVcNh28qFm2us928OPa(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object QxR7UM8QQNIUMjOMLc7(object P_0)
	{
		return ((DbStructureExtension)P_0).Transformation;
	}

	internal static object wXpd458VkpafRhwKoLi(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).NoLockTableExpression((string)P_1, (string)P_2);
	}

	internal static object U0RYp28DGj41c4mjmRe(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object TfrUmR8KO6soOrfsiMu(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void PxSI848MWY0M1Z2W3Dt(object P_0, object P_1)
	{
		((Filter)P_0).Query = (string)P_1;
	}

	internal static object aq07d08aAGH7fSVfLLQ()
	{
		return FetchOptions.All;
	}

	internal static void jd76Ld8YXy28UHS99bA(object P_0, object P_1)
	{
		((IWorkflowMessageItem)P_0).ReceiverUids = P_1;
	}

	internal static void BPFx2C8vRL0W8IpAYZN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
