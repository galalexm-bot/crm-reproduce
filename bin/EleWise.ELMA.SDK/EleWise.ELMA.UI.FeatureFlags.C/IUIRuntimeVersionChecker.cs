using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.UI.FeatureFlags.Components;

[ExtensionPoint(ComponentType.All)]
public interface IUIRuntimeVersionChecker
{
	RuntimeVersion CheckRuntimeVersion();
}
