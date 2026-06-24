using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;

namespace EleWise.ELMA.Components.SettingsChecker;

internal sealed class AnyTypeSettingsChecker : BaseSettingsChecker<AnyTypeSettings>
{
	protected override System.Collections.Generic.IEnumerable<string> Check(AnyTypeSettings settings)
	{
		if (string.IsNullOrWhiteSpace(settings.get_FullTypeName()))
		{
			return new string[1] { SR.T("Не заполнена настройка \"Полное имя типа\"") };
		}
		return (System.Collections.Generic.IEnumerable<string>)Enumerable.Empty<string>();
	}
}
