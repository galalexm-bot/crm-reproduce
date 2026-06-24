using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Export;

[Component(Order = 100)]
public class SecurityExportExtension : IConfigExportExtension
{
	private ExportRuleBuilder<IUserGroup> customGroupExportRuleBuilder;

	private ExportRuleBuilder<IOrganizationModel> customOrgExportRuleBuilder;

	internal static SecurityExportExtension VgoYP73MhfJ421JCPVT;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			SecurityExportConsts.ExportExtensionUid,
			new SecurityExportSetting()
		} };
	}

	public void AddExportObjects(ExportExtensionParams parameters)
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
				AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AddCustomRules();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void AddCustomRules()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				customGroupExportRuleBuilder = new ExportRuleBuilder<IUserGroup>(new ExportRuleList());
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				customOrgExportRuleBuilder = new ExportRuleBuilder<IOrganizationModel>(new ExportRuleList());
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			}
			ExportRuleBuilderSelectType<IOrganizationModel> exportRuleBuilderSelectType = customOrgExportRuleBuilder.Rule();
			ParameterExpression parameterExpression = (ParameterExpression)fMAE2V34dc53FB4hI57(Y26HZm3IC4is52A5RgQ(typeof(IOrganizationModel).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959692314));
			qmoIWE3dkuu39Y7QgxM(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<IOrganizationModel, object>>((Expression)g52Pmx3Q8WKLKNaToLC(parameterExpression, (MethodInfo)tO86QV3VHGk9RMsCpPW((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
			{
				num2 = 1;
			}
		}
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<string, object> serviceData, List<PacketEntity> packetEntities)
	{
		if (!(parameters[SecurityExportConsts.ExportExtensionUid] is SecurityExportSetting securityExportSetting))
		{
			return;
		}
		bool exportOrgModel = securityExportSetting.ExportOrgModel;
		bool exportUserGroups = securityExportSetting.ExportUserGroups;
		ICollection<IUserGroup> collection = Locator.GetServiceNotNull<UserGroupManager>().FindAll();
		if (collection != null)
		{
			foreach (IUserGroup item in collection)
			{
				serviceData.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068840604) + item.Id, item.Uid);
			}
		}
		if (exportOrgModel)
		{
			AddOrgModel(packetEntities);
		}
		ICollection<IOrganizationItem> collection2 = Locator.GetServiceNotNull<OrganizationItemManager>().FindAll();
		if (collection2 != null)
		{
			foreach (IOrganizationItem item2 in collection2)
			{
				serviceData.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-225736894 ^ -225739400) + item2.Id, item2.Uid);
			}
		}
		if (exportUserGroups)
		{
			AddUserGroups(packetEntities, securityExportSetting);
		}
	}

	private List<IEntity> GetGroupsEntities(IUserGroup group)
	{
		ExportHelperBuilder<IUserGroup> exportHelperBuilder = ExportHelperBuilder.Create(group);
		exportHelperBuilder.ExportRuleList = customGroupExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddUserGroups(List<PacketEntity> packetEntities, SecurityExportSetting securityExportSetting)
	{
		foreach (IUserGroup group in GetGroups(securityExportSetting))
		{
			PacketEntity packetEntity = new PacketEntity(group);
			packetEntity.ExportRules = customGroupExportRuleBuilder.ExportRules;
			foreach (IEntity groupsEntity in GetGroupsEntities(group))
			{
				packetEntity.SubEntities.Add(groupsEntity);
			}
			packetEntities.Add(packetEntity);
		}
	}

	private ICollection<IUserGroup> GetGroups(SecurityExportSetting securityExportSetting)
	{
		UserGroupManager serviceNotNull = Locator.GetServiceNotNull<UserGroupManager>();
		List<IUserGroup> list = new List<IUserGroup>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (long userGroupsId in securityExportSetting.UserGroupsIds)
		{
			IUserGroup userGroup = serviceNotNull.Load(userGroupsId);
			list.Add(userGroup);
			hashSet.Add(userGroup.Uid);
		}
		foreach (Guid userGroupsUid in securityExportSetting.UserGroupsUids)
		{
			if (!hashSet.Contains(userGroupsUid))
			{
				IUserGroup userGroup2 = serviceNotNull.Load(userGroupsUid);
				list.Add(userGroup2);
				hashSet.Add(userGroup2.Uid);
			}
		}
		return list;
	}

	private List<IEntity> GetOrgEntities(IOrganizationModel model)
	{
		ExportHelperBuilder<IOrganizationModel> exportHelperBuilder = ExportHelperBuilder.Create(model);
		exportHelperBuilder.ExportRuleList = customOrgExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddOrgModel(List<PacketEntity> packetEntities)
	{
		IOrganizationModel organizationModel = Locator.GetServiceNotNull<OrganizationModelManager>().LoadPublishedOrNull();
		if (organizationModel == null)
		{
			return;
		}
		PacketEntity packetEntity = new PacketEntity(organizationModel);
		packetEntity.ExportRules = customOrgExportRuleBuilder.ExportRules;
		foreach (IEntity orgEntity in GetOrgEntities(organizationModel))
		{
			packetEntity.SubEntities.Add(orgEntity);
		}
		packetEntities.Add(packetEntity);
	}

	public SecurityExportExtension()
	{
		//Discarded unreachable code: IL_0054, IL_0059
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		customGroupExportRuleBuilder = new ExportRuleBuilder<IUserGroup>(new ExportRuleList());
		customOrgExportRuleBuilder = new ExportRuleBuilder<IOrganizationModel>(new ExportRuleList());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool detgyX3splXULo7rApu()
	{
		return VgoYP73MhfJ421JCPVT == null;
	}

	internal static SecurityExportExtension x4gJrT3YHpKypC8gRlv()
	{
		return VgoYP73MhfJ421JCPVT;
	}

	internal static Type Y26HZm3IC4is52A5RgQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object fMAE2V34dc53FB4hI57(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object tO86QV3VHGk9RMsCpPW(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object g52Pmx3Q8WKLKNaToLC(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void qmoIWE3dkuu39Y7QgxM(object P_0)
	{
		((ExportRuleBuilderSelectAction<IOrganizationModel>)P_0).Ignore();
	}
}
