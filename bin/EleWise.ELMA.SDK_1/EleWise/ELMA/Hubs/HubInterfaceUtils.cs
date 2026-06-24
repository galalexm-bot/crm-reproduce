// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.HubInterfaceUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Hubs
{
  /// <summary>Вспомогательный класс для работы с интерфейсами хабов</summary>
  internal static class HubInterfaceUtils
  {
    internal static HubInterfaceUtils VNCcNghgHvet8vWl34sx;

    /// <summary>
    /// Определяет, является ли указанный интерфейс интерфейсом Хаба
    /// </summary>
    /// <param name="type">Тип интерфейса</param>
    /// <returns><c>true</c> если является</returns>
    public static bool IsHubInterface(Type type)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (HubInterfaceUtils.KL7Qethg01SsjXYnq3xa(type.GetInterface((string) HubInterfaceUtils.DlJLbdhgxr42rKrNRXCj()), (Type) null))
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 3:
            if (!type.IsInterface)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            if (type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 5:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return HubInterfaceUtils.KL7Qethg01SsjXYnq3xa(type, TypeOf<IHub>.Raw);
label_7:
      return false;
    }

    internal static object DlJLbdhgxr42rKrNRXCj() => (object) TypeOf<IHub>.FullName;

    internal static bool KL7Qethg01SsjXYnq3xa([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool tblbqUhgAYlnPqpaWhVS() => HubInterfaceUtils.VNCcNghgHvet8vWl34sx == null;

    internal static HubInterfaceUtils EhTERGhg7xGf43LjTSmv() => HubInterfaceUtils.VNCcNghgHvet8vWl34sx;
  }
}
