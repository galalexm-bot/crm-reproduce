using System;

namespace EleWise.ELMA.Documents.Models;

internal class DmsObjectTreeNodeState
{
	public static class Tables
	{
		public static class Fields
		{
			public const string TreeId = "TreeId";

			public const string User = "User";

			public const string DmsObject = "DmsObject";

			public const string Expanded = "Expanded";

			public const string ParentExpanded = "ParentExpanded";

			public const string Timestamp = "Timestamp";

			public const int TreeIdLength = 32;
		}

		public const string TableName = "Sys_DmsObjectTreeNodeState";
	}

	public string TreeId { get; set; }

	public long User { get; set; }

	public long DmsObject { get; set; }

	public bool Expanded { get; set; }

	public bool ParentExpanded { get; set; }

	public DateTime? Timestamp { get; set; }
}
