// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.EntityAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Абстрактное действие для метаданных сущности</summary>
  public abstract class EntityAction : ModelAction
  {
    private EntityMetadata metadata;
    private static EntityAction Xb28aToEGJJCBQxYAQgI;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    public EntityAction(IDbModelUpdater updater, EntityMetadata metadata)
    {
      EntityAction.XlChdIoEQ4wL64N2JOQv();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            EntityAction.zI5fNnoECJ56EwNDZsBq((object) metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088322842));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          default:
            this.metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Метаданные сущности</summary>
    protected EntityMetadata Metadata => this.metadata;

    internal static void XlChdIoEQ4wL64N2JOQv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void zI5fNnoECJ56EwNDZsBq([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool gvjQB1oEEGka3SgHc8gh() => EntityAction.Xb28aToEGJJCBQxYAQgI == null;

    internal static EntityAction UQdQKLoEfVAJu4YQSVST() => EntityAction.Xb28aToEGJJCBQxYAQgI;
  }
}
