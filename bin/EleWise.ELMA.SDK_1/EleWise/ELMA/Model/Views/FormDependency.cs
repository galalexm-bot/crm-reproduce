// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormDependency
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Реализация для отслеживания зависимостей форм внутри других форм
  /// </summary>
  [Serializable]
  public class FormDependency : IFormDependency
  {
    internal static FormDependency XJA6PmoXMH5MNY9vh9E3;

    public FormDependency()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Name = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.FormUids = (IList<Guid>) new List<Guid>();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public FormDependency(string name, IEnumerable<Guid> formUids)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.FormUids = (IList<Guid>) formUids.ToList<Guid>();
    }

    public FormDependency(string name, IEnumerable<Guid> formUids, bool defaultDependency)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.FormUids = (IList<Guid>) formUids.ToList<Guid>();
      this.DefaultDependency = defaultDependency;
    }

    /// <summary>
    /// Идентификаторы форм, которые используют в данную форму
    /// </summary>
    public IList<Guid> FormUids { get; set; }

    /// <summary>Имя формы, у которой есть зависимости</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    public bool DefaultDependency
    {
      get => this.\u003CDefaultDependency\u003Ek__BackingField;
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
              this.\u003CDefaultDependency\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

    internal static bool GBJck2oXJ9oJjalwMmxt() => FormDependency.XJA6PmoXMH5MNY9vh9E3 == null;

    internal static FormDependency y33rWFoX9ZZxrQvTbZkC() => FormDependency.XJA6PmoXMH5MNY9vh9E3;
  }
}
