using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Common;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("4ee8d373-6759-4850-a8fa-0db8098755fb")]
internal class __AssemblyInfo
{
	public const string UID_S = "4ee8d373-6759-4850-a8fa-0db8098755fb";

	private static Guid _UID = new Guid("4ee8d373-6759-4850-a8fa-0db8098755fb");

	public static Guid UID => _UID;
}
