using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class CustomizerModel
{
	public IWorkPlace WorkPlace { get; set; }

	public IUser User { get; set; }

	public bool TranslationEnabled { get; set; }
}
