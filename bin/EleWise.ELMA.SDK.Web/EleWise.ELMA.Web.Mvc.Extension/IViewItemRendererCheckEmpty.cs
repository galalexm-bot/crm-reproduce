using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public interface IViewItemRendererCheckEmpty
{
	bool? IsEmpty(ViewItem viewItem);
}
