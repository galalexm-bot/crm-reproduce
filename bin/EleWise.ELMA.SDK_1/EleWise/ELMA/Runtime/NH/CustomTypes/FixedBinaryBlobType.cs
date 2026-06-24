// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.FixedBinaryBlobType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  [Serializable]
  public class FixedBinaryBlobType : FixedBinaryType
  {
    private static FixedBinaryBlobType omopddWmffda4PVmkoFi;

    internal FixedBinaryBlobType()
    {
      FixedBinaryBlobType.gpvpqSWmvp6dcCmyTxH4();
      // ISSUE: explicit constructor call
      base.\u002Ector((BinarySqlType) new BinaryBlobSqlType());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal FixedBinaryBlobType(BinarySqlType sqlType)
    {
      FixedBinaryBlobType.gpvpqSWmvp6dcCmyTxH4();
      // ISSUE: explicit constructor call
      base.\u002Ector(sqlType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public static void RegisterInTypeFactory()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            BinaryBlobType binaryBlob1 = NHibernateUtil.BinaryBlob;
            string[] aliases = new string[0];
            // ISSUE: reference to a compiler-generated field
            Func<int, NullableType> func1 = FixedBinaryBlobType.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<int, NullableType> ctorLength;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              FixedBinaryBlobType.\u003C\u003Ec.\u003C\u003E9__2_0 = ctorLength = (Func<int, NullableType>) (l =>
              {
                BinaryBlobType binaryBlob2 = NHibernateUtil.BinaryBlob;
                int length = l;
                // ISSUE: reference to a compiler-generated field
                Func<int, NullableType> func2 = FixedBinaryBlobType.\u003C\u003Ec.\u003C\u003E9__2_1;
                Func<int, NullableType> ctorDelegate;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  FixedBinaryBlobType.\u003C\u003Ec.\u003C\u003E9__2_1 = ctorDelegate = (Func<int, NullableType>) (len => (NullableType) new FixedBinaryBlobType((BinarySqlType) FixedBinaryBlobType.\u003C\u003Ec.S6kAy8QYakDYneUIKkB6(len)));
                }
                else
                  goto label_1;
label_3:
                return TypeFactoryExtensions.GetType((NullableType) binaryBlob2, length, ctorDelegate);
label_1:
                ctorDelegate = func2;
                goto label_3;
              });
            }
            else
              goto label_7;
label_6:
            TypeFactoryExtensions.ReRegisterType((IType) binaryBlob1, (IEnumerable<string>) aliases, ctorLength);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
label_7:
            ctorLength = func1;
            goto label_6;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <summary></summary>
    public override string Name => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138281818);

    internal static void gpvpqSWmvp6dcCmyTxH4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Mp2KJeWmQPO56vG5mTCi() => FixedBinaryBlobType.omopddWmffda4PVmkoFi == null;

    internal static FixedBinaryBlobType BWobynWmCi4sZoVFZuts() => FixedBinaryBlobType.omopddWmffda4PVmkoFi;
  }
}
