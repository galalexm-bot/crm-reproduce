using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentHistoryProfileManager : EntityManager<IDocumentHistoryProfile, long>
{
	public const string RootCacheKey = "DOCUMENTHISTORYPROFILES";

	public const string SupportedDocumentTypesCacheKey = "SUPPORTEDDOCUMENTHISTORYPROFILES";

	[NotNull]
	public new static DocumentHistoryProfileManager Instance => Locator.GetServiceNotNull<DocumentHistoryProfileManager>();

	public ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public IDocumentHistoryProfile GetByDocumentType(Guid documentType)
	{
		if (documentType == Guid.Empty)
		{
			return null;
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(documentType);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
		if (documentMetadataProfile != null && !documentMetadataProfile.UseCustomHistorySettings)
		{
			return LoadDefaultSettings();
		}
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("DocumentProfile", (object)documentMetadataProfile)).List<IDocumentHistoryProfile>().FirstOrDefault();
	}

	public bool ChapterIsVisible(Guid chapterUid, Guid documentType)
	{
		string key = $"Chapter_{chapterUid}_{documentType}";
		if (CacheService.TryGetValue<bool>(key, "DOCUMENTHISTORYPROFILES", out var value))
		{
			return value;
		}
		IDocumentHistoryChapter documentHistoryChapter = ((IEnumerable<IDocumentHistoryChapter>)(GetByDocumentType(documentType) ?? LoadDefaultSettings()).Chapters).FirstOrDefault((IDocumentHistoryChapter ch) => ch.ChapterUid == chapterUid);
		if (documentHistoryChapter == null)
		{
			CacheService.Insert(key, value: true, "DOCUMENTHISTORYPROFILES");
			return true;
		}
		CacheService.Insert(key, documentHistoryChapter.Visible, "DOCUMENTHISTORYPROFILES");
		return documentHistoryChapter.Visible;
	}

	public bool ActionIsVisible(Guid actionUid, Guid chapterUid, Guid documentType)
	{
		string key = $"Chapter_{actionUid}_{chapterUid}_{documentType}";
		if (CacheService.TryGetValue<bool>(key, "DOCUMENTHISTORYPROFILES", out var value))
		{
			return value;
		}
		IDocumentHistoryChapter documentHistoryChapter = ((IEnumerable<IDocumentHistoryChapter>)(GetByDocumentType(documentType) ?? LoadDefaultSettings()).Chapters).FirstOrDefault((IDocumentHistoryChapter ch) => ch.ChapterUid == chapterUid);
		if (documentHistoryChapter != null && !documentHistoryChapter.Visible)
		{
			CacheService.Insert(key, value: false, "DOCUMENTHISTORYPROFILES");
			return false;
		}
		if (documentHistoryChapter == null)
		{
			CacheService.Insert(key, value: true, "DOCUMENTHISTORYPROFILES");
			return true;
		}
		IDocumentHistoryAction documentHistoryAction = ((IEnumerable<IDocumentHistoryAction>)documentHistoryChapter.Actions).FirstOrDefault((IDocumentHistoryAction a) => a.ActionUid == actionUid);
		if (documentHistoryAction == null)
		{
			CacheService.Insert(key, value: true, "DOCUMENTHISTORYPROFILES");
			return true;
		}
		CacheService.Insert(key, documentHistoryAction.Visible, "DOCUMENTHISTORYPROFILES");
		return documentHistoryAction.Visible;
	}

	public IDocumentHistoryProfile LoadDefaultSettings()
	{
		return LoadOrNull(DocumentConstants.DefaultDocumentHistoryProfileUid);
	}

	[Transaction]
	public virtual IDocumentHistoryProfile CreateNew(Guid? documentType = null, Guid? customUid = null)
	{
		IDocumentHistoryProfile @new = new InstanceOf<IDocumentHistoryProfile>().New;
		if (documentType.HasValue)
		{
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(documentType.Value);
			@new.DocumentProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
		}
		if (customUid.HasValue)
		{
			@new.Uid = customUid.Value;
		}
		IEnumerable<IDocumentHistoryChapterInfo> extensionPoints = ComponentManager.Current.GetExtensionPoints<IDocumentHistoryChapterInfo>();
		List<IDocumentHistoryActionInfo> source = ComponentManager.Current.GetExtensionPoints<IDocumentHistoryActionInfo>().ToList();
		foreach (IDocumentHistoryChapterInfo item in extensionPoints)
		{
			IDocumentHistoryChapterInfo chapter = item;
			InstanceOf<IDocumentHistoryChapter> instanceOf = new InstanceOf<IDocumentHistoryChapter>();
			instanceOf.New.ChapterUid = chapter.Uid;
			instanceOf.New.Visible = true;
			instanceOf.New.HistoryProfile = @new;
			IDocumentHistoryChapter new2 = instanceOf.New;
			@new.Chapters.Add(new2);
			foreach (IDocumentHistoryActionInfo item2 in source.Where((IDocumentHistoryActionInfo a) => a.ActionChapterUid == chapter.Uid))
			{
				InstanceOf<IDocumentHistoryAction> instanceOf2 = new InstanceOf<IDocumentHistoryAction>();
				instanceOf2.New.ActionUid = item2.ActionUid;
				instanceOf2.New.Visible = true;
				instanceOf2.New.HistoryChapter = new2;
				IDocumentHistoryAction new3 = instanceOf2.New;
				new2.Actions.Add(new3);
			}
		}
		@new.Save();
		ClearCache();
		if (documentType.HasValue)
		{
			RefreshSupportedDocumentCacheRecord(documentType.Value, @new.DocumentProfile != null && @new.DocumentProfile.UseCustomHistorySettings);
		}
		return @new;
	}

	[Transaction]
	public virtual void RefreshProfile(IDocumentHistoryProfile profile)
	{
		IEnumerable<IDocumentHistoryChapterInfo> extensionPoints = ComponentManager.Current.GetExtensionPoints<IDocumentHistoryChapterInfo>();
		List<IDocumentHistoryActionInfo> source = ComponentManager.Current.GetExtensionPoints<IDocumentHistoryActionInfo>().ToList();
		foreach (IDocumentHistoryChapterInfo item in extensionPoints)
		{
			IDocumentHistoryChapterInfo chapter = item;
			IDocumentHistoryChapter documentHistoryChapter = ((IEnumerable<IDocumentHistoryChapter>)profile.Chapters).FirstOrDefault((IDocumentHistoryChapter c) => c.ChapterUid == chapter.Uid);
			if (documentHistoryChapter == null)
			{
				InstanceOf<IDocumentHistoryChapter> instanceOf = new InstanceOf<IDocumentHistoryChapter>();
				instanceOf.New.ChapterUid = chapter.Uid;
				instanceOf.New.Visible = true;
				instanceOf.New.HistoryProfile = profile;
				documentHistoryChapter = instanceOf.New;
				profile.Chapters.Add(documentHistoryChapter);
			}
			List<IDocumentHistoryActionInfo> actions = source.Where((IDocumentHistoryActionInfo a) => a.ActionChapterUid == chapter.Uid).ToList();
			foreach (IDocumentHistoryActionInfo action in actions)
			{
				IDocumentHistoryAction documentHistoryAction = ((IEnumerable<IDocumentHistoryAction>)documentHistoryChapter.Actions).FirstOrDefault((IDocumentHistoryAction a) => a.ActionUid == action.ActionUid);
				if (documentHistoryAction == null)
				{
					InstanceOf<IDocumentHistoryAction> instanceOf2 = new InstanceOf<IDocumentHistoryAction>();
					instanceOf2.New.ActionUid = action.ActionUid;
					instanceOf2.New.Visible = true;
					instanceOf2.New.HistoryChapter = documentHistoryChapter;
					documentHistoryAction = instanceOf2.New;
					documentHistoryChapter.Actions.Add(documentHistoryAction);
				}
			}
			List<IDocumentHistoryAction> list = ((IEnumerable<IDocumentHistoryAction>)documentHistoryChapter.Actions).Where((IDocumentHistoryAction a) => actions.All((IDocumentHistoryActionInfo cha) => cha.ActionUid != a.ActionUid)).ToList();
			documentHistoryChapter.Actions.RemoveAll((ICollection<IDocumentHistoryAction>)list);
			documentHistoryChapter.Save();
		}
		ClearCache();
	}

	public override void Save(IDocumentHistoryProfile obj)
	{
		base.Save(obj);
		CacheService.ClearRegion("DOCUMENTHISTORYPROFILES");
	}

	public virtual void ClearCache()
	{
		CacheService.ClearRegion("DOCUMENTHISTORYPROFILES");
	}

	public bool IsDocumentSupportCustomHistory(Guid documentTypeGuid)
	{
		string key = documentTypeGuid.ToString();
		if (CacheService.TryGetValue<bool>(key, "SUPPORTEDDOCUMENTHISTORYPROFILES", out var value))
		{
			return value;
		}
		IDocumentHistoryProfile documentHistoryProfile = GetByDocumentType(documentTypeGuid) ?? LoadDefaultSettings();
		bool flag = documentHistoryProfile.DocumentProfile != null && documentHistoryProfile.DocumentProfile.UseCustomHistorySettings;
		RefreshSupportedDocumentCacheRecord(documentTypeGuid, flag);
		return flag;
	}

	public void RefreshSupportedDocumentCacheRecord(IDocumentMetadataProfile profile)
	{
		if (profile != null && profile.DocumentType != null)
		{
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(profile.DocumentType.EntityType, inherit: false, loadImplementation: false);
			if (entityMetadata != null)
			{
				RefreshSupportedDocumentCacheRecord(entityMetadata.Uid, profile.UseCustomHistorySettings);
			}
		}
	}

	private void RefreshSupportedDocumentCacheRecord(Guid documentTypeGuid, bool value)
	{
		string key = documentTypeGuid.ToString();
		CacheService.Insert(key, value, "SUPPORTEDDOCUMENTHISTORYPROFILES");
	}
}
