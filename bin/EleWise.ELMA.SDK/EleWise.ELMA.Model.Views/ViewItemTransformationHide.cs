using System;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ViewItemTransformationHide : ViewItemTransformation
{
	internal static ViewItemTransformationHide Kt7sJ2oPJJEZsfZPqStN;

	public override void Apply(ViewItem formViewItem)
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
				TransformationHide<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApply(formViewItem, base.Uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ViewItemTransformationHide()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GCn7xcoPlYJHpHH9U8Rh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool x5mFEyoP9fau17xWcuLA()
	{
		return Kt7sJ2oPJJEZsfZPqStN == null;
	}

	internal static ViewItemTransformationHide uM0XfQoPd3AIjS2nxQpa()
	{
		return Kt7sJ2oPJJEZsfZPqStN;
	}

	internal static void GCn7xcoPlYJHpHH9U8Rh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
