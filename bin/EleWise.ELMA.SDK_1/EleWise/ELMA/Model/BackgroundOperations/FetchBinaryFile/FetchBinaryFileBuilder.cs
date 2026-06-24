// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile.FetchBinaryFileBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile
{
  /// <summary>
  /// Основной билдер фоновой операции "Получить BinaryFile".
  /// </summary>
  public class FetchBinaryFileBuilder : ICreatingBuilder
  {
    private FetchBinaryFileBackgroundOperation operation;
    internal static FetchBinaryFileBuilder atp4ybWzBhfhyki5yqro;

    /// <summary>Ctor</summary>
    /// <param name="key">Ключ BinaryFile</param>
    public FetchBinaryFileBuilder(string key)
    {
      FetchBinaryFileBuilder.sJyvomWzbyOeQYNGTj5Z();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            FetchBinaryFileBackgroundOperation backgroundOperation = new FetchBinaryFileBackgroundOperation();
            FetchBinaryFileBuilder.bLhofiWzh0ZZEmv8HEap((object) backgroundOperation, (object) key);
            this.operation = backgroundOperation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать объект фоновой операции.</summary>
    /// <returns>Объект фоновой операции.</returns>
    public IBackgroundOperation Create() => (IBackgroundOperation) this.operation;

    /// <summary>
    /// Установить делегаты продолжения после выполнения фоновой операции.
    /// </summary>
    /// <typeparam name="TContext">Тип контекста процесса.</typeparam>
    /// <param name="onSuccess">Билдер делегата успешного завершения операции.</param>
    /// <param name="onError">Билдер делегата неудачного завершения операции.</param>
    /// <returns>Билдер фоновой операции.</returns>
    public ICreatingBuilder WhenCompleted<TContext>(
      Action<FetchBinaryFileSuccessDelegateBuilder<TContext>> onSuccess,
      Action<FetchBinaryFileErrorDelegateBuilder<TContext>> onError)
    {
      FetchBinaryFileSuccessDelegateBuilder<TContext> successDelegateBuilder = new FetchBinaryFileSuccessDelegateBuilder<TContext>(this.operation.SuccessCallback);
      FetchBinaryFileErrorDelegateBuilder<TContext> errorDelegateBuilder = new FetchBinaryFileErrorDelegateBuilder<TContext>(this.operation.ErrorCallback);
      onSuccess(successDelegateBuilder);
      onError(errorDelegateBuilder);
      return (ICreatingBuilder) this;
    }

    internal static void sJyvomWzbyOeQYNGTj5Z() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void bLhofiWzh0ZZEmv8HEap([In] object obj0, [In] object obj1) => ((FetchBinaryFileBackgroundOperation) obj0).Key = (string) obj1;

    internal static bool Oo1hVQWzWtt4HakUY8iu() => FetchBinaryFileBuilder.atp4ybWzBhfhyki5yqro == null;

    internal static FetchBinaryFileBuilder GpyTJcWzotgjxOBgTv3T() => FetchBinaryFileBuilder.atp4ybWzBhfhyki5yqro;
  }
}
