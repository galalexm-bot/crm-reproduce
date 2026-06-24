// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.ItemsDeletingEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Параметры события перед удалением каких-либо элементов
  /// </summary>
  public abstract class ItemsDeletingEventArgs : EventArgs
  {
    private List<string> skipNames;
    private static ItemsDeletingEventArgs nJ99ylWSpinVYgRD9gNu;

    /// <summary>
    /// Имена элементов, которые не нужно удалять (в формате ИМЯ_ТАБЛИЦЫ.ИМЯ_КОЛОНКИ или просто ИМЯ_КОЛОНКИ)
    /// </summary>
    public List<string> SkipNames => this.skipNames;

    protected ItemsDeletingEventArgs()
    {
      ItemsDeletingEventArgs.kkfybVWStBb2UPsUXTKx();
      this.skipNames = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void kkfybVWStBb2UPsUXTKx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool w01QUAWSaSwQkrlpjI8i() => ItemsDeletingEventArgs.nJ99ylWSpinVYgRD9gNu == null;

    internal static ItemsDeletingEventArgs H4WE6tWSDs0HNjHdkQGZ() => ItemsDeletingEventArgs.nJ99ylWSpinVYgRD9gNu;
  }
}
