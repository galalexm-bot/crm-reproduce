using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Serializable]
public class VariableCodeItemToolBoxItem : NewCodeItemToolBoxItem<VariableCodeItem>
{
	private Guid? propertyMetadataUid;

	private static VariableCodeItemToolBoxItem mD37bKV4xrZRxGkT06b;

	public Guid? PropertyMetadataUid
	{
		get
		{
			return propertyMetadataUid;
		}
		set
		{
			if (value.HasValue && value != Guid.Empty)
			{
				base.PropertyMetadata = MetadataServiceContext.Service.GetMetadata(value.Value);
			}
			propertyMetadataUid = value;
		}
	}

	public override Guid GroupUid => VariablesCodeItemToolBoxGroup.UID;

	public VariableCodeItemToolBoxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ca3eNsVA3eMM4hp3bQ9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.DisplayNames = new List<string>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num = 2;
				}
				break;
			default:
				base.PropertyNames = new List<string>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void Ca3eNsVA3eMM4hp3bQ9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool v6CA4MV6mOfAIlEYCLR()
	{
		return mD37bKV4xrZRxGkT06b == null;
	}

	internal static VariableCodeItemToolBoxItem UH85gNVH9vjepqsHeAU()
	{
		return mD37bKV4xrZRxGkT06b;
	}
}
