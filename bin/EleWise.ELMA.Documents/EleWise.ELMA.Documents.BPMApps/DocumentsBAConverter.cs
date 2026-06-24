using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Documents.Deploy.Export;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.BPMApps;

[Component(Order = 300)]
public class DocumentsBAConverter : IBPMAppItemsConverter
{
	private readonly Guid _exportDocTypesUid = new Guid("{F19C1E62-869B-4FB5-992A-3CECA632C703}");

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		Contract.ArgumentNotNull(bpmAppManifest, "bpmAppManifest");
		Contract.ArgumentNotNull(settings, "settings");
		if (!settings.CustomSettings.TryGetValue(DocumentsExportConsts.ExportExtensionUid, out var value) || !(value is DocumentExportSetting documentExportSetting) || !documentExportSetting.ExportDocTypes || documentExportSetting.DocTypes == null || documentExportSetting.DocTypes.Count == 0)
		{
			return;
		}
		DocumentsBAChapter documentsBAChapter = new DocumentsBAChapter
		{
			Uid = DocumentsExportConsts.ExportExtensionUid
		};
		bpmAppManifest.SetFlag(_exportDocTypesUid, documentExportSetting.ExportDocTypes);
		if (documentExportSetting.ExportDocTypes && documentExportSetting.DocTypes != null)
		{
			documentsBAChapter.DocumentTypes = documentExportSetting.DocTypes.Select((Guid uid) => new DocumentTypeBAItem
			{
				Uid = uid
			}).ToList();
		}
		if (documentExportSetting.ExportDocTypes && documentExportSetting.Profiles != null)
		{
			documentsBAChapter.DocumentProfiles = documentExportSetting.Profiles.Select((KeyValuePair<Guid, bool> p) => new DocumentTypeBAItem
			{
				Uid = p.Key,
				ExportData = p.Value
			}).ToList();
		}
		if (documentsBAChapter.DocumentTypes != null && documentsBAChapter.DocumentTypes.Count > 0)
		{
			bpmAppManifest.SetChapter(documentsBAChapter);
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		Contract.ArgumentNotNull(bpmAppManifest, "bpmAppManifest");
		Contract.ArgumentNotNull(settings, "settings");
		DocumentExportSetting documentExportSetting = new DocumentExportSetting();
		documentExportSetting.ExportDocTypes = bpmAppManifest.GetFlag(_exportDocTypesUid, documentExportSetting.ExportDocTypes);
		DocumentsBAChapter documentsBAChapter = bpmAppManifest.GetChapter(DocumentsExportConsts.ExportExtensionUid) as DocumentsBAChapter;
		if (documentsBAChapter != null && documentsBAChapter.DocumentTypes != null)
		{
			documentExportSetting.DocTypes = documentsBAChapter.DocumentTypes.Select((DocumentTypeBAItem d) => d.Uid).ToList();
		}
		if (documentsBAChapter != null && documentsBAChapter.DocumentProfiles != null)
		{
			documentExportSetting.Profiles = new SerializableDictionary<Guid, bool>();
			foreach (DocumentTypeBAItem documentProfile in documentsBAChapter.DocumentProfiles)
			{
				documentExportSetting.Profiles[documentProfile.Uid] = documentProfile.ExportData;
			}
		}
		settings.CustomSettings[DocumentsExportConsts.ExportExtensionUid] = documentExportSetting;
	}
}
