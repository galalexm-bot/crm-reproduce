using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Serialization;

internal interface IReferenceResolver
{
	object ResolveReference(string reference);

	void AddReference(string reference, object value);

	bool TryGetReference(object value, IMetadata metadata, out string reference);
}
