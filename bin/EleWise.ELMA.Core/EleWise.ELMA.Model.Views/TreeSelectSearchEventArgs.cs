namespace EleWise.ELMA.Model.Views;

public sealed class TreeSelectSearchEventArgs : TreeSelectFilterEventArgs
{
	private readonly string _003CSearchString_003Ek__BackingField;

	public string SearchString => _003CSearchString_003Ek__BackingField;

	public TreeSelectSearchEventArgs(string searchString, ITreeModel model)
		: base(model)
	{
		_003CSearchString_003Ek__BackingField = searchString;
	}
}
