using System;
using EleWise.ELMA.Model.Validation;

namespace EleWise.ELMA.Core.React.Models;

public interface IViewModelValidationModel : IValidationModel
{
	void AddValidator(Func<ValidationResult> validateFunc, string name = "");

	void RemoveValidator(Func<ValidationResult> validateFunc);

	void Destroy();
}
