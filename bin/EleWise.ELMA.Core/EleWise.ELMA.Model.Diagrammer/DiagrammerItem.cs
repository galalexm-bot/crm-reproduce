namespace EleWise.ELMA.Model.Diagrammer;

public abstract class DiagrammerItem<TCloneable> : DiagrammerElement<TCloneable>, IDiagrammerItem, IDiagrammerElement, ICloneableObjectLiteral where TCloneable : IDiagrammerElement, new()
{
	private string _003CDisplayName_003Ek__BackingField;

	private DiagrammerItemType _003CType_003Ek__BackingField;

	private DiagrammerSize _003CSize_003Ek__BackingField;

	private DiagrammerPoint _003CPosition_003Ek__BackingField;

	private string _003CParent_003Ek__BackingField;

	public new string DisplayName
	{
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		set
		{
			_003CDisplayName_003Ek__BackingField = value;
		}
	}

	public DiagrammerItemType Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public override DiagrammerElementKind Kind => DiagrammerElementKind.Item;

	public DiagrammerSize Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	public DiagrammerPoint Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public string Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}
}
