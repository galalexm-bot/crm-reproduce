using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Tasks.Models;

public interface IQuestionedHistoryModel : IHistoryBaseModel
{
	IQuestion Question { get; set; }
}
