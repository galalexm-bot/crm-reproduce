// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.WebReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Tools.ServiceModel.SvcUtil;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel.Description;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Xml.Serialization;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>Веб-ссылка</summary>
  public class WebReference
  {
    private List<ScriptProjectItem> items;
    private string url;
    private string relativePath;
    private DiscoveryClientProtocol protocol;
    private string webReferencesDirectory;
    private string proxyNamespace;
    private string name;
    private string projectDirPath;
    private MetadataSet metadata;
    private static WebReference TK6Q9tBz91jKJcMu74O8;

    /// <summary>Cotr</summary>
    /// <param name="url">Адрес веб-сервиса</param>
    /// <param name="name">Имя</param>
    /// <param name="proxyNamespace">Пространство имен</param>
    /// <param name="protocol">Протокол для получения информации о сервисе XML</param>
    /// <param name="projectDirPath">Папка с проектом</param>
    /// <param name="metadata">Метаданные</param>
    public WebReference(
      string url,
      string name,
      string proxyNamespace,
      DiscoveryClientProtocol protocol,
      string projectDirPath,
      MetadataSet metadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.url = string.Empty;
      this.relativePath = string.Empty;
      this.webReferencesDirectory = string.Empty;
      this.proxyNamespace = string.Empty;
      this.name = string.Empty;
      this.projectDirPath = string.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num1 = 0;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.name = name;
            num1 = 3;
            continue;
          case 2:
            this.proxyNamespace = proxyNamespace;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
          case 3:
            this.GetRelativePath();
            num2 = 4;
            break;
          case 4:
            goto label_4;
          case 5:
            this.metadata = metadata;
            num1 = 7;
            continue;
          case 6:
            this.projectDirPath = projectDirPath;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 5;
            continue;
          case 7:
            this.protocol = protocol;
            num2 = 2;
            break;
          default:
            this.url = url;
            num1 = 6;
            continue;
        }
        num1 = num2;
      }
label_4:;
    }

    /// <summary>
    /// Checks that the string is valid to use for a web reference namespace.
    /// </summary>
    /// <param name="ns">Имя пространства имен</param>
    public static bool IsValidNamespace(string ns)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ns.Length > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 2:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_2:
      bool flag;
      try
      {
        WebReference.OP9OohBzr4gIMu3Vuk5E((object) new CodeNamespace(ns));
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_13;
          }
        }
      }
      catch (ArgumentException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_12;
        }
      }
label_13:
      return flag;
label_12:
      return false;
    }

    /// <summary>
    /// Checks that the string is valid to use for a web reference name.
    /// </summary>
    /// <param name="name">Имя ссылки</param>
    public static bool IsValidReferenceName(string name)
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
              if (WebReference.K7JCnoBzgUI7jDx5ZFXR((object) name) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              goto label_8;
            case 3:
              if (WebReference.ContainsInvalidDirectoryChar((object) name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            case 4:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_9:
        if (WebReference.RK35xjBz5ayFQnW0gkoO((object) name, '\\') == -1)
          num1 = 3;
        else
          goto label_8;
      }
label_7:
      return true;
label_8:
      return false;
    }

    /// <summary>
    /// Returns the reference name.  If the folder that will contain the
    /// web reference already exists this method looks for a new folder by
    /// adding a digit to the end of the reference name.
    /// </summary>
    /// <param name="webReferenceFolder">Папка с веб-ссылкой</param>
    /// <param name="name">Имя ссылки</param>
    public static string GetReferenceName(string webReferenceFolder, string name)
    {
      int num1 = 7;
      string referenceName;
      while (true)
      {
        int num2 = num1;
        int num3;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_6;
            case 4:
              ++num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 5:
            case 9:
              referenceName = (string) WebReference.KqUWBrBzY6N7MdrFsIu4((object) name, (object) num3.ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
              continue;
            case 6:
              referenceName = name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 7 : 8;
              continue;
            case 7:
              num3 = 1;
              num2 = 6;
              continue;
            case 8:
              str = (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) webReferenceFolder, (object) name);
              num2 = 3;
              continue;
            default:
              if (WebReference.WhOwGLBzLcUO13mhXRxV((object) str))
              {
                num2 = 9;
                continue;
              }
              goto label_6;
          }
        }
label_8:
        str = (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) webReferenceFolder, (object) referenceName);
        num1 = 4;
      }
label_6:
      return referenceName;
    }

    /// <summary>
    /// Gets the web references directory which is the parent folder for
    /// this web reference.
    /// </summary>
    public string WebReferencesDirectory => this.webReferencesDirectory;

    /// <summary>
    /// Gets the directory where the web reference files will be saved.
    /// </summary>
    public string Directory => Path.Combine(this.projectDirPath, this.relativePath);

    /// <summary>Gets or sets the name of the web reference.</summary>
    /// <remarks>
    /// Changing the name will also change the directory where the
    /// web reference files are saved.
    /// </remarks>
    public string Name
    {
      get => this.name;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.OnNameChanged();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Пространство имен</summary>
    public string ProxyNamespace
    {
      get => this.proxyNamespace;
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
              this.proxyNamespace = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
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

    /// <summary>Элементы проекта</summary>
    public List<ScriptProjectItem> Items
    {
      get
      {
        if (this.items == null)
          this.items = this.CreateProjectItems();
        return this.items;
      }
    }

    /// <summary>Получить имя файла с сгенерированным кодом</summary>
    public string WebProxyFileName => this.GetFullProxyFileName();

    /// <summary>Протокол</summary>
    public DiscoveryClientProtocol Protocol => this.protocol;

    /// <summary>Url адрес</summary>
    public string Url => this.url;

    /// <summary>Сохранить ссылку в файловой системе</summary>
    public void Save()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            System.IO.Directory.CreateDirectory(this.Directory);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          case 2:
            WebReference.zWv9VuBzsQUVf8413FJ2((object) this.protocol, (object) this.Directory, WebReference.qm7fbjBzUtxaUbQ7Db7n(1581325282 << 3 ^ -234267174));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 4;
            continue;
          case 3:
            this.GenerateWebProxy();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            this.CheckDocumentsNames();
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сохранить ссылку в файловой системе</summary>
    /// <param name="useSvcUtil">Использовать UseSvcUtil.exe</param>
    internal void Save(bool useSvcUtil)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.RunSvcUtil();
            num = 6;
            continue;
          case 2:
            if (!useSvcUtil)
            {
              this.GenerateWebProxy();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 3;
            continue;
          case 3:
            WebReference.zWv9VuBzsQUVf8413FJ2((object) this.protocol, (object) this.Directory, WebReference.qm7fbjBzUtxaUbQ7Db7n(-1978478350 ^ -1978445256));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
            continue;
          case 4:
            this.CheckDocumentsNames();
            num = 2;
            continue;
          case 5:
            System.IO.Directory.CreateDirectory(this.Directory);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 4 : 3;
            continue;
          case 6:
            goto label_2;
          case 7:
            goto label_4;
          default:
            WebReference.zWv9VuBzsQUVf8413FJ2((object) this.protocol, (object) this.Directory, WebReference.qm7fbjBzUtxaUbQ7Db7n(-1839087379 - 334718690 ^ 2121259201));
            num = 7;
            continue;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить путь до файла со сгенерированным кодом</summary>
    public string GetFullProxyFileName() => (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) this.projectDirPath, (object) this.GetProxyFileName());

    private void CheckDocumentsNames()
    {
      int num1 = 2;
      Regex regex;
      IEnumerator enumerator;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_24;
            case 2:
              str = new string(Path.GetInvalidFileNameChars());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            case 3:
              enumerator = (IEnumerator) WebReference.IBNxlAWFFSKWwENKL7Ia(WebReference.clRitvBzzu6Cveq96dIR(WebReference.bJvaoTBzc8aUtBbaaUsV((object) this.protocol)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_19;
            default:
              goto label_3;
          }
        }
label_24:
        regex = new Regex(string.Format((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(95909607 + 343705423 ^ 439559348), (object) Regex.Escape(str)));
        num1 = 3;
      }
label_19:
      return;
label_3:
      try
      {
label_11:
        if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator))
          goto label_13;
        else
          goto label_12;
label_5:
        NamedItem namedItem;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              WebReference.fixcwBWFhqaD5RivFbIb((object) namedItem, WebReference.vbVl8NWFbgCfkeEdfKJj((object) regex, WebReference.Vpx2w4WFWh5i06FoCY8E((object) namedItem), WebReference.qm7fbjBzUtxaUbQ7Db7n(2045296739 + 1688595713 ^ -561077986)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 2:
              if (namedItem != null)
              {
                num3 = 5;
                continue;
              }
              goto label_11;
            case 3:
              goto label_18;
            case 4:
              goto label_13;
            case 5:
              if (!WebReference.XNoa7UWFolZ9IirPkw93(WebReference.Vpx2w4WFWh5i06FoCY8E((object) namedItem)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
                continue;
              }
              goto label_11;
            default:
              goto label_11;
          }
        }
label_18:
        return;
label_12:
        num3 = 3;
        goto label_5;
label_13:
        namedItem = WebReference.RaM337WFBkKQYA3ibetf((object) enumerator) as NamedItem;
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        {
          num3 = 2;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (disposable == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              disposable.Dispose();
              num4 = 3;
              continue;
            default:
              goto label_23;
          }
        }
label_23:;
      }
    }

    private void RunSvcUtil()
    {
      int num1 = 3;
      while (true)
      {
        List<string> collection;
        List<string> values;
        string str1;
        List<string>.Enumerator enumerator;
        DirectoryInfo directoryInfo;
        string path;
        string str2;
        string str3;
        string contents;
        object obj1;
        object obj2;
        switch (num1)
        {
          case 1:
            values.AddRange((IEnumerable<string>) collection);
            num1 = 18;
            continue;
          case 2:
            List<string> stringList = new List<string>();
            stringList.Add((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-1317790512 ^ -1317691848));
            stringList.Add((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-812025778 ^ -812057930));
            stringList.Add((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(1505778440 - 1981636111 ^ -475824129));
            stringList.Add((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(516838154 ^ 516935700));
            directoryInfo = new DirectoryInfo(this.Directory);
            enumerator = stringList.GetEnumerator();
            num1 = 12;
            continue;
          case 3:
            collection = new List<string>();
            num1 = 2;
            continue;
          case 4:
            WebReference.XFhMZrWFICU6hD7a228e(WebReference.Dhy27eWFubMeHeMw8ln5(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867727452), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921216799), (IEnumerable<string>) values)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 5:
            obj1 = (object) "";
            goto label_42;
          case 6:
            if (!WebReference.XNoa7UWFolZ9IirPkw93((object) EleWise.ELMA.SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597111040))))
            {
              num1 = 20;
              continue;
            }
            goto case 17;
          case 7:
            str1 = (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) this.Directory, WebReference.qm7fbjBzUtxaUbQ7Db7n(-688192331 - 435440695 ^ -1123553886));
            num1 = 16;
            continue;
          case 8:
            if (File.Exists(path))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 9 : 15;
              continue;
            }
            goto case 13;
          case 9:
            obj1 = WebReference.y81rBEWFS1OS3Tin0n4P((object) str1);
            goto label_42;
          case 10:
            contents = (string) WebReference.o4kGfJWFR9P45yDjIUI7((object) Locator.GetServiceNotNull<ServiceReferenceHelper>(), (object) str2, (object) str3, (object) this.url);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 14 : 14;
            continue;
          case 11:
label_6:
            values = new List<string>()
            {
              (string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-1426456882 ^ 2009939514 ^ -583711804),
              (string) WebReference.KqUWBrBzY6N7MdrFsIu4(WebReference.qm7fbjBzUtxaUbQ7Db7n(-1350312861 << 3 ^ 2082431066), (object) this.Directory),
              (string) WebReference.QIrjpqWFQTrMancgpWgx((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638501027), (object) this.Directory, WebReference.qm7fbjBzUtxaUbQ7Db7n(~-306453669 ^ 306552818)),
              (string) WebReference.KqUWBrBzY6N7MdrFsIu4(WebReference.qm7fbjBzUtxaUbQ7Db7n(-1921202237 ^ -1921170249), (object) this.proxyNamespace),
              (string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-1839087379 - 334718690 ^ 2121259401),
              (string) WebReference.qm7fbjBzUtxaUbQ7Db7n(1012087039 ^ 1012054901),
              (string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-1334993905 ^ -1335091303) + this.Directory + (string) WebReference.qm7fbjBzUtxaUbQ7Db7n(572119659 - -337058038 ^ 909209803)
            };
            num1 = 6;
            continue;
          case 12:
            try
            {
label_15:
              if (enumerator.MoveNext())
                goto label_12;
              else
                goto label_16;
label_11:
              string current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (((IEnumerable<FileInfo>) WebReference.sLEaRQWFE0b8i37c746E((object) directoryInfo, (object) current)).Any<FileInfo>())
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_15;
                  case 2:
                    collection.Add((string) WebReference.WdZAjkWFfo38XVbooRtR(WebReference.qm7fbjBzUtxaUbQ7Db7n(-1824388195 ^ -1824359675), (object) this.Directory, (object) current));
                    num2 = 4;
                    continue;
                  case 3:
                    goto label_6;
                  case 4:
                    goto label_15;
                  default:
                    goto label_12;
                }
              }
label_12:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
              {
                num2 = 0;
                goto label_11;
              }
              else
                goto label_11;
label_16:
              num2 = 3;
              goto label_11;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 13:
            obj2 = (object) "";
            break;
          case 14:
            File.WriteAllText(Path.Combine(this.Directory, (string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-867826612 ^ -867729046)), contents);
            num1 = 19;
            continue;
          case 15:
            obj2 = WebReference.y81rBEWFS1OS3Tin0n4P((object) path);
            break;
          case 16:
            if (WebReference.TkPvAdWFiG0ZOrENl1HN((object) str1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 9 : 0;
              continue;
            }
            goto case 5;
          case 17:
            if (WebReference.kALaXQWFv2qy240XHn8B((object) collection) > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            }
            goto case 18;
          case 18:
            if (WebReference.bfRmRwWFZlfLumqCZ3Ij(WebReference.FrZD03WF8h8NbAAq72JZ((object) values)) == 0)
            {
              path = (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) this.Directory, WebReference.qm7fbjBzUtxaUbQ7Db7n(87862435 ^ 87894405));
              num1 = 8;
              continue;
            }
            num1 = 4;
            continue;
          case 19:
            goto label_27;
          case 20:
            values.AddRange((IEnumerable<string>) WebReference.i4faCCWFC8aDg2rhlaFk((object) EleWise.ELMA.SR.GetSetting((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(-643786247 ^ -643753393)), (object) new char[1]
            {
              ' '
            }, StringSplitOptions.RemoveEmptyEntries));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 17 : 15;
            continue;
          default:
            goto label_30;
        }
        str2 = (string) obj2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 7 : 3;
        continue;
label_42:
        str3 = (string) obj1;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 10 : 1;
      }
label_27:
      return;
label_30:
      throw new System.Exception((string) WebReference.lwTiEtWFVlob1EmKZsqm(WebReference.qm7fbjBzUtxaUbQ7Db7n(-1824388195 ^ -1824288995)));
    }

    private ServiceDescriptionCollection GetServiceDescriptionCollection(
      DiscoveryClientProtocol protocol)
    {
      int num1 = 1;
      ServiceDescriptionCollection descriptionCollection;
      IDictionaryEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            descriptionCollection = new ServiceDescriptionCollection();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_19;
          default:
            enumerator = ((DictionaryBase) WebReference.eo2jxTWFqi2xYoa1AUqu((object) protocol)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      try
      {
label_8:
        if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator))
          goto label_11;
        else
          goto label_9;
label_3:
        DictionaryEntry dictionaryEntry;
        ContractReference contractReference;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 3:
              object obj = dictionaryEntry.Value;
              num2 = 6;
              continue;
            case 4:
              contractReference = dictionaryEntry.Value as ContractReference;
              num2 = 3;
              continue;
            case 5:
              goto label_19;
            case 6:
              if (contractReference == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 7:
              WebReference.zyyFA5WFXGlk3bhsO1yc((object) descriptionCollection, WebReference.CHU2GFWFKsKNu9SU1uLi((object) contractReference));
              num2 = 2;
              continue;
            default:
              goto label_8;
          }
        }
label_9:
        num2 = 5;
        goto label_3;
label_11:
        dictionaryEntry = (DictionaryEntry) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator);
        num2 = 4;
        goto label_3;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 3;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 2:
              goto label_17;
            case 3:
              if (disposable == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                continue;
              }
              break;
          }
          WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 2;
        }
label_17:;
      }
label_19:
      return descriptionCollection;
    }

    private XmlSchemas GetXmlSchemas(DiscoveryClientProtocol protocol)
    {
      int num1 = 3;
      XmlSchemas xmlSchemas;
      IDictionaryEnumerator dictionaryEnumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_22;
          case 2:
            dictionaryEnumerator = (IDictionaryEnumerator) WebReference.LE5gPXWFk26a4ndsjVq1((object) protocol.References);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 3:
            xmlSchemas = new XmlSchemas();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      try
      {
label_10:
        if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) dictionaryEnumerator))
          goto label_8;
        else
          goto label_11;
label_5:
        SchemaReference schemaReference;
        DictionaryEntry dictionaryEntry;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              if (schemaReference == null)
              {
                num2 = 5;
                continue;
              }
              goto case 3;
            case 3:
              WebReference.txadjZWFOo6ik9SoKq4n((object) xmlSchemas, WebReference.cKk8vBWFnRRCo05ZLSBk((object) schemaReference));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            case 4:
              schemaReference = dictionaryEntry.Value as SchemaReference;
              num2 = 2;
              continue;
            case 6:
              goto label_22;
            default:
              goto label_10;
          }
        }
label_8:
        dictionaryEntry = (DictionaryEntry) WebReference.RaM337WFBkKQYA3ibetf((object) dictionaryEnumerator);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        {
          num2 = 4;
          goto label_5;
        }
        else
          goto label_5;
label_11:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 6 : 2;
        goto label_5;
      }
      finally
      {
        IDisposable disposable = dictionaryEnumerator as IDisposable;
        int num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_20;
            case 2:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              }
              goto label_20;
            default:
              WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
              continue;
          }
        }
label_20:;
      }
label_22:
      return xmlSchemas;
    }

    private void GenerateWebProxy()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebReference.OgspLDWF2vdlF6329MFp((object) this.proxyNamespace, (object) this.GetFullProxyFileName(), (object) this.GetServiceDescriptionCollection(this.protocol), (object) this.GetXmlSchemas(this.protocol));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void GenerateWebProxy(
      object proxyNamespace,
      object fileName,
      object serviceDescriptions,
      object schemas)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        ServiceDescriptionImporter descriptionImporter;
        CodeNamespace codeNamespace;
        CodeCompileUnit codeCompileUnit1;
        IEnumerator enumerator1;
        StreamWriter streamWriter1;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_25:
              enumerator1 = (IEnumerator) WebReference.aYoEhOWFPnuVI9NMYtey(schemas);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 2;
              continue;
            case 2:
              streamWriter1.Close();
              num2 = 9;
              continue;
            case 3:
              try
              {
label_12:
                if (enumerator1.MoveNext())
                  goto label_10;
                else
                  goto label_13;
label_9:
                System.Xml.Schema.XmlSchema xmlSchema;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      goto label_10;
                    case 3:
                      goto label_12;
                    default:
                      WebReference.txadjZWFOo6ik9SoKq4n((object) descriptionImporter.Schemas, (object) xmlSchema);
                      num3 = 3;
                      continue;
                  }
                }
label_10:
                xmlSchema = (System.Xml.Schema.XmlSchema) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator1);
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                {
                  num3 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
                goto label_9;
              }
              finally
              {
                IDisposable disposable = enumerator1 as IDisposable;
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (disposable == null)
                      {
                        num4 = 3;
                        continue;
                      }
                      goto case 2;
                    case 2:
                      WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_21;
                  }
                }
label_21:;
              }
            case 4:
label_5:
              codeNamespace = new CodeNamespace((string) proxyNamespace);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 5:
              enumerator1 = (IEnumerator) WebReference.aYoEhOWFPnuVI9NMYtey((object) codeCompileUnit1.Namespaces);
              num2 = 12;
              continue;
            case 6:
              int num5 = (int) descriptionImporter.Import(codeNamespace, codeCompileUnit1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 5 : 5;
              continue;
            case 7:
              try
              {
label_140:
                if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator1))
                  goto label_138;
                else
                  goto label_141;
label_137:
                System.Web.Services.Description.ServiceDescription current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_138;
                    case 2:
                      WebReference.psV3DjWFewiA44pRXv6c((object) descriptionImporter, (object) current, (object) null, (object) null);
                      num6 = 3;
                      continue;
                    case 3:
                      goto label_140;
                    default:
                      goto label_25;
                  }
                }
label_138:
                current = (System.Web.Services.Description.ServiceDescription) enumerator1.Current;
                num6 = 2;
                goto label_137;
label_141:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                goto label_137;
              }
              finally
              {
                IDisposable disposable = enumerator1 as IDisposable;
                int num7 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                  num7 = 2;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      if (disposable == null)
                      {
                        num7 = 3;
                        continue;
                      }
                      goto case 1;
                    default:
                      goto label_149;
                  }
                }
label_149:;
              }
            case 8:
              WebReference.q019EYWF16Nh32UTIaXO((object) codeCompileUnit1.Namespaces, (object) codeNamespace);
              num2 = 6;
              continue;
            case 9:
              goto label_147;
            case 10:
              enumerator1 = ((CollectionBase) serviceDescriptions).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 7;
              continue;
            case 11:
              goto label_22;
            case 12:
              try
              {
label_30:
                if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator1))
                  goto label_28;
                else
                  goto label_31;
label_27:
                IEnumerator enumerator2;
                int num8;
                switch (num8)
                {
                  case 1:
                    try
                    {
label_119:
                      if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator2))
                        goto label_49;
                      else
                        goto label_120;
label_33:
                      IEnumerator enumerator3;
                      CodeTypeDeclaration current;
                      int num9;
                      while (true)
                      {
                        switch (num9)
                        {
                          case 1:
                            goto label_49;
                          case 2:
label_51:
                            enumerator3 = ((CollectionBase) WebReference.GNEpSpWFtSVrZ6r2YQIW((object) current)).GetEnumerator();
                            num9 = 6;
                            continue;
                          case 3:
                            goto label_119;
                          case 4:
                            goto label_30;
                          case 5:
                            try
                            {
label_38:
                              if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator3))
                                goto label_40;
                              else
                                goto label_39;
label_35:
                              CodeAttributeDeclaration attributeDeclaration;
                              int num10;
                              while (true)
                              {
                                switch (num10)
                                {
                                  case 1:
                                  case 3:
                                    goto label_38;
                                  case 2:
                                    WebReference.XbR2HnWFDve8DA2Trpe8((object) attributeDeclaration, WebReference.ErCUhrWFa0irej5HwO9K(WebReference.qm7fbjBzUtxaUbQ7Db7n(-2138160520 ^ -2138061010), (object) attributeDeclaration.Name));
                                    num10 = 3;
                                    continue;
                                  case 4:
                                    goto label_51;
                                  case 5:
                                    if (WebReference.NoA0KrWFpWWF9ZEVH8jX(WebReference.kmVusIWF3Pn9etev4BlS((object) attributeDeclaration), WebReference.qm7fbjBzUtxaUbQ7Db7n(-649342099 - -1150814748 ^ 501373131)))
                                    {
                                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
                                      continue;
                                    }
                                    goto case 2;
                                  default:
                                    goto label_40;
                                }
                              }
label_39:
                              num10 = 4;
                              goto label_35;
label_40:
                              attributeDeclaration = (CodeAttributeDeclaration) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator3);
                              num10 = 3;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
                              {
                                num10 = 5;
                                goto label_35;
                              }
                              else
                                goto label_35;
                            }
                            finally
                            {
                              IDisposable disposable = enumerator3 as IDisposable;
                              int num11 = 2;
                              while (true)
                              {
                                switch (num11)
                                {
                                  case 1:
                                    WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                                    continue;
                                  case 2:
                                    if (disposable != null)
                                    {
                                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
                                      continue;
                                    }
                                    goto label_48;
                                  default:
                                    goto label_48;
                                }
                              }
label_48:;
                            }
                          case 6:
                            goto label_53;
                          default:
                            enumerator3 = (IEnumerator) WebReference.aYoEhOWFPnuVI9NMYtey(WebReference.RP49jbWFNDVhJiAms8Nt((object) current));
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 5 : 0;
                            continue;
                        }
                      }
label_53:
                      try
                      {
label_57:
                        if (enumerator3.MoveNext())
                          goto label_96;
                        else
                          goto label_58;
label_54:
                        CodeTypeMember codeTypeMember;
                        IEnumerator enumerator4;
                        int num12;
                        while (true)
                        {
                          switch (num12)
                          {
                            case 1:
label_55:
                              if (codeTypeMember is CodeMemberMethod)
                              {
                                num12 = 6;
                                continue;
                              }
                              goto label_57;
                            case 2:
                              enumerator4 = (IEnumerator) WebReference.aYoEhOWFPnuVI9NMYtey((object) codeTypeMember.CustomAttributes);
                              num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                              continue;
                            case 3:
                              goto label_57;
                            case 4:
                              goto label_97;
                            case 5:
                              goto label_119;
                            case 6:
                              enumerator4 = (IEnumerator) WebReference.aYoEhOWFPnuVI9NMYtey(WebReference.wmxtDfWFxRxaHxlmdMRb((object) (CodeMemberMethod) codeTypeMember));
                              num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 4;
                              continue;
                            case 7:
                              goto label_96;
                            default:
                              try
                              {
label_87:
                                if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator4))
                                  goto label_84;
                                else
                                  goto label_88;
label_62:
                                IEnumerator enumerator5;
                                CodeAttributeDeclaration attributeDeclaration;
                                int num13;
                                while (true)
                                {
                                  switch (num13)
                                  {
                                    case 1:
                                      goto label_55;
                                    case 2:
                                      goto label_87;
                                    case 3:
                                      goto label_84;
                                    case 4:
                                      if (!WebReference.NoA0KrWFpWWF9ZEVH8jX(WebReference.kmVusIWF3Pn9etev4BlS((object) attributeDeclaration), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16655451)))
                                      {
                                        num13 = 5;
                                        continue;
                                      }
                                      goto case 6;
                                    case 5:
                                      WebReference.XbR2HnWFDve8DA2Trpe8((object) attributeDeclaration, WebReference.ErCUhrWFa0irej5HwO9K(WebReference.qm7fbjBzUtxaUbQ7Db7n(-867826612 ^ -867729126), WebReference.kmVusIWF3Pn9etev4BlS((object) attributeDeclaration)));
                                      num13 = 6;
                                      continue;
                                    case 6:
                                      enumerator5 = (IEnumerator) WebReference.aYoEhOWFPnuVI9NMYtey(WebReference.zA9sXmWFwbmtFxvrYG1l((object) attributeDeclaration));
                                      num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                                      continue;
                                    default:
                                      goto label_63;
                                  }
                                }
label_63:
                                try
                                {
label_66:
                                  if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator5))
                                    goto label_74;
                                  else
                                    goto label_67;
label_65:
                                  CodeFieldReferenceExpression referenceExpression1;
                                  CodeTypeReferenceExpression referenceExpression2;
                                  int num14;
                                  while (true)
                                  {
                                    switch (num14)
                                    {
                                      case 1:
                                        goto label_74;
                                      case 2:
                                        referenceExpression2 = WebReference.HuhHG0WF6xDBDnTqPA0D((object) referenceExpression1) as CodeTypeReferenceExpression;
                                        num14 = 6;
                                        continue;
                                      case 3:
                                      case 4:
                                        goto label_66;
                                      case 5:
                                        if (referenceExpression1 != null)
                                        {
                                          num14 = 2;
                                          continue;
                                        }
                                        goto label_66;
                                      case 6:
                                        if (referenceExpression2 == null)
                                        {
                                          num14 = 4;
                                          continue;
                                        }
                                        goto case 7;
                                      case 7:
                                        WebReference.CVm5MwWF7Fw3tmgRs3pj(WebReference.HbXSfdWFHCpvssLsXjpI((object) referenceExpression2), (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413659977), WebReference.mksp0uWFARLJ5KE0FMSt((object) referenceExpression2.Type)));
                                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 3;
                                        continue;
                                      default:
                                        goto label_87;
                                    }
                                  }
label_67:
                                  num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                                  goto label_65;
label_74:
                                  referenceExpression1 = WebReference.sOTxxjWF4fbhvVlPxlhH((object) (CodeAttributeArgument) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator5)) as CodeFieldReferenceExpression;
                                  num14 = 5;
                                  goto label_65;
                                }
                                finally
                                {
                                  IDisposable disposable = enumerator5 as IDisposable;
                                  int num15 = 1;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                                    num15 = 1;
                                  while (true)
                                  {
                                    switch (num15)
                                    {
                                      case 1:
                                        if (disposable == null)
                                        {
                                          num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                                          continue;
                                        }
                                        goto case 2;
                                      case 2:
                                        disposable.Dispose();
                                        num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 3;
                                        continue;
                                      default:
                                        goto label_81;
                                    }
                                  }
label_81:;
                                }
label_84:
                                attributeDeclaration = (CodeAttributeDeclaration) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator4);
                                num13 = 4;
                                goto label_62;
label_88:
                                num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
                                goto label_62;
                              }
                              finally
                              {
                                IDisposable disposable = enumerator4 as IDisposable;
                                int num16 = 2;
                                while (true)
                                {
                                  switch (num16)
                                  {
                                    case 1:
                                      goto label_94;
                                    case 2:
                                      if (disposable != null)
                                      {
                                        num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                                        continue;
                                      }
                                      goto label_94;
                                    default:
                                      WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
                                      continue;
                                  }
                                }
label_94:;
                              }
                          }
                        }
label_97:
                        try
                        {
label_101:
                          if (WebReference.gnJE1oWFGBUpTUSAyVpe((object) enumerator4))
                            goto label_104;
                          else
                            goto label_102;
label_98:
                          CodeAttributeDeclaration attributeDeclaration;
                          int num17;
                          while (true)
                          {
                            switch (num17)
                            {
                              case 1:
                                goto label_104;
                              case 2:
                                if (!attributeDeclaration.Name.StartsWith((string) WebReference.qm7fbjBzUtxaUbQ7Db7n(1021410165 ^ 1021378103)))
                                {
                                  num17 = 3;
                                  continue;
                                }
                                goto label_101;
                              case 3:
                                WebReference.XbR2HnWFDve8DA2Trpe8((object) attributeDeclaration, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909211191), (object) attributeDeclaration.Name));
                                num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 3;
                                continue;
                              case 4:
                                goto label_101;
                              default:
                                goto label_57;
                            }
                          }
label_102:
                          num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                          goto label_98;
label_104:
                          attributeDeclaration = (CodeAttributeDeclaration) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator4);
                          num17 = 2;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                          {
                            num17 = 0;
                            goto label_98;
                          }
                          else
                            goto label_98;
                        }
                        finally
                        {
                          IDisposable disposable = enumerator4 as IDisposable;
                          int num18 = 2;
                          while (true)
                          {
                            switch (num18)
                            {
                              case 1:
                                goto label_111;
                              case 2:
                                if (disposable != null)
                                {
                                  num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_111;
                              default:
                                WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                                continue;
                            }
                          }
label_111:;
                        }
label_58:
                        num12 = 5;
                        goto label_54;
label_96:
                        codeTypeMember = (CodeTypeMember) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator3);
                        num12 = 2;
                        goto label_54;
                      }
                      finally
                      {
                        IDisposable disposable = enumerator3 as IDisposable;
                        int num19 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                          num19 = 0;
                        while (true)
                        {
                          switch (num19)
                          {
                            case 1:
                              WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                              num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
                              continue;
                            case 2:
                              goto label_118;
                            default:
                              if (disposable != null)
                              {
                                num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
                                continue;
                              }
                              goto label_118;
                          }
                        }
label_118:;
                      }
label_49:
                      current = (CodeTypeDeclaration) enumerator2.Current;
                      num9 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
                      {
                        num9 = 0;
                        goto label_33;
                      }
                      else
                        goto label_33;
label_120:
                      num9 = 4;
                      goto label_33;
                    }
                    finally
                    {
                      IDisposable disposable = enumerator2 as IDisposable;
                      int num20 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                        num20 = 0;
                      while (true)
                      {
                        switch (num20)
                        {
                          case 1:
                            if (disposable != null)
                            {
                              num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                              continue;
                            }
                            goto label_127;
                          case 2:
                            goto label_127;
                          default:
                            WebReference.H5LVm2WFTPe2xL6ZPAGD((object) disposable);
                            num20 = 2;
                            continue;
                        }
                      }
label_127:;
                    }
                  case 2:
                    goto label_6;
                  case 3:
                    goto label_30;
                }
label_28:
                enumerator2 = ((CodeNamespace) WebReference.RaM337WFBkKQYA3ibetf((object) enumerator1)).Types.GetEnumerator();
                num8 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                {
                  num8 = 1;
                  goto label_27;
                }
                else
                  goto label_27;
label_31:
                num8 = 2;
                goto label_27;
              }
              finally
              {
                IDisposable disposable = enumerator1 as IDisposable;
                int num21 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                  num21 = 1;
                while (true)
                {
                  switch (num21)
                  {
                    case 1:
                      if (disposable != null)
                      {
                        num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_134;
                    case 2:
                      goto label_134;
                    default:
                      disposable.Dispose();
                      num21 = 2;
                      continue;
                  }
                }
label_134:;
              }
            case 13:
label_6:
              object obj = WebReference.qm5NbHWF0tiqCBFc4PrE(WebReference.qm7fbjBzUtxaUbQ7Db7n(323422137 << 2 ^ 1293786004));
              streamWriter1 = new StreamWriter((string) fileName);
              CodeGeneratorOptions generatorOptions1 = new CodeGeneratorOptions();
              WebReference.mfUavdWFmNZmTCGjou1O((object) generatorOptions1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514944613));
              CodeCompileUnit codeCompileUnit2 = codeCompileUnit1;
              StreamWriter streamWriter2 = streamWriter1;
              CodeGeneratorOptions generatorOptions2 = generatorOptions1;
              WebReference.qJEa3nWFyXST0FyJNHmX(obj, (object) codeCompileUnit2, (object) streamWriter2, (object) generatorOptions2);
              num2 = 2;
              continue;
            default:
              codeCompileUnit1 = new CodeCompileUnit();
              num2 = 8;
              continue;
          }
        }
label_22:
        descriptionImporter = new ServiceDescriptionImporter();
        num1 = 10;
      }
label_147:;
    }

    private string GetProxyFileName()
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) WebReference.KqUWBrBzY6N7MdrFsIu4(WebReference.qm7fbjBzUtxaUbQ7Db7n(132912447 ^ 133009479), WebReference.qm7fbjBzUtxaUbQ7Db7n(654297945 ^ 654234135));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) this.relativePath, (object) str);
    }

    /// <summary>
    /// Updates the various relative paths due to the change in the web
    /// reference name.
    /// </summary>
    private void OnNameChanged()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.items = this.CreateProjectItems();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.items == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 2;
              continue;
            }
            goto case 1;
          case 3:
            this.GetRelativePath();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Gets the web references relative path.</summary>
    private void GetRelativePath()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.relativePath = (string) WebReference.WXRCgsBzjv4uTT95Ellg(WebReference.qm7fbjBzUtxaUbQ7Db7n(1994213607 >> 4 ^ 124539136), (object) this.name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            this.webReferencesDirectory = (string) WebReference.WXRCgsBzjv4uTT95Ellg((object) this.projectDirPath, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138859914));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private List<ScriptProjectItem> CreateProjectItems()
    {
      this.items = new List<ScriptProjectItem>();
      this.items.Add(new ScriptProjectItem()
      {
        ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099653927),
        Include = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345454486)
      });
      this.items.Add(new ScriptProjectItem()
      {
        ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883382240),
        Include = this.url,
        Metadata = {
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413660141),
            Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606685424)
          },
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767686169),
            Value = this.url
          },
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574229610),
            Value = this.relativePath
          },
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812057086),
            Value = this.relativePath
          }
        }
      });
      foreach (DictionaryEntry reference in (DictionaryBase) this.protocol.References)
      {
        if (reference.Value is DiscoveryReference discoveryReference)
        {
          string defaultFilename = discoveryReference.DefaultFilename;
          ScriptProjectItem scriptProjectItem = new ScriptProjectItem();
          scriptProjectItem.ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304639279);
          if (defaultFilename != null && !defaultFilename.IsNullOrEmpty())
            scriptProjectItem.Include = Path.Combine(this.relativePath, defaultFilename);
          this.items.Add(scriptProjectItem);
        }
      }
      this.items.Add(new ScriptProjectItem()
      {
        Include = this.GetProxyFileName(),
        ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345453654),
        Metadata = {
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727324214),
            Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3366264)
          },
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841348910),
            Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306551350)
          },
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372654751),
            Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088403182)
          }
        }
      });
      this.items.Add(new ScriptProjectItem()
      {
        ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979284909),
        Include = Path.Combine(this.relativePath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470407060)),
        Metadata = {
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841348964),
            Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088402126)
          },
          new MetadataItem()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345453870),
            Value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29353915)
          }
        }
      });
      this.items.Add(new ScriptProjectItem()
      {
        ItemType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606686108),
        Include = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515060217)
      });
      foreach (ScriptProjectItem scriptProjectItem in this.items.ToList<ScriptProjectItem>())
      {
        string path = Path.Combine(this.projectDirPath, scriptProjectItem.Include);
        if (File.Exists(path))
          scriptProjectItem.FileContent = File.ReadAllText(path, Encoding.UTF8);
      }
      return this.items;
    }

    private static bool ContainsInvalidDirectoryChar(object item)
    {
      int num = 1;
      string item1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            item1 = (string) item;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<char>) WebReference.nsrPByWFMS6HTm1WbDLB()).Any<char>((Func<char, bool>) (ch => WebReference.\u003C\u003Ec__DisplayClass44_0.paZLjBQ1i21h83tIclej((object) item1, ch) >= 0));
    }

    internal static bool EcMZTHBzdptdmlbjNRis() => WebReference.TK6Q9tBz91jKJcMu74O8 == null;

    internal static WebReference OlsbwOBzlyOqbIyYauZ7() => WebReference.TK6Q9tBz91jKJcMu74O8;

    internal static void OP9OohBzr4gIMu3Vuk5E([In] object obj0) => System.CodeDom.Compiler.CodeGenerator.ValidateIdentifiers((CodeObject) obj0);

    internal static int K7JCnoBzgUI7jDx5ZFXR([In] object obj0) => ((string) obj0).Length;

    internal static int RK35xjBz5ayFQnW0gkoO([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object WXRCgsBzjv4uTT95Ellg([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object KqUWBrBzY6N7MdrFsIu4([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool WhOwGLBzLcUO13mhXRxV([In] object obj0) => System.IO.Directory.Exists((string) obj0);

    internal static object qm7fbjBzUtxaUbQ7Db7n(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zWv9VuBzsQUVf8413FJ2([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((DiscoveryClientProtocol) obj0).WriteAll((string) obj1, (string) obj2);

    internal static object bJvaoTBzc8aUtBbaaUsV([In] object obj0) => (object) ((DiscoveryClientProtocol) obj0).Documents;

    internal static object clRitvBzzu6Cveq96dIR([In] object obj0) => (object) ((DiscoveryClientDocumentCollection) obj0).Values;

    internal static object IBNxlAWFFSKWwENKL7Ia([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object RaM337WFBkKQYA3ibetf([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object Vpx2w4WFWh5i06FoCY8E([In] object obj0) => (object) ((NamedItem) obj0).Name;

    internal static bool XNoa7UWFolZ9IirPkw93([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object vbVl8NWFbgCfkeEdfKJj([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((Regex) obj0).Replace((string) obj1, (string) obj2);

    internal static void fixcwBWFhqaD5RivFbIb([In] object obj0, [In] object obj1) => ((NamedItem) obj0).Name = (string) obj1;

    internal static bool gnJE1oWFGBUpTUSAyVpe([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object sLEaRQWFE0b8i37c746E([In] object obj0, [In] object obj1) => (object) ((DirectoryInfo) obj0).GetFiles((string) obj1);

    internal static object WdZAjkWFfo38XVbooRtR([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object QIrjpqWFQTrMancgpWgx([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object i4faCCWFC8aDg2rhlaFk([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static int kALaXQWFv2qy240XHn8B([In] object obj0) => ((List<string>) obj0).Count;

    internal static object FrZD03WF8h8NbAAq72JZ([In] object obj0) => (object) ((List<string>) obj0).ToArray();

    internal static int bfRmRwWFZlfLumqCZ3Ij([In] object obj0) => Tool.Main((string[]) obj0);

    internal static object Dhy27eWFubMeHeMw8ln5() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void XFhMZrWFICU6hD7a228e([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object lwTiEtWFVlob1EmKZsqm([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object y81rBEWFS1OS3Tin0n4P([In] object obj0) => (object) File.ReadAllText((string) obj0);

    internal static bool TkPvAdWFiG0ZOrENl1HN([In] object obj0) => File.Exists((string) obj0);

    internal static object o4kGfJWFR9P45yDjIUI7(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((ServiceReferenceHelper) obj0).EditSourceCode((string) obj1, (string) obj2, (string) obj3);
    }

    internal static object eo2jxTWFqi2xYoa1AUqu([In] object obj0) => (object) ((DiscoveryClientProtocol) obj0).References;

    internal static object CHU2GFWFKsKNu9SU1uLi([In] object obj0) => (object) ((ContractReference) obj0).Contract;

    internal static int zyyFA5WFXGlk3bhsO1yc([In] object obj0, [In] object obj1) => ((ServiceDescriptionCollection) obj0).Add((System.Web.Services.Description.ServiceDescription) obj1);

    internal static void H5LVm2WFTPe2xL6ZPAGD([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object LE5gPXWFk26a4ndsjVq1([In] object obj0) => (object) ((DictionaryBase) obj0).GetEnumerator();

    internal static object cKk8vBWFnRRCo05ZLSBk([In] object obj0) => (object) ((SchemaReference) obj0).Schema;

    internal static int txadjZWFOo6ik9SoKq4n([In] object obj0, [In] object obj1) => ((XmlSchemas) obj0).Add((System.Xml.Schema.XmlSchema) obj1);

    internal static void OgspLDWF2vdlF6329MFp([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => WebReference.GenerateWebProxy(obj0, obj1, obj2, obj3);

    internal static void psV3DjWFewiA44pRXv6c([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ServiceDescriptionImporter) obj0).AddServiceDescription((System.Web.Services.Description.ServiceDescription) obj1, (string) obj2, (string) obj3);

    internal static object aYoEhOWFPnuVI9NMYtey([In] object obj0) => (object) ((CollectionBase) obj0).GetEnumerator();

    internal static int q019EYWF16Nh32UTIaXO([In] object obj0, [In] object obj1) => ((CodeNamespaceCollection) obj0).Add((CodeNamespace) obj1);

    internal static object RP49jbWFNDVhJiAms8Nt([In] object obj0) => (object) ((CodeTypeMember) obj0).CustomAttributes;

    internal static object kmVusIWF3Pn9etev4BlS([In] object obj0) => (object) ((CodeAttributeDeclaration) obj0).Name;

    internal static bool NoA0KrWFpWWF9ZEVH8jX([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object ErCUhrWFa0irej5HwO9K([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void XbR2HnWFDve8DA2Trpe8([In] object obj0, [In] object obj1) => ((CodeAttributeDeclaration) obj0).Name = (string) obj1;

    internal static object GNEpSpWFtSVrZ6r2YQIW([In] object obj0) => (object) ((CodeTypeDeclaration) obj0).Members;

    internal static object zA9sXmWFwbmtFxvrYG1l([In] object obj0) => (object) ((CodeAttributeDeclaration) obj0).Arguments;

    internal static object sOTxxjWF4fbhvVlPxlhH([In] object obj0) => (object) ((CodeAttributeArgument) obj0).Value;

    internal static object HuhHG0WF6xDBDnTqPA0D([In] object obj0) => (object) ((CodeFieldReferenceExpression) obj0).TargetObject;

    internal static object HbXSfdWFHCpvssLsXjpI([In] object obj0) => (object) ((CodeTypeReferenceExpression) obj0).Type;

    internal static object mksp0uWFARLJ5KE0FMSt([In] object obj0) => (object) ((CodeTypeReference) obj0).BaseType;

    internal static void CVm5MwWF7Fw3tmgRs3pj([In] object obj0, [In] object obj1) => ((CodeTypeReference) obj0).BaseType = (string) obj1;

    internal static object wmxtDfWFxRxaHxlmdMRb([In] object obj0) => (object) ((CodeMemberMethod) obj0).ReturnTypeCustomAttributes;

    internal static object qm5NbHWF0tiqCBFc4PrE([In] object obj0) => (object) CodeDomProvider.CreateProvider((string) obj0);

    internal static void mfUavdWFmNZmTCGjou1O([In] object obj0, [In] object obj1) => ((CodeGeneratorOptions) obj0).BracingStyle = (string) obj1;

    internal static void qJEa3nWFyXST0FyJNHmX([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((CodeDomProvider) obj0).GenerateCodeFromCompileUnit((CodeCompileUnit) obj1, (TextWriter) obj2, (CodeGeneratorOptions) obj3);

    internal static object nsrPByWFMS6HTm1WbDLB() => (object) Path.GetInvalidPathChars();
  }
}
