using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public class ExcelTable<TRow>
{
	public interface IColumn
	{
		string Title { get; }

		double Width { get; }

		Func<TRow, object> ValueAccessor { get; }

		IExcelCellFormat Format { get; }

		Type ValueType { get; }
	}

	public interface IOrderedColumn : IColumn
	{
		long Order { get; set; }
	}

	public class Column<TValue> : IOrderedColumn, IColumn
	{
		internal static object E1G21d8iDMotBwupaJYV;

		public long Order
		{
			[CompilerGenerated]
			get
			{
				return _003COrder_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003COrder_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Title
		{
			[CompilerGenerated]
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CTitle_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public double Width
		{
			[CompilerGenerated]
			get
			{
				return _003CWidth_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CWidth_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

		public Func<TRow, TValue> ValueAccessor { get; set; }

		public IExcelCellFormat Format
		{
			[CompilerGenerated]
			get
			{
				return _003CFormat_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CFormat_003Ek__BackingField = value;
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

		Func<TRow, object> IColumn.ValueAccessor
		{
			get
			{
				if (ValueAccessor == null)
				{
					return null;
				}
				return (TRow r) => ValueAccessor(r);
			}
		}

		public Type ValueType => typeof(TValue);

		public Column()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool qsOuQm8itYLlxUWo8dcO()
		{
			return E1G21d8iDMotBwupaJYV == null;
		}

		internal static object e2bVsw8iwscr13dZ3SCI()
		{
			return E1G21d8iDMotBwupaJYV;
		}
	}

	private static object kfYvBnEEOqO4OhcRPYeh;

	public List<IColumn> Columns { get; set; }

	public int FixedRows
	{
		[CompilerGenerated]
		get
		{
			return _003CFixedRows_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CFixedRows_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int FixedColumns
	{
		[CompilerGenerated]
		get
		{
			return _003CFixedColumns_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CFixedColumns_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<TRow> Items { get; set; }

	public ExcelTable()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Columns = new List<IColumn>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ExcelTable<TRow> AddColumn<TValue>(string title, double width, Func<TRow, TValue> valueAccessor, IExcelCellFormat format = null)
	{
		Columns.Add(new Column<TValue>
		{
			Title = title,
			Width = width,
			ValueAccessor = valueAccessor,
			Format = format
		});
		return this;
	}

	public ExcelTable<TRow> AddColumn<TValue>(long order, string title, double width, Func<TRow, TValue> valueAccessor, IExcelCellFormat format = null)
	{
		Columns.Add(new Column<TValue>
		{
			Order = order,
			Title = title,
			Width = width,
			ValueAccessor = valueAccessor,
			Format = format
		});
		return this;
	}

	public void Order()
	{
		int num = 2;
		int num2 = num;
		IEnumerable<IOrderedColumn> source = default(IEnumerable<IOrderedColumn>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				source = Columns.CastOrNull<IOrderedColumn>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Columns = source.OrderBy((IOrderedColumn c) => c.Order).Cast<IColumn>().ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool UPmR1WEE2wkUvYP42RQV()
	{
		return kfYvBnEEOqO4OhcRPYeh == null;
	}

	internal static object xSWuLOEEeBbbBnSBUwt9()
	{
		return kfYvBnEEOqO4OhcRPYeh;
	}
}
