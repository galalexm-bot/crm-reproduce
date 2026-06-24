using EleWise.ELMA.Model.Validation;

namespace EleWise.ELMA.Core.Controllers;

public interface IOnValidate
{
	ValidationResult OnValidate();
}
