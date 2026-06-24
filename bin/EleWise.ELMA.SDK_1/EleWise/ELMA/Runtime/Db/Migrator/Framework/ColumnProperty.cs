// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ColumnProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Represents a table column properties.</summary>
  [Flags]
  public enum ColumnProperty
  {
    None = 0,
    /// <summary>Null is allowable</summary>
    Null = 1,
    /// <summary>Null is not allowable</summary>
    NotNull = 2,
    /// <summary>Identity column, autoinc</summary>
    Identity = 4,
    /// <summary>Unique Column</summary>
    Unique = 8,
    /// <summary>Unsigned Column</summary>
    Unsigned = 16, // 0x00000010
    /// <summary>Foreign Key</summary>
    ForeignKey = 32, // 0x00000020
    /// <summary>Primary Key</summary>
    PrimaryKey = 66, // 0x00000042
    /// <summary>
    /// Primary key. Make the column a PrimaryKey and unsigned
    /// </summary>
    PrimaryKeyWithIdentity = PrimaryKey | Identity, // 0x00000046
  }
}
