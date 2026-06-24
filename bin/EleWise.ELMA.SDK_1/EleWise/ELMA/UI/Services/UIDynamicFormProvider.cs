// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.UIDynamicFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  [Component]
  public abstract class UIDynamicFormProvider : IDynamicFormsProvider
  {
    public const string ResultDataItemName = "UIFormResult";
    internal static UIDynamicFormProvider vRUklecPRvACKAwUYiK;

    /// <summary>Фабрика для создания контекста выполнения</summary>
    public IExecutionScopeFactory ExecutionScopeFactory
    {
      get => this.\u003CExecutionScopeFactory\u003Ek__BackingField;
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
              this.\u003CExecutionScopeFactory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    public abstract Guid Uid { get; }

    public Type GetEntityType(DynamicFormSettings settings)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            this.ParseViewItemParams((string) UIDynamicFormProvider.e0bMq2c3QWcf6IoD8Ek((object) settings));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 3:
            if (settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (Type) null;
label_5:
      return (Type) null;
    }

    public void ExecuteScript(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string scriptName,
      DynamicFormResultData resultData)
    {
      int num1 = 34;
      while (true)
      {
        int num2 = num1;
        object obj1;
        Type type;
        object controllerInstance;
        List<object> parameterValues;
        while (true)
        {
          FormDescriptor descriptor;
          ITablePartItem source;
          UIViewItemParams viewItemParams;
          IExecutionScope executionScope;
          object obj2;
          IEntity entity1;
          ParameterInfo[] parameters;
          int index;
          ParameterInfo parameterInfo;
          ITablePartItem tablePartItem;
          string str1;
          string str2;
          MethodInfo method;
          switch (num2)
          {
            case 1:
            case 3:
              parameterValues.Add((object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 31 : 11;
              continue;
            case 2:
            case 13:
              if (tablePartItem == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto case 54;
            case 4:
              source = entity as ITablePartItem;
              num2 = 52;
              continue;
            case 5:
              controllerInstance = (object) null;
              num2 = 30;
              continue;
            case 6:
              obj2 = UIDynamicFormProvider.FjNjeBcrsQSBvfkUH84((object) this, obj1);
              num2 = 23;
              continue;
            case 8:
              goto label_30;
            case 9:
            case 41:
              parameters = method.GetParameters();
              num2 = 42;
              continue;
            case 10:
              if (scriptName != null)
              {
                num2 = 21;
                continue;
              }
              goto label_42;
            case 11:
              if (!UIDynamicFormProvider.iOCtdIcmagOKiCuDCaX((object) parameterInfo).IsAssignableFrom(entity.GetType()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
                continue;
              }
              goto label_35;
            case 12:
            case 14:
              if (index >= parameters.Length)
              {
                num2 = 44;
                continue;
              }
              goto case 48;
            case 15:
              goto label_78;
            case 16:
              if (entity is ITablePartItem)
              {
                num2 = 11;
                continue;
              }
              goto case 1;
            case 17:
              goto label_28;
            case 18:
              resultData.Data[(string) UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(1470998129 - 231418599 ^ 1239589304)] = obj2;
              num2 = 55;
              continue;
            case 19:
              source = source.CastAsRealType<ITablePartItem>();
              num2 = 26;
              continue;
            case 20:
              goto label_25;
            case 21:
              viewItemParams = (UIViewItemParams) UIDynamicFormProvider.OkCbNUcp6cPZj5ICehw((object) this, UIDynamicFormProvider.e0bMq2c3QWcf6IoD8Ek((object) settings));
              num2 = 57;
              continue;
            case 22:
              goto label_51;
            case 23:
              if (obj2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 18 : 14;
                continue;
              }
              goto label_72;
            case 24:
            case 50:
              if (entity1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 40 : 33;
                continue;
              }
              goto case 46;
            case 25:
              UIDynamicFormProvider.hkWnbncAG6hTMgOe4Fr(UIDynamicFormProvider.EVlHcDcHXfEPCXyNDWe(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765809076));
              num2 = 27;
              continue;
            case 26:
              obj1 = UIDynamicFormProvider.cxNELycywqaOVYyTNcm((object) this, UIDynamicFormProvider.iOCtdIcmagOKiCuDCaX(UIDynamicFormProvider.YyuxoMc0tCd2sc6fQdZ((object) method)[0]), (object) descriptor, (object) source, (object) view, (object) viewItemParams);
              num2 = 22;
              continue;
            case 27:
              goto label_24;
            case 28:
              goto label_40;
            case 29:
              obj1 = this.CreateViewModelType(UIDynamicFormProvider.iOCtdIcmagOKiCuDCaX((object) method.GetParameters()[0]), descriptor, entity1, view, viewItemParams);
              num2 = 47;
              continue;
            case 30:
              if (!UIDynamicFormProvider.npdZZxcDfKfhjZpj1c1(descriptor.ControllerType, (Type) null))
                goto case 56;
              else
                goto label_69;
            case 31:
            case 35:
              ++index;
              num2 = 14;
              continue;
            case 32:
              UIDynamicFormProvider.sB2UEXclbX4Tx2qtkeT((object) (System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      UIDynamicFormProvider.\u003C\u003Ec__DisplayClass8_0.FOKexDfsBnjVSTTocONZ((object) method, controllerInstance, UIDynamicFormProvider.\u003C\u003Ec__DisplayClass8_0.pXnGMLfsFmlhipxamZMr((object) parameterValues));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }), (object) str1);
              num2 = 6;
              continue;
            case 33:
              if (settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 24 : 28;
                continue;
              }
              goto case 10;
            case 34:
              num2 = 33;
              continue;
            case 36:
              try
              {
                controllerInstance = UIDynamicFormProvider.Bqi2onc4BYhb3sgDHjx((object) executionScope, UIDynamicFormProvider.mOyyyXcw2gBsSN5tgrH((object) descriptor));
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_3;
                }
              }
              finally
              {
                if (executionScope != null)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        UIDynamicFormProvider.Bg8yXyc6CSrEunVaI7K((object) executionScope);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_18;
                    }
                  }
                }
label_18:;
              }
            case 37:
              goto label_35;
            case 38:
              method = this.GetMethodInfo(type, scriptName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 13 : 43;
              continue;
            case 39:
              goto label_63;
            case 40:
              goto label_32;
            case 42:
              index = UIDynamicFormProvider.e8UXlGcM36MoUw0J72c((object) parameterValues);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 12;
              continue;
            case 43:
              if (!UIDynamicFormProvider.wwOwqWc7bMbrPycMFAB((object) method, (object) null))
              {
                if (source == null)
                {
                  num2 = 24;
                  continue;
                }
                goto case 19;
              }
              else
              {
                num2 = 17;
                continue;
              }
            case 44:
              if (!(UIDynamicFormProvider.NCHXWOcJUmRysbIdAJb((object) descriptor) is PageMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 43 : 45;
                continue;
              }
              str2 = EleWise.ELMA.SR.T((string) UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(-342626196 - 1290888215 ^ -1633531985), UIDynamicFormProvider.pbp0UpcdbwZUqmGRd70(UIDynamicFormProvider.NCHXWOcJUmRysbIdAJb((object) descriptor)));
              break;
            case 45:
              str2 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813581829), (object) descriptor.Metadata.Name);
              break;
            case 46:
              entity1 = entity1.CastAsRealType<IEntity>();
              num2 = 29;
              continue;
            case 47:
              parameterValues.Add(obj1);
              num2 = 41;
              continue;
            case 48:
              parameterInfo = parameters[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 9 : 16;
              continue;
            case 49:
              tablePartItem = tablePartItem.Parent as ITablePartItem;
              num2 = 13;
              continue;
            case 51:
              tablePartItem = source;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 1;
              continue;
            case 52:
              if (source != null)
                goto case 51;
              else
                goto label_39;
            case 53:
              executionScope = ((IExecutionScopeBuilder) UIDynamicFormProvider.HhVmwLctABQDbhhNBOa((object) this.ExecutionScopeFactory)).AddRegistration(UIDynamicFormProvider.mOyyyXcw2gBsSN5tgrH((object) descriptor), Array.Empty<Type>()).StartScope();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 13 : 36;
              continue;
            case 54:
              entity1 = tablePartItem.Parent;
              num2 = 49;
              continue;
            case 55:
              goto label_19;
            case 56:
label_3:
              if (controllerInstance == null)
              {
                num2 = 25;
                continue;
              }
              entity1 = entity;
              num2 = 4;
              continue;
            case 57:
              descriptor = (FormDescriptor) UIDynamicFormProvider.LHIKPecaAn5GHgJmjNP((object) viewItemParams);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 5;
              continue;
            default:
              parameterValues = new List<object>();
              num2 = 39;
              continue;
          }
          str1 = str2;
          num2 = 32;
        }
label_28:
        UIDynamicFormProvider.CpHmAIcx5R2YJ4cbDMX(type, (object) scriptName);
        num1 = 15;
        continue;
label_35:
        parameterValues.Add((object) null);
        num1 = 35;
        continue;
label_39:
        num1 = 7;
        continue;
label_51:
        parameterValues.Add(obj1);
        num1 = 9;
        continue;
label_63:
        type = controllerInstance.GetType();
        num1 = 38;
        continue;
label_69:
        num1 = 53;
      }
label_30:
      return;
label_78:
      return;
label_25:
      return;
label_24:
      return;
label_40:
      return;
label_32:
      return;
label_19:
      return;
label_72:
      return;
label_42:;
    }

    public string GetPropertyValueChangeScriptName(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string propertyName)
    {
      int num1 = 10;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        int num2 = num1;
        FormDescriptor formDescriptor;
        FormPartMetadata partMetadata;
        while (true)
        {
          Type typeByUid;
          EntityMetadata entityMetadata;
          string propertyName1;
          switch (num2)
          {
            case 1:
              if (partMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 5 : 4;
                continue;
              }
              goto label_12;
            case 2:
              goto label_18;
            case 3:
              goto label_15;
            case 4:
              if (formDescriptor == null)
              {
                num2 = 11;
                continue;
              }
              goto case 1;
            case 5:
              typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(UIDynamicFormProvider.YnSAsYc5dviIf3WtT3A(UIDynamicFormProvider.MQ2OcGcgxUoCfs4atGP((object) partMetadata)));
              num2 = 14;
              continue;
            case 6:
              entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeByUid);
              break;
            case 7:
              entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(entity.GetType());
              break;
            case 8:
              if (propertyMetadata == null)
              {
                num2 = 3;
                continue;
              }
              goto label_16;
            case 9:
              propertyName1 = propertyName;
              num2 = 13;
              continue;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 9 : 0;
              continue;
            case 11:
            case 12:
              goto label_12;
            case 13:
              if (settings != null)
              {
                num2 = 2;
                continue;
              }
              goto label_17;
            case 14:
              if (entity != null)
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            default:
              goto label_17;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => UIDynamicFormProvider.\u003C\u003Ec__DisplayClass9_0.MmT8WBfsGHBK9qOL083f(UIDynamicFormProvider.\u003C\u003Ec__DisplayClass9_0.zq7ANGfshcBEx0AvueMe((object) p), (object) propertyName1)));
          num2 = 8;
        }
label_18:
        UIViewItemParams viewItemParams = this.ParseViewItemParams((string) UIDynamicFormProvider.e0bMq2c3QWcf6IoD8Ek((object) settings));
        formDescriptor = (FormDescriptor) UIDynamicFormProvider.LHIKPecaAn5GHgJmjNP((object) viewItemParams);
        partMetadata = viewItemParams.PartMetadata;
        num1 = 4;
      }
label_12:
      return (string) null;
label_15:
      return (string) null;
label_16:
      return (string) UIDynamicFormProvider.zLMc5ecjmVc4rkyi31k((object) propertyMetadata);
label_17:
      return (string) null;
    }

    protected virtual UIViewItemParams ParseViewItemParams(string dynamicFormsProviderData) => new UIViewItemParams(dynamicFormsProviderData);

    protected abstract Type GetItemViewModelType(Type itemType, FormDescriptor descriptor);

    protected abstract Type GetViewModelType(Type entityType, FormDescriptor descriptor);

    protected abstract object CreateItemViewModelType(
      Type itemViewModelType,
      FormDescriptor descriptor,
      IEntity entity,
      RootViewItem view,
      UIViewItemParams viewItemParams);

    protected abstract object CreateViewModelType(
      Type viewModelType,
      FormDescriptor descriptor,
      IEntity entity,
      RootViewItem view,
      UIViewItemParams viewItemParams);

    protected abstract object GetResult(object viewModel);

    private MethodInfo GetMethodInfo(Type type, string scriptName)
    {
      int num1 = 8;
      string name;
      MethodInfo methodInfo1;
      List<MethodInfo>.Enumerator enumerator;
      while (true)
      {
        MethodInfo methodInfo2;
        string scriptName1;
        string scriptShortName;
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            enumerator = ((IEnumerable<MethodInfo>) type.GetMethods()).Where<MethodInfo>((Func<MethodInfo, bool>) (q => UIDynamicFormProvider.\u003C\u003Ec__DisplayClass16_1.U7QRATfsRE0N8SBhR2iB(UIDynamicFormProvider.\u003C\u003Ec__DisplayClass16_1.yNPRVkfsi9NCV69RmStD((object) q), (object) scriptShortName))).ToList<MethodInfo>().GetEnumerator();
            num1 = 3;
            continue;
          case 2:
          case 4:
            goto label_9;
          case 3:
            goto label_13;
          case 5:
            scriptShortName = (string) UIDynamicFormProvider.TN1snJcUTEuyokAs9P1((object) name, 0, UIDynamicFormProvider.YuIscgcLWoJICvwJQjc((object) name, '('));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
          case 6:
            methodInfo1 = (MethodInfo) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 10 : 10;
            continue;
          case 7:
            scriptName1 = scriptName;
            num1 = 6;
            continue;
          case 8:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 2;
            continue;
          case 9:
            if (!name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870893695)))
            {
              num1 = 12;
              continue;
            }
            goto default;
          case 10:
            name = ((IEnumerable<string>) UIDynamicFormProvider.lqtKqOcYJhw6n174wGS((object) scriptName1, (object) new string[1]
            {
              (string) UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(-1876063057 ^ -1876078839)
            }, StringSplitOptions.None)).First<string>();
            num1 = 9;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            methodInfo2 = ((IEnumerable<MethodInfo>) type.GetMethods()).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (a => UIDynamicFormProvider.\u003C\u003Ec__DisplayClass16_0.vJ6oFXfsZAVUnbLw43yd((object) ((string) UIDynamicFormProvider.\u003C\u003Ec__DisplayClass16_0.FgYdX4fsvEshmNJhUBmp((object) a)).ToLower(), UIDynamicFormProvider.\u003C\u003Ec__DisplayClass16_0.rVZINLfs8mEbsXFgclQ6((object) scriptName1))));
            break;
          case 12:
            MethodInfo method = type.GetMethod(name);
            if ((object) method == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 11;
              continue;
            }
            methodInfo2 = method;
            break;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 2;
            continue;
        }
        methodInfo1 = methodInfo2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
      }
label_9:
      return methodInfo1;
label_13:
      try
      {
label_18:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_19;
label_14:
        MethodInfo current;
        List<string> list;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_9;
            case 2:
              object obj = UIDynamicFormProvider.bctLcMccoMKkrF6deT6((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372711015), UIDynamicFormProvider.CR26EscsgS46FpZwqfw((object) current), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105212654), (IEnumerable<string>) list));
              name = (string) UIDynamicFormProvider.Nhc4obzFLYuCEktiny3(UIDynamicFormProvider.FFeAjJczaXETYYpDnGF((object) name, '+', '.'), UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(--1333735954 ^ 1333754672), (object) "");
              string str1 = name;
              if (!UIDynamicFormProvider.VpOBWuzBiExIPPlRAU9(obj, (object) str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 6 : 6;
                continue;
              }
              goto label_18;
            case 4:
              goto label_18;
            case 5:
              goto label_15;
            case 6:
              methodInfo1 = current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            default:
              list = ((IEnumerable<ParameterInfo>) current.GetParameters()).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (q =>
              {
                int num3 = 1;
                string str2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      str2 = (string) UIDynamicFormProvider.\u003C\u003Ec.BqXvEOfsnbllWyUfSfvb(UIDynamicFormProvider.\u003C\u003Ec.dTveDxfsk4DiBwdcFq9n((object) q));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return (string) UIDynamicFormProvider.\u003C\u003Ec.NEl6bxfs2vcfZDZCmZZP((object) str2, 1, UIDynamicFormProvider.\u003C\u003Ec.YVTcXkfsOvHlM0eHosfR((object) str2) - 2);
              })).ToList<string>();
              num2 = 2;
              continue;
          }
        }
label_15:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        {
          num2 = 0;
          goto label_14;
        }
        else
          goto label_14;
label_19:
        num2 = 3;
        goto label_14;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    private static string GetTypeInfo(Type type)
    {
      int num = 3;
      Type[] genericArguments;
      int index;
      Type type1;
      List<string> values;
      string str;
      string typeInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = string.Join((string) UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(1012087039 ^ 1012099599), (IEnumerable<string>) values);
            num = 13;
            continue;
          case 2:
            values = new List<string>();
            num = 7;
            continue;
          case 3:
            if (type.IsGenericType)
            {
              num = 2;
              continue;
            }
            goto case 9;
          case 4:
          case 8:
            goto label_11;
          case 5:
          case 14:
            if (index < genericArguments.Length)
            {
              num = 11;
              continue;
            }
            goto case 1;
          case 6:
            values.Add((string) UIDynamicFormProvider.ioJXPJzWkF8SFIY7lSf(type1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 12 : 1;
            continue;
          case 7:
            genericArguments = type.GetGenericArguments();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 9:
            typeInfo = (string) UIDynamicFormProvider.clEutvzb3NghdUSdpnF(UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(-441065788 ^ -2092910478 ^ 1727380532), UIDynamicFormProvider.FFeAjJczaXETYYpDnGF((object) type.FullName, '+', '.'));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 4;
            continue;
          case 10:
          case 11:
            type1 = genericArguments[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 6;
            continue;
          case 12:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 5 : 2;
            continue;
          case 13:
            typeInfo = (string) UIDynamicFormProvider.vwmCmjzoWaNOgjGq1W6(UIDynamicFormProvider.hCojN5c9CSLyyFcdstx(993438473 ^ 993423723), (object) type.Namespace, (object) type.Name, (object) str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 8;
            continue;
          default:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 14;
            continue;
        }
      }
label_11:
      return typeInfo;
    }

    protected UIDynamicFormProvider()
    {
      UIDynamicFormProvider.cW9lmYzhTi3h9p8L98T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Od8uYgc1TO5uB6UXTf2() => UIDynamicFormProvider.vRUklecPRvACKAwUYiK == null;

    internal static UIDynamicFormProvider sYsMQccNEYxIZVvBAOy() => UIDynamicFormProvider.vRUklecPRvACKAwUYiK;

    internal static object e0bMq2c3QWcf6IoD8Ek([In] object obj0) => (object) ((DynamicFormSettings) obj0).DynamicFormsProviderData;

    internal static object OkCbNUcp6cPZj5ICehw([In] object obj0, [In] object obj1) => (object) ((UIDynamicFormProvider) obj0).ParseViewItemParams((string) obj1);

    internal static object LHIKPecaAn5GHgJmjNP([In] object obj0) => (object) ((UIViewItemParams) obj0).FormDescriptor;

    internal static bool npdZZxcDfKfhjZpj1c1([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object HhVmwLctABQDbhhNBOa([In] object obj0) => (object) ((IExecutionScopeFactory) obj0).CreateScope();

    internal static Type mOyyyXcw2gBsSN5tgrH([In] object obj0) => ((FormDescriptor) obj0).ControllerType;

    internal static object Bqi2onc4BYhb3sgDHjx([In] object obj0, Type objectType) => ((IExecutionScope) obj0).Resolve(objectType);

    internal static void Bg8yXyc6CSrEunVaI7K([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object EVlHcDcHXfEPCXyNDWe() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void hkWnbncAG6hTMgOe4Fr([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static bool wwOwqWc7bMbrPycMFAB([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static void CpHmAIcx5R2YJ4cbDMX(Type type, [In] object obj1) => ScriptExecutionService.MethodNotFound(type, (string) obj1);

    internal static object YyuxoMc0tCd2sc6fQdZ([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static Type iOCtdIcmagOKiCuDCaX([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static object cxNELycywqaOVYyTNcm(
      [In] object obj0,
      Type itemViewModelType,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4,
      [In] object obj5)
    {
      return ((UIDynamicFormProvider) obj0).CreateItemViewModelType(itemViewModelType, (FormDescriptor) obj2, (IEntity) obj3, (RootViewItem) obj4, (UIViewItemParams) obj5);
    }

    internal static int e8UXlGcM36MoUw0J72c([In] object obj0) => ((List<object>) obj0).Count;

    internal static object NCHXWOcJUmRysbIdAJb([In] object obj0) => (object) ((FormDescriptor) obj0).Metadata;

    internal static object hCojN5c9CSLyyFcdstx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object pbp0UpcdbwZUqmGRd70([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void sB2UEXclbX4Tx2qtkeT([In] object obj0, [In] object obj1) => ScriptExecutionService.ScriptExecution((System.Action) obj0, (string) obj1);

    internal static object FjNjeBcrsQSBvfkUH84([In] object obj0, [In] object obj1) => ((UIDynamicFormProvider) obj0).GetResult(obj1);

    internal static object MQ2OcGcgxUoCfs4atGP([In] object obj0) => (object) ((FormPartMetadata) obj0).Context;

    internal static Guid YnSAsYc5dviIf3WtT3A([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object zLMc5ecjmVc4rkyi31k([In] object obj0) => (object) ((PropertyMetadata) obj0).OnChangeScriptName;

    internal static object lqtKqOcYJhw6n174wGS([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static int YuIscgcLWoJICvwJQjc([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object TN1snJcUTEuyokAs9P1([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object CR26EscsgS46FpZwqfw([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object bctLcMccoMKkrF6deT6([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object FFeAjJczaXETYYpDnGF([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object Nhc4obzFLYuCEktiny3([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool VpOBWuzBiExIPPlRAU9([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object ioJXPJzWkF8SFIY7lSf(Type type) => (object) UIDynamicFormProvider.GetTypeInfo(type);

    internal static object vwmCmjzoWaNOgjGq1W6([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object clEutvzb3NghdUSdpnF([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void cW9lmYzhTi3h9p8L98T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
