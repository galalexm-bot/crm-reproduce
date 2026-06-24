// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableViewGroupDescriptor
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
  /// <summary>Параметры группировки</summary>
  [DataContract]
  [Serializable]
  public class TableViewGroupDescriptor : IEquatable<TableViewGroupDescriptor>
  {
    private static TableViewGroupDescriptor CtJ62soNFOrR2yV3gUQU;

    /// <summary>
    /// Уникальный идентификатор свойства, по которому производится группировка
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

    /// <summary>Направление группировки</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    public override bool Equals(object obj) => this.Equals(obj as TableViewGroupDescriptor);

    public bool Equals(TableViewGroupDescriptor other)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(this.PropertyUid == other.PropertyUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            if (other == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return this.Direction == TableViewGroupDescriptor.g8bVQ1oNobQyvUMXJv38((object) other);
label_7:
      return false;
    }

    public TableViewGroupDescriptor()
    {
      TableViewGroupDescriptor.srNJFnoNboi6an6vEObO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vDfjOOoNBs2oY1wan9tZ() => TableViewGroupDescriptor.CtJ62soNFOrR2yV3gUQU == null;

    internal static TableViewGroupDescriptor m7qf3ZoNW20xb5FvuXTy() => TableViewGroupDescriptor.CtJ62soNFOrR2yV3gUQU;

    internal static ListSortDirection g8bVQ1oNobQyvUMXJv38([In] object obj0) => ((TableViewGroupDescriptor) obj0).Direction;

    internal static void srNJFnoNboi6an6vEObO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
