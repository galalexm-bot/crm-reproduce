// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.RestartBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Hасширитель поведения для <see cref="F:EleWise.ELMA.Model.Enums.PublicationType.Restart" /> публикации
  /// </summary>
  internal sealed class RestartBehaviour : DeltaRestartBaseBehaviour
  {
    internal static RestartBehaviour vq8ZBSblLrjc5DsvTt3T;

    /// <inheritdoc />
    public override PublicationType Check(CheckType action, object oldValue, object newValue) => this.Check(PublicationType.Restart, action, oldValue, newValue);

    public RestartBehaviour()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cBTZ8rblUVrM2ov8iv6q() => RestartBehaviour.vq8ZBSblLrjc5DsvTt3T == null;

    internal static RestartBehaviour WmIPaIblsjn1sgc4NNhY() => RestartBehaviour.vq8ZBSblLrjc5DsvTt3T;
  }
}
