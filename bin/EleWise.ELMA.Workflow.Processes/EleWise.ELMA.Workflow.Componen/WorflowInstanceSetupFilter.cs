using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class WorflowInstanceSetupFilter : IWorflowInstanceSetupFilter
{
	internal static WorflowInstanceSetupFilter RQwbvsdoT2Cj5IeIEDI;

	public void SetupFilter(ICriteria criteria, IWorkflowInstanceFilter filter, ref bool hasFilteringByMember, ref bool processHeaderJoined)
	{
		//Discarded unreachable code: IL_0185, IL_0196, IL_01e2, IL_01f1, IL_0201, IL_0210, IL_021f, IL_0241, IL_0250, IL_0276, IL_0286, IL_02d2, IL_0517, IL_0521, IL_05b0, IL_05e6, IL_0618, IL_0623, IL_062d, IL_067c, IL_06b8, IL_06f4, IL_071a, IL_075a, IL_077b, IL_0836, IL_0846, IL_0876, IL_0885, IL_0896, IL_08a1
		int num = 14;
		Guid? guid = default(Guid?);
		Guid guid2 = default(Guid);
		string text = default(string);
		Func<ICriterion> func2 = default(Func<ICriterion>);
		IEnumerable<IProcessHeader> source = default(IEnumerable<IProcessHeader>);
		ISecurityService serviceNotNull2 = default(ISecurityService);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		List<string> values = default(List<string>);
		List<IProcessHeader> processHeaderList = default(List<IProcessHeader>);
		string alias = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Func<ICriterion> func;
				switch (num2)
				{
				case 67:
					guid = filter.CurrentExecuterRole;
					num2 = 22;
					continue;
				case 54:
					guid2 = o9jxe2dxN0xNBPlCtbC(WorkflowProcessesPermissionProvider.ImprovementModulePermission);
					num2 = 33;
					continue;
				case 38:
					BSuCmxdt4B7ir0YWupi(criteria, Restrictions.Or((ICriterion)GGVposdYgOGIFn3eNsP(text), func2()));
					num2 = 27;
					continue;
				case 1:
					return;
				case 34:
					return;
				case 40:
					return;
				case 24:
					if (!guid.HasValue)
					{
						num2 = 51;
						continue;
					}
					if (!guid.HasValue)
					{
						num2 = 68;
						continue;
					}
					if (z6SoLKdFYLhTFnPUAwi(guid.GetValueOrDefault(), guid2))
					{
						goto case 41;
					}
					goto case 51;
				case 31:
					if (guid.HasValue)
					{
						num2 = 17;
						continue;
					}
					goto case 19;
				case 64:
					guid = filter.PermissionId;
					num = 54;
					break;
				case 14:
					guid = filter.PermissionId;
					num2 = 13;
					continue;
				case 41:
				case 68:
					source = ((ProcessHeaderManager)uG2W6pds77npnZ1cweP()).LoadMyResponsibilityProcess();
					num2 = 28;
					continue;
				case 55:
					if (!guid.HasValue)
					{
						num2 = 59;
						continue;
					}
					if (z6SoLKdFYLhTFnPUAwi(guid.GetValueOrDefault(), guid2))
					{
						goto case 18;
					}
					goto case 45;
				case 10:
					if (!QlPoCsd8cmg1T2kW9V9(serviceNotNull2, WorkflowProcessesPermissionProvider.ImprovementExecutionAccessPermission))
					{
						num2 = 44;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
						{
							num2 = 58;
						}
						continue;
					}
					goto case 53;
				case 23:
				case 26:
					if (QlPoCsd8cmg1T2kW9V9(serviceNotNull2, WorkflowProcessesPermissionProvider.ImprovementAccessPermission))
					{
						num2 = 6;
						continue;
					}
					goto case 41;
				case 11:
				case 50:
					guid = filter.PermissionId;
					num2 = 37;
					continue;
				case 22:
					guid2 = e9iAngdwmtnelH6usMW(WorkflowRoleTypes.Initiator);
					num2 = 56;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
					{
						num2 = 26;
					}
					continue;
				case 15:
					text = (string)EA1ZohdMXwScDYMtNG4(nnkEZodQF8oY6HSYZw4(-1941486619 ^ -1941454189), MYqqmvdVe9lgt5wQxZu(criteria), RjDOOCdKnlVlST3x7hu(WuLaHndDTcB0a3CqQLK(serviceNotNull), nnkEZodQF8oY6HSYZw4(-1411073168 ^ -1411085174)), string.Join((string)nnkEZodQF8oY6HSYZw4(-1756425685 ^ -1756401107), values));
					num = 67;
					break;
				case 44:
					criteria.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1843608060 ^ -1843596802), new object[0]));
					num2 = 69;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
					{
						num2 = 44;
					}
					continue;
				case 33:
					if (guid.HasValue)
					{
						num2 = 21;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 11;
				case 25:
					guid2 = o9jxe2dxN0xNBPlCtbC(WorkflowProcessesPermissionProvider.ImprovementAccessPermission);
					num2 = 49;
					continue;
				case 19:
				case 27:
				case 42:
				case 52:
				case 60:
					processHeaderList = ((ImprovementProcessSettingsManager)mL4K3SdqUcQ5ultmnc4()).GetProcessHeaderList((string)null);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd != 0)
					{
						num2 = 12;
					}
					continue;
				default:
					criteria.GetOrCreateAlias((string)nnkEZodQF8oY6HSYZw4(-444713948 ^ -444680830), (string)XOnVAndvmvmyLi8wYan(WorkflowInstanceManager.Instance, nnkEZodQF8oY6HSYZw4(-275456087 ^ -275489265)), (JoinType)0, ref alias).Add((ICriterion)(object)Restrictions.In((string)WgS3XodPCkT5IFNdFvf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1363339545 ^ -1363306657), alias), ((IEnumerable<object>)processHeaderList).ToArray()));
					num2 = 29;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
					{
						num2 = 10;
					}
					continue;
				case 57:
					guid2 = o9jxe2dxN0xNBPlCtbC(WorkflowProcessesPermissionProvider.ImprovementExecutionAccessPermission);
					num2 = 24;
					continue;
				case 2:
					if (serviceNotNull2.HasPermission(WorkflowProcessesPermissionProvider.ImprovementModulePermission))
					{
						num2 = 61;
						continue;
					}
					goto case 44;
				case 69:
					return;
				case 61:
					func = _003C_003Ec._003C_003E9__0_0;
					if (func == null)
					{
						num2 = 47;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
						{
							num2 = 47;
						}
						continue;
					}
					goto IL_0933;
				case 58:
					if (serviceNotNull2.HasPermission(WorkflowProcessesPermissionProvider.ImprovementAccessPermission))
					{
						num2 = 53;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 48;
				case 7:
				case 32:
					BSuCmxdt4B7ir0YWupi(criteria, GGVposdYgOGIFn3eNsP(text));
					num = 42;
					break;
				case 13:
					if (!guid.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 64;
				case 53:
					guid = filter.PermissionId;
					num2 = 66;
					continue;
				case 5:
				case 36:
					guid = filter.PermissionId;
					num = 25;
					break;
				case 48:
					guid = filter.CurrentExecuterRole;
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
					{
						num2 = 1;
					}
					continue;
				case 21:
					if (!guid.HasValue)
					{
						num = 20;
						break;
					}
					if (!z6SoLKdFYLhTFnPUAwi(guid.GetValueOrDefault(), guid2))
					{
						goto case 11;
					}
					goto case 20;
				case 37:
					guid2 = o9jxe2dxN0xNBPlCtbC(WorkflowProcessesPermissionProvider.ImprovementExecutionAccessPermission);
					num2 = 35;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
					{
						num2 = 9;
					}
					continue;
				case 56:
					if (guid.HasValue)
					{
						if (!guid.HasValue)
						{
							num = 32;
							break;
						}
						if (!aNRhY9daNf1PHiPRFqF(guid.GetValueOrDefault(), guid2))
						{
							goto case 7;
						}
						goto case 39;
					}
					num2 = 39;
					continue;
				case 8:
					guid2 = e9iAngdwmtnelH6usMW(WorkflowRoleTypes.Initiator);
					num2 = 9;
					continue;
				case 12:
					alias = (string)nnkEZodQF8oY6HSYZw4(-905209456 ^ -905242614);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
					{
						num2 = 0;
					}
					continue;
				case 49:
					if (guid.HasValue)
					{
						num2 = 55;
						continue;
					}
					goto case 45;
				case 9:
					if (guid.HasValue)
					{
						num2 = 31;
						continue;
					}
					goto case 46;
				case 18:
				case 59:
				case 62:
				case 65:
					serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
					num2 = 2;
					continue;
				case 29:
					processHeaderJoined = true;
					num2 = 40;
					continue;
				case 66:
					guid2 = o9jxe2dxN0xNBPlCtbC(WorkflowProcessesPermissionProvider.ImprovementModulePermission);
					num2 = 63;
					continue;
				case 35:
					if (!guid.HasValue)
					{
						num2 = 36;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (!guid.HasValue)
					{
						num2 = 7;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
						{
							num2 = 30;
						}
						continue;
					}
					if (!z6SoLKdFYLhTFnPUAwi(guid.GetValueOrDefault(), guid2))
					{
						goto case 5;
					}
					goto case 30;
				case 63:
					if (guid.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 23;
				case 16:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
					{
						num2 = 15;
					}
					continue;
				case 6:
					guid = filter.PermissionId;
					num2 = 57;
					continue;
				case 3:
					if (!guid.HasValue)
					{
						num = 43;
						break;
					}
					if (!z6SoLKdFYLhTFnPUAwi(guid.GetValueOrDefault(), guid2))
					{
						goto case 23;
					}
					goto case 43;
				case 4:
					BSuCmxdt4B7ir0YWupi(criteria, func2());
					num2 = 19;
					continue;
				case 20:
					num2 = 65;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
					{
						num2 = 16;
					}
					continue;
				case 30:
					num2 = 15;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
					{
						num2 = 62;
					}
					continue;
				case 45:
					num2 = 34;
					continue;
				case 47:
					func = (_003C_003Ec._003C_003E9__0_0 = delegate
					{
						int num3 = 1;
						int num4 = num3;
						EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
						while (true)
						{
							switch (num4)
							{
							default:
								return (ICriterion)_003C_003Ec.JIQqOxBu5d9dnpoMnhM(_003C_003Ec.jHwqjrBiT6C1rece5fj(WorkflowInstanceManager.Instance, _003C_003Ec.JK873mBebxvdDiL30hd(-2038986505 ^ -2039004119)), currentUser);
							case 1:
								currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
								num4 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					goto IL_0933;
				case 43:
					num = 48;
					break;
				case 17:
					if (!(guid.GetValueOrDefault() != guid2))
					{
						goto case 19;
					}
					goto case 46;
				case 46:
					num2 = 4;
					continue;
				case 51:
					num2 = 60;
					continue;
				case 28:
					values = ((WorkflowInstanceManager)yVlo2Md2IRiCTT8F7f4()).BuildInstancesByEntityQueryList(source.Select((IProcessHeader h) => h.Id), InterfaceActivator.TypeOf<IProcessHeader>(), (ICollection<Guid>)((ImprovementProcessSettingsManager)mL4K3SdqUcQ5ultmnc4()).GetProcessHeaderPropertyUidList(), (string)null);
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
					{
						num2 = 12;
					}
					continue;
				case 39:
					{
						num2 = 38;
						continue;
					}
					IL_0933:
					func2 = func;
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	public WorflowInstanceSetupFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ahkyond4aSEocvBGVrv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid o9jxe2dxN0xNBPlCtbC(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool z6SoLKdFYLhTFnPUAwi(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool QlPoCsd8cmg1T2kW9V9(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static Guid e9iAngdwmtnelH6usMW(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static object BSuCmxdt4B7ir0YWupi(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object uG2W6pds77npnZ1cweP()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object yVlo2Md2IRiCTT8F7f4()
	{
		return WorkflowInstanceManager.Instance;
	}

	internal static object mL4K3SdqUcQ5ultmnc4()
	{
		return ImprovementProcessSettingsManager.Instance;
	}

	internal static object nnkEZodQF8oY6HSYZw4(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MYqqmvdVe9lgt5wQxZu(object P_0)
	{
		return SqlQueryBuilder.GetCriteriaAlias((ICriteria)P_0);
	}

	internal static object WuLaHndDTcB0a3CqQLK(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object RjDOOCdKnlVlST3x7hu(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object EA1ZohdMXwScDYMtNG4(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool aNRhY9daNf1PHiPRFqF(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object GGVposdYgOGIFn3eNsP(object P_0)
	{
		return Expression.Sql((string)P_0);
	}

	internal static object XOnVAndvmvmyLi8wYan(object P_0, object P_1)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).GetAliasedPropertyString((string)P_1);
	}

	internal static object WgS3XodPCkT5IFNdFvf(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool GyVgWxd3cZmFguiZgjX()
	{
		return RQwbvsdoT2Cj5IeIEDI == null;
	}

	internal static WorflowInstanceSetupFilter r9OmxVdhTQWCk593Fs9()
	{
		return RQwbvsdoT2Cj5IeIEDI;
	}

	internal static void Ahkyond4aSEocvBGVrv()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
