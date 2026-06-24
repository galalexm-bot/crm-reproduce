namespace Orchard.ContentManagement;

public class VersionOptions
{
	public static VersionOptions Latest => new VersionOptions
	{
		IsLatest = true
	};

	public static VersionOptions Published => new VersionOptions
	{
		IsPublished = true
	};

	public static VersionOptions Draft => new VersionOptions
	{
		IsDraft = true
	};

	public bool IsLatest { get; private set; }

	public bool IsPublished { get; private set; }

	public bool IsDraft { get; private set; }

	public int VersionRecordId { get; private set; }

	public static VersionOptions VersionRecord(int id)
	{
		return new VersionOptions
		{
			VersionRecordId = id
		};
	}
}
