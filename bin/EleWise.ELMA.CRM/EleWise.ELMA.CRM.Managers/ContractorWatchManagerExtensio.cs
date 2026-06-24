using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Managers;

public class ContractorWatchManagerExtension : EntityExtensionManager<IWatch, IContractorWatchExt, long, WatchManager>
{
	public UserManager UserManager { get; set; }

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	protected bool OnCanDeleteWatchesByUser(EleWise.ELMA.Security.Models.IUser user, object entityId, Guid typeUid, object result)
	{
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(InterfaceActivator.LoadMetadata<IContractor>() as EntityMetadata);
		if ((bool)result && childClasses.Any((ClassMetadata item) => item.Uid == typeUid))
		{
			long id = Convert.ToInt64(entityId);
			IContractor contractor = ContractorManager.Instance.Load(id);
			EleWise.ELMA.Security.Models.IUser currentUser = UserManager.GetCurrentUser();
			if (user.Id != currentUser.Id && contractor.CreationAuthor.Id != currentUser.Id && contractor.Responsible.Id != currentUser.Id)
			{
				return SecurityService.HasPermission(currentUser, CRMPermissionProvider.EditContractorPermission, contractor);
			}
			return true;
		}
		return (bool)result;
	}
}
