using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.IntegrationModules.Web.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.IntegrationModules.Web.Controllers;

[RouteArea("EleWise.ELMA.IntegrationModules.Web")]
[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
public class IntegrationModuleActivityController : FilterTreeBaseController<IIntegrationModuleActivity, long>
{
	private IMetadataRuntimeService metadataRuntimeService;

	public IntegrationModuleActivityController(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	public ActionResult ViewActivityPopup(long id, Guid uid)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(metadataRuntimeService.GetTypeByUid(uid));
		IntegrationActivityViewModel integrationActivityViewModel = new IntegrationActivityViewModel();
		integrationActivityViewModel.Entity = (IIntegrationModuleActivity)entityManager.Load(id);
		integrationActivityViewModel.ViewType = ViewType.Display;
		return (ActionResult)(object)((Controller)this).PartialView((object)integrationActivityViewModel);
	}
}
