// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.SvgHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Text;
using SG9KiyIbtdgGDf12qr;
using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Services
{
  /// <summary>Статический транспорт работы с SVG</summary>
  public static class SvgHelper
  {
    private static SvgHelper dXI9XLBtrCI7qjRAXHxV;

    /// <summary>Добавить кастомные аттрибуты в шапку svg</summary>
    /// <param name="content">Содержимое SVG разметки</param>
    /// <param name="htmlAttributes">Кастомные аттрибуты с html хелпера</param>
    /// <returns>Содержимое SVG</returns>
    public static string MergeAttributes(string content, IDictionary<string, string> htmlAttributes)
    {
      string empty = string.Empty;
      return !string.IsNullOrEmpty(content) ? SvgDocument.FromSvg<SvgDocumentRender>(content).MergeAttributes(htmlAttributes) : empty;
    }

    /// <summary>Сбросить цвет SVG элемента к состоянию "currentColor"</summary>
    /// <param name="content">Контент SVG</param>
    /// <returns>Контент SVG</returns>
    public static string ResetColor(string content) => SvgHelper.MergeAttributes(content, (IDictionary<string, string>) new Dictionary<string, string>()
    {
      {
        (string) SvgHelper.ykdoybBtjby1QcLdypF4(-1978478350 ^ -1978428156),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272543601)
      }
    });

    /// <summary>Конвертировать изображение к указанный формат</summary>
    /// <param name="stream">Поток</param>
    /// <param name="type">Тип конвертации</param>
    /// <param name="size">Размер bitmap-изображения</param>
    /// <returns>Bitmap</returns>
    public static Bitmap Convert(MemoryStream stream, ImageFormatType type, int size)
    {
      int num1 = 4;
      MemoryStream memoryStream;
      Bitmap bitmap1;
      while (true)
      {
        int num2 = num1;
        SvgDocument svgDocument;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              if (size > 0)
              {
                obj = (object) svgDocument.Draw(size, size);
                break;
              }
              goto label_8;
            case 2:
            case 6:
              goto label_5;
            case 3:
              if (svgDocument == null)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_19;
            case 5:
              memoryStream = (MemoryStream) SvgHelper.oeOTQ1BtLcY8RfZL4P0j();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            case 7:
              obj = SvgHelper.ycC7KmBtYh7MlYgca5DF((object) svgDocument);
              break;
            default:
              goto label_9;
          }
          bitmap1 = (Bitmap) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 5 : 5;
        }
label_8:
        num1 = 7;
        continue;
label_19:
        svgDocument = SvgDocument.Open<SvgDocument>((Stream) stream);
        num1 = 3;
      }
label_5:
      return (Bitmap) null;
label_9:
      Bitmap bitmap2;
      try
      {
        SvgHelper.YdKQqRBts65Cw9Yv5C9Z((object) bitmap1, (object) memoryStream, SvgHelper.eEBM1vBtUTwUrWcCAepl(type));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_6;
            default:
              bitmap2 = new Bitmap((Stream) memoryStream);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num4;
        if (memoryStream == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
        else
          goto label_17;
label_16:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_17:
        SvgHelper.pVCdLuBtcb87WAOSlQ6T((object) memoryStream);
        num4 = 2;
        goto label_16;
      }
label_6:
      return bitmap2;
    }

    /// <summary>Конвертировать изображение к указанный формат</summary>
    /// <param name="stream">Поток</param>
    /// <param name="type">Тип конвертации</param>
    /// <returns>Bitmap</returns>
    public static Bitmap Convert(MemoryStream stream, ImageFormatType type) => (Bitmap) SvgHelper.TdBo97BtzKBqsjCGsceI((object) stream, type, 0);

    /// <summary>Конвертировать изображение к указанный формат</summary>
    /// <param name="data">Набор байтов метаданных</param>
    /// <param name="type">Тип конвертации</param>
    /// <returns>Bitmap</returns>
    public static Bitmap Convert(byte[] data, ImageFormatType type)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = (MemoryStream) SvgHelper.GWWYm4BwF1G5s0bUkLpc((object) data, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          default:
            goto label_3;
        }
      }
label_3:
      Bitmap bitmap;
      try
      {
        bitmap = (Bitmap) SvgHelper.pTgUGIBwBp4bRXym7Zbf((object) memoryStream, type);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
        else
          goto label_10;
label_9:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_10:
        SvgHelper.pVCdLuBtcb87WAOSlQ6T((object) memoryStream);
        num3 = 2;
        goto label_9;
      }
label_12:
      return bitmap;
    }

    /// <summary>Конвертировать изображение к указанный формат</summary>
    /// <param name="imagePath">Путь до иконки типа SVG</param>
    /// <param name="type">Тип конвертации</param>
    /// <returns>Bitmap</returns>
    public static Bitmap Convert(string imagePath, ImageFormatType type)
    {
      int num1 = 1;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read, 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      Bitmap bitmap;
      try
      {
        long length = fileStream.Length;
        if (length > (long) int.MaxValue)
          throw new IOException((string) SvgHelper.ucrWNVBwWfTisIrsokVF(SvgHelper.ykdoybBtjby1QcLdypF4(1178210108 ^ 1178290460)));
        bitmap = MemoryHelper.ActionWithMemoryBuffer<byte, (FileStream, string, ImageFormatType), Bitmap>((int) length, (fileStream, imagePath, type), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (FileStream, string, ImageFormatType), Bitmap>(SvgHelper.ConvertAction));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (fileStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_11:
        SvgHelper.pVCdLuBtcb87WAOSlQ6T((object) fileStream);
        num3 = 2;
        goto label_10;
      }
label_13:
      return bitmap;
    }

    private static Bitmap ConvertAction(
      object buffer,
      int offset,
      int length,
      (FileStream, string, ImageFormatType) param)
    {
      int length1 = length;
      (FileStream fileStream, string str, ImageFormatType type) = param;
      int num;
      for (; length > 0; length -= num)
      {
        num = fileStream.Read((byte[]) buffer, offset, length);
        if (num == 0)
          throw new EndOfStreamException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98019786), (object) str));
        offset += num;
      }
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream((byte[]) buffer, offset, length1, false))
        return SvgHelper.Convert(memoryStream, type);
    }

    /// <summary>Получить ViewBox SVG элемента</summary>
    /// <param name="content">Содержимое SVG элемента</param>
    /// <returns>ViewBox DTO</returns>
    public static ViewBox GetViewBox(string content)
    {
      int num = 1;
      SvgDocument svgDocument;
      while (true)
      {
        switch (num)
        {
          case 1:
            svgDocument = SvgDocument.FromSvg<SvgDocument>(content);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ViewBox viewBox = new ViewBox();
      SvgViewBox svgViewBox = SvgHelper.bKOZmcBwoAHp8m9CCVpN((object) svgDocument);
      SvgHelper.UaM6BhBwbHEZI8EsFIlr((object) viewBox, svgViewBox.Height);
      svgViewBox = SvgHelper.bKOZmcBwoAHp8m9CCVpN((object) svgDocument);
      SvgHelper.nhCG8fBwhaF5ThfBb67Q((object) viewBox, svgViewBox.Width);
      return viewBox;
    }

    /// <summary>Изменить размеры SVG элемента</summary>
    /// <param name="content">Содержимое SVG элемента</param>
    /// <param name="size">Размер SVG элемента</param>
    /// <returns>Содержимое SVG элемента с заданным размеров</returns>
    public static string SvgResize(string content, int size)
    {
      int num1 = 5;
      MemoryStream memoryStream;
      SvgDocument svgDocument;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_28;
            case 2:
              memoryStream = MemoryHelper.GetMemoryStream();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            case 3:
              SvgHelper.Q56dNKBwf1KLBHFNfKcn((object) svgDocument, (SvgUnit) (float) size);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 1;
              continue;
            case 4:
              goto label_30;
            case 5:
              svgDocument = SvgDocument.FromSvg<SvgDocument>(content);
              num2 = 4;
              continue;
            default:
              goto label_3;
          }
        }
label_30:
        SvgHelper.HtKFroBwE92U8NDU4V0J((object) svgDocument, SvgHelper.lSRLAEBwGFegiyE80QFc((float) size));
        num1 = 3;
      }
label_3:
      try
      {
        XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) memoryStream, (Encoding) EncodingCache.UTF8WithoutEmitIdentifier);
        SvgHelper.fhWllwBwQTu3glH9EFwf((object) xmlTextWriter, Formatting.Indented);
        XmlTextWriter writer = xmlTextWriter;
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              svgDocument.Write(writer);
              int num4 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                num4 = 3;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_28;
                  case 2:
                    if (SvgHelper.TghpJKBwC4RdKDP1U06B((object) memoryStream) > 0L)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_28;
                  case 3:
                    writer.Flush();
                    num4 = 2;
                    continue;
                  default:
                    content = memoryStream.AsString((Encoding) EncodingCache.UTF8WithoutEmitIdentifier);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
                    continue;
                }
              }
            }
            finally
            {
              int num5;
              if (writer == null)
                num5 = 2;
              else
                goto label_18;
label_17:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_18:
              SvgHelper.pVCdLuBtcb87WAOSlQ6T((object) writer);
              num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
              {
                num5 = 0;
                goto label_17;
              }
              else
                goto label_17;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_26;
              default:
                SvgHelper.pVCdLuBtcb87WAOSlQ6T((object) memoryStream);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_26:;
      }
label_28:
      return content;
    }

    /// <summary>
    /// Получить формат изображения в зависимости от входного параметра
    /// </summary>
    /// <param name="type">Требуемый формат изображения</param>
    /// <returns>Формат изображения</returns>
    private static ImageFormat GetImageFormat(ImageFormatType type)
    {
      int num = 6;
      ImageFormat imageFormat;
      while (true)
      {
        switch (num)
        {
          case 1:
label_7:
            imageFormat = (ImageFormat) SvgHelper.jtheHBBw8WAZNNcbLQVD();
            num = 7;
            continue;
          case 2:
            goto label_3;
          case 3:
          case 7:
          case 8:
          case 9:
            goto label_4;
          case 4:
label_9:
            imageFormat = (ImageFormat) SvgHelper.rxxbcDBwZHdFNSVnrjFN();
            num = 3;
            continue;
          case 5:
            switch (type)
            {
              case ImageFormatType.Jpg:
                goto label_7;
              case ImageFormatType.Png:
                goto label_9;
              case ImageFormatType.Gif:
                break;
              case ImageFormatType.Svg:
                goto label_3;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 9 : 3;
                continue;
            }
            break;
          case 6:
            imageFormat = (ImageFormat) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 5;
            continue;
        }
        imageFormat = (ImageFormat) SvgHelper.BRS04kBwvXNoYIiPWmA2();
        num = 8;
      }
label_3:
      throw new ArgumentException((string) SvgHelper.ucrWNVBwWfTisIrsokVF(SvgHelper.ykdoybBtjby1QcLdypF4(-1146510045 ^ -1146559559)));
label_4:
      return imageFormat;
    }

    internal static object ykdoybBtjby1QcLdypF4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool pMaVKABtgfUxjWEE2iUt() => SvgHelper.dXI9XLBtrCI7qjRAXHxV == null;

    internal static SvgHelper oFAedOBt5d2lTIuNtJ7P() => SvgHelper.dXI9XLBtrCI7qjRAXHxV;

    internal static object ycC7KmBtYh7MlYgca5DF([In] object obj0) => (object) ((SvgDocument) obj0).Draw();

    internal static object oeOTQ1BtLcY8RfZL4P0j() => (object) MemoryHelper.GetMemoryStream();

    internal static object eEBM1vBtUTwUrWcCAepl(ImageFormatType type) => (object) SvgHelper.GetImageFormat(type);

    internal static void YdKQqRBts65Cw9Yv5C9Z([In] object obj0, [In] object obj1, [In] object obj2) => ((Image) obj0).Save((Stream) obj1, (ImageFormat) obj2);

    internal static void pVCdLuBtcb87WAOSlQ6T([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object TdBo97BtzKBqsjCGsceI([In] object obj0, ImageFormatType type, int size) => (object) SvgHelper.Convert((MemoryStream) obj0, type, size);

    internal static object GWWYm4BwF1G5s0bUkLpc([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object pTgUGIBwBp4bRXym7Zbf([In] object obj0, ImageFormatType type) => (object) SvgHelper.Convert((MemoryStream) obj0, type);

    internal static object ucrWNVBwWfTisIrsokVF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static SvgViewBox bKOZmcBwoAHp8m9CCVpN([In] object obj0) => ((SvgFragment) obj0).ViewBox;

    internal static void UaM6BhBwbHEZI8EsFIlr([In] object obj0, float value) => ((ViewBox) obj0).Height = value;

    internal static void nhCG8fBwhaF5ThfBb67Q([In] object obj0, float value) => ((ViewBox) obj0).Width = value;

    internal static SvgUnit lSRLAEBwGFegiyE80QFc([In] float obj0) => (SvgUnit) obj0;

    internal static void HtKFroBwE92U8NDU4V0J([In] object obj0, [In] SvgUnit obj1) => ((SvgFragment) obj0).Height = obj1;

    internal static void Q56dNKBwf1KLBHFNfKcn([In] object obj0, [In] SvgUnit obj1) => ((SvgFragment) obj0).Width = obj1;

    internal static void fhWllwBwQTu3glH9EFwf([In] object obj0, [In] Formatting obj1) => ((XmlTextWriter) obj0).Formatting = obj1;

    internal static long TghpJKBwC4RdKDP1U06B([In] object obj0) => ((Stream) obj0).Length;

    internal static object BRS04kBwvXNoYIiPWmA2() => (object) ImageFormat.Gif;

    internal static object jtheHBBw8WAZNNcbLQVD() => (object) ImageFormat.Jpeg;

    internal static object rxxbcDBwZHdFNSVnrjFN() => (object) ImageFormat.Png;
  }
}
