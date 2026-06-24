using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface ICodeItemMetadata : IMetadata, IXsiType
{
	string Name { get; set; }

	string DisplayName { get; set; }

	string Namespace { get; set; }

	string NamespaceForDisplay { get; set; }

	string FullTypeName { get; }
}
