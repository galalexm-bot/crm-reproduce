using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Files.Previews;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IFilePreviewCreator
{
	Guid Uid { get; }

	string DisplayName { get; }

	List<string> Extensions { get; }

	string GetMainFileName(BinaryFile file);

	string GetTextFileName(BinaryFile file);

	string GetRelativeMainFileName(BinaryFile file);

	void Create(string path, BinaryFile file);

	bool IsAvaliable(BinaryFile file);

	bool HasPreview(BinaryFile file);

	bool HasPreview(BinaryFile file, long priority);

	string GetPreviewText(BinaryFile file);

	bool EnableGenerateHtml();
}
