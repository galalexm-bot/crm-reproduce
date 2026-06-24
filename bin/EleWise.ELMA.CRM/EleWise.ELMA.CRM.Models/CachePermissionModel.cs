using System;

namespace EleWise.ELMA.CRM.Models;

public class CachePermissionModel
{
	public DateTime TimestampTime { get; set; }

	public bool Blocking { get; set; }

	public int NumberBlock { get; set; }

	public CachePermissionModel()
	{
	}

	public CachePermissionModel(bool blocking)
	{
		TimestampTime = DateTime.Now;
		Blocking = blocking;
	}
}
