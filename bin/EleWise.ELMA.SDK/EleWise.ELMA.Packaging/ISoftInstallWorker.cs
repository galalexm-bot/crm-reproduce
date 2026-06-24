using System;
using System.Collections.Generic;
using System.IO;

namespace EleWise.ELMA.Packaging;

[Obsolete("Интерфейс утратил актуальность - не используйте его", true)]
public interface ISoftInstallWorker
{
	Guid UpdatingUid { get; }

	bool InstallationComplete { get; }

	bool HasErrors { get; }

	ISoftInstallState CurrentInstallationStatus { get; }

	IDictionary<string, ISoftInstallState> InstallationStatus { get; }

	Stream GetLog();

	void Install(IEnumerable<IStoreComponentInfo> componentsInfos, bool saveStatusToDb, SoftInstallWorkerNotificationCallback notificationCallback = null);
}
