using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public sealed class DiagrammerTerminalChangeEvent : BaseDiagrammerChangeEvent, IDiagrammerTerminalChangeEvent, IDiagrammerChangeEvent
{
	private bool _003CSource_003Ek__BackingField;

	private string _003CTerminal_003Ek__BackingField;

	private double _003CTerminalX_003Ek__BackingField;

	private double _003CTerminalY_003Ek__BackingField;

	public bool Source
	{
		get
		{
			return _003CSource_003Ek__BackingField;
		}
		set
		{
			_003CSource_003Ek__BackingField = value;
		}
	}

	public string Terminal
	{
		get
		{
			return _003CTerminal_003Ek__BackingField;
		}
		set
		{
			_003CTerminal_003Ek__BackingField = value;
		}
	}

	public double TerminalX
	{
		get
		{
			return _003CTerminalX_003Ek__BackingField;
		}
		set
		{
			_003CTerminalX_003Ek__BackingField = value;
		}
	}

	public double TerminalY
	{
		get
		{
			return _003CTerminalY_003Ek__BackingField;
		}
		set
		{
			_003CTerminalY_003Ek__BackingField = value;
		}
	}

	public override void Apply(IDiagrammerElement element)
	{
		if (element is IDiagrammerTransition diagrammerTransition)
		{
			if (Source)
			{
				diagrammerTransition.Source = Terminal;
				diagrammerTransition.SourceX = TerminalX;
				diagrammerTransition.SourceY = TerminalY;
			}
			else
			{
				diagrammerTransition.Target = Terminal;
				diagrammerTransition.TargetX = TerminalX;
				diagrammerTransition.TargetY = TerminalY;
			}
		}
	}
}
