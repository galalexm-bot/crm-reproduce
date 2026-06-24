using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.CodeGeneration;

public class ProcessContextDebugGenerator : EntityGenerator
{
	internal static ProcessContextDebugGenerator vGrwWnOYChwWkaSofg3O;

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				dqg4VfOYUOMHu7GRsvZW(this, type);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			jGJjHKOYAoltHemEIP9r(type, new ISyntaxNode[1] { WULgUTOYVY3iRIgqAxBe(typeof(DefaultManagerAttribute).TypeHandle).CreateAttribute(typeof(MemoryEntityManagerMaker)) });
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
			{
				num2 = 0;
			}
		}
	}

	protected override EntityGenerator CreateTablePartGenerator()
	{
		return new ProcessContextDebugGenerator();
	}

	public ProcessContextDebugGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		C2uql2OYGbGULwKiPZj4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void dqg4VfOYUOMHu7GRsvZW(object P_0, object P_1)
	{
		((EntityGenerator)P_0).WriteTypeAttributes((ISyntaxNode)P_1);
	}

	internal static Type WULgUTOYVY3iRIgqAxBe(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object jGJjHKOYAoltHemEIP9r(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).AddAttributes((ISyntaxNode[])P_1);
	}

	internal static bool xu1vDUOYMo7d8na8FHB7()
	{
		return vGrwWnOYChwWkaSofg3O == null;
	}

	internal static ProcessContextDebugGenerator TQQRVbOYkVKilrOJlKU5()
	{
		return vGrwWnOYChwWkaSofg3O;
	}

	internal static void C2uql2OYGbGULwKiPZj4()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
