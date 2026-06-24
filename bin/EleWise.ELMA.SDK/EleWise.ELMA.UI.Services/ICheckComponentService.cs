using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services;

public interface ICheckComponentService
{
	ValidationResult Validate(ComponentMetadata componentMetadata);
}
