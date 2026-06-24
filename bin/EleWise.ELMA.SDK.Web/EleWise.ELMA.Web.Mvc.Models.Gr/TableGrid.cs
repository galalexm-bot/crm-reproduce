using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class TableGrid : Grid
{
	public const string HiddenColumnAttribute = "Hidden";

	public const string NotSortableColumnAttribute = "NotSortable";

	private readonly DataTable table;

	private readonly long total;

	public new IGridData GridData
	{
		get
		{
			throw new NotImplementedException(SR.T("GridData не используется в TableGrid. Данные хранятся в Table.Rows."));
		}
	}

	public DataTable Table => table;

	public bool IsAjax => true;

	public bool IsServerBinding => true;

	public bool IsPageable { get; set; }

	public int PageSize { get; set; }

	public int PageIndex { get; set; }

	public long Total => total;

	public List<GridGroupDescriptor> GroupDescriptors { get; set; }

	public string SortExpression => State.SortExpression;

	public ListSortDirection SortDirection => State.SortDirection;

	public GridState State
	{
		get
		{
			GridState gridState = GridPersonalizationAdministration.LoadState(base.UniqueName, base.StateProviderUid);
			if (gridState == null)
			{
				List<DataColumn> source = (from DataColumn c in Table.Columns
					where !c.ColumnName.EndsWith("_$view") && !c.ColumnName.EndsWith("_$export")
					select c).ToList();
				int order = 0;
				gridState = GridState.CreateNew(base.UniqueName, base.Type);
				List<ColumnState> initialValues = source.Select((DataColumn c) => new ColumnState
				{
					UniqueName = c.ColumnName,
					Name = c.ColumnName,
					DisplayName = ((!string.IsNullOrWhiteSpace(c.Caption)) ? c.Caption : SR.T(c.ColumnName)),
					Hidden = (c.ExtendedProperties.ContainsKey("Hidden") && (bool)c.ExtendedProperties["Hidden"]),
					Order = ++order,
					Sortable = (!c.ExtendedProperties.ContainsKey("NotSortable") || !(bool)c.ExtendedProperties["NotSortable"]),
					TypeUid = Guid.Empty
				}).ToList();
				gridState.ColumnStates = new GridStateSet(initialValues);
				GridPersonalizationAdministration.SaveState(base.UniqueName, gridState, base.StateProviderUid);
			}
			return gridState;
		}
	}

	public TableGrid(string uniqueName, DataTable table, long total, string callbackFunction = null)
		: base(null, typeof(DataRow))
	{
		base.UniqueName = uniqueName;
		this.table = table;
		this.total = total;
		base.CallbackFunction = callbackFunction;
	}
}
