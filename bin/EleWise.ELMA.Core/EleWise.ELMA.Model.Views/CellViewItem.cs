namespace EleWise.ELMA.Model.Views;

internal sealed class CellViewItem : RootViewItem, IContainerViewItem
{
	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
