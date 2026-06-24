// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.ViewModelTypeService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Базовый класс для получения типа модели представления по типу метаданных
  /// </summary>
  [Component]
  public abstract class ViewModelTypeService : IViewModelTypeService
  {
    private static ViewModelTypeService vMo7mJfGD8RdbrHEhcQG;

    /// <inheritdoc />
    public abstract bool Check(string metadataTypeCode);

    /// <inheritdoc />
    public virtual ViewModelTypeName GetViewPropertyModelType(
      IPropertyMetadata property,
      string metadataNamespace)
    {
      int num1 = 11;
      Type type1;
      bool isNullable;
      ClassMetadata metadata;
      bool isEnumerable;
      while (true)
      {
        int num2 = num1;
        ITypeDescriptor typeDescriptor;
        while (true)
        {
          EntitySettings settings;
          int num3;
          int num4;
          Type type2;
          switch (num2)
          {
            case 1:
              if (metadataNamespace != null)
              {
                num2 = 15;
                continue;
              }
              goto label_28;
            case 2:
              if (ViewModelTypeService.SDE7y7fGx5Q217q8K2Dp(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                continue;
              }
              goto label_19;
            case 3:
              settings = property.Settings as EntitySettings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 7 : 9;
              continue;
            case 4:
              if (!(property is PropertyMetadata))
              {
                num2 = 7;
                continue;
              }
              goto case 16;
            case 5:
              metadata = (ClassMetadata) MetadataServiceContext.Service.GetMetadata(property.SubTypeUid);
              num2 = 3;
              continue;
            case 6:
            case 14:
              goto label_28;
            case 7:
            case 21:
              num3 = 0;
              goto label_36;
            case 8:
              goto label_27;
            case 9:
              if (settings != null)
              {
                num2 = 17;
                continue;
              }
              num4 = 0;
              goto label_38;
            case 10:
              if (property == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 14 : 6;
                continue;
              }
              goto case 13;
            case 11:
              if (!(property is ITablePartMetadata))
              {
                num2 = 10;
                continue;
              }
              goto case 19;
            case 12:
              if (!(typeDescriptor is IRuntimeTypeDescriptor))
              {
                num2 = 18;
                continue;
              }
              type2 = ViewModelTypeService.nZy2MXfG7Iyx25xrLJEr((object) (IRuntimeTypeDescriptor) typeDescriptor);
              break;
            case 13:
              typeDescriptor = (ITypeDescriptor) ViewModelTypeService.THWx5ZfGAFaoike68hDs(ViewModelTypeService.iLh2O6fG6j1DppFKGExP(), property.TypeUid, ViewModelTypeService.wOc8IefGH9o918HLQCcR((object) property));
              num2 = 12;
              continue;
            case 15:
              goto label_6;
            case 16:
              num3 = ViewModelTypeService.oo8VTefGm9AraSDBcOE7((object) (PropertyMetadata) property) ? 1 : 0;
              goto label_36;
            case 17:
              num4 = ViewModelTypeService.FQI544fGML2iogM0YQup((object) settings) != 0 ? 1 : 0;
              goto label_38;
            case 18:
              type2 = (Type) null;
              break;
            case 19:
              if (!(property is ClassMetadata))
              {
                num2 = 6;
                continue;
              }
              goto case 1;
            case 20:
              goto label_18;
            default:
              if (ViewModelTypeService.hTlsOgfG07ALk1hjp1L9((object) typeDescriptor))
                goto case 4;
              else
                goto label_32;
          }
          type1 = type2;
          num2 = 2;
          continue;
label_36:
          isNullable = num3 != 0;
          num2 = 20;
          continue;
label_38:
          isEnumerable = num4 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 8 : 4;
        }
label_19:
        if (typeDescriptor is EntityDescriptor)
        {
          num1 = 5;
          continue;
        }
        goto label_28;
label_32:
        num1 = 21;
      }
label_6:
      return new ViewModelTypeName((string) ViewModelTypeService.PBvQhPfG4MPXOYCUWLDL((object) property), metadataNamespace, isEnumerable: true);
label_18:
      return new ViewModelTypeName((string) ViewModelTypeService.fpsyhufGyhNjE25CJ3hi((object) type1), type1.Namespace, isNullable);
label_27:
      return new ViewModelTypeName((string) ViewModelTypeService.QELlqsfGJtLisKWvv008((object) metadata), (string) ViewModelTypeService.nklVKdfG9Y829lpRK9Ww((object) metadata), isEnumerable: isEnumerable);
label_28:
      return (ViewModelTypeName) null;
    }

    /// <inheritdoc />
    public virtual ViewModelTypeName GetViewModelType(
      string metadataName,
      string metadataNamespace,
      bool useOriginalModel)
    {
      return new ViewModelTypeName(metadataName, metadataNamespace);
    }

    protected ViewModelTypeService()
    {
      ViewModelTypeService.WxxpUsfGdhuT4quc8nKO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object PBvQhPfG4MPXOYCUWLDL([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static object iLh2O6fG6j1DppFKGExP() => (object) MetadataServiceContext.Service;

    internal static Guid wOc8IefGH9o918HLQCcR([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static object THWx5ZfGAFaoike68hDs([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static Type nZy2MXfG7Iyx25xrLJEr([In] object obj0) => ((IRuntimeTypeDescriptor) obj0).RuntimeType;

    internal static bool SDE7y7fGx5Q217q8K2Dp([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool hTlsOgfG07ALk1hjp1L9([In] object obj0) => ((ITypeDescriptor) obj0).CanBeNullable;

    internal static bool oo8VTefGm9AraSDBcOE7([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static object fpsyhufGyhNjE25CJ3hi([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static RelationType FQI544fGML2iogM0YQup([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static object QELlqsfGJtLisKWvv008([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object nklVKdfG9Y829lpRK9Ww([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static bool en1VX3fGtPkZkGZ3Jxnu() => ViewModelTypeService.vMo7mJfGD8RdbrHEhcQG == null;

    internal static ViewModelTypeService tDnNWkfGwpH5ubUMfiDV() => ViewModelTypeService.vMo7mJfGD8RdbrHEhcQG;

    internal static void WxxpUsfGdhuT4quc8nKO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
