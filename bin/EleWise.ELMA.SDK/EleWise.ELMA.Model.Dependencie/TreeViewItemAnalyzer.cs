using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal sealed class TreeViewItemAnalyzer : DynamicViewItemsAnalyzer
{
	internal static TreeViewItemAnalyzer xOe5n9hqvKdv4Aimnp8r;

	protected override bool CheckViewItem(ViewItem viewItem)
	{
		return viewItem is ITreeViewItem;
	}

	protected override void AdditionalProcess(IDynamicViewItem dynamicViewItem, Guid currentModuleUid, ClassMetadata metadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		ITreeViewItem treeViewItem = (ITreeViewItem)dynamicViewItem;
		CS_0024_003C_003E8__locals0.keyUid = treeViewItem.KeyUid;
		if (CS_0024_003C_003E8__locals0.keyUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == CS_0024_003C_003E8__locals0.keyUid);
			if (propertyMetadata != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata);
			}
		}
		CS_0024_003C_003E8__locals0.parentUid = treeViewItem.ParentKeyUid;
		if (CS_0024_003C_003E8__locals0.parentUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass1_0.tjP8aMvbiehWCvBVhoqF(a.Uid, CS_0024_003C_003E8__locals0.parentUid));
			if (propertyMetadata2 != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata2);
			}
		}
	}

	public TreeViewItemAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PSUbj7hquIx8blIr8ctA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool H2DZ0ehq88WhJV891Vk7()
	{
		return xOe5n9hqvKdv4Aimnp8r == null;
	}

	internal static TreeViewItemAnalyzer D2xMaihqZXiT9cdqxkGw()
	{
		return xOe5n9hqvKdv4Aimnp8r;
	}

	internal static void PSUbj7hquIx8blIr8ctA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
