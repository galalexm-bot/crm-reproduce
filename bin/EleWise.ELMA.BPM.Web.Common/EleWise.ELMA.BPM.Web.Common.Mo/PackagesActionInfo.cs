using System;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PackagesActionInfo
{
	public string PackagesToInstall { get; set; }

	public string PackagesToUpdate { get; set; }

	public string PackagesToDelete { get; set; }

	public Guid UpdatingUid { get; set; }

	public bool IsSelectedToInstall(string id)
	{
		if (!string.IsNullOrEmpty(PackagesToInstall))
		{
			return PackagesToInstall.Contains(id + ";");
		}
		return false;
	}

	public bool IsSelectedToUpdate(string id)
	{
		if (!string.IsNullOrEmpty(PackagesToUpdate))
		{
			return PackagesToUpdate.Contains(id + ";");
		}
		return false;
	}

	public bool IsSelectedToDelete(string id)
	{
		if (!string.IsNullOrEmpty(PackagesToDelete))
		{
			return PackagesToDelete.Contains(id + ";");
		}
		return false;
	}
}
