// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Manifest.ExportedObjectsDescription
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Manifest
{
  public class ExportedObjectsDescription
  {
    private static ExportedObjectsDescription ea6v0HEaEe8ADE8txVZm;

    /// <summary>
    /// Экспортируемые объекты безопасности, группы метаданных, процессы
    /// </summary>
    public Dictionary<string, object> ExportServiceData { get; set; }

    /// <summary>Экспортируемые пакеты</summary>
    public Dictionary<string, IPackage> ExportPackages { get; set; }

    /// <summary>Экспортируемые пакеты сущностей</summary>
    public List<PacketEntity> ExportedPacketEntities { get; set; }

    /// <summary>Экспортируемые пакеты метаданных</summary>
    public List<PacketMetadata> ExportedPacketMetadatas { get; set; }

    /// <summary>Экспортируемые метаданные с флагом переноса данных</summary>
    public Dictionary<IGroupedMetadata, bool> ExportedObjects { get; set; }

    public ExportedObjectsDescription()
    {
      ExportedObjectsDescription.TcN4kOEaCVrsZpJiDfQj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ExportPackages = new Dictionary<string, IPackage>();
            num = 5;
            continue;
          case 2:
            this.ExportedPacketMetadatas = new List<PacketMetadata>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 3:
            this.ExportedObjects = new Dictionary<IGroupedMetadata, bool>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
            continue;
          case 4:
            this.ExportedPacketEntities = new List<PacketEntity>();
            num = 2;
            continue;
          case 5:
            goto label_3;
          default:
            this.ExportServiceData = new Dictionary<string, object>();
            num = 3;
            continue;
        }
      }
label_3:;
    }

    internal static void TcN4kOEaCVrsZpJiDfQj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FjBiiwEafNsSyPvtrDD1() => ExportedObjectsDescription.ea6v0HEaEe8ADE8txVZm == null;

    internal static ExportedObjectsDescription X78WCCEaQQ6Lc6QilOhS() => ExportedObjectsDescription.ea6v0HEaEe8ADE8txVZm;
  }
}
