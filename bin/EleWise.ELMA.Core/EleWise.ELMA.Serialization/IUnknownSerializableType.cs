namespace EleWise.ELMA.Serialization;

internal interface IUnknownSerializableType
{
	string GetTypeName();

	void OnSerializedMethod(UnknownObjectWrapper raw);

	void OnDeserializedMethod(object raw);
}
