// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.FingerprintingExpressionVisitor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class FingerprintingExpressionVisitor : ExpressionVisitor
  {
    private readonly List<object> _seenConstants;
    private readonly List<ParameterExpression> _seenParameters;
    private readonly ExpressionFingerprintChain _currentChain;
    private bool _gaveUp;
    private static FingerprintingExpressionVisitor RKUkmdW0w1gG1DlHjuI;

    private FingerprintingExpressionVisitor()
    {
      FingerprintingExpressionVisitor.ypRuPSWMeSSQStrT5qf();
      this._seenConstants = new List<object>();
      this._seenParameters = new List<ParameterExpression>();
      this._currentChain = new ExpressionFingerprintChain();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    private T GiveUp<T>(T node)
    {
      this._gaveUp = true;
      return node;
    }

    public static ExpressionFingerprintChain GetFingerprintChain(
      Expression expr,
      out List<object> capturedConstants)
    {
      int num = 1;
      FingerprintingExpressionVisitor expressionVisitor;
      while (true)
      {
        switch (num)
        {
          case 1:
            expressionVisitor = new FingerprintingExpressionVisitor();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            capturedConstants = (List<object>) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 1;
            continue;
          case 4:
            goto label_9;
          case 5:
            if (!expressionVisitor._gaveUp)
            {
              num = 6;
              continue;
            }
            goto case 3;
          case 6:
            capturedConstants = expressionVisitor._seenConstants;
            num = 4;
            continue;
          default:
            FingerprintingExpressionVisitor.leirAXWJTTA1ieBXadV((object) expressionVisitor, (object) expr);
            num = 5;
            continue;
        }
      }
label_6:
      return (ExpressionFingerprintChain) null;
label_9:
      return expressionVisitor._currentChain;
    }

    public override Expression Visit(Expression node)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            this._currentChain.Elements.Add((ExpressionFingerprint) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 3:
            if (node == null)
            {
              num = 2;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (Expression) null;
label_5:
      return (Expression) FingerprintingExpressionVisitor.EKJOgHW9wfrbrqpstPg((object) this, (object) node);
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._gaveUp)
            {
              this._currentChain.Elements.Add((ExpressionFingerprint) new BinaryExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), node.Method));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (Expression) FingerprintingExpressionVisitor.GQymxCWrCCXHYWLOYAY((object) this, (object) node);
label_3:
      return (Expression) node;
    }

    protected override Expression VisitBlock(BlockExpression node) => (Expression) this.GiveUp<BlockExpression>(node);

    protected override CatchBlock VisitCatchBlock(CatchBlock node) => this.GiveUp<CatchBlock>(node);

    protected override Expression VisitConditional(ConditionalExpression node)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._currentChain.Elements.Add((ExpressionFingerprint) new ConditionalExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node)));
            num = 3;
            continue;
          case 2:
            if (!this._gaveUp)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_2:
      return (Expression) node;
label_6:
      return (Expression) FingerprintingExpressionVisitor.KM2VBeWgAmIGYm3kiXQ((object) this, (object) node);
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._currentChain.Elements.Add((ExpressionFingerprint) new ConstantExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), node.Type));
            num = 2;
            continue;
          case 2:
            goto label_6;
          case 3:
            this._seenConstants.Add(FingerprintingExpressionVisitor.FlfPGpW5ZoeWSCVThUT((object) node));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
            continue;
          case 4:
            if (!this._gaveUp)
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (Expression) node;
label_6:
      return (Expression) FingerprintingExpressionVisitor.cxsK23WjlxcUZQWvL2G((object) this, (object) node);
    }

    protected override Expression VisitDebugInfo(DebugInfoExpression node) => (Expression) this.GiveUp<DebugInfoExpression>(node);

    protected override Expression VisitDefault(DefaultExpression node)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!this._gaveUp)
            {
              this._currentChain.Elements.Add((ExpressionFingerprint) new DefaultExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), node.Type));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return (Expression) node;
label_4:
      return (Expression) FingerprintingExpressionVisitor.CW8klCWYg0w8p6iQv75((object) this, (object) node);
    }

    protected override Expression VisitDynamic(DynamicExpression node) => (Expression) this.GiveUp<DynamicExpression>(node);

    protected override ElementInit VisitElementInit(ElementInit node) => this.GiveUp<ElementInit>(node);

    protected override Expression VisitExtension(Expression node) => this.GiveUp<Expression>(node);

    protected override Expression VisitGoto(GotoExpression node) => (Expression) this.GiveUp<GotoExpression>(node);

    protected override Expression VisitIndex(IndexExpression node)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              this._currentChain.Elements.Add((ExpressionFingerprint) new IndexExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), (PropertyInfo) FingerprintingExpressionVisitor.e5P38XWLbOpQONhUygL((object) node)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_3:
        if (!this._gaveUp)
          num1 = 2;
        else
          break;
      }
label_5:
      return (Expression) node;
label_7:
      return base.VisitIndex(node);
    }

    protected override Expression VisitInvocation(InvocationExpression node) => (Expression) this.GiveUp<InvocationExpression>(node);

    protected override Expression VisitLabel(LabelExpression node) => (Expression) this.GiveUp<LabelExpression>(node);

    protected override LabelTarget VisitLabelTarget(LabelTarget node) => this.GiveUp<LabelTarget>(node);

    protected override Expression VisitLambda<T>(Expression<T> node)
    {
      if (this._gaveUp)
        return (Expression) node;
      this._currentChain.Elements.Add((ExpressionFingerprint) new LambdaExpressionFingerprint(node.NodeType, node.Type));
      return base.VisitLambda<T>(node);
    }

    protected override Expression VisitListInit(ListInitExpression node) => (Expression) this.GiveUp<ListInitExpression>(node);

    protected override Expression VisitLoop(LoopExpression node) => (Expression) this.GiveUp<LoopExpression>(node);

    protected override Expression VisitMember(MemberExpression node)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!this._gaveUp)
            {
              this._currentChain.Elements.Add((ExpressionFingerprint) new MemberExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), (MemberInfo) FingerprintingExpressionVisitor.GPdfHwWUhNklT83Ijow((object) node)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.VisitMember(node);
label_3:
      return (Expression) node;
    }

    protected override MemberAssignment VisitMemberAssignment(MemberAssignment node) => this.GiveUp<MemberAssignment>(node);

    protected override MemberBinding VisitMemberBinding(MemberBinding node) => this.GiveUp<MemberBinding>(node);

    protected override Expression VisitMemberInit(MemberInitExpression node) => (Expression) this.GiveUp<MemberInitExpression>(node);

    protected override MemberListBinding VisitMemberListBinding(MemberListBinding node) => this.GiveUp<MemberListBinding>(node);

    protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node) => this.GiveUp<MemberMemberBinding>(node);

    protected override Expression VisitMethodCall(MethodCallExpression node)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._gaveUp)
            {
              this._currentChain.Elements.Add((ExpressionFingerprint) new MethodCallExpressionFingerprint(node.NodeType, FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), (MethodInfo) FingerprintingExpressionVisitor.ipVYi8WsS7aovlxSv54((object) node)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_2:
      return (Expression) node;
label_6:
      return base.VisitMethodCall(node);
    }

    protected override Expression VisitNew(NewExpression node) => (Expression) this.GiveUp<NewExpression>(node);

    protected override Expression VisitNewArray(NewArrayExpression node) => (Expression) this.GiveUp<NewArrayExpression>(node);

    protected override Expression VisitParameter(ParameterExpression node)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int parameterIndex;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this._gaveUp)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              goto label_8;
            case 3:
              this._seenParameters.Add(node);
              num2 = 5;
              continue;
            case 4:
            case 5:
              goto label_3;
            case 6:
              parameterIndex = FingerprintingExpressionVisitor.TWRYYmWcKZVoLfwiwxq((object) this._seenParameters);
              num2 = 3;
              continue;
            case 7:
              if (parameterIndex >= 0)
              {
                num2 = 4;
                continue;
              }
              goto case 6;
            case 8:
              goto label_7;
            default:
              parameterIndex = this._seenParameters.IndexOf(node);
              num2 = 7;
              continue;
          }
        }
label_3:
        this._currentChain.Elements.Add((ExpressionFingerprint) new ParameterExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), parameterIndex));
        num1 = 8;
      }
label_7:
      return (Expression) FingerprintingExpressionVisitor.OvyVG1Wz4AjOaTKt3Nt((object) this, (object) node);
label_8:
      return (Expression) node;
    }

    protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node) => (Expression) this.GiveUp<RuntimeVariablesExpression>(node);

    protected override Expression VisitSwitch(SwitchExpression node) => (Expression) this.GiveUp<SwitchExpression>(node);

    protected override SwitchCase VisitSwitchCase(SwitchCase node) => this.GiveUp<SwitchCase>(node);

    protected override Expression VisitTry(TryExpression node) => (Expression) this.GiveUp<TryExpression>(node);

    protected override Expression VisitTypeBinary(TypeBinaryExpression node)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._gaveUp)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_2;
          case 3:
            goto label_5;
          default:
            this._currentChain.Elements.Add((ExpressionFingerprint) new TypeBinaryExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), FingerprintingExpressionVisitor.XbWoBUoF4rQjHsq4weQ((object) node)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return (Expression) FingerprintingExpressionVisitor.xqe1dqoBHumpa1FVQOp((object) this, (object) node);
label_5:
      return (Expression) node;
    }

    protected override Expression VisitUnary(UnaryExpression node)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this._currentChain.Elements.Add((ExpressionFingerprint) new UnaryExpressionFingerprint(FingerprintingExpressionVisitor.YujUmnWdY9qrm03lH7U((object) node), FingerprintingExpressionVisitor.j4OSoeWl5HvuVTx427F((object) node), node.Method));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 3:
            if (!this._gaveUp)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return (Expression) node;
label_6:
      return (Expression) FingerprintingExpressionVisitor.noXlRpoWN1GwYINEdY5((object) this, (object) node);
    }

    internal static void ypRuPSWMeSSQStrT5qf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fbAHfFWmddXWYBYNKoY() => FingerprintingExpressionVisitor.RKUkmdW0w1gG1DlHjuI == null;

    internal static FingerprintingExpressionVisitor or8sHRWyi6xKnIq0ivA() => FingerprintingExpressionVisitor.RKUkmdW0w1gG1DlHjuI;

    internal static object leirAXWJTTA1ieBXadV([In] object obj0, [In] object obj1) => (object) ((ExpressionVisitor) obj0).Visit((Expression) obj1);

    internal static object EKJOgHW9wfrbrqpstPg([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).Visit((Expression) obj1));

    internal static ExpressionType YujUmnWdY9qrm03lH7U([In] object obj0) => ((Expression) obj0).NodeType;

    internal static Type j4OSoeWl5HvuVTx427F([In] object obj0) => ((Expression) obj0).Type;

    internal static object GQymxCWrCCXHYWLOYAY([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitBinary((BinaryExpression) obj1));

    internal static object KM2VBeWgAmIGYm3kiXQ([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitConditional((ConditionalExpression) obj1));

    internal static object FlfPGpW5ZoeWSCVThUT([In] object obj0) => ((ConstantExpression) obj0).Value;

    internal static object cxsK23WjlxcUZQWvL2G([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitConstant((ConstantExpression) obj1));

    internal static object CW8klCWYg0w8p6iQv75([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitDefault((DefaultExpression) obj1));

    internal static object e5P38XWLbOpQONhUygL([In] object obj0) => (object) ((IndexExpression) obj0).Indexer;

    internal static object GPdfHwWUhNklT83Ijow([In] object obj0) => (object) ((MemberExpression) obj0).Member;

    internal static object ipVYi8WsS7aovlxSv54([In] object obj0) => (object) ((MethodCallExpression) obj0).Method;

    internal static int TWRYYmWcKZVoLfwiwxq([In] object obj0) => ((List<ParameterExpression>) obj0).Count;

    internal static object OvyVG1Wz4AjOaTKt3Nt([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitParameter((ParameterExpression) obj1));

    internal static Type XbWoBUoF4rQjHsq4weQ([In] object obj0) => ((TypeBinaryExpression) obj0).TypeOperand;

    internal static object xqe1dqoBHumpa1FVQOp([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitTypeBinary((TypeBinaryExpression) obj1));

    internal static object noXlRpoWN1GwYINEdY5([In] object obj0, [In] object obj1) => (object) __nonvirtual (((ExpressionVisitor) obj0).VisitUnary((UnaryExpression) obj1));
  }
}
