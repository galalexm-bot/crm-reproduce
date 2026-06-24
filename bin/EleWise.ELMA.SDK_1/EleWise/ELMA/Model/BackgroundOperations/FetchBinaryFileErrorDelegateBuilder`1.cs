// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFileErrorDelegateBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.BackgroundOperations
{
  /// <summary>
  /// Билдер делегата обратного вызова при неудачном завершении фоновой операции "Получить BinaryFile".
  /// </summary>
  /// <typeparam name="TContext">Тип контекста процесса.</typeparam>
  public class FetchBinaryFileErrorDelegateBuilder<TContext> : 
    DelegateWithArgumentBuilder<TContext, Exception>
  {
    internal static object A1f5QZWcAjtpg14E96eK;

    /// <summary>Ctor</summary>
    /// <param name="callbackDelegate">Объект делегата обратного вызова, над которым будет произведена конфигурация этим билдером.</param>
    internal FetchBinaryFileErrorDelegateBuilder(ICallbackDelegate callbackDelegate)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callbackDelegate);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool eRL7G2Wc7OALi6WcWerK() => FetchBinaryFileErrorDelegateBuilder<TContext>.A1f5QZWcAjtpg14E96eK == null;

    internal static object n6TUfRWcxD4obcM5wZbY() => FetchBinaryFileErrorDelegateBuilder<TContext>.A1f5QZWcAjtpg14E96eK;
  }
}
