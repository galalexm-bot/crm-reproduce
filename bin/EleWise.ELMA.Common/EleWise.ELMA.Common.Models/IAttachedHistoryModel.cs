using System.Collections.Generic;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Common.Models;

public interface IAttachedHistoryModel : IHistoryBaseModel
{
	ICollection<IAttachment> Attachments { get; set; }
}
