using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

public static class DependencyServiceHelper
{
	private static IEnumerable<ITypeDescriptor> descriptors;

	internal static DependencyServiceHelper gcTskcbClJXvDoem6Cep;

	private static IEnumerable<ITypeDescriptor> Descriptors => descriptors ?? (descriptors = Locator.GetServiceNotNull<IEnumerable<ITypeDescriptor>>());

	internal static void AnalyseTypeSignature(TypeSignature signature, IDictionary<Guid, DataClassDependency> dataClassDependencies, IDictionary<Guid, EntityDependency> entityDependencies, IDictionary<Guid, EnumDependency> enumDependencies, Guid currentModuleUid, DependencyServiceOptions options)
	{
		if (IsDataClass(signature.TypeUid, signature.SubTypeUid))
		{
			if (!(MetadataServiceContext.Service.GetMetadata(signature.SubTypeUid) is DataClassMetadata dataClassMetadata))
			{
				throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269CEC44), signature.SubTypeUid));
			}
			if (!SkipDependency(dataClassMetadata, currentModuleUid, options))
			{
				AddClassDependency(dataClassDependencies, dataClassMetadata.Uid, dataClassMetadata, (DataClassMetadata m) => m.GetSignature(simple: true));
			}
			return;
		}
		if (IsEntity(signature.TypeUid))
		{
			if (!(MetadataServiceContext.Service.GetMetadata(signature.SubTypeUid) is EntityMetadata metadata))
			{
				throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217617179), signature.SubTypeUid));
			}
			AddClassDependency(entityDependencies, signature.SubTypeUid, metadata, (EntityMetadata m) => m.GetSignature(simple: true));
		}
		if (IsEnum(signature.TypeUid))
		{
			if (!(MetadataServiceContext.Service.GetMetadata(signature.SubTypeUid) is EnumMetadata metadata2))
			{
				throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AF7F04), signature.SubTypeUid));
			}
			AddEnumDependency(enumDependencies, metadata2);
		}
	}

	internal static bool IsDataClass(Guid typeUid, Guid subTypeUid)
	{
		return tfYDwXbC5UG5cY7BOi6R(typeUid, DataClassDescriptor.UID);
	}

	internal static bool IsAction(Guid typeUid)
	{
		return tfYDwXbC5UG5cY7BOi6R(typeUid, ActionDescriptor.UID);
	}

	internal static bool IsEntity(Guid typeUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass6_.typeUid = typeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			return Descriptors.Where(delegate(ITypeDescriptor a)
			{
				//Discarded unreachable code: IL_005e, IL_006d
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 1:
						if (!(a is EntityDescriptor))
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						return !_003C_003Ec.MPvQRbCnLcgcBOdZq2Wc(a);
					default:
						return false;
					}
				}
			}).FirstOrDefault(_003C_003Ec__DisplayClass6_._003CIsEntity_003Eb__1) != null;
		}
	}

	internal static bool IsEnum(Guid typeUid)
	{
		return tfYDwXbC5UG5cY7BOi6R(typeUid, EnumDescriptor.UID);
	}

	public static void ProcessMetadata(Guid currentModuleUid, IMetadata metadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies, IPropertyMetadata propertyMetadata = null)
	{
		if (metadata == null)
		{
			return;
		}
		if (!(metadata is EnumMetadata enumMetadata))
		{
			if (!(metadata is EntityMetadata entityMetadata))
			{
				if (!(metadata is DataClassMetadata dataClassMetadata))
				{
					return;
				}
				DataClassMetadata dataClassMetadata2 = dataClassMetadata;
				if (!SkipDependency(dataClassMetadata2, currentModuleUid, options))
				{
					AddClassDependency(dataClassDependencies, dataClassMetadata2, (DataClassMetadata m) => m.GetSignature(simple: true), propertyMetadata);
				}
			}
			else
			{
				EntityMetadata metadata2 = entityMetadata;
				AddClassDependency(entityDependencies, metadata2, (EntityMetadata m) => m.GetSignature(simple: true), propertyMetadata);
			}
		}
		else
		{
			EnumMetadata metadata3 = enumMetadata;
			AddEnumDependency(enumDependencies, metadata3);
		}
	}

	internal static void AddClassDependency<T, TMetadata>(IDictionary<Guid, T> classDependencies, Guid metadataUid, TMetadata metadata, Func<TMetadata, T> createDependency, IPropertyMetadata property = null) where T : ClassDependency where TMetadata : ClassMetadata
	{
		_003C_003Ec__DisplayClass9_0<T, TMetadata> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0<T, TMetadata>();
		CS_0024_003C_003E8__locals0.property = property;
		if (metadata == null || classDependencies == null)
		{
			return;
		}
		if (!classDependencies.ContainsKey(metadataUid))
		{
			classDependencies[metadataUid] = createDependency(metadata);
		}
		if (CS_0024_003C_003E8__locals0.property != null)
		{
			List<PropertySignature> properties = classDependencies[metadataUid].Properties;
			if (properties.FirstOrDefault((PropertySignature p) => p.Uid == CS_0024_003C_003E8__locals0.property.Uid) == null)
			{
				properties.Add(CS_0024_003C_003E8__locals0.property.CreatePropertySignature());
			}
		}
	}

	internal static void AddClassDependency<T, TMetadata>(IDictionary<Guid, T> classDependencies, TMetadata metadata, Func<TMetadata, T> createDependency, IPropertyMetadata property = null) where T : ClassDependency where TMetadata : ClassMetadata
	{
		Guid uid = metadata.Uid;
		if (metadata is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceExtension)
		{
			IMetadata metadata2 = MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid);
			if (metadata2 != null)
			{
				uid = metadata2.Uid;
			}
		}
		AddClassDependency(classDependencies, uid, metadata, createDependency, property);
	}

	internal static void AddFunctionDependency(IDictionary<Guid, FunctionDependency> functionDependencies, FunctionMetadata metadata)
	{
		if (metadata != null && functionDependencies != null && !functionDependencies.ContainsKey(metadata.Uid))
		{
			functionDependencies[metadata.Uid] = metadata.GetSignature();
		}
	}

	internal static void AddEnumDependency(IDictionary<Guid, EnumDependency> enumDependencies, EnumMetadata metadata)
	{
		if (metadata != null && enumDependencies != null && !enumDependencies.ContainsKey(metadata.Uid))
		{
			enumDependencies[metadata.Uid] = metadata.GetSignature();
		}
	}

	internal static bool SkipDependency(IMetadata md, Guid currentModuleUid, DependencyServiceOptions options)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_007c, IL_008b, IL_009a
		int num = 7;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if ((dataClassMetadata = md as DataClassMetadata) == null)
					{
						num2 = 6;
						break;
					}
					goto case 8;
				default:
					return true;
				case 4:
				case 6:
					if (tfYDwXbC5UG5cY7BOi6R(currentModuleUid, Guid.Empty))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 2;
						}
						break;
					}
					if (tfYDwXbC5UG5cY7BOi6R(Vhk4jDbCUCAb3sT8ijlB(md), currentModuleUid))
					{
						if (options == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 5;
					}
					num2 = 2;
					break;
				case 8:
					if (!QQgqa4bCLExWppXR5IMt(HtF1uVbCjvC4xjHjG9uW(dataClassMetadata), sC9WhWbCYIss1Bn5boKk(-475857671 ^ -476034867)))
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					return false;
				case 3:
					return false;
				case 5:
					return C73ZG5bCsUW1KGYEsTiG(options);
				case 1:
					return true;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static bool tfYDwXbC5UG5cY7BOi6R(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool nnbePdbCrwM6SdYq99pL()
	{
		return gcTskcbClJXvDoem6Cep == null;
	}

	internal static DependencyServiceHelper yr6ZHKbCgP053ufJqeuA()
	{
		return gcTskcbClJXvDoem6Cep;
	}

	internal static object HtF1uVbCjvC4xjHjG9uW(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object sC9WhWbCYIss1Bn5boKk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool QQgqa4bCLExWppXR5IMt(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Guid Vhk4jDbCUCAb3sT8ijlB(object P_0)
	{
		return ((IMetadata)P_0).ModuleUid;
	}

	internal static bool C73ZG5bCsUW1KGYEsTiG(object P_0)
	{
		return ((DependencyServiceOptions)P_0).SkipCurrentModule;
	}
}
