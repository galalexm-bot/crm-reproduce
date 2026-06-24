// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.DataClassItemHeaderChangesLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>
  /// Компонент загрузки изменений по заголовокам элементов метаданных <see cref="T:EleWise.ELMA.Model.Metadata.DataClassMetadataItemHeader" /> и всем наследникам
  /// </summary>
  internal sealed class DataClassItemHeaderChangesLoader : EntityChangesLoader
  {
    private static DataClassItemHeaderChangesLoader RLk3pMbLJQQOrx6RXZGP;

    /// <summary>
    /// Поддерживается ли тип сущности данной точкой расширения
    /// </summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <returns><c>true</c>, если поддерживается</returns>
    public override bool IsTypeSupported(Guid typeUid)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_4;
          case 3:
            if (!(MetadataLoader.LoadMetadata(typeUid) is ClassMetadata metadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
              continue;
            }
            break;
        }
        if (InterfaceActivator.LoadMetadata<DataClassMetadataItemHeader>() != metadata)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
        else
          goto label_3;
      }
label_2:
      return MetadataLoader.IsBaseClass(InterfaceActivator.UID<DataClassMetadataItemHeader>(), metadata);
label_3:
      return true;
label_4:
      return false;
    }

    public DataClassItemHeaderChangesLoader()
    {
      DataClassItemHeaderChangesLoader.dkEJgHbLl1Dw4puW5BwR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool wkL6q2bL9KW5vkK2dYcK() => DataClassItemHeaderChangesLoader.RLk3pMbLJQQOrx6RXZGP == null;

    internal static DataClassItemHeaderChangesLoader vuAA4ObLduVRrcmCvkD5() => DataClassItemHeaderChangesLoader.RLk3pMbLJQQOrx6RXZGP;

    internal static void dkEJgHbLl1Dw4puW5BwR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
