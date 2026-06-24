// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.PageDynamicFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  public class PageDynamicFormProvider : UIDynamicFormProvider
  {
    public static readonly Guid UID;
    private static PageDynamicFormProvider weCsPDsnLKKHySVyqhc;

    public override Guid Uid => PageDynamicFormProvider.UID;

    public static string CreateData(FormDescriptor formDescriptor, FormPartMetadata partMetadata) => (string) PageDynamicFormProvider.hSYtE5seicI1QoOrhwF((object) formDescriptor, (object) partMetadata);

    protected override Type GetItemViewModelType(Type itemType, FormDescriptor descriptor)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PageDynamicFormProvider.VB9qTts1EWG5fXEMx60((object) itemType, PageDynamicFormProvider.iPDVFksPu53xopgwTHM(-1146510045 ^ -1146522713));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: type reference
      return PageDynamicFormProvider.DQHTBGsNmjTCKUUdZWE(__typeref (PageItemViewModel<>)).MakeGenericType(itemType);
    }

    protected override Type GetViewModelType(Type entityType, FormDescriptor descriptor)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PageDynamicFormProvider.VB9qTts1EWG5fXEMx60((object) entityType, PageDynamicFormProvider.iPDVFksPu53xopgwTHM(-2092274397 << 4 ^ 883294628));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return PageDynamicFormProvider.DQHTBGsNmjTCKUUdZWE(__typeref (PageViewModel<>)).MakeGenericType(entityType);
    }

    protected override object CreateItemViewModelType(
      Type itemViewModelType,
      FormDescriptor descriptor,
      IEntity entity,
      RootViewItem view,
      UIViewItemParams viewItemParams)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PageDynamicFormProvider.VB9qTts1EWG5fXEMx60((object) itemViewModelType, PageDynamicFormProvider.iPDVFksPu53xopgwTHM(589593376 ^ -1977315327 ^ -1459601991));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Activator.CreateInstance(itemViewModelType, (object) entity, (object) view);
    }

    protected override object CreateViewModelType(
      Type viewModelType,
      FormDescriptor descriptor,
      IEntity entity,
      RootViewItem view,
      UIViewItemParams viewItemParams)
    {
      int num = 3;
      PageDescriptor pageDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            PageDynamicFormProvider.VB9qTts1EWG5fXEMx60((object) descriptor, PageDynamicFormProvider.iPDVFksPu53xopgwTHM(-2112703338 ^ -2112698788));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 3:
            PageDynamicFormProvider.VB9qTts1EWG5fXEMx60((object) viewModelType, PageDynamicFormProvider.iPDVFksPu53xopgwTHM(-740338220 ^ -740326550));
            num = 2;
            continue;
          default:
            pageDescriptor = (PageDescriptor) descriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
            continue;
        }
      }
label_3:
      return PageDynamicFormProvider.Frt3jTspFsqBkaA9Lj7(viewModelType, (object) new object[3]
      {
        PageDynamicFormProvider.nIt7g2s3ecvyuuDuAKB((object) pageDescriptor),
        (object) entity,
        (object) view
      });
    }

    protected override object GetResult(object viewModel)
    {
      int num = 2;
      IPageViewModel pageViewModel;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (pageViewModel == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            pageViewModel = viewModel as IPageViewModel;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (object) null;
label_4:
      return PageDynamicFormProvider.tFIlARsahwClnH5TdAf((object) pageViewModel);
    }

    public PageDynamicFormProvider()
    {
      PageDynamicFormProvider.LADyWbsD3nDiICZoaAM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PageDynamicFormProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PageDynamicFormProvider.UID = new Guid((string) PageDynamicFormProvider.iPDVFksPu53xopgwTHM(-1710575414 ^ -1710594538));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            PageDynamicFormProvider.LADyWbsD3nDiICZoaAM();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object hSYtE5seicI1QoOrhwF([In] object obj0, [In] object obj1) => (object) UIViewItemProvider.CreateViewItemId((FormDescriptor) obj0, (FormPartMetadata) obj1);

    internal static bool nwWiDBsOBDWAqvP0s1A() => PageDynamicFormProvider.weCsPDsnLKKHySVyqhc == null;

    internal static PageDynamicFormProvider vIyxuhs2qhZFE7WE7yv() => PageDynamicFormProvider.weCsPDsnLKKHySVyqhc;

    internal static object iPDVFksPu53xopgwTHM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void VB9qTts1EWG5fXEMx60([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type DQHTBGsNmjTCKUUdZWE([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object nIt7g2s3ecvyuuDuAKB([In] object obj0) => (object) ((PageDescriptor) obj0).Content;

    internal static object Frt3jTspFsqBkaA9Lj7([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

    internal static object tFIlARsahwClnH5TdAf([In] object obj0) => (object) ((IFormViewModel) obj0).Result;

    internal static void LADyWbsD3nDiICZoaAM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
