using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Common.Models;

public interface ICommentActionModel : IAutoImplement
{
	[DisplayName(typeof(__Resources_ICommentActionModel), "P_Comment_DisplayName")]
	IComment Comment { get; set; }

	[DisplayName(typeof(__Resources_ICommentActionModel), "P_Attachments_DisplayName")]
	IList<IAttachment> Attachments { get; set; }

	[DisplayName(typeof(__Resources_ICommentActionModel), "P_CopiedAttachments_DisplayName")]
	IList<IAttachment> CopiedAttachments { get; set; }
}
