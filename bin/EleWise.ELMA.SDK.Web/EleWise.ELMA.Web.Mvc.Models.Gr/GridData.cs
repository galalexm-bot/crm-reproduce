using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Extensions;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class GridData<T> : IGridData<T>, IGridData
{
	private int _pageSize = 15;

	private int _pageIndex = 1;

	private bool _isAjax = true;

	private bool _isPageable = true;

	private string _sortExpression;

	private ListSortDirection _sortDirection;

	private bool _isServerBinding = true;

	private Func<GridData<T>, FetchOptions, long> _countFunc;

	private Func<GridData<T>, FetchOptions, IEnumerable> _dataSourceFunc;

	protected bool dataSourceFuncCalled;

	protected IEnumerable cachedDataSource;

	protected bool countFuncCalled;

	protected int cachedCount;

	public int PageSize
	{
		get
		{
			return _pageSize;
		}
		set
		{
			_pageSize = ((value <= 0) ? 1 : value);
		}
	}

	public int PageCount => (Count - 1) / PageSize + 1;

	public int PageIndex
	{
		get
		{
			return _pageIndex;
		}
		set
		{
			_pageIndex = ((value <= 0) ? 1 : value);
		}
	}

	public string SortExpression
	{
		get
		{
			return _sortExpression;
		}
		set
		{
			_sortExpression = value;
		}
	}

	public ListSortDirection SortDirection
	{
		get
		{
			return _sortDirection;
		}
		set
		{
			_sortDirection = value;
		}
	}

	public List<GridGroupDescriptor> GroupDescriptors { get; set; }

	public virtual int Count
	{
		get
		{
			try
			{
				if (!countFuncCalled && _countFunc != null)
				{
					FetchOptions fetchOptions = CreateFetchOptions();
					countFuncCalled = true;
					cachedCount = 0;
					OnCountFuncExecuting(fetchOptions);
					cachedCount = ExtractCount(fetchOptions);
					OnCountFuncExecuted();
				}
			}
			catch (Exception exception)
			{
				countFuncCalled = false;
				cachedCount = 0;
				Logger.Log.Warn("GridData Count get fail", exception);
			}
			return cachedCount;
		}
		set
		{
			SetCount(value);
			cachedCount = value;
		}
	}

	public virtual bool DataSourceIsNull
	{
		get
		{
			if (!dataSourceFuncCalled || cachedDataSource != null)
			{
				if (!dataSourceFuncCalled)
				{
					return _dataSourceFunc == null;
				}
				return false;
			}
			return true;
		}
	}

	public virtual IEnumerable DataSource
	{
		get
		{
			try
			{
				OnBeforeSourceFuncExecuting();
				if (!dataSourceFuncCalled && _dataSourceFunc != null)
				{
					FetchOptions fetchOptions = CreateFetchOptions();
					dataSourceFuncCalled = true;
					cachedDataSource = null;
					OnDataSourceFuncExecuting(fetchOptions);
					cachedDataSource = ExtractDataSource(fetchOptions);
					OnDataSourceFuncExecuted();
				}
			}
			catch (Exception exception)
			{
				cachedDataSource = null;
				dataSourceFuncCalled = false;
				Logger.Log.Error("GridData DataSource get failed", exception);
				throw;
			}
			return cachedDataSource;
		}
		set
		{
			SetDataSource(value);
			cachedDataSource = value;
		}
	}

	public string JsonDataHiddenFieldId { get; set; }

	public string ParentDataHiddenFieldId { get; set; }

	public object JsonData { get; set; }

	public string ParentDataObjectId { get; set; }

	public string ParentDataMetadataUid { get; set; }

	public bool IsAjax
	{
		get
		{
			return _isAjax;
		}
		set
		{
			_isAjax = value;
		}
	}

	public bool IsPageable
	{
		get
		{
			return _isPageable;
		}
		set
		{
			_isPageable = value;
		}
	}

	public bool IsServerBinding
	{
		get
		{
			return _isServerBinding;
		}
		set
		{
			_isServerBinding = value;
		}
	}

	public object EditingRowKeyValue { get; set; }

	public object EditingItem { get; set; }

	public RootViewItem EditingItemView { get; set; }

	public bool HasExitFromGroup { get; set; }

	public GridCommand Command { get; set; }

	public Grid GridModel { get; set; }

	public Type EntityType { get; set; }

	protected Func<GridData<T>, FetchOptions, long> CountFunc
	{
		get
		{
			return _countFunc;
		}
		set
		{
			if ((object)_countFunc != value)
			{
				ResetCountFunc();
				_countFunc = value;
			}
		}
	}

	protected Func<GridData<T>, FetchOptions, IEnumerable> DataSourceFunc
	{
		get
		{
			return _dataSourceFunc;
		}
		set
		{
			if ((object)_dataSourceFunc != value)
			{
				ResetDataSourceFunc();
				_dataSourceFunc = value;
			}
		}
	}

	protected event Action<GridData<T>, FetchOptions> DataSourceExecuting;

	protected event Action<GridData<T>> DataSourceExecuted;

	protected event Action<GridData<T>, FetchOptions> CountExecuting;

	protected event Action<GridData<T>> CountExecuted;

	public void SetData(int count, IEnumerable dataSource)
	{
		Count = count;
		DataSource = dataSource;
	}

	public void SetData(Func<IGridData, FetchOptions, long> count, Func<IGridData, FetchOptions, IEnumerable> dataSource)
	{
		SetCount(count);
		SetDataSource(dataSource);
	}

	public void SetDataSource(Func<GridData<T>, FetchOptions, IEnumerable> dataSourceFunc)
	{
		DataSourceFunc = dataSourceFunc;
	}

	public void SetCount(Func<GridData<T>, FetchOptions, long> countFunc)
	{
		CountFunc = countFunc;
	}

	public void AddDataSourceExecuting([NotNull] Action<GridData<T>, FetchOptions> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		DataSourceExecuting += @event;
	}

	public void AddDataSourceExecuted([NotNull] Action<GridData<T>> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		DataSourceExecuted += @event;
	}

	public void AddCountExecuting([NotNull] Action<GridData<T>, FetchOptions> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		CountExecuting += @event;
	}

	public void AddCountExecuted([NotNull] Action<GridData<T>> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		CountExecuted += @event;
	}

	private FetchOptions CreateFetchOptions(GridData<T> gridData)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		bool flag = false;
		FetchOptions fetchOptions = Command.GetFetchOptions();
		if (!fetchOptions.Equals(FetchOptions.All) && fetchOptions.MaxResults > 1)
		{
			flag = true;
		}
		if (fetchOptions.Equals(FetchOptions.All) && GridModel != null && !string.IsNullOrEmpty(GridModel.UniqueName))
		{
			GridState gridState = GridPersonalizationAdministration.LoadState(GridModel.UniqueName, GridModel.StateProviderUid);
			if (gridState != null)
			{
				GridCommand val = new GridCommand();
				val.set_PageSize(gridState.PageSize);
				GridCommand val2 = val;
				if (val2.get_PageSize() > 1)
				{
					flag = true;
				}
				string sortExpression = gridState.SortExpression;
				if (!string.IsNullOrEmpty(sortExpression) && !GridModel.Columns.Any((GridColumn a) => !a.Sortable && a.SortExpression == sortExpression) && !Guid.TryParse(sortExpression, out var _))
				{
					IList<SortDescriptor> sortDescriptors = val2.get_SortDescriptors();
					SortDescriptor val3 = new SortDescriptor();
					val3.set_Member(sortExpression);
					val3.set_SortDirection(gridState.SortDirection);
					sortDescriptors.Add(val3);
				}
				if (gridState.GroupDescriptors != null)
				{
					foreach (GridGroupDescriptor groupDescriptor in gridState.GroupDescriptors)
					{
						IList<GroupDescriptor> groupDescriptors = val2.get_GroupDescriptors();
						GroupDescriptor val4 = new GroupDescriptor();
						((SortDescriptor)val4).set_Member(groupDescriptor.Member);
						((SortDescriptor)val4).set_SortDirection(groupDescriptor.SortDirection);
						groupDescriptors.Add(val4);
					}
				}
				fetchOptions = val2.GetFetchOptions();
			}
		}
		if (fetchOptions.Equals(FetchOptions.All) && MetadataLoader.LoadMetadata(typeof(T)) is ClassMetadata classMetadata)
		{
			TableView tableView = classMetadata.TableViews.FirstOrDefault();
			if (tableView != null)
			{
				fetchOptions.FirstResult = 0;
				fetchOptions.MaxResults = tableView.PageSize;
				if (tableView.PageSize > 1)
				{
					flag = true;
				}
				TableViewSortDescriptor sort = tableView.SortDescriptors.FirstOrDefault();
				if (sort != null)
				{
					PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p != null && p.Uid == sort.PropertyUid);
					if (propertyMetadata != null)
					{
						fetchOptions.SortDirection = sort.Direction;
						fetchOptions.SortExpression = propertyMetadata.Name;
					}
				}
			}
		}
		if (string.IsNullOrEmpty(fetchOptions.SortExpression) && (!string.IsNullOrEmpty(gridData.SortExpression) || (!string.IsNullOrEmpty(gridData.SortExpression) && GridModel != null && GridModel.Childs && !gridData.SortExpression.Equals(fetchOptions.SortExpression))))
		{
			fetchOptions.SortExpression = gridData.SortExpression;
			fetchOptions.SortDirection = gridData.SortDirection;
		}
		gridData.SortExpression = fetchOptions.SortExpression;
		gridData.SortDirection = fetchOptions.SortDirection;
		int num3 = (fetchOptions.MaxResults = (gridData.PageSize = (flag ? fetchOptions.MaxResults : 15)));
		gridData.PageIndex = fetchOptions.FirstResult / gridData.PageSize + 1;
		return fetchOptions;
	}

	private bool DoesGridModelContainDataToUpdateDataSource()
	{
		if (!dataSourceFuncCalled)
		{
			return false;
		}
		if (GridModel == null || (!GridModel.Childs && string.IsNullOrEmpty(GridModel.UniqueName)))
		{
			return false;
		}
		GridData<T> gridData = new GridData<T>();
		FetchOptions fetchOptions = CreateFetchOptions(gridData);
		OnDataSourceFuncExecuting(fetchOptions);
		if (gridData.PageSize == PageSize && gridData.PageIndex == PageIndex && gridData.SortDirection == SortDirection)
		{
			return !string.Equals(gridData.SortExpression ?? string.Empty, SortExpression ?? string.Empty);
		}
		return true;
	}

	protected virtual FetchOptions CreateFetchOptions()
	{
		return CreateFetchOptions(this);
	}

	protected virtual void OnBeforeSourceFuncExecuting()
	{
		if (DoesGridModelContainDataToUpdateDataSource())
		{
			ResetDataSourceFunc();
		}
	}

	protected virtual void OnDataSourceFuncExecuting(FetchOptions fetchOptions)
	{
		this.DataSourceExecuting?.Invoke(this, fetchOptions);
	}

	protected virtual void OnDataSourceFuncExecuted()
	{
		this.DataSourceExecuted?.Invoke(this);
	}

	protected virtual void OnCountFuncExecuting(FetchOptions fetchOptions)
	{
		this.CountExecuting?.Invoke(this, fetchOptions);
	}

	protected virtual void OnCountFuncExecuted()
	{
		this.CountExecuted?.Invoke(this);
	}

	protected void ResetDataSourceFunc()
	{
		dataSourceFuncCalled = false;
		cachedDataSource = null;
	}

	protected void ResetCountFunc()
	{
		countFuncCalled = false;
		cachedCount = 0;
	}

	protected virtual IEnumerable ExtractDataSource(FetchOptions fo)
	{
		if (_dataSourceFunc == null)
		{
			return null;
		}
		return _dataSourceFunc(this, fo);
	}

	protected virtual void SetDataSource(IEnumerable value)
	{
		SetDataSource((GridData<T> d, FetchOptions f) => value);
	}

	protected virtual int ExtractCount(FetchOptions fo)
	{
		long num = ((_countFunc != null) ? _countFunc(this, fo) : 0);
		if (num <= int.MaxValue)
		{
			return Convert.ToInt32(num);
		}
		return int.MaxValue;
	}

	protected virtual void SetCount(int value)
	{
		SetCount((GridData<T> d, FetchOptions f) => (value >= 0) ? value : 0);
	}
}
public class GridData<T, TFilter> : GridData<T> where TFilter : IEntityFilter
{
	private TFilter filter;

	public TFilter DataFilter
	{
		get
		{
			return filter;
		}
		set
		{
			filter = value;
		}
	}

	public void SetDataSource(Func<GridData<T, TFilter>, FetchOptions, IEnumerable> dataSourceFunc)
	{
		if (dataSourceFunc == null)
		{
			base.DataSourceFunc = null;
			return;
		}
		base.DataSourceFunc = (GridData<T> d, FetchOptions f) => dataSourceFunc((GridData<T, TFilter>)d, f);
	}

	public void SetCount(Func<GridData<T, TFilter>, FetchOptions, long> countFunc)
	{
		if (countFunc == null)
		{
			base.CountFunc = null;
			return;
		}
		base.CountFunc = (GridData<T> d, FetchOptions f) => countFunc((GridData<T, TFilter>)d, f);
	}

	public void AddDataSourceExecuting([NotNull] Action<GridData<T, TFilter>, FetchOptions> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		base.DataSourceExecuting += delegate(GridData<T> d, FetchOptions f)
		{
			@event((GridData<T, TFilter>)d, f);
		};
	}

	public void AddDataSourceExecuted([NotNull] Action<GridData<T, TFilter>> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		base.DataSourceExecuted += delegate(GridData<T> d)
		{
			@event((GridData<T, TFilter>)d);
		};
	}

	public void AddCountExecuting([NotNull] Action<GridData<T, TFilter>, FetchOptions> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		base.CountExecuting += delegate(GridData<T> d, FetchOptions f)
		{
			@event((GridData<T, TFilter>)d, f);
		};
	}

	public void AddCountExecuted([NotNull] Action<GridData<T, TFilter>> @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		base.CountExecuted += delegate(GridData<T> d)
		{
			@event((GridData<T, TFilter>)d);
		};
	}
}
