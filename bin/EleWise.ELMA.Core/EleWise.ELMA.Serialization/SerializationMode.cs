using Bridge;

namespace EleWise.ELMA.Serialization;

[Enum(/*Could not decode attribute arguments.*/)]
[External]
[Module("Reactive")]
[ObjectLiteral]
public enum SerializationMode
{
	Default,
	Full,
	FullWithInit
}
