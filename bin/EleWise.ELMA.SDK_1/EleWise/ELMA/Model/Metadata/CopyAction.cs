// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.CopyAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Действие при копировании объекта</summary>
  [Uid("ded50eaa-8f9d-4457-b083-60b8b721705b")]
  [DisplayName(typeof (__Resources_CopyAction), "DisplayName")]
  [DefaultValueUid("d161a296-99ee-4e01-93e3-225a4a8cfdb1")]
  [MetadataType(typeof (EnumMetadata))]
  public enum CopyAction
  {
    /// <summary>По умолчанию</summary>
    /// <remarks>Выбирается действие согласно контекста копирования</remarks>
    [Uid("d161a296-99ee-4e01-93e3-225a4a8cfdb1"), DisplayName(typeof (__Resources_CopyAction), "P_Default_DisplayName"), Description(typeof (__Resources_CopyAction), "P_Default_Description")] Default,
    /// <summary>Всегда копировать по ссылке</summary>
    /// <remarks>
    /// Работает аналогично действию "Сохранять исходную ссылку", но если объект, на который указывает ссылка, уже скопирован (при общей операции копирования), то будет использоваться этот скопированный объект.
    /// </remarks>
    [Uid("8b18eee9-0990-4c36-a011-ebc0ee4d4068"), Description(typeof (__Resources_CopyAction), "P_ByRef_Description"), DisplayName(typeof (__Resources_CopyAction), "P_ByRef_DisplayName")] ByRef,
    /// <summary>Всегда создавать копию</summary>
    /// <remarks>Всегда будет создаваться клон объекта</remarks>
    [Uid("2424ee20-46cd-448a-91eb-7f7dd6d0df22"), DisplayName(typeof (__Resources_CopyAction), "P_Clone_DisplayName"), Description(typeof (__Resources_CopyAction), "P_Clone_Description")] Clone,
    /// <summary>Не копировать</summary>
    /// <remarks>Никогда не будет копироваться</remarks>
    [Uid("c4b194eb-4316-4249-9078-3b91343890e3"), DisplayName(typeof (__Resources_CopyAction), "P_Ignore_DisplayName"), Description(typeof (__Resources_CopyAction), "P_Ignore_Description")] Ignore,
    /// <summary>Сохранять исходную ссылку</summary>
    /// <remarks>
    /// При копировании будет сохраняться ссылка на исходный объект.
    /// </remarks>
    [Uid("e4c54db1-acdc-49ef-82e9-c836d1df8eb9"), DisplayName(typeof (__Resources_CopyAction), "P_SaveRef_DisplayName"), Description(typeof (__Resources_CopyAction), "P_SaveRef_Description")] SaveRef,
  }
}
