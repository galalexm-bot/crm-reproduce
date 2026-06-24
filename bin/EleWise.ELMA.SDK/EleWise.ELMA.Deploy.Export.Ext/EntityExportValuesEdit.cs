using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[Component]
public abstract class EntityExportValuesEdit : IEntityExportValuesEdit
{
	private static EntityExportValuesEdit AsKmJJEU4dA3751wtWhW;

	public abstract Guid TypeUid { get; }

	public abstract void EditValues(Dictionary<string, object> values);

	protected EntityExportValuesEdit()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YpLKAYEU6HeVFPk0h3GD()
	{
		return AsKmJJEU4dA3751wtWhW == null;
	}

	internal static EntityExportValuesEdit CFLi2UEUHZcQw3RQHybW()
	{
		return AsKmJJEU4dA3751wtWhW;
	}
}
