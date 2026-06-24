using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public sealed class DiagrammerGeometryChangeEvent : BaseDiagrammerChangeEvent, IDiagrammerGeometryChangeEvent, IDiagrammerChangeEvent
{
	private DiagrammerPoint _003CPosition_003Ek__BackingField;

	private DiagrammerSize _003CSize_003Ek__BackingField;

	private bool _003CRelative_003Ek__BackingField;

	private DiagrammerPoint[] _003CPoints_003Ek__BackingField;

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

	public bool Relative
	{
		get
		{
			return _003CRelative_003Ek__BackingField;
		}
		set
		{
			_003CRelative_003Ek__BackingField = value;
		}
	}

	public DiagrammerPoint[] Points
	{
		get
		{
			return _003CPoints_003Ek__BackingField;
		}
		set
		{
			_003CPoints_003Ek__BackingField = value;
		}
	}

	public override void Apply(IDiagrammerElement element)
	{
		if (element != null)
		{
			if (element is IDiagrammerItem diagrammerItem)
			{
				diagrammerItem.Size.Width = Size.Width;
				diagrammerItem.Size.Height = Size.Height;
				diagrammerItem.Position.X = Position.X;
				diagrammerItem.Position.Y = Position.Y;
			}
			else if (element is IDiagrammerTransition diagrammerTransition)
			{
				diagrammerTransition.Path = Points;
			}
		}
	}
}
