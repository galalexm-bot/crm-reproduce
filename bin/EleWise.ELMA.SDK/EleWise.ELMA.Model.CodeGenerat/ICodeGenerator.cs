using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.CodeGeneration;

public interface ICodeGenerator
{
	IMetadata Metadata { get; set; }

	GenerationParams GenerationParams { get; set; }

	GeneratedFileInfo GenerateMainFile();

	GeneratedFileInfo[] Generate();

	GeneratedFileInfo[] GenerateAdditionalFiles();
}
