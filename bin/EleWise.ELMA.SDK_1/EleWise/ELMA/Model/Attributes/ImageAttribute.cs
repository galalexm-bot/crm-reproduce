// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ImageAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут, указывающий иконку</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = true)]
  public class ImageAttribute : Attribute, IImageAttribute
  {
    private Type typeOfAssembly;
    private string resourceName;
    private int size;
    private ImageFormatType format;
    private bool isDefault;
    internal static ImageAttribute RFfrSyo8PeOmhfLa2jBd;

    /// <summary>Ctor</summary>
    /// <param name="typeOfAssembly">Тип из сборки, где находится ресурс с иконкой</param>
    /// <param name="resourceName">Имя ресурса</param>
    /// <param name="size">Размер изображения</param>
    /// <param name="format">Формат изображения</param>
    /// <param name="isDefault">Является ли изображением по умолчанию</param>
    public ImageAttribute(
      Type typeOfAssembly,
      string resourceName,
      int size,
      ImageFormatType format,
      bool isDefault = false)
    {
      ImageAttribute.rioH4go83dRZUc8FUP8V();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.resourceName = resourceName;
            num = 4;
            continue;
          case 3:
            this.isDefault = isDefault;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          case 4:
            this.size = size;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 5:
            this.typeOfAssembly = typeOfAssembly;
            num = 2;
            continue;
          default:
            this.format = format;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить данные иконки</summary>
    /// <returns>Данные иконки</returns>
    public byte[] GetImageData()
    {
      int num1 = 2;
      Stream manifestResourceStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            manifestResourceStream = this.typeOfAssembly.Assembly.GetReflectionManifestResourceStream(this.resourceName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
            continue;
          default:
            goto label_16;
        }
      }
label_3:
      byte[] imageData;
      try
      {
        int num2;
        if (manifestResourceStream == null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
        else
          goto label_7;
label_5:
        byte[] buffer;
        while (true)
        {
          switch (num2)
          {
            case 1:
              imageData = (byte[]) null;
              num2 = 4;
              continue;
            case 2:
              imageData = buffer;
              num2 = 3;
              continue;
            case 3:
            case 4:
              goto label_16;
            case 5:
              goto label_7;
            default:
              manifestResourceStream.Read(buffer, 0, (int) ImageAttribute.xAYPxwo8pLauRWEGr3TK((object) manifestResourceStream));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
              continue;
          }
        }
label_7:
        buffer = new byte[manifestResourceStream.Length];
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num3;
        if (manifestResourceStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
        else
          goto label_14;
label_13:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_14:
        ImageAttribute.T0IXiho8ah8x7B2SYJAT((object) manifestResourceStream);
        num3 = 2;
        goto label_13;
      }
label_16:
      return imageData;
    }

    /// <summary>Размер изображения</summary>
    public int Size => this.size;

    /// <summary>Является ли изображением по умолчанию</summary>
    public bool IsDefault => this.isDefault;

    /// <summary>Формат изображения</summary>
    public ImageFormatType Format => this.format;

    /// <summary>
    /// Создать изображение. После использования необходимо уничтожить.
    /// </summary>
    public Image CreateImage()
    {
      int num1 = 5;
      byte[] imageData;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_16;
          case 2:
            goto label_4;
          case 3:
            memoryStream = (MemoryStream) ImageAttribute.w33aSko8DV1NbbVQxCSr((object) imageData, false);
            num1 = 2;
            continue;
          case 4:
            if (imageData != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 3;
              continue;
            }
            goto label_2;
          case 5:
            imageData = this.GetImageData();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 3 : 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (Image) null;
label_4:
      Image image;
      try
      {
        image = (Image) new Bitmap((Stream) memoryStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              default:
                ImageAttribute.T0IXiho8ah8x7B2SYJAT((object) memoryStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_12:;
      }
label_16:
      return image;
    }

    /// <summary>Получить наименование ресурса</summary>
    public string ResouseName => this.resourceName;

    internal static void rioH4go83dRZUc8FUP8V() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Ys3jcpo81skeVmKi1Jdj() => ImageAttribute.RFfrSyo8PeOmhfLa2jBd == null;

    internal static ImageAttribute ax5QCHo8NLvwnlMEMnCi() => ImageAttribute.RFfrSyo8PeOmhfLa2jBd;

    internal static long xAYPxwo8pLauRWEGr3TK([In] object obj0) => ((Stream) obj0).Length;

    internal static void T0IXiho8ah8x7B2SYJAT([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object w33aSko8DV1NbbVQxCSr([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);
  }
}
