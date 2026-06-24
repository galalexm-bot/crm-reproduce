using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Type = ComponentType.Server)]
public class DocumentMetadataInitHandler : IInitHandler
{
	public void Init()
	{
	}

	public void InitComplete()
	{
		Locator.GetService<IDocumentMetadataProfileUpdaterService>().UpdateProfiles();
	}
}
