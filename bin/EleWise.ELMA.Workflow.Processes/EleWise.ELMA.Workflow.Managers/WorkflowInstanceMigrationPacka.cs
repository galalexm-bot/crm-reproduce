using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.ChangeProcessVersion;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowInstanceMigrationPackageManager : EntityManager<IWorkflowInstanceMigrationPackage, long>
{
	private class SwimlaneProcessingInfo
	{
		internal static object E8INXBnoObHO7wgtjlx;

		public bool ManualProcessing
		{
			[CompilerGenerated]
			get
			{
				return _003CManualProcessing_003Ek__BackingField;
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
						_003CManualProcessing_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
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

		public List<IChangeProcessVersionAction> Actions { get; set; }

		public SwimlaneProcessingInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			BnNy9Vnx102EVywb3sg();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool vxmy6Wn3bHHKdOyXlAo()
		{
			return E8INXBnoObHO7wgtjlx == null;
		}

		internal static SwimlaneProcessingInfo B1b0Xinh8kI0sYyDuxq()
		{
			return (SwimlaneProcessingInfo)E8INXBnoObHO7wgtjlx;
		}

		internal static void BnNy9Vnx102EVywb3sg()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	private static WorkflowInstanceMigrationPackageManager sB34WsQ09UN6OHS2P9u;

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
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

	public IEntityActionHandler EntityActionHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityActionHandler_003Ek__BackingField;
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
					_003CEntityActionHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 == 0)
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

	public WorkflowInstanceManager WorkflowManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowManager_003Ek__BackingField;
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
					_003CWorkflowManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowInstanceMigrationItemManager WorkflowItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowItemManager_003Ek__BackingField;
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
					_003CWorkflowItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 != 0)
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

	public WorkflowInstanceMigrationItemManager WorkflowMigrationItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMigrationItemManager_003Ek__BackingField;
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
					_003CWorkflowMigrationItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
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

	public new static WorkflowInstanceMigrationPackageManager Instance => Locator.GetServiceNotNull<WorkflowInstanceMigrationPackageManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0070, IL_007f, IL_00b8
		int num = 10;
		IWorkflowInstanceMigrationPackageFilter workflowInstanceMigrationPackageFilter = default(IWorkflowInstanceMigrationPackageFilter);
		bool? isActive = default(bool?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					return;
				case 7:
					return;
				case 10:
					qw8W3fQHjSaC1XrEEmr(this, criteria, filter);
					num2 = 9;
					continue;
				case 6:
					break;
				case 8:
					return;
				case 9:
					workflowInstanceMigrationPackageFilter = filter as IWorkflowInstanceMigrationPackageFilter;
					num2 = 4;
					continue;
				case 5:
					if (!isActive.HasValue)
					{
						num2 = 8;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					if (workflowInstanceMigrationPackageFilter == null)
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 1:
					ywkqH0QltTJmbGvvZYr(criteria, hBdHcyQu0aokXKGeBFH(Restrictions.Eq((string)Y8vIFpQeD9d5sSCx6pt(0xB863F17 ^ 0xB860833), (object)WorkflowInstanceMigrationPackageStatus.New), M7ApkmQiSrku7EmmRc9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CBDA8D5 ^ 0x4CBD9FF1), WorkflowInstanceMigrationPackageStatus.ReOpen)));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 2:
					isActive = workflowInstanceMigrationPackageFilter.IsActive;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					if (!isActive.Value)
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			isActive = workflowInstanceMigrationPackageFilter.IsActive;
			num = 11;
		}
	}

	[Transaction]
	public virtual void ResetStatuses()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				EY63tBQ5ElCsmIpM6Wp(JVvsUxQflwYj17fospG(this), new Type[1] { InterfaceActivator.TypeOf<IWorkflowInstanceMigrationPackage>() });
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				((IQuery)XLZAJnQ7yeOGcRWkCRq(JVvsUxQflwYj17fospG(this), doKkW0Qr1fi8RxQd6Au(Y8vIFpQeD9d5sSCx6pt(0xE108112 ^ 0xE10D3A0), VRJiZ5QJm3R6yEwOwC4(zkOmsuQLWl2BFhjxv6U(TransformationProvider), Y8vIFpQeD9d5sSCx6pt(-769877317 ^ -769865651)), VRJiZ5QJm3R6yEwOwC4(zkOmsuQLWl2BFhjxv6U(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68C900C0 ^ 0x68C937E4))))).SetParameter<WorkflowInstanceMigrationPackageStatus>(0, WorkflowInstanceMigrationPackageStatus.ReOpen).SetParameter<WorkflowInstanceMigrationPackageStatus>(1, WorkflowInstanceMigrationPackageStatus.InProgress).ExecuteUpdate(cleanUpCache: false);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Transaction]
	public virtual IEnumerable<IWorkflowInstanceMigrationPackage> GetPacketsForProccesing(int maxResult)
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x234241C0 ^ 0x234212EE)).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386102027 ^ -1386114675), maxResult).List<IWorkflowInstanceMigrationPackage>();
	}

	[Transaction]
	public virtual IWorkflowInstanceMigrationPackage Create(IEnumerable<IWorkflowInstance> workflowInstances, string packageName, string migrationReason)
	{
		IWorkflowInstanceMigrationPackage workflowInstanceMigrationPackage = Create();
		workflowInstanceMigrationPackage.Name = packageName;
		workflowInstanceMigrationPackage.MigrationReason = migrationReason;
		workflowInstanceMigrationPackage.Status = WorkflowInstanceMigrationPackageStatus.New;
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		foreach (IWorkflowInstance workflowInstance in workflowInstances)
		{
			IWorkflowInstanceMigrationItem workflowInstanceMigrationItem = EntityManager<IWorkflowInstanceMigrationItem>.Create();
			workflowInstanceMigrationItem.Package = workflowInstanceMigrationPackage;
			workflowInstanceMigrationItem.WorkflowInstance = workflowInstance;
			if (workflowInstance.Status != WorkflowInstanceStatus.Running && workflowInstance.Status != 0)
			{
				workflowInstanceMigrationItem.Comment = workflowInstance.Status.GetDisplayName();
				workflowInstanceMigrationItem.IsManualUpdateAvailable = false;
				workflowInstanceMigrationItem.Status = WorkflowInstanceMigrationItemStatus.UpdateIsNotRequired;
			}
			else
			{
				ChangeProcessVersionActionData changeData = new ChangeProcessVersionActionData
				{
					Reason = "",
					Instance = workflowInstance,
					NewProcess = workflowInstance.Process.Header.Published,
					User = currentUser
				};
				if (!WorkflowManager.CanChangeVersion(changeData))
				{
					workflowInstanceMigrationItem.Comment = WorkflowInstanceMigrationItemStatus.UpdateIsNotRequired.GetDisplayName();
					workflowInstanceMigrationItem.IsManualUpdateAvailable = false;
					workflowInstanceMigrationItem.Status = WorkflowInstanceMigrationItemStatus.UpdateIsNotRequired;
				}
				workflowInstanceMigrationItem.Status = WorkflowInstanceMigrationItemStatus.New;
			}
			workflowInstanceMigrationPackage.Items.Add(workflowInstanceMigrationItem);
		}
		workflowInstanceMigrationPackage.Save();
		return workflowInstanceMigrationPackage;
	}

	[Transaction]
	public virtual void ProcessMigrationErrors(IWorkflowInstanceMigrationPackage package)
	{
		int num = 2;
		int num2 = num;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				TJ0rKOQ171C7JcOe08Z(EntityActionHandler, entityActionEventArgs);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				entityActionEventArgs = new EntityActionEventArgs(null, package, p6jILwQgNjX3XANBmOy());
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void ProcessMigrationSuccess(IWorkflowInstanceMigrationPackage package)
	{
		int num = 1;
		int num2 = num;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				TJ0rKOQ171C7JcOe08Z(EntityActionHandler, entityActionEventArgs);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				entityActionEventArgs = new EntityActionEventArgs(null, package, o7ZjGZQIe4lby9ZuSYk());
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private SwimlaneProcessingInfo SwimlaneProcess(SwimlaneChangeInfo swimlane, IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0083, IL_00c9, IL_00dc, IL_00eb, IL_0111
		int num = 2;
		SwimlaneProcessingInfo swimlaneProcessingInfo = default(SwimlaneProcessingInfo);
		ChangeProcessVersionRemoveSwimlaneBindingAction item = default(ChangeProcessVersionRemoveSwimlaneBindingAction);
		Func<SwimlaneElement, IWorkflowInstance, IUser> func2 = default(Func<SwimlaneElement, IWorkflowInstance, IUser>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Func<SwimlaneElement, IWorkflowInstance, IUser> func;
				switch (num2)
				{
				case 9:
					e3I4ZHQZOBKlUXfLjOD(swimlaneProcessingInfo, false);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (swimlane.OldSwimlane == null)
					{
						num2 = 6;
						continue;
					}
					goto case 5;
				case 6:
				case 10:
					e3I4ZHQZOBKlUXfLjOD(swimlaneProcessingInfo, false);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					if (((Array)SyP5hyQzs4UCnEQ8Pem(swimlane)).Length != 0)
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				case 1:
					func = _003C_003Ec._003C_003E9__29_0;
					if (func == null)
					{
						num2 = 13;
						continue;
					}
					break;
				default:
					item = new ChangeProcessVersionRemoveSwimlaneBindingAction(instance, ((Element)iDBY2FVCu8qvAj7nDft(swimlane)).Uid);
					num2 = 8;
					continue;
				case 2:
				{
					SwimlaneProcessingInfo swimlaneProcessingInfo2 = new SwimlaneProcessingInfo();
					e3I4ZHQZOBKlUXfLjOD(swimlaneProcessingInfo2, true);
					swimlaneProcessingInfo2.Actions = new List<IChangeProcessVersionAction>();
					swimlaneProcessingInfo = swimlaneProcessingInfo2;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 15:
					if (func2((SwimlaneElement)iDBY2FVCu8qvAj7nDft(swimlane), instance) != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 9;
				case 8:
					swimlaneProcessingInfo.Actions.Add(item);
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					if (q16FQWVEHN2AmjVQJfu(swimlane) != null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 3:
				case 4:
				case 12:
				case 14:
					return swimlaneProcessingInfo;
				case 13:
					func = (_003C_003Ec._003C_003E9__29_0 = delegate(SwimlaneElement swimlaneElement, IWorkflowInstance wfInstance)
					{
						//Discarded unreachable code: IL_0169, IL_0178, IL_0187, IL_0197, IL_01a6
						int num3 = 6;
						int num4 = num3;
						IWorkflowSwimlaneExecutor workflowSwimlaneExecutor = default(IWorkflowSwimlaneExecutor);
						_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
						IUser user = default(IUser);
						while (true)
						{
							switch (num4)
							{
							case 9:
								return null;
							case 4:
								return (IUser)_003C_003Ec.QJSshEnYGguenOZvipI(workflowSwimlaneExecutor);
							case 5:
								_003C_003Ec__DisplayClass29_.swimlaneElement = swimlaneElement;
								num4 = 2;
								break;
							case 3:
								if (user == null)
								{
									num4 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 10;
							case 10:
								return user;
							default:
								workflowSwimlaneExecutor = ((IEnumerable<IWorkflowSwimlaneExecutor>)wfInstance.SwimlaneExecutors).FirstOrDefault(_003C_003Ec__DisplayClass29_._003CSwimlaneProcess_003Eb__1);
								num4 = 8;
								break;
							case 12:
								user = ((Entity<long>)_003C_003Ec.K5ffE7nan2nZLvLxUV4(wfInstance)).GetPropertyValue<IUser>(_003C_003Ec.cfEKv8nKXGghpJRhVAM(_003C_003Ec__DisplayClass29_.swimlaneElement));
								num4 = 3;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
								{
									num4 = 3;
								}
								break;
							case 11:
								if (_003C_003Ec.V4XiivnMllLwjXnBLXx(_003C_003Ec.cfEKv8nKXGghpJRhVAM(_003C_003Ec__DisplayClass29_.swimlaneElement), Guid.Empty))
								{
									num4 = 12;
									break;
								}
								goto case 3;
							case 8:
								if (workflowSwimlaneExecutor != null)
								{
									num4 = 4;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
									{
										num4 = 4;
									}
									break;
								}
								goto case 9;
							case 6:
								_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
								num4 = 5;
								break;
							case 2:
								if (_003C_003Ec__DisplayClass29_.swimlaneElement != null)
								{
									num4 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
									{
										num4 = 1;
									}
									break;
								}
								goto case 7;
							case 7:
								return null;
							case 1:
								user = null;
								num4 = 11;
								break;
							}
						}
					});
					break;
				}
				func2 = func;
				num2 = 11;
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	[Transaction]
	public virtual void ChangeStatus(IWorkflowInstanceMigrationPackage package, WorkflowInstanceMigrationPackageStatus status)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					if (package != null)
					{
						num2 = 3;
						continue;
					}
					return;
				case 1:
					return;
				case 3:
					break;
				case 2:
					QvvS3uVXRKIJn2RuZZ3(package);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			package.Status = status;
			num = 2;
		}
	}

	public virtual void StartMigration(IWorkflowInstanceMigrationPackage package)
	{
		//Discarded unreachable code: IL_0057, IL_0066, IL_0071, IL_01d2, IL_0262, IL_02e7, IL_0392, IL_03a1, IL_03ac, IL_0447, IL_045a, IL_0469, IL_0499, IL_04d1, IL_0531, IL_0540, IL_0582, IL_05cd, IL_062f, IL_06cf, IL_0769, IL_0778, IL_07a9, IL_07e1, IL_086d, IL_087c
		int num = 7;
		IEnumerator<IWorkflowInstanceMigrationItem> enumerator = default(IEnumerator<IWorkflowInstanceMigrationItem>);
		IWorkflowInstanceMigrationItem current = default(IWorkflowInstanceMigrationItem);
		bool flag = default(bool);
		bool flag2 = default(bool);
		ChangeProcessVersionValidationResult changeProcessVersionValidationResult = default(ChangeProcessVersionValidationResult);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		IEnumerator<SwimlaneChangeInfo> enumerator2 = default(IEnumerator<SwimlaneChangeInfo>);
		SwimlaneProcessingInfo swimlaneProcessingInfo = default(SwimlaneProcessingInfo);
		List<IChangeProcessVersionAction>.Enumerator enumerator3 = default(List<IChangeProcessVersionAction>.Enumerator);
		SwimlaneChangeInfo current3 = default(SwimlaneChangeInfo);
		ChangeProcessVersionActionData changeProcessVersionActionData2 = default(ChangeProcessVersionActionData);
		IChangeProcessVersionAction current2 = default(IChangeProcessVersionAction);
		WorkflowInstanceMigrationItemStatus workflowInstanceMigrationItemStatus = default(WorkflowInstanceMigrationItemStatus);
		string text = default(string);
		IUser currentUser = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					return;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!OYxJtEVVNgZMXnaP6Jr(enumerator))
							{
								num3 = 3;
								goto IL_0075;
							}
							goto IL_008f;
							IL_0075:
							switch (num3)
							{
							case 1:
								break;
							default:
								continue;
							case 2:
								try
								{
									WorkflowInstanceMigrationItemStatus? status = current.Status;
									int num4 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										case 19:
											flag = true;
											num4 = 9;
											continue;
										case 5:
										case 6:
											flag = true;
											num4 = 10;
											continue;
										case 9:
											WorkflowMigrationItemManager.ChangeStatus(current, WorkflowInstanceMigrationItemStatus.UnSatisfied);
											num4 = 21;
											continue;
										case 8:
											flag2 = false;
											num4 = 20;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
											{
												num4 = 2;
											}
											continue;
										case 28:
											changeProcessVersionValidationResult = WorkflowManager.ValidateChangeProcessVersion(workflowInstance, workflowProcess);
											num4 = 12;
											continue;
										case 29:
											break;
										case 14:
											enumerator2 = changeProcessVersionValidationResult.ChangedSwimlanes.GetEnumerator();
											num4 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
											{
												num4 = 3;
											}
											continue;
										case 25:
											if (txnePAVqai0d7eN67nq(changeProcessVersionValidationResult.ChangedSwimlanes) > 0)
											{
												num4 = 14;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
												{
													num4 = 13;
												}
												continue;
											}
											goto case 16;
										case 20:
											flag = true;
											num4 = 7;
											continue;
										case 26:
										{
											x3ncIiV3yJYSBYF6Tho(WorkflowItemManager, current);
											int num10 = 4;
											num4 = num10;
											continue;
										}
										case 3:
											try
											{
												while (true)
												{
													int num5;
													if (!OYxJtEVVNgZMXnaP6Jr(enumerator2))
													{
														num5 = 6;
														goto IL_0270;
													}
													goto IL_035c;
													IL_0270:
													while (true)
													{
														switch (num5)
														{
														case 5:
															break;
														case 9:
															if (!aNNvMMVQJYm52CHF94b(swimlaneProcessingInfo))
															{
																num5 = 0;
																if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
																{
																	num5 = 0;
																}
																continue;
															}
															goto case 3;
														case 2:
														{
															WorkflowMigrationItemManager.ChangeStatus(current, WorkflowInstanceMigrationItemStatus.ManualProcessingRequired);
															int num8 = 7;
															num5 = num8;
															continue;
														}
														default:
															enumerator3 = swimlaneProcessingInfo.Actions.GetEnumerator();
															num5 = 7;
															if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
															{
																num5 = 8;
															}
															continue;
														case 1:
															swimlaneProcessingInfo = SwimlaneProcess(current3, workflowInstance);
															num5 = 9;
															if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
															{
																num5 = 2;
															}
															continue;
														case 10:
															goto IL_035c;
														case 3:
															flag2 = false;
															num5 = 2;
															continue;
														case 8:
															try
															{
																while (true)
																{
																	IL_0405:
																	int num6;
																	if (!enumerator3.MoveNext())
																	{
																		num6 = 2;
																		goto IL_03b0;
																	}
																	goto IL_03ca;
																	IL_03b0:
																	while (true)
																	{
																		switch (num6)
																		{
																		case 3:
																			changeProcessVersionActionData2.Actions.Add(current2);
																			num6 = 1;
																			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
																			{
																				num6 = 1;
																			}
																			continue;
																		case 1:
																			goto IL_0405;
																		case 2:
																			goto end_IL_0405;
																		}
																		break;
																	}
																	goto IL_03ca;
																	IL_03ca:
																	current2 = enumerator3.Current;
																	num6 = 3;
																	goto IL_03b0;
																	continue;
																	end_IL_0405:
																	break;
																}
															}
															finally
															{
																((IDisposable)enumerator3).Dispose();
																int num7 = 0;
																if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
																{
																	num7 = 0;
																}
																switch (num7)
																{
																case 0:
																	break;
																}
															}
															break;
														case 7:
															goto end_IL_02a6;
														case 6:
															goto end_IL_02a6;
														}
														break;
													}
													continue;
													IL_035c:
													current3 = enumerator2.Current;
													num5 = 1;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 != 0)
													{
														num5 = 0;
													}
													goto IL_0270;
													continue;
													end_IL_02a6:
													break;
												}
											}
											finally
											{
												if (enumerator2 != null)
												{
													int num9 = 0;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
													{
														num9 = 0;
													}
													while (true)
													{
														switch (num9)
														{
														default:
															QSD2jCVDvp1S1asfswC(enumerator2);
															num9 = 1;
															if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
															{
																num9 = 1;
															}
															continue;
														case 1:
															break;
														}
														break;
													}
												}
											}
											goto case 16;
										case 18:
											workflowInstance = current.WorkflowInstance;
											num4 = 22;
											continue;
										case 2:
											if (!MdtOLSVsInbFWRkAgv0(WorkflowManager, changeProcessVersionActionData2))
											{
												num4 = 23;
												continue;
											}
											goto case 27;
										case 11:
											if (status != workflowInstanceMigrationItemStatus)
											{
												num4 = 13;
												continue;
											}
											goto case 26;
										case 21:
											break;
										case 15:
											if (!DA3aGeVKrLHxFjoPAno(WorkflowMigrationItemManager, current, workflowInstance, workflowProcess, changeProcessVersionActionData2))
											{
												num4 = 1;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
												{
													num4 = 24;
												}
												continue;
											}
											break;
										case 13:
											break;
										case 24:
											flag = true;
											num4 = 6;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
											{
												num4 = 29;
											}
											continue;
										case 17:
											text = (string)j0HuIHVx07GjVvPEg9P(package);
											num4 = 28;
											continue;
										case 23:
											flag2 = false;
											num4 = 19;
											continue;
										case 22:
											workflowProcess = (IWorkflowProcess)VGqIBnVhShjJDIiSMsF(workflowInstance.Process.Header);
											num4 = 17;
											continue;
										case 7:
											WorkflowMigrationItemManager.ChangeStatus(current, WorkflowInstanceMigrationItemStatus.ValidationCriticalError);
											num4 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											workflowInstanceMigrationItemStatus = WorkflowInstanceMigrationItemStatus.New;
											num4 = 11;
											continue;
										case 0:
											break;
										case 27:
											if (dScAZMV2Lh0ckhRw3rN(changeProcessVersionValidationResult))
											{
												num4 = 8;
												continue;
											}
											goto case 25;
										case 4:
											flag2 = true;
											num4 = 18;
											continue;
										case 16:
											if (!flag2)
											{
												num4 = 6;
												continue;
											}
											goto case 15;
										case 12:
										{
											ChangeProcessVersionActionData changeProcessVersionActionData = new ChangeProcessVersionActionData();
											yVPma0VFo9OnmNKvJUX(changeProcessVersionActionData, text);
											Y5nYT1V88KiKHfpwaIV(changeProcessVersionActionData, workflowInstance);
											es121lVwnvHqU7mZtXt(changeProcessVersionActionData, workflowProcess);
											tYv4evVtOYrxmJyQoPx(changeProcessVersionActionData, currentUser);
											changeProcessVersionActionData2 = changeProcessVersionActionData;
											num4 = 2;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
											{
												num4 = 2;
											}
											continue;
										}
										case 10:
											break;
										}
										break;
									}
								}
								catch (Exception ex)
								{
									int num11 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
									{
										num11 = 1;
									}
									while (true)
									{
										switch (num11)
										{
										case 2:
											WorkflowMigrationItemManager.ChangeStatus(current, WorkflowInstanceMigrationItemStatus.OtherError, (string)PZv52eValxE99u0oYx0(ex));
											num11 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
											{
												num11 = 0;
											}
											continue;
										case 1:
											DJudxkVvDHBIHId3VYU(aW9Xt8VMbyAeNeTJFxh(), rpL2GOVYetakRmDkq8o(PZv52eValxE99u0oYx0(ex), new object[1] { ex }));
											num11 = 2;
											continue;
										default:
											flag = true;
											num11 = 1;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
											{
												num11 = 3;
											}
											continue;
										case 3:
											break;
										}
										break;
									}
								}
								continue;
							case 3:
								goto end_IL_00a2;
							}
							goto IL_008f;
							IL_008f:
							current = enumerator.Current;
							num3 = 2;
							goto IL_0075;
							continue;
							end_IL_00a2:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num12 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 != 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									enumerator.Dispose();
									num12 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd != 0)
									{
										num12 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 10;
				case 10:
					if (!flag)
					{
						num2 = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				case 7:
					if (package == null)
					{
						num2 = 6;
						continue;
					}
					flag = false;
					num2 = 4;
					continue;
				case 6:
					return;
				case 2:
					Bx5UXJVPWCOtNqlkGe4(this, package);
					num2 = 8;
					continue;
				case 1:
					break;
				case 12:
					enumerator = ((IEnumerable<IWorkflowInstanceMigrationItem>)package.Items).GetEnumerator();
					num2 = 3;
					continue;
				case 8:
					return;
				case 5:
					ChangeStatus(package, WorkflowInstanceMigrationPackageStatus.Processed);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					GjEvhUVospsZxMochN8(this, package, WorkflowInstanceMigrationPackageStatus.InProgress);
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
					{
						num2 = 9;
					}
					continue;
				default:
					LfsZaSV4UHQihfWXIuJ(this, package);
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			}
			GjEvhUVospsZxMochN8(this, package, WorkflowInstanceMigrationPackageStatus.ProcessedWithErrors);
			num = 2;
		}
	}

	public WorkflowInstanceMigrationPackageManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		juuiQ5V9GX80vQJ6W9V();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EK3BZ9QBueqpU2hO42g()
	{
		return sB34WsQ09UN6OHS2P9u == null;
	}

	internal static WorkflowInstanceMigrationPackageManager DmcjmMQW8KuJxVNyfHm()
	{
		return sB34WsQ09UN6OHS2P9u;
	}

	internal static void qw8W3fQHjSaC1XrEEmr(object P_0, object P_1, object P_2)
	{
		((EntityManager<IWorkflowInstanceMigrationPackage, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object Y8vIFpQeD9d5sSCx6pt(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object M7ApkmQiSrku7EmmRc9(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object hBdHcyQu0aokXKGeBFH(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static object ywkqH0QltTJmbGvvZYr(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object JVvsUxQflwYj17fospG(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object zkOmsuQLWl2BFhjxv6U(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object VRJiZ5QJm3R6yEwOwC4(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object doKkW0Qr1fi8RxQd6Au(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object XLZAJnQ7yeOGcRWkCRq(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static void EY63tBQ5ElCsmIpM6Wp(object P_0, object P_1)
	{
		((ISession)P_0).CleanUpCache((Type[])P_1);
	}

	internal static Guid p6jILwQgNjX3XANBmOy()
	{
		return WorkflowInstanceMigrationPackageActions.ProcessErrorGuid;
	}

	internal static void TJ0rKOQ171C7JcOe08Z(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static Guid o7ZjGZQIe4lby9ZuSYk()
	{
		return WorkflowInstanceMigrationPackageActions.ProcessSuccessGuid;
	}

	internal static void e3I4ZHQZOBKlUXfLjOD(object P_0, bool value)
	{
		((SwimlaneProcessingInfo)P_0).ManualProcessing = value;
	}

	internal static object SyP5hyQzs4UCnEQ8Pem(object P_0)
	{
		return ((SwimlaneChangeInfo)P_0).ActiveElementUids;
	}

	internal static object q16FQWVEHN2AmjVQJfu(object P_0)
	{
		return ((SwimlaneChangeInfo)P_0).NewSwimlane;
	}

	internal static object iDBY2FVCu8qvAj7nDft(object P_0)
	{
		return ((SwimlaneChangeInfo)P_0).OldSwimlane;
	}

	internal static void QvvS3uVXRKIJn2RuZZ3(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void GjEvhUVospsZxMochN8(object P_0, object P_1, WorkflowInstanceMigrationPackageStatus status)
	{
		((WorkflowInstanceMigrationPackageManager)P_0).ChangeStatus((IWorkflowInstanceMigrationPackage)P_1, status);
	}

	internal static void x3ncIiV3yJYSBYF6Tho(object P_0, object P_1)
	{
		((WorkflowInstanceMigrationItemManager)P_0).Start((IWorkflowInstanceMigrationItem)P_1);
	}

	internal static object VGqIBnVhShjJDIiSMsF(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object j0HuIHVx07GjVvPEg9P(object P_0)
	{
		return ((IWorkflowInstanceMigrationPackage)P_0).MigrationReason;
	}

	internal static void yVPma0VFo9OnmNKvJUX(object P_0, object P_1)
	{
		((ChangeProcessVersionActionData)P_0).Reason = (string)P_1;
	}

	internal static void Y5nYT1V88KiKHfpwaIV(object P_0, object P_1)
	{
		((ChangeProcessVersionActionData)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static void es121lVwnvHqU7mZtXt(object P_0, object P_1)
	{
		((ChangeProcessVersionActionData)P_0).NewProcess = (IWorkflowProcess)P_1;
	}

	internal static void tYv4evVtOYrxmJyQoPx(object P_0, object P_1)
	{
		((ChangeProcessVersionActionData)P_0).User = (IUser)P_1;
	}

	internal static bool MdtOLSVsInbFWRkAgv0(object P_0, object P_1)
	{
		return ((WorkflowInstanceManager)P_0).CanChangeVersion((ChangeProcessVersionActionData)P_1);
	}

	internal static bool dScAZMV2Lh0ckhRw3rN(object P_0)
	{
		return ((ChangeProcessVersionValidationResult)P_0).HasCriticalIssues;
	}

	internal static int txnePAVqai0d7eN67nq(object P_0)
	{
		return ((ICollection<SwimlaneChangeInfo>)P_0).Count;
	}

	internal static bool aNNvMMVQJYm52CHF94b(object P_0)
	{
		return ((SwimlaneProcessingInfo)P_0).ManualProcessing;
	}

	internal static bool OYxJtEVVNgZMXnaP6Jr(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void QSD2jCVDvp1S1asfswC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool DA3aGeVKrLHxFjoPAno(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((WorkflowInstanceMigrationItemManager)P_0).TryChangeWorkflowInstanceVersion((IWorkflowInstanceMigrationItem)P_1, (IWorkflowInstance)P_2, (IWorkflowProcess)P_3, (ChangeProcessVersionActionData)P_4);
	}

	internal static object aW9Xt8VMbyAeNeTJFxh()
	{
		return EleWise.ELMA.Logging.Logger.Log;
	}

	internal static object PZv52eValxE99u0oYx0(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object rpL2GOVYetakRmDkq8o(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void DJudxkVvDHBIHId3VYU(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void Bx5UXJVPWCOtNqlkGe4(object P_0, object P_1)
	{
		((WorkflowInstanceMigrationPackageManager)P_0).ProcessMigrationErrors((IWorkflowInstanceMigrationPackage)P_1);
	}

	internal static void LfsZaSV4UHQihfWXIuJ(object P_0, object P_1)
	{
		((WorkflowInstanceMigrationPackageManager)P_0).ProcessMigrationSuccess((IWorkflowInstanceMigrationPackage)P_1);
	}

	internal static void juuiQ5V9GX80vQJ6W9V()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
