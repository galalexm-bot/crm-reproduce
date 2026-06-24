using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Files.Previews;

[DeveloperApi(DeveloperApiType.Service)]
public interface IFolderPreviewService
{
	string PreviewsPath { get; }

	string GetPreviewDirectory(Guid id);
}
