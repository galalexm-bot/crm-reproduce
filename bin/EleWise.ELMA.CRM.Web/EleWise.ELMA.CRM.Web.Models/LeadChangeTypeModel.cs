using System.Collections.Generic;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadChangeTypeModel
{
	public long[] LeadsId { get; set; }

	[DisplayName(typeof(LeadChangeTypeModel_SR), "Type")]
	public ICollection<ILeadType> Types { get; set; }

	public bool Save(out string leadsWithoutEditAccess)
	{
		bool result = false;
		leadsWithoutEditAccess = string.Empty;
		long[] leadsId = LeadsId;
		foreach (long id in leadsId)
		{
			ILead lead = LeadManager.Instance.Load(id);
			if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditLeadPermission, lead))
			{
				leadsWithoutEditAccess = leadsWithoutEditAccess + lead.Name + ", ";
				continue;
			}
			result = true;
			((ICollection<ILeadType>)lead.Types).Clear();
			if (Types != null)
			{
				lead.Types.AddAll(Types);
			}
			if (lead.Responsible == null)
			{
				lead.Responsible = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			}
			lead.Save();
		}
		if (leadsWithoutEditAccess != string.Empty)
		{
			leadsWithoutEditAccess = leadsWithoutEditAccess.Remove(leadsWithoutEditAccess.Length - 2);
		}
		return result;
	}
}
