namespace EleWise.ELMA.CAB.UIElements;

public interface IUIElementAdapterFactory
{
	IUIElementAdapter GetAdapter(object uiElement);

	bool Supports(object uiElement);
}
