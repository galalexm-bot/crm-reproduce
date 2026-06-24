using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentMetadataHeadManager : EntityManager<IDocumentMetadataHead, long>
{
	public static string ControlOnSendingKey = "EleWise.ELMA.Documents.Managers.ControlOnSendingKey";

	public new static DocumentMetadataHeadManager Instance => Locator.GetServiceNotNull<DocumentMetadataHeadManager>();

	public ILockManager LockManager { get; set; }

	public IEnumerable<IDocumentMetadataHead> PublishedHeads()
	{
		List<DocumentMetadata> source = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
			where m.Type == EntityMetadataType.Interface
			select m).ToList();
		return CreateCriteria().Add((ICriterion)(object)Restrictions.In("DocumentTypeUid", (ICollection)source.Select((DocumentMetadata d) => d.Uid).ToList())).List<IDocumentMetadataHead>();
	}

	[Auditable]
	[Transaction]
	public virtual void InitDeleteAction(IDocumentMetadataHead head)
	{
	}

	[Transaction]
	[PublicApiMember]
	public override void Delete(IDocumentMetadataHead obj)
	{
		InitDeleteAction(obj);
		base.Delete(obj);
	}

	public override ExportRuleList ExportRules()
	{
		InterfaceActivator.TypeOf<IDocumentMetadataHead>();
		return new ExportRuleList();
	}

	internal long findUse(Guid metadataType, long elementOrgstructurId, Guid typeUid)
	{
		long result = 0L;
		foreach (IDocumentMetadataHead item in from e in Instance.PublishedHeads()
			where e.DocumentTypeUid == metadataType
			select e)
		{
			DocumentMetadata obj = (DocumentMetadata)MetadataLoader.LoadMetadata(item.DocumentTypeUid, inherit: false);
			string tableName = obj.TableName;
			IEnumerable<PropertyMetadata> enumerable = obj.Properties.Where((PropertyMetadata e) => e.SubTypeUid == typeUid);
			new List<string>();
			int num = 1;
			List<string> list = new List<string>();
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			List<int> list2 = new List<int>();
			List<string> list3 = new List<string>();
			foreach (EntityPropertyMetadata propMetadta in enumerable)
			{
				EntitySettings entitySettings = (EntitySettings)propMetadta.SimpleTypeSettings;
				if (propMetadta.TableNumber > 0 && list2.All((int j) => j != propMetadta.TableNumber))
				{
					list.Add(string.Format("left join {0} tab_{1} on tab_{1}.{2} = {3}.{2}", serviceNotNull.Dialect.QuoteIfNeeded(tableName), propMetadta.TableNumber, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.FieldName)));
					list2.Add(propMetadta.TableNumber);
				}
				if (propMetadta.Settings != null)
				{
					switch (entitySettings.RelationType)
					{
					case RelationType.ManyToMany:
						list.Add(string.Format("left join {0} rel_join_{1} on rel_join_{1}.{2}={3}.{4}", entitySettings.RelationTableName, num, serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.ParentColumnName), serviceNotNull.Dialect.QuoteIfNeeded(tableName), serviceNotNull.Dialect.QuoteIfNeeded("Id")));
						list3.Add($"rel_join_{num}.{serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.ChildColumnName)}" + "=" + elementOrgstructurId);
						num++;
						break;
					case RelationType.ManyToManyInverse:
						list.Add(string.Format("left join {0} rel_join_{1} on rel_join_{1}.{2}={3}.{4}", entitySettings.RelationTableName, num, serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.ChildColumnName), serviceNotNull.Dialect.QuoteIfNeeded(tableName), serviceNotNull.Dialect.QuoteIfNeeded("Id")));
						list3.Add($"rel_join_{num}.{serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.ParentColumnName)}" + "=" + elementOrgstructurId);
						num++;
						break;
					default:
						list3.Add(string.Format("{0}{1}", (propMetadta.TableNumber > 0) ? $"tab_{propMetadta.TableNumber}." : "", serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.FieldName)) + "=" + elementOrgstructurId);
						break;
					}
				}
				else
				{
					list3.Add(string.Format("{0}{1}", (propMetadta.TableNumber > 0) ? $"tab_{propMetadta.TableNumber}." : "", serviceNotNull.Dialect.QuoteIfNeeded(entitySettings.FieldName)));
				}
			}
			if (list3.Count() > 0)
			{
				string text = string.Format("select count(1) from {0} {1} {2} where {3} ", serviceNotNull.Dialect.QuoteIfNeeded(tableName), string.Join(" ", list), string.Join(" ", list2), string.Join(" or ", list3));
				result = Convert.ToInt64(((IQuery)(object)base.Session.CreateSQLQuery(text)).CleanUpCache(cleanUpCache: false).UniqueResult());
			}
		}
		return result;
	}

	[Transaction]
	public virtual void SaveControlOnSendingChanges(ControlOnSendingItem item)
	{
		if (!LockManager.TryLock(ControlOnSendingKey, out var @lock))
		{
			return;
		}
		using (@lock)
		{
			if (item == null)
			{
				return;
			}
			_ = item.ParentMetadata;
			ControlOnSendingInfo controlOnSendingInfo = DataAccessManager.BLOBManager.GetBLOB<ControlOnSendingInfo>(__AssemblyInfo.UID, ControlOnSendingInfo.BLOBKey);
			if (controlOnSendingInfo == null)
			{
				controlOnSendingInfo = new ControlOnSendingInfo();
			}
			ControlOnSendingItem controlOnSendingItem = controlOnSendingInfo.Infos.FirstOrDefault((ControlOnSendingItem i) => i.ParentMetadata == item.ParentMetadata);
			if (controlOnSendingItem == null)
			{
				controlOnSendingInfo.Infos.Add(item);
			}
			else
			{
				foreach (Guid childMetadatum in item.ChildMetadata)
				{
					if (!controlOnSendingItem.ChildMetadata.Contains(childMetadatum))
					{
						controlOnSendingItem.ChildMetadata.Add(childMetadatum);
					}
				}
			}
			DataAccessManager.BLOBManager.SetBLOB(__AssemblyInfo.UID, ControlOnSendingInfo.BLOBKey, controlOnSendingInfo);
		}
	}

	[Transaction]
	public virtual ControlOnSendingInfo PutControlOnSendingChanges()
	{
		if (LockManager.TryLock(ControlOnSendingKey, out var @lock))
		{
			using (@lock)
			{
				ControlOnSendingInfo controlOnSendingInfo = DataAccessManager.BLOBManager.GetBLOB<ControlOnSendingInfo>(__AssemblyInfo.UID, ControlOnSendingInfo.BLOBKey);
				if (controlOnSendingInfo == null)
				{
					controlOnSendingInfo = new ControlOnSendingInfo();
				}
				DataAccessManager.BLOBManager.SetBLOB(__AssemblyInfo.UID, ControlOnSendingInfo.BLOBKey, new ControlOnSendingInfo());
				return controlOnSendingInfo;
			}
		}
		return null;
	}
}
