// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.DeltaBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Hасширитель поведения для <see cref="F:EleWise.ELMA.Model.Enums.PublicationType.Delta" /> публикации
  /// </summary>
  internal sealed class DeltaBehaviour : DeltaRestartBaseBehaviour
  {
    internal static DeltaBehaviour ifwgQgblcZRJ7hqf0HMk;

    /// <inheritdoc />
    public override PublicationType Check(CheckType action, object oldValue, object newValue) => this.Check(PublicationType.Delta, action, oldValue, newValue);

    public DeltaBehaviour()
    {
      DeltaBehaviour.mUT90MbrBYaC9BH0qWZF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ypUbOKblz0H5aqM4J4tf() => DeltaBehaviour.ifwgQgblcZRJ7hqf0HMk == null;

    internal static DeltaBehaviour NT4Nd9brFfLrnGYhnLc7() => DeltaBehaviour.ifwgQgblcZRJ7hqf0HMk;

    internal static void mUT90MbrBYaC9BH0qWZF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
