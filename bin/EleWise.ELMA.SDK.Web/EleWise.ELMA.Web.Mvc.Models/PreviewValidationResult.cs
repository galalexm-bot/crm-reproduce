using System;

namespace EleWise.ELMA.Web.Mvc.Models;

internal sealed class PreviewValidationResult : IPreviewValidationResult
{
	public bool PreviewIsPossible { get; set; }

	public string ErrorMessage { get; set; }

	public Guid RendererUid { get; set; }
}
