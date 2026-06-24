// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ServiceAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Атрибут службы, автоматически регистрируемой в контейнере Autofac
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public class ServiceAttribute : Attribute
  {
    private bool injectProerties;
    private ServiceScope scope;
    private bool enableInterceptors;
    private ComponentType type;
    private static ServiceAttribute J1eXcufZr7KWWODZZI4Z;

    /// <summary>Автоматически присвоить значения свойств</summary>
    [DefaultValue(true)]
    public bool InjectProperties
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <summary>Тип жизненного цикла</summary>
    [DefaultValue(ServiceScope.Application)]
    public ServiceScope Scope
    {
      get => this.scope;
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
              this.scope = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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
    [DefaultValue(true)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    public ServiceAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.injectProerties = true;
      this.scope = ServiceScope.Application;
      this.enableInterceptors = true;
      this.type = ComponentType.All;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vbYHvBfZgmaRVcrTrlWt() => ServiceAttribute.J1eXcufZr7KWWODZZI4Z == null;

    internal static ServiceAttribute lbPG1tfZ5XdjEcODi4rH() => ServiceAttribute.J1eXcufZr7KWWODZZI4Z;
  }
}
