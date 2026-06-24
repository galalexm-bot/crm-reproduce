using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IActionInsertRuleProvider
{
	IEnumerable<ActionInsertRuleSet> Rules { get; }
}
