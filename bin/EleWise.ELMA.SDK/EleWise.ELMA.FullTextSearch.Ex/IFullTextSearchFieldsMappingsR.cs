using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface IFullTextSearchFieldsMappingsReIndexingExtension : IFullTextSearchFieldsMappingsExtension, IModuleFullTextSearchExtension
{
	void DisableIndexing(string disableInfo);
}
