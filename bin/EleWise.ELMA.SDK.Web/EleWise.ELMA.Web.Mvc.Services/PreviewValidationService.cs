using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Web.Mvc.Components.Previews;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

[Service(EnableInterceptors = false, Type = ComponentType.Web)]
internal class PreviewValidationService : IPreviewValidationService
{
	private readonly IFilePreviewService filePreviewService;

	private readonly IEnumerable<IFilePreviewCreatorRenderer> filePreviewCreatorRenderers;

	private readonly IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators;

	public PreviewValidationService(IFilePreviewService filePreviewService, IEnumerable<IFilePreviewCreatorRenderer> filePreviewCreatorRenderers, IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators)
	{
		this.filePreviewService = filePreviewService;
		this.filePreviewCreatorRenderers = filePreviewCreatorRenderers;
		this.extendedFilePermissionValidators = extendedFilePermissionValidators;
	}

	public IPreviewValidationResult HasPreviewValidation(IPreviewValidationParams parameters)
	{
		BinaryFile binaryFile = parameters.BinaryFile;
		PreviewValidationResult previewValidationResult = new PreviewValidationResult();
		if (binaryFile != null)
		{
			string errorMessageOut = "";
			previewValidationResult.PreviewIsPossible = extendedFilePermissionValidators.All((IExtendedFilePermissionValidator v) => v.HasPermission(binaryFile, out errorMessageOut));
			previewValidationResult.ErrorMessage = errorMessageOut;
		}
		else
		{
			previewValidationResult.PreviewIsPossible = true;
			previewValidationResult.ErrorMessage = "";
		}
		if (!filePreviewService.IsSupportPreview(binaryFile))
		{
			previewValidationResult.PreviewIsPossible = false;
		}
		IFilePreviewCreator creator = filePreviewService.GetPreviewCreator(binaryFile);
		if (creator == null || !creator.IsAvaliable(binaryFile))
		{
			previewValidationResult.PreviewIsPossible = false;
		}
		if (creator != null)
		{
			IFilePreviewCreatorRenderer filePreviewCreatorRenderer = filePreviewCreatorRenderers.FirstOrDefault((IFilePreviewCreatorRenderer r) => r.CreatorType == creator.GetType());
			if (filePreviewCreatorRenderer != null)
			{
				previewValidationResult.RendererUid = filePreviewCreatorRenderer.Uid;
			}
		}
		return previewValidationResult;
	}
}
