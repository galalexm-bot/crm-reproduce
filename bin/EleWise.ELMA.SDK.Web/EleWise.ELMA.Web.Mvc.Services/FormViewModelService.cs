using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;

namespace EleWise.ELMA.Web.Mvc.Services;

[Service]
internal sealed class FormViewModelService : IFormViewModelService
{
	private IEnumerable<IOpenFormProvider> openFormProviders;

	private ISecurityService securityService;

	public FormViewModelService(IEnumerable<IOpenFormProvider> openFormProviders, ISecurityService securityService)
	{
		this.openFormProviders = openFormProviders;
		this.securityService = securityService;
	}

	public EntityFormModel GetEntityFormModel(IEntity entity, Guid viewFormUid)
	{
		if (entity == null)
		{
			return null;
		}
		entity = entity.CastAsRealType();
		Type type = entity.GetType();
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		if (entityMetadata == null)
		{
			throw new MetadataLoadException(SR.T("Не удалось загрузить метаданные сущности"));
		}
		EntityFormInfo entityFormInfo = (openFormProviders.FirstOrDefault((IOpenFormProvider q) => q.CheckType(entityMetadata.ImplementationUid)) ?? throw new ElmaInvalidOperationException(SR.T("Не найден провайдер для открытия формы"))).GetFormInfo(formBindingModel: new FormBindingModel
		{
			FormUid = viewFormUid,
			TypeUid = entityMetadata.ImplementationUid,
			ReadOnly = true,
			ViewType = ViewType.Display
		}, typeUid: entityMetadata.ImplementationUid, entity: entity, viewItemId: "");
		entityFormInfo.FormId = "Form" + entityFormInfo.CreatorPrefix;
		entityFormInfo.Route.Add("formId", entityFormInfo.FormId);
		entityFormInfo.TypeUid = entityMetadata.ImplementationUid;
		entityFormInfo.EntityId = entity.GetId().ToString();
		EntityFormModel result = new EntityFormModel(entityFormInfo)
		{
			CanEdit = securityService.HasPermission(CommonPermissions.Edit, entity)
		};
		ViewItemControl<ViewItem, object, object>.HideMode = ViewItemHideMode.Modal;
		return result;
	}
}
