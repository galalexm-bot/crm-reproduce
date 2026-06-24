using System;
using System.Data;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Documents.Types;

public class DocumentTemplatesListTypeDescriptor : CLRTypeDescriptor<DocumentTemplatesList, DocumentTemplatesListTypeSettings>
{
	public const string UID_S = "1F947818-02FC-4F92-A810-A79E7B1E1F2E";

	public static readonly Guid UID = new Guid("1F947818-02FC-4F92-A810-A79E7B1E1F2E");

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T("Коллекция шаблонов документа");

	public override bool Visible => false;

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}
}
