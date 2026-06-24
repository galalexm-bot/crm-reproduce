using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Models;

[FilterFor(typeof(IProjectionScale))]
public interface IProjectionScaleFilter : IEntityFilter
{
	string Name { get; set; }

	Guid? Holder { get; set; }
}
