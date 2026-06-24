// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.SavePointHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Core;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Хэлпер установки точек сохранения транзакций</summary>
  public static class SavePointHelper
  {
    private static ITransformationProvider _transformationProvider;
    private static SavePointHelper zmsU1QW8QGVbLNUBVPja;

    private static ITransformationProvider TransformationProvider()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (SavePointHelper.TD0qnyW88u5P0Hg6qUVj())
            {
              num1 = 3;
              continue;
            }
            goto label_9;
          case 2:
            if (SavePointHelper._transformationProvider == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
              continue;
            }
            goto label_11;
          case 3:
            goto label_2;
          case 4:
            goto label_11;
          default:
            goto label_9;
        }
      }
label_2:
      ITransformationProvider transformationProvider;
      try
      {
        SavePointHelper._transformationProvider = Locator.GetService<ITransformationProvider>();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            default:
              transformationProvider = SavePointHelper._transformationProvider;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
              continue;
          }
        }
      }
      catch (DependencyResolutionException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_9;
        }
      }
label_10:
      return transformationProvider;
label_9:
      return (ITransformationProvider) null;
label_11:
      return SavePointHelper._transformationProvider;
    }

    /// <summary>Установить точку сохранения</summary>
    public static bool SavePoint(string key, IDbCommand dBCommand)
    {
      int num1 = 4;
      ITransformationProvider transformationProvider;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (dBCommand.Transaction != null)
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            case 2:
              transformationProvider = (ITransformationProvider) SavePointHelper.FMohcKW8Z99dJUChZpxB();
              num2 = 6;
              continue;
            case 4:
              if (dBCommand != null)
                goto case 1;
              else
                goto label_10;
            case 5:
              goto label_11;
            case 6:
              if (transformationProvider != null)
              {
                num2 = 5;
                continue;
              }
              goto label_12;
            default:
              goto label_3;
          }
        }
label_10:
        num1 = 3;
      }
label_3:
      return false;
label_11:
      return SavePointHelper.oqphV1W8IUj8oHQ8jf9n((object) transformationProvider, (object) key, SavePointHelper.zqqS9VW8uCwYA3HnnSMm((object) dBCommand));
label_12:
      return false;
    }

    /// <summary>Освободить точку сохранения</summary>
    /// <param name="key"></param>
    /// <param name="dBCommand"></param>
    public static void ReleaseSavePoint(string key, IDbCommand dBCommand)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider transformationProvider;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              if (dBCommand == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              if (SavePointHelper.zqqS9VW8uCwYA3HnnSMm((object) dBCommand) != null)
              {
                transformationProvider = (ITransformationProvider) SavePointHelper.FMohcKW8Z99dJUChZpxB();
                num2 = 4;
                continue;
              }
              goto label_13;
            case 3:
              goto label_14;
            case 4:
              goto label_10;
            case 5:
              SavePointHelper.q1oTVCW8VlEFVNq7kCFB((object) transformationProvider, (object) key, SavePointHelper.zqqS9VW8uCwYA3HnnSMm((object) dBCommand));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 4 : 6;
              continue;
            case 6:
              goto label_5;
            default:
              goto label_15;
          }
        }
label_10:
        if (transformationProvider != null)
        {
          num1 = 5;
          continue;
        }
        goto label_3;
label_13:
        num1 = 3;
      }
label_8:
      return;
label_14:
      return;
label_5:
      return;
label_15:
      return;
label_3:;
    }

    /// <summary>Откатить точку сохранения</summary>
    /// <param name="key"></param>
    /// <param name="dBCommand"></param>
    public static void RollBackSavePoint(string key, IDbCommand dBCommand)
    {
      int num = 1;
      ITransformationProvider transformationProvider;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dBCommand != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 2:
            if (transformationProvider != null)
            {
              num = 3;
              continue;
            }
            goto label_12;
          case 3:
            SavePointHelper.rvTNH6W8SVwDkY4nOHJd((object) transformationProvider, (object) key, (object) dBCommand.Transaction);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 1;
            continue;
          case 4:
            goto label_10;
          case 5:
            goto label_2;
          default:
            if (SavePointHelper.zqqS9VW8uCwYA3HnnSMm((object) dBCommand) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 4 : 3;
              continue;
            }
            transformationProvider = (ITransformationProvider) SavePointHelper.FMohcKW8Z99dJUChZpxB();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 2;
            continue;
        }
      }
label_10:
      return;
label_2:
      return;
label_12:
      return;
label_13:;
    }

    /// <summary>Сгенерировать уникальное имя точки сохранения</summary>
    /// <returns></returns>
    public static string GetSavePointKey() => (string) SavePointHelper.VPEetqW8qiUpsCv3DOuh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409003296), (object) SavePointHelper.p3FhnXW8iQKFvZ4YBDZ4().ToString((string) SavePointHelper.TUF00CW8RPdL9OlvNxMi(-710283084 ^ -537863435 ^ 173627983)));

    internal static bool TD0qnyW88u5P0Hg6qUVj() => Locator.Initialized;

    internal static bool wikojfW8C1YGwAQIO0x9() => SavePointHelper.zmsU1QW8QGVbLNUBVPja == null;

    internal static SavePointHelper GcumVAW8vb7bYsKEeJlu() => SavePointHelper.zmsU1QW8QGVbLNUBVPja;

    internal static object FMohcKW8Z99dJUChZpxB() => (object) SavePointHelper.TransformationProvider();

    internal static object zqqS9VW8uCwYA3HnnSMm([In] object obj0) => (object) ((IDbCommand) obj0).Transaction;

    internal static bool oqphV1W8IUj8oHQ8jf9n([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).SavePoint((string) obj1, (IDbTransaction) obj2);

    internal static void q1oTVCW8VlEFVNq7kCFB([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).ReleaseSavePoint((string) obj1, (IDbTransaction) obj2);

    internal static void rvTNH6W8SVwDkY4nOHJd([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).RollBackSavePoint((string) obj1, (IDbTransaction) obj2);

    internal static Guid p3FhnXW8iQKFvZ4YBDZ4() => Guid.NewGuid();

    internal static object TUF00CW8RPdL9OlvNxMi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VPEetqW8qiUpsCv3DOuh([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
