// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.ServerInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

namespace EleWise.ELMA.ServerInfoReference
{
  /// <remarks />
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "ServerInfoSoap", Namespace = "http://tempuri.org/")]
  [GeneratedCode("System.Web.Services", "4.8.3761.0")]
  [DebuggerStepThrough]
  public class ServerInfo : SoapHttpClientProtocol
  {
    private SendOrPostCallback GetStartInformationOperationCompleted;
    private SendOrPostCallback GetStartInformationLocalizedOperationCompleted;
    private SendOrPostCallback GetRemotingPortOperationCompleted;
    private SendOrPostCallback AdminHasEmptyPasswordOperationCompleted;
    private SendOrPostCallback ReactivateOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;
    private static ServerInfo RTpikYCcEO3LZPwPxyN;

    /// <remarks />
    public ServerInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.IsLocalFileSystemWebService(this.Url))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            this.useDefaultCredentialsSetExplicitly = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 5;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.Url = (string) ServerInfo.h2sdRpvBa7Omg98hr6s(-1824388195 ^ -1824376895);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
            continue;
          case 4:
            this.useDefaultCredentialsSetExplicitly = false;
            num = 2;
            continue;
          case 5:
            goto label_8;
          default:
            this.UseDefaultCredentials = true;
            num = 4;
            continue;
        }
      }
label_3:
      return;
label_8:;
    }

    public new string Url
    {
      get => (string) ServerInfo.IEMFiNvWrZGuPNTRJqn((object) this);
      set
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (this.useDefaultCredentialsSetExplicitly)
                {
                  num2 = 4;
                  continue;
                }
                goto case 5;
              case 2:
                if (this.IsLocalFileSystemWebService(base.Url))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
                  continue;
                }
                goto case 3;
              case 3:
              case 4:
              case 7:
                ServerInfo.GpJTIGvbYysXHpaeANA((object) this, (object) value);
                num2 = 6;
                continue;
              case 5:
                if (!this.IsLocalFileSystemWebService(value))
                  break;
                goto label_8;
              case 6:
                goto label_11;
            }
            ServerInfo.bl7KrmvopNM7tdqX31H((object) this, false);
            num2 = 3;
          }
label_8:
          num1 = 7;
        }
label_11:;
      }
    }

    public new bool UseDefaultCredentials
    {
      get => ServerInfo.oqTygavhsrtVBDBwhYB((object) this);
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ServerInfo.bl7KrmvopNM7tdqX31H((object) this, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.useDefaultCredentialsSetExplicitly = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }
    }

    /// <remarks />
    public event GetStartInformationCompletedEventHandler GetStartInformationCompleted
    {
      add
      {
        int num = 3;
        GetStartInformationCompletedEventHandler comparand;
        GetStartInformationCompletedEventHandler completedEventHandler1;
        GetStartInformationCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              comparand = completedEventHandler2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 1;
              continue;
            case 3:
              completedEventHandler2 = this.GetStartInformationCompleted;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
              continue;
            case 4:
              completedEventHandler1 = (GetStartInformationCompletedEventHandler) ServerInfo.BkMgrAvGdo3RxhGrM9g((object) comparand, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 5:
              if (completedEventHandler2 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            default:
              completedEventHandler2 = Interlocked.CompareExchange<GetStartInformationCompletedEventHandler>(ref this.GetStartInformationCompleted, completedEventHandler1, comparand);
              num = 5;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num = 4;
        GetStartInformationCompletedEventHandler completedEventHandler1;
        GetStartInformationCompletedEventHandler comparand;
        GetStartInformationCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (completedEventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            case 3:
              comparand = completedEventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 4:
              completedEventHandler1 = this.GetStartInformationCompleted;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 3 : 1;
              continue;
            case 5:
              completedEventHandler1 = Interlocked.CompareExchange<GetStartInformationCompletedEventHandler>(ref this.GetStartInformationCompleted, completedEventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 2;
              continue;
            default:
              completedEventHandler2 = (GetStartInformationCompletedEventHandler) ServerInfo.JMeZOgvEHJdqgemvbGG((object) comparand, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 4 : 5;
              continue;
          }
        }
label_2:;
      }
    }

    /// <remarks />
    public event GetStartInformationLocalizedCompletedEventHandler GetStartInformationLocalizedCompleted
    {
      add
      {
        int num = 5;
        GetStartInformationLocalizedCompletedEventHandler completedEventHandler1;
        GetStartInformationLocalizedCompletedEventHandler comparand;
        GetStartInformationLocalizedCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              completedEventHandler1 = Interlocked.CompareExchange<GetStartInformationLocalizedCompletedEventHandler>(ref this.GetStartInformationLocalizedCompleted, completedEventHandler2, comparand);
              num = 3;
              continue;
            case 3:
              if (completedEventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
                continue;
              }
              goto case 4;
            case 4:
              comparand = completedEventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 5:
              completedEventHandler1 = this.GetStartInformationLocalizedCompleted;
              num = 4;
              continue;
            default:
              completedEventHandler2 = (GetStartInformationLocalizedCompletedEventHandler) ServerInfo.BkMgrAvGdo3RxhGrM9g((object) comparand, (object) value);
              num = 2;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num = 2;
        GetStartInformationLocalizedCompletedEventHandler completedEventHandler1;
        GetStartInformationLocalizedCompletedEventHandler comparand;
        GetStartInformationLocalizedCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              comparand = completedEventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 2;
              continue;
            case 2:
              completedEventHandler1 = this.GetStartInformationLocalizedCompleted;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
            case 3:
              if (completedEventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 4:
              completedEventHandler2 = (GetStartInformationLocalizedCompletedEventHandler) ServerInfo.JMeZOgvEHJdqgemvbGG((object) comparand, (object) value);
              num = 5;
              continue;
            case 5:
              completedEventHandler1 = Interlocked.CompareExchange<GetStartInformationLocalizedCompletedEventHandler>(ref this.GetStartInformationLocalizedCompleted, completedEventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_2:
        return;
label_9:;
      }
    }

    /// <remarks />
    public event GetRemotingPortCompletedEventHandler GetRemotingPortCompleted
    {
      add
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          GetRemotingPortCompletedEventHandler completedEventHandler1;
          GetRemotingPortCompletedEventHandler comparand;
          GetRemotingPortCompletedEventHandler completedEventHandler2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (completedEventHandler2 == comparand)
                {
                  num2 = 5;
                  continue;
                }
                goto case 3;
              case 2:
                completedEventHandler1 = (GetRemotingPortCompletedEventHandler) ServerInfo.BkMgrAvGdo3RxhGrM9g((object) comparand, (object) value);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              case 3:
                comparand = completedEventHandler2;
                num2 = 2;
                continue;
              case 4:
                goto label_8;
              case 5:
                goto label_3;
              default:
                completedEventHandler2 = Interlocked.CompareExchange<GetRemotingPortCompletedEventHandler>(ref this.GetRemotingPortCompleted, completedEventHandler1, comparand);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                continue;
            }
          }
label_8:
          completedEventHandler2 = this.GetRemotingPortCompleted;
          num1 = 3;
        }
label_3:;
      }
      remove
      {
        int num = 5;
        GetRemotingPortCompletedEventHandler completedEventHandler1;
        GetRemotingPortCompletedEventHandler comparand;
        GetRemotingPortCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (completedEventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
                continue;
              }
              goto case 4;
            case 3:
              completedEventHandler1 = Interlocked.CompareExchange<GetRemotingPortCompletedEventHandler>(ref this.GetRemotingPortCompleted, completedEventHandler2, comparand);
              num = 2;
              continue;
            case 4:
              comparand = completedEventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            case 5:
              completedEventHandler1 = this.GetRemotingPortCompleted;
              num = 4;
              continue;
            default:
              completedEventHandler2 = (GetRemotingPortCompletedEventHandler) ServerInfo.JMeZOgvEHJdqgemvbGG((object) comparand, (object) value);
              num = 3;
              continue;
          }
        }
label_2:;
      }
    }

    /// <remarks />
    public event AdminHasEmptyPasswordCompletedEventHandler AdminHasEmptyPasswordCompleted
    {
      add
      {
        int num = 3;
        AdminHasEmptyPasswordCompletedEventHandler completedEventHandler1;
        AdminHasEmptyPasswordCompletedEventHandler comparand;
        AdminHasEmptyPasswordCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (completedEventHandler1 == comparand)
              {
                num = 4;
                continue;
              }
              goto case 2;
            case 2:
              comparand = completedEventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            case 3:
              completedEventHandler1 = this.AdminHasEmptyPasswordCompleted;
              num = 2;
              continue;
            case 4:
              goto label_2;
            case 5:
              completedEventHandler1 = Interlocked.CompareExchange<AdminHasEmptyPasswordCompletedEventHandler>(ref this.AdminHasEmptyPasswordCompleted, completedEventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
            default:
              completedEventHandler2 = (AdminHasEmptyPasswordCompletedEventHandler) ServerInfo.BkMgrAvGdo3RxhGrM9g((object) comparand, (object) value);
              num = 5;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          AdminHasEmptyPasswordCompletedEventHandler completedEventHandler1;
          AdminHasEmptyPasswordCompletedEventHandler comparand;
          AdminHasEmptyPasswordCompletedEventHandler completedEventHandler2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_3;
              case 1:
                goto label_5;
              case 2:
                if (completedEventHandler1 == comparand)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                  continue;
                }
                goto case 3;
              case 3:
                comparand = completedEventHandler1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
                continue;
              case 4:
                completedEventHandler1 = this.AdminHasEmptyPasswordCompleted;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 3;
                continue;
              case 5:
                completedEventHandler1 = Interlocked.CompareExchange<AdminHasEmptyPasswordCompletedEventHandler>(ref this.AdminHasEmptyPasswordCompleted, completedEventHandler2, comparand);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 2;
                continue;
              default:
                goto label_10;
            }
          }
label_5:
          completedEventHandler2 = (AdminHasEmptyPasswordCompletedEventHandler) ServerInfo.JMeZOgvEHJdqgemvbGG((object) comparand, (object) value);
          num1 = 5;
        }
label_3:
        return;
label_10:;
      }
    }

    /// <remarks />
    public event ReactivateCompletedEventHandler ReactivateCompleted
    {
      add
      {
        int num = 2;
        ReactivateCompletedEventHandler completedEventHandler1;
        ReactivateCompletedEventHandler comparand;
        ReactivateCompletedEventHandler completedEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              comparand = completedEventHandler1;
              num = 5;
              continue;
            case 2:
              completedEventHandler1 = this.ReactivateCompleted;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
              continue;
            case 3:
              completedEventHandler1 = Interlocked.CompareExchange<ReactivateCompletedEventHandler>(ref this.ReactivateCompleted, completedEventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 4;
              continue;
            case 4:
              if (completedEventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 5:
              completedEventHandler2 = comparand + value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 3 : 3;
              continue;
            default:
              goto label_9;
          }
        }
label_2:
        return;
label_9:;
      }
      remove
      {
        int num = 1;
        while (true)
        {
          ReactivateCompletedEventHandler comparand;
          ReactivateCompletedEventHandler completedEventHandler1;
          ReactivateCompletedEventHandler completedEventHandler2;
          switch (num)
          {
            case 1:
              completedEventHandler2 = this.ReactivateCompleted;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            case 2:
              completedEventHandler1 = (ReactivateCompletedEventHandler) ServerInfo.JMeZOgvEHJdqgemvbGG((object) comparand, (object) value);
              num = 5;
              continue;
            case 3:
              if (completedEventHandler2 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 2;
                continue;
              }
              break;
            case 4:
              goto label_2;
            case 5:
              completedEventHandler2 = Interlocked.CompareExchange<ReactivateCompletedEventHandler>(ref this.ReactivateCompleted, completedEventHandler1, comparand);
              num = 3;
              continue;
          }
          comparand = completedEventHandler2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 2 : 2;
        }
label_2:;
      }
    }

    /// <remarks />
    [SoapDocumentMethod("http://tempuri.org/GetStartInformation", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    public StartInformation GetStartInformation() => (StartInformation) ServerInfo.Y0JMQSvfCAJo24Y6xit((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459562613), (object) new object[0])[0];

    /// <remarks />
    public void GetStartInformationAsync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetStartInformationAsync((object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <remarks />
    public void GetStartInformationAsync(object userState)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            this.InvokeAsync((string) ServerInfo.h2sdRpvBa7Omg98hr6s(-477139494 ^ -477146768), new object[0], this.GetStartInformationOperationCompleted, userState);
            num = 2;
            continue;
          case 2:
            goto label_5;
          case 4:
            if (this.GetStartInformationOperationCompleted != null)
            {
              num = 3;
              continue;
            }
            break;
        }
        this.GetStartInformationOperationCompleted = new SendOrPostCallback(this.OnGetStartInformationOperationCompleted);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
      }
label_5:;
    }

    private void OnGetStartInformationOperationCompleted(object arg)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        InvokeCompletedEventArgs completedEventArgs;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              if (this.GetStartInformationCompleted == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
          }
          completedEventArgs = (InvokeCompletedEventArgs) arg;
          num2 = 4;
        }
label_4:
        ServerInfo.iEqpvmvveg0wCmYuRaF((object) this.GetStartInformationCompleted, (object) this, (object) new GetStartInformationCompletedEventArgs(completedEventArgs.Results, (Exception) ServerInfo.PK8YnDvQhmsjEt2jJSA((object) completedEventArgs), completedEventArgs.Cancelled, ServerInfo.noRbfcvC3qSqXpMrIHS((object) completedEventArgs)));
        num1 = 3;
      }
label_8:
      return;
label_3:;
    }

    /// <remarks />
    [SoapDocumentMethod("http://tempuri.org/GetStartInformationLocalized", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    public StartInformation GetStartInformationLocalized(string lang) => (StartInformation) this.Invoke(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154086913), new object[1]
    {
      (object) lang
    })[0];

    /// <remarks />
    public void GetStartInformationLocalizedAsync(string lang)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetStartInformationLocalizedAsync(lang, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <remarks />
    public void GetStartInformationLocalizedAsync(string lang, object userState)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
          case 3:
            this.InvokeAsync((string) ServerInfo.h2sdRpvBa7Omg98hr6s(1505778440 - 1981636111 ^ -475873235), new object[1]
            {
              (object) lang
            }, this.GetStartInformationLocalizedOperationCompleted, userState);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
            continue;
          case 4:
            if (this.GetStartInformationLocalizedOperationCompleted != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 0;
              continue;
            }
            break;
        }
        this.GetStartInformationLocalizedOperationCompleted = new SendOrPostCallback(this.OnGetStartInformationLocalizedOperationCompleted);
        num = 2;
      }
label_6:;
    }

    private void OnGetStartInformationLocalizedOperationCompleted(object arg)
    {
      int num = 2;
      InvokeCompletedEventArgs completedEventArgs;
      while (true)
      {
        switch (num)
        {
          case 1:
            completedEventArgs = (InvokeCompletedEventArgs) arg;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.GetStartInformationLocalizedCompleted != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            }
            goto label_7;
          case 3:
            goto label_2;
          default:
            ServerInfo.nhEDxDvZU9fq914tXm4((object) this.GetStartInformationLocalizedCompleted, (object) this, (object) new GetStartInformationLocalizedCompletedEventArgs((object[]) ServerInfo.I3CLNjv8b9mTZL9oHyt((object) completedEventArgs), (Exception) ServerInfo.PK8YnDvQhmsjEt2jJSA((object) completedEventArgs), completedEventArgs.Cancelled, ServerInfo.noRbfcvC3qSqXpMrIHS((object) completedEventArgs)));
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <remarks />
    [SoapDocumentMethod("http://tempuri.org/GetRemotingPort", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    public int GetRemotingPort() => (int) ServerInfo.Y0JMQSvfCAJo24Y6xit((object) this, ServerInfo.h2sdRpvBa7Omg98hr6s(-787452571 ^ -787459979), (object) new object[0])[0];

    /// <remarks />
    public void GetRemotingPortAsync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetRemotingPortAsync((object) null);
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

    /// <remarks />
    public void GetRemotingPortAsync(object userState)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
            case 3:
              this.InvokeAsync((string) ServerInfo.h2sdRpvBa7Omg98hr6s(-1876063057 ^ -1876053569), new object[0], this.GetRemotingPortOperationCompleted, userState);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 2:
              this.GetRemotingPortOperationCompleted = new SendOrPostCallback(this.OnGetRemotingPortOperationCompleted);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
            case 4:
              if (this.GetRemotingPortOperationCompleted == null)
                goto case 2;
              else
                goto label_8;
            default:
              goto label_3;
          }
        }
label_8:
        num1 = 3;
      }
label_4:
      return;
label_3:;
    }

    private void OnGetRemotingPortOperationCompleted(object arg)
    {
      int num = 2;
      InvokeCompletedEventArgs completedEventArgs;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            completedEventArgs = (InvokeCompletedEventArgs) arg;
            num = 3;
            continue;
          case 2:
            if (this.GetRemotingPortCompleted != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
              continue;
            }
            goto label_7;
          case 3:
            ServerInfo.eFn50dvIikTWQg8DXu6((object) this.GetRemotingPortCompleted, (object) this, (object) new GetRemotingPortCompletedEventArgs((object[]) ServerInfo.I3CLNjv8b9mTZL9oHyt((object) completedEventArgs), (Exception) ServerInfo.PK8YnDvQhmsjEt2jJSA((object) completedEventArgs), ServerInfo.vu6XpBvuXAQ8LdQbgW2((object) completedEventArgs), completedEventArgs.UserState));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    /// <remarks />
    [SoapDocumentMethod("http://tempuri.org/AdminHasEmptyPassword", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    public bool AdminHasEmptyPassword() => (bool) ServerInfo.Y0JMQSvfCAJo24Y6xit((object) this, ServerInfo.h2sdRpvBa7Omg98hr6s(-1120607109 - 305487170 ^ -1426081269), (object) new object[0])[0];

    /// <remarks />
    public void AdminHasEmptyPasswordAsync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AdminHasEmptyPasswordAsync((object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <remarks />
    public void AdminHasEmptyPasswordAsync(object userState)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
          case 3:
            this.InvokeAsync(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576152938), new object[0], this.AdminHasEmptyPasswordOperationCompleted, userState);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
          case 4:
            if (this.AdminHasEmptyPasswordOperationCompleted != null)
            {
              num = 3;
              continue;
            }
            break;
        }
        this.AdminHasEmptyPasswordOperationCompleted = new SendOrPostCallback(this.OnAdminHasEmptyPasswordOperationCompleted);
        num = 2;
      }
label_6:;
    }

    private void OnAdminHasEmptyPasswordOperationCompleted(object arg)
    {
      int num = 4;
      InvokeCompletedEventArgs completedEventArgs;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ServerInfo.KUK0aGvV5VZjZ2HYlXU((object) this.AdminHasEmptyPasswordCompleted, (object) this, (object) new AdminHasEmptyPasswordCompletedEventArgs((object[]) ServerInfo.I3CLNjv8b9mTZL9oHyt((object) completedEventArgs), (Exception) ServerInfo.PK8YnDvQhmsjEt2jJSA((object) completedEventArgs), ServerInfo.vu6XpBvuXAQ8LdQbgW2((object) completedEventArgs), ServerInfo.noRbfcvC3qSqXpMrIHS((object) completedEventArgs)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            completedEventArgs = (InvokeCompletedEventArgs) arg;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (this.AdminHasEmptyPasswordCompleted == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 3;
              continue;
            }
            goto case 2;
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

    /// <remarks />
    [SoapDocumentMethod("http://tempuri.org/Reactivate", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
    public StartInformation Reactivate() => (StartInformation) this.Invoke((string) ServerInfo.h2sdRpvBa7Omg98hr6s(92412609 - 1050237057 ^ -957808864), new object[0])[0];

    /// <remarks />
    public void ReactivateAsync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ReactivateAsync((object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <remarks />
    public void ReactivateAsync(object userState)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            this.InvokeAsync((string) ServerInfo.h2sdRpvBa7Omg98hr6s(993438473 ^ 993433193), new object[0], this.ReactivateOperationCompleted, userState);
            num = 4;
            continue;
          case 2:
            if (this.ReactivateOperationCompleted != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
            goto label_2;
        }
        this.ReactivateOperationCompleted = new SendOrPostCallback(this.OnReactivateOperationCompleted);
        num = 3;
      }
label_2:;
    }

    private void OnReactivateOperationCompleted(object arg)
    {
      int num = 1;
      InvokeCompletedEventArgs completedEventArgs;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (this.ReactivateCompleted == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            ServerInfo.sDEi3HvStGGxuDmdIeW((object) this.ReactivateCompleted, (object) this, (object) new ReactivateCompletedEventArgs((object[]) ServerInfo.I3CLNjv8b9mTZL9oHyt((object) completedEventArgs), (Exception) ServerInfo.PK8YnDvQhmsjEt2jJSA((object) completedEventArgs), completedEventArgs.Cancelled, ServerInfo.noRbfcvC3qSqXpMrIHS((object) completedEventArgs)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            completedEventArgs = (InvokeCompletedEventArgs) arg;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 2;
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

    /// <remarks />
    public new void CancelAsync(object userState)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ServerInfo.adWhf3viwaUCrBx9SkS((object) this, userState);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        Uri uri;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              if (url != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
                continue;
              }
              goto label_7;
            case 3:
              if (string.Compare((string) ServerInfo.UiGjuWvKaPB3LYTL4S5((object) uri), (string) ServerInfo.h2sdRpvBa7Omg98hr6s(-643786247 ^ -643783551), StringComparison.OrdinalIgnoreCase) != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 6;
                continue;
              }
              goto label_3;
            case 4:
              uri = new Uri(url);
              num2 = 6;
              continue;
            case 5:
              goto label_3;
            case 6:
              if (ServerInfo.fyLR4Tvqryx0PtKAUtD((object) uri) < 1024)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 4 : 7;
                continue;
              }
              goto case 3;
            case 7:
            case 8:
              goto label_4;
            default:
              goto label_7;
          }
        }
label_11:
        if (!ServerInfo.F78sFlvRJPkWu5i5sMH((object) url, (object) string.Empty))
          num1 = 4;
        else
          goto label_7;
      }
label_3:
      return true;
label_4:
      return false;
label_7:
      return false;
    }

    internal static object h2sdRpvBa7Omg98hr6s(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool N9N2h0CzmCyL1qbpPxd() => ServerInfo.RTpikYCcEO3LZPwPxyN == null;

    internal static ServerInfo o2CxfcvF9Srup4v239c() => ServerInfo.RTpikYCcEO3LZPwPxyN;

    internal static object IEMFiNvWrZGuPNTRJqn([In] object obj0) => (object) ((WebClientProtocol) obj0).Url;

    internal static void bl7KrmvopNM7tdqX31H([In] object obj0, [In] bool obj1) => ((WebClientProtocol) obj0).UseDefaultCredentials = obj1;

    internal static void GpJTIGvbYysXHpaeANA([In] object obj0, [In] object obj1) => ((WebClientProtocol) obj0).Url = (string) obj1;

    internal static bool oqTygavhsrtVBDBwhYB([In] object obj0) => ((WebClientProtocol) obj0).UseDefaultCredentials;

    internal static object BkMgrAvGdo3RxhGrM9g([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static object JMeZOgvEHJdqgemvbGG([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);

    internal static object Y0JMQSvfCAJo24Y6xit([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SoapHttpClientProtocol) obj0).Invoke((string) obj1, (object[]) obj2);

    internal static object PK8YnDvQhmsjEt2jJSA([In] object obj0) => (object) ((AsyncCompletedEventArgs) obj0).Error;

    internal static object noRbfcvC3qSqXpMrIHS([In] object obj0) => ((AsyncCompletedEventArgs) obj0).UserState;

    internal static void iEqpvmvveg0wCmYuRaF([In] object obj0, [In] object obj1, [In] object obj2) => ((GetStartInformationCompletedEventHandler) obj0)(obj1, (GetStartInformationCompletedEventArgs) obj2);

    internal static object I3CLNjv8b9mTZL9oHyt([In] object obj0) => (object) ((InvokeCompletedEventArgs) obj0).Results;

    internal static void nhEDxDvZU9fq914tXm4([In] object obj0, [In] object obj1, [In] object obj2) => ((GetStartInformationLocalizedCompletedEventHandler) obj0)(obj1, (GetStartInformationLocalizedCompletedEventArgs) obj2);

    internal static bool vu6XpBvuXAQ8LdQbgW2([In] object obj0) => ((AsyncCompletedEventArgs) obj0).Cancelled;

    internal static void eFn50dvIikTWQg8DXu6([In] object obj0, [In] object obj1, [In] object obj2) => ((GetRemotingPortCompletedEventHandler) obj0)(obj1, (GetRemotingPortCompletedEventArgs) obj2);

    internal static void KUK0aGvV5VZjZ2HYlXU([In] object obj0, [In] object obj1, [In] object obj2) => ((AdminHasEmptyPasswordCompletedEventHandler) obj0)(obj1, (AdminHasEmptyPasswordCompletedEventArgs) obj2);

    internal static void sDEi3HvStGGxuDmdIeW([In] object obj0, [In] object obj1, [In] object obj2) => ((ReactivateCompletedEventHandler) obj0)(obj1, (ReactivateCompletedEventArgs) obj2);

    internal static void adWhf3viwaUCrBx9SkS([In] object obj0, [In] object obj1) => ((HttpWebClientProtocol) obj0).CancelAsync(obj1);

    internal static bool F78sFlvRJPkWu5i5sMH([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static int fyLR4Tvqryx0PtKAUtD([In] object obj0) => ((Uri) obj0).Port;

    internal static object UiGjuWvKaPB3LYTL4S5([In] object obj0) => (object) ((Uri) obj0).Host;
  }
}
