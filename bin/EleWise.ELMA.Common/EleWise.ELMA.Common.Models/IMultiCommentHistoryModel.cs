using System.Collections.Generic;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Common.Models;

public interface IMultiCommentHistoryModel : IHistoryBaseModel
{
	ICollection<IComment> Comments { get; set; }
}
