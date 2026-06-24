// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ActionDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Действие"</summary>
  [Component(Order = 900)]
  public sealed class ActionDescriptor : CLRTypeDescriptor<object, ActionSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{BF9C9728-A0F8-46F4-AB87-7C1F8DDE427C}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static ActionDescriptor fu1hLeo49K15nkK7HniF;

    /// <inheritdoc />
    public override Guid Uid => ActionDescriptor.UID;

    /// <inheritdoc />
    public override string Name => (string) ActionDescriptor.vyPNLyo4gKqdqksSOh6k(ActionDescriptor.akgoQNo4rRk5vhUwjII1(1319452732 ^ 1319440398));

    /// <inheritdoc />
    public override bool Visible => false;

    /// <inheritdoc />
    public override bool IsRuntimeType => false;

    /// <inheritdoc />
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return (ColumnType) null;
    }

    /// <inheritdoc />
    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      return (IDictionary<string, object>) null;
    }

    /// <inheritdoc />
    public override object SerializeSimple(object value) => (object) null;

    /// <inheritdoc />
    public override void Deserialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType) => (object) null;

    public ActionDescriptor()
    {
      ActionDescriptor.lUeNrFo45uVuVvj1MuEs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ActionDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ActionDescriptor.UID = new Guid((string) ActionDescriptor.akgoQNo4rRk5vhUwjII1(1113862659 ^ 1113999673));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            ActionDescriptor.lUeNrFo45uVuVvj1MuEs();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object akgoQNo4rRk5vhUwjII1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vyPNLyo4gKqdqksSOh6k([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool TtX53Jo4dC9Fakq49h8c() => ActionDescriptor.fu1hLeo49K15nkK7HniF == null;

    internal static ActionDescriptor MfJBWVo4lHtZeTJOAxLP() => ActionDescriptor.fu1hLeo49K15nkK7HniF;

    internal static void lUeNrFo45uVuVvj1MuEs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
