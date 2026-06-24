// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RegularExpressionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  /// <summary>Валидация строки по регулярному выражению</summary>
  public class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.RegularExpressionAttribute
  {
    private static RegularExpressionAttribute QUAB9sogl8ZbuDjDZqZa;

    public RegularExpressionAttribute(string pattern)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(pattern);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ErrorMessage = (string) RegularExpressionAttribute.bYdycDogjvaKMfeaFadf(RegularExpressionAttribute.ojdDg2og5I3NnIQKfTLa(~1767720452 ^ -1767729073));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public RegularExpressionAttribute(string pattern, Type staticResourceType, string propertyName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(pattern);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ErrorMessageResourceType = staticResourceType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            RegularExpressionAttribute.Up8eNdogYrqyIIEkHcS6((object) this, (object) propertyName);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public RegularExpressionAttribute(string pattern, string message)
    {
      RegularExpressionAttribute.pMojkfogLVkTWZnX23Uh();
      // ISSUE: explicit constructor call
      base.\u002Ector(pattern);
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            RegularExpressionAttribute.g4aH0KogUdI7W803Vabi((object) this, (object) message);
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (!string.IsNullOrEmpty(message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 2;
              continue;
            }
            break;
        }
        message = (string) RegularExpressionAttribute.bYdycDogjvaKMfeaFadf(RegularExpressionAttribute.ojdDg2og5I3NnIQKfTLa(-16752921 ^ -16744621));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
      }
label_2:;
    }

    internal static object ojdDg2og5I3NnIQKfTLa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object bYdycDogjvaKMfeaFadf([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool vb51CoogrZIxV6jYxILb() => RegularExpressionAttribute.QUAB9sogl8ZbuDjDZqZa == null;

    internal static RegularExpressionAttribute maMYbuogglVrJ8L56yPy() => RegularExpressionAttribute.QUAB9sogl8ZbuDjDZqZa;

    internal static void Up8eNdogYrqyIIEkHcS6([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessageResourceName = (string) obj1;

    internal static void pMojkfogLVkTWZnX23Uh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void g4aH0KogUdI7W803Vabi([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessage = (string) obj1;
  }
}
