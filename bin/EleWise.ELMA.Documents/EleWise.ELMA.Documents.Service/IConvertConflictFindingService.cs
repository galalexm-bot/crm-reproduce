using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;

namespace EleWise.ELMA.Documents.Services;

public interface IConvertConflictFindingService
{
	Guid StartConflictFindingProcess(IDocument[] docs, DocTypeMappingInfo[] mappings, Guid targetTypeUid);

	ConflictFindingProgress GetConflictFindingProcessStatus(Guid conflictFindingProcessUid);

	void RemoveFindingConflictProgressFromDictionary(Guid conflictFindingProcessUid);
}
