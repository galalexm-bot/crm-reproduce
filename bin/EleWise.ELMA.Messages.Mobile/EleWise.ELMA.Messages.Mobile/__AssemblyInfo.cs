using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Mobile;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("2895645B-523D-4054-8D73-E1F66E11B465")]
[AssemblySummary(typeof(__Resources__AssemblyInfo), "Summary")]
internal class __AssemblyInfo
{
	public const string UID_S = "2895645B-523D-4054-8D73-E1F66E11B465";

	private static Guid _UID = new Guid("2895645B-523D-4054-8D73-E1F66E11B465");

	public static Guid UID => _UID;
}
