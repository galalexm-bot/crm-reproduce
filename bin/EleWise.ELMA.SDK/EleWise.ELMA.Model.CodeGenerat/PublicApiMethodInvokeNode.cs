using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiMethodInvokeNode : IPublicApiNode
{
	private readonly ISyntaxNode targetObjectExpression;

	private readonly TypeArgument[] typeArguments;

	internal static PublicApiMethodInvokeNode uEqoDQhHgL4GySZtVhbg;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

	string IPublicApiNode.Path
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public MethodInfo MethodInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CMethodInfo_003Ek__BackingField;
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
					_003CMethodInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PublicApiMethodInvokeNode(string parentPath, MethodInfo methodInfo, ISyntaxNode targetObjectExpression, params TypeArgument[] typeArguments)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ApBLNthHYyVDZhdxPwOt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.typeArguments = typeArguments;
				num = 4;
				break;
			case 3:
				MethodInfo = methodInfo;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.targetObjectExpression = targetObjectExpression;
				num = 2;
				break;
			default:
				ParentPath = parentPath;
				num = 3;
				break;
			case 4:
				return;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerate_003Ed__13))]
	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerate_003Ed__13(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal static void ApBLNthHYyVDZhdxPwOt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EB11vuhH5cSYesg1CJsY()
	{
		return uEqoDQhHgL4GySZtVhbg == null;
	}

	internal static PublicApiMethodInvokeNode SL0qUEhHj1yIR5rovuml()
	{
		return uEqoDQhHgL4GySZtVhbg;
	}
}
