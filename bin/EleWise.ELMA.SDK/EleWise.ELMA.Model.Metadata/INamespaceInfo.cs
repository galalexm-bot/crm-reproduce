using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Metadata;

[ExtensionPoint(ComponentType.All)]
public interface INamespaceInfo
{
	string Namespace { get; }

	string DisplayName { get; }
}
