using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class LastObjectInfoViewModel
{
	public List<ILastObjectInfo> DisplayInfos { get; set; }

	public virtual string ModelId => Guid.NewGuid().ToString();

	public string GetContextMenuClass(Guid entityType, ReferenceOnEntity entity)
	{
		ILastObjectRenderer rendererLastObject = GetRendererLastObject(entityType, entity);
		if (rendererLastObject == null || !rendererLastObject.HasContextMenu(entity))
		{
			return string.Empty;
		}
		return rendererLastObject.ContextMenuName;
	}

	public bool HasContextMenu()
	{
		return DisplayInfos.Any((ILastObjectInfo i) => GetRendererLastObject(i.ObjectType.TypeUid, i.Object)?.HasContextMenu(i.Object) ?? false);
	}

	public bool HasContextMenu(Guid entityType, ReferenceOnEntity entity)
	{
		return GetRendererLastObject(entityType, entity)?.HasContextMenu(entity) ?? false;
	}

	public ILastObjectRenderer GetRendererLastObject(Guid entityType, ReferenceOnEntity entity)
	{
		return ComponentManager.Current.GetExtensionPoints<ILastObjectRenderer>().FirstOrDefault((ILastObjectRenderer p) => p.TypeUid == entityType);
	}

	public MvcHtmlString RenderLastObject(HtmlHelper helper, Guid entityType, ReferenceOnEntity entity)
	{
		ILastObjectRenderer rendererLastObject = GetRendererLastObject(entityType, entity);
		if (rendererLastObject == null)
		{
			return PartialExtensions.Partial(helper, "DisplayTemplates/ReferenceOnEntity", (object)entity);
		}
		return rendererLastObject.Render(helper, entity);
	}

	public LastObjectInfoViewModel()
	{
		DisplayInfos = new List<ILastObjectInfo>();
	}
}
