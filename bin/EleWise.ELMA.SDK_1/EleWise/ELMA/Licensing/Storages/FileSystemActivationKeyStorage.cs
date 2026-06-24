// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Storages.FileSystemActivationKeyStorage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Licensing.Storages
{
  public class FileSystemActivationKeyStorage : IActivationKeyStorage
  {
    private string _path;
    private bool _canRead;
    private bool _canWrite;
    private static FileSystemActivationKeyStorage Ab2WdB0GQB9HSqf9BAY;

    public FileSystemActivationKeyStorage(string path)
    {
      FileSystemActivationKeyStorage.xZw6km0QCEu5HVofb8P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_4;
          case 1:
            try
            {
              FileSystemActivationKeyStorage.GGhEXl0vB4GteRpkmh0((object) path);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_13;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_34;
                  case 1:
                    FileSystemActivationKeyStorage.wEBg5e0CBRa6WtuI9HR(FileSystemActivationKeyStorage.tH1gTX08wPrRQZDr5GQ(), (object) ((string) FileSystemActivationKeyStorage.mnNS2F0ZYar4yq4LKan(-1217523399 ^ -1217491551) + path), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_33;
                }
              }
label_34:
              return;
label_33:
              return;
            }
          case 2:
            if (!Directory.Exists(path))
            {
              num1 = 8;
              continue;
            }
            goto case 5;
          case 3:
label_13:
            this._canRead = true;
            num1 = 6;
            continue;
          case 4:
            if (!string.IsNullOrEmpty(path))
            {
              this._path = path;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 2;
              continue;
            }
            num1 = 7;
            continue;
          case 5:
label_3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_14;
          case 7:
            goto label_40;
          case 8:
            try
            {
              Directory.CreateDirectory(path);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_3;
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_17;
                  default:
                    FileSystemActivationKeyStorage.wEBg5e0CBRa6WtuI9HR((object) Logger.Log, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138927148) + path), (object) ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
                    continue;
                }
              }
label_17:
              return;
            }
          default:
            goto label_38;
        }
      }
label_4:
      return;
label_40:
      return;
label_38:
      return;
label_14:
      try
      {
        Guid guid = FileSystemActivationKeyStorage.Eg8QRl0uxogAqnaC8e4();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num6 = 0;
        string str;
        while (true)
        {
          switch (num6)
          {
            case 1:
              this._canWrite = true;
              num6 = 2;
              continue;
            case 2:
              goto label_27;
            case 3:
              object obj = FileSystemActivationKeyStorage.cNCLys0V0swVf7GADYJ((object) path, FileSystemActivationKeyStorage.NtdZOC0IfsKFByCctQI((object) str, FileSystemActivationKeyStorage.mnNS2F0ZYar4yq4LKan(-680446928 - -370807692 ^ -309601444)));
              FileSystemActivationKeyStorage.HFq6JI0SlOIUnPhI2bp(obj, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921198001));
              FileSystemActivationKeyStorage.TlUPRU0ibaqCONRCIfn(obj);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            default:
              str = guid.ToString();
              num6 = 3;
              continue;
          }
        }
label_27:;
      }
      catch (Exception ex)
      {
        int num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 0:
              goto label_25;
            case 1:
              FileSystemActivationKeyStorage.wEBg5e0CBRa6WtuI9HR(FileSystemActivationKeyStorage.tH1gTX08wPrRQZDr5GQ(), FileSystemActivationKeyStorage.NtdZOC0IfsKFByCctQI(FileSystemActivationKeyStorage.mnNS2F0ZYar4yq4LKan(-1921202237 ^ -1921230033), (object) path), (object) ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            default:
              goto label_21;
          }
        }
label_25:
        return;
label_21:;
      }
    }

    public bool CanRead => this._canRead;

    public bool CanWrite => this._canWrite;

    public Dictionary<Guid, string> GetActivationKeys()
    {
      Dictionary<Guid, string> activationKeys = new Dictionary<Guid, string>();
      if (!this._canRead)
        return activationKeys;
      try
      {
        foreach (string file in Directory.GetFiles(this._path))
        {
          Guid result;
          if (Guid.TryParse(Path.GetFileNameWithoutExtension(Path.GetFileName(file)), out result))
          {
            try
            {
              activationKeys[result] = File.ReadAllText(file);
            }
            catch (Exception ex)
            {
              Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889490414) + file), ex);
            }
          }
        }
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536765682) + this._path), ex);
      }
      return activationKeys;
    }

    public void AddActivationKey(Guid uid, string key)
    {
      int num1 = 2;
      string str;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            if (this._canWrite)
            {
              str = (string) FileSystemActivationKeyStorage.cNCLys0V0swVf7GADYJ((object) this._path, FileSystemActivationKeyStorage.NtdZOC0IfsKFByCctQI((object) uid.ToString(), FileSystemActivationKeyStorage.mnNS2F0ZYar4yq4LKan(1669371371 ^ 1669335307)));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_14;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_14:
      return;
label_2:
      try
      {
        FileSystemActivationKeyStorage.HFq6JI0SlOIUnPhI2bp((object) str, (object) key);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_6;
            default:
              FileSystemActivationKeyStorage.wEBg5e0CBRa6WtuI9HR(FileSystemActivationKeyStorage.tH1gTX08wPrRQZDr5GQ(), FileSystemActivationKeyStorage.NtdZOC0IfsKFByCctQI((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195577959), (object) str), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
          }
        }
label_6:;
      }
    }

    public void RemoveActivationKey(Guid uid)
    {
      int num1 = 1;
      string path;
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
              if (!this._canWrite)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_21;
            case 3:
              goto label_8;
            default:
              goto label_3;
          }
        }
label_5:
        path = (string) FileSystemActivationKeyStorage.cNCLys0V0swVf7GADYJ((object) this._path, FileSystemActivationKeyStorage.NtdZOC0IfsKFByCctQI((object) uid.ToString(), FileSystemActivationKeyStorage.mnNS2F0ZYar4yq4LKan(-643786247 ^ -643824359)));
        num1 = 3;
      }
label_4:
      return;
label_21:
      return;
label_3:
      return;
label_8:
      try
      {
        int num3;
        if (!FileSystemActivationKeyStorage.WHSVuK0ReKbFooWHZxH((object) path))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
        else
          goto label_12;
label_10:
        switch (num3)
        {
          case 0:
            return;
          case 1:
            return;
          case 2:
            break;
          default:
            return;
        }
label_12:
        File.Delete(path);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_11;
            default:
              FileSystemActivationKeyStorage.wEBg5e0CBRa6WtuI9HR(FileSystemActivationKeyStorage.tH1gTX08wPrRQZDr5GQ(), FileSystemActivationKeyStorage.NtdZOC0IfsKFByCctQI(FileSystemActivationKeyStorage.mnNS2F0ZYar4yq4LKan(-787452571 ^ -787418207), (object) path), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
          }
        }
label_11:;
      }
    }

    internal static void xZw6km0QCEu5HVofb8P() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void wEBg5e0CBRa6WtuI9HR([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object GGhEXl0vB4GteRpkmh0([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static object tH1gTX08wPrRQZDr5GQ() => (object) Logger.Log;

    internal static object mnNS2F0ZYar4yq4LKan(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid Eg8QRl0uxogAqnaC8e4() => Guid.NewGuid();

    internal static object NtdZOC0IfsKFByCctQI([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object cNCLys0V0swVf7GADYJ([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static void HFq6JI0SlOIUnPhI2bp([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);

    internal static void TlUPRU0ibaqCONRCIfn([In] object obj0) => File.Delete((string) obj0);

    internal static bool JtQtwg0E3LWhx2Ud7mA() => FileSystemActivationKeyStorage.Ab2WdB0GQB9HSqf9BAY == null;

    internal static FileSystemActivationKeyStorage L2x9r10fmyC0aIh4lL5() => FileSystemActivationKeyStorage.Ab2WdB0GQB9HSqf9BAY;

    internal static bool WHSVuK0ReKbFooWHZxH([In] object obj0) => File.Exists((string) obj0);
  }
}
