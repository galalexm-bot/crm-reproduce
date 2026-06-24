using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Documents.Models;

public interface IDocumentAttachedHistoryModel : IAttachedHistoryModel, IHistoryBaseModel
{
	ICollection<IDocumentAttachment> DocumentAttachments { get; set; }
}
