using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 400)]
public class EntityDescriptor : RefTypeDescriptor<IEntity, EntitySettings>, IConvertableTypeDescriptor, IEqualityTypeDescriptor
{
	public const string UID_S = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";

	public static readonly Guid UID;

	protected static readonly string IdPropertyName;

	protected const string NamePropertyName = "Name";

	protected const string UidPropertyName = "Uid";

	protected static readonly string TypeUidPropertyName;

	private static ConcurrentDictionary<Guid, Guid> entityUidProperties;

	[ThreadStatic]
	private static bool сheckSoftDeletable;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static EntityDescriptor NyA7jho90FTcZKmug8Y3;

	public override Guid Uid => UID;

	public override string Name => (string)VTfxOto9JfEHSGKRwBi7(sGggSRo9M7FDG9iI3Gii(0x31326106 ^ 0x3130FD80));

	public override Guid ParentUid => Guid.Empty;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new EntityPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0129, IL_0138, IL_0148, IL_0157, IL_01ae, IL_01bd, IL_01cd, IL_01dc
		int num = 8;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		EntitySettings entitySettings = default(EntitySettings);
		ICollection collection = default(ICollection);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
					num2 = 12;
					break;
				case 5:
					return true;
				case 11:
					if (nLFjy2o99PPyGug0YhUK(entitySettings) != 0)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 10;
				case 9:
					if (entitySettings != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 8:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					if (collection != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 13;
						}
						break;
					}
					goto case 2;
				case 1:
					return true;
				case 14:
					entitySettings = (EntitySettings)_003C_003Ec__DisplayClass8_.propertyMetadata.Settings;
					num2 = 9;
					break;
				case 4:
					return true;
				case 10:
					return base.IsEmpty(_003C_003Ec__DisplayClass8_.propertyMetadata, val);
				case 3:
					collection = val as ICollection;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (_003C_003Ec__DisplayClass8_.propertyMetadata != null)
					{
						num2 = 14;
						break;
					}
					goto case 1;
				case 12:
					_003C_003Ec__DisplayClass8_.propertyMetadata = propertyMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 6;
					}
					break;
				case 2:
					return true;
				case 13:
					if (!collection.Cast<object>().All((object v) => v == null))
					{
						return collection.Cast<object>().All(_003C_003Ec__DisplayClass8_._003CIsEmpty_003Eb__1);
					}
					num2 = 4;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		int num = 3;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (VFwffro9lujehijBYfDG(entitySettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_006f;
			case 3:
				entitySettings = (EntitySettings)ANZRtso9d3igFQKtT5ZT(propertyMetadata);
				num2 = 2;
				break;
			default:
				return EntityFilterDescriptor.UID;
			case 2:
				{
					if (entitySettings != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_006f;
				}
				IL_006f:
				return base.GetFilterType(propertyMetadata, entityMetadata);
			}
		}
	}

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classMetadata = classMetadata;
		List<NamedMetadata> metadataList = ((IEnumerable<NamedMetadata>)(from m in GetSubTypesMetadataList()
			where _003C_003Ec__DisplayClass10_0.jh66R0CSRbt9uGUIVtPP(CS_0024_003C_003E8__locals0._003C_003E4__this, m.GetType(), CS_0024_003C_003E8__locals0.classMetadata)
			select m)).ToList();
		return CompositeTypeDescriptorHelper.GetDescriptorsByGroups(this, metadataList);
	}

	public static IEnumerable<EntityMetadata> GetSubTypesMetadataList()
	{
		return from m in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
			{
				//Discarded unreachable code: IL_0031, IL_0040
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (_003C_003Ec.q4iTDACSEiNTm5bM0IUL(m) != EntityMetadataType.Interface)
						{
							num2 = 2;
							break;
						}
						goto case 1;
					case 2:
						if (_003C_003Ec.q4iTDACSEiNTm5bM0IUL(m) != 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 1;
					case 1:
						return _003C_003Ec.w312PSCSfZKkvrI2i0Fd(m);
					default:
						return false;
					}
				}
			})
			orderby (string)_003C_003Ec.ipFnHHCSQujnZhp7kJX7(m)
			select m;
	}

	[IteratorStateMachine(typeof(_003CGetAdditionalTypeMembers_003Ed__12))]
	public override IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetAdditionalTypeMembers_003Ed__12(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__classMetadata = classMetadata,
			_003C_003E3__propertyMetadata = propertyMetadata
		};
	}

	public override IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		EntityMetadata entityMetadata = classMetadata as EntityMetadata;
		if (сheckSoftDeletable && entityMetadata != null && !entityMetadata.IsInterfaceType && ((EntitySettings)propertyMetadata.Settings).RelationType == RelationType.OneToOne && GetMetadata(propertyMetadata.SubTypeUid) is EntityMetadata entityMetadata2)
		{
			EntityMetadata entityMetadata3 = entityMetadata2;
			if (entityMetadata2.Type == EntityMetadataType.Interface)
			{
				entityMetadata3 = (EntityMetadata)GetMetadata(entityMetadata2.ImplementationUid);
			}
			else if (entityMetadata2.Type == EntityMetadataType.InterfaceExtension)
			{
				EntityMetadata entityMetadata4 = (EntityMetadata)GetMetadata(entityMetadata2.BaseClassUid);
				entityMetadata3 = ((entityMetadata4 != null) ? ((EntityMetadata)GetMetadata(entityMetadata4.ImplementationUid)) : null);
			}
			if (entityMetadata3 == null)
			{
				throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309732580), entityMetadata2.FullTypeName, entityMetadata2.ImplementationUid));
			}
			if (entityMetadata3.ImplementedInterfaces.EmptyIfNull().Any((string n) => Type.GetType(n) == TypeOf<ISoftDeletable>.Raw))
			{
				return new ISyntaxNode[1] { typeof(EntityExtensions).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70134986)).InvocationExpression(fieldName.IdentifierName())
					.ReturnStatement() };
			}
		}
		return new ISyntaxNode[1] { fieldName.IdentifierName().ReturnStatement() };
	}

	public override IEnumerable<ISyntaxNode> GetPropertySetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName)
	{
		if (((EntitySettings)propertyMetadata.Settings).RelationType != 0)
		{
			EntityMetadata obj = classMetadata as EntityMetadata;
			if (obj != null && obj.Type == EntityMetadataType.InterfaceImplementation)
			{
				if (GetMetadata(propertyMetadata.SubTypeUid) is EntityMetadata entityMetadata && entityMetadata.IsInterfaceType)
				{
					EntityMetadata entityMetadata2 = null;
					if (entityMetadata.Type == EntityMetadataType.Interface)
					{
						entityMetadata2 = (EntityMetadata)GetMetadata(entityMetadata.ImplementationUid);
					}
					else if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
					{
						EntityMetadata entityMetadata3 = (EntityMetadata)GetMetadata(entityMetadata.BaseClassUid);
						if (entityMetadata3 != null)
						{
							entityMetadata2 = (EntityMetadata)GetMetadata(entityMetadata3.ImplementationUid);
						}
					}
					ISyntaxNode syntaxNode = entityMetadata.FullTypeName.CreateTypeSyntax();
					ISyntaxNode syntaxNode2 = entityMetadata2.FullTypeName.CreateTypeSyntax();
					return new ISyntaxNode[1] { fieldName.IdentifierName().AssignmentStatement(typeof(WrappedSetHelper).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -476028473).GenericName(syntaxNode2, syntaxNode)).InvocationExpression(SyntaxGeneratorExtensions.Value)) };
				}
				return new ISyntaxNode[1] { fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value) };
			}
		}
		return new ISyntaxNode[1] { fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value) };
	}

	public override TypeSerializationDescriptor GetSerializeDescriptor(ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_00c9, IL_00d3
		int num = 5;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		string description = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					if (_003C_003Ec__DisplayClass15_.valueMd != null)
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 3:
					break;
				case 5:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 4;
					continue;
				case 10:
					obj = "";
					goto IL_01df;
				case 11:
					if (!string.IsNullOrEmpty((string)f1CIdio9rZ4r8OHxb0k6(_003C_003Ec__DisplayClass15_.propertyMetadata)))
					{
						num2 = 9;
						continue;
					}
					goto case 10;
				case 7:
					_003C_003Ec__DisplayClass15_.settings = (EntitySettings)ANZRtso9d3igFQKtT5ZT(_003C_003Ec__DisplayClass15_.propertyMetadata);
					num2 = 11;
					continue;
				case 4:
					_003C_003Ec__DisplayClass15_.propertyMetadata = propertyMetadata;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					throw new InvalidOperationException(SR.T((string)sGggSRo9M7FDG9iI3Gii(0x7C1EE318 ^ 0x7C1C7EB4), _003C_003Ec__DisplayClass15_.propertyMetadata.TypeUid));
				case 8:
					return (TypeSerializationDescriptor)cjl5e7o9Ui3Rt1ySfrgb(new TypeSerializationDescriptorBuilder().Description(description).Item(_003C_003Ec__DisplayClass15_._003CGetSerializeDescriptor_003Eb__0));
				case 9:
					obj = SR.T((string)sGggSRo9M7FDG9iI3Gii(-538519530 ^ -538685062), f1CIdio9rZ4r8OHxb0k6(_003C_003Ec__DisplayClass15_.propertyMetadata), iW4pjto9g1RnqhQdJkZs(this, _003C_003Ec__DisplayClass15_.propertyMetadata));
					goto IL_01df;
				default:
					_003C_003Ec__DisplayClass15_.descr = (string)((!MmKhu2o95vW1RVN7BrLD(f1CIdio9rZ4r8OHxb0k6(_003C_003Ec__DisplayClass15_.propertyMetadata))) ? TiPCRjo9YVNGPUXkAWdL(sGggSRo9M7FDG9iI3Gii(0x8317432 ^ 0x833FDBA), f1CIdio9rZ4r8OHxb0k6(_003C_003Ec__DisplayClass15_.propertyMetadata), iq2isfo9jiuvYdZ9xIsq(_003C_003Ec__DisplayClass15_.propertyMetadata), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867102659), GetPropertyTypeDisplayName(_003C_003Ec__DisplayClass15_.propertyMetadata))) : "");
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					{
						_003C_003Ec__DisplayClass15_.descrList = (string)((!string.IsNullOrEmpty((string)f1CIdio9rZ4r8OHxb0k6(_003C_003Ec__DisplayClass15_.propertyMetadata))) ? TiPCRjo9YVNGPUXkAWdL(sGggSRo9M7FDG9iI3Gii(-1824388195 ^ -1824488939), _003C_003Ec__DisplayClass15_.propertyMetadata.DisplayName, _003C_003Ec__DisplayClass15_.propertyMetadata.Description ?? VTfxOto9JfEHSGKRwBi7(sGggSRo9M7FDG9iI3Gii(0x26FFCB59 ^ 0x26FD5613)), iW4pjto9g1RnqhQdJkZs(this, _003C_003Ec__DisplayClass15_.propertyMetadata)) : "");
						num2 = 3;
						continue;
					}
					IL_01df:
					description = (string)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass15_.valueMd = MetadataLoader.LoadMetadata(aXsQDqo9LAocDrZMPFve(_003C_003Ec__DisplayClass15_.propertyMetadata)) as EntityMetadata;
			num = 2;
		}
	}

	public override TypeSerializationDescriptor GetSerializeDescriptor(Guid subTypeUid)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		TypeSerializationDescriptor typeSerializationDescriptor = default(TypeSerializationDescriptor);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 6:
				Do51Wjo9z2On9XKYiDRF((EntitySettings)propertyMetadata.Settings, RelationType.OneToOne);
				num2 = 5;
				break;
			case 8:
			{
				ICollection<TypeSerializationItemDescriptor> items2 = typeSerializationDescriptor.Items;
				TypeSerializationItemDescriptor typeSerializationItemDescriptor = new TypeSerializationItemDescriptor();
				QubtcaodWxhC5S84uyKS(typeSerializationItemDescriptor, SR.T((string)sGggSRo9M7FDG9iI3Gii(-1852837372 ^ -1853002748), PTr3mkodB9TEO4tKZUwq(sGggSRo9M7FDG9iI3Gii(-1217523399 ^ -1217622159), RelationType.OneToOne)));
				C37BVrodFhIBj61bKhqy(typeSerializationItemDescriptor, GetSerializeDescriptor(entityMetadata, propertyMetadata));
				items2.Add(typeSerializationItemDescriptor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
			{
				PropertyMetadata obj = new PropertyMetadata
				{
					Name = (string)fu9QDyo9sMj57bHq21jD(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824373669), VTfxOto9JfEHSGKRwBi7(sGggSRo9M7FDG9iI3Gii(0x7247028A ^ 0x72459236)), sGggSRo9M7FDG9iI3Gii(-16752921 ^ -16772825))
				};
				DAaEZSo9c26UD4B01XkT(obj, Uid);
				obj.SubTypeUid = subTypeUid;
				propertyMetadata = obj;
				num2 = 4;
				break;
			}
			case 7:
				Do51Wjo9z2On9XKYiDRF((EntitySettings)ANZRtso9d3igFQKtT5ZT(propertyMetadata), RelationType.ManyToMany);
				num2 = 8;
				break;
			case 2:
				typeSerializationDescriptor = new TypeSerializationDescriptor();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				entityMetadata.Properties.Add(propertyMetadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 6;
				}
				break;
			default:
				return typeSerializationDescriptor;
			case 1:
				entityMetadata = new EntityMetadata();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
			{
				ICollection<TypeSerializationItemDescriptor> items = typeSerializationDescriptor.Items;
				TypeSerializationItemDescriptor typeSerializationItemDescriptor = new TypeSerializationItemDescriptor
				{
					Name = SR.T((string)sGggSRo9M7FDG9iI3Gii(-882126494 ^ -882290846), string.Concat(sGggSRo9M7FDG9iI3Gii(-1317790512 ^ -1317633340), RelationType.OneToOne))
				};
				C37BVrodFhIBj61bKhqy(typeSerializationItemDescriptor, GetSerializeDescriptor(entityMetadata, propertyMetadata));
				items.Add(typeSerializationItemDescriptor);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 7;
				}
				break;
			}
			}
		}
	}

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings serializationSettings)
	{
		//IL_0172: Expected O, but got Unknown
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31322838));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218478340));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		bool flag = serializationSettings?.WriteReferences ?? false;
		using (ReferenceResolverSerializer.CreateResolver(ReferenceResolverSerializer.CurrentResolver != null || flag))
		{
			object value = property.GetValue(obj, null);
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
			if (value != null)
			{
				switch (((EntitySettings)propertyMetadata.Settings).RelationType)
				{
				case RelationType.OneToOne:
					serializableDictionary[propertyMetadata.Name] = SerializeSimple(value, value.GetType(), serializationSettings);
					break;
				case RelationType.OneToMany:
				case RelationType.ManyToMany:
				case RelationType.ManyToManyInverse:
				{
					if (!(value is IEnumerable enumerable))
					{
						break;
					}
					SerializableList<object> serializableList = new SerializableList<object>();
					try
					{
						foreach (object item in enumerable)
						{
							serializableList.Add(SerializeSimple(item, item.GetType(), serializationSettings));
						}
						serializableDictionary[propertyMetadata.Name] = serializableList;
					}
					catch (LazyInitializationException val)
					{
						LazyInitializationException val2 = val;
						base.Logger.Log(LogLevel.Debug, (Exception)(object)val2, ((Exception)(object)val2).Message);
					}
					catch (Exception ex)
					{
						base.Logger.Log(LogLevel.Error, ex, ex.Message);
					}
					break;
				}
				}
			}
			else
			{
				serializableDictionary[propertyMetadata.Name] = null;
			}
			return serializableDictionary;
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_00a2, IL_020c, IL_021b, IL_0287, IL_02c6, IL_0372, IL_0381, IL_03a4, IL_03b3, IL_03be, IL_046a, IL_04a2, IL_04b1, IL_04e6, IL_04f5, IL_0579, IL_0628, IL_063b, IL_06c4, IL_0827, IL_0852, IL_085c, IL_0908, IL_0927, IL_0936, IL_0963, IL_0972, IL_09f9, IL_0a08, IL_0a17, IL_0a27, IL_0a5f, IL_0a96, IL_0b17, IL_0b9d, IL_0bac, IL_0c44, IL_0c84, IL_0c93, IL_0c9f, IL_0cae, IL_0cfa
		int num = 2;
		EntitySerializationSettings settings2 = default(EntitySerializationSettings);
		IReferenceResolver referenceResolver = default(IReferenceResolver);
		object result = default(object);
		_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_1);
		bool flag2 = default(bool);
		IEntity entity = default(IEntity);
		bool flag = default(bool);
		SerializableDictionary<string, object> serializableDictionary = default(SerializableDictionary<string, object>);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current2 = default(KeyValuePair<string, object>);
		string reference = default(string);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 2:
					settings2 = settings;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (!fOg8cKodoLabF4DApiQF(valueType, null))
					{
						num = 5;
						break;
					}
					goto case 6;
				case 4:
					referenceResolver = (IReferenceResolver)SR49OWodhF5C0uU5I7Re();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 8;
					}
					continue;
				default:
					return result;
				case 7:
					try
					{
						int num4;
						if (Rdtb3fodEj9WldhCsD2n(typeof(IEntity).TypeHandle).IsAssignableFrom(valueType))
						{
							num4 = 52;
							goto IL_00d3;
						}
						goto IL_023c;
						IL_0b07:
						object obj = ((WebData)YbpqDmodKcKOQ4JSqiPk(value)).ToDictionary();
						goto IL_0c12;
						IL_023c:
						if (!valueType.IsClass)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num4 = 1;
							}
							goto IL_00d3;
						}
						goto IL_0b1c;
						IL_0c12:
						result = obj;
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num4 = 24;
						}
						goto IL_00d3;
						IL_0c11:
						obj = null;
						goto IL_0c12;
						IL_0b1c:
						if (value == null)
						{
							num4 = 37;
							goto IL_00d3;
						}
						goto IL_0b07;
						IL_00d3:
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 23:
								return result;
							case 24:
								return result;
							case 31:
								return result;
							case 43:
								return result;
							case 48:
								return result;
							case 56:
								return result;
							case 62:
								return result;
							case 9:
							case 19:
							case 39:
								if (settings2 != null)
								{
									num4 = 18;
									continue;
								}
								goto case 42;
							case 25:
								if (_003C_003Ec__DisplayClass18_.valueMd == null)
								{
									num4 = 39;
									continue;
								}
								goto case 54;
							case 34:
								break;
							case 40:
								if (flag2)
								{
									num4 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num4 = 11;
									}
									continue;
								}
								goto case 35;
							case 21:
								if (entity != null)
								{
									num4 = 65;
									continue;
								}
								goto case 7;
							case 10:
								if (vnytVFodQ7LhRKFIhpv4(settings2) == EntitySerializationMode.Default)
								{
									num4 = 20;
									continue;
								}
								goto case 35;
							case 35:
							case 46:
							case 58:
								if (referenceResolver != null && flag)
								{
									num5 = 64;
									goto IL_00cf;
								}
								goto case 32;
							case 54:
								if (settings2 != null)
								{
									num4 = 17;
									continue;
								}
								goto case 4;
							case 17:
								if (settings2.Mode != 0)
								{
									num4 = 25;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num4 = 33;
									}
									continue;
								}
								goto case 4;
							case 57:
								if (settings2 == null)
								{
									num4 = 46;
									continue;
								}
								goto case 10;
							case 49:
								if (vnytVFodQ7LhRKFIhpv4(settings2) != 0)
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 13;
							case 12:
							case 14:
								result = serializableDictionary;
								num5 = 31;
								goto IL_00cf;
							case 30:
								try
								{
									while (true)
									{
										int num8;
										if (!P67muCod8ED2Am6II7gA(enumerator))
										{
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
											{
												num8 = 2;
											}
											goto IL_03c2;
										}
										goto IL_0421;
										IL_0421:
										current2 = enumerator.Current;
										num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
										{
											num8 = 1;
										}
										goto IL_03c2;
										IL_03c2:
										while (true)
										{
											switch (num8)
											{
											case 1:
												serializableDictionary.Add(current2.Key, current2.Value);
												num8 = 3;
												continue;
											case 3:
												break;
											default:
												goto IL_0421;
											case 2:
												goto end_IL_03fb;
											}
											break;
										}
										continue;
										end_IL_03fb:
										break;
									}
								}
								finally
								{
									if (enumerator != null)
									{
										int num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
										{
											num9 = 0;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												enumerator.Dispose();
												num9 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
												{
													num9 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto case 47;
							case 1:
								if (valueType.IsInterface)
								{
									num4 = 36;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num4 = 4;
									}
									continue;
								}
								goto case 61;
							case 5:
							case 15:
								if (dFUH1noduobUSk8j6Jx0(settings2.TypePropertySelector) > 0)
								{
									num4 = 51;
									continue;
								}
								goto case 35;
							case 53:
							case 55:
								serializableDictionary[(string)sGggSRo9M7FDG9iI3Gii(-978351861 ^ -978387115)] = reference;
								num4 = 32;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num4 = 12;
								}
								continue;
							case 4:
								if (nNyu9HodiBEQtdhmif3a(_003C_003Ec__DisplayClass18_.valueMd))
								{
									num4 = 13;
									continue;
								}
								goto case 6;
							case 7:
								result = null;
								num4 = 43;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num4 = 34;
								}
								continue;
							case 6:
								if (settings2 == null)
								{
									num4 = 59;
									continue;
								}
								goto case 49;
							case 61:
								result = base.SerializeSimple(value, valueType, settings2);
								num4 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
								{
									num4 = 56;
								}
								continue;
							case 42:
								serializableDictionary.Add((string)sGggSRo9M7FDG9iI3Gii(-70037984 ^ -70108324), entity.ToString());
								num4 = 41;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num4 = 45;
								}
								continue;
							case 65:
								_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_1();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num4 = 0;
								}
								continue;
							case 27:
								flag2 = HasPropertySelector(_003C_003Ec__DisplayClass18_._003CSerializeSimple_003Eb__3);
								num4 = 40;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num4 = 0;
								}
								continue;
							case 16:
								enumerator = ((IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(entity, settings2)).GetEnumerator();
								num4 = 68;
								continue;
							case 51:
								if (_003C_003Ec__DisplayClass18_.valueMd == null)
								{
									num4 = 35;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 27;
									}
									continue;
								}
								goto case 63;
							case 13:
							case 59:
							case 66:
								serializableDictionary.Add(TypeUidPropertyName, txZuxZodRdw61Gr5LRxu(_003C_003Ec__DisplayClass18_.valueMd));
								num4 = 26;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num4 = 19;
								}
								continue;
							case 60:
								serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785D39F), entity.GetPropertyValue<Guid>(txZuxZodRdw61Gr5LRxu(entityPropertyMetadata)));
								num4 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num4 = 19;
								}
								continue;
							case 64:
								if (!referenceResolver.TryGetReference(entity, _003C_003Ec__DisplayClass18_.valueMd, out reference))
								{
									num4 = 53;
									continue;
								}
								goto case 29;
							case 44:
								if (entityPropertyMetadata != null)
								{
									num4 = 60;
									continue;
								}
								goto case 9;
							case 38:
								flag2 = HasPropertySelector(_003C_003Ec__DisplayClass18_._003CSerializeSimple_003Eb__2);
								num4 = 50;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num4 = 11;
								}
								continue;
							case 63:
								flag2 = HasPropertySelector(_003C_003Ec__DisplayClass18_._003CSerializeSimple_003Eb__1);
								num4 = 22;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num4 = 10;
								}
								continue;
							case 22:
								if (flag2)
								{
									num4 = 41;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num4 = 30;
									}
									continue;
								}
								goto case 38;
							case 20:
								if (settings2.PropertySelector == null)
								{
									num4 = 5;
									continue;
								}
								goto case 3;
							case 68:
								try
								{
									while (true)
									{
										IL_089d:
										int num6;
										if (!P67muCod8ED2Am6II7gA(enumerator))
										{
											num6 = 3;
											goto IL_0860;
										}
										goto IL_087a;
										IL_0860:
										while (true)
										{
											switch (num6)
											{
											case 2:
												break;
											case 1:
												goto IL_089d;
											default:
												serializableDictionary.Add(current.Key, current.Value);
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
												{
													num6 = 1;
												}
												continue;
											case 3:
												goto end_IL_089d;
											}
											break;
										}
										goto IL_087a;
										IL_087a:
										current = enumerator.Current;
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
										{
											num6 = 0;
										}
										goto IL_0860;
										continue;
										end_IL_089d:
										break;
									}
								}
								finally
								{
									int num7;
									if (enumerator == null)
									{
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
										{
											num7 = 1;
										}
										goto IL_090c;
									}
									goto IL_0941;
									IL_0941:
									aDCIFgodZSG33d1GslqU(enumerator);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num7 = 0;
									}
									goto IL_090c;
									IL_090c:
									switch (num7)
									{
									default:
										goto end_IL_08e7;
									case 1:
										goto end_IL_08e7;
									case 2:
										break;
									case 0:
										goto end_IL_08e7;
									}
									goto IL_0941;
									end_IL_08e7:;
								}
								goto case 28;
							case 47:
								result = serializableDictionary;
								num4 = 62;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num4 = 50;
								}
								continue;
							case 45:
								serializableDictionary.Add((string)sGggSRo9M7FDG9iI3Gii(0x4D1C1EE4 ^ 0x4D1C6D24), entity.ToString());
								num5 = 12;
								goto IL_00cf;
							default:
								_003C_003Ec__DisplayClass18_.valueMd = MetadataLoader.LoadMetadata(Wm3Tf3odfFGjAkxDNPSg(value).GetType()) as EntityMetadata;
								num4 = 57;
								continue;
							case 11:
								enumerator = ((IDictionary<string, object>)Jp8J3vodIOCEDWS0B0Tw(new EntityJsonSerializer(), entity, settings2)).GetEnumerator();
								num4 = 30;
								continue;
							case 52:
								entity = value as IEntity;
								num4 = 67;
								continue;
							case 33:
								if (!S36he6odSjVF50kbYj5Y(entity))
								{
									num4 = 9;
									continue;
								}
								goto case 4;
							case 28:
								result = serializableDictionary;
								num4 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num4 = 19;
								}
								continue;
							case 32:
								serializableDictionary.Add(IdPropertyName, iLDYtuodVU0ZBvNWNvdT(entity));
								num4 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num4 = 25;
								}
								continue;
							case 2:
							case 26:
								entityPropertyMetadata = (EntityPropertyMetadata)bIQkvVodqc6moksZ09nE(_003C_003Ec__DisplayClass18_.valueMd);
								num5 = 44;
								goto IL_00cf;
							case 8:
								goto IL_0b07;
							case 36:
								goto IL_0b1c;
							case 41:
							case 50:
								if (!flag2)
								{
									num4 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num4 = 27;
									}
									continue;
								}
								goto case 40;
							case 18:
								if (vnytVFodQ7LhRKFIhpv4(settings2) != 0)
								{
									num4 = 14;
									continue;
								}
								goto case 42;
							case 3:
								if (DntH6GodvqjPnMFG0u8B(tbmoRkodCtV4AEFC5BAg(settings2)) != 0)
								{
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num4 = 16;
									}
									continue;
								}
								goto case 5;
							case 29:
								result = new SerializableDictionary<string, object> { 
								{
									(string)sGggSRo9M7FDG9iI3Gii(0x4DC2B14D ^ 0x4DC3C71F),
									reference
								} };
								num4 = 45;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num4 = 48;
								}
								continue;
							case 67:
								serializableDictionary = new SerializableDictionary<string, object>();
								num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num4 = 21;
								}
								continue;
							case 37:
								goto IL_0c11;
								IL_00cf:
								num4 = num5;
								continue;
							}
							break;
						}
						goto IL_023c;
					}
					finally
					{
						int num10;
						if (disposable == null)
						{
							num10 = 2;
							goto IL_0c48;
						}
						goto IL_0c5e;
						IL_0c48:
						switch (num10)
						{
						default:
							goto end_IL_0c33;
						case 1:
							break;
						case 2:
							goto end_IL_0c33;
						case 0:
							goto end_IL_0c33;
						}
						goto IL_0c5e;
						IL_0c5e:
						aDCIFgodZSG33d1GslqU(disposable);
						num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num10 = 0;
						}
						goto IL_0c48;
						end_IL_0c33:;
					}
				case 6:
					throw new ArgumentNullException((string)sGggSRo9M7FDG9iI3Gii(-477139494 ^ -477240218));
				case 5:
					if (settings2 != null)
					{
						num = 3;
						break;
					}
					num3 = 0;
					goto IL_0d19;
				case 3:
					num3 = (bWpPduodbBoo4jF6ETiF(settings2) ? 1 : 0);
					goto IL_0d19;
				case 8:
					{
						disposable = (IDisposable)evm0aOodGIEu960xfRNc(referenceResolver != null || flag);
						num2 = 7;
						continue;
					}
					IL_0d19:
					flag = (byte)num3 != 0;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.obj = obj;
		_003C_003Ec__DisplayClass19_._003C_003E4__this = this;
		if (_003C_003Ec__DisplayClass19_.obj == null || values == null)
		{
			return;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867217237));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC5C6D));
		}
		_003C_003Ec__DisplayClass19_.obj = _003C_003Ec__DisplayClass19_.obj.CastAsRealType();
		_003C_003Ec__DisplayClass19_.propInfo = _003C_003Ec__DisplayClass19_.obj.GetProperty(metadata, propertyMetadata);
		if (_003C_003Ec__DisplayClass19_.propInfo == null || !_003C_003Ec__DisplayClass19_.propInfo.CanWrite || !values.TryGetValue(propertyMetadata.Name, out var value))
		{
			return;
		}
		using (ReferenceResolverSerializer.CreateResolver(needResolver: true))
		{
			object serializerMarker = new object();
			EntityJsonSerializer.AddSerializerMarker(serializerMarker);
			EntitySettings obj2 = (EntitySettings)propertyMetadata.Settings;
			_003C_003Ec__DisplayClass19_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass19_1();
			CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass19_;
			switch (obj2.RelationType)
			{
			case RelationType.OneToOne:
			{
				IDictionary<string, object> dictionary2 = value as IDictionary<string, object>;
				Type entityType = GetEntityType(dictionary2, propertyMetadata);
				object obj4 = TryDeserializeEntityId(dictionary2, entityType);
				object obj5 = ((!(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propInfo.GetValue(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.obj, null) is IEntity entity3) || obj4 == null || !entity3.GetId().Equals(obj4)) ? DeserializeSimple(dictionary2, entityType) : DeserializeSimple(dictionary2, entityType, entity3));
				if ((CS_0024_003C_003E8__locals2.func = obj5 as Func<object>) != null)
				{
					EntityJsonSerializer.AddAction(delegate
					{
						int num = 2;
						int num2 = num;
						object obj6 = default(object);
						while (true)
						{
							switch (num2)
							{
							default:
								return;
							case 1:
								_003C_003Ec__DisplayClass19_1.rQCJldCiIhkhXjEDM9I6(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propInfo, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.obj, obj6, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num2 = 0;
								}
								break;
							case 0:
								return;
							case 2:
								obj6 = CS_0024_003C_003E8__locals2.func();
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
								{
									num2 = 0;
								}
								break;
							}
						}
					});
				}
				else if (obj5 != null || obj4 == null)
				{
					CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propInfo.SetValue(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.obj, obj5, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
				}
				break;
			}
			case RelationType.OneToMany:
			case RelationType.ManyToMany:
			case RelationType.ManyToManyInverse:
			{
				IEnumerable enumerable = (IEnumerable)CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propInfo.GetValue(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.obj, null);
				CS_0024_003C_003E8__locals2.untypedISet = null;
				if (enumerable == null)
				{
					_003C_003Ec__DisplayClass19_2 _003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_2();
					_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals2;
					Type propertyType = _003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propInfo.PropertyType;
					_003C_003Ec__DisplayClass19_2.typeToCreate = null;
					if (propertyType.IsGenericType)
					{
						Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
						if (genericTypeDefinition == typeof(IDictionary<, >))
						{
							_003C_003Ec__DisplayClass19_2.typeToCreate = typeof(Dictionary<, >).MakeGenericType(propertyType.GetGenericArguments());
							enumerable = (IEnumerable)Activator.CreateInstance(_003C_003Ec__DisplayClass19_2.typeToCreate);
							_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals2.untypedISet = enumerable.AsUntypedIDictionary();
						}
						else if (genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IList<>))
						{
							_003C_003Ec__DisplayClass19_2.typeToCreate = typeof(List<>).MakeGenericType(propertyType.GetGenericArguments());
							enumerable = (IEnumerable)Activator.CreateInstance(_003C_003Ec__DisplayClass19_2.typeToCreate);
							_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals2.untypedISet = enumerable.AsUntypedICollection();
						}
					}
					else if (propertyType.IsArray && value is IEnumerable source)
					{
						_003C_003Ec__DisplayClass19_3 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_3();
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3 = _003C_003Ec__DisplayClass19_2;
						object[] array = source.CastToArrayOrNull<object>();
						if (array == null)
						{
							return;
						}
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.typeToCreate = propertyType.GetElementType();
						if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.typeToCreate == null)
						{
							return;
						}
						CS_0024_003C_003E8__locals0.newArray = Array.CreateInstance(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.typeToCreate, array.Length);
						array.ForEach(delegate(object item, int index)
						{
							int num5 = 4;
							int num6 = num5;
							Func<object> func = default(Func<object>);
							_003C_003Ec__DisplayClass19_4 _003C_003Ec__DisplayClass19_3 = default(_003C_003Ec__DisplayClass19_4);
							object obj7 = default(object);
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 8:
									if (func != null)
									{
										num6 = 2;
									}
									else
									{
										_003C_003Ec__DisplayClass19_3.S5A0M9CikWKaG9YUNARZ(CS_0024_003C_003E8__locals0.newArray, _003C_003Ec__DisplayClass19_3.index, obj7);
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
										{
											num6 = 1;
										}
									}
									break;
								case 5:
									func = (_003C_003Ec__DisplayClass19_3.function = obj7 as Func<object>);
									num6 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
									{
										num6 = 8;
									}
									break;
								case 6:
									obj7 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.DeserializeSimple(item, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.typeToCreate);
									num6 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
									{
										num6 = 2;
									}
									break;
								case 2:
									_003C_003Ec__DisplayClass19_3.ixm86TCiTDDYNJndJFAm(new Action(_003C_003Ec__DisplayClass19_3._003CDeserialize_003Eb__2));
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num6 = 0;
									}
									break;
								case 7:
									_003C_003Ec__DisplayClass19_3.index = index;
									num6 = 6;
									break;
								case 1:
									return;
								case 3:
									_003C_003Ec__DisplayClass19_3.CS_0024_003C_003E8__locals4 = CS_0024_003C_003E8__locals0;
									num6 = 7;
									break;
								case 4:
									_003C_003Ec__DisplayClass19_3 = new _003C_003Ec__DisplayClass19_4();
									num6 = 3;
									break;
								case 0:
									return;
								}
							}
						});
						enumerable = CS_0024_003C_003E8__locals0.newArray;
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.untypedISet = enumerable.AsUntypedICollection();
					}
					if (_003C_003Ec__DisplayClass19_2.typeToCreate == null)
					{
						return;
					}
					if (enumerable != null)
					{
						_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propInfo.SetValue(_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.obj, enumerable, null);
					}
				}
				if (CS_0024_003C_003E8__locals2.untypedISet == null)
				{
					CS_0024_003C_003E8__locals2.untypedISet = enumerable.AsUntypedISet();
				}
				if (CS_0024_003C_003E8__locals2.untypedISet == null)
				{
					return;
				}
				Dictionary<Guid, IEntity> dictionary = new Dictionary<Guid, IEntity>();
				foreach (IEntity item in enumerable)
				{
					dictionary[GetEntityGuid(item)] = item;
				}
				List<Guid> list = new List<Guid>();
				if (value is IEnumerable enumerable2)
				{
					foreach (object item2 in enumerable2)
					{
						_003C_003Ec__DisplayClass19_5 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass19_5();
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals5 = CS_0024_003C_003E8__locals2;
						IDictionary<string, object> dictionary2 = item2 as IDictionary<string, object>;
						Type entityType = GetEntityType(dictionary2, propertyMetadata);
						object obj3 = DeserializeSimple(dictionary2, entityType);
						if ((CS_0024_003C_003E8__locals1.function = obj3 as Func<object>) != null)
						{
							EntityJsonSerializer.AddAction(delegate
							{
								int num3 = 2;
								int num4 = num3;
								IEntity entity4 = default(IEntity);
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 1:
										_003C_003Ec__DisplayClass19_5.euyji6CiahWX4a9J1Bhy(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals5.untypedISet, entity4);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
										{
											num4 = 0;
										}
										break;
									case 0:
										return;
									case 2:
										entity4 = (IEntity)CS_0024_003C_003E8__locals1.function();
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
										{
											num4 = 1;
										}
										break;
									}
								}
							});
							continue;
						}
						IEntity entity2 = (IEntity)obj3;
						if (entity2 != null)
						{
							Guid entityGuid = GetEntityGuid(entity2, entityType);
							if (!dictionary.ContainsKey(entityGuid))
							{
								CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals5.untypedISet.Add(entity2);
							}
							list.Add(entityGuid);
						}
					}
				}
				foreach (KeyValuePair<Guid, IEntity> item3 in dictionary)
				{
					if (!list.Contains(item3.Key))
					{
						CS_0024_003C_003E8__locals2.untypedISet.Remove(item3.Value);
					}
				}
				break;
			}
			}
			EntityJsonSerializer.InvokeActions(serializerMarker);
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_004e, IL_0086, IL_00a5, IL_00b4, IL_00e1, IL_00f0
		int num = 1;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				disposable = (IDisposable)evm0aOodGIEu960xfRNc(needResolver: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = DeserializeSimple(value, deserializeToType, null);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (disposable == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num4 = 0;
					}
					goto IL_008a;
				}
				goto IL_00bf;
				IL_00bf:
				aDCIFgodZSG33d1GslqU(disposable);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num4 = 1;
				}
				goto IL_008a;
				IL_008a:
				switch (num4)
				{
				default:
					goto end_IL_0065;
				case 0:
					goto end_IL_0065;
				case 2:
					break;
				case 1:
					goto end_IL_0065;
				}
				goto IL_00bf;
				end_IL_0065:;
			}
		}
	}

	protected virtual object DeserializeSimple(object value, Type deserializeToType, IEntity entity)
	{
		//Discarded unreachable code: IL_00f8, IL_0107, IL_01a5, IL_01f6, IL_0200, IL_020f, IL_021e, IL_02ff, IL_031e, IL_034a, IL_0359
		int num = 2;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		object result = default(object);
		Func<object> func = default(Func<object>);
		object obj3 = default(object);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		bool orDefault = default(bool);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (deserializeToType == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					disposable = (IDisposable)evm0aOodGIEu960xfRNc(needResolver: true);
					num2 = 3;
				}
				break;
			default:
				return result;
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138940804));
			case 3:
				try
				{
					int num3;
					if (Rdtb3fodEj9WldhCsD2n(typeof(IEntity).TypeHandle).IsAssignableFrom(deserializeToType))
					{
						num3 = 2;
						goto IL_00a1;
					}
					goto IL_0250;
					IL_01c3:
					int num4 = 16;
					goto IL_009d;
					IL_0250:
					result = base.DeserializeSimple(value, deserializeToType);
					num4 = 13;
					goto IL_009d;
					IL_009d:
					num3 = num4;
					goto IL_00a1;
					IL_00a1:
					while (true)
					{
						object obj;
						switch (num3)
						{
						case 1:
							return result;
						case 10:
							return result;
						case 13:
							return result;
						case 15:
							return result;
						case 5:
							if ((func = obj3 as Func<object>) != null)
							{
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto case 4;
						case 11:
							result = (IEntity)obj3;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num3 = 0;
							}
							continue;
						case 7:
							if (entity == null)
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num3 = 14;
								}
								continue;
							}
							goto case 8;
						case 2:
							dictionary = value as IDictionary<string, object>;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num3 = 0;
							}
							continue;
						case 16:
							result = null;
							num3 = 15;
							continue;
						default:
							if (dictionary == null)
							{
								goto IL_01c3;
							}
							goto case 6;
						case 12:
							result = func;
							num3 = 10;
							continue;
						case 8:
							obj = new EntityJsonSerializer().ConvertFromSerializable(entity, dictionary, !orDefault);
							goto IL_02bd;
						case 17:
							orDefault = ContextVars.GetOrDefault<bool>((string)sGggSRo9M7FDG9iI3Gii(-3333094 ^ -3163548));
							num3 = 7;
							continue;
						case 9:
							break;
						case 3:
							SDyfk4odXyjnwAinNhcF(obj2);
							num3 = 17;
							continue;
						case 4:
							ERjICJodTtkKV2HioDor(obj2);
							num3 = 11;
							continue;
						case 6:
							obj2 = new object();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num3 = 3;
							}
							continue;
						case 14:
							{
								obj = new EntityJsonSerializer().ConvertFromSerializable(dictionary, deserializeToType, !orDefault);
								goto IL_02bd;
							}
							IL_02bd:
							obj3 = obj;
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num3 = 5;
							}
							continue;
						}
						break;
					}
					goto IL_0250;
				}
				finally
				{
					int num5;
					if (disposable == null)
					{
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num5 = 0;
						}
						goto IL_0303;
					}
					goto IL_0328;
					IL_0328:
					disposable.Dispose();
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num5 = 0;
					}
					goto IL_0303;
					IL_0303:
					switch (num5)
					{
					default:
						goto end_IL_02de;
					case 1:
						goto end_IL_02de;
					case 2:
						break;
					case 0:
						goto end_IL_02de;
					}
					goto IL_0328;
					end_IL_02de:;
				}
			}
		}
	}

	public override void Copy(object obj, object target, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0099, IL_00a8, IL_00b9, IL_00c3, IL_0175, IL_01c2, IL_0251, IL_02e5, IL_031e, IL_044b, IL_045a, IL_04b4
		int num = 9;
		IEnumerator enumerator = default(IEnumerator);
		object o = default(object);
		UntypedISetProxy untypedISetProxy = default(UntypedISetProxy);
		PropertyInfo propertyCached = default(PropertyInfo);
		IEnumerable enumerable = default(IEnumerable);
		RelationType relationType = default(RelationType);
		IEnumerable enumerable2 = default(IEnumerable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 18:
					try
					{
						while (true)
						{
							int num3;
							if (!P67muCod8ED2Am6II7gA(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num3 = 0;
								}
								goto IL_00c7;
							}
							goto IL_0107;
							IL_0107:
							o = gI2Ae8odNiv0WIfWdnNc(enumerator);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
							{
								num3 = 1;
							}
							goto IL_00c7;
							IL_00c7:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 3:
									break;
								case 2:
									goto IL_0107;
								case 1:
									untypedISetProxy.Add(o);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
									{
										num3 = 3;
									}
									continue;
								case 0:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (disposable != null)
								{
									num4 = 2;
									continue;
								}
								break;
							case 2:
								aDCIFgodZSG33d1GslqU(disposable);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				case 29:
					if (!HaibTgodOeNPMAISM2rB(propertyCached, null))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 10;
						}
						break;
					}
					return;
				case 7:
					if (enumerable == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 1;
						}
						break;
					}
					propertyCached = target.GetType().GetPropertyCached((string)avPtyiodk81ybncCa6L9(propertyMetadata));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 29;
					}
					break;
				case 15:
					if (relationType != 0)
					{
						num2 = 5;
						break;
					}
					base.Copy(obj, target, metadata, propertyMetadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 12;
					}
					break;
				case 19:
					if (propertyCached == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 25;
						}
						break;
					}
					goto case 20;
				case 12:
					return;
				case 22:
					propertyCached = obj.GetType().GetPropertyCached((string)avPtyiodk81ybncCa6L9(propertyMetadata));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 19;
					}
					break;
				case 5:
					if ((uint)(relationType - 1) <= 2u)
					{
						num2 = 22;
						break;
					}
					return;
				case 24:
					return;
				case 23:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A617C80));
				case 6:
					if (untypedISetProxy == null)
					{
						num2 = 28;
						break;
					}
					aMI7P7odP1wlhTfoTycJ(untypedISetProxy);
					num2 = 4;
					break;
				case 8:
					return;
				case 13:
					return;
				case 14:
					if (metadata != null)
					{
						if (propertyMetadata == null)
						{
							num2 = 11;
							break;
						}
						relationType = nLFjy2o99PPyGug0YhUK((EntitySettings)ANZRtso9d3igFQKtT5ZT(propertyMetadata));
						num2 = 15;
						break;
					}
					goto end_IL_0012;
				case 25:
					return;
				case 1:
					if (target == null)
					{
						return;
					}
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 3;
					}
					break;
				case 9:
					if (obj == null)
					{
						num2 = 8;
						break;
					}
					goto case 1;
				case 20:
					if (propertyCached.CanRead)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 3;
						}
						break;
					}
					return;
				case 26:
					return;
				case 4:
					enumerator = (IEnumerator)LcNMByod1ed7Uv2UsvR8(enumerable);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 9;
					}
					break;
				case 11:
					throw new ArgumentNullException((string)sGggSRo9M7FDG9iI3Gii(-2107978722 ^ -2107996852));
				case 28:
					return;
				case 21:
					return;
				case 17:
					untypedISetProxy = (UntypedISetProxy)rkJHx0ode8qwKGvBtUVt(enumerable2);
					num2 = 6;
					break;
				case 16:
					if (enumerable2 == null)
					{
						return;
					}
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 17;
					}
					break;
				case 10:
					if (rglNjuod28gkaiITv2T2(propertyCached))
					{
						enumerable2 = (IEnumerable)propertyCached.GetValue(target, null);
						num2 = 16;
						break;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 24;
					}
					break;
				case 2:
					return;
				case 27:
					return;
				case 3:
					enumerable = (IEnumerable)QfYxApodnqp01XXlcgsl(propertyCached, obj, null);
					num2 = 7;
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 23;
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_0062, IL_0071, IL_0081, IL_01ed
		int num = 14;
		IEnumerable enumerable = default(IEnumerable);
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		DetachedCriteria val = default(DetachedCriteria);
		object[] array = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					return;
				case 11:
					if (enumerable == null)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 9:
					if (nLFjy2o99PPyGug0YhUK(_003C_003Ec__DisplayClass23_.settings) == RelationType.OneToMany)
					{
						num2 = 8;
						continue;
					}
					goto case 12;
				case 8:
				{
					Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(aXsQDqo9LAocDrZMPFve(propertyMetadata));
					PropertyMetadata propertyMetadata2 = (InterfaceActivator.LoadMetadata(typeByUid) as ClassMetadata).Properties.FirstOrDefault(_003C_003Ec__DisplayClass23_._003CApplyFilterValue_003Eb__1);
					val = (DetachedCriteria)zi4ISYodtXiaYryQqnxQ(((DetachedCriteria)XlnLe7od3KiRmnv2iHlF(typeByUid)).Add((ICriterion)BbahUaodaiGc8VT1bQb8(QHVvrVodpr5m3DF707Tl(), array)), YBrpdcodDtksPVUD4Dmv(avPtyiodk81ybncCa6L9(propertyMetadata2)));
					num = 10;
					break;
				}
				case 15:
					return;
				case 5:
				case 10:
					criteria.Add((ICriterion)sNNvybodAPGp1y3Bs7Sl(mfOY6IodHo8AVIitAvem(rVQVmKod64m1Npbi3JYr(criteria), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477236354)), val));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (array.Length != 0)
					{
						_003C_003Ec__DisplayClass23_.settings = (EntitySettings)ANZRtso9d3igFQKtT5ZT(propertyMetadata);
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 15;
					}
					continue;
				case 1:
					return;
				case 7:
					base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
					num2 = 4;
					continue;
				case 0:
					return;
				case 13:
					enumerable = value as IEnumerable;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					num2 = 2;
					continue;
				case 14:
					if (value == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 13;
					}
					continue;
				case 12:
					val = (DetachedCriteria)zi4ISYodtXiaYryQqnxQ(MdyUGhod49MsjBqIkeIP(sGY6tsodw300ZTV9hvar(DetachedCriteria.For(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(txZuxZodRdw61Gr5LRxu(metadata))), avPtyiodk81ybncCa6L9(propertyMetadata), (JoinType)0), Restrictions.In((IProjection)QHVvrVodpr5m3DF707Tl(), array)), QHVvrVodpr5m3DF707Tl());
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					array = (from e in enumerable.OfType<IEntity>()
						select _003C_003Ec.X7WO1bCSuMjcQtoBBow5(e)).ToArray();
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	public override string FormatValue(object value, TypeSettings settings)
	{
		//Discarded unreachable code: IL_00d1, IL_00e4, IL_00f3, IL_0102
		int num = 3;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			switch (num2)
			{
			default:
				if (nLFjy2o99PPyGug0YhUK(entitySettings) != 0)
				{
					num2 = 7;
					break;
				}
				goto case 4;
			case 2:
				entitySettings = settings as EntitySettings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				enumerable = value as IEnumerable;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				if (entitySettings == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (enumerable == null)
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 4:
			case 5:
			case 6:
				return base.FormatValue(value, settings);
			case 7:
				return (string)n0ZZ30od7K3RM5MX63AZ(sGggSRo9M7FDG9iI3Gii(-3333094 ^ -3332072), (from object o in enumerable
					select o.ToString()).ToArray());
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 5;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 6:
				Do51Wjo9z2On9XKYiDRF(entitySettings, RelationType.ManyToMany);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (propertyMetadata.Settings != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 2:
				entitySettings = (EntitySettings)ClassSerializationHelper.CloneObjectByXml((TypeSettings)ANZRtso9d3igFQKtT5ZT(propertyMetadata));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (propertyMetadata != null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
				return entitySettings;
			case 3:
				if (unn6gpodx412EG27lmTf(entitySettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_016a, IL_0179, IL_0188, IL_0327, IL_0336
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		int num = 12;
		int num2 = num;
		IEntity entity = default(IEntity);
		_003C_003Ec__DisplayClass26_1 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_1);
		Type typeByUid = default(Type);
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_2 = default(_003C_003Ec__DisplayClass26_0);
		EntityInfo entityInfo = default(EntityInfo);
		RelationType relationType = default(RelationType);
		Action<EntityInfo> action = default(Action<EntityInfo>);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (entity == null)
				{
					num2 = 25;
					break;
				}
				goto case 19;
			case 17:
				_003C_003Ec__DisplayClass26_.result = (ISet)Activator.CreateInstance(typeof(HashedSet<>).MakeGenericType(typeByUid));
				num2 = 21;
				break;
			case 19:
				return entity;
			case 25:
				return ModelHelper.GetEntity(aXsQDqo9LAocDrZMPFve(_003C_003Ec__DisplayClass26_2.propertyMetadata), wlHig4odytsPSNNtXWV1(entityInfo));
			case 18:
				if (entityInfo != null)
				{
					num2 = 4;
					break;
				}
				return null;
			case 23:
				if (_003C_003Ec__DisplayClass26_2.propertyMetadata == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 14;
					}
					break;
				}
				if (value == null)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 26;
					}
					break;
				}
				relationType = ((EntitySettings)ANZRtso9d3igFQKtT5ZT(_003C_003Ec__DisplayClass26_2.propertyMetadata)).RelationType;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 13;
				}
				break;
			case 14:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124455F6));
			case 16:
				if (!(value is EntityListInfo))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 7:
				_003C_003Ec__DisplayClass26_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass26_2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(aXsQDqo9LAocDrZMPFve(_003C_003Ec__DisplayClass26_.CS_0024_003C_003E8__locals1.propertyMetadata));
				num2 = 17;
				break;
			case 11:
				_003C_003Ec__DisplayClass26_2.propertyMetadata = propertyMetadata;
				num2 = 23;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 11;
				}
				break;
			case 4:
				if (entityInfo.Uid != Guid.Empty)
				{
					num2 = 5;
					break;
				}
				goto case 25;
			case 9:
				if (value is EntityInfo)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			case 20:
			case 22:
				return _003C_003Ec__DisplayClass26_.result;
			case 1:
				return value;
			case 3:
				((EntityListInfo)value).Items.ForEach(action);
				num2 = 22;
				break;
			case 8:
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_1();
				num2 = 7;
				break;
			case 26:
				return null;
			case 2:
				return value;
			case 24:
				entityInfo = value as EntityInfo;
				num2 = 18;
				break;
			case 13:
				action((EntityInfo)value);
				num2 = 20;
				break;
			case 5:
				entity = (IEntity)ExY5anodml90kLgvRR9t(aXsQDqo9LAocDrZMPFve(_003C_003Ec__DisplayClass26_2.propertyMetadata), GaO1Tood0p82QSfncg0m(entityInfo));
				num2 = 10;
				break;
			case 15:
				if (relationType != 0)
				{
					if (!(value is EntityInfo))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 16;
						}
						break;
					}
					goto case 8;
				}
				num2 = 6;
				break;
			case 12:
				_003C_003Ec__DisplayClass26_2 = new _003C_003Ec__DisplayClass26_0();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 11;
				}
				break;
			case 6:
				if (!(value is IEntity))
				{
					num2 = 24;
					break;
				}
				goto case 2;
			case 21:
				action = _003C_003Ec__DisplayClass26_._003CConvertFrom_003Eb__0;
				num2 = 9;
				break;
			}
		}
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	public virtual bool IsValuesEquals(object v1, object v2)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_0243, IL_0252, IL_027f, IL_028e, IL_029e, IL_02e5, IL_02f4
		int num = 13;
		IEnumerable enumerable2 = default(IEnumerable);
		_003C_003Ec__DisplayClass28_1 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_1);
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_2 = default(_003C_003Ec__DisplayClass28_0);
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (enumerable2 != null)
					{
						goto end_IL_0012;
					}
					goto case 19;
				case 14:
					return true;
				case 10:
				case 17:
					if (TqQHEDodMOBxpMZQcr05(_003C_003Ec__DisplayClass28_.list1) != _003C_003Ec__DisplayClass28_.list2.Count)
					{
						num2 = 7;
						continue;
					}
					if (_003C_003Ec__DisplayClass28_.list1.All(_003C_003Ec__DisplayClass28_._003CIsValuesEquals_003Eb__1))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 21;
						}
						continue;
					}
					return false;
				case 13:
					_003C_003Ec__DisplayClass28_2 = new _003C_003Ec__DisplayClass28_0();
					num2 = 12;
					continue;
				case 11:
					if (TqQHEDodMOBxpMZQcr05(_003C_003Ec__DisplayClass28_.list2) != 0)
					{
						num2 = 10;
						continue;
					}
					goto case 14;
				case 23:
					if (v2 == null)
					{
						num2 = 15;
						continue;
					}
					break;
				case 4:
					if (!(v1 is IEntity))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 7:
					return false;
				case 8:
					enumerable2 = v2 as IEnumerable;
					num2 = 22;
					continue;
				case 9:
					_003C_003Ec__DisplayClass28_.list2 = enumerable2.Cast<object>().ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					continue;
				case 21:
					return _003C_003Ec__DisplayClass28_.list2.All(_003C_003Ec__DisplayClass28_._003CIsValuesEquals_003Eb__2);
				case 19:
					return false;
				case 20:
					return _003C_003Ec__DisplayClass28_2.CompareValues(v1, v2);
				case 2:
				case 6:
					enumerable = v1 as IEnumerable;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 8;
					}
					continue;
				case 12:
					if (v1 == null)
					{
						num2 = 23;
						continue;
					}
					break;
				default:
					if (_003C_003Ec__DisplayClass28_.list1.Count != 0)
					{
						num2 = 17;
						continue;
					}
					goto case 11;
				case 22:
					if (enumerable == null)
					{
						num2 = 19;
						continue;
					}
					goto case 3;
				case 18:
					_003C_003Ec__DisplayClass28_.list1 = enumerable.Cast<object>().ToList();
					num2 = 9;
					continue;
				case 1:
					if (!(v2 is IEntity))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 20;
				case 16:
					_003C_003Ec__DisplayClass28_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass28_2;
					num2 = 18;
					continue;
				case 5:
					_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_1();
					num2 = 16;
					continue;
				case 15:
					return true;
				}
				_003C_003Ec__DisplayClass28_2.CompareValues = delegate(object obj1, object obj2)
				{
					//Discarded unreachable code: IL_0045, IL_00c2, IL_00d1
					int num3 = 6;
					IEntity entity = default(IEntity);
					IEntity entity2 = default(IEntity);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 6:
								entity = obj1 as IEntity;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
								{
									num4 = 5;
								}
								continue;
							case 5:
								break;
							case 4:
								if (entity.GetType().IsAssignableFrom(entity2.GetType()))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 2;
							case 2:
								if (entity2.GetType().IsAssignableFrom(entity.GetType()))
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 7;
							case 8:
								if (entity2 != null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
									{
										num4 = 4;
									}
									continue;
								}
								goto case 7;
							default:
								return _003C_003Ec.X7WO1bCSuMjcQtoBBow5(entity).Equals(_003C_003Ec.X7WO1bCSuMjcQtoBBow5(entity2));
							case 7:
								return false;
							case 3:
								if (entity == null)
								{
									num4 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num4 = 7;
									}
									continue;
								}
								goto case 8;
							}
							break;
						}
						entity2 = obj2 as IEntity;
						num3 = 3;
					}
				};
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public virtual void PrepareDeserializedData(IDictionary<string, object> data)
	{
		foreach (string key in data.Keys)
		{
			if (data[key] is IDictionary<string, object> dictionary)
			{
				foreach (string item in dictionary.Keys.ToList())
				{
					if (item != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138127578))
					{
						dictionary.Remove(item);
					}
				}
			}
			if (!(data[key] is List<IDictionary<string, object>> list))
			{
				continue;
			}
			foreach (IDictionary<string, object> item2 in list)
			{
				foreach (string item3 in item2.Keys.ToList())
				{
					if (item3 != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870859415))
					{
						item2.Remove(item3);
					}
				}
			}
		}
	}

	internal static T RunWithCheckSoftDeletable<T>(Func<T> action)
	{
		bool flag = сheckSoftDeletable;
		сheckSoftDeletable = true;
		try
		{
			return action();
		}
		finally
		{
			сheckSoftDeletable = flag;
		}
	}

	protected override string GetTypeName(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_01ae
		int num = 3;
		ClassMetadata classMetadata2 = default(ClassMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					classMetadata2 = GetMetadata(PaWVJModdiZ9KNOgcbNM(entityMetadata2));
					num2 = 11;
					break;
				case 8:
					if (entityMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 10;
				case 5:
					if (!bK0CxfodJsUP9Vq1mOLO(classMetadata))
					{
						num2 = 9;
						break;
					}
					goto case 10;
				case 6:
					if (KUmPIYod9O7ROugOeY08(entityMetadata) == EntityMetadataType.InterfaceExtension)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 10;
				default:
					if (classMetadata != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 10;
				case 1:
					classMetadata2 = (ClassMetadata)thEU7codlu6EVWL2TTKo(this, PaWVJModdiZ9KNOgcbNM(entityMetadata));
					num2 = 10;
					break;
				case 7:
					if (entityMetadata2 != null)
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 3:
					classMetadata2 = GetMetadata(aXsQDqo9LAocDrZMPFve(propertyMetadata));
					num2 = 2;
					break;
				case 12:
					if (!forFilter)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 10;
				case 10:
				case 11:
					return classMetadata2.FullTypeName;
				case 2:
					entityMetadata = classMetadata2 as EntityMetadata;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 12;
					}
					break;
				case 4:
					entityMetadata2 = thEU7codlu6EVWL2TTKo(this, qjvF9CodrTjn0du9rVMR(classMetadata2)) as EntityMetadata;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					if (KUmPIYod9O7ROugOeY08(entityMetadata) == EntityMetadataType.Interface)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 6;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public override string GetTypeDisplayName(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)LhL7HCodgYQtXTX3rAIF(sGggSRo9M7FDG9iI3Gii(0x42643203 ^ 0x42664137), VTfxOto9JfEHSGKRwBi7(f1CIdio9rZ4r8OHxb0k6(classMetadata)), SR.T((string)sGggSRo9M7FDG9iI3Gii(0x1DE3DD89 ^ 0x1DE14327)));
			case 1:
				classMetadata = (ClassMetadata)thEU7codlu6EVWL2TTKo(this, subTypeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual bool IsSupportedMetadataType(Type type, ClassMetadata classMetadata)
	{
		return fOg8cKodoLabF4DApiQF(type, typeof(EntityMetadata));
	}

	[IteratorStateMachine(typeof(_003CGetAdditionalTypeMembers_003Ed__34))]
	protected virtual IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(EntityMetadata entityMetadata, PropertyMetadata propertyMetadata, EntityMetadata intfMetadata, EntityMetadata refIntfMetadata, EntityMetadata refImplMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetAdditionalTypeMembers_003Ed__34(-2)
		{
			_003C_003E3__propertyMetadata = propertyMetadata,
			_003C_003E3__intfMetadata = intfMetadata,
			_003C_003E3__refIntfMetadata = refIntfMetadata,
			_003C_003E3__refImplMetadata = refImplMetadata
		};
	}

	protected virtual object TryDeserializeEntityId(IDictionary<string, object> dictionary, Type entityType)
	{
		if (dictionary != null && dictionary.TryGetValue(IdPropertyName, out var value))
		{
			return ModelHelper.TryConvertEntityId(entityType, value);
		}
		return null;
	}

	protected virtual Type GetEntityType(IDictionary<string, object> objects, PropertyMetadata propertyMetadata)
	{
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		if (objects != null && objects.TryGetValue(TypeUidPropertyName, out var value))
		{
			Guid uid = (Guid)Locator.GetServiceNotNull<GuidDescriptor>().DeserializeSimple(value, typeof(Guid));
			return serviceNotNull.GetTypeByUid(uid);
		}
		if (propertyMetadata != null)
		{
			return serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid);
		}
		return null;
	}

	private Guid GetEntityGuid(IEntity entity, Type entityType = null)
	{
		//Discarded unreachable code: IL_0072
		int num = 1;
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = default(_003C_003Ec__DisplayClass43_0);
		Guid orAdd = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return Guid.Empty;
				default:
					_003C_003Ec__DisplayClass43_.entityType = entityType;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
				case 7:
					orAdd = entityUidProperties.GetOrAdd(_003C_003Ec__DisplayClass43_.entityType.GUID, _003C_003Ec__DisplayClass43_._003CGetEntityGuid_003Eb__0);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					if (orAdd != Guid.Empty)
					{
						return entity.GetPropertyValue<Guid>(orAdd);
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					if (_003C_003Ec__DisplayClass43_.entityType == null)
					{
						break;
					}
					goto end_IL_0012;
				case 1:
					_003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				}
				_003C_003Ec__DisplayClass43_.entityType = entity.GetType();
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public EntityDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LvmKccod5r2THlyyIkiw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityDescriptor()
	{
		int num = 3;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					parameterExpression = (ParameterExpression)vqrgsXodjJMBkbVdtLFI(Rdtb3fodEj9WldhCsD2n(typeof(IEntity<object>).TypeHandle), sGggSRo9M7FDG9iI3Gii(-787452571 ^ -787421875));
					num2 = 7;
					continue;
				case 6:
					entityUidProperties = new ConcurrentDictionary<Guid, Guid>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					parameterExpression = (ParameterExpression)vqrgsXodjJMBkbVdtLFI(Rdtb3fodEj9WldhCsD2n(typeof(IInheritable).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146531661));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F7F808));
					num2 = 5;
					continue;
				case 1:
					return;
				case 3:
					LvmKccod5r2THlyyIkiw();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					IdPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>((Expression)aYWAEjodLQ7j2uCDisIq(parameterExpression, (MethodInfo)cAwecmodYWdYSTE9niMY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 4;
					continue;
				}
				break;
			}
			TypeUidPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IInheritable, object>>((Expression)lDNyTSodsbiJNnKvk2Zc(aYWAEjodLQ7j2uCDisIq(parameterExpression, (MethodInfo)NdRAFModU3rtEVyGg4tC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Rdtb3fodEj9WldhCsD2n(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
			num = 6;
		}
	}

	internal static object sGggSRo9M7FDG9iI3Gii(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VTfxOto9JfEHSGKRwBi7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool HLxy98o9m7bZNlKXg51B()
	{
		return NyA7jho90FTcZKmug8Y3 == null;
	}

	internal static EntityDescriptor cLet6Zo9yhOeRgok8cvl()
	{
		return NyA7jho90FTcZKmug8Y3;
	}

	internal static RelationType nLFjy2o99PPyGug0YhUK(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object ANZRtso9d3igFQKtT5ZT(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool VFwffro9lujehijBYfDG(object P_0)
	{
		return ((EntitySettings)P_0).GenerateFilterInFilter;
	}

	internal static object f1CIdio9rZ4r8OHxb0k6(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object iW4pjto9g1RnqhQdJkZs(object P_0, object P_1)
	{
		return ((TypeDescriptor)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
	}

	internal static bool MmKhu2o95vW1RVN7BrLD(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object iq2isfo9jiuvYdZ9xIsq(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object TiPCRjo9YVNGPUXkAWdL(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static Guid aXsQDqo9LAocDrZMPFve(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object cjl5e7o9Ui3Rt1ySfrgb(object P_0)
	{
		return ((TypeSerializationDescriptorBuilder)P_0).Descriptor;
	}

	internal static object fu9QDyo9sMj57bHq21jD(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void DAaEZSo9c26UD4B01XkT(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void Do51Wjo9z2On9XKYiDRF(object P_0, RelationType value)
	{
		((EntitySettings)P_0).RelationType = value;
	}

	internal static void C37BVrodFhIBj61bKhqy(object P_0, object P_1)
	{
		((TypeSerializationItemDescriptor)P_0).Descriptor = (TypeSerializationDescriptor)P_1;
	}

	internal static object PTr3mkodB9TEO4tKZUwq(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void QubtcaodWxhC5S84uyKS(object P_0, object P_1)
	{
		((TypeSerializationItemDescriptor)P_0).Name = (string)P_1;
	}

	internal static bool fOg8cKodoLabF4DApiQF(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool bWpPduodbBoo4jF6ETiF(object P_0)
	{
		return ((EntitySerializationSettings)P_0).WriteReferences;
	}

	internal static object SR49OWodhF5C0uU5I7Re()
	{
		return ReferenceResolverSerializer.CurrentResolver;
	}

	internal static object evm0aOodGIEu960xfRNc(bool needResolver)
	{
		return ReferenceResolverSerializer.CreateResolver(needResolver);
	}

	internal static Type Rdtb3fodEj9WldhCsD2n(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Wm3Tf3odfFGjAkxDNPSg(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static EntitySerializationMode vnytVFodQ7LhRKFIhpv4(object P_0)
	{
		return ((EntitySerializationSettings)P_0).Mode;
	}

	internal static object tbmoRkodCtV4AEFC5BAg(object P_0)
	{
		return ((EntitySerializationSettings)P_0).PropertySelector;
	}

	internal static SelectionMode DntH6GodvqjPnMFG0u8B(object P_0)
	{
		return ((EntitySerializationSelector)P_0).SelectionMode;
	}

	internal static bool P67muCod8ED2Am6II7gA(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void aDCIFgodZSG33d1GslqU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int dFUH1noduobUSk8j6Jx0(object P_0)
	{
		return ((Dictionary<Guid, EntitySerializationSelector>)P_0).Count;
	}

	internal static object Jp8J3vodIOCEDWS0B0Tw(object P_0, object P_1, object P_2)
	{
		return ((EntityJsonSerializer)P_0).ConvertToSerializable(P_1, (EntitySerializationSettings)P_2);
	}

	internal static object iLDYtuodVU0ZBvNWNvdT(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool S36he6odSjVF50kbYj5Y(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static bool nNyu9HodiBEQtdhmif3a(object P_0)
	{
		return ((ClassMetadata)P_0).AllowCreateHeirs;
	}

	internal static Guid txZuxZodRdw61Gr5LRxu(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object bIQkvVodqc6moksZ09nE(object P_0)
	{
		return ((EntityMetadata)P_0).GetUidProperty();
	}

	internal static object YbpqDmodKcKOQ4JSqiPk(object P_0)
	{
		return WebData.CreateFromObject(P_0);
	}

	internal static void SDyfk4odXyjnwAinNhcF(object P_0)
	{
		EntityJsonSerializer.AddSerializerMarker(P_0);
	}

	internal static void ERjICJodTtkKV2HioDor(object P_0)
	{
		EntityJsonSerializer.InvokeActions(P_0);
	}

	internal static object avPtyiodk81ybncCa6L9(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object QfYxApodnqp01XXlcgsl(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool HaibTgodOeNPMAISM2rB(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool rglNjuod28gkaiITv2T2(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static object rkJHx0ode8qwKGvBtUVt(object P_0)
	{
		return P_0.AsUntypedISet();
	}

	internal static void aMI7P7odP1wlhTfoTycJ(object P_0)
	{
		((UntypedISetProxy)P_0).Clear();
	}

	internal static object LcNMByod1ed7Uv2UsvR8(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object gI2Ae8odNiv0WIfWdnNc(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object XlnLe7od3KiRmnv2iHlF(Type P_0)
	{
		return DetachedCriteria.For(P_0);
	}

	internal static object QHVvrVodpr5m3DF707Tl()
	{
		return Projections.Id();
	}

	internal static object BbahUaodaiGc8VT1bQb8(object P_0, object P_1)
	{
		return Restrictions.In((IProjection)P_0, (object[])P_1);
	}

	internal static object YBrpdcodDtksPVUD4Dmv(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object zi4ISYodtXiaYryQqnxQ(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static object sGY6tsodw300ZTV9hvar(object P_0, object P_1, JoinType P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateCriteria((string)P_1, P_2);
	}

	internal static object MdyUGhod49MsjBqIkeIP(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object rVQVmKod64m1Npbi3JYr(object P_0)
	{
		return ((ICriteria)P_0).get_Alias();
	}

	internal static object mfOY6IodHo8AVIitAvem(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object sNNvybodAPGp1y3Bs7Sl(object P_0, object P_1)
	{
		return Subqueries.PropertyIn((string)P_0, (DetachedCriteria)P_1);
	}

	internal static object n0ZZ30od7K3RM5MX63AZ(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static bool unn6gpodx412EG27lmTf(object P_0)
	{
		return ((EntitySettings)P_0).GenerateListInFilter;
	}

	internal static Guid GaO1Tood0p82QSfncg0m(object P_0)
	{
		return ((EntityInfo)P_0).Uid;
	}

	internal static object ExY5anodml90kLgvRR9t(Guid typeUid, Guid uid)
	{
		return ModelHelper.GetEntity(typeUid, uid);
	}

	internal static object wlHig4odytsPSNNtXWV1(object P_0)
	{
		return ((EntityInfo)P_0).Id;
	}

	internal static int TqQHEDodMOBxpMZQcr05(object P_0)
	{
		return ((List<object>)P_0).Count;
	}

	internal static bool bK0CxfodJsUP9Vq1mOLO(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static EntityMetadataType KUmPIYod9O7ROugOeY08(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid PaWVJModdiZ9KNOgcbNM(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object thEU7codlu6EVWL2TTKo(object P_0, Guid P_1)
	{
		return ((RefTypeDescriptor<IEntity, EntitySettings>)P_0).GetMetadata(P_1);
	}

	internal static Guid qjvF9CodrTjn0du9rVMR(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object LhL7HCodgYQtXTX3rAIF(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void LvmKccod5r2THlyyIkiw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object vqrgsXodjJMBkbVdtLFI(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object cAwecmodYWdYSTE9niMY(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object aYWAEjodLQ7j2uCDisIq(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object NdRAFModU3rtEVyGg4tC(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object lDNyTSodsbiJNnKvk2Zc(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}
