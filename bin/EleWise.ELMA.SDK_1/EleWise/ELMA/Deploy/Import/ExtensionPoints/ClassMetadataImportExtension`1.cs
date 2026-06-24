// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ClassMetadataImportExtension`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки ClassMetadata при импорте конфигурации
  /// </summary>
  /// <typeparam name="T">Тип метаданных</typeparam>
  public abstract class ClassMetadataImportExtension<T> : ClassMetadataImportExtension<T, T> where T : ClassMetadata
  {
    internal static object sS7ciLElGka1fKQpS8Uc;

    protected ClassMetadataImportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KRf1QZElEBjIAqCl6Okr() => ClassMetadataImportExtension<T>.sS7ciLElGka1fKQpS8Uc == null;

    internal static object NtTxJVElfSpN3TihYkfX() => ClassMetadataImportExtension<T>.sS7ciLElGka1fKQpS8Uc;
  }
}
