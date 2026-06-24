using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Common.Models;

public interface ICommentedHistoryModel : IHistoryBaseModel
{
	IComment Comment { get; set; }
}
