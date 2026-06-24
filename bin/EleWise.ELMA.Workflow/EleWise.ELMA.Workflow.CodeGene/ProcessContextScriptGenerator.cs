using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.CodeGeneration;

internal sealed class ProcessContextScriptGenerator : EntityScriptGenerator
{
	private static ProcessContextScriptGenerator yBCXwtOYBLS6WmTY6wqL;

	private string ClassName => (string)AtkHuVOYp2uUEOysW0xZ(fwW72fOYQHChp2qE8dQs(metadata), qxIn1VOYdKg7EwXhJ4BB(0x2F44D93A ^ 0x2F454CBA));

	private string InterfaceName
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = metadata.FullTypeName;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = "";
					break;
				}
				break;
			}
			return (string)obj;
		}
	}

	public ProcessContextScriptGenerator(IMetadataService metadataService)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		MMf1bYOYXu6gNDxPNnFt();
		base._002Ector(metadataService);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void InitIgnoreNamespaces(IMetadata metadata)
	{
		int num = 2;
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
				ignoreNamespaces.Add((string)qxIn1VOYdKg7EwXhJ4BB(-1638225214 ^ -1638187014));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ignoreNamespaces.Clear();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		return new ISyntaxNode[1] { ClassName.ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Partial, GetBaseClass(), null, GetMembers()) };
	}

	protected override string GetNamespace()
	{
		return (string)qxIn1VOYdKg7EwXhJ4BB(-63028171 ^ -62926467);
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return (ISyntaxNode)diaLr5OYDWnqm5jvdRXJ(tnfAZ1OYu7rSZAgSs8Ho(typeof(ProcessScriptBase<Context>).TypeHandle), new ISyntaxNode[1] { InterfaceName.CreateTypeSyntax() });
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		ProcessContextViewModelGenerator processContextViewModelGenerator = new ProcessContextViewModelGenerator();
		((ICodeGenerator)processContextViewModelGenerator).Metadata = metadata;
		list.Add(processContextViewModelGenerator.Generate());
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

	private EntityMetadata GetFakeEntityMetadata(EntityMetadata entityMetadata)
	{
		EntityMetadata obj = new EntityMetadata
		{
			Uid = (entityMetadata.IsInterfaceType ? TMdy9MOYHc37pmiVeAUb(entityMetadata) : ObxN6NOYnByt7Ogq4Ibi(entityMetadata))
		};
		ze8j6oOYLIdla0C4GlBl(obj, entityMetadata.Name);
		RHJ2oLOYfiDeviebkQol(obj, entityMetadata.Namespace);
		VDKh0sOYW6SIYsdlOIbR(obj, AGiwa2OY9oVmjy3Vv0r2(entityMetadata));
		bLAvmxOYRkBakkLX0wsW(obj, qcov9DOYjmN6XWDw2q5w(entityMetadata));
		mmad73OY6j7cpG1BmbO1(obj, EntityMetadataType.Entity);
		obj.ViewModelMetadata = (DataClassMetadata)AiBG5XOYq18lQ0FhsDWT(entityMetadata);
		if (McQZOjOY3YXuym1YDKmJ(entityMetadata.Uid, metadata.Uid))
		{
			((ClassMetadata)AiBG5XOYq18lQ0FhsDWT(entityMetadata)).Properties.RemoveAll((PropertyMetadata property) => _003C_003Ec.NItNC5Zwr09c52PBKcgU(_003C_003Ec.l7EVauZwaJgBhnrR9De8(property), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125930772)));
		}
		if (F8jJqKOYTvFRqOa6Poro(generationParams) == GenerationMode.CodeEditor)
		{
			((ClassMetadata)AiBG5XOYq18lQ0FhsDWT(entityMetadata)).Properties.RemoveAll((PropertyMetadata property) => property.Name == (string)_003C_003Ec.rAsID5ZwepPZFme0vKoU(-768800937 ^ -768802925));
		}
		obj.Properties.AddRange(entityMetadata.ViewModelMetadata.Properties);
		return obj;
	}

	internal static void MMf1bYOYXu6gNDxPNnFt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool v5kmV2OYc3sYk2p8yDKN()
	{
		return yBCXwtOYBLS6WmTY6wqL == null;
	}

	internal static ProcessContextScriptGenerator s0DDtxOYPQk2JjO3E2iX()
	{
		return yBCXwtOYBLS6WmTY6wqL;
	}

	internal static object qxIn1VOYdKg7EwXhJ4BB(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type tnfAZ1OYu7rSZAgSs8Ho(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object diaLr5OYDWnqm5jvdRXJ(Type P_0, object P_1)
	{
		return P_0.CreateTypeSyntax((ISyntaxNode[])P_1);
	}

	internal static Guid ObxN6NOYnByt7Ogq4Ibi(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid TMdy9MOYHc37pmiVeAUb(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static void ze8j6oOYLIdla0C4GlBl(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void RHJ2oLOYfiDeviebkQol(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static object AGiwa2OY9oVmjy3Vv0r2(object P_0)
	{
		return ((ClassMetadata)P_0).NamespaceForDisplay;
	}

	internal static void VDKh0sOYW6SIYsdlOIbR(object P_0, object P_1)
	{
		((ClassMetadata)P_0).NamespaceForDisplay = (string)P_1;
	}

	internal static object qcov9DOYjmN6XWDw2q5w(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void bLAvmxOYRkBakkLX0wsW(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void mmad73OY6j7cpG1BmbO1(object P_0, EntityMetadataType P_1)
	{
		((EntityMetadata)P_0).Type = P_1;
	}

	internal static object AiBG5XOYq18lQ0FhsDWT(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static bool McQZOjOY3YXuym1YDKmJ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static GenerationMode F8jJqKOYTvFRqOa6Poro(object P_0)
	{
		return ((GenerationParams)P_0).Mode;
	}

	internal static object fwW72fOYQHChp2qE8dQs(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object AtkHuVOYp2uUEOysW0xZ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
