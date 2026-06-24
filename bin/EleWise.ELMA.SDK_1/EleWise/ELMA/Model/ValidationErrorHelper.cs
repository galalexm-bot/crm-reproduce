// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.ValidationErrorHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model
{
  /// <summary>Хелпер для работы с ошибками валидации</summary>
  public static class ValidationErrorHelper
  {
    private static ValidationErrorHelper mBvmyvWg4578VyvswZQh;

    /// <summary>Получить общее сообщение об ошибках валидации</summary>
    /// <param name="validationErrors">Ошибки валидации</param>
    /// <returns>Сообщение</returns>
    public static string GetMessage(params ValidationError[] validationErrors)
    {
      int num = 1;
      ValidationError[] validationErrorArray;
      int index;
      StringBuilder builder;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (validationErrors != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_9;
          case 3:
          case 4:
            if (index < validationErrorArray.Length)
            {
              num = 10;
              continue;
            }
            goto label_9;
          case 5:
            validationErrorArray = validationErrors;
            num = 9;
            continue;
          case 6:
            ++index;
            num = 3;
            continue;
          case 7:
            goto label_7;
          case 8:
          case 10:
            ValidationErrorHelper.GetMessage((object) validationErrorArray[index], (object) builder);
            num = 6;
            continue;
          case 9:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 0;
            continue;
          default:
            builder = new StringBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 5 : 4;
            continue;
        }
      }
label_7:
      return string.Empty;
label_9:
      return builder.ToString();
    }

    private static void GetMessage(object validationError, object builder)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        int index;
        ValidationError[] validationErrorArray;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_5;
            case 1:
              if (!ValidationErrorHelper.zYxI2eWg0n1lZW2O9EFO(ValidationErrorHelper.lILlcwWgxPj8LCJt0ypG(validationError), Guid.Empty))
              {
                num2 = 2;
                continue;
              }
              goto label_11;
            case 2:
            case 8:
              if (ValidationErrorHelper.zYxI2eWg0n1lZW2O9EFO(ValidationErrorHelper.lILlcwWgxPj8LCJt0ypG(validationError), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 10;
                continue;
              }
              goto case 9;
            case 3:
            case 15:
              ValidationErrorHelper.X3oVVOWgrOQbCfBSJ0Wm((object) validationErrorArray[index], builder);
              num2 = 4;
              continue;
            case 4:
              ++index;
              num2 = 12;
              continue;
            case 5:
              goto label_11;
            case 6:
              goto label_12;
            case 7:
              if (ValidationErrorHelper.q8waa3WgAxPJ2DoKfCme((object) ((ValidationError) validationError).Message))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 6 : 4;
                continue;
              }
              ((StringBuilder) builder).AppendLine((string) ValidationErrorHelper.rEwEKvWg7MB9dbnN4nUW(validationError));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 1;
              continue;
            case 9:
              if (ValidationErrorHelper.UPnxSHWgl6L3lDugdZLg(validationError) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 9 : 13;
                continue;
              }
              goto label_9;
            case 10:
              ValidationErrorHelper.buv5QhWgM7ono1Op9ygE(builder, ValidationErrorHelper.oE7P5ZWgduERdFA8cq4E(ValidationErrorHelper.JtuFolWgJimRWLp0Ou1s(322893104 - -1992822529 ^ -1979368903), (object) ValidationErrorHelper.JsOWPiWg92jcrf8SWuYr(validationError)));
              num2 = 9;
              continue;
            case 11:
              index = 0;
              num2 = 16;
              continue;
            case 12:
            case 16:
              if (index < validationErrorArray.Length)
              {
                num2 = 3;
                continue;
              }
              goto label_19;
            case 13:
              goto label_13;
            case 14:
              goto label_24;
            default:
              goto label_8;
          }
        }
label_11:
        ValidationErrorHelper.buv5QhWgM7ono1Op9ygE(builder, ValidationErrorHelper.uwUfxEWgy74XOFX49Y9m((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909299339), ValidationErrorHelper.iYbC5bWgm9alL8GiwHt8(ValidationErrorHelper.lILlcwWgxPj8LCJt0ypG(validationError))));
        num1 = 8;
        continue;
label_13:
        validationErrorArray = (ValidationError[]) ValidationErrorHelper.UPnxSHWgl6L3lDugdZLg(validationError);
        num1 = 11;
      }
label_5:
      return;
label_12:
      return;
label_24:
      return;
label_8:
      return;
label_19:
      return;
label_9:;
    }

    private static string GetElementTypeDisplayName(Guid elementTypeUid)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            goto label_5;
          case 3:
            goto label_10;
          case 4:
            if (elementTypeUid == ValidationElementType.ComponentViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 3;
              continue;
            }
            if (!ValidationErrorHelper.bPHoLTWgg7PUPVQ0rom6(elementTypeUid, ValidationElementType.ObjectFormViewItem))
            {
              if (!ValidationErrorHelper.bPHoLTWgg7PUPVQ0rom6(elementTypeUid, ValidationElementType.Property))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            }
            else
            {
              num = 6;
              continue;
            }
          case 5:
            goto label_14;
          case 6:
            goto label_2;
          default:
            if (!ValidationErrorHelper.bPHoLTWgg7PUPVQ0rom6(elementTypeUid, ValidationElementType.ViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 5 : 5;
              continue;
            }
            goto label_13;
        }
      }
label_2:
      return (string) ValidationErrorHelper.JtuFolWgJimRWLp0Ou1s(-1886646897 ^ -1886506043);
label_5:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77814397);
label_10:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767864353);
label_13:
      return (string) ValidationErrorHelper.JtuFolWgJimRWLp0Ou1s(~-397266137 ^ 397406814);
label_14:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515079091);
    }

    internal static bool D3uEpiWg6qgGbwDNvRyg() => ValidationErrorHelper.mBvmyvWg4578VyvswZQh == null;

    internal static ValidationErrorHelper VBlZPVWgHFhe8ZJOCqFI() => ValidationErrorHelper.mBvmyvWg4578VyvswZQh;

    internal static bool q8waa3WgAxPJ2DoKfCme([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object rEwEKvWg7MB9dbnN4nUW([In] object obj0) => (object) ((ValidationError) obj0).Message;

    internal static Guid lILlcwWgxPj8LCJt0ypG([In] object obj0) => ((ValidationError) obj0).ElementTypeUid;

    internal static bool zYxI2eWg0n1lZW2O9EFO([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object iYbC5bWgm9alL8GiwHt8(Guid elementTypeUid) => (object) ValidationErrorHelper.GetElementTypeDisplayName(elementTypeUid);

    internal static object uwUfxEWgy74XOFX49Y9m([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object buv5QhWgM7ono1Op9ygE([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object JtuFolWgJimRWLp0Ou1s(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid JsOWPiWg92jcrf8SWuYr([In] object obj0) => ((ValidationError) obj0).ElementUid;

    internal static object oE7P5ZWgduERdFA8cq4E([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object UPnxSHWgl6L3lDugdZLg([In] object obj0) => (object) ((ValidationError) obj0).InnerErrors;

    internal static void X3oVVOWgrOQbCfBSJ0Wm([In] object obj0, [In] object obj1) => ValidationErrorHelper.GetMessage(obj0, obj1);

    internal static bool bPHoLTWgg7PUPVQ0rom6([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
