// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.FindComponentOptions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services.FindComponent
{
  /// <summary>Опции поиска</summary>
  public sealed class FindComponentOptions : ICloneable
  {
    private static FindComponentOptions jdq6O7BBZhiyBoUkPDmJ;

    /// <summary>Ctor</summary>
    public FindComponentOptions()
    {
      FindComponentOptions.ogDq4TBBVfEkAjjPcr2x();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CheckCompatibility = true;
            num = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.NeededModules = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
            continue;
          default:
            this.LoadedModules = new List<ItemRuntimeModel>();
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Режим отображения</summary>
    public InterfaceBuilderViewMode ViewMode
    {
      get => this.\u003CViewMode\u003Ek__BackingField;
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
              this.\u003CViewMode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Загруженные модули в Runtime</summary>
    public List<ItemRuntimeModel> LoadedModules { get; set; }

    /// <summary>Необходимые модули для загрузки</summary>
    public List<Guid> NeededModules { get; set; }

    /// <summary>Проверять совместимость</summary>
    public bool CheckCompatibility
    {
      get => this.\u003CCheckCompatibility\u003Ek__BackingField;
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
              this.\u003CCheckCompatibility\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    /// <summary>Кешировать результат метода</summary>
    public bool CacheResult
    {
      get => this.\u003CCacheResult\u003Ek__BackingField;
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
              this.\u003CCacheResult\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    public object Clone()
    {
      FindComponentOptions componentOptions = new FindComponentOptions();
      FindComponentOptions.OQgI7yBBSm3Pt14enMvE((object) componentOptions, this.ViewMode);
      componentOptions.CheckCompatibility = this.CheckCompatibility;
      componentOptions.LoadedModules.AddRange((IEnumerable<ItemRuntimeModel>) this.LoadedModules);
      componentOptions.NeededModules.AddRange((IEnumerable<Guid>) this.NeededModules);
      return (object) componentOptions;
    }

    internal static void ogDq4TBBVfEkAjjPcr2x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FeOClCBBuFJjpCtRLshT() => FindComponentOptions.jdq6O7BBZhiyBoUkPDmJ == null;

    internal static FindComponentOptions OQh7xJBBI2uGxZLtBVSc() => FindComponentOptions.jdq6O7BBZhiyBoUkPDmJ;

    internal static void OQgI7yBBSm3Pt14enMvE([In] object obj0, InterfaceBuilderViewMode value) => ((FindComponentOptions) obj0).ViewMode = value;
  }
}
