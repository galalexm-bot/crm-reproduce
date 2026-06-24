namespace EleWise.ELMA.Model.Views;

internal class PropertyDescriptionViewItem : PropertyViewItem
{
	public override bool ReadOnlyEnabled => false;

	public override bool FocusableEnabled => false;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
