namespace EleWise.ELMA.Model.Views;

public sealed class TypeSettingsViewParams
{
	private bool _003CIsEntity_003Ek__BackingField = true;

	private bool _003CCanUseOneToMany_003Ek__BackingField = true;

	public bool IsEntity
	{
		get
		{
			return _003CIsEntity_003Ek__BackingField;
		}
		set
		{
			_003CIsEntity_003Ek__BackingField = value;
		}
	}

	public bool CanUseOneToMany
	{
		get
		{
			return _003CCanUseOneToMany_003Ek__BackingField;
		}
		set
		{
			_003CCanUseOneToMany_003Ek__BackingField = value;
		}
	}
}
