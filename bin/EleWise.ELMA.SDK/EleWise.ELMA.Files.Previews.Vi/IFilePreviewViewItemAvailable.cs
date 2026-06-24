using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.Previews.ViewItems;

[ExtensionPoint(ComponentType.All)]
public interface IFilePreviewViewItemAvailable
{
	bool IsAvailable(IMetadata metadata);

	BinaryFile GetFile(object model);
}
