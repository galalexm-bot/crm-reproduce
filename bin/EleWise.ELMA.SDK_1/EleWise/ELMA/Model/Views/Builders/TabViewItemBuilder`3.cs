// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TabViewItemBuilder`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders
{
  public abstract class TabViewItemBuilder<TM, T, TB> : RootViewItemBuilder<TM, T, TB>
    where TM : IEntity
    where T : TabViewItem, new()
    where TB : TabViewItemBuilder<TM, T, TB>
  {
    private static object lxRpf7oatCfsGtCNLuSy;

    protected TabViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected TabViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TB Caption(string caption)
    {
      this.ViewItem.Caption = caption;
      return this as TB;
    }

    public TB AsyncLoading(bool asyncLoading = true)
    {
      this.ViewItem.AsyncLoading = asyncLoading;
      this.ViewItem.LoadingType = asyncLoading ? ViewItemLoadingType.AsyncLoading : ViewItemLoadingType.SyncLoading;
      return this as TB;
    }

    internal static bool eu5pjloawNOdR46oZhtQ() => TabViewItemBuilder<TM, T, TB>.lxRpf7oatCfsGtCNLuSy == null;

    internal static object nx8unQoa4VMQVp4uGYCw() => TabViewItemBuilder<TM, T, TB>.lxRpf7oatCfsGtCNLuSy;
  }
}
