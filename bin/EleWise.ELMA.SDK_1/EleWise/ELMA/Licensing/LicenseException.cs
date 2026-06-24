// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.LicenseException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Licensing
{
  /// <summary>Вызывается при ошибке лицензирования</summary>
  [Serializable]
  public class LicenseException : Exception
  {
    private static LicenseException Jjdp24A5P5B84EX64CV;

    public LicenseException()
    {
      LicenseException.XbZT90ALcp4m32Ef0gJ();
      // ISSUE: explicit constructor call
      this.\u002Ector((string) LicenseException.D3vqKWAswVBMZbOpa77(LicenseException.hH5FxlAUjqfmKNb99jX(654297945 ^ 654266953)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public LicenseException(string message)
    {
      LicenseException.XbZT90ALcp4m32Ef0gJ();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected LicenseException(SerializationInfo info, StreamingContext context)
    {
      LicenseException.XbZT90ALcp4m32Ef0gJ();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void XbZT90ALcp4m32Ef0gJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object hH5FxlAUjqfmKNb99jX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object D3vqKWAswVBMZbOpa77([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool eMCYgnAjbdeSawsRHIa() => LicenseException.Jjdp24A5P5B84EX64CV == null;

    internal static LicenseException QiZFacAY6ahm7rNE91s() => LicenseException.Jjdp24A5P5B84EX64CV;
  }
}
