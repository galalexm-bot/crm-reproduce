using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class AddWpiSelectListItemViewModel : FormViewModel
{
	public IWpiSelectListItem Entity { get; set; }
}
