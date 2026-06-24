using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("784a3bab-48f4-42cc-998c-35518127efef")]
[DisplayName(typeof(__Resources_AuditType), "DisplayName")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
public enum AuditType
{
	[Uid("6c0ae8e2-cfe8-4c61-8c5b-173af3eea9c9")]
	[DisplayName(typeof(__Resources_AuditType), "P_Insert_DisplayName")]
	Insert = 1,
	[Uid("fdd1942c-2efc-4984-9755-bc49c16e3575")]
	[DisplayName(typeof(__Resources_AuditType), "P_Update_DisplayName")]
	Update,
	[Uid("61a66f4e-c6f4-4e2b-b50c-93fedf6f4d50")]
	[DisplayName(typeof(__Resources_AuditType), "P_Delete_DisplayName")]
	Delete
}
