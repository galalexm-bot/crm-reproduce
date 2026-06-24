using System.Diagnostics;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Files.Previews;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IFilePreviewCreatorEx : IFilePreviewCreator
{
	string ExternalCreatorFileName { get; }

	bool RequiredExternalCreator { get; }

	string GetExternalCreatorFileName(BinaryFile file);

	Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file);
}
