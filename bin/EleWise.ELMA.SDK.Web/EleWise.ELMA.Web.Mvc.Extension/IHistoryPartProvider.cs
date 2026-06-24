using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IHistoryPartProvider
{
	IEnumerable<HistoryPartButton> GetButtons(HtmlHelper html, IEntity entity);

	IEnumerable<HistoryPartViewBlock> GetBlocks(HtmlHelper html, IHistoryBaseModel eventData);
}
