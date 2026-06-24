namespace EleWise.ELMA.Documents.Services;

internal class ToManyDeleteOperation
{
	public string TableName { get; set; }

	public string WhereField1Name { get; set; }

	public long Where1Id { get; set; }

	public string WhereField2Name { get; set; }

	public long Where2Id { get; set; }
}
