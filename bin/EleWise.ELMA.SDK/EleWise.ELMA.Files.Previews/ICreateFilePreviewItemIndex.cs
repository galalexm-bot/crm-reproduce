using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Files.Previews;

[ExtensionPoint(ComponentType.All)]
public interface ICreateFilePreviewItemIndex
{
	Guid Uid { get; }

	void AddPreviewToIndexQueue(BinaryFile file);
}
