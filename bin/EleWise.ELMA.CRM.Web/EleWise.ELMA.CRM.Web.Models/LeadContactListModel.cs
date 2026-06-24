using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadContactListModel
{
	public string FilterQuery { get; set; }

	[DisplayName("Контакты")]
	public IList<ILeadContact> LeadContacts { get; set; }
}
