// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile.FetchBinaryFileSuccessDelegateBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile
{
  /// <summary>
  /// Билдер делегата обратного вызова при успешном завершении фоновой операции "Получить BinaryFile".
  /// </summary>
  /// <typeparam name="TContext">Тип контекста процесса.</typeparam>
  public class FetchBinaryFileSuccessDelegateBuilder<TContext> : 
    DelegateWithArgumentBuilder<TContext, BinaryFile>
  {
    internal static object shfTxCWzGoHB2fsRreTr;

    /// <summary>Ctor</summary>
    /// <param name="callbackDelegate">Объект делегата обратного вызова, над которым будет произведена конфигурация этим билдером.</param>
    internal FetchBinaryFileSuccessDelegateBuilder(ICallbackDelegate callbackDelegate)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callbackDelegate);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JM02btWzEjxXSg0oMxOu() => FetchBinaryFileSuccessDelegateBuilder<TContext>.shfTxCWzGoHB2fsRreTr == null;

    internal static object sjCOZaWzfojLpeLhWkoh() => FetchBinaryFileSuccessDelegateBuilder<TContext>.shfTxCWzGoHB2fsRreTr;
  }
}
