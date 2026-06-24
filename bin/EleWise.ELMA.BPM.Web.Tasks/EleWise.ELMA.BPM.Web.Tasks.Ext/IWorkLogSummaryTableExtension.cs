using System;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogSummaryTableExtension
{
	Guid Uid { get; }

	void SetFilter(IWorkLogObjectSearchFilter filter, WorkLogItemGridParams parameters);
}
