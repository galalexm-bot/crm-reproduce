using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Globalization;

[ExtensionPoint(ComponentType.All)]
public interface ILocalizationFileResolver
{
	string FileName { get; }

	IEnumerable<PoLineDescriptor> CollectResources(LocalizationLoadSettings settings);
}
