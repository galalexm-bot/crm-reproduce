using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IAddrBase))]
public interface IAddrBaseFilter : IEntityFilter
{
	Guid? ParentGuid { get; set; }

	Int64Range TypeOfSub { get; set; }

	string ObjectName { get; set; }

	string FullName { get; set; }

	string ZIP { get; set; }

	string FiasCode { get; set; }

	string CountryCode { get; set; }
}
