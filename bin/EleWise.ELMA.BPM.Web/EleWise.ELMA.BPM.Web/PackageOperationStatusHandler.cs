using System;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web;

public class PackageOperationStatusHandler : PackageOperationStatusHandlerBase
{
	private const int ServerType = 1;

	public PackageOperationStatusHandler()
		: base(1)
	{
	}

	protected override PackageOperationStatus LoadStatus(Guid updatingUid)
	{
		PackageService packageService = (Locator.Initialized ? Locator.GetService<PackageService>() : null);
		if (packageService == null || !packageService.Initialized)
		{
			return null;
		}
		return packageService.GetOperationStatus(updatingUid);
	}

	public static string FormatStatus(PackageOperationStatus status)
	{
		return PackageOperationStatusHandlerBase.FormatStatus(status, 1);
	}
}
