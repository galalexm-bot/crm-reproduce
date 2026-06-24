using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiMembersNode : IPublicApiNode
{
	private readonly IEnumerable<ISyntaxNode> syntaxNodes;

	internal static PublicApiMembersNode zd1lTRhH9Ft40UZH2ZpV;

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
				case 0:
					return;
				case 1:
					_003CParentPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	public PublicApiMembersNode(string parentPath, params ISyntaxNode[] syntaxNodes)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		Q6vWcshHrTybiGs0cf81();
		this._002Ector(parentPath, syntaxNodes.AsEnumerable());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicApiMembersNode(string parentPath, IEnumerable<ISyntaxNode> syntaxNodes)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		ParentPath = parentPath;
		this.syntaxNodes = syntaxNodes;
	}

	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		return syntaxNodes;
	}

	internal static void Q6vWcshHrTybiGs0cf81()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QSvnePhHdRPwWIQ5uqle()
	{
		return zd1lTRhH9Ft40UZH2ZpV == null;
	}

	internal static PublicApiMembersNode J4cZYuhHlAEhYblBMsRr()
	{
		return zd1lTRhH9Ft40UZH2ZpV;
	}
}
