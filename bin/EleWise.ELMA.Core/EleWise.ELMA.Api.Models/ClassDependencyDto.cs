namespace EleWise.ELMA.Api.Models;

public class ClassDependencyDto : DependencyDto
{
	private PropertySignatureDto[] _003CProperties_003Ek__BackingField;

	public PropertySignatureDto[] Properties
	{
		get
		{
			return _003CProperties_003Ek__BackingField;
		}
		set
		{
			_003CProperties_003Ek__BackingField = value;
		}
	}
}
