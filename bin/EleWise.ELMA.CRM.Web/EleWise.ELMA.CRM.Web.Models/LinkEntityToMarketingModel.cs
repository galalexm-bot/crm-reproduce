using System;
using System.Linq.Expressions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Models;

public class LinkEntityToMarketingModel
{
	[DisplayName(typeof(LinkEntityToMarketingModel_SR), "Contractor")]
	public IContractor Contractor { get; set; }

	[DisplayName(typeof(LinkEntityToMarketingModel_SR), "Lead")]
	public ILead Lead { get; set; }

	[DisplayName(typeof(LinkEntityToMarketingModel_SR), "Sale")]
	public ISale Sale { get; set; }

	public IMarketingBase MarketingBase { get; set; }

	public Expression<Func<LinkEntityToMarketingModel, IEntity>> EntityExpression { get; set; }

	public string Action { get; set; }

	public string Callback { get; set; }
}
