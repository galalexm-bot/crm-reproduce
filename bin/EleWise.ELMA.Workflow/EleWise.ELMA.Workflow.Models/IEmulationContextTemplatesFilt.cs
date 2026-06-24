using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IEmulationContextTemplates))]
public interface IEmulationContextTemplatesFilter : IEntityFilter
{
	Guid? UidProcess { get; set; }
}
