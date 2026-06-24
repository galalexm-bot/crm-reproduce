// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.DataClassPostEntityXmlSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>Хак для вырезания TypeRef из метаданных датаклассов</summary>
  [Component]
  [Obsolete("Временное решение сериализации для экспорта-импорта. Удалить при решении ELMA-29857")]
  internal sealed class DataClassPostEntityXmlSerializer : PostEntityXmlSerializer
  {
    private static DataClassPostEntityXmlSerializer K2CsvkEsTJEZFWwJxopy;

    /// <inheritdoc />
    public override string Replace(string serializedObject)
    {
      int num1 = 1;
      MemoryStream memoryStream1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream1 = (MemoryStream) DataClassPostEntityXmlSerializer.VM2bGLEsOVw5dLdoqyj9();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_74;
          default:
            goto label_2;
        }
      }
label_2:
      string str;
      try
      {
        MemoryStream memoryStream2 = memoryStream1;
        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
        DataClassPostEntityXmlSerializer.z71RaREs2XGXv5GGCNRY((object) xmlWriterSettings, true);
        XmlWriter writer = (XmlWriter) DataClassPostEntityXmlSerializer.mIUJIAEseAp7FMDucWVB((object) memoryStream2, (object) xmlWriterSettings);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num2 = 3;
        StreamReader streamReader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_58;
            case 2:
              streamReader = new StreamReader((Stream) memoryStream1, (Encoding) DataClassPostEntityXmlSerializer.YtVy6WEsAO4WkYbsgp6E());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            case 3:
              try
              {
                int num3;
                if (DataClassPostEntityXmlSerializer.J6UEydEs1I77AL9viCBQ((object) serializedObject, DataClassPostEntityXmlSerializer.vVKwFZEsPpPumodIt3La()))
                  num3 = 5;
                else
                  goto label_11;
label_9:
                StringReader input;
                int num4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_74;
                    case 2:
                    case 5:
                      num4 = DataClassPostEntityXmlSerializer.jMfsL3EsNn1rcQndCRLS((object) serializedObject, '<');
                      num3 = 3;
                      continue;
                    case 3:
                      input = new StringReader(serializedObject);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_11;
                    default:
                      goto label_14;
                  }
                }
label_14:
                try
                {
                  int num5;
                  if (num4 <= 0)
                  {
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 11 : 8;
                    goto label_18;
                  }
                  else
                    goto label_19;
label_17:
                  int num6;
                  num5 = num6;
label_18:
                  int num7;
                  XmlTextReader reader;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                      case 5:
                        if (num7 < num4)
                        {
                          num5 = 8;
                          continue;
                        }
                        goto case 2;
                      case 2:
                        DataClassPostEntityXmlSerializer.cZbtOVEsaD9qUKF5HUya((object) writer, DataClassPostEntityXmlSerializer.jtyKSIEspBrH6soO4i5K((object) serializedObject, 0, num4));
                        num5 = 3;
                        continue;
                      case 3:
                      case 11:
                        goto label_25;
                      case 4:
                        try
                        {
                          DataClassPostEntityXmlSerializer.TypeRefReWriter typeRefReWriter = new DataClassPostEntityXmlSerializer.TypeRefReWriter((XmlReader) reader, writer);
                          int num8 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                            num8 = 0;
                          switch (num8)
                          {
                            default:
                              try
                              {
                                DataClassPostEntityXmlSerializer.JF0TbXEsDGLmohvrjgAe((object) typeRefReWriter);
                                int num9 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                                  num9 = 0;
                                switch (num9)
                                {
                                  default:
                                    goto label_44;
                                }
                              }
                              catch (Exception ex)
                              {
                                int num10 = 2;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                                  num10 = 2;
                                while (true)
                                {
                                  switch (num10)
                                  {
                                    case 1:
                                      str = serializedObject;
                                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                                      continue;
                                    case 2:
                                      ((ILogger) DataClassPostEntityXmlSerializer.eAxvECEstdotKhRKHLqZ()).Error(ex, (string) DataClassPostEntityXmlSerializer.GctMypEs4GkqkrdQLvbv(DataClassPostEntityXmlSerializer.mN9e25EswmNgWxH0tsom(864270449 << 6 ^ -521464632)));
                                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                                      continue;
                                    default:
                                      goto label_74;
                                  }
                                }
                              }
                          }
                        }
                        finally
                        {
                          int num11;
                          if (reader == null)
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 2;
                          else
                            goto label_41;
label_40:
                          switch (num11)
                          {
                            case 1:
                              break;
                            default:
                          }
label_41:
                          DataClassPostEntityXmlSerializer.D3P0X3Es6apZD5SqvaBl((object) reader);
                          num11 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
                          {
                            num11 = 0;
                            goto label_40;
                          }
                          else
                            goto label_40;
                        }
                      case 6:
                        goto label_57;
                      case 7:
                      case 8:
                        DataClassPostEntityXmlSerializer.frKfqVEs3wg7nWL8IGLx((object) input);
                        num5 = 10;
                        continue;
                      case 9:
label_44:
                        DataClassPostEntityXmlSerializer.NP9uttEsHUKG802TRVwU((object) writer);
                        num5 = 6;
                        continue;
                      case 10:
                        ++num7;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                        continue;
                      default:
                        goto label_19;
                    }
                  }
label_25:
                  reader = new XmlTextReader((TextReader) input);
                  num6 = 4;
                  goto label_17;
label_19:
                  num7 = 0;
                  num6 = 5;
                  goto label_17;
                }
                finally
                {
                  int num12;
                  if (input == null)
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                  else
                    goto label_48;
label_47:
                  switch (num12)
                  {
                    case 2:
                      break;
                    default:
                  }
label_48:
                  input.Dispose();
                  num12 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
                  {
                    num12 = 0;
                    goto label_47;
                  }
                  else
                    goto label_47;
                }
label_11:
                str = serializedObject;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                {
                  num3 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              finally
              {
                if (writer != null)
                {
                  int num13 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                    num13 = 0;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        goto label_56;
                      default:
                        writer.Dispose();
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_56:;
              }
          }
label_57:
          memoryStream1.Seek(0L, SeekOrigin.Begin);
          num2 = 2;
        }
label_58:
        try
        {
          str = (string) DataClassPostEntityXmlSerializer.IaL1jsEs7Hi8PuIiZZ6H((object) streamReader);
          int num14 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
            num14 = 0;
          switch (num14)
          {
          }
        }
        finally
        {
          if (streamReader != null)
          {
            int num15 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
              num15 = 1;
            while (true)
            {
              switch (num15)
              {
                case 1:
                  DataClassPostEntityXmlSerializer.D3P0X3Es6apZD5SqvaBl((object) streamReader);
                  num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_66;
              }
            }
          }
label_66:;
        }
      }
      finally
      {
        if (memoryStream1 != null)
        {
          int num16 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
            num16 = 0;
          while (true)
          {
            switch (num16)
            {
              case 1:
                goto label_72;
              default:
                memoryStream1.Dispose();
                num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_72:;
      }
label_74:
      return str;
    }

    public DataClassPostEntityXmlSerializer()
    {
      DataClassPostEntityXmlSerializer.AeGglnEsx94LOAse6Get();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object VM2bGLEsOVw5dLdoqyj9() => (object) MemoryHelper.GetMemoryStream();

    internal static void z71RaREs2XGXv5GGCNRY([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).OmitXmlDeclaration = obj1;

    internal static object mIUJIAEseAp7FMDucWVB([In] object obj0, [In] object obj1) => (object) XmlWriter.Create((Stream) obj0, (XmlWriterSettings) obj1);

    internal static object vVKwFZEsPpPumodIt3La() => (object) TypeOf<DataClassMetadata>.FullName;

    internal static bool J6UEydEs1I77AL9viCBQ([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static int jMfsL3EsNn1rcQndCRLS([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static int frKfqVEs3wg7nWL8IGLx([In] object obj0) => ((TextReader) obj0).Read();

    internal static object jtyKSIEspBrH6soO4i5K([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static void cZbtOVEsaD9qUKF5HUya([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteRaw((string) obj1);

    internal static void JF0TbXEsDGLmohvrjgAe([In] object obj0) => ((XmlStreamingEditorBase) obj0).Process();

    internal static object eAxvECEstdotKhRKHLqZ() => (object) Logger.Log;

    internal static object mN9e25EswmNgWxH0tsom(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GctMypEs4GkqkrdQLvbv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void D3P0X3Es6apZD5SqvaBl([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void NP9uttEsHUKG802TRVwU([In] object obj0) => ((XmlWriter) obj0).Flush();

    internal static object YtVy6WEsAO4WkYbsgp6E() => (object) Encoding.UTF8;

    internal static object IaL1jsEs7Hi8PuIiZZ6H([In] object obj0) => (object) ((TextReader) obj0).ReadToEnd();

    internal static bool tir4MgEskWDXZeDSKoD4() => DataClassPostEntityXmlSerializer.K2CsvkEsTJEZFWwJxopy == null;

    internal static DataClassPostEntityXmlSerializer rvNqFjEsnQyipUZtFjEx() => DataClassPostEntityXmlSerializer.K2CsvkEsTJEZFWwJxopy;

    internal static void AeGglnEsx94LOAse6Get() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class TypeRefReWriter : XmlStreamingEditorBase
    {
      internal static object CPvqPw8mpwsV2FWOjqrs;

      public TypeRefReWriter(XmlReader reader, XmlWriter writer)
      {
        DataClassPostEntityXmlSerializer.TypeRefReWriter.sNDe438mtMIqg0c0GvXx();
        // ISSUE: explicit constructor call
        base.\u002Ector(reader, writer);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      protected override void TransformElement(XmlReader reader, XmlWriter writer)
      {
      }

      protected override bool ShouldTransformElement(XmlReader reader) => DataClassPostEntityXmlSerializer.TypeRefReWriter.IcQoC28m6oZpfVBX91lY(DataClassPostEntityXmlSerializer.TypeRefReWriter.pFfWwG8mwDSR1QFwUT47((object) reader), DataClassPostEntityXmlSerializer.TypeRefReWriter.PoSZda8m4ux0uHx8moMH(1199946765 ^ 1199814213));

      internal static void sNDe438mtMIqg0c0GvXx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool iNlBrj8ma0VdyInYk7Tj() => DataClassPostEntityXmlSerializer.TypeRefReWriter.CPvqPw8mpwsV2FWOjqrs == null;

      internal static DataClassPostEntityXmlSerializer.TypeRefReWriter R5ts348mDbhq71KmrvdB() => (DataClassPostEntityXmlSerializer.TypeRefReWriter) DataClassPostEntityXmlSerializer.TypeRefReWriter.CPvqPw8mpwsV2FWOjqrs;

      internal static object pFfWwG8mwDSR1QFwUT47([In] object obj0) => (object) ((XmlReader) obj0).Name;

      internal static object PoSZda8m4ux0uHx8moMH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool IcQoC28m6oZpfVBX91lY([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
    }
  }
}
