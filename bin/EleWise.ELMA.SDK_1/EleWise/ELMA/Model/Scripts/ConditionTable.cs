// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ConditionTable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Класс для задания условий в табличном виде</summary>
  [Serializable]
  public class ConditionTable
  {
    private List<ConditionTable.Item> items;
    internal static ConditionTable PauUZZbRuvOf79lJiyAc;

    /// <summary>Элементы</summary>
    public List<ConditionTable.Item> Items
    {
      get => this.items;
      set => this.items = value;
    }

    public ConditionTable()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.items = new List<ConditionTable.Item>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VRYSmtbRIE3Ntg9P1xhG() => ConditionTable.PauUZZbRuvOf79lJiyAc == null;

    internal static ConditionTable IGIQ4FbRV9YLDBg1Ejw5() => ConditionTable.PauUZZbRuvOf79lJiyAc;

    /// <summary>Элемент табличного условия</summary>
    [Serializable]
    public class Item
    {
      private static ConditionTable.Item iaZmByC1nh1MMqgR9g1A;

      /// <summary>Ctor</summary>
      public Item()
      {
        ConditionTable.Item.J8tlluC1e4o34d0vii3o();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Operand2 = new ConditionTable.Operand();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 2:
              this.Operand1 = new ConditionTable.Operand();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      /// <summary>Отношение</summary>
      public ConditionTable.Relation Relation
      {
        get => this.\u003CRelation\u003Ek__BackingField;
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
                this.\u003CRelation\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

      /// <summary>Операнд 1</summary>
      public ConditionTable.Operand Operand1
      {
        get => this.\u003COperand1\u003Ek__BackingField;
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
                this.\u003COperand1\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

      /// <summary>Операция</summary>
      public ConditionTable.Operation Operation
      {
        get => this.\u003COperation\u003Ek__BackingField;
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
                this.\u003COperation\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

      /// <summary>Операнд 2</summary>
      public ConditionTable.Operand Operand2
      {
        get => this.\u003COperand2\u003Ek__BackingField;
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
                this.\u003COperand2\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

      internal static void J8tlluC1e4o34d0vii3o() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool e6np3VC1O7Z137x6iUoC() => ConditionTable.Item.iaZmByC1nh1MMqgR9g1A == null;

      internal static ConditionTable.Item m2oi0lC12sy17mcSPLgQ() => ConditionTable.Item.iaZmByC1nh1MMqgR9g1A;
    }

    /// <summary>Операнд элемента табличного условия</summary>
    [Serializable]
    public class Operand
    {
      private static ConditionTable.Operand Mj5W8rC1PKqXbUFmSWdi;

      /// <summary>Тип операнда</summary>
      public ConditionTable.OperandType Type
      {
        get => this.\u003CType\u003Ek__BackingField;
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
                this.\u003CType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

      /// <summary>Значение</summary>
      public object Value
      {
        get => this.\u003CValue\u003Ek__BackingField;
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
                this.\u003CValue\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

      /// <summary>UID свойства</summary>
      public Guid PropertyUid
      {
        get => this.\u003CPropertyUid\u003Ek__BackingField;
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
                this.\u003CPropertyUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

      /// <summary>UID Custom Type</summary>
      public Guid CustomTypeUid
      {
        get => this.\u003CCustomTypeUid\u003Ek__BackingField;
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
                this.\u003CCustomTypeUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

      public Operand()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool hDH8qbC11GeOfkdBOh83() => ConditionTable.Operand.Mj5W8rC1PKqXbUFmSWdi == null;

      internal static ConditionTable.Operand ioWKN3C1NMd3oFsL2SR5() => ConditionTable.Operand.Mj5W8rC1PKqXbUFmSWdi;
    }

    /// <summary>Отношение между операндами</summary>
    public enum Relation
    {
      /// <summary>И</summary>
      [DisplayName(typeof (ConditionTable.Relation_SR), "And")] And,
      /// <summary>Или</summary>
      [DisplayName(typeof (ConditionTable.Relation_SR), "Or")] Or,
      /// <summary>И не</summary>
      [DisplayName(typeof (ConditionTable.Relation_SR), "AndNot")] AndNot,
      /// <summary>Или не</summary>
      [DisplayName(typeof (ConditionTable.Relation_SR), "OrNot")] OrNot,
    }

    internal static class Relation_SR
    {
      private static ConditionTable.Relation_SR rNKUetC1DlXCsooqZTna;

      public static string And => (string) ConditionTable.Relation_SR.Sn65ZNC16a0fEQbomnM9(ConditionTable.Relation_SR.lGh4EgC14BalmjY9mKGV(-1445902765 ^ -1980277732 ^ 539383057));

      public static string Or => EleWise.ELMA.SR.T((string) ConditionTable.Relation_SR.lGh4EgC14BalmjY9mKGV(1505778440 - 1981636111 ^ -475876451));

      public static string AndNot => (string) ConditionTable.Relation_SR.Sn65ZNC16a0fEQbomnM9(ConditionTable.Relation_SR.lGh4EgC14BalmjY9mKGV(-1146510045 ^ -1146351723));

      public static string OrNot => (string) ConditionTable.Relation_SR.Sn65ZNC16a0fEQbomnM9((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406069897));

      internal static object lGh4EgC14BalmjY9mKGV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object Sn65ZNC16a0fEQbomnM9([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool jQnGHjC1tnLJfPJu7yBZ() => ConditionTable.Relation_SR.rNKUetC1DlXCsooqZTna == null;

      internal static ConditionTable.Relation_SR ciQuxdC1wBQU6kB3Z9sN() => ConditionTable.Relation_SR.rNKUetC1DlXCsooqZTna;
    }

    /// <summary>Тип операнда</summary>
    public enum OperandType
    {
      /// <summary>Свойство</summary>
      Property,
      /// <summary>Значение</summary>
      Value,
      /// <summary>
      /// Переменная шлюза (используйте вместо этого значения CustomType)
      /// </summary>
      GatewayVar,
      /// <summary>Custom тип</summary>
      CustomType,
    }

    /// <summary>Операция сравнения операндов</summary>
    public enum Operation
    {
      /// <summary>Равно</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "Equal")] Equal,
      /// <summary>Не равно</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "NotEqual")] NotEqual,
      /// <summary>Больше</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "More")] More,
      /// <summary>Меньше</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "Less")] Less,
      /// <summary>Больше или равно</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "MoreOrEqual")] MoreOrEqual,
      /// <summary>Меньше или равно</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "LessOrEqual")] LessOrEqual,
      /// <summary>Начинается с</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "StartWith")] StartWith,
      /// <summary>Оканчивается на</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "EndWith")] EndWith,
      /// <summary>Содержит</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "Contain")] Contain,
      /// <summary>Не содержит</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "NotContain")] NotContain,
      /// <summary>Равно (без учета регистра)</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "EqualIC")] EqualIC,
      /// <summary>Не равно (без учета регистра)</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "NotEqualIC")] NotEqualIC,
      /// <summary>Начинается с (без учета регистра)</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "StartWithIC")] StartWithIC,
      /// <summary>Заканчивается на (без учета регистра)</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "EndWithIC")] EndWithIC,
      /// <summary>Содержит (без учета регистра)</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "ContainIC")] ContainIC,
      /// <summary>Не содержит (без учета регистра)</summary>
      [DisplayName(typeof (ConditionTable.Operation_SR), "NotContainIC")] NotContainIC,
    }

    internal static class Operation_SR
    {
      internal static ConditionTable.Operation_SR TXpQFHC1yR9I0UQKRQ3R;

      public static string Equal => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(1669212571 ^ 1669211537));

      public static string NotEqual => EleWise.ELMA.SR.T((string) ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(-1822890472 ^ -1822602038));

      public static string More => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825372358));

      public static string Less => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(589593376 ^ -1977315327 ^ -1459575577));

      public static string MoreOrEqual => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(-441065788 ^ -2092910478 ^ 1727057004));

      public static string LessOrEqual => EleWise.ELMA.SR.T((string) ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(1178210108 ^ 1178192646));

      public static string StartWith => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3633416));

      public static string EndWith => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(-1426456882 ^ 2009939514 ^ -583964150));

      public static string Contain => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653942905));

      public static string NotContain => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 396912620));

      public static string EqualIC => EleWise.ELMA.SR.T((string) ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(1033719030 - 2012070891 ^ -978705851));

      public static string NotEqualIC => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(323422137 << 2 ^ 1293530466));

      public static string StartWithIC => EleWise.ELMA.SR.T((string) ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(-1350312861 << 3 ^ 2082162908));

      public static string EndWithIC => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(87862435 ^ 87621801));

      public static string ContainIC => (string) ConditionTable.Operation_SR.cvO3vCC1dQUsyM8FIFnB(ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(-477139494 ^ -477445758));

      public static string NotContainIC => EleWise.ELMA.SR.T((string) ConditionTable.Operation_SR.Eh4hB6C19hi3ITlUvd6H(2045296739 + 1688595713 ^ -561315342));

      internal static object Eh4hB6C19hi3ITlUvd6H(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object cvO3vCC1dQUsyM8FIFnB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool E4OQ5uC1MSoCw9rRKskW() => ConditionTable.Operation_SR.TXpQFHC1yR9I0UQKRQ3R == null;

      internal static ConditionTable.Operation_SR oaRnbBC1JpYQoI7bn9V6() => ConditionTable.Operation_SR.TXpQFHC1yR9I0UQKRQ3R;
    }
  }
}
