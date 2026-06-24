using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules
{
	[MetadataType(typeof(NamespaceMetadata))]
	[Uid("fe4af471-3ea6-4e20-842a-62e6f581f1e5")]
	internal class _NamespaceInfo : NamespaceInfo
	{
		public const string UID_S = "fe4af471-3ea6-4e20-842a-62e6f581f1e5";

		private static Guid _UID = new Guid("fe4af471-3ea6-4e20-842a-62e6f581f1e5");

		public static Guid UID => _UID;

		public override string DisplayName => SR.T("Модули интеграции");
	}
}
namespace EleWise.ELMA.IntegrationModules.Models
{
	[MetadataType(typeof(NamespaceMetadata))]
	[Uid("c6156508-3697-4ad2-8a0a-89775cba7a93")]
	internal class _NamespaceInfo : NamespaceInfo
	{
		public const string UID_S = "c6156508-3697-4ad2-8a0a-89775cba7a93";

		private static Guid _UID = new Guid("c6156508-3697-4ad2-8a0a-89775cba7a93");

		public static Guid UID => _UID;

		public override string DisplayName => "";
	}
}
