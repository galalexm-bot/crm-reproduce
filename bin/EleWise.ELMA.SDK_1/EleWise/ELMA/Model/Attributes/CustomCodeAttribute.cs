// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CustomCodeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут указывает кастомный код для класса</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class CustomCodeAttribute : Attribute
  {
    private Type typeOfAssembly;
    private string resourceName;
    internal static CustomCodeAttribute UDrO52ov5HIPP72dJSUr;

    /// <summary>Ctor</summary>
    /// <param name="typeOfAssembly">Тип из сборки, где находится ресурс с кастомным кодом</param>
    /// <param name="resourceName">Имя ресурса</param>
    public CustomCodeAttribute(Type typeOfAssembly, string resourceName)
    {
      CustomCodeAttribute.v2dC0QovLcnDsTrbmKtK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.typeOfAssembly = typeOfAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          default:
            this.resourceName = resourceName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить код</summary>
    /// <returns>Данные иконки</returns>
    public string GetCode()
    {
      int num1 = 1;
      Stream stream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            stream = (Stream) CustomCodeAttribute.ehvbY2ovUwuBPkylTLPd((object) this.typeOfAssembly.Assembly, (object) this.resourceName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      string code;
      return code;
label_4:
      try
      {
        int num2;
        if (stream != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
        else
          goto label_8;
label_7:
        MemoryStream memoryStream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_8;
            case 4:
              goto label_11;
            default:
              memoryStream = (MemoryStream) CustomCodeAttribute.Rr0ImMovsK44dqyslDuU((int) stream.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 4;
              continue;
          }
        }
label_11:
        try
        {
          CustomCodeAttribute.mQJDtWovcQGA3KhAb4jL((object) stream, (object) memoryStream);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_3;
              default:
                code = memoryStream.AsString((Encoding) CustomCodeAttribute.iHGlsTovzFTlNrKZsY5o());
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
                continue;
            }
          }
        }
        finally
        {
          if (memoryStream != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_20;
                default:
                  CustomCodeAttribute.BLJ8Ffo8FQ1PxgsruJDZ((object) memoryStream);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_20:;
        }
label_8:
        code = (string) null;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        {
          num2 = 1;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        if (stream != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                CustomCodeAttribute.BLJ8Ffo8FQ1PxgsruJDZ((object) stream);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
    }

    internal static void v2dC0QovLcnDsTrbmKtK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool D1ys1WovjPPaWu75Z5vH() => CustomCodeAttribute.UDrO52ov5HIPP72dJSUr == null;

    internal static CustomCodeAttribute WN2fKuovYu6OPUK8aUHD() => CustomCodeAttribute.UDrO52ov5HIPP72dJSUr;

    internal static object ehvbY2ovUwuBPkylTLPd([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetReflectionManifestResourceStream((string) obj1);

    internal static object Rr0ImMovsK44dqyslDuU(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static void mQJDtWovcQGA3KhAb4jL([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static object iHGlsTovzFTlNrKZsY5o() => (object) Encoding.UTF8;

    internal static void BLJ8Ffo8FQ1PxgsruJDZ([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
