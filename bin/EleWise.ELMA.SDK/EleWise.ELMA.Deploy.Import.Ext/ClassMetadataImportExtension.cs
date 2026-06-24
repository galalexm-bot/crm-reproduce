using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class ClassMetadataImportExtension<T> : ClassMetadataImportExtension<T, T> where T : ClassMetadata
{
	internal static object sS7ciLElGka1fKQpS8Uc;

	protected ClassMetadataImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool KRf1QZElEBjIAqCl6Okr()
	{
		return sS7ciLElGka1fKQpS8Uc == null;
	}

	internal static object NtTxJVElfSpN3TihYkfX()
	{
		return sS7ciLElGka1fKQpS8Uc;
	}
}
public abstract class ClassMetadataImportExtension<T, TBase> : NamedMetadataImportExtension<T> where T : TBase where TBase : ClassMetadata
{
	private static object hdKKaJElQ42erooRNAK9;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IEnumerable<IInheriteEntityMetadataGuid> InheriteEntityMetadataGuids { private get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	public IEnumerable<IExecuteMetadataPropertyExtension> PropertyMetadataImports { private get; set; }

	protected override bool TestMetadata(T mdMerged, ReadMetadataParameters parameters, bool isTestRead)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.mdMerged = mdMerged;
		bool flag = base.TestMetadata(CS_0024_003C_003E8__locals0.mdMerged, parameters, isTestRead);
		if (CS_0024_003C_003E8__locals0.mdMerged.BaseClassUid != Guid.Empty && base.MetadataService.GetMetadataList().All((IMetadata md) => md.Uid != CS_0024_003C_003E8__locals0.mdMerged.BaseClassUid))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099476725), CS_0024_003C_003E8__locals0.mdMerged.Uid, CS_0024_003C_003E8__locals0.mdMerged.Name, CS_0024_003C_003E8__locals0.mdMerged.DisplayName, CS_0024_003C_003E8__locals0.mdMerged.BaseClassUid)));
			flag = false;
		}
		if (flag)
		{
			CheckMetadataProperties((TBase)CS_0024_003C_003E8__locals0.mdMerged, isTestRead, parameters);
		}
		return flag;
	}

	protected override void MergeMetadata(T mdImported, T mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
		MergeMetadataProperties((TBase)mdImported, (TBase)mdDraft, parameters);
		if (isTestRead)
		{
			return;
		}
		if (mdImported.AllowCreateHeirs)
		{
			mdDraft.AllowCreateHeirs = true;
		}
		if (mdImported.ImplementedInterfaces != null)
		{
			if (mdDraft.ImplementedInterfaces == null)
			{
				mdDraft.ImplementedInterfaces = mdImported.ImplementedInterfaces;
			}
			else
			{
				mdDraft.ImplementedInterfaces = mdDraft.ImplementedInterfaces.Union(mdImported.ImplementedInterfaces).Distinct().ToList();
			}
		}
		mdDraft.ShowInDesigner = mdImported.ShowInDesigner;
		mdDraft.ShowInTypeTree = mdImported.ShowInTypeTree;
		if (mdImported.TitlePropertyUid != Guid.Empty)
		{
			mdDraft.TitlePropertyUid = mdImported.TitlePropertyUid;
		}
		if (!string.IsNullOrEmpty(mdImported.XmlComments))
		{
			mdDraft.XmlComments = mdImported.XmlComments;
		}
		MergeMetadataForms(mdImported, mdDraft, parameters);
		if (!string.IsNullOrEmpty(mdImported.ScriptModuleTypeName))
		{
			mdDraft.ScriptModuleTypeName = mdImported.ScriptModuleTypeName;
		}
		mdDraft.OnViewLoadScriptName = mdImported.OnViewLoadScriptName;
	}

	protected virtual void MergeMetadataProperties(TBase mdImported, TBase mdDraft, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.mdImported = mdImported;
		_003C_003Ec__DisplayClass10_.parameters = parameters;
		List<PropertyMetadata> list = mdDraft.Properties.ToList();
		using (IEnumerator<PropertyMetadata> enumerator = list.Where((PropertyMetadata p) => p.IsSystem).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_1();
				CS_0024_003C_003E8__locals0.propertyImported = enumerator.Current;
				if (CS_0024_003C_003E8__locals0.propertyImported.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals0.propertyImported.TypeUid == e.Uid))
				{
					CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid = _003C_003Ec__DisplayClass10_.parameters.MergeReplace.GetUidReplaceMD(CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid);
				}
			}
		}
		using (IEnumerator<PropertyMetadata> enumerator = _003C_003Ec__DisplayClass10_.mdImported.Properties.Where((PropertyMetadata p) => !p.IsSystem).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass10_2 _003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_2();
				_003C_003Ec__DisplayClass10_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass10_;
				_003C_003Ec__DisplayClass10_2.propertyImported = enumerator.Current;
				_003C_003Ec__DisplayClass10_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass10_3();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass10_2;
				try
				{
					CS_0024_003C_003E8__locals1.propertyBase = list.SingleOrDefault((PropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Uid);
				}
				catch (InvalidOperationException)
				{
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410987795), mdDraft.Name, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Uid)));
					continue;
				}
				if (CS_0024_003C_003E8__locals1.propertyBase != null && CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Name != CS_0024_003C_003E8__locals1.propertyBase.Name)
				{
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC5960C), mdDraft.Name, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Uid, CS_0024_003C_003E8__locals1.propertyBase.Uid, mdDraft.DisplayName, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.DisplayName, CS_0024_003C_003E8__locals1.propertyBase.DisplayName, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Name, CS_0024_003C_003E8__locals1.propertyBase.Name)));
				}
				if (CS_0024_003C_003E8__locals1.propertyBase == null)
				{
					try
					{
						CS_0024_003C_003E8__locals1.propertyBase = list.SingleOrDefault(delegate(PropertyMetadata p)
						{
							//Discarded unreachable code: IL_00a8, IL_00b7
							int num5 = 4;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									if (p.TypeUid == CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.TypeUid)
									{
										num6 = 2;
										break;
									}
									goto case 1;
								case 2:
									return p.SubTypeUid == CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.SubTypeUid;
								case 1:
									return false;
								case 3:
									if (!(p.Name == CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Name))
									{
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
										{
											num6 = 1;
										}
										break;
									}
									goto default;
								case 4:
									if (!p.IsSystem)
									{
										num6 = 3;
										break;
									}
									goto case 1;
								}
							}
						});
					}
					catch (InvalidOperationException)
					{
						continue;
					}
					if (CS_0024_003C_003E8__locals1.propertyBase != null)
					{
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951199654), mdDraft.Name, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Uid, CS_0024_003C_003E8__locals1.propertyBase.Uid, mdDraft.DisplayName, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.DisplayName, CS_0024_003C_003E8__locals1.propertyBase.DisplayName, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Name, CS_0024_003C_003E8__locals1.propertyBase.Name)));
					}
				}
				if (CS_0024_003C_003E8__locals1.propertyBase != null)
				{
					if (!MergePropertySettings(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported, CS_0024_003C_003E8__locals1.propertyBase, mdDraft, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters))
					{
						continue;
					}
					PropertyMetadataImports.ForEach(delegate(IExecuteMetadataPropertyExtension component)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								component.MetadataPropertyProcessing(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported, CS_0024_003C_003E8__locals1.propertyBase, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.mdImported, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters.MergeReplace.SetUidReplaceProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.mdImported.Uid, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Uid, CS_0024_003C_003E8__locals1.propertyBase.Uid);
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters.MergeReplace.SetNameReplaceProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.mdImported.Uid, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Name, CS_0024_003C_003E8__locals1.propertyBase.Name);
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.Uid = CS_0024_003C_003E8__locals1.propertyBase.Uid;
					list.Remove(CS_0024_003C_003E8__locals1.propertyBase);
					list.Add(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported);
					continue;
				}
				PropertyMetadataImports.ForEach(delegate(IExecuteMetadataPropertyExtension component)
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
							component.MetadataPropertyProcessing(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported, null, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.mdImported, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
				if (CheckNewProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported, mdDraft, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters))
				{
					if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.TypeUid == e.Uid))
					{
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.SubTypeUid = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.parameters.MergeReplace.GetUidReplaceMD(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported.SubTypeUid);
					}
					list.Add(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.propertyImported);
				}
			}
		}
		mdDraft.Properties = list;
	}

	protected virtual bool MergePropertySettings(PropertyMetadata propertyImported, PropertyMetadata propertyBase, TBase mdDraft, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.propertyBase = propertyBase;
		CS_0024_003C_003E8__locals0.propertyImported = propertyImported;
		if (!(CS_0024_003C_003E8__locals0.propertyBase.TypeUid == CS_0024_003C_003E8__locals0.propertyImported.TypeUid) || !(CS_0024_003C_003E8__locals0.propertyBase.SubTypeUid == CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088087690), mdDraft.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Uid, CS_0024_003C_003E8__locals0.propertyBase.Uid, mdDraft.Name, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyBase.DisplayName)));
			return false;
		}
		EntitySettings entitySettings = CS_0024_003C_003E8__locals0.propertyImported.Settings as EntitySettings;
		EntitySettings entitySettings2 = CS_0024_003C_003E8__locals0.propertyBase.Settings as EntitySettings;
		if ((CS_0024_003C_003E8__locals0.propertyBase.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals0.propertyBase.TypeUid == e.Uid)) && ((entitySettings2 != null && entitySettings != null && entitySettings2.RelationType != entitySettings.RelationType) || (entitySettings2 == null && entitySettings != null) || (entitySettings == null && entitySettings2 != null)))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC662E3), mdDraft.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Uid, CS_0024_003C_003E8__locals0.propertyBase.Uid, mdDraft.Name, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyBase.DisplayName)));
			return false;
		}
		if (CS_0024_003C_003E8__locals0.propertyImported.Settings is PropertySettings propertySettings)
		{
			_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass11_1();
			Guid uidReplaceProperty = parameters.MergeReplace.GetUidReplaceProperty(CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid, propertySettings.EntityTypeUid);
			ClassMetadata classMetadata;
			try
			{
				classMetadata = MetadataServiceContext.Service.GetMetadata(uidReplaceProperty) as ClassMetadata;
			}
			catch (TypeNotFoundException)
			{
				classMetadata = null;
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AF702E), mdDraft.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Uid, CS_0024_003C_003E8__locals0.propertyBase.Uid, mdDraft.Name, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyBase.DisplayName, uidReplaceProperty)));
			}
			CS_0024_003C_003E8__locals1.propertyUid = parameters.MergeReplace.GetUidReplaceProperty(CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid, propertySettings.PropertyUid);
			_ = classMetadata?.Properties.All((PropertyMetadata p) => p.Uid != CS_0024_003C_003E8__locals1.propertyUid) ?? true;
		}
		if ((CS_0024_003C_003E8__locals0.propertyImported.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals0.propertyImported.TypeUid == e.Uid)) && entitySettings != null && entitySettings2 != null && entitySettings.RelationType == RelationType.OneToMany)
		{
			entitySettings.KeyColumnUid = parameters.MergeReplace.GetUidReplaceProperty(mdDraft.Uid, entitySettings2.KeyColumnUid);
		}
		if (CS_0024_003C_003E8__locals0.propertyImported.TypeUid == EntityDescriptor.UID && entitySettings != null && entitySettings2 != null && entitySettings.HierarchyParentUid != Guid.Empty)
		{
			entitySettings.HierarchyParentUid = parameters.MergeReplace.GetUidReplaceProperty(mdDraft.Uid, entitySettings2.HierarchyParentUid);
		}
		if ((CS_0024_003C_003E8__locals0.propertyImported.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals0.propertyImported.TypeUid == e.Uid)) && entitySettings != null && entitySettings2 != null && entitySettings.RelationType == RelationType.ManyToMany)
		{
			entitySettings.RelationTableName = entitySettings2.RelationTableName;
		}
		return true;
	}

	protected virtual void CheckMetadataProperties(TBase mdImported, bool isTestRead, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.mdImported = mdImported;
		_003C_003Ec__DisplayClass12_.parameters = parameters;
		if (_003C_003Ec__DisplayClass12_.mdImported == null)
		{
			return;
		}
		PropertyMetadata[] array = _003C_003Ec__DisplayClass12_.mdImported.Properties.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass12_;
			CS_0024_003C_003E8__locals0.propertyImported = array[i];
			bool num = CheckNewProperty(CS_0024_003C_003E8__locals0.propertyImported, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.mdImported, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.parameters);
			if (!num && !isTestRead)
			{
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.mdImported.Properties.Remove(CS_0024_003C_003E8__locals0.propertyImported);
			}
			if (num && !isTestRead && CS_0024_003C_003E8__locals0.propertyImported != null && (CS_0024_003C_003E8__locals0.propertyImported.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals0.propertyImported.TypeUid == e.Uid)))
			{
				CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.parameters.MergeReplace.GetUidReplaceMD(CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid);
			}
			PropertyMetadataImports.ForEach(delegate(IExecuteMetadataPropertyExtension component)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						component.MetadataPropertyProcessing(CS_0024_003C_003E8__locals0.propertyImported, null, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.mdImported, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.parameters);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
	}

	protected override bool CheckMetadata(T mdImported, T mdDraft, ReadMetadataParameters parameters)
	{
		bool result = base.CheckMetadata(mdImported, mdDraft, parameters);
		if (mdDraft.Namespace != mdImported.Namespace)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633265191), mdImported.DisplayName, mdImported.Uid, mdDraft.DisplayName, mdImported.Namespace, mdDraft.Namespace, mdDraft.Uid)));
			result = false;
		}
		if (mdDraft.BaseClassUid != mdImported.BaseClassUid)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6A8CFD), mdImported.DisplayName, mdImported.Uid, mdDraft.DisplayName, mdDraft.Uid)));
			result = false;
		}
		return result;
	}

	protected virtual bool CheckNewProperty(PropertyMetadata propertyImported, TBase md, ReadMetadataParameters parameters)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.propertyImported = propertyImported;
		string message = "";
		bool result = true;
		if (!MetadataImportHelper.CheckPropertyDisplayName(((IEnumerable<IMetadata>)GetProperties(md)).ToList(), CS_0024_003C_003E8__locals0.propertyImported, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, out message))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3136B942), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, message, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			result = false;
		}
		if (!MetadataImportHelper.CheckPropertyName(((IEnumerable<IMetadata>)GetProperties(md)).ToList(), CS_0024_003C_003E8__locals0.propertyImported, md.Name, CS_0024_003C_003E8__locals0.propertyImported.Name, out message))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811753462), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, message, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			result = false;
		}
		EntitySettings entitySettings = CS_0024_003C_003E8__locals0.propertyImported.Settings as EntitySettings;
		if (!(md is DataClassMetadata) && (entitySettings == null || entitySettings.RelationType != RelationType.OneToMany) && (entitySettings == null || entitySettings.RelationType != RelationType.ManyToMany) && (entitySettings == null || entitySettings.RelationType != RelationType.ManyToManyInverse) && CS_0024_003C_003E8__locals0.propertyImported.Settings is SimpleTypeSettings && !MetadataImportHelper.CheckPropertyFieldName(((IEnumerable<IMetadata>)GetProperties(md)).ToList(), CS_0024_003C_003E8__locals0.propertyImported, (CS_0024_003C_003E8__locals0.propertyImported.Settings as SimpleTypeSettings).FieldName, out message))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FB131D), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, message, CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			result = false;
		}
		if (CS_0024_003C_003E8__locals0.propertyImported.Settings is PropertySettings propertySettings)
		{
			_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass14_1();
			ClassMetadata classMetadata;
			try
			{
				classMetadata = MetadataServiceContext.Service.GetMetadata(parameters.MergeReplace.GetUidReplaceMD(propertySettings.EntityTypeUid)) as ClassMetadata;
			}
			catch (TypeNotFoundException)
			{
				classMetadata = null;
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A734FF3), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FED9DE)), CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			}
			Guid uidReplaceMD = parameters.MergeReplace.GetUidReplaceMD(propertySettings.EntityTypeUid);
			CS_0024_003C_003E8__locals2.propertyUid = parameters.MergeReplace.GetUidReplaceProperty(uidReplaceMD, propertySettings.PropertyUid);
			_ = classMetadata?.Properties.All((PropertyMetadata p) => p.Uid != CS_0024_003C_003E8__locals2.propertyUid) ?? true;
		}
		if ((CS_0024_003C_003E8__locals0.propertyImported.TypeUid == EntityDescriptor.UID || InheriteEntityMetadataGuids.Any((IInheriteEntityMetadataGuid e) => CS_0024_003C_003E8__locals0.propertyImported.TypeUid == e.Uid)) && entitySettings != null && entitySettings.RelationType == RelationType.OneToMany)
		{
			_003C_003Ec__DisplayClass14_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass14_2();
			ClassMetadata classMetadata2;
			try
			{
				classMetadata2 = MetadataServiceContext.Service.GetMetadata(parameters.MergeReplace.GetUidReplaceMD(CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid)) as ClassMetadata;
			}
			catch (TypeNotFoundException)
			{
				classMetadata2 = null;
			}
			CS_0024_003C_003E8__locals1.keyUid = parameters.MergeReplace.GetUidReplaceProperty(CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid, entitySettings.KeyColumnUid);
			if (classMetadata2 == null || !classMetadata2.Properties.Any((PropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals1.keyUid))
			{
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106208384), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571A7AEF)), CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			}
		}
		IMetadataService service = MetadataServiceContext.Service;
		ITypeDescriptor typeDescriptor = service.GetTypeDescriptor(CS_0024_003C_003E8__locals0.propertyImported.TypeUid, CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid);
		if (typeDescriptor == null)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108373388), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767481329)), CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			result = false;
		}
		else if ((typeDescriptor is EntityDescriptor || typeDescriptor is EnumDescriptor) && service.GetMetadataList().All((IMetadata m) => m.Uid != CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid) && (!(md is TablePartMetadata) || !CS_0024_003C_003E8__locals0.propertyImported.IsSystem))
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210482297), CS_0024_003C_003E8__locals0.propertyImported.Uid, md.DisplayName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35775505), CS_0024_003C_003E8__locals0.propertyImported.SubTypeUid), CS_0024_003C_003E8__locals0.propertyImported.DisplayName, CS_0024_003C_003E8__locals0.propertyImported.Name, md.Name, md.Uid)));
			result = false;
		}
		return result;
	}

	protected virtual IEnumerable<IPropertyMetadata> GetProperties(TBase md)
	{
		return md.Properties;
	}

	private void MergeMetadataForms(ClassMetadata mdImported, ClassMetadata mdDraft, ReadMetadataParameters parameters)
	{
		int num = 12;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_003C_003Ec__DisplayClass16_.replaceList = new List<KeyValuePair<Guid, Guid>>();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 13;
					}
					continue;
				case 12:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass16_.mdDraft.TableViews = mdImported.TableViews;
					num2 = 6;
					continue;
				case 1:
					_003C_003Ec__DisplayClass16_.replaceList.AddRange(parameters.MergeReplace.GetAllUidReplaceProperty());
					num2 = 4;
					continue;
				default:
					_003C_003Ec__DisplayClass16_.mdDraft.DefaultForms = mdImported.DefaultForms;
					num2 = 7;
					continue;
				case 10:
					_003C_003Ec__DisplayClass16_.mdDraft.FormsScheme = mdImported.FormsScheme;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					mdImported.FormTransformations.Each(_003C_003Ec__DisplayClass16_._003CMergeMetadataForms_003Eb__3);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass16_.replacePropertyUids = _003C_003Ec__DisplayClass16_._003CMergeMetadataForms_003Eb__1;
					num2 = 9;
					continue;
				case 13:
					_003C_003Ec__DisplayClass16_.replaceList.AddRange(parameters.MergeReplace.GetAllUidReplaceMd());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					mdImported.Forms.Each(_003C_003Ec__DisplayClass16_._003CMergeMetadataForms_003Eb__2);
					num2 = 2;
					continue;
				case 11:
					break;
				case 8:
					return;
				case 7:
					_003C_003Ec__DisplayClass16_.mdDraft.InheritForms = mdImported.InheritForms;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass16_.replaceList = _003C_003Ec__DisplayClass16_.replaceList.Where((KeyValuePair<Guid, Guid> r) => r.Key != r.Value).ToList();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass16_.mdDraft = mdDraft;
			num = 10;
		}
	}

	protected ClassMetadataImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool VGnM6EElCn0Jtm0fdDRp()
	{
		return hdKKaJElQ42erooRNAK9 == null;
	}

	internal static object EHjXOVElv6mFs6L7qKjA()
	{
		return hdKKaJElQ42erooRNAK9;
	}
}
