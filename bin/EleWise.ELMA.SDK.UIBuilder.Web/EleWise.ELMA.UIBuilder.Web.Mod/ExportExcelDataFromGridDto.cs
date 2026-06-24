using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UIBuilder.Web.Models;

[DataContract]
internal sealed class ExportExcelDataFromGridDto
{
	[DataMember]
	public string Query { get; set; }

	[DataMember]
	public Guid EntityTypeUid { get; set; }

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
	public IEnumerable<TableViewSortDescriptor> SortDescriptors { get; set; }

	[DataMember]
	public IEnumerable<TableViewGroupDescriptor> GroupDescriptors { get; set; }

	[DataMember]
	public string Filter { get; set; }

	[DataMember]
	public string Title { get; set; }

	[DataMember]
	public string TitleUrl { get; set; }
}
