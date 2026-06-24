using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
internal sealed class DmsObjectPermissionsAccessRequestRenderer : IEntityPermissionAccessRequestRenderer
{
	public PermissionsModelService PermissionsModelService { get; set; }

	public ISecurityService SecurityService { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	public bool CanRender(IEntityPermissionAccessRequestProvider permissionAccessRequestProvider)
	{
		return permissionAccessRequestProvider is DmsObjectPermissionsAccessRequestProvider;
	}

	public void Render(Guid entityTypeUid, long entityId, HtmlHelper helper)
	{
		IDmsObject entity = null;
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			entity = DmsObjectManager.LoadOrNull(entityId);
		});
		if (entity != null)
		{
			EntityPermissionRoleTypeSelectorModel entityPermissionRoleTypeSelectorModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(entity, entity.GetType(), helper.Url());
			RenderPartialExtensions.RenderPartial(helper, "DmsObject/Partial/DmsObjectPermissions", (object)entityPermissionRoleTypeSelectorModel);
		}
	}
}
