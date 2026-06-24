using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class FingerprintingExpressionVisitor : ExpressionVisitor
{
	private readonly List<object> _seenConstants;

	private readonly List<ParameterExpression> _seenParameters;

	private readonly ExpressionFingerprintChain _currentChain;

	private bool _gaveUp;

	private static FingerprintingExpressionVisitor RKUkmdW0w1gG1DlHjuI;

	private FingerprintingExpressionVisitor()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		ypRuPSWMeSSQStrT5qf();
		_seenConstants = new List<object>();
		_seenParameters = new List<ParameterExpression>();
		_currentChain = new ExpressionFingerprintChain();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private T GiveUp<T>(T node)
	{
		_gaveUp = true;
		return node;
	}

	public static ExpressionFingerprintChain GetFingerprintChain(Expression expr, out List<object> capturedConstants)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 1;
		int num2 = num;
		FingerprintingExpressionVisitor fingerprintingExpressionVisitor = default(FingerprintingExpressionVisitor);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!fingerprintingExpressionVisitor._gaveUp)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 3:
				capturedConstants = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				fingerprintingExpressionVisitor = new FingerprintingExpressionVisitor();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return null;
			case 6:
				capturedConstants = fingerprintingExpressionVisitor._seenConstants;
				num2 = 4;
				break;
			default:
				leirAXWJTTA1ieBXadV(fingerprintingExpressionVisitor, expr);
				num2 = 5;
				break;
			case 4:
				return fingerprintingExpressionVisitor._currentChain;
			}
		}
	}

	public override Expression Visit(Expression node)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (node == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			default:
				return null;
			case 1:
				return (Expression)EKJOgHW9wfrbrqpstPg(this, node);
			case 2:
				_currentChain.Elements.Add(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override Expression VisitBinary(BinaryExpression node)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (Expression)GQymxCWrCCXHYWLOYAY(this, node);
			default:
				return node;
			case 1:
				if (!_gaveUp)
				{
					_currentChain.Elements.Add(new BinaryExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node), node.Method));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	protected override Expression VisitBlock(BlockExpression node)
	{
		return GiveUp(node);
	}

	protected override CatchBlock VisitCatchBlock(CatchBlock node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitConditional(ConditionalExpression node)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return node;
			case 1:
				_currentChain.Elements.Add(new ConditionalExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node)));
				num2 = 3;
				break;
			case 2:
				if (!_gaveUp)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return (Expression)KM2VBeWgAmIGYm3kiXQ(this, node);
			}
		}
	}

	protected override Expression VisitConstant(ConstantExpression node)
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return node;
			case 3:
				_seenConstants.Add(FlfPGpW5ZoeWSCVThUT(node));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (!_gaveUp)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				return (Expression)cxsK23WjlxcUZQWvL2G(this, node);
			case 1:
				_currentChain.Elements.Add(new ConstantExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), node.Type));
				num2 = 2;
				break;
			}
		}
	}

	protected override Expression VisitDebugInfo(DebugInfoExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitDefault(DefaultExpression node)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return node;
			default:
				return (Expression)CW8klCWYg0w8p6iQv75(this, node);
			case 2:
				if (!_gaveUp)
				{
					_currentChain.Elements.Add(new DefaultExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), node.Type));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	protected override Expression VisitDynamic(DynamicExpression node)
	{
		return GiveUp(node);
	}

	protected override ElementInit VisitElementInit(ElementInit node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitExtension(Expression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitGoto(GotoExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitIndex(IndexExpression node)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!_gaveUp)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 1:
					return node;
				case 2:
					_currentChain.Elements.Add(new IndexExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node), (PropertyInfo)e5P38XWLbOpQONhUygL(node)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return base.VisitIndex(node);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	protected override Expression VisitInvocation(InvocationExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitLabel(LabelExpression node)
	{
		return GiveUp(node);
	}

	protected override LabelTarget VisitLabelTarget(LabelTarget node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitLambda<T>(Expression<T> node)
	{
		if (_gaveUp)
		{
			return node;
		}
		_currentChain.Elements.Add(new LambdaExpressionFingerprint(node.NodeType, node.Type));
		return base.VisitLambda(node);
	}

	protected override Expression VisitListInit(ListInitExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitLoop(LoopExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitMember(MemberExpression node)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.VisitMember(node);
			case 1:
				return node;
			case 2:
				if (!_gaveUp)
				{
					_currentChain.Elements.Add(new MemberExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node), (MemberInfo)GPdfHwWUhNklT83Ijow(node)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
	{
		return GiveUp(node);
	}

	protected override MemberBinding VisitMemberBinding(MemberBinding node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitMemberInit(MemberInitExpression node)
	{
		return GiveUp(node);
	}

	protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
	{
		return GiveUp(node);
	}

	protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitMethodCall(MethodCallExpression node)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return node;
			case 1:
				if (!_gaveUp)
				{
					_currentChain.Elements.Add(new MethodCallExpressionFingerprint(node.NodeType, j4OSoeWl5HvuVTx427F(node), (MethodInfo)ipVYi8WsS7aovlxSv54(node)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return base.VisitMethodCall(node);
			}
		}
	}

	protected override Expression VisitNew(NewExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitNewArray(NewArrayExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitParameter(ParameterExpression node)
	{
		//Discarded unreachable code: IL_0076, IL_0085, IL_011b
		int num = 1;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 5:
					break;
				case 6:
					num3 = TWRYYmWcKZVoLfwiwxq(_seenParameters);
					num2 = 3;
					continue;
				case 7:
					if (num3 >= 0)
					{
						num2 = 4;
						continue;
					}
					goto case 6;
				case 8:
					return (Expression)OvyVG1Wz4AjOaTKt3Nt(this, node);
				case 2:
					return node;
				default:
					num3 = _seenParameters.IndexOf(node);
					num2 = 7;
					continue;
				case 3:
					_seenParameters.Add(node);
					num2 = 5;
					continue;
				case 1:
					if (!_gaveUp)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			_currentChain.Elements.Add(new ParameterExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node), num3));
			num = 8;
		}
	}

	protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitSwitch(SwitchExpression node)
	{
		return GiveUp(node);
	}

	protected override SwitchCase VisitSwitchCase(SwitchCase node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitTry(TryExpression node)
	{
		return GiveUp(node);
	}

	protected override Expression VisitTypeBinary(TypeBinaryExpression node)
	{
		//Discarded unreachable code: IL_005e
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (Expression)xqe1dqoBHumpa1FVQOp(this, node);
			case 1:
				if (!_gaveUp)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return node;
			default:
				_currentChain.Elements.Add(new TypeBinaryExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node), XbWoBUoF4rQjHsq4weQ(node)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override Expression VisitUnary(UnaryExpression node)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return node;
			case 2:
				_currentChain.Elements.Add(new UnaryExpressionFingerprint(YujUmnWdY9qrm03lH7U(node), j4OSoeWl5HvuVTx427F(node), node.Method));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!_gaveUp)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			default:
				return (Expression)noXlRpoWN1GwYINEdY5(this, node);
			}
		}
	}

	internal static void ypRuPSWMeSSQStrT5qf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fbAHfFWmddXWYBYNKoY()
	{
		return RKUkmdW0w1gG1DlHjuI == null;
	}

	internal static FingerprintingExpressionVisitor or8sHRWyi6xKnIq0ivA()
	{
		return RKUkmdW0w1gG1DlHjuI;
	}

	internal static object leirAXWJTTA1ieBXadV(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).Visit((Expression)P_1);
	}

	internal static object EKJOgHW9wfrbrqpstPg(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).Visit((Expression)P_1);
	}

	internal static ExpressionType YujUmnWdY9qrm03lH7U(object P_0)
	{
		return ((Expression)P_0).NodeType;
	}

	internal static Type j4OSoeWl5HvuVTx427F(object P_0)
	{
		return ((Expression)P_0).Type;
	}

	internal static object GQymxCWrCCXHYWLOYAY(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitBinary((BinaryExpression)P_1);
	}

	internal static object KM2VBeWgAmIGYm3kiXQ(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitConditional((ConditionalExpression)P_1);
	}

	internal static object FlfPGpW5ZoeWSCVThUT(object P_0)
	{
		return ((ConstantExpression)P_0).Value;
	}

	internal static object cxsK23WjlxcUZQWvL2G(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitConstant((ConstantExpression)P_1);
	}

	internal static object CW8klCWYg0w8p6iQv75(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitDefault((DefaultExpression)P_1);
	}

	internal static object e5P38XWLbOpQONhUygL(object P_0)
	{
		return ((IndexExpression)P_0).Indexer;
	}

	internal static object GPdfHwWUhNklT83Ijow(object P_0)
	{
		return ((MemberExpression)P_0).Member;
	}

	internal static object ipVYi8WsS7aovlxSv54(object P_0)
	{
		return ((MethodCallExpression)P_0).Method;
	}

	internal static int TWRYYmWcKZVoLfwiwxq(object P_0)
	{
		return ((List<ParameterExpression>)P_0).Count;
	}

	internal static object OvyVG1Wz4AjOaTKt3Nt(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitParameter((ParameterExpression)P_1);
	}

	internal static Type XbWoBUoF4rQjHsq4weQ(object P_0)
	{
		return ((TypeBinaryExpression)P_0).TypeOperand;
	}

	internal static object xqe1dqoBHumpa1FVQOp(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitTypeBinary((TypeBinaryExpression)P_1);
	}

	internal static object noXlRpoWN1GwYINEdY5(object P_0, object P_1)
	{
		return ((ExpressionVisitor)P_0).VisitUnary((UnaryExpression)P_1);
	}
}
