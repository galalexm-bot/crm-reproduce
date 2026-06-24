// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.ApplicationUnit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Modules.Impl
{
  /// <summary>Часть приложения</summary>
  internal abstract class ApplicationUnit : IApplicationUnit
  {
    internal static ApplicationUnit XH5B0rNQkrCQlp0LSNe;

    /// <summary>Строковый идентификатор</summary>
    public abstract string Id { get; }

    /// <summary>Уникальный идентификатор</summary>
    public abstract Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    public abstract string Title { get; }

    /// <summary>Описание</summary>
    public abstract string Description { get; }

    /// <summary>Номер версии</summary>
    public abstract string Version { get; }

    /// <summary>Автор</summary>
    public abstract string Author { get; }

    /// <summary>Владелец</summary>
    public IApplicationUnit Owner
    {
      get => this.\u003COwner\u003Ek__BackingField;
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
              this.\u003COwner\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    public override string ToString() => (string) ApplicationUnit.QMy4QnN8FhOtnWDQLtt((object) this);

    protected ApplicationUnit()
    {
      ApplicationUnit.H2FNRCNZuU8Iu54eeVU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gQKsE4NCi4oiq6MJYtP() => ApplicationUnit.XH5B0rNQkrCQlp0LSNe == null;

    internal static ApplicationUnit svxuQANvn1ZJWyiMD2V() => ApplicationUnit.XH5B0rNQkrCQlp0LSNe;

    internal static object QMy4QnN8FhOtnWDQLtt([In] object obj0) => (object) ((ApplicationUnit) obj0).Id;

    internal static void H2FNRCNZuU8Iu54eeVU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
