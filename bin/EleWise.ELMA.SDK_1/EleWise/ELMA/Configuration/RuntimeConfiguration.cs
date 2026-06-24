// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.RuntimeConfiguration
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Параметры конфигурации ELMA</summary>
  public class RuntimeConfiguration
  {
    private static RuntimeConfiguration IbOBQ5fBdeOXSb5TL0jC;

    protected RuntimeConfiguration()
    {
      RuntimeConfiguration.xuHWUefBgJPq9iTHcJca();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public System.Configuration.Configuration Config
    {
      get => this.\u003CConfig\u003Ek__BackingField;
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
              this.\u003CConfig\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    /// <summary>Загрузить из файла</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns></returns>
    public static RuntimeConfiguration Load(string fileName)
    {
      int num1 = 7;
      string path;
      RuntimeConfiguration runtimeConfiguration;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_22:
              num2 = 3;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_13;
            case 4:
              goto label_26;
            case 5:
              try
              {
                runtimeConfiguration = new RuntimeConfiguration()
                {
                  Config = (System.Configuration.Configuration) RuntimeConfiguration.WJ9JRIfBzJsYwB6hcVqO((object) path)
                };
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_22;
                }
              }
              catch (ConfigurationInitializeException ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    throw;
                }
              }
              catch (Exception ex)
              {
                throw new ConfigurationInitializeException(ex);
              }
            case 6:
              if (RuntimeConfiguration.tBLCrUfBLO5S0koxwdZ6(RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(-488881205 ^ -489073819), RuntimeConfiguration.LHk6AAfBYxnWkDd9mvkb((object) fileName), StringComparison.InvariantCultureIgnoreCase))
              {
                RuntimeConfiguration.UnmXDgfBsyiLJ2jZBDxw((object) fileName);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              }
              goto label_24;
            case 7:
              goto label_25;
            default:
              path = (string) RuntimeConfiguration.dRxb7bfBc2jW6AYHg6aL((object) fileName);
              num2 = 5;
              continue;
          }
        }
label_24:
        num1 = 2;
        continue;
label_25:
        RuntimeConfiguration.fiv40kfBjx3vZOLHE4J9((object) fileName, RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(-951514650 ^ -951486468));
        num1 = 6;
      }
label_3:
      throw new ConfigurationInitializeException((string) RuntimeConfiguration.GjGXY1fBUYG2vqBXqVLk(RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(~538519529 ^ -538720042)));
label_13:
      try
      {
        if (RuntimeConfiguration.CO8crifWFDgNRkJCjNHf((object) path))
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_26;
              default:
                File.Delete(path);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
                continue;
            }
          }
        }
      }
      catch
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          num6 = 0;
        switch (num6)
        {
        }
      }
label_26:
      return runtimeConfiguration;
    }

    private static void CreateEmptyConfig(object fileName)
    {
      int num1 = 5;
      bool lockTaken;
      string str;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_32;
          case 2:
            goto label_6;
          case 3:
            lockTaken = false;
            num1 = 2;
            continue;
          case 4:
            str = (string) RuntimeConfiguration.Q3dbvufWBupJ6Lv1bdR7(fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 3;
            continue;
          case 5:
            if (!RuntimeConfiguration.CO8crifWFDgNRkJCjNHf(fileName))
            {
              num1 = 4;
              continue;
            }
            goto label_9;
          default:
            goto label_8;
        }
      }
label_5:
      return;
label_32:
      return;
label_8:
      return;
label_9:
      return;
label_6:
      try
      {
        Monitor.Enter((object) str, ref lockTaken);
        int num2 = 2;
        StreamWriter streamWriter;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_25;
            case 2:
              if (!RuntimeConfiguration.CO8crifWFDgNRkJCjNHf(fileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 6;
                continue;
              }
              goto label_20;
            case 3:
              streamWriter = new StreamWriter((string) fileName);
              num2 = 4;
              continue;
            case 4:
              goto label_16;
            case 5:
              ((Stream) RuntimeConfiguration.GuBcD1fWotsutrdtglv1(fileName)).Close();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 3;
              continue;
            default:
              RuntimeConfiguration.dBmuCEfWWmqxQqquamBr(fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 5 : 1;
              continue;
          }
        }
label_25:
        return;
label_20:
        return;
label_16:
        try
        {
          RuntimeConfiguration.G1q5nffWhnYJlZK3GjgH((object) streamWriter, RuntimeConfiguration.tQXOLRfWbFQbEAl7h7dR());
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          if (streamWriter != null)
          {
            int num4 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
              num4 = 1;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  RuntimeConfiguration.jj1MGPfWGGWAu1LBZU7t((object) streamWriter);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_27;
              }
            }
          }
label_27:;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_34;
              default:
                RuntimeConfiguration.jqBVaFfWEy5UZpnuWiAS((object) str);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_34:;
      }
    }

    private static string GetExeFile(object fileName)
    {
      int num1 = 5;
      string path2;
      while (true)
      {
        int num2 = num1;
        string directoryName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              path2 = Path.Combine(directoryName, path2);
              num2 = 6;
              continue;
            case 2:
              if (directoryName != null)
              {
                num2 = 3;
                continue;
              }
              goto case 6;
            case 3:
              if (path2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                continue;
              }
              goto case 6;
            case 4:
              goto label_3;
            case 5:
              path2 = (string) RuntimeConfiguration.NDvfVpfWffXhErP3S6Pe(fileName);
              num2 = 4;
              continue;
            case 6:
              if (!RuntimeConfiguration.CO8crifWFDgNRkJCjNHf((object) path2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 7:
              goto label_12;
            default:
              RuntimeConfiguration.XRJMKIfWQsKmmJFgcqGb(RuntimeConfiguration.GuBcD1fWotsutrdtglv1((object) path2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 7;
              continue;
          }
        }
label_3:
        directoryName = Path.GetDirectoryName((string) fileName);
        num1 = 2;
      }
label_12:
      return path2;
    }

    /// <summary>Сохранить в файл</summary>
    /// <param name="fileName">Имя файла</param>
    public void Save(string fileName)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            RuntimeConfiguration.XtjYOnfWvLbF6gJrD9EL((object) this.Config, (object) fileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 4;
            continue;
          case 3:
            this.Config.Save();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_2;
          case 5:
            RuntimeConfiguration.EnsureDirectoryExists((object) fileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 6:
            Contract.ArgumentNotNull((object) fileName, (string) RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(1581325282 << 3 ^ -234315510));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 1;
            continue;
          default:
            if (!RuntimeConfiguration.jSdbbnfWCGAs3iS1voOc((object) fileName, (object) this.Config.FilePath, StringComparison.InvariantCultureIgnoreCase))
            {
              num = 2;
              continue;
            }
            goto case 3;
        }
      }
label_6:
      return;
label_2:;
    }

    private static void EnsureDirectoryExists(object fileName)
    {
      int num = 5;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            Directory.CreateDirectory(path);
            num = 6;
            continue;
          case 3:
            goto label_6;
          case 4:
            if (path == null)
            {
              num = 3;
              continue;
            }
            goto default;
          case 5:
            path = (string) RuntimeConfiguration.vMyyp4fW8ioSjHwC9wZW(fileName);
            num = 4;
            continue;
          case 6:
            goto label_2;
          default:
            if (RuntimeConfiguration.BMXXWVfWZmBEdgbuKn8Z((object) path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
              continue;
            }
            goto case 2;
        }
      }
label_8:
      return;
label_6:
      return;
label_2:;
    }

    public IMainBaseSettingsSection MainDB
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              Contract.NotNull((object) this.Config, (string) RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(1574260816 ^ 1573929338));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_2;
            default:
              if (this.Config.Sections.OfType<IMainBaseSettingsSection>().Count<IMainBaseSettingsSection>() <= 1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
                continue;
              }
              goto label_2;
          }
        }
label_2:
        throw new ConfigurationInitializeException(EleWise.ELMA.SR.T((string) RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(1149433385 + 173655049 ^ 1322887944)));
label_3:
        return ((IEnumerable) RuntimeConfiguration.gsm9qXfWudwqnfnXlLwS((object) this.Config)).OfType<IMainBaseSettingsSection>().FirstOrDefault<IMainBaseSettingsSection>();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              Contract.NotNull((object) this.Config, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3656400));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 2:
              RuntimeConfiguration.EE1MV7fWSaLbhTYV0bO9(RuntimeConfiguration.gsm9qXfWudwqnfnXlLwS((object) this.Config), RuntimeConfiguration.mWcAqDfB5JH4VeXQw5BG(1113862659 ^ 1113977489), (object) (value as DataBaseSettingsSection));
              num = 5;
              continue;
            case 3:
              if (this.MainDB != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 4 : 4;
                continue;
              }
              goto case 2;
            case 4:
              RuntimeConfiguration.nK7W7kfWVEMB2RfxED5Q(RuntimeConfiguration.gsm9qXfWudwqnfnXlLwS((object) this.Config), (object) ((SectionInformation) RuntimeConfiguration.X2b0eSfWI1d3qXwg2UGm((object) (this.MainDB as DataBaseSettingsSection))).Name);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 2;
              continue;
            case 5:
              goto label_2;
            default:
              RuntimeConfiguration.fiv40kfBjx3vZOLHE4J9((object) value, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132930633));
              num = 3;
              continue;
          }
        }
label_2:;
      }
    }

    internal static void xuHWUefBgJPq9iTHcJca() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UsMqGJfBluBOKgYuur1t() => RuntimeConfiguration.IbOBQ5fBdeOXSb5TL0jC == null;

    internal static RuntimeConfiguration vlGAqHfBrrj9JlFPyJGg() => RuntimeConfiguration.IbOBQ5fBdeOXSb5TL0jC;

    internal static object mWcAqDfB5JH4VeXQw5BG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void fiv40kfBjx3vZOLHE4J9([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object LHk6AAfBYxnWkDd9mvkb([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static bool tBLCrUfBLO5S0koxwdZ6([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object GjGXY1fBUYG2vqBXqVLk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void UnmXDgfBsyiLJ2jZBDxw([In] object obj0) => RuntimeConfiguration.CreateEmptyConfig(obj0);

    internal static object dRxb7bfBc2jW6AYHg6aL([In] object obj0) => (object) RuntimeConfiguration.GetExeFile(obj0);

    internal static object WJ9JRIfBzJsYwB6hcVqO([In] object obj0) => (object) ConfigurationManager.OpenExeConfiguration((string) obj0);

    internal static bool CO8crifWFDgNRkJCjNHf([In] object obj0) => File.Exists((string) obj0);

    internal static object Q3dbvufWBupJ6Lv1bdR7([In] object obj0) => (object) string.Intern((string) obj0);

    internal static void dBmuCEfWWmqxQqquamBr([In] object obj0) => RuntimeConfiguration.EnsureDirectoryExists(obj0);

    internal static object GuBcD1fWotsutrdtglv1([In] object obj0) => (object) File.Create((string) obj0);

    internal static object tQXOLRfWbFQbEAl7h7dR() => (object) Resources.Configuration;

    internal static void G1q5nffWhnYJlZK3GjgH([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static void jj1MGPfWGGWAu1LBZU7t([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void jqBVaFfWEy5UZpnuWiAS([In] object obj0) => Monitor.Exit(obj0);

    internal static object NDvfVpfWffXhErP3S6Pe([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static void XRJMKIfWQsKmmJFgcqGb([In] object obj0) => ((Stream) obj0).Close();

    internal static bool jSdbbnfWCGAs3iS1voOc([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static void XtjYOnfWvLbF6gJrD9EL([In] object obj0, [In] object obj1) => ((System.Configuration.Configuration) obj0).SaveAs((string) obj1);

    internal static object vMyyp4fW8ioSjHwC9wZW([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static bool BMXXWVfWZmBEdgbuKn8Z([In] object obj0) => Directory.Exists((string) obj0);

    internal static object gsm9qXfWudwqnfnXlLwS([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).Sections;

    internal static object X2b0eSfWI1d3qXwg2UGm([In] object obj0) => (object) ((ConfigurationSection) obj0).SectionInformation;

    internal static void nK7W7kfWVEMB2RfxED5Q([In] object obj0, [In] object obj1) => ((ConfigurationSectionCollection) obj0).Remove((string) obj1);

    internal static void EE1MV7fWSaLbhTYV0bO9([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationSectionCollection) obj0).Add((string) obj1, (ConfigurationSection) obj2);
  }
}
