namespace EleWise.ELMA.Model.Views;

public class TreeSelectFilterEventArgs : TreeSelectEventArgs
{
	private bool _003CResult_003Ek__BackingField = true;

	public bool Result
	{
		get
		{
			return _003CResult_003Ek__BackingField;
		}
		set
		{
			_003CResult_003Ek__BackingField = value;
		}
	}

	public TreeSelectFilterEventArgs(ITreeModel model)
		: base(model)
	{
	}
}
