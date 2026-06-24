using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Deploy.Export;

[Component(Order = 500)]
public class DocumentsExportExtension : MetadataConfigurationExportExtension
{
	private ExportRuleBuilder<ILifeCycle> customExportRuleBuilderLc = new ExportRuleBuilder<ILifeCycle>(new ExportRuleList());

	private ExportRuleBuilder<IDocumentMetadataHead> customExportRuleBuilderDh = new ExportRuleBuilder<IDocumentMetadataHead>(new ExportRuleList());

	private ExportRuleBuilder<IDocumentMetadataProfile> customExportRuleBuilderDp = new ExportRuleBuilder<IDocumentMetadataProfile>(new ExportRuleList());

	public override Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			DocumentsExportConsts.ExportExtensionUid,
			new DocumentExportSetting()
		} };
	}

	public override void AddExportObjects(ExportExtensionParams parameters)
	{
		AddCustomRules();
		AddExportObjectsCustom(parameters.Parameters, parameters.Objects, parameters.ServiceData, parameters.PacketMetadatas, parameters.PacketEntities);
	}

	private List<IEntity> GetEntities(IDocumentMetadataHead header)
	{
		ExportHelperBuilder<IDocumentMetadataHead> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilderDh.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddCustomRules()
	{
		customExportRuleBuilderLc = new ExportRuleBuilder<ILifeCycle>(new ExportRuleList());
		customExportRuleBuilderLc.Rule().ForPropertyName((ILifeCycle pt) => pt.Statuses).ExportDeep();
		customExportRuleBuilderLc.Rule().ForPropertyName((ILifeCycle pt) => pt.Transitions).ExportDeep();
		customExportRuleBuilderLc.Rule().ForPropertyName((ILifeCycleTransition pt) => pt.Finish).ExportDeep();
		customExportRuleBuilderDh = new ExportRuleBuilder<IDocumentMetadataHead>(new ExportRuleList());
		customExportRuleBuilderDp = new ExportRuleBuilder<IDocumentMetadataProfile>(new ExportRuleList());
		customExportRuleBuilderDp.Rule().ForPropertyName((IDmsObjectDefaultPermissions p) => p.Assigned).Ignore();
		customExportRuleBuilderDp.Rule().ForPropertyName((IDmsObjectDefaultPermissions p) => p.DocumentMetadataProfile).Ignore();
		customExportRuleBuilderDp.Rule().ForPropertyName((IDocumentHistoryProfile p) => p.Chapters).ExportDeep();
		customExportRuleBuilderDp.Rule().ForPropertyName((IDocumentHistoryChapter p) => p.Actions).ExportDeep();
		customExportRuleBuilderDp.Rule().ForPropertyName((IDocumentTemplate p) => p.Profile).Ignore();
	}

	private List<IEntity> GetEntities(ILifeCycle lifeCycle)
	{
		ExportHelperBuilder<ILifeCycle> exportHelperBuilder = ExportHelperBuilder.Create(lifeCycle);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilderLc.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private List<IEntity> GetEntities(IDocumentMetadataProfile profile)
	{
		ExportHelperBuilder<IDocumentMetadataProfile> exportHelperBuilder = ExportHelperBuilder.Create(profile);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilderDp.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<IGroupedMetadata, bool> objects, Dictionary<string, object> serviceData, List<PacketMetadata> packetMetadatas, List<PacketEntity> packetEntities)
	{
		if (!(parameters[DocumentsExportConsts.ExportExtensionUid] is DocumentExportSetting documentExportSetting))
		{
			return;
		}
		bool exportDocTypes = documentExportSetting.ExportDocTypes;
		List<Guid> docTypes = documentExportSetting.DocTypes;
		SerializableDictionary<Guid, bool> profiles = documentExportSetting.Profiles;
		if (!exportDocTypes || docTypes == null)
		{
			return;
		}
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		foreach (Guid item in docTypes)
		{
			IMetadata metadata = serviceNotNull.GetMetadata(item, loadImplementation: false);
			IGroupedMetadata groupedMetadata = metadata as IGroupedMetadata;
			ClassMetadata classMetadata = metadata as ClassMetadata;
			if (metadata == null || groupedMetadata == null || classMetadata == null)
			{
				continue;
			}
			objects.Add(groupedMetadata, value: false);
			PacketMetadata packetMetadata = CreatePacketMetadata(metadata, serviceData);
			ILifeCycle lifeCycle = Locator.GetServiceNotNull<LifeCycleManager>().LoadOrNull(item);
			if (lifeCycle != null)
			{
				foreach (IEntity entity in GetEntities(lifeCycle))
				{
					if (!packetMetadata.SubEntitiesAfter.ContainsKey(entity))
					{
						packetMetadata.SubEntitiesAfter.Add(entity, null);
					}
				}
			}
			bool value = true;
			profiles?.TryGetValue(item, out value);
			if (value)
			{
				IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(item);
				if (documentMetadataProfile != null)
				{
					foreach (IDocumentTemplate item2 in (IEnumerable<IDocumentTemplate>)documentMetadataProfile.Templates)
					{
						switch (item2.TemplateType)
						{
						case DocumentTemplateType.File:
							if (item2.File != null && item2.File.Uid != Guid.Empty)
							{
								string key = $"FileToExport_{item2.File.Uid}_{item2.Uid}";
								if (!serviceData.ContainsKey(key))
								{
									serviceData.Add(key, 2);
								}
							}
							break;
						case DocumentTemplateType.Document:
							if (item2.Document != null && item2.Document.CurrentVersion != null && item2.Document.CurrentVersion.File != null)
							{
								BinaryFile file = item2.Document.CurrentVersion.File;
								string key = $"FileToExport_{file.Uid}_{item2.Uid}";
								if (!serviceData.ContainsKey(key))
								{
									serviceData.Add(key, 2);
								}
							}
							break;
						}
					}
					List<IEntity> entities = GetEntities(documentMetadataProfile);
					PacketEntity packetEntity = new PacketEntity(documentMetadataProfile);
					foreach (IEntity item3 in entities)
					{
						packetEntity.SubEntities.Add(item3);
					}
					packetEntity.ExportRules = customExportRuleBuilderDp.ExportRules;
					packetEntities.Add(packetEntity);
				}
			}
			if (packetMetadata.ExportRules != null)
			{
				packetMetadata.ExportRules.AddRange(customExportRuleBuilderLc.ExportRules);
			}
			else
			{
				packetMetadata.ExportRules = customExportRuleBuilderLc.ExportRules;
			}
			packetMetadatas.Add(packetMetadata);
		}
	}

	private void AddGroupToServiceData(IDocumentMetadataGroup group, ref Dictionary<string, object> serviceData)
	{
		if (group != null && group.ParentGroup != null)
		{
			string key = $"DocumentGroupForDocumentGroup_{group.Uid.ToString().ToLower()}_{group.ParentGroup.Uid.ToString().ToLower()}";
			if (!serviceData.ContainsKey(key))
			{
				serviceData.Add(key, group.ParentGroup.Name);
			}
			AddGroupToServiceData(group.ParentGroup, ref serviceData);
		}
	}

	protected override void AddInfoForUserMetadata(PacketMetadata packetMetadata, IMetadata metadata, Dictionary<string, object> serviceData)
	{
		List<IDocumentMetadataHead> list = DocumentMetadataHeadManager.Instance.Find((IDocumentMetadataHead h) => h.DocumentTypeUid == metadata.Uid).ToList();
		if (list == null || !list.Any() || list[0] == null)
		{
			return;
		}
		IDocumentMetadataHead header = list[0];
		foreach (IEntity entity in GetEntities(header))
		{
			packetMetadata.SubEntitiesAfter.Add(entity, null);
		}
		AddGroupToServiceData(header, ref serviceData);
	}

	protected override void AddInfoForSystemMetadata(PacketMetadata packetMetadata, IMetadata metadata, Dictionary<string, object> serviceData)
	{
		List<IDocumentMetadataHead> list = DocumentMetadataHeadManager.Instance.Find((IDocumentMetadataHead h) => h.DocumentTypeUid == metadata.Uid).ToList();
		if (list != null && list.Any() && list[0] != null)
		{
			IDocumentMetadataHead header = list[0];
			AddGroupToServiceData(header, ref serviceData);
		}
	}

	private void AddGroupToServiceData(IDocumentMetadataHead header, ref Dictionary<string, object> serviceData)
	{
		if (header != null && header.Group != null)
		{
			string key = $"{DocumentsExportConsts.DocumentGroupForDocumentHeaderKey}{header.Uid.ToString().ToLower()}_{header.Group.Uid.ToString().ToLower()}";
			if (!serviceData.ContainsKey(key))
			{
				serviceData.Add(key, header.Group.Name);
			}
			AddGroupToServiceData(header.Group, ref serviceData);
		}
	}
}
