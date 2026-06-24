using EleWise.ELMA.Files;

namespace EleWise.ELMA.Runtime.Managers;

public interface ITemplateFileManager
{
	string SaveTemplate(BinaryFile binaryFile);

	BinaryFile LoadTemplate(string id);

	BinaryFile CreateFromTemplate(string id);

	string GetTemplateFileServerPath(string id);
}
