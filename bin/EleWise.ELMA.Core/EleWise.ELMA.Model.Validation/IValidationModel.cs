using System.Collections.Generic;

namespace EleWise.ELMA.Model.Validation;

public interface IValidationModel
{
	bool IsValid { get; }

	System.Collections.Generic.IReadOnlyCollection<ModelError> Errors { get; }

	ValidationResult GetSummaryResult();
}
