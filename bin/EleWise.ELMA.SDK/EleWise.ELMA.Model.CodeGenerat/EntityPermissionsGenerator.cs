using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration;

internal sealed class EntityPermissionsGenerator : EntityGenerator
{
	private readonly EntityMetadata entityMetadata;

	private static IEnumerable<IEntityPermissionsTypeExtensionPoint> entityPermissionsTypeExtensionPoints;

	private static EntityPermissionsGenerator qpqjoIh10oO84806LTEP;

	protected override bool HasCustomCode => true;

	private static IEnumerable<IEntityPermissionsTypeExtensionPoint> EntityPermissionsTypeExtensionPoints => entityPermissionsTypeExtensionPoints ?? (entityPermissionsTypeExtensionPoints = ComponentManager.Current.GetExtensionPoints<IEntityPermissionsTypeExtensionPoint>());

	public EntityPermissionsGenerator(EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DXcw4Sh1MKvqO4BtrT5A();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.entityMetadata = entityMetadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		return GenerateMainFile(metadata, base.GenerateMainFile);
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources()
	{
		return GenerateCustomCodeResources(entityMetadata, metadata);
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return GenerateCustomCodeResources();
	}

	internal static IEnumerable<ISyntaxNode> GenerateMainFile(EntityMetadata metadata, Func<IEnumerable<ISyntaxNode>> action)
	{
		List<string> implementedInterfaces = metadata.ImplementedInterfaces;
		try
		{
			if (!metadata.IsInterfaceType)
			{
				if (metadata.ImplementedInterfaces == null)
				{
					metadata.ImplementedInterfaces = new List<string>();
				}
				metadata.ImplementedInterfaces.AddRange(GetPermissionInterfaces(metadata));
			}
			return action();
		}
		finally
		{
			metadata.ImplementedInterfaces = implementedInterfaces;
		}
	}

	[IteratorStateMachine(typeof(_003CGenerateCustomCodeResources_003Ed__8))]
	internal static IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources(EntityMetadata entityMetadata, EntityMetadata metadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateCustomCodeResources_003Ed__8(-2)
		{
			_003C_003E3__entityMetadata = entityMetadata,
			_003C_003E3__metadata = metadata
		};
	}

	private static List<string> GetPermissionInterfaces(object metadata)
	{
		List<string> list = new List<string>();
		foreach (IEntityPermissionsTypeExtensionPoint entityPermissionsTypeExtensionPoint in EntityPermissionsTypeExtensionPoints)
		{
			foreach (string implementedInterface in entityPermissionsTypeExtensionPoint.GetImplementedInterfaces((EntityMetadata)metadata))
			{
				if (!list.Contains(implementedInterface))
				{
					list.Add(implementedInterface);
				}
			}
		}
		return list;
	}

	internal static void DXcw4Sh1MKvqO4BtrT5A()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bk34Swh1mwBH76HFwXaS()
	{
		return qpqjoIh10oO84806LTEP == null;
	}

	internal static EntityPermissionsGenerator h6oceih1ylrxWick1Qg9()
	{
		return qpqjoIh10oO84806LTEP;
	}
}
