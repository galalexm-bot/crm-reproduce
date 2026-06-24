using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Collections;

public class DelegatePagination<T> : IPagination<T>, IPagination, IEnumerable, IEnumerable<T>
{
	private IList<T> _results;

	private object _additionalArgs;

	private bool _doRefresh;

	private int _totalItems;

	private int _pageNumber;

	private int _pageSize;

	private static object i4a5WYmF5gU3BgVdM0j;

	public int PageNumber
	{
		get
		{
			return _pageNumber;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_pageNumber = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					_doRefresh = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (value != _pageNumber)
					{
						num2 = 2;
						break;
					}
					return;
				case 1:
					return;
				}
			}
		}
	}

	public int PageSize
	{
		get
		{
			return _pageSize;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (value != _pageSize)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 2;
						}
						break;
					}
					return;
				case 2:
					_doRefresh = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					_pageSize = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
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
		get
		{
			return _totalItems;
		}
		private set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_totalItems = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_doRefresh = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (value != _totalItems)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 2;
						}
						break;
					}
					return;
				case 0:
					return;
				}
			}
		}
	}

	public object AdditionalArgs
	{
		get
		{
			return _additionalArgs;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_doRefresh = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 1:
					if (value == _additionalArgs)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_additionalArgs = value;
					num2 = 3;
					break;
				}
			}
		}
	}

	public int TotalPages
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					TryExecuteQuery();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (int)Math.Ceiling((double)TotalItems / (double)PageSize);
				}
			}
		}
	}

	public int FirstItem
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (PageNumber - 1) * PageSize + 1;
				case 1:
					TryExecuteQuery();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int LastItem
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					TryExecuteQuery();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return FirstItem + _results.Count - 1;
				}
			}
		}
	}

	public bool HasPreviousPage
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					TryExecuteQuery();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return PageNumber > 1;
				}
			}
		}
	}

	public bool HasNextPage
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return PageNumber < TotalPages;
				case 1:
					TryExecuteQuery();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public event DoQueryDelegate<T> DoQuery;

	public DelegatePagination(DoQueryDelegate<T> method, int pageNumber, int pageSize, object additionalArgs)
	{
		SingletonReader.JJCZtPuTvSt();
		_doRefresh = true;
		base._002Ector();
		this.DoQuery = method;
		_pageNumber = pageNumber;
		_pageSize = pageSize;
		_additionalArgs = additionalArgs;
	}

	protected virtual void OnDoQuery(PagingQueryEventArgs e)
	{
		int num = 2;
		while (true)
		{
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
					break;
				case 2:
					if (this.DoQuery == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					TotalItems = e.TotalItems;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					_doRefresh = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_results = this.DoQuery(this, e).ToList();
			num = 4;
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		TryExecuteQuery();
		return _results.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	protected void TryExecuteQuery()
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (!_doRefresh)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				return;
			case 0:
				return;
			case 1:
				break;
			}
			OnDoQuery(new PagingQueryEventArgs
			{
				PageNumber = PageNumber,
				PageSize = PageSize,
				AdditionalArgs = _additionalArgs
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool VFdDxBmBvlYrUHmBFZx()
	{
		return i4a5WYmF5gU3BgVdM0j == null;
	}

	internal static object P5gniomWi69bqWYtpy6()
	{
		return i4a5WYmF5gU3BgVdM0j;
	}
}
