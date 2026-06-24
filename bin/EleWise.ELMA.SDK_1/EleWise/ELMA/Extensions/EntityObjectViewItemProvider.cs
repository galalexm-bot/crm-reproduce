// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EntityObjectViewItemProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Провайдер информации о представлении на основе сущности
  /// </summary>
  [Component]
  public class EntityObjectViewItemProvider : IObjectViewItemProvider
  {
    public static readonly Guid UID;
    internal static EntityObjectViewItemProvider hWOkRkGHwZ6ceSNF69w6;

    public IMetadataRuntimeService MetadataRuntimeService
    {
      get => this.\u003CMetadataRuntimeService\u003Ek__BackingField;
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
              this.\u003CMetadataRuntimeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    public virtual Guid ProviderUid => EntityObjectViewItemProvider.UID;

    public static string CreateViewItemId(IEntity entity, ViewType viewType, ItemType itemType)
    {
      int num = 3;
      Type type;
      FormViewItem formViewItem;
      ViewType viewType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            viewType1 = viewType;
            num = 4;
            continue;
          case 3:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 2;
            continue;
          case 4:
            if (entity == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 5 : 5;
              continue;
            }
            type = EntityObjectViewItemProvider.pvM9miGHHmkOqJEAeW04((object) entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_4;
          default:
            // ISSUE: reference to a compiler-generated method
            formViewItem = ((ClassMetadata) MetadataLoader.LoadMetadata(type)).GetForms().FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (f => EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass7_0.GfQ8jQ8GXAGbKRxZTneb((object) f) == viewType1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
            continue;
        }
      }
label_4:
      return (string) null;
label_9:
      return (string) EntityObjectViewItemProvider.u66YqCGHxAW7XwTc19s9(EntityObjectViewItemProvider.CDeXkoGHAyAPfwC4ioHx(874012245 ^ 873990793), (object) new object[5]
      {
        (object) (int) viewType1,
        (object) (formViewItem != null ? formViewItem.Uid : Guid.Empty),
        (object) (int) itemType,
        (object) InterfaceActivator.UID(type),
        EntityObjectViewItemProvider.Kq4bVoGH7CZrqHfBvKCN((object) entity)
      });
    }

    public virtual ViewItem GetViewItem(string viewItemId)
    {
      int num1 = 5;
      Guid result1;
      Type typeByUid;
      Guid result2;
      EntityObjectViewItemProvider viewItemProvider;
      ViewType viewType;
      ItemType itemType;
      while (true)
      {
        int num2 = num1;
        Guid uid;
        string[] source;
        while (true)
        {
          switch (num2)
          {
            case 1:
              uid = new Guid(source[3]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 11 : 0;
              continue;
            case 2:
              result1 = Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_6;
            case 4:
              viewItemProvider = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 13 : 7;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              if (!Guid.TryParse(((IEnumerable<string>) source).Last<string>(), out result2))
              {
                if (!EntityObjectViewItemProvider.NR76RcGHykxgaAdllbIa(result1, Guid.Empty))
                {
                  num2 = 3;
                  continue;
                }
                goto label_7;
              }
              else
              {
                num2 = 8;
                continue;
              }
            case 7:
              itemType = (ItemType) EntityObjectViewItemProvider.rKJ0xBGHmZUCuh08DUTa((object) source[2]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
              continue;
            case 8:
              goto label_9;
            case 9:
              goto label_13;
            case 10:
              if (source.Length >= 4)
              {
                viewType = (ViewType) EntityObjectViewItemProvider.rKJ0xBGHmZUCuh08DUTa((object) source[0]);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 2;
                continue;
              }
              num2 = 9;
              continue;
            case 11:
              typeByUid = this.MetadataRuntimeService.GetTypeByUid(uid);
              num2 = 6;
              continue;
            case 12:
              goto label_22;
            case 13:
              if (EntityObjectViewItemProvider.YPAfXdGH0PBNxrtkB3iX((object) viewItemId))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 9 : 12;
                continue;
              }
              source = viewItemId.Split(new string[1]
              {
                (string) EntityObjectViewItemProvider.CDeXkoGHAyAPfwC4ioHx(-105199646 ^ -105213122)
              }, StringSplitOptions.None);
              num2 = 10;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        Guid.TryParse(source[1], out result1);
        num1 = 7;
      }
label_6:
      return EntityObjectViewItemProvider.GetViewItem(typeByUid, new Guid?(result1), itemType, (Func<ClassMetadata, FormViewItem, ViewItem>) ((metadata, form) =>
      {
        EntityObjectViewItemProvider viewItemProvider1 = viewItemProvider;
        ClassMetadata classMetadata = metadata;
        FormViewItem formViewItem = form;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        object obj = formViewItem == null ? EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.USHjeX8G22C3fTwJ7sUr((object) new FormViewItemBuilder(EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.k6LodW8GOjKRvVYITmYE((object) metadata), viewType).DefaultContainer()) : (object) formViewItem;
        int num3 = (int) viewType;
        int num4 = (int) itemType;
        // ISSUE: reference to a compiler-generated method
        return (ViewItem) EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.XQJTA98GegNHWdwyY3xe((object) viewItemProvider1, (object) classMetadata, obj, (ViewType) num3, (ItemType) num4);
      }));
label_7:
      return EntityObjectViewItemProvider.GetViewItem(typeByUid, viewType, itemType, (Func<ClassMetadata, FormViewItem, ViewItem>) ((metadata, form) =>
      {
        EntityObjectViewItemProvider viewItemProvider2 = viewItemProvider;
        ClassMetadata classMetadata = metadata;
        FormViewItem formViewItem = form;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        object obj = formViewItem == null ? EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.USHjeX8G22C3fTwJ7sUr((object) new FormViewItemBuilder(EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.k6LodW8GOjKRvVYITmYE((object) metadata), viewType).DefaultContainer()) : (object) formViewItem;
        int num5 = (int) viewType;
        int num6 = (int) itemType;
        // ISSUE: reference to a compiler-generated method
        return (ViewItem) EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.XQJTA98GegNHWdwyY3xe((object) viewItemProvider2, (object) classMetadata, obj, (ViewType) num5, (ItemType) num6);
      }));
label_9:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return EntityObjectViewItemProvider.GetViewItem(typeByUid, new Guid?(result2), itemType, (Func<ClassMetadata, FormViewItem, ViewItem>) ((metadata, form) => (ViewItem) viewItemProvider.Transformate(metadata, (FormViewItem) ((object) form ?? EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.USHjeX8G22C3fTwJ7sUr((object) new FormViewItemBuilder(EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass8_0.k6LodW8GOjKRvVYITmYE((object) metadata), viewType).DefaultContainer())), viewType, itemType)));
label_13:
      return (ViewItem) null;
label_22:
      return (ViewItem) null;
    }

    protected static FormViewItem TransformateStatic(
      ClassMetadata metadata,
      FormViewItem formViewItem,
      ViewType viewType,
      ItemType itemType)
    {
      int num1 = 1;
      FormViewItem formViewItem1;
      while (true)
      {
        int num2 = num1;
        FormViewItemTransformation itemTransformation;
        ViewType viewType1;
        ItemType itemType1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_10;
            case 4:
              formViewItem1 = (FormViewItem) EntityObjectViewItemProvider.KP0DwwGHMH2i7hTsMhpI((object) formViewItem1, (object) itemTransformation);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 2;
              continue;
            case 5:
              List<ViewItemTransformation> items = itemTransformation.Items;
              // ISSUE: reference to a compiler-generated method
              IEnumerable<FormViewItemTransformation> source = formViewItem1.GetAllItems().OfType<DefaultContainerViewItem>().Select<DefaultContainerViewItem, FormViewItemTransformation>((Func<DefaultContainerViewItem, FormViewItemTransformation>) (d => (FormViewItemTransformation) EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass9_0.BW7DpE8GpMdEOorrJIpw((object) d, (object) formViewItem1, viewType1, itemType1, (object) null)));
              // ISSUE: reference to a compiler-generated field
              Func<FormViewItemTransformation, bool> func = EntityObjectViewItemProvider.\u003C\u003Ec.\u003C\u003E9__9_1;
              Func<FormViewItemTransformation, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityObjectViewItemProvider.\u003C\u003Ec.\u003C\u003E9__9_1 = predicate = (Func<FormViewItemTransformation, bool>) (t => t != null);
              }
              else
                goto label_15;
label_14:
              IEnumerable<FormViewItemTransformation> collection = source.Where<FormViewItemTransformation>(predicate);
              items.AddRange((IEnumerable<ViewItemTransformation>) collection);
              num2 = 6;
              continue;
label_15:
              predicate = func;
              goto label_14;
            case 6:
              if (itemTransformation.Items.Any<ViewItemTransformation>())
              {
                num2 = 4;
                continue;
              }
              goto label_10;
            case 7:
              itemTransformation = new FormViewItemTransformation();
              num2 = 5;
              continue;
            case 8:
              viewType1 = viewType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_8:
        itemType1 = itemType;
        num1 = 7;
        continue;
label_9:
        formViewItem1 = formViewItem;
        num1 = 8;
      }
label_10:
      return formViewItem1;
    }

    protected virtual FormViewItem Transformate(
      ClassMetadata metadata,
      FormViewItem formViewItem,
      ViewType viewType,
      ItemType itemType)
    {
      return (FormViewItem) EntityObjectViewItemProvider.JjLGyNGHJUc35NixMgtS((object) metadata, (object) formViewItem, viewType, itemType);
    }

    protected static FormViewItem GetFormViewItem(
      Type entityType,
      ViewType viewType,
      ItemType itemType,
      Func<ClassMetadata, FormViewItem, FormViewItem> transformate)
    {
      return (FormViewItem) EntityObjectViewItemProvider.GetViewItem(entityType, viewType, itemType, (Func<ClassMetadata, FormViewItem, ViewItem>) ((cm, fvi) => (ViewItem) transformate(cm, fvi)));
    }

    protected static ViewItem GetViewItem(
      Type entityType,
      ViewType viewType,
      ItemType itemType,
      Func<ClassMetadata, FormViewItem, ViewItem> transformate)
    {
      ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityType);
      FormViewItem formViewItem = classMetadata.FormsScheme == ClassFormsScheme.FormConstructor ? classMetadata.DefaultForms.GetForm(viewType) : (FormViewItem) null;
      if (formViewItem != null && viewType == ViewType.Display)
        formViewItem = (FormViewItem) formViewItem.CloneAsReadOnly();
      return transformate(classMetadata, formViewItem);
    }

    /// <summary>Получить элемент представления</summary>
    /// <param name="entityType"></param>
    /// <param name="formUid"></param>
    /// <param name="itemType"></param>
    /// <param name="transformate"></param>
    /// <returns></returns>
    protected static ViewItem GetViewItem(
      Type entityType,
      Guid? formUid,
      ItemType itemType,
      Func<ClassMetadata, FormViewItem, ViewItem> transformate)
    {
      ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityType);
      FormViewItem formViewItem = classMetadata.GetForms().FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (q =>
      {
        int num = 3;
        Guid? nullable;
        Guid uid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              nullable = formUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 4;
              continue;
            case 3:
              uid = q.Uid;
              num = 2;
              continue;
            case 4:
              if (nullable.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_4;
          }
        }
label_3:
        return false;
label_4:
        // ISSUE: reference to a compiler-generated method
        return EntityObjectViewItemProvider.\u003C\u003Ec__DisplayClass13_0.bNj80O8GyfUqLrt78pNx(uid, nullable.GetValueOrDefault());
      }));
      return transformate(classMetadata, formViewItem);
    }

    public static ViewItem GetViewItem(Type entityType, ViewType viewType, ItemType itemType)
    {
      int num1 = 3;
      ViewType viewType1;
      ItemType itemType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            itemType1 = itemType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            viewType1 = viewType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return EntityObjectViewItemProvider.GetViewItem(entityType, viewType1, itemType1, (Func<ClassMetadata, FormViewItem, ViewItem>) ((metadata, form) =>
      {
        int num2 = 1;
        FormViewItem viewItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              viewItem = form;
              if (viewItem == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return (ViewItem) viewItem;
label_5:
        return (ViewItem) new FormView(metadata, viewType1, itemType1);
      }));
    }

    public EntityObjectViewItemProvider()
    {
      EntityObjectViewItemProvider.wYftwRGH9kO9bMetM1xW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityObjectViewItemProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityObjectViewItemProvider.UID = new Guid((string) EntityObjectViewItemProvider.CDeXkoGHAyAPfwC4ioHx(1514961705 ^ 1514700555));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 2:
            EntityObjectViewItemProvider.wYftwRGH9kO9bMetM1xW();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool IrHMQ3GH4V1uR6xBaW3d() => EntityObjectViewItemProvider.hWOkRkGHwZ6ceSNF69w6 == null;

    internal static EntityObjectViewItemProvider CSpw9oGH6kXEMci2Awo1() => EntityObjectViewItemProvider.hWOkRkGHwZ6ceSNF69w6;

    internal static Type pvM9miGHHmkOqJEAeW04([In] object obj0) => EntityHelper.GetType(obj0);

    internal static object CDeXkoGHAyAPfwC4ioHx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Kq4bVoGH7CZrqHfBvKCN([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object u66YqCGHxAW7XwTc19s9([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (object[]) obj1);

    internal static bool YPAfXdGH0PBNxrtkB3iX([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static long rKJ0xBGHmZUCuh08DUTa([In] object obj0) => long.Parse((string) obj0);

    internal static bool NR76RcGHykxgaAdllbIa([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object KP0DwwGHMH2i7hTsMhpI([In] object obj0, [In] object obj1) => (object) ((FormViewItem) obj0).Transformate((ViewItemTransformation) obj1);

    internal static object JjLGyNGHJUc35NixMgtS(
      [In] object obj0,
      [In] object obj1,
      ViewType viewType,
      ItemType itemType)
    {
      return (object) EntityObjectViewItemProvider.TransformateStatic((ClassMetadata) obj0, (FormViewItem) obj1, viewType, itemType);
    }

    internal static void wYftwRGH9kO9bMetM1xW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
