// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Типы представления</summary>
  [Flags]
  public enum ViewType
  {
    /// <summary>Создание</summary>
    [DisplayName(typeof (__ViewTypeLocalization), "Create")] Create = 1,
    /// <summary>Редактирование</summary>
    [DisplayName(typeof (__ViewTypeLocalization), "Edit")] Edit = 2,
    /// <summary>Просмотр</summary>
    [DisplayName(typeof (__ViewTypeLocalization), "Display")] Display = 4,
    /// <summary>Список</summary>
    [DisplayName(typeof (__ViewTypeLocalization), "List")] List = 8,
    /// <summary>Фильтр сущности</summary>
    [DisplayName(typeof (__ViewTypeLocalization), "Filter")] Filter = 16, // 0x00000010
    /// <summary>Кастомное представление</summary>
    [DisplayName(typeof (__ViewTypeLocalization), "Custom")] Custom = 256, // 0x00000100
    /// <summary>Все, кроме списка</summary>
    AllExceptList = Filter | Display | Edit | Create, // 0x00000017
    /// <summary>Все</summary>
    All = AllExceptList | List, // 0x0000001F
  }
}
