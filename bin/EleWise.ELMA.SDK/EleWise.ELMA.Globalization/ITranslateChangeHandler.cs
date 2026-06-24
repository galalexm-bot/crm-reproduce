using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Globalization;

[ExtensionPoint(ComponentType.All)]
public interface ITranslateChangeHandler
{
	void Execute();
}
