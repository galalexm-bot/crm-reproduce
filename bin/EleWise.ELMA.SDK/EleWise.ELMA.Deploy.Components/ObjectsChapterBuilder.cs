using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component(Order = 200)]
internal sealed class ObjectsChapterBuilder : MetadataHeaderChapterBuilder
{
	private readonly DataClassMetadataItemHeaderManager dataClassService;

	private readonly ISecurityService securityService;

	private static ObjectsChapterBuilder QNvvooEc8tZbApU1bLTr;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(ObjectsExportConsts.ExportExtensionUidEntity, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521524360)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B33A159)),
		new BPMAppChapterBuilderTemplate(ObjectsExportConsts.ExportExtensionUidEnum, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710735478)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CE4C1B)),
		new BPMAppChapterBuilderTemplate(ObjectsExportConsts.ExportExtensionUidDataClass, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317642102)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751506512))
	};

	public ObjectsChapterBuilder(IMetadataRuntimeService metadataService, MetadataItemHeaderManager metadataItemHeaderManager, DataClassMetadataItemHeaderManager dataClassService, ISecurityService securityService)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		QK1Z6gEcIBcNHouQJAJD();
		base._002Ector(metadataService, metadataItemHeaderManager);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.securityService = securityService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.dataClassService = dataClassService;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334975991));
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUidEntity = ObjectsExportConsts.ExportExtensionUidEntity;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUidEntity.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF7173)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C54C2B));
		exportExtensionUidEntity = ObjectsExportConsts.ExportExtensionUidEnum;
		DeployTreeNode deployTreeNode2 = CreateNode(exportExtensionUidEntity.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088207720)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104870478));
		exportExtensionUidEntity = ObjectsExportConsts.ExportExtensionUidDataClass;
		DeployTreeNode deployTreeNode3 = CreateNode(exportExtensionUidEntity.ToString(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A7A9B5)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138629720));
		if (!(manifest.GetChapter(ObjectsExportConsts.ExportExtensionUid) is ObjectsBAChapter objectsBAChapter) || ((objectsBAChapter.Catalogs == null || objectsBAChapter.Catalogs.Count == 0) && (objectsBAChapter.SysCatalogs == null || objectsBAChapter.SysCatalogs.Count == 0) && (objectsBAChapter.Enums == null || objectsBAChapter.Enums.Count == 0) && (objectsBAChapter.DataClasses == null || objectsBAChapter.DataClasses.Count == 0)))
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
				list.Add(deployTreeNode2);
				list.Add(deployTreeNode3);
			}
			return list;
		}
		List<DeployTreeNode> list2 = new List<DeployTreeNode>();
		if (objectsBAChapter.Catalogs != null)
		{
			list2.AddRange(GetNodes(objectsBAChapter.Catalogs, (BPMAppManifestItem bpmAppManifestItem, string displayName) => GetNodeName(bpmAppManifestItem, displayName, withData: true)));
		}
		if (objectsBAChapter.SysCatalogs != null)
		{
			list2.AddRange(GetNodes(objectsBAChapter.SysCatalogs, isSystemObject: true, (BPMAppManifestItem bpmAppManifestItem, string displayName) => GetNodeName(bpmAppManifestItem, displayName, withData: false)));
		}
		if (parameters.WithEmptyChapters || list2.Count > 0)
		{
			deployTreeNode.Children.AddRange(list2.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.YZyEGn8y8tFIRQfJUoQO(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = deployTreeNode.Children.Count;
			list.Add(deployTreeNode);
		}
		List<DeployTreeNode> list3 = new List<DeployTreeNode>();
		if (objectsBAChapter.Enums != null)
		{
			list3.AddRange(GetNodes(objectsBAChapter.Enums));
		}
		if (parameters.WithEmptyChapters || list3.Count > 0)
		{
			deployTreeNode2.Children.AddRange(list3.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.YZyEGn8y8tFIRQfJUoQO(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode2.Count = deployTreeNode2.Children.Count;
			list.Add(deployTreeNode2);
		}
		List<DeployTreeNode> list4 = new List<DeployTreeNode>();
		if (objectsBAChapter.DataClasses != null)
		{
			list4.AddRange(GetDataClassNodes(objectsBAChapter.DataClasses));
		}
		if (parameters.WithEmptyChapters || list4.Count > 0)
		{
			deployTreeNode3.Children.AddRange(list4.OrderBy((DeployTreeNode n) => (string)_003C_003Ec.YZyEGn8y8tFIRQfJUoQO(n), StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode3.Count = deployTreeNode3.Children.Count;
			list.Add(deployTreeNode3);
		}
		return list;
	}

	private string GetNodeName(BPMAppManifestItem item, string displayName, bool withData)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_005b
		int num = 6;
		int num2 = num;
		EntityBAItem entityBAItem = default(EntityBAItem);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (entityBAItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				if (withData)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 4;
			default:
				if (!entityBAItem.ExportData)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			case 6:
				entityBAItem = item as EntityBAItem;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710339100), displayName);
			case 1:
				return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E8F7B4), displayName);
			case 3:
				break;
			}
			break;
		}
		return displayName;
	}

	private ICollection<DeployTreeNode> GetDataClassNodes(IEnumerable<DataClassBAItem> items)
	{
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		using IEnumerator<DataClassBAItem> enumerator = items.GetEnumerator();
		_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0;
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
			_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
			_003C_003Ec__DisplayClass7_.item = enumerator.Current;
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass7_;
				CS_0024_003C_003E8__locals0.header = null;
				securityService.RunWithElevatedPrivilegies(delegate
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							CS_0024_003C_003E8__locals0.header = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.dataClassService.LoadOrNull(_003C_003Ec__DisplayClass7_1.mLGZtX8yKFhGL1b2CxRP(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.item));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
				if (CS_0024_003C_003E8__locals0.header != null)
				{
					list.Add(CreateNode(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.item.Uid.ToString(), CS_0024_003C_003E8__locals0.header.DisplayName, "", CS_0024_003C_003E8__locals0.header.IsDirtyItem, CS_0024_003C_003E8__locals0.header.Published != null));
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675703849) + _003C_003Ec__DisplayClass7_.item.Uid, exception);
			}
		}
		return list;
	}

	internal static void QK1Z6gEcIBcNHouQJAJD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bFtB5lEcZKEQ3rtTpOia()
	{
		return QNvvooEc8tZbApU1bLTr == null;
	}

	internal static ObjectsChapterBuilder h4EZBiEcumCtsGnMaFlv()
	{
		return QNvvooEc8tZbApU1bLTr;
	}
}
