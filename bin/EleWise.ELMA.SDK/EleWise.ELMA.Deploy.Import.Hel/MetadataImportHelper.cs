using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Helpers;

public static class MetadataImportHelper
{
	internal static MetadataImportHelper ILhJuvEykNKYmlqIYu2d;

	[Obsolete("Use EntityMetadataExtensions.IsSystem instead", true)]
	public static bool IsSystem(EntityMetadata md)
	{
		return XRkrLSEy2qfJLREGCI0B(md);
	}

	[Obsolete("Use EntityMetadataExtensions.IsSystem or MetadataRuntimeService.IsSystem instead", true)]
	public static bool IsSystem(IMetadata md)
	{
		return md.IsSystem();
	}

	[Obsolete("Use EntityMetadataExtensions.IsSystemMetadata or MetadataRuntimeService.IsSystem instead", true)]
	public static bool IsSystem(Guid typeUidMd)
	{
		return typeUidMd.IsSystemMetadata();
	}

	[Obsolete("Use EntityMetadataExtensions.IsConfig or MetadataRuntimeService.IsConfig instead", true)]
	public static bool IsConfig(IMetadata md)
	{
		return IDvr2BEyeY7516cnNhlA(md);
	}

	[Obsolete("Use EntityMetadataExtensions.IsConfigMetadata or MetadataRuntimeService.IsConfig instead", true)]
	public static bool IsConfig(Guid typeUidMd)
	{
		return typeUidMd.IsConfigMetadata();
	}

	public static List<IPropertyMetadata> GetAllPropertiesAndTableParts(EntityMetadata md)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.result = new List<IPropertyMetadata>();
		if (md != null && md.Properties != null)
		{
			CS_0024_003C_003E8__locals0.result.AddRange(md.Properties);
		}
		if (md != null && md.TableParts != null)
		{
			md.TableParts.ForEach(delegate(TablePartMetadata t)
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						CS_0024_003C_003E8__locals0.result.Add(t);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						CS_0024_003C_003E8__locals0.result.AddRange(GetAllPropertiesAndTableParts(t));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.result;
	}

	public static bool IsRestartNeeded()
	{
		return Locator.GetServiceNotNull<IModelManager>().GetRestartRequiredMetadataUids().Count > 0;
	}

	public static TestImportMessages ValidateObjectName(NamedMetadata metadata, string name)
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_00dc, IL_01c5, IL_01d4, IL_0227, IL_0236, IL_0246, IL_0260, IL_026f
		int num = 12;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		NamedMetadata metadata2 = default(NamedMetadata);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				_003C_003Ec__DisplayClass7_.name = name;
				num2 = 18;
				continue;
			case 18:
				if (!ApapVyEyP3LmxV9sDU5W(_003C_003Ec__DisplayClass7_.name))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (!jK9OTtEyNDaCFAyR8mVR(_003C_003Ec__DisplayClass7_.name))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 20;
					}
					continue;
				}
				goto case 22;
			case 2:
				if (metadata2 is FunctionMetadata)
				{
					num2 = 16;
					continue;
				}
				break;
			case 10:
				if (metadata2 is ComponentMetadata)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 2;
			case 5:
				text = SR.T((string)jgyh0PEy1XR7gj3FqUWV(-1876063057 ^ -1876345699), _003C_003Ec__DisplayClass7_.name);
				num2 = 23;
				continue;
			case 3:
				if (metadata2 == null)
				{
					num2 = 14;
					continue;
				}
				goto case 10;
			case 22:
				return new TestImportMessages(TestImportMessagesType.Error, SR.T((string)jgyh0PEy1XR7gj3FqUWV(0x92F12D5 ^ 0x92BBD95), _003C_003Ec__DisplayClass7_.name));
			case 20:
				metadata2 = _003C_003Ec__DisplayClass7_.metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 3;
				}
				continue;
			case 11:
				_003C_003Ec__DisplayClass7_.metadata = metadata;
				num2 = 9;
				continue;
			case 17:
				text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C4F6C1), _003C_003Ec__DisplayClass7_.name);
				num2 = 6;
				continue;
			case 21:
				return new TestImportMessages(TestImportMessagesType.Error, text);
			case 7:
				return null;
			case 1:
			case 6:
			case 23:
				if (!((IMetadataService)SsJUppEy3PnZ6h2mMab2()).GetMetadataList().OfType<NamedMetadata>().Any(_003C_003Ec__DisplayClass7_._003CValidateObjectName_003Eb__0))
				{
					num2 = 7;
					continue;
				}
				goto case 21;
			case 15:
				text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420521850), _003C_003Ec__DisplayClass7_.name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				continue;
			case 12:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 11;
				continue;
			default:
				return new TestImportMessages(TestImportMessagesType.Error, SR.T((string)jgyh0PEy1XR7gj3FqUWV(-138018305 ^ -138236019), _003C_003Ec__DisplayClass7_.name));
			case 4:
			case 13:
				_003C_003Ec__DisplayClass7_.checkMetadata = (NamedMetadata m) => m is ComponentMetadata;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				continue;
			case 16:
			case 19:
				_003C_003Ec__DisplayClass7_.checkMetadata = (NamedMetadata m) => m is FunctionMetadata;
				num2 = 5;
				continue;
			case 8:
			case 14:
				break;
			}
			_003C_003Ec__DisplayClass7_.checkMetadata = delegate(NamedMetadata m)
			{
				//Discarded unreachable code: IL_00b9, IL_00c8
				int num3 = 2;
				int num4 = num3;
				EntityMetadata entityMetadata = default(EntityMetadata);
				while (true)
				{
					switch (num4)
					{
					case 2:
						if (!(m is ComponentMetadata))
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
							{
								num4 = 1;
							}
							continue;
						}
						break;
					case 1:
						if (m is FunctionMetadata)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num4 = 0;
							}
							continue;
						}
						goto case 3;
					case 3:
						if ((entityMetadata = m as EntityMetadata) != null)
						{
							num4 = 4;
							continue;
						}
						return true;
					case 4:
						return !entityMetadata.Type.In(EntityMetadataType.InterfaceExtension, EntityMetadataType.InterfaceImplementation);
					}
					break;
				}
				return false;
			};
			num2 = 10;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
			{
				num2 = 17;
			}
		}
	}

	public static TestImportMessages ValidateObjectTablePartName(ICodeItemMetadata metadata, string name, Guid uid)
	{
		//Discarded unreachable code: IL_00c3, IL_01d1
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass8_.name = name;
				num2 = 7;
				break;
			case 8:
				if (ApapVyEyP3LmxV9sDU5W(_003C_003Ec__DisplayClass8_.name))
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 6:
				return new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C9024F4), _003C_003Ec__DisplayClass8_.name));
			case 5:
				if (jK9OTtEyNDaCFAyR8mVR(_003C_003Ec__DisplayClass8_.name))
				{
					num2 = 4;
					break;
				}
				if (!MetadataServiceContext.Service.GetMetadataList().OfType<ICodeItemMetadata>().Any(_003C_003Ec__DisplayClass8_._003CValidateObjectTablePartName_003Eb__0))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 4:
				return new TestImportMessages(TestImportMessagesType.Error, SR.T((string)jgyh0PEy1XR7gj3FqUWV(-1459557599 ^ -1459332821), _003C_003Ec__DisplayClass8_.name));
			case 1:
				_003C_003Ec__DisplayClass8_.metadata = metadata;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass8_.uid = uid;
				num2 = 8;
				break;
			case 2:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				return new TestImportMessages(TestImportMessagesType.Error, SR.T((string)jgyh0PEy1XR7gj3FqUWV(0x4D1C1EE4 ^ 0x4D18AC82), _003C_003Ec__DisplayClass8_.name));
			default:
				return null;
			}
		}
	}

	public static TestImportMessages ValidateEntityTableName(EntityMetadata metadata, string tableName, string messageAdditionalInfo = null)
	{
		//Discarded unreachable code: IL_005d
		int num = 2;
		int num2 = num;
		Guid ownerUid;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (HZtra3Eyp8v2JenA8gET(metadata) == EntityMetadataType.InterfaceExtension)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (!(metadata is TablePartMetadata))
				{
					num2 = 3;
					continue;
				}
				ownerUid = GOm7ykEya66GGNQudyGE((TablePartMetadata)metadata);
				break;
			case 3:
				ownerUid = metadata.Uid;
				break;
			case 2:
				if (metadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			default:
				return null;
			}
			break;
		}
		return ValidateTableName(ownerUid, tableName, default(Guid), messageAdditionalInfo);
	}

	public static string NewRelationTableName(string tableName, Guid propertyImportedUid, EntitySettings propertyImportedSettings)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_0077, IL_00ed, IL_0147, IL_0151
		int num = 1;
		int num2 = num;
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 11:
				return "";
			case 5:
				text = (string)PPxEimEywpOTRbu4HjTt(tableName, ++num3);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 8;
				}
				continue;
			case 7:
			case 8:
				if (ValidateTableName(propertyImportedUid, text) == null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 12;
			case 12:
				if (text.Count() < 28)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 11;
			case 3:
				text = (string)PPxEimEywpOTRbu4HjTt(tableName, ++num3);
				num2 = 7;
				continue;
			case 6:
				obj = tableName;
				break;
			case 13:
				if (js7CQUEytgX4utoivcHE(tableName) <= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 10:
				text = "";
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 13;
				}
				continue;
			case 4:
				num3 = 0;
				num2 = 3;
				continue;
			case 1:
				if (tableName.Count() >= 28)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 2:
			case 9:
				return text;
			default:
				obj = t4oYKSEyDXEhmVqo2RQt(tableName, 0, 23);
				break;
			}
			tableName = (string)obj;
			num2 = 10;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num2 = 10;
			}
		}
	}

	public static TestImportMessages ValidateTableName(Guid ownerUid, string tableName, Guid uid = default(Guid), string messageAdditionalInfo = null)
	{
		//Discarded unreachable code: IL_004a, IL_0059, IL_00a4, IL_00b3, IL_0146, IL_0165, IL_0174, IL_01a1, IL_01b0, IL_0378
		int num = 9;
		int num2 = num;
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		TestImportMessages testImportMessages = default(TestImportMessages);
		EntityMetadata current = default(EntityMetadata);
		TestImportMessages result = default(TestImportMessages);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						IL_00f8:
						int num4;
						if (!kEmFYtEy0rQ2v31HI1ZU(enumerator))
						{
							num4 = 2;
							goto IL_0068;
						}
						goto IL_00d5;
						IL_0068:
						while (true)
						{
							switch (num4)
							{
							case 5:
								if (testImportMessages != null)
								{
									num4 = 4;
									continue;
								}
								goto IL_00f8;
							case 1:
								testImportMessages = ValidateRelationTableNameForMd(ownerUid, tableName, current, uid, messageAdditionalInfo);
								num4 = 5;
								continue;
							case 6:
								break;
							default:
								goto IL_00f8;
							case 4:
							{
								result = testImportMessages;
								int num5 = 3;
								num4 = num5;
								continue;
							}
							case 2:
								goto end_IL_00f8;
							case 3:
								return result;
							}
							break;
						}
						goto IL_00d5;
						IL_00d5:
						current = enumerator.Current;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num4 = 1;
						}
						goto IL_0068;
						continue;
						end_IL_00f8:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num6 = 1;
						}
						goto IL_014a;
					}
					goto IL_017f;
					IL_017f:
					P4CWWAEympblS5thpmGf(enumerator);
					num6 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num6 = 1;
					}
					goto IL_014a;
					IL_014a:
					switch (num6)
					{
					case 1:
						goto end_IL_0125;
					case 2:
						goto end_IL_0125;
					}
					goto IL_017f;
					end_IL_0125:;
				}
				goto default;
			case 3:
				return new TestImportMessages(TestImportMessagesType.Error, text + SR.T((string)jgyh0PEy1XR7gj3FqUWV(-812025778 ^ -811742550), tableName, iYkomWEyHtAk2crgG1XY(jgyh0PEy1XR7gj3FqUWV(0x4D1C1EE4 ^ 0x4D18AD88))));
			case 1:
				if (T3rjTWEy6gd9DkVBVCYe(tableName))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 5;
					}
				}
				else if (!xqo1qPEyAOxmC4E7GLum(tableName, jgyh0PEy1XR7gj3FqUWV(0x57A5235E ^ 0x57A52F24)))
				{
					if (!ApapVyEyP3LmxV9sDU5W(tableName))
					{
						num2 = 4;
						continue;
					}
					num3 = yV5VfdEyxKnJlfq2vb1S(wdxxmBEy7wiZcu1mKmfl(Locator.GetServiceNotNull<ITransformationProvider>()));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 3;
				}
				continue;
			case 4:
				return new TestImportMessages(TestImportMessagesType.Error, (string)Td76TmEy4D9fbDElmmiZ(text, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138235109), tableName, iYkomWEyHtAk2crgG1XY(jgyh0PEy1XR7gj3FqUWV(0x12441CA4 ^ 0x1240AF78)))));
			case 9:
				if (!string.IsNullOrWhiteSpace(messageAdditionalInfo))
				{
					num2 = 8;
					continue;
				}
				obj = "";
				break;
			case 5:
				return new TestImportMessages(TestImportMessagesType.Error, (string)Td76TmEy4D9fbDElmmiZ(text, SR.T((string)jgyh0PEy1XR7gj3FqUWV(-1978478350 ^ -1978244586), tableName, iYkomWEyHtAk2crgG1XY(jgyh0PEy1XR7gj3FqUWV(-867826612 ^ -868042908)))));
			default:
				return null;
			case 7:
				if (tableName.Length > num3)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					enumerator = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().GetEnumerator();
					num2 = 6;
				}
				continue;
			case 8:
				obj = Td76TmEy4D9fbDElmmiZ(messageAdditionalInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787275725));
				break;
			case 2:
				return new TestImportMessages(TestImportMessagesType.Error, (string)Td76TmEy4D9fbDElmmiZ(text, SR.T((string)jgyh0PEy1XR7gj3FqUWV(0x53FA00CE ^ 0x53FEB22A), tableName, SR.T((string)jgyh0PEy1XR7gj3FqUWV(0x5A4C7B29 ^ 0x5A48CFF5), num3))));
			}
			text = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
			{
				num2 = 1;
			}
		}
	}

	private static TestImportMessages ValidateRelationTableNameForMd(Guid ownerUid, object tableName, object m, Guid uid = default(Guid), string messageAdditionalInfo = null)
	{
		//Discarded unreachable code: IL_00ba, IL_00f7, IL_0106, IL_01de, IL_01f1, IL_026a, IL_02bb, IL_0316, IL_0373, IL_0382, IL_0393, IL_03a2, IL_03ad, IL_0450, IL_045f, IL_046f, IL_047e, IL_04b5, IL_04c8, IL_04d7
		int num = 9;
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		TestImportMessages testImportMessages2 = default(TestImportMessages);
		PropertyMetadata current2 = default(PropertyMetadata);
		TestImportMessages result = default(TestImportMessages);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		string text = default(string);
		TestImportMessages testImportMessages = default(TestImportMessages);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			object obj;
			while (true)
			{
				Guid guid;
				switch (num2)
				{
				case 17:
					if (e8UtyrEyJMgs3P3rCwlc(m) != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 7;
				case 9:
					if (((EntityMetadata)m).Type == EntityMetadataType.InterfaceImplementation)
					{
						num2 = 8;
						break;
					}
					if (!T8AooyEyy690hqDxRI3k(messageAdditionalInfo))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 0;
						}
						break;
					}
					obj = "";
					goto end_IL_0012;
				case 15:
					if (HZtra3Eyp8v2JenA8gET(m) != 0)
					{
						num2 = 16;
						break;
					}
					goto case 2;
				case 13:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator2.MoveNext())
							{
								int num5 = 5;
								num6 = num5;
								goto IL_00cc;
							}
							goto IL_016e;
							IL_00cc:
							while (true)
							{
								switch (num6)
								{
								case 6:
									testImportMessages2 = (TestImportMessages)BlV9LREyl62uYSMYkxPq(ownerUid, tableName, current2);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num6 = 3;
									}
									continue;
								default:
									result = testImportMessages2;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
									{
										num6 = 1;
									}
									continue;
								case 2:
									break;
								case 4:
									goto IL_016e;
								case 3:
									if (testImportMessages2 != null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
										{
											num6 = 0;
										}
										continue;
									}
									break;
								case 5:
									goto end_IL_0154;
								case 1:
									return result;
								}
								break;
							}
							continue;
							IL_016e:
							current2 = enumerator2.Current;
							num6 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num6 = 0;
							}
							goto IL_00cc;
							continue;
							end_IL_0154:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 2:
					if (kXJcsIEy9KUR81t9c3yP(e8UtyrEyJMgs3P3rCwlc(m), tableName, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 7;
				case 8:
					return null;
				case 16:
					if (HZtra3Eyp8v2JenA8gET(m) == EntityMetadataType.Interface)
					{
						num2 = 2;
						break;
					}
					goto case 7;
				case 10:
					if (!(IyYeWTEyd338qTIyidUk(m) != uid))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					obj = Td76TmEy4D9fbDElmmiZ(messageAdditionalInfo, jgyh0PEy1XR7gj3FqUWV(0x48A7E34A ^ 0x48A4AE1C));
					goto end_IL_0012;
				case 4:
					if (uid == Guid.Empty)
					{
						num2 = 14;
						break;
					}
					goto case 10;
				case 6:
					enumerator = ((EntityMetadata)m).TableParts.GetEnumerator();
					num2 = 12;
					break;
				case 1:
					return null;
				case 11:
					if (!(m is TablePartMetadata))
					{
						num2 = 5;
						break;
					}
					guid = GOm7ykEya66GGNQudyGE((TablePartMetadata)m);
					goto IL_0502;
				case 5:
					guid = ((AbstractMetadata)m).Uid;
					goto IL_0502;
				case 3:
				case 14:
					return new TestImportMessages(TestImportMessagesType.Error, (string)Td76TmEy4D9fbDElmmiZ(text, SR.T((string)jgyh0PEy1XR7gj3FqUWV(0x53CB464B ^ 0x53CFF371), tableName, ((NamedMetadata)m).DisplayName)));
				case 7:
					enumerator2 = ((ClassMetadata)m).Properties.GetEnumerator();
					num2 = 13;
					break;
				case 12:
					{
						try
						{
							while (true)
							{
								IL_041d:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 5;
									goto IL_03b1;
								}
								goto IL_03e9;
								IL_03b1:
								while (true)
								{
									switch (num3)
									{
									case 4:
										return result;
									case 3:
										result = testImportMessages;
										num3 = 4;
										continue;
									case 1:
										break;
									case 2:
										if (testImportMessages == null)
										{
											num3 = 7;
											continue;
										}
										goto case 3;
									case 6:
									case 7:
										goto IL_041d;
									default:
										testImportMessages = ValidateRelationTableNameForMd(ownerUid, tableName, current, uid, messageAdditionalInfo);
										num3 = 2;
										continue;
									case 5:
										goto end_IL_041d;
									}
									break;
								}
								goto IL_03e9;
								IL_03e9:
								current = enumerator.Current;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 0;
								}
								goto IL_03b1;
								continue;
								end_IL_041d:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto case 1;
					}
					IL_0502:
					if (LIZkmVEyMqSLO9DMXIxu(guid, ownerUid))
					{
						num2 = 17;
						break;
					}
					goto case 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			text = (string)obj;
			num = 11;
		}
	}

	private static TestImportMessages ValidateRelationTableName(Guid ownerUid, object tableName, object pm)
	{
		//Discarded unreachable code: IL_00aa, IL_00b9
		int num = 7;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (entitySettings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				if (!kXJcsIEy9KUR81t9c3yP(p8hxy5Ey5HsLifPDhL8Z(entitySettings), tableName, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 7:
				if (YhC6KSEyraWvue7dX7nj(ownerUid, IyYeWTEyd338qTIyidUk(pm)))
				{
					num2 = 6;
					break;
				}
				entitySettings = vyTd0IEygts4trlgPWVg(pm) as EntitySettings;
				num2 = 3;
				break;
			case 5:
				return new TestImportMessages(TestImportMessagesType.InfoMetadata, SR.T((string)jgyh0PEy1XR7gj3FqUWV(0x26FFCB59 ^ 0x26FB7ECD), tableName));
			case 4:
				return null;
			case 6:
				return null;
			case 1:
				if (p8hxy5Ey5HsLifPDhL8Z(entitySettings) != null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			default:
				if (entitySettings.RelationType == RelationType.ManyToMany)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public static bool CheckPropertyDisplayName(List<IMetadata> allProperties, IMetadata propertyMetadata, string name, out string message)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.propertyMetadata = propertyMetadata;
		message = null;
		if (allProperties == null)
		{
			return true;
		}
		IPropertyMetadata propertyMetadata2 = allProperties.OfType<IPropertyMetadata>().FirstOrDefault(delegate(IPropertyMetadata p)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec__DisplayClass14_0.osGWuj8tv8KJFl7rVL1S(_003C_003Ec__DisplayClass14_0.zVwfsg8tCIjubN1nBUeO(p), _003C_003Ec__DisplayClass14_0.zVwfsg8tCIjubN1nBUeO((IPropertyMetadata)CS_0024_003C_003E8__locals0.propertyMetadata));
				case 1:
					if (!_003C_003Ec__DisplayClass14_0.dNc06M8tQm7QRWVjU95R(p.DisplayName, CS_0024_003C_003E8__locals0.name, StringComparison.CurrentCultureIgnoreCase))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		if (propertyMetadata2 != null)
		{
			message = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29021317), propertyMetadata2.Name, propertyMetadata2.Uid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477373468)));
			return false;
		}
		return true;
	}

	public static bool CheckPropertyName(List<IMetadata> allProperties, IMetadata propertyMetadata, string mdName, string name, out string message)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.propertyMetadata = propertyMetadata;
		message = null;
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.name) || CS_0024_003C_003E8__locals0.name.Trim().Equals(string.Empty))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E6CD22));
			return false;
		}
		if (allProperties == null)
		{
			return true;
		}
		if (CS_0024_003C_003E8__locals0.name.Equals(mdName, StringComparison.CurrentCultureIgnoreCase))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECAE5D0));
			return false;
		}
		IPropertyMetadata propertyMetadata2 = allProperties.OfType<IPropertyMetadata>().FirstOrDefault(delegate(IPropertyMetadata p)
		{
			//Discarded unreachable code: IL_007c, IL_008b
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!_003C_003Ec__DisplayClass15_0.oam5e88tVNE3qPJHppZl(p.Name, CS_0024_003C_003E8__locals0.name, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return _003C_003Ec__DisplayClass15_0.l8EGqB8tiol4BkqaNMWN(_003C_003Ec__DisplayClass15_0.FGvlhT8tSZ20WJ7uW1WP(p), _003C_003Ec__DisplayClass15_0.FGvlhT8tSZ20WJ7uW1WP((IPropertyMetadata)CS_0024_003C_003E8__locals0.propertyMetadata));
				default:
					return false;
				}
			}
		});
		if (propertyMetadata2 != null)
		{
			message = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A19546), propertyMetadata2.Name, propertyMetadata2.Uid, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463EB87C)));
			return false;
		}
		if (!CS_0024_003C_003E8__locals0.name.IsValidIdentifier())
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17A97B48));
			return false;
		}
		if (CSharpHelper.IsKeyword(CS_0024_003C_003E8__locals0.name))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957580590));
			return false;
		}
		return true;
	}

	public static bool CheckPropertyFieldName(List<IMetadata> allProperties, IMetadata propertyMetadata, string name, out string message)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.name = name;
		message = null;
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.name) || CS_0024_003C_003E8__locals0.name.Trim().Equals(string.Empty))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D18A632));
			return false;
		}
		if (allProperties == null)
		{
			return true;
		}
		if (GetFieldNames(allProperties, ((IPropertyMetadata)propertyMetadata).PropertyUid).Any((string n) => _003C_003Ec__DisplayClass16_0.adBt1c8tTWaeU9YJYvd3(n, CS_0024_003C_003E8__locals0.name, StringComparison.CurrentCultureIgnoreCase)))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BF0C3E), CS_0024_003C_003E8__locals0.name);
			return false;
		}
		if (CS_0024_003C_003E8__locals0.name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418522F)))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234068406));
			return false;
		}
		if (!CS_0024_003C_003E8__locals0.name.IsValidIdentifier())
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36344AA5));
			return false;
		}
		if (CS_0024_003C_003E8__locals0.name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7451F5C), StringComparison.CurrentCultureIgnoreCase))
		{
			message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A5DEB1), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECDBB6C));
			return false;
		}
		return true;
	}

	public static TestImportMessages ValidateFieldName(string name)
	{
		//Discarded unreachable code: IL_0137, IL_0146, IL_0155
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return new TestImportMessages(TestImportMessagesType.Error, (string)iYkomWEyHtAk2crgG1XY(jgyh0PEy1XR7gj3FqUWV(-1088304168 ^ -1088064894)));
			case 1:
			case 4:
				return new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E8ADE9)));
			case 6:
				if (!YMXRFkEyjSRmaChaVYhL(name.Trim(), string.Empty))
				{
					if (!name.StartsWith((string)jgyh0PEy1XR7gj3FqUWV(-3333094 ^ -3332000)))
					{
						if (name.IsValidIdentifier())
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 3;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 5;
					}
					break;
				}
				num2 = 4;
				break;
			case 3:
				return new TestImportMessages(TestImportMessagesType.Error, (string)iYkomWEyHtAk2crgG1XY(jgyh0PEy1XR7gj3FqUWV(-1824388195 ^ -1824083367)));
			default:
				return null;
			case 2:
				if (string.IsNullOrEmpty(name))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	private static string[] GetFieldNames(IEnumerable<IMetadata> properties, Guid ignorePropertyUid)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.ignorePropertyUid = ignorePropertyUid;
		return (from s in (from p in properties.OfType<PropertyMetadata>()
				where _003C_003Ec__DisplayClass18_0.BaoPRR8tPvJScPY3S5UL(_003C_003Ec__DisplayClass18_0.UgxPiA8teFAQCf5oDCVC(p), CS_0024_003C_003E8__locals0.ignorePropertyUid)
				select (TypeSettings)_003C_003Ec.YRcUcK8DLyeyHYlOQ86q(p)).OfType<SimpleTypeSettings>()
			select (string[])_003C_003Ec.JDmeIw8DUw6gkT8N0rXg(s) into fn
			where fn != null
			select fn).SelectMany((string[] fn) => fn).ToArray();
	}

	public static string CheckEnumValueDisplayName(EnumValueMetadata valueMetadata, string name, List<EnumValueMetadata> allValues)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.valueMetadata = valueMetadata;
		if (allValues.FirstOrDefault(delegate(EnumValueMetadata p)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!_003C_003Ec__DisplayClass19_0.fUPYkN8tDdksZqNSwDGS(_003C_003Ec__DisplayClass19_0.nNjCC08taT98eFmqgNL4(p), CS_0024_003C_003E8__locals0.name, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return _003C_003Ec__DisplayClass19_0.t67m2g8twt5OPpKeXhP4(_003C_003Ec__DisplayClass19_0.YKOHUm8tt41eq2BcIKgM(p), _003C_003Ec__DisplayClass19_0.YKOHUm8tt41eq2BcIKgM(CS_0024_003C_003E8__locals0.valueMetadata));
				default:
					return false;
				}
			}
		}) != null)
		{
			return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x7696E72));
		}
		return null;
	}

	public static string CheckEnumValueName(EnumValueMetadata valueMetadata, string name, List<EnumValueMetadata> allValues)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.valueMetadata = valueMetadata;
		if (allValues.OfType<NamedMetadata>().FirstOrDefault(delegate(NamedMetadata p)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!_003C_003Ec__DisplayClass20_0.qWXe6a8txO2X18ZP8Vi8(_003C_003Ec__DisplayClass20_0.rx0sKF8t768MCxHlylLn(p), CS_0024_003C_003E8__locals0.name, StringComparison.CurrentCultureIgnoreCase))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return _003C_003Ec__DisplayClass20_0.og027K8tm6JBlE3QGgF3(_003C_003Ec__DisplayClass20_0.hZa4ok8t00ObgYdMPMOs(p), CS_0024_003C_003E8__locals0.valueMetadata.Uid);
				}
			}
		}) != null)
		{
			return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A199A2));
		}
		if (!CS_0024_003C_003E8__locals0.name.IsValidIdentifier())
		{
			return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E8B7F4));
		}
		if (CSharpHelper.IsKeyword(CS_0024_003C_003E8__locals0.name))
		{
			return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475642773));
		}
		return null;
	}

	public static string CheckEnumIntValue(EnumValueMetadata valueMetadata, int? intValue, List<EnumValueMetadata> allValues)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.intValue = intValue;
		CS_0024_003C_003E8__locals0.valueMetadata = valueMetadata;
		string result = null;
		if (!CS_0024_003C_003E8__locals0.intValue.HasValue)
		{
			return result;
		}
		if (allValues.FirstOrDefault(delegate(EnumValueMetadata p)
		{
			int num = 2;
			int num2 = num;
			int? intValue2 = default(int?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (intValue2.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				case 4:
					if (intValue2.Value == CS_0024_003C_003E8__locals0.intValue.Value)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					intValue2 = p.IntValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					intValue2 = p.IntValue;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return _003C_003Ec__DisplayClass21_0.IXVguT8tdOv9onYXve6r(_003C_003Ec__DisplayClass21_0.Xs6Zdr8t90r1d4VCCCCi(p), _003C_003Ec__DisplayClass21_0.Xs6Zdr8t90r1d4VCCCCi(CS_0024_003C_003E8__locals0.valueMetadata));
				}
				break;
			}
			return false;
		}) != null)
		{
			return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487078360));
		}
		return null;
	}

	internal static bool XRkrLSEy2qfJLREGCI0B(object P_0)
	{
		return ((IMetadata)P_0).IsSystem();
	}

	internal static bool IDvr2BEyeY7516cnNhlA(object P_0)
	{
		return ((IMetadata)P_0).IsConfig();
	}

	internal static bool FLVHwsEynHRDoTRI97e4()
	{
		return ILhJuvEykNKYmlqIYu2d == null;
	}

	internal static MetadataImportHelper PPoZx3EyON5B3hb50Iqm()
	{
		return ILhJuvEykNKYmlqIYu2d;
	}

	internal static bool ApapVyEyP3LmxV9sDU5W(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object jgyh0PEy1XR7gj3FqUWV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jK9OTtEyNDaCFAyR8mVR(object P_0)
	{
		return CSharpHelper.IsKeyword((string)P_0);
	}

	internal static object SsJUppEy3PnZ6h2mMab2()
	{
		return MetadataServiceContext.Service;
	}

	internal static EntityMetadataType HZtra3Eyp8v2JenA8gET(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid GOm7ykEya66GGNQudyGE(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static object t4oYKSEyDXEhmVqo2RQt(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static int js7CQUEytgX4utoivcHE(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object PPxEimEywpOTRbu4HjTt(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object Td76TmEy4D9fbDElmmiZ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool T3rjTWEy6gd9DkVBVCYe(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object iYkomWEyHtAk2crgG1XY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool xqo1qPEyAOxmC4E7GLum(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object wdxxmBEy7wiZcu1mKmfl(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static int yV5VfdEyxKnJlfq2vb1S(object P_0)
	{
		return ((Dialect)P_0).MaxTableNameLength;
	}

	internal static bool kEmFYtEy0rQ2v31HI1ZU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void P4CWWAEympblS5thpmGf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool T8AooyEyy690hqDxRI3k(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool LIZkmVEyMqSLO9DMXIxu(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object e8UtyrEyJMgs3P3rCwlc(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool kXJcsIEy9KUR81t9c3yP(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static Guid IyYeWTEyd338qTIyidUk(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object BlV9LREyl62uYSMYkxPq(Guid ownerUid, object P_1, object P_2)
	{
		return ValidateRelationTableName(ownerUid, P_1, P_2);
	}

	internal static bool YhC6KSEyraWvue7dX7nj(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object vyTd0IEygts4trlgPWVg(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object p8hxy5Ey5HsLifPDhL8Z(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static bool YMXRFkEyjSRmaChaVYhL(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}
}
