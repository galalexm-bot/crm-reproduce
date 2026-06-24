namespace EleWise.ELMA.Model.Views;

public class HierarchicalChild
{
	private readonly string _003CPropertyName_003Ek__BackingField;

	private readonly int _003CDeep_003Ek__BackingField;

	private readonly int _003CIndent_003Ek__BackingField;

	public string PropertyName => _003CPropertyName_003Ek__BackingField;

	public int Deep => _003CDeep_003Ek__BackingField;

	public int Indent => _003CIndent_003Ek__BackingField;

	public HierarchicalChild()
	{
	}

	public HierarchicalChild(string propertyName, int deep, int indent)
	{
		_003CPropertyName_003Ek__BackingField = propertyName;
		_003CDeep_003Ek__BackingField = deep;
		_003CIndent_003Ek__BackingField = indent;
	}
}
