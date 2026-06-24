using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UIBuilder.Web.Models;

[DataContract]
public sealed class ExportExcelDataFromBlockDto
{
	[DataMember]
	public Guid EntityTypeUid { get; set; }

	[DataMember]
	public long ParentId { get; set; }

	[DataMember]
	public string ExportExcelFileName { get; set; }

	[DataMember]
	public string GridId { get; set; }

	[DataMember]
	public Guid ProviderUid { get; set; }

	[DataMember]
	public int Count { get; set; }

	[DataMember]
	public int Page { get; set; }

	[DataMember]
	public int PageSize { get; set; }

	[DataMember]
	public bool Pageable { get; set; }

	[DataMember]
	public IEnumerable<TableViewSortDescriptor> SortDescriptors { get; set; }

	[DataMember]
	public IEnumerable<TableViewGroupDescriptor> GroupDescriptors { get; set; }

	[DataMember]
	public string TablePartChangesModelSerialized { get; set; }

	[DataMember]
	public Guid PropertyViewItemUid { get; set; }

	[DataMember]
	public List<string> ColumnsOrder { get; set; }
}
