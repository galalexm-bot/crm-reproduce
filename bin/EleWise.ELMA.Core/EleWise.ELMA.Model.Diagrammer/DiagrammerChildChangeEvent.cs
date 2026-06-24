using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public sealed class DiagrammerChildChangeEvent : BaseDiagrammerChangeEvent, IDiagrammerChildChangeEvent, IDiagrammerChangeEvent
{
	private string _003CParent_003Ek__BackingField;

	private int _003CIndex_003Ek__BackingField;

	private string _003CPrevious_003Ek__BackingField;

	private int _003CPreviousIndex_003Ek__BackingField;

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

	public int Index
	{
		get
		{
			return _003CIndex_003Ek__BackingField;
		}
		set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}

	public string Previous
	{
		get
		{
			return _003CPrevious_003Ek__BackingField;
		}
		set
		{
			_003CPrevious_003Ek__BackingField = value;
		}
	}

	public int PreviousIndex
	{
		get
		{
			return _003CPreviousIndex_003Ek__BackingField;
		}
		set
		{
			_003CPreviousIndex_003Ek__BackingField = value;
		}
	}

	public override void Apply(IDiagrammerElement element)
	{
		if (element != null)
		{
			_ = element is IDiagrammerItem;
		}
	}
}
