// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.FormRenderHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Хелпер для отрисовки форм</summary>
  public static class FormRenderHelper
  {
    private static FormRenderHelper RC4mlOh5YDqi7neklwyW;

    /// <summary>
    /// Можно ли отрендерить форму с помощью конструктора интерфейсов
    /// </summary>
    /// <param name="viewType">Тип формы</param>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <returns><c>True</c>, если форму можно отрендерить с помощью конструктора интерфейсов</returns>
    public static bool CanRenderRuntimeVersion2<T>(ViewType viewType) => FormRenderHelper.CanRenderRuntimeVersion2(typeof (T), viewType);

    /// <summary>
    /// Можно ли отрендерить форму с помощью конструктора интерфейсов
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="viewType">Тип формы</param>
    /// <returns><c>True</c>, если форму можно отрендерить с помощью конструктора интерфейсов</returns>
    public static bool CanRenderRuntimeVersion2(Type type, ViewType viewType)
    {
      int num = 7;
      EntityMetadata entityMetadata;
      IMetadataRuntimeService serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!FormRenderHelper.SajIdxh5sAO7icULfKwD((object) entityMetadata))
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 2:
            goto label_8;
          case 3:
            if (entityMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 1;
              continue;
            }
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_11;
          case 5:
            entityMetadata = MetadataLoader.LoadMetadata(FormRenderHelper.RIunkrh5cHq1Y42CtJ7H((object) entityMetadata), loadImplementation: false) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 2;
            continue;
          case 6:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          case 7:
            entityMetadata = MetadataLoader.LoadMetadata(type, loadImplementation: false) as EntityMetadata;
            num = 6;
            continue;
          default:
            goto label_13;
        }
      }
label_8:
      return false;
label_11:
      return false;
label_13:
      return FormRenderHelper.qKnISUh5zlhR8bKmvBlH((object) entityMetadata, viewType, (object) serviceNotNull);
    }

    /// <summary>Получить уникальный идентификатор формы</summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="viewType">Тип представления</param>
    /// <returns>Уникальный идентификатор формы</returns>
    public static Guid GetFormUid(Type type, ViewType viewType)
    {
      int num1 = 3;
      IMetadataRuntimeService serviceNotNull;
      EntityMetadata entityMetadata;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              if (entityMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 3:
              entityMetadata = MetadataLoader.LoadMetadata(type, loadImplementation: false) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 2;
              continue;
            case 4:
              serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
              continue;
            case 5:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_7:
        if (entityMetadata != null)
          num1 = 4;
        else
          break;
      }
label_3:
      return Guid.Empty;
label_6:
      return Guid.Empty;
label_9:
      return FormRenderHelper.XcLN5QhjFg3P2dSc0yh6((object) entityMetadata, viewType, (object) serviceNotNull);
    }

    /// <summary>
    /// Можно ли отрендерить форму с помощью конструктора интерфейсов
    /// </summary>
    /// <param name="formViewItem">Форма</param>
    /// <returns><c>True</c>, если форму можно отрендерить с помощью конструктора интерфейсов</returns>
    public static bool CanRenderRuntimeVersion2(FormViewItem formViewItem) => FormRenderHelper.gwjLMFhjBdBQs10rs5qQ((object) formViewItem) == RuntimeVersion.Version2;

    /// <summary>
    /// Можно ли отрендерить форму с помощью конструктора интерфейсов
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    /// <returns><c>True</c>, если форму можно отрендерить с помощью конструктора интерфейсов</returns>
    public static bool CanRenderRuntimeVersion2(IEntity<long> entity, Guid formUid)
    {
      IFormRenderExtension formRenderExtension = Locator.GetServiceNotNull<IEnumerable<IFormRenderExtension>>().FirstOrDefault<IFormRenderExtension>((Func<IFormRenderExtension, bool>) (ext => ext.Check(entity)));
      return formRenderExtension != null && formRenderExtension.CanRenderRuntimeVersion2(entity, formUid);
    }

    private static Guid GetFormUid(
      object entityMetadata,
      ViewType viewType,
      object metadataRuntimeService)
    {
      int num = 4;
      EntityMetadata entityMetadata1;
      Guid formUid;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            formUid = FormRenderHelper.hDoN9DhjoOy5iwTrmOHJ(FormRenderHelper.kVvkj8hjWbhGmTCKnm6F((object) entityMetadata1), viewType);
            num = 9;
            continue;
          case 3:
            entityMetadata1 = (EntityMetadata) entityMetadata;
            num = 6;
            continue;
          case 4:
            formUid = Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 2;
            continue;
          case 5:
            entityMetadata1 = ((IMetadataService) metadataRuntimeService).GetMetadata(FormRenderHelper.QG4TUPhjbgcW3XYurecX((object) entityMetadata1)) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 11;
            continue;
          case 6:
          case 7:
            if (FormRenderHelper.FyypYBhjhrLbK4VijqrY(formUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 9:
            if (FormRenderHelper.FyypYBhjhrLbK4VijqrY(FormRenderHelper.QG4TUPhjbgcW3XYurecX((object) entityMetadata1), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 8 : 0;
              continue;
            }
            goto case 5;
          case 11:
            if (entityMetadata1 == null)
            {
              num = 10;
              continue;
            }
            goto case 6;
          default:
            goto label_7;
        }
      }
label_7:
      return formUid;
    }

    private static bool CanRender(
      object entityMetadata,
      ViewType viewType,
      object metadataRuntimeService)
    {
      int num1 = 13;
      FormViewItem formViewItem1;
      FormViewItem formViewItem2;
      IMetadataRuntimeService metadataRuntimeService1;
      while (true)
      {
        int num2 = num1;
        FormViewItemTransformation itemTransformation1;
        EntityMetadata entityMetadata1;
        FormViewItemTransformation itemTransformation2;
        EntityMetadata entityMetadata2;
        Guid formUid;
        Guid extensionFormUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              entityMetadata2 = (EntityMetadata) entityMetadata;
              num2 = 4;
              continue;
            case 2:
              if (entityMetadata1 != null)
              {
                num2 = 39;
                continue;
              }
              goto case 6;
            case 3:
              if (itemTransformation2 == null)
              {
                num2 = 6;
                continue;
              }
              goto case 8;
            case 4:
            case 11:
              if (!(formUid == Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 9 : 6;
                continue;
              }
              goto case 26;
            case 5:
              if (itemTransformation1 == null)
              {
                num2 = 15;
                continue;
              }
              goto case 27;
            case 6:
            case 22:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              formViewItem2 = Locator.GetServiceNotNull<IEntityFormsService>().GetAllForms((ClassMetadata) entityMetadata).FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (form => FormRenderHelper.\u003C\u003Ec__DisplayClass6_0.UeZGFHv0xiKc0W9qWSbi(FormRenderHelper.\u003C\u003Ec__DisplayClass6_0.qalKZXv07qK4yvVrlCyD((object) form), formUid)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 14 : 2;
              continue;
            case 7:
              extensionFormUid = formUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 13 : 34;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!itemTransformation2.Items.OfType<ViewItemTransformationChange>().Any<ViewItemTransformationChange>((Func<ViewItemTransformationChange, bool>) (transformationChange => FormRenderHelper.\u003C\u003Ec.xjRbHGv0YI0EloZhQx64(FormRenderHelper.\u003C\u003Ec.Mdp2mhv05pqlucZYcTuP((object) transformationChange), FormRenderHelper.\u003C\u003Ec.GIUH52v0jC2OgmCitrvs(-675505729 ^ -675395903)))))
                goto case 6;
              else
                goto label_53;
            case 10:
              if (!FormRenderHelper.HcBDilhjEh1SvvKlcrpl(extensionFormUid, Guid.Empty))
              {
                num2 = 7;
                continue;
              }
              goto case 38;
            case 12:
              metadataRuntimeService1 = (IMetadataRuntimeService) metadataRuntimeService;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 37 : 23;
              continue;
            case 13:
              num2 = 12;
              continue;
            case 14:
              if (formViewItem2 == null)
              {
                // ISSUE: reference to a compiler-generated method
                itemTransformation1 = ((ClassMetadata) entityMetadata).FormTransformations.Find((Predicate<FormViewItemTransformation>) (transformation => FormRenderHelper.\u003C\u003Ec__DisplayClass6_0.UeZGFHv0xiKc0W9qWSbi(transformation.Uid, formUid)));
                num2 = 5;
                continue;
              }
              num2 = 23;
              continue;
            case 15:
            case 19:
              if (!FormRenderHelper.HcBDilhjEh1SvvKlcrpl(FormRenderHelper.QG4TUPhjbgcW3XYurecX(entityMetadata), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 7 : 16;
                continue;
              }
              goto case 41;
            case 16:
            case 25:
              goto label_19;
            case 17:
            case 34:
              itemTransformation2 = entityMetadata1.FormTransformations.Find((Predicate<FormViewItemTransformation>) (transformation => transformation.Uid == extensionFormUid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 0;
              continue;
            case 18:
              extensionFormUid = entityMetadata1.DefaultForms.GetFormUid(viewType);
              num2 = 10;
              continue;
            case 20:
              goto label_40;
            case 21:
              goto label_45;
            case 23:
              goto label_12;
            case 24:
              if (entityMetadata2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 26:
              formUid = FormRenderHelper.hDoN9DhjoOy5iwTrmOHJ(FormRenderHelper.kVvkj8hjWbhGmTCKnm6F((object) entityMetadata2), viewType);
              num2 = 35;
              continue;
            case 27:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!itemTransformation1.Items.OfType<ViewItemTransformationChange>().Any<ViewItemTransformationChange>((Func<ViewItemTransformationChange, bool>) (transformationChange => FormRenderHelper.\u003C\u003Ec.xjRbHGv0YI0EloZhQx64(FormRenderHelper.\u003C\u003Ec.Mdp2mhv05pqlucZYcTuP((object) transformationChange), FormRenderHelper.\u003C\u003Ec.GIUH52v0jC2OgmCitrvs(1597012150 ^ 1597155272)))))
              {
                num2 = 19;
                continue;
              }
              goto label_40;
            case 28:
              entityMetadata2 = metadataRuntimeService1.GetMetadata(entityMetadata2.BaseClassUid, false) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 20 : 24;
              continue;
            case 29:
              if (!FormRenderHelper.fPimr4hjGacMbNDY9oMc(entityMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 22 : 9;
                continue;
              }
              goto label_49;
            case 30:
              goto label_3;
            case 31:
              goto label_14;
            case 32:
              goto label_49;
            case 33:
              goto label_18;
            case 35:
              if (FormRenderHelper.QG4TUPhjbgcW3XYurecX((object) entityMetadata2) == Guid.Empty)
              {
                num2 = 40;
                continue;
              }
              goto case 28;
            case 36:
              if (formViewItem1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 7 : 17;
                continue;
              }
              goto label_45;
            case 37:
              formUid = Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            case 38:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              formViewItem1 = entityMetadata1.Forms.Find((Predicate<FormViewItem>) (form => FormRenderHelper.\u003C\u003Ec__DisplayClass6_1.rkAcAFv09DlGwLMZt1GL(FormRenderHelper.\u003C\u003Ec__DisplayClass6_1.fV581vv0JYoxucDK5UFP((object) form), extensionFormUid)));
              num2 = 36;
              continue;
            case 39:
              num2 = 18;
              continue;
            case 41:
              if (!(metadataRuntimeService1.GetMetadata(FormRenderHelper.QG4TUPhjbgcW3XYurecX(entityMetadata), false) is EntityMetadata metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 13 : 25;
                continue;
              }
              goto label_18;
            default:
              if (!FormRenderHelper.FyypYBhjhrLbK4VijqrY(formUid, Guid.Empty))
              {
                num2 = 29;
                continue;
              }
              goto label_3;
          }
        }
label_49:
        IEnumerable<Guid> source = ((EntityMetadata) metadataRuntimeService1.GetMetadata(((EntityMetadata) entityMetadata).ImplementationUid)).ImplementedExtensionUids.EmptyIfNull<Guid>();
        // ISSUE: reference to a compiler-generated field
        Func<Guid, bool> func = FormRenderHelper.\u003C\u003Ec.\u003C\u003E9__6_2;
        Func<Guid, bool> predicate;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          FormRenderHelper.\u003C\u003Ec.\u003C\u003E9__6_2 = predicate = (Func<Guid, bool>) (uid => uid.IsConfigMetadata());
        }
        else
          goto label_56;
label_51:
        entityMetadata1 = source.Where<Guid>(predicate).Select<Guid, EntityMetadata>((Func<Guid, EntityMetadata>) (uid => (EntityMetadata) metadataRuntimeService1.GetMetadata(uid, false))).FirstOrDefault<EntityMetadata>();
        num1 = 2;
        continue;
label_56:
        predicate = func;
        goto label_51;
label_53:
        num1 = 31;
      }
label_3:
      return false;
label_12:
      return FormRenderHelper.A5nQWchjfu0t5NyLHvc6((object) formViewItem2);
label_14:
      return true;
label_18:
      return FormRenderHelper.qKnISUh5zlhR8bKmvBlH((object) metadata, viewType, (object) metadataRuntimeService1);
label_19:
      return false;
label_40:
      return true;
label_45:
      return FormRenderHelper.A5nQWchjfu0t5NyLHvc6((object) formViewItem1);
    }

    internal static bool SajIdxh5sAO7icULfKwD([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static Guid RIunkrh5cHq1Y42CtJ7H([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static bool qKnISUh5zlhR8bKmvBlH([In] object obj0, ViewType viewType, [In] object obj2) => FormRenderHelper.CanRender(obj0, viewType, obj2);

    internal static bool XBYSesh5LmortkB49DIt() => FormRenderHelper.RC4mlOh5YDqi7neklwyW == null;

    internal static FormRenderHelper c04Wh4h5UTKNkq9ix5lM() => FormRenderHelper.RC4mlOh5YDqi7neklwyW;

    internal static Guid XcLN5QhjFg3P2dSc0yh6([In] object obj0, ViewType viewType, [In] object obj2) => FormRenderHelper.GetFormUid(obj0, viewType, obj2);

    internal static RuntimeVersion gwjLMFhjBdBQs10rs5qQ([In] object obj0) => ((FormViewItem) obj0).RuntimeVersion;

    internal static object kVvkj8hjWbhGmTCKnm6F([In] object obj0) => (object) ((ClassMetadata) obj0).DefaultForms;

    internal static Guid hDoN9DhjoOy5iwTrmOHJ([In] object obj0, ViewType viewType) => ((ClassDefaultForms) obj0).GetFormUid(viewType);

    internal static Guid QG4TUPhjbgcW3XYurecX([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool FyypYBhjhrLbK4VijqrY([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool fPimr4hjGacMbNDY9oMc([In] object obj0) => ((IMetadata) obj0).IsSystem();

    internal static bool HcBDilhjEh1SvvKlcrpl([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool A5nQWchjfu0t5NyLHvc6([In] object obj0) => FormRenderHelper.CanRenderRuntimeVersion2((FormViewItem) obj0);
  }
}
