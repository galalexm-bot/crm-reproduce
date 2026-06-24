// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.PortletDynamicFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  [Component]
  public class PortletDynamicFormProvider : UIDynamicFormProvider
  {
    public static readonly Guid UID;
    internal static PortletDynamicFormProvider ASPg98codWgSHqqAwHC;

    public override Guid Uid => PortletDynamicFormProvider.UID;

    public static string CreateData(
      FormDescriptor formDescriptor,
      FormPartMetadata partMetadata,
      int portletManagerScope,
      string portletManagerPath,
      Guid portletId,
      Guid instanceId,
      string path)
    {
      return (string) PortletDynamicFormProvider.Dt3XndcGkIJYIrrJ7h7((object) formDescriptor, (object) partMetadata, portletManagerScope, (object) portletManagerPath, portletId, instanceId, (object) path);
    }

    protected override UIViewItemParams ParseViewItemParams(string dynamicFormsProviderData) => (UIViewItemParams) new PortletViewItemParams(dynamicFormsProviderData);

    protected override Type GetItemViewModelType(Type itemType, FormDescriptor descriptor)
    {
      int num1 = 3;
      PortletDescriptor portletDescriptor;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              PortletDynamicFormProvider.X8Yx9ncfZ0J7Tlbecbi((object) descriptor, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289719136));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_5;
            default:
              portletDescriptor = (PortletDescriptor) descriptor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
              continue;
          }
        }
label_5:
        PortletDynamicFormProvider.X8Yx9ncfZ0J7Tlbecbi((object) itemType, PortletDynamicFormProvider.Y062OucEnvtCP1vf1T7(1113862659 ^ 1113908359));
        num1 = 2;
      }
label_3:
      // ISSUE: type reference
      return PortletDynamicFormProvider.rMBWQncQNePbRff8RnY(__typeref (PortletContentItemViewModel<,>)).MakeGenericType(itemType, PortletDynamicFormProvider.jIq5LjcCxMr5yUn3SvZ((object) portletDescriptor));
    }

    protected override Type GetViewModelType(Type entityType, FormDescriptor descriptor)
    {
      int num = 1;
      PortletDescriptor portletDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) entityType, (string) PortletDynamicFormProvider.Y062OucEnvtCP1vf1T7(1253244298 - 1829393894 ^ -576162768));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            portletDescriptor = (PortletDescriptor) descriptor;
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            PortletDynamicFormProvider.X8Yx9ncfZ0J7Tlbecbi((object) descriptor, PortletDynamicFormProvider.Y062OucEnvtCP1vf1T7(1051276242 - 990076387 ^ 61187877));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 0;
            continue;
        }
      }
label_5:
      // ISSUE: type reference
      return PortletDynamicFormProvider.rMBWQncQNePbRff8RnY(__typeref (PortletContentViewModel<,>)).MakeGenericType(entityType, PortletDynamicFormProvider.jIq5LjcCxMr5yUn3SvZ((object) portletDescriptor));
    }

    protected override object CreateItemViewModelType(
      Type itemViewModelType,
      FormDescriptor descriptor,
      IEntity entity,
      RootViewItem view,
      UIViewItemParams viewItemParams)
    {
      int num = 2;
      PortletViewItemParams portletViewItemParams;
      IPortletPersonalization portletPersonalization;
      while (true)
      {
        switch (num)
        {
          case 1:
            PortletDynamicFormProvider.X8Yx9ncfZ0J7Tlbecbi((object) viewItemParams, PortletDynamicFormProvider.Y062OucEnvtCP1vf1T7(-542721635 ^ -542744261));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) itemViewModelType, (string) PortletDynamicFormProvider.Y062OucEnvtCP1vf1T7(-1872275253 >> 6 ^ -29275141));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          case 4:
            portletPersonalization = (IPortletPersonalization) PortletDynamicFormProvider.J4NAMAcZWq0RZ8gPvsl((object) Locator.GetServiceNotNull<IPortletPersonalizationLoader>(), PortletDynamicFormProvider.PA9DvRcvaVIatN2TJqZ((object) portletViewItemParams), (object) portletViewItemParams.PortletManagerPath, portletViewItemParams.PortletId, portletViewItemParams.InstanceId, PortletDynamicFormProvider.sQqSlIc8YAfh3J0JW7G((object) portletViewItemParams));
            num = 3;
            continue;
          default:
            portletViewItemParams = (PortletViewItemParams) viewItemParams;
            num = 4;
            continue;
        }
      }
label_3:
      return PortletDynamicFormProvider.WMCJmBcuEFIOHoOpE1F(itemViewModelType, (object) new object[3]
      {
        (object) entity,
        (object) portletPersonalization,
        (object) view
      });
    }

    protected override object CreateViewModelType(
      Type viewModelType,
      FormDescriptor descriptor,
      IEntity entity,
      RootViewItem view,
      UIViewItemParams viewItemParams)
    {
      int num1 = 2;
      PortletDescriptor portletDescriptor;
      IPortletPersonalization portletPersonalization;
      while (true)
      {
        int num2 = num1;
        PortletViewItemParams portletViewItemParams;
        while (true)
        {
          switch (num2)
          {
            case 1:
              PortletDynamicFormProvider.X8Yx9ncfZ0J7Tlbecbi((object) descriptor, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123628364));
              num2 = 5;
              continue;
            case 2:
              PortletDynamicFormProvider.X8Yx9ncfZ0J7Tlbecbi((object) viewModelType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867773710));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_4;
            case 4:
              portletViewItemParams = (PortletViewItemParams) viewItemParams;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_7;
            default:
              portletPersonalization = (IPortletPersonalization) PortletDynamicFormProvider.J4NAMAcZWq0RZ8gPvsl((object) Locator.GetServiceNotNull<IPortletPersonalizationLoader>(), PortletDynamicFormProvider.PA9DvRcvaVIatN2TJqZ((object) portletViewItemParams), PortletDynamicFormProvider.SuOV7dcI7qLmJbIHP2g((object) portletViewItemParams), portletViewItemParams.PortletId, portletViewItemParams.InstanceId, (object) portletViewItemParams.Path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 3;
              continue;
          }
        }
label_7:
        portletDescriptor = (PortletDescriptor) descriptor;
        num1 = 4;
      }
label_4:
      return PortletDynamicFormProvider.WMCJmBcuEFIOHoOpE1F(viewModelType, (object) new object[4]
      {
        (object) portletDescriptor.Content,
        (object) entity,
        (object) portletPersonalization,
        (object) view
      });
    }

    protected override object GetResult(object viewModel)
    {
      int num = 2;
      IPortletContentViewModel contentViewModel;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (contentViewModel == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            contentViewModel = viewModel as IPortletContentViewModel;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return PortletDynamicFormProvider.RsuKiScVRmVnekmOkmw((object) contentViewModel);
    }

    public PortletDynamicFormProvider()
    {
      PortletDynamicFormProvider.a5SueycSyvEHQwq7CVO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PortletDynamicFormProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PortletDynamicFormProvider.UID = new Guid((string) PortletDynamicFormProvider.Y062OucEnvtCP1vf1T7(825385222 ^ 825407936));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object Dt3XndcGkIJYIrrJ7h7(
      [In] object obj0,
      [In] object obj1,
      int portletManagerScope,
      [In] object obj3,
      Guid portletId,
      Guid instanceId,
      [In] object obj6)
    {
      return (object) PortletViewItemProvider.CreateViewItemId((FormDescriptor) obj0, (FormPartMetadata) obj1, portletManagerScope, (string) obj3, portletId, instanceId, (string) obj6);
    }

    internal static bool B979m0cbXafOUmeqA6P() => PortletDynamicFormProvider.ASPg98codWgSHqqAwHC == null;

    internal static PortletDynamicFormProvider fO0WfmchkuK8yQJKQXC() => PortletDynamicFormProvider.ASPg98codWgSHqqAwHC;

    internal static object Y062OucEnvtCP1vf1T7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void X8Yx9ncfZ0J7Tlbecbi([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type rMBWQncQNePbRff8RnY([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type jIq5LjcCxMr5yUn3SvZ([In] object obj0) => ((PortletDescriptor) obj0).PersonalizationType;

    internal static int PA9DvRcvaVIatN2TJqZ([In] object obj0) => ((PortletViewItemParams) obj0).PortletManagerScope;

    internal static object sQqSlIc8YAfh3J0JW7G([In] object obj0) => (object) ((PortletViewItemParams) obj0).Path;

    internal static object J4NAMAcZWq0RZ8gPvsl(
      [In] object obj0,
      int portletManagerScope,
      [In] object obj2,
      Guid portletId,
      Guid instanceId,
      [In] object obj5)
    {
      return (object) ((IPortletPersonalizationLoader) obj0).Load(portletManagerScope, (string) obj2, portletId, instanceId, (string) obj5);
    }

    internal static object WMCJmBcuEFIOHoOpE1F([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

    internal static object SuOV7dcI7qLmJbIHP2g([In] object obj0) => (object) ((PortletViewItemParams) obj0).PortletManagerPath;

    internal static object RsuKiScVRmVnekmOkmw([In] object obj0) => (object) ((IFormViewModel) obj0).Result;

    internal static void a5SueycSyvEHQwq7CVO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
