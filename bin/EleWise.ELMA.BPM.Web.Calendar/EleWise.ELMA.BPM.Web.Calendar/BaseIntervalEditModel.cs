using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class BaseIntervalEditModel : FormViewModel
{
	public IBaseTimeInterval Entity { get; set; }

	public string Prefix { get; set; }
}
