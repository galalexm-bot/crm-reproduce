// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.XmlCommentsHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.API
{
  public static class XmlCommentsHelper
  {
    internal static XmlCommentsHelper MdWBVxfPfScHqg4ATnvQ;

    public static List<XmlDocument> XmlDocuments { get; set; }

    static XmlCommentsHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            XmlCommentsHelper.vW3gDgfPvaYwuM3oFSid();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            XmlCommentsHelper.XmlDocuments = new List<XmlDocument>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public static string GetSummary(PropertyInfo propertyInfo)
    {
      int num1 = 7;
      string summary;
      while (true)
      {
        int num2 = num1;
        XmlDocument xmlDocument;
        while (true)
        {
          XmlNode xmlNode;
          string str1;
          Type type1;
          string str2;
          Type type2;
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              xmlNode = (XmlNode) XmlCommentsHelper.ErWIonfPqQZlg9mlDawj((object) xmlDocument, (object) str1);
              num2 = 9;
              continue;
            case 4:
              type2 = XmlCommentsHelper.FKylgtfPSQL65EskRmiu((object) propertyInfo);
              break;
            case 5:
              str1 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(654297945 ^ 653950993), (object) str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
              continue;
            case 6:
              goto label_10;
            case 7:
              summary = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 6;
              continue;
            case 8:
              Type declaringType = XmlCommentsHelper.RJnUHPfP86NBki4oNyrn((object) propertyInfo).DeclaringType;
              if ((object) declaringType == null)
              {
                num2 = 4;
                continue;
              }
              type2 = declaringType;
              break;
            case 9:
              if (xmlNode == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 10:
              summary = ((string) XmlCommentsHelper.zCuoZXfPXvCmRarckDKg(XmlCommentsHelper.UZ5QaOfPKBai9gLKJZh6((object) xmlNode), (object) Array.Empty<char>())).TrimStart();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 3;
              continue;
            case 11:
              str2 = (string) XmlCommentsHelper.qc9MLnfPiHGe3mBwlrRI(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1872275253 >> 6 ^ -29043119), XmlCommentsHelper.sDOFiIfPIXaEYaK9AFMC((object) type1.FullName, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(589593376 ^ -1977315327 ^ -1459575553), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137457398)), (object) propertyInfo.Name);
              num2 = 5;
              continue;
            default:
              goto label_5;
          }
          type1 = type2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 9 : 11;
        }
label_10:
        xmlDocument = (XmlDocument) XmlCommentsHelper.iQGvKrfPV6nRtSBiuoeU(XmlCommentsHelper.sDOFiIfPIXaEYaK9AFMC(XmlCommentsHelper.dhi413fPZ5ra0BrHcU5K((object) XmlCommentsHelper.RJnUHPfP86NBki4oNyrn((object) propertyInfo).Assembly), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439532172), XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1978478350 ^ -1978507588)));
        num1 = 8;
        continue;
label_11:
        if (xmlDocument != null)
          num1 = 2;
        else
          break;
      }
label_5:
      return summary;
    }

    public static string GetRemarks(PropertyInfo propertyInfo) => string.Empty;

    public static string GetCodeExample(PropertyInfo propertyInfo) => string.Empty;

    public static string ReplaceIgnoreCase(
      this string originalString,
      string oldValue,
      string newValue)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int startIndex;
        while (true)
        {
          switch (num2)
          {
            case 1:
              originalString = (string) XmlCommentsHelper.vy8RWHfPkUXY7w0oXu0g((object) originalString.Remove(startIndex, XmlCommentsHelper.I5FZkQfPTc8nUHfpifcI((object) oldValue)), startIndex, (object) newValue);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
              continue;
            case 2:
              startIndex += XmlCommentsHelper.I5FZkQfPTc8nUHfpifcI((object) newValue);
              num2 = 3;
              continue;
            case 3:
              if (startIndex >= 0)
              {
                num2 = 6;
                continue;
              }
              goto label_6;
            case 4:
            case 6:
              startIndex = originalString.IndexOf(oldValue, startIndex, StringComparison.InvariantCultureIgnoreCase);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 7;
              continue;
            case 5:
              goto label_3;
            case 7:
              if (startIndex >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            default:
              goto label_6;
          }
        }
label_3:
        startIndex = 0;
        num1 = 4;
      }
label_6:
      return originalString;
    }

    /// <summary>Получить описание параметров метода</summary>
    /// <param name="info"></param>
    /// <returns></returns>
    public static Dictionary<string, string> GetParametersDescription(MethodInfo info)
    {
      Dictionary<string, string> parametersDescription = new Dictionary<string, string>();
      XmlDocument xmlDocument = XmlCommentsHelper.LoadIfNotContains((object) info.DeclaringType.Assembly.CodeBase.ReplaceIgnoreCase(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837745471), z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236103553)));
      // ISSUE: reference to a compiler-generated method
      string str1 = info.GetParameters().Length == 0 ? string.Empty : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501340729), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488894149), ((IEnumerable<ParameterInfo>) info.GetParameters()).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (a => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass9_0.WH4txQZF23MOT7PnP4KV(a.ParameterType, (object) info)))));
      string str2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767378335), (object) info.DeclaringType.FullName.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218948244), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360337113)), (object) info.Name, (object) str1);
      string xpath = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210380683), (object) str2);
      foreach (XmlNode selectNode in xmlDocument.SelectNodes(xpath))
      {
        string innerText = selectNode.Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889461162)].InnerText;
        int startIndex = selectNode.InnerText.IndexOf('.');
        string str3 = startIndex > 0 ? selectNode.InnerText.Remove(startIndex) : selectNode.InnerText;
        parametersDescription.Add(innerText, str3);
      }
      return parametersDescription;
    }

    /// <summary>Получить описание для метода</summary>
    /// <param name="methodInfo"></param>
    /// <returns></returns>
    public static string GetSummary(MethodInfo methodInfo)
    {
      int num = 15;
      string s;
      while (true)
      {
        Type type;
        XmlDocument xmlDocument;
        string str1;
        string str2;
        string str3;
        XmlNode xmlNode;
        object obj;
        MethodInfo methodInfo1;
        switch (num)
        {
          case 1:
            if (xmlNode != null)
            {
              num = 19;
              continue;
            }
            goto case 3;
          case 2:
            if (!XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type), XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1994213607 >> 4 ^ 124295418)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 2 : 8;
              continue;
            }
            goto label_4;
          case 3:
            type = type.BaseType;
            num = 6;
            continue;
          case 4:
          case 10:
            xmlDocument = (XmlDocument) XmlCommentsHelper.iQGvKrfPV6nRtSBiuoeU((object) ((string) XmlCommentsHelper.dhi413fPZ5ra0BrHcU5K((object) type.Assembly)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583955216), (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-2099751081 ^ -2099717863)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 11 : 9;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            obj = XmlCommentsHelper.BnNor0fPRitOybv6Tyof((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979382911), (object) string.Join((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(964881585 - -1459193222 ^ -1870913337), ((IEnumerable<ParameterInfo>) methodInfo1.GetParameters()).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (a => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass10_0.H1kF5nZF3H9VbRoLyR6a(XmlCommentsHelper.\u003C\u003Ec__DisplayClass10_0.VjRKLgZFNUAVAvSlQMWH((object) a), (object) methodInfo1)))));
            break;
          case 6:
          case 17:
            if (!s.IsNullOrEmpty())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 11 : 20;
              continue;
            }
            goto case 2;
          case 7:
            type = XmlCommentsHelper.FKylgtfPSQL65EskRmiu((object) methodInfo1);
            num = 17;
            continue;
          case 8:
            if (XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
            {
              num = 10;
              continue;
            }
            goto label_4;
          case 9:
          case 20:
            goto label_4;
          case 11:
            if (methodInfo1.GetParameters().Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 12:
            s = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 7 : 6;
            continue;
          case 13:
            xmlNode = (XmlNode) XmlCommentsHelper.ErWIonfPqQZlg9mlDawj((object) xmlDocument, (object) str3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
            continue;
          case 14:
            methodInfo1 = methodInfo;
            num = 12;
            continue;
          case 15:
            num = 14;
            continue;
          case 16:
            str3 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(272623989 ^ 272278849), (object) str2);
            num = 13;
            continue;
          case 18:
            str2 = string.Format((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1837662597 ^ -1838009749), (object) type.Namespace, XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type), XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) methodInfo1), (object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 16;
            continue;
          case 19:
            s = (string) XmlCommentsHelper.UZ5QaOfPKBai9gLKJZh6((object) xmlNode);
            num = 3;
            continue;
          default:
            obj = (object) string.Empty;
            break;
        }
        str1 = (string) obj;
        num = 18;
      }
label_4:
      return s;
    }

    /// <summary>Получить ремарки для метода</summary>
    /// <param name="methodInfo"></param>
    /// <returns></returns>
    public static string GetRemarks(MethodInfo methodInfo)
    {
      int num1 = 5;
      string remarks;
      while (true)
      {
        int num2 = num1;
        XmlNode xmlNode;
        string str1;
        string xpath;
        Type type;
        string str2;
        XmlDocument xmlDocument;
        MethodInfo methodInfo1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              type = XmlCommentsHelper.FKylgtfPSQL65EskRmiu((object) methodInfo1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 18 : 19;
              continue;
            case 2:
              if (xmlNode != null)
                goto case 6;
              else
                goto label_20;
            case 3:
              if (!XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
              {
                num2 = 9;
                continue;
              }
              goto case 17;
            case 4:
              methodInfo1 = methodInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 4 : 7;
              continue;
            case 5:
              goto label_23;
            case 6:
              remarks = (string) XmlCommentsHelper.UZ5QaOfPKBai9gLKJZh6((object) xmlNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 15 : 11;
              continue;
            case 7:
              remarks = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            case 8:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type), XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(~-122002947 ^ 121688694)))
              {
                num2 = 13;
                continue;
              }
              goto case 3;
            case 9:
            case 10:
            case 13:
              goto label_6;
            case 11:
              if (methodInfo1.GetParameters().Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              }
              goto label_25;
            case 12:
              goto label_7;
            case 14:
              xmlNode = xmlDocument.SelectSingleNode(xpath);
              num2 = 2;
              continue;
            case 15:
            case 18:
              type = type.BaseType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 13 : 20;
              continue;
            case 16:
              str1 = (string) XmlCommentsHelper.nbDWNsfPPrS9Phjcdixe(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876377409), (object) new object[4]
              {
                (object) type.Namespace,
                XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type),
                XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) methodInfo1),
                (object) str2
              });
              num2 = 12;
              continue;
            case 17:
              xmlDocument = (XmlDocument) XmlCommentsHelper.iQGvKrfPV6nRtSBiuoeU((object) ((string) XmlCommentsHelper.dhi413fPZ5ra0BrHcU5K((object) type.Assembly)).Replace((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1251470110 >> 2 ^ 312522435), (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1574260816 ^ 1574297118)));
              num2 = 11;
              continue;
            case 19:
            case 20:
              if (!XmlCommentsHelper.lGUZv2fP1ivmhLi3TSbB((object) remarks))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 10 : 5;
                continue;
              }
              goto case 8;
            default:
              goto label_24;
          }
        }
label_7:
        xpath = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(864270449 << 6 ^ -521449242), (object) str1);
        num1 = 14;
        continue;
label_20:
        num1 = 18;
        continue;
label_23:
        num1 = 4;
        continue;
label_24:
        object obj1 = XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(87862435 ^ 87993107);
        object separator = XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876042145);
        object source = XmlCommentsHelper.gJ144afPeYxHb5qPQSaw((object) methodInfo1);
        Func<ParameterInfo, string> func;
        Func<ParameterInfo, string> func1 = func;
        // ISSUE: reference to a compiler-generated method
        Func<ParameterInfo, string> selector = func1 == null ? (func = (Func<ParameterInfo, string>) (a => XmlCommentsHelper.GetParameterName(XmlCommentsHelper.\u003C\u003Ec__DisplayClass11_0.yliXs8ZFwevCxb6aXov9((object) a), (object) methodInfo1))) : func1;
        IEnumerable<string> values = ((IEnumerable<ParameterInfo>) source).Select<ParameterInfo, string>(selector);
        string str3 = string.Join((string) separator, values);
        object obj2 = XmlCommentsHelper.BnNor0fPRitOybv6Tyof(obj1, (object) str3);
        goto label_26;
label_25:
        obj2 = (object) string.Empty;
label_26:
        str2 = (string) obj2;
        num1 = 16;
      }
label_6:
      return remarks;
    }

    /// <summary>
    /// Получить пример кода <example></example> для метода
    /// </summary>
    /// <param name="methodInfo">Метод</param>
    public static string GetCodeExample(MethodInfo methodInfo)
    {
      int num1 = 11;
      string s;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          XmlNode xmlNode;
          Type type;
          string str1;
          string str2;
          string str3;
          XmlDocument xmlDocument;
          object obj;
          MethodInfo methodInfo1;
          switch (num2)
          {
            case 1:
            case 16:
              if (s.IsNullOrEmpty())
              {
                num2 = 5;
                continue;
              }
              goto label_6;
            case 2:
              type = type.BaseType;
              num2 = 16;
              continue;
            case 3:
              s = (string) XmlCommentsHelper.UZ5QaOfPKBai9gLKJZh6((object) xmlNode);
              num2 = 2;
              continue;
            case 4:
            case 15:
              goto label_6;
            case 5:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type), XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1858887263 ^ -1858671147)))
              {
                num2 = 4;
                continue;
              }
              goto case 13;
            case 6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              obj = XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-643786247 ^ -643654071), (object) string.Join((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876042145), ((IEnumerable<ParameterInfo>) XmlCommentsHelper.gJ144afPeYxHb5qPQSaw((object) methodInfo1)).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (a => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass12_0.qDalobZF7g1x5Oi36VWq(XmlCommentsHelper.\u003C\u003Ec__DisplayClass12_0.GAQvaEZFAKh3a1eKdwj1((object) a), (object) methodInfo1)))));
              break;
            case 7:
              xmlNode = (XmlNode) XmlCommentsHelper.ErWIonfPqQZlg9mlDawj((object) xmlDocument, (object) str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 14 : 2;
              continue;
            case 8:
              str1 = string.Format((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(323422137 << 2 ^ 1293505268), (object) type.Namespace, (object) type.Name, XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) methodInfo1), (object) str3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            case 9:
              type = XmlCommentsHelper.FKylgtfPSQL65EskRmiu((object) methodInfo1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
            case 10:
              methodInfo1 = methodInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 18 : 2;
              continue;
            case 11:
              num2 = 10;
              continue;
            case 12:
              if (XmlCommentsHelper.gJ144afPeYxHb5qPQSaw((object) methodInfo1).Length != 0)
              {
                num2 = 6;
                continue;
              }
              obj = (object) string.Empty;
              break;
            case 13:
              if (XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 11 : 19;
                continue;
              }
              goto label_6;
            case 14:
              if (xmlNode != null)
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 17:
            case 19:
              xmlDocument = (XmlDocument) XmlCommentsHelper.iQGvKrfPV6nRtSBiuoeU(XmlCommentsHelper.sDOFiIfPIXaEYaK9AFMC(XmlCommentsHelper.dhi413fPZ5ra0BrHcU5K((object) type.Assembly), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44674937), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477109356)));
              num2 = 12;
              continue;
            case 18:
              goto label_23;
            default:
              str2 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(132912447 ^ 132733401), (object) str1);
              num2 = 7;
              continue;
          }
          str3 = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 3 : 8;
        }
label_23:
        s = "";
        num1 = 9;
      }
label_6:
      return s;
    }

    /// <summary>Получить описание параметров</summary>
    /// <param name="methodInfo"></param>
    /// <returns></returns>
    public static List<string> GetParameters(MethodInfo methodInfo)
    {
      List<string> parameters = new List<string>();
      for (Type type = methodInfo.DeclaringType; parameters.Count == 0 && !type.Name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653952813)) && type != TypeOf<object>.Raw; type = type.BaseType)
      {
        XmlDocument xmlDocument = XmlCommentsHelper.LoadIfNotContains((object) type.Assembly.CodeBase.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475549443), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124607168)));
        // ISSUE: reference to a compiler-generated method
        string str1 = methodInfo.GetParameters().Length == 0 ? string.Empty : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917125946), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97959258), ((IEnumerable<ParameterInfo>) methodInfo.GetParameters()).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (a => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass13_0.OoZurvZFyCacIWMGLqFM(a.ParameterType, (object) methodInfo)))));
        string str2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858671183), (object) type.Namespace, (object) type.Name, (object) methodInfo.Name, (object) str1);
        string xpath = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104887612), (object) str2);
        XmlNodeList source = xmlDocument.SelectNodes(xpath);
        if (source != null && source.Count > 0)
          parameters.AddRange(source.Cast<XmlNode>().Select<XmlNode, string>((Func<XmlNode, string>) (result => result.OuterXml)));
      }
      return parameters;
    }

    /// <summary>
    /// Получить <returns></returns>
    /// </summary>
    /// <param name="methodInfo">метод</param>
    /// <returns></returns>
    public static string GetReturns(MethodInfo methodInfo)
    {
      int num1 = 9;
      string returns;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          XmlDocument xmlDocument;
          string str1;
          XmlNode xmlNode;
          Type type;
          string str2;
          string str3;
          object obj1;
          MethodInfo methodInfo1;
          switch (num2)
          {
            case 1:
              str2 = (string) XmlCommentsHelper.nbDWNsfPPrS9Phjcdixe(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-70007027 ^ -69825763), (object) new object[4]
              {
                (object) type.Namespace,
                XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type),
                XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) methodInfo1),
                (object) str3
              });
              num2 = 11;
              continue;
            case 2:
            case 21:
              if (!XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 6;
                continue;
              }
              goto case 12;
            case 3:
              xmlDocument = (XmlDocument) XmlCommentsHelper.iQGvKrfPV6nRtSBiuoeU(XmlCommentsHelper.sDOFiIfPIXaEYaK9AFMC(XmlCommentsHelper.dhi413fPZ5ra0BrHcU5K((object) type.Assembly), XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-398663332 ^ -398873256), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642889974)));
              num2 = 4;
              continue;
            case 4:
              if (methodInfo1.GetParameters().Length != 0)
              {
                num2 = 20;
                continue;
              }
              obj1 = (object) string.Empty;
              break;
            case 5:
            case 6:
            case 15:
            case 16:
              goto label_4;
            case 7:
              if (!XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
              {
                num2 = 16;
                continue;
              }
              goto case 3;
            case 8:
              methodInfo1 = methodInfo;
              num2 = 10;
              continue;
            case 9:
              num2 = 8;
              continue;
            case 10:
              returns = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 11:
              str1 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1149433385 + 173655049 ^ 1322907472), (object) str2);
              num2 = 14;
              continue;
            case 12:
              if (XmlCommentsHelper.lGUZv2fP1ivmhLi3TSbB((object) returns))
                goto case 17;
              else
                goto label_18;
            case 13:
              if (xmlNode != null)
              {
                num2 = 18;
                continue;
              }
              goto case 19;
            case 14:
              xmlNode = (XmlNode) XmlCommentsHelper.ErWIonfPqQZlg9mlDawj((object) xmlDocument, (object) str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 13 : 3;
              continue;
            case 17:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type), XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(323422137 << 2 ^ 1293505168)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 9 : 15;
                continue;
              }
              goto case 7;
            case 18:
              returns = xmlNode.OuterXml;
              num2 = 19;
              continue;
            case 19:
              type = type.BaseType;
              num2 = 2;
              continue;
            case 20:
              object obj2 = XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-35995181 ^ -36125085);
              object separator = XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1581325282 << 3 ^ -234320416);
              object source = XmlCommentsHelper.gJ144afPeYxHb5qPQSaw((object) methodInfo1);
              Func<ParameterInfo, string> func;
              Func<ParameterInfo, string> func1 = func;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              Func<ParameterInfo, string> selector = func1 == null ? (func = (Func<ParameterInfo, string>) (a => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass14_0.AWB21ZZFzN0YqLxkhF8n(XmlCommentsHelper.\u003C\u003Ec__DisplayClass14_0.IaKsZuZFc7kSsLHHhoo2((object) a), (object) methodInfo1))) : func1;
              IEnumerable<string> values = ((IEnumerable<ParameterInfo>) source).Select<ParameterInfo, string>(selector);
              string str4 = string.Join((string) separator, values);
              obj1 = XmlCommentsHelper.BnNor0fPRitOybv6Tyof(obj2, (object) str4);
              break;
            default:
              type = methodInfo1.DeclaringType;
              num2 = 21;
              continue;
          }
          str3 = (string) obj1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
        }
label_18:
        num1 = 5;
      }
label_4:
      return returns;
    }

    /// <summary>XML-документирование к методу для кодогенерации</summary>
    /// <param name="methodInfo">Метод</param>
    /// <param name="propertyTypeArguments">Соответсвие типа аргумена к имени свойства</param>
    /// <returns>XML-документирование</returns>
    public static IEnumerable<ISyntaxTrivia> GetFullCommentsTrivia(
      this MethodBase methodInfo,
      IDictionary<string, TypeArgument> propertyTypeArguments = null)
    {
      List<ISyntaxTrivia> fullCommentsTrivia = new List<ISyntaxTrivia>();
      for (Type type1 = methodInfo.DeclaringType; type1 != (Type) null && fullCommentsTrivia.Count == 0 && !type1.Name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112358174)) && type1 != TypeOf<object>.Raw; type1 = type1.BaseType)
      {
        XmlDocument xmlDocument = XmlCommentsHelper.LoadIfNotContains((object) Path.ChangeExtension(type1.Assembly.CodeBase, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751145042)));
        if (xmlDocument != null)
        {
          string str1 = (object) (methodInfo as ConstructorInfo) != null ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107670084) : methodInfo.Name;
          if (methodInfo.IsGenericMethod)
            str1 = str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653952745) + (object) ((IEnumerable<Type>) methodInfo.GetGenericArguments()).Count<Type>();
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          string s = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408913982), ((IEnumerable<ParameterInfo>) methodInfo.GetParameters()).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (a => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.uex39tZBheVwpGk5eoVC(XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik((object) a), (object) methodInfo))));
          if (!s.IsNullOrEmpty())
            s = z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813596775) + s + z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372759445);
          string str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439792526) + type1.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979447674) + type1.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306447968) + str1 + s;
          string xpath = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97755754) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138872824);
          XmlNode xmlNode1 = xmlDocument.SelectSingleNode(xpath);
          if (xmlNode1 != null)
          {
            XmlNode xmlNode2 = xmlNode1.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195926803));
            if (xmlNode2 != null && !xmlNode2.InnerXml.IsNullOrEmpty())
              fullCommentsTrivia.Add(xmlNode2.InnerXml.SummaryComment(true));
            XmlNode xmlNode3 = xmlNode1.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787143819));
            if (xmlNode3 != null && !xmlNode3.InnerXml.IsNullOrEmpty())
              fullCommentsTrivia.Add(xmlNode3.InnerXml.RemarksComment(true));
            XmlNode xmlNode4 = xmlNode1.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597322910));
            if (xmlNode4 != null && !xmlNode4.InnerXml.IsNullOrEmpty())
              fullCommentsTrivia.Add(xmlNode4.InnerXml.ExampleComment(true));
            XmlNodeList source1 = xmlNode1.SelectNodes(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575804956));
            if (source1 != null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              fullCommentsTrivia.AddRange(source1.OfType<XmlNode>().Where<XmlNode>((Func<XmlNode, bool>) (p => !XmlCommentsHelper.\u003C\u003Ec.faM0HyZFrQcd1L3U6d6I(XmlCommentsHelper.\u003C\u003Ec.LPRuxfZFlyJNhiMTWKSL((object) p)))).Select<XmlNode, ISyntaxTrivia>((Func<XmlNode, ISyntaxTrivia>) (p =>
              {
                int num1 = 7;
                string str3;
                string propName;
                while (true)
                {
                  int num2 = num1;
                  while (true)
                  {
                    ParameterInfo parameterInfo1;
                    TypeArgument typeArgument;
                    Type type2;
                    ParameterInfo parameterInfo2;
                    switch (num2)
                    {
                      case 1:
                        type2 = (Type) null;
                        goto label_32;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        type2 = XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik((object) parameterInfo1).GetGenericArguments()[0];
                        goto label_32;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        str3 = (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.s4F9HNZBGXcQXXkKxPRl((object) typeArgument);
                        num2 = 12;
                        continue;
                      case 4:
                      case 14:
                      case 16:
                        // ISSUE: reference to a compiler-generated method
                        if (!XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.qPggw3ZBEiR8538NWI90((object) propName))
                        {
                          num2 = 15;
                          continue;
                        }
                        parameterInfo2 = (ParameterInfo) null;
                        break;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        type2 = XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik((object) parameterInfo1);
                        goto label_32;
                      case 6:
                        IEnumerable<XmlAttribute> source2 = p.Attributes.OfType<XmlAttribute>();
                        // ISSUE: reference to a compiler-generated field
                        Func<XmlAttribute, bool> func1 = XmlCommentsHelper.\u003C\u003Ec.\u003C\u003E9__15_3;
                        Func<XmlAttribute, bool> predicate;
                        if (func1 == null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          XmlCommentsHelper.\u003C\u003Ec.\u003C\u003E9__15_3 = predicate = (Func<XmlAttribute, bool>) (a => XmlCommentsHelper.\u003C\u003Ec.eeNpAwZFjJGYXImb6yXc(XmlCommentsHelper.\u003C\u003Ec.F3Cr2GZFgLu9KgZS3Pl3((object) a), XmlCommentsHelper.\u003C\u003Ec.ekcbUkZF5NheTFNRx4up(236071375 ^ 236070361)));
                        }
                        else
                          goto label_35;
label_26:
                        IEnumerable<XmlAttribute> source3 = source2.Where<XmlAttribute>(predicate);
                        // ISSUE: reference to a compiler-generated field
                        Func<XmlAttribute, string> func2 = XmlCommentsHelper.\u003C\u003Ec.\u003C\u003E9__15_4;
                        Func<XmlAttribute, string> selector;
                        if (func2 == null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          XmlCommentsHelper.\u003C\u003Ec.\u003C\u003E9__15_4 = selector = (Func<XmlAttribute, string>) (a => a.Value);
                        }
                        else
                          goto label_3;
label_28:
                        propName = source3.Select<XmlAttribute, string>(selector).FirstOrDefault<string>();
                        num2 = 17;
                        continue;
label_3:
                        selector = func2;
                        goto label_28;
label_35:
                        predicate = func1;
                        goto label_26;
                      case 7:
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 6 : 4;
                        continue;
                      case 8:
                        if (parameterInfo1.ParameterType.IsArray)
                        {
                          // ISSUE: reference to a compiler-generated method
                          type2 = XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik((object) parameterInfo1).GetElementType();
                          goto label_32;
                        }
                        else
                        {
                          num2 = 5;
                          continue;
                        }
                      case 9:
                      case 12:
                        if (string.IsNullOrWhiteSpace(str3))
                        {
                          num2 = 10;
                          continue;
                        }
                        goto label_33;
                      case 10:
                        goto label_34;
                      case 11:
                        if (!propertyTypeArguments.TryGetValue(propName, out typeArgument))
                        {
                          num2 = 4;
                          continue;
                        }
                        goto case 3;
                      case 13:
                        if (parameterInfo1 != null)
                        {
                          // ISSUE: reference to a compiler-generated method
                          if (!XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik((object) parameterInfo1).IsGenericType)
                            goto case 8;
                          else
                            goto label_6;
                        }
                        else
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
                          continue;
                        }
                      case 15:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        parameterInfo2 = ((IEnumerable<ParameterInfo>) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.j3998qZBf8sLG53Yod4a((object) methodInfo)).FirstOrDefault<ParameterInfo>((Func<ParameterInfo, bool>) (i => (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_1.YyeKETZBStcQuKGDSFRF((object) i) == propName));
                        break;
                      case 17:
                        if (propertyTypeArguments == null)
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 6 : 16;
                          continue;
                        }
                        goto case 11;
                      default:
                        goto label_33;
                    }
                    parameterInfo1 = parameterInfo2;
                    num2 = 13;
                    continue;
label_32:
                    str3 = type2.ParameterPath();
                    num2 = 9;
                  }
label_6:
                  num1 = 2;
                }
label_33:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return ((string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.kowDEQZB8FvSmU3pV7rd((object) new string[7]
                {
                  (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(-1858887263 ^ -1859075871),
                  propName,
                  (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(-649342099 - -1150814748 ^ 501267671),
                  p.InnerXml,
                  !XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.mQK7E6ZBvawXbbZPxlNh(XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.BuWtoQZBCg6HOLYqXnY3((object) p)) ? (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(1142330761 ^ 1541959139 ^ 536590178) : "",
                  str3,
                  (string) XmlCommentsHelper.\u003C\u003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(-710283084 ^ -537863435 ^ 173689639)
                })).SplittedComment(true);
label_34:
                return p.OuterXml.SplittedComment(true);
              })));
            }
            XmlNode xmlNode5 = xmlNode1.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957510636));
            if (xmlNode5 != null && !xmlNode5.OuterXml.IsNullOrEmpty())
              fullCommentsTrivia.Add(xmlNode5.OuterXml.SplittedComment(true));
          }
        }
        else
          break;
      }
      return (IEnumerable<ISyntaxTrivia>) fullCommentsTrivia;
    }

    /// <summary>Путь типа параметра для PublicAPI</summary>
    /// <param name="metadata">Метаданные типа</param>
    /// <returns>Путь типа параметра для PublicAPI</returns>
    internal static string ParameterPath(this EntityMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return XmlCommentsHelper.ParameterPath(XmlCommentsHelper.snROSRfPNtus824D2Jmr((object) PublicApiCodeGenerator.Current, (object) metadata));
label_5:
      return (string) null;
    }

    /// <summary>Путь типа параметра для PublicAPI</summary>
    /// <param name="type">Тип</param>
    /// <returns>Путь типа параметра для PublicAPI</returns>
    public static string ParameterPath(this Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (XmlCommentsHelper.xEwP3ufP3POeeJGqbH03(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (XmlCommentsHelper.tOdVtLfPpDGLarmLkxPE((object) type.Namespace, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883137628)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) XmlCommentsHelper.TOScXSfPtPr2GrMVYiX4(XmlCommentsHelper.p8j3jgfPD0L8KMtciLR6(XmlCommentsHelper.aJIwqJfPaSgHGYE31vo8(), type));
label_5:
      return (string) null;
    }

    private static string ParameterPath(object path)
    {
      int num1 = 6;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              obj = XmlCommentsHelper.PvmvBFfPwQ5QvJsmlmGk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44674449));
              break;
            case 2:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(path, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(654297945 ^ 653952401)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
                continue;
              }
              goto case 4;
            case 3:
              if (!XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(path, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-70007027 ^ -69826139)))
                goto case 2;
              else
                goto label_8;
            case 4:
              obj = (object) EleWise.ELMA.SR.T((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-35995181 ^ -36151427));
              break;
            case 5:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(path, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-138018305 ^ -138195083)))
              {
                num2 = 8;
                continue;
              }
              goto case 3;
            case 6:
              if (path != null)
              {
                num2 = 5;
                continue;
              }
              goto label_12;
            case 7:
              goto label_12;
            case 8:
              obj = XmlCommentsHelper.PvmvBFfPwQ5QvJsmlmGk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882334050));
              break;
            case 9:
              obj = XmlCommentsHelper.PvmvBFfPwQ5QvJsmlmGk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236016041));
              break;
            default:
              goto label_15;
          }
          str = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
        }
label_8:
        num1 = 9;
      }
label_12:
      return (string) null;
label_15:
      return (string) XmlCommentsHelper.dGpYNJfP4jF2w4Ys0Hb4((object) new string[5]
      {
        str,
        (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(516838154 ^ 516627458),
        (string) XmlCommentsHelper.PvmvBFfPwQ5QvJsmlmGk(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1824388195 ^ -1824045939)),
        (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-787452571 ^ -787479247),
        (string) path
      });
    }

    public static string GetFullComments(this MethodInfo methodInfo)
    {
      int num = 1;
      StringBuilder stringBuilder;
      while (true)
      {
        XmlNode xmlNode1;
        XmlNode xmlNode2;
        Type type;
        XmlDocument xmlDocument;
        string str1;
        string str2;
        string str3;
        object obj;
        MethodInfo methodInfo1;
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            XmlCommentsHelper.xGDAIJfPHLkMKbc349ay((object) stringBuilder, XmlCommentsHelper.UZ5QaOfPKBai9gLKJZh6((object) xmlNode2));
            num = 14;
            continue;
          case 3:
            str2 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(~-122002947 ^ 121688366), (object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 11 : 16;
            continue;
          case 4:
            if (XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
            {
              num = 17;
              continue;
            }
            goto label_4;
          case 5:
            if (XmlCommentsHelper.gJ144afPeYxHb5qPQSaw((object) methodInfo1).Length == 0)
            {
              num = 20;
              continue;
            }
            goto case 7;
          case 6:
          case 8:
            goto label_4;
          case 7:
            string str4 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642990344);
            string separator = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643773687);
            ParameterInfo[] parameters = methodInfo1.GetParameters();
            Func<ParameterInfo, string> func;
            Func<ParameterInfo, string> func1 = func;
            // ISSUE: reference to a compiler-generated method
            Func<ParameterInfo, string> selector = func1 == null ? (func = (Func<ParameterInfo, string>) (a => XmlCommentsHelper.GetParameterName(XmlCommentsHelper.\u003C\u003Ec__DisplayClass19_0.aHhI7SZBXRyiDxO1Dyol((object) a), (object) methodInfo1))) : func1;
            IEnumerable<string> values = ((IEnumerable<ParameterInfo>) parameters).Select<ParameterInfo, string>(selector);
            string str5 = string.Join(separator, values);
            obj = XmlCommentsHelper.BnNor0fPRitOybv6Tyof((object) str4, (object) str5);
            break;
          case 9:
            if (!XmlCommentsHelper.lGUZv2fP1ivmhLi3TSbB(XmlCommentsHelper.UZ5QaOfPKBai9gLKJZh6((object) xmlNode2)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
              continue;
            }
            goto case 13;
          case 10:
            stringBuilder = new StringBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 27;
            continue;
          case 11:
            if (xmlNode2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 13 : 13;
              continue;
            }
            goto case 9;
          case 12:
          case 25:
            if (!XmlCommentsHelper.eXQR4FfP2epSgYso1I4J(type, (Type) null))
            {
              num = 6;
              continue;
            }
            goto case 23;
          case 13:
          case 14:
          case 18:
            type = type.BaseType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 12 : 9;
            continue;
          case 15:
            if (xmlNode1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 18;
              continue;
            }
            goto case 22;
          case 16:
            xmlNode1 = (XmlNode) XmlCommentsHelper.ErWIonfPqQZlg9mlDawj((object) xmlDocument, (object) str2);
            num = 15;
            continue;
          case 17:
          case 21:
            xmlDocument = (XmlDocument) XmlCommentsHelper.iQGvKrfPV6nRtSBiuoeU((object) ((string) XmlCommentsHelper.dhi413fPZ5ra0BrHcU5K((object) type.Assembly)).Replace((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-710283084 ^ -537863435 ^ 173567739), (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876098335)));
            num = 24;
            continue;
          case 19:
            str1 = (string) XmlCommentsHelper.FU51UOfP6vCl88Fsed45(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(95909607 + 343705423 ^ 439793068), XmlCommentsHelper.sDOFiIfPIXaEYaK9AFMC((object) type.FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541746089), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021403569)), XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) methodInfo1), (object) str3);
            num = 3;
            continue;
          case 20:
            obj = (object) string.Empty;
            break;
          case 22:
            xmlNode2 = (XmlNode) XmlCommentsHelper.ErWIonfPqQZlg9mlDawj((object) xmlNode1, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(381945751 ^ 1158627804 ^ 1406012339));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 5 : 11;
            continue;
          case 23:
            if (!XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv(XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) type), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409240250)))
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 24:
            if (xmlDocument != null)
            {
              num = 5;
              continue;
            }
            goto label_10;
          case 26:
            goto label_10;
          case 27:
            type = XmlCommentsHelper.FKylgtfPSQL65EskRmiu((object) methodInfo1);
            num = 25;
            continue;
          default:
            methodInfo1 = methodInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 7 : 10;
            continue;
        }
        str3 = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 11 : 19;
      }
label_4:
      return stringBuilder.ToString();
label_10:
      return (string) null;
    }

    /// <summary>
    /// Навешивает атрибуты, чтобы данный класс не отображался в автокомплите
    /// </summary>
    /// <param name="target"></param>
    public static ISyntaxNode MakeClassHide(this ISyntaxNode target)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            target.AddAttributes(TypeOf<ShowDefaultMethodsAttribute>.Raw.CreateAttribute((object) false), TypeOf<BrowsableAttribute>.Raw.CreateAttribute((object) false), TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute((object) EditorBrowsableState.Never));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return target;
    }

    /// <summary>Определяет направление параметра</summary>
    public static RefKind GetParameterDirection(this ParameterInfo parameterInfo)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (XmlCommentsHelper.yYBBnbfPAE2NDhsvDLKo((object) parameterInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_7;
            case 3:
              if (XmlCommentsHelper.rhO8LyfP7uxJwIJJW1id((object) parameterInfo))
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 4:
              goto label_8;
            case 5:
              goto label_9;
            default:
              if (!XmlCommentsHelper.rhO8LyfP7uxJwIJJW1id((object) parameterInfo))
                goto case 3;
              else
                goto label_4;
          }
        }
label_4:
        num1 = 5;
      }
label_7:
      return RefKind.None;
label_8:
      return RefKind.Out;
label_9:
      return RefKind.Ref;
    }

    /// <summary>Получить выражение для параметров метода</summary>
    public static ISyntaxNode GetParameterBindingExpression(this ParameterInfo parameterInfo)
    {
      int num1 = 8;
      ISyntaxNode bindingExpression;
      ISyntaxNode syntaxNode;
      while (true)
      {
        int num2 = num1;
        Type genericTypeDefinition;
        Type[] genericArguments;
        while (true)
        {
          switch (num2)
          {
            case 1:
              syntaxNode = (ISyntaxNode) XmlCommentsHelper.ysajwqfPMbVMHbK7h9BJ(genericArguments[0]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 2:
            case 6:
              goto label_12;
            case 3:
              if (!genericTypeDefinition.IsAssignableFrom(System.Reflection.TypeOf.IDictionary.Raw))
                goto case 9;
              else
                goto label_7;
            case 4:
              if (genericArguments.Length == 0)
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 5:
              Type[] interfaces = (genericTypeDefinition = XmlCommentsHelper.wvnQiFfPmDk22kmFanF3((object) parameterInfo).GetGenericTypeDefinition()).GetInterfaces();
              // ISSUE: reference to a compiler-generated field
              Func<Type, bool> func = XmlCommentsHelper.\u003C\u003Ec.\u003C\u003E9__22_0;
              Func<Type, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                XmlCommentsHelper.\u003C\u003Ec.\u003C\u003E9__22_0 = predicate = (Func<Type, bool>) (i => i.IsAssignableFrom(XmlCommentsHelper.\u003C\u003Ec.Kw4PcWZFYopJwlaWptoZ((object) System.Reflection.TypeOf.IEnumerable)));
              }
              else
                goto label_18;
label_16:
              if (((IEnumerable<Type>) interfaces).Any<Type>(predicate))
              {
                num2 = 3;
                continue;
              }
              goto label_12;
label_18:
              predicate = func;
              goto label_16;
            case 7:
              goto label_10;
            case 8:
              bindingExpression = (ISyntaxNode) XmlCommentsHelper.aO5CEufP0qQNanH6LEIB(XmlCommentsHelper.IpkfwGfPxxv5T2aTXcq2((object) parameterInfo));
              num2 = 7;
              continue;
            case 9:
              if (!genericTypeDefinition.IsAssignableFrom(XmlCommentsHelper.L5KjGFfPyIfYPr86HZbu((object) System.Reflection.TypeOf.List)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
                continue;
              }
              goto label_12;
            default:
              goto label_11;
          }
        }
label_7:
        num1 = 6;
        continue;
label_10:
        genericArguments = XmlCommentsHelper.wvnQiFfPmDk22kmFanF3((object) parameterInfo).GetGenericArguments();
        num1 = 4;
      }
label_11:
      return ((ISyntaxNode) XmlCommentsHelper.gp8ltDfPJ58kURCUM1Th(XmlCommentsHelper.ysajwqfPMbVMHbK7h9BJ(EleWise.ELMA.SDK.TypeOf.EnumerableExtensions.Raw), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1871102631).GenericName(syntaxNode))).InvocationExpression(bindingExpression);
label_12:
      return bindingExpression;
    }

    private static XmlDocument LoadIfNotContains(object path)
    {
      int num1 = 2;
      XmlDocument xmlDocument1;
      string path1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            path1 = (string) path;
            num1 = 5;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_7;
          case 5:
            // ISSUE: reference to a compiler-generated method
            xmlDocument1 = XmlCommentsHelper.XmlDocuments.FirstOrDefault<XmlDocument>((Func<XmlDocument, bool>) (a => XmlCommentsHelper.\u003C\u003Ec__DisplayClass23_0.ISMfHrZBOwqZBEQBMBPs((object) a.BaseURI, (object) path1)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            if (xmlDocument1 == null)
            {
              num1 = 4;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return xmlDocument1;
label_7:
      XmlDocument xmlDocument2;
      try
      {
        int num2;
        if (File.Exists((string) XmlCommentsHelper.Ts1mmSfP9asNyRai6uNd((object) new Uri(path1))))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
        else
          goto label_11;
label_9:
        XmlDocument xmlDocument3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              xmlDocument1 = xmlDocument3;
              num2 = 5;
              continue;
            case 3:
              XmlCommentsHelper.U3tWGxfPdk2tcFNZFSGG((object) xmlDocument3, (object) path1);
              num2 = 7;
              continue;
            case 4:
              goto label_6;
            case 5:
              goto label_5;
            case 6:
              goto label_11;
            case 7:
              XmlCommentsHelper.XmlDocuments.Add(xmlDocument3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
              continue;
            default:
              xmlDocument3 = new XmlDocument();
              num2 = 3;
              continue;
          }
        }
label_11:
        xmlDocument2 = (XmlDocument) null;
        num2 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        {
          num2 = 4;
          goto label_9;
        }
        else
          goto label_9;
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_6;
            default:
              xmlDocument2 = (XmlDocument) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
          }
        }
      }
label_6:
      return xmlDocument2;
    }

    private static string GetParameterName(Type parameterType, object methodInfo)
    {
      int num1 = 34;
      string parameterName1;
      while (true)
      {
        int num2 = num1;
        int num3;
        string str1;
        string str2;
        string str3;
        int num4;
        string parameterName2;
        string str4;
        string str5;
        Type[] genericArguments;
        while (true)
        {
          switch (num2)
          {
            case 1:
              parameterName2 = XmlCommentsHelper.GetParameterName(parameterType.GetGenericArguments()[0], methodInfo);
              num2 = 7;
              continue;
            case 2:
              parameterName1 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671783429), (object) num3);
              num2 = 25;
              continue;
            case 3:
            case 39:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv((object) str2, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(647913418 ^ 647682088)))
              {
                num2 = 23;
                continue;
              }
              goto label_39;
            case 4:
            case 22:
              if (!parameterType.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 9;
                continue;
              }
              goto case 1;
            case 5:
              parameterName1 = (string) XmlCommentsHelper.qc9MLnfPiHGe3mBwlrRI(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-342626196 - 1290888215 ^ -1633166119), (object) str5, (object) parameterName2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 46;
              continue;
            case 6:
              if (parameterType.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 35 : 0;
                continue;
              }
              goto case 4;
            case 7:
              str5 = (string) XmlCommentsHelper.qc9MLnfPiHGe3mBwlrRI(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(~289714581 ^ -289731480), (object) parameterType.Namespace, XmlCommentsHelper.DWTcDYfPjqf3Rby3ZvkI((object) str2, 0, XmlCommentsHelper.GNHGu6fP55qfpixELMeH((object) str2, '`')));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 5 : 0;
              continue;
            case 8:
            case 9:
              if (!((IEnumerable<Type>) XmlCommentsHelper.FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments()).Contains<Type>(parameterType))
              {
                num2 = 37;
                continue;
              }
              goto case 26;
            case 10:
              if (XmlCommentsHelper.fIVbeSfPLmY1jldLxqll(methodInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 29 : 11;
                continue;
              }
              goto label_49;
            case 11:
              str4 = (string) XmlCommentsHelper.mPRE5lfPrwD5hpFUF794((object) str4, str4.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461645673), StringComparison.Ordinal), XmlCommentsHelper.I5FZkQfPTc8nUHfpifcI((object) str4) - XmlCommentsHelper.n48kIZfPl9eSdX7yUCNB((object) str4, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(647913418 ^ 647892282), StringComparison.Ordinal));
              num2 = 20;
              continue;
            case 12:
              str3 = (string) XmlCommentsHelper.qc9MLnfPiHGe3mBwlrRI(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1218962250 ^ 1218622306), (object) genericArguments[0].FullName, (object) genericArguments[1].FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 4 : 18;
              continue;
            case 13:
              if (!XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv((object) str2, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1978478350 ^ -1978247408)))
              {
                num2 = 4;
                continue;
              }
              goto case 15;
            case 14:
            case 16:
            case 21:
            case 25:
            case 38:
            case 40:
            case 46:
              goto label_39;
            case 15:
            case 36:
              if (!XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv((object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221815032)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                continue;
              }
              goto case 45;
            case 17:
              parameterName1 = (string) XmlCommentsHelper.w72m2AfPgMkSnj35h1oJ(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(--1333735954 ^ 1333427652), (object) str1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239578522));
              num2 = 3;
              continue;
            case 18:
              parameterName1 = (string) XmlCommentsHelper.w72m2AfPgMkSnj35h1oJ(XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1824388195 ^ -1824040025), (object) str3, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1021410165 ^ 1021409125));
              num2 = 38;
              continue;
            case 19:
              goto label_49;
            case 20:
              parameterName1 = (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(825385222 ^ 825700020) + str4 + (string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1858887263 ^ -1858884175);
              num2 = 30;
              continue;
            case 23:
              genericArguments = parameterType.GetGenericArguments();
              num2 = 12;
              continue;
            case 24:
              parameterName1 = string.Format((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-105199646 ^ -104884410), (object) num4);
              num2 = 14;
              continue;
            case 26:
              parameterName1 = (string) XmlCommentsHelper.BnNor0fPRitOybv6Tyof((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138619044), (object) XmlCommentsHelper.IH8vXifPY5u4VQH9ivst((object) ((MemberInfo) methodInfo).DeclaringType.GetGenericArguments(), (object) parameterType));
              num2 = 16;
              continue;
            case 27:
              parameterName1 = string.Format((string) XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(694673736 ^ -23604109 ^ -671783541), (object) XmlCommentsHelper.IH8vXifPY5u4VQH9ivst((object) XmlCommentsHelper.FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments(), (object) parameterType.GetElementType()));
              num2 = 21;
              continue;
            case 28:
              parameterName1 = parameterType.FullName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 31 : 40;
              continue;
            case 29:
              num3 = XmlCommentsHelper.IH8vXifPY5u4VQH9ivst(XmlCommentsHelper.YPbWGkfPUkhx1ENZpKlM(methodInfo), (object) parameterType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 2;
              continue;
            case 31:
              if (!str2.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710227632)))
                goto case 13;
              else
                goto label_47;
            case 32:
              str1 = (string) XmlCommentsHelper.mPRE5lfPrwD5hpFUF794((object) parameterType.FullName, 0, XmlCommentsHelper.n48kIZfPl9eSdX7yUCNB((object) parameterType.FullName, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(825385222 ^ 825304146), StringComparison.Ordinal) + 2);
              num2 = 44;
              continue;
            case 33:
              goto label_10;
            case 34:
              parameterName1 = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 33 : 2;
              continue;
            case 35:
              if (XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv((object) str2, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(-1852837372 ^ -1853178494)))
                goto case 15;
              else
                goto label_45;
            case 37:
            case 43:
              if (parameterType.IsArray)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 41 : 16;
                continue;
              }
              goto case 42;
            case 41:
              if (((IEnumerable<Type>) XmlCommentsHelper.FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments()).Contains<Type>(parameterType.GetElementType()))
              {
                num2 = 27;
                continue;
              }
              goto case 42;
            case 42:
              if (parameterType.IsGenericParameter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 10 : 0;
                continue;
              }
              goto case 28;
            case 44:
              str1 = (string) XmlCommentsHelper.mPRE5lfPrwD5hpFUF794((object) str1, XmlCommentsHelper.n48kIZfPl9eSdX7yUCNB((object) str1, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(381945751 ^ 1158627804 ^ 1405818043), StringComparison.Ordinal), XmlCommentsHelper.I5FZkQfPTc8nUHfpifcI((object) str1) - XmlCommentsHelper.n48kIZfPl9eSdX7yUCNB((object) str1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319441100), StringComparison.Ordinal));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 17;
              continue;
            case 45:
              str4 = (string) XmlCommentsHelper.mPRE5lfPrwD5hpFUF794((object) parameterType.FullName, 0, XmlCommentsHelper.n48kIZfPl9eSdX7yUCNB((object) parameterType.FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575937808), StringComparison.Ordinal) + 2);
              num2 = 11;
              continue;
            default:
              if (!XmlCommentsHelper.MZCJZZfPON0o9tX39Kpv((object) str2, XmlCommentsHelper.e1cmPPfPuRCc6J13BtBX(1461825605 - 1531863589 ^ -69860934)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 36 : 39;
                continue;
              }
              goto case 32;
          }
        }
label_10:
        str2 = (string) XmlCommentsHelper.yotysmfPn0liKKjBVZTD((object) parameterType);
        num1 = 6;
        continue;
label_45:
        num1 = 31;
        continue;
label_47:
        num1 = 36;
        continue;
label_49:
        num4 = XmlCommentsHelper.IH8vXifPY5u4VQH9ivst((object) XmlCommentsHelper.FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments(), (object) parameterType);
        num1 = 24;
      }
label_39:
      return parameterName1;
    }

    internal static void vW3gDgfPvaYwuM3oFSid() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wuH6pgfPQbJBvBEUrQ0W() => XmlCommentsHelper.MdWBVxfPfScHqg4ATnvQ == null;

    internal static XmlCommentsHelper AM9IpDfPCNhfEemXJ922() => XmlCommentsHelper.MdWBVxfPfScHqg4ATnvQ;

    internal static Type RJnUHPfP86NBki4oNyrn([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object dhi413fPZ5ra0BrHcU5K([In] object obj0) => (object) ((Assembly) obj0).CodeBase;

    internal static object e1cmPPfPuRCc6J13BtBX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sDOFiIfPIXaEYaK9AFMC([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object iQGvKrfPV6nRtSBiuoeU([In] object obj0) => (object) XmlCommentsHelper.LoadIfNotContains(obj0);

    internal static Type FKylgtfPSQL65EskRmiu([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object qc9MLnfPiHGe3mBwlrRI([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object BnNor0fPRitOybv6Tyof([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object ErWIonfPqQZlg9mlDawj([In] object obj0, [In] object obj1) => (object) ((XmlNode) obj0).SelectSingleNode((string) obj1);

    internal static object UZ5QaOfPKBai9gLKJZh6([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static object zCuoZXfPXvCmRarckDKg([In] object obj0, [In] object obj1) => (object) ((string) obj0).TrimEnd((char[]) obj1);

    internal static int I5FZkQfPTc8nUHfpifcI([In] object obj0) => ((string) obj0).Length;

    internal static object vy8RWHfPkUXY7w0oXu0g([In] object obj0, [In] int obj1, [In] object obj2) => (object) ((string) obj0).Insert(obj1, (string) obj2);

    internal static object yotysmfPn0liKKjBVZTD([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool MZCJZZfPON0o9tX39Kpv([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static bool eXQR4FfP2epSgYso1I4J([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object gJ144afPeYxHb5qPQSaw([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object nbDWNsfPPrS9Phjcdixe([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static bool lGUZv2fP1ivmhLi3TSbB([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object snROSRfPNtus824D2Jmr([In] object obj0, [In] object obj1) => (object) ((PublicApiCodeGenerator) obj0).GetNodeFullPath((EntityMetadata) obj1);

    internal static bool xEwP3ufP3POeeJGqbH03([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool tOdVtLfPpDGLarmLkxPE([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object aJIwqJfPaSgHGYE31vo8() => (object) PublicApiCodeGenerator.Current;

    internal static object p8j3jgfPD0L8KMtciLR6([In] object obj0, Type type) => (object) ((PublicApiCodeGenerator) obj0).GetNodeFullPath(type);

    internal static object TOScXSfPtPr2GrMVYiX4([In] object obj0) => (object) XmlCommentsHelper.ParameterPath(obj0);

    internal static object PvmvBFfPwQ5QvJsmlmGk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object dGpYNJfP4jF2w4Ys0Hb4([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object FU51UOfP6vCl88Fsed45(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object xGDAIJfPHLkMKbc349ay([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static bool yYBBnbfPAE2NDhsvDLKo([In] object obj0) => ((ParameterInfo) obj0).IsIn;

    internal static bool rhO8LyfP7uxJwIJJW1id([In] object obj0) => ((ParameterInfo) obj0).IsOut;

    internal static object IpkfwGfPxxv5T2aTXcq2([In] object obj0) => (object) ((ParameterInfo) obj0).Name;

    internal static object aO5CEufP0qQNanH6LEIB([In] object obj0) => (object) ((string) obj0).IdentifierName();

    internal static Type wvnQiFfPmDk22kmFanF3([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static Type L5KjGFfPyIfYPr86HZbu([In] object obj0) => ((RipeType) obj0).Raw;

    internal static object ysajwqfPMbVMHbK7h9BJ(Type type) => (object) type.CreateTypeSyntax();

    internal static object gp8ltDfPJ58kURCUM1Th([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).MemberAccessExpression((ISyntaxNode) obj1);

    internal static object Ts1mmSfP9asNyRai6uNd([In] object obj0) => (object) ((Uri) obj0).LocalPath;

    internal static void U3tWGxfPdk2tcFNZFSGG([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Load((string) obj1);

    internal static int n48kIZfPl9eSdX7yUCNB([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static object mPRE5lfPrwD5hpFUF794([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object w72m2AfPgMkSnj35h1oJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static int GNHGu6fP55qfpixELMeH([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object DWTcDYfPjqf3Rby3ZvkI([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static int IH8vXifPY5u4VQH9ivst([In] object obj0, [In] object obj1) => ((IEnumerable) obj0).IndexOf(obj1);

    internal static bool fIVbeSfPLmY1jldLxqll([In] object obj0) => ((MethodBase) obj0).IsGenericMethod;

    internal static object YPbWGkfPUkhx1ENZpKlM([In] object obj0) => (object) ((MethodBase) obj0).GetGenericArguments();
  }
}
