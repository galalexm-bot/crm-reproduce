using System;

namespace EleWise.ELMA.Web.Mvc.Models;

public class CachFileUploadInfo
{
	public bool UploadComplete { get; set; }

	public string JsonData { get; set; }

	public Guid FileGuid { get; set; }

	public CachFileUploadInfo()
	{
		UploadComplete = false;
	}
}
