using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

public interface IPreviewValidationService
{
	IPreviewValidationResult HasPreviewValidation(IPreviewValidationParams parameters);
}
