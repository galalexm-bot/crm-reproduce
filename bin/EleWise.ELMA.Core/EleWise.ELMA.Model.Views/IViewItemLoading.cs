namespace EleWise.ELMA.Model.Views;

public interface IViewItemLoading : IViewItem, IReactive
{
	ViewItemLoadingType LoadingType { get; set; }
}
