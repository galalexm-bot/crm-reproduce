// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TypeDescriptor`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Абстрактный класс описания типа данных</summary>
  [Component]
  public abstract class TypeDescriptor<T> : TypeDescriptor
  {
    private static object iVtFUEoruSUiPLi8Dl7B;

    public virtual object SerializeSimple(T value) => this.SerializeSimple((object) value, typeof (T));

    public virtual T DeserializeSimple(object value) => (T) this.DeserializeSimple(value, typeof (T));

    protected TypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vp8ThcorI34EnYKYQXq6() => TypeDescriptor<T>.iVtFUEoruSUiPLi8Dl7B == null;

    internal static object Ym8MHWorVoOewpKRtJoy() => TypeDescriptor<T>.iVtFUEoruSUiPLi8Dl7B;
  }
}
