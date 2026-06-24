using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public abstract class BaseDiagrammerChangeEvent : IDiagrammerChangeEvent
{
	private string _003CTarget_003Ek__BackingField;

	private string _003CEventName_003Ek__BackingField;

	public string Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		set
		{
			_003CTarget_003Ek__BackingField = value;
		}
	}

	public string EventName
	{
		get
		{
			return _003CEventName_003Ek__BackingField;
		}
		set
		{
			_003CEventName_003Ek__BackingField = value;
		}
	}

	public abstract void Apply(IDiagrammerElement element);
}
