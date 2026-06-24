// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ObtainLockException
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
  public class ObtainLockException : Exception
  {
    internal static ObtainLockException cMKsALG5ITAsLCivOWnf;

    public ObtainLockException()
    {
      ObtainLockException.EHVYlCG5i3BtWuA64XGP();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) ObtainLockException.nJJXbxG5que3VS77kRrC(ObtainLockException.bdc1JaG5RhgO5XGc7kpC(~1767720452 ^ -1767461285)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ObtainLockException(string lockName)
    {
      ObtainLockException.EHVYlCG5i3BtWuA64XGP();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ObtainLockException.bdc1JaG5RhgO5XGc7kpC(-1939377524 ^ -1939643028), (object) lockName));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ObtainLockException(string lockName, Exception innerException)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) ObtainLockException.bdc1JaG5RhgO5XGc7kpC(-1146510045 ^ -1146244413), (object) lockName), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected ObtainLockException(SerializationInfo info, StreamingContext context)
    {
      ObtainLockException.EHVYlCG5i3BtWuA64XGP();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void EHVYlCG5i3BtWuA64XGP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object bdc1JaG5RhgO5XGc7kpC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nJJXbxG5que3VS77kRrC([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool JOu0PFG5Vw7KdqEjUhin() => ObtainLockException.cMKsALG5ITAsLCivOWnf == null;

    internal static ObtainLockException qt0ycFG5SaBfVEJZC2h9() => ObtainLockException.cMKsALG5ITAsLCivOWnf;
  }
}
