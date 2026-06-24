// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.EntityPropertyAction
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
  /// <summary>Абстрактное дейстиве со свойством сущности</summary>
  public abstract class EntityPropertyAction : EntityAction
  {
    private EntityPropertyMetadata propertyMetadata;
    internal static EntityPropertyAction RpBZKboG4uQlvLyTBhSi;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства сущности</param>
    public EntityPropertyAction(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      EntityPropertyAction.T7iijooGAMSUVBhhYCVG();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            EntityPropertyAction.lYsw8goG7XXoU9g5l0iE((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360350031));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          default:
            this.propertyMetadata = propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Метаданные свойства сущности</summary>
    protected EntityPropertyMetadata PropertyMetadata => this.propertyMetadata;

    internal static void T7iijooGAMSUVBhhYCVG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void lYsw8goG7XXoU9g5l0iE([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool jM6WeAoG6T5vSKkd6DFC() => EntityPropertyAction.RpBZKboG4uQlvLyTBhSi == null;

    internal static EntityPropertyAction DLs6qmoGH8V1qTgBsJAt() => EntityPropertyAction.RpBZKboG4uQlvLyTBhSi;
  }
}
