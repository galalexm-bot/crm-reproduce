using System.Collections.Generic;

namespace EleWise.ELMA.CAB.UIElements;

public interface IUIElementAdapterFactoryCatalog
{
	IList<IUIElementAdapterFactory> Factories { get; }

	IUIElementAdapterFactory GetFactory(object element);

	void RegisterFactory(IUIElementAdapterFactory factory);
}
