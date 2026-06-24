namespace EleWise.ELMA.Model.Views;

public interface ICustomViewNameViewItem : IViewItem, IReactive
{
	string CustomViewName { get; set; }
}
