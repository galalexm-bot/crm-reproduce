using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[InterfaceExtension(typeof(ICommentActionModel))]
public interface ICommentWithDocumentsActionModel : ICommentActionModel, IAutoImplement
{
	[DisplayName("Прикрепленные документы")]
	IList<IDocumentAttachment> DocumentAttachments { get; set; }

	[DisplayName("Документы для копирования в текущий объект")]
	IList<IDocumentAttachment> CopiedDocumentAttachments { get; set; }
}
