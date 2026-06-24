using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Util;

internal static class GridExportExcelUtility
{
	private struct ExportExcelParameters
	{
		public IGridData GridData;

		public Type Type;

		public bool ExportAllData;

		public string GridId;

		public Guid Provider;

		public string FileName;

		public IUser CurrentUser;

		public string SessionId;

		public object UserId;

		public TaskCompletionSource<bool> TaskCompletionSource;

		public GridExportExcelOptions Options { get; set; }
	}

	[DataContract]
	public class ExportExcelStatus
	{
		[DataMember]
		public string GridId { get; set; }

		[DataMember]
		public Guid FileGuid { get; set; }

		[DataMember]
		public bool Ready { get; set; }

		[DataMember]
		public double Percentage { get; set; }

		[DataMember]
		public string Error { get; set; }
	}

	private class GridDataExportPageProvider : LightCellsDataProvider
	{
		protected int _row = -1;

		protected int _column = -1;

		private readonly string sessionId;

		private readonly object userId;

		private readonly string gridId;

		private readonly GridExportExcelOptions options;

		private readonly bool includeTitle;

		private bool _break;

		protected readonly List<ExportColumnDescription> columns;

		protected readonly IGridData gridData;

		private List<IEntity> dataSource;

		private readonly Dictionary<Guid, IExportExcelValueProvider> propertyToProvidersCache = new Dictionary<Guid, IExportExcelValueProvider>();

		private IEnumerable<IExportExcelValueProvider> exportExcelValueProviders;

		private IEnumerable<IExportExcelValueProvider> ExportExcelValueProviders => exportExcelValueProviders ?? (exportExcelValueProviders = ComponentManager.Current.GetExtensionPoints<IExportExcelValueProvider>());

		protected int RowCount => Count + RowOffset;

		protected int RowOffset
		{
			get
			{
				if (!includeTitle)
				{
					return 0;
				}
				return 1;
			}
		}

		protected virtual int Count => DataSource.Count;

		protected virtual List<IEntity> DataSource
		{
			get
			{
				if (dataSource == null)
				{
					dataSource = gridData.DataSource.OfType<IEntity>().ToList();
				}
				return dataSource;
			}
		}

		public GridDataExportPageProvider(string sessionId, object userId, string gridId, List<ExportColumnDescription> columns, IGridData gridData, GridExportExcelOptions options)
		{
			this.sessionId = sessionId;
			this.userId = userId;
			this.gridId = gridId;
			this.columns = columns;
			this.gridData = gridData;
			this.options = options;
			includeTitle = !string.IsNullOrWhiteSpace(options.Title);
		}

		public bool StartSheet(int sheetIndex)
		{
			return sheetIndex == 0;
		}

		public int NextRow()
		{
			_row++;
			if (_break || _row > RowCount)
			{
				return -1;
			}
			_column = -1;
			return _row;
		}

		public void StartRow(Row row)
		{
			if (!SetExportExcelStatus(sessionId, userId, gridId, 100f * (float)_row / (float)(RowCount + 1)))
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
			if (includeTitle && _row == 0)
			{
				if (_column == 0)
				{
					cell.PutValue(options.Title);
				}
				return;
			}
			if ((!includeTitle && _row == 0) || (includeTitle && _row == 1))
			{
				cell.PutValue(columns[_column].ColumnName);
				return;
			}
			try
			{
				IEntity entity = GetEntity();
				Guid propertyUid = columns[_column].PropertyUid;
				IPropertyPermissionService service = Locator.GetService<IPropertyPermissionService>();
				if (service != null && service.CheckPropertyPermission(entity, propertyUid) == PropertyPermissionType.Hide)
				{
					return;
				}
				Style style = cell.GetStyle();
				style.set_VerticalAlignment((TextAlignmentType)1);
				Func<object, object> func = (object v) => (v is IEntity && v.ToString().IsNullOrEmpty()) ? SR.Untitled : v;
				object obj = GetValue(entity, propertyUid, style);
				IEnumerable enumerable = obj as IEnumerable;
				if (!(obj is string) && enumerable != null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object item in enumerable)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(func(item));
					}
					obj = stringBuilder;
				}
				if (obj != null)
				{
					obj = func(obj);
					cell.SetStyle(style);
					cell.PutValue(obj);
				}
			}
			catch (MetadataException)
			{
			}
			catch (Exception exception)
			{
				Logger.Log.Error(exception, "Ошибка вывода значения в Excel (row: {0}, column: {1})", _row, _column + 1);
			}
		}

		private object GetValue(IEntity entity, Guid propertyUid, Style cellStyle)
		{
			IExportExcelValueProvider value = null;
			if (!propertyToProvidersCache.TryGetValue(propertyUid, out value))
			{
				value = ExportExcelValueProviders.FirstOrDefault((IExportExcelValueProvider p) => p.Resolve(entity, propertyUid));
				propertyToProvidersCache[propertyUid] = value;
			}
			if (value == null)
			{
				return entity.GetPropertyValue(propertyUid).CastAsRealType();
			}
			if (!(value is IExportExcelStyledValueProvider))
			{
				return value.GetValue(entity, propertyUid).CastAsRealType();
			}
			return ((IExportExcelStyledValueProvider)value).GetStyledValue(entity, propertyUid, cellStyle).CastAsRealType();
		}

		protected virtual IEntity GetEntity()
		{
			return DataSource[_row - 1 - RowOffset];
		}

		public bool IsGatherString()
		{
			return false;
		}
	}

	private class GridDataExportAllProvider : GridDataExportPageProvider
	{
		private int count = -1;

		private FetchOptions fetchOptions;

		private List<IEntity> dataSource;

		protected override int Count
		{
			get
			{
				if (count == -1)
				{
					try
					{
						FetchOptions fetchOptions = CreateFetchOptions(gridData);
						OnCountFuncExecuting(gridData, fetchOptions);
						count = ExtractCount(gridData, fetchOptions);
					}
					catch (Exception exception)
					{
						Logger.Log.Warn("GridData Count get fail", exception);
						throw;
					}
				}
				return count;
			}
		}

		protected FetchOptions FetchOptions
		{
			get
			{
				if (fetchOptions == null)
				{
					fetchOptions = CreateFetchOptions(gridData);
					OnDataSourceFuncExecuting(gridData, fetchOptions);
					fetchOptions.MaxResults = 15;
					fetchOptions.FirstResult = 0;
				}
				return fetchOptions;
			}
		}

		protected override List<IEntity> DataSource
		{
			get
			{
				bool flag = dataSource == null;
				while (_row - base.RowOffset > FetchOptions.FirstResult + FetchOptions.MaxResults && FetchOptions.MaxResults > 0)
				{
					FetchOptions.FirstResult += FetchOptions.MaxResults;
					flag = true;
				}
				if (flag)
				{
					try
					{
						dataSource = ExtractDataSource(gridData, FetchOptions).OfType<IEntity>().ToList();
					}
					catch (Exception exception)
					{
						Logger.Log.Error("GridData DataSource get failed", exception);
						throw;
					}
				}
				return dataSource;
			}
		}

		public GridDataExportAllProvider(string sessionID, object userId, string gridId, List<ExportColumnDescription> columns, IGridData gridData, GridExportExcelOptions options)
			: base(sessionID, userId, gridId, columns, gridData, options)
		{
		}

		private static FetchOptions CreateFetchOptions(IGridData gridData)
		{
			return DeterministicFetchOptions((FetchOptions)gridData.GetType().GetMethod("CreateFetchOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null).Invoke(gridData, null));
		}

		private static FetchOptions DeterministicFetchOptions(FetchOptions fo)
		{
			if (!string.IsNullOrEmpty(fo.SortExpression))
			{
				if (!fo.SortExpression.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray()
					.Contains("Id"))
				{
					fo.SortExpression += ",Id";
				}
			}
			else
			{
				fo.SortExpression = "Id";
			}
			return fo;
		}

		private static void OnCountFuncExecuting(IGridData gridData, FetchOptions fetchOptions)
		{
			gridData.GetType().GetMethod("OnCountFuncExecuting", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(gridData, new object[1] { fetchOptions });
		}

		private static void OnDataSourceFuncExecuting(IGridData gridData, FetchOptions fetchOptions)
		{
			gridData.GetType().GetMethod("OnDataSourceFuncExecuting", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(gridData, new object[1] { fetchOptions });
		}

		private static int ExtractCount(IGridData gridData, FetchOptions fetchOptions)
		{
			return (int)gridData.GetType().GetMethod("ExtractCount", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(gridData, new object[1] { fetchOptions });
		}

		private static IEnumerable ExtractDataSource(IGridData gridData, FetchOptions fetchOptions)
		{
			return (IEnumerable)gridData.GetType().GetMethod("ExtractDataSource", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(gridData, new object[1] { fetchOptions });
		}

		protected override IEntity GetEntity()
		{
			return DataSource[_row - 1 - FetchOptions.FirstResult - base.RowOffset];
		}
	}

	private const string ExportExcelStatusLockKey = "ExportExcelStatus";

	private static readonly GridExportExcelOptions DefaultExportOptions = new GridExportExcelOptions();

	private static readonly Color titleColor = Color.FromArgb(203, 226, 255);

	private static readonly Color borderColor = Color.Gray;

	private static IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	public static bool ExportExcel(IGridData gridData, Type type, bool exportAllData, string gridId, Guid provider, Guid fileGuid, string fileName, string sessionId, object userId, TimeSpan timeOut, GridExportExcelOptions options)
	{
		InitExportExcelStatus(sessionId, userId, gridId, fileGuid);
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		ThreadStarter.QueueThread(ExportExcelThread, new ExportExcelParameters
		{
			GridData = gridData,
			Type = type,
			ExportAllData = exportAllData,
			GridId = gridId,
			Provider = provider,
			FileName = fileName,
			CurrentUser = AuthenticationService.GetCurrentUser(),
			SessionId = sessionId,
			UserId = userId,
			TaskCompletionSource = taskCompletionSource,
			Options = (options ?? DefaultExportOptions)
		});
		return taskCompletionSource.Task.Wait(timeOut);
	}

	private static string CacheKey(string sessionId)
	{
		return $"ExportExcelStatus_{sessionId}";
	}

	public static ExportExcelStatus[] GetExportExcelStatuses(string sessionId, object userId)
	{
		lock ("ExportExcelStatus")
		{
			SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>> value;
			return Locator.GetServiceNotNull<ICacheService>().TryGetValue<SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>>>(CacheKey(sessionId), out value) ? value[userId].Values.ToArray() : new ExportExcelStatus[0];
		}
	}

	public static void ResetExportExcelStatus(string sessionId, object userId, string key)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			string key2 = CacheKey(sessionId);
			if (serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>>>(key2, out var value))
			{
				if (value.ContainsKey(userId))
				{
					value[userId].Remove(key);
				}
				serviceNotNull.Insert(key2, value);
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

	public static ExportExcelStatus GetExportExcelStatus(string sessionId, object userId, string key)
	{
		lock ("ExportExcelStatus")
		{
			if (!Locator.GetServiceNotNull<ICacheService>().TryGetValue<SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>>>(CacheKey(sessionId), out var value))
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
			SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>> orAdd = serviceNotNull.GetOrAdd(CacheKey(sessionId), () => new SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>>());
			SerializableDictionary<string, ExportExcelStatus> serializableDictionary2 = (orAdd.ContainsKey(userId) ? orAdd[userId] : (orAdd[userId] = new SerializableDictionary<string, ExportExcelStatus>()));
			serializableDictionary2[key] = new ExportExcelStatus
			{
				GridId = key,
				FileGuid = fileGuid
			};
			serviceNotNull.Insert(CacheKey(sessionId), orAdd);
		}
	}

	private static bool SetExportExcelStatus(string sessionId, object userId, string key, double percentage)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			string key2 = CacheKey(sessionId);
			if (serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>>>(key2, out var value) && value.ContainsKey(userId) && value[userId].ContainsKey(key))
			{
				value[userId][key].Percentage = percentage;
				serviceNotNull.Insert(key2, value);
				return true;
			}
			return false;
		}
	}

	private static void SetExportExcelReadyStatus(string sessionId, object userId, string key, string errorMessage = null)
	{
		lock ("ExportExcelStatus")
		{
			ICacheService serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
			string key2 = CacheKey(sessionId);
			if (serviceNotNull.TryGetValue<SerializableDictionary<object, SerializableDictionary<string, ExportExcelStatus>>>(key2, out var value) && value.ContainsKey(userId) && value[userId].ContainsKey(key))
			{
				value[userId][key].Percentage = 100.0;
				value[userId][key].Ready = true;
				value[userId][key].Error = ((errorMessage != null) ? SR.T("Ошибка при формировании экспорта<br>{0}", errorMessage) : null);
				serviceNotNull.Insert(key2, value);
			}
		}
	}

	private static void SetExportExcelReady(string sessionId, object userId, string key, Exception ex = null)
	{
		string errorMessage = null;
		if (ex != null)
		{
			errorMessage = ((ex.Message != null) ? ex.Message : SR.T("Неизвестная ошибка"));
		}
		SetExportExcelReadyStatus(sessionId, userId, key, errorMessage);
	}

	private static void ExportExcelThread(object p)
	{
		ExportExcelParameters parameters = (ExportExcelParameters)p;
		try
		{
			new BackgroundTask(delegate
			{
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d8: Expected O, but got Unknown
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0276: Expected O, but got Unknown
				//IL_02be: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Expected O, but got Unknown
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cc: Expected O, but got Unknown
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_032b: Expected O, but got Unknown
				//IL_032b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0330: Unknown result type (might be due to invalid IL or missing references)
				//IL_0339: Expected O, but got Unknown
				//IL_0398: Unknown result type (might be due to invalid IL or missing references)
				//IL_039d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0431: Expected O, but got Unknown
				AuthenticationService.SetAuthenticatedUserForRequest(parameters.CurrentUser);
				GridState gridState;
				if (parameters.Options.GridState != null)
				{
					gridState = parameters.Options.GridState;
				}
				else
				{
					gridState = GridPersonalizationAdministration.LoadState(parameters.GridId, parameters.Provider) ?? GridState.CreateNew(parameters.GridId, parameters.Type);
					gridState.Refresh(parameters.Type, isNew: false, forceRefresh: false, addEntityName: false);
				}
				if (gridState.GroupDescriptors != null && gridState.GroupDescriptors.Count > 0)
				{
					SetExportExcelReadyStatus(parameters.SessionId, parameters.UserId, parameters.GridId, SR.T("Экспорт таблиц с группировками по колонкам не поддерживается"));
				}
				else
				{
					HashedSet<string> ignoreColumns = new HashedSet<string>(IgnoreColumns(parameters.Type));
					ClassMetadata classMetadata = MetadataLoader.LoadMetadata(parameters.Type) as ClassMetadata;
					List<PropertyMetadata> properties = ((classMetadata != null) ? classMetadata.Properties : new List<PropertyMetadata>());
					IPropertyPermissionService service = Locator.GetServiceNotNull<IPropertyPermissionService>();
					List<ExportColumnDescription> baseColumns = (from c in gridState.ColumnStates.Where((ColumnState c) => !c.Hidden && !c.ForceHidden && !((Set<string>)(object)ignoreColumns).Contains(c.UniqueName)).OrderColumns(gridState.CustomColumns, parameters.Options.ColumnOrderOverride).Select(delegate(ColumnState c)
						{
							if (!Guid.TryParse(c.UniqueName, out var result))
							{
								result = Guid.Empty;
							}
							return new
							{
								Column = c,
								PropertyUid = result
							};
						})
						where c.PropertyUid == Guid.Empty || service.HasPermissionsByRole(parameters.Type, c.PropertyUid) || service.CheckPropertyPermissionByGlobalOnly(parameters.Type, c.PropertyUid) != PropertyPermissionType.Hide
						select c).Select(c =>
					{
						PropertyMetadata propertyMetadata = properties.FirstOrDefault((PropertyMetadata prop) => prop.Uid == c.PropertyUid);
						if (propertyMetadata == null)
						{
							propertyMetadata = ((MetadataLoader.LoadMetadata(c.Column.TypeUid, inherit: false) is ClassMetadata classMetadata2) ? classMetadata2.Properties.FirstOrDefault((PropertyMetadata prop) => prop.Uid == c.PropertyUid) : null);
						}
						return new ExportColumnDescription
						{
							ColumnName = ((propertyMetadata != null) ? propertyMetadata.DisplayName : c.Column.DisplayName),
							TableColumnWidth = (propertyMetadata?.TableColumnWidth ?? 200),
							PropertyUid = c.PropertyUid
						};
					}).ToList();
					baseColumns = GetColumns(parameters.Type, baseColumns);
					Workbook val = new Workbook();
					Worksheet val2 = val.get_Worksheets().get_Item(0);
					for (int i = 0; i < baseColumns.Count; i++)
					{
						val2.get_Cells().SetColumnWidthPixel(i, baseColumns[i].TableColumnWidth);
					}
					int num = 0;
					if (!string.IsNullOrWhiteSpace(parameters.Options.Title))
					{
						num = 1;
						if (!string.IsNullOrWhiteSpace(parameters.Options.TitleUrl))
						{
							val2.get_Hyperlinks().Add(0, 0, 1, 1, parameters.Options.TitleUrl);
							Style val3 = new Style();
							val3.get_Font().set_Color(Color.Blue);
							val3.get_Font().set_Underline((FontUnderlineType)1);
							val2.get_Cells().get_Item(0, 0).SetStyle(val3);
						}
						val2.get_Cells().Merge(0, 0, 1, baseColumns.Count);
					}
					Style val4 = new Style();
					StyleFlag val5 = new StyleFlag();
					Range obj = val2.get_Cells().CreateRange(num, 1, false);
					ExcelStyleHelper.SetFontBold(val4, val5, isBold: true);
					ExcelStyleHelper.SetBackColor(val4, val5, titleColor);
					obj.ApplyStyle(val4, val5);
					Range obj2 = val2.get_Cells().CreateRange(num, 0, parameters.GridData.Count + 1, baseColumns.Count);
					val4 = new Style();
					StyleFlag val6 = new StyleFlag();
					val6.set_Borders(true);
					val5 = val6;
					val4.SetBorder((BorderType)4, (CellBorderType)1, borderColor);
					val4.SetBorder((BorderType)2, (CellBorderType)1, borderColor);
					val4.SetBorder((BorderType)8, (CellBorderType)1, borderColor);
					val4.SetBorder((BorderType)1, (CellBorderType)1, borderColor);
					obj2.ApplyStyle(val4, val5);
					obj2.SetOutlineBorders((CellBorderType)6, borderColor);
					string fileName = parameters.FileName;
					OoxmlSaveOptions val7 = new OoxmlSaveOptions((SaveFormat)6);
					val7.set_LightCellsDataProvider((LightCellsDataProvider)(object)(parameters.ExportAllData ? new GridDataExportAllProvider(parameters.SessionId, parameters.UserId, parameters.GridId, baseColumns, parameters.GridData, parameters.Options) : new GridDataExportPageProvider(parameters.SessionId, parameters.UserId, parameters.GridId, baseColumns, parameters.GridData, parameters.Options)));
					val.Save(fileName, (SaveOptions)val7);
					SetExportExcelReady(parameters.SessionId, parameters.UserId, parameters.GridId);
				}
			}, typeof(GridExportExcelUtility), "ExportGridToExcel", SR.T("Экспорт данных таблицы '{0}' в Excel.", parameters.GridId), useCallSessionOwner: true, handleExceptions: false).Execute();
		}
		catch (Exception ex)
		{
			Logger.Log.Error("Export excel error", ex);
			SetExportExcelReady(parameters.SessionId, parameters.UserId, parameters.GridId, ex);
		}
		finally
		{
			parameters.TaskCompletionSource.SetResult(result: true);
		}
	}

	private static ICollection<string> IgnoreColumns(Type type)
	{
		return (from p in ComponentManager.Current.GetExtensionPoints<IExportExcelIgnoreColumns>()
			where p.Resolve(type)
			select p).SelectMany((IExportExcelIgnoreColumns p) => p.IgnoreColumnUids).Distinct().ToArray();
	}

	private static List<ExportColumnDescription> GetColumns(Type type, IEnumerable<ExportColumnDescription> baseColumns)
	{
		return ComponentManager.Current.GetExtensionPoints<IExportExcelCustomColumnsProvider>().Aggregate(baseColumns.ToList(), delegate(List<ExportColumnDescription> result, IExportExcelCustomColumnsProvider prov)
		{
			IEnumerable<ExportColumnDescription> columns = prov.GetColumns(type, result);
			return (columns == null) ? result : columns.ToList();
		}, (List<ExportColumnDescription> result) => result);
	}
}
