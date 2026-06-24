using System.Collections.Generic;
using EleWise.ELMA.Globalization.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public sealed class ExportTranslationConfigurationModel
{
	public string ExportFileName { get; set; }

	public IEnumerable<IExportLocalizationFileExtensionPoint> WizardStepExtensions { get; set; }

	public IDictionary<string, string> SettingsJsonData { get; set; }
}
