using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

public interface ICrmAttachmentActionModel : IAutoImplement
{
	[DisplayName(typeof(__Resources_ICrmAttachmentActionModel), "P_Files_DisplayName")]
	IList<IAttachment> Files { get; set; }

	[DisplayName(typeof(__Resources_ICrmAttachmentActionModel), "P_Documents_DisplayName")]
	IList<IDocument> Documents { get; set; }

	[DisplayName(typeof(__Resources_ICrmAttachmentActionModel), "P_Comment_DisplayName")]
	string Comment { get; set; }
}
