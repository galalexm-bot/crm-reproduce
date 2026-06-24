using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("6016d815-dc78-4ffe-be49-6d23ade6f8c2")]
[DisplayName(typeof(__Resources_TasksPortletSortExpression), "DisplayName")]
public enum TasksPortletSortExpression
{
	[Uid("ce8b411b-8c92-4923-bbc0-691a22caca79")]
	[DisplayName(typeof(__Resources_TasksPortletSortExpression), "P_CreationDate_DisplayName")]
	CreationDate,
	[Uid("4b3dad85-adb3-4659-94af-dbf5e0ee1140")]
	[DisplayName(typeof(__Resources_TasksPortletSortExpression), "P_EndDate_DisplayName")]
	EndDate
}
