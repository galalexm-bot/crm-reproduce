using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Settings;

public interface IMvcValidatableTypeSettings
{
	void ApplyValidationRules(ICollection<ModelClientValidationRule> rules, ModelMetadata metadata, ControllerContext context, TypeSettings originalPropertySettings);
}
