// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Сериализатор объектов метаданных</summary>
  public static class MetadataSerializer
  {
    private static object lockObj;
    private static Dictionary<Type, XmlSerializer> serializers;
    private static Dictionary<string, Type> metadataTypesByXmlName;
    private static Type[] xsiTypes;
    internal static MetadataSerializer ldRvwsb0c0KmjGOhlICA;

    /// <summary>Загрузить метаданные из файла</summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <returns>Метаданные</returns>
    public static IMetadata LoadMetadata(string fileName) => (IMetadata) MetadataSerializer.vifxUAbmBGNtlVrlTsU9((object) fileName, true);

    /// <summary>Загрузить метаданные из файла</summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <param name="throwEx">Если файл неверный, возвратить ошибку или null</param>
    /// <returns>Метаданные</returns>
    public static IMetadata LoadMetadata(string fileName, bool throwEx)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            Contract.ArgumentNotNull((object) fileName, (string) MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(277947046 - -1479185048 ^ 1757137700));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            continue;
          default:
            goto label_54;
        }
      }
label_2:
      IMetadata metadata1;
      try
      {
        Type metadataType = MetadataSerializer.GetMetadataType((object) fileName, throwEx);
        int num2 = 4;
        bool lockTaken;
        object lockObj;
        FileStream input;
        XmlSerializer xmlSerializer;
        IMetadata metadata2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              lockObj = MetadataSerializer.lockObj;
              num2 = 6;
              continue;
            case 2:
label_40:
              if (MetadataSerializer.DwyR58bmfoZPCsZWMwOO(MetadataSerializer.W5G0HybmEv3k6uEZAEpC((object) metadata2), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 9 : 10;
                continue;
              }
              goto case 11;
            case 3:
              try
              {
                XmlTextReader xmlTextReader = new XmlTextReader((Stream) input);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  num3 = 1;
                switch (num3)
                {
                  case 1:
                    try
                    {
                      metadata2 = (IMetadata) MetadataSerializer.hcZ5BwbmhvvlQe0mnMTM((object) xmlSerializer, (object) xmlTextReader);
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                          goto label_40;
                      }
                    }
                    finally
                    {
                      int num5;
                      if (xmlTextReader == null)
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 2;
                      else
                        goto label_15;
label_14:
                      switch (num5)
                      {
                        case 1:
                        case 2:
                      }
label_15:
                      MetadataSerializer.FnQRWTbmGQG7vbGtXLBb((object) xmlTextReader);
                      num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                      {
                        num5 = 1;
                        goto label_14;
                      }
                      else
                        goto label_14;
                    }
                  default:
                    goto label_40;
                }
              }
              finally
              {
                int num6;
                if (input == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                else
                  goto label_21;
label_20:
                switch (num6)
                {
                  case 2:
                    break;
                  default:
                }
label_21:
                MetadataSerializer.FnQRWTbmGQG7vbGtXLBb((object) input);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                {
                  num6 = 0;
                  goto label_20;
                }
                else
                  goto label_20;
              }
            case 4:
              if (metadataType == (Type) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 9;
                continue;
              }
              goto case 1;
            case 5:
            case 8:
              goto label_54;
            case 6:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 7:
label_38:
              input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
              num2 = 3;
              continue;
            case 9:
              metadata1 = (IMetadata) null;
              num2 = 8;
              continue;
            case 10:
              MetadataSerializer.xJGonBbmQECodauVEdTu((object) metadata2);
              num2 = 11;
              continue;
            case 11:
              metadata1 = metadata2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 5 : 5;
              continue;
            default:
              try
              {
                Monitor.Enter(lockObj, ref lockTaken);
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                  num7 = 2;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      xmlSerializer = new XmlSerializer(metadataType, (Type[]) MetadataSerializer.wuZICSbmoXi1wC10g1Q4());
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      if (!MetadataSerializer.serializers.TryGetValue(metadataType, out xmlSerializer))
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_38;
                    case 3:
                      goto label_38;
                    default:
                      MetadataSerializer.serializers.Add(metadataType, xmlSerializer);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 3;
                      continue;
                  }
                }
              }
              finally
              {
                int num8;
                if (!lockTaken)
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                else
                  goto label_36;
label_35:
                switch (num8)
                {
                  case 1:
                  case 2:
                }
label_36:
                MetadataSerializer.zVcmf7bmbncEFHinCBTQ(lockObj);
                num8 = 2;
                goto label_35;
              }
          }
        }
      }
      catch (MetadataLoadException ex)
      {
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
          num9 = 0;
        switch (num9)
        {
          default:
            throw;
        }
      }
      catch (Exception ex)
      {
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num10 = 0;
        switch (num10)
        {
          default:
            throw new MetadataLoadException(EleWise.ELMA.SR.T((string) MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(1597012150 ^ 1597145858)), fileName, ex);
        }
      }
label_54:
      return metadata1;
    }

    /// <summary>Сохранить метаданные в файл</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="fileName">Полное имя файла</param>
    public static void SaveMetadata(IMetadata metadata, string fileName)
    {
      int num1 = 2;
      MemoryStream w;
      XmlSerializer xmlSerializer;
      while (true)
      {
        int num2 = num1;
        object lockObj;
        bool lockTaken;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              MetadataSerializer.zub0KFbmC0GKO0Q9w4Jk((object) fileName, MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(-87337865 ^ -87348627));
              num2 = 9;
              continue;
            case 2:
              MetadataSerializer.zub0KFbmC0GKO0Q9w4Jk((object) metadata, MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(979449278 ^ 979467392));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            case 4:
label_55:
              str = (string) MetadataSerializer.xtr35Tbmv9lfDAt3RLA2((object) fileName);
              num2 = 6;
              continue;
            case 5:
              goto label_54;
            case 6:
              if (!MetadataSerializer.Lpuieibm8JDaRCjrUQgw((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 5 : 5;
                continue;
              }
              goto case 8;
            case 7:
              goto label_49;
            case 8:
              w = (MemoryStream) MetadataSerializer.iJ9TOhbmuYa7aclf8amr();
              num2 = 3;
              continue;
            case 9:
              lockObj = MetadataSerializer.lockObj;
              num2 = 10;
              continue;
            case 10:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            default:
              try
              {
                Monitor.Enter(lockObj, ref lockTaken);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      xmlSerializer = new XmlSerializer(metadata.GetType(), (Type[]) MetadataSerializer.wuZICSbmoXi1wC10g1Q4());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 3;
                      continue;
                    case 2:
                      goto label_55;
                    case 3:
                      MetadataSerializer.serializers.Add(metadata.GetType(), xmlSerializer);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 2;
                      continue;
                    default:
                      if (!MetadataSerializer.serializers.TryGetValue(metadata.GetType(), out xmlSerializer))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_55;
                  }
                }
              }
              finally
              {
                int num4;
                if (!lockTaken)
                  num4 = 2;
                else
                  goto label_50;
label_47:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_50:
                Monitor.Exit(lockObj);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                {
                  num4 = 0;
                  goto label_47;
                }
                else
                  goto label_47;
              }
          }
        }
label_54:
        MetadataSerializer.xMva6nbmZZfmxSKLC4hF((object) str);
        num1 = 8;
      }
label_49:
      return;
label_3:
      try
      {
        XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, (Encoding) MetadataSerializer.HLKTpUbmIDYsmyl5KbKs());
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
            try
            {
              MetadataSerializer.Jw7iJQbmVyXI40fecZQe((object) xmlTextWriter, Formatting.Indented);
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                num6 = 0;
              FileStream fileStream;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    num6 = 4;
                    continue;
                  case 2:
                    MetadataSerializer.aqUPoqbmRdCImXDJo9wi((object) w, 0L, SeekOrigin.Begin);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
                    continue;
                  case 3:
                    xmlTextWriter.IndentChar = ' ';
                    num6 = 5;
                    continue;
                  case 4:
                    goto label_15;
                  case 5:
                    MetadataSerializer.kPp7IIbmiY9X4gWnMCMM((object) xmlSerializer, (object) xmlTextWriter, (object) metadata);
                    num6 = 2;
                    continue;
                  default:
                    MetadataSerializer.PH9IJ8bmSrF0ac8Q1snW((object) xmlTextWriter, 2);
                    num6 = 3;
                    continue;
                }
              }
label_15:
              try
              {
                MetadataSerializer.lUpWVobmqA7XgbFc05hH((object) w, (object) fileStream);
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num7 = 0;
                switch (num7)
                {
                  case 0:
                    return;
                  default:
                    return;
                }
              }
              finally
              {
                int num8;
                if (fileStream == null)
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 0;
                else
                  goto label_21;
label_20:
                switch (num8)
                {
                  case 1:
                    break;
                  default:
                }
label_21:
                MetadataSerializer.FnQRWTbmGQG7vbGtXLBb((object) fileStream);
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                {
                  num8 = 0;
                  goto label_20;
                }
                else
                  goto label_20;
              }
            }
            finally
            {
              if (xmlTextWriter != null)
              {
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_29;
                    default:
                      xmlTextWriter.Dispose();
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_29:;
            }
        }
      }
      finally
      {
        int num10;
        if (w == null)
          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
        else
          goto label_33;
label_32:
        switch (num10)
        {
          case 1:
            break;
          default:
        }
label_33:
        MetadataSerializer.FnQRWTbmGQG7vbGtXLBb((object) w);
        num10 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        {
          num10 = 1;
          goto label_32;
        }
        else
          goto label_32;
      }
    }

    private static Type[] GetXsiTypes()
    {
      int num1 = 3;
      object lockObj;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 3:
            lockObj = MetadataSerializer.lockObj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      Type[] xsiTypes;
      return xsiTypes;
label_3:
      try
      {
        Monitor.Enter(lockObj, ref lockTaken);
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            case 2:
              if (MetadataSerializer.xsiTypes == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 3:
              xsiTypes = MetadataSerializer.xsiTypes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            default:
              // ISSUE: type reference
              MetadataSerializer.xsiTypes = (Type[]) MetadataSerializer.fOsa7JbmX4rLsKBRYFQt((object) ComponentManager.Current, MetadataSerializer.YjRrUZbmKdFeI9VtP1OJ(__typeref (IXsiType)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 3;
              continue;
          }
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                MetadataSerializer.zVcmf7bmbncEFHinCBTQ(lockObj);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_16:;
      }
    }

    public static void LoadMetadataTypes()
    {
      int num1 = 3;
      object lockObj;
      bool lockTaken;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_37;
            case 2:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_40;
            default:
              goto label_3;
          }
        }
label_40:
        lockObj = MetadataSerializer.lockObj;
        num1 = 2;
      }
label_37:
      return;
label_3:
      try
      {
        Monitor.Enter(lockObj, ref lockTaken);
        int num3 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
          num3 = 1;
        IEnumerator<IMetadataTypeInfo> enumerator;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_30;
            case 1:
              goto label_11;
            case 2:
              MetadataSerializer.metadataTypesByXmlName = new Dictionary<string, Type>();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 2 : 3;
              continue;
            case 3:
              enumerator = ((ComponentManager) MetadataSerializer.YLSH98bmTiUmef1TIFmm()).GetExtensionPoints<IMetadataTypeInfo>().GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
              continue;
            case 4:
              if (MetadataSerializer.metadataTypesByXmlName == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
                continue;
              }
              goto label_27;
            default:
              goto label_23;
          }
        }
label_30:
        return;
label_23:
        return;
label_27:
        return;
label_11:
        try
        {
label_19:
          if (MetadataSerializer.MVfXDxbmOhkPcicepxlO((object) enumerator))
            goto label_16;
          else
            goto label_20;
label_12:
          int num4;
          int num5 = num4;
label_13:
          XmlRootAttribute attribute;
          IMetadataTypeInfo current;
          while (true)
          {
            switch (num5)
            {
              case 1:
                if (!MetadataSerializer.metadataTypesByXmlName.ContainsKey((string) MetadataSerializer.lTpo2Gbmn4fIJDX2etmN((object) attribute)))
                  goto case 3;
                else
                  goto label_15;
              case 2:
                if (attribute != null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
                  continue;
                }
                goto label_19;
              case 3:
                MetadataSerializer.metadataTypesByXmlName.Add((string) MetadataSerializer.lTpo2Gbmn4fIJDX2etmN((object) attribute), MetadataSerializer.B9NC0Fbmklo3RYi1U7xE((object) current));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 6;
                continue;
              case 4:
                attribute = AttributeHelper<XmlRootAttribute>.GetAttribute(MetadataSerializer.B9NC0Fbmklo3RYi1U7xE((object) current), false);
                num5 = 2;
                continue;
              case 5:
              case 6:
                goto label_19;
              case 7:
                goto label_32;
              default:
                goto label_16;
            }
          }
label_32:
          return;
label_15:
          num4 = 5;
          goto label_12;
label_16:
          current = enumerator.Current;
          num4 = 4;
          goto label_12;
label_20:
          num5 = 7;
          goto label_13;
        }
        finally
        {
          int num6;
          if (enumerator == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
          else
            goto label_28;
label_26:
          switch (num6)
          {
            case 1:
            case 2:
          }
label_28:
          MetadataSerializer.FnQRWTbmGQG7vbGtXLBb((object) enumerator);
          num6 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          {
            num6 = 0;
            goto label_26;
          }
          else
            goto label_26;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num7 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
            num7 = 1;
          while (true)
          {
            switch (num7)
            {
              case 1:
                MetadataSerializer.zVcmf7bmbncEFHinCBTQ(lockObj);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
    }

    private static Type GetMetadataType(object fileName, bool throwEx)
    {
      int num1 = 3;
      XmlNode xmlNode;
      Type metadataType1;
      Type metadataType2;
      while (true)
      {
        int num2 = num1;
        XmlDocument xmlDocument;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (xmlNode == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              }
              MetadataSerializer.LoadMetadataTypes();
              num2 = 15;
              continue;
            case 2:
              if (!MetadataSerializer.WTXOnxbmeAkcncYZXW25(fileName))
              {
                num2 = 13;
                continue;
              }
              goto label_17;
            case 3:
              MetadataSerializer.EQ6h7ibm2giaxgBWd62a();
              num2 = 2;
              continue;
            case 4:
              goto label_5;
            case 5:
              xmlNode = xmlNode.NextSibling;
              num2 = 14;
              continue;
            case 6:
            case 14:
              if (xmlNode != null)
              {
                num2 = 7;
                continue;
              }
              goto case 1;
            case 7:
              if (xmlNode is XmlElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 8:
              goto label_19;
            case 9:
              try
              {
                MetadataSerializer.ACq9Fpbm17opwJq5w14d((object) xmlDocument, fileName);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_18;
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (!throwEx)
                      {
                        metadataType2 = (Type) null;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                        continue;
                      }
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_32;
                    default:
                      goto label_6;
                  }
                }
label_32:
                throw new MetadataLoadException(EleWise.ELMA.SR.T((string) MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(-218496594 ^ -218563188)), (string) fileName, ex);
              }
            case 10:
              goto label_3;
            case 11:
              if (throwEx)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 10 : 1;
                continue;
              }
              goto label_4;
            case 12:
label_18:
              xmlNode = (XmlNode) MetadataSerializer.NeWl7ebmNK4rtdKu80Rl((object) xmlDocument);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 6 : 4;
              continue;
            case 13:
              goto label_16;
            case 15:
              if (MetadataSerializer.metadataTypesByXmlName.TryGetValue(xmlNode.Name, out metadataType1))
              {
                num2 = 4;
                continue;
              }
              goto case 11;
            default:
              if (throwEx)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 6 : 8;
                continue;
              }
              goto label_20;
          }
        }
label_17:
        xmlDocument = new XmlDocument();
        num1 = 9;
      }
label_3:
      throw new MetadataLoadException(EleWise.ELMA.SR.T((string) MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(87862435 ^ 87970037), MetadataSerializer.ixhmNBbm33B5cwDcf9dB((object) xmlNode)), (string) fileName);
label_4:
      return (Type) null;
label_5:
      return metadataType1;
label_6:
      return metadataType2;
label_16:
      throw new MetadataLoadException((string) MetadataSerializer.Fk5H0fbmPmAgPMYAv8as(MetadataSerializer.BGhrj6bmWYrn7G6LvQ7J(-787452571 ^ -787310967)), (string) fileName);
label_19:
      throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516730664)), (string) fileName);
label_20:
      return (Type) null;
    }

    static MetadataSerializer()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MetadataSerializer.serializers = new Dictionary<Type, XmlSerializer>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            MetadataSerializer.lockObj = new object();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
            continue;
          case 3:
            MetadataSerializer.UdOxOZbmp07vJpluZSd3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object vifxUAbmBGNtlVrlTsU9([In] object obj0, bool throwEx) => (object) MetadataSerializer.LoadMetadata((string) obj0, throwEx);

    internal static bool hE5Bc0b0ztKfAAZCqZ0I() => MetadataSerializer.ldRvwsb0c0KmjGOhlICA == null;

    internal static MetadataSerializer v1pSRSbmFAEF2FRBHyXC() => MetadataSerializer.ldRvwsb0c0KmjGOhlICA;

    internal static object BGhrj6bmWYrn7G6LvQ7J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wuZICSbmoXi1wC10g1Q4() => (object) MetadataSerializer.GetXsiTypes();

    internal static void zVcmf7bmbncEFHinCBTQ([In] object obj0) => Monitor.Exit(obj0);

    internal static object hcZ5BwbmhvvlQe0mnMTM([In] object obj0, [In] object obj1) => ((XmlSerializer) obj0).Deserialize((XmlReader) obj1);

    internal static void FnQRWTbmGQG7vbGtXLBb([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid W5G0HybmEv3k6uEZAEpC([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool DwyR58bmfoZPCsZWMwOO([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void xJGonBbmQECodauVEdTu([In] object obj0) => ((IMetadata) obj0).InitNew();

    internal static void zub0KFbmC0GKO0Q9w4Jk([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object xtr35Tbmv9lfDAt3RLA2([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static bool Lpuieibm8JDaRCjrUQgw([In] object obj0) => Directory.Exists((string) obj0);

    internal static object xMva6nbmZZfmxSKLC4hF([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object iJ9TOhbmuYa7aclf8amr() => (object) MemoryHelper.GetMemoryStream();

    internal static object HLKTpUbmIDYsmyl5KbKs() => (object) Encoding.UTF8;

    internal static void Jw7iJQbmVyXI40fecZQe([In] object obj0, [In] Formatting obj1) => ((XmlTextWriter) obj0).Formatting = obj1;

    internal static void PH9IJ8bmSrF0ac8Q1snW([In] object obj0, [In] int obj1) => ((XmlTextWriter) obj0).Indentation = obj1;

    internal static void kPp7IIbmiY9X4gWnMCMM([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlSerializer) obj0).Serialize((XmlWriter) obj1, obj2);

    internal static long aqUPoqbmRdCImXDJo9wi([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void lUpWVobmqA7XgbFc05hH([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static Type YjRrUZbmKdFeI9VtP1OJ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object fOsa7JbmX4rLsKBRYFQt([In] object obj0, Type type) => (object) ((ComponentManager) obj0).GetExtensionPointTypesArray(type);

    internal static object YLSH98bmTiUmef1TIFmm() => (object) ComponentManager.Current;

    internal static Type B9NC0Fbmklo3RYi1U7xE([In] object obj0) => ((IMetadataTypeInfo) obj0).MetadataType;

    internal static object lTpo2Gbmn4fIJDX2etmN([In] object obj0) => (object) ((XmlRootAttribute) obj0).ElementName;

    internal static bool MVfXDxbmOhkPcicepxlO([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void EQ6h7ibm2giaxgBWd62a() => MetadataSerializer.LoadMetadataTypes();

    internal static bool WTXOnxbmeAkcncYZXW25([In] object obj0) => File.Exists((string) obj0);

    internal static object Fk5H0fbmPmAgPMYAv8as([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void ACq9Fpbm17opwJq5w14d([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Load((string) obj1);

    internal static object NeWl7ebmNK4rtdKu80Rl([In] object obj0) => (object) ((XmlNode) obj0).FirstChild;

    internal static object ixhmNBbm33B5cwDcf9dB([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static void UdOxOZbmp07vJpluZSd3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
