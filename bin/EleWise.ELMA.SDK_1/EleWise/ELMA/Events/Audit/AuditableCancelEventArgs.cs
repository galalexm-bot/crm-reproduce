// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.AuditableCancelEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Параметры события для обработчика <see cref="T:EleWise.ELMA.Events.Audit.IAuditableEventHandler" /> с возможностью отмены обработки
  /// </summary>
  public class AuditableCancelEventArgs : AuditableEventArgs
  {
    internal static AuditableCancelEventArgs sBFRhyGL6HKbFHU17blK;

    /// <summary>Нужно ли отменить обработку</summary>
    public bool Cancel
    {
      get => this.\u003CCancel\u003Ek__BackingField;
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
              this.\u003CCancel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    public AuditableCancelEventArgs()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dC2FnRGLHnEQgflkGmXl() => AuditableCancelEventArgs.sBFRhyGL6HKbFHU17blK == null;

    internal static AuditableCancelEventArgs wkvenNGLAsfPHX7f4LcO() => AuditableCancelEventArgs.sBFRhyGL6HKbFHU17blK;
  }
}
