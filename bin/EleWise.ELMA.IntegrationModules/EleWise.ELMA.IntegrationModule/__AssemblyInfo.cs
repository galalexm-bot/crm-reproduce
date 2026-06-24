using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("7ee94876-4e8c-457e-8c72-f0db60324f22")]
internal class __AssemblyInfo
{
	public const string UID_S = "7ee94876-4e8c-457e-8c72-f0db60324f22";

	private static Guid _UID = new Guid("7ee94876-4e8c-457e-8c72-f0db60324f22");

	public static Guid UID => _UID;
}
