// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.LifetimeScopeAccessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Доступ к текущему контексту</summary>
  public class LifetimeScopeAccessor : ILifetimeScopeAccessor
  {
    private Func<ILifetimeScope> current;
    private static LifetimeScopeAccessor oB7asEfZ7YrnRUgeBSsZ;

    public LifetimeScopeAccessor(Func<ILifetimeScope> current)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.current = current != null ? current : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323059634));
      this.CurrentType = ServiceScope.Application;
    }

    public ILifetimeScope Current => this.current();

    public ServiceScope CurrentType
    {
      get => this.\u003CCurrentType\u003Ek__BackingField;
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
              this.\u003CCurrentType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    public void SetAccessor(Func<ILifetimeScope> accessor) => this.current = accessor != null ? accessor : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561278466));

    internal static bool xouseJfZx26Psgy7YHAL() => LifetimeScopeAccessor.oB7asEfZ7YrnRUgeBSsZ == null;

    internal static LifetimeScopeAccessor aX7LDgfZ0mB9cuY8fMK3() => LifetimeScopeAccessor.oB7asEfZ7YrnRUgeBSsZ;
  }
}
