using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Types.Validation;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRequiredFieldValidatorHandler
{
	void GetClientValidationRules(ModelValidator validator, ModelMetadata metadata, ControllerContext controllerContext, List<ModelClientValidationRule> rules, ModelClientValidationRule mainRule);
}
