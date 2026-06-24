using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Models;

public interface IHideEmptyViewItemContainerModel
{
	void AddHideEmpty(IViewItem viewItem, IHideEmptyContainerModel hideEmptyModel);

	IHideEmptyContainerModel FindHideEmpty(IViewItem viewItem);

	void RemoveHideEmpty(IViewItem viewItem);

	IHideEmptyContainerModel FindOwner(IViewItem viewItem);

	bool IsHideEmpty(IViewItem viewItem);

	void Destroy();
}
