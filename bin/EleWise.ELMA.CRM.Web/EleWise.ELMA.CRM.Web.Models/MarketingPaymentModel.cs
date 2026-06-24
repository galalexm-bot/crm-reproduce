using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Models;

public class MarketingPaymentModel
{
	public IEntity Entity { get; set; }

	public Money Budget { get; set; }

	public DateTime CreationDate { get; set; }
}
