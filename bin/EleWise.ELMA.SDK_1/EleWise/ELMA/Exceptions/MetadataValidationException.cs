// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.MetadataValidationException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка валидации метаданных</summary>
  [Serializable]
  public class MetadataValidationException : Exception
  {
    internal static MetadataValidationException KUFtxeGgVtY2nf8JnQgC;

    private static string DefaultMessage => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69741571));

    /// <summary>Ctor</summary>
    /// <param name="validationErrors">Список ошибок валидации</param>
    public MetadataValidationException(ValidationError[] validationErrors)
    {
      MetadataValidationException.itQbC9GgRtGSDYQY2dgZ();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) MetadataValidationException.qwyWsMGgqBOuqgcpIYLi());
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ValidationErrors = validationErrors;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="validationErrors">Список ошибок валидации</param>
    public MetadataValidationException(string message, ValidationError[] validationErrors)
    {
      MetadataValidationException.itQbC9GgRtGSDYQY2dgZ();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) MetadataValidationException.O8DoGjGgXN6TP35TRQ2K(MetadataValidationException.qwyWsMGgqBOuqgcpIYLi(), MetadataValidationException.J17AFNGgKWOJLraJXFqg(-2106517564 ^ -2106490992), (object) message));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ValidationErrors = validationErrors;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info">info</param>
    /// <param name="context">context</param>
    protected MetadataValidationException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ValidationErrors = (ValidationError[]) MetadataValidationException.K5uCvvGgTGKHUKkbQwXB((object) info, MetadataValidationException.J17AFNGgKWOJLraJXFqg(-281842504 ^ -281819532), typeof (ValidationError[]));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Список ошибок валидации</summary>
    public ValidationError[] ValidationErrors
    {
      get => this.\u003CValidationErrors\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CValidationErrors\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataValidationException.sMyDBsGgkMUjE1xXAQZb((object) this, (object) info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MetadataValidationException.lXaZkgGgn6MAmWMcq9Js((object) info, MetadataValidationException.J17AFNGgKWOJLraJXFqg(1917256330 ^ 1917298758), (object) this.ValidationErrors);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool J8hudsGgS5txCToG7GRx() => MetadataValidationException.KUFtxeGgVtY2nf8JnQgC == null;

    internal static MetadataValidationException XRQdBAGgiXGkNlquyfLD() => MetadataValidationException.KUFtxeGgVtY2nf8JnQgC;

    internal static void itQbC9GgRtGSDYQY2dgZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object qwyWsMGgqBOuqgcpIYLi() => (object) MetadataValidationException.DefaultMessage;

    internal static object J17AFNGgKWOJLraJXFqg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object O8DoGjGgXN6TP35TRQ2K([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object K5uCvvGgTGKHUKkbQwXB([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void sMyDBsGgkMUjE1xXAQZb([In] object obj0, [In] object obj1, [In] StreamingContext obj2) => __nonvirtual (((Exception) obj0).GetObjectData((SerializationInfo) obj1, obj2));

    internal static void lXaZkgGgn6MAmWMcq9Js([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
