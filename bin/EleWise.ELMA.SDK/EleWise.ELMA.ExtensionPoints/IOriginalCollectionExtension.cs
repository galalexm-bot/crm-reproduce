using System.Collections;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IOriginalCollectionExtension
{
	bool Can(object obj);

	IEnumerable OriginalItems(object obj);
}
