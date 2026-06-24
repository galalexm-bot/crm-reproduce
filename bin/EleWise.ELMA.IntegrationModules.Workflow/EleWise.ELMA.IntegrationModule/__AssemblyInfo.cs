using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Workflow;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("A24528CB-3806-42D5-8CA0-42FB5BFBC66B")]
internal class __AssemblyInfo
{
	public const string UID_S = "A24528CB-3806-42D5-8CA0-42FB5BFBC66B";

	private static Guid _UID = new Guid("A24528CB-3806-42D5-8CA0-42FB5BFBC66B");

	public static Guid UID => _UID;
}
