using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IReplaceModelMetadata
{
	ICodeItemMetadata Metadata { get; }

	ICodeItemMetadata RootMetadata { get; }

	string ModuleName { get; }

	string GetFullTypeName();
}
