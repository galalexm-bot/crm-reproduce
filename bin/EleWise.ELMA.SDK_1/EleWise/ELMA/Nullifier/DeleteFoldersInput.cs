// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Nullifier.DeleteFoldersInput
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Nullifier
{
  /// <summary>Параметры для передачи при вызове удаления папки</summary>
  public class DeleteFoldersInput
  {
    /// <summary>Uid удаляемой папки</summary>
    public Guid uid;
    /// <summary>уровень вложенности запроса</summary>
    public int level;
    /// <summary>Интерфейс провайдера преобразования БД</summary>
    public ITransformationProvider transform;
    /// <summary>
    /// Выполнить запрос
    /// Параметры функции
    ///  string - sql запрос;
    ///  string - коментарий к запросу;
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<string, string, bool> sqlQuery;
    /// <summary>
    /// Выполнить SQL запрос
    /// Параметры функции
    ///  string - sql запрос;
    ///  string - коментарий к запросу;
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<string, string, bool> ExecuteQuery;
    /// <summary>Только очищать папку (без удаления)</summary>
    public bool ClearFolderOnly;
    internal static DeleteFoldersInput pOZ3Ow2Dfe7kVrobb5w;

    public DeleteFoldersInput()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xmcWaJ2tx84BCpC1uuD() => DeleteFoldersInput.pOZ3Ow2Dfe7kVrobb5w == null;

    internal static DeleteFoldersInput OnAhpD2wCyCYU7pcVtH() => DeleteFoldersInput.pOZ3Ow2Dfe7kVrobb5w;
  }
}
