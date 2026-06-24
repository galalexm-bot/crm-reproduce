// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Serialization.XmlStreamingEditorBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy.Serialization
{
  /// <summary>Класс для переписывания XML</summary>
  internal abstract class XmlStreamingEditorBase
  {
    private readonly XmlReader reader;
    private readonly XmlWriter writer;
    private static XmlStreamingEditorBase uYHYyDEtyGRy0PFraCC3;

    /// <summary>Ctor</summary>
    /// <param name="reader">Читатель входного XML</param>
    /// <param name="writer">Писатель в выходной XML</param>
    protected XmlStreamingEditorBase(XmlReader reader, XmlWriter writer)
    {
      XmlStreamingEditorBase.dOLKaOEt9lqFJuhEbmhy();
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
            this.reader = reader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            this.writer = writer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Обработать</summary>
    public void Process()
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 7:
            if (this.reader.NodeType == XmlNodeType.Element)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 9 : 9;
              continue;
            }
            break;
          case 2:
            this.EditCurrentElement();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 3;
            continue;
          case 3:
          case 4:
          case 8:
            if (this.reader.Read())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 5:
            goto label_7;
          case 9:
            if (!XmlStreamingEditorBase.Ko1RlhEtdOojjtTTt74D((object) this, (object) this.reader))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
        }
        XmlStreamingEditorBase.sSvj23Etlv7a1wSBHbPL((object) this.reader, (object) this.writer);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 4;
      }
label_7:
      return;
label_6:;
    }

    /// <summary>Нужно ли менять элемент входного XML</summary>
    /// <param name="reader">Входной поток</param>
    /// <returns></returns>
    protected abstract bool ShouldTransformElement(XmlReader reader);

    /// <summary>Изменить элемент входного потока и вывести в выходной</summary>
    /// <param name="reader">Входной поток</param>
    /// <param name="writer">Выходной поток</param>
    protected abstract void TransformElement(XmlReader reader, XmlWriter writer);

    private void EditCurrentElement()
    {
      int num1 = 2;
      XmlReader reader;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_2;
          case 2:
            reader = (XmlReader) XmlStreamingEditorBase.g5tvQvEtrvUqqIbifBB5((object) this.reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_11:
      return;
label_10:
      return;
label_2:
      try
      {
        this.TransformElement(reader, this.writer);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (reader == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
        else
          goto label_12;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        XmlStreamingEditorBase.P2tbnXEtgroa1qrEs26G((object) reader);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        {
          num3 = 0;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    private static void WriteShallowNode(object reader, object writer)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        XmlNodeType xmlNodeType;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_8;
            case 3:
              if (XmlStreamingEditorBase.GnfjMrEtcoPGOkmES0dI(reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                continue;
              }
              goto label_37;
            case 4:
              goto label_3;
            case 5:
              XmlStreamingEditorBase.CmO7uCEtsDP807hnvSRG(writer, reader, true);
              num2 = 3;
              continue;
            case 6:
              goto label_26;
            case 7:
              XmlStreamingEditorBase.bPLBEjEtj75mtjocs7CV(reader, XmlStreamingEditorBase.FF61ekEt5x4yfDIDVFIk(-1822890472 ^ -1822861794));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 10 : 1;
              continue;
            case 8:
              Contract.NotNull(writer, (string) XmlStreamingEditorBase.FF61ekEt5x4yfDIDVFIk(1051802738 - -1831968059 ^ -1410965985));
              num2 = 7;
              continue;
            case 9:
              switch (xmlNodeType)
              {
                case XmlNodeType.Element:
                  goto label_25;
                case XmlNodeType.Attribute:
                  goto label_31;
                case XmlNodeType.Text:
                  XmlStreamingEditorBase.zHdpBeEwBPuWegPuOsO4(writer, XmlStreamingEditorBase.TPl0OEEwF7vJcymTNdP6(reader));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 4 : 6;
                  continue;
                case XmlNodeType.CDATA:
                  XmlStreamingEditorBase.oLXtPMEwoOkZEmnASThi(writer, XmlStreamingEditorBase.TPl0OEEwF7vJcymTNdP6(reader));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                  continue;
                case XmlNodeType.EntityReference:
                  ((XmlWriter) writer).WriteEntityRef(((XmlReader) reader).Name);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 15 : 2;
                  continue;
                case XmlNodeType.Entity:
                  goto label_32;
                case XmlNodeType.ProcessingInstruction:
                case XmlNodeType.XmlDeclaration:
                  XmlStreamingEditorBase.DERZxuEwhNx1CkAotgYc(writer, XmlStreamingEditorBase.UVxadbEwbJyWhaOtaQTk(reader), XmlStreamingEditorBase.TPl0OEEwF7vJcymTNdP6(reader));
                  num2 = 14;
                  continue;
                case XmlNodeType.Comment:
                  ((XmlWriter) writer).WriteComment((string) XmlStreamingEditorBase.TPl0OEEwF7vJcymTNdP6(reader));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 2;
                  continue;
                case XmlNodeType.Document:
                  goto label_33;
                case XmlNodeType.DocumentType:
                  XmlStreamingEditorBase.qB4nGLEwEAkQKK3MIHRP(writer, XmlStreamingEditorBase.UVxadbEwbJyWhaOtaQTk(reader), XmlStreamingEditorBase.ts1fZyEwGxY0mcUS0II9(reader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479203958)), XmlStreamingEditorBase.ts1fZyEwGxY0mcUS0II9(reader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787117158)), XmlStreamingEditorBase.TPl0OEEwF7vJcymTNdP6(reader));
                  num2 = 16;
                  continue;
                case XmlNodeType.DocumentFragment:
                  goto label_34;
                case XmlNodeType.Notation:
                  goto label_35;
                case XmlNodeType.Whitespace:
                case XmlNodeType.SignificantWhitespace:
                  XmlStreamingEditorBase.SdorReEwWpjdgQLcI1Tm(writer, XmlStreamingEditorBase.TPl0OEEwF7vJcymTNdP6(reader));
                  num2 = 4;
                  continue;
                case XmlNodeType.EndElement:
                  ((XmlWriter) writer).WriteFullEndElement();
                  num2 = 13;
                  continue;
                case XmlNodeType.EndEntity:
                  goto label_36;
                default:
                  goto label_7;
              }
            case 10:
              xmlNodeType = XmlStreamingEditorBase.atWxAwEtYMmDDJhXaMMa(reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 9 : 7;
              continue;
            case 11:
              goto label_20;
            case 12:
              goto label_21;
            case 13:
              goto label_17;
            case 14:
              goto label_14;
            case 15:
              goto label_4;
            case 16:
              goto label_24;
            default:
              XmlStreamingEditorBase.ivugpsEtzLXFT2WV4kBL(writer);
              num2 = 11;
              continue;
          }
        }
label_7:
        num1 = 12;
        continue;
label_25:
        ((XmlWriter) writer).WriteStartElement(((XmlReader) reader).Prefix, (string) XmlStreamingEditorBase.Jfc2qeEtLFSyNKonQXB6(reader), (string) XmlStreamingEditorBase.Sj5K6REtUZANUNeI4NmM(reader));
        num1 = 5;
      }
label_10:
      return;
label_24:
      return;
label_14:
      return;
label_17:
      return;
label_21:
      return;
label_4:
      return;
label_26:
      return;
label_3:
      return;
label_8:
      return;
label_20:
      return;
label_36:
      return;
label_31:
      return;
label_32:
      return;
label_33:
      return;
label_34:
      return;
label_35:
      return;
label_37:;
    }

    internal static void dOLKaOEt9lqFJuhEbmhy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bVgFj8EtMvWLH4ucDSJ1() => XmlStreamingEditorBase.uYHYyDEtyGRy0PFraCC3 == null;

    internal static XmlStreamingEditorBase BdnE2qEtJqjrYIyXQhYX() => XmlStreamingEditorBase.uYHYyDEtyGRy0PFraCC3;

    internal static bool Ko1RlhEtdOojjtTTt74D([In] object obj0, [In] object obj1) => ((XmlStreamingEditorBase) obj0).ShouldTransformElement((XmlReader) obj1);

    internal static void sSvj23Etlv7a1wSBHbPL([In] object obj0, [In] object obj1) => XmlStreamingEditorBase.WriteShallowNode(obj0, obj1);

    internal static object g5tvQvEtrvUqqIbifBB5([In] object obj0) => (object) ((XmlReader) obj0).ReadSubtree();

    internal static void P2tbnXEtgroa1qrEs26G([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object FF61ekEt5x4yfDIDVFIk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void bPLBEjEtj75mtjocs7CV([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static XmlNodeType atWxAwEtYMmDDJhXaMMa([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object Jfc2qeEtLFSyNKonQXB6([In] object obj0) => (object) ((XmlReader) obj0).LocalName;

    internal static object Sj5K6REtUZANUNeI4NmM([In] object obj0) => (object) ((XmlReader) obj0).NamespaceURI;

    internal static void CmO7uCEtsDP807hnvSRG([In] object obj0, [In] object obj1, [In] bool obj2) => ((XmlWriter) obj0).WriteAttributes((XmlReader) obj1, obj2);

    internal static bool GnfjMrEtcoPGOkmES0dI([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static void ivugpsEtzLXFT2WV4kBL([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();

    internal static object TPl0OEEwF7vJcymTNdP6([In] object obj0) => (object) ((XmlReader) obj0).Value;

    internal static void zHdpBeEwBPuWegPuOsO4([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteString((string) obj1);

    internal static void SdorReEwWpjdgQLcI1Tm([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteWhitespace((string) obj1);

    internal static void oLXtPMEwoOkZEmnASThi([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteCData((string) obj1);

    internal static object UVxadbEwbJyWhaOtaQTk([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static void DERZxuEwhNx1CkAotgYc([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteProcessingInstruction((string) obj1, (string) obj2);

    internal static object ts1fZyEwGxY0mcUS0II9([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static void qB4nGLEwEAkQKK3MIHRP(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      ((XmlWriter) obj0).WriteDocType((string) obj1, (string) obj2, (string) obj3, (string) obj4);
    }
  }
}
