using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Components;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component(Order = 100000)]
internal sealed class EntityExecuteMetadataExtension : EntityExecuteMetadataExtension<EntityMetadata>
{
	internal static EntityExecuteMetadataExtension Aadq1pEl1NpB4RoCfWSZ;

	public EntityExecuteMetadataExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cxrybvElpSACa7OPRLUi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void cxrybvElpSACa7OPRLUi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool KmEFeFElN6fZmmGtdg3i()
	{
		return Aadq1pEl1NpB4RoCfWSZ == null;
	}

	internal static EntityExecuteMetadataExtension bKBqsPEl3cA44DZsm0DD()
	{
		return Aadq1pEl1NpB4RoCfWSZ;
	}
}
public abstract class EntityExecuteMetadataExtension<T> : EntityMetadataImportExtension<T, TablePartMetadata, EntityMetadata> where T : EntityMetadata
{
	private static readonly ILogger ImportLog;

	private readonly DataClassMetadataImportExtension dataClassMetadataImportExtension;

	private readonly IEntityMetadataDependencyService entityMetadataDependencyService;

	private readonly MetadataItemManager metadataItemManager;

	private readonly IFeatureFlagService featureFlagService;

	internal static object zP62mlElabJ14TiWKq2S;

	private bool SecondRuntimeEnabled => featureFlagService.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978376959), defaultEnabled: false);

	public EntityExecuteMetadataExtension()
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				dataClassMetadataImportExtension = Locator.GetServiceNotNull<DataClassMetadataImportExtension>();
				num = 2;
				break;
			default:
				featureFlagService = Locator.GetServiceNotNull<IFeatureFlagService>();
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				metadataItemManager = Locator.GetServiceNotNull<MetadataItemManager>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			case 4:
				return;
			case 2:
			{
				entityMetadataDependencyService = Locator.GetServiceNotNull<IEntityMetadataDependencyService>();
				int num2 = 3;
				num = num2;
				break;
			}
			}
		}
	}

	protected override IReadMetadataResult ReadMetadata(T metadata, ReadMetadataParameters parameters, bool isTestRead)
	{
		IReadMetadataResult result = base.ReadMetadata(metadata, parameters, isTestRead);
		if (metadata.IsUnique)
		{
			parameters.MetadataNotIsUnique.Remove(metadata.Uid);
			parameters.MetadataNotIsUnique.Remove(metadata.ImplementationUid);
			return result;
		}
		parameters.MetadataNotIsUnique.Add(metadata.Uid);
		parameters.MetadataNotIsUnique.Add(metadata.ImplementationUid);
		return result;
	}

	protected override void SaveMetadata(T mdMerged, ReadMetadataParameters parameters)
	{
		base.SaveMetadata(mdMerged, parameters);
		try
		{
			IMetadataItem metadataItem = metadataItemManager.LoadOrNull(mdMerged.Uid);
			entityMetadataDependencyService.CollectDependencies(mdMerged, metadataItem);
			metadataItem.Save();
		}
		catch (Exception ex)
		{
			parameters.Messages?.Add(new DeployLogMessage(DeployLogMessageType.Warn, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269ABDAC), mdMerged.DisplayName, mdMerged.Name, mdMerged.Uid)));
			ImportLog.Error(ex.Message);
		}
	}

	protected override T GetDraft(T mdImported, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.mdImported = mdImported;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		T val = base.GetDraft(CS_0024_003C_003E8__locals0.mdImported, parameters);
		if (val == null && CS_0024_003C_003E8__locals0.mdImported.Type == EntityMetadataType.InterfaceExtension)
		{
			val = base.MetadataEditorService.GetMetadataList().OfType<T>().FirstOrDefault((T md) => md.Name == CS_0024_003C_003E8__locals0.mdImported.Name && md.TypeUid == CS_0024_003C_003E8__locals0.mdImported.TypeUid && md.BaseClassUid == CS_0024_003C_003E8__locals0.mdImported.BaseClassUid && md.Type == CS_0024_003C_003E8__locals0.mdImported.Type && CS_0024_003C_003E8__locals0._003C_003E4__this.MetadataEditorService.IsConfig(md.Uid));
			if (val != null)
			{
				parameters.MergeReplace.SetUidReplaceMD(CS_0024_003C_003E8__locals0.mdImported.Uid, val.Uid);
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867502261), CS_0024_003C_003E8__locals0.mdImported.Uid, CS_0024_003C_003E8__locals0.mdImported.DisplayName, val.Uid, val.DisplayName, CS_0024_003C_003E8__locals0.mdImported.Name, val.Name)));
			}
		}
		return val;
	}

	protected override void MergeMetadata(T mdImported, T mdMerged, bool isTestRead, ReadMetadataParameters parameters)
	{
		base.MergeMetadata(mdImported, mdMerged, isTestRead, parameters);
		MergeHierarchyProperties(mdImported, mdMerged, isTestRead, parameters);
		if (isTestRead)
		{
			return;
		}
		if (mdImported.ViewModelMetadata != null)
		{
			if (mdMerged.ViewModelMetadata != null)
			{
				dataClassMetadataImportExtension.MergeMetadata(mdImported.ViewModelMetadata, mdMerged.ViewModelMetadata, parameters, isTestRead);
			}
			else
			{
				dataClassMetadataImportExtension.CheckNewMetadata(mdImported.ViewModelMetadata, parameters, isTestRead);
				mdMerged.ViewModelMetadata = mdImported.ViewModelMetadata;
			}
		}
		if (mdImported.CacheEntity)
		{
			mdMerged.CacheEntity = true;
		}
		if (mdImported.Filterable)
		{
			mdMerged.Filterable = true;
		}
		if (mdImported.FilterImplementedInterfaces != null)
		{
			if (mdMerged.FilterImplementedInterfaces == null)
			{
				mdMerged.FilterImplementedInterfaces = mdImported.FilterImplementedInterfaces;
			}
			else
			{
				mdMerged.FilterImplementedInterfaces = mdMerged.FilterImplementedInterfaces.Union(mdImported.FilterImplementedInterfaces).Distinct().ToList();
			}
		}
		if (mdImported.IsSoftDeletable)
		{
			mdMerged.IsSoftDeletable = true;
		}
		if (mdImported.IsUnique)
		{
			mdMerged.IsUnique = true;
		}
		if (mdImported.SaveHistory)
		{
			mdMerged.SaveHistory = true;
		}
		mdMerged.ShowInCatalogList = mdImported.ShowInCatalogList;
		mdMerged.InstancePermissionsSupport = mdImported.InstancePermissionsSupport;
		mdMerged.PermissionsMetadataName = mdImported.PermissionsMetadataName;
		mdMerged.PermissionsPropertyName = mdImported.PermissionsPropertyName;
		MergeMetadataActions(mdImported, mdMerged);
		MergeMetadataFilter(mdImported, mdMerged);
	}

	protected override bool CheckMetadata(T mdImported, T mdDraft, ReadMetadataParameters parameters)
	{
		if (mdImported.ViewModelMetadata != null && !SecondRuntimeEnabled)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A2921D), mdImported.DisplayName, mdImported.Uid)));
			return false;
		}
		if (mdImported.Forms.Any((FormViewItem a) => a.RuntimeVersion == RuntimeVersion.Version2) && !SecondRuntimeEnabled)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A371A34), mdImported.DisplayName, mdImported.Uid)));
			return false;
		}
		bool result = base.CheckMetadata(mdImported, mdDraft, parameters);
		if (mdImported.Uid == mdDraft.Uid && (mdDraft.TableName ?? "") != (mdImported.TableName ?? ""))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210471177), mdImported.DisplayName, mdImported.Uid, mdDraft.DisplayName, mdImported.TableName, mdDraft.TableName, mdDraft.Uid)));
			result = false;
		}
		return result;
	}

	protected override bool TestMetadata(T mdImported, ReadMetadataParameters parameters, bool isTestRead)
	{
		if (mdImported.ViewModelMetadata != null && !SecondRuntimeEnabled)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35772975), mdImported.DisplayName, mdImported.Uid)));
			return false;
		}
		if (mdImported.Forms.Any((FormViewItem a) => a.RuntimeVersion == RuntimeVersion.Version2) && !SecondRuntimeEnabled)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195834601), mdImported.DisplayName, mdImported.Uid)));
			return false;
		}
		bool result = base.TestMetadata(mdImported, parameters, isTestRead);
		if (mdImported.ViewModelMetadata != null)
		{
			EntityMetadataPublicationHandler.UpdateIncludeList(mdImported);
		}
		string messageAdditionalInfo = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099465763), mdImported.DisplayName, mdImported.Uid);
		TestImportMessages testImportMessages = MetadataImportHelper.ValidateEntityTableName(mdImported, mdImported.TableName, messageAdditionalInfo);
		if (testImportMessages != null)
		{
			parameters.TestMessagesAdd(testImportMessages);
			if (testImportMessages.Type == TestImportMessagesType.Error)
			{
				result = false;
			}
		}
		if (isTestRead && !ValidateForm(mdImported, parameters))
		{
			result = false;
		}
		return result;
	}

	protected override bool CheckNewProperty(PropertyMetadata propertyImported, EntityMetadata md, ReadMetadataParameters parameters)
	{
		return base.CheckNewProperty(propertyImported, md, parameters) & CheckRelationTableName(propertyImported, md, parameters);
	}

	protected override bool CheckNewTablePart(TablePartMetadata tablepartImported, EntityMetadata md, ReadMetadataParameters parameters)
	{
		return base.CheckNewTablePart(tablepartImported, md, parameters) & CheckTablePartTableName(tablepartImported, md, parameters);
	}

	private void MergeHierarchyProperties(EntityMetadata mdImported, EntityMetadata mdMerged, bool isTestRead, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_022e, IL_023d, IL_02d4, IL_039f, IL_03ae, IL_03be, IL_043a, IL_0449, IL_06f8, IL_0792, IL_082d, IL_0916, IL_0925, IL_0935, IL_0944, IL_0a02, IL_0a11, IL_0acd, IL_0aed, IL_0afc, IL_0b1f, IL_0b2e, IL_0b3e, IL_0b4d, IL_0b5d, IL_0b6c, IL_0ba1, IL_0bb0, IL_0bfa, IL_0c09, IL_0c18, IL_0ce1, IL_0cf0, IL_0e9c, IL_0ee5, IL_0f05, IL_0f18, IL_0fb4, IL_0fc3, IL_0fd3, IL_0fe2, IL_10ea, IL_10f9, IL_1219
		int num = 29;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		PropertyMetadata propertyMetadata6 = default(PropertyMetadata);
		PropertyMetadata propertyMetadata3 = default(PropertyMetadata);
		PropertyMetadata propertyMetadata4 = default(PropertyMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyMetadata propertyMetadata5 = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 36:
					return;
				case 66:
					if (propertyMetadata2 != null)
					{
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 65;
				case 62:
					_003C_003Ec__DisplayClass14_.mdMerged.HierarchyType = _003C_003Ec__DisplayClass14_.mdImported.HierarchyType;
					num2 = 84;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 85;
					}
					continue;
				case 53:
					if (propertyMetadata6 == null)
					{
						num2 = 33;
						continue;
					}
					goto case 9;
				case 24:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138642522), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata3.DisplayName, propertyMetadata3.Name, propertyMetadata3.Uid)));
					num2 = 32;
					continue;
				case 72:
					_003C_003Ec__DisplayClass14_.mdMerged.Properties.Add(propertyMetadata4);
					num2 = 78;
					continue;
				case 75:
					if (propertyMetadata == null)
					{
						num2 = 76;
						continue;
					}
					goto case 95;
				case 29:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 20;
					}
					continue;
				case 25:
					propertyMetadata = _003C_003Ec__DisplayClass14_.mdMerged.Properties.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CMergeHierarchyProperties_003Eb__2);
					num2 = 84;
					continue;
				case 67:
					_003C_003Ec__DisplayClass14_.mdMerged = mdMerged;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 55;
					}
					continue;
				case 91:
					if (propertyMetadata == null)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 40;
						}
						continue;
					}
					goto case 2;
				case 8:
					if (_003C_003Ec__DisplayClass14_.mdImported.Hierarchical)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 33:
					if (propertyMetadata5 != null)
					{
						num2 = 9;
						continue;
					}
					goto case 19;
				case 51:
					if (!isTestRead)
					{
						num = 72;
						break;
					}
					goto case 1;
				case 60:
					propertyMetadata3 = null;
					num2 = 68;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 46;
					}
					continue;
				case 105:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710335748), _003C_003Ec__DisplayClass14_.mdImported.DisplayName, _003C_003Ec__DisplayClass14_.mdImported.Name, _003C_003Ec__DisplayClass14_.mdImported.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36324071))));
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 35;
					}
					continue;
				case 78:
					_003C_003Ec__DisplayClass14_.mdMerged.IsGroupPropertyUid = propertyMetadata4.Uid;
					num2 = 3;
					continue;
				case 31:
					if (propertyMetadata5 == null)
					{
						num2 = 51;
						continue;
					}
					goto case 56;
				case 54:
					if (!_003C_003Ec__DisplayClass14_.mdImported.Hierarchical)
					{
						num2 = 45;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 5;
				case 95:
					if (_003C_003Ec__DisplayClass14_.mdImported.HierarchyType != 0)
					{
						num2 = 34;
						continue;
					}
					goto case 77;
				case 103:
					if (propertyMetadata3 != null)
					{
						num2 = 24;
						continue;
					}
					goto case 1;
				case 38:
					_003C_003Ec__DisplayClass14_.mdMerged.Properties.Add(propertyMetadata2);
					num2 = 15;
					continue;
				default:
					if (propertyMetadata != null)
					{
						num2 = 37;
						continue;
					}
					goto case 58;
				case 73:
					if (propertyMetadata4 != null)
					{
						num2 = 64;
						continue;
					}
					goto case 12;
				case 101:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16469971), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata5.DisplayName, propertyMetadata5.Name, propertyMetadata5.Uid)));
					num2 = 14;
					continue;
				case 17:
					if (_003C_003Ec__DisplayClass14_.mdImported.Hierarchical)
					{
						num2 = 26;
						continue;
					}
					goto case 49;
				case 2:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420542902), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata.DisplayName, propertyMetadata.Name, propertyMetadata.Uid, propertyMetadata6.DisplayName, propertyMetadata6.Name, propertyMetadata6.Uid)));
					num2 = 74;
					continue;
				case 4:
					_003C_003Ec__DisplayClass14_.mdMerged.Hierarchical = _003C_003Ec__DisplayClass14_.mdImported.Hierarchical;
					num2 = 92;
					continue;
				case 80:
				case 83:
					if (_003C_003Ec__DisplayClass14_.mdMerged.HierarchyType == HierarchyType.Elements)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 1;
				case 21:
				case 43:
				case 45:
					if (!_003C_003Ec__DisplayClass14_.mdMerged.Hierarchical)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 39:
					return;
				case 64:
					if (propertyMetadata2 == null)
					{
						num2 = 53;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto case 104;
				case 1:
				case 3:
				case 14:
				case 18:
				case 32:
				case 34:
				case 35:
				case 61:
				case 63:
				case 74:
				case 79:
				case 93:
				case 96:
				case 98:
				case 102:
					if (!isTestRead)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 13:
					if (propertyMetadata4 == null)
					{
						num2 = 105;
						continue;
					}
					goto case 66;
				case 50:
					if (propertyMetadata6 == null)
					{
						num = 57;
						break;
					}
					goto case 94;
				case 92:
					if (_003C_003Ec__DisplayClass14_.mdImported.Hierarchical)
					{
						num2 = 62;
						continue;
					}
					return;
				case 5:
					if (_003C_003Ec__DisplayClass14_.mdMerged.HierarchyType != 0)
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 80;
						}
						continue;
					}
					goto case 100;
				case 65:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146270597), _003C_003Ec__DisplayClass14_.mdImported.DisplayName, _003C_003Ec__DisplayClass14_.mdImported.Name, _003C_003Ec__DisplayClass14_.mdImported.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426122993))));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 3;
					}
					continue;
				case 26:
					if (propertyMetadata2 == null)
					{
						num2 = 90;
						continue;
					}
					goto case 64;
				case 76:
					if (!isTestRead)
					{
						num2 = 38;
						continue;
					}
					goto case 95;
				case 42:
					if (_003C_003Ec__DisplayClass14_.mdImported.HierarchyType == HierarchyType.GroupAndElements)
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 53;
						}
						continue;
					}
					goto case 1;
				case 85:
					return;
				case 27:
					_003C_003Ec__DisplayClass14_.mdMerged.Properties.Add(propertyMetadata4);
					num2 = 88;
					continue;
				case 12:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979456715), _003C_003Ec__DisplayClass14_.mdImported.DisplayName, _003C_003Ec__DisplayClass14_.mdImported.Name, _003C_003Ec__DisplayClass14_.mdImported.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210762763), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317621824))));
					num2 = 39;
					continue;
				case 40:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87049327), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata6.DisplayName, propertyMetadata6.Name, propertyMetadata6.Uid)));
					num2 = 63;
					continue;
				case 68:
					if (_003C_003Ec__DisplayClass14_.mdMerged.ParentPropertyUid != Guid.Empty)
					{
						num2 = 25;
						continue;
					}
					goto case 48;
				case 56:
				case 99:
					if (propertyMetadata6 == null)
					{
						num2 = 86;
						continue;
					}
					goto case 91;
				case 82:
					if (!isTestRead)
					{
						num = 87;
						break;
					}
					goto case 17;
				case 70:
					if (_003C_003Ec__DisplayClass14_.mdMerged.IsGroupPropertyUid != Guid.Empty)
					{
						num2 = 20;
						continue;
					}
					goto case 44;
				case 22:
				case 84:
					propertyMetadata6 = null;
					num2 = 7;
					continue;
				case 15:
					_003C_003Ec__DisplayClass14_.mdMerged.ParentPropertyUid = propertyMetadata2.Uid;
					num2 = 95;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 12;
					}
					continue;
				case 16:
				case 86:
					if (propertyMetadata5 == null)
					{
						num2 = 102;
						continue;
					}
					goto case 30;
				case 89:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766076300), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata6.DisplayName, propertyMetadata6.Name, propertyMetadata6.Uid)));
					num2 = 18;
					continue;
				case 90:
					if (_003C_003Ec__DisplayClass14_.mdImported.HierarchyType == HierarchyType.GroupAndElements)
					{
						num2 = 73;
						continue;
					}
					goto case 64;
				case 20:
					propertyMetadata6 = _003C_003Ec__DisplayClass14_.mdMerged.Properties.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CMergeHierarchyProperties_003Eb__4);
					num2 = 69;
					continue;
				case 57:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410976867), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata.DisplayName, propertyMetadata.Name, propertyMetadata.Uid)));
					num2 = 93;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 50;
					}
					continue;
				case 104:
					if (_003C_003Ec__DisplayClass14_.mdImported.HierarchyType == HierarchyType.GroupAndElements)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 66;
				case 94:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487099058), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata.DisplayName, propertyMetadata.Name, propertyMetadata.Uid, propertyMetadata6.DisplayName, propertyMetadata6.Name, propertyMetadata6.Uid)));
					num2 = 61;
					continue;
				case 46:
				case 69:
					if (!_003C_003Ec__DisplayClass14_.mdMerged.Hierarchical)
					{
						num2 = 41;
						continue;
					}
					goto case 71;
				case 7:
					propertyMetadata5 = null;
					num2 = 70;
					continue;
				case 6:
					return;
				case 49:
				case 87:
					propertyMetadata = null;
					num2 = 60;
					continue;
				case 77:
					if (propertyMetadata6 != null)
					{
						num2 = 99;
						continue;
					}
					goto case 31;
				case 81:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED8567E), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata6.DisplayName, propertyMetadata6.Name, propertyMetadata6.Uid)));
					num2 = 96;
					continue;
				case 10:
				case 23:
					if (propertyMetadata5 == null)
					{
						num2 = 35;
						continue;
					}
					goto case 101;
				case 59:
					propertyMetadata4 = _003C_003Ec__DisplayClass14_.mdImported.Properties.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CMergeHierarchyProperties_003Eb__1);
					num2 = 79;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 82;
					}
					continue;
				case 88:
					_003C_003Ec__DisplayClass14_.mdMerged.IsGroupPropertyUid = propertyMetadata4.Uid;
					num2 = 98;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 77;
					}
					continue;
				case 28:
					_003C_003Ec__DisplayClass14_.mdImported = mdImported;
					num2 = 67;
					continue;
				case 100:
					if (_003C_003Ec__DisplayClass14_.mdImported.HierarchyType == HierarchyType.Elements)
					{
						num2 = 81;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 80;
				case 9:
				case 97:
					if (propertyMetadata6 == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 89;
				case 58:
					if (propertyMetadata3 != null)
					{
						num2 = 43;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 47;
						}
						continue;
					}
					goto case 75;
				case 19:
					if (isTestRead)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 27;
				case 30:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4260C11D), _003C_003Ec__DisplayClass14_.mdMerged.DisplayName, _003C_003Ec__DisplayClass14_.mdMerged.Name, _003C_003Ec__DisplayClass14_.mdMerged.Uid, propertyMetadata5.DisplayName, propertyMetadata5.Name, propertyMetadata5.Uid)));
					num2 = 72;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 79;
					}
					continue;
				case 71:
					if (_003C_003Ec__DisplayClass14_.mdImported.Hierarchical)
					{
						num = 11;
						break;
					}
					goto case 50;
				case 55:
					propertyMetadata2 = _003C_003Ec__DisplayClass14_.mdImported.Properties.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CMergeHierarchyProperties_003Eb__0);
					num2 = 59;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 15;
					}
					continue;
				case 11:
				case 41:
				case 52:
					if (!_003C_003Ec__DisplayClass14_.mdMerged.Hierarchical)
					{
						num2 = 21;
						continue;
					}
					goto case 54;
				case 37:
				case 47:
					if (propertyMetadata != null)
					{
						num2 = 75;
						continue;
					}
					goto case 103;
				case 48:
					propertyMetadata3 = _003C_003Ec__DisplayClass14_.mdMerged.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106488846));
					num2 = 22;
					continue;
				case 44:
					propertyMetadata5 = _003C_003Ec__DisplayClass14_.mdMerged.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420920266));
					num2 = 46;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool ValidateForm(EntityMetadata entityMetadata, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_0042, IL_0051, IL_005c, IL_00f8, IL_0114, IL_01dd, IL_021d, IL_022c, IL_0238, IL_0247, IL_0273, IL_02cc, IL_02db, IL_0312, IL_0325, IL_0352, IL_03a6, IL_03b5, IL_03c4
		int num = 5;
		int num2 = num;
		bool result = default(bool);
		List<FormViewItem>.Enumerator enumerator = default(List<FormViewItem>.Enumerator);
		FormViewItem current = default(FormViewItem);
		ValidationError current2 = default(ValidationError);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 5:
				result = true;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				obj = null;
				goto IL_03d5;
			case 4:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 3;
			case 6:
			case 7:
				return result;
			case 2:
				enumerator = entityMetadata.Forms.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				{
					obj = entityMetadata.ViewModelMetadata;
					goto IL_03d5;
				}
				IL_03d5:
				if (obj == null)
				{
					num2 = 7;
					continue;
				}
				goto case 2;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 0;
						}
						goto IL_0060;
					}
					goto IL_00a0;
					IL_00a0:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num3 = 3;
					}
					goto IL_0060;
					IL_0060:
					switch (num3)
					{
					case 2:
						break;
					case 1:
						goto IL_00a0;
					case 3:
						try
						{
							IEnumerator<ValidationError> enumerator2 = CheckComponentHelper.CheckComponentViewItems(current, entityMetadata.ViewModelMetadata.Uid, entityMetadata).GetEnumerator();
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									while (true)
									{
										IL_0180:
										int num6;
										if (!enumerator2.MoveNext())
										{
											int num5 = 2;
											num6 = num5;
											goto IL_0122;
										}
										goto IL_0140;
										IL_0122:
										while (true)
										{
											switch (num6)
											{
											case 3:
												break;
											case 1:
												parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, current2.Message));
												num6 = 4;
												continue;
											default:
												goto IL_0180;
											case 4:
												result = false;
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
												{
													num6 = 0;
												}
												continue;
											case 2:
												goto end_IL_0180;
											}
											break;
										}
										goto IL_0140;
										IL_0140:
										current2 = enumerator2.Current;
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
										{
											num6 = 1;
										}
										goto IL_0122;
										continue;
										end_IL_0180:
										break;
									}
								}
								finally
								{
									int num7;
									if (enumerator2 == null)
									{
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
										{
											num7 = 2;
										}
										goto IL_01e1;
									}
									goto IL_01f7;
									IL_01f7:
									enumerator2.Dispose();
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
									{
										num7 = 0;
									}
									goto IL_01e1;
									IL_01e1:
									switch (num7)
									{
									case 2:
										goto end_IL_01bc;
									case 1:
										goto end_IL_01bc;
									}
									goto IL_01f7;
									end_IL_01bc:;
								}
								break;
							case 1:
								break;
							}
						}
						catch (Exception ex)
						{
							int num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								case 1:
									parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, ex.Message));
									num8 = 2;
									continue;
								case 2:
									result = false;
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num8 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num9 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num9 = 0;
				}
				switch (num9)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void MergeMetadataActions(EntityMetadata mdImported, EntityMetadata mdMerged)
	{
		//Discarded unreachable code: IL_009f, IL_0131, IL_01fa, IL_0267, IL_0276, IL_035d, IL_0370, IL_0383, IL_0392
		int num = 2;
		int num2 = num;
		EntityActionsMetadata actions = default(EntityActionsMetadata);
		EntityActionsMetadata actions2 = default(EntityActionsMetadata);
		List<EnumValueMetadata>.Enumerator enumerator = default(List<EnumValueMetadata>.Enumerator);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		int index = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 11:
				if (actions.Values.Count != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				actions = mdImported.Actions;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (actions2.Values.Count != 0)
				{
					num2 = 7;
					break;
				}
				goto case 10;
			case 1:
				if (actions != null)
				{
					num2 = 11;
					break;
				}
				return;
			case 6:
				if (actions2 != null)
				{
					num2 = 4;
					break;
				}
				goto case 10;
			case 10:
				mdMerged.Actions = actions;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				return;
			default:
				actions2 = mdMerged.Actions;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator.MoveNext())
						{
							int num3 = 8;
							num4 = num3;
							goto IL_013f;
						}
						goto IL_02c8;
						IL_013f:
						while (true)
						{
							switch (num4)
							{
							case 8:
								return;
							case 4:
								_003C_003Ec__DisplayClass16_.importedAction = enumerator.Current;
								num4 = 6;
								continue;
							case 7:
							case 12:
								break;
							case 2:
							case 5:
								if (enumValueMetadata != null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 3;
							case 9:
								if (enumValueMetadata != null)
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 13;
							case 13:
								enumValueMetadata = actions2.Values.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CMergeMetadataActions_003Eb__1);
								num4 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num4 = 0;
								}
								continue;
							case 6:
								enumValueMetadata = actions2.Values.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CMergeMetadataActions_003Eb__0);
								num4 = 9;
								continue;
							case 1:
								index = actions2.Values.IndexOf(enumValueMetadata);
								num4 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num4 = 8;
								}
								continue;
							case 3:
								actions2.Values.Add(_003C_003Ec__DisplayClass16_.importedAction);
								num4 = 12;
								continue;
							case 11:
								goto IL_02c8;
							default:
								actions2.Values.Remove(enumValueMetadata);
								num4 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num4 = 7;
								}
								continue;
							case 10:
								actions2.Values.Insert(index, _003C_003Ec__DisplayClass16_.importedAction);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						}
						continue;
						IL_02c8:
						_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
						num4 = 4;
						goto IL_013f;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 5:
				return;
			case 7:
				enumerator = actions.Values.GetEnumerator();
				num2 = 8;
				break;
			}
		}
	}

	private void MergeMetadataFilter(EntityMetadata mdImported, EntityMetadata mdMerged)
	{
		//Discarded unreachable code: IL_0113, IL_0122, IL_0178, IL_0187, IL_01bf, IL_01d0, IL_01df, IL_01ea, IL_0285, IL_034e, IL_035d, IL_03c6, IL_03d9, IL_03e8
		int num = 18;
		int num2 = num;
		EntityFilterMetadata filter = default(EntityFilterMetadata);
		int num3 = default(int);
		EntityFilterMetadata filter2 = default(EntityFilterMetadata);
		List<PropertyMetadata> list = default(List<PropertyMetadata>);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		int index = default(int);
		while (true)
		{
			switch (num2)
			{
			case 12:
				if (filter != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			default:
				num3 = 0;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 3;
				}
				break;
			case 17:
				if (filter2 != null)
				{
					num2 = 2;
					break;
				}
				return;
			case 2:
				if (filter2.Properties.Count != 0)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 11:
				num3++;
				num2 = 7;
				break;
			case 7:
			case 10:
				if (num3 < list.Count)
				{
					num2 = 6;
					break;
				}
				goto case 15;
			case 1:
				return;
			case 9:
				filter = mdMerged.Filter;
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 4;
				}
				break;
			case 18:
				filter2 = mdImported.Filter;
				num2 = 17;
				break;
			case 4:
				mdMerged.Filter = filter2;
				num2 = 14;
				break;
			case 8:
				enumerator = filter2.Properties.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 2;
				}
				break;
			case 16:
				return;
			case 5:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 13;
							goto IL_01ee;
						}
						goto IL_0314;
						IL_01ee:
						while (true)
						{
							switch (num4)
							{
							case 9:
								propertyMetadata = list.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CMergeMetadataFilter_003Eb__2);
								num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num4 = 2;
								}
								continue;
							default:
								propertyMetadata = list.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CMergeMetadataFilter_003Eb__1);
								num4 = 12;
								continue;
							case 4:
							case 10:
								break;
							case 2:
								index = list.IndexOf(propertyMetadata);
								num4 = 8;
								continue;
							case 6:
								_003C_003Ec__DisplayClass17_.importedProp = enumerator.Current;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num4 = 0;
								}
								continue;
							case 5:
								list.Add(_003C_003Ec__DisplayClass17_.importedProp);
								num4 = 4;
								continue;
							case 8:
								list.Insert(index, _003C_003Ec__DisplayClass17_.importedProp);
								num4 = 11;
								continue;
							case 1:
								goto IL_0314;
							case 11:
								list.Remove(propertyMetadata);
								num4 = 10;
								continue;
							case 12:
								if (propertyMetadata != null)
								{
									num4 = 7;
									continue;
								}
								goto case 9;
							case 3:
							case 7:
								if (propertyMetadata != null)
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 5;
							case 13:
								goto end_IL_028f;
							}
							break;
						}
						continue;
						IL_0314:
						_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
						num4 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num4 = 3;
						}
						goto IL_01ee;
						continue;
						end_IL_028f:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 6:
			case 13:
				list[num3].Order = num3;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 11;
				}
				break;
			case 15:
				filter.Properties = list;
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				if (filter.Properties.Count != 0)
				{
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 14:
				return;
			case 19:
				list = filter.Properties.OrderBy((PropertyMetadata p) => p.Order).ToList();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private bool CheckRelationTableName(PropertyMetadata propertyImported, EntityMetadata md, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_0232, IL_0276, IL_0285, IL_0295, IL_03c5, IL_03e5, IL_03f4
		int num = 15;
		bool flag = default(bool);
		string messageAdditionalInfo = default(string);
		TestImportMessages testImportMessages = default(TestImportMessages);
		EntitySettings entitySettings = default(EntitySettings);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
				case 30:
					return !flag;
				case 4:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979452523))));
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 9;
					}
					continue;
				case 13:
					messageAdditionalInfo = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31369452), propertyImported.Uid, md.DisplayName, propertyImported.DisplayName, propertyImported.Name, md.Name, md.Uid);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					testImportMessages = MetadataImportHelper.ValidateTableName(propertyImported.Uid, entitySettings.RelationTableName, default(Guid), messageAdditionalInfo);
					num2 = 2;
					continue;
				case 19:
					flag = true;
					num2 = 17;
					continue;
				case 32:
					flag = true;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 17;
					}
					continue;
				case 18:
					if (testImportMessages == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 31:
					if (entitySettings.RelationType == RelationType.ManyToMany)
					{
						num2 = 13;
						continue;
					}
					goto case 16;
				case 9:
					text = MetadataImportHelper.NewRelationTableName(entitySettings.RelationTableName, propertyImported.Uid, entitySettings);
					num2 = 11;
					continue;
				case 10:
					if (testImportMessages.Type == TestImportMessagesType.Error)
					{
						num = 5;
						break;
					}
					goto case 1;
				case 26:
					parameters.TestMessagesAdd(testImportMessages);
					num2 = 24;
					continue;
				case 27:
					flag = true;
					num2 = 16;
					continue;
				case 11:
					if (string.IsNullOrWhiteSpace(text))
					{
						num2 = 12;
						continue;
					}
					goto case 34;
				case 17:
				case 25:
				case 29:
					testImportMessages = MetadataImportHelper.ValidateFieldName(entitySettings.ChildColumnName);
					num = 28;
					break;
				case 6:
					flag = true;
					num2 = 22;
					continue;
				case 21:
					if (testImportMessages.Type == TestImportMessagesType.Error)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 22;
				case 12:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489114077), propertyImported.Uid, md.DisplayName, text, propertyImported.DisplayName, propertyImported.Name, md.Name, md.Uid)));
					num2 = 19;
					continue;
				case 23:
					entitySettings.RelationTableName = text;
					num2 = 29;
					continue;
				default:
					testImportMessages = MetadataImportHelper.ValidateFieldName(entitySettings.ParentColumnName);
					num = 18;
					break;
				case 24:
					if (testImportMessages.Type == TestImportMessagesType.Error)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto default;
				case 2:
					if (testImportMessages == null)
					{
						num2 = 25;
						continue;
					}
					goto case 7;
				case 5:
					flag = true;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 33;
					}
					continue;
				case 7:
					parameters.TestMessagesAdd(testImportMessages);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 13;
					}
					continue;
				case 22:
					if (testImportMessages.Type == TestImportMessagesType.InfoMetadata)
					{
						num2 = 9;
						continue;
					}
					goto case 17;
				case 14:
					if ((entitySettings = propertyImported.Settings as EntitySettings) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 16;
				case 15:
					flag = false;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 14;
					}
					continue;
				case 34:
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313697CA), propertyImported.Uid, md.DisplayName, text, propertyImported.DisplayName, propertyImported.Name, md.Name, md.Uid)));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 23;
					}
					continue;
				case 3:
					parameters.TestMessagesAdd(testImportMessages);
					num2 = 10;
					continue;
				case 28:
					if (testImportMessages == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 26;
				case 1:
				case 33:
					if (!(entitySettings.ChildColumnName == entitySettings.ParentColumnName))
					{
						num2 = 30;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	private bool CheckTablePartTableName(TablePartMetadata tablepartImported, EntityMetadata md, ReadMetadataParameters parameters)
	{
		int num = 3;
		int num2 = num;
		string messageAdditionalInfo = default(string);
		TestImportMessages testImportMessages = default(TestImportMessages);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 3:
				messageAdditionalInfo = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099470203), tablepartImported.Uid, md.DisplayName, tablepartImported.DisplayName, tablepartImported.Name, md.Name, md.Uid);
				num2 = 2;
				break;
			case 5:
				if (testImportMessages != null)
				{
					num2 = 4;
					break;
				}
				goto IL_0036;
			case 2:
				testImportMessages = MetadataImportHelper.ValidateTableName(tablepartImported.Uid, tablepartImported.TableName, tablepartImported.Uid, messageAdditionalInfo);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (testImportMessages.Type == TestImportMessagesType.Error)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0036;
			case 4:
				{
					parameters.TestMessagesAdd(testImportMessages);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_0036:
				return true;
			}
		}
	}

	static EntityExecuteMetadataExtension()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ImportLog = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35765747));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool AZm93pElD1Wmt492ckAt()
	{
		return zP62mlElabJ14TiWKq2S == null;
	}

	internal static object KDdwucEltLiVLSwJsBIx()
	{
		return zP62mlElabJ14TiWKq2S;
	}
}
