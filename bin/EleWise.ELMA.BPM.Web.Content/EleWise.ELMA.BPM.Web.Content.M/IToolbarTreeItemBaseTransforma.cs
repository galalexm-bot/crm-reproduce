using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public interface IToolbarTreeItemBaseTransformation
{
	void Apply(HtmlHelper htmlHelper, IActionItem rootItem);
}
