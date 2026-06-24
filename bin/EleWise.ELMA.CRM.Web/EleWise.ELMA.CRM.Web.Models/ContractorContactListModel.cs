using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.Models;

public class ContractorContactListModel
{
	public string FilterQuery { get; set; }

	[DisplayName("Контакты")]
	public IList<IContact> ContractorContacts { get; set; }
}
