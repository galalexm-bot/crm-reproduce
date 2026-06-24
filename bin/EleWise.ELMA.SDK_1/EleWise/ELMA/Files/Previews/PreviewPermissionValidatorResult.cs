// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.PreviewPermissionValidatorResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Результат проверки доступа для отображения превью</summary>
  public sealed class PreviewPermissionValidatorResult
  {
    internal static PreviewPermissionValidatorResult M3IIJVGO2DIBkLZhmXe8;

    /// <summary>Ctor</summary>
    /// <param name="isValid">Возможен ли показ превью</param>
    /// <param name="message">Сообщение пользователю</param>
    public PreviewPermissionValidatorResult(bool isValid, string message)
    {
      PreviewPermissionValidatorResult.I7Re2rGO1tbWlJhpfPdl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.IsValid = isValid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            this.Message = message;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Возможен ли показ превью</summary>
    public bool IsValid
    {
      get => this.\u003CIsValid\u003Ek__BackingField;
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
              this.\u003CIsValid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Сообщение пользователю</summary>
    public string Message
    {
      get => this.\u003CMessage\u003Ek__BackingField;
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
              this.\u003CMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    internal static void I7Re2rGO1tbWlJhpfPdl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool G2qVk5GOeSPTKENkCNeI() => PreviewPermissionValidatorResult.M3IIJVGO2DIBkLZhmXe8 == null;

    internal static PreviewPermissionValidatorResult TiKDQuGOPBQYLX0UQ8QF() => PreviewPermissionValidatorResult.M3IIJVGO2DIBkLZhmXe8;
  }
}
