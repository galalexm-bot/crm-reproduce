// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Cache.TypeInfoCache
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Cache
{
  /// <summary>
  /// Информация о типе. Нужна для оптимизации запуска приложения.
  /// </summary>
  public class TypeInfoCache
  {
    internal AssemblyInfoCache _owner;
    private static TypeInfoCache XMLk0TWPElpRSZc85aEu;

    /// <summary>Имя типа</summary>
    public string TypeName
    {
      get => this.\u003CTypeName\u003Ek__BackingField;
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
              this.\u003CTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    /// <summary>Индексы доступных перехватчиков</summary>
    public List<int> EnabledInterceptors { get; set; }

    /// <summary>Индексы недоступных перехватчиков</summary>
    public List<int> DisabledInterceptors { get; set; }

    /// <summary>Является ли тип компонентом</summary>
    public bool? IsComponentType { get; set; }

    /// <summary>Является ли тип сервисом</summary>
    public bool? IsServiceType { get; set; }

    /// <summary>Ctor</summary>
    public TypeInfoCache()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EnabledInterceptors = new List<int>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.DisabledInterceptors = new List<int>();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="owner">Объект-владелец</param>
    /// <param name="type">Тип</param>
    public TypeInfoCache(AssemblyInfoCache owner, Type type)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._owner = owner;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.TypeName = type.FullName;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Доступен ли перехватчик с указанным именем</summary>
    /// <param name="name">Имя перехватчика</param>
    /// <returns></returns>
    public bool? IsInterceptorEnabled(string name)
    {
      if (this._owner == null || this._owner._owner == null)
        return new bool?();
      int interceptorIndex = this._owner._owner.GetInterceptorIndex(name);
      if (this.EnabledInterceptors.Contains(interceptorIndex))
        return new bool?(true);
      return this.DisabledInterceptors.Contains(interceptorIndex) ? new bool?(false) : new bool?();
    }

    /// <summary>Установить доступность перехватчика</summary>
    /// <param name="name">Имя перехватчика</param>
    /// <param name="enabled">Доступен ли перехватчик</param>
    /// <returns></returns>
    public void SetInterceptorEnabled(string name, bool enabled)
    {
      int num1 = 4;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!enabled)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            }
            goto case 10;
          case 2:
            goto label_9;
          case 3:
            goto label_19;
          case 4:
            if (this._owner == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 3;
              continue;
            }
            goto case 5;
          case 5:
            if (this._owner._owner == null)
            {
              num1 = 8;
              continue;
            }
            num2 = TypeInfoCache.wQ3ArLWPC8usZKNYpZA8((object) this._owner._owner, (object) name);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
            continue;
          case 6:
            this.DisabledInterceptors.Add(num2);
            num1 = 11;
            continue;
          case 7:
            this.EnabledInterceptors.Add(num2);
            num1 = 9;
            continue;
          case 8:
            goto label_16;
          case 9:
            goto label_12;
          case 10:
            if (this.EnabledInterceptors.Contains(num2))
            {
              num1 = 2;
              continue;
            }
            goto case 7;
          case 11:
            goto label_2;
          default:
            if (!this.DisabledInterceptors.Contains(num2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 2;
              continue;
            }
            goto label_13;
        }
      }
label_9:
      return;
label_19:
      return;
label_16:
      return;
label_12:
      return;
label_2:
      return;
label_13:;
    }

    internal static bool J3u3awWPftuu96ZSAx0Q() => TypeInfoCache.XMLk0TWPElpRSZc85aEu == null;

    internal static TypeInfoCache GABwODWPQPd9r6NO2giU() => TypeInfoCache.XMLk0TWPElpRSZc85aEu;

    internal static int wQ3ArLWPC8usZKNYpZA8([In] object obj0, [In] object obj1) => ((ApplicationStartCache) obj0).GetInterceptorIndex((string) obj1);
  }
}
