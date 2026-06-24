using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
internal class EnumMetadataImportExtension : NamedMetadataImportExtension<EnumMetadata>
{
	private readonly MetadataItemManager metadataItemManager;

	private readonly MetadataItemGroupManager metadataItemGroupManager;

	private readonly IModelManager modelManager;

	private static EnumMetadataImportExtension J7b50VE9KN4rNt1pGDc0;

	public EnumMetadataImportExtension(MetadataItemManager metadataItemManager, MetadataItemGroupManager metadataItemGroupManager, IModelManager modelManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zGLDqeE9kKOpjYdaNxgD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				this.modelManager = modelManager;
				num = 2;
				break;
			case 2:
				return;
			default:
				this.metadataItemManager = metadataItemManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.metadataItemGroupManager = metadataItemGroupManager;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	protected override bool CheckSystemMetadata(EnumMetadata eMdImported, ReadMetadataParameters parameters, bool isTestRead)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_007e, IL_008d
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		EnumMetadata enumMetadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass4_.eMdImported = eMdImported;
				num2 = 7;
				continue;
			case 3:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 2;
				continue;
			case 10:
				fhKF9UE9Nm6H7Egx1uEj(parameters, new TestImportMessages(TestImportMessagesType.Error, SR.T((string)C1BaRyE9OxipopCJ5AOu(-643786247 ^ -643539833), boB35vE91gwiyoFIeJMq(enumMetadata), enumMetadata.Name, enumMetadata.Uid)));
				num2 = 6;
				continue;
			case 7:
				if (!VsUHi2E9n844xeqHOnsD(_003C_003Ec__DisplayClass4_.eMdImported))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 5:
				return false;
			default:
				enumMetadata = ((IMetadataService)dybCulE9PMVtf6l3gGW6(this)).GetMetadataList().FirstOrDefault(_003C_003Ec__DisplayClass4_._003CCheckSystemMetadata_003Eb__0) as EnumMetadata;
				num2 = 8;
				continue;
			case 8:
				if (enumMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 4;
			case 4:
				if (enumMetadata.IsSystem())
				{
					num2 = 10;
					continue;
				}
				break;
			case 1:
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)C1BaRyE9OxipopCJ5AOu(0x53FA00CE ^ 0x53FEC438), _003C_003Ec__DisplayClass4_.eMdImported.DisplayName, aGAItWE92eioB0aVgUWn(_003C_003Ec__DisplayClass4_.eMdImported), MMjaTkE9eo1GaemWcpuk(_003C_003Ec__DisplayClass4_.eMdImported))));
				num2 = 5;
				continue;
			case 6:
				return false;
			case 9:
				break;
			}
			break;
		}
		return true;
	}

	protected override void CheckNewMetadata(EnumMetadata mdImported, bool isTestRead, ReadMetadataParameters parameters)
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
				CheckEnumValues(mdImported, parameters, isTestRead);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override bool CheckMetadata(EnumMetadata eMdImported, EnumMetadata mdDraft, ReadMetadataParameters parameters)
	{
		int num = 4;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				result = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			case 3:
				if (nWO2fNE93F43IBwVkIUi(aGAItWE92eioB0aVgUWn(mdDraft), aGAItWE92eioB0aVgUWn(eMdImported)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 2:
				fhKF9UE9Nm6H7Egx1uEj(parameters, new TestImportMessages(TestImportMessagesType.Error, SR.T((string)C1BaRyE9OxipopCJ5AOu(-29254301 ^ -29009763), eMdImported.DisplayName, MMjaTkE9eo1GaemWcpuk(eMdImported), boB35vE91gwiyoFIeJMq(mdDraft), aGAItWE92eioB0aVgUWn(eMdImported), mdDraft.Name, MMjaTkE9eo1GaemWcpuk(mdDraft))));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				result = true;
				num2 = 3;
				break;
			}
		}
	}

	protected override void MergeMetadata(EnumMetadata eMdImported, EnumMetadata mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_007f, IL_008e, IL_01b1, IL_01e3, IL_01fa, IL_0285, IL_0294, IL_02ee, IL_0406, IL_0442, IL_0499, IL_04cb, IL_0545, IL_05c7, IL_05d6, IL_06bc, IL_06cf, IL_06de
		int num = 3;
		int num2 = num;
		List<EnumValueMetadata>.Enumerator enumerator = default(List<EnumValueMetadata>.Enumerator);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		int? intValue2 = default(int?);
		int? intValue = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				base.MergeMetadata(eMdImported, mdDraft, isTestRead, parameters);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				return;
			case 2:
				enumerator = eMdImported.Values.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0567:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num3 = 18;
						}
						goto IL_009d;
					}
					goto IL_042c;
					IL_042c:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num3 = 24;
					goto IL_009d;
					IL_009d:
					while (true)
					{
						int num8;
						switch (num3)
						{
						case 25:
							return;
						case 26:
							BqBSZSE9aRjCJ1nmQnQs(cLGoFvE9pNqH52iOS01n(parameters), MMjaTkE9eo1GaemWcpuk(eMdImported), MMjaTkE9eo1GaemWcpuk(_003C_003Ec__DisplayClass7_.valueImported), MMjaTkE9eo1GaemWcpuk(enumValueMetadata));
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num3 = 16;
							}
							continue;
						case 22:
							if (_003C_003Ec__DisplayClass7_.valueImported == null)
							{
								num3 = 21;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num3 = 13;
								}
								continue;
							}
							goto case 1;
						case 5:
							try
							{
								enumValueMetadata = mdDraft.Values.SingleOrDefault(_003C_003Ec__DisplayClass7_._003CMergeMetadata_003Eb__1);
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							catch (InvalidOperationException)
							{
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								}
								goto IL_0567;
							}
							goto case 11;
						case 24:
							_003C_003Ec__DisplayClass7_.valueImported = enumerator.Current;
							num3 = 22;
							continue;
						case 9:
							if (intValue2 != intValue)
							{
								num8 = 15;
								goto IL_0099;
							}
							goto case 26;
						case 7:
							I5JSc7E9tqKraisAObyh(_003C_003Ec__DisplayClass7_.valueImported, MMjaTkE9eo1GaemWcpuk(enumValueMetadata));
							num3 = 14;
							continue;
						case 23:
							intValue2 = enumValueMetadata.IntValue;
							num3 = 6;
							continue;
						case 16:
							PxUqLPE9DWhKFCejUe8Y(cLGoFvE9pNqH52iOS01n(parameters), MMjaTkE9eo1GaemWcpuk(eMdImported), aGAItWE92eioB0aVgUWn(_003C_003Ec__DisplayClass7_.valueImported), aGAItWE92eioB0aVgUWn(enumValueMetadata));
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
							num3 = 8;
							continue;
						case 17:
							mdDraft.Values.Add(_003C_003Ec__DisplayClass7_.valueImported);
							num3 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num3 = 27;
							}
							continue;
						case 2:
							if (enumValueMetadata == null)
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 12;
						case 11:
							if (enumValueMetadata == null)
							{
								num8 = 12;
								goto IL_0099;
							}
							goto case 10;
						case 12:
						case 13:
							if (enumValueMetadata == null)
							{
								num3 = 20;
								continue;
							}
							goto case 23;
						case 15:
							parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)C1BaRyE9OxipopCJ5AOu(0x3630F361 ^ 0x36343B0D), boB35vE91gwiyoFIeJMq(mdDraft), _003C_003Ec__DisplayClass7_.valueImported.Uid, MMjaTkE9eo1GaemWcpuk(enumValueMetadata), aGAItWE92eioB0aVgUWn(mdDraft), _003C_003Ec__DisplayClass7_.valueImported.DisplayName, boB35vE91gwiyoFIeJMq(enumValueMetadata))));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							mdDraft.Values.Add(_003C_003Ec__DisplayClass7_.valueImported);
							num3 = 4;
							continue;
						case 18:
							break;
						case 14:
							mdDraft.Values.Remove(enumValueMetadata);
							num3 = 3;
							continue;
						case 8:
							try
							{
								enumValueMetadata = mdDraft.Values.SingleOrDefault(_003C_003Ec__DisplayClass7_._003CMergeMetadata_003Eb__0);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							catch (InvalidOperationException)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740584660), aGAItWE92eioB0aVgUWn(mdDraft), MMjaTkE9eo1GaemWcpuk(_003C_003Ec__DisplayClass7_.valueImported))));
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
										{
											num5 = 0;
										}
										continue;
									}
									break;
								}
								goto IL_0567;
							}
							goto case 2;
						case 6:
							intValue = _003C_003Ec__DisplayClass7_.valueImported.IntValue;
							num3 = 9;
							continue;
						default:
							goto IL_0567;
						case 19:
						case 20:
							if (CheckNewValue(mdDraft, _003C_003Ec__DisplayClass7_.valueImported, mdDraft.Values, parameters))
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 17;
								}
								continue;
							}
							goto IL_0567;
						case 10:
							{
								fhKF9UE9Nm6H7Egx1uEj(parameters, new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T((string)C1BaRyE9OxipopCJ5AOu(0x34A6D230 ^ 0x34A21548), aGAItWE92eioB0aVgUWn(mdDraft), MMjaTkE9eo1GaemWcpuk(_003C_003Ec__DisplayClass7_.valueImported), enumValueMetadata.Uid, boB35vE91gwiyoFIeJMq(mdDraft), boB35vE91gwiyoFIeJMq(_003C_003Ec__DisplayClass7_.valueImported), boB35vE91gwiyoFIeJMq(enumValueMetadata), _003C_003Ec__DisplayClass7_.valueImported.Name, aGAItWE92eioB0aVgUWn(enumValueMetadata))));
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num3 = 13;
								}
								continue;
							}
							IL_0099:
							num3 = num8;
							continue;
						}
						break;
					}
					goto IL_042c;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num9 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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

	protected override void SaveMetadata(EnumMetadata eMdMerged, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_009d, IL_00be, IL_00cd, IL_020c, IL_0240, IL_024f, IL_0338, IL_03d5, IL_03e4, IL_03f4, IL_0403
		int num = 4;
		MetadataItemDTO metadataItemDTO2 = default(MetadataItemDTO);
		IMetadataItemGroup metadataItemGroup2 = default(IMetadataItemGroup);
		long num3 = default(long);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IMetadataItemGroup metadataItemGroup = default(IMetadataItemGroup);
		Guid result = default(Guid);
		List<MetadataItemDTO> list = default(List<MetadataItemDTO>);
		IMetadataItem metadataItem = default(IMetadataItem);
		IMetadataItemGroup metadataItemGroup3 = default(IMetadataItemGroup);
		string key = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				MetadataItemDTO metadataItemDTO;
				switch (num2)
				{
				case 8:
					atUcAbE943d1vprSZmWG(metadataItemDTO2, eMdMerged);
					num2 = 7;
					continue;
				case 11:
					return;
				case 13:
					if (metadataItemGroup2 == null)
					{
						num2 = 28;
						continue;
					}
					goto case 17;
				default:
					num3 = 0L;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 23;
					}
					continue;
				case 22:
				case 25:
				{
					MetadataItemGroupManager obj2 = metadataItemGroupManager;
					ParameterExpression parameterExpression = Expression.Parameter(pIXWAjE9A1slVIxiEq9o(typeof(IMetadataItemGroup).TypeHandle), (string)C1BaRyE9OxipopCJ5AOu(-867826612 ^ -867765300));
					metadataItemGroup2 = obj2.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression)eKjP1YE9MwYGdTrmrQca(yaYejKE9xFNOAZpRbJxq(parameterExpression, (MethodInfo)yqDgnIE97Zh5lru4Z6QA((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), JDl8NAE9yqUnlQLCZuLB(jidCpIE90bvqrBlh8Bri(_003C_003Ec__DisplayClass8_, pIXWAjE9A1slVIxiEq9o(typeof(_003C_003Ec__DisplayClass8_0).TypeHandle)), VMwxxJE9mcbR3wqDFTXV((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }), (FetchOptions)NkY7bdE9JqKYvIxfr4eg()).FirstOrDefault();
					num2 = 13;
					continue;
				}
				case 20:
					num3 = metadataItemGroup.Id;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 1;
					}
					continue;
				case 23:
					if (!Guid.TryParse(_003C_003Ec__DisplayClass8_.tmp, out result))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 19;
				case 26:
					parameters.Headers.Add(aWJ3TUE9dFMwvrJlIPgJ(list[0]));
					num2 = 11;
					continue;
				case 2:
				case 6:
				case 15:
				case 28:
					if (num3 != 0L)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 16;
				case 12:
				case 21:
					metadataItemDTO2.HeaderGroupId = num3;
					num2 = 9;
					continue;
				case 30:
					parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T((string)C1BaRyE9OxipopCJ5AOu(0x57A5235E ^ 0x57A1EA86), MMjaTkE9eo1GaemWcpuk(eMdMerged), eMdMerged.DisplayName, eMdMerged.Name), endProcess: false));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 26;
					}
					continue;
				case 3:
					metadataItem = metadataItemManager.LoadOrNull(MMjaTkE9eo1GaemWcpuk(eMdMerged));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 27;
					}
					continue;
				case 1:
					if (metadataItemGroup3 == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 29;
				case 10:
					metadataItemDTO = new MetadataItemDTO();
					HuTTO7E9wSIa8mCTcobp(metadataItemDTO, MMjaTkE9eo1GaemWcpuk(eMdMerged));
					goto IL_0581;
				case 5:
					if (metadataItemGroup != null)
					{
						num = 20;
						break;
					}
					goto case 12;
				case 24:
					list = modelManager.SaveMetadataItems(new List<MetadataItemDTO> { metadataItemDTO2 });
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 23;
					}
					continue;
				case 19:
					metadataItemGroup3 = metadataItemGroupManager.LoadOrNull(result);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 27:
					if (metadataItem != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 10;
				case 17:
					num3 = metadataItemGroup2.Id;
					num = 2;
					break;
				case 7:
					key = (string)JdSNlHE9HXmjVnD2mQFT(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123936914), mUrLJAE96CniX5O2QmIy(eMdMerged));
					num = 18;
					break;
				case 16:
				{
					MetadataItemGroupManager obj = metadataItemGroupManager;
					ParameterExpression parameterExpression = (ParameterExpression)fnX6xRE99oZJCkrtEhwY(pIXWAjE9A1slVIxiEq9o(typeof(IMetadataItemGroup).TypeHandle), C1BaRyE9OxipopCJ5AOu(0x1ECE530A ^ 0x1ECEA48A));
					metadataItemGroup = obj.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression)eKjP1YE9MwYGdTrmrQca(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), jidCpIE90bvqrBlh8Bri(C1BaRyE9OxipopCJ5AOu(0x1A33FE36 ^ 0x1A373796), pIXWAjE9A1slVIxiEq9o(typeof(string).TypeHandle))), new ParameterExpression[1] { parameterExpression }), (FetchOptions)NkY7bdE9JqKYvIxfr4eg()).FirstOrDefault();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 5;
					}
					continue;
				}
				case 4:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					if (parameters.ServiceData.TryGetValue(key, out _003C_003Ec__DisplayClass8_.tmp))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 24;
				case 29:
					num3 = metadataItemGroup3.Id;
					num2 = 15;
					continue;
				case 9:
					eMdMerged.GroupId = num3;
					num = 24;
					break;
				case 14:
					{
						metadataItemDTO = Mapper.Map<IMetadataItem, MetadataItemDTO>(metadataItem);
						goto IL_0581;
					}
					IL_0581:
					metadataItemDTO2 = metadataItemDTO;
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	private bool CheckNewValue(EnumMetadata metadata, EnumValueMetadata value, List<EnumValueMetadata> allValues, ReadMetadataParameters parameters)
	{
		bool result = true;
		string text = MetadataImportHelper.CheckEnumValueDisplayName(value, value.DisplayName, allValues);
		if (text != null)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281565550), value.DisplayName, value.Name, value.IntValue, metadata.DisplayName, metadata.Name, metadata.Uid, text)));
			result = false;
		}
		text = MetadataImportHelper.CheckEnumValueName(value, value.Name, allValues);
		if (text != null)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106204690), value.DisplayName, value.Name, value.IntValue, metadata.DisplayName, metadata.Name, metadata.Uid, text)));
			result = false;
		}
		text = MetadataImportHelper.CheckEnumIntValue(value, value.IntValue, allValues);
		if (text != null)
		{
			parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571A69B3), value.DisplayName, value.Name, value.IntValue, metadata.DisplayName, metadata.Name, metadata.Uid, text)));
			result = false;
		}
		return result;
	}

	private void CheckEnumValues(EnumMetadata eMdImported, ReadMetadataParameters parameters, bool isTestRead)
	{
		//Discarded unreachable code: IL_00d5, IL_00e4, IL_00ef, IL_01b6, IL_01c9, IL_01d8
		int num = 5;
		int num2 = num;
		List<EnumValueMetadata> list = default(List<EnumValueMetadata>);
		List<EnumValueMetadata>.Enumerator enumerator = default(List<EnumValueMetadata>.Enumerator);
		EnumValueMetadata current = default(EnumValueMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				eMdImported.Values = list;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				list = new List<EnumValueMetadata>();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				enumerator = eMdImported.Values.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				break;
			default:
				try
				{
					while (true)
					{
						IL_013e:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num3 = 0;
							}
							goto IL_00f3;
						}
						goto IL_0164;
						IL_0164:
						current = enumerator.Current;
						num3 = 3;
						goto IL_00f3;
						IL_00f3:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (CheckNewValue(eMdImported, current, list, parameters) || isTestRead)
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_013e;
							case 2:
								goto IL_013e;
							case 1:
								goto IL_0164;
							case 4:
								list.Add(current);
								num3 = 2;
								continue;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 2:
				return;
			}
			if (y8DTvyE9lxQPfYxGGMHU(list) != y8DTvyE9lxQPfYxGGMHU(eMdImported.Values))
			{
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 3;
				}
				continue;
			}
			break;
		}
	}

	internal static void zGLDqeE9kKOpjYdaNxgD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sjkY9SE9XJ5pKwErcLIe()
	{
		return J7b50VE9KN4rNt1pGDc0 == null;
	}

	internal static EnumMetadataImportExtension XCGyT1E9TGeeOKBTWqlY()
	{
		return J7b50VE9KN4rNt1pGDc0;
	}

	internal static bool VsUHi2E9n844xeqHOnsD(object P_0)
	{
		return ((IMetadata)P_0).IsSystem();
	}

	internal static object C1BaRyE9OxipopCJ5AOu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aGAItWE92eioB0aVgUWn(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid MMjaTkE9eo1GaemWcpuk(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object dybCulE9PMVtf6l3gGW6(object P_0)
	{
		return ((NamedMetadataImportExtension<EnumMetadata>)P_0).MetadataRuntimeService;
	}

	internal static object boB35vE91gwiyoFIeJMq(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void fhKF9UE9Nm6H7Egx1uEj(object P_0, object P_1)
	{
		((ReadMetadataParameters)P_0).TestMessagesAdd((TestImportMessages)P_1);
	}

	internal static bool nWO2fNE93F43IBwVkIUi(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object cLGoFvE9pNqH52iOS01n(object P_0)
	{
		return ((ReadMetadataParameters)P_0).MergeReplace;
	}

	internal static void BqBSZSE9aRjCJ1nmQnQs(object P_0, Guid mdUid, Guid uidFrom, Guid uidTo)
	{
		((MergeReplace)P_0).SetUidReplaceProperty(mdUid, uidFrom, uidTo);
	}

	internal static void PxUqLPE9DWhKFCejUe8Y(object P_0, Guid mdUid, object P_2, object P_3)
	{
		((MergeReplace)P_0).SetNameReplaceProperty(mdUid, (string)P_2, (string)P_3);
	}

	internal static void I5JSc7E9tqKraisAObyh(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void HuTTO7E9wSIa8mCTcobp(object P_0, Guid value)
	{
		((MetadataItemDTO)P_0).Uid = value;
	}

	internal static void atUcAbE943d1vprSZmWG(object P_0, object P_1)
	{
		((MetadataItemDTO)P_0).Metadata = (IMetadata)P_1;
	}

	internal static long mUrLJAE96CniX5O2QmIy(object P_0)
	{
		return ((EnumMetadata)P_0).GroupId;
	}

	internal static object JdSNlHE9HXmjVnD2mQFT(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static Type pIXWAjE9A1slVIxiEq9o(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object yqDgnIE97Zh5lru4Z6QA(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object yaYejKE9xFNOAZpRbJxq(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object jidCpIE90bvqrBlh8Bri(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object VMwxxJE9mcbR3wqDFTXV(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object JDl8NAE9yqUnlQLCZuLB(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object eKjP1YE9MwYGdTrmrQca(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object NkY7bdE9JqKYvIxfr4eg()
	{
		return FetchOptions.First;
	}

	internal static object fnX6xRE99oZJCkrtEhwY(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static long aWJ3TUE9dFMwvrJlIPgJ(object P_0)
	{
		return ((MetadataItemDTO)P_0).HeaderId;
	}

	internal static int y8DTvyE9lxQPfYxGGMHU(object P_0)
	{
		return ((List<EnumValueMetadata>)P_0).Count;
	}
}
