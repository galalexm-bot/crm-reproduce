using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

[Serializable]
public class OriginalGridSettings : IEquatable<OriginalGridSettings>
{
	public Tuple<string, string>[] ColumnsWidth { get; set; }

	public TableViewSortDescriptor[] SortDescriptors { get; set; }

	public GridGroupDescriptor[] GroupDescriptors { get; set; }

	public OriginalGridSettings()
	{
	}

	[Obsolete("Данный конструктор устарел, вместо него нужно использовать OriginalGridSettings(metadata, columns, sortDescriptors, groupDescriptors)", true)]
	public OriginalGridSettings(IEnumerable<string> columns, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
		: this(columns.Select((string c) => new Tuple<string, string>(c, null)), sortDescriptors, groupDescriptors)
	{
	}

	[Obsolete("Данный конструктор устарел, вместо него нужно использовать OriginalGridSettings(metadata, columnsWidth, sortDescriptors, groupDescriptors)", true)]
	public OriginalGridSettings(IEnumerable<KeyValuePair<string, string>> columnsWidth, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
		: this(columnsWidth.Select((KeyValuePair<string, string> c) => new Tuple<string, string>(c.Key, c.Value)), sortDescriptors, groupDescriptors)
	{
	}

	[Obsolete("Данный конструктор устарел, вместо него нужно использовать OriginalGridSettings(metadata, columnsWidth, sortDescriptors, groupDescriptors)", true)]
	public OriginalGridSettings(IEnumerable<Tuple<string, string>> columnsWidth, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
		: this(null, columnsWidth, sortDescriptors, groupDescriptors)
	{
	}

	public OriginalGridSettings(ClassMetadata metadata, IEnumerable<string> columns, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
	{
		IEnumerable<Tuple<string, string>> enumerable = null;
		Init(columnsWidth: (columns == null || columns.Count() <= 0 || metadata == null || metadata.Properties.Count <= 0) ? columns.Select((string c) => new Tuple<string, string>(c, null)) : columns.Select(delegate(string c)
		{
			string colUid = c.ToLower();
			PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata x) => x.UidStr.ToLower() == colUid);
			return (propertyMetadata != null) ? new Tuple<string, string>(c, propertyMetadata.TableColumnWidth.ToString()) : new Tuple<string, string>(c, null);
		}), metadata: metadata, sortDescriptors: sortDescriptors, groupDescriptors: groupDescriptors);
	}

	[Obsolete("Данный конструктор устарел, вместо него нужно использовать OriginalGridSettings(metadata, columnsWidth, sortDescriptors, groupDescriptors)", true)]
	public OriginalGridSettings(ClassMetadata metadata, IEnumerable<KeyValuePair<string, string>> columnsWidth, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
		: this(metadata, columnsWidth.Select((KeyValuePair<string, string> c) => new Tuple<string, string>(c.Key, c.Value)), sortDescriptors, groupDescriptors)
	{
	}

	public OriginalGridSettings(ClassMetadata metadata, IEnumerable<Tuple<string, string>> columnsWidth, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
	{
		Init(metadata, columnsWidth, sortDescriptors, groupDescriptors);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as OriginalGridSettings);
	}

	public bool Equals(OriginalGridSettings other)
	{
		if (other != null && ColumnsWidth.SequenceEqual(other.ColumnsWidth) && SortDescriptors.EmptyIfNull().SequenceEqual(other.SortDescriptors.EmptyIfNull()))
		{
			return GroupDescriptors.EmptyIfNull().SequenceEqual(other.GroupDescriptors.EmptyIfNull());
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((ColumnsWidth != null) ? ColumnsWidth.GetHashCode() : 0) * 397) ^ SortDescriptors.EmptyIfNull().GetHashCode()) * 397) ^ GroupDescriptors.EmptyIfNull().GetHashCode();
	}

	private void Init(ClassMetadata metadata, IEnumerable<Tuple<string, string>> columnsWidth, IEnumerable<TableViewSortDescriptor> sortDescriptors = null, IEnumerable<GridGroupDescriptor> groupDescriptors = null)
	{
		if (metadata != null && metadata.Properties.Count > 0)
		{
			IEnumerable<string> uidStrs = metadata.Properties.Select((PropertyMetadata x) => x.UidStr.ToLower());
			ColumnsWidth = columnsWidth.Where((Tuple<string, string> x) => uidStrs.Contains(x.Item1.ToLower())).ToArray();
		}
		else
		{
			ColumnsWidth = columnsWidth.ToArray();
		}
		SortDescriptors = sortDescriptors?.ToArray();
		GroupDescriptors = groupDescriptors?.ToArray();
	}
}
