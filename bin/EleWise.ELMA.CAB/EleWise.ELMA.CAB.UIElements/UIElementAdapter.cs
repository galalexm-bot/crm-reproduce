using System;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.UIElements;

public abstract class UIElementAdapter<TUIElement> : IUIElementAdapter
{
	public object Add(object uiElement)
	{
		Guard.ArgumentNotNull(uiElement, "uiElement");
		TUIElement typedElement = GetTypedElement(uiElement);
		return Add(typedElement);
	}

	public void Remove(object uiElement)
	{
		Guard.ArgumentNotNull(uiElement, "uiElement");
		TUIElement typedElement = GetTypedElement(uiElement);
		Remove(typedElement);
	}

	protected abstract TUIElement Add(TUIElement uiElement);

	protected abstract void Remove(TUIElement uiElement);

	private TUIElement GetTypedElement(object uiElement)
	{
		if (!(uiElement is TUIElement))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.UIElementNotCorrectType, new object[1] { typeof(TUIElement) }));
		}
		return (TUIElement)uiElement;
	}
}
