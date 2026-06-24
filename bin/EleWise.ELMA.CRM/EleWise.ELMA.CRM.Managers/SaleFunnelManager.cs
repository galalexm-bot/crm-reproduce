using System;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class SaleFunnelManager : EntityManager<ISaleFunnel, long>
{
	public const string SaleFunnelReportUidStr = "{869E49A0-BB96-495F-8EA4-0EFC5F06ED35}";

	public static readonly Guid SaleFunnelReportUid = new Guid("{869E49A0-BB96-495F-8EA4-0EFC5F06ED35}");

	public new static SaleFunnelManager Instance => Locator.GetServiceNotNull<SaleFunnelManager>();

	[PublicApiMember]
	public override void Delete(ISaleFunnel obj)
	{
		DeleteSaleFunnelReportFilters(obj);
		base.Delete(obj);
	}

	public IFilter CreateSaleFunnelReportFilter(ISaleFunnel saleFunnel)
	{
		InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
		instanceOf.New.FilterType = FilterType.SystemFilter;
		instanceOf.New.Name = saleFunnel.Name;
		instanceOf.New.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = SaleFunnelReportUid
		};
		instanceOf.New.UseDefaultSettings = true;
		IFilter @new = instanceOf.New;
		InstanceOf<ISaleFilter> instanceOf2 = new InstanceOf<ISaleFilter>();
		instanceOf2.New.SaleFunnel = saleFunnel;
		@new.FilterFields = UniversalFilterSaver.Pack(instanceOf2.New);
		IFilter new2 = instanceOf.New;
		IUserGroup userGroup = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		ISet<IFilterPermission> permissions = new2.Permissions;
		InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
		instanceOf3.New.Filter = new2;
		instanceOf3.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterViewPermission.Id;
		instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf3.New.Group = userGroup;
		instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
		permissions.Add(instanceOf3.New);
		new2.Save();
		saleFunnel.Filter = new2;
		saleFunnel.Save();
		return new2;
	}

	public void DeleteSaleFunnelReportFilters(ISaleFunnel saleFunnel)
	{
		FilterFolderManager instance = FilterFolderManager.Instance;
		InstanceOf<IFilterFolderFilter> instanceOf = new InstanceOf<IFilterFolderFilter>();
		instanceOf.New.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = SaleFunnelReportUid
		};
		foreach (IFilter item in instance.Find(instanceOf.New, FetchOptions.All).OfType<IFilter>())
		{
			try
			{
				if (((ISaleFilter)UniversalFilterSaver.UnPack(item.FilterFields)).SaleFunnel == saleFunnel)
				{
					item.Delete();
				}
			}
			catch
			{
				item.Delete();
			}
		}
	}
}
