using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using Aspose.Cells;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Util;

internal static class TableExportExcelUtility
{
	private class ExportExcelParameters
	{
		public DataTable Table { get; set; }

		public GridState State { get; set; }

		public string GridId { get; set; }

		public string FileName { get; set; }

		public IUser CurrentUser { get; set; }

		public string SessionId { get; set; }

		public object UserId { get; set; }
	}

	private class ExportColumnDescription
	{
		public string ColumnName { get; set; }

		public int TableColumnWidth { get; set; }
	}

	private class TableDataExportProvider : LightCellsDataProvider
	{
		protected int _row = -1;

		protected int _column = -1;

		private readonly string sessionId;

		private readonly object userId;

		private readonly string gridId;

		private bool _break;

		protected readonly List<ExportColumnDescription> columns;

		protected readonly DataTable table;

		private List<DataRow> dataSource;

		protected virtual int Count => table.Rows.Count;

		protected virtual List<DataRow> DataSource => dataSource ?? (dataSource = table.Rows.Cast<DataRow>().ToList());

		public TableDataExportProvider(string sessionId, object userId, string gridId, List<ExportColumnDescription> columns, DataTable table)
		{
			this.sessionId = sessionId;
			this.userId = userId;
			this.gridId = gridId;
			this.columns = columns;
			this.table = table;
		}

		public bool StartSheet(int sheetIndex)
		{
			return sheetIndex == 0;
		}

		public int NextRow()
		{
			_row++;
			if (_break || _row > Count)
			{
				return -1;
			}
			_column = -1;
			return _row;
		}

		public void StartRow(Row row)
		{
			if (!SetExportExcelStatus(sessionId, userId, gridId, 100f * (float)_row / (float)(Count + 1)))
			{
				_break = true;
			}
		}

		public int NextCell()
		{
			_column++;
			if (_break || _column >= columns.Count)
			{
				_column = -1;
			}
			return _column;
		}

		public void StartCell(Cell cell)
		{
			if (_row == 0)
			{
				cell.PutValue(columns[_column].ColumnName);
				return;
			}
			try
			{
				DataRow row = GetRow();
				object obj = GetValue(row, columns[_column].ColumnName);
				if (obj == null)
				{
					return;
				}
				Style style = cell.GetStyle();
				style.set_VerticalAlignment((TextAlignmentType)1);
				if (obj is DateTime)
				{
					style.set_Number(22);
				}
				if (obj.GetType().IsEnum || obj is EnumBase)
				{
					obj = ModelHelper.GetEnumDisplayName(obj);
				}
				if (obj is Money || obj is double || obj is float || obj is decimal || obj is byte || obj is ushort || obj is uint || obj is ulong || obj is sbyte || obj is short || obj is int || obj is long)
				{
					if (obj is Money money)
					{
						if (!money.HasValue)
						{
							return;
						}
						obj = ((Money)obj).Value;
					}
					int? num = ((obj is double || obj is float || obj is decimal) ? null : new int?(0));
					if (num == 0)
					{
						style.set_Number(3);
					}
					else if (!num.HasValue || num == 2)
					{
						style.set_Number(4);
					}
					else
					{
						style.set_Custom("#,##0.".PadRight(num.Value + 6, '0'));
					}
				}
				if (obj is string && ((string)obj).Contains("\n"))
				{
					style.set_IsTextWrapped(true);
				}
				if (obj is IEntity && obj.ToString().IsNullOrEmpty())
				{
					obj = SR.Untitled;
				}
				if (obj is bool)
				{
					obj = (((bool)obj) ? SR.Yes : SR.No);
				}
				cell.SetStyle(style);
				cell.PutValue(obj);
			}
			catch (Exception exception)
			{
				Logger.Log.Error(exception, "Ошибка вывода значения в Excel (row: {0}, column: {1})", _row, _column + 1);
			}
		}

		private object GetValue(DataRow row, string columnName)
		{
			string text = columnName + "_$export";
			if (!row.Table.Columns.Contains(text))
			{
				return row[columnName];
			}
			return row[text];
		}

		protected virtual DataRow GetRow()
		{
			return DataSource[_row - 1];
		}

		public bool IsGatherString()
		{
			return false;
		}
	}

	private const string ExportExcelStatusLockKey = "ExportExcelStatus";

	private static readonly Color titleColor = Color.FromArgb(203, 226, 255);

	private static readonly Color borderColor = Color.Gray;

	private static IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	public static bool ExportExcel(DataTable table, string gridId, Guid fileGuid, string fileName, string sessionId, object userId, TimeSpan timeOut)
	{
		InitExportExcelStatus(sessionId, userId, gridId, fileGuid);
		Thread thread = new Thread(ExportExcelThread);
		thread.CurrentCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
		thread.CurrentUICulture = (CultureInfo)Thread.CurrentThread.CurrentUICulture.Clone();
		GridState state = GridPersonalizationAdministration.LoadState(gridId);
		thread.Start(new ExportExcelParameters
		{
			Table = table,
			State = state,
			GridId = gridId,
			FileName = fileName,
			CurrentUser = AuthenticationService.GetCurrentUser(),
			SessionId = sessionId,
			UserId = userId
		});
		return thread.Join(timeOut);
	}

	private static string CacheKey(string sessionId)
	{
		return $"ExportExcelStatus_{sessionId}";
	}

	public static GridExportExcelUtility.ExportExcelStatus[] GetExportExcelStatuses(string sessionId, object userId)
	{
		lock ("ExportExcelStatus")
		{
			SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>> value;
			return Locator.GetServiceNotNull<ICacheService>().TryGetValue<SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>>(CacheKey(sessionId), out value) ? value[userId].Values.ToArray() : new GridExportExcelUtility.ExportExcelStatus[0];
		}
	}

	public static void ResetExportExcelStatus(string sessionId, object userId, string key)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			if (serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>>(CacheKey(sessionId), out var value))
			{
				if (value.ContainsKey(userId))
				{
					value[userId].Remove(key);
				}
				serviceNotNull.Insert(CacheKey(sessionId), value);
			}
		}
	}

	internal static void ClearExportExcelStatusForSession(string sessionId)
	{
		lock ("ExportExcelStatus")
		{
			Locator.GetServiceNotNull<ICacheService>().Remove(CacheKey(sessionId));
		}
	}

	public static GridExportExcelUtility.ExportExcelStatus GetExportExcelStatus(string sessionId, object userId, string key)
	{
		lock ("ExportExcelStatus")
		{
			if (!Locator.GetServiceNotNull<ICacheService>().TryGetValue<SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>>(CacheKey(sessionId), out var value))
			{
				return null;
			}
			return (value.ContainsKey(userId) && value[userId].ContainsKey(key)) ? value[userId][key] : null;
		}
	}

	private static void InitExportExcelStatus(string sessionId, object userId, string key, Guid fileGuid)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			if (!serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>>(CacheKey(sessionId), out var value))
			{
				value = new SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>();
			}
			SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus> serializableDictionary2 = (value.ContainsKey(userId) ? value[userId] : (value[userId] = new SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>()));
			serializableDictionary2[key] = new GridExportExcelUtility.ExportExcelStatus
			{
				GridId = key,
				FileGuid = fileGuid
			};
			serviceNotNull.Insert(CacheKey(sessionId), value);
		}
	}

	private static bool SetExportExcelStatus(string sessionId, object userId, string key, double percentage)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			if (serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>>(CacheKey(sessionId), out var value) && value.ContainsKey(userId) && value[userId].ContainsKey(key))
			{
				value[userId][key].Percentage = percentage;
				serviceNotNull.Insert(CacheKey(sessionId), value);
				return true;
			}
			return false;
		}
	}

	private static void SetExportExcelReady(string sessionId, object userId, string key, Exception ex = null)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			if (serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, GridExportExcelUtility.ExportExcelStatus>>>(CacheKey(sessionId), out var value) && value.ContainsKey(userId) && value[userId].ContainsKey(key))
			{
				value[userId][key].Percentage = 100.0;
				value[userId][key].Ready = true;
				value[userId][key].Error = ((ex != null) ? SR.T("Ошибка при формировании экспорта<br>{0}", ex.Message) : null);
				serviceNotNull.Insert(CacheKey(sessionId), value);
			}
		}
	}

	private static void ExportExcelThread(object p)
	{
		ExportExcelParameters parameters = (ExportExcelParameters)p;
		try
		{
			new BackgroundTask(delegate
			{
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected O, but got Unknown
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Expected O, but got Unknown
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Expected O, but got Unknown
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Expected O, but got Unknown
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected O, but got Unknown
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Expected O, but got Unknown
				AuthenticationService.SetAuthenticatedUserForRequest(parameters.CurrentUser);
				List<ExportColumnDescription> list = (from c in parameters.State.ColumnStates.Where((ColumnState c) => !c.Hidden && !c.ForceHidden).OrderColumns(parameters.State.CustomColumns)
					select new ExportColumnDescription
					{
						ColumnName = c.DisplayName,
						TableColumnWidth = ((!string.IsNullOrWhiteSpace(c.WidthAttribute)) ? int.Parse(c.WidthAttribute) : 200)
					}).ToList();
				Workbook val = new Workbook();
				for (int i = 0; i < list.Count; i++)
				{
					val.get_Worksheets().get_Item(0).get_Cells()
						.SetColumnWidthPixel(i, list[i].TableColumnWidth);
				}
				Style val2 = new Style();
				StyleFlag val3 = new StyleFlag();
				Range obj = val.get_Worksheets().get_Item(0).get_Cells()
					.CreateRange(0, 1, false);
				ExcelStyleHelper.SetFontBold(val2, val3, isBold: true);
				ExcelStyleHelper.SetBackColor(val2, val3, titleColor);
				obj.ApplyStyle(val2, val3);
				Range obj2 = val.get_Worksheets().get_Item(0).get_Cells()
					.CreateRange(0, 0, parameters.Table.Rows.Count + 1, list.Count);
				val2 = new Style();
				StyleFlag val4 = new StyleFlag();
				val4.set_Borders(true);
				val3 = val4;
				val2.SetBorder((BorderType)4, (CellBorderType)1, borderColor);
				val2.SetBorder((BorderType)2, (CellBorderType)1, borderColor);
				val2.SetBorder((BorderType)8, (CellBorderType)1, borderColor);
				val2.SetBorder((BorderType)1, (CellBorderType)1, borderColor);
				obj2.ApplyStyle(val2, val3);
				obj2.SetOutlineBorders((CellBorderType)6, borderColor);
				string fileName = parameters.FileName;
				OoxmlSaveOptions val5 = new OoxmlSaveOptions((SaveFormat)6);
				val5.set_LightCellsDataProvider((LightCellsDataProvider)(object)new TableDataExportProvider(parameters.SessionId, parameters.UserId, parameters.GridId, list, parameters.Table));
				val.Save(fileName, (SaveOptions)val5);
				SetExportExcelReady(parameters.SessionId, parameters.UserId, parameters.GridId);
			}, typeof(GridExportExcelUtility), "ExportGridToExcel", SR.T("Экспорт данных таблицы '{0}' в Excel.", parameters.GridId), useCallSessionOwner: true, handleExceptions: false).Execute();
		}
		catch (Exception ex)
		{
			Logger.Log.Error("Export excel error", ex);
			SetExportExcelReady(parameters.SessionId, parameters.UserId, parameters.GridId, ex);
		}
	}
}
