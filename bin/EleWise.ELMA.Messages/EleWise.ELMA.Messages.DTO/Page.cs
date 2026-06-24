using System.Collections.Generic;

namespace EleWise.ELMA.Messages.DTO;

public sealed class Page<T> : Page
{
	public ICollection<T> Items { get; set; }

	public Page(ICollection<T> items, int? start, int? limit = null, long? totalCount = null)
	{
		base.Start = start ?? Page.GetDefaultStart();
		base.Limit = limit ?? Page.GetDefaultLimit();
		base.TotalCount = totalCount;
		Items = items;
	}
}
public class Page
{
	private static readonly int defaultStart = 0;

	private static readonly int defaultLimit = 20;

	public long Start { get; set; }

	public long? Limit { get; set; }

	public long? TotalCount { get; set; }

	public static int GetDefaultStart()
	{
		return defaultStart;
	}

	public static int GetDefaultLimit()
	{
		return defaultLimit;
	}
}
