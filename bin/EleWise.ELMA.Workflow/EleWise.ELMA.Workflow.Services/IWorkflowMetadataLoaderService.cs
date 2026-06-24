using System;
using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IWorkflowMetadataLoaderService
{
	void CheckOrLoadMetadata(IWorkflowProcess process);

	void RegisterProcessHeaderMetadata(IEnumerable<IProcessHeader> processHeaders);

	Type GetFullInstanceContextType(long headerId, bool throwOnMissing);

	Type GetFullInstanceMetricValuesType(long headerId);

	Type GetFullProcessMetricValuesType(long headerId);

	long? GetHeaderIdByFullMetadataUid(Guid metadataUid);

	IDictionary<IProcessHeader, Type> GetFullContextTypes();

	IDictionary<long, Type> GetFullInstanceContextTypes();
}
