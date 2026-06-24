using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

public static class ProcessToolbarWorkflow
{
	public static StartRouteButtonInfo CreateStartRouteButtonInfo(CatalogItemModel model)
	{
		long num = 0L;
		if (model.Id is long)
		{
			num = (long)model.Id;
			return new StartRouteButtonInfo
			{
				ObjectType = model.TypeUid,
				ObjectId = num,
				ImageUrl = "#play.svg",
				Caption = SR.T("Для отправки проекта введите название экземпляра, укажите<br/>маршрут и нажмите Enter или \"Отправить\".:"),
				PopupId = $"StartProcessByRoutePopup_{num}"
			};
		}
		return null;
	}

	public static StartRouteButtonInfo CreateStartRouteButtonInfoFromList(CatalogViewModel model)
	{
		long objectId = 0L;
		return new StartRouteButtonInfo
		{
			ObjectType = model.Metadata.Uid,
			ObjectId = objectId,
			ImageUrl = "#play.svg",
			Caption = SR.T("Для отправки проекта введите название экземпляра, укажите<br/>маршрут и нажмите Enter или \"Отправить\".:"),
			PopupId = "StartProcessByRoutePopup"
		};
	}
}
