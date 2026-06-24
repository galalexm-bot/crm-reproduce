using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Components.SettingsChecker;

[Component]
internal abstract class BaseSettingsChecker<T> : ISettingsChecker where T : TypeSettings
{
	protected abstract System.Collections.Generic.IEnumerable<string> Check(T settings);

	string[] ISettingsChecker.Check(TypeSettings settings)
	{
		if (settings == null)
		{
			return new string[1] { SR.T("Настройки не заполнены") };
		}
		if (settings is T settings2)
		{
			return Enumerable.ToArray<string>(Check(settings2));
		}
		return new string[0];
	}
}
