using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Db.PostgreSQL;

internal class CrmDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override Type Parent => typeof(EleWise.ELMA.CRM.Db.CrmDbStructure);

	public void CreateTempTableForPermissionPsql()
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
					new Column("ContractorId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Contractor", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				IsTemporary = true,
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
					new Column("SaleId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Sale", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table2);
		}
		text = "TemplateContractorPermUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table3 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContractorId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Contractor", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table3);
		}
		text = "ContractorPersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table4 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContractorId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Contractor", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table4);
		}
		text = "ContactPersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table5 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("ContactId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Contact", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table5);
		}
		text = "SalePersonPermissionUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table6 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("SaleId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Sale", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table6);
		}
		text = "RelationshipPersonPermUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table7 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("RelationshipId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Relationship", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table7);
		}
		text = "RelationshipPersonPermDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table8 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("RelationshipId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Relationship", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				IsTemporary = true,
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
					new Column("Uid", DbType.Guid),
					new Column("ContactId", DbType.Int64),
					new Column("Contact", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				IsTemporary = true,
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
					new Column("LeadId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Lead", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				IsTemporary = true,
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
					new Column("LeadId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Lead", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table11);
		}
		text = "ContractorTmpCategory";
		if (!serviceNotNull.TableExists(text))
		{
			Table table12 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("CategoryId", DbType.Int64),
					new Column("Categorytype", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table12);
		}
		text = "ContractorTmpPermission";
		if (!serviceNotNull.TableExists(text))
		{
			Table table13 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("CategoryId", DbType.Int64),
					new Column("UserId", DbType.Int64),
					new Column("CanEdit", DbType.Int64),
					new Column("CountPermission", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table13);
		}
		text = "ContractorTmpPermissionCount";
		if (!serviceNotNull.TableExists(text))
		{
			Table table14 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("UserId", DbType.Int64),
					new Column("CanEdit", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table14);
		}
		text = "TemplateLeadPermUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table15 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("LeadId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Lead", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table15);
		}
		text = "RelationshipPersonPermDel";
		if (!serviceNotNull.TableExists(text))
		{
			Table table16 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("RelationshipId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Relationship", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table16);
		}
		text = "RelationshipPersonPermUpd";
		if (!serviceNotNull.TableExists(text))
		{
			Table table17 = new Table
			{
				Name = text,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("RelationshipId", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Relationship", DbType.Int64),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Child", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64),
					new Column("Ins", DbType.Int64)
				},
				IsTemporary = true,
				Sequence = true
			};
			serviceNotNull.AddTable(table17);
		}
	}
}
