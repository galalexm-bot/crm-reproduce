using Bridge;

namespace EleWise.ELMA.Model.Diagrammer.Events;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public class DiagrammerCopyEvent : BaseDiagrammerChangeEvent, IDiagrammerCopyEvent, IDiagrammerChangeEvent
{
	private string[] _003CElements_003Ek__BackingField;

	public string[] Elements
	{
		get
		{
			return _003CElements_003Ek__BackingField;
		}
		set
		{
			_003CElements_003Ek__BackingField = value;
		}
	}

	public override void Apply(IDiagrammerElement element)
	{
	}
}
