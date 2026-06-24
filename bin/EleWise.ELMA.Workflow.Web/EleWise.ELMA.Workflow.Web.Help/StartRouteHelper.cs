using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Helpers;

public static class StartRouteHelper
{
	public static StartRouteRunInfo RunStartRoute<TModel, TModelId>(BPMController<TModel, TModelId> controller, IStartRouteInfo info) where TModel : IEntity<TModelId>
	{
		return new StartRouteRunInfo();
	}

	public static List<PropertyMetadata> GetInputContextVars(Guid objectType, RelationType? relationType, long processHeadId, string text = "", List<object> objectsId = null)
	{
		return new List<PropertyMetadata>();
	}
}
