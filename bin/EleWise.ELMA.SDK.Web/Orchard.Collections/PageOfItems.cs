using System;
using System.Collections;
using System.Collections.Generic;

namespace Orchard.Collections;

public class PageOfItems<T> : List<T>, IPageOfItems<T>, IEnumerable<T>, IEnumerable
{
	public int PageNumber { get; set; }

	public int PageSize { get; set; }

	public int TotalItemCount { get; set; }

	public int TotalPageCount => (int)Math.Ceiling((double)TotalItemCount / (double)PageSize);

	public int StartPosition => (PageNumber - 1) * PageSize + 1;

	public int EndPosition
	{
		get
		{
			if (PageNumber * PageSize <= TotalItemCount)
			{
				return PageNumber * PageSize;
			}
			return TotalItemCount;
		}
	}

	public PageOfItems(IEnumerable<T> items)
	{
		AddRange(items);
	}
}
