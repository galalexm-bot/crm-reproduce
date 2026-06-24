// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Storages.InstallationIdFileStorage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Licensing.Storages
{
  public class InstallationIdFileStorage : IInstallationIdStorage
  {
    private string _path;
    private bool _canRead;
    private bool _canWrite;
    private static InstallationIdFileStorage RKQy4fxAGbWlq2MkJIV;

    public InstallationIdFileStorage(string path)
    {
      InstallationIdFileStorage.LP6kgPx0dVT0bQUCTdR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!Directory.Exists(path))
            {
              num1 = 3;
              continue;
            }
            goto case 6;
          case 2:
label_31:
            this._canRead = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 3:
            try
            {
              Directory.CreateDirectory(path);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_28;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_25;
                  case 1:
                    InstallationIdFileStorage.hbH3xJx9XFVI2t3K30o(InstallationIdFileStorage.u4cRF2xyWDvExR7FkYM(), InstallationIdFileStorage.jAfVi1xJEFv610O4hMj(InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(1142330761 ^ 1541959139 ^ 536765510), (object) path), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_21;
                }
              }
label_25:
              return;
label_21:
              return;
            }
          case 4:
            if (!InstallationIdFileStorage.wyKAPfxmNVw5OMGwIIa((object) path))
            {
              this._path = path;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 2;
            continue;
          case 5:
            goto label_42;
          case 6:
label_28:
            num1 = 7;
            continue;
          case 7:
            try
            {
              InstallationIdFileStorage.BLjX6rxd4xjtUGqpUq9((object) path);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_31;
              }
            }
            catch (Exception ex)
            {
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_35;
                  case 1:
                    InstallationIdFileStorage.hbH3xJx9XFVI2t3K30o(InstallationIdFileStorage.u4cRF2xyWDvExR7FkYM(), InstallationIdFileStorage.jAfVi1xJEFv610O4hMj(InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(-688192331 - 435440695 ^ -1123670810), (object) path), (object) ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_27;
                }
              }
label_35:
              return;
label_27:
              return;
            }
          case 8:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_42:
      return;
label_3:
      return;
label_7:
      try
      {
        Guid guid = InstallationIdFileStorage.Cs16jFxl2i2tLgRNr9x();
        int num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
          num6 = 1;
        string str;
        while (true)
        {
          switch (num6)
          {
            case 1:
              str = guid.ToString();
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            case 2:
              this._canWrite = true;
              num6 = 3;
              continue;
            case 3:
              goto label_40;
            default:
              object obj = InstallationIdFileStorage.nt6eF1xrJnsagrXDH6o((object) path, InstallationIdFileStorage.jAfVi1xJEFv610O4hMj((object) str, InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(1149433385 + 173655049 ^ 1323050706)));
              InstallationIdFileStorage.VeXeqFxgp99glMNbp5a(obj, InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(-16752921 ^ -16760469));
              InstallationIdFileStorage.wSskbPx5gyvIDTGH4IW(obj);
              num6 = 2;
              continue;
          }
        }
label_40:;
      }
      catch (Exception ex)
      {
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_36;
            default:
              InstallationIdFileStorage.hbH3xJx9XFVI2t3K30o(InstallationIdFileStorage.u4cRF2xyWDvExR7FkYM(), (object) ((string) InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(2008901894 << 3 ^ -1108618020) + path), (object) ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
          }
        }
label_36:;
      }
    }

    public bool CanRead => this._canRead;

    public bool CanWrite => this._canWrite;

    public string Read()
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_16;
          case 3:
            if (!this._canRead)
            {
              num1 = 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_6:
      string str1;
      try
      {
        string str2 = (string) InstallationIdFileStorage.nt6eF1xrJnsagrXDH6o((object) this._path, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477105944));
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!InstallationIdFileStorage.RFmqgexj9H0lw4ALmL7((object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              goto label_5;
            case 4:
              str1 = ((string) InstallationIdFileStorage.otfjj2xY6xHStsS8NrR((object) str2)).Trim(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487399382).ToCharArray());
              num2 = 2;
              continue;
            default:
              goto label_4;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_4;
            default:
              InstallationIdFileStorage.hbH3xJx9XFVI2t3K30o(InstallationIdFileStorage.u4cRF2xyWDvExR7FkYM(), InstallationIdFileStorage.jAfVi1xJEFv610O4hMj(InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(-16752921 ^ -16727109), (object) this._path), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
          }
        }
      }
label_5:
      return str1;
label_16:
      return (string) null;
    }

    public bool Write(string value)
    {
      int num1 = 1;
      string path;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this._canWrite)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 2:
            goto label_4;
          case 3:
            goto label_2;
          case 4:
            goto label_14;
          default:
            path = (string) InstallationIdFileStorage.nt6eF1xrJnsagrXDH6o((object) this._path, InstallationIdFileStorage.M1LVXdxMeCetuN1k9UA(-951514650 ^ -951479084));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return false;
label_4:
      bool flag;
      try
      {
        File.WriteAllText(path, value);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              Logger.Log.Error(InstallationIdFileStorage.jAfVi1xJEFv610O4hMj((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787418925), (object) path), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
      }
label_3:
      return flag;
label_14:
      return false;
    }

    internal static void LP6kgPx0dVT0bQUCTdR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wyKAPfxmNVw5OMGwIIa([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object u4cRF2xyWDvExR7FkYM() => (object) Logger.Log;

    internal static object M1LVXdxMeCetuN1k9UA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jAfVi1xJEFv610O4hMj([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void hbH3xJx9XFVI2t3K30o([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object BLjX6rxd4xjtUGqpUq9([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static Guid Cs16jFxl2i2tLgRNr9x() => Guid.NewGuid();

    internal static object nt6eF1xrJnsagrXDH6o([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static void VeXeqFxgp99glMNbp5a([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);

    internal static void wSskbPx5gyvIDTGH4IW([In] object obj0) => File.Delete((string) obj0);

    internal static bool jGEpGdx7OIIyY0hDNFm() => InstallationIdFileStorage.RKQy4fxAGbWlq2MkJIV == null;

    internal static InstallationIdFileStorage ceV8fgxxtMLnw2PwQmf() => InstallationIdFileStorage.RKQy4fxAGbWlq2MkJIV;

    internal static bool RFmqgexj9H0lw4ALmL7([In] object obj0) => File.Exists((string) obj0);

    internal static object otfjj2xY6xHStsS8NrR([In] object obj0) => (object) File.ReadAllText((string) obj0);
  }
}
