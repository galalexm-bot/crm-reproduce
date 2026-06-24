// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.TypeNotFoundException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>
  /// Ошибка возникает, когда не найден какой-либо тип данных
  /// </summary>
  [Serializable]
  public class TypeNotFoundException : Exception
  {
    private Guid typeUid;
    private static TypeNotFoundException tedjEbGjuA7h8xZET4re;

    public TypeNotFoundException()
    {
      TypeNotFoundException.Y9507yGjSbivmCZYNtJf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TypeNotFoundException(Guid typeUid)
    {
      TypeNotFoundException.Y9507yGjSbivmCZYNtJf();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319583540), (object) typeUid));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.typeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public TypeNotFoundException(string typeName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) TypeNotFoundException.e6l3LqGjiZEZoDHvv7TJ(~-122002947 ^ 121734342), (object) typeName));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected TypeNotFoundException(SerializationInfo info, StreamingContext context)
    {
      TypeNotFoundException.Y9507yGjSbivmCZYNtJf();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор типа данных</summary>
    public Guid TypeUid => this.typeUid;

    internal static void Y9507yGjSbivmCZYNtJf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pGDnSlGjIuOcnsN23B6s() => TypeNotFoundException.tedjEbGjuA7h8xZET4re == null;

    internal static TypeNotFoundException lPhfBAGjVOLkTpEX9fnJ() => TypeNotFoundException.tedjEbGjuA7h8xZET4re;

    internal static object e6l3LqGjiZEZoDHvv7TJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
