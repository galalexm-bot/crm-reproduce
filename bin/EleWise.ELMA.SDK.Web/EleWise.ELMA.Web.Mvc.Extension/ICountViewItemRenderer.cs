using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public interface ICountViewItemRenderer
{
	long? Count(object model, ICountViewItem viewItem);
}
