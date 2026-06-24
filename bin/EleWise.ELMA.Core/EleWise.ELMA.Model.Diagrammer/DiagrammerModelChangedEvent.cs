namespace EleWise.ELMA.Model.Diagrammer;

public class DiagrammerModelChangedEvent
{
	private IDiagrammerModel _003CModel_003Ek__BackingField;

	private IDiagrammerChangeEvent[] _003CEvents_003Ek__BackingField;

	public IDiagrammerModel Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		set
		{
			_003CModel_003Ek__BackingField = value;
		}
	}

	public IDiagrammerChangeEvent[] Events
	{
		get
		{
			return _003CEvents_003Ek__BackingField;
		}
		set
		{
			_003CEvents_003Ek__BackingField = value;
		}
	}
}
