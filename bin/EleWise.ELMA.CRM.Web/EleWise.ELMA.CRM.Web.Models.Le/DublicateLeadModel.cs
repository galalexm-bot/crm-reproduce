using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.CRM.Web.Models.Lead;

public class DublicateLeadModel
{
	public ILead ThisLead { get; set; }

	[DisplayName(typeof(DublicateLeadModel_SR), "To")]
	public DublicateLeadLink Link { get; set; }

	[RequiredField]
	public IContractor Contractor { get; set; }

	[RequiredField]
	public ILead Lead { get; set; }

	[RequiredField]
	public ISale Sale { get; set; }

	[DisplayName(typeof(DublicateLeadModel_SR), "CopyContacts")]
	public bool CopyContacts { get; set; }

	[StringSettings(MultiLine = true, FieldName = "Comment")]
	[DisplayName(typeof(DublicateLeadModel_SR), "Comment")]
	public string Comment { get; set; }

	public DublicateLeadModel()
	{
	}

	public DublicateLeadModel(ILead lead)
	{
		ThisLead = lead;
		Link = DublicateLeadLink.Contractor;
	}

	public void Dublicate()
	{
		LeadManager.Instance.Dublicate(ThisLead, Comment, CopyContacts, (Link == DublicateLeadLink.Contractor) ? Contractor : null, (Link == DublicateLeadLink.Lead) ? Lead : null, (Link == DublicateLeadLink.Sale) ? Sale : null);
	}
}
