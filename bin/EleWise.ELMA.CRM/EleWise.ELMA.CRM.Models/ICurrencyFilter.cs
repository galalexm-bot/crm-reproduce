using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ICurrency))]
public interface ICurrencyFilter : IEntityFilter
{
	long? CodeISONumerical { get; set; }

	string CodeISOAlphabetic { get; set; }

	DateTime? ExpiryDate { get; set; }
}
