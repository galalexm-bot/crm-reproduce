using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IViewModelTypeService
{
	bool Check(string metadataTypeCode);

	ViewModelTypeName GetViewPropertyModelType(IPropertyMetadata property, string metadataNamespace);

	ViewModelTypeName GetViewModelType(string metadataName, string metadataNamespace, bool useOriginalModel);
}
