using System.Collections.Generic;

namespace EleWise.ELMA.Files.Previews;

internal interface IMultiFilePreviewCreator
{
	IEnumerable<string> GetPreviewFilesList(BinaryFile file);

	long GetTextPreviewFilesSize(BinaryFile file);
}
