// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.StringDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Строка"</summary>
  [Component(Order = 100)]
  public class StringDescriptor : StringDescriptor<StringSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{9B9AAC17-22BB-425C-AA93-9C02C5146965}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static StringDescriptor KW8shXolsBwyeN7k8k5y;

    /// <summary>Uid типа</summary>
    public override Guid Uid => StringDescriptor.UID;

    /// <summary>Имя "Строка"</summary>
    public override string Name => (string) StringDescriptor.GUo9inorB92GpdFGg5Qc(StringDescriptor.xwk4I1orFSnmuJw3m9Qu(-1088304168 ^ -1088186782));

    /// <summary>Разрешить использовать для идентификатора сущности</summary>
    public override bool UseForId => true;

    public StringDescriptor()
    {
      StringDescriptor.vpPnHVorWgZvDJ9eqFDr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static StringDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            StringDescriptor.vpPnHVorWgZvDJ9eqFDr();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            StringDescriptor.UID = new Guid((string) StringDescriptor.xwk4I1orFSnmuJw3m9Qu(-1445902765 ^ -1980277732 ^ 539278009));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object xwk4I1orFSnmuJw3m9Qu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GUo9inorB92GpdFGg5Qc([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Dpig5KolcsSHMNy20qJ7() => StringDescriptor.KW8shXolsBwyeN7k8k5y == null;

    internal static StringDescriptor BhE6p3olzMJPRDKj55ZB() => StringDescriptor.KW8shXolsBwyeN7k8k5y;

    internal static void vpPnHVorWgZvDJ9eqFDr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
