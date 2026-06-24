namespace EleWise.ELMA.Model.Views;

public interface ICustomViewItem : ICustomViewNameViewItem, IViewItem, IReactive
{
	bool UseOriginalModel { get; set; }
}
