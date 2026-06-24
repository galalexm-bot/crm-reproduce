using System;
using EleWise.ELMA.Common.BulkDataImport.Exceptions;
using EleWise.ELMA.Common.BulkDataImport.Models;
using EleWise.ELMA.Common.BulkDataImport.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.BulkDataImport.Helpers;

public static class BulkDataImportHelper
{
	public static void CheckStopCommand(Guid workUid)
	{
		if (IsStopCommand(workUid))
		{
			throw new StopImportException(workUid);
		}
	}

	public static bool IsStopCommand(Guid workUid)
	{
		return Locator.GetServiceNotNull<IBulkDataImportCommandService>().GetCommand(workUid) == ImportCommand.Stop;
	}
}
