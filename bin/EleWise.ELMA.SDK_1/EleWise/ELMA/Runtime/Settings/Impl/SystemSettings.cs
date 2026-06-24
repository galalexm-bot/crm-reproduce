// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.Impl.SystemSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Settings.Impl
{
  /// <summary>Модель для хранения настроек в основной БД</summary>
  public class SystemSettings
  {
    internal static SystemSettings dOJyuyWhUBoCSytIm6a8;

    /// <summary>Уникальный идентификатор модуля</summary>
    public virtual Guid ModuleUid
    {
      get => this.\u003CModuleUid\u003Ek__BackingField;
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
              this.\u003CModuleUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    /// <summary>Ключ настройки</summary>
    public virtual string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    /// <summary>Значение настройки</summary>
    public virtual string Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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

    public override bool Equals(object obj)
    {
      int num = 2;
      SystemSettings systemSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (systemSettings != null)
            {
              if (!SystemSettings.VLunZPWGFq2SW62ZGtbc(systemSettings.ModuleUid, SystemSettings.WJXTAwWhzEAMZF5PlLZ3((object) this)))
              {
                num = 3;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            }
          case 2:
            systemSettings = obj as SystemSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_9;
          case 4:
            goto label_8;
          default:
            goto label_3;
        }
      }
label_3:
      return false;
label_8:
      return (string) SystemSettings.Bb04xXWGBlKRIqtj9kly((object) systemSettings) == (string) SystemSettings.Bb04xXWGBlKRIqtj9kly((object) this);
label_9:
      return false;
    }

    public override int GetHashCode()
    {
      int num = 1;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            guid = SystemSettings.WJXTAwWhzEAMZF5PlLZ3((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return guid.GetHashCode() * 397 ^ (this.Key ?? "").GetHashCode();
    }

    public SystemSettings()
    {
      SystemSettings.As2ZaTWGWijTHQ4kCJ4w();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jR6G64WhsyBmYqQS8MS4() => SystemSettings.dOJyuyWhUBoCSytIm6a8 == null;

    internal static SystemSettings dCVCJHWhcDCcKdsSKaba() => SystemSettings.dOJyuyWhUBoCSytIm6a8;

    internal static Guid WJXTAwWhzEAMZF5PlLZ3([In] object obj0) => ((SystemSettings) obj0).ModuleUid;

    internal static bool VLunZPWGFq2SW62ZGtbc([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object Bb04xXWGBlKRIqtj9kly([In] object obj0) => (object) ((SystemSettings) obj0).Key;

    internal static void As2ZaTWGWijTHQ4kCJ4w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
