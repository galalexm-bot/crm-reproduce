namespace EleWise.ELMA.Documents.Services;

internal class ToManyInsertOperation
{
	public string TableName { get; set; }

	public string ParentFieldName { get; set; }

	public string ChildFieldName { get; set; }

	public long ParentId { get; set; }

	public long ChildId { get; set; }

	public string ParentTableName { get; set; }
}
