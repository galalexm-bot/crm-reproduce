using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.FileProvider.Distributed.Db;

public class DistributedFileProviderDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(CoreDbStructure) };

	public void CreateBinaryFileOriginsTable()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (!serviceNotNull.TableExists("FS_ORIGINS"))
		{
			Table table = new Table
			{
				Name = "FS_ORIGINS",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int32, ColumnProperty.PrimaryKey),
					new Column("FileId", DbType.Int32, ColumnProperty.None),
					new Column("SourceGateway", DbType.String, 256)
				}
			};
			serviceNotNull.AddTable(table);
		}
	}
}
