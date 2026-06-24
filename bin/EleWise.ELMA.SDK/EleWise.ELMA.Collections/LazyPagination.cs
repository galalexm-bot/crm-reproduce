using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Collections;

public class LazyPagination<T> : IPagination<T>, IPagination, IEnumerable, IEnumerable<T>
{
	public const int DefaultPageSize = 20;

	private IList<T> results;

	private int totalItems;

	private static object GxC7QpmQyQPXPb5wVs4;

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
				case 1:
					_003CPageSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IQueryable<T> Query { get; protected set; }

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
				case 1:
					_003CPageNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public int TotalItems
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return totalItems;
				}
			}
		}
	}

	public int TotalPages => (int)Math.Ceiling((double)TotalItems / (double)PageSize);

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int LastItem => FirstItem + results.Count - 1;

	public bool HasPreviousPage => PageNumber > 1;

	public bool HasNextPage => PageNumber < TotalPages;

	public LazyPagination(IQueryable<T> query, int pageNumber, int pageSize)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		PageNumber = pageNumber;
		PageSize = pageSize;
		Query = query;
	}

	[IteratorStateMachine(typeof(LazyPagination<>._003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CT_003E_002DGetEnumerator_003Ed__16))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CT_003E_002DGetEnumerator_003Ed__16(0)
		{
			_003C_003E4__this = this
		};
	}

	protected void TryExecuteQuery()
	{
		//Discarded unreachable code: IL_005a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (results == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				return;
			default:
				totalItems = Query.Count();
				num2 = 3;
				break;
			case 3:
				results = ExecuteQuery();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected virtual IList<T> ExecuteQuery()
	{
		int count = (PageNumber - 1) * PageSize;
		return Query.Skip(count).Take(PageSize).ToList();
	}

	public IEnumerator GetEnumerator()
	{
		return ((IEnumerable<T>)this).GetEnumerator();
	}

	internal static bool rpOmKRmC4qs42w0Mksv()
	{
		return GxC7QpmQyQPXPb5wVs4 == null;
	}

	internal static object jVsdFfmv5pwMiAtTkuq()
	{
		return GxC7QpmQyQPXPb5wVs4;
	}
}
