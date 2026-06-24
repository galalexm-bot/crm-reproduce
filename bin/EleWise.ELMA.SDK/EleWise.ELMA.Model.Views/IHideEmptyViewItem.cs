namespace EleWise.ELMA.Model.Views;

public interface IHideEmptyViewItem
{
	HideEmptyEnum HideEmptySettings { get; set; }

	bool IsHideEmpty(RootViewItem parent = null);
}
