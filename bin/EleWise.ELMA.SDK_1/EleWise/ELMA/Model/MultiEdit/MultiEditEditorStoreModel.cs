// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MultiEdit.MultiEditEditorStoreModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.MultiEdit
{
  /// <summary>
  /// Модель дополнительных атрибутов задачи при импорте из MS Project
  /// </summary>
  public class MultiEditEditorStoreModel
  {
    public Guid editSessionUid;
    public long userId;
    public string userName;
    public string userLink;
    public long parentObjectId;
    public string parentObjectName;
    public long objectId;
    public string objectName;
    public DateTime openTime;
    public string openTimeStr;
    public DateTime? saveTime;
    public string saveTimeStr;
    public DateTime? publishTime;
    public string publishTimeStr;
    public DateTime lastActivityTime;
    public string lastActivityTimeStr;
    /// <summary>Сохранить изменения от предыдущей открытой сессии</summary>
    public bool SaveChanges;
    public bool savedAfter;
    internal static MultiEditEditorStoreModel UqcTsAWLwIlssfxFQ30u;

    public MultiEditEditorStoreModel()
    {
      MultiEditEditorStoreModel.NHShgTWLHZ3EncwkmaaW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void NHShgTWLHZ3EncwkmaaW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yeF8o7WL4JajaZZFjijk() => MultiEditEditorStoreModel.UqcTsAWLwIlssfxFQ30u == null;

    internal static MultiEditEditorStoreModel cEs6x9WL6FOfFAro0KWA() => MultiEditEditorStoreModel.UqcTsAWLwIlssfxFQ30u;
  }
}
