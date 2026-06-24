using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Extensions.PostgreSQL;

internal class CoreDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.Model.Db.CoreDbStructure);

	public void CreateSystemSettingsTable()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (!serviceNotNull.TableExists("SystemSettings"))
		{
			Table table = new Table
			{
				Name = "SystemSettings",
				Columns = new List<Column>
				{
					new Column("ModuleUid", DbType.Guid, ColumnProperty.PrimaryKey),
					new Column("SettingKey", DbType.StringFixedLength, 255, ColumnProperty.PrimaryKey),
					new Column("SettingValue", DbType.String, int.MaxValue)
				}
			};
			serviceNotNull.AddTable(table);
		}
	}

	public void UpdateSystemSettingsTable()
	{
		try
		{
			Locator.GetServiceNotNull<ITransformationProvider>().AddPrimaryKey(new PrimaryKey
			{
				Columns = new List<string> { "ModuleUid", "SettingKey" },
				Name = "PK_Module_Settings",
				TableName = "SystemSettings"
			});
		}
		catch (Exception)
		{
		}
	}
}
