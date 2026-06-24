using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.Models;

public enum RelationshipLink
{
	[DisplayName(typeof(RelationshipLink_SR), "Contractor")]
	Contractor = 1,
	[DisplayName(typeof(RelationshipLink_SR), "Contact")]
	Contact,
	[DisplayName(typeof(RelationshipLink_SR), "Lead")]
	Lead
}
