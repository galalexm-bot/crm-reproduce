using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IQueryFunctionResult
{
	string FunctionName { get; }

	object GetValue(EntityMetadata metadata, string propName, object[] parameters);
}
