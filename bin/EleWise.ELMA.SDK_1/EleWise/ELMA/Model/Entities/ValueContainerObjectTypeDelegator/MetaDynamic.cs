// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.MetaDynamic
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Accessors;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class MetaDynamic : DynamicMetaObject
  {
    private readonly GetPropertyAccessorDelegate getPropertyAccessor;
    private static MetaDynamic OseSWohSDu2QgTvdcDsT;

    public MetaDynamic(
      Expression expression,
      IValueContainerObjectInternal value,
      GetPropertyAccessorDelegate getPropertyAccessor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(expression, BindingRestrictions.Empty, (object) value);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.getPropertyAccessor = getPropertyAccessor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
    {
      int num = 2;
      IAccessor accessor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (accessor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 3 : 2;
              continue;
            }
            goto case 4;
          case 2:
            accessor = (IAccessor) MetaDynamic.SaAlZNhS6SjUG60GBVeQ((object) this.getPropertyAccessor, MetaDynamic.zqBLbUhS4sX4baE8N7ZH((object) binder));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          case 4:
            if (!accessor.HasGetter)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 5:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      return (DynamicMetaObject) MetaDynamic.sNpCINhS0C5MjMEvPPew((object) binder, (object) this, (object) new DynamicMetaObject((Expression) Expression.Block((Expression) MetaDynamic.myLMKahSH7xVYsTku4lS((object) accessor, (object) this.Expression)), (BindingRestrictions) MetaDynamic.UmDNuNhSxHf5RNDrLLuD((object) this.GetRestriction(), MetaDynamic.Sv461fhS79MLMO1jEf09(MetaDynamic.SHFxnbhSAIXtUsAJ3TfM((object) binder, (object) this)))));
label_4:
      return (DynamicMetaObject) MetaDynamic.tu16r2hSmK7DwikMdlrF((object) this, (object) binder);
    }

    public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
    {
      int num = 3;
      IAccessor accessor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!accessor.HasSetter)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 5;
              continue;
            }
            break;
          case 2:
            if (accessor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          case 3:
            accessor = (IAccessor) MetaDynamic.SaAlZNhS6SjUG60GBVeQ((object) this.getPropertyAccessor, MetaDynamic.IKtUvRhSy9fR7ve11t18((object) binder));
            num = 2;
            continue;
          case 4:
            goto label_7;
          case 5:
            goto label_8;
        }
        // ISSUE: type reference
        MetaDynamic.m9VtKnhSJBOTxBcQnJIq(MetaDynamic.dFPomnhSMTGa66BdQyRe(__typeref (object)), (object) null);
        num = 4;
      }
label_7:
      return (DynamicMetaObject) MetaDynamic.sCmCguhSguhAKiFKvYv7((object) binder, (object) this, (object) value, (object) new DynamicMetaObject((Expression) MetaDynamic.HI0CNyhSlb3NENv61vf7((object) new Expression[1]
      {
        (Expression) MetaDynamic.JrPk9UhSdTpluy0j4BwG((object) accessor, MetaDynamic.jm3WpIhS9K9ZquIdKRyt((object) this), (object) value.Expression)
      }), this.GetRestriction().Merge((BindingRestrictions) MetaDynamic.Sv461fhS79MLMO1jEf09(MetaDynamic.ErTYowhSrbqdGPs2WJHn((object) binder, (object) this, (object) value)))));
label_8:
      return base.BindSetMember(binder, value);
    }

    internal BindingRestrictions GetRestriction()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_6;
          case 3:
            if (this.Value != null)
            {
              num = 2;
              continue;
            }
            break;
        }
        if (!MetaDynamic.J2EVfRhS56anrD8hJcP0((object) this))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
        else
          goto label_7;
      }
label_6:
      return (BindingRestrictions) MetaDynamic.sHaJ7BhSYtbVR8NGyTrT(MetaDynamic.jm3WpIhS9K9ZquIdKRyt((object) this), MetaDynamic.FT0ujThSjp8NL2hNKxqB((object) this));
label_7:
      return (BindingRestrictions) MetaDynamic.a5Zk1ahSLelLAF3OLIOG(MetaDynamic.jm3WpIhS9K9ZquIdKRyt((object) this), (object) null);
    }

    internal static bool B1YNOQhStaftGtDPlqte() => MetaDynamic.OseSWohSDu2QgTvdcDsT == null;

    internal static MetaDynamic KrnnvhhSwfE0DdQu0jXY() => MetaDynamic.OseSWohSDu2QgTvdcDsT;

    internal static object zqBLbUhS4sX4baE8N7ZH([In] object obj0) => (object) ((GetMemberBinder) obj0).Name;

    internal static object SaAlZNhS6SjUG60GBVeQ([In] object obj0, [In] object obj1) => (object) ((GetPropertyAccessorDelegate) obj0)((string) obj1);

    internal static object myLMKahSH7xVYsTku4lS([In] object obj0, [In] object obj1) => (object) ((IAccessor) obj0).GetExpression((Expression) obj1);

    internal static object SHFxnbhSAIXtUsAJ3TfM([In] object obj0, [In] object obj1) => (object) ((GetMemberBinder) obj0).FallbackGetMember((DynamicMetaObject) obj1);

    internal static object Sv461fhS79MLMO1jEf09([In] object obj0) => (object) ((DynamicMetaObject) obj0).Restrictions;

    internal static object UmDNuNhSxHf5RNDrLLuD([In] object obj0, [In] object obj1) => (object) ((BindingRestrictions) obj0).Merge((BindingRestrictions) obj1);

    internal static object sNpCINhS0C5MjMEvPPew([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((GetMemberBinder) obj0).FallbackGetMember((DynamicMetaObject) obj1, (DynamicMetaObject) obj2);

    internal static object tu16r2hSmK7DwikMdlrF([In] object obj0, [In] object obj1) => (object) __nonvirtual (((DynamicMetaObject) obj0).BindGetMember((GetMemberBinder) obj1));

    internal static object IKtUvRhSy9fR7ve11t18([In] object obj0) => (object) ((SetMemberBinder) obj0).Name;

    internal static Type dFPomnhSMTGa66BdQyRe([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object m9VtKnhSJBOTxBcQnJIq([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object jm3WpIhS9K9ZquIdKRyt([In] object obj0) => (object) ((DynamicMetaObject) obj0).Expression;

    internal static object JrPk9UhSdTpluy0j4BwG([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IAccessor) obj0).SetExpression((Expression) obj1, (Expression) obj2);

    internal static object HI0CNyhSlb3NENv61vf7([In] object obj0) => (object) Expression.Block((Expression[]) obj0);

    internal static object ErTYowhSrbqdGPs2WJHn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SetMemberBinder) obj0).FallbackSetMember((DynamicMetaObject) obj1, (DynamicMetaObject) obj2);

    internal static object sCmCguhSguhAKiFKvYv7(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((SetMemberBinder) obj0).FallbackSetMember((DynamicMetaObject) obj1, (DynamicMetaObject) obj2, (DynamicMetaObject) obj3);
    }

    internal static bool J2EVfRhS56anrD8hJcP0([In] object obj0) => ((DynamicMetaObject) obj0).HasValue;

    internal static Type FT0ujThSjp8NL2hNKxqB([In] object obj0) => ((DynamicMetaObject) obj0).LimitType;

    internal static object sHaJ7BhSYtbVR8NGyTrT([In] object obj0, [In] Type obj1) => (object) BindingRestrictions.GetTypeRestriction((Expression) obj0, obj1);

    internal static object a5Zk1ahSLelLAF3OLIOG([In] object obj0, [In] object obj1) => (object) BindingRestrictions.GetInstanceRestriction((Expression) obj0, obj1);
  }
}
