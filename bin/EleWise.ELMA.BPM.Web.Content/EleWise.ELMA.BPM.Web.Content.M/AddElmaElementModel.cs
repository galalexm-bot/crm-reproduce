using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class AddElmaElementModel
{
	public List<ActionWizardItemModel> Actions { get; set; }

	public List<ActionWizardItemModel> Links { get; set; }

	public ActionWizardSettings Settings { get; set; }
}
