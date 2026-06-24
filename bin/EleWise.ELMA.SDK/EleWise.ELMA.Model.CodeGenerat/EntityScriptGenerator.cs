using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class EntityScriptGenerator : ClassGenerator
{
	protected readonly IMetadataService MetadataService;

	private static EntityScriptGenerator V3AdV2hOfuxi2N2qAsON;

	private string ClassName
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (string.IsNullOrEmpty((string)aIyvblhOTq70emQ7yBqD(metadata)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return (string)tI2w7HhOnBPFuq6acWtK(((IEnumerable<string>)hHTF2PhOkw97Pf0EclEm(((IEnumerable<string>)hHTF2PhOkw97Pf0EclEm(aIyvblhOTq70emQ7yBqD(metadata), new char[1] { ',' })).First(), new char[1] { '.' })).Last());
				default:
					return metadata.Name + (string)ftA5P7hOvJyWuQowVAtS(0x17ADCCD8 ^ 0x17AC9FC6);
				}
			}
		}
	}

	private string InterfaceName => (string)OLBLkfhO8pqCVPI0df4n(ftA5P7hOvJyWuQowVAtS(0x4DC2B14D ^ 0x4DC04F8B), metadata.Name);

	public EntityScriptGenerator(IMetadataService metadataService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				MetadataService = metadataService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		return new ISyntaxNode[1] { ClassName.ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Partial, GetBaseClass(), null, GetMembers()) };
	}

	protected override string GetNamespace()
	{
		return (string)OLBLkfhO8pqCVPI0df4n(metadata.Namespace, ftA5P7hOvJyWuQowVAtS(0x68BBB53E ^ 0x68B8E4EC));
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return typeof(EntityScriptModule<>).CreateTypeSyntax(InterfaceName.CreateTypeSyntax());
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		EntityViewModelGenerator entityViewModelGenerator = new EntityViewModelGenerator();
		((ICodeGenerator)entityViewModelGenerator).Metadata = metadata;
		list.Add(entityViewModelGenerator.Generate());
		list.AddRange(ProcessTableParts(metadata, (EntityMetadata)metadata));
		EntityMetadata entityMetadata = (EntityMetadata)ClassSerializationHelper.CloneObjectByXml(metadata);
		while (entityMetadata?.ViewModelMetadata != null)
		{
			Guid baseClassUid = entityMetadata.BaseClassUid;
			EntityMetadata obj = ((baseClassUid != Guid.Empty) ? ((EntityMetadata)MetadataService.GetMetadata(baseClassUid, loadImplementation: false)) : null);
			list.Add(new ViewModelContextGenerator(obj?.Uid)
			{
				Metadata = GetFakeEntityMetadata(entityMetadata)
			}.Generate());
			entityMetadata = ClassSerializationHelper.CloneObjectByXml(obj);
			if (!(baseClassUid != Guid.Empty))
			{
				break;
			}
		}
		return list;
	}

	protected virtual IEnumerable<ISyntaxNode> ProcessTableParts(ClassMetadata rootMetadata, EntityMetadata entityMetadata)
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
		{
			TablePartViewModelGenerator tablePartViewModelGenerator = new TablePartViewModelGenerator(tablePart);
			((ICodeGenerator)tablePartViewModelGenerator).Metadata = rootMetadata;
			list.Add(tablePartViewModelGenerator.Generate());
			list.AddRange(ProcessTableParts(rootMetadata, tablePart));
		}
		return list;
	}

	private EntityMetadata GetFakeEntityMetadata(EntityMetadata entityMetadata)
	{
		EntityMetadata obj = new EntityMetadata
		{
			Uid = (qFe0VuhOZiFtdBbSKUwH(entityMetadata) ? KyCePwhOI3EhEHfuOYhS(entityMetadata) : kC0iXMhOuss9RMd9TZ2c(entityMetadata))
		};
		cxGZLdhOV9HtWLIFKHBL(obj, entityMetadata.Name);
		obj.Namespace = (string)fVn4i9hOS4Vq1EGFg6iG(entityMetadata);
		Qm1uT9hOiffWmYQxFuxb(obj, entityMetadata.NamespaceForDisplay);
		u0s8OUhOREQicsaIExpE(obj, entityMetadata.DisplayName);
		obj.Type = EntityMetadataType.Interface;
		aZwImGhOKYW5cE6ZCkNP(obj, HW9Un9hOqZKlnrTeeewE(entityMetadata));
		if (kLmvEohOXruKmwwKlMuN(entityMetadata.Uid, metadata.Uid))
		{
			((ClassMetadata)HW9Un9hOqZKlnrTeeewE(entityMetadata)).Properties.RemoveAll((PropertyMetadata property) => _003C_003Ec.RexZYEvvL926F9mQQT1K(_003C_003Ec.HUkeP0vvj2dR3XRLNJkE(property), _003C_003Ec.jWEfm8vvYjsCcUTrkW4K(-675505729 ^ -675526669)));
		}
		obj.Properties.AddRange(((ClassMetadata)HW9Un9hOqZKlnrTeeewE(entityMetadata)).Properties);
		return obj;
	}

	internal static bool BlfQUhhOQSllrSVpShS0()
	{
		return V3AdV2hOfuxi2N2qAsON == null;
	}

	internal static EntityScriptGenerator nJZGyZhOCbwY9enMGuXd()
	{
		return V3AdV2hOfuxi2N2qAsON;
	}

	internal static object ftA5P7hOvJyWuQowVAtS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OLBLkfhO8pqCVPI0df4n(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool qFe0VuhOZiFtdBbSKUwH(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static Guid kC0iXMhOuss9RMd9TZ2c(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static Guid KyCePwhOI3EhEHfuOYhS(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void cxGZLdhOV9HtWLIFKHBL(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object fVn4i9hOS4Vq1EGFg6iG(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void Qm1uT9hOiffWmYQxFuxb(object P_0, object P_1)
	{
		((ClassMetadata)P_0).NamespaceForDisplay = (string)P_1;
	}

	internal static void u0s8OUhOREQicsaIExpE(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object HW9Un9hOqZKlnrTeeewE(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static void aZwImGhOKYW5cE6ZCkNP(object P_0, object P_1)
	{
		((EntityMetadata)P_0).ViewModelMetadata = (DataClassMetadata)P_1;
	}

	internal static bool kLmvEohOXruKmwwKlMuN(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object aIyvblhOTq70emQ7yBqD(object P_0)
	{
		return ((ClassMetadata)P_0).ScriptModuleTypeName;
	}

	internal static object hHTF2PhOkw97Pf0EclEm(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object tI2w7HhOnBPFuq6acWtK(object P_0)
	{
		return ((string)P_0).Trim();
	}
}
