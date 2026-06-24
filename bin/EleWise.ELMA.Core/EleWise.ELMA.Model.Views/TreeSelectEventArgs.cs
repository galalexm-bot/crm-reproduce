namespace EleWise.ELMA.Model.Views;

public class TreeSelectEventArgs
{
	private ITreeModel _003CModel_003Ek__BackingField;

	public ITreeModel Model
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

	public TreeSelectEventArgs(ITreeModel model)
	{
		Model = model;
	}
}
