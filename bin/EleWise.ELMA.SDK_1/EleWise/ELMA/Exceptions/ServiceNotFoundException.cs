// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ServiceNotFoundException
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
  /// <summary>
  /// Ошибка возникает, когда запрашиваемая служба не найдена
  /// </summary>
  [Serializable]
  public class ServiceNotFoundException : Exception
  {
    internal static ServiceNotFoundException utOGwVGjds98atBRLIeS;

    public ServiceNotFoundException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(ServiceNotFoundException.ServiceNotFound);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ServiceNotFoundException(string serviceName)
    {
      ServiceNotFoundException.VTbj4AGjgdLtTMpypUaa();
      // ISSUE: explicit constructor call
      this.\u002Ector(serviceName, (string) ServiceNotFoundException.Hs9qG4Gj5JbAhR0wtwTd((object) ServiceNotFoundException.NamedServiceNotFound, (object) serviceName));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ServiceNotFoundException(Type serviceType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(serviceType.FullName, (string) ServiceNotFoundException.Hs9qG4Gj5JbAhR0wtwTd(ServiceNotFoundException.Yq9QVHGjjbxrseXfF0Be(), (object) serviceType.FullName));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ServiceNotFoundException(string serviceName, string message)
    {
      ServiceNotFoundException.VTbj4AGjgdLtTMpypUaa();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected ServiceNotFoundException(SerializationInfo info, StreamingContext context)
    {
      ServiceNotFoundException.VTbj4AGjgdLtTMpypUaa();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected static string NamedServiceNotFound => EleWise.ELMA.SR.T((string) ServiceNotFoundException.oeDNuLGjYE74xyQKs0vH(272623989 ^ 272364281));

    protected static string ServiceNotFound => EleWise.ELMA.SR.T((string) ServiceNotFoundException.oeDNuLGjYE74xyQKs0vH(-2092274397 << 4 ^ 883083662));

    internal static bool C6UfXmGjl0THXDg3m8e5() => ServiceNotFoundException.utOGwVGjds98atBRLIeS == null;

    internal static ServiceNotFoundException eVvdwFGjrlKpnbO0qafN() => ServiceNotFoundException.utOGwVGjds98atBRLIeS;

    internal static void VTbj4AGjgdLtTMpypUaa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Hs9qG4Gj5JbAhR0wtwTd([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object Yq9QVHGjjbxrseXfF0Be() => (object) ServiceNotFoundException.NamedServiceNotFound;

    internal static object oeDNuLGjYE74xyQKs0vH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
