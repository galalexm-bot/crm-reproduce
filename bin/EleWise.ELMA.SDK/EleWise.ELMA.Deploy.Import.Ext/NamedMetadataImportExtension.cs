using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class NamedMetadataImportExtension<T> : IConfigImportActionExtension where T : NamedMetadata
{
	private sealed class ReadMetadataResult : IReadMetadataResult
	{
		private readonly T mdMerged;

		private readonly ReadMetadataParameters parameters;

		private readonly bool isTestRead;

		private readonly NamedMetadataImportExtension<T> importExtension;

		private static object YMBAkY8AAE0y2FTylHHP;

		IMetadata IReadMetadataResult.Metadata => mdMerged;

		public ReadMetadataResult(T mdMerged, ReadMetadataParameters parameters, bool isTestRead, NamedMetadataImportExtension<T> importExtension)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.mdMerged = mdMerged;
			this.parameters = parameters;
			this.isTestRead = isTestRead;
			this.importExtension = importExtension;
		}

		public bool TestMetadata()
		{
			return importExtension.TestMetadata(mdMerged, parameters, isTestRead);
		}

		public void SaveMetadata()
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
					importExtension.SaveMetadata(mdMerged, parameters);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool Sf275G8A7s7GCD1eR1yQ()
		{
			return YMBAkY8AAE0y2FTylHHP == null;
		}

		internal static object LIWkuR8Axn1Cw2cumikE()
		{
			return YMBAkY8AAE0y2FTylHHP;
		}
	}

	private static object x7QID5El21aAyqENoiUC;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IEnumerable<IMetadataImport> MetadataImports { private get; set; }

	internal IMetadataService MetadataService => MetadataServiceContext.Service;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IMetadataRuntimeService MetadataRuntimeService
	{
		[CompilerGenerated]
		internal get
		{
			return _003CMetadataRuntimeService_003Ek__BackingField;
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
					_003CMetadataRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IMetadataEditorService MetadataEditorService
	{
		[CompilerGenerated]
		internal get
		{
			return _003CMetadataEditorService_003Ek__BackingField;
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
					_003CMetadataEditorService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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
	public ScriptModuleManager ScriptModuleManager
	{
		[CompilerGenerated]
		internal get
		{
			return _003CScriptModuleManager_003Ek__BackingField;
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
					_003CScriptModuleManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual void OnPreStartTest(PreStartTestImportParameters parameters)
	{
	}

	IReadMetadataResult IConfigImportActionExtension.OnReadMetadata(ReadMetadataParameters parameters, bool isTestRead)
	{
		//Discarded unreachable code: IL_0071, IL_0080
		int num = 2;
		int num2 = num;
		T mdImported = default(T);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return ReadMetadata(mdImported, parameters, isTestRead);
			case 2:
				if ((mdImported = parameters.Metadata as T) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual void OnPrePublish(PrePublishParameters parameters)
	{
	}

	public virtual void OnPostPublish(PostPublishParameters parameters)
	{
	}

	protected virtual IReadMetadataResult ReadMetadata(T mdImported, ReadMetadataParameters parameters, bool isTestRead)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.mdImported = mdImported;
		CS_0024_003C_003E8__locals0.parameters = parameters;
		CS_0024_003C_003E8__locals0.parameters.Messages.Add(new DeployLogMessage(BPMAppItemImportStatus.InProgress, CS_0024_003C_003E8__locals0.mdImported.Uid, CS_0024_003C_003E8__locals0.parameters.TreeUid));
		if (isTestRead && (CS_0024_003C_003E8__locals0.configImportSettings = CS_0024_003C_003E8__locals0.parameters.ImportSettings as IConfigImportSettings) != null && CS_0024_003C_003E8__locals0.configImportSettings.FakeManifest != null)
		{
			MetadataImports.ForEach(delegate(IMetadataImport e)
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
						e.CreateFakeChapter(CS_0024_003C_003E8__locals0.mdImported, CS_0024_003C_003E8__locals0.configImportSettings.FakeManifest, CS_0024_003C_003E8__locals0.parameters.ManifestExecuteMetadata);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		if (!CheckSystemMetadata(CS_0024_003C_003E8__locals0.mdImported, CS_0024_003C_003E8__locals0.parameters, isTestRead))
		{
			return null;
		}
		T draft = GetDraft(CS_0024_003C_003E8__locals0.mdImported, CS_0024_003C_003E8__locals0.parameters);
		if (draft == null)
		{
			CheckNewMetadata(CS_0024_003C_003E8__locals0.mdImported, isTestRead, CS_0024_003C_003E8__locals0.parameters);
			draft = CS_0024_003C_003E8__locals0.mdImported;
		}
		else
		{
			draft = ClassSerializationHelper.CloneObjectByXml(draft);
			if (!CheckMetadata(CS_0024_003C_003E8__locals0.mdImported, draft, CS_0024_003C_003E8__locals0.parameters))
			{
				return null;
			}
			MergeMetadata(CS_0024_003C_003E8__locals0.mdImported, draft, isTestRead, CS_0024_003C_003E8__locals0.parameters);
		}
		CS_0024_003C_003E8__locals0.parameters.MetadataNotIsUnique.Add(CS_0024_003C_003E8__locals0.mdImported.Uid);
		return new ReadMetadataResult(draft, CS_0024_003C_003E8__locals0.parameters, isTestRead, this);
	}

	protected virtual bool CheckSystemMetadata(T mdImported, ReadMetadataParameters parameters, bool isTestRead)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals0.mdImported = mdImported;
		T val = MetadataRuntimeService.GetMetadataList().FirstOrDefault((IMetadata md) => md.Uid == CS_0024_003C_003E8__locals0.mdImported.Uid) as T;
		if (parameters.IsSystemMetadata)
		{
			if (val == null)
			{
				if (!isTestRead || MetadataService.GetMetadataList().All((IMetadata md) => md.Uid != CS_0024_003C_003E8__locals0.mdImported.Uid))
				{
					parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C904F2C), CS_0024_003C_003E8__locals0.mdImported.Name, CS_0024_003C_003E8__locals0.mdImported.Uid, CS_0024_003C_003E8__locals0.mdImported.DisplayName)));
				}
				if (!isTestRead)
				{
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97661976)));
				}
			}
			else if (!val.IsSystem())
			{
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2022C615), CS_0024_003C_003E8__locals0.mdImported.Name, CS_0024_003C_003E8__locals0.mdImported.Uid, val.DisplayName, CS_0024_003C_003E8__locals0.mdImported.DisplayName, val.Name, val.Uid)));
			}
			else if (val.Name != CS_0024_003C_003E8__locals0.mdImported.Name)
			{
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548F73F6), CS_0024_003C_003E8__locals0.mdImported.Uid, CS_0024_003C_003E8__locals0.mdImported.Name, val.Name, CS_0024_003C_003E8__locals0.mdImported.DisplayName, val.DisplayName, val.Uid)));
			}
			else if (val.GetType() != CS_0024_003C_003E8__locals0.mdImported.GetType())
			{
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477383850), CS_0024_003C_003E8__locals0.mdImported.Uid, CS_0024_003C_003E8__locals0.mdImported.Name, val.Name, CS_0024_003C_003E8__locals0.mdImported.DisplayName, val.DisplayName, val.Uid)));
			}
			return false;
		}
		if (val != null && val.IsSystem())
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138399266), CS_0024_003C_003E8__locals0.mdImported.DisplayName, CS_0024_003C_003E8__locals0.mdImported.Uid, val.DisplayName, CS_0024_003C_003E8__locals0.mdImported.Name, val.Name, val.Uid)));
			return false;
		}
		return true;
	}

	protected virtual T GetDraft(T mdImported, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.mdImported = mdImported;
		return MetadataEditorService.GetMetadataList().FirstOrDefault((IMetadata md) => md.Uid == CS_0024_003C_003E8__locals0.mdImported.Uid) as T;
	}

	protected virtual bool TestMetadata(T mdMerged, ReadMetadataParameters parameters, bool isTestRead)
	{
		TestImportMessages testImportMessages = MetadataImportHelper.ValidateObjectName(mdMerged, mdMerged.Name);
		if (testImportMessages != null)
		{
			parameters.TestMessagesAdd(testImportMessages);
			if (testImportMessages.Type == TestImportMessagesType.Error)
			{
				return false;
			}
		}
		return true;
	}

	protected abstract void SaveMetadata(T mdMerged, ReadMetadataParameters parameters);

	internal void SetScriptModule<TMetadataItem>(TMetadataItem metadataItem, Expression<Func<TMetadataItem, ScriptModule>> propertyExpression, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass27_0<TMetadataItem> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0<TMetadataItem>();
		CS_0024_003C_003E8__locals0.metadataItem = metadataItem;
		CS_0024_003C_003E8__locals0.scriptModulePropertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
		SetScriptModule(CS_0024_003C_003E8__locals0.scriptModulePropertyInfo.Name, () => (IScriptModule)CS_0024_003C_003E8__locals0.scriptModulePropertyInfo.GetValue(CS_0024_003C_003E8__locals0.metadataItem), delegate(ScriptModule scriptModule)
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
					CS_0024_003C_003E8__locals0.scriptModulePropertyInfo.SetValue(CS_0024_003C_003E8__locals0.metadataItem, scriptModule);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}, parameters);
	}

	internal void SetScriptModule<TMetadataItem>(TMetadataItem metadataItem, Expression<Func<TMetadataItem, ScriptModuleDTO>> propertyExpression, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass28_0<TMetadataItem> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0<TMetadataItem>();
		CS_0024_003C_003E8__locals0.metadataItem = metadataItem;
		CS_0024_003C_003E8__locals0.scriptModulePropertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
		SetScriptModule(CS_0024_003C_003E8__locals0.scriptModulePropertyInfo.Name, () => (IScriptModule)CS_0024_003C_003E8__locals0.scriptModulePropertyInfo.GetValue(CS_0024_003C_003E8__locals0.metadataItem), delegate(ScriptModule scriptModule)
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
					CS_0024_003C_003E8__locals0.scriptModulePropertyInfo.SetValue(CS_0024_003C_003E8__locals0.metadataItem, (scriptModule != null) ? Mapper.Map<ScriptModule, ScriptModuleDTO>(scriptModule, new ScriptModuleDTO()) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}, parameters);
	}

	private void SetScriptModule(string scriptModulePropertyName, Func<IScriptModule> getOriginalScriptModuleFunc, Action<ScriptModule> setScriptModuleAction, ReadMetadataParameters parameters)
	{
		if (parameters.Attributes.TryGetValue(scriptModulePropertyName, out var value) && Guid.TryParse(value.First(), out var result))
		{
			ScriptModule scriptModule = ((result != Guid.Empty) ? ScriptModuleManager.LoadOrNull(result) : null);
			IScriptModule scriptModule2 = ((scriptModule != null) ? getOriginalScriptModuleFunc() : null);
			if (scriptModule2 != null && scriptModule2.SourceCode != null && scriptModule2.Uid != result)
			{
				string arg = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858663845), scriptModule2.SourceCode.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217524067), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A84F75), Environment.NewLine)));
				scriptModule.SourceCode = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C57D82F), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767483123)), arg, scriptModule.SourceCode);
			}
			setScriptModuleAction(scriptModule);
		}
	}

	protected virtual void MergeMetadata(T mdImported, T mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		if (!isTestRead)
		{
			mdDraft.DisplayName = mdImported.DisplayName;
			mdDraft.Description = mdImported.Description;
			if (mdImported.Images != null && mdImported.Images.Count > 0)
			{
				mdDraft.Images = mdImported.Images;
			}
			MergeMetadataNamedImages(mdImported, mdDraft);
		}
	}

	protected virtual void CheckNewMetadata(T mdImported, bool isTestRead, ReadMetadataParameters parameters)
	{
	}

	protected virtual bool CheckMetadata(T mdImported, T mdDraft, ReadMetadataParameters parameters)
	{
		bool result = true;
		if (mdDraft.Name != mdImported.Name)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146272749), mdImported.DisplayName, mdImported.Uid, mdDraft.DisplayName, mdImported.Name, mdDraft.Name, mdDraft.Uid)));
			result = false;
		}
		return result;
	}

	private void MergeMetadataNamedImages(NamedMetadata mdImported, NamedMetadata mdDraft)
	{
		//Discarded unreachable code: IL_0060, IL_00ad, IL_00bc, IL_014e, IL_015d, IL_0211, IL_0224, IL_0233, IL_0268, IL_0277
		int num = 1;
		int num2 = num;
		List<NamedImageMetadata> namedImages = default(List<NamedImageMetadata>);
		List<NamedImageMetadata>.Enumerator enumerator = default(List<NamedImageMetadata>.Enumerator);
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = default(_003C_003Ec__DisplayClass33_0);
		List<NamedImageMetadata> namedImages2 = default(List<NamedImageMetadata>);
		int index = default(int);
		NamedImageMetadata namedImageMetadata = default(NamedImageMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 10:
				mdDraft.NamedImages = namedImages;
				num2 = 9;
				continue;
			case 5:
				try
				{
					while (true)
					{
						IL_01bf:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num3 = 0;
							}
							goto IL_006e;
						}
						goto IL_0179;
						IL_0179:
						_003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
						num3 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num3 = 7;
						}
						goto IL_006e;
						IL_006e:
						while (true)
						{
							switch (num3)
							{
							case 11:
								_003C_003Ec__DisplayClass33_.importedImage = enumerator.Current;
								num3 = 4;
								continue;
							case 1:
							{
								namedImages2.Insert(index, _003C_003Ec__DisplayClass33_.importedImage);
								int num4 = 10;
								num3 = num4;
								continue;
							}
							case 10:
								namedImages2.Remove(namedImageMetadata);
								num3 = 9;
								continue;
							case 6:
							case 8:
								namedImages2.Add(_003C_003Ec__DisplayClass33_.importedImage);
								num3 = 2;
								continue;
							case 4:
								namedImageMetadata = namedImages2.FirstOrDefault(_003C_003Ec__DisplayClass33_._003CMergeMetadataNamedImages_003Eb__0);
								num3 = 3;
								continue;
							case 3:
								if (namedImageMetadata == null)
								{
									num3 = 6;
									continue;
								}
								goto default;
							case 7:
								break;
							default:
								index = namedImages2.IndexOf(namedImageMetadata);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
							case 9:
								goto IL_01bf;
							case 5:
								return;
							}
							break;
						}
						goto IL_0179;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 6:
				if (namedImages2 == null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 9:
				return;
			default:
				if (namedImages != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 8:
				return;
			case 4:
				return;
			case 2:
				if (namedImages.Count != 0)
				{
					namedImages2 = mdDraft.NamedImages;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 8;
				}
				continue;
			case 1:
				namedImages = mdImported.NamedImages;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				break;
			}
			if (namedImages2.Count != 0)
			{
				enumerator = namedImages.GetEnumerator();
				num2 = 5;
			}
			else
			{
				num2 = 10;
			}
		}
	}

	protected NamedMetadataImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xaulOwEleywUHx5FiB7X()
	{
		return x7QID5El21aAyqENoiUC == null;
	}

	internal static object rhD3NmElP0kmTFjB5jKi()
	{
		return x7QID5El21aAyqENoiUC;
	}
}
