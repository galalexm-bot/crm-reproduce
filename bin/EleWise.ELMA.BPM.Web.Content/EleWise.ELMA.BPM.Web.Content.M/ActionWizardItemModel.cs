using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class ActionWizardItemModel
{
	public ILinkTypeProvider Provider { get; set; }

	public ActionWizardItemAttribute Attribute { get; set; }
}
