// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ComponentAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Атрибут компонента, реализующего точки расширений</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
  public class ComponentAttribute : Attribute
  {
    private bool injectProerties;
    private bool enableInterceptors;
    private ComponentType type;
    internal static ComponentAttribute o2qWs7fZz56ixuxjuj6c;

    /// <summary>
    /// Порядок, в котором выстраивается список компонентов, реализующих определенную точку расширения
    /// </summary>
    [DefaultValue(0)]
    public int Order
    {
      get => this.\u003COrder\u003Ek__BackingField;
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
              this.\u003COrder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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
    /// Автоматически инициализировать значения свойств (через контейнер Autofac)
    /// </summary>
    [DefaultValue(true)]
    public bool InjectProerties
    {
      get => this.injectProerties;
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
              this.injectProerties = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Применять перехватчики методов к классу</summary>
    [DefaultValue(false)]
    [Obsolete("Use EnableInterceptors. This will be removed.")]
    public bool EnableInterceptiors
    {
      get => this.enableInterceptors;
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
              this.enableInterceptors = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    /// <summary>Применять перехватчики методов к классу</summary>
    [DefaultValue(false)]
    public bool EnableInterceptors
    {
      get => this.enableInterceptors;
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
              this.enableInterceptors = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <summary>Тип компонента</summary>
    [DefaultValue(ComponentType.All)]
    public ComponentType Type
    {
      get => this.type;
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
              this.type = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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

    public ComponentAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.injectProerties = true;
      this.type = ComponentType.All;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Q2jh7CfuF3WJ5iSRU5tU() => ComponentAttribute.o2qWs7fZz56ixuxjuj6c == null;

    internal static ComponentAttribute bCMD1MfuBefdtRqKru2m() => ComponentAttribute.o2qWs7fZz56ixuxjuj6c;
  }
}
