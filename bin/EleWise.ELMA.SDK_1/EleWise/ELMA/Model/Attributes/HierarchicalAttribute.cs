// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.HierarchicalAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что объект поддерживает иерархичность
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class HierarchicalAttribute : Attribute
  {
    private HierarchyType _hierarchyType;
    private Guid _parentPropertyUid;
    private Guid _isGroupPropertyUid;
    private static HierarchicalAttribute oQCjr6o8q63tFHRxQOGP;

    /// <summary>Ctor</summary>
    /// <param name="hierarchyType">Тип иерархии</param>
    /// <param name="parentPropertyUid">Уникальный идентификатор свойства "Родительский объект"</param>
    /// <param name="isGroupPropertyUid">Уникальный идентификатор свойства "Является группой"</param>
    public HierarchicalAttribute(
      HierarchyType hierarchyType,
      string parentPropertyUid,
      string isGroupPropertyUid)
    {
      HierarchicalAttribute.iBVqJ5o8TXJWQ2c2j7rf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._parentPropertyUid = !HierarchicalAttribute.JuQ4Ygo8koS05DmrUTb4((object) parentPropertyUid) ? new Guid(parentPropertyUid) : Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
            continue;
          case 2:
            this._isGroupPropertyUid = !string.IsNullOrEmpty(isGroupPropertyUid) ? new Guid(isGroupPropertyUid) : Guid.Empty;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this._hierarchyType = hierarchyType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип иерархии</summary>
    public HierarchyType HierarchyType => this._hierarchyType;

    /// <summary>
    /// Уникальный идентификатор свойства "Родительский объект"
    /// </summary>
    public Guid ParentPropertyUid => this._parentPropertyUid;

    /// <summary>Уникальный идентификатор свойства "Является группой"</summary>
    public Guid IsGroupPropertyUid => this._isGroupPropertyUid;

    internal static void iBVqJ5o8TXJWQ2c2j7rf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JuQ4Ygo8koS05DmrUTb4([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool YvWLLXo8Kib0vpI1KSM6() => HierarchicalAttribute.oQCjr6o8q63tFHRxQOGP == null;

    internal static HierarchicalAttribute dbbtg4o8X2aEWVSB6KeF() => HierarchicalAttribute.oQCjr6o8q63tFHRxQOGP;
  }
}
