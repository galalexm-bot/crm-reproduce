using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FilePreview.LocalService;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("dcb31189-030e-4074-81a4-c377cc199cfd")]
[AssemblySummary(typeof(__Resources__AssemblyInfo), "Summary")]
internal class __AssemblyInfo
{
	public const string UID_S = "dcb31189-030e-4074-81a4-c377cc199cfd";

	private static Guid _UID = new Guid("dcb31189-030e-4074-81a4-c377cc199cfd");

	public static Guid UID => _UID;
}
