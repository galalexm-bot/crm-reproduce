// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.VariableNotFoundException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>
  /// Исключение, когда не найдена переменная в хранилище, или для нее не задано значение
  /// </summary>
  [Serializable]
  public class VariableNotFoundException : EQLException
  {
    private string variableName;
    private static VariableNotFoundException N66CDkGjNE8geQhoEkpl;

    /// <summary>Конструктор</summary>
    public VariableNotFoundException()
    {
      VariableNotFoundException.Q7ApCHGjaqpMvovCNBu6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="variableName">Имя переменной</param>
    public VariableNotFoundException(string variableName)
    {
      VariableNotFoundException.Q7ApCHGjaqpMvovCNBu6();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) null, EleWise.ELMA.SR.T((string) VariableNotFoundException.lq8JsWGjDSn6oIeOPvuT(333888594 ^ 1075625116 ^ 1409161760), (object) variableName));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.variableName = variableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя переменной</summary>
    public string VariableName => this.variableName;

    internal static void Q7ApCHGjaqpMvovCNBu6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JAbnXQGj3FmOcpGVtRw2() => VariableNotFoundException.N66CDkGjNE8geQhoEkpl == null;

    internal static VariableNotFoundException VPhYicGjpdcvdBCASySS() => VariableNotFoundException.N66CDkGjNE8geQhoEkpl;

    internal static object lq8JsWGjDSn6oIeOPvuT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
