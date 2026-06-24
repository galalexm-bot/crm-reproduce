// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.ObjectsBAChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Настройки BPM App для экспорта объектной модели</summary>
  public class ObjectsBAChapter : BPMAppManifestChapter
  {
    internal static ObjectsBAChapter Iqwe5wfk97WyMTbReAxP;

    /// <summary>
    /// Гуиды метаданных объектов с флагом переноса справочников
    /// </summary>
    [XmlArray("Catalogs")]
    [DefaultValue(null)]
    public List<EntityBAItem> Catalogs { get; set; }

    /// <summary>
    /// Гуиды метаданных системных справочников (переносятся только данные)
    /// </summary>
    [XmlArray("SysCatalogs")]
    [DefaultValue(null)]
    public List<EntityBAItem> SysCatalogs { get; set; }

    /// <summary>
    /// Гуиды метаданных объектов с флагом переноса перечислений
    /// </summary>
    [DefaultValue(null)]
    [XmlArray("Enums")]
    public List<EnumBAItem> Enums { get; set; }

    /// <summary>
    /// Идентификаторы метаданных датаклассов с флагом переноса
    /// </summary>
    [XmlArray("DataClasses")]
    [DefaultValue(null)]
    public List<DataClassBAItem> DataClasses { get; set; }

    public ObjectsBAChapter()
    {
      ObjectsBAChapter.ITbYVZfkrAAaR7tJw2Nd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void ITbYVZfkrAAaR7tJw2Nd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YR1594fkdQo9e2nJcXIZ() => ObjectsBAChapter.Iqwe5wfk97WyMTbReAxP == null;

    internal static ObjectsBAChapter i0KHIIfkltHnUy2od32G() => ObjectsBAChapter.Iqwe5wfk97WyMTbReAxP;
  }
}
