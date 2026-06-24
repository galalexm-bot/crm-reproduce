// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.MetadataItemHeaderChangesLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Компонент загрузки изменений по заголовокам элементов метаданных <see cref="T:EleWise.ELMA.Model.Metadata.IMetadataItemHeader" /> и всем наследникам
  /// </summary>
  internal sealed class MetadataItemHeaderChangesLoader : EntityChangesLoader
  {
    internal static MetadataItemHeaderChangesLoader pWxaethh5cFxGMtRwdSX;

    /// <summary>
    /// Поддерживается ли тип сущности данной точкой расширения
    /// </summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <returns><c>true</c>, если поддерживается</returns>
    public override bool IsTypeSupported(Guid typeUid)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (InterfaceActivator.LoadMetadata<IMetadataItemHeader>() != metadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata metadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      return MetadataLoader.IsBaseClass(InterfaceActivator.UID<IMetadataItemHeader>(), metadata);
label_5:
      return true;
label_6:
      return false;
    }

    public MetadataItemHeaderChangesLoader()
    {
      MetadataItemHeaderChangesLoader.RrBWrxhhLriO2hjiNSnY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool B6lssghhjdhb0yud2lQT() => MetadataItemHeaderChangesLoader.pWxaethh5cFxGMtRwdSX == null;

    internal static MetadataItemHeaderChangesLoader gUrYTphhY3P1ZbFhljlY() => MetadataItemHeaderChangesLoader.pWxaethh5cFxGMtRwdSX;

    internal static void RrBWrxhhLriO2hjiNSnY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
