using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
internal sealed class WorkflowProcessPermissionDelegate : IPermissionsDelegate
{
	private ISessionProvider sessionProvider;

	private ReplacementManager replacementManager;

	private static WorkflowProcessPermissionDelegate vDSOfHl6RgxXtRWfxjR;

	public WorkflowProcessPermissionDelegate(ISessionProvider sessionProvider, ReplacementManager replacementManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eSon87lTkvvuTuq14ny();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.sessionProvider = sessionProvider;
				num = 2;
				break;
			case 2:
				this.replacementManager = replacementManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_009c
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!wuE4tSlpq1GILLM9LTW(typeof(IWorkflowProcess).TypeHandle).IsAssignableFrom(type))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 4:
					if (!JIC5mVlQ1FpcJ5g9BAN(permission, null))
					{
						break;
					}
					goto default;
				case 2:
					return npfohqlMdwFX9BNOymk(hwBmJ1lC9gVkV6kQsot(WorkflowPermissionProvider.StartProcess), hwBmJ1lC9gVkV6kQsot(permission));
				case 1:
				case 3:
					return false;
				}
				break;
			}
			num = 3;
		}
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_00a9, IL_0169, IL_0178, IL_0224, IL_0233, IL_0289, IL_0298, IL_02a8, IL_02cb, IL_0327, IL_0336, IL_0346, IL_0465
		int num = 27;
		IEnumerable<long> value = default(IEnumerable<long>);
		Dictionary<Guid, IEnumerable<long>> dictionary = default(Dictionary<Guid, IEnumerable<long>>);
		IEnumerable<long> value2 = default(IEnumerable<long>);
		IQuery val = default(IQuery);
		ISession session = default(ISession);
		IBPMNProcess iBPMNProcess = default(IBPMNProcess);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		List<long> list = default(List<long>);
		long[] array = default(long[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 31:
					if (value != null)
					{
						num2 = 32;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto default;
				case 28:
					dictionary.TryGetValue(UserGroupDTO.MetadataUid, out value2);
					num = 21;
					break;
				case 7:
					val = (IQuery)AEaRiSl22AtaNFCG9gV(AEaRiSl22AtaNFCG9gV(qtKj3VlGjUgrKT2TVmM(session, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157D45FC)), TvAGs5l75tFuXdZs0Cq(-420003255 ^ -419994939), value2, NHibernateUtil.Int64), TvAGs5l75tFuXdZs0Cq(--296112178 ^ 0x11A670AE), value, NHibernateUtil.Int64);
					num2 = 14;
					continue;
				case 33:
					if (value == null)
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				case 4:
				case 12:
				case 24:
					return false;
				case 15:
					iBPMNProcess = workflowProcess.CastAsRealType() as IBPMNProcess;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 9;
					}
					continue;
				case 21:
					dictionary.TryGetValue(h8JtyJlVk0wy1BumrgN(), out value);
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					list = new List<long>(array.Length + 1) { (long)user.GetId() };
					num2 = 20;
					continue;
				case 32:
					if (value2 == null)
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 7;
				case 29:
					if (permission == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 6;
				case 18:
					session = sessionProvider.GetSession("");
					num = 8;
					break;
				case 13:
					if (user != null)
					{
						num2 = 29;
						continue;
					}
					goto case 4;
				case 27:
					workflowProcess = target as IWorkflowProcess;
					num2 = 26;
					continue;
				case 25:
					if (P3cWYilUAB4TGXfnpuF(dictionary) <= 0)
					{
						num2 = 10;
						continue;
					}
					goto case 28;
				case 6:
					if (!nkXNwZlkQDOtSaHGJ12(hwBmJ1lC9gVkV6kQsot(permission), hwBmJ1lC9gVkV6kQsot(WorkflowPermissionProvider.StartProcess)))
					{
						num2 = 15;
						continue;
					}
					goto case 4;
				case 2:
				case 14:
				case 23:
					return s0AYRTlF4S0mf3LVkhP(EEbD9klorEsHnt5TYbL(((IQuery)AEaRiSl22AtaNFCG9gV(val, TvAGs5l75tFuXdZs0Cq(0x141C968 ^ 0x141EBD0), list, NHibernateUtil.Int64)).CleanUpCache(cleanUpCache: false))) > 0;
				case 3:
				case 10:
					return false;
				case 20:
					list.AddRange(array);
					num2 = 18;
					continue;
				case 1:
				case 16:
					array = (long[])UidHWelAuMjExGJrGg8(replacementManager, user);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 3;
					}
					continue;
				case 30:
					if (value2 != null)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 33;
				default:
					if (value != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 17;
				case 5:
					val = (IQuery)AEaRiSl22AtaNFCG9gV(qtKj3VlGjUgrKT2TVmM(session, TvAGs5l75tFuXdZs0Cq(-25709590 ^ -25717926)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6D16E), value, NHibernateUtil.Int64);
					num2 = 2;
					continue;
				case 8:
					val = null;
					num2 = 31;
					continue;
				case 26:
					if (workflowProcess == null)
					{
						num2 = 24;
						continue;
					}
					goto case 13;
				case 9:
					if (iBPMNProcess != null)
					{
						num2 = 19;
						continue;
					}
					goto case 3;
				case 17:
					val = (IQuery)AEaRiSl22AtaNFCG9gV(qtKj3VlGjUgrKT2TVmM(session, TvAGs5l75tFuXdZs0Cq(0x614CF569 ^ 0x614CD4D1)), TvAGs5l75tFuXdZs0Cq(0x2ACCDD87 ^ 0x2ACCFD0B), value2, NHibernateUtil.Int64);
					num2 = 23;
					continue;
				case 19:
					dictionary = (from i in ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).Where(delegate(IResponsibilityMatrixItem i)
						{
							//Discarded unreachable code: IL_0053
							int num5 = 2;
							int num6 = num5;
							long? workerId2 = default(long?);
							while (true)
							{
								switch (num6)
								{
								case 3:
									workerId2 = i.WorkerId;
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
									{
										num6 = 0;
									}
									break;
								default:
									return workerId2.HasValue;
								case 1:
									return false;
								case 2:
									if (!_003C_003Ec.BqyHZHZ9hUXNNKGspioW(i))
									{
										num6 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
										{
											num6 = 0;
										}
										break;
									}
									goto case 3;
								}
							}
						})
						group i by i.WorkerType).ToDictionary((IGrouping<Guid, IResponsibilityMatrixItem> gr) => gr.Key, (IGrouping<Guid, IResponsibilityMatrixItem> v) => v.Select(delegate(IResponsibilityMatrixItem item)
					{
						int num3 = 1;
						int num4 = num3;
						long? workerId = default(long?);
						while (true)
						{
							switch (num4)
							{
							case 1:
								workerId = item.WorkerId;
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
								{
									num4 = 0;
								}
								break;
							default:
								return workerId.Value;
							}
						}
					}));
					num2 = 25;
					continue;
				}
				break;
			}
		}
	}

	internal static void eSon87lTkvvuTuq14ny()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Jfi8mWlqyZBlswbP1CE()
	{
		return vDSOfHl6RgxXtRWfxjR == null;
	}

	internal static WorkflowProcessPermissionDelegate eq81Xul3N0hHxOkGQxt()
	{
		return vDSOfHl6RgxXtRWfxjR;
	}

	internal static bool JIC5mVlQ1FpcJ5g9BAN(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static Type wuE4tSlpq1GILLM9LTW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid hwBmJ1lC9gVkV6kQsot(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool npfohqlMdwFX9BNOymk(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool nkXNwZlkQDOtSaHGJ12(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int P3cWYilUAB4TGXfnpuF(object P_0)
	{
		return ((Dictionary<Guid, IEnumerable<long>>)P_0).Count;
	}

	internal static Guid h8JtyJlVk0wy1BumrgN()
	{
		return OrganizationItemDTO.MetadataUid;
	}

	internal static object UidHWelAuMjExGJrGg8(object P_0, object P_1)
	{
		return ((ReplacementManager)P_0).GetReplacedUsers((IUser)P_1);
	}

	internal static object qtKj3VlGjUgrKT2TVmM(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object TvAGs5l75tFuXdZs0Cq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AEaRiSl22AtaNFCG9gV(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IQuery)P_0).SetParameterList((string)P_1, (IEnumerable)P_2, (IType)P_3);
	}

	internal static object EEbD9klorEsHnt5TYbL(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static long s0AYRTlF4S0mf3LVkhP(object P_0)
	{
		return Convert.ToInt64(P_0);
	}
}
