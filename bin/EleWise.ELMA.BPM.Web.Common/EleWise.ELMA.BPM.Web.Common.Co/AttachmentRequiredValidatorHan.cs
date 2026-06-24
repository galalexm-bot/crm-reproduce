using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class AttachmentRequiredValidatorHandler : IRequiredFieldValidatorHandler
{
	public void GetClientValidationRules(ModelValidator validator, ModelMetadata metadata, ControllerContext controllerContext, List<ModelClientValidationRule> rules, ModelClientValidationRule mainRule)
	{
		if (typeof(IAttachment).IsAssignableFrom(metadata.get_ModelType()) || typeof(BinaryFile).IsAssignableFrom(metadata.get_ModelType()))
		{
			mainRule.set_ValidationType("validateAttachmentRequired");
			mainRule.get_ValidationParameters().Clear();
			mainRule.get_ValidationParameters().Add("prefix", "_ValidationStub");
			return;
		}
		Type @interface = metadata.get_ModelType().GetInterface(typeof(IEnumerable<>).FullName);
		if (@interface != null && @interface.GetGenericArguments().Length != 0 && typeof(IAttachment).IsAssignableFrom(@interface.GetGenericArguments()[0]))
		{
			mainRule.set_ValidationType("validateAttachmentSetRequired");
			mainRule.get_ValidationParameters().Clear();
			mainRule.get_ValidationParameters().Add("prefix", "_ValidationStub");
		}
	}
}
