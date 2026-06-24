// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService.IReplaceUidAtPropertyMapServiceExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService
{
  /// <summary>
  /// Точка расширения для сервиса маппинга свойств <see cref="T:EleWise.ELMA.Model.Mappings.PropertyMapService" />
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IReplaceUidAtPropertyMapServiceExtension
  {
    /// <summary>Инициализировать расширение</summary>
    /// <param name="objLeft">Объект маппинга ИЗ чего</param>
    /// <param name="objRight">Объект маппинга ВО что</param>
    void Init(object objLeft, object objRight);

    /// <summary>Получить значение из словаря замен для UID-а</summary>
    /// <param name="uid">UID для которого надо получить замену</param>
    /// <param name="newUid">Новое значение из словаря замен</param>
    /// <returns>Успех операции</returns>
    bool GetUidReplace(Guid uid, out Guid? newUid);

    /// <summary>Закончить работу</summary>
    void EndWork();
  }
}
