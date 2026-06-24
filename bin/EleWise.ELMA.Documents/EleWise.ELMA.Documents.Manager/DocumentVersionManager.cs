using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading;
using System.Web;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Encrypters;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Threading;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentVersionManager : EntityManager<IDocumentVersion, long>
{
	public new static DocumentVersionManager Instance => Locator.GetServiceNotNull<DocumentVersionManager>();

	public IEntityActionHandler EntityActionHandler { get; set; }

	public ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public IFileManager FileManager { get; set; }

	public DocumentGeneratorManager DocumentGeneratorManager { get; set; }

	public DocumentMetadataProfileManager DocumentMetadataProfileManager { get; set; }

	public IDocumentFileManager DocumentFileManager { get; set; }

	public long GetVersionCount(IDocument document)
	{
		InstanceOf<IDocumentVersionFilter> instanceOf = new InstanceOf<IDocumentVersionFilter>();
		instanceOf.New.Document = document;
		IDocumentVersionFilter @new = instanceOf.New;
		return Count(@new);
	}

	public long GetLastVersionDocument(IDocument document)
	{
		IDocumentVersion documentVersion = (from v in (from d in base.Session.Query<IDocumentVersion>()
				where d.Document == document
				select d).ToList()
			orderby v.Version
			select v).LastOrDefault();
		if (documentVersion != null && documentVersion.Version.HasValue)
		{
			return documentVersion.Version.Value;
		}
		return 0L;
	}

	public IDocumentVersion GetLast(IDocument document)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Document", (object)document)).AddOrder(Order.Desc("Version")).SetMaxResults(1)
			.List<IDocumentVersion>()
			.FirstOrDefault();
	}

	public List<IDocumentVersion> Get(long documentId)
	{
		return CreateCriteria().CreateAlias("Document", "doc").Add((ICriterion)(object)Restrictions.Eq("doc.Id", (object)documentId)).List<IDocumentVersion>()
			.ToList();
	}

	public virtual IEnumerable<IDocumentVersion> GetCurrentVersion(IDocument document)
	{
		return GetCurrentVersion(document.Id);
	}

	public virtual IEnumerable<IDocumentVersion> GetCurrentVersion(long document)
	{
		return CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IDocumentVersion>(), "v").Add((ICriterion)(object)Restrictions.Eq("Document.Id", (object)document)).Add((ICriterion)(object)Restrictions.Eq("Status", (object)DocumentVersionStatus.Current)).List<IDocumentVersion>();
	}

	public IEnumerable<IDocumentVersion> GetCurrentVersionsForUser(IDocument document, EleWise.ELMA.Security.Models.IUser user)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Document", (object)document)).Add((ICriterion)(object)Restrictions.Eq("Status", (object)DocumentVersionStatus.Current)).Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)user))
			.List<IDocumentVersion>();
	}

	public virtual void CheckPremissionToEdit(IDocumentVersion version)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		bool flag = serviceNotNull.HasPermission(PermissionProvider.DocumentFullAccessPermission, version.Document.CastAsRealType());
		bool flag2 = serviceNotNull.HasPermission(PermissionProvider.DocumentEditPermission, version.Document.CastAsRealType());
		if (!flag && (!flag2 || !version.IsNew()) && (!flag2 || version.ChangeAuthor == null || version.ChangeAuthor.Id != currentUser.Id))
		{
			throw new SecurityException(string.Format(SR.T("Недостаточно прав для редактирования версии {0} в документе {1}"), version, version.Document));
		}
	}

	[Transaction]
	public virtual void LockWithLock(long versionId)
	{
		DateTime dateTime = DateTime.Now.AddSeconds(30.0);
		while (true)
		{
			try
			{
				IDocumentVersion version = (IDocumentVersion)base.Session.Load(InterfaceActivator.TypeOf<IDocumentVersion>(), (object)versionId, LockMode.Upgrade);
				Lock(version);
				break;
			}
			catch (GenericADOException)
			{
				if (DateTime.Now > dateTime)
				{
					throw new Exception(SR.T("Не удалось заблокировать версию."));
				}
				Thread.Sleep(1000);
			}
		}
	}

	[Transaction]
	public virtual void Lock(IDocumentVersion version)
	{
		CheckPremissionToEdit(version);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (version.IsBlocked && version.BlockAuthor != null && version.BlockAuthor.Id != currentUser.Id)
		{
			throw new Exception(SR.T("Версия заблокирована пользоввателем {0}", version.BlockAuthor.FullName));
		}
		version.IsBlocked = true;
		version.BlockDate = DateTime.Now;
		version.BlockAuthor = currentUser;
		RunWithoutUserEdit(delegate
		{
			version.Save();
		});
		EntityActionEventArgs e = new EntityActionEventArgs(null, version, DocumentVersionActions.LockGuid);
		EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	public virtual void UnLock(IDocumentVersion version)
	{
		CheckPremissionToEdit(version);
		version.IsBlocked = false;
		version.BlockDate = null;
		version.BlockAuthor = null;
		RunWithoutUserEdit(delegate
		{
			version.Save();
		});
		EntityActionEventArgs e = new EntityActionEventArgs(null, version, DocumentVersionActions.UnLockGuid);
		EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	public virtual void ChangeStatus(IDocumentVersion version, DocumentVersionStatus state)
	{
		version.Status = state;
		RunWithoutUserEdit(delegate
		{
			version.Save();
		});
		EntityActionEventArgs e = new EntityActionEventArgs(null, version, DocumentVersionActions.ChangeStatusGuid);
		EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	public virtual void Download(IDocumentVersion version)
	{
		EntityActionEventArgs e = new EntityActionEventArgs(null, version, DocumentVersionActions.DownloadGuid);
		EntityActionHandler.ActionExecuted(e);
	}

	[Transaction]
	[Obsolete("Использовать стандартный метод Save для сущности")]
	public virtual void Edit(IDocumentVersion version)
	{
		version.Save();
	}

	[Transaction]
	public virtual void Encrypt(IDocumentVersion version, string password)
	{
		if (version.Encrypt)
		{
			throw new ArgumentException(SR.T("Версия документа уже зашифрована"));
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(version.Document.CastAsRealType().TypeUid);
		if (!documentMetadata.EnableCrypto || documentMetadata.CryptoSettings == null)
		{
			throw new Exception(SR.T("Для типа документа {0} не включена возможность для шифрования"));
		}
		if (documentMetadata.CryptoSettings.CryptoEntityTypeUid == Guid.Empty)
		{
			throw new Exception(SR.T("Не задана сущность для шифрования"));
		}
		EnryptInternal(version, password);
	}

	[Transaction]
	internal virtual void EnryptInternal(IDocumentVersion version, string password)
	{
		string salt = EncryptionHelper.GenerateSalt();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentVersion>();
		Filter filter = new Filter
		{
			Query = $"DocumentVersion = {version.Id}"
		};
		IDocumentVersionCrypto documentVersionCrypto = EntityManager<IDocumentVersionCrypto>.Instance.Find(filter, new FetchOptions(0, 1)).FirstOrDefault();
		if (documentVersionCrypto == null)
		{
			documentVersionCrypto = InterfaceActivator.Create<IDocumentVersionCrypto>();
			documentVersionCrypto.DocumentVersion = version;
		}
		if (version.Content != null)
		{
			PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Content");
			ITypeEncrypter typeEncrypter = ComponentManager.Current.GetExtensionPoints<ITypeEncrypter>().FirstOrDefault((ITypeEncrypter e) => e.CheckType(version.Content, propertyMetadata));
			if (typeEncrypter != null)
			{
				string text2 = (documentVersionCrypto.Content = typeEncrypter.Encrypt(version.Content, password, salt, propertyMetadata));
				version.Content = (HtmlString)typeEncrypter.EncryptStub(version.Content, propertyMetadata);
			}
		}
		if (version.File != null)
		{
			Locator.GetServiceNotNull<IFilePreviewService>().ClearPreview(version.File);
			DataAccessManager.FileManager.Encrypt(version.File, password, salt);
		}
		version.Salt = salt;
		version.Encrypt = true;
		version.EncryptDate = DateTime.Now;
		version.EncryptUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		version.Save();
		documentVersionCrypto.Save();
		base.Session.Flush();
	}

	public virtual IDocumentVersionCrypto GetCryptoVersion(IDocumentVersion version)
	{
		Filter filter = new Filter
		{
			Query = $"DocumentVersion = {version.Id}"
		};
		return EntityManager<IDocumentVersionCrypto>.Instance.Find(filter, new FetchOptions(0, 1)).FirstOrDefault();
	}

	internal virtual bool CheckPassword(IDocumentVersion version, string password)
	{
		try
		{
			return DecryptInternal(version, password) != null;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public virtual void Decrypt(IDocumentVersion version, string password)
	{
		object obj = DecryptInternal(version, password);
		if (obj != null && obj is HtmlString content)
		{
			version.Content = content;
		}
	}

	[Transaction]
	public virtual void CancelEncrypt(IDocumentVersion version, string password)
	{
		Decrypt(version, password);
		version.Encrypt = false;
		version.Salt = null;
		version.EncryptDate = null;
		version.EncryptUser = null;
		if (version.File != null)
		{
			version.File = DataAccessManager.FileManager.Decrypt(version.File, password);
			DataAccessManager.FileManager.CancelEncrypt(version.File, password);
		}
		version.Save();
	}

	public override ActionCheckResult CanSave(IDocumentVersion version)
	{
		if (version.Document == null)
		{
			return ActionCheckResult.False(SR.T("Невозможно сохранить версию без указания документа"));
		}
		if (version.IsNew() && version.Document.IsNew())
		{
			return DocumentManager.Instance.CanSave(version.Document);
		}
		try
		{
			CheckPremissionToEdit(version);
			return ActionCheckResult.True;
		}
		catch (SecurityException ex)
		{
			return ActionCheckResult.False(ex.Message);
		}
	}

	public override ActionCheckResult CanDelete(IDocumentVersion version)
	{
		if (version.IsNew())
		{
			return ActionCheckResult.False(SR.T("Невозможно удалить версию, т.к. она еще не была сохранена"));
		}
		if (version.Document == null || version.Document.IsNew())
		{
			return ActionCheckResult.True;
		}
		try
		{
			CheckPremissionToEdit(version);
			return ActionCheckResult.True;
		}
		catch (SecurityException ex)
		{
			return ActionCheckResult.False(ex.Message);
		}
	}

	public static bool IsUserEditGuidDisable()
	{
		IContextBoundVariableService serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
		bool value = false;
		serviceNotNull.TryGetValue<bool>("UserEditGuidDisable", out value);
		return value;
	}

	public static void RunWithoutUserEdit(Action action)
	{
		IContextBoundVariableService serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
		bool flag = false;
		try
		{
			flag = IsUserEditGuidDisable();
			if (!flag)
			{
				serviceNotNull.Set("UserEditGuidDisable", true);
			}
			action();
		}
		finally
		{
			if (!flag)
			{
				serviceNotNull.Set("UserEditGuidDisable", false);
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public override void Save(IDocumentVersion obj)
	{
		bool num = obj.IsNew();
		bool flag = obj.IsDirty();
		base.Save(obj);
		if (num)
		{
			EntityActionEventArgs e = new EntityActionEventArgs(null, obj, DocumentVersionActions.UserCreateGuid);
			EntityActionHandler.ActionExecuted(e);
		}
		else if (flag && !IsUserEditGuidDisable())
		{
			string name = "VersionUserEdit" + obj.Id;
			if (!(base.ContextService.TryGetValue<bool>(name, out var value) && value))
			{
				EntityActionEventArgs e2 = new EntityActionEventArgs(null, obj, DocumentVersionActions.EditGuid);
				EntityActionHandler.ActionExecuted(e2);
				base.ContextService.Set(name, true);
			}
		}
	}

	[Transaction]
	public virtual AddDocumentVersionResult AddVersionAndFlush(IDocument document, BinaryFile binaryFile)
	{
		Contract.ArgumentNotNull(document, "document");
		Contract.ArgumentNotNull(binaryFile, "binaryFile");
		WebDocumentManager instance = WebDocumentManager.Instance;
		DocumentManager instance2 = DocumentManager.Instance;
		bool num = document.Encrypt && instance2.IsVersionsNeedEncrypt(document);
		string text = null;
		if (num)
		{
			text = instance2.CheckAndGetCryptPassword(document);
		}
		bool flag = instance.IsWebDocument(document.TypeUid);
		InstanceOf<IDocumentVersion> instanceOf = new InstanceOf<IDocumentVersion>();
		instanceOf.New.Document = document;
		instanceOf.New.File = (flag ? null : binaryFile);
		IDocumentVersion @new = instanceOf.New;
		if (flag)
		{
			instance.CreateFromFile(binaryFile, @new);
			ChangeStatus(@new, DocumentVersionStatus.Current);
		}
		document.Versions.Add(@new);
		document.Save();
		if (num && !string.IsNullOrEmpty(text))
		{
			Encrypt(@new, text);
		}
		base.Session.Flush();
		return new AddDocumentVersionResult
		{
			IsWebDocument = flag,
			NewDocumentVersion = @new
		};
	}

	[Auditable]
	public virtual bool IsSigned(IDocumentVersion version)
	{
		return false;
	}

	[Auditable]
	public virtual bool IsCurrentUserSigned(IDocumentVersion version)
	{
		return false;
	}

	[Auditable]
	public virtual bool CanCurrentUserResign(IDocumentVersion version)
	{
		return false;
	}

	[Auditable]
	public virtual long SignersCount(IDocumentVersion version)
	{
		return 0L;
	}

	[Auditable]
	public virtual bool HasPermissionToSign(IDocumentVersion version)
	{
		return false;
	}

	internal ICriteria GetDocumentVersionIdCriteria(long documentId)
	{
		return CreateCriteria().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() }).Add((ICriterion)(object)Restrictions.Eq("Document.Id", (object)documentId));
	}

	internal object DecryptInternal(IDocumentVersion version, string password)
	{
		IDocumentVersionCrypto cryptoVersion = GetCryptoVersion(version);
		if (cryptoVersion == null)
		{
			throw new Exception(SR.T("Не найдена зашифрованная сущность"));
		}
		if (cryptoVersion.Content != null)
		{
			EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentVersion>();
			PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Content");
			ITypeEncrypter typeEncrypter = ComponentManager.Current.GetExtensionPoints<ITypeEncrypter>().FirstOrDefault((ITypeEncrypter e) => e.CheckType(version.Content, propertyMetadata));
			if (typeEncrypter != null)
			{
				return typeEncrypter.Decrypt(cryptoVersion.Content, password, version.Salt, propertyMetadata);
			}
		}
		if (version.File != null)
		{
			return DataAccessManager.FileManager.Decrypt(version.File, password);
		}
		return null;
	}

	[PublicApiMember]
	public virtual IDocumentVersion AddDocumentVersion(IDocument document, BinaryFile file, DocumentVersionStatus versionStatus)
	{
		IDocumentVersion documentVersion = InterfaceActivator.Create<IDocumentVersion>();
		IFileManager serviceNotNull = Locator.GetServiceNotNull<IFileManager>();
		ContextVars.Set(serviceNotNull.ProcessStoreKey, value: true);
		serviceNotNull.SaveFile(file);
		ContextVars.Set(serviceNotNull.ProcessStoreKey, value: false);
		documentVersion.File = file;
		documentVersion.Document = document;
		if (versionStatus == DocumentVersionStatus.Current)
		{
			document.CurrentVersion = documentVersion;
		}
		document.Versions.Add(documentVersion);
		document.Save();
		if (versionStatus != 0)
		{
			Instance.ChangeStatus(documentVersion, versionStatus);
		}
		return documentVersion;
	}

	[PublicApiMember]
	public virtual IDocumentVersion AddDocumentVersion(IDocument document, BinaryFile file)
	{
		return AddDocumentVersion(document, file, DocumentVersionStatus.Draft);
	}

	[PublicApiMember]
	public virtual void RenameVersionFile(IDocumentVersion docVersion, string newVersionFileName, bool saveOldExtension)
	{
		if (newVersionFileName == null)
		{
			throw new NullReferenceException(SR.T("Новое имя не может быть null."));
		}
		if (newVersionFileName == "")
		{
			throw new ArgumentException(SR.T("Имя файла не может быть пустым."));
		}
		if (docVersion == null)
		{
			throw new NullReferenceException(SR.T("Версия документа не может быть null."));
		}
		int num = newVersionFileName.LastIndexOf('.');
		int num2 = docVersion.File.Name.LastIndexOf('.');
		string name = string.Empty;
		if (num == -1 && num2 == -1)
		{
			name = newVersionFileName;
		}
		else if (num == -1 && num2 > -1)
		{
			name = (saveOldExtension ? (newVersionFileName + docVersion.File.Name.Substring(num2)) : newVersionFileName);
		}
		else if (num2 == -1 && num > -1)
		{
			name = (saveOldExtension ? newVersionFileName.Substring(0, num) : newVersionFileName);
		}
		else if (num > -1 && num2 > -1)
		{
			name = (saveOldExtension ? (newVersionFileName.Substring(0, num) + docVersion.File.Name.Substring(num2)) : newVersionFileName);
		}
		docVersion.File.Name = name;
		docVersion.Save();
	}

	[PublicApiMember]
	public virtual void ChangeVersionStatus(IDocumentVersion version, DocumentVersionStatus versionStatus)
	{
		Instance.ChangeStatus(version, versionStatus);
	}

	[PublicApiMember]
	public virtual void GenerateByCurrentVersion(IDocument document, string fileName, bool saveOldExtension)
	{
		BinaryFile file = GenerateDocument(DocumentFileManager.GetFileByDocumentId(document.Id), DocumentGeneratorManager, document);
		IDocumentVersion docVersion = Instance.AddDocumentVersion(document, file, DocumentVersionStatus.Current);
		Instance.RenameVersionFile(docVersion, fileName, saveOldExtension);
	}

	[PublicApiMember]
	public virtual void GenerateByTemplateFile(IDocument document, string fileName, bool saveOldExtension)
	{
		GenerateByTemplateFile(document, string.Empty, fileName, saveOldExtension);
	}

	[PublicApiMember]
	public virtual void GenerateByTemplateFile(IDocument document, string templateName, string fileName, bool saveOldExtension)
	{
		Contract.ArgumentNotNull(document, "document");
		Guid typeUid = InterfaceActivator.UID(document.CastAsRealType().GetType());
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.LoadByDocumentTypeFromImplementation(typeUid);
		if (documentMetadataProfile == null)
		{
			throw new Exception(SR.T("Не найден профиль типа документа"));
		}
		string lowerTemplateName = templateName.ToLower();
		BinaryFile file = GenerateDocument(((!string.IsNullOrEmpty(templateName)) ? ((IEnumerable<IDocumentTemplate>)documentMetadataProfile.Templates).Select(delegate(IDocumentTemplate t)
		{
			BinaryFile file2 = t.File;
			if (file2 != null && file2.Name.ToLower() == lowerTemplateName)
			{
				return file2;
			}
			IDocument document2 = t.Document;
			return (document2 != null && document2.Name.ToLower() == lowerTemplateName) ? DocumentFileManager.GetFileByDocumentId(document2.Id) : null;
		}).FirstOrDefault((BinaryFile f) => f != null) : ((IEnumerable<IDocumentTemplate>)documentMetadataProfile.Templates).FirstOrDefault()?.File) ?? throw new Exception(SR.T("Не найден шаблон для генерации версии документа")), DocumentGeneratorManager, document);
		IDocumentVersion docVersion = AddDocumentVersion(document, file, DocumentVersionStatus.Current);
		RenameVersionFile(docVersion, fileName, saveOldExtension);
	}

	[PublicApiMember]
	public virtual void GenerateByTemplateFile(IDocument document, IDocumentTemplate template, string fileName, bool saveOldExtension)
	{
		Contract.ArgumentNotNull(document, "document");
		Contract.ArgumentNotNull(template, "template");
		BinaryFile file = GenerateDocument(template.File, DocumentGeneratorManager, document);
		IDocumentVersion docVersion = AddDocumentVersion(document, file, DocumentVersionStatus.Current);
		RenameVersionFile(docVersion, fileName, saveOldExtension);
	}

	[PublicApiMember]
	public virtual void GenerateByFile(IDocument document, BinaryFile file, string fileName, bool saveOldExtension)
	{
		long id = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id;
		ContextVars.Set("EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.ProcessStore", value: true);
		string fileId = Locator.GetServiceNotNull<IFileManager>().SaveFile(file);
		ContextVars.Set("EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.ProcessStore", value: false);
		using (ELMAContext.CreateIsolated())
		{
			using (CallContextSessionOwner.Create())
			{
				AddVersionExecute(document.Id, fileId, id);
			}
		}
		Instance.GenerateByCurrentVersion(document, fileName, saveOldExtension);
	}

	private static BinaryFile GenerateDocument(BinaryFile templateFile, DocumentGeneratorManager documentGeneratorManager, object dataSource)
	{
		BinaryFile binaryFile = documentGeneratorManager.GenerateToBinaryFile(templateFile, dataSource);
		DataAccessManager.FileManager.SaveFile(binaryFile);
		return binaryFile;
	}

	private void AddVersionExecute(long documentId, string fileId, long currentUserId)
	{
		new BackgroundTask(delegate
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New("");
			try
			{
				Locator.GetServiceNotNull<ISecurityService>().RunByUser(UserManager.Instance.Load(currentUserId), delegate
				{
					BinaryFile file = Locator.GetServiceNotNull<IFileManager>().LoadFile(fileId);
					IDocument document = DocumentManager.Instance.Load(documentId);
					Instance.AddDocumentVersion(document, file, DocumentVersionStatus.Current);
				});
				unitOfWork.Commit();
			}
			catch (Exception message)
			{
				base.Logger.Error(message);
				unitOfWork.Rollback();
			}
		}, typeof(IDocumentVersion), "AddDocumentVersion", "Добавить версию документа").Execute();
	}
}
