// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RestrictionBuilderSelectAction`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Helpers
{
  public class RestrictionBuilderSelectAction<T> : RestrictionBuilderBase<T>
  {
    private static object sDNsjHhcjlVO6sbZOvUo;

    public RestrictionBuilderSelectAction(
      RestrictionBuilderSelectType<T> baseRestrictionBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(baseRestrictionBuilder.restriction, baseRestrictionBuilder.restrictionsBuilder);
    }

    /// <summary>Игнорировать по текущему правилу</summary>
    public void Ignore()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.restriction.RuleType = RuleType.Ignore;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Клонировать по текущему правилу</summary>
    public void Clone()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.restriction.RuleType = RuleType.Clone;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Копировать ссылку по текущему правилу</summary>
    public void ByRef()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.restriction.RuleType = RuleType.CopyByRef;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Правило для ссылки устанавливается обработчиком</summary>
    public void Action(Func<object, object, CopyAction> action)
    {
      this.restriction.RuleType = RuleType.Action;
      this.restriction.Action = action;
    }

    internal static bool EqUN7jhcYvMtwyaI1ro6() => RestrictionBuilderSelectAction<T>.sDNsjHhcjlVO6sbZOvUo == null;

    internal static object Svw3yphcL8C2A3Gv3ZPW() => RestrictionBuilderSelectAction<T>.sDNsjHhcjlVO6sbZOvUo;
  }
}
