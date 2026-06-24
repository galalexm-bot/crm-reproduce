// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.Impl.Models.FileEncryptData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Providers.Impl.Models
{
  /// <summary>Информация о зашифрованом файле</summary>
  internal class FileEncryptData
  {
    internal static FileEncryptData RcMkCSWv6JMtrZSrdB1U;

    /// <summary>Соль для шифрования файла</summary>
    public string Salt
    {
      get => this.\u003CSalt\u003Ek__BackingField;
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
              this.\u003CSalt\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    /// <summary>Пароль</summary>
    public string Password
    {
      get => this.\u003CPassword\u003Ek__BackingField;
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
              this.\u003CPassword\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    public FileEncryptData()
    {
      FileEncryptData.FSHrJOWv7A3PQKcyCMxU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LDQp64WvHa9mOQwmESgw() => FileEncryptData.RcMkCSWv6JMtrZSrdB1U == null;

    internal static FileEncryptData em2QYfWvAF8Bktwe8nJC() => FileEncryptData.RcMkCSWv6JMtrZSrdB1U;

    internal static void FSHrJOWv7A3PQKcyCMxU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
