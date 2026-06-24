// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbStructureException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Исключение при обновлении структуры БД</summary>
  [Serializable]
  public class DbStructureException : Exception
  {
    internal static DbStructureException VHuOwcWIycm7JHBy6F3m;

    public DbStructureException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) DbStructureException.bGCHnNWI9981Ay6SEXxh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199861357)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DbStructureException(string message)
    {
      DbStructureException.SufXosWIdS0L2bOTVYMH();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) DbStructureException.bGCHnNWI9981Ay6SEXxh(DbStructureException.Ka45qCWIlwBWhsBcHSjG(-2112703338 ^ -2112657674)) + (string) DbStructureException.Ka45qCWIlwBWhsBcHSjG(1012087039 ^ 1012093099) + message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DbStructureException(Exception innerException)
    {
      DbStructureException.SufXosWIdS0L2bOTVYMH();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137406034)), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DbStructureException(string message, Exception innerException)
    {
      DbStructureException.SufXosWIdS0L2bOTVYMH();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) DbStructureException.bGCHnNWI9981Ay6SEXxh(DbStructureException.Ka45qCWIlwBWhsBcHSjG(-138018305 ^ -137899105)) + (string) DbStructureException.Ka45qCWIlwBWhsBcHSjG(-1876063057 ^ -1876040453) + message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected DbStructureException(SerializationInfo info, StreamingContext context)
    {
      DbStructureException.SufXosWIdS0L2bOTVYMH();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object bGCHnNWI9981Ay6SEXxh([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool O8IIp6WIM2PucYCyhsla() => DbStructureException.VHuOwcWIycm7JHBy6F3m == null;

    internal static DbStructureException DMsKsOWIJXdVMme8y4u6() => DbStructureException.VHuOwcWIycm7JHBy6F3m;

    internal static void SufXosWIdS0L2bOTVYMH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Ka45qCWIlwBWhsBcHSjG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
