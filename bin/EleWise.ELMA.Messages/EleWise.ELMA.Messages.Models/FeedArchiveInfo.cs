namespace EleWise.ELMA.Messages.Models;

internal sealed class FeedArchiveInfo
{
	public long LastUserId { get; set; }

	public int ErrorCount { get; set; }

	public FeedArchiveInfo(long lastUserId)
		: this(lastUserId, 0)
	{
	}

	public FeedArchiveInfo(long lastUserId, int errorCount)
	{
		LastUserId = lastUserId;
		ErrorCount = errorCount;
	}

	public FeedArchiveInfo(string value)
	{
		LastUserId = 0L;
		ErrorCount = 0;
		if (string.IsNullOrEmpty(value))
		{
			return;
		}
		string[] array = value.Split(';');
		if (array.Length >= 2)
		{
			if (long.TryParse(array[0], out var result))
			{
				LastUserId = result;
			}
			if (int.TryParse(array[1], out var result2))
			{
				ErrorCount = result2;
			}
		}
	}

	public override string ToString()
	{
		return $"{LastUserId};{ErrorCount}";
	}
}
