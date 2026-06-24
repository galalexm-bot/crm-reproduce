using System;

namespace EleWise.ELMA.Packaging;

[Serializable]
public class PackageOperationStatus
{
	private string _message;

	public PackageOperationStatusType Type { get; set; }

	public string Message
	{
		get
		{
			return _message;
		}
		set
		{
			_message = value;
		}
	}

	public static string GenerateFileName(Guid updatingUid)
	{
		return DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") + "_" + ((updatingUid != Guid.Empty) ? updatingUid : Guid.NewGuid()).ToString("n") + ".xml";
	}
}
