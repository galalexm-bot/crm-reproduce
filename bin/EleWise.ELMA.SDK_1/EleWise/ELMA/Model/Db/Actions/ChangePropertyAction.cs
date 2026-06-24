// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.ChangePropertyAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Дей</summary>
  public class ChangePropertyAction : EntityPropertyAction
  {
    private EntityPropertyMetadata oldPropertyMetadata;
    internal static ChangePropertyAction TvwV3aoGCEP4jvAgt8UJ;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства сущности</param>
    /// <param name="oldPropertyMetadata">Предыдущие метаданные свойства сущности</param>
    public ChangePropertyAction(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      ChangePropertyAction.zBDITXoGZ9bJOpkgP80S();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata, propertyMetadata);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.oldPropertyMetadata = oldPropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            ChangePropertyAction.XlM0SXoGuBKTaYVBHr0a((object) this.Updater, (object) this.Metadata, (object) propertyMetadata, (object) oldPropertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    internal static void zBDITXoGZ9bJOpkgP80S() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XlM0SXoGuBKTaYVBHr0a([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => DbModelHelper.ApplyPropertyDbChanges((IDbModelUpdater) obj0, (EntityMetadata) obj1, (EntityPropertyMetadata) obj2, (EntityPropertyMetadata) obj3);

    internal static bool h2M7bAoGvgGtebAm8O4N() => ChangePropertyAction.TvwV3aoGCEP4jvAgt8UJ == null;

    internal static ChangePropertyAction pvxcKPoG8sddIpn1WyOZ() => ChangePropertyAction.TvwV3aoGCEP4jvAgt8UJ;
  }
}
