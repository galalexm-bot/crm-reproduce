using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

[Service]
public class DocumentActionsProfileManager
{
	public const string RootCacheKey = "DOCUMENTACTIONSPROFILES";

	public const string DefaultSettingsKey = "DefaultDocumentActionsProfileUidBaseHolder";

	public static DocumentActionsProfileManager Instance => Locator.GetServiceNotNull<DocumentActionsProfileManager>();

	public ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public DocumentActionSettingsHolder GetByDocumentType(Guid documentType)
	{
		if (documentType == Guid.Empty)
		{
			return null;
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(documentType);
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
		if (documentMetadataProfile == null || !documentMetadataProfile.UseCustomActionsSettings)
		{
			return LoadDefaultSettings();
		}
		return documentMetadataProfile.ActionVisibility as DocumentActionSettingsHolder;
	}

	public DocumentActionSettingsHolder LoadDefaultSettings()
	{
		string bLOB = DataAccessManager.BLOBManager.GetBLOB<string>(DocumentConstants.DefaultDocumentActionsProfileUid, "DefaultDocumentActionsProfileUidBaseHolder");
		DocumentActionSettingsHolder result = null;
		if (!string.IsNullOrEmpty(bLOB))
		{
			result = ClassSerializationHelper.DeserializeObjectByXml<DocumentActionSettingsHolder>(bLOB);
		}
		return result;
	}

	public void SaveDefaultSettings(DocumentActionSettingsHolder holder)
	{
		string value = ClassSerializationHelper.SerializeObjectByXml(holder);
		DataAccessManager.BLOBManager.SetBLOB(DocumentConstants.DefaultDocumentActionsProfileUid, "DefaultDocumentActionsProfileUidBaseHolder", value);
	}

	public bool ChapterIsVisible(Guid chapterUid, Guid documentType)
	{
		string key = $"Chapter_{chapterUid}_{documentType}";
		if (CacheService.TryGetValue<bool>(key, "DOCUMENTACTIONSPROFILES", out var value))
		{
			return value;
		}
		value = (GetByDocumentType(documentType) ?? LoadDefaultSettings())?.ChapterIsVisible(chapterUid) ?? true;
		CacheService.Insert(key, value, "DOCUMENTACTIONSPROFILES");
		return value;
	}

	public bool ActionIsVisible(Guid actionUid, Guid chapterUid, Guid documentType)
	{
		string key = $"Chapter_{actionUid}_{chapterUid}_{documentType}";
		if (CacheService.TryGetValue<bool>(key, "DOCUMENTACTIONSPROFILES", out var value))
		{
			return value;
		}
		value = (GetByDocumentType(documentType) ?? LoadDefaultSettings())?.ActionIsVisible(chapterUid, actionUid) ?? true;
		CacheService.Insert(key, value, "DOCUMENTACTIONSPROFILES");
		return value;
	}

	public virtual DocumentActionSettingsHolder CreateNew(Guid? documentType = null, Guid? customUid = null)
	{
		DocumentActionSettingsHolder documentActionSettingsHolder = new DocumentActionSettingsHolder();
		List<IDocumentActionProvider> source = ComponentManager.Current.GetExtensionPoints<IDocumentActionProvider>().ToList();
		List<DocumentActionChapterInfo> list = source.SelectMany((IDocumentActionProvider p) => p.Groups).ToList();
		List<DocumentActionInfo> source2 = source.SelectMany((IDocumentActionProvider p) => p.Actions).ToList();
		IDocumentMetadataProfile profile = null;
		if (documentType.HasValue)
		{
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(documentType.Value);
			profile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
		}
		foreach (DocumentActionChapterInfo item in list)
		{
			DocumentActionChapterInfo chapter = item;
			bool value = true;
			if (documentType.HasValue)
			{
				value = (from p in ComponentManager.Current.GetExtensionPoints<IDocumentChapterDefaultVisibility>()
					where p.CheckType(documentType.Value)
					select p).ToList().All((IDocumentChapterDefaultVisibility ch) => ch.CheckVisibility(chapter, profile));
			}
			documentActionSettingsHolder.Chapters.Add(new DocumentChapterState
			{
				ChapterUid = chapter.Uid,
				Visible = value
			});
			foreach (DocumentActionInfo item2 in source2.Where((DocumentActionInfo a) => a.ActionChapterUid == chapter.Uid))
			{
				DocumentActionInfo action = item2;
				bool value2 = true;
				if (documentType.HasValue)
				{
					value2 = (from p in ComponentManager.Current.GetExtensionPoints<IDocumentActionDefaultVisibility>()
						where p.CheckType(documentType.Value)
						select p).ToList().All((IDocumentActionDefaultVisibility ch) => ch.CheckVisibility(action, profile));
				}
				documentActionSettingsHolder.Actions.Add(new DocumentActionState
				{
					ActionUid = action.ActionUid,
					ChapterUid = chapter.Uid,
					Visible = value2
				});
			}
		}
		return documentActionSettingsHolder;
	}

	public virtual void RefreshProfile(DocumentActionSettingsHolder holder, Guid? documentType = null)
	{
		List<IDocumentActionProvider> source = ComponentManager.Current.GetExtensionPoints<IDocumentActionProvider>().ToList();
		List<DocumentActionChapterInfo> list = source.SelectMany((IDocumentActionProvider p) => p.Groups).ToList();
		List<DocumentActionInfo> source2 = source.SelectMany((IDocumentActionProvider p) => p.Actions).ToList();
		IDocumentMetadataProfile profile = null;
		if (documentType.HasValue)
		{
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(documentType.Value);
			profile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
		}
		foreach (DocumentActionChapterInfo item in list)
		{
			DocumentActionChapterInfo chapter = item;
			DocumentChapterState documentChapterState = holder.Chapters.FirstOrDefault((DocumentChapterState c) => c.ChapterUid == chapter.Uid);
			if (documentChapterState == null)
			{
				bool value = true;
				if (documentType.HasValue)
				{
					value = (from p in ComponentManager.Current.GetExtensionPoints<IDocumentChapterDefaultVisibility>()
						where p.CheckType(documentType.Value)
						select p).ToList().All((IDocumentChapterDefaultVisibility ch) => ch.CheckVisibility(chapter, profile));
				}
				documentChapterState = new DocumentChapterState
				{
					ChapterUid = chapter.Uid,
					Visible = value
				};
				holder.Chapters.Add(documentChapterState);
			}
			List<DocumentActionInfo> actions = source2.Where((DocumentActionInfo a) => a.ActionChapterUid == chapter.Uid).ToList();
			foreach (DocumentActionInfo item2 in actions)
			{
				DocumentActionInfo action = item2;
				DocumentActionState documentActionState = holder.Actions.FirstOrDefault((DocumentActionState a) => a.ActionUid == action.ActionUid);
				if (documentActionState != null)
				{
					continue;
				}
				bool value2 = true;
				if (documentType.HasValue)
				{
					value2 = (from p in ComponentManager.Current.GetExtensionPoints<IDocumentActionDefaultVisibility>()
						where p.CheckType(documentType.Value)
						select p).ToList().All((IDocumentActionDefaultVisibility ch) => ch.CheckVisibility(action, profile));
				}
				documentActionState = new DocumentActionState
				{
					ActionUid = action.ActionUid,
					ChapterUid = chapter.Uid,
					Visible = value2
				};
				holder.Actions.Add(documentActionState);
			}
			foreach (DocumentActionState item3 in holder.Actions.Where((DocumentActionState a) => a.ChapterUid == chapter.Uid && actions.All((DocumentActionInfo cha) => cha.ActionUid != a.ActionUid)).ToList())
			{
				holder.Actions.Remove(item3);
			}
		}
	}

	public DocumentActionInfo GetActionInfo(Guid actionuid)
	{
		string key = $"GetActionInfo_{actionuid}";
		if (CacheService.TryGetValue<DocumentActionInfo>(key, "DOCUMENTACTIONSPROFILES", out var value))
		{
			return value;
		}
		value = ComponentManager.Current.GetExtensionPoints<IDocumentActionProvider>().SelectMany((IDocumentActionProvider a) => a.Actions).FirstOrDefault((DocumentActionInfo a) => a.ActionUid == actionuid);
		if (value != null)
		{
			CacheService.Insert(key, value, "DOCUMENTACTIONSPROFILES");
		}
		return value;
	}

	public virtual void ClearCache()
	{
		CacheService.ClearRegion("DOCUMENTACTIONSPROFILES");
	}
}
