// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.StepsViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Шаги</summary>
  [Serializable]
  public sealed class StepsViewItem : 
    RootViewItem,
    ILayoutViewItem,
    IViewItemWithActiveKey,
    IViewItemWithPropertyParents
  {
    private static StepsViewItem no4witoirV79JDiJ5gW5;

    /// <summary>Ctor</summary>
    public StepsViewItem()
    {
      StepsViewItem.Smi74woijIqqoWXiAPfA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Direction = DirectionType.Horizontal;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Направление</summary>
    [DefaultValue(DirectionType.Horizontal)]
    public DirectionType Direction
    {
      get => this.\u003CDirection\u003Ek__BackingField;
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
              this.\u003CDirection\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Активный шаг</summary>
    public Guid ActiveKeyProperty
    {
      get => this.\u003CActiveKeyProperty\u003Ek__BackingField;
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
              this.\u003CActiveKeyProperty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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
    public List<Guid> PropertyParents { get; set; }

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => true;

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.StepsViewItem.PropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PropertyParents != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.PropertyParents.Count > 0;
label_5:
      return false;
    }

    internal static void Smi74woijIqqoWXiAPfA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Gs0QZfoigl1y8nHYWM2j() => StepsViewItem.no4witoirV79JDiJ5gW5 == null;

    internal static StepsViewItem aZi5x1oi5em4tOb4Cb20() => StepsViewItem.no4witoirV79JDiJ5gW5;
  }
}
