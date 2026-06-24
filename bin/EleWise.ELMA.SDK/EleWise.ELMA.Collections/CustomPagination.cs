using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Collections;

public class CustomPagination<T> : IPagination<T>, IPagination, IEnumerable, IEnumerable<T>
{
	private readonly IList<T> _dataSource;

	private static object J1HZTv0YsKQ1xE9CcQo;

	public int PageNumber
	{
		[CompilerGenerated]
		get
		{
			return _003CPageNumber_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CPageNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int PageSize
	{
		[CompilerGenerated]
		get
		{
			return _003CPageSize_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CPageSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int TotalItems
	{
		[CompilerGenerated]
		get
		{
			return _003CTotalItems_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CTotalItems_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int TotalPages => (int)Math.Ceiling((double)TotalItems / (double)PageSize);

	public int FirstItem => (PageNumber - 1) * PageSize + 1;

	public int LastItem => FirstItem + _dataSource.Count - 1;

	public bool HasPreviousPage => PageNumber > 1;

	public bool HasNextPage => PageNumber < TotalPages;

	public CustomPagination(IEnumerable<T> dataSource, int pageNumber, int pageSize, int totalItems)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		_dataSource = dataSource.ToList();
		PageNumber = pageNumber;
		PageSize = pageSize;
		TotalItems = totalItems;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _dataSource.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static bool vdWVky0LkI7JTkdlaD8()
	{
		return J1HZTv0YsKQ1xE9CcQo == null;
	}

	internal static object AmyF1d0UJFY4d1aWpxv()
	{
		return J1HZTv0YsKQ1xE9CcQo;
	}
}
