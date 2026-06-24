using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.CodeGeneration;

public interface IMetadataGeneratorService
{
	ICodeGenerator GetCodeGenerator(IMetadata metadata);
}
