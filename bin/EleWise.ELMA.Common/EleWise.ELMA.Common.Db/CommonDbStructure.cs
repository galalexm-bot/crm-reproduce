using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Projects.Models;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Db;

public class CommonDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public IMetadataRuntimeService IMetadataRuntimeService { get; set; }

	public void UpdateFiltersPerms()
	{
		AbstractNHEntityManager<IFilter, long>.Instance.FindAll().ToList().ForEach(delegate(IFilter f)
		{
			if (f != null && ((ICollection<IFilterPermission>)f.Permissions).Count == 0)
			{
				ISet<IFilterPermission> permissions = f.Permissions;
				InstanceOf<IFilterPermission> instanceOf = new InstanceOf<IFilterPermission>();
				instanceOf.New.Filter = f;
				instanceOf.New.PermissionId = PermissionProvider.FilterViewPermission.Id;
				instanceOf.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf.New.User = f.CreationAuthor;
				instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(f.CreationAuthor.Id);
				permissions.Add(instanceOf.New);
				ISet<IFilterPermission> permissions2 = f.Permissions;
				InstanceOf<IFilterPermission> instanceOf2 = new InstanceOf<IFilterPermission>();
				instanceOf2.New.Filter = f;
				instanceOf2.New.PermissionId = PermissionProvider.FilterEditPermission.Id;
				instanceOf2.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf2.New.User = f.CreationAuthor;
				instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(f.CreationAuthor.Id);
				permissions2.Add(instanceOf2.New);
				ISet<IFilterPermission> permissions3 = f.Permissions;
				InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
				instanceOf3.New.Filter = f;
				instanceOf3.New.PermissionId = PermissionProvider.FilterFullAccessPermission.Id;
				instanceOf3.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf3.New.User = f.CreationAuthor;
				instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(f.CreationAuthor.Id);
				permissions3.Add(instanceOf3.New);
				f.Save();
			}
		});
	}

	public void FixFiltersTypes()
	{
		AbstractNHEntityManager<IFilter, long>.Instance.FindAll().ToList().ForEach(delegate(IFilter f)
		{
			if (f.ParentFolder != null && f.FilterType != f.ParentFolder.FilterType)
			{
				f.FilterType = f.ParentFolder.FilterType;
				f.CreationAuthor = f.ParentFolder.CreationAuthor;
			}
		});
	}

	public void SetDefaultSettingsToFilter()
	{
		IFilterFilter filterFilter = InterfaceActivator.Create<IFilterFilter>();
		filterFilter.Query = "GridState IS NULL";
		AbstractNHEntityManager<IFilter, long>.Instance.Find(filterFilter, FetchOptions.All).ToList().ForEach(delegate(IFilter f)
		{
			f.UseDefaultSettings = true;
			f.Save();
		});
	}

	public void ConvertBlobStoreHolderKey1()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists("BlobStoreHolder", "Key"))
		{
			serviceNotNull.RenameColumn("BlobStoreHolder", "Key", "Key_Temp");
			serviceNotNull.AddColumn("BlobStoreHolder", new Column("Key", DbType.String, 400));
		}
	}

	public void ConvertBlobStoreHolderKey2()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists("BlobStoreHolder", "Key_Temp"))
		{
			serviceNotNull.ExecuteNonQuery(string.Format("update BlobStoreHolder set {0}=Key_Temp", serviceNotNull.Dialect.QuoteIfNeeded("Key")));
			serviceNotNull.RemoveColumn("BlobStoreHolder", "Key_Temp");
		}
	}

	public void DeleteBlobStoreHolderKeyDups()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ExecuteNonQuery(string.Format("\r\nDELETE FROM {0}\r\nWHERE {1} IN (\r\n\tSELECT {1} FROM {0}\r\n\tGROUP BY {1}\r\n\tHAVING COUNT(*) > 1\r\n)", serviceNotNull.Dialect.QuoteIfNeeded("BlobStoreHolder"), serviceNotNull.Dialect.QuoteIfNeeded("Key")));
	}

	public void CreateUnitMeasures1()
	{
		CreateUnitMeasure(SR.T("Проценты"), new Guid("2F298AB5-4A75-4aff-A2EF-241CA72614DC"), "%", 2, new Guid("AA358531-CE79-4545-9A20-8E3F627FBB18"));
		CreateUnitMeasure(SR.T("Штуки"), new Guid("CE85DB02-D53B-446c-97E3-1FAA87D7F26D"), SR.T("шт."), 0, new Guid("0094A38B-4CC2-4055-9BF7-84176B7C9C87"));
		CreateUnitMeasure(SR.T("Человек"), new Guid("2C13586C-2D11-4862-BC47-1939799C2FE1"), SR.T("чел."), 0, new Guid("D06363C5-9C59-424E-9780-0D636C1C464F"));
		CreateUnitMeasure(SR.T("Разы"), new Guid("96C0C47F-C753-4ddb-9615-28BA4217AF53"), SR.T("раз."), 0, new Guid("30A0C2D5-7888-4676-8C55-3B6EB8A13FEF"));
		CreateUnitMeasure(SR.T("Комплекты"), new Guid("90B59030-86CD-4cc3-A02B-A795915A0D18"), SR.T("комплект."), 0, new Guid("285C2C11-DB89-4C77-90BE-582416C4D582"));
		CreateUnitMeasure(SR.T("Тысячи рублей"), new Guid("4831CEAF-6256-4f07-B94B-BA03921EB61F"), SR.T("тыс. руб."), 2, new Guid("01EE0BB6-8167-4774-BFB2-7778D0EA7038"));
		CreateUnitMeasure(SR.T("Рубли"), new Guid("EE0EBF00-1EF9-4503-AFC6-87424F90D9BE"), SR.T("руб."), 2, new Guid("18006FA0-DF61-4CE1-8732-904168640A19"));
		CreateUnitMeasure(SR.T("Доллары"), new Guid("F9D9B1BA-99B5-4ff0-8582-05BEBA8C91E1"), "$", 2, new Guid("62F02F70-85BF-488F-AF40-BEAD18753DF5"));
		CreateUnitMeasure(SR.T("Евро"), new Guid("668DBFC1-9151-47b1-A084-B24C17673EB3"), SR.T("евро"), 2, new Guid("14910812-52B8-45FB-992A-C4589A34174F"));
	}

	private void CreateUnitMeasure(string name, Guid uid, string shortening, int doublePrecision, Guid propUid)
	{
		IUnitMeasureProperties unitMeasureProperties = EntityManager<IUnitMeasureProperties>.Instance.LoadOrCreate(propUid);
		unitMeasureProperties.Uid = propUid;
		unitMeasureProperties.DoublePrecision = doublePrecision;
		unitMeasureProperties.DoubleSeparator = ",";
		unitMeasureProperties.NegativeFormat = NegativeFormat.LeftMinus;
		unitMeasureProperties.GroupSeparator = " ";
		unitMeasureProperties.GroupMemberLenght = 3;
		unitMeasureProperties.Position = UnitMeasurePosition.Right;
		unitMeasureProperties.Save();
		IUnitMeasure unitMeasure = EntityManager<IUnitMeasure>.Instance.LoadOrCreate(uid);
		unitMeasure.Name = name;
		unitMeasure.Uid = uid;
		unitMeasure.Shortening = shortening;
		unitMeasure.Properties = unitMeasureProperties;
		unitMeasure.Save();
	}

	public void WatchEntityFieldConvert()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists("Watch", "tmp_EntityId_"))
		{
			serviceNotNull.ExecuteNonQuery(string.Format("update Watch set {0}=tmp_EntityId_", serviceNotNull.Dialect.QuoteIfNeeded("EntityId")));
			serviceNotNull.RemoveColumn("Watch", "tmp_EntityId_");
		}
		if (serviceNotNull.ColumnExists("Watch", "tmp_ParentEntityId_"))
		{
			serviceNotNull.ExecuteNonQuery(string.Format("update Watch set {0}=tmp_ParentEntityId_", serviceNotNull.Dialect.QuoteIfNeeded("ParentEntityId")));
			serviceNotNull.RemoveColumn("Watch", "tmp_ParentEntityId_");
		}
	}

	public void FillBudgetIncomeReference()
	{
		if (!BudgetIncomeItemRefManager.Instance.Exists())
		{
			BudgetIncomeItemRefManager.Instance.CreateDefaultItems();
		}
	}

	public void FillBudgetExpenseReference()
	{
		if (!BudgetExpenseItemRefManager.Instance.Exists())
		{
			BudgetExpenseItemRefManager.Instance.CreateDefaultItems();
		}
	}

	public void UpdateBudgetReferenceUids()
	{
		IBudgetIncomeItemRefFilter budgetIncomeItemRefFilter = InterfaceActivator.Create<IBudgetIncomeItemRefFilter>();
		string format = "Name = '{0}'";
		budgetIncomeItemRefFilter.Query = string.Format(format, SR.T("Доходы от реализации продукции"));
		IBudgetIncomeItemRef budgetIncomeItemRef = BudgetIncomeItemRefManager.Instance.Find(budgetIncomeItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetIncomeItemRef != null)
		{
			budgetIncomeItemRef.Uid = BudgetIncomeItemRefManager.BudgetIncomeItemRef1Uid;
			budgetIncomeItemRef.Save();
		}
		budgetIncomeItemRefFilter.Query = string.Format(format, SR.T("Консалтинг"));
		budgetIncomeItemRef = BudgetIncomeItemRefManager.Instance.Find(budgetIncomeItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetIncomeItemRef != null)
		{
			budgetIncomeItemRef.Uid = BudgetIncomeItemRefManager.BudgetIncomeItemRef2Uid;
			budgetIncomeItemRef.Save();
		}
		budgetIncomeItemRefFilter.Query = string.Format(format, SR.T("Лицензионные отчисления"));
		budgetIncomeItemRef = BudgetIncomeItemRefManager.Instance.Find(budgetIncomeItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetIncomeItemRef != null)
		{
			budgetIncomeItemRef.Uid = BudgetIncomeItemRefManager.BudgetIncomeItemRef3Uid;
			budgetIncomeItemRef.Save();
		}
		budgetIncomeItemRefFilter.Query = string.Format(format, SR.T("Прочее"));
		budgetIncomeItemRef = BudgetIncomeItemRefManager.Instance.Find(budgetIncomeItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetIncomeItemRef != null)
		{
			budgetIncomeItemRef.Uid = BudgetIncomeItemRefManager.BudgetIncomeItemRef4Uid;
			budgetIncomeItemRef.Save();
		}
		IBudgetExpenseItemRefFilter budgetExpenseItemRefFilter = InterfaceActivator.Create<IBudgetExpenseItemRefFilter>();
		budgetExpenseItemRefFilter.Query = string.Format(format, SR.T("Арендная плата"));
		IBudgetExpenseItemRef budgetExpenseItemRef = BudgetExpenseItemRefManager.Instance.Find(budgetExpenseItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetExpenseItemRef != null)
		{
			budgetExpenseItemRef.Uid = BudgetExpenseItemRefManager.BudgetExpenseItemRef1Uid;
			budgetExpenseItemRef.Save();
		}
		budgetExpenseItemRefFilter.Query = string.Format(format, SR.T("Зарплата"));
		budgetExpenseItemRef = BudgetExpenseItemRefManager.Instance.Find(budgetExpenseItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetExpenseItemRef != null)
		{
			budgetExpenseItemRef.Uid = BudgetExpenseItemRefManager.BudgetExpenseItemRef2Uid;
			budgetExpenseItemRef.Save();
		}
		budgetExpenseItemRefFilter.Query = string.Format(format, SR.T("Командировочные расходы"));
		budgetExpenseItemRef = BudgetExpenseItemRefManager.Instance.Find(budgetExpenseItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetExpenseItemRef != null)
		{
			budgetExpenseItemRef.Uid = BudgetExpenseItemRefManager.BudgetExpenseItemRef3Uid;
			budgetExpenseItemRef.Save();
		}
		budgetExpenseItemRefFilter.Query = string.Format(format, SR.T("Страховые выплаты"));
		budgetExpenseItemRef = BudgetExpenseItemRefManager.Instance.Find(budgetExpenseItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetExpenseItemRef != null)
		{
			budgetExpenseItemRef.Uid = BudgetExpenseItemRefManager.BudgetExpenseItemRef4Uid;
			budgetExpenseItemRef.Save();
		}
		budgetExpenseItemRefFilter.Query = string.Format(format, SR.T("Выплаты по кредитам"));
		budgetExpenseItemRef = BudgetExpenseItemRefManager.Instance.Find(budgetExpenseItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetExpenseItemRef != null)
		{
			budgetExpenseItemRef.Uid = BudgetExpenseItemRefManager.BudgetExpenseItemRef5Uid;
			budgetExpenseItemRef.Save();
		}
		budgetExpenseItemRefFilter.Query = string.Format(format, SR.T("Прочее"));
		budgetExpenseItemRef = BudgetExpenseItemRefManager.Instance.Find(budgetExpenseItemRefFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (budgetExpenseItemRef != null)
		{
			budgetExpenseItemRef.Uid = BudgetExpenseItemRefManager.BudgetExpenseItemRef6Uid;
			budgetExpenseItemRef.Save();
		}
	}

	internal void UpdateBudgetReferenceIsDeleted()
	{
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IBudgetIncomeItemRef>());
		base.Transformation.Update(entityMetadata.TableName, new string[1] { base.Transformation.Dialect.QuoteIfNeeded("IsDeleted") }, new object[1] { 0 }, "");
		EntityMetadata entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IBudgetExpenseItemRef>());
		base.Transformation.Update(entityMetadata2.TableName, new string[1] { base.Transformation.Dialect.QuoteIfNeeded("IsDeleted") }, new object[1] { 0 }, "");
	}

	public void ConvertWatchesColumns()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ConvertColumnString("Watch", InterfaceActivator.PropertyName((IWatch w) => w.EntityId), 50, substringStrings: true);
		serviceNotNull.ConvertColumnString("Watch", InterfaceActivator.PropertyName((IWatch w) => w.ParentEntityId), 50, substringStrings: true);
	}

	internal void DeleteSystemMetadataItemWithHeaders()
	{
		IEnumerable<EntityMetadata> enumerable = IMetadataRuntimeService.GetMetadataList().OfType<EntityMetadata>();
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		bool flag = false;
		List<Guid> list = new List<Guid>();
		foreach (EntityMetadata item in enumerable)
		{
			if (item != null && item.ShowInCatalogList && item.ShowInDesigner && item.Type == EntityMetadataType.Interface && item.BaseClassUid == Guid.Empty && item.IsSystem())
			{
				flag = true;
				list.Add(item.Uid);
			}
		}
		if (!flag)
		{
			return;
		}
		string text = "head";
		foreach (IGrouping<IMetadataItemHeader, IMetadataItem> item2 in from a in session.CreateCriteria(InterfaceActivator.TypeOf<IMetadataItem>()).CreateAlias(LinqUtils.NameOf((Expression<Func<IMetadataItem, object>>)((IMetadataItem a) => a.Header)), text).Add((ICriterion)(object)Restrictions.In(text + "." + LinqUtils.NameOf((Expression<Func<IMetadataItemHeader, object>>)((IMetadataItemHeader a) => a.Uid)), (ICollection)list))
				.List<IMetadataItem>()
				.ToList()
			group a by a.Header)
		{
			foreach (IMetadataItem item3 in item2)
			{
				if (item3.ScriptModule != null)
				{
					item3.ScriptModule.Delete();
				}
				item3.Delete();
			}
			item2.Key.Delete();
		}
	}

	internal void DeleteMetadataDublicateSystemProperties()
	{
		MetadataItemManager instance = MetadataItemManager.Instance;
		IEnumerable<IMetadataItem> enumerable = instance.FindDraftItems();
		bool flag = false;
		foreach (IMetadataItem item in enumerable)
		{
			if (!(item.Metadata is EntityMetadata entityMetadata) || entityMetadata.Type != EntityMetadataType.InterfaceExtension)
			{
				continue;
			}
			IEnumerable<PropertyMetadata> source = MetadataLoader.GetBaseClassMetadataList(entityMetadata, includeExtensions: true, loadImplementation: false).SelectMany((ClassMetadata a) => a.Properties);
			for (int num = entityMetadata.Properties.Count; num > 0; num--)
			{
				PropertyMetadata prop = entityMetadata.Properties[num - 1];
				if (source.Any((PropertyMetadata a) => a.Uid == prop.Uid))
				{
					entityMetadata.Properties.Remove(prop);
					flag = true;
				}
			}
		}
		if (flag)
		{
			instance.Save(enumerable);
		}
	}

	internal void FixUpdateIdFieldFSFileForObject()
	{
		IFixUpdateIdFieldFSFileForObjectExtension fixUpdateIdFieldFSFileForObjectExtension = ComponentManager.Current.GetExtensionPoints<IFixUpdateIdFieldFSFileForObjectExtension>().FirstOrDefault((IFixUpdateIdFieldFSFileForObjectExtension ext) => ext.ProviderUid == base.Transformation.Uid);
		if (fixUpdateIdFieldFSFileForObjectExtension != null)
		{
			ILogger logger = Logger.GetLogger("ElmaDbUpdate");
			logger.Info(SR.T("Начало исправления ссылок на файлы"));
			fixUpdateIdFieldFSFileForObjectExtension.CreateTemplateTable();
			IEnumerable<IMetadata> metadataList = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList();
			UpdateFileIdForMetadataList(fixUpdateIdFieldFSFileForObjectExtension, logger, metadataList);
			fixUpdateIdFieldFSFileForObjectExtension.RemoveTemplateTable();
			logger.Info(SR.T("Завершение исправления ссылок на файлы"));
		}
	}

	private void UpdateFileIdForMetadataList(IFixUpdateIdFieldFSFileForObjectExtension extensionPoint, ILogger dbUpdateLog, IEnumerable<IMetadata> metadataList)
	{
		int num = metadataList.Count();
		int num2 = 0;
		foreach (IMetadata metadata in metadataList)
		{
			num2++;
			UpdateFileIdForMetadata(extensionPoint, metadata as EntityMetadata);
			dbUpdateLog.Info(SR.T("Исправление ссылок на файлы: {0} из {1} - {2}", num2, num, metadata));
		}
	}

	private void UpdateFileIdForMetadata(IFixUpdateIdFieldFSFileForObjectExtension extensionPoint, EntityMetadata entityMetadata)
	{
		if (entityMetadata == null || entityMetadata.IsInterfaceType)
		{
			return;
		}
		foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
		{
			UpdateFileIdForMetadata(extensionPoint, tablePart);
		}
		foreach (PropertyMetadata property in entityMetadata.Properties)
		{
			if (property.TypeUid == BinaryFileDescriptor.UID && property.Settings is SimpleTypeSettings simpleTypeSettings)
			{
				UpdateFileIdQuery(extensionPoint, entityMetadata.TableName, simpleTypeSettings.FieldName);
			}
		}
	}

	private void UpdateFileIdQuery(IFixUpdateIdFieldFSFileForObjectExtension extensionPoint, string tableName, string fieldName)
	{
		extensionPoint.UpdateData(tableName, fieldName);
	}
}
