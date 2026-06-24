// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Nullifier.PostNullifierParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Nullifier
{
  /// <summary>Действия после очистки всех объектов</summary>
  public class PostNullifierParameters
  {
    /// <summary>
    /// Удалить сущность
    /// Параметры функции
    /// UnitNullConfig - Удаляемая сущность;
    /// string - ограничивающий запрос;
    /// bool  mark - маркировать сущность как очищенную
    /// bool сlearParentAll - Очистить все зависимые сущности
    /// int level - уровень вложенности запроса
    /// bool noDeleteRootEntity - не удалять корневую сцщность
    /// int clearLevel - уровень вложенности зависимых объектов до которой будет осуществлена очистка
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<UnitNullConfig, string, bool, int, bool, bool> DeleteEntityMetadata;
    /// <summary>Интерфейс провайдера преобразования БД</summary>
    public ITransformationProvider Transform;
    private static PostNullifierParameters KON2iW2eeLTe0YZ1uAn;

    /// <summary>Количество помеченных для удаления документов</summary>
    public int TempTableNameDmsCount
    {
      get => this.\u003CTempTableNameDmsCount\u003Ek__BackingField;
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
              this.\u003CTempTableNameDmsCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>Количество помеченных для удаления папок</summary>
    public int TempTableNameFolderCount
    {
      get => this.\u003CTempTableNameFolderCount\u003Ek__BackingField;
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
              this.\u003CTempTableNameFolderCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

    public PostNullifierParameters()
    {
      PostNullifierParameters.gH1VlC2Nf6wiH12EVn2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AEq8GT2Pj8lF7sEVZ9T() => PostNullifierParameters.KON2iW2eeLTe0YZ1uAn == null;

    internal static PostNullifierParameters XNV3LD21oOcFlvCxfuS() => PostNullifierParameters.KON2iW2eeLTe0YZ1uAn;

    internal static void gH1VlC2Nf6wiH12EVn2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
