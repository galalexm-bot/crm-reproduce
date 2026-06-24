using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public sealed class ReplaceModelMetadata : IReplaceModelMetadata
{
	private readonly string fullTypeName;

	public ICodeItemMetadata Metadata { get; }

	public ICodeItemMetadata RootMetadata { get; }

	public string ModuleName { get; }

	public ReplaceModelMetadata(ICodeItemMetadata metadata, string moduleName)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Metadata = metadata;
		ModuleName = moduleName;
	}

	public ReplaceModelMetadata(ICodeItemMetadata rootMetadata, ICodeItemMetadata metadata, string moduleName)
		: this(metadata, moduleName)
	{
		RootMetadata = rootMetadata;
	}

	public ReplaceModelMetadata(ICodeItemMetadata metadata, string moduleName, string fullTypeName)
		: this(metadata, moduleName)
	{
		this.fullTypeName = fullTypeName;
	}

	public string GetFullTypeName()
	{
		if (!string.IsNullOrWhiteSpace(fullTypeName))
		{
			return fullTypeName;
		}
		if (RootMetadata != null)
		{
			return Metadata.Namespace + "." + RootMetadata.Name + "." + Metadata.Name;
		}
		return Metadata.FullTypeName;
	}
}
