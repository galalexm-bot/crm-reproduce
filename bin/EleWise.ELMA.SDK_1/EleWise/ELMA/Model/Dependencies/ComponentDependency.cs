// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.ComponentDependency
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Зависимость от компонента</summary>
  [Serializable]
  public sealed class ComponentDependency : Dependency
  {
    internal static ComponentDependency s3MBNOhRhKgu7FcOMVI2;

    /// <summary>Ctor</summary>
    public ComponentDependency()
    {
      ComponentDependency.RrPWTwhRfmY7aUBLWFnL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Inputs = new List<InputComputedValue>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор компонента на форме</summary>
    [DefaultValue(null)]
    public Guid ViewItemUid
    {
      get => this.\u003CViewItemUid\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CViewItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Список входных параметров компонента</summary>
    public List<InputComputedValue> Inputs { get; }

    /// <summary>Компонент является асинхронным</summary>
    [DefaultValue(false)]
    public bool Async
    {
      get => this.\u003CAsync\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAsync\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Dependencies.ComponentDependency.Inputs" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeInputs() => ComponentDependency.xFe3gQhRQkq03YYC1Ywm((object) this.Inputs) != 0;

    internal static void RrPWTwhRfmY7aUBLWFnL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool z09kjJhRGWffB0wOkFd1() => ComponentDependency.s3MBNOhRhKgu7FcOMVI2 == null;

    internal static ComponentDependency Ql6BvahRE1cAI1pFNpQC() => ComponentDependency.s3MBNOhRhKgu7FcOMVI2;

    internal static int xFe3gQhRQkq03YYC1Ywm([In] object obj0) => ((List<InputComputedValue>) obj0).Count;
  }
}
