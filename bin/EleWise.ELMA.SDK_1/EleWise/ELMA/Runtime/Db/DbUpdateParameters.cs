// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbUpdateParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Параметры обновления БД</summary>
  public struct DbUpdateParameters
  {
    private static object KBffRpWZAWsO0aUwebdm;

    /// <summary>
    /// Нужно ли пересоздавать ограничения, индексы и внешние ключи
    /// </summary>
    public bool RecreateConstraints
    {
      get => this.\u003CRecreateConstraints\u003Ek__BackingField;
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
              this.\u003CRecreateConstraints\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    internal static bool MkgiiBWZ7melxQ9dFtm6() => DbUpdateParameters.KBffRpWZAWsO0aUwebdm == null;

    internal static object H1vqk1WZxFfPSCe6xBt1() => DbUpdateParameters.KBffRpWZAWsO0aUwebdm;
  }
}
