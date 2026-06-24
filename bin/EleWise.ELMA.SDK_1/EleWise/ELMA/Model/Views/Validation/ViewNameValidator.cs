// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Validation.ViewNameValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files.DTO.Managers;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views.Validation
{
  public static class ViewNameValidator
  {
    private static bool _isRazorEditing;
    private static ViewNameValidator UCoIsDoD7LH6IsANVkCQ;

    public static string ValidateViewName(string viewNamePrefix, string viewName, bool isProperty = false) => (string) ViewNameValidator.oqasXfoDml3XS4cln3RU((object) viewNamePrefix, (object) viewName, isProperty, (object) Locator.GetService<IWebApplicationDTOManager>());

    public static string ValidateViewName(
      string viewNamePrefix,
      string viewName,
      bool isProperty,
      IWebApplicationDTOManager webApplicationDTOManager)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
              goto label_13;
            case 2:
              if (ViewNameValidator.spKhxZoDJHoBIvUwCkLK((object) webApplicationDTOManager, (object) viewName, isProperty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 3:
              if (webApplicationDTOManager == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                continue;
              }
              goto case 2;
            case 4:
              goto label_17;
            case 5:
              goto label_9;
            case 6:
              if (ViewNameValidator.sq1frUoDygus0XWBX9C3((object) viewName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 5 : 2;
                continue;
              }
              if (ViewNameValidator._isRazorEditing)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 4;
                continue;
              }
              if (!ViewNameValidator.yd9ilToDMhfn0rjU10ga((object) viewName, (object) viewNamePrefix))
              {
                num2 = 8;
                continue;
              }
              goto case 3;
            case 7:
              goto label_7;
            case 9:
              goto label_8;
            default:
              goto label_12;
          }
        }
label_13:
        if (!ViewNameValidator.yd9ilToDMhfn0rjU10ga((object) viewName, (object) viewNamePrefix))
          num1 = 9;
        else
          break;
      }
label_7:
      return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957698322));
label_8:
      return (string) ViewNameValidator.L51MZKoDdEyI1HY5khti(ViewNameValidator.VJhHsdoD9JVE0Xf7oPFD(~538519529 ^ -538659556));
label_9:
      return (string) null;
label_12:
      return (string) null;
label_17:
      return (string) null;
    }

    public static void IsRazorEditing(bool isRazorEditing) => ViewNameValidator._isRazorEditing = isRazorEditing;

    internal static object oqasXfoDml3XS4cln3RU(
      [In] object obj0,
      [In] object obj1,
      bool isProperty,
      [In] object obj3)
    {
      return (object) ViewNameValidator.ValidateViewName((string) obj0, (string) obj1, isProperty, (IWebApplicationDTOManager) obj3);
    }

    internal static bool zBoSKwoDxIlqwfmFsxxU() => ViewNameValidator.UCoIsDoD7LH6IsANVkCQ == null;

    internal static ViewNameValidator QuRcn4oD0anQIFZP6gtZ() => ViewNameValidator.UCoIsDoD7LH6IsANVkCQ;

    internal static bool sq1frUoDygus0XWBX9C3([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool yd9ilToDMhfn0rjU10ga([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool spKhxZoDJHoBIvUwCkLK([In] object obj0, [In] object obj1, bool isProperty) => ((IWebApplicationDTOManager) obj0).CheckViewExists((string) obj1, isProperty);

    internal static object VJhHsdoD9JVE0Xf7oPFD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L51MZKoDdEyI1HY5khti([In] object obj0) => (object) SR.T((string) obj0);
  }
}
