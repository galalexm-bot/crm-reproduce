using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiCustomBuilderNode : IPublicApiNode
{
	internal static PublicApiCustomBuilderNode R07IaPh6cFTpiX7Vemu1;

	public string ParentPath
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPath_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CParentPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
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

	internal Type BuilderType
	{
		[CompilerGenerated]
		get
		{
			return _003CBuilderType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CBuilderType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	string IPublicApiNode.Path
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public PublicApiCustomBuilderNode(string parentPath, Type builderType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ThvQFphHBiO0utf3vmO9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				BuilderType = builderType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 1;
				}
				break;
			default:
				ParentPath = parentPath;
				num = 2;
				break;
			}
		}
	}

	internal ISyntaxNode CreateBuilderExpression(IEnumerable<(string Name, Type Type)> parameters, IEnumerable<Type> availableBuilders, Func<Type, ISyntaxNode> builderIdentifier)
	{
		return BuilderType.CreateTypeSyntax().ObjectCreationExpression(parameters.Select(((string Name, Type Type) p) => p.Name.IdentifierName()));
	}

	IEnumerable<ISyntaxNode> IPublicApiNode.Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		throw new NotImplementedException();
	}

	internal static void ThvQFphHBiO0utf3vmO9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GKkCuAh6zrCeE5tPSprq()
	{
		return R07IaPh6cFTpiX7Vemu1 == null;
	}

	internal static PublicApiCustomBuilderNode BAYwqbhHFSbtNCxEToQH()
	{
		return R07IaPh6cFTpiX7Vemu1;
	}
}
