namespace EleWise.ELMA.Serialization;

internal interface IReferenceResolver
{
	bool TryGetReference(object value, out string reference);
}
