using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow;

[Component]
internal class WorkflowTaskPermissionProvider : ExpressionPermissionBase<IWorkflowTaskBase, ITaskBasePermission>
{
	internal static WorkflowTaskPermissionProvider oMawCuOHEIyP3vrW6IA;

	protected override PropertyExpressionDescriptor[] AccesspropertiesExpressions()
	{
		int num = 1;
		int num2 = num;
		PropertyExpressionDescriptor[] result = default(PropertyExpressionDescriptor[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
			{
				PropertyExpressionDescriptorWithInstanceUid[] array = new PropertyExpressionDescriptorWithInstanceUid[10];
				ParameterExpression parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E97649));
				Expression<Func<IWorkflowTaskBase, object>> expression = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = Expression.Parameter(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), (string)yTRjXBORvYsLMaeAebx(-1574607501 ^ -1574608285));
				array[0] = new PropertyExpressionDescriptorWithInstanceUid(expression, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), CommonRoleTypes.User);
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542189558));
				Expression<Func<IWorkflowTaskBase, object>> expression2 = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = Expression.Parameter(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), (string)yTRjXBORvYsLMaeAebx(-261315199 ^ -261315951));
				array[1] = new PropertyExpressionDescriptorWithInstanceUid(expression2, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), CommonRoleTypes.Group);
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(0x246EEF98 ^ 0x246EE888));
				Expression<Func<IWorkflowTaskBase, object>> expression3 = Expression.Lambda<Func<IWorkflowTaskBase, object>>(Expression.Call(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(typeof(IWorkflowTaskBase), yTRjXBORvYsLMaeAebx(-43932417 ^ -43932689));
				array[2] = new PropertyExpressionDescriptorWithInstanceUid(expression3, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), CommonRoleTypes.OrganizationItem);
				parameterExpression = Expression.Parameter(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), (string)yTRjXBORvYsLMaeAebx(0x6871CA ^ 0x6876DA));
				Expression<Func<IWorkflowTaskBase, object>> expression4 = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-43932417 ^ -43932689));
				array[3] = new PropertyExpressionDescriptorWithInstanceUid(expression4, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.CurrentExecutor);
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-398691253 ^ -398691493));
				Expression<Func<IWorkflowTaskBase, object>> expression5 = Expression.Lambda<Func<IWorkflowTaskBase, object>>(Expression.Call(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(0x1927DA93 ^ 0x1927DD83));
				array[4] = new PropertyExpressionDescriptorWithInstanceUid(expression5, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.DirectorsOfCurrentExecutor, allowChief: true);
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-862330810 ^ -862329002));
				Expression<Func<IWorkflowTaskBase, object>> expression6 = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-1028861977 ^ -1028863753));
				array[5] = new PropertyExpressionDescriptorWithInstanceUid(expression6, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.Initiator);
				parameterExpression = Expression.Parameter(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), (string)yTRjXBORvYsLMaeAebx(-17847711 ^ -17846927));
				Expression<Func<IWorkflowTaskBase, object>> expression7 = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(typeof(IWorkflowTaskBase), yTRjXBORvYsLMaeAebx(0x1843E01F ^ 0x1843E70F));
				array[6] = new PropertyExpressionDescriptorWithInstanceUid(expression7, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.ProcessCurator);
				parameterExpression = Expression.Parameter(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), (string)yTRjXBORvYsLMaeAebx(0x361628FF ^ 0x36162FEF));
				Expression<Func<IWorkflowTaskBase, object>> expression8 = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-17847711 ^ -17846927));
				array[7] = new PropertyExpressionDescriptorWithInstanceUid(expression8, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.ProcessInstanceMember);
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-2111219045 ^ -2111218293));
				Expression<Func<IWorkflowTaskBase, object>> expression9 = Expression.Lambda<Func<IWorkflowTaskBase, object>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression });
				parameterExpression = Expression.Parameter(typeof(IWorkflowTaskBase), (string)yTRjXBORvYsLMaeAebx(--1756698829 ^ 0x68B51FDD));
				array[8] = new PropertyExpressionDescriptorWithInstanceUid(expression9, Expression.Lambda<Func<IWorkflowTaskBase, string>>((Expression)owKqiPOj7JevqnDMInK(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.ProcessOwner);
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(0x6CC04061 ^ 0x6CC04771));
				Expression<Func<IWorkflowTaskBase, object>> expression10 = Expression.Lambda<Func<IWorkflowTaskBase, object>>(Expression.Call(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression });
				parameterExpression = (ParameterExpression)HZvnGqOW1lXLkhh6ZOn(FaD0BOO9fmwhw2ofdlg(typeof(IWorkflowTaskBase).TypeHandle), yTRjXBORvYsLMaeAebx(-684210684 ^ -684211948));
				array[9] = new PropertyExpressionDescriptorWithInstanceUid(expression10, Expression.Lambda<Func<IWorkflowTaskBase, string>>(Expression.Call(null, (MethodInfo)zU5qN0O6hufZZlGD15r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression }), WorkflowRoleTypes.ResponsibleForInstance);
				result = array;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected override ICollection<ITaskBasePermission> GetPermissionPersistenceCollection(IWorkflowTaskBase target)
	{
		return (ICollection<ITaskBasePermission>)(target.Permissions ?? (target.Permissions = (ISet<ITaskBasePermission>)(object)new HashedSet<ITaskBasePermission>()));
	}

	private static string GetWorkflowInstanceUid(object workflowTask)
	{
		//Discarded unreachable code: IL_0085, IL_00a4, IL_00b3
		int num = 4;
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 5:
				case 6:
					return null;
				case 1:
					if (((IWorkflowBookmark)XUw9SEOqUQEN5eydOjS(workflowTask)).Instance != null)
					{
						guid = Ow3mF5O3QwxMaJ8bsKR(((IWorkflowBookmark)XUw9SEOqUQEN5eydOjS(workflowTask)).Instance);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 5;
					}
					break;
				case 4:
					if (workflowTask == null)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 2:
					if (XUw9SEOqUQEN5eydOjS(workflowTask) == null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				default:
					return guid.ToString();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	private static IEnumerable<IProcessHeaderAccess> GetWorkflowPermissions(object workflowTask)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.workflowTask = (IWorkflowTaskBase)workflowTask;
		if (CS_0024_003C_003E8__locals0.workflowTask == null || CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark == null || CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance == null)
		{
			return Enumerable.Empty<IProcessHeaderAccess>();
		}
		if (!SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516553476), defaultValue: false))
		{
			return Enumerable.Empty<IProcessHeaderAccess>();
		}
		IContextBoundVariableService serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
		string name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077785816) + CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance.Process.Header.Uid;
		return serviceNotNull.GetOrAdd(name, delegate
		{
			IEntityManager<IProcessHeaderAccess> instance = EntityManager<IProcessHeaderAccess>.Instance;
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IProcessHeaderAccess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360681037));
			return instance.Find(Expression.Lambda<Func<IProcessHeaderAccess, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Property(Expression.Property(Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Field(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }));
		});
	}

	private static IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsers(object workflowTask)
	{
		if (workflowTask == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance == null)
		{
			return null;
		}
		return from x in GetWorkflowPermissions(workflowTask)
			where x.User != null
			select (EleWise.ELMA.Security.Models.IUser)_003C_003Ec.vRDAFfZHA1yKmI9QRLNc(x);
	}

	private static IEnumerable<IUserGroup> GetUserGroups(object workflowTask)
	{
		if (workflowTask == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance == null)
		{
			return null;
		}
		return from x in GetWorkflowPermissions(workflowTask)
			where x.Group != null
			select (IUserGroup)_003C_003Ec.IFJ1XdZHG39T1b9GS6M2(x);
	}

	private static IEnumerable<IOrganizationItem> GetOrganizationItems(object workflowTask)
	{
		if (workflowTask == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance == null)
		{
			return null;
		}
		HashedSet<IOrganizationItem> val = new HashedSet<IOrganizationItem>();
		IEnumerable<IProcessHeaderAccess> workflowPermissions = GetWorkflowPermissions(workflowTask);
		IEnumerable<IOrganizationItem> enumerable = from x in workflowPermissions
			where _003C_003Ec.faHoGoZH7hhgpjgkm56c(x) != null
			select x.OrganizationItem;
		IEnumerable<IOrganizationItem> enumerable2 = from x in workflowPermissions
			where x.OrganizationItemPosition != null
			select (IOrganizationItem)_003C_003Ec.q9gk4RZH29N1jihviHwS(x);
		if (enumerable.Count() > 0 || enumerable2.Count() > 0)
		{
			((ISet<IOrganizationItem>)val).AddAll(enumerable2);
			((ISet<IOrganizationItem>)val).AddAll(enumerable);
			return (IEnumerable<IOrganizationItem>)val;
		}
		return Enumerable.Empty<IOrganizationItem>();
	}

	private static EleWise.ELMA.Security.Models.IUser GetSystemUser()
	{
		return ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)d0KeJ3OT9H8BKEvbTWg()).Load(SecurityConstants.SystemUserUid);
	}

	private static IEnumerable<Guid?> GetRoleTypes(object workflowTask)
	{
		return from x in GetWorkflowPermissions(workflowTask).Where(delegate(IProcessHeaderAccess p)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (_003C_003Ec.IFJ1XdZHG39T1b9GS6M2(p) == null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 1:
						if (_003C_003Ec.vRDAFfZHA1yKmI9QRLNc(p) == null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 2:
						return p.OrganizationItem == null;
					}
					break;
				}
				return false;
			})
			select x.PermissionRole;
	}

	private static EleWise.ELMA.Security.Models.IUser GetCurrentExecutor(object workflowTask)
	{
		//Discarded unreachable code: IL_0041, IL_0081, IL_0090, IL_00a0
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (workflowTask == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 6:
					return (EleWise.ELMA.Security.Models.IUser)Vow6DxOQywK1UKucXTj(workflowTask);
				case 2:
					if (((IWorkflowBookmark)XUw9SEOqUQEN5eydOjS(workflowTask)).Instance != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 1:
					if (XUw9SEOqUQEN5eydOjS(workflowTask) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				default:
					return null;
				case 5:
					if (!GetRoleTypes(workflowTask).Any(delegate(Guid? x)
					{
						Guid? guid = x;
						Guid id = WorkflowRoleTypes.CurrentExecutor.Id;
						if (!guid.HasValue)
						{
							return false;
						}
						return !guid.HasValue || guid.GetValueOrDefault() == id;
					}))
					{
						return (EleWise.ELMA.Security.Models.IUser)VRUoc1Op9gxYwtQE8c8();
					}
					num = 6;
					break;
				}
				break;
			}
		}
	}

	private static EleWise.ELMA.Security.Models.IUser GetAllowChiefOfCurrentExecutor(object workflowTask)
	{
		//Discarded unreachable code: IL_009d, IL_00cc, IL_00db, IL_00eb
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (nhXc8SOCBsSxqJabh9D(XUw9SEOqUQEN5eydOjS(workflowTask)) != null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 1:
				if (XUw9SEOqUQEN5eydOjS(workflowTask) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				return (EleWise.ELMA.Security.Models.IUser)Vow6DxOQywK1UKucXTj(workflowTask);
			case 3:
				return (EleWise.ELMA.Security.Models.IUser)VRUoc1Op9gxYwtQE8c8();
			case 5:
				if (workflowTask == null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
			case 4:
				return null;
			case 7:
				if (!GetRoleTypes(workflowTask).Any(delegate(Guid? x)
				{
					Guid? guid = x;
					Guid id = WorkflowRoleTypes.DirectorsOfCurrentExecutor.Id;
					if (!guid.HasValue)
					{
						return false;
					}
					return !guid.HasValue || guid.GetValueOrDefault() == id;
				}))
				{
					num2 = 3;
					break;
				}
				goto case 6;
			}
		}
	}

	private static EleWise.ELMA.Security.Models.IUser GetInitiator(object workflowTask)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_007b, IL_00a8, IL_00b7, IL_00c7
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return (EleWise.ELMA.Security.Models.IUser)coBfU0OMKLJIWw5m38H(nhXc8SOCBsSxqJabh9D(XUw9SEOqUQEN5eydOjS(workflowTask)));
				case 5:
					return (EleWise.ELMA.Security.Models.IUser)VRUoc1Op9gxYwtQE8c8();
				case 6:
					if (nhXc8SOCBsSxqJabh9D(XUw9SEOqUQEN5eydOjS(workflowTask)) != null)
					{
						num = 4;
						break;
					}
					goto default;
				case 1:
					if (XUw9SEOqUQEN5eydOjS(workflowTask) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 3:
					if (workflowTask == null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				default:
					return null;
				case 4:
					if (!GetRoleTypes(workflowTask).Any(delegate(Guid? x)
					{
						Guid? guid = x;
						Guid id = WorkflowRoleTypes.Initiator.Id;
						if (!guid.HasValue)
						{
							return false;
						}
						return !guid.HasValue || guid.GetValueOrDefault() == id;
					}))
					{
						num = 5;
						break;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	private static IEnumerable<IOrganizationItem> GetProcessCurators(object workflowTask)
	{
		if (workflowTask == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance == null)
		{
			return null;
		}
		IEnumerable<Guid?> roleTypes = GetRoleTypes(workflowTask);
		HashedSet<IOrganizationItem> val = new HashedSet<IOrganizationItem>();
		if (roleTypes.Any(delegate(Guid? x)
		{
			Guid? guid = x;
			Guid id = WorkflowRoleTypes.ProcessCurator.Id;
			if (!guid.HasValue)
			{
				return false;
			}
			return !guid.HasValue || guid.GetValueOrDefault() == id;
		}) && ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance.Process.CastAsRealType() is IBPMNProcess iBPMNProcess)
		{
			{
				foreach (IResponsibilityMatrixItem item in ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).Where(delegate(IResponsibilityMatrixItem r)
				{
					//Discarded unreachable code: IL_00ab, IL_00ba
					int num = 4;
					int num2 = num;
					long? workerId = default(long?);
					while (true)
					{
						switch (num2)
						{
						default:
							if (_003C_003Ec.tn9ipdZHFsN95AeZMI60(r) == _003C_003Ec.UBkS4ZZHiijb3a4m8F68())
							{
								num2 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
								{
									num2 = 2;
								}
								continue;
							}
							break;
						case 4:
							if (!_003C_003Ec.prBnlUZHog1UOdmFEFvM(r))
							{
								num2 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto default;
						case 2:
							workerId = r.WorkerId;
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
							{
								num2 = 1;
							}
							continue;
						case 1:
							return workerId.HasValue;
						case 3:
							break;
						}
						break;
					}
					return false;
				}))
				{
					IOrganizationItem organizationItem = OrganizationItemManager.Instance.LoadOrNull(item.WorkerId.Value);
					if (organizationItem != null)
					{
						((Set<IOrganizationItem>)(object)val).Add(organizationItem);
					}
				}
				return (IEnumerable<IOrganizationItem>)val;
			}
		}
		return (IEnumerable<IOrganizationItem>)val;
	}

	private static IEnumerable<EleWise.ELMA.Security.Models.IUser> GetProcessInstanceMembers(object workflowTask)
	{
		if (workflowTask == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark == null || ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance == null)
		{
			return null;
		}
		IEnumerable<Guid?> roleTypes = GetRoleTypes(workflowTask);
		HashedSet<EleWise.ELMA.Security.Models.IUser> val = new HashedSet<EleWise.ELMA.Security.Models.IUser>();
		if (roleTypes.Any(delegate(Guid? x)
		{
			Guid? guid = x;
			Guid id = WorkflowRoleTypes.ProcessInstanceMember.Id;
			if (!guid.HasValue)
			{
				return false;
			}
			return !guid.HasValue || guid.GetValueOrDefault() == id;
		}))
		{
			ISet<IWorkflowInstanceMember> members = ((IWorkflowTaskBase)workflowTask).WorkflowBookmark.Instance.Members;
			if (!members.get_IsEmpty())
			{
				((ISet<EleWise.ELMA.Security.Models.IUser>)val).AddAll(((IEnumerable<IWorkflowInstanceMember>)members).Select((IWorkflowInstanceMember x) => x.User));
			}
		}
		return (IEnumerable<EleWise.ELMA.Security.Models.IUser>)val;
	}

	private static object GetProcessOwners(object workflowTask)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_008c, IL_009a, IL_017a, IL_01b2, IL_01c1, IL_020f, IL_021e, IL_0264
		int num = 1;
		int num2 = num;
		HashedSet<IOrganizationItem> val = default(HashedSet<IOrganizationItem>);
		IEnumerator<IResponsibilityMatrixItem> enumerator = default(IEnumerator<IResponsibilityMatrixItem>);
		IResponsibilityMatrixItem current = default(IResponsibilityMatrixItem);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		IBPMNProcess iBPMNProcess = default(IBPMNProcess);
		while (true)
		{
			switch (num2)
			{
			case 11:
			case 12:
				if (cLGSowOU36vPixaT3EK(val) <= 0)
				{
					num2 = 6;
					continue;
				}
				goto case 9;
			case 7:
				try
				{
					while (true)
					{
						IL_00d3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
							{
								num3 = 0;
							}
							goto IL_009e;
						}
						goto IL_00c0;
						IL_00c0:
						current = enumerator.Current;
						num3 = 3;
						goto IL_009e;
						IL_009e:
						while (true)
						{
							switch (num3)
							{
							case 5:
								goto IL_00c0;
							case 1:
								goto IL_00d3;
							case 4:
								if (organizationItem != null)
								{
									num3 = 2;
									continue;
								}
								goto IL_00d3;
							case 2:
								((Set<IOrganizationItem>)(object)val).Add(organizationItem);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								organizationItem = OrganizationItemManager.Instance.LoadOrNull(current.WorkerId.Value);
								num3 = 4;
								continue;
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								njeE8EOkQcoX0jsuoBR(enumerator);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 11;
			case 1:
				if (workflowTask != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 9:
				return val;
			case 6:
				return GetSystemUser();
			default:
				if (XUw9SEOqUQEN5eydOjS(workflowTask) != null)
				{
					num2 = 8;
					continue;
				}
				goto case 3;
			case 10:
				iBPMNProcess = ((IWorkflowInstance)nhXc8SOCBsSxqJabh9D(((IWorkflowTaskBase)workflowTask).WorkflowBookmark)).Process.CastAsRealType() as IBPMNProcess;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				if (iBPMNProcess == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			case 8:
				if (((IWorkflowBookmark)XUw9SEOqUQEN5eydOjS(workflowTask)).Instance != null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 3:
				return null;
			case 5:
			{
				IEnumerable<Guid?> roleTypes = GetRoleTypes(workflowTask);
				val = new HashedSet<IOrganizationItem>();
				if (roleTypes.Any(delegate(Guid? x)
				{
					Guid? guid = x;
					Guid id = WorkflowRoleTypes.ProcessOwner.Id;
					if (!guid.HasValue)
					{
						return false;
					}
					return !guid.HasValue || guid.GetValueOrDefault() == id;
				}))
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 11;
			}
			case 2:
				break;
			}
			enumerator = ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).Where(delegate(IResponsibilityMatrixItem r)
			{
				int num5 = 3;
				int num6 = num5;
				long? workerId = default(long?);
				while (true)
				{
					switch (num6)
					{
					case 2:
						if (_003C_003Ec.ze13iNZHa879quUnq56W(_003C_003Ec.tn9ipdZHFsN95AeZMI60(r), _003C_003Ec.UBkS4ZZHiijb3a4m8F68()))
						{
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
							{
								num6 = 0;
							}
							break;
						}
						goto IL_0085;
					default:
						workerId = r.WorkerId;
						num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num6 = 1;
						}
						break;
					case 1:
						return workerId.HasValue;
					case 3:
						{
							if (_003C_003Ec.VLqdyJZHIWSWUuYAPDmI(r) == ResponsibilityLevel.Owner)
							{
								num6 = 2;
								break;
							}
							goto IL_0085;
						}
						IL_0085:
						return false;
					}
				}
			}).GetEnumerator();
			num2 = 7;
		}
	}

	private static EleWise.ELMA.Security.Models.IUser GetResponsibleForInstance(object workflowTask)
	{
		//Discarded unreachable code: IL_0069, IL_0078, IL_00a2, IL_00b1
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (XUw9SEOqUQEN5eydOjS(workflowTask) != null)
					{
						num2 = 2;
						continue;
					}
					break;
				case 1:
					return (EleWise.ELMA.Security.Models.IUser)OW3ug6OVKAjg5JocqBu(nhXc8SOCBsSxqJabh9D(XUw9SEOqUQEN5eydOjS(workflowTask)));
				case 3:
					return GetSystemUser();
				case 2:
					if (((IWorkflowBookmark)XUw9SEOqUQEN5eydOjS(workflowTask)).Instance == null)
					{
						num2 = 4;
						continue;
					}
					if (!GetRoleTypes(workflowTask).Any(delegate(Guid? x)
					{
						Guid? guid = x;
						Guid id = WorkflowRoleTypes.ResponsibleForInstance.Id;
						if (!guid.HasValue)
						{
							return false;
						}
						return !guid.HasValue || guid.GetValueOrDefault() == id;
					}))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 6:
					if (workflowTask == null)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 4:
				case 5:
					break;
				}
				return null;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public WorkflowTaskPermissionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type FaD0BOO9fmwhw2ofdlg(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object HZvnGqOW1lXLkhh6ZOn(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object owKqiPOj7JevqnDMInK(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}

	internal static object yTRjXBORvYsLMaeAebx(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zU5qN0O6hufZZlGD15r(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static bool GbHiKpOLd6udq8rBCR3()
	{
		return oMawCuOHEIyP3vrW6IA == null;
	}

	internal static WorkflowTaskPermissionProvider rCjU9uOfXkII5SM0CDZ()
	{
		return oMawCuOHEIyP3vrW6IA;
	}

	internal static object XUw9SEOqUQEN5eydOjS(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static Guid Ow3mF5O3QwxMaJ8bsKR(object P_0)
	{
		return ((IWorkflowInstance)P_0).Uid;
	}

	internal static object d0KeJ3OT9H8BKEvbTWg()
	{
		return UserManager.Instance;
	}

	internal static object Vow6DxOQywK1UKucXTj(object P_0)
	{
		return ((ITaskBase)P_0).Executor;
	}

	internal static object VRUoc1Op9gxYwtQE8c8()
	{
		return GetSystemUser();
	}

	internal static object nhXc8SOCBsSxqJabh9D(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object coBfU0OMKLJIWw5m38H(object P_0)
	{
		return ((IWorkflowInstance)P_0).Initiator;
	}

	internal static void njeE8EOkQcoX0jsuoBR(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int cLGSowOU36vPixaT3EK(object P_0)
	{
		return ((Set<IOrganizationItem>)P_0).get_Count();
	}

	internal static object OW3ug6OVKAjg5JocqBu(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}
}
