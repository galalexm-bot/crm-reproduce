using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Documents.Services;

[Service]
public class ConvertProcessService : IConvertProcessService
{
	private ConcurrentDictionary<Guid, ConvertionProgress> progressDict = new ConcurrentDictionary<Guid, ConvertionProgress>();

	private void StartThread(object param)
	{
		ConvertionParameters p = param as ConvertionParameters;
		IDocument[] docs = p.Docs;
		DocTypeMappingInfo[] mappings = p.Mappings;
		Guid targetTypeUid = p.TargetTypeUid;
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(p.CurrentUserId);
		IDictionary<string, object> extendedData = p.ExtendedData;
		progressDict[p.ConvertionUid].ConvertionState = ConvertionState.InWork;
		for (int i = 0; i < docs.Length; i++)
		{
			IDocument currDoc = docs[i];
			DocTypeMappingInfo currMapping = mappings[i];
			try
			{
				Locator.GetServiceNotNull<ISecurityService>().RunByUser(user, delegate
				{
					DocumentManager.Instance.ConvertType(currDoc, targetTypeUid, currMapping, p.ConvertionUid, extendedData);
				});
			}
			catch (Exception ex)
			{
				progressDict[p.ConvertionUid].ConvertionState = ConvertionState.FinishedWithError;
				progressDict[p.ConvertionUid].CurrentWorkDescription = ex.Message;
				return;
			}
			progressDict[p.ConvertionUid].GlobalPercentComplete += 100 / docs.Length;
		}
		progressDict[p.ConvertionUid].ConvertionState = ConvertionState.Finished;
		progressDict[p.ConvertionUid].GlobalPercentComplete = 100;
		progressDict.TryRemove(p.ConvertionUid, out var _);
	}

	public Guid StartConvertProcess(IDocument[] docs, DocTypeMappingInfo[] mappings, Guid targetTypeUid, IDictionary<string, object> extData)
	{
		ConvertionProgress progr = new ConvertionProgress();
		progressDict.AddOrUpdate(progr.ConvertionUid, progr, (Guid guid, ConvertionProgress progress) => progr);
		ConvertionParameters param = new ConvertionParameters
		{
			ConvertionUid = progr.ConvertionUid,
			Docs = docs,
			Mappings = mappings,
			TargetTypeUid = targetTypeUid,
			CurrentUserId = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id,
			ExtendedData = extData
		};
		Locator.GetServiceNotNull<ISessionProvider>().GetSession(string.Empty).Flush();
		ThreadStarter.QueueThread(new BackgroundTask(delegate
		{
			StartThread(param);
		}, typeof(ConvertProcessService), "ConvertProcess" + Guid.NewGuid().ToString(), "ConvertProcess" + Guid.NewGuid().ToString()).Execute);
		return progr.ConvertionUid;
	}

	public ConvertionProgress GetConvertionStatus(Guid convertionProcessUid)
	{
		if (progressDict.ContainsKey(convertionProcessUid))
		{
			return progressDict[convertionProcessUid];
		}
		return null;
	}

	public void SetConvertionStatus(Guid convertionProcessUid, string name, string desciption, int? localPercent)
	{
		ConvertionProgress convertionStatus = GetConvertionStatus(convertionProcessUid);
		if (convertionStatus != null)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				convertionStatus.CurrentName = name;
			}
			if (!string.IsNullOrWhiteSpace(desciption))
			{
				convertionStatus.CurrentWorkDescription = desciption;
			}
			if (localPercent.HasValue)
			{
				convertionStatus.LocalPercentComplete = localPercent.Value;
			}
		}
	}
}
