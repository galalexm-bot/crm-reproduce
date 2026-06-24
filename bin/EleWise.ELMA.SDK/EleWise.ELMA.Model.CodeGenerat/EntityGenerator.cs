using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.SDK;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class EntityGenerator : ClassGenerator
{
	protected new EntityMetadata metadata;

	protected const string CoreEntity = "EleWise.ELMA.Core.Model.Entities.Entity";

	protected const string PROP_TYPE_UID = "TypeUid";

	public const string FILTER_POSTFIX = "Filter";

	protected const string RES_FILTER_PROPERTY_PREFIX = "FP_";

	private static EntityGenerator kbJOjVh46eb27EitZRWa;

	protected virtual bool NeedWriteTypeUidProperty
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return lchJ5Mh4rEikjPPyyE7c(NiD7lIh4lrZSiVhJIdCw(metadata), Guid.Empty);
				case 1:
					if (metadata.AllowCreateHeirs)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual bool HasFilterClass
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return metadata.Filterable;
				case 1:
					mFmaRqh4JG13Q1JZSJYF(metadata, Lure5ih4xuXECmddpOn0(0x4A1640F ^ 0x4A12D31));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual string FilterClassName
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)OdisQ5h45npiCgl1fSk1(metadata) + (string)Lure5ih4xuXECmddpOn0(0x18A6761F ^ 0x18A63523);
				case 1:
					mFmaRqh4JG13Q1JZSJYF(metadata, Lure5ih4xuXECmddpOn0(-2107978722 ^ -2107996896));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Не используется")]
	protected virtual bool HasPermissionClass
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					mFmaRqh4JG13Q1JZSJYF(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765837804));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return EntityMetadataExtensions.GetActivePermissionMetadataFromMetadata(metadata) != null;
				}
				if (NiD7lIh4lrZSiVhJIdCw(metadata) == Guid.Empty)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				return false;
			}
		}
	}

	protected virtual bool HasActionsType
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					mFmaRqh4JG13Q1JZSJYF(metadata, Lure5ih4xuXECmddpOn0(-29254301 ^ -29240227));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return HasActions(metadata);
				}
			}
		}
	}

	protected string ActionsTypeName => (string)WLWaYhh637vbhDVYNLWI(metadata);

	protected override bool HasCustomCode
	{
		get
		{
			//Discarded unreachable code: IL_00db, IL_00ea
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (metadata.ImplementedExtensionUids != null)
						{
							num2 = 2;
							continue;
						}
						return false;
					case 3:
						if (HasCustomCodeInternal(metadata))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					case 4:
						break;
					case 2:
						return metadata.ImplementedExtensionUids.Select((Guid extUid) => (EntityMetadata)GetMetadata(extUid)).Any(HasCustomCodeInternal);
					case 1:
						return true;
					}
					break;
				}
				mFmaRqh4JG13Q1JZSJYF(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE394B7));
				num = 3;
			}
		}
	}

	public static string GetActionsTypeName(EntityMetadata entityMetadata)
	{
		return (string)YgAF88h47bK52hNKwHkw(entityMetadata) + (string)Lure5ih4xuXECmddpOn0(0x1A33FE36 ^ 0x1A308A12);
	}

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				base.InitInternal(metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				DaDv3eh40sQ322l76aZb(metadata, Lure5ih4xuXECmddpOn0(0x63ABA4E8 ^ 0x63ABEDD6));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			default:
				this.metadata = (EntityMetadata)metadata;
				num2 = 3;
				break;
			case 1:
				a31mADh4mAyn0MqGCXIw(metadata is EntityMetadata, Lure5ih4xuXECmddpOn0(-29254301 ^ -29169323));
				num2 = 4;
				break;
			}
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return base.GenerateAdditionalFilesInternal().Concat(GenerateActions()).Concat(WritePermissionClass())
			.If(metadata.ViewModelMetadata != null, (IEnumerable<GeneratedFileInfo> files) => files.Concat(GenerateViewModelMetadataResource()));
	}

	protected ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		return (ITypeDescriptor)dXBXQDh4MfTwOTiQ9YJO(xDsK1Rh4yIVqvV4PvIE1(), typeUid);
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		return base.GenerateMainFile().If(metadata.IsInterfaceType, (IEnumerable<ISyntaxNode> n) => n.Concat(WriteFilterInterface())).If(!metadata.IsInterfaceType, (IEnumerable<ISyntaxNode> n) => n.Concat(WriteFilterClass()))
			.Concat(WriteTablePartClasses());
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return base.GetNamespaces().Concat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541802045).NamespaceImportDeclaration());
	}

	protected ITypeDescriptor GetIdTypeDescriptor()
	{
		//Discarded unreachable code: IL_0078, IL_0114, IL_0123
		int num = 1;
		int num2 = num;
		ITypeDescriptor idTypeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				mFmaRqh4JG13Q1JZSJYF(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870906615));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!R3QjKTh4dJc43SLGVFkn(bMoiflh49hGNPYf30f54(metadata), Guid.Empty))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 3:
				throw new CodeGenerationException(SR.T((string)Lure5ih4xuXECmddpOn0(-2107978722 ^ -2108049296)));
			case 4:
				idTypeDescriptor = GetIdTypeDescriptor(metadata.IdTypeUid);
				num2 = 6;
				break;
			case 6:
				if (idTypeDescriptor != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 5:
				throw new CodeGenerationException(SR.T((string)Lure5ih4xuXECmddpOn0(0x1637C429 ^ 0x1634B081), bMoiflh49hGNPYf30f54(metadata)));
			case 2:
				return idTypeDescriptor;
			}
		}
	}

	protected virtual ISyntaxNode GetBasicEntity(ISyntaxNode idTypeRef)
	{
		return EleWise.ELMA.SDK.TypeOf.Entity1.Raw.CreateTypeSyntax(idTypeRef);
	}

	protected override ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		ISyntaxNode propertyTypeReference = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (ISyntaxNode)x2q7tCh4Lnqj9XJOt3m5(this, propertyTypeReference);
			case 4:
				mFmaRqh4JG13Q1JZSJYF(metadata, Lure5ih4xuXECmddpOn0(-1824388195 ^ -1824374109));
				num2 = 3;
				break;
			case 3:
				if (!lchJ5Mh4rEikjPPyyE7c(NiD7lIh4lrZSiVhJIdCw(metadata), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return ((string)ooTnNAh4YFoC7vNBaXJU((UVUZlXh4gO4ZKuJ4pbkr(this, metadata.BaseClassUid) as EntityMetadata) ?? throw new CodeGenerationException((string)si7jdTh4jjc6VeHqnL2f(Lure5ih4xuXECmddpOn0(-740338220 ^ -740548316), OdisQ5h45npiCgl1fSk1(metadata), metadata.BaseClassUid)))).CreateTypeSyntax();
			case 1:
				propertyTypeReference = ((ITypeGenerationInfo)GetIdTypeDescriptor()).GetPropertyTypeReference(metadata, null, forFilter: false);
				num2 = 2;
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetBaseInterfaces_003Ed__15))]
	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetBaseInterfaces_003Ed__15(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_0254, IL_0302, IL_0311, IL_0355, IL_0364, IL_0393, IL_044d, IL_04bc, IL_04e5, IL_05b5, IL_05c5, IL_05d4, IL_05df, IL_068e, IL_06a1, IL_06b0, IL_0873, IL_0882, IL_088d, IL_08e2, IL_08f1, IL_09c5, IL_09d8, IL_0a17, IL_0a26, IL_0a31, IL_0af4, IL_0b07, IL_0b16, IL_0b93, IL_0ba2, IL_0d06, IL_0d15, IL_0d25, IL_0d34, IL_0d44, IL_0eb1
		int num = 24;
		List<ISyntaxNode> list = default(List<ISyntaxNode>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<EleWise.ELMA.Common.PropertiesContainer>.Enumerator enumerator = default(List<EleWise.ELMA.Common.PropertiesContainer>.Enumerator);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		string text = default(string);
		List<TablePartMetadata>.Enumerator enumerator3 = default(List<TablePartMetadata>.Enumerator);
		Guid current2 = default(Guid);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					list.Add(TypeOf<FilterableAttribute>.Raw.CreateAttribute());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
				case 66:
					if (!HasFilterClass)
					{
						num2 = 74;
						continue;
					}
					goto case 21;
				case 54:
					list.Add(TypeOf<ViewModelMetadataAttribute>.Raw.CreateAttribute(k41Lnah68679sJSS8mHc(metadata.TypeName), GetViewModelMetadataResourceName()));
					num2 = 3;
					continue;
				case 35:
					list.Add(TypeOf<EntityMetadataTypeAttribute>.Raw.CreateAttribute(metadata.Type));
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 12;
					}
					continue;
				case 68:
					entityMetadata = (EntityMetadata)UVUZlXh4gO4ZKuJ4pbkr(this, zRrt6ih6vwMl5uTCobf5(metadata));
					num2 = 70;
					continue;
				case 17:
					if (metadata.Type != EntityMetadataType.InterfaceExtension)
					{
						num2 = 64;
						continue;
					}
					goto case 30;
				case 30:
				case 51:
					if (eJjCAEh4z69gYosmRvfM(metadata) == EntityMetadataType.InterfaceImplementation)
					{
						num2 = 43;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 68;
						}
						continue;
					}
					goto case 7;
				case 57:
					enumerator = metadata.PropertiesDiffContainer.GetEnumerator();
					num2 = 65;
					continue;
				case 26:
					list.Add(TypeOf<CacheEntityAttribute>.Raw.CreateAttribute());
					num = 58;
					break;
				case 13:
				case 41:
					if (eJjCAEh4z69gYosmRvfM(metadata) == EntityMetadataType.Entity)
					{
						num2 = 29;
						continue;
					}
					goto case 35;
				case 6:
				case 58:
					if (!metadata.InstancePermissionsSupport)
					{
						num2 = 67;
						continue;
					}
					goto case 22;
				case 39:
					list.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(k41Lnah68679sJSS8mHc(entityMetadata.FullTypeName)));
					num = 32;
					break;
				case 53:
					if (!string.IsNullOrWhiteSpace(metadata.PermissionsPropertyName))
					{
						num2 = 22;
						continue;
					}
					goto case 17;
				case 11:
				case 56:
					if (eJjCAEh4z69gYosmRvfM(metadata) == EntityMetadataType.InterfaceExtension)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 31;
				case 32:
				case 62:
					if (metadata.ImplementedExtensionUids == null)
					{
						num2 = 66;
						continue;
					}
					goto case 27;
				case 12:
					if (!tablePartMetadata.Required)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 75;
				case 1:
					if (R3QjKTh4dJc43SLGVFkn(metadata.BaseClassUid, Guid.Empty))
					{
						num2 = 50;
						continue;
					}
					goto case 42;
				case 27:
					enumerator2 = metadata.ImplementedExtensionUids.GetEnumerator();
					num2 = 8;
					continue;
				case 5:
					return;
				case 36:
					list.Add(TypeOf<EntityAttribute>.Raw.CreateAttribute(FWJOG3h4U2n29mDVeeBb(metadata)));
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 69:
					list.Add(TypeOf<NonUniqueAttribute>.Raw.CreateAttribute());
					num2 = 42;
					continue;
				case 50:
					if (DBqUGph6oX9DJSNosyQr(metadata))
					{
						num2 = 44;
						continue;
					}
					goto case 69;
				case 14:
				case 71:
					list.Add((ISyntaxNode)d086YZh6S8PE6NleXWpm(TypeOf<TablePartInfoAttribute>.Raw, new Dictionary<string, object>
					{
						{
							(string)Lure5ih4xuXECmddpOn0(-812025778 ^ -811987682),
							r009cKh6Iy1mTS1Pt4VZ(tablePartMetadata).ToString()
						},
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F975B2),
							tablePartMetadata.TablePartPropertyUid.ToString()
						},
						{
							(string)Lure5ih4xuXECmddpOn0(-2112703338 ^ -2112765640),
							D5wmwih6VIVUZtd3Dw6I(tablePartMetadata)
						}
					}.ToArray()));
					num2 = 25;
					continue;
				case 4:
					list.Add(TypeOf<SaveHistoryAttribute>.Raw.CreateAttribute());
					num2 = 59;
					continue;
				case 65:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator.MoveNext())
							{
								num7 = 3;
								goto IL_05e3;
							}
							goto IL_0639;
							IL_05e3:
							while (true)
							{
								switch (num7)
								{
								case 1:
									list.Add(TypeOf<OverrideExtensibleClassPropertyAttribute>.Raw.CreateAttribute(text));
									num7 = 2;
									continue;
								case 2:
									break;
								default:
									goto IL_0639;
								case 3:
									goto end_IL_0623;
								}
								break;
							}
							continue;
							IL_0639:
							text = ClassSerializationHelper.SerializeObjectByXml(enumerator.Current);
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num7 = 1;
							}
							goto IL_05e3;
							continue;
							end_IL_0623:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 31;
				case 45:
					if (!g2o0Nnh4cEmdfTaEry3N(metadata))
					{
						num2 = 41;
						continue;
					}
					goto case 15;
				case 9:
					list.Add(TypeOf<ActionsTypeAttribute>.Raw.CreateAttribute(k41Lnah68679sJSS8mHc(ActionsTypeName)));
					num2 = 72;
					continue;
				case 55:
					list.Add(TypeOf<ShowInCatalogListAttribute>.Raw.CreateAttribute(IMO1HHh4sxFwjRpX5gxV(metadata)));
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 45;
					}
					continue;
				case 2:
					enumerator3 = metadata.TableParts.GetEnumerator();
					num2 = 40;
					continue;
				case 70:
					if (entityMetadata == null)
					{
						num2 = 62;
						continue;
					}
					goto case 39;
				case 3:
					type.AddAttributes(list);
					num2 = 5;
					continue;
				case 60:
					list = new List<ISyntaxNode>();
					num2 = 36;
					continue;
				case 46:
					if (eJjCAEh4z69gYosmRvfM(metadata) == EntityMetadataType.InterfaceImplementation)
					{
						num2 = 38;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 1;
				case 67:
					if (!gNSUMRh6GQkf3lB0kT0R(vi6JO1h6hMuHWZAOrpIl(metadata)))
					{
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 53;
				case 19:
				case 29:
					if (!fJFNPuh6FvsiF3bUBWnM(metadata))
					{
						num2 = 28;
						continue;
					}
					goto case 4;
				case 47:
					list.Add(TypeOf<OrderAttribute>.Raw.CreateAttribute(W6pqiph6ubpTQyqOWjiU(tablePartMetadata)));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 2;
					}
					continue;
				case 37:
					if (metadata.PropertiesDiffContainer.Count > 0)
					{
						num2 = 57;
						continue;
					}
					goto case 31;
				case 8:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
								{
									num5 = 0;
								}
								goto IL_0891;
							}
							goto IL_0946;
							IL_0946:
							current2 = enumerator2.Current;
							num5 = 4;
							goto IL_0891;
							IL_0891:
							while (true)
							{
								switch (num5)
								{
								case 4:
									entityMetadata2 = (EntityMetadata)UVUZlXh4gO4ZKuJ4pbkr(this, current2);
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
									{
										num5 = 0;
									}
									continue;
								case 2:
									if (entityMetadata2 == null)
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 1;
								case 5:
									goto IL_0946;
								case 1:
									list.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(k41Lnah68679sJSS8mHc(entityMetadata2.FullTypeName)));
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
									{
										num5 = 3;
									}
									continue;
								case 6:
									goto end_IL_08b7;
								}
								break;
							}
							continue;
							end_IL_08b7:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 21:
					list.Add(TypeOf<FilterTypeAttribute>.Raw.CreateAttribute(k41Lnah68679sJSS8mHc(FilterClassName)));
					num2 = 63;
					continue;
				case 40:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator3.MoveNext())
							{
								num3 = 3;
								goto IL_0a35;
							}
							goto IL_0aa5;
							IL_0a35:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									list.Add(TypeOf<TablePartAttribute>.Raw.CreateAttribute(k41Lnah68679sJSS8mHc(OdisQ5h45npiCgl1fSk1(current))));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									goto IL_0aa5;
								case 3:
									goto end_IL_0a4f;
								}
								break;
							}
							continue;
							IL_0aa5:
							current = enumerator3.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num3 = 0;
							}
							goto IL_0a35;
							continue;
							end_IL_0a4f:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 11;
				case 15:
					list.Add(TypeOf<HideChildItemsTabAttribute>.Raw.CreateAttribute(g2o0Nnh4cEmdfTaEry3N(metadata)));
					num = 13;
					break;
				case 23:
					Contract.NotNull(metadata, (string)Lure5ih4xuXECmddpOn0(-477139494 ^ -477158172));
					num2 = 73;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 22;
					}
					continue;
				case 73:
					base.WriteTypeAttributes(type);
					num2 = 60;
					continue;
				case 24:
					DaDv3eh40sQ322l76aZb(type, Lure5ih4xuXECmddpOn0(0x61EC0CB8 ^ 0x61EC009A));
					num2 = 23;
					continue;
				case 43:
					list.Add(TypeOf<OnChangeScriptNameAttribute>.Raw.CreateAttribute(CoKCyAh6i5WxjfPAC5hR(tablePartMetadata)));
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 61;
					}
					continue;
				case 28:
				case 59:
					if (Ni8eI1h6BLd27aPseTRl(metadata) == CopyAction.Default)
					{
						num2 = 20;
						continue;
					}
					goto case 10;
				case 75:
					list.Add(TypeOf<RequiredAttribute>.Raw.CreateAttribute(true));
					num = 71;
					break;
				case 33:
					if (Q6JfWth6fICcfyNxn948(metadata))
					{
						num2 = 52;
						continue;
					}
					goto case 30;
				case 63:
				case 74:
					if (cFEgrCh6ZNxfQR4UcOWO(this))
					{
						num2 = 9;
						continue;
					}
					goto case 72;
				case 16:
					if (tablePartMetadata != null)
					{
						num2 = 47;
						continue;
					}
					goto case 61;
				case 22:
				case 49:
					list.Add(TypeOf<InstancePermissionAttribute>.Raw.CreateAttribute(J5cfJyh6EplgSseCSRxo(metadata), vi6JO1h6hMuHWZAOrpIl(metadata), metadata.PermissionsPropertyName));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 17;
					}
					continue;
				case 61:
					if (metadata.TableParts == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 2;
				case 72:
					tablePartMetadata = metadata as TablePartMetadata;
					num2 = 16;
					continue;
				case 38:
					list.Add(TypeOf<ImplementationUidAttribute>.Raw.CreateAttribute(metadata.ImplementationUid.ToString()));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					continue;
				case 42:
				case 44:
					if (!A0d4wah6bhh3eKnPqO7v(metadata))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 26;
				case 25:
					if (!yI8YoVh6RiCrKxSPiCIK(CoKCyAh6i5WxjfPAC5hR(tablePartMetadata)))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto case 61;
				case 10:
					list.Add(TypeOf<CopyActionAttribute>.Raw.CreateAttribute(Ni8eI1h6BLd27aPseTRl(metadata)));
					num = 48;
					break;
				case 34:
					list.Add(TypeOf<IdTypeAttribute>.Raw.CreateAttribute(bMoiflh49hGNPYf30f54(metadata).ToString()));
					num = 55;
					break;
				case 31:
					if (KQ4Qd1h6qETRKbfcpTLS(metadata) != null)
					{
						num2 = 54;
						continue;
					}
					goto case 3;
				case 20:
				case 48:
					if (pq9CMRh6WsZg7okAShQk(metadata))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto default;
				case 64:
					if (!R3QjKTh4dJc43SLGVFkn(NiD7lIh4lrZSiVhJIdCw(metadata), Guid.Empty))
					{
						num2 = 30;
						continue;
					}
					goto case 33;
				default:
					if (eJjCAEh4z69gYosmRvfM(metadata) != EntityMetadataType.Interface)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 38;
				case 52:
					list.Add(TypeOf<HierarchicalAttribute>.Raw.CreateAttribute(mOKlJSh6QIed4wrMvLSH(metadata), metadata.ParentPropertyUid.ToString(), (TCDAm3h6C36JI6eDx6ql(metadata) != Guid.Empty) ? TCDAm3h6C36JI6eDx6ql(metadata).ToString() : null));
					num2 = 51;
					continue;
				}
				break;
			}
		}
	}

	protected string GetEntityTypeName(int? tableNumber = null)
	{
		return metadata.FullTypeName + ((!tableNumber.HasValue) ? "" : (z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECE5F70) + tableNumber.Value));
	}

	protected ISyntaxNode GetEntityTypeRef(int? tableNumber = null)
	{
		return GetEntityTypeName(tableNumber).CreateTypeSyntax();
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return EntityDescriptor.RunWithCheckSoftDeletable(() => base.GetMembers().ToArray());
	}

	protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements)
	{
		return base.GetProperties(ctorStatements).If(NeedWriteTypeUidProperty && !metadata.IsInterfaceType, (IEnumerable<ISyntaxNode> m) => m.Concat(WriteTypeUidProperty())).Concat(WriteTablePartProperties(ctorStatements))
			.If(metadata is TablePartMetadata && !metadata.IsInterfaceType, (IEnumerable<ISyntaxNode> m) => m.Concat(WriteTablePartParentProperty()));
	}

	[IteratorStateMachine(typeof(_003CWriteTypeUidProperty_003Ed__23))]
	protected virtual IEnumerable<ISyntaxNode> WriteTypeUidProperty()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteTypeUidProperty_003Ed__23(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual string GetTableName(int? tableNumber)
	{
		return NHibernateClassMapping.GetTableName(metadata, tableNumber);
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		//Discarded unreachable code: IL_0111
		int num = 12;
		int num2 = num;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		List<ISyntaxNode> list = default(List<ISyntaxNode>);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 17:
				if (YtpVcWh6kTcVJnnKf7vZ(entityPropertyMetadata))
				{
					num2 = 19;
					continue;
				}
				goto case 6;
			case 8:
				if (f38vJUh6Xt2Q4wTcWZsN(entityPropertyMetadata))
				{
					num2 = 18;
					continue;
				}
				goto case 10;
			case 9:
				return;
			case 13:
				base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				if (((EntityPropertyMetadata)propertyMetadata).Filterable)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 10:
				if (!KqOoB4h6TcEqWiiB9H52(entityPropertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 16;
			case 7:
				list.Add(TypeOf<FastSearchAttribute>.Raw.CreateAttribute(entityPropertyMetadata.InFastSearch));
				num2 = 8;
				continue;
			case 4:
				if (CtAqYEh6KYMhne8E1xYM(entityPropertyMetadata))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 8;
			case 18:
				list.Add(TypeOf<ShowInTableAttribute>.Raw.CreateAttribute(f38vJUh6Xt2Q4wTcWZsN(entityPropertyMetadata)));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 10;
				}
				continue;
			case 19:
				list.Add(TypeOf<OutputAttribute>.Raw.CreateAttribute(entityPropertyMetadata.Output));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				entityPropertyMetadata = propertyMetadata as EntityPropertyMetadata;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 5;
				}
				continue;
			case 12:
				Contract.ArgumentNotNull(property, (string)Lure5ih4xuXECmddpOn0(-70007027 ^ -70066677));
				num2 = 11;
				continue;
			case 14:
				property.AddAttributes(list);
				num2 = 9;
				continue;
			case 11:
				DaDv3eh40sQ322l76aZb(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42647B51));
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 12;
				}
				continue;
			default:
				list.Add(TypeOf<FilterableAttribute>.Raw.CreateAttribute());
				num2 = 3;
				continue;
			case 16:
				list.Add(TypeOf<InputAttribute>.Raw.CreateAttribute(KqOoB4h6TcEqWiiB9H52(entityPropertyMetadata)));
				num2 = 17;
				continue;
			case 15:
				return;
			case 5:
				if (entityPropertyMetadata != null)
				{
					list = new List<ISyntaxNode>();
					num2 = 4;
					continue;
				}
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 15;
				}
				continue;
			case 3:
				break;
			}
			List<ISyntaxNode> list2 = list;
			Type raw = TypeOf<EntityPropertyAttribute>.Raw;
			object[] args = ((entityPropertyMetadata.TableNumber <= 0) ? new ISyntaxNode[0] : new ISyntaxNode[1] { ((ISyntaxNode)Sre7cih6O15bF5sQn1b0(cyDidrh6nI2htiXI4dgL(entityPropertyMetadata))).AttributeArgument((string)Lure5ih4xuXECmddpOn0(-475857671 ^ -475952859)) });
			list2.Add(raw.CreateAttribute(args));
			num2 = 14;
		}
	}

	protected override IEnumerable<ISyntaxTrivia> Resources()
	{
		Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A56A60));
		return base.Resources().If(HasFilterClass, (IEnumerable<ISyntaxTrivia> m) => m.Concat(metadata.Filter.Properties.SelectMany((PropertyMetadata propertyMetadata) => PropertyResources(propertyMetadata))));
	}

	protected virtual ISyntaxNode GetBasicFilter()
	{
		return (ISyntaxNode)g9T6J9h62yV8JfUcvYSo(TypeOf<Filter>.Raw);
	}

	[IteratorStateMachine(typeof(_003CWriteFilterInterface_003Ed__32))]
	protected virtual IEnumerable<ISyntaxNode> WriteFilterInterface()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteFilterInterface_003Ed__32(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode WriteFilterClassByBaseClass(List<ISyntaxNode> attributes, List<ISyntaxNode> interfaceTypes)
	{
		EntityMetadata entityMetadata = null;
		if (metadata.BaseClassUid != Guid.Empty)
		{
			entityMetadata = GetMetadata(metadata.BaseClassUid) as EntityMetadata;
			while (entityMetadata != null && !entityMetadata.Filterable)
			{
				entityMetadata = ((entityMetadata.BaseClassUid != Guid.Empty) ? (GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata) : null);
			}
		}
		ISyntaxNode result = ((entityMetadata != null) ? (entityMetadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36011281)).CreateTypeSyntax() : GetBasicFilter());
		if (metadata.Type == EntityMetadataType.InterfaceImplementation)
		{
			string interfaceTypeName = GetInterfaceTypeName();
			if (interfaceTypeName != null)
			{
				interfaceTypes.Add((interfaceTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EE0A5)).CreateTypeSyntax());
				attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute((interfaceTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36011281)).TypeOfExpression()));
			}
			if (metadata.ImplementedExtensionUids != null)
			{
				foreach (Guid implementedExtensionUid in metadata.ImplementedExtensionUids)
				{
					if (GetMetadata(implementedExtensionUid) is EntityMetadata entityMetadata2 && entityMetadata2.Filterable)
					{
						interfaceTypes.Add((entityMetadata2.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411212655)).CreateTypeSyntax());
						attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute((entityMetadata2.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EA024)).TypeOfExpression()));
					}
				}
				return result;
			}
		}
		return result;
	}

	[IteratorStateMachine(typeof(_003CFilterForAttribute_003Ed__34))]
	protected virtual IEnumerable<ISyntaxNode> FilterForAttribute()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CFilterForAttribute_003Ed__34(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual string GetInterfaceTypeName()
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_0074, IL_0083
		int num = 4;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				if (pq9CMRh6WsZg7okAShQk(entityMetadata))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
			case 3:
				return null;
			case 2:
				return (string)ooTnNAh4YFoC7vNBaXJU(entityMetadata);
			case 4:
				if ((entityMetadata = UVUZlXh4gO4ZKuJ4pbkr(this, zRrt6ih6vwMl5uTCobf5(metadata)) as EntityMetadata) == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	protected virtual void FilterCommentSummary(ISyntaxNode filterType)
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
				filterType.XmlComments(SR.T((string)Lure5ih4xuXECmddpOn0(0x2ACE37D ^ 0x2AF968B), R0b7OPh6eWsZfSPakY43(metadata.DisplayName)).SummaryComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetFilterCtors_003Ed__37))]
	protected virtual IEnumerable<ISyntaxNode> GetFilterCtors(List<ISyntaxNode> ctorStatements)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetFilterCtors_003Ed__37(-2)
		{
			_003C_003E3__ctorStatements = ctorStatements
		};
	}

	protected virtual IEnumerable<ISyntaxNode> WriteFilterMembers()
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.ctorStatements = (metadata.IsInterfaceType ? null : new List<ISyntaxNode>());
		List<ISyntaxNode> second = (from p in metadata.Properties.OfType<EntityPropertyMetadata>()
			where _003C_003Ec.LqQIX4vOaTuqUiGt4HDG(p)
			select p).SelectMany((EntityPropertyMetadata prop) => CS_0024_003C_003E8__locals0._003C_003E4__this.FilterClassProperty(prop, CS_0024_003C_003E8__locals0.ctorStatements, isCustomProperty: false)).If(metadata.Filter != null && metadata.Filter.Properties != null, (IEnumerable<ISyntaxNode> p) => p.Concat(CS_0024_003C_003E8__locals0._003C_003E4__this.metadata.Filter.Properties.SelectMany((PropertyMetadata prop) => CS_0024_003C_003E8__locals0._003C_003E4__this.FilterClassProperty(prop, CS_0024_003C_003E8__locals0.ctorStatements, isCustomProperty: true)))).ToList();
		return GetFilterCtors(CS_0024_003C_003E8__locals0.ctorStatements).Concat(second);
	}

	[IteratorStateMachine(typeof(_003CWriteFilterClass_003Ed__39))]
	protected virtual IEnumerable<ISyntaxNode> WriteFilterClass()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteFilterClass_003Ed__39(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual PropertyMetadata CreateFilterPropertyMetadataFromProperty(ITypeDescriptor filterType, PropertyMetadata propertyMetadata)
	{
		PropertyMetadata propertyMetadata2 = ClassSerializationHelper.CloneObjectByXml(propertyMetadata);
		propertyMetadata2.Required = false;
		KcmcKlh6Pb4kh04y3fEn(propertyMetadata2, true);
		Yhhs7bh6N1fPs6N300vQ(propertyMetadata2, V7TQiKh610rtlRy05g1s(filterType, propertyMetadata));
		return propertyMetadata2;
	}

	[IteratorStateMachine(typeof(_003CWriteFilterClassProperty_003Ed__41))]
	protected virtual IEnumerable<ISyntaxNode> WriteFilterClassProperty(PropertyMetadata filterPropertyMetadata, List<ISyntaxNode> ctorStatements, bool isCustomProperty, ITypeDescriptor filterType)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteFilterClassProperty_003Ed__41(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__filterPropertyMetadata = filterPropertyMetadata,
			_003C_003E3__ctorStatements = ctorStatements,
			_003C_003E3__isCustomProperty = isCustomProperty,
			_003C_003E3__filterType = filterType
		};
	}

	[IteratorStateMachine(typeof(_003CFilterClassProperty_003Ed__42))]
	protected IEnumerable<ISyntaxNode> FilterClassProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool isCustomProperty)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CFilterClassProperty_003Ed__42(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__propertyMetadata = propertyMetadata,
			_003C_003E3__ctorStatements = ctorStatements,
			_003C_003E3__isCustomProperty = isCustomProperty
		};
	}

	private IEnumerable<GeneratedFileInfo> WritePermissionClass()
	{
		Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DB8CD));
		TablePartMetadata activePermissionMetadataFromMetadata = EntityMetadataExtensions.GetActivePermissionMetadataFromMetadata(metadata);
		if (activePermissionMetadataFromMetadata != null)
		{
			activePermissionMetadataFromMetadata.Namespace = metadata.Namespace;
			EntityPermissionsGenerator obj = new EntityPermissionsGenerator(metadata)
			{
				Metadata = activePermissionMetadataFromMetadata,
				GenerationParams = generationParams.Clone()
			};
			((ICodeGenerator)obj).GenerationParams.Prefix += activePermissionMetadataFromMetadata.Name;
			return ((ICodeGenerator)obj).GenerateAdditionalFiles();
		}
		return Enumerable.Empty<GeneratedFileInfo>();
	}

	protected virtual IEnumerable<GeneratedFileInfo> GenerateActions()
	{
		if (!HasActionsType)
		{
			return Enumerable.Empty<GeneratedFileInfo>();
		}
		string name = metadata.Actions.Name;
		string displayName = metadata.Actions.DisplayName;
		string @namespace = metadata.Actions.Namespace;
		try
		{
			metadata.Actions.Name = ActionsTypeName;
			metadata.Actions.DisplayName = string.Format(SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A74E19D)), metadata.DisplayName);
			metadata.Actions.Namespace = metadata.Namespace;
			EntityActionsGenerator entityActionsGenerator = new EntityActionsGenerator();
			entityActionsGenerator.EntityMetadata = metadata;
			((ICodeGenerator)entityActionsGenerator).Metadata = metadata.Actions;
			((ICodeGenerator)entityActionsGenerator).GenerationParams = generationParams.Clone();
			((ICodeGenerator)entityActionsGenerator).GenerationParams.Prefix = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3256258);
			return ((ICodeGenerator)entityActionsGenerator).Generate();
		}
		finally
		{
			metadata.Actions.Name = name;
			metadata.Actions.DisplayName = displayName;
			metadata.Actions.Namespace = @namespace;
		}
	}

	[IteratorStateMachine(typeof(_003CWriteTablePartClasses_003Ed__51))]
	protected virtual IEnumerable<ISyntaxNode> WriteTablePartClasses()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteTablePartClasses_003Ed__51(-2)
		{
			_003C_003E4__this = this
		};
	}

	[Obsolete("Метод устарел", true)]
	protected virtual EntityGenerator CreateTablePartGenerator()
	{
		return (EntityGenerator)TbfJJoh6pjUywntIw6Vm(this, null);
	}

	protected virtual EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (Uoe1NPh6aBaC3fYX4hQp(tablePart))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				if (tablePart != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return new EntityPermissionsGenerator(metadata);
			}
			break;
		}
		return new EntityGenerator();
	}

	protected virtual IEnumerable<ISyntaxNode> WriteTablePartClass(TablePartMetadata tablePart)
	{
		Contract.ArgumentNotNull(tablePart, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420970172));
		Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123618496));
		EntityGenerator entityGenerator = CreateTablePartGenerator(tablePart);
		((ICodeGenerator)entityGenerator).GenerationParams = generationParams;
		((ICodeGenerator)entityGenerator).Metadata = tablePart;
		return entityGenerator.GenerateMainFile();
	}

	[IteratorStateMachine(typeof(_003CWriteTablePartProperties_003Ed__55))]
	protected virtual IEnumerable<ISyntaxNode> WriteTablePartProperties(List<ISyntaxNode> ctorStatements)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteTablePartProperties_003Ed__55(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__ctorStatements = ctorStatements
		};
	}

	protected virtual IEnumerable<ISyntaxNode> WriteTablePartProperty(TablePartMetadata tablePart, List<ISyntaxNode> ctorStatements, bool writeAttributes = true)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass56_0();
		CS_0024_003C_003E8__locals0.writeAttributes = writeAttributes;
		Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195600341));
		Contract.ArgumentNotNull(tablePart, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475952485));
		CS_0024_003C_003E8__locals0.propertyMetadata = new EntityPropertyTablePartMetadata(metadata, tablePart);
		return WriteProperty(CS_0024_003C_003E8__locals0.propertyMetadata, ctorStatements, CS_0024_003C_003E8__locals0.writeAttributes, delegate(ISyntaxNode property)
		{
			//Discarded unreachable code: IL_00ac
			int num = 1;
			int num2 = num;
			List<ISyntaxNode> list = default(List<ISyntaxNode>);
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 4:
					list.Add(TypeOf<TablePartPropertyAttribute>.Raw.CreateAttribute());
					num2 = 6;
					break;
				case 3:
					return;
				case 5:
					list.Add(TypeOf<UidAttribute>.Raw.CreateAttribute(_003C_003Ec__DisplayClass56_0.krDQVfvefThpXukGhRLL(CS_0024_003C_003E8__locals0.propertyMetadata).ToString()));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 4;
					}
					break;
				case 6:
					property.AddAttributes(list);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 3;
					}
					break;
				default:
					if (CS_0024_003C_003E8__locals0.writeAttributes)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 5;
				case 1:
					list = new List<ISyntaxNode>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	[IteratorStateMachine(typeof(_003CWriteTablePartParentProperty_003Ed__57))]
	protected virtual IEnumerable<ISyntaxNode> WriteTablePartParentProperty()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteTablePartParentProperty_003Ed__57(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual GeneratedFileInfo GenerateViewModelMetadataResource()
	{
		GeneratedFileInfo obj = new GeneratedFileInfo
		{
			Data = ClassSerializationHelper.SerializeObjectByXmlToBytes(KQ4Qd1h6qETRKbfcpTLS(metadata)),
			Extension = GetViewModelMetadataResourceExtension()
		};
		fic5keh6DCyqW3XvraM4(obj, GeneratedFileType.EmbeddedResource);
		return obj;
	}

	protected string GetViewModelMetadataResourceExtension()
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (yI8YoVh6RiCrKxSPiCIK(AVWCCBh6tYpBuv2ZAZTi(generationParams)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (string)EUXaNeh6wZvisSB9qTMu(Lure5ih4xuXECmddpOn0(0x3CE17B75 ^ 0x3CE161B1), generationParams.Prefix, Lure5ih4xuXECmddpOn0(-542721635 ^ -542781467));
			default:
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6383E393);
			}
		}
	}

	protected string GetViewModelMetadataResourceName()
	{
		return (string)d4Faq0h644Q5nnrCwAC2(generationParams) + (string)Lure5ih4xuXECmddpOn0(-1767720453 ^ -1767726273) + (string)T3BfNDh6HbViW6ej1xVP(Path.GetFileName((string)orVOBkh66X0ZYoQL964V(generationParams))) + GetViewModelMetadataResourceExtension();
	}

	private bool HasCustomCodeInternal(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0096, IL_00a5
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!string.IsNullOrEmpty((string)FmwvGsh6Ao0KWDFlsVto(metadata)))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 3:
				return !string.IsNullOrEmpty(metadata.CustomCode.Trim(((string)Lure5ih4xuXECmddpOn0(0x5F3078B6 ^ 0x5F302EFA)).ToCharArray()));
			default:
				return false;
			case 1:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerateCustomCodeResources_003Ed__62))]
	private IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources(EntityMetadata metadata, bool isInterfaceType)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateCustomCodeResources_003Ed__62(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__metadata = metadata,
			_003C_003E3__isInterfaceType = isInterfaceType
		};
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources()
	{
		Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EAA26));
		return GenerateCustomCodeResources(metadata, metadata.IsInterfaceType).If(metadata.ImplementedExtensionUids != null, (IEnumerable<GeneratedFileInfo> r) => r.Concat(metadata.ImplementedExtensionUids.Select((Guid extUid) => (EntityMetadata)UVUZlXh4gO4ZKuJ4pbkr(this, extUid)).SelectMany((EntityMetadata m) => GenerateCustomCodeResources(m, metadata.IsInterfaceType))));
	}

	private bool HasActions(EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_00b6, IL_0162
		int num = 6;
		int num2 = num;
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				if (entityMetadata2 != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 7:
				return false;
			case 5:
				if (eJjCAEh4z69gYosmRvfM(entityMetadata) != EntityMetadataType.InterfaceImplementation)
				{
					if (entityMetadata.Actions != null)
					{
						num2 = 4;
						continue;
					}
					goto IL_012d;
				}
				num2 = 7;
				continue;
			case 6:
				mFmaRqh4JG13Q1JZSJYF(entityMetadata, Lure5ih4xuXECmddpOn0(0x307E9FD1 ^ 0x307C101F));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				return false;
			case 3:
				return HasActions(entityMetadata2);
			case 4:
				if (Ty8KOGh6x2jaBbQrkSoO(((EnumMetadata)nO92cfh67aF9xBRZAxBV(entityMetadata)).Values) > 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_012d;
			case 2:
				return true;
			case 8:
				obj = null;
				break;
			case 9:
				{
					obj = (EntityMetadata)UVUZlXh4gO4ZKuJ4pbkr(this, entityMetadata.BaseClassUid);
					break;
				}
				IL_012d:
				if (NiD7lIh4lrZSiVhJIdCw(entityMetadata) != Guid.Empty)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 8;
			}
			entityMetadata2 = (EntityMetadata)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num2 = 0;
			}
		}
	}

	public EntityGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aiiu0Lh60e1Iio1oBB0r();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object YgAF88h47bK52hNKwHkw(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object Lure5ih4xuXECmddpOn0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool fUdH8Ph4HKGjw1wMCraF()
	{
		return kbJOjVh46eb27EitZRWa == null;
	}

	internal static EntityGenerator RkR66ph4AQ626BUFvHGk()
	{
		return kbJOjVh46eb27EitZRWa;
	}

	internal static void DaDv3eh40sQ322l76aZb(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void a31mADh4mAyn0MqGCXIw(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object xDsK1Rh4yIVqvV4PvIE1()
	{
		return MetadataServiceContext.Service;
	}

	internal static object dXBXQDh4MfTwOTiQ9YJO(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static void mFmaRqh4JG13Q1JZSJYF(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static Guid bMoiflh49hGNPYf30f54(object P_0)
	{
		return ((EntityMetadata)P_0).IdTypeUid;
	}

	internal static bool R3QjKTh4dJc43SLGVFkn(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid NiD7lIh4lrZSiVhJIdCw(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool lchJ5Mh4rEikjPPyyE7c(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object UVUZlXh4gO4ZKuJ4pbkr(object P_0, Guid uid)
	{
		return ((CodeGenerator)P_0).GetMetadata(uid);
	}

	internal static object OdisQ5h45npiCgl1fSk1(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static object si7jdTh4jjc6VeHqnL2f(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object ooTnNAh4YFoC7vNBaXJU(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object x2q7tCh4Lnqj9XJOt3m5(object P_0, object P_1)
	{
		return ((EntityGenerator)P_0).GetBasicEntity((ISyntaxNode)P_1);
	}

	internal static object FWJOG3h4U2n29mDVeeBb(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool IMO1HHh4sxFwjRpX5gxV(object P_0)
	{
		return ((EntityMetadata)P_0).ShowInCatalogList;
	}

	internal static bool g2o0Nnh4cEmdfTaEry3N(object P_0)
	{
		return ((EntityMetadata)P_0).HideChildItemsTab;
	}

	internal static EntityMetadataType eJjCAEh4z69gYosmRvfM(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static bool fJFNPuh6FvsiF3bUBWnM(object P_0)
	{
		return ((EntityMetadata)P_0).SaveHistory;
	}

	internal static CopyAction Ni8eI1h6BLd27aPseTRl(object P_0)
	{
		return ((EntityMetadata)P_0).CopyAction;
	}

	internal static bool pq9CMRh6WsZg7okAShQk(object P_0)
	{
		return ((EntityMetadata)P_0).Filterable;
	}

	internal static bool DBqUGph6oX9DJSNosyQr(object P_0)
	{
		return ((EntityMetadata)P_0).IsUnique;
	}

	internal static bool A0d4wah6bhh3eKnPqO7v(object P_0)
	{
		return ((EntityMetadata)P_0).CacheEntity;
	}

	internal static object vi6JO1h6hMuHWZAOrpIl(object P_0)
	{
		return ((EntityMetadata)P_0).PermissionsMetadataName;
	}

	internal static bool gNSUMRh6GQkf3lB0kT0R(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool J5cfJyh6EplgSseCSRxo(object P_0)
	{
		return ((EntityMetadata)P_0).InstancePermissionsSupport;
	}

	internal static bool Q6JfWth6fICcfyNxn948(object P_0)
	{
		return ((EntityMetadata)P_0).Hierarchical;
	}

	internal static HierarchyType mOKlJSh6QIed4wrMvLSH(object P_0)
	{
		return ((EntityMetadata)P_0).HierarchyType;
	}

	internal static Guid TCDAm3h6C36JI6eDx6ql(object P_0)
	{
		return ((EntityMetadata)P_0).IsGroupPropertyUid;
	}

	internal static Guid zRrt6ih6vwMl5uTCobf5(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object k41Lnah68679sJSS8mHc(object P_0)
	{
		return ((string)P_0).TypeOfExpression();
	}

	internal static bool cFEgrCh6ZNxfQR4UcOWO(object P_0)
	{
		return ((EntityGenerator)P_0).HasActionsType;
	}

	internal static int W6pqiph6ubpTQyqOWjiU(object P_0)
	{
		return ((TablePartMetadata)P_0).Order;
	}

	internal static Guid r009cKh6Iy1mTS1Pt4VZ(object P_0)
	{
		return ((EntityMetadata)P_0).ParentPropertyUid;
	}

	internal static object D5wmwih6VIVUZtd3Dw6I(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static object d086YZh6S8PE6NleXWpm(Type attributeType, object P_1)
	{
		return attributeType.CreateAttribute((KeyValuePair<string, object>[])P_1);
	}

	internal static object CoKCyAh6i5WxjfPAC5hR(object P_0)
	{
		return ((TablePartMetadata)P_0).OnChangeScriptName;
	}

	internal static bool yI8YoVh6RiCrKxSPiCIK(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object KQ4Qd1h6qETRKbfcpTLS(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static bool CtAqYEh6KYMhne8E1xYM(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).InFastSearch;
	}

	internal static bool f38vJUh6Xt2Q4wTcWZsN(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).ShowInTable;
	}

	internal static bool KqOoB4h6TcEqWiiB9H52(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).Input;
	}

	internal static bool YtpVcWh6kTcVJnnKf7vZ(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).Output;
	}

	internal static int cyDidrh6nI2htiXI4dgL(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).TableNumber;
	}

	internal static object Sre7cih6O15bF5sQn1b0(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object g9T6J9h62yV8JfUcvYSo(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object R0b7OPh6eWsZfSPakY43(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void KcmcKlh6Pb4kh04y3fEn(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Nullable = value;
	}

	internal static object V7TQiKh610rtlRy05g1s(object P_0, object P_1)
	{
		return ((ITypeDescriptor)P_0).CreateSettingsForFilterProperty((PropertyMetadata)P_1);
	}

	internal static void Yhhs7bh6N1fPs6N300vQ(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object WLWaYhh637vbhDVYNLWI(object P_0)
	{
		return GetActionsTypeName((EntityMetadata)P_0);
	}

	internal static object TbfJJoh6pjUywntIw6Vm(object P_0, object P_1)
	{
		return ((EntityGenerator)P_0).CreateTablePartGenerator((TablePartMetadata)P_1);
	}

	internal static bool Uoe1NPh6aBaC3fYX4hQp(object P_0)
	{
		return ((EntityMetadata)P_0).IsActivePermissionMetadata();
	}

	internal static void fic5keh6DCyqW3XvraM4(object P_0, GeneratedFileType value)
	{
		((GeneratedFileInfo)P_0).Type = value;
	}

	internal static object AVWCCBh6tYpBuv2ZAZTi(object P_0)
	{
		return ((GenerationParams)P_0).Prefix;
	}

	internal static object EUXaNeh6wZvisSB9qTMu(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object d4Faq0h644Q5nnrCwAC2(object P_0)
	{
		return ((GenerationParams)P_0).Namespace;
	}

	internal static object orVOBkh66X0ZYoQL964V(object P_0)
	{
		return ((GenerationParams)P_0).FileName;
	}

	internal static object T3BfNDh6HbViW6ej1xVP(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object FmwvGsh6Ao0KWDFlsVto(object P_0)
	{
		return ((ClassMetadata)P_0).CustomCode;
	}

	internal static object nO92cfh67aF9xBRZAxBV(object P_0)
	{
		return ((EntityMetadata)P_0).Actions;
	}

	internal static int Ty8KOGh6x2jaBbQrkSoO(object P_0)
	{
		return ((List<EnumValueMetadata>)P_0).Count;
	}

	internal static void aiiu0Lh60e1Iio1oBB0r()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
