using Bridge;

namespace EleWise.ELMA.Serialization;

[Convention(/*Could not decode attribute arguments.*/)]
[ObjectLiteral]
[External]
[Module("Reactive")]
public sealed class SerializationSettings
{
	private SerializationMode _003CMode_003Ek__BackingField;

	private bool _003CWriteReferences_003Ek__BackingField;

	private bool _003CUseOriginalReferencesIfExists_003Ek__BackingField;

	private IReferenceResolver _003CReferenceResolver_003Ek__BackingField;

	public SerializationMode Mode
	{
		get
		{
			return _003CMode_003Ek__BackingField;
		}
		set
		{
			_003CMode_003Ek__BackingField = value;
		}
	}

	internal bool WriteReferences
	{
		get
		{
			return _003CWriteReferences_003Ek__BackingField;
		}
		set
		{
			_003CWriteReferences_003Ek__BackingField = value;
		}
	}

	internal bool UseOriginalReferencesIfExists
	{
		get
		{
			return _003CUseOriginalReferencesIfExists_003Ek__BackingField;
		}
		set
		{
			_003CUseOriginalReferencesIfExists_003Ek__BackingField = value;
		}
	}

	internal IReferenceResolver ReferenceResolver
	{
		get
		{
			return _003CReferenceResolver_003Ek__BackingField;
		}
		set
		{
			_003CReferenceResolver_003Ek__BackingField = value;
		}
	}
}
