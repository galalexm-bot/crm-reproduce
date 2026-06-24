namespace EleWise.ELMA.Model.Views;

public interface IHideEmptyViewItem
{
	HideEmptyEnum HideEmpty { get; set; }

	bool IsHideable { get; }
}
