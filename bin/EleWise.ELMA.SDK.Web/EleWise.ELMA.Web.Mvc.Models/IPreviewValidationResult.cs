using System;

namespace EleWise.ELMA.Web.Mvc.Models;

public interface IPreviewValidationResult
{
	bool PreviewIsPossible { get; set; }

	string ErrorMessage { get; set; }

	Guid RendererUid { get; set; }
}
