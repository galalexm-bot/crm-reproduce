// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Components.PageObjectFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Components
{
  /// <summary>Провайдер для форм страниц</summary>
  [Component]
  internal sealed class PageObjectFormProvider : IObjectFormProvider
  {
    private readonly FormDescriptorProvider formDescriptorProvider;
    internal static PageObjectFormProvider HtlLqdBZcQIY33xVRETJ;

    /// <summary>Ctor</summary>
    /// <param name="formDescriptorProvider">Провайдер дескриптора страниц</param>
    public PageObjectFormProvider(FormDescriptorProvider formDescriptorProvider)
    {
      PageObjectFormProvider.xBsD6cBuBgbS2DMO20SH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.formDescriptorProvider = formDescriptorProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public bool Check(Guid typeUid, Guid subTypeUid)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!PageObjectFormProvider.gFaYUkBuWeP6W750qq0c(typeUid, PageMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return PageObjectFormProvider.EvMKmyBuovi7EaB4oWyN((object) this.formDescriptorProvider, typeUid, subTypeUid, false) is PageDescriptor;
label_5:
      return false;
    }

    /// <inheritdoc />
    public (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
    {
      FormDescriptor descriptorByHeaderUid = this.formDescriptorProvider.GetDescriptorByHeaderUid(PageMetadata.TypeUid, subTypeUid, false);
      PageMetadata metadata = (PageMetadata) descriptorByHeaderUid.Metadata;
      Type type = descriptorByHeaderUid.Assembly.GetType(metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740353526) + metadata.Content.Context.Name);
      return (new EntityJsonSerializer().Deserialize(model, type, false), (ClassMetadata) metadata.Content.Context);
    }

    /// <inheritdoc />
    public FormViewItem GetFormByType(object obj, ViewType viewType) => throw new NotImplementedException(EleWise.ELMA.SR.T((string) PageObjectFormProvider.RUIY2oBub4nmO2B9GmJd(-1939377524 ^ -1939439922)));

    /// <inheritdoc />
    public FormViewItem GetFormByUid(object obj, Guid formUid) => ClassSerializationHelper.CloneObjectByXml<FormViewItem>((FormViewItem) PageObjectFormProvider.VSQ9eyBuGParM4km8aFH((object) ((FormPartDescriptor<PageDescriptor, PageContentMetadata>) PageObjectFormProvider.fMieAABuhEHMyhdVcL3h((object) (PageDescriptor) this.formDescriptorProvider.GetDescriptorByHeaderUid(PageMetadata.TypeUid, formUid, false))).Metadata));

    /// <inheritdoc />
    public void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
    {
    }

    internal static void xBsD6cBuBgbS2DMO20SH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MS8bxWBZzX6CEKJJCIK4() => PageObjectFormProvider.HtlLqdBZcQIY33xVRETJ == null;

    internal static PageObjectFormProvider cE9qIaBuFWoj5rYCjIMi() => PageObjectFormProvider.HtlLqdBZcQIY33xVRETJ;

    internal static bool gFaYUkBuWeP6W750qq0c([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object EvMKmyBuovi7EaB4oWyN(
      [In] object obj0,
      Guid metadataType,
      Guid headerUid,
      bool forEmulation)
    {
      return (object) ((FormDescriptorProvider) obj0).GetDescriptorByHeaderUid(metadataType, headerUid, forEmulation);
    }

    internal static object RUIY2oBub4nmO2B9GmJd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fMieAABuhEHMyhdVcL3h([In] object obj0) => (object) ((PageDescriptor) obj0).Content;

    internal static object VSQ9eyBuGParM4km8aFH([In] object obj0) => (object) ((FormPartMetadata) obj0).View;
  }
}
