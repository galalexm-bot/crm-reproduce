using System.ComponentModel.Composition;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[InheritedExport]
public interface IControllerNamespaceMap
{
	string Route { get; }

	string[] Namespaces { get; }

	object Defaults { get; }

	object Constraints { get; }
}
