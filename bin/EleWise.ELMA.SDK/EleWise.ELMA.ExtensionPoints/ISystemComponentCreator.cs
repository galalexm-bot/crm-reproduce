using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ISystemComponentCreator
{
	ComponentMetadataItem Create();
}
