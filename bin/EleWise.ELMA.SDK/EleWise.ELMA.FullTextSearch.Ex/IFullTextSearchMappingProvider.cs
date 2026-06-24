using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFullTextSearchMappingProvider : IFullTextSearchProvider
{
	void UpdateMapping();

	void UpdateMapping(Type cardType);
}
