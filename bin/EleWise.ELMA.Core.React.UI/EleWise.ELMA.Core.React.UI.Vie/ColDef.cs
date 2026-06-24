using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class ColDef
{
	private string _003CSort_003Ek__BackingField;

	private bool _003CSortable_003Ek__BackingField;

	[Name("sort")]
	public string Sort
	{
		get
		{
			return _003CSort_003Ek__BackingField;
		}
		set
		{
			_003CSort_003Ek__BackingField = value;
		}
	}

	[Name("sortable")]
	public bool Sortable
	{
		get
		{
			return _003CSortable_003Ek__BackingField;
		}
		set
		{
			_003CSortable_003Ek__BackingField = value;
		}
	}
}
