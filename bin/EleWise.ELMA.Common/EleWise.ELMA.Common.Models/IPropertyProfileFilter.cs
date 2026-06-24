using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IPropertyProfile))]
public interface IPropertyProfileFilter : IEntityFilter
{
	Guid? PropertyGuid { get; set; }
}
