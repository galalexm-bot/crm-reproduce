using System.Runtime.CompilerServices;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration;

internal class SyntaxNodeContainer : ISyntaxNode
{
	private static SyntaxNodeContainer hOQSXLhegx8dg672xnNq;

	public SyntaxNode SyntaxNode
	{
		[CompilerGenerated]
		get
		{
			return _003CSyntaxNode_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CSyntaxNode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public SyntaxNodeContainer(SyntaxNode syntaxNode)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			SyntaxNode = syntaxNode;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
			{
				num = 0;
			}
		}
	}

	public override string ToString()
	{
		return SyntaxNode.ToString();
	}

	internal static bool K8WC6Whe54Y4U2Gj48xS()
	{
		return hOQSXLhegx8dg672xnNq == null;
	}

	internal static SyntaxNodeContainer HKfJqRhejVk71vLaPbqh()
	{
		return hOQSXLhegx8dg672xnNq;
	}
}
