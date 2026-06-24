using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Antlr.Runtime;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Audit;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Documents.BPMN;
using EleWise.ELMA.Documents.DocumentAuditEvents;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.FullTextSearch.Components;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Listeners;
using EleWise.ELMA.Documents.Managers.Filters;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Documents.Models.Messages;
using EleWise.ELMA.Documents.PropertyHandlers;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Encrypters;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentManager<T, TId> : DmsObjectManager<T, TId> where T : IDocument, IEntity<TId>
{
	private ICryptoContextAuthService cryptoContextAuthService;

	private IDocumentEventHandler documentEventHandler;

	private IDocumentEventHandler DocumentEventHandler => documentEventHandler ?? (documentEventHandler = Locator.GetService<IDocumentEventHandler>());

	protected WatchEntityActionHandler WatchEntityActionHandler => Locator.GetServiceNotNull<WatchEntityActionHandler>();

	public ITransformationProvider Transform { get; set; }

	public IConvertProcessService ConvertProcessService { get; set; }

	public ICryptoContextAuthService CryptoContextAuthService => cryptoContextAuthService ?? (cryptoContextAuthService = Locator.GetServiceNotNull<ICryptoContextAuthService>());

	public IEnumerable<ITypeEncrypter> TypeEncrypters { get; set; }

	public IMimeMappingService MimeMappingService { get; set; }

	public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService { get; set; }

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter == null || !(filter is IDocumentFilter))
		{
			return;
		}
		IDocumentFilter documentFilter = (IDocumentFilter)filter;
		string typeUidPropertyName = GetTypeUidPropertyName(filter);
		if (documentFilter.TypeUid.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq(typeUidPropertyName, (object)documentFilter.TypeUid.Value));
		}
		if (documentFilter.Types != null && documentFilter.Types.Count > 0)
		{
			List<Guid> list = documentFilter.Types.Where((ReferenceOnEntityType t) => t != null && t.TypeUid != Guid.Empty).SelectMany(delegate(ReferenceOnEntityType t)
			{
				ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(t.TypeUid);
				List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
				childClasses.Add(classMetadata);
				return childClasses.Select((ClassMetadata ch) => ch.Uid);
			}).Distinct()
				.ToList();
			if (list.Count > 0)
			{
				criteria.Add((ICriterion)(object)Restrictions.In(typeUidPropertyName, (ICollection)list));
			}
		}
		if (documentFilter.ListCycleStatus != null && ((IEnumerable<ILifeCycleStatus>)documentFilter.ListCycleStatus).Count((ILifeCycleStatus s) => s != null) > 0)
		{
			DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<ILifeCycleStatus>()).Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)(from s in (IEnumerable<ILifeCycleStatus>)documentFilter.ListCycleStatus
				where s != null
				select s into m
				select m.Uid).ToList())).SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")));
			criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Status.id", val));
		}
		if (documentFilter.SendInfo != null)
		{
			DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf<IDocumentSendStatusCache>()).SetProjection((IProjection)(object)Projections.Property("Document"));
			bool flag = false;
			if (documentFilter.SendInfo.SendStatus.HasValue)
			{
				if (documentFilter.SendInfo.SendStatus.Value == SendStatus.NotSended)
				{
					val2.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("SendStatus", (object)documentFilter.SendInfo.SendStatus.Value), (ICriterion)(object)Restrictions.IsNull("SendStatus")));
				}
				else
				{
					val2.Add((ICriterion)(object)Restrictions.Eq("SendStatus", (object)documentFilter.SendInfo.SendStatus.Value));
				}
				flag = true;
			}
			if (documentFilter.SendInfo.SendDate != null)
			{
				DateTimeRange dateTimeRange = new DateTimeRange(documentFilter.SendInfo.SendDate.FromValue, documentFilter.SendInfo.SendDate.ToValue);
				if (dateTimeRange.From.HasValue)
				{
					val2.Add((ICriterion)(object)Restrictions.Ge("SendDate", (object)dateTimeRange.From.Value));
					flag = true;
				}
				if (dateTimeRange.To.HasValue)
				{
					val2.Add((ICriterion)(object)Restrictions.Le("SendDate", (object)dateTimeRange.To.Value));
					flag = true;
				}
			}
			if (documentFilter.SendInfo.SendUser != null)
			{
				val2.Add((ICriterion)(object)Restrictions.Eq("SendUser", (object)documentFilter.SendInfo.SendUser));
				flag = true;
			}
			if (documentFilter.SendInfo.SendDocumentType != null)
			{
				val2.Add((ICriterion)(object)Restrictions.Eq("SendDocumentType", (object)documentFilter.SendInfo.SendDocumentType));
				flag = true;
			}
			if (!string.IsNullOrEmpty(documentFilter.SendInfo.SendNumber))
			{
				val2.Add((ICriterion)(object)ElmaRestrictions.Like("SendNumber", documentFilter.SendInfo.SendNumber, MatchMode.Anywhere));
				flag = true;
			}
			if (flag)
			{
				criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
				List<Guid> list2 = (from m in (from m in base.MetadataRuntimeService.GetMetadataList().OfType<DocumentMetadata>()
						where m.ControlOnSending
						select MetadataLoader.LoadMetadata(m.Uid)).Distinct((IMetadata m1, IMetadata m2) => m1.Uid == m2.Uid)
					select m.Uid).ToList();
				criteria.Add((ICriterion)(object)Restrictions.In(typeUidPropertyName, (ICollection)list2));
			}
		}
		if (documentFilter.NeedAnswer.HasValue)
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			List<DocumentMetadata> list3 = (from m in base.MetadataRuntimeService.GetMetadataList().OfType<DocumentMetadata>()
				where m.NeedAnswer && (m.Type == EntityMetadataType.Interface || m.Type == EntityMetadataType.Entity || m.Type == EntityMetadataType.InterfaceExtension)
				select (DocumentMetadata)MetadataLoader.LoadMetadata(m.Uid)).Distinct((DocumentMetadata m1, DocumentMetadata m2) => m1.Uid == m2.Uid).ToList();
			List<string> list4 = new List<string>();
			foreach (DocumentMetadata answerType in list3)
			{
				if (answerType.AnswerDocumentProperty == Guid.Empty)
				{
					continue;
				}
				EntityPropertyMetadata entityPropertyMetadata = (EntityPropertyMetadata)answerType.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == answerType.AnswerDocumentProperty);
				if (entityPropertyMetadata != null)
				{
					EntityMetadata entityMetadata = MetadataLoader.GetRealMetadataForProperty(answerType, entityPropertyMetadata.Uid) as EntityMetadata;
					if (entityMetadata == null)
					{
						entityMetadata = answerType;
					}
					list4.Add(string.Format("select {0} from {1} where {2} {3}", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded(EntityPropertyMetadata.GetTableName(entityMetadata.TableName, entityPropertyMetadata.TableNumber)), serviceNotNull.Dialect.QuoteIfNeeded(((EntitySettings)entityPropertyMetadata.Settings).FieldName), documentFilter.NeedAnswer.Value ? "is null" : "is not null"));
				}
			}
			if (list4.Count > 0)
			{
				string arg = string.Join(" union ", list4);
				criteria.Add((ICriterion)(object)Expression.Sql(string.Format("{{alias}}.{0} in ({1})", serviceNotNull.Dialect.QuoteIfNeeded("Id"), arg)));
			}
			else
			{
				criteria.Add((ICriterion)(object)Expression.Sql("0=1"));
			}
		}
		if (documentFilter.Ids.HasItems())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)documentFilter.Ids));
		}
		if (documentFilter.TypeUids.HasItems())
		{
			criteria.Add((ICriterion)(object)Restrictions.In(typeUidPropertyName, (ICollection)documentFilter.TypeUids));
		}
		List<IDocumentFilterExtension> list5 = ComponentManager.Current.GetExtensionPoints<IDocumentFilterExtension>().ToList();
		if (list5 == null)
		{
			return;
		}
		foreach (IDocumentFilterExtension item in list5)
		{
			item.AddFilterCriteris(criteria, filter);
		}
	}

	public void AuditBrowse(IDocument document)
	{
		if (DocumentEventHandler != null)
		{
			DocumentEventHandler.BrowseDocument(document);
		}
	}

	public string CheckAndGetCryptPassword(IDocument document)
	{
		if (document.Encrypt)
		{
			return CryptoContextAuthService.GetPasswordFromContext(document) ?? throw new EncryptDocumentException(document.Id);
		}
		return null;
	}

	[Transaction]
	public virtual void EditSave(T document)
	{
		document.ChangeDate = DateTime.Now;
		document.ChangeAuthor = base.AuthenticationService.GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
		document.Save();
		EntityActionEventArgs e = new EntityActionEventArgs(null, document, DmsObjectActions.EditGuid);
		base.EntityActionHandler.ActionExecuted(e);
	}

	public virtual bool IsVersionsNeedEncrypt(T document)
	{
		if (document.Encrypt)
		{
			IEntity cryptoEntity = GetCryptoEntity(document);
			if (cryptoEntity == null)
			{
				return false;
			}
			string text = (string)cryptoEntity.GetPropertyValue("CryptedAttr", null);
			return ((!string.IsNullOrEmpty(text)) ? (from a in text.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
				select new Guid(a)).ToList() : new List<Guid>()).Contains(InterfaceActivator.PropertyUid((IDocument m) => m.Versions));
		}
		return false;
	}

	[Transaction]
	public virtual void Encrypt(T document, string password)
	{
		if (document.Encrypt)
		{
			throw new ArgumentException(SR.T("Документ уже зашифрован"));
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
		if (!documentMetadata.EnableCrypto || documentMetadata.CryptoSettings == null)
		{
			throw new Exception(SR.T("Для типа документа {0} не включена возможность для шифрования"));
		}
		if (documentMetadata.CryptoSettings.CryptoEntityTypeUid == Guid.Empty)
		{
			throw new Exception(SR.T("Не задана сущность для шифрования"));
		}
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		string text = EncryptionHelper.GenerateSalt();
		foreach (Guid cryptoAttribute in documentMetadata.CryptoSettings.CryptoAttributes)
		{
			PropertyMetadata propertyMetadata = documentMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == cryptoAttribute);
			if (propertyMetadata == null)
			{
				continue;
			}
			object propertyValue = document.CastAsRealType().GetPropertyValue(cryptoAttribute);
			if (propertyValue == null)
			{
				continue;
			}
			Type valueType = propertyValue.CastAsRealType().GetType();
			System.Reflection.PropertyInfo reflectionProperty = document.CastAsRealType().GetType().GetReflectionProperty(propertyMetadata.Name);
			bool flag = typeof(IEnumerable).IsAssignableFrom(reflectionProperty.PropertyType) && reflectionProperty.PropertyType.IsGenericType;
			if (propertyMetadata.Name.Equals("Versions"))
			{
				foreach (IDocumentVersion item3 in (IEnumerable<IDocumentVersion>)document.Versions)
				{
					DocumentVersionManager.Instance.EnryptInternal(item3, password);
				}
			}
			else if (flag)
			{
				ListInfo listInfo = new ListInfo();
				foreach (object item in (IEnumerable)propertyValue)
				{
					ITypeEncrypter typeEncrypter = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(item, propertyMetadata));
					if (typeEncrypter != null)
					{
						string item2 = typeEncrypter.Encrypt(item, password, text, propertyMetadata);
						listInfo.Objects.Add(item2);
					}
				}
				dictionary.Add(cryptoAttribute, ClassSerializationHelper.SerializeObjectByXml(listInfo));
				Type @interface = reflectionProperty.PropertyType.GetInterface(typeof(ICollection<>).GetGenericTypeDefinition().Name);
				if (@interface != null)
				{
					MethodInfo method = @interface.GetMethod("Clear");
					if (method != null)
					{
						method.Invoke(propertyValue, new object[0]);
					}
				}
			}
			else
			{
				ITypeEncrypter typeEncrypter2 = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(valueType, propertyMetadata));
				if (typeEncrypter2 != null)
				{
					string value = typeEncrypter2.Encrypt(propertyValue, password, text, propertyMetadata);
					dictionary.Add(cryptoAttribute, value);
					document.CastAsRealType().SetPropertyValue(cryptoAttribute, typeEncrypter2.EncryptStub(propertyValue, propertyMetadata));
				}
			}
		}
		IEntityManager entityManager = EntityHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(documentMetadata.CryptoSettings.CryptoEntityTypeUid));
		Filter filter = new Filter
		{
			Query = $"ParentDocument = {document.GetId()}"
		};
		IEntity entity = entityManager.Find(filter, new FetchOptions(0, 1)).Cast<IEntity>().FirstOrDefault() ?? ((IEntity)entityManager.Create());
		entity.SetPropertyValue("ParentDocument", document);
		entity.SetPropertyValue("CryptedAttr", string.Join(",", documentMetadata.CryptoSettings.CryptoAttributes));
		foreach (KeyValuePair<Guid, string> item4 in dictionary)
		{
			entity.SetPropertyValue(item4.Key, item4.Value);
		}
		entityManager.Save(entity);
		document.Salt = text;
		string plainText = EncryptionHelper.GenerateSalt(256);
		document.CryptoToken = EncryptionHelper.Encrypt(plainText, text, password);
		document.Encrypt = true;
		document.EncryptDate = DateTime.Now;
		document.EncryptUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		document.Save();
		base.Session.Flush();
		EntityActionEventArgs e2 = new EntityActionEventArgs(null, document, "88bfde2c-ef7b-4784-a08e-b021bf658970");
		base.EntityActionHandler.ActionExecuted(e2);
	}

	public virtual IEntity GetCryptoEntity(T document)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
		IEntityManager entityManager = EntityHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(documentMetadata.CryptoSettings.CryptoEntityTypeUid));
		Filter filter = new Filter
		{
			Query = $"ParentDocument = {document.GetId()}"
		};
		return entityManager.Find(filter, new FetchOptions(0, 1)).Cast<IEntity>().FirstOrDefault() ?? ((IEntity)entityManager.Create());
	}

	[Transaction]
	public virtual void SendEncryptPasswordEntered(T document, bool status)
	{
		EntityActionEventArgs e = new EntityActionEventArgs(null, document, status ? "d745477e-4d0c-406b-afea-f46966137358" : "83875845-16cb-4ea1-84b1-178dcc3bb420");
		base.EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	public override void Rename(T dmsObject, string newName)
	{
		if (dmsObject.Encrypt && MetadataLoader.LoadMetadata(dmsObject.TypeUid) is DocumentMetadata documentMetadata)
		{
			PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata((IDmsObject m) => m.Name);
			if (documentMetadata.CryptoSettings.CryptoAttributes.Contains(propertyMetadata.Uid))
			{
				return;
			}
		}
		base.Rename(dmsObject, newName);
	}

	[Transaction]
	public virtual void Rename(T document, string newName, string password)
	{
		if (!(MetadataLoader.LoadMetadata(document.TypeUid) is DocumentMetadata documentMetadata))
		{
			return;
		}
		PropertyMetadata nameProperty = InterfaceActivator.LoadPropertyMetadata((IDmsObject m) => m.Name);
		if (!document.Encrypt || !documentMetadata.CryptoSettings.CryptoAttributes.Contains(nameProperty.Uid))
		{
			Rename(document, newName);
		}
		else if (CheckPassword(document, password))
		{
			IEntityManager entityManager = EntityHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(documentMetadata.CryptoSettings.CryptoEntityTypeUid));
			Filter filter = new Filter
			{
				Query = $"ParentDocument = {document.GetId()}"
			};
			IEntity entity = entityManager.Find(filter, new FetchOptions(0, 1)).Cast<IEntity>().FirstOrDefault();
			if (entity == null)
			{
				throw new Exception(SR.T("Не найдены зашифрованные данные для документа."));
			}
			ITypeEncrypter typeEncrypter = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(typeof(string), nameProperty));
			if (typeEncrypter != null)
			{
				string value = typeEncrypter.Encrypt(newName, password, document.Salt, nameProperty);
				entity.SetPropertyValue(nameProperty.Uid, value);
				document.Name = (string)typeEncrypter.EncryptStub(newName, nameProperty);
				document.Save();
			}
		}
	}

	public virtual bool CheckPassword(IDocument document, string password, bool writeHistory = false)
	{
		try
		{
			EncryptionHelper.Decrypt(document.CryptoToken, document.Salt, password);
		}
		catch (Exception)
		{
			if (writeHistory)
			{
				DocumentManager.Instance.SendEncryptPasswordEntered(document, status: false);
			}
			return false;
		}
		return true;
	}

	public virtual T Decrypt(T document, string password, bool noVersion = false)
	{
		return ContextVars.GetOrAdd("DecryptedDocument" + document.GetId(), delegate
		{
			DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
			IEntityManager entityManager = EntityHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(documentMetadata.CryptoSettings.CryptoEntityTypeUid));
			Filter filter = new Filter
			{
				Query = $"ParentDocument = {document.GetId()}"
			};
			IEntity entity = entityManager.Find(filter, FetchOptions.First).Cast<IEntity>().FirstOrDefault();
			if (entity == null)
			{
				throw new Exception(SR.T("Не найдена зашифрованная сущность"));
			}
			string text = (string)entity.GetPropertyValue("CryptedAttr", null);
			foreach (Guid cryptoAttribute in (!string.IsNullOrEmpty(text)) ? (from a in text.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
				select new Guid(a)).ToList() : new List<Guid>())
			{
				PropertyMetadata propertyMetadata = documentMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == cryptoAttribute);
				if (propertyMetadata != null && (!noVersion || !propertyMetadata.Name.Equals("Versions")))
				{
					if (propertyMetadata.Name.Equals("Versions"))
					{
						foreach (IDocumentVersion item in (IEnumerable<IDocumentVersion>)document.Versions)
						{
							DocumentVersionManager.Instance.Decrypt(item, password);
						}
					}
					else
					{
						object propertyValue = entity.GetPropertyValue(propertyMetadata.Uid);
						if (propertyValue == null)
						{
							document.SetPropertyValue(propertyMetadata.Uid, null);
						}
						else
						{
							System.Reflection.PropertyInfo reflectionProperty = document.CastAsRealType().GetType().GetReflectionProperty(propertyMetadata.Name);
							bool flag = reflectionProperty != null && typeof(IEnumerable).IsAssignableFrom(reflectionProperty.PropertyType) && reflectionProperty.PropertyType.IsGenericType;
							ITypeEncrypter typeEncrypter = ComponentManager.Current.GetExtensionPoints<ITypeEncrypter>().FirstOrDefault((ITypeEncrypter e) => e.CheckType(null, propertyMetadata));
							if (typeEncrypter != null)
							{
								if (flag)
								{
									MethodInfo method = reflectionProperty.PropertyType.GetMethod("Add");
									object value = reflectionProperty.GetValue(document.CastAsRealType(), null);
									if (method != null)
									{
										foreach (object @object in ClassSerializationHelper.DeserializeObjectByXml<ListInfo>(propertyValue.ToString()).Objects)
										{
											if (@object != null)
											{
												object source = typeEncrypter.Decrypt(@object.ToString(), password, document.Salt, propertyMetadata);
												method.Invoke(value, new object[1] { source.CastAsRealType() });
											}
										}
									}
								}
								else
								{
									object value2 = typeEncrypter.Decrypt(propertyValue.ToString(), password, document.Salt, propertyMetadata);
									document.CastAsRealType().SetPropertyValue(propertyMetadata.Uid, value2);
								}
							}
						}
					}
				}
			}
			return document;
		});
	}

	[Transaction]
	public virtual void CancelEncrypt(T document, string password)
	{
		document = Decrypt(document, password, noVersion: true);
		((IEnumerable<IDocumentVersion>)document.Versions).ForEach(delegate(IDocumentVersion v)
		{
			if (v.Encrypt)
			{
				DocumentVersionManager.Instance.CancelEncrypt(v.CastAsRealType(), password);
			}
		});
		document.Encrypt = false;
		document.Salt = null;
		document.EncryptDate = null;
		document.EncryptUser = null;
		document.CryptoToken = null;
		document.Save();
		EntityActionEventArgs e = new EntityActionEventArgs(null, document, DocumentActions.DecryptGuid);
		base.EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	public virtual void UpdateEncryptedProperties(T document, string password)
	{
		List<Guid> list = document.GetDirtyPropertyUids().ToList();
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
		IEntity cryptoEntity = GetCryptoEntity(document);
		string text = (string)cryptoEntity.GetPropertyValue("CryptedAttr", null);
		IEnumerable<Guid> enumerable = ((!string.IsNullOrEmpty(text)) ? (from a in text.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
			select new Guid(a)).ToList() : new List<Guid>()).Where(list.Contains);
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		foreach (Guid cryptoAttribute in enumerable)
		{
			PropertyMetadata propertyMetadata = documentMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == cryptoAttribute);
			if (propertyMetadata == null)
			{
				continue;
			}
			object propertyValue = document.CastAsRealType().GetPropertyValue(cryptoAttribute);
			if (propertyValue != null)
			{
				Type valueType = propertyValue.CastAsRealType().GetType();
				System.Reflection.PropertyInfo reflectionProperty = document.CastAsRealType().GetType().GetReflectionProperty(propertyMetadata.Name);
				bool flag = typeof(IEnumerable).IsAssignableFrom(reflectionProperty.PropertyType) && reflectionProperty.PropertyType.IsGenericType;
				if (propertyMetadata.Name.Equals("Versions"))
				{
					continue;
				}
				if (flag)
				{
					ListInfo listInfo = new ListInfo();
					foreach (object item in (IEnumerable)propertyValue)
					{
						ITypeEncrypter typeEncrypter = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(item, propertyMetadata));
						if (typeEncrypter != null)
						{
							string item2 = typeEncrypter.Encrypt(item, password, document.Salt, propertyMetadata);
							listInfo.Objects.Add(item2);
						}
					}
					dictionary.Add(cryptoAttribute, ClassSerializationHelper.SerializeObjectByXml(listInfo));
					Type @interface = reflectionProperty.PropertyType.GetInterface(typeof(ICollection<>).GetGenericTypeDefinition().Name);
					if (@interface != null)
					{
						MethodInfo method = @interface.GetMethod("Clear");
						if (method != null)
						{
							method.Invoke(propertyValue, new object[0]);
						}
					}
				}
				else
				{
					ITypeEncrypter typeEncrypter2 = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(valueType, propertyMetadata));
					if (typeEncrypter2 != null)
					{
						string value = typeEncrypter2.Encrypt(propertyValue, password, document.Salt, propertyMetadata);
						dictionary.Add(cryptoAttribute, value);
						document.CastAsRealType().SetPropertyValue(cryptoAttribute, typeEncrypter2.EncryptStub(propertyValue, propertyMetadata));
					}
				}
			}
			else
			{
				dictionary.Add(cryptoAttribute, null);
			}
		}
		cryptoEntity.SetPropertyValue("ParentDocument", document);
		foreach (KeyValuePair<Guid, string> item3 in dictionary)
		{
			cryptoEntity.SetPropertyValue(item3.Key, item3.Value);
		}
		cryptoEntity.Save();
		document.Save();
	}

	[Transaction]
	public virtual void UpdateEncryptedProperty(T document, string property, object value, string password)
	{
		PropertyMetadata propertyMetadata = ((DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid)).Properties.FirstOrDefault((PropertyMetadata p) => p.Name == property);
		if (propertyMetadata != null)
		{
			UpdateEncryptedProperty(document, propertyMetadata.Uid, value, password);
		}
	}

	[Transaction]
	public virtual void UpdateEncryptedProperty(T document, Guid propertyUid, object value, string password)
	{
		if (!document.Encrypt)
		{
			document.CastAsRealType().SetPropertyValue(propertyUid, value);
			document.Save();
			return;
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
		if (documentMetadata.CryptoSettings.CryptoAttributes.All((Guid a) => a != propertyUid))
		{
			document.CastAsRealType().SetPropertyValue(propertyUid, value);
			document.Save();
			return;
		}
		PropertyMetadata propertyMetadata = documentMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata == null)
		{
			return;
		}
		IEntityManager entityManager = EntityHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(documentMetadata.CryptoSettings.CryptoEntityTypeUid));
		Filter filter = new Filter
		{
			Query = $"ParentDocument = {document.GetId()}"
		};
		IEntity entity = entityManager.Find(filter, new FetchOptions(0, 1)).Cast<IEntity>().FirstOrDefault();
		if (entity == null || value == null)
		{
			return;
		}
		Type valueType = value.CastAsRealType().GetType();
		System.Reflection.PropertyInfo reflectionProperty = document.CastAsRealType().GetType().GetReflectionProperty(propertyMetadata.Name);
		bool flag = typeof(IEnumerable).IsAssignableFrom(reflectionProperty.PropertyType) && reflectionProperty.PropertyType.IsGenericType;
		if (propertyMetadata.Name.Equals("Versions"))
		{
			return;
		}
		if (flag)
		{
			ListInfo listInfo = new ListInfo();
			foreach (object item in (IEnumerable)value)
			{
				ITypeEncrypter typeEncrypter = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(item, propertyMetadata));
				if (typeEncrypter == null)
				{
					return;
				}
				string item2 = typeEncrypter.Encrypt(item, password, document.Salt, propertyMetadata);
				listInfo.Objects.Add(item2);
			}
			entity.SetPropertyValue(propertyUid, ClassSerializationHelper.SerializeObjectByXml(listInfo));
			entity.Save();
			Type @interface = reflectionProperty.PropertyType.GetInterface(typeof(ICollection<>).GetGenericTypeDefinition().Name);
			if (@interface != null)
			{
				MethodInfo method = @interface.GetMethod("Clear");
				if (method != null)
				{
					method.Invoke(value, new object[0]);
				}
			}
		}
		else
		{
			ITypeEncrypter typeEncrypter2 = TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(valueType, propertyMetadata));
			if (typeEncrypter2 != null)
			{
				string value2 = typeEncrypter2.Encrypt(value, password, document.Salt, propertyMetadata);
				entity.SetPropertyValue(propertyUid, value2);
				entity.Save();
				document.CastAsRealType().SetPropertyValue(propertyUid, typeEncrypter2.EncryptStub(value, propertyMetadata));
			}
		}
	}

	public object GetEncryptedProperyValue(T document, Guid propertyUid, string password)
	{
		IEntity cryptoEntity = GetCryptoEntity(document);
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
		PropertyMetadata propertyMetadata = documentMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata == null)
		{
			return null;
		}
		string text = (string)cryptoEntity.GetPropertyValue(propertyUid);
		if (text == null)
		{
			return null;
		}
		return TypeEncrypters.FirstOrDefault((ITypeEncrypter e) => e.CheckType(null, propertyMetadata)).Decrypt(text, password, document.Salt, propertyMetadata);
	}

	public List<ConflictConvertReferencesObject> GetReferencesForConvertion(Guid targetTypeUid, IDocument[] sourceDocuments, DocTypeMappingInfo[] docTypeMappingInfos, Guid conflictFindingProcessUid = default(Guid))
	{
		IConvertConflictFindingService service = Locator.GetService<IConvertConflictFindingService>();
		ConflictFindingProgress conflictFindingProgress = null;
		if (conflictFindingProcessUid != Guid.Empty)
		{
			conflictFindingProgress = service.GetConflictFindingProcessStatus(conflictFindingProcessUid);
		}
		IEnumerable<IConvertDocumentReferencesExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IConvertDocumentReferencesExtension>();
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(targetTypeUid);
		List<EntityMetadata> list = MetadataLoader.GetBaseClasses(entityMetadata).OfType<EntityMetadata>().ToList();
		list.Insert(0, entityMetadata);
		List<ConflictConvertReferencesObject> list2 = new List<ConflictConvertReferencesObject>();
		foreach (DocTypeMappingInfo docTypeMappingInfo in docTypeMappingInfos)
		{
			EntityMetadata entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(docTypeMappingInfo.SourceTypeInfo.Uid);
			List<EntityMetadata> list3 = MetadataLoader.GetBaseClasses(entityMetadata2).OfType<EntityMetadata>().ToList();
			list3.Insert(0, entityMetadata2);
			List<EntityMetadata> second = list3.Intersect(list).ToList();
			List<EntityMetadata> sourceEntities = list3.Except(second).ToList();
			List<ConflictConvertReferencesObject> list4 = new List<ConflictConvertReferencesObject>();
			List<EntityMetadata> currSourceTypePossibleRefEntities = new List<EntityMetadata>();
			conflictFindingProgress.CurrentWorkDescription = entityMetadata2.DisplayName;
			extensionPoints.ForEach(delegate(IConvertDocumentReferencesExtension c)
			{
				currSourceTypePossibleRefEntities.AddRange(c.GetAllEntitiesWithPossibleReferences());
			});
			currSourceTypePossibleRefEntities = currSourceTypePossibleRefEntities.Where((EntityMetadata m) => m.Type != EntityMetadataType.InterfaceExtension).ToList();
			list4 = GetPossibleReferenceEntitiesForSourceType(sourceEntities, currSourceTypePossibleRefEntities);
			DocTypeMappingInfo mapping = docTypeMappingInfo;
			foreach (IDocument item in sourceDocuments.Where((IDocument m) => m.TypeUid == mapping.SourceTypeInfo.Uid))
			{
				conflictFindingProgress.CurrentWorkDescription = item.Name;
				list2.AddRange(GetReferencesToDocumentsFromPossible(list4, entityMetadata.TypeUid, item));
				conflictFindingProgress.TotalPercentComplete += 100 / sourceDocuments.Length;
			}
		}
		return list2;
	}

	private List<ConflictConvertReferencesObject> GetReferencesToDocumentsFromPossible(List<ConflictConvertReferencesObject> possibleReferences, Guid targetTypeUid, IDocument doc)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		ISecurityService serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
		List<ConflictConvertReferencesObject> list = new List<ConflictConvertReferencesObject>();
		foreach (ConflictConvertReferencesObject possibleReference in possibleReferences)
		{
			IEntity refObject = null;
			Type typeByUid = base.MetadataRuntimeService.GetTypeByUid(possibleReference.EntityMetadata.Uid);
			IEntityManager manager = EntityHelper.GetEntityManager(typeByUid);
			EntitySettings entitySettings = possibleReference.PropertyMetadata.Settings as EntitySettings;
			ConflictConvertReferencesObject conflictConvertReferencesObject = new ConflictConvertReferencesObject
			{
				EntityMetadata = possibleReference.EntityMetadata,
				PropertyMetadata = possibleReference.PropertyMetadata,
				RefObjects = new List<IEntity>(),
				RefToDocument = doc,
				RootEntityMetadata = possibleReference.RootEntityMetadata
			};
			if (entitySettings == null || entitySettings.RelationType != RelationType.OneToMany)
			{
				if (entitySettings != null && entitySettings.RelationType == RelationType.ManyToMany)
				{
					string relationTableName = entitySettings.RelationTableName;
					string parentColumnName = entitySettings.ParentColumnName;
					string childColumnName = entitySettings.ChildColumnName;
					string sql = $"SELECT {serviceNotNull.Dialect.QuoteIfNeeded(parentColumnName)} FROM {serviceNotNull.Dialect.QuoteIfNeeded(relationTableName)} Where {serviceNotNull.Dialect.QuoteIfNeeded(childColumnName)} = {doc.Id}";
					List<long> list2 = new List<long>();
					using (IDataReader dataReader = serviceNotNull.ExecuteQuery(sql))
					{
						while (dataReader.Read())
						{
							long @int = dataReader.GetInt64(dataReader.GetOrdinal(parentColumnName));
							list2.Add(@int);
						}
					}
					foreach (long item in list2)
					{
						long id2 = item;
						serviceNotNull2.RunWithElevatedPrivilegies(delegate
						{
							refObject = (IEntity)manager.LoadOrNull(id2);
						});
						if (refObject != null)
						{
							conflictConvertReferencesObject.RefObjects.Add(refObject);
						}
					}
				}
				else if (entitySettings == null || entitySettings.RelationType == RelationType.OneToOne)
				{
					string tableName = EntityPropertyMetadata.GetTableName(possibleReference.EntityMetadata.TableName, ((EntityPropertyMetadata)possibleReference.PropertyMetadata).TableNumber);
					string fieldName = ((SimpleTypeSettings)possibleReference.PropertyMetadata.Settings).FieldName;
					string sql2 = string.Format("SELECT {0} FROM {1} Where {2} = {3}", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded(tableName), serviceNotNull.Dialect.QuoteIfNeeded(fieldName), doc.Id);
					List<long> list3 = new List<long>();
					using (IDataReader dataReader2 = serviceNotNull.ExecuteQuery(sql2))
					{
						while (dataReader2.Read())
						{
							long int2 = dataReader2.GetInt64(dataReader2.GetOrdinal("Id"));
							list3.Add(int2);
						}
					}
					foreach (long item2 in list3)
					{
						long id1 = item2;
						serviceNotNull2.RunWithElevatedPrivilegies(delegate
						{
							refObject = (IEntity)manager.LoadOrNull(id1);
						});
						if (refObject == null)
						{
							continue;
						}
						refObject.ToString();
						IDocumentsAdditionalChecks documentsAdditionalChecks = ComponentManager.Current.GetExtensionPoints<IDocumentsAdditionalChecks>().FirstOrDefault((IDocumentsAdditionalChecks m) => m.IsItNecessaryType(refObject));
						if (documentsAdditionalChecks != null)
						{
							IEntity entity = (IEntity)documentsAdditionalChecks.GetFromEntity(refObject);
							if (entity != null)
							{
								conflictConvertReferencesObject.RefObjects.Add(entity);
							}
						}
					}
				}
			}
			if (conflictConvertReferencesObject.RefObjects.Count > 0)
			{
				list.Add(conflictConvertReferencesObject);
			}
		}
		return list;
	}

	private List<ConflictConvertReferencesObject> GetPossibleReferenceEntitiesForSourceType(List<EntityMetadata> sourceEntities, List<EntityMetadata> otherEntities)
	{
		List<ConflictConvertReferencesObject> list = new List<ConflictConvertReferencesObject>();
		List<Guid> list2 = sourceEntities.Select((EntityMetadata m) => m.ImplementationUid).ToList();
		foreach (EntityMetadata otherEntity in otherEntities)
		{
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(otherEntity.Uid, inherit: false);
			foreach (PropertyMetadata property in entityMetadata.Properties)
			{
				if (list2.Contains(property.SubTypeUid) && ((EntitySettings)property.Settings).CascadeMode != CascadeMode.AllDeleteOrphan && (property.Name != "Parent" || !(entityMetadata is TablePartMetadata)))
				{
					list.Add(new ConflictConvertReferencesObject
					{
						RootEntityMetadata = GetParentEntityOrCurrent(entityMetadata, otherEntities),
						EntityMetadata = entityMetadata,
						PropertyMetadata = property
					});
				}
			}
		}
		return list;
	}

	private EntityMetadata GetParentEntityOrCurrent(EntityMetadata entity, List<EntityMetadata> otherEntities)
	{
		if (entity is TablePartMetadata)
		{
			EntityMetadata entity2 = null;
			foreach (EntityMetadata otherEntity in otherEntities)
			{
				if ((from m in otherEntity.TableParts.Concat((IEnumerable<TablePartMetadata>)otherEntity.EntityTableParts)
					select m.TablePartPropertyUid).Contains(((TablePartMetadata)entity).TablePartPropertyUid))
				{
					entity2 = otherEntity;
					break;
				}
			}
			return GetParentEntityOrCurrent(entity2, otherEntities);
		}
		return entity;
	}

	public List<EntityMetadata> GetChildBlocks(EntityMetadata rootEntity)
	{
		List<EntityMetadata> list = new List<EntityMetadata>();
		foreach (TablePartMetadata item in rootEntity.TableParts.Concat((IEnumerable<TablePartMetadata>)rootEntity.EntityTableParts))
		{
			list.Add(item);
			list.AddRange(GetChildBlocks(item));
		}
		return list;
	}

	[Auditable]
	[Transaction]
	public virtual void ConvertType(T document, Guid targetTypeUid, DocTypeMappingInfo mappingInfo, Guid convertionUid = default(Guid))
	{
		ConvertType(document, targetTypeUid, mappingInfo, convertionUid, null);
	}

	[Auditable]
	[Transaction]
	public virtual void ConvertType(T document, Guid targetTypeUid, DocTypeMappingInfo mappingInfo, Guid convertionUid, IDictionary<string, object> extData)
	{
		long docId = Convert.ToInt64(document.GetId());
		IDocument doc = null;
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			doc = DocumentManager.Instance.Load(docId);
		});
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(doc.TypeUid);
		EntityMetadata entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(targetTypeUid);
		if (mappingInfo == null)
		{
			mappingInfo = DocTypeMappingInfo.GetDefaultMapping(entityMetadata, entityMetadata2);
		}
		List<EleWise.ELMA.Security.Models.IUser> watches = WatchEntityActionHandler.GetWatches(Locator.GetServiceNotNull<IMemoryCacheService>(), new EntityActionEventArgs(null, doc, DocumentActions.ConvertedFromOtherTypeGuid));
		ConvertProcessService.SetConvertionStatus(convertionUid, doc.Name, SR.T("Генерация нового имени.."), 1);
		if (!mappingInfo.IsNoNeedToGenerateNameByTemplate)
		{
			TextTemplateGenerator textTemplateGenerator = new TextTemplateGenerator(mappingInfo.NameTemplate);
			DocumentGenerateNameModel documentGenerateNameModel = new DocumentGenerateNameModel(doc);
			if (doc.CurrentVersion != null && doc.CurrentVersion.File != null)
			{
				documentGenerateNameModel.FileName = doc.CurrentVersion.File.Name;
			}
			string text = textTemplateGenerator.Generate(documentGenerateNameModel);
			doc.Name = text;
			Transform.Update("DmsObject", new string[1] { "Name" }, new object[1] { text }, string.Format("{0} = {1}", Transform.Dialect.QuoteIfNeeded("Id"), docId));
		}
		doc.Refresh();
		Dictionary<string, int> progreses = new Dictionary<string, int>
		{
			{
				ConvertTypeStatus.UpdateData.ToString(),
				5
			},
			{
				ConvertTypeStatus.UpdateRefs.ToString(),
				50
			},
			{
				ConvertTypeStatus.DeleteData.ToString(),
				60
			},
			{
				ConvertTypeStatus.UpdateHistory.ToString(),
				70
			},
			{
				ConvertTypeStatus.UpdateWatches.ToString(),
				80
			}
		};
		Locator.GetServiceNotNull<IConvertTypeService>().Convert(doc, mappingInfo, delegate(ConvertTypeProgressInfo info)
		{
			if (progreses.ContainsKey(info.Status))
			{
				ConvertProcessService.SetConvertionStatus(convertionUid, doc.Name, info.Description, progreses[info.Status]);
			}
		});
		ConvertProcessService.SetConvertionStatus(convertionUid, doc.Name, SR.T("Обновление последних активностей по документу данных.."), 90);
		Guid guid = InterfaceActivator.UID<IDocument>();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("parameter01", guid);
		Transform.Update("LastObjectInfo", new string[1] { "RealObjectType" }, new object[1] { targetTypeUid }, string.Format("{0} = {1} and {2} = {3}", Transform.Dialect.QuoteIfNeeded("ObjectOI"), docId, Transform.Dialect.QuoteIfNeeded("ObjectTU"), Transform.ParameterSeparator + "parameter01"), dictionary);
		Transform.Update("Question", new string[1] { "RefObjectTU" }, new object[1] { targetTypeUid }, string.Format("RefObjectTU = {0} and RefObjectOI = {1}", Transform.ParameterSeparator + "parameter01", docId), dictionary);
		Transform.Update("DmsObject", new string[1] { "TypeUid" }, new object[1] { targetTypeUid }, string.Format("{0} = {1}", Transform.Dialect.QuoteIfNeeded("Id"), docId));
		RefreshTypeUidCache(docId);
		DocumentListener.DoReferencesUpdate(doc);
		IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
		if (!mappingInfo.IsNoNeedToGenerateNameByTemplate && serviceNotNull.IndexingIsWorking())
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Name)), doc.Name));
			IndexQueueManager.Instance.AddReindexObjectPartItem(typeof(IDocumentsFullTextSearchObject), doc.Id, targetTypeUid, list, visualData: true);
		}
		ComponentManager.Current.GetExtensionPoints<IConvertDocumentAfterProcessing>().ForEach(delegate(IConvertDocumentAfterProcessing m)
		{
			m.DoAfterProcessing(doc, targetTypeUid);
		});
		ConvertTypeExecute(document, entityMetadata, entityMetadata2, watches);
	}

	[Transaction]
	protected virtual void ConvertTypeExecute(T doc, EntityMetadata sourceMd, EntityMetadata targetMd, List<EleWise.ELMA.Security.Models.IUser> watchers)
	{
		DocumentConvertedActionEventArgs documentConvertedActionEventArgs = new DocumentConvertedActionEventArgs(doc, targetMd.Uid, DocumentActions.ConvertedFromOtherTypeGuid)
		{
			PrevType = sourceMd.Uid,
			PrevTypeName = sourceMd.DisplayName,
			NewType = targetMd.Uid,
			NewTypeName = targetMd.DisplayName
		};
		documentConvertedActionEventArgs.ExtendedProperties["WatchList"] = watchers;
		base.EntityActionHandler.ActionExecuted(documentConvertedActionEventArgs);
	}

	[PublicApiMember]
	[PublicApiObsoleteInNode("PublicAPI.Docflow.Document", "SR.M('Этот метод устарел')", true)]
	public virtual T Create(BinaryFile file, IFolder folder, string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Contract.ArgumentNotNull(file, "file");
		T val = (T)InterfaceActivator.Create(typeof(T));
		val.Folder = folder;
		InstanceOf<IDocumentVersion> instanceOf = new InstanceOf<IDocumentVersion>();
		instanceOf.New.File = file;
		instanceOf.New.Status = DocumentVersionStatus.Current;
		IDocumentVersion version = (val.CurrentVersion = instanceOf.New);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentTypeFromImplementation(val.TypeUid);
		if (documentMetadataProfile != null && documentMetadataProfile.DefaultPermissionType == DocumentDefaultPermissionType.Custom)
		{
			val.InheritPermissions = false;
		}
		DocumentManager.Instance.InitNew(val, version, makeVersionCurrent: true);
		IEntityManager entityManager = ModelHelper.GetEntityManager(val.GetType());
		entityManager.Save(val);
		val.Name = (string.IsNullOrEmpty(name) ? DocumentManager.Instance.GenerateName(val, (file != null) ? file.Name : "", forceGenerate: true) : name);
		entityManager.Save(val);
		return val;
	}

	[PublicApiMember]
	[PublicApiObsoleteInNode("PublicAPI.Docflow.Document", "SR.M('Этот метод устарел')", true)]
	public virtual T Create(IFolder folder, string name)
	{
		if (name == null)
		{
			throw new NullReferenceException(SR.T("Параметр name не может быть null"));
		}
		if (folder == null)
		{
			throw new NullReferenceException(SR.T("Параметр folder не может быть null"));
		}
		T val = (T)InterfaceActivator.Create(typeof(T));
		val.Folder = folder;
		val.Name = (string.IsNullOrEmpty(name) ? DocumentManager.Instance.GenerateName(val, "", forceGenerate: true) : name);
		return val;
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentManager : DocumentManager<IDocument, long>
{
	public new static DocumentManager Instance => Locator.GetServiceNotNull<DocumentManager>();

	public DocumentVersionManager DocumentVersionManager { get; set; }

	public new IndexQueueManager IndexQueueManager { get; set; }

	public IList<ReferenceOnEntityType> DocumentTypeToRegister(Guid rkkUid)
	{
		return null;
	}

	public override ActionCheckResult CanSave(IDocument obj)
	{
		if (obj == null)
		{
			return ActionCheckResult.False(SR.T("Невозможно сохранить пустую ссылку"));
		}
		Type typeWithoutProxy = obj.GetType().GetTypeWithoutProxy();
		if (typeWithoutProxy == typeof(IDocument) || typeWithoutProxy == InterfaceActivator.TypeOf<IDocument>())
		{
			return ActionCheckResult.False(SR.T("Невозможно сохранить документ типа {0} т.к. он не является бизнес типом", typeWithoutProxy.FullName));
		}
		if (obj.Folder == null)
		{
			return ActionCheckResult.False(SR.T("Невозможно сохранить документ без папки", obj.Name));
		}
		if ((obj.IsNew() || ChangeFolder(obj)) && base.SecurityServiceExists && !base.SecurityService.HasPermission(PermissionProvider.DocumentCreatePermission, obj.Folder))
		{
			return ActionCheckResult.False(SR.T("Невозможно сохранить документ \"{0}\" в папке \"{1}\", так как у папки нет привилегии \"Создание документов\"", obj.Name, obj.Folder));
		}
		return ModelHelper.GetEntityManager(typeWithoutProxy).CanSave(obj);
	}

	public override ActionCheckResult CanDelete(IDocument obj)
	{
		if (obj == null)
		{
			return ActionCheckResult.False(SR.T("Невозможно удалить пустую ссылку"));
		}
		Type typeWithoutProxy = obj.GetType().GetTypeWithoutProxy();
		if (typeWithoutProxy == typeof(IDocument) || typeWithoutProxy == InterfaceActivator.TypeOf<IDocument>())
		{
			return ActionCheckResult.False(SR.T("Невозможно удалить документ типа {0} т.к. он не является бизнес типом", typeWithoutProxy.FullName));
		}
		return ModelHelper.GetEntityManager(typeWithoutProxy).CanSave(obj);
	}

	public IDocument CopyVersion([NotNull] IDocument from, [NotNull] IDocument to)
	{
		Contract.ArgumentNotNull(from, "from");
		Contract.ArgumentNotNull(to, "to");
		IDocumentVersion currentVersion = from.CurrentVersion;
		IDocumentVersion documentVersion = ((currentVersion == null) ? new InstanceOf<IDocumentVersion>().New : CloneHelperBuilder.Create(currentVersion).Clone());
		documentVersion.Document = to;
		to.Versions.Add(documentVersion);
		return to;
	}

	public IDocument Copy(IDocument document, bool inheritPermissionsParentFolder = true)
	{
		if (document == null)
		{
			return null;
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, document.Folder))
		{
			document.Folder = base.SystemFoldersService.GetMyDocumentFolderForCurrentUser();
		}
		else if (document.Folder.Uid == DocumentConstants.ArchiveFolderUid)
		{
			if (document.OldFolder != null && !base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, document.OldFolder))
			{
				document.Folder = document.OldFolder;
			}
			else
			{
				document.Folder = base.SystemFoldersService.GetMyDocumentFolderForCurrentUser();
			}
		}
		IDocument to = CloneHelperBuilder.Create(document).Restrictions(delegate(RestrictionsBuilder<IDocument> m)
		{
			m.Rule().ForPropertyName((IDocument d) => d.Versions).Ignore();
			if (!inheritPermissionsParentFolder)
			{
				m.Rule().ForPropertyName((IDocument d) => d.Permissions).Ignore();
			}
			m.Rule().ForPropertyName((IDocument d) => d.Encrypt).Ignore();
			m.Rule().ForPropertyName((IDocument d) => d.EncryptDate).Ignore();
			m.Rule().ForPropertyName((IDocument d) => d.EncryptUser).Ignore();
			m.Rule().ForPropertyName((IDocument d) => d.CryptoToken).Ignore();
			m.Rule().ForPropertyName((IDocument d) => d.Salt);
			m.Rule().ForPropertyName((IDocument q) => q.CreationAuthor).Ignore();
			m.Rule().ForPropertyName((IDocument q) => q.CreationDate).Ignore();
		}).Clone();
		return CopyVersion(document, to);
	}

	public void InitNew(IDocument document, IDocumentVersion version, bool makeVersionCurrent)
	{
		Contract.ArgumentNotNull(document, "document");
		Contract.ArgumentNotNull(version, "version");
		document.Versions.Add(version);
		if (version != null)
		{
			version.Document = document;
			version.Status = (makeVersionCurrent ? DocumentVersionStatus.Current : DocumentVersionStatus.Draft);
		}
	}

	public string GenerateName(IDocument document, string fileName, bool forceGenerate = false)
	{
		Contract.ArgumentNotNull(document, "document");
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.GetType());
		if (documentMetadata != null && documentMetadata.TemplateName != null)
		{
			string text = SR.T(documentMetadata.TemplateName);
			string text2 = ((!documentMetadata.IsAllowRename || forceGenerate) ? text : document.Name);
			if (string.IsNullOrEmpty(text2))
			{
				text2 = text;
			}
			return GenerateNameOnSpecifiedTemplate(document, fileName, text2);
		}
		return "";
	}

	public string GenerateNameOnSpecifiedTemplate(IDocument document, string fileName, string template)
	{
		Contract.ArgumentNotNull(document, "document");
		if (!string.IsNullOrWhiteSpace(template))
		{
			try
			{
				TextTemplateGenerator textTemplateGenerator = new TextTemplateGenerator(template);
				DocumentGenerateNameModel dataSourceObject = new DocumentGenerateNameModel(document)
				{
					FileName = fileName
				};
				return textTemplateGenerator.Generate(dataSourceObject);
			}
			catch (RecognitionException exception)
			{
				base.Logger.Error(SR.T("Некорректное название документа"), exception);
				throw new TextTemplateGeneratorParseException(SR.T("Некорректное название документа"));
			}
			catch (Exception)
			{
				throw;
			}
		}
		return string.Empty;
	}

	[Transaction]
	public virtual void SetStatus(IDocument document, ILifeCycleStatus status, string comment = null)
	{
		Contract.ArgumentNotNull(document, "document");
		Contract.ArgumentNotNull(status, "status");
		SetStatus(document, status, null, comment);
	}

	[Transaction]
	public virtual void SetStatus(IDocument document, ILifeCycleStatus status, string password, string comment = null)
	{
		Contract.ArgumentNotNull(document, "document");
		Contract.ArgumentNotNull(status, "status");
		bool hasChanging = false;
		Action action = delegate
		{
			hasChanging = document.Status == null || document.Status != status;
			if (hasChanging)
			{
				document.Status = status;
				document.Save();
			}
		};
		if (document.Encrypt)
		{
			PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata((IDocument d) => d.Status);
			string text = (string)GetCryptoEntity(document).GetPropertyValue("CryptedAttr", null);
			if (((!string.IsNullOrEmpty(text)) ? (from a in text.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
				select new Guid(a)).ToList() : new List<Guid>()).Contains(propertyMetadata.Uid))
			{
				if (string.IsNullOrEmpty(password))
				{
					throw new Exception(SR.T("Не задан пароль для изменения зашифрованной сущности"));
				}
				object encryptedProperyValue = GetEncryptedProperyValue(document, propertyMetadata.Uid, password);
				hasChanging = encryptedProperyValue == null || !encryptedProperyValue.Equals(status);
				if (hasChanging)
				{
					UpdateEncryptedProperty(document, "Status", status, password);
					document.Save();
				}
			}
			else
			{
				action();
			}
		}
		else
		{
			action();
		}
		if (!hasChanging)
		{
			return;
		}
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, document, "e49ec0ba-0dfd-4715-8b2f-2bb7ecfa00f3");
		if (entityActionEventArgs != null)
		{
			if (!string.IsNullOrEmpty(comment))
			{
				InstanceOf<IComment> instanceOf = new InstanceOf<IComment>();
				instanceOf.New.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				instanceOf.New.CreationDate = DateTime.Now;
				instanceOf.New.Text = comment;
				IComment @new = instanceOf.New;
				document.Comments.Add(@new);
				document.Save();
				ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
				commentActionModel.Comment = @new;
				ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
				serviceNotNull.Process(document, commentActionModel);
				serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			}
			base.EntityActionHandler.ActionExecuted(entityActionEventArgs);
		}
	}

	public bool HasIndexingDocumentCards()
	{
		return IndexQueueManager.ContainIndexingVisualData(DocumentsFullTextSearchExtension.DocumentCardUid);
	}

	[PublicApiMember]
	public virtual void AddComment([RequiredParameter] IDocument document, [RequiredParameter] IComment comment)
	{
		AddComment(document, comment, null, null);
	}

	[Transaction]
	[PublicApiMember]
	[ActionMethod("cc7bcb58-4cc5-4931-94f2-de572153e051")]
	public virtual void AddComment([RequiredParameter] IDocument document, [RequiredParameter] IComment comment, IEnumerable<IAttachment> attachments, IEnumerable<IDocumentAttachment> documentAttachments)
	{
		Contract.ArgumentNotNull(document, "document");
		Contract.ArgumentNotNull(comment, "comment");
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, comment, DefaultEntityActions.CreateGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
		document.Comments.Add(comment);
		ICommentWithDocumentsActionModel commentWithDocumentsActionModel = InterfaceActivator.Create<ICommentWithDocumentsActionModel>();
		commentWithDocumentsActionModel.Comment = comment;
		if (attachments != null)
		{
			commentWithDocumentsActionModel.Attachments = new List<IAttachment>();
			foreach (IAttachment attachment2 in attachments)
			{
				IAttachment attachment = InterfaceActivator.Create<IAttachment>();
				attachment.CreationAuthor = attachment2.CreationAuthor;
				attachment.File = attachment2.File;
				attachment.Save();
				commentWithDocumentsActionModel.Attachments.Add(attachment);
				EntityActionEventArgs entityActionEventArgs2 = EntityActionEventArgs.TryCreate(null, attachment2, DefaultEntityActions.CreateGuid);
				if (entityActionEventArgs2 != null)
				{
					serviceNotNull.ActionExecuted(entityActionEventArgs2);
				}
			}
		}
		if (documentAttachments != null)
		{
			foreach (IDocumentAttachment documentAttachment in documentAttachments)
			{
				EntityActionEventArgs entityActionEventArgs3 = EntityActionEventArgs.TryCreate(null, documentAttachment, DefaultEntityActions.CreateGuid);
				if (entityActionEventArgs3 != null)
				{
					serviceNotNull.ActionExecuted(entityActionEventArgs3);
				}
			}
			commentWithDocumentsActionModel.DocumentAttachments = documentAttachments.ToList();
		}
		ICommentActionHandler serviceNotNull2 = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull2.Process(document, commentWithDocumentsActionModel);
		document.Save();
		EntityActionEventArgs entityActionEventArgs4 = EntityActionEventArgs.TryCreate(null, document, "cc7bcb58-4cc5-4931-94f2-de572153e051");
		if (entityActionEventArgs4 != null)
		{
			entityActionEventArgs4.ActionAuthor = comment.CreationAuthor;
			serviceNotNull2.ProcessEventArgs(entityActionEventArgs4, commentWithDocumentsActionModel);
			serviceNotNull.ActionExecuted(entityActionEventArgs4);
		}
	}

	[Transaction]
	public virtual void CreateDocument<T>(BinaryFile file, IFolder folder)
	{
		CreateDocument(typeof(T), file, folder);
	}

	[Transaction]
	public virtual void CreateDocument(Type t, BinaryFile file, IFolder folder)
	{
		CreateDocument(t, file, folder, null);
	}

	[Transaction]
	public virtual void CreateDocument(Type t, BinaryFile file, IFolder folder, string customTemplateName)
	{
		CreateDocument(t, file, folder, customTemplateName, out var _);
	}

	[Transaction]
	public virtual void CreateDocument(Type t, BinaryFile file, IFolder folder, string customTemplateName, out IDocument document)
	{
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(t);
		bool flag = WebDocumentManager.Instance.IsWebDocument(entityMetadata.Uid);
		document = (IDocument)InterfaceActivator.Create(t);
		document.Folder = folder;
		InstanceOf<IDocumentVersion> instanceOf = new InstanceOf<IDocumentVersion>();
		instanceOf.New.File = (flag ? null : file);
		instanceOf.New.Status = DocumentVersionStatus.Current;
		IDocumentVersion @new = instanceOf.New;
		if (flag)
		{
			try
			{
				WebDocumentManager.Instance.CreateFromFile(file, @new);
			}
			catch (Exception ex)
			{
				base.Logger.Log(LogLevel.Error, ex, ex.Message);
			}
		}
		if (file != null)
		{
			InitNew(document, @new, makeVersionCurrent: true);
		}
		IEntityManager entityManager = ModelHelper.GetEntityManager(document.GetType());
		entityManager.Save(document);
		string fileName = ((file != null) ? file.Name : "");
		if (string.IsNullOrEmpty(customTemplateName))
		{
			document.Name = GenerateName(document, fileName, forceGenerate: true);
		}
		else
		{
			document.Name = GenerateNameOnSpecifiedTemplate(document, fileName, customTemplateName);
		}
		bool turned = base.RunWithElevatedPrivilegiesService.Turned;
		base.RunWithElevatedPrivilegiesService.Turned = true;
		try
		{
			entityManager.Save(document);
		}
		finally
		{
			base.RunWithElevatedPrivilegiesService.Turned = turned;
		}
	}

	public IDocumentFilter GetSecondaryFilter(IDocumentFilter baseFilter, IDocumentFilter secondaryFilter)
	{
		List<PropertyMetadata> properties = ((ClassMetadata)MetadataLoader.LoadMetadata(baseFilter.GetType())).Properties;
		_ = (ClassMetadata)MetadataLoader.LoadMetadata(secondaryFilter.GetType());
		foreach (PropertyMetadata item in properties)
		{
			object propertyValue = baseFilter.GetPropertyValue(item.Name, null);
			if (propertyValue != null)
			{
				System.Reflection.PropertyInfo reflectionProperty = secondaryFilter.GetType().GetReflectionProperty(item.Name);
				if (reflectionProperty != null)
				{
					reflectionProperty.SetValue(secondaryFilter, propertyValue, null);
				}
			}
		}
		return secondaryFilter;
	}

	public IDocumentVersion GetCurrentVersionOrNull(IDocument document)
	{
		IDocumentVersion currentVersion = document.CurrentVersion;
		if (currentVersion != null && currentVersion.Document == null)
		{
			return null;
		}
		return currentVersion;
	}

	[Auditable]
	public virtual ICriteria TasksCriteria(IDocument document, List<TaskBaseStatus> statuses, ICriteria crit)
	{
		return TasksCriteria(document.Id, statuses, crit);
	}

	[Auditable]
	public virtual ICriteria TasksCriteria(long documentId, List<TaskBaseStatus> statuses, ICriteria crit)
	{
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IAttachmentsTaskBase>()).CreateAlias("DocumentAttachments", "dat", (JoinType)0).Add((ICriterion)(object)Restrictions.Eq("dat.Document.Id", (object)documentId))
			.SetProjection(Projections.Distinct((IProjection)(object)Projections.Property("Id")));
		if (crit == null)
		{
			crit = base.Session.CreateCriteria(InterfaceActivator.TypeOf<ITaskBase>());
		}
		crit.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val));
		if (statuses != null)
		{
			crit.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)statuses));
		}
		return crit;
	}

	[Auditable]
	public virtual ICriteria DocumentTasksCriteria(List<IDocument> document, List<TaskBaseStatus> statuses, ICriteria crit)
	{
		if (crit == null)
		{
			crit = base.Session.CreateCriteria(InterfaceActivator.TypeOf<ITaskBase>());
		}
		crit.Add((ICriterion)(object)Restrictions.Eq("Id", (object)(-1)));
		return crit;
	}

	[Auditable]
	public virtual long GetTasksByDocumentCount(IDocument document, List<TaskBaseStatus> statuses)
	{
		return Convert.ToInt64(TasksCriteria(document, statuses, null).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Count("Id")) }).UniqueResult());
	}

	[Auditable]
	public virtual long GetDocumentsTasksByDocumentCount(List<IDocument> document, List<TaskBaseStatus> statuses)
	{
		return Convert.ToInt64(DocumentTasksCriteria(document, statuses, null).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Count("Id")) }).UniqueResult());
	}

	[Auditable]
	public virtual IList<ITaskBase> GetTasksByDocument(IDocument document, List<TaskBaseStatus> statuses, FetchOptions options = null)
	{
		ICriteria val = TasksCriteria(document, statuses, null);
		if (options != null)
		{
			SetupFetchOptions(val, options, InterfaceActivator.TypeOf<ITaskBase>());
		}
		return val.List<ITaskBase>();
	}

	[Auditable]
	public virtual IList<ITaskBase> GetDocumentTasksByDocument(List<IDocument> document, List<TaskBaseStatus> statuses, FetchOptions options = null)
	{
		ICriteria val = DocumentTasksCriteria(document, statuses, null);
		if (options != null)
		{
			SetupFetchOptions(val, options, InterfaceActivator.TypeOf<ITaskBase>());
		}
		return val.List<ITaskBase>();
	}

	[Transaction]
	public virtual void CloseAllTasks(List<IDocument> document, string comment)
	{
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			foreach (IDocument item in document)
			{
				IList<ITaskBase> tasksByDocument = GetTasksByDocument(item, TaskBaseExtensions.ActiveTaskStatuses.ToList());
				ArchiveDocumentTasksSweepService.Instance.EnqueueDocumentWithTasks(item.Id, tasksByDocument, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>(), comment);
			}
		});
	}

	public List<long> GetArchivingDocumentIds()
	{
		return ArchiveDocumentTasksSweepService.Instance.GetQueuedDocumentIds();
	}

	[Auditable]
	[Transaction]
	public virtual void TerminateTask(ITaskBase taskBase, ICommentActionModel actionModel)
	{
		if (taskBase.IsActive())
		{
			TaskBaseManager.Instance.Terminate(taskBase, alert: true, actionModel);
		}
	}

	[Transaction]
	public virtual void Send(IDocument document, EleWise.ELMA.Security.Models.IUser user = null)
	{
		Send(new List<IDocument> { document }, user);
	}

	[Transaction]
	public virtual void Send(List<IDocument> documents, EleWise.ELMA.Security.Models.IUser user = null)
	{
		DateTime sendDate = DateTime.Now;
		documents.Select((IDocument d) => d.CastAsRealType()).OfType<ISendableDocument>().ForEach(delegate(ISendableDocument d)
		{
			d.SendStatus = SendStatus.Sended;
			if (!d.SendDate.HasValue)
			{
				d.SendDate = sendDate;
			}
			d.SendUser = user ?? base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			Save((IDocument)d);
			EntityActionEventArgs e = new EntityActionEventArgs(null, (IDocument)d, "9749db56-60fd-4eac-be3b-a2a726816bac");
			base.EntityActionHandler.ActionExecuted(e);
		});
	}

	internal IEnumerable<IDocument> FindAllAttachedToObject(Guid actionObject, long id)
	{
		ICriteria val = CreateCriteria();
		Type typeByUid = base.MetadataRuntimeService.GetTypeByUid(actionObject);
		ClassMetadata classMetadata = base.MetadataRuntimeService.GetMetadata(actionObject) as ClassMetadata;
		string text = "";
		if (classMetadata == null)
		{
			return Enumerable.Empty<IDocument>();
		}
		foreach (PropertyMetadata property in classMetadata.Properties)
		{
			if (property.Handlers.Any((PropertyHandlerInfo info) => info.HandlerUid == DocumentAttachmentsPropertyHandler.UID))
			{
				text = property.Name;
				break;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return Enumerable.Empty<IDocument>();
		}
		DetachedCriteria val2 = DetachedCriteria.For(typeByUid);
		val2.Add((ICriterion)(object)Restrictions.IdEq((object)id)).CreateAlias(text, "tda", (JoinType)0).CreateAlias("tda.Document", "tdad", (JoinType)0)
			.SetProjection((IProjection)(object)Projections.Property("tdad.Id"));
		val.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
		return val.List<IDocument>();
	}

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	public IEnumerable<IDocument> GetDocumentsFromObject(IEntity entity)
	{
		return (from r in ComponentManager.Current.GetExtensionPoints<IObjectDocumentResolver>()
			where r.CheckType(entity)
			select r).SelectMany((IObjectDocumentResolver r) => r.Resolve(entity)).Distinct().ToList();
	}

	public virtual Pair<Guid, long> GetDocumentTypeUidWithId(long documentId)
	{
		Type type = InterfaceActivator.TypeOf<IDocument>();
		ProjectionList val = Projections.ProjectionList().Add((IProjection)(object)Projections.Property(NHibernateHelper.GetCriteriaTypeUidPropertyName(type)), "First");
		return new Pair<Guid, long>(base.Session.CreateCriteria(type).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)val }).Add((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument prop) => prop.Id)), (object)documentId))
			.UniqueResult<Guid>(), documentId);
	}

	public virtual Pair<Guid, long> GetDocumentTypeUidWithId(Guid documentUid)
	{
		Type type = InterfaceActivator.TypeOf<IDocument>();
		ProjectionList val = Projections.ProjectionList().Add((IProjection)(object)Projections.Property(NHibernateHelper.GetCriteriaTypeUidPropertyName(type)), "First").Add((IProjection)(object)Projections.Property(LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument prop) => prop.Id))), "Second");
		return base.Session.CreateCriteria(type).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)val }).Add((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument prop) => prop.Uid)), (object)documentUid))
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(Pair<Guid, long>)))
			.List<Pair<Guid, long>>()
			.FirstOrDefault();
	}

	internal virtual void ReplacementTaskSetPermissionAction(IEntity entity, IReplacementTaskDocumentPermission replacement)
	{
		List<Permission> list = new List<Permission>();
		if (replacement.TaskDocumentsPermissions)
		{
			list.Add(PermissionProvider.DocumentViewPermission);
			list.Add(PermissionProvider.DocumentLoadPermission);
		}
		if (replacement.TaskDocumentsManagePermissions)
		{
			list.Add(PermissionProvider.DocumentManagerAccessPermission);
		}
		ReplacementTaskSetPermissionAction(entity, replacement.SourceUser, new List<EleWise.ELMA.Security.Models.IUser> { replacement.TargetUser }, list);
	}

	[Transaction]
	internal virtual void ReplacementTaskSetPermissionAction(IEntity entity, EleWise.ELMA.Security.Models.IUser sourceUser, ICollection<EleWise.ELMA.Security.Models.IUser> targetUsers, ICollection<Permission> permissions)
	{
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IEnumerable<IDocument> documentsFromObject = GetDocumentsFromObject(entity);
			if (documentsFromObject == null && !documentsFromObject.Any())
			{
				return;
			}
			foreach (IDocument item in documentsFromObject.ToList())
			{
				bool flag = false;
				foreach (Permission permission in permissions)
				{
					foreach (EleWise.ELMA.Security.Models.IUser targetUser in targetUsers)
					{
						if (SetReplacementPermissionDocument(item, permission, sourceUser, targetUser))
						{
							flag = true;
						}
					}
				}
				if (flag)
				{
					item.Save();
				}
			}
		});
	}

	private bool SetReplacementPermissionDocument(IDocument document, Permission permission, EleWise.ELMA.Security.Models.IUser sourceUser, EleWise.ELMA.Security.Models.IUser targetUser)
	{
		bool flag = false;
		List<Guid> source = (from p in (IEnumerable<IDmsObjectPermission>)document.Permissions
			where p.User != null && p.User.Id == sourceUser.Id
			select p.PermissionId).ToList();
		if (permission == PermissionProvider.DocumentViewPermission && source.Any((Guid p) => p == PermissionProvider.DocumentLoadPermission.Id || p == PermissionProvider.DocumentEditPermission.Id || p == PermissionProvider.DocumentFullAccessPermission.Id || p == PermissionProvider.DocumentViewPermission.Id))
		{
			flag = true;
		}
		if (permission == PermissionProvider.DocumentLoadPermission && source.Any((Guid p) => p == PermissionProvider.DocumentLoadPermission.Id || p == PermissionProvider.DocumentEditPermission.Id || p == PermissionProvider.DocumentFullAccessPermission.Id))
		{
			flag = true;
		}
		if (permission == PermissionProvider.DocumentEditPermission && source.Any((Guid p) => p == PermissionProvider.DocumentEditPermission.Id || p == PermissionProvider.DocumentFullAccessPermission.Id))
		{
			flag = true;
		}
		if (permission == PermissionProvider.DocumentManagerAccessPermission && source.Any((Guid p) => p == PermissionProvider.DocumentManagerAccessPermission.Id || p == PermissionProvider.DocumentFullAccessPermission.Id))
		{
			flag = true;
		}
		if (permission == PermissionProvider.DocumentFullAccessPermission && source.Any((Guid p) => p == PermissionProvider.DocumentFullAccessPermission.Id))
		{
			flag = true;
		}
		if (flag)
		{
			return AddPermissionsDependencies(document, permission, targetUser);
		}
		return false;
	}

	private bool ChangeFolder(IDocument document)
	{
		return GetDirtyPropertyUids(document).Any((Guid a) => a.Equals(InterfaceActivator.PropertyUid((IDmsObject m) => m.Folder)));
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> recipientList, IEnumerable<IInformationChannel> channelList, EleWise.ELMA.Security.Models.IUser messageAuthor, IEnumerable<IAttachment> attachmentList, IEnumerable<IDocumentAttachment> documentAttachmentList)
	{
		IChannelMessage channelMessage = InterfaceActivator.Create<IChannelMessage>();
		channelMessage.Subject = messageSubject;
		channelMessage.MessageType = ChannelMessageType.Post;
		channelMessage.CreationDate = DateTime.Now;
		channelMessage.CreationAuthor = messageAuthor ?? base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		channelMessage.FullMessage = messageText;
		if (attachmentList != null && attachmentList.Any())
		{
			foreach (IAttachment attachment in attachmentList)
			{
				channelMessage.Attachments.Add(attachment);
			}
		}
		if (channelList != null && channelList.Any())
		{
			foreach (IInformationChannel channel in channelList)
			{
				channelMessage.Channels.Add(channel);
			}
		}
		if (documentAttachmentList != null && documentAttachmentList.Any())
		{
			foreach (IDocumentAttachment documentAttachment in documentAttachmentList)
			{
				((IChannelMessageDocumentsExtension)channelMessage).DocumentAttachments.Add(documentAttachment);
			}
		}
		if (recipientList != null && recipientList.Any())
		{
			((ISet<EleWise.ELMA.Security.Models.IUser>)channelMessage.Recipients).AddAll(recipientList);
		}
		if (channelMessage.CreationAuthor != null && !((ICollection<EleWise.ELMA.Security.Models.IUser>)channelMessage.Recipients).Contains(channelMessage.CreationAuthor))
		{
			channelMessage.Recipients.Add(channelMessage.CreationAuthor);
		}
		channelMessage.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, IEnumerable<IInformationChannel> channels, EleWise.ELMA.Security.Models.IUser messageAuthor, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, channels, messageAuthor, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, IEnumerable<IInformationChannel> channels, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, user, channels, null, attachments);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, null, null, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, EleWise.ELMA.Security.Models.IUser messageAuthor, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, null, messageAuthor, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, EleWise.ELMA.Security.Models.IUser messageAuthor)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, null, messageAuthor, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, null, null, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, IEnumerable<IInformationChannel> channels)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, channels, null, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, EleWise.ELMA.Security.Models.IUser user, IEnumerable<IInformationChannel> channels, EleWise.ELMA.Security.Models.IUser messageAuthor)
	{
		SendMessage(messageSubject, messageText, new List<EleWise.ELMA.Security.Models.IUser> { user }, channels, messageAuthor, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<IInformationChannel> channels, EleWise.ELMA.Security.Models.IUser messageAuthor, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, users, channels, messageAuthor, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<IInformationChannel> channels, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, users, channels, null, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, EleWise.ELMA.Security.Models.IUser messageAuthor)
	{
		SendMessage(messageSubject, messageText, users, null, messageAuthor, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users)
	{
		SendMessage(messageSubject, messageText, users, null, null, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, users, null, null, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<IInformationChannel> channels)
	{
		SendMessage(messageSubject, messageText, users, channels, null, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<IInformationChannel> channels, EleWise.ELMA.Security.Models.IUser messageAuthor)
	{
		SendMessage(messageSubject, messageText, users, channels, messageAuthor, null, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void SendMessage(string messageSubject, string messageText, IEnumerable<EleWise.ELMA.Security.Models.IUser> users, EleWise.ELMA.Security.Models.IUser messageAuthor, IEnumerable<IAttachment> attachments)
	{
		SendMessage(messageSubject, messageText, users, null, messageAuthor, attachments, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	[PublicApiObsolete("SR.M('Этот метод устарел. Используйте метод MessageBuilder')", true)]
	public virtual SendMessageBuilder SendMessageBuilder(string messageSubject)
	{
		return new SendMessageBuilder(messageSubject);
	}

	[PublicApiMember]
	public bool ChangeStatus(IDocument document, ILifeCycleStatus status)
	{
		return Instance.ChangeStatus(document, status, null);
	}

	[PublicApiMember]
	public bool ChangeStatus(IDocument document, ILifeCycleStatus status, string comment)
	{
		if (document.Status == status || !Instance.CanChangeStatus(document, status))
		{
			return false;
		}
		Instance.SetStatus(document, status, comment);
		return document.Status == status;
	}

	[PublicApiMember]
	public bool CanChangeStatus(IDocument document, ILifeCycleStatus status)
	{
		return GetEnableStatuses(document).Any((ILifeCycleStatus q) => q == status);
	}

	[PublicApiMember]
	public IEnumerable<ILifeCycleStatus> GetEnableStatuses(IDocument document)
	{
		if (!Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, document))
		{
			return new List<ILifeCycleStatus>();
		}
		IMetadata metadata = MetadataLoader.LoadMetadata(((EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID(document.CastAsRealType().GetType()))).ImplementationUid, inherit: true, loadImplementation: false);
		ILifeCycle lifeCycle = LifeCycleManager.Instance.LoadOrNull(metadata.Uid);
		if (lifeCycle == null)
		{
			return new List<ILifeCycleStatus>();
		}
		List<ILifeCycleTransition> source = ((IEnumerable<ILifeCycleTransition>)lifeCycle.Transitions).ToList();
		if (!Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission))
		{
			source = source.Where((ILifeCycleTransition t) => document.Status == null || t.Start.Id == document.Status.Id).ToList();
		}
		return source.Select((ILifeCycleTransition q) => q.Finish).Distinct();
	}

	[PublicApiMember]
	public void Archive(IDocument document)
	{
		DmsObjectManager.Instance.Archive(new List<IDmsObject> { document });
	}

	[PublicApiMember]
	public void UnArchive(IDocument document)
	{
		DmsObjectManager.Instance.UnArchive(new List<IDmsObject> { document.CastAsRealType() });
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment([RequiredParameter] IDocument document, [RequiredParameter] string commentText)
	{
		IComment comment = InterfaceActivator.Create<IComment>();
		comment.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment.CreationDate = DateTime.Now;
		comment.Text = commentText;
		comment.Save();
		AddComment(document, comment);
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment([RequiredParameter] IDocument document, [RequiredParameter] string commentText, EleWise.ELMA.Security.Models.IUser commentAuthor, IEnumerable<IDocumentAttachment> documentAttachments, IEnumerable<IAttachment> attachments)
	{
		IComment comment = InterfaceActivator.Create<IComment>();
		comment.Text = commentText;
		comment.CreationAuthor = commentAuthor;
		if (commentAuthor != base.AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(document, comment, attachments, documentAttachments);
			});
		}
		else
		{
			AddComment(document, comment, attachments, documentAttachments);
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddQuestion(IDocument document, EleWise.ELMA.Security.Models.IUser recipient, string description, IEnumerable<IAttachment> attachments, bool showAll)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		IQuestion question = InterfaceActivator.Create<IQuestion>();
		question.RefObject = new ReferenceOnEntity
		{
			Object = document
		};
		question.Subject = document.Name;
		question.Executor = recipient;
		question.Description = description;
		question.ShowAll = showAll;
		question.Status = TaskBaseStatus.NewOrder;
		IList<IAttachment> list = (attachments as IList<IAttachment>) ?? attachments.ToList();
		if (list != null && list.Any())
		{
			foreach (IAttachment item in list)
			{
				question.Attachments.Add(item);
			}
		}
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, document, DocumentActions.AddQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddQuestion(IDocument document, IQuestion question)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		question.Subject = question.Subject ?? document.Name;
		question.RefObject = new ReferenceOnEntity
		{
			Object = document
		};
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, document, DocumentActions.AddQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public void Move(IDocument document, IFolder newFolder, bool? toEvent = true)
	{
		Instance.MoveTo(newFolder, new List<long> { document.Id }, null, toEvent.HasValue);
		document.Refresh();
	}

	[PublicApiMember]
	public virtual IEnumerable<IDocument> GetAllLinkedDocuments(IDocument document)
	{
		DocumentLinkFilter documentLinkFilter = InterfaceActivator.Create<DocumentLinkFilter>();
		documentLinkFilter.Query = $"Document = {document.Id}";
		return (from link in DocumentLinkManager.Instance.Find(documentLinkFilter, null)
			select link.LinkedDocument).ToList();
	}

	[PublicApiMember]
	public void AddViewPermission(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentViewPermission, user);
		document.Save();
	}

	[PublicApiMember]
	public void AddLoadPermission(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentLoadPermission, user);
		document.Save();
	}

	[PublicApiMember]
	public void AddViewPermission(IDocument document, IOrganizationItem orgItem)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentViewPermission, orgItem);
	}

	[PublicApiMember]
	public void AddLoadPermission(IDocument document, IOrganizationItem orgItem)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentLoadPermission, orgItem);
	}

	[PublicApiMember]
	public void AddViewPermission(IDocument document, IUserGroup userGroup)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentViewPermission, userGroup);
	}

	[PublicApiMember]
	public void AddLoadPermission(IDocument document, IUserGroup userGroup)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentLoadPermission, userGroup);
	}

	[PublicApiMember]
	public void AddEditPermission(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentEditPermission, user);
		document.Save();
	}

	[PublicApiMember]
	public void AddEditPermission(IDocument document, IOrganizationItem orgItem)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentEditPermission, orgItem);
	}

	[PublicApiMember]
	public void AddEditPermission(IDocument document, IUserGroup userGroup)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentEditPermission, userGroup);
	}

	[PublicApiMember]
	public void AddFullAccessPermission(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentFullAccessPermission, user);
		document.Save();
	}

	[PublicApiMember]
	public void AddFullAccessPermission(IDocument document, IOrganizationItem orgItem)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentFullAccessPermission, orgItem);
	}

	[PublicApiMember]
	public void AddFullAccessPermission(IDocument document, IUserGroup userGroup)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentFullAccessPermission, userGroup);
	}

	[PublicApiMember]
	public void AddManageAccessPermission(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentManagerAccessPermission, user);
		document.Save();
	}

	[PublicApiMember]
	public void AddManageAccessPermission(IDocument document, IOrganizationItem orgItem)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentManagerAccessPermission, orgItem);
	}

	[PublicApiMember]
	public void AddManageAccessPermission(IDocument document, IUserGroup userGroup)
	{
		DmsObjectManager.Instance.AddPermissionWithDependencies(document, PermissionProvider.DocumentManagerAccessPermission, userGroup);
	}

	[PublicApiMember]
	public void DeletePermissions(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		if (document == null)
		{
			throw new ArgumentNullException(SR.T("Документ не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)document.Permissions).Where((IDmsObjectPermission a) => a.Assigned == user).ToList())
		{
			((ICollection<IDmsObjectPermission>)document.Permissions).Remove(item);
		}
		document.Save();
	}

	[PublicApiMember]
	public void DeletePermissions(IDocument document, IOrganizationItem orgItem)
	{
		if (document == null)
		{
			throw new ArgumentNullException(SR.T("Документ не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Элемент оргструктуры не может быть null"));
		}
		foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)document.Permissions).Where((IDmsObjectPermission a) => a.Assigned == orgItem).ToList())
		{
			((ICollection<IDmsObjectPermission>)document.Permissions).Remove(item);
		}
		document.Save();
	}

	[PublicApiMember]
	public void DeletePermissions(IDocument document, IUserGroup userGroup)
	{
		if (document == null)
		{
			throw new ArgumentNullException(SR.T("Документ не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)document.Permissions).Where((IDmsObjectPermission a) => a.Assigned == userGroup).ToList())
		{
			((ICollection<IDmsObjectPermission>)document.Permissions).Remove(item);
		}
		document.Save();
	}

	[PublicApiMember]
	public virtual void AddDocumentCreatePermission(EleWise.ELMA.Security.Models.IUser user, Type type)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		if (((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).FirstOrDefault((IDmsObjectDefaultPermissions p) => p.User != null && p.User.Id == user.Id && p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id) == null)
		{
			ISet<IDmsObjectDefaultPermissions> permissions = documentMetadataProfile.Permissions;
			InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
			instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
			instanceOf.New.DocumentMetadataProfile = documentMetadataProfile;
			instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
			instanceOf.New.User = user;
			permissions.Add(instanceOf.New);
			documentMetadataProfile.Save();
		}
	}

	[PublicApiMember]
	public virtual void DeleteDocumentCreatePermission(EleWise.ELMA.Security.Models.IUser user, Type type)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		IDmsObjectDefaultPermissions dmsObjectDefaultPermissions = ((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).FirstOrDefault((IDmsObjectDefaultPermissions p) => p.User != null && p.User.Id == user.Id && p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id);
		if (dmsObjectDefaultPermissions != null)
		{
			((ICollection<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).Remove(dmsObjectDefaultPermissions);
			documentMetadataProfile.Save();
		}
	}

	[PublicApiMember]
	public virtual void AddDocumentCreatePermission(IUserGroup userGroup, Type type)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		if (((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).FirstOrDefault((IDmsObjectDefaultPermissions p) => p.Group != null && p.Group.Id == userGroup.Id && p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id) == null)
		{
			ISet<IDmsObjectDefaultPermissions> permissions = documentMetadataProfile.Permissions;
			InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
			instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
			instanceOf.New.DocumentMetadataProfile = documentMetadataProfile;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf.New.Group = userGroup;
			permissions.Add(instanceOf.New);
			documentMetadataProfile.Save();
		}
	}

	[PublicApiMember]
	public virtual void DeleteDocumentCreatePermission(IUserGroup userGroup, Type type)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		IDmsObjectDefaultPermissions dmsObjectDefaultPermissions = ((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).FirstOrDefault((IDmsObjectDefaultPermissions p) => p.Group != null && p.Group.Id == userGroup.Id && p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id);
		if (dmsObjectDefaultPermissions != null)
		{
			((ICollection<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).Remove(dmsObjectDefaultPermissions);
			documentMetadataProfile.Save();
		}
	}

	[PublicApiMember]
	public virtual void AddDocumentCreatePermission(IOrganizationItem orgItem, Type type)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		if (((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).FirstOrDefault((IDmsObjectDefaultPermissions p) => p.Assigned != null && p.Assigned == orgItem && p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id) == null)
		{
			ISet<IDmsObjectDefaultPermissions> permissions = documentMetadataProfile.Permissions;
			InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
			instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
			instanceOf.New.DocumentMetadataProfile = documentMetadataProfile;
			instanceOf.New.TypeRoleId = CommonRoleTypes.OrganizationItem.Id;
			instanceOf.New.Assigned = orgItem;
			permissions.Add(instanceOf.New);
			documentMetadataProfile.Save();
		}
	}

	[PublicApiMember]
	public virtual void DeleteDocumentCreatePermission(IOrganizationItem orgItem, Type type)
	{
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		IDmsObjectDefaultPermissions dmsObjectDefaultPermissions = ((IEnumerable<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).FirstOrDefault((IDmsObjectDefaultPermissions p) => p.Assigned != null && p.Assigned == orgItem && p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id);
		if (dmsObjectDefaultPermissions != null)
		{
			((ICollection<IDmsObjectDefaultPermissions>)documentMetadataProfile.Permissions).Remove(dmsObjectDefaultPermissions);
			documentMetadataProfile.Save();
		}
	}

	[PublicApiMember]
	public BinaryFile GetFileByDocumentId(IDocument document)
	{
		if (document == null)
		{
			throw new NullReferenceException(SR.T("Документ не может быть null"));
		}
		if (document.CurrentVersion == null)
		{
			throw new NullReferenceException(SR.T("Текущая версия документа не может быть null"));
		}
		if (!WebDocumentManager.Instance.IsWebDocument(document))
		{
			return document.CurrentVersion.File;
		}
		if (document.CurrentVersion.Content == null)
		{
			return null;
		}
		try
		{
			return BinaryFile.CreateNew().Name($"{document.Name}.html").ContentType(base.MimeMappingService.GetTypeByExtension(".html"))
				.Content(Encoding.UTF8.GetBytes(document.CurrentVersion.Content.ToString()))
				.Build();
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			return null;
		}
	}

	public IEnumerable<DocumentCompactInfoModel> DocumentCompactInfo(List<long> ids)
	{
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		int i = 0;
		Dictionary<string, object> dictionary = ((IEnumerable<long>)ids).ToDictionary((Func<long, string>)((long k) => $"id{i++}"), (Func<long, object>)((long v) => v));
		string sql = string.Format("\r\nselect dob.{1}, dob.{2}, dob.{3}, dob.{4}, dob.{5}, dob.{22}, dob.{23}, u.{2} {7}, u.{8} {9}, u.{10} {11}, u.{12} {13}, u.{14}, d.{16}, dob.{17}, v.{18}\r\nfrom {0}\r\ninner join {6} on u.{5} = dob.{3}\r\ninner join {15} on d.{5} = dob.{5}\r\nleft join {19} on v.{5} = d.{20}\r\nwhere dob.{5} in ({21})", transformationProvider.NoLockTableExpression("DmsObject", "dob"), transformationProvider.Dialect.QuoteIfNeeded("TypeUid"), transformationProvider.Dialect.QuoteIfNeeded("Uid"), transformationProvider.Dialect.QuoteIfNeeded("CreationAuthor"), transformationProvider.Dialect.QuoteIfNeeded("CreationDate"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.NoLockTableExpression("User", "u"), transformationProvider.Dialect.QuoteIfNeeded("UserUid"), transformationProvider.Dialect.QuoteIfNeeded("LastName"), transformationProvider.Dialect.QuoteIfNeeded("UserLastName"), transformationProvider.Dialect.QuoteIfNeeded("FirstName"), transformationProvider.Dialect.QuoteIfNeeded("UserFirstName"), transformationProvider.Dialect.QuoteIfNeeded("MiddleName"), transformationProvider.Dialect.QuoteIfNeeded("UserMiddleName"), transformationProvider.Dialect.QuoteIfNeeded("UserName"), transformationProvider.NoLockTableExpression("Document", "d"), transformationProvider.Dialect.QuoteIfNeeded("CurrentVersion"), transformationProvider.Dialect.QuoteIfNeeded("Name"), transformationProvider.Dialect.QuoteIfNeeded("File"), transformationProvider.NoLockTableExpression("DocumentVersion", "v"), transformationProvider.Dialect.QuoteIfNeeded("CurrentVersion"), string.Join(",", dictionary.Keys.Select((string k) => transformationProvider.ParameterSeparator + k)), transformationProvider.Dialect.QuoteIfNeeded("IsDeleted"), transformationProvider.Dialect.QuoteIfNeeded("IsArchived"));
		List<DocumentCompactInfoModel> list = new List<DocumentCompactInfoModel>();
		using IDataReader dataReader = transformationProvider.ExecuteQuery(sql, dictionary);
		while (dataReader.Read())
		{
			list.Add(new DocumentCompactInfoModel
			{
				DocumentName = dataReader["Name"].ToString(),
				DocumentTypeUid = transformationProvider.Dialect.GetGuid(dataReader["TypeUid"]),
				DocumentUid = transformationProvider.Dialect.GetGuid(dataReader["Uid"]),
				CreationAuthorId = ((dataReader["CreationAuthor"] is DBNull) ? 0 : Convert.ToInt64(dataReader["CreationAuthor"])),
				CreationDate = ((dataReader["CreationDate"] is DBNull) ? DateTime.MinValue : Convert.ToDateTime(dataReader["CreationDate"])),
				DocumentId = Convert.ToInt64(dataReader["Id"]),
				CreationAuthorUid = transformationProvider.Dialect.GetGuid(dataReader["UserUid"]),
				CreationAuthorLastName = ((dataReader["UserLastName"] is DBNull) ? string.Empty : dataReader["UserLastName"].ToString()),
				CreationAuthorFirstName = ((dataReader["UserFirstName"] is DBNull) ? string.Empty : dataReader["UserFirstName"].ToString()),
				CreationAuthorMiddleName = ((dataReader["UserMiddleName"] is DBNull) ? string.Empty : dataReader["UserMiddleName"].ToString()),
				CreationAuthorName = ((dataReader["UserName"] is DBNull) ? string.Empty : dataReader["UserName"].ToString()),
				CurrentVersion = ((!(dataReader["CurrentVersion"] is DBNull)) ? new long?(Convert.ToInt64(dataReader["CurrentVersion"])) : null),
				FileId = dataReader["File"].ToString(),
				IsDeleted = (!(dataReader["IsDeleted"] is DBNull) && Convert.ToBoolean(dataReader["IsDeleted"])),
				IsArchived = (!(dataReader["IsArchived"] is DBNull) && Convert.ToBoolean(dataReader["IsArchived"]))
			});
		}
		return list;
	}

	public IEnumerable<DocumentCompactInfoModel> DocumentCompactInfoForAttachments(List<Guid> uids)
	{
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		int i = 0;
		Dictionary<string, object> dictionary = ((IEnumerable<Guid>)uids).ToDictionary((Func<Guid, string>)((Guid k) => $"u{i++}"), (Func<Guid, object>)((Guid v) => v));
		string sql = string.Format("\r\nselect dob.{1}, dob.{2}, dob.{3}, dob.{4}, dob.{5}, dob.{22}, dob.{25}, da.{2} {8}, u.{2} {10}, u.{11} {12}, u.{13} {14}, u.{15} {16}, u.{17}, d.{19}, dob.{20}, v.{24}\r\nfrom {0}\r\ninner join {6} on da.{7} = dob.{5}\r\ninner join {9} on u.{5} = dob.{3}\r\ninner join {18} on d.{5} = dob.{5}\r\nleft join {23} on v.{5} = d.{19}\r\nwhere da.{2} in ({21})", transformationProvider.NoLockTableExpression("DmsObject", "dob"), transformationProvider.Dialect.QuoteIfNeeded("TypeUid"), transformationProvider.Dialect.QuoteIfNeeded("Uid"), transformationProvider.Dialect.QuoteIfNeeded("CreationAuthor"), transformationProvider.Dialect.QuoteIfNeeded("CreationDate"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.NoLockTableExpression("DocumentAttachment", "da"), transformationProvider.Dialect.QuoteIfNeeded("Document"), transformationProvider.Dialect.QuoteIfNeeded("DocumentAttachmentUid"), transformationProvider.NoLockTableExpression("User", "u"), transformationProvider.Dialect.QuoteIfNeeded("UserUid"), transformationProvider.Dialect.QuoteIfNeeded("LastName"), transformationProvider.Dialect.QuoteIfNeeded("UserLastName"), transformationProvider.Dialect.QuoteIfNeeded("FirstName"), transformationProvider.Dialect.QuoteIfNeeded("UserFirstName"), transformationProvider.Dialect.QuoteIfNeeded("MiddleName"), transformationProvider.Dialect.QuoteIfNeeded("UserMiddleName"), transformationProvider.Dialect.QuoteIfNeeded("UserName"), transformationProvider.NoLockTableExpression("Document", "d"), transformationProvider.Dialect.QuoteIfNeeded("CurrentVersion"), transformationProvider.Dialect.QuoteIfNeeded("Name"), string.Join(",", dictionary.Keys.Select((string k) => transformationProvider.ParameterSeparator + k)), transformationProvider.Dialect.QuoteIfNeeded("IsDeleted"), transformationProvider.NoLockTableExpression("DocumentVersion", "v"), transformationProvider.Dialect.QuoteIfNeeded("File"), transformationProvider.Dialect.QuoteIfNeeded("IsArchived"));
		List<DocumentCompactInfoModel> list = new List<DocumentCompactInfoModel>();
		using IDataReader dataReader = transformationProvider.ExecuteQuery(sql, dictionary);
		while (dataReader.Read())
		{
			list.Add(new DocumentCompactInfoModel
			{
				DocumentName = dataReader["Name"].ToString(),
				DocumentAttachmentUid = transformationProvider.Dialect.GetGuid(dataReader["DocumentAttachmentUid"]),
				DocumentTypeUid = transformationProvider.Dialect.GetGuid(dataReader["TypeUid"]),
				DocumentUid = transformationProvider.Dialect.GetGuid(dataReader["Uid"]),
				CreationAuthorId = ((dataReader["CreationAuthor"] is DBNull) ? 0 : Convert.ToInt64(dataReader["CreationAuthor"])),
				CreationDate = ((dataReader["CreationDate"] is DBNull) ? DateTime.MinValue : Convert.ToDateTime(dataReader["CreationDate"])),
				DocumentId = ((dataReader["Id"] is DBNull) ? 0 : Convert.ToInt64(dataReader["Id"])),
				CreationAuthorUid = transformationProvider.Dialect.GetGuid(dataReader["UserUid"]),
				CreationAuthorLastName = ((dataReader["UserLastName"] is DBNull) ? string.Empty : dataReader["UserLastName"].ToString()),
				CreationAuthorFirstName = ((dataReader["UserFirstName"] is DBNull) ? string.Empty : dataReader["UserFirstName"].ToString()),
				CreationAuthorMiddleName = ((dataReader["UserMiddleName"] is DBNull) ? string.Empty : dataReader["UserMiddleName"].ToString()),
				CreationAuthorName = ((dataReader["UserName"] is DBNull) ? string.Empty : dataReader["UserName"].ToString()),
				CurrentVersion = ((!(dataReader["CurrentVersion"] is DBNull)) ? new long?(Convert.ToInt64(dataReader["CurrentVersion"])) : null),
				FileId = ((dataReader["File"] != null) ? dataReader["File"].ToString() : string.Empty),
				IsDeleted = (!(dataReader["IsDeleted"] is DBNull) && Convert.ToBoolean(dataReader["IsDeleted"])),
				IsArchived = (!(dataReader["IsArchived"] is DBNull) && Convert.ToBoolean(dataReader["IsArchived"]))
			});
		}
		return list;
	}
}
