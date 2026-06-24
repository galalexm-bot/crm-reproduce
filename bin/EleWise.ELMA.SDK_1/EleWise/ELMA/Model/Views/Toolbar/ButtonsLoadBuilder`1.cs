// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.ButtonsLoadBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  public class ButtonsLoadBuilder<TContext> where TContext : IEntity
  {
    private readonly RootToolbarItem parent;
    internal static object S5eC5NowNQfo2HHfnEXb;

    internal ButtonsLoadBuilder(RootToolbarItem parent)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.parent = parent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Кнопка</summary>
    /// <param name="uid">Идентификатор кнопки (найти кнопку с указанным идентификатором, или создать новую)</param>
    /// <returns>Builder кнопки</returns>
    public ButtonLoadBuilder<TContext> Button(string uid = null) => new ButtonLoadBuilder<TContext>(this.parent, uid);

    /// <summary>Разделитель</summary>
    /// <param name="uid">Идентификатор разделителя (найти разделитель с указанным идентификатором, или создать новый)</param>
    /// <returns>Builder разделителя</returns>
    public SeparatorLoadBuilder<TContext> Separator(string uid = null) => new SeparatorLoadBuilder<TContext>(this.parent, uid);

    internal static bool jAMvy4ow3eiIfV3dn2ek() => ButtonsLoadBuilder<TContext>.S5eC5NowNQfo2HHfnEXb == null;

    internal static object DE6j5howpb5grT3ZSXa2() => ButtonsLoadBuilder<TContext>.S5eC5NowNQfo2HHfnEXb;
  }
}
