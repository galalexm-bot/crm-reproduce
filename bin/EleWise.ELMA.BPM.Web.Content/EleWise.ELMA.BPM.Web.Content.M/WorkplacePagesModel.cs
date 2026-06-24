using System.Collections.Generic;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class WorkplacePagesModel
{
	public OrganizerModel OrganizerModel { get; set; }

	public IWorkplacePages Entity { get; set; }

	public ICollection<IHomePageSetting> Pages { get; set; }

	public string ReturnUrl { get; set; }

	public ICollection<IWorkPlace> Workplaces { get; set; }

	public bool ReadOnly { get; set; }
}
