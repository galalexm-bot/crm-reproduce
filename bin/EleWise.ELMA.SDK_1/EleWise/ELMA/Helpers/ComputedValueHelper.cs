// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ComputedValueHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Хелпер для работы с вычисляемыми значеняими</summary>
  public static class ComputedValueHelper
  {
    internal static ComputedValueHelper rc5aodh51XSdHKcrMRba;

    /// <summary>
    /// Установить имя метода для вычисляемых значений с типом CalculateScript
    /// </summary>
    /// <param name="computedValue">Вычисляемое значение</param>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    public static void SetCalculateScriptMethodName(IComputedValue computedValue, Guid metadataUid)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_2;
          case 3:
            if (!ComputedValueHelper.uryTLFh5ps3MTGcNRrhd((object) computedValue))
            {
              num = 2;
              continue;
            }
            break;
        }
        ComputedValueHelper.g6Kd7kh5tocCvBZVlIVb((object) computedValue, ComputedValueHelper.GIZjG3h5DsHYpvpRr4v1(ComputedValueHelper.Vv1C2Ah5aXhDCNVQrjT3((object) computedValue), metadataUid));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
      }
label_4:
      return;
label_2:;
    }

    /// <summary>
    /// Установлен ли у вычисляемого значения тип CalculateScript
    /// </summary>
    /// <param name="computedValue">Вычисляемое значение</param>
    /// <returns><c>True</c>, если у вычисляемого значения установлен тип CalculateScript</returns>
    internal static bool IsCalculateScript(IComputedValue computedValue)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (computedValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          default:
            if (ComputedValueHelper.ikIGmMh5wsoahfR8jUjR((object) computedValue) == ComputedValueType.CalculateScript)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 0;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return !ComputedValueHelper.wigf2Wh54P2et9Fpu8bg(ComputedValueHelper.Vv1C2Ah5aXhDCNVQrjT3((object) computedValue));
label_7:
      return false;
    }

    /// <summary>Сгенерировать имя метода</summary>
    /// <param name="calculateScript">Вычисляемый код</param>
    /// <param name="metadataUid">Идентификатор метаданных</param>
    /// <returns></returns>
    internal static string GenerateMethodName(string calculateScript, Guid metadataUid)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!string.IsNullOrWhiteSpace(calculateScript))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return string.Empty;
label_3:
      ScriptMethodInfo methodInfo = new ScriptMethodInfo();
      ComputedValueHelper.HdlpGUh5AD7L9rkwKGgF((object) methodInfo, (object) string.Format((string) ComputedValueHelper.F7Gi2Ih56OjvWOfIkNS5(-680446928 - -370807692 ^ -309794996), (object) ((string) ComputedValueHelper.W4sk7nh5HoyvPk8PfOrk((object) calculateScript)).GetDeterministicGuid()));
      methodInfo.CodeType = CodeType.Client;
      methodInfo.MetadataUid = metadataUid;
      return ScriptMethodInfoHelper.Serialize(methodInfo);
    }

    internal static bool uryTLFh5ps3MTGcNRrhd([In] object obj0) => ComputedValueHelper.IsCalculateScript((IComputedValue) obj0);

    internal static object Vv1C2Ah5aXhDCNVQrjT3([In] object obj0) => (object) ((IComputedValue) obj0).CalculateScript;

    internal static object GIZjG3h5DsHYpvpRr4v1([In] object obj0, Guid metadataUid) => (object) ComputedValueHelper.GenerateMethodName((string) obj0, metadataUid);

    internal static void g6Kd7kh5tocCvBZVlIVb([In] object obj0, [In] object obj1) => ((IComputedValue) obj0).MethodName = (string) obj1;

    internal static bool VyCjRJh5NGPX8W1wC9eW() => ComputedValueHelper.rc5aodh51XSdHKcrMRba == null;

    internal static ComputedValueHelper Onip07h53wjdX5Gg642X() => ComputedValueHelper.rc5aodh51XSdHKcrMRba;

    internal static ComputedValueType ikIGmMh5wsoahfR8jUjR([In] object obj0) => ((IComputedValue) obj0).ComputedValueType;

    internal static bool wigf2Wh54P2et9Fpu8bg([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object F7Gi2Ih56OjvWOfIkNS5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object W4sk7nh5HoyvPk8PfOrk([In] object obj0) => (object) ((string) obj0).Trim();

    internal static void HdlpGUh5AD7L9rkwKGgF([In] object obj0, [In] object obj1) => ((ScriptMethodInfo) obj0).Name = (string) obj1;
  }
}
