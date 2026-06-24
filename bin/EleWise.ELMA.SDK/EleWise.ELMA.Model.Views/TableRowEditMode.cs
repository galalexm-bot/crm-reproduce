using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views;

[DisplayName(typeof(__Resources_TableRowEditMode), "DisplayName")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[MetadataType(typeof(EnumMetadata))]
[Uid("02062d1b-10e3-4799-ad8d-9bceddba7b30")]
public enum TableRowEditMode
{
	[DisplayName(typeof(__Resources_TableRowEditMode), "P_PopUp_DisplayName")]
	[Uid("d34e5976-a35f-47d3-9e3c-7daaebdf2e48")]
	PopUp,
	[DisplayName(typeof(__Resources_TableRowEditMode), "P_Table_DisplayName")]
	[Uid("86785551-c2a9-4e07-af8f-96ca071da06a")]
	Table,
	[DisplayName(typeof(__Resources_TableRowEditMode), "P_PopUpAndTable_DisplayName")]
	[Uid("eec44ace-368f-41cb-86fe-21a628fd0cbb")]
	PopUpAndTable
}
