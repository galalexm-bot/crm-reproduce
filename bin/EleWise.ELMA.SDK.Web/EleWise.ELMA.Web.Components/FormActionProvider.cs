using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.Components;

[Component]
public class FormActionProvider : IControllerActionProvider
{
	[Obsolete("Нужно использовать SR.M при присваивании описаний в менюшках")]
	public List<string> LocalizedItemsNames => new List<string>();

	[Obsolete("Нужно использовать SR.M при присваивании описаний в менюшках")]
	public List<string> LocalizedItemsDescriptions => new List<string>();

	public IEnumerable<IContentAction> Actions()
	{
		yield return new ContentAction
		{
			Id = "EleWise.ELMA.Web.Components.FormActionProvider",
			NameForLocalization = SR.T("Открыть форму"),
			Category = SR.T("Формы"),
			Order = 0,
			ActionType = ContentAction.ActionTypeDialog,
			Image24 = "#pattern.svg",
			LinkTemplate = (RequestContext cc) => string.Empty
		};
	}

	public IEnumerable<IContentCategory> Categories()
	{
		return Enumerable.Empty<IContentCategory>();
	}
}
