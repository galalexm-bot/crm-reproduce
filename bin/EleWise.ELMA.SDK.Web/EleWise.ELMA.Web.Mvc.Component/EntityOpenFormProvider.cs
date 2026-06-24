using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = 20)]
internal class EntityOpenFormProvider : IOpenFormProvider
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IEnumerable<IFormCreator> formCreators;

	public EntityOpenFormProvider(IMetadataRuntimeService metadataRuntimeService, IEnumerable<IFormCreator> formCreators)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.formCreators = formCreators;
	}

	public bool CheckType(Guid typeUid)
	{
		Type typeByUidOrNull = metadataRuntimeService.GetTypeByUidOrNull(typeUid);
		if (typeByUidOrNull != null)
		{
			return MetadataLoader.LoadMetadata(typeByUidOrNull) is EntityMetadata;
		}
		return false;
	}

	public EntityFormInfo GetFormInfo(Guid typeUid, IEntity entity, FormBindingModel formBindingModel, string viewItemId)
	{
		Type type = metadataRuntimeService.GetTypeByUidOrNull(typeUid);
		if (type == null)
		{
			return null;
		}
		List<IFormCreator> list = formCreators.Where((IFormCreator c) => c.CheckType(type)).ToList();
		if (!list.Any())
		{
			return null;
		}
		IFormCreator formCreator;
		if (list.Count == 1)
		{
			formCreator = list.First();
		}
		else
		{
			formCreator = list.FirstOrDefault((IFormCreator c) => !c.IsBase);
			if (formCreator == null)
			{
				return null;
			}
		}
		EntityFormInfo entityFormInfo = new EntityFormInfo
		{
			Action = formCreator.Action(type),
			Controller = formCreator.Controller(type),
			PostAction = formCreator.PostAction(type),
			PostRoute = formCreator.PostRoute(type),
			PostController = formCreator.PostController(type),
			CreatorPrefix = "Bind" + UIExtensions.PrepareId(Guid.NewGuid().ToString()),
			OnSubmitScript = formCreator.OnSubmitScript,
			ParameterName = formCreator.ParameterName(type)
		};
		entityFormInfo.Route = formCreator.Route(type, entityFormInfo.CreatorPrefix, entity, formBindingModel);
		return entityFormInfo;
	}
}
