namespace EleWise.ELMA.Documents.Models;

internal class DmsObjectRelation
{
	public static class Tables
	{
		public static class Fields
		{
			public const string Parent = "Parent";

			public const string Child = "Child";

			public const string Depth = "Depth";

			public const string Owner = "Owner";
		}

		public const string TableName = "Sys_DmsObjectRelation";
	}

	public long Parent { get; set; }

	public long Child { get; set; }

	public long Depth { get; set; }

	public long Owner { get; set; }

	public override string ToString()
	{
		return $"Child: {Child}, Parent: {Parent}, Depth: {Depth}, Owner: {Owner}";
	}
}
