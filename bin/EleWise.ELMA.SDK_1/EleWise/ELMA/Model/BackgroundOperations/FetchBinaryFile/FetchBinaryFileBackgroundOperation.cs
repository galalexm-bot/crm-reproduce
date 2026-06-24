// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile.FetchBinaryFileBackgroundOperation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile
{
  /// <summary>
  /// Класс-держатель информации по запуску фоновой операции "Получить BinaryFile".
  /// </summary>
  [Serializable]
  internal class FetchBinaryFileBackgroundOperation : BaseBackgroundOperationWithCallbacks
  {
    private static FetchBinaryFileBackgroundOperation bo4UFCWcsRUuoTuIiWDK;

    /// <summary>Ключ для выборки BinaryFile (Id или Uid строкой).</summary>
    public string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

    public FetchBinaryFileBackgroundOperation()
    {
      FetchBinaryFileBackgroundOperation.Fuky0dWzFOnrfgB18sHF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tJ8WabWcccVxZEar2kVH() => FetchBinaryFileBackgroundOperation.bo4UFCWcsRUuoTuIiWDK == null;

    internal static FetchBinaryFileBackgroundOperation Iw971OWczL07YPbG7Dgr() => FetchBinaryFileBackgroundOperation.bo4UFCWcsRUuoTuIiWDK;

    internal static void Fuky0dWzFOnrfgB18sHF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
