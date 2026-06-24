using System;
using System.Collections.Generic;
using System.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public static class PaginationHelper
{
	public static IPagination<T> AsPagination<T>(this IEnumerable<T> source, int pageNumber)
	{
		return source.AsPagination(pageNumber, 20);
	}

	public static IPagination<T> AsPagination<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
	{
		if (pageNumber < 1)
		{
			throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939353422), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECEF15C));
		}
		return new LazyPagination<T>(source.AsQueryable(), pageNumber, pageSize);
	}
}
