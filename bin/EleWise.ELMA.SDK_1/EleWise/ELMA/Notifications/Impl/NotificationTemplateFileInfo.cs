// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateFileInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Информация о файле шаблонов оповещений</summary>
  public class NotificationTemplateFileInfo
  {
    private NotificationTemplateLoader loader;
    private string name;
    private XmlDocument document;
    private XmlNode root;
    private List<NotificationTemplate> templates;
    private List<NotificationTemplate> defaultTemplates;
    private List<NotificationPartialTemplate> partials;
    private List<NotificationPartialExtensionTemplate> extensionTemplates;
    private Version version;
    private List<CustomMessage> customMessages;
    internal static NotificationTemplateFileInfo p9YlqMwXIwjxnXwuKZ5;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя файла шаблона</param>
    /// <param name="document">XML документа с шаблонами оповещений</param>
    public NotificationTemplateFileInfo(string name, XmlDocument document)
    {
      NotificationTemplateFileInfo.IqvZ1hwnU3GJuNHnNeW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 17;
      while (true)
      {
        int num2;
        string input;
        switch (num1)
        {
          case 1:
            this.name = name;
            num2 = 7;
            break;
          case 2:
            if (NotificationTemplateFileInfo.utJJkww1HSRU0FTRmwJ((object) ((string) NotificationTemplateFileInfo.JZ7DRWwPIEyFxjePSbc((object) this.root)).ToUpper(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767755229)))
            {
              num1 = 10;
              continue;
            }
            goto case 3;
          case 3:
            if (this.root != null)
            {
              num1 = 15;
              continue;
            }
            goto label_8;
          case 4:
            goto label_8;
          case 5:
          case 8:
            if (this.root != null)
            {
              num1 = 2;
              continue;
            }
            goto case 3;
          case 6:
            Version.TryParse(input, out this.version);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 12;
            continue;
          case 7:
            this.document = document;
            num1 = 13;
            continue;
          case 9:
            NotificationTemplateFileInfo.nT8vvnwOj8Ic6cZ1dOy((object) document, NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(647913418 ^ 647943182));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
            continue;
          case 11:
            goto label_23;
          case 12:
            goto label_19;
          case 13:
            this.root = document.FirstChild;
            num2 = 8;
            break;
          case 14:
            goto label_14;
          case 15:
            if (NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB(NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) this.root), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099717341)) == null)
            {
              num1 = 14;
              continue;
            }
            goto case 18;
          case 16:
            if (NotificationTemplateFileInfo.R8sYQuwa849IwgYL247((object) input))
            {
              num1 = 11;
              continue;
            }
            goto case 6;
          case 17:
            NotificationTemplateFileInfo.nT8vvnwOj8Ic6cZ1dOy((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727359648));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 9 : 8;
            continue;
          case 18:
            input = (string) NotificationTemplateFileInfo.KO3SOxwpqsFsWtDyWZd((object) ((XmlAttributeCollection) NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) this.root))[(string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(1051276242 - 990076387 ^ 61168027)]);
            num1 = 16;
            continue;
          default:
            this.root = (XmlNode) NotificationTemplateFileInfo.Y4lAexweILcKq3aI85K((object) this.root);
            num1 = 5;
            continue;
        }
        num1 = num2;
      }
label_23:
      return;
label_19:
      return;
label_14:
      return;
label_8:
      throw new Exception((string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(712480695 ^ 712449089));
    }

    /// <summary>Загрузчик шаблонов</summary>
    public NotificationTemplateLoader Loader => this.loader;

    /// <summary>Имя файла шаблонов</summary>
    public string Name => this.name;

    /// <summary>Документ XML</summary>
    public XmlDocument Document => this.document;

    /// <summary>Версия ELMA, которой соответствует шаблон</summary>
    public Version Version
    {
      get => this.version;
      set
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_7;
            case 1:
              NotificationTemplateFileInfo.LaDpmdwDTuMLX939wKf((object) (XmlElement) this.root, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867349383), (object) value.ToString());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              if (this.root == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
                continue;
              }
              goto case 1;
            case 4:
              this.version = value;
              num = 3;
              continue;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_2:
        return;
label_8:;
      }
    }

    /// <summary>Имя шаблона по умолчанию</summary>
    public string DefaultName
    {
      get => this.\u003CDefaultName\u003Ek__BackingField;
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
              this.\u003CDefaultName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Список шаблонов</summary>
    public IEnumerable<NotificationTemplate> Templates => (IEnumerable<NotificationTemplate>) this.templates;

    /// <summary>Список шаблонов по умолчанию</summary>
    public IEnumerable<NotificationTemplate> DefaultTemplates => (IEnumerable<NotificationTemplate>) this.defaultTemplates;

    /// <summary>Шаблоны расширений</summary>
    public IEnumerable<NotificationPartialExtensionTemplate> ExtensionTemplates => (IEnumerable<NotificationPartialExtensionTemplate>) this.extensionTemplates;

    /// <summary>Частичные шаблоны</summary>
    public IEnumerable<NotificationPartialTemplate> Partials => (IEnumerable<NotificationPartialTemplate>) this.partials;

    /// <summary>Список кастомных сообщений</summary>
    public IEnumerable<CustomMessage> CustomMessages => (IEnumerable<CustomMessage>) this.customMessages;

    /// <summary>Загрузить шаблоны оповещений</summary>
    /// <param name="loader">Загрузчик шаблонов</param>
    public void LoadTemplates(NotificationTemplateLoader loader)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        XmlNode xmlNode;
        string str1;
        while (true)
        {
          XmlElement node;
          NotificationTemplate notificationTemplate1;
          string str2;
          string str3;
          string str4;
          NotificationTemplate notificationTemplate2;
          string[] source1;
          string str5;
          string[] strArray;
          object obj;
          switch (num2)
          {
            case 1:
            case 8:
            case 15:
            case 26:
            case 27:
            case 33:
            case 38:
            case 40:
            case 50:
            case 52:
              xmlNode = (XmlNode) NotificationTemplateFileInfo.Y4lAexweILcKq3aI85K((object) xmlNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 56 : 33;
              continue;
            case 2:
              this.loader = loader;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 48 : 9;
              continue;
            case 3:
              NotificationTemplateFileInfo.nT8vvnwOj8Ic6cZ1dOy((object) loader, NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-606654180 ^ -606618214));
              num2 = 2;
              continue;
            case 4:
            case 28:
              notificationTemplate1 = new NotificationTemplate(this, node);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 6;
              continue;
            case 5:
              strArray = new string[0];
              goto label_73;
            case 6:
              this.templates.Add(notificationTemplate1);
              num2 = 40;
              continue;
            case 7:
              if (NotificationTemplateFileInfo.R8sYQuwa849IwgYL247((object) str5))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 15 : 3;
                continue;
              }
              goto case 49;
            case 9:
            case 34:
              if (xmlNode.Attributes[(string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-1120607109 - 305487170 ^ -1426126333)] == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 27 : 14;
                continue;
              }
              goto case 29;
            case 10:
              str3 = (string) NotificationTemplateFileInfo.z2o3Bkw4B7qoQ9X274T((object) xmlNode);
              num2 = 58;
              continue;
            case 11:
              xmlNode = this.root.FirstChild;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 5 : 55;
              continue;
            case 12:
            case 55:
            case 56:
              if (xmlNode != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 21 : 51;
                continue;
              }
              goto label_67;
            case 13:
              goto label_70;
            case 14:
              if (!NotificationTemplateFileInfo.xTtyqSwwRhSxOeHirb3((object) str4, NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(~-306453669 ^ 306483212)))
              {
                num2 = 21;
                continue;
              }
              goto case 39;
            case 16:
              if (NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB(NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) xmlNode), NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(1113862659 ^ 1113898799)) == null)
              {
                num2 = 41;
                continue;
              }
              goto label_64;
            case 17:
              xmlNode = (XmlNode) NotificationTemplateFileInfo.Y4lAexweILcKq3aI85K((object) xmlNode);
              num2 = 12;
              continue;
            case 18:
            case 35:
              if (NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB((object) xmlNode.Attributes, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740304690)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 1;
                continue;
              }
              goto case 31;
            case 19:
              this.extensionTemplates = new List<NotificationPartialExtensionTemplate>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            case 20:
              if (node != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 11 : 46;
                continue;
              }
              goto case 17;
            case 21:
              if (str4 == (string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(95909607 + 343705423 ^ 439580728))
              {
                num2 = 35;
                continue;
              }
              goto case 24;
            case 22:
              if (string.IsNullOrEmpty(str3))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 8 : 2;
                continue;
              }
              goto case 32;
            case 23:
              if (NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB(NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) this.root), NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(694673736 ^ -23604109 ^ -672089683)) != null)
              {
                num2 = 30;
                continue;
              }
              goto case 11;
            case 24:
              if (!NotificationTemplateFileInfo.xTtyqSwwRhSxOeHirb3((object) str4, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97936148)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 25;
                continue;
              }
              goto case 44;
            case 25:
              if (!NotificationTemplateFileInfo.xTtyqSwwRhSxOeHirb3((object) str4, NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-398663332 ^ -398692976)))
              {
                num2 = 54;
                continue;
              }
              goto case 16;
            case 29:
              List<CustomMessage> customMessages = this.customMessages;
              CustomMessage customMessage = new CustomMessage();
              customMessage.Key = new Pair<string, string>(((XmlNode) NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB((object) xmlNode.Attributes, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583774770))).Value, ((XmlNode) NotificationTemplateFileInfo.QOcmk5wxk856tFpw8o2((object) xmlNode)).Attributes[(string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-70007027 ^ -70011699)].Value);
              NotificationTemplateFileInfo.HCy2uLw0DwQNUh0eId9((object) customMessage, (object) ((XmlNode) NotificationTemplateFileInfo.QOcmk5wxk856tFpw8o2((object) xmlNode)).InnerText);
              customMessages.Add(customMessage);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
              continue;
            case 30:
              this.DefaultName = (string) NotificationTemplateFileInfo.KO3SOxwpqsFsWtDyWZd(NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB(NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) this.root), NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-1872275253 >> 6 ^ -29289995)));
              num2 = 11;
              continue;
            case 31:
              if (!NotificationTemplateFileInfo.xTtyqSwwRhSxOeHirb3(NotificationTemplateFileInfo.iODRKGwtXA02rIJDXCn((object) ((XmlAttributeCollection) NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) xmlNode))[(string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(1581325282 << 3 ^ -234335734)].Value), NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(~289714581 ^ -289713052)))
              {
                num2 = 50;
                continue;
              }
              goto case 4;
            case 32:
              List<NotificationPartialTemplate> partials = this.partials;
              NotificationPartialTemplate notificationPartialTemplate = new NotificationPartialTemplate();
              NotificationTemplateFileInfo.SBoQIUw6bMRrfaHm4lc((object) notificationPartialTemplate, (object) str2);
              NotificationTemplateFileInfo.We1dowwHJ2kcrFEiRXq((object) notificationPartialTemplate, (object) str3);
              partials.Add(notificationPartialTemplate);
              num2 = 38;
              continue;
            case 36:
              this.defaultTemplates.Add(notificationTemplate2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 31 : 33;
              continue;
            case 37:
            case 51:
              node = xmlNode as XmlElement;
              num2 = 20;
              continue;
            case 39:
              notificationTemplate2 = new NotificationTemplate(this, node);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 36 : 29;
              continue;
            case 41:
              goto label_50;
            case 42:
              this.customMessages = new List<CustomMessage>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 23;
              continue;
            case 43:
              goto label_24;
            case 44:
              if (((XmlAttributeCollection) NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) xmlNode))[(string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(236071375 ^ 236083727)] == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 27 : 45;
                continue;
              }
              obj = NotificationTemplateFileInfo.KO3SOxwpqsFsWtDyWZd(NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB((object) xmlNode.Attributes, NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-16752921 ^ -16765657)));
              break;
            case 45:
              obj = (object) null;
              break;
            case 46:
            case 57:
              str4 = (string) NotificationTemplateFileInfo.iODRKGwtXA02rIJDXCn(NotificationTemplateFileInfo.JZ7DRWwPIEyFxjePSbc((object) node));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 14 : 1;
              continue;
            case 47:
              str5 = (string) NotificationTemplateFileInfo.z2o3Bkw4B7qoQ9X274T((object) xmlNode);
              num2 = 7;
              continue;
            case 48:
              this.templates = new List<NotificationTemplate>();
              num2 = 19;
              continue;
            case 49:
              this.extensionTemplates.Add(new NotificationPartialExtensionTemplate()
              {
                Zones = ((IEnumerable<string>) source1).ToList<string>(),
                Content = str5
              });
              num2 = 26;
              continue;
            case 53:
              if (str1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 5 : 5;
                continue;
              }
              object source2 = NotificationTemplateFileInfo.k6ZS7mw7b7S4pbclfSX((object) str1, NotificationTemplateFileInfo.eRaw0JwATdpbejsXXPU(NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-1350312861 << 3 ^ 2082387908)));
              // ISSUE: reference to a compiler-generated field
              Func<string, string> func1 = NotificationTemplateFileInfo.\u003C\u003Ec.\u003C\u003E9__24_0;
              Func<string, string> selector;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                NotificationTemplateFileInfo.\u003C\u003Ec.\u003C\u003E9__24_0 = selector = (Func<string, string>) (s => (string) NotificationTemplateFileInfo.\u003C\u003Ec.UbVOEdfldvvRUXlMlTHC((object) s, NotificationTemplateFileInfo.\u003C\u003Ec.CIr1uUfl9pykKDMfyVwH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44665421))));
              }
              else
                goto label_75;
label_69:
              IEnumerable<string> source3 = ((IEnumerable<string>) source2).Select<string, string>(selector);
              // ISSUE: reference to a compiler-generated field
              Func<string, bool> func2 = NotificationTemplateFileInfo.\u003C\u003Ec.\u003C\u003E9__24_1;
              Func<string, bool> predicate;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                NotificationTemplateFileInfo.\u003C\u003Ec.\u003C\u003E9__24_1 = predicate = (Func<string, bool>) (s => s != "");
              }
              else
                goto label_74;
label_72:
              strArray = source3.Where<string>(predicate).ToArray<string>();
              goto label_73;
label_74:
              predicate = func2;
              goto label_72;
label_75:
              selector = func1;
              goto label_69;
            case 54:
              if (str4 == (string) NotificationTemplateFileInfo.cPrr6Tw2cS9f9Bbv8oo(-643786247 ^ -643820279))
              {
                num2 = 9;
                continue;
              }
              goto case 1;
            case 58:
              if (!NotificationTemplateFileInfo.R8sYQuwa849IwgYL247((object) str2))
              {
                num2 = 22;
                continue;
              }
              goto case 1;
            default:
              this.partials = new List<NotificationPartialTemplate>();
              num2 = 43;
              continue;
          }
          str2 = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 10 : 8;
          continue;
label_73:
          source1 = strArray;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 16 : 47;
        }
label_24:
        this.defaultTemplates = new List<NotificationTemplate>();
        num1 = 42;
        continue;
label_50:
        object obj1 = (object) null;
        goto label_65;
label_64:
        obj1 = NotificationTemplateFileInfo.KO3SOxwpqsFsWtDyWZd(NotificationTemplateFileInfo.EywJe6w34y5o8qyECtB(NotificationTemplateFileInfo.TEqe2fwNs33OmiKKm7e((object) xmlNode), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727392666)));
label_65:
        str1 = (string) obj1;
        num1 = 53;
      }
label_70:
      return;
label_67:;
    }

    internal static void IqvZ1hwnU3GJuNHnNeW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void nT8vvnwOj8Ic6cZ1dOy([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object cPrr6Tw2cS9f9Bbv8oo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Y4lAexweILcKq3aI85K([In] object obj0) => (object) ((XmlNode) obj0).NextSibling;

    internal static object JZ7DRWwPIEyFxjePSbc([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static bool utJJkww1HSRU0FTRmwJ([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object TEqe2fwNs33OmiKKm7e([In] object obj0) => (object) ((XmlNode) obj0).Attributes;

    internal static object EywJe6w34y5o8qyECtB([In] object obj0, [In] object obj1) => (object) ((XmlAttributeCollection) obj0)[(string) obj1];

    internal static object KO3SOxwpqsFsWtDyWZd([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static bool R8sYQuwa849IwgYL247([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool rEmh9pwTq1IsTBeBjXY() => NotificationTemplateFileInfo.p9YlqMwXIwjxnXwuKZ5 == null;

    internal static NotificationTemplateFileInfo OH34OVwk1XwouHxh0DY() => NotificationTemplateFileInfo.p9YlqMwXIwjxnXwuKZ5;

    internal static void LaDpmdwDTuMLX939wKf([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlElement) obj0).SetAttribute((string) obj1, (string) obj2);

    internal static object iODRKGwtXA02rIJDXCn([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static bool xTtyqSwwRhSxOeHirb3([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object z2o3Bkw4B7qoQ9X274T([In] object obj0) => (object) NotificationTemplate.GetContentAndTrim((XmlNode) obj0);

    internal static void SBoQIUw6bMRrfaHm4lc([In] object obj0, [In] object obj1) => ((NotificationPartialTemplate) obj0).Name = (string) obj1;

    internal static void We1dowwHJ2kcrFEiRXq([In] object obj0, [In] object obj1) => ((NotificationPartialTemplate) obj0).Content = (string) obj1;

    internal static object eRaw0JwATdpbejsXXPU([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object k6ZS7mw7b7S4pbclfSX([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object QOcmk5wxk856tFpw8o2([In] object obj0) => (object) ((XmlNode) obj0).FirstChild;

    internal static void HCy2uLw0DwQNUh0eId9([In] object obj0, [In] object obj1) => ((CustomMessage) obj0).Content = (string) obj1;
  }
}
