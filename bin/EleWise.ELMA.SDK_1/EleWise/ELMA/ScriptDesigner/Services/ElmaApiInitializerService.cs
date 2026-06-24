// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.Services.ElmaApiInitializerService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

namespace EleWise.ELMA.ScriptDesigner.Services
{
  [Service(Type = ComponentType.Server)]
  internal class ElmaApiInitializerService
  {
    private static readonly Guid moduleUid;
    private byte[] zippedTree;
    private bool initializing;
    private Exception initException;
    private object initApiTreeLockObj;
    internal static ElmaApiInitializerService DWqw0xV7X9Km4mg9cdR;

    public bool IsApiTreeInitialized()
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 4:
            goto label_4;
          case 2:
            if (this.initException == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            if (this.zippedTree == null)
            {
              num1 = 2;
              continue;
            }
            goto label_5;
          case 5:
            ThreadStarter.QueueThread((ThreadStart) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    new BackgroundTask((System.Action) (() => this.Init()), typeof (ElmaApiInitializerService), (string) ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(-1380439818 << 3 ^ 1841367320), (string) ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(-1445902765 ^ -1980277732 ^ 539383015)).Execute();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
          default:
            if (this.initializing)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
        }
      }
label_4:
      return false;
label_5:
      return true;
    }

    public virtual byte[] GetZippedApiTree()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.zippedTree == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          case 3:
            goto label_2;
          case 4:
            this.Init();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 5;
            continue;
          case 5:
            goto label_4;
          default:
            if (this.initException == null)
            {
              num = 4;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      throw this.initException;
label_4:
      return this.zippedTree;
label_7:
      return this.zippedTree;
    }

    private void Init()
    {
      int num1 = 6;
      object initApiTreeLockObj;
      bool lockTaken;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.initException == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              }
              goto label_49;
            case 2:
              goto label_82;
            case 3:
              goto label_87;
            case 4:
              goto label_81;
            case 5:
              goto label_45;
            case 6:
              if (this.zippedTree != null)
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 7:
              goto label_3;
            default:
              initApiTreeLockObj = this.initApiTreeLockObj;
              num2 = 4;
              continue;
          }
        }
label_81:
        lockTaken = false;
        num1 = 7;
      }
label_82:
      return;
label_87:
      return;
label_45:
      return;
label_3:
      try
      {
        Monitor.Enter(initApiTreeLockObj, ref lockTaken);
        int num3 = 4;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_83;
            case 1:
            case 2:
              num3 = 3;
              continue;
            case 3:
              goto label_10;
            case 4:
              if (this.zippedTree != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 5:
              goto label_76;
            case 6:
              if (this.initException == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 2;
                continue;
              }
              goto label_79;
            default:
              goto label_71;
          }
        }
label_83:
        return;
label_76:
        return;
label_71:
        return;
label_79:
        return;
label_10:
        try
        {
          this.initializing = true;
          int num4 = 5;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
            num4 = 9;
          string str;
          SHA1 shA1;
          Assembly assembly;
          string blob;
          string path;
          byte[] bytes;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_55;
              case 2:
                ((IBLOBDataManager) ElmaApiInitializerService.fkU1lqVYWqy76O84usJ()).SetBLOB<byte[]>(ElmaApiInitializerService.moduleUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309655038), this.zippedTree);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 14 : 3;
                continue;
              case 3:
                try
                {
                  FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                    num5 = 0;
                  switch (num5)
                  {
                    case 1:
                      goto label_18;
                    default:
                      try
                      {
                        str = (string) ElmaApiInitializerService.FTHmQCVdpdAAXNhPYxT(ElmaApiInitializerService.HmQ6N2V9qaxFI81fl2v((object) shA1, (object) fileStream));
                        int num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                          num6 = 0;
                        switch (num6)
                        {
                          default:
                            goto label_18;
                        }
                      }
                      finally
                      {
                        int num7;
                        if (fileStream == null)
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                        else
                          goto label_42;
label_41:
                        switch (num7)
                        {
                          case 1:
                            break;
                          default:
                        }
label_42:
                        ElmaApiInitializerService.JQf7p9VlOfP5QbSLyS8((object) fileStream);
                        num7 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
                        {
                          num7 = 2;
                          goto label_41;
                        }
                        else
                          goto label_41;
                      }
                  }
                }
                finally
                {
                  int num8;
                  if (shA1 == null)
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                  else
                    goto label_51;
label_48:
                  switch (num8)
                  {
                    case 2:
                      break;
                    default:
                  }
label_51:
                  ElmaApiInitializerService.JQf7p9VlOfP5QbSLyS8((object) shA1);
                  num8 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                  {
                    num8 = 1;
                    goto label_48;
                  }
                  else
                    goto label_48;
                }
              case 4:
                if (this.zippedTree == null)
                {
                  num4 = 7;
                  continue;
                }
                goto label_60;
              case 5:
                goto label_67;
              case 6:
                this.zippedTree = bytes.Zip();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 10 : 13;
                continue;
              case 7:
                assembly = (Assembly) ElmaApiInitializerService.hEc8wKVgqQvmrtpUvJR(ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(--1360331293 ^ 1360332851));
                num4 = 16;
                continue;
              case 8:
                str = (string) null;
                num4 = 15;
                continue;
              case 9:
                blob = DataAccessManager.BLOBManager.GetBLOB<string>(ElmaApiInitializerService.moduleUid, (string) ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(-1876063057 ^ -1876049535));
                num4 = 8;
                continue;
              case 10:
                if (ElmaApiInitializerService.wZyTv5VrBSa9k1uvbRH((object) blob, (object) str))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                  continue;
                }
                goto case 4;
              case 11:
label_18:
                if (str != null)
                {
                  num4 = 17;
                  continue;
                }
                goto case 4;
              case 12:
                if (File.Exists(path))
                {
                  num4 = 18;
                  continue;
                }
                goto case 11;
              case 13:
                if (!ElmaApiInitializerService.Xp6imhVj6BTKdEQOi7F((object) str))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 2;
                  continue;
                }
                goto label_64;
              case 14:
                ((IBLOBDataManager) ElmaApiInitializerService.fkU1lqVYWqy76O84usJ()).SetBLOB<string>(ElmaApiInitializerService.moduleUid, (string) ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(1251470110 >> 2 ^ 312850409), str);
                num4 = 5;
                continue;
              case 15:
                path = (string) ElmaApiInitializerService.noLluXVMcxJNZty6yZD(ElmaApiInitializerService.noLluXVMcxJNZty6yZD((object) ((ComponentManager) ElmaApiInitializerService.julgr2VyMXOmLtUeIWJ()).WorkDirectory, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867365521)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70022515));
                num4 = 12;
                continue;
              case 16:
                if (assembly == (Assembly) null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
                  continue;
                }
                bytes = ClassSerializationHelper.SerializeObjectByXmlToBytes(ElmaApiInitializerService.ss9QCxV5c4CMWo6YYc0((object) assembly));
                num4 = 6;
                continue;
              case 17:
                if (blob != null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 10 : 7;
                  continue;
                }
                goto case 4;
              case 18:
                shA1 = (SHA1) ElmaApiInitializerService.J9mTsuVJT5nPkQwB6da();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 3 : 2;
                continue;
              default:
                this.zippedTree = DataAccessManager.BLOBManager.GetBLOB<byte[]>(ElmaApiInitializerService.moduleUid, (string) ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(813604817 ^ 813617775));
                num4 = 4;
                continue;
            }
          }
label_67:
          return;
label_64:
          return;
label_55:
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886633877), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757134608)));
label_60:
          return;
        }
        catch (Exception ex)
        {
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
            num9 = 0;
          while (true)
          {
            switch (num9)
            {
              case 1:
                goto label_50;
              case 2:
                this.initException = ex;
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
                continue;
              default:
                ElmaApiInitializerService.bqUhmwVUfyGj7ogpeM5(ElmaApiInitializerService.pIEGX7VL7bDtqAwPDf3(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323103256), (object) ex);
                num9 = 2;
                continue;
            }
          }
label_50:
          return;
        }
        finally
        {
          this.initializing = false;
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
            num10 = 0;
          switch (num10)
          {
            default:
          }
        }
      }
      finally
      {
        int num11;
        if (!lockTaken)
          num11 = 2;
        else
          goto label_77;
label_75:
        switch (num11)
        {
          case 1:
          case 2:
        }
label_77:
        ElmaApiInitializerService.OiltYkVsCw2B6I5gkEU(initApiTreeLockObj);
        num11 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        {
          num11 = 1;
          goto label_75;
        }
        else
          goto label_75;
      }
label_49:;
    }

    public ElmaApiInitializerService()
    {
      ElmaApiInitializerService.z6VuxBVcEvxJFjMft3T();
      this.initApiTreeLockObj = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ElmaApiInitializerService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ElmaApiInitializerService.moduleUid = new Guid((string) ElmaApiInitializerService.Ne0SfYVmUgj56fl5dDO(-1445902765 ^ -1980277732 ^ 539382803));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool FTCNcNVxXIEojJSToTw() => ElmaApiInitializerService.DWqw0xV7X9Km4mg9cdR == null;

    internal static ElmaApiInitializerService JRq5TXV0aNtkM53amQM() => ElmaApiInitializerService.DWqw0xV7X9Km4mg9cdR;

    internal static object Ne0SfYVmUgj56fl5dDO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object julgr2VyMXOmLtUeIWJ() => (object) ComponentManager.Current;

    internal static object noLluXVMcxJNZty6yZD([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object J9mTsuVJT5nPkQwB6da() => (object) SHA1.Create();

    internal static object HmQ6N2V9qaxFI81fl2v([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object FTHmQCVdpdAAXNhPYxT([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static void JQf7p9VlOfP5QbSLyS8([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool wZyTv5VrBSa9k1uvbRH([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object hEc8wKVgqQvmrtpUvJR([In] object obj0) => (object) Assembly.Load((string) obj0);

    internal static object ss9QCxV5c4CMWo6YYc0([In] object obj0) => (object) DynamicAssemblyResolver.GetElmaApiFullTree((Assembly) obj0);

    internal static bool Xp6imhVj6BTKdEQOi7F([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object fkU1lqVYWqy76O84usJ() => (object) DataAccessManager.BLOBManager;

    internal static object pIEGX7VL7bDtqAwPDf3() => (object) Logger.Log;

    internal static void bqUhmwVUfyGj7ogpeM5([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void OiltYkVsCw2B6I5gkEU([In] object obj0) => Monitor.Exit(obj0);

    internal static void z6VuxBVcEvxJFjMft3T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
