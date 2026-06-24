// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableViewSortDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Параметры сортировки</summary>
  [DataContract]
  [Serializable]
  public class TableViewSortDescriptor : IEquatable<TableViewSortDescriptor>
  {
    internal static TableViewSortDescriptor iG9Yt2oNhWUCDIRweks7;

    /// <summary>
    /// Уникальный идентификатор свойства, по которому производится сортировка
    /// </summary>
    [DataMember]
    public Guid PropertyUid
    {
      get => this.\u003CPropertyUid\u003Ek__BackingField;
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
              this.\u003CPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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

    /// <summary>Направление сортировки</summary>
    [DataMember]
    public ListSortDirection Direction
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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
    public override bool Equals(object obj) => this.Equals(obj as TableViewSortDescriptor);

    /// <summary>Проверить равенство</summary>
    /// <param name="other">Параметры сортировки</param>
    /// <returns></returns>
    public bool Equals(TableViewSortDescriptor other)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (other != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_3;
            case 3:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_5:
        if (!TableViewSortDescriptor.aQoU0FoNQd4ij8ib49Hu(this.PropertyUid, TableViewSortDescriptor.JF7gYSoNfHi2kf0NbTXv((object) other)))
          num1 = 3;
        else
          break;
      }
label_3:
      return this.Direction == TableViewSortDescriptor.lyiS7ZoNCRGj48ualXJB((object) other);
label_4:
      return false;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
      int num = 2;
      Guid propertyUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyUid1 = this.PropertyUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 2:
            Guid propertyUid2 = this.PropertyUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return propertyUid1.GetHashCode() * 397 ^ this.Direction.GetHashCode();
    }

    public TableViewSortDescriptor()
    {
      TableViewSortDescriptor.cuh16uoNvAKmX9dwnh1f();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vZob9goNGsklFcqojVVm() => TableViewSortDescriptor.iG9Yt2oNhWUCDIRweks7 == null;

    internal static TableViewSortDescriptor oSurlfoNEUIUooO2IEVq() => TableViewSortDescriptor.iG9Yt2oNhWUCDIRweks7;

    internal static Guid JF7gYSoNfHi2kf0NbTXv([In] object obj0) => ((TableViewSortDescriptor) obj0).PropertyUid;

    internal static bool aQoU0FoNQd4ij8ib49Hu([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static ListSortDirection lyiS7ZoNCRGj48ualXJB([In] object obj0) => ((TableViewSortDescriptor) obj0).Direction;

    internal static void cuh16uoNvAKmX9dwnh1f() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
