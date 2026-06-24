using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Models.Wizard;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWizardStep
{
	string Wizard { get; }

	int? Index { get; }

	[Obsolete("Этот метод устарел")]
	WizardItem GetStep(object model);

	WizardItem GetStep(HtmlHelper helper);
}
