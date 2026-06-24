using System;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class InpaymentChangeStatusModel
{
	public long InpaymentId { get; set; }

	public InpaymentStatus Value { get; set; }

	public DateTime? ActualDate { get; set; }

	public string Comment { get; set; }
}
