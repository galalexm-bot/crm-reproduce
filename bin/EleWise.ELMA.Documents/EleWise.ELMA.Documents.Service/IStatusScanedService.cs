using System;

namespace EleWise.ELMA.Documents.Services;

public interface IStatusScanedService
{
	void ClearAll();

	void DeleteByUid(Guid uid);

	void SetStatus(Guid uid, StatusScanedFileEnum status);

	StatusScanedFileEnum GetStatus(Guid uid);
}
