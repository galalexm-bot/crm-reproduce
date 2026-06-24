// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PageMetadataUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>Обновление метаданных на новый рантайм для страниц</summary>
  internal sealed class PageMetadataUpdateHandler : FormMetadataUpdateHandler
  {
    internal static PageMetadataUpdateHandler XLWoYTgVIqXw0BbMgDD;

    /// <inheritdoc />
    public override bool Check(IMetadata metadata) => metadata is PageMetadata;

    /// <inheritdoc />
    protected override string OnLoadScriptName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283433675);

    /// <inheritdoc />
    protected override string GetMetadataName(IMetadataUpdateResult updateResult) => ((NamedMetadata) PageMetadataUpdateHandler.VjholQgRo6nPVTCh3NZ((object) updateResult)).Name;

    /// <inheritdoc />
    protected override FormPartMetadata GetContent(IMetadataUpdateResult updateResult) => (FormPartMetadata) ((PageMetadata) PageMetadataUpdateHandler.VjholQgRo6nPVTCh3NZ((object) updateResult)).Content;

    /// <inheritdoc />
    protected override string GetViewModelTypeName(IMetadataUpdateResult updateResult) => (string) PageMetadataUpdateHandler.usPDYfgKb0Bb6QQn1tJ(PageMetadataUpdateHandler.SUO9SBgqGrXKdO6NLTu(132912447 ^ 132960535), (object) this.GetMetadataName(updateResult), PageMetadataUpdateHandler.SUO9SBgqGrXKdO6NLTu(-1487388570 ^ -1487371218));

    /// <inheritdoc />
    protected override string GetLoadViewModelTypeName(IMetadataUpdateResult updateResult) => (string) PageMetadataUpdateHandler.usPDYfgKb0Bb6QQn1tJ(PageMetadataUpdateHandler.SUO9SBgqGrXKdO6NLTu(-2138160520 ^ -2138143198), PageMetadataUpdateHandler.eNhndpgXhQnVB5ASA2H((object) this, (object) updateResult), PageMetadataUpdateHandler.SUO9SBgqGrXKdO6NLTu(~-397266137 ^ 397215888));

    /// <inheritdoc />
    protected override string ItemViewModelTypeName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16737691);

    public PageMetadataUpdateHandler()
    {
      PageMetadataUpdateHandler.B7PkB1gT998aKd5bhZ8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QSxvmdgSsS4I3KkFUOv() => PageMetadataUpdateHandler.XLWoYTgVIqXw0BbMgDD == null;

    internal static PageMetadataUpdateHandler G2PnOBgifZnfK4Njk5u() => PageMetadataUpdateHandler.XLWoYTgVIqXw0BbMgDD;

    internal static object VjholQgRo6nPVTCh3NZ([In] object obj0) => (object) ((IMetadataUpdateResult) obj0).Metadata;

    internal static object SUO9SBgqGrXKdO6NLTu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object usPDYfgKb0Bb6QQn1tJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object eNhndpgXhQnVB5ASA2H([In] object obj0, [In] object obj1) => (object) ((FormMetadataUpdateHandler) obj0).GetMetadataName((IMetadataUpdateResult) obj1);

    internal static void B7PkB1gT998aKd5bhZ8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
