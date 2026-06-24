using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

internal class TelerikGridViewDataContainer<T> : IViewDataContainer
{
	public ViewDataDictionary ViewData { get; set; }

	public TelerikGridViewDataContainer(T model, ViewDataDictionary viewData)
	{
		ViewData = viewData;
		ViewData.set_Model((object)model);
	}
}
