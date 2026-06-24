// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.TypeDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>Менеджер для работы с типами в дизайнере</summary>
  public class TypeDTOManager : DTOManager, ITypeDTOManager, IConfigurationService
  {
    /// <summary>Тип аттрибута</summary>
    private static Type typeAttribute;
    /// <summary>Служба управления метаданными в режиме Runtime</summary>
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private static TypeDTOManager xJADj6EthUQwta1cAmlv;

    /// <summary>Конструктор</summary>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    public TypeDTOManager(IMetadataRuntimeService metadataRuntimeService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Проверить уникальное наименование в интерфейсах</summary>
    /// <param name="typeUid">Guid типа</param>
    /// <param name="propertyName">Наименование свойства</param>
    /// <param name="propertyUid">Uid свойства</param>
    /// <returns>True, если в интерфейсе нет такого свойства или он имеет такой же Uid, иначе false</returns>
    public virtual bool CheckUniqueName(Guid typeUid, string propertyName, Guid propertyUid)
    {
      int num1 = 10;
      UidAttribute uidAttribute;
      while (true)
      {
        int num2 = num1;
        Type typeByUidOrNull;
        PropertyInfo property;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (TypeDTOManager.VO9ckZEtQHyMNLIXd54A(typeByUidOrNull, (Type) null))
              {
                num2 = 3;
                continue;
              }
              goto label_10;
            case 2:
            case 4:
              goto label_21;
            case 3:
              goto label_9;
            case 5:
              goto label_19;
            case 6:
              if (TypeDTOManager.pv8IZEEtCFLlk2cxEIx6((object) property, (object) null))
              {
                num2 = 5;
                continue;
              }
              uidAttribute = TypeDTOManager.BFLc1BEtv8bKNR8ZCyjk((object) property, TypeDTOManager.typeAttribute) as UidAttribute;
              num2 = 11;
              continue;
            case 7:
              goto label_8;
            case 8:
              if (string.IsNullOrEmpty(propertyName))
              {
                num2 = 2;
                continue;
              }
              typeByUidOrNull = this.metadataRuntimeService.GetTypeByUidOrNull(typeUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
            case 9:
              if (TypeDTOManager.pMjNy3Etf2nIoOy4id8h(propertyUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 4;
                continue;
              }
              goto case 8;
            case 10:
              if (!(typeUid == Guid.Empty))
              {
                num2 = 9;
                continue;
              }
              goto label_21;
            case 11:
              goto label_17;
            default:
              goto label_7;
          }
        }
label_10:
        property = typeByUidOrNull.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        num1 = 6;
        continue;
label_17:
        if (uidAttribute == null)
          num1 = 7;
        else
          break;
      }
label_7:
      return TypeDTOManager.pMjNy3Etf2nIoOy4id8h(uidAttribute.Uid, propertyUid);
label_8:
      return false;
label_9:
      return true;
label_19:
      return true;
label_21:
      return true;
    }

    static TypeDTOManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            TypeDTOManager.typeAttribute = TypeDTOManager.Wg5UobEt8phDOROtjg9W(__typeref (UidAttribute));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool aILd7JEtGnJOFDPN1Tew() => TypeDTOManager.xJADj6EthUQwta1cAmlv == null;

    internal static TypeDTOManager cec1o1EtEQaMvipLYNyo() => TypeDTOManager.xJADj6EthUQwta1cAmlv;

    internal static bool pMjNy3Etf2nIoOy4id8h([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool VO9ckZEtQHyMNLIXd54A([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool pv8IZEEtCFLlk2cxEIx6([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object BFLc1BEtv8bKNR8ZCyjk([In] object obj0, [In] Type obj1) => (object) ((MemberInfo) obj0).GetCustomAttribute(obj1);

    internal static Type Wg5UobEt8phDOROtjg9W([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
