using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;

namespace EleWise.ELMA.Documents.Services;

public interface IConvertProcessService
{
	Guid StartConvertProcess(IDocument[] docs, DocTypeMappingInfo[] mappings, Guid targetTypeUid, IDictionary<string, object> extData);

	ConvertionProgress GetConvertionStatus(Guid convertionProcessUid);

	void SetConvertionStatus(Guid convertionProcessUid, string name, string desciption, int? localPercent);
}
