// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.AbstractObjectFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Абстрактая реализация провайдера форм</summary>
  public abstract class AbstractObjectFormProvider : IObjectFormProvider
  {
    /// <summary>Служба управления метаданными в режиме Runtime</summary>
    protected readonly IMetadataRuntimeService MetadataRuntimeService;
    /// <summary>Дескриптор для типа "ViewModel"</summary>
    protected readonly ViewModelDescriptor ViewModelDescriptor;
    internal static AbstractObjectFormProvider ie6cdqG3jKjObZ0qF8sO;

    /// <summary>Ctor</summary>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    /// <param name="viewModelDescriptor">Дескриптор для типа "ViewModel"</param>
    protected AbstractObjectFormProvider(
      IMetadataRuntimeService metadataRuntimeService,
      ViewModelDescriptor viewModelDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ViewModelDescriptor = viewModelDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 1;
            continue;
          default:
            this.MetadataRuntimeService = metadataRuntimeService;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public abstract bool Check(Guid typeUid, Guid subTypeUid);

    /// <inheritdoc />
    public virtual (object, ClassMetadata) GetObjectInfo(
      Guid typeUid,
      Guid subTypeUid,
      string model)
    {
      Type typeByUid = this.MetadataRuntimeService.GetTypeByUid(subTypeUid);
      if (!(InterfaceActivator.LoadMetadata(typeByUid) is EntityMetadata entityMetadata1))
        return ((object) null, (ClassMetadata) null);
      DataClassMetadata viewModelMetadata = entityMetadata1.ViewModelMetadata;
      entityMetadata3 = (EntityMetadata) null;
      EntityMetadata entityMetadata2 = entityMetadata1;
      while (viewModelMetadata == null)
      {
        if (entityMetadata2.ImplementedExtensionUids != null)
        {
          foreach (Guid implementedExtensionUid in entityMetadata2.ImplementedExtensionUids)
          {
            if ((this.MetadataRuntimeService.GetMetadata(implementedExtensionUid, false) is EntityMetadata entityMetadata3 ? entityMetadata3.ViewModelMetadata : (DataClassMetadata) null) != null)
            {
              viewModelMetadata = entityMetadata3.ViewModelMetadata;
              entityMetadata1 = entityMetadata2;
              break;
            }
          }
        }
        if (!(entityMetadata2.BaseClassUid == Guid.Empty))
        {
          entityMetadata2 = (EntityMetadata) this.MetadataRuntimeService.GetMetadata(entityMetadata2.BaseClassUid);
          if (entityMetadata2.ViewModelMetadata != null)
          {
            viewModelMetadata = entityMetadata2.ViewModelMetadata;
            entityMetadata1 = entityMetadata2;
            break;
          }
        }
        else
          break;
      }
      if (viewModelMetadata == null)
        return (new EntityJsonSerializer().Deserialize(model, typeByUid, true), (ClassMetadata) entityMetadata1);
      Assembly loadedAssembly = ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97920304), false);
      string str1;
      if (string.IsNullOrWhiteSpace(entityMetadata1.ScriptModuleTypeName))
        str1 = entityMetadata1.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408819378) + entityMetadata1.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44937315);
      else
        str1 = ((IEnumerable<string>) entityMetadata1.ScriptModuleTypeName.Split(',')).First<string>().Trim();
      string str2 = str1;
      string name1 = str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345264810);
      if (loadedAssembly.GetType(name1) != (Type) null)
      {
        string str3 = entityMetadata3 != null ? entityMetadata3.Name : entityMetadata1.Name;
        string name2 = str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021392043) + str3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304429945);
        Type type = loadedAssembly.GetType(name2);
        if (type != (Type) null)
          return (this.DeserializeViewModelContext(model, viewModelMetadata, type), (ClassMetadata) viewModelMetadata);
      }
      return ((object) null, (ClassMetadata) null);
    }

    /// <inheritdoc />
    public virtual FormViewItem GetFormByType(object obj, ViewType viewType)
    {
      int num = 1;
      FormViewItem formViewItem;
      while (true)
      {
        ClassMetadata metadata;
        object obj1;
        switch (num)
        {
          case 1:
            metadata = (ClassMetadata) MetadataLoader.LoadMetadata(AbstractObjectFormProvider.H1CPZ0G3UZOCGnHKegsr(obj).GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          case 2:
            formViewItem = (FormViewItem) AbstractObjectFormProvider.rIRkJ0GpFLqTExBTUuWD((object) formViewItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 6;
            continue;
          case 3:
            if (viewType == ViewType.Display)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 2;
              continue;
            }
            goto label_8;
          case 4:
            obj1 = (object) null;
            break;
          case 5:
            formViewItem = this.Transform(metadata, formViewItem, viewType);
            num = 7;
            continue;
          case 6:
            goto label_8;
          case 7:
            if (formViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 3;
              continue;
            }
            goto label_8;
          default:
            if (AbstractObjectFormProvider.aMEdLhG3sAty7CfWd5rE((object) metadata) != ClassFormsScheme.FormConstructor)
            {
              num = 4;
              continue;
            }
            obj1 = AbstractObjectFormProvider.KQRnwwG3zAdAkqjo3YfF(AbstractObjectFormProvider.qg6YnjG3crqYOKsuSRrt((object) metadata), viewType);
            break;
        }
        formViewItem = (FormViewItem) obj1;
        num = 5;
      }
label_8:
      return formViewItem;
    }

    /// <inheritdoc />
    public virtual FormViewItem GetFormByUid(object obj, Guid formUid)
    {
      int num = 6;
      ClassMetadata metadata;
      FormViewItem formViewItem;
      Guid formUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            // ISSUE: reference to a compiler-generated method
            formViewItem = metadata.GetForms().FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (q => AbstractObjectFormProvider.\u003C\u003Ec__DisplayClass6_0.HXdCAT8FJIgcrWw1jE3k((object) q) == formUid1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            metadata = (ClassMetadata) MetadataLoader.LoadMetadata(AbstractObjectFormProvider.H1CPZ0G3UZOCGnHKegsr(obj).GetType());
            num = 2;
            continue;
          case 5:
            formUid1 = formUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 6:
            num = 5;
            continue;
          default:
            if (!(formUid1 == Guid.Empty))
            {
              num = 4;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return (FormViewItem) null;
label_9:
      return this.Transform(metadata, formViewItem);
    }

    /// <inheritdoc />
    public virtual void InitObject(
      object obj,
      ViewType viewType,
      IDictionary<string, object> arguments)
    {
    }

    /// <summary>Применить трансформацию к форме</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="formViewItem">Форма</param>
    /// <param name="viewType">Тип формы</param>
    /// <param name="itemType">Тип элемента</param>
    /// <returns>Преобразованная форма</returns>
    protected virtual FormViewItem Transform(
      ClassMetadata metadata,
      FormViewItem formViewItem,
      ViewType viewType = ViewType.Custom,
      ItemType itemType = ItemType.Default)
    {
      int num = 8;
      FormViewItemTransformation itemTransformation;
      FormViewItem formViewItem1;
      ViewType viewType1;
      ItemType itemType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            itemTransformation.Items.AddRange((IEnumerable<ViewItemTransformation>) formViewItem1.GetAllItems().OfType<DefaultContainerViewItem>().Select<DefaultContainerViewItem, FormViewItemTransformation>((Func<DefaultContainerViewItem, FormViewItemTransformation>) (d => (FormViewItemTransformation) AbstractObjectFormProvider.\u003C\u003Ec__DisplayClass8_0.LvkDGn8Fg5yMFq3qrYQR((object) d, (object) formViewItem1, viewType1, itemType1, (object) null))).Where<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (t => t != null)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 9 : 9;
            continue;
          case 2:
            formViewItem1 = (FormViewItem) AbstractObjectFormProvider.nqyxQuGpWPOuxZ8ZRC0V((object) formViewItem1, (object) itemTransformation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
            continue;
          case 4:
            viewType1 = viewType;
            num = 5;
            continue;
          case 5:
            itemType1 = itemType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 6 : 6;
            continue;
          case 6:
            itemTransformation = new FormViewItemTransformation();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          case 7:
            formViewItem1 = formViewItem;
            num = 4;
            continue;
          case 8:
            num = 7;
            continue;
          case 9:
            if (AbstractObjectFormProvider.JQ3ItQGpBHsik39oJFpp((object) itemTransformation.Items) == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          default:
            goto label_9;
        }
      }
label_9:
      return formViewItem1;
    }

    private object DeserializeViewModelContext(
      string model,
      DataClassMetadata viewModelContextMetadata,
      Type viewModelContextType)
    {
      int num = 5;
      ExpandoObject expandoObject;
      Dictionary<string, object> values;
      ClassMetadata metadata;
      PropertyMetadata propertyMetadata1;
      IActionExecutionParamModel instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ViewModelDescriptor.Deserialize((object) instance, metadata, propertyMetadata1, (IDictionary<string, object>) values);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 2;
            continue;
          case 2:
            goto label_8;
          case 3:
            PropertyMetadata propertyMetadata2 = new PropertyMetadata();
            AbstractObjectFormProvider.QmbFbSGph77R7AiRXKdX((object) propertyMetadata2, AbstractObjectFormProvider.YduP8CGpbq8lIl1gxKne(-1638402543 ^ -1638576285));
            AbstractObjectFormProvider.S0HatyGpEAFRMOaYWAqe((object) propertyMetadata2, AbstractObjectFormProvider.Nnt3XvGpGQBIgoSLw62J((object) this.ViewModelDescriptor));
            AbstractObjectFormProvider.ixNdXaGpfd8Fh7dHj2yt((object) propertyMetadata2, viewModelContextMetadata.Uid);
            DataClassSettings dataClassSettings = new DataClassSettings();
            AbstractObjectFormProvider.rUVHyQGpQUS1SMp2Qen1((object) dataClassSettings, RelationType.OneToOne);
            AbstractObjectFormProvider.EJswTQGpC5ubKn7iGqbb((object) propertyMetadata2, (object) dataClassSettings);
            propertyMetadata1 = propertyMetadata2;
            num = 6;
            continue;
          case 4:
            metadata = new ClassMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 3 : 1;
            continue;
          case 5:
            // ISSUE: type reference
            instance = (IActionExecutionParamModel) Activator.CreateInstance(AbstractObjectFormProvider.I7dJIKGpo4KwclwghmKr(__typeref (ActionExecutionParamModel<>)).MakeGenericType(viewModelContextType));
            num = 4;
            continue;
          case 6:
            expandoObject = new JsonSerializer().Deserialize<ExpandoObject>(model);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            values = new Dictionary<string, object>()
            {
              {
                (string) AbstractObjectFormProvider.YduP8CGpbq8lIl1gxKne(1669371371 ^ 1669475481),
                (object) expandoObject
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
        }
      }
label_8:
      return AbstractObjectFormProvider.COHcWZGpvb3j6AAer0Is((object) instance);
    }

    internal static bool c69OKMG3YQVQtubCckpW() => AbstractObjectFormProvider.ie6cdqG3jKjObZ0qF8sO == null;

    internal static AbstractObjectFormProvider XgsM5BG3LKMpCXwHsGnY() => AbstractObjectFormProvider.ie6cdqG3jKjObZ0qF8sO;

    internal static object H1CPZ0G3UZOCGnHKegsr([In] object obj0) => obj0.CastAsRealType();

    internal static ClassFormsScheme aMEdLhG3sAty7CfWd5rE([In] object obj0) => ((ClassMetadata) obj0).FormsScheme;

    internal static object qg6YnjG3crqYOKsuSRrt([In] object obj0) => (object) ((ClassMetadata) obj0).DefaultForms;

    internal static object KQRnwwG3zAdAkqjo3YfF([In] object obj0, ViewType viewType) => (object) ((ClassDefaultForms) obj0).GetForm(viewType);

    internal static object rIRkJ0GpFLqTExBTUuWD([In] object obj0) => (object) ((FormView) obj0).CloneAsReadOnly();

    internal static int JQ3ItQGpBHsik39oJFpp([In] object obj0) => ((List<ViewItemTransformation>) obj0).Count;

    internal static object nqyxQuGpWPOuxZ8ZRC0V([In] object obj0, [In] object obj1) => (object) ((FormViewItem) obj0).Transformate((ViewItemTransformation) obj1);

    internal static Type I7dJIKGpo4KwclwghmKr([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object YduP8CGpbq8lIl1gxKne(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void QmbFbSGph77R7AiRXKdX([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static Guid Nnt3XvGpGQBIgoSLw62J([In] object obj0) => ((TypeDescriptor) obj0).Uid;

    internal static void S0HatyGpEAFRMOaYWAqe([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void ixNdXaGpfd8Fh7dHj2yt([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static void rUVHyQGpQUS1SMp2Qen1([In] object obj0, RelationType value) => ((DataClassSettings) obj0).RelationType = value;

    internal static void EJswTQGpC5ubKn7iGqbb([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static object COHcWZGpvb3j6AAer0Is([In] object obj0) => ((IActionExecutionParamModel) obj0).Parameter;
  }
}
