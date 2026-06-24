using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.FullTextSearch;

public class DocumentsFullTextSearchSettings : GlobalSettingsBase, IFullTextSearchModuleSettings
{
	[DisplayName(typeof(__Resources_DocumentsFullTextSearchSettings), "Indexing")]
	public bool Indexing { get; set; }

	[DisplayName(typeof(__Resources_DocumentsFullTextSearchSettings), "IndexingVersion")]
	public bool IndexingVersion { get; set; }

	[DisplayName("SR.M('Причина последней остановки индексирования')")]
	public string IndexingStopInfo { get; set; }

	public DocumentsFullTextSearchSettings()
	{
		Indexing = true;
		IndexingVersion = true;
	}

	public void BindAndSaveToGlobalSettings()
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null)
		{
			if (serviceNotNull.Settings != this)
			{
				serviceNotNull.Settings.Indexing = Indexing;
				serviceNotNull.Settings.IndexingVersion = IndexingVersion;
			}
			serviceNotNull.SaveSettings();
		}
	}
}
[Component]
public class DocumentsFullTextSearchSettingsModule : GlobalSettingsModuleBase<DocumentsFullTextSearchSettings>
{
	public const string ModuleUid = "00FD7E1B-AB79-4699-8EBF-5C2DB9F26DC2";

	public override string ModuleName => SR.T("Индексация документов");

	public override Guid ModuleGuid => Guid.Parse("00FD7E1B-AB79-4699-8EBF-5C2DB9F26DC2");

	public override Permission AdminPermission => PermissionProvider.DocumentsAdminAccessPermission;
}
