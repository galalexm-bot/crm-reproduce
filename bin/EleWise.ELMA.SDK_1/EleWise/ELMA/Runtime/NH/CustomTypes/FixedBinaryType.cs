// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.FixedBinaryType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.SqlTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>BinaryType.</summary>
  [Serializable]
  public class FixedBinaryType : FixedAbstractBinaryType
  {
    internal static FixedBinaryType C1eXjGWm8eahCxJXM7M8;

    internal FixedBinaryType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(new BinarySqlType());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal FixedBinaryType(BinarySqlType sqlType)
    {
      FixedBinaryType.ObFl1UWmIZPc511eRJcC();
      // ISSUE: explicit constructor call
      base.\u002Ector(sqlType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override Type ReturnedClass => FixedBinaryType.mXNKPnWmVXkpGe0oAkAy(__typeref (byte[]));

    public override string Name => (string) FixedBinaryType.Nlhh6yWmSLIdT9fSgAsB(-882126494 ^ -882246764);

    protected internal override object ToExternalFormat(byte[] bytes) => (object) bytes;

    protected internal override byte[] ToInternalFormat(object bytes) => (byte[]) bytes;

    public override int Compare(object x, object y) => 0;

    internal static bool haio6CWmZFTpYAYH0kOo() => FixedBinaryType.C1eXjGWm8eahCxJXM7M8 == null;

    internal static FixedBinaryType rLabywWmuBXoWEijNUXm() => FixedBinaryType.C1eXjGWm8eahCxJXM7M8;

    internal static void ObFl1UWmIZPc511eRJcC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type mXNKPnWmVXkpGe0oAkAy([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Nlhh6yWmSLIdT9fSgAsB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
