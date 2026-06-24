namespace EleWise.ELMA.Documents.Services;

internal class ToManyUpdateOperation
{
	public string TableName { get; set; }

	public string WhereFieldName { get; set; }

	public long WhereId { get; set; }

	public string[] Columns { get; set; }

	public object[] Values { get; set; }
}
