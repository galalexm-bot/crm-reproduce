// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ElmaClientBase`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Locking;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Threading;

namespace EleWise.ELMA.Model.CodeGeneration
{
  public abstract class ElmaClientBase<TChannel> where TChannel : class
  {
    private readonly ILockKeyFactory lockKeyFactory;
    private ChannelFactory<TChannel> channelFactory;
    private TChannel channel;
    internal static object nQFu1Zh1lsDvtO8hfQGk;

    private System.Configuration.Configuration OpenConfiguration()
    {
      int num = 1;
      System.Type serviceType;
      string appConfigPath;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceType = typeof (TChannel);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 2:
            this.CreateEmptyConfig(appConfigPath);
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            appConfigPath = Locator.GetServiceNotNull<ServiceReferenceHelper>().GetAppConfigPath(serviceType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return ConfigurationManager.OpenExeConfiguration(ElmaClientBase<TChannel>.GetExeFile(appConfigPath));
    }

    protected ElmaClientBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 1;
      System.Configuration.Configuration configuration;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.lockKeyFactory = Locator.GetServiceNotNull<ILockKeyFactory>();
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            configuration = this.OpenConfiguration();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          default:
            this.channelFactory = (ChannelFactory<TChannel>) new ConfigurationChannelFactory<TChannel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272612133), configuration, (EndpointAddress) null);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    protected ElmaClientBase(string endpointAddress)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      System.Configuration.Configuration configuration;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            configuration = this.OpenConfiguration();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 1;
            continue;
          case 3:
            this.channelFactory = (ChannelFactory<TChannel>) new ConfigurationChannelFactory<TChannel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44871981), configuration, new EndpointAddress(endpointAddress));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
            continue;
          default:
            this.lockKeyFactory = Locator.GetServiceNotNull<ILockKeyFactory>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    public ClientCredentials ClientCredentials => this.channelFactory.Credentials;

    protected ElmaClientBase(Binding binding, EndpointAddress endpoint)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.channelFactory = new ChannelFactory<TChannel>(binding, endpoint);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public TChannel Channel => this.channel ?? (this.channel = this.channelFactory.CreateChannel());

    private void CreateEmptyConfig(string fileName)
    {
      int num1 = 3;
      IDisposable disposable1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_44;
          case 1:
            goto label_2;
          case 2:
            disposable1 = this.lockKeyFactory.Get(fileName);
            num1 = 4;
            continue;
          case 3:
            if (!File.Exists(fileName))
            {
              num1 = 2;
              continue;
            }
            goto label_38;
          case 4:
            goto label_6;
          default:
            goto label_35;
        }
      }
label_44:
      return;
label_2:
      return;
label_35:
      return;
label_38:
      return;
label_6:
      try
      {
        IDisposable disposable2 = disposable1;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num2 = 0;
        bool lockTaken;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            default:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
              continue;
          }
        }
label_10:
        try
        {
          Monitor.Enter((object) disposable2, ref lockTaken);
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
            num3 = 1;
          StreamWriter streamWriter;
          while (true)
          {
            switch (num3)
            {
              case 1:
                if (!File.Exists(fileName))
                {
                  num3 = 6;
                  continue;
                }
                goto label_27;
              case 2:
                goto label_30;
              case 3:
                streamWriter = new StreamWriter(fileName);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              case 4:
                File.Create(fileName).Close();
                num3 = 3;
                continue;
              case 5:
              case 6:
                ElmaClientBase<TChannel>.EnsureDirectoryExists(fileName);
                num3 = 4;
                continue;
              default:
                goto label_18;
            }
          }
label_30:
          return;
label_27:
          return;
label_18:
          try
          {
            streamWriter.Write(Resources.Configuration);
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
              num4 = 0;
            switch (num4)
            {
            }
          }
          finally
          {
            int num5;
            if (streamWriter == null)
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            else
              goto label_28;
label_26:
            switch (num5)
            {
              case 2:
                break;
              default:
            }
label_28:
            streamWriter.Dispose();
            num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
            {
              num5 = 0;
              goto label_26;
            }
            else
              goto label_26;
          }
        }
        finally
        {
          int num6;
          if (!lockTaken)
            num6 = 2;
          else
            goto label_36;
label_34:
          switch (num6)
          {
            case 1:
              break;
            default:
          }
label_36:
          Monitor.Exit((object) disposable2);
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
          {
            num6 = 0;
            goto label_34;
          }
          else
            goto label_34;
        }
      }
      finally
      {
        if (disposable1 != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
            num7 = 0;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_46;
              default:
                disposable1.Dispose();
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_46:;
      }
    }

    private static string GetExeFile(string fileName)
    {
      int num = 3;
      string exeFile;
      while (true)
      {
        string directoryName;
        switch (num)
        {
          case 1:
          case 4:
          case 9:
            if (File.Exists(exeFile))
            {
              num = 8;
              continue;
            }
            break;
          case 2:
            directoryName = Path.GetDirectoryName(fileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 7 : 1;
            continue;
          case 3:
            exeFile = Path.GetFileNameWithoutExtension(fileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 1;
            continue;
          case 5:
          case 8:
            goto label_4;
          case 6:
            if (exeFile == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 2;
              continue;
            }
            goto case 10;
          case 7:
            if (directoryName == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 9 : 4;
              continue;
            }
            goto case 6;
          case 10:
            exeFile = Path.Combine(directoryName, exeFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
        }
        File.Create(exeFile).Close();
        num = 5;
      }
label_4:
      return exeFile;
    }

    private static void EnsureDirectoryExists(string fileName)
    {
      int num = 3;
      string directoryName;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (directoryName != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 3:
            directoryName = Path.GetDirectoryName(fileName);
            num = 2;
            continue;
          case 4:
            Directory.CreateDirectory(directoryName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          default:
            if (!Directory.Exists(directoryName))
            {
              num = 4;
              continue;
            }
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_10:;
    }

    internal static bool eMVBlqh1re4f9YD6NdRh() => ElmaClientBase<TChannel>.nQFu1Zh1lsDvtO8hfQGk == null;

    internal static object a5QZeHh1ghw1PdeMDEJJ() => ElmaClientBase<TChannel>.nQFu1Zh1lsDvtO8hfQGk;
  }
}
