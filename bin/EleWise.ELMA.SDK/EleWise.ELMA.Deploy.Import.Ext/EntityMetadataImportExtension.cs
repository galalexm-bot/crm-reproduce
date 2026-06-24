using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase> : ClassMetadataImportExtension<TMetadata, TCommonBase> where TMetadata : TCommonBase where TTablePart : TCommonBase, ITablePartMetadata where TCommonBase : ITablePartContainer, ClassMetadata, IEntityMetadata
{
	private static readonly ILogger ImportLog;

	internal static object OS2vx4ElwXwD6KVMM2wO;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MetadataItemManager MetadataItemManager
	{
		[CompilerGenerated]
		private get
		{
			return _003CMetadataItemManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IWorkWithFormDependeciesService WorkWithFormDependeciesService
	{
		[CompilerGenerated]
		private get
		{
			return _003CWorkWithFormDependeciesService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CWorkWithFormDependeciesService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ModelManager ModelManager
	{
		[CompilerGenerated]
		private get
		{
			return _003CModelManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CModelManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MetadataItemGroupManager MetadataItemGroupManager
	{
		[CompilerGenerated]
		private get
		{
			return _003CMetadataItemGroupManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CMetadataItemGroupManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override IReadMetadataResult ReadMetadata(TMetadata mdImported, ReadMetadataParameters parameters, bool isTestRead)
	{
		if (!(parameters.ImportSettings is IConfigImportSettings))
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637AD1F9)));
		}
		return base.ReadMetadata(mdImported, parameters, isTestRead);
	}

	protected override void SaveMetadata(TMetadata mdMerged, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.parameters = parameters;
		CS_0024_003C_003E8__locals0.mdMerged = mdMerged;
		CS_0024_003C_003E8__locals0.mdItemBaseDTO = null;
		IMetadataItem metadataItem = MetadataItemManager.LoadOrNull(CS_0024_003C_003E8__locals0.mdMerged.Uid);
		CS_0024_003C_003E8__locals0.mdItemBaseDTO = ((metadataItem != null) ? Mapper.Map<IMetadataItem, MetadataItemDTO>(metadataItem) : new MetadataItemDTO
		{
			Uid = CS_0024_003C_003E8__locals0.mdMerged.Uid
		});
		CS_0024_003C_003E8__locals0.mdItemBaseDTO.Metadata = CS_0024_003C_003E8__locals0.mdMerged;
		MetadataItemDTO mdItemBaseDTO = CS_0024_003C_003E8__locals0.mdItemBaseDTO;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633519163));
		SetScriptModule(mdItemBaseDTO, Expression.Lambda<Func<MetadataItemDTO, ScriptModuleDTO>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), CS_0024_003C_003E8__locals0.parameters);
		MetadataItemDTO mdItemBaseDTO2 = CS_0024_003C_003E8__locals0.mdItemBaseDTO;
		parameterExpression = Expression.Parameter(typeof(MetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103F1CE5));
		SetScriptModule(mdItemBaseDTO2, Expression.Lambda<Func<MetadataItemDTO, ScriptModuleDTO>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), CS_0024_003C_003E8__locals0.parameters);
		string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218190658) + CS_0024_003C_003E8__locals0.mdMerged.GroupId;
		if (CS_0024_003C_003E8__locals0.parameters.ServiceData.TryGetValue(key, out CS_0024_003C_003E8__locals0.tmp))
		{
			long num = 0L;
			if (Guid.TryParse(CS_0024_003C_003E8__locals0.tmp, out var result))
			{
				IMetadataItemGroup metadataItemGroup = MetadataItemGroupManager.LoadOrNull(result);
				if (metadataItemGroup != null)
				{
					num = metadataItemGroup.Id;
				}
			}
			else
			{
				MetadataItemGroupManager metadataItemGroupManager = MetadataItemGroupManager;
				parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867237355));
				IMetadataItemGroup metadataItemGroup2 = metadataItemGroupManager.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass18_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ec__DisplayClass18_0).TypeHandle))), new ParameterExpression[1] { parameterExpression }), FetchOptions.First).FirstOrDefault();
				if (metadataItemGroup2 != null)
				{
					num = metadataItemGroup2.Id;
				}
			}
			if (num == 0L)
			{
				MetadataItemGroupManager metadataItemGroupManager2 = MetadataItemGroupManager;
				parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740318636));
				IMetadataItemGroup metadataItemGroup3 = metadataItemGroupManager2.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x5386503), typeof(string))), new ParameterExpression[1] { parameterExpression }), FetchOptions.First).FirstOrDefault();
				if (metadataItemGroup3 != null)
				{
					num = metadataItemGroup3.Id;
				}
			}
			CS_0024_003C_003E8__locals0.mdItemBaseDTO.HeaderGroupId = num;
			CS_0024_003C_003E8__locals0.mdMerged.GroupId = num;
		}
		CS_0024_003C_003E8__locals0.mdTypeImported = (ImportLog.IsInfoEnabled() ? CS_0024_003C_003E8__locals0.mdMerged.GetType() : null);
		WorkWithFormDependeciesService.Run(delegate
		{
			int num2 = 4;
			int num3 = num2;
			List<MetadataItemDTO> list = default(List<MetadataItemDTO>);
			while (true)
			{
				switch (num3)
				{
				case 2:
					return;
				case 4:
					ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307A5311), CS_0024_003C_003E8__locals0.mdTypeImported.Name, CS_0024_003C_003E8__locals0.mdItemBaseDTO.Uid);
					num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num3 = 3;
					}
					break;
				case 3:
					list = CS_0024_003C_003E8__locals0._003C_003E4__this.ModelManager.SaveMetadataItems(new List<MetadataItemDTO> { CS_0024_003C_003E8__locals0.mdItemBaseDTO });
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num3 = 0;
					}
					break;
				case 5:
					CS_0024_003C_003E8__locals0.parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF8F93), CS_0024_003C_003E8__locals0.mdMerged.Uid, CS_0024_003C_003E8__locals0.mdMerged.DisplayName, CS_0024_003C_003E8__locals0.mdMerged.Name), endProcess: false));
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num3 = 1;
					}
					break;
				default:
					ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420529620), CS_0024_003C_003E8__locals0.mdTypeImported.Name, CS_0024_003C_003E8__locals0.mdItemBaseDTO.Uid);
					num3 = 5;
					break;
				case 1:
					CS_0024_003C_003E8__locals0.parameters.Headers.Add(list[0].HeaderId);
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num3 = 2;
					}
					break;
				}
			}
		});
	}

	protected override void MergeMetadataProperties(TCommonBase mdImported, TCommonBase mdDraft, ReadMetadataParameters parameters)
	{
		base.MergeMetadataProperties(mdImported, mdDraft, parameters);
		List<ITablePartMetadata> list = mdDraft.TableParts.ToList();
		using (IEnumerator<TTablePart> enumerator = mdImported.TableParts.Cast<TTablePart>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
				CS_0024_003C_003E8__locals0.tablepartImported = enumerator.Current;
				TTablePart val;
				try
				{
					val = (TTablePart)list.SingleOrDefault((ITablePartMetadata b) => b.Uid == CS_0024_003C_003E8__locals0.tablepartImported.Uid);
				}
				catch (InvalidOperationException)
				{
					continue;
				}
				if (val != null && (CS_0024_003C_003E8__locals0.tablepartImported.Name != val.Name || CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyName != val.TablePartPropertyName))
				{
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103B11A9), mdDraft.Name, CS_0024_003C_003E8__locals0.tablepartImported.Uid, val.Uid, mdDraft.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, val.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyName, val.TablePartPropertyName)));
				}
				if (val == null)
				{
					try
					{
						val = (TTablePart)list.SingleOrDefault(delegate(ITablePartMetadata b)
						{
							int num = 1;
							int num2 = num;
							while (true)
							{
								switch (num2)
								{
								default:
									return b.TablePartPropertyName == CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyName;
								case 1:
									if (!(b.Name == CS_0024_003C_003E8__locals0.tablepartImported.Name))
									{
										return false;
									}
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num2 = 0;
									}
									break;
								}
							}
						});
					}
					catch (InvalidOperationException)
					{
						continue;
					}
					if (val != null)
					{
						parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E8EDE3), mdDraft.Name, CS_0024_003C_003E8__locals0.tablepartImported.Uid, val.Uid, mdDraft.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, val.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyName, val.TablePartPropertyName)));
					}
				}
				if (val != null)
				{
					MergeMetadataProperties((TCommonBase)CS_0024_003C_003E8__locals0.tablepartImported, (TCommonBase)val, parameters);
					parameters.MergeReplace.SetUidReplaceMD(CS_0024_003C_003E8__locals0.tablepartImported.Uid, val.Uid);
					parameters.MergeReplace.SetUidReplaceProperty(mdImported.Uid, CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyUid, val.TablePartPropertyUid);
					parameters.MergeReplace.SetNameReplaceProperty(mdImported.Uid, CS_0024_003C_003E8__locals0.tablepartImported.Name, val.Name);
					val.DisplayName = CS_0024_003C_003E8__locals0.tablepartImported.DisplayName;
					val.Name = CS_0024_003C_003E8__locals0.tablepartImported.Name;
					val.TablePartPropertyName = CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyName;
					val.Properties = val.Properties;
					ITablePartContainer tablePartContainer = val;
					ITablePartContainer tablepartImported = CS_0024_003C_003E8__locals0.tablepartImported;
					if (tablePartContainer != null && tablepartImported != null)
					{
						tablePartContainer.TableParts = tablepartImported.TableParts;
					}
					val.Description = CS_0024_003C_003E8__locals0.tablepartImported.Description;
					ClassMetadata classMetadata = val;
					ClassMetadata tablepartImported2 = CS_0024_003C_003E8__locals0.tablepartImported;
					if (classMetadata != null && tablepartImported2 != null)
					{
						classMetadata.ScriptModuleTypeName = tablepartImported2.ScriptModuleTypeName;
					}
				}
				else if (CheckNewTablePart(CS_0024_003C_003E8__locals0.tablepartImported, mdDraft, parameters))
				{
					CheckMetadataProperties((TCommonBase)CS_0024_003C_003E8__locals0.tablepartImported, isTestRead: false, parameters);
					list.Add(CS_0024_003C_003E8__locals0.tablepartImported);
				}
			}
		}
		mdDraft.TableParts = list;
	}

	protected override void CheckMetadataProperties(TCommonBase mdImported, bool isTestRead, ReadMetadataParameters parameters)
	{
		base.CheckMetadataProperties(mdImported, isTestRead, parameters);
		TTablePart[] array = mdImported.TableParts.Cast<TTablePart>().ToArray();
		foreach (TTablePart val in array)
		{
			if (CheckNewTablePart(val, mdImported, parameters))
			{
				CheckMetadataProperties((TCommonBase)val, isTestRead, parameters);
			}
			else if (!isTestRead)
			{
				mdImported.TableParts.Remove(val);
			}
		}
	}

	protected override bool CheckNewProperty(PropertyMetadata propertyImported, TCommonBase md, ReadMetadataParameters parameters)
	{
		bool result = base.CheckNewProperty(propertyImported, md, parameters);
		if (propertyImported.Name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867793646), StringComparison.CurrentCultureIgnoreCase))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69787831), propertyImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463EB582), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867832790)), propertyImported.DisplayName, propertyImported.Name, md.Name, md.Uid)));
			result = false;
		}
		return result;
	}

	protected virtual bool CheckNewTablePart(TTablePart tablepartImported, TCommonBase md, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.tablepartImported = tablepartImported;
		string message = "";
		bool flag = false;
		if (!MetadataImportHelper.CheckPropertyDisplayName(((IEnumerable<IMetadata>)GetProperties(md)).ToList(), CS_0024_003C_003E8__locals0.tablepartImported, CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, out message))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951193510), CS_0024_003C_003E8__locals0.tablepartImported.Uid, md.DisplayName, message, CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.Name, md.Name, md.Uid)));
			flag = true;
		}
		if (!MetadataImportHelper.CheckPropertyName(((IEnumerable<IMetadata>)GetProperties(md)).ToList(), CS_0024_003C_003E8__locals0.tablepartImported, md.Name, CS_0024_003C_003E8__locals0.tablepartImported.TablePartPropertyName, out message))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767489465), CS_0024_003C_003E8__locals0.tablepartImported.Uid, md.DisplayName, message, CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.Name, md.Name, md.Uid)));
			flag = true;
		}
		if (CS_0024_003C_003E8__locals0.tablepartImported.Name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51158343), StringComparison.CurrentCultureIgnoreCase))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243FB36), CS_0024_003C_003E8__locals0.tablepartImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FB71E7), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398522054)), CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.Name, md.Name, md.Uid)));
			flag = true;
		}
		if (md.TableParts.Any(delegate(ITablePartMetadata p)
		{
			//Discarded unreachable code: IL_0086, IL_0095
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(p.Uid != CS_0024_003C_003E8__locals0.tablepartImported.Uid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return p.Name.Equals(CS_0024_003C_003E8__locals0.tablepartImported.Name, StringComparison.CurrentCultureIgnoreCase);
				default:
					return false;
				}
			}
		}))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637AD027), CS_0024_003C_003E8__locals0.tablepartImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69749596)), CS_0024_003C_003E8__locals0.tablepartImported.DisplayName, CS_0024_003C_003E8__locals0.tablepartImported.Name, md.Name, md.Uid)));
			flag = true;
		}
		TestImportMessages testImportMessages = MetadataImportHelper.ValidateObjectTablePartName(md, CS_0024_003C_003E8__locals0.tablepartImported.Name, CS_0024_003C_003E8__locals0.tablepartImported.Uid);
		if (testImportMessages != null)
		{
			parameters.TestMessagesAdd(testImportMessages);
			flag = true;
		}
		return !flag;
	}

	protected override IEnumerable<IPropertyMetadata> GetProperties(TCommonBase md)
	{
		return ((IEnumerable<IPropertyMetadata>)md.Properties).Concat((IEnumerable<IPropertyMetadata>)md.TableParts);
	}

	protected EntityMetadataImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityMetadataImportExtension()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				ImportLog = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A65B660));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool doTHW9El46GqGORSPubx()
	{
		return OS2vx4ElwXwD6KVMM2wO == null;
	}

	internal static object P9j36wEl6k6KbrQHDY2i()
	{
		return OS2vx4ElwXwD6KVMM2wO;
	}
}
