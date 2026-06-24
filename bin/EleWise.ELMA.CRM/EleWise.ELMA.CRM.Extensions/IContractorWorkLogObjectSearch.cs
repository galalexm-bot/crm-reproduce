using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Extensions;

[InterfaceExtension(typeof(IWorkLogObjectSearchFilter))]
public interface IContractorWorkLogObjectSearchFilter : IWorkLogObjectSearchFilter, IAutoImplement, IEntityFilter
{
	[DisplayName(typeof(ProjectTaskWorkLogItemSearchFilter_SR), "P_Contractor")]
	List<IContractor> Contractor { get; set; }
}
