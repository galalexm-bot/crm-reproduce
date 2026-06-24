// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ObtainObjectLockException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка при попытке получения блокировки</summary>
  [Serializable]
  public class ObtainObjectLockException : Exception
  {
    private static ObtainObjectLockException o1eA4NG5KuvDT7jpyx3s;

    public ObtainObjectLockException()
    {
      ObtainObjectLockException.NhPUdGG5kyNruBhXi5nF();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) ObtainObjectLockException.CNTGecG5Oc0kNqBNSZFi(ObtainObjectLockException.woiduyG5nd96UpMXhNLk(1461825605 - 1531863589 ^ -69773794)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ObtainObjectLockException(string typeName, object id)
    {
      ObtainObjectLockException.NhPUdGG5kyNruBhXi5nF();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ObtainObjectLockException.woiduyG5nd96UpMXhNLk(236071375 ^ 236335425), (object) typeName, id));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ObtainObjectLockException(string typeName, object id, Exception innerException)
    {
      ObtainObjectLockException.NhPUdGG5kyNruBhXi5nF();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516574084), (object) typeName, id), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected ObtainObjectLockException(SerializationInfo info, StreamingContext context)
    {
      ObtainObjectLockException.NhPUdGG5kyNruBhXi5nF();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void NhPUdGG5kyNruBhXi5nF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object woiduyG5nd96UpMXhNLk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CNTGecG5Oc0kNqBNSZFi([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool qaBgFrG5XAbeNxtbOt8p() => ObtainObjectLockException.o1eA4NG5KuvDT7jpyx3s == null;

    internal static ObtainObjectLockException sw1mtaG5TjWlfwQpCl4E() => ObtainObjectLockException.o1eA4NG5KuvDT7jpyx3s;
  }
}
