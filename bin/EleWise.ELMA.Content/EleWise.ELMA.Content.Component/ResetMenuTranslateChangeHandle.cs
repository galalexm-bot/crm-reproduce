using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Globalization;

namespace EleWise.ELMA.Content.Components;

[Component]
public class ResetMenuTranslateChangeHandler : ITranslateChangeHandler
{
	public void Execute()
	{
		MenuManager.Instance.ResetCache();
	}
}
