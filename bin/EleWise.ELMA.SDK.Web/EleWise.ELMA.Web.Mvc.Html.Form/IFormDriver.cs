using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public interface IFormDriver<out TRowDriver> where TRowDriver : IRowDriver
{
	IEnumerable<TRowDriver> GetRowDrivers();
}
