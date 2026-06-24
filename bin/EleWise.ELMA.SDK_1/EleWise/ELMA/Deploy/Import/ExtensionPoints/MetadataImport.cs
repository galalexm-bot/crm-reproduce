// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.MetadataImport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  [Component]
  public abstract class MetadataImport : IMetadataImport
  {
    internal static MetadataImport kYdQw9ErXXsZvhgfrgTD;

    /// <summary>
    /// Создание фальшивого раздела метаданных дерева импортируемых объектов
    /// </summary>
    public abstract void CreateFakeChapter(
      NamedMetadata namedMd,
      BPMAppFakeManifest fakeManifest,
      BPMAppManifest manifest);

    public virtual void MergeMetadataSettings(
      NamedMetadata mdBase,
      NamedMetadata mdImported,
      Dictionary<string, string> serviceData)
    {
    }

    protected MetadataImport()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool q0H1SEErTIqyRrKjsk3v() => MetadataImport.kYdQw9ErXXsZvhgfrgTD == null;

    internal static MetadataImport gFoKEjErkfVucG69dmEJ() => MetadataImport.kYdQw9ErXXsZvhgfrgTD;
  }
}
