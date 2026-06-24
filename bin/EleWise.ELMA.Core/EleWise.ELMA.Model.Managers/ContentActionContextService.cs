using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;

namespace EleWise.ELMA.Model.Managers;

[Service]
internal sealed class ContentActionContextService : IContentActionContextService
{
	private readonly ICurrentPageService currentPageService;

	private readonly ContentActionManager contentActionManager;

	private Guid CurrentModuleUid => currentPageService.CurrentPageViewModel?.ModuleUid ?? Guid.Empty;

	public ContentActionContextService(ICurrentPageService currentPageService, ContentActionManager contentActionManager)
	{
		this.currentPageService = currentPageService;
		this.contentActionManager = contentActionManager;
	}

	public System.Threading.Tasks.Task<FormBindingModel> GetFormBindingModel(string actionId)
	{
		return contentActionManager.GetFormBindingModel(actionId);
	}

	public System.Threading.Tasks.Task<ContentActionId> GetActionId(ContentActionModel model)
	{
		return contentActionManager.GetActionId(model);
	}

	public System.Threading.Tasks.Task<EntityFormView> LoadEntityForm(FormModel model)
	{
		return contentActionManager.LoadEntityForm(model);
	}

	public System.Collections.Generic.IEnumerable<ContentAction> GetAll()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return contentActionManager.GetAll(CurrentModuleUid);
	}

	public ContentAction GetAction(string actionId)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return contentActionManager.GetAction(CurrentModuleUid, actionId);
	}
}
