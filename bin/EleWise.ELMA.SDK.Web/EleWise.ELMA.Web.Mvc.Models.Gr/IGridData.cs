using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public interface IGridData
{
	int PageSize { get; set; }

	int PageCount { get; }

	int PageIndex { get; set; }

	string SortExpression { get; set; }

	ListSortDirection SortDirection { get; set; }

	List<GridGroupDescriptor> GroupDescriptors { get; set; }

	int Count { get; set; }

	IEnumerable DataSource { get; set; }

	bool DataSourceIsNull { get; }

	object JsonData { get; }

	string JsonDataHiddenFieldId { get; }

	string ParentDataHiddenFieldId { get; }

	string ParentDataObjectId { get; }

	string ParentDataMetadataUid { get; }

	bool IsAjax { get; set; }

	bool IsPageable { get; set; }

	bool IsServerBinding { get; set; }

	object EditingRowKeyValue { get; set; }

	object EditingItem { get; set; }

	RootViewItem EditingItemView { get; set; }

	Grid GridModel { get; set; }

	Type EntityType { get; set; }

	bool HasExitFromGroup { get; set; }

	void SetData(int count, IEnumerable dataSource);

	void SetData(Func<IGridData, FetchOptions, long> count, Func<IGridData, FetchOptions, IEnumerable> dataSource);
}
public interface IGridData<T> : IGridData
{
	void AddDataSourceExecuting([NotNull] Action<GridData<T>, FetchOptions> @event);
}
