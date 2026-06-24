using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services;

public interface ICheckDataClassService
{
	ValidationResult Validate(DataClassMetadata dataClassMetadata);
}
