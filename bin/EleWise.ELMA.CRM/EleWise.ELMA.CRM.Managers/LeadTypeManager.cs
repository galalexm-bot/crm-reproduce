using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Managers;

public class LeadTypeManager : EntityManager<ILeadType, long>
{
	public new static LeadTypeManager Instance => Locator.GetServiceNotNull<LeadTypeManager>();
}
