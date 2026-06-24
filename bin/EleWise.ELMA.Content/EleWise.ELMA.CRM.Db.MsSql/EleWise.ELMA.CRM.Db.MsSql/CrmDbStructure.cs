using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Db.MsSql;

internal class CrmDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.CRM.Db.CrmDbStructure);

	private void CopyDeletingPropertyValues(string tableName, string columnName)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName(tableName, columnName);
		if (serviceNotNull.ColumnExists(tableName, deletingColumnTemporaryName))
		{
			string sql = $"UPDATE {serviceNotNull.Dialect.QuoteIfNeeded(tableName)} SET {serviceNotNull.Dialect.QuoteIfNeeded(columnName)} = {serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName)}";
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	public void CreateTempTableForPermissionMs()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = "ContractorPersonPermissionDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContractorId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Contractor", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table);
		}
		text = "SalePersonPermissionDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table2 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("SaleId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Sale", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table2);
		}
		text = "RelationshipPersonPermissionDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table3 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("RelationshipId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Relationship", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table3);
		}
		text = "TemplateContractorPermUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table4 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContractorId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Contractor", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table4);
		}
		text = "ContractorPersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table5 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContractorId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Contractor", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table5);
		}
		text = "ContactPersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table6 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContactId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Contact", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table6);
		}
		text = "SalePersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table7 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("SaleId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Sale", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table7);
		}
		text = "RelationshipPersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table8 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("RelationshipId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Relationship", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("Ins", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table8);
		}
		text = "ContactPersonPermissionDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table9 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("ContactId", DbType.Int64),
					new Column("Contact", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table9);
		}
		text = "LeadPersonPermissionDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table10 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("LeadId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Lead", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table10);
		}
		text = "LeadPersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table11 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("LeadId", DbType.Int64),
					new Column("UId", DbType.Guid),
					new Column("Lead", DbType.Int64),
					new Column("PERMISSIONID", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("ORGANIZATIONITEMPOSITION", DbType.Int64),
					new Column("USERSECURITYSETCACHEID", DbType.Int64),
					new Column("PERMISSIONROLE", DbType.Guid),
					new Column("ORGANIZATIONITEMEMPLOYEE", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table11);
		}
	}
}
