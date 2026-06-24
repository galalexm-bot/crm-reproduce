using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

[Component(Order = int.MaxValue)]
internal sealed class EntityObjectFormProvider : AbstractObjectFormProvider<IEntity>
{
	internal static EntityObjectFormProvider efBBubGpKgyYtiXpgxXt;

	public EntityObjectFormProvider(IMetadataRuntimeService metadataRuntimeService, ViewModelDescriptor viewModelDescriptor)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		soJq97GpkoQsZr0JjPCm();
		base._002Ector(metadataRuntimeService, viewModelDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override FormViewItem Transform(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			FormViewItem formViewItem2;
			switch (num2)
			{
			case 2:
				return base.Transform(metadata, formViewItem, viewType, itemType);
			case 1:
				formViewItem2 = formViewItem;
				if (formViewItem2 != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				formViewItem2 = new FormViewItemBuilder(timG60GpnKgThb1i7x9k(metadata), viewType).DefaultContainer().FormView;
				break;
			}
			formViewItem = formViewItem2;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void soJq97GpkoQsZr0JjPCm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool gPWLhoGpXmvmtP0mJ1T1()
	{
		return efBBubGpKgyYtiXpgxXt == null;
	}

	internal static EntityObjectFormProvider MQqNsgGpTiii3vcBqWYn()
	{
		return efBBubGpKgyYtiXpgxXt;
	}

	internal static Guid timG60GpnKgThb1i7x9k(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}
}
