using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Extensions;

namespace EleWise.ELMA.Documents.Services;

public class ConflictFindingProgress
{
	public Guid ConflictFindingProcessUid = Guid.NewGuid();

	public ConflictFindingState ConflictFindingState;

	public int TotalPercentComplete;

	public string CurrentWorkDescription;

	public Guid TargetTypeUid;

	public List<ConflictConvertReferencesObject> RetList;

	public ConflictFindingParameters Parameters;
}
