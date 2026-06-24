using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Web.Mvc.Models.History;

public class HistoryItemView
{
	public IHistoryBaseModel HistoryModel { get; set; }

	public HistoryPartViewBlock ExtraBlock { get; set; }
}
