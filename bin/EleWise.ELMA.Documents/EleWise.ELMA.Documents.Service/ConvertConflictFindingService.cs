using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Documents.Services;

[Service]
public class ConvertConflictFindingService : IConvertConflictFindingService
{
	private ConcurrentDictionary<Guid, ConflictFindingProgress> progressDict = new ConcurrentDictionary<Guid, ConflictFindingProgress>();

	private void StartThread(object param)
	{
		ConflictFindingParameters conflictFindingParameters = param as ConflictFindingParameters;
		IDocument[] docs = conflictFindingParameters.Docs;
		DocTypeMappingInfo[] mappings = conflictFindingParameters.mappings;
		Guid targetTypeUid = conflictFindingParameters.targetTypeUid;
		progressDict[conflictFindingParameters.ConflictFindingProcessUid].ConflictFindingState = ConflictFindingState.InWork;
		List<ConflictConvertReferencesObject> list = null;
		try
		{
			list = DocumentManager.Instance.GetReferencesForConvertion(targetTypeUid, docs, mappings, conflictFindingParameters.ConflictFindingProcessUid);
		}
		catch (Exception ex)
		{
			progressDict[conflictFindingParameters.ConflictFindingProcessUid].ConflictFindingState = ConflictFindingState.FinishedWithError;
			progressDict[conflictFindingParameters.ConflictFindingProcessUid].CurrentWorkDescription = ex.Message;
			return;
		}
		progressDict[conflictFindingParameters.ConflictFindingProcessUid].ConflictFindingState = ConflictFindingState.Finished;
		progressDict[conflictFindingParameters.ConflictFindingProcessUid].TotalPercentComplete = 100;
		progressDict[conflictFindingParameters.ConflictFindingProcessUid].RetList = list;
	}

	public Guid StartConflictFindingProcess(IDocument[] docs, DocTypeMappingInfo[] mappings, Guid targetTypeUid)
	{
		ConflictFindingProgress progr = new ConflictFindingProgress();
		progr.TargetTypeUid = targetTypeUid;
		progressDict.AddOrUpdate(progr.ConflictFindingProcessUid, progr, (Guid guid, ConflictFindingProgress progress) => progr);
		ConflictFindingParameters param = new ConflictFindingParameters
		{
			ConflictFindingProcessUid = progr.ConflictFindingProcessUid,
			Docs = docs,
			mappings = mappings,
			targetTypeUid = targetTypeUid
		};
		progr.Parameters = param;
		ThreadStarter.QueueThread(new BackgroundTask(delegate
		{
			StartThread(param);
		}, typeof(ConvertConflictFindingService), "ConvertFindingProcess" + Guid.NewGuid().ToString(), "ConvertFIndingProcess" + Guid.NewGuid().ToString()).Execute);
		return progr.ConflictFindingProcessUid;
	}

	public ConflictFindingProgress GetConflictFindingProcessStatus(Guid conflictFindingProcessUid)
	{
		if (progressDict.ContainsKey(conflictFindingProcessUid))
		{
			return progressDict[conflictFindingProcessUid];
		}
		return null;
	}

	public void RemoveFindingConflictProgressFromDictionary(Guid conflictFindingProcessUid)
	{
		progressDict.TryRemove(conflictFindingProcessUid, out var _);
	}
}
