using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.Models.Lead;

public enum DublicateLeadLink
{
	[DisplayName(typeof(DublicateLeadLink_SR), "Contractor")]
	Contractor = 1,
	[DisplayName(typeof(DublicateLeadLink_SR), "Lead")]
	Lead = 3,
	[DisplayName(typeof(DublicateLeadLink_SR), "Sale")]
	Sale = 4
}
