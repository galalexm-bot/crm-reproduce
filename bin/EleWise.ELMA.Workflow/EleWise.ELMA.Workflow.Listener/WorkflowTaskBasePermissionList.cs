using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowTaskBasePermissionListener : EntityEventsListener
{
	internal const string insertRoleTypeEnKey = "EleWise.ELMA.Workflow.Listeners.WorkflowTaskBasePermissionListener.insertCommonRoleTypeEnKey";

	internal const string deleteRoleTypeEnKey = "EleWise.ELMA.Workflow.Listeners.WorkflowTaskBasePermissionListener.deleteCommonRoleTypeEnKey";

	internal const string insertWorkflowRoleTypeEnKey = "EleWise.ELMA.Workflow.Listeners.WorkflowTaskBasePermissionListener.insertWorkflowRoleTypeEnKey";

	internal const string deleteWorkflowRoleTypeEnKey = "EleWise.ELMA.Workflow.Listeners.WorkflowTaskBasePermissionListener.deleteWorkflowRoleTypeEnKey";

	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly ITransformationProvider transformationProvider;

	internal static WorkflowTaskBasePermissionListener aZy6KJ6Idnl9QwP0ttw;

	public WorkflowTaskBasePermissionListener(IContextBoundVariableService contextBoundVariableService, ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.transformationProvider = transformationProvider;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.contextBoundVariableService = contextBoundVariableService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_009a, IL_00a9
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (IsAddTaskPermissionEnabled())
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 0:
				return;
			case 3:
				return;
			case 1:
				UpdateTaskBasePermissionInCache((AbstractPostDatabaseOperationEvent)(object)@event, (string)TB6KOF6efVGJcZ83qmK(-961162596 ^ -961188510), (string)TB6KOF6efVGJcZ83qmK(-949717965 ^ -949701495));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				UpdateResponsibleForInstancePermission(@event);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return false;
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
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
				UpdateTaskBasePermissionInCache((AbstractPostDatabaseOperationEvent)(object)@event, (string)TB6KOF6efVGJcZ83qmK(--1212129906 ^ 0x483F6308), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393949692));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
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
				UpdateProcessInstanceMemberPermission(@event);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void UpdateTaskBasePermissionInCache(AbstractPostDatabaseOperationEvent @event, string roleTypeEnKey, string workflowRoleTypeEnKey)
	{
		//Discarded unreachable code: IL_0099, IL_00a8, IL_00b9, IL_00c3, IL_00d3, IL_00dd, IL_00ec, IL_0136, IL_0145, IL_017b, IL_025d, IL_026c, IL_02ac, IL_02bc, IL_02dd, IL_02e8, IL_0302, IL_0383
		int num = 4;
		Guid? permissionRole = default(Guid?);
		IProcessHeaderAccess processHeaderAccess = default(IProcessHeaderAccess);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					permissionRole = processHeaderAccess.PermissionRole;
					num2 = 25;
					continue;
				case 13:
					return;
				case 11:
					return;
				case 25:
					guid = Rx8evQ61ihxZpj07yQK(CommonRoleTypes.OrganizationItem);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
				case 23:
					permissionRole = processHeaderAccess.PermissionRole;
					num2 = 22;
					continue;
				case 1:
					return;
				case 18:
					permissionRole = processHeaderAccess.PermissionRole;
					num2 = 21;
					continue;
				case 10:
					if (permissionRole.HasValue)
					{
						num2 = 15;
						continue;
					}
					goto default;
				case 12:
					if (processHeaderAccess == null)
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 19;
				case 6:
					return;
				case 3:
					processHeaderAccess = acUrTk6NqgtSdXYVKsA(@event) as IProcessHeaderAccess;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 12;
					}
					continue;
				default:
					AddPermissionsToCache(processHeaderAccess, roleTypeEnKey);
					num2 = 26;
					continue;
				case 8:
					if (permissionRole.HasValue)
					{
						if (!permissionRole.HasValue)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						if (!jv4D396hpaOV68YG5Px(permissionRole.GetValueOrDefault(), guid))
						{
							break;
						}
						goto default;
					}
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 3;
					}
					continue;
				case 26:
					return;
				case 29:
					AddPermissionsToCache(processHeaderAccess, workflowRoleTypeEnKey);
					num2 = 13;
					continue;
				case 9:
					if (!permissionRole.HasValue)
					{
						num2 = 2;
						continue;
					}
					if (!jv4D396hpaOV68YG5Px(permissionRole.GetValueOrDefault(), guid))
					{
						goto case 7;
					}
					goto case 2;
				case 20:
					if (permissionRole.HasValue)
					{
						goto end_IL_0012;
					}
					goto case 16;
				case 28:
					if (permissionRole.HasValue)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 4:
					if (@event == null)
					{
						return;
					}
					num2 = 3;
					continue;
				case 19:
					if (dbTmtf6SmT8CuZe5A6E(processHeaderAccess.PermissionId, m2GgFU6xeYLn9yEIKoo(WorkflowPermissionProvider.ViewTaskListOfInstance)))
					{
						return;
					}
					num2 = 18;
					continue;
				case 21:
					guid = Rx8evQ61ihxZpj07yQK(CommonRoleTypes.User);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 28;
					}
					continue;
				case 22:
					guid = Rx8evQ61ihxZpj07yQK(CommonRoleTypes.Group);
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					num2 = 17;
					continue;
				case 15:
					if (jv4D396hpaOV68YG5Px(permissionRole.GetValueOrDefault(), guid))
					{
						goto default;
					}
					goto case 16;
				case 16:
					num2 = 5;
					continue;
				case 27:
					break;
				}
				num2 = 29;
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	private void AddPermissionsToCache(IProcessHeaderAccess processHeaderAccess, string cacheKey)
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
				contextBoundVariableService.GetOrAdd(cacheKey, () => new HashSet<IProcessHeaderAccess>()).Add(processHeaderAccess);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void UpdateResponsibleForInstancePermission(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0101, IL_01cc, IL_02b1, IL_02c0, IL_02cf, IL_0348, IL_0357
		int num = 18;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		string value2 = default(string);
		IPropertyExpressionDescriptor propertyExpressionDescriptor = default(IPropertyExpressionDescriptor);
		int num3 = default(int);
		ParameterExpression parameterExpression = default(ParameterExpression);
		string value = default(string);
		string sql = default(string);
		long num4 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (KjmdqsqZj77iC2t2eQW(@event) == null)
					{
						num2 = 3;
						break;
					}
					goto case 10;
				case 9:
					if (workflowInstance != null)
					{
						num2 = 4;
						break;
					}
					return;
				case 7:
					value2 = string.Format((string)TB6KOF6efVGJcZ83qmK(-1514166050 ^ -1514193526), fOMmqnqlSfbwp0LmfDt(propertyExpressionDescriptor), ll8hrFq00xP1AoXlZeV(workflowInstance));
					num2 = 21;
					break;
				case 2:
					return;
				case 17:
					workflowInstance = f7i7PP6EMohdjHuvWua(@event) as IWorkflowInstance;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
					{
						num2 = 9;
					}
					break;
				case 10:
					if (((object[])YZWa0GqvBEiPgtjGasW(@event))[num3] == ((object[])KjmdqsqZj77iC2t2eQW(@event))[num3])
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num2 = 19;
						}
						break;
					}
					goto case 3;
				case 11:
					return;
				case 16:
					parameterExpression = (ParameterExpression)srZFfe64ZMPlj81cNOQ(U2wmNr6woqjMpKLJc3I(typeof(IWorkflowInstance).TypeHandle), TB6KOF6efVGJcZ83qmK(0x101D10F ^ 0x10188F3));
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 2;
					}
					break;
				case 13:
					return;
				case 14:
					return;
				case 5:
					num3 = Array.IndexOf((string[])FbeqelqOLECfcFjHbda(dYORdtqKpdYE1LryrfW(@event)), value);
					num2 = 6;
					break;
				case 20:
					return;
				case 4:
					if (!IsAddTaskPermissionEnabled())
					{
						return;
					}
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001919082), TuWyNTqbTtDUtRtK4LJ(iGUvnqqtmV6DveIBTSb(transformationProvider), TB6KOF6efVGJcZ83qmK(-1361036319 ^ -1360986179)), TuWyNTqbTtDUtRtK4LJ(transformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360651471)), ((Dialect)iGUvnqqtmV6DveIBTSb(transformationProvider)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351387078)), transformationProvider.ParameterSeparator);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 0;
					}
					break;
				case 18:
					if (@event == null)
					{
						return;
					}
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 6;
					}
					break;
				case 21:
					num4 = YrN1XFqmMYY6vmZUVlS(((IEntity<long>)RH8B66qyIxuAye9J6wf(workflowInstance)).Id);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 1;
					}
					break;
				case 12:
					if (propertyExpressionDescriptor == null)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 19:
					return;
				case 3:
					if (!HasProcessHeaderAccess((IProcessHeader)uaJ8thq8pSxnLVZyRxN(H4VI8bqYwQ6K23rAlPt(workflowInstance)), WorkflowRoleTypes.ResponsibleForInstance))
					{
						return;
					}
					num2 = 8;
					break;
				default:
					transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>
					{
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213FA0C3),
							workflowInstance.Responsible.Id
						},
						{
							(string)TB6KOF6efVGJcZ83qmK(-768800937 ^ -768752763),
							num4
						},
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB24E26),
							value2
						}
					});
					num2 = 13;
					break;
				case 15:
					value = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Property(parameterExpression, (MethodInfo)zt2PNL6z4NCTgW0FBmn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 5;
					break;
				case 8:
					propertyExpressionDescriptor = ((IEnumerable<IPropertyExpressionDescriptor>)J1PntUqJqUBxfT4NerF(((ComponentManager)eruqA1qs6GHWrVSgUpi()).GetExtensionPointByType<WorkflowTaskPermissionProvider>())).FirstOrDefault((IPropertyExpressionDescriptor x) => _003C_003Ec.rUrJNuZVYq2ZtSacENBA(_003C_003Ec.mNGcYCZVvFIGeBh4JCOd(_003C_003Ec.S4crZUZVZiVx6Hq3im9g(x as IPropertyExpressionDescriptorWithInstanceUid)), _003C_003Ec.mNGcYCZVvFIGeBh4JCOd(WorkflowRoleTypes.ResponsibleForInstance)));
					num2 = 12;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	private void UpdateProcessInstanceMemberPermission(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_0302, IL_05a9, IL_05b8, IL_062a, IL_0639, IL_0648, IL_06bd, IL_06cc, IL_06dc, IL_079e, IL_082e, IL_083d
		int num = 46;
		string text = default(string);
		IPropertyExpressionDescriptor propertyExpressionDescriptor2 = default(IPropertyExpressionDescriptor);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		int num3 = default(int);
		long num5 = default(long);
		IWorkflowInstanceMember workflowInstanceMember = default(IWorkflowInstanceMember);
		IPropertyExpressionDescriptor propertyExpressionDescriptor = default(IPropertyExpressionDescriptor);
		string text2 = default(string);
		IWorkflowInstanceMember[] array3 = default(IWorkflowInstanceMember[]);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		IWorkflowInstanceMember[] array2 = default(IWorkflowInstanceMember[]);
		string sql = default(string);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		string value = default(string);
		_003C_003Ec__DisplayClass14_1 _003C_003Ec__DisplayClass14_2 = default(_003C_003Ec__DisplayClass14_1);
		IWorkflowInstanceMember[] array = default(IWorkflowInstanceMember[]);
		int num4 = default(int);
		CollectionEntry val = default(CollectionEntry);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					text = (string)qZ1OwhqdM5gnsld5JVM(TB6KOF6efVGJcZ83qmK(-949717965 ^ -949690009), fOMmqnqlSfbwp0LmfDt(propertyExpressionDescriptor2), workflowInstance.Uid);
					num2 = 10;
					continue;
				case 16:
					num3 = 0;
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					num5 = YrN1XFqmMYY6vmZUVlS(((IEntity<long>)H7Z8ZZqnYOMmhkeX9gN(workflowInstanceMember)).Id);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 25;
					}
					continue;
				case 29:
					if (propertyExpressionDescriptor2 != null)
					{
						num2 = 18;
						continue;
					}
					return;
				case 47:
					if (propertyExpressionDescriptor == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 42;
				default:
					text2 = string.Join((string)TB6KOF6efVGJcZ83qmK(--296112178 ^ 0x11A6CA30), array3.Select(_003C_003Ec__DisplayClass14_._003CUpdateProcessInstanceMemberPermission_003Eb__3));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 14;
					}
					continue;
				case 20:
				case 37:
					if (num3 < array2.Length)
					{
						num2 = 43;
						continue;
					}
					return;
				case 7:
					sql = (string)nCpFqPqD4S02kHPDPrl(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261332855), new object[5]
					{
						((Dialect)iGUvnqqtmV6DveIBTSb(transformationProvider)).QuoteIfNeeded((string)TB6KOF6efVGJcZ83qmK(0x361628FF ^ 0x3616ECA3)),
						TuWyNTqbTtDUtRtK4LJ(iGUvnqqtmV6DveIBTSb(transformationProvider), TB6KOF6efVGJcZ83qmK(0x361628FF ^ 0x3616ED11)),
						text2,
						uIw7Rkqu9M9AmHNmrei(transformationProvider),
						TuWyNTqbTtDUtRtK4LJ(transformationProvider.Dialect, TB6KOF6efVGJcZ83qmK(0x5BCD23A0 ^ 0x5BCD7D28))
					});
					num2 = 33;
					continue;
				case 14:
					dictionary = new Dictionary<string, object> { 
					{
						(string)TB6KOF6efVGJcZ83qmK(-452127399 ^ -452079187),
						value
					} };
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 6;
					}
					continue;
				case 33:
					transformationProvider.ExecuteNonQuery(sql, dictionary);
					num2 = 24;
					continue;
				case 25:
					transformationProvider.Insert((string)TB6KOF6efVGJcZ83qmK(-1393899982 ^ -1393950098), new string[6]
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895837091),
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885110153),
						(string)TB6KOF6efVGJcZ83qmK(0x65B7F624 ^ 0x65B7A8AC),
						(string)TB6KOF6efVGJcZ83qmK(-11799394 ^ -11849360),
						(string)TB6KOF6efVGJcZ83qmK(0x6CC04061 ^ 0x6CC08673),
						(string)TB6KOF6efVGJcZ83qmK(--1436248540 ^ 0x559BAD58)
					}, string.Format((string)TB6KOF6efVGJcZ83qmK(0x5F534A5C ^ 0x5F538C76), SRefdeqH3avbgmiWqv1(iGUvnqqtmV6DveIBTSb(transformationProvider)), ((IEntity<long>)H7Z8ZZqnYOMmhkeX9gN(workflowInstanceMember)).Id, text, num5), (string)nCpFqPqD4S02kHPDPrl(TB6KOF6efVGJcZ83qmK(0xF400DF8 ^ 0xF40CAE4), new object[6]
					{
						TuWyNTqbTtDUtRtK4LJ(iGUvnqqtmV6DveIBTSb(transformationProvider), TB6KOF6efVGJcZ83qmK(0x17F0C5A2 ^ 0x17F08324)),
						TuWyNTqbTtDUtRtK4LJ(transformationProvider.Dialect, TB6KOF6efVGJcZ83qmK(-1516552726 ^ -1516506076)),
						((Dialect)iGUvnqqtmV6DveIBTSb(transformationProvider)).QuoteIfNeeded((string)TB6KOF6efVGJcZ83qmK(0x6F6D7B44 ^ 0x6F6D117E)),
						TuWyNTqbTtDUtRtK4LJ(transformationProvider.Dialect, TB6KOF6efVGJcZ83qmK(--1436248540 ^ 0x559B3176)),
						TuWyNTqbTtDUtRtK4LJ(iGUvnqqtmV6DveIBTSb(transformationProvider), TB6KOF6efVGJcZ83qmK(-682910880 ^ -682914844)),
						transformationProvider.ParameterSeparator
					}), isNeedInsertId: true, new Dictionary<string, object> { 
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122729795),
						workflowInstance.Id
					} });
					num2 = 17;
					continue;
				case 36:
					return;
				case 2:
					if (HasProcessHeaderAccess((IProcessHeader)uaJ8thq8pSxnLVZyRxN(H4VI8bqYwQ6K23rAlPt(workflowInstance)), WorkflowRoleTypes.ProcessInstanceMember))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
						{
							num2 = 12;
						}
						continue;
					}
					return;
				case 32:
					array3 = _003C_003Ec__DisplayClass14_2.oldWorkflowInstanceMembers.Where(_003C_003Ec__DisplayClass14_._003CUpdateProcessInstanceMemberPermission_003Eb__0).ToArray();
					num2 = 26;
					continue;
				case 41:
				case 43:
					workflowInstanceMember = array2[num3];
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 2;
					}
					continue;
				case 42:
					value = (string)qZ1OwhqdM5gnsld5JVM(TB6KOF6efVGJcZ83qmK(-980570076 ^ -980605584), fOMmqnqlSfbwp0LmfDt(propertyExpressionDescriptor), ll8hrFq00xP1AoXlZeV(workflowInstance));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return;
				case 4:
					workflowInstance = bqjuSWqgJXePR6DOYPG(@event) as IWorkflowInstance;
					num2 = 38;
					continue;
				case 19:
					return;
				case 46:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 45;
					continue;
				case 10:
					array2 = array;
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 5;
					}
					continue;
				case 40:
					if (!IsAddTaskPermissionEnabled())
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 21;
				case 6:
					num4 = 0;
					num = 11;
					break;
				case 3:
					if (_003C_003Ec__DisplayClass14_.newWorkflowInstanceMembers == null)
					{
						return;
					}
					num2 = 4;
					continue;
				case 11:
				case 44:
					if (num4 < array3.Length)
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				case 34:
					if (array3.Length != 0)
					{
						num2 = 22;
						continue;
					}
					goto case 1;
				case 5:
					return;
				case 30:
					return;
				case 13:
					if (@event != null)
					{
						num2 = 27;
						continue;
					}
					return;
				case 45:
					_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num2 = 3;
					}
					continue;
				case 39:
					_003C_003Ec__DisplayClass14_2.oldWorkflowInstanceMembers = qoUsq1qXWAEJr1cHWmP(val) as IEnumerable<IWorkflowInstanceMember>;
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 10;
					}
					continue;
				case 1:
				case 24:
					if (array.Length == 0)
					{
						num = 19;
						break;
					}
					goto case 40;
				case 26:
					array = _003C_003Ec__DisplayClass14_.newWorkflowInstanceMembers.Where(_003C_003Ec__DisplayClass14_2._003CUpdateProcessInstanceMemberPermission_003Eb__1).ToArray();
					num2 = 34;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
				case 15:
					dictionary.Add(string.Concat(TB6KOF6efVGJcZ83qmK(0x46EA3D1 ^ 0x46EFD9B), num4), array3[num4].User.Id);
					num2 = 31;
					continue;
				case 23:
					return;
				case 27:
					_003C_003Ec__DisplayClass14_.newWorkflowInstanceMembers = rtKFAGq5DAP9olERqHD(@event) as IEnumerable<IWorkflowInstanceMember>;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 3;
					}
					continue;
				case 35:
					val = (CollectionEntry)S9EQxZqPDLnkpeHQ5ud(YGElTiqcH5DZtvLpgi5(NN6pUVqBcNLVPaZn14V(@event)), rtKFAGq5DAP9olERqHD(@event));
					num2 = 39;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
					{
						num2 = 17;
					}
					continue;
				case 12:
					_003C_003Ec__DisplayClass14_2 = new _003C_003Ec__DisplayClass14_1();
					num2 = 35;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 31;
					}
					continue;
				case 38:
					if (workflowInstance == null)
					{
						return;
					}
					num2 = 2;
					continue;
				case 31:
					num4++;
					num2 = 44;
					continue;
				case 17:
					num3++;
					num2 = 37;
					continue;
				case 22:
					propertyExpressionDescriptor = ((IEnumerable<IPropertyExpressionDescriptor>)J1PntUqJqUBxfT4NerF(((ComponentManager)eruqA1qs6GHWrVSgUpi()).GetExtensionPointByType<WorkflowTaskPermissionProvider>())).FirstOrDefault((IPropertyExpressionDescriptor x) => _003C_003Ec.rUrJNuZVYq2ZtSacENBA(_003C_003Ec.mNGcYCZVvFIGeBh4JCOd(_003C_003Ec.S4crZUZVZiVx6Hq3im9g(x as IPropertyExpressionDescriptorWithInstanceUid)), WorkflowRoleTypes.ProcessInstanceMember.Id));
					num2 = 47;
					continue;
				case 21:
					propertyExpressionDescriptor2 = ((IEnumerable<IPropertyExpressionDescriptor>)J1PntUqJqUBxfT4NerF(ComponentManager.Current.GetExtensionPointByType<WorkflowTaskPermissionProvider>())).FirstOrDefault((IPropertyExpressionDescriptor x) => _003C_003Ec.mNGcYCZVvFIGeBh4JCOd(_003C_003Ec.S4crZUZVZiVx6Hq3im9g(x as IPropertyExpressionDescriptorWithInstanceUid)) == _003C_003Ec.mNGcYCZVvFIGeBh4JCOd(WorkflowRoleTypes.ProcessInstanceMember));
					num = 29;
					break;
				}
				break;
			}
		}
	}

	private bool HasProcessHeaderAccess(IProcessHeader header, PermissionRoleType roleType)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass15_.header = header;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass15_.roleType = roleType;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				IEntityManager<IProcessHeaderAccess> instance = EntityManager<IProcessHeaderAccess>.Instance;
				ParameterExpression parameterExpression = (ParameterExpression)srZFfe64ZMPlj81cNOQ(U2wmNr6woqjMpKLJc3I(typeof(IProcessHeaderAccess).TypeHandle), TB6KOF6efVGJcZ83qmK(0x350C0E8 ^ 0x3500AE2));
				return instance.Find(Expression.Lambda<Func<IProcessHeaderAccess, bool>>((Expression)CI2TLpqjFtv2KrkVMpM(YB98egq9sng5Pq5SWcP(Expression.Property(parameterExpression, (MethodInfo)zt2PNL6z4NCTgW0FBmn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), x3uQu9qfif2vQsFknGo(nuYvHoqLHXMlundJhJs(_003C_003Ec__DisplayClass15_, U2wmNr6woqjMpKLJc3I(typeof(_003C_003Ec__DisplayClass15_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), toNZmKqWGuwiqCV9yaG(Expression.Property(parameterExpression, (MethodInfo)zt2PNL6z4NCTgW0FBmn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Field(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)zt2PNL6z4NCTgW0FBmn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)zt2PNL6z4NCTgW0FBmn((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).Any(_003C_003Ec__DisplayClass15_._003CHasProcessHeaderAccess_003Eb__1);
			}
			}
		}
	}

	private bool IsAddTaskPermissionEnabled()
	{
		return SR.GetSetting((string)TB6KOF6efVGJcZ83qmK(-801808857 ^ -801810127), defaultValue: false);
	}

	internal static bool KwwXNC6aEJEZm5vhG04()
	{
		return aZy6KJ6Idnl9QwP0ttw == null;
	}

	internal static WorkflowTaskBasePermissionListener Y0a0Cu6r79oigJrAU55()
	{
		return aZy6KJ6Idnl9QwP0ttw;
	}

	internal static object TB6KOF6efVGJcZ83qmK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object acUrTk6NqgtSdXYVKsA(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static Guid m2GgFU6xeYLn9yEIKoo(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool dbTmtf6SmT8CuZe5A6E(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid Rx8evQ61ihxZpj07yQK(object P_0)
	{
		return ((PermissionRoleType)P_0).Id;
	}

	internal static bool jv4D396hpaOV68YG5Px(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object f7i7PP6EMohdjHuvWua(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static Type U2wmNr6woqjMpKLJc3I(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object srZFfe64ZMPlj81cNOQ(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object zt2PNL6z4NCTgW0FBmn(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object dYORdtqKpdYE1LryrfW(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object FbeqelqOLECfcFjHbda(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object KjmdqsqZj77iC2t2eQW(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static object YZWa0GqvBEiPgtjGasW(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_State();
	}

	internal static object H4VI8bqYwQ6K23rAlPt(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object uaJ8thq8pSxnLVZyRxN(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object eruqA1qs6GHWrVSgUpi()
	{
		return ComponentManager.Current;
	}

	internal static object J1PntUqJqUBxfT4NerF(object P_0)
	{
		return ((ExpressionPermissionBase<IWorkflowTaskBase, ITaskBasePermission>)P_0).AccessExpressions;
	}

	internal static object fOMmqnqlSfbwp0LmfDt(object P_0)
	{
		return ((IPropertyExpressionDescriptor)P_0).Name;
	}

	internal static Guid ll8hrFq00xP1AoXlZeV(object P_0)
	{
		return ((IWorkflowInstance)P_0).Uid;
	}

	internal static object RH8B66qyIxuAye9J6wf(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}

	internal static long YrN1XFqmMYY6vmZUVlS(long P_0)
	{
		return UserSecuritySetHelper.GetUserMask(P_0);
	}

	internal static object iGUvnqqtmV6DveIBTSb(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object TuWyNTqbTtDUtRtK4LJ(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object rtKFAGq5DAP9olERqHD(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_Collection();
	}

	internal static object bqjuSWqgJXePR6DOYPG(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_AffectedOwnerOrNull();
	}

	internal static object NN6pUVqBcNLVPaZn14V(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static object YGElTiqcH5DZtvLpgi5(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object S9EQxZqPDLnkpeHQ5ud(object P_0, object P_1)
	{
		return ((IPersistenceContext)P_0).GetCollectionEntry((IPersistentCollection)P_1);
	}

	internal static object qoUsq1qXWAEJr1cHWmP(object P_0)
	{
		return ((CollectionEntry)P_0).get_Snapshot();
	}

	internal static object qZ1OwhqdM5gnsld5JVM(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object uIw7Rkqu9M9AmHNmrei(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object nCpFqPqD4S02kHPDPrl(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object H7Z8ZZqnYOMmhkeX9gN(object P_0)
	{
		return ((IWorkflowInstanceMember)P_0).User;
	}

	internal static object SRefdeqH3avbgmiWqv1(object P_0)
	{
		return ((Dialect)P_0).GenUid();
	}

	internal static object nuYvHoqLHXMlundJhJs(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object x3uQu9qfif2vQsFknGo(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object YB98egq9sng5Pq5SWcP(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object toNZmKqWGuwiqCV9yaG(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static object CI2TLpqjFtv2KrkVMpM(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}
}
