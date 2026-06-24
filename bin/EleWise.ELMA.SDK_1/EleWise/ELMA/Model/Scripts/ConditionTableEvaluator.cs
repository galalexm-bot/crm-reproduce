// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ConditionTableEvaluator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Вычислитель табличных условий</summary>
  public class ConditionTableEvaluator
  {
    private ConditionTable condTable;
    private object obj;
    private Dictionary<string, object> additionalParams;
    private static ConditionTableEvaluator UYVDKqbRSb71AeweDSEo;

    /// <summary>Проверить условие</summary>
    /// <param name="condTable">Таблица условий</param>
    /// <param name="obj">Объект, для которого проверяется условие</param>
    /// <returns>True, если условие верно</returns>
    public static bool CheckConditionTable(ConditionTable condTable, object obj) => ConditionTableEvaluator.CheckConditionTable(condTable, obj, (Dictionary<string, object>) null);

    /// <summary>Проверить условие</summary>
    /// <param name="condTable">Таблица условий</param>
    /// <param name="obj">Объект, для которого проверяется условие</param>
    /// <param name="additionalParams">Дополнительные параметры</param>
    /// <returns>True, если условие верно</returns>
    public static bool CheckConditionTable(
      ConditionTable condTable,
      object obj,
      Dictionary<string, object> additionalParams)
    {
      return new ConditionTableEvaluator()
      {
        condTable = condTable,
        obj = obj,
        additionalParams = additionalParams
      }.CheckConditionTable();
    }

    private ConditionTableEvaluator()
    {
      ConditionTableEvaluator.AJuBo9bRqDgGetjYFClp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    private bool CheckConditionTable()
    {
      int num1 = 11;
      bool flag1;
      List<List<bool>>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        List<bool> boolList;
        bool flag2;
        int index;
        List<List<bool>> boolListList;
        ConditionTable.Relation relation;
        bool flag3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              boolList.Add(flag2);
              num2 = 24;
              continue;
            case 2:
              boolList.Add(flag2);
              num2 = 29;
              continue;
            case 3:
              if (!flag3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 26 : 8;
                continue;
              }
              goto case 1;
            case 4:
            case 8:
            case 12:
            case 24:
            case 29:
            case 32:
              flag3 = false;
              num2 = 17;
              continue;
            case 5:
            case 22:
              flag2 = this.CheckItem(this.condTable.Items[index]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 3;
              continue;
            case 6:
label_9:
              boolListList.Add(boolList);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 3 : 9;
              continue;
            case 7:
              boolList = new List<bool>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 1;
              continue;
            case 9:
              boolList = new List<bool>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 23 : 16;
              continue;
            case 10:
              boolListList = new List<List<bool>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            case 11:
              flag3 = true;
              num2 = 10;
              continue;
            case 13:
              goto label_45;
            case 14:
              goto label_8;
            case 15:
label_40:
              boolList.Add(flag2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 8;
              continue;
            case 16:
              enumerator1 = boolListList.GetEnumerator();
              num2 = 31;
              continue;
            case 17:
              goto label_39;
            case 18:
              boolListList.Add(boolList);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 27 : 2;
              continue;
            case 19:
            case 33:
              if (index < ConditionTableEvaluator.RuYJw0bRKlvWfxnpgYB1((object) this.condTable.Items))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 22 : 21;
                continue;
              }
              goto case 28;
            case 20:
              switch (relation)
              {
                case ConditionTable.Relation.And:
                  goto label_40;
                case ConditionTable.Relation.Or:
                  goto label_52;
                case ConditionTable.Relation.AndNot:
                  goto label_3;
                case ConditionTable.Relation.OrNot:
                  goto label_9;
                default:
                  num2 = 32;
                  continue;
              }
            case 21:
label_3:
              boolList.Add(!flag2);
              num2 = 12;
              continue;
            case 23:
              boolList.Add(!flag2);
              num2 = 4;
              continue;
            case 25:
label_52:
              boolListList.Add(boolList);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 7 : 1;
              continue;
            case 26:
            case 30:
              relation = this.condTable.Items[index].Relation;
              num2 = 20;
              continue;
            case 27:
              goto label_41;
            case 28:
              if (ConditionTableEvaluator.vAacdsbRX1gy6i69WFmN((object) boolList) > 0)
              {
                num2 = 18;
                continue;
              }
              goto label_41;
            case 31:
              goto label_18;
            default:
              boolList = new List<bool>();
              num2 = 13;
              continue;
          }
        }
label_39:
        ++index;
        num1 = 33;
        continue;
label_41:
        flag1 = false;
        num1 = 16;
        continue;
label_45:
        index = 0;
        num1 = 19;
      }
label_8:
      return flag1;
label_18:
      try
      {
label_31:
        if (enumerator1.MoveNext())
          goto label_34;
        else
          goto label_32;
label_19:
        bool flag4;
        List<bool>.Enumerator enumerator2;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
label_33:
              flag1 |= flag4;
              num3 = 4;
              continue;
            case 2:
              try
              {
label_25:
                if (enumerator2.MoveNext())
                  goto label_23;
                else
                  goto label_26;
label_21:
                bool current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_33;
                    case 2:
                      goto label_23;
                    case 3:
                      goto label_25;
                    default:
                      flag4 &= current;
                      num4 = 3;
                      continue;
                  }
                }
label_23:
                current = enumerator2.Current;
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                {
                  num4 = 0;
                  goto label_21;
                }
                else
                  goto label_21;
label_26:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
                goto label_21;
              }
              finally
              {
                enumerator2.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 3:
              goto label_34;
            case 4:
              goto label_31;
            default:
              goto label_8;
          }
        }
label_32:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
        goto label_19;
label_34:
        List<bool> current1 = enumerator1.Current;
        flag4 = true;
        enumerator2 = current1.GetEnumerator();
        num3 = 2;
        goto label_19;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    private ConditionTableEvaluator.OperandValue CalcOperand(ConditionTable.Operand op)
    {
      int num1 = 5;
      PropertyMetadata propertyMetadata;
      object obj;
      IConditionOperandEvaluator operandEvaluator;
      ConditionTable.Operand op1;
      while (true)
      {
        int num2 = num1;
        ClassMetadata classMetadata;
        ConditionTable.OperandType operandType;
        while (true)
        {
          switch (num2)
          {
            case 1:
              switch (operandType)
              {
                case ConditionTable.OperandType.Property:
                  goto label_5;
                case ConditionTable.OperandType.Value:
                  goto label_8;
                case ConditionTable.OperandType.GatewayVar:
                  goto label_26;
                case ConditionTable.OperandType.CustomType:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  operandEvaluator = ((ComponentManager) ConditionTableEvaluator.oj5qaNbR2VpAkSK0NRmG()).GetExtensionPoints<IConditionOperandEvaluator>().FirstOrDefault<IConditionOperandEvaluator>((Func<IConditionOperandEvaluator, bool>) (e => ConditionTableEvaluator.\u003C\u003Ec__DisplayClass8_0.RV30ATC1zZ6s1AuLp4ZG(ConditionTableEvaluator.\u003C\u003Ec__DisplayClass8_0.IigfeJC1s7q5qVYAxOh1((object) e), ConditionTableEvaluator.\u003C\u003Ec__DisplayClass8_0.Xba0FDC1cVlNFqlwI2v4((object) op1))));
                  num2 = 11;
                  continue;
                default:
                  num2 = 6;
                  continue;
              }
            case 2:
              goto label_3;
            case 3:
label_5:
              if (this.obj == null)
              {
                num2 = 10;
                continue;
              }
              classMetadata = MetadataLoader.LoadMetadata(this.obj.GetType()) as ClassMetadata;
              num2 = 14;
              continue;
            case 4:
              op1 = op;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              goto label_26;
            case 7:
              goto label_15;
            case 8:
              if (propertyMetadata != null)
              {
                obj = this.obj.GetType().InvokeMember(propertyMetadata.Name, BindingFlags.GetProperty, (Binder) null, this.obj, (object[]) null);
                num2 = 12;
                continue;
              }
              goto label_14;
            case 9:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == ConditionTableEvaluator.\u003C\u003Ec__DisplayClass8_0.tB6jT0C1UM61Rw9tYXly((object) op1)));
              num2 = 8;
              continue;
            case 10:
              goto label_23;
            case 11:
              if (operandEvaluator != null)
              {
                num2 = 13;
                continue;
              }
              goto label_26;
            case 12:
              goto label_7;
            case 13:
              goto label_25;
            case 14:
              if (classMetadata != null)
              {
                num2 = 9;
                continue;
              }
              goto label_3;
            default:
              operandType = ConditionTableEvaluator.b7l706bRTu863VCqnDYb((object) op1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
              continue;
          }
        }
label_14:
        num1 = 7;
      }
label_3:
      return (ConditionTableEvaluator.OperandValue) null;
label_7:
      ConditionTableEvaluator.OperandValue operandValue1 = new ConditionTableEvaluator.OperandValue();
      operandValue1.Value = obj;
      ConditionTableEvaluator.c7i5XcbRk871wIRLLlbb((object) operandValue1, (object) propertyMetadata);
      return operandValue1;
label_8:
      ConditionTableEvaluator.OperandValue operandValue2 = new ConditionTableEvaluator.OperandValue();
      ConditionTableEvaluator.ia885JbROV0sFVxamGpf((object) operandValue2, ConditionTableEvaluator.vOHVEGbRnU2L6nhx2iiC((object) op1));
      return operandValue2;
label_15:
      return (ConditionTableEvaluator.OperandValue) null;
label_23:
      return (ConditionTableEvaluator.OperandValue) null;
label_25:
      return operandEvaluator.Evaluate(op1, this.obj, this.additionalParams);
label_26:
      return (ConditionTableEvaluator.OperandValue) null;
    }

    private static bool TryConvertOperands(
      object ov1,
      object ov2,
      out object v1,
      out object v2,
      out ITypeDescriptor typeDescriptor)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
            case 9:
            case 14:
              if (v1 != null)
              {
                num2 = 11;
                continue;
              }
              goto case 15;
            case 3:
              typeDescriptor = (ITypeDescriptor) null;
              num2 = 10;
              continue;
            case 4:
              v2 = ov2 == null ? (object) null : ConditionTableEvaluator.m9CvkbbReAKPF0pFdRFk(ov2);
              num2 = 3;
              continue;
            case 5:
              v1 = ov1 != null ? ConditionTableEvaluator.m9CvkbbReAKPF0pFdRFk(ov1) : (object) null;
              num2 = 4;
              continue;
            case 6:
              if (ConditionTableEvaluator.rAwZvjbRamPrS6fsnD6N(ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov1)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 9 : 13;
                continue;
              }
              goto label_107;
            case 7:
              typeDescriptor = (ITypeDescriptor) ConditionTableEvaluator.zxoXXabR3kaXDSinGsi6((object) Locator.GetServiceNotNull<IMetadataRuntimeService>(), ConditionTableEvaluator.qPydErbR1cg1UituwUmY((object) ((ConditionTableEvaluator.OperandValue) ov1).PropertyMetadata), ConditionTableEvaluator.NBsYfUbRN7EweqDOMqbX(ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov1)));
              num2 = 2;
              continue;
            case 8:
              goto label_111;
            case 10:
              if (ov1 == null)
              {
                num2 = 14;
                continue;
              }
              goto default;
            case 11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
              continue;
            case 12:
              if (ConditionTableEvaluator.XVDimZbRp81dDcBVrB6p((object) typeDescriptor))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 0;
                continue;
              }
              goto label_107;
            case 13:
              goto label_106;
            case 15:
              if (typeDescriptor != null)
              {
                num2 = 12;
                continue;
              }
              goto label_107;
            default:
              if (ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov1) != null)
                goto case 7;
              else
                goto label_4;
          }
        }
label_4:
        num1 = 9;
      }
label_7:
      bool flag;
      try
      {
        int num3;
        if (v2 == null)
          num3 = 16;
        else
          goto label_32;
label_9:
        int num4 = num3;
label_10:
        TypeConverter converter;
        TimeSpan result;
        EnumValueMetadata enumValueMetadata;
        IConvertableTypeDescriptor convertableTypeDescriptor;
        TimeSpan timeSpan;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (v1 is TimeSpan)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 0;
                continue;
              }
              goto case 9;
            case 2:
            case 30:
              if (!v2.GetType().IsEnum)
              {
                num4 = 81;
                continue;
              }
              goto label_46;
            case 3:
              ref object local1 = ref v1;
              timeSpan = (TimeSpan) v1;
              // ISSUE: variable of a boxed type
              __Boxed<long> ticks1 = (System.ValueType) timeSpan.Ticks;
              local1 = (object) ticks1;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 73 : 9;
              continue;
            case 4:
              v2 = (object) (v2 == null ? 0 : (int) ConditionTableEvaluator.RrK94HbRALYod1D5yFMa(v2));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 71 : 91;
              continue;
            case 5:
            case 13:
            case 26:
            case 27:
            case 29:
            case 39:
            case 58:
            case 75:
            case 82:
            case 88:
            case 91:
              flag = true;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 43 : 51;
              continue;
            case 6:
              flag = true;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 17 : 22;
              continue;
            case 7:
            case 22:
            case 28:
            case 38:
            case 40:
            case 51:
            case 61:
            case 70:
            case 85:
            case 93:
              goto label_111;
            case 8:
            case 80:
              goto label_53;
            case 9:
              flag = false;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 28 : 2;
              continue;
            case 10:
              if (v2 == null)
              {
                num4 = 80;
                continue;
              }
              goto case 76;
            case 11:
              goto label_95;
            case 12:
              v2 = ConditionTableEvaluator.Me2nKDbR4674ucY55CfL(v1.GetType(), enumValueMetadata.Uid);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 37 : 4;
              continue;
            case 14:
              v2 = ConditionTableEvaluator.K1RB9FbRwKPlch7UGAs7((object) convertableTypeDescriptor, v2, ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov1));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            case 15:
            case 55:
              v2 = v1.GetType().DefaultValue();
              num4 = 78;
              continue;
            case 16:
              if (ov2 != null)
                goto case 53;
              else
                goto label_79;
            case 17:
              if (!ConditionTableEvaluator.XVDimZbRp81dDcBVrB6p((object) typeDescriptor))
                goto case 15;
              else
                goto label_44;
            case 18:
            case 35:
              if (v2 is long)
              {
                num4 = 41;
                continue;
              }
              goto case 10;
            case 19:
              goto label_28;
            case 20:
              goto label_46;
            case 21:
              flag = true;
              num4 = 61;
              continue;
            case 23:
              goto label_93;
            case 24:
            case 89:
              goto label_92;
            case 25:
              enumValueMetadata = v2 as EnumValueMetadata;
              num4 = 52;
              continue;
            case 31:
              flag = true;
              num4 = 85;
              continue;
            case 32:
            case 56:
              if (!(v1 is long))
              {
                num4 = 50;
                continue;
              }
              goto case 49;
            case 33:
            case 45:
              if (!(v1 is byte))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 87 : 73;
                continue;
              }
              goto label_96;
            case 34:
              if ((object) (v1 as EnumBase) == null)
              {
                num4 = 68;
                continue;
              }
              goto case 90;
            case 36:
              goto label_96;
            case 37:
              flag = true;
              num4 = 38;
              continue;
            case 41:
              v2 = (object) (long) v2;
              num4 = 26;
              continue;
            case 42:
              v2 = (object) (float) (v2 == null ? 0.0 : (double) ConditionTableEvaluator.ONub5rbR6sRWi3vt8txV(v2));
              num4 = 84;
              continue;
            case 43:
            case 68:
              if (v1 is double)
              {
                num4 = 23;
                continue;
              }
              goto case 97;
            case 44:
              if (!ConditionTableEvaluator.dWTLhCbRDHdHJvOgChW6((object) converter, v1.GetType()))
              {
                num4 = 24;
                continue;
              }
              goto case 86;
            case 46:
              v2 = (object) (v2 == null ? ConditionTableEvaluator.B9hyy8bR7txlmHWoag2Q(0.0) : ConditionTableEvaluator.pVMRRHbRxEvcrMiyrU8r(v2));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 88 : 60;
              continue;
            case 47:
            case 84:
              if (!(v1 is Decimal))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 43 : 45;
                continue;
              }
              goto label_95;
            case 48:
            case 87:
              if (!(v1 is short))
              {
                num4 = 74;
                continue;
              }
              goto case 4;
            case 49:
              v2 = (object) (v2 != null ? Convert.ToInt64(v2) : 0L);
              num4 = 5;
              continue;
            case 50:
            case 71:
              if (!(v1 is DateTime))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 18 : 64;
                continue;
              }
              goto case 46;
            case 52:
              if (enumValueMetadata != null)
              {
                num4 = 12;
                continue;
              }
              goto case 69;
            case 53:
              if (ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov2) != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 79 : 18;
                continue;
              }
              goto case 83;
            case 54:
              v2 = ModelHelper.GetEnumDefaultValue(v1.GetType());
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 31 : 22;
              continue;
            case 57:
            case 64:
              if (v1 is bool)
              {
                num4 = 59;
                continue;
              }
              goto case 1;
            case 59:
              v2 = (object) (bool) (v2 == null ? 0 : (ConditionTableEvaluator.p3yJGabR0vrk2xiFZKgM(v2) ? 1 : 0));
              num4 = 58;
              continue;
            case 60:
            case 74:
              if (!(v1 is int))
              {
                num4 = 32;
                continue;
              }
              goto case 62;
            case 62:
              v2 = (object) (v2 == null ? 0 : Convert.ToInt32(v2));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 39 : 6;
              continue;
            case 63:
              goto label_32;
            case 65:
            case 72:
            case 94:
              if (!v1.GetType().IsEnum)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 34 : 27;
                continue;
              }
              goto case 90;
            case 66:
              v2 = (object) result.Ticks;
              num4 = 13;
              continue;
            case 67:
              ref object local2 = ref v2;
              timeSpan = (TimeSpan) v2;
              // ISSUE: variable of a boxed type
              __Boxed<long> ticks2 = (System.ValueType) timeSpan.Ticks;
              local2 = (object) ticks2;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 75 : 24;
              continue;
            case 69:
              flag = false;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 93 : 17;
              continue;
            case 73:
              if (!(v2 is TimeSpan))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 8 : 35;
                continue;
              }
              goto case 67;
            case 76:
              TimeSpan.TryParse(v2.ToString(), out result);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 66 : 5;
              continue;
            case 77:
              if (convertableTypeDescriptor == null)
              {
                num4 = 65;
                continue;
              }
              goto case 14;
            case 78:
              goto label_75;
            case 79:
              typeDescriptor = (ITypeDescriptor) ConditionTableEvaluator.zxoXXabR3kaXDSinGsi6((object) Locator.GetServiceNotNull<IMetadataRuntimeService>(), ((ConditionTableEvaluator.OperandValue) ov2).PropertyMetadata.TypeUid, ((PropertyMetadata) ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov2)).SubTypeUid);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 95 : 35;
              continue;
            case 81:
              if ((object) (v2 as EnumBase) != null)
              {
                num4 = 20;
                continue;
              }
              goto case 25;
            case 83:
            case 95:
              if (typeDescriptor != null)
                goto case 17;
              else
                goto label_69;
            case 86:
              v2 = ConditionTableEvaluator.Ii4o5lbRtdefCVYG6LFs((object) converter, v2, v1.GetType());
              num4 = 19;
              continue;
            case 90:
              if (v2 != null)
              {
                num4 = 30;
                continue;
              }
              goto case 54;
            case 92:
              if (((PropertyMetadata) ConditionTableEvaluator.JjuDn5bRPfA5iTMRKUkm(ov2)).Nullable)
              {
                num4 = 6;
                continue;
              }
              goto case 15;
            case 96:
              if (converter != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 44 : 37;
                continue;
              }
              goto label_92;
            case 97:
              if (!(v1 is float))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 39 : 47;
                continue;
              }
              goto case 42;
            default:
              if (v2 == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 94 : 32;
                continue;
              }
              goto case 21;
          }
        }
label_28:
        flag = true;
        num3 = 70;
        goto label_9;
label_44:
        num3 = 92;
        goto label_9;
label_46:
        flag = true;
        num3 = 7;
        goto label_9;
label_53:
        v2 = (object) 0L;
        num3 = 27;
        goto label_9;
label_69:
        num3 = 15;
        goto label_9;
label_75:
        flag = true;
        num3 = 40;
        goto label_9;
label_79:
        num3 = 83;
        goto label_9;
label_92:
        convertableTypeDescriptor = typeDescriptor as IConvertableTypeDescriptor;
        num3 = 77;
        goto label_9;
label_93:
        v2 = (object) (v2 == null ? 0.0 : Convert.ToDouble(v2));
        num3 = 97;
        goto label_9;
label_95:
        v2 = (object) (v2 == null ? 0M : Convert.ToDecimal(v2));
        num3 = 33;
        goto label_9;
label_96:
        v2 = (object) (v2 == null ? 0 : (int) ConditionTableEvaluator.X2A67xbRHQIBkNQYFAK7(v2));
        num3 = 82;
        goto label_9;
label_32:
        converter = System.ComponentModel.TypeDescriptor.GetConverter(v2.GetType());
        num4 = 96;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        {
          num4 = 47;
          goto label_10;
        }
        else
          goto label_10;
      }
      catch (Exception ex)
      {
        int num5 = 2;
        while (true)
        {
          switch (num5)
          {
            case 1:
              flag = false;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            case 2:
              ((ILogger) ConditionTableEvaluator.STLG7BbRm0jviJOIkUlX()).Error(ConditionTableEvaluator.EDHEXIbRMKbUOGr6L98f(ConditionTableEvaluator.NPuuBJbRypa1Ucusxunk(874012245 ^ 874177005), v1, v2), ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
              continue;
            default:
              goto label_111;
          }
        }
      }
label_106:
      return true;
label_107:
      return false;
label_111:
      return flag;
    }

    private void ConvertOperandsToString(ref object v1, ref object v2)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            if (!(v2 is string))
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 2:
            if (v1 is string)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 4:
            v2 = v2 == null ? (object) string.Empty : (object) v2.ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 5;
            continue;
          case 5:
            goto label_9;
        }
        v1 = v1 != null ? (object) v1.ToString() : (object) string.Empty;
        num = 3;
      }
label_9:
      return;
label_6:;
    }

    private bool CheckItem(ConditionTable.Item el)
    {
      int num1 = 21;
      object v2;
      IEqualityTypeDescriptor equalityTypeDescriptor;
      object v1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ConditionTable.Operation operation;
          ConditionTableEvaluator.OperandValue operandValue1;
          ITypeDescriptor typeDescriptor;
          ConditionTableEvaluator.OperandValue operandValue2;
          switch (num2)
          {
            case 1:
            case 12:
            case 31:
              equalityTypeDescriptor = typeDescriptor as IEqualityTypeDescriptor;
              num2 = 37;
              continue;
            case 2:
              goto label_46;
            case 3:
              goto label_37;
            case 4:
              goto label_34;
            case 5:
              goto label_41;
            case 6:
              goto label_49;
            case 7:
              if (v2 != null)
              {
                num2 = 40;
                continue;
              }
              goto label_12;
            case 8:
              goto label_55;
            case 9:
label_27:
              if (equalityTypeDescriptor == null)
              {
                if (v1 != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 26 : 7;
                  continue;
                }
                break;
              }
              num2 = 15;
              continue;
            case 10:
label_72:
              if (!(v2 is IComparable))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 36 : 7;
                continue;
              }
              goto label_11;
            case 11:
              goto label_67;
            case 13:
              goto label_31;
            case 14:
            case 17:
            case 19:
            case 27:
            case 32:
            case 36:
              goto label_12;
            case 15:
              goto label_5;
            case 16:
              goto label_43;
            case 18:
              goto label_19;
            case 20:
              operandValue2 = this.CalcOperand((ConditionTable.Operand) ConditionTableEvaluator.cGmPjtbR9XrshY5Ws2RH((object) el));
              num2 = 22;
              continue;
            case 21:
              operandValue1 = this.CalcOperand((ConditionTable.Operand) ConditionTableEvaluator.vcPjv6bRJHvIUKBL7Br3((object) el));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 10 : 20;
              continue;
            case 22:
              if (ConditionTableEvaluator.TryConvertOperands((object) operandValue1, (object) operandValue2, out v1, out v2, out typeDescriptor))
              {
                num2 = 12;
                continue;
              }
              goto case 25;
            case 23:
label_65:
              if (v2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 32 : 32;
                continue;
              }
              goto label_67;
            case 24:
              goto label_15;
            case 25:
              if (ConditionTableEvaluator.TryConvertOperands((object) operandValue2, (object) operandValue1, out v2, out v1, out typeDescriptor))
              {
                num2 = 31;
                continue;
              }
              goto case 41;
            case 26:
              if (v2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
                continue;
              }
              break;
            case 28:
              if (v2 is IComparable)
              {
                num2 = 6;
                continue;
              }
              goto label_12;
            case 29:
              goto label_13;
            case 30:
              goto label_17;
            case 33:
label_63:
              if (v2 is IComparable)
              {
                num2 = 34;
                continue;
              }
              goto label_12;
            case 34:
              goto label_22;
            case 35:
              switch (operation)
              {
                case ConditionTable.Operation.Equal:
                  goto label_27;
                case ConditionTable.Operation.NotEqual:
                  if (equalityTypeDescriptor == null)
                  {
                    if (v1 != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 7 : 6;
                      continue;
                    }
                    goto label_12;
                  }
                  else
                  {
                    num2 = 8;
                    continue;
                  }
                case ConditionTable.Operation.More:
                  if (v1 is IComparable)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_12;
                case ConditionTable.Operation.Less:
                  if (v1 is IComparable)
                  {
                    num2 = 28;
                    continue;
                  }
                  goto label_12;
                case ConditionTable.Operation.MoreOrEqual:
                  if (!(v1 is IComparable))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 19;
                    continue;
                  }
                  goto label_72;
                case ConditionTable.Operation.LessOrEqual:
                  if (!(v1 is IComparable))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 3 : 27;
                    continue;
                  }
                  goto label_63;
                case ConditionTable.Operation.StartWith:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 1;
                  continue;
                case ConditionTable.Operation.EndWith:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 30;
                  continue;
                case ConditionTable.Operation.Contain:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 5;
                  continue;
                case ConditionTable.Operation.NotContain:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 4;
                  continue;
                case ConditionTable.Operation.EqualIC:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 24;
                  continue;
                case ConditionTable.Operation.NotEqualIC:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 10 : 13;
                  continue;
                case ConditionTable.Operation.StartWithIC:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 38;
                  continue;
                case ConditionTable.Operation.EndWithIC:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 42;
                  continue;
                case ConditionTable.Operation.ContainIC:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 29 : 29;
                  continue;
                case ConditionTable.Operation.NotContainIC:
                  this.ConvertOperandsToString(ref v1, ref v2);
                  num2 = 16;
                  continue;
                default:
                  num2 = 17;
                  continue;
              }
            case 37:
              operation = ConditionTableEvaluator.Ehr0iIbRdjTRr02nvGgK((object) el);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 35 : 27;
              continue;
            case 38:
              goto label_9;
            case 39:
              goto label_11;
            case 40:
              goto label_25;
            case 41:
              this.ConvertOperandsToString(ref v1, ref v2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 0;
              continue;
            case 42:
              goto label_39;
            default:
              if (v2 is IComparable)
              {
                num2 = 18;
                continue;
              }
              goto label_12;
          }
          if (v1 == null)
            goto label_65;
          else
            break;
        }
        num1 = 14;
      }
label_5:
      return equalityTypeDescriptor.IsValuesEquals(v1, v2);
label_9:
      return ConditionTableEvaluator.BAsIYabRL6qZVgsiKLQ7((object) (string) v1, (object) (string) v2, StringComparison.CurrentCultureIgnoreCase);
label_11:
      return ConditionTableEvaluator.tqWRQGbRUWe7TuWewwCw((object) (IComparable) v1, v2) >= 0;
label_12:
      return false;
label_13:
      return ConditionTableEvaluator.OWe4rfbRrbUWLGKNjYkX(ConditionTableEvaluator.eRRpn7bRjxf3Ndg7cZ7u((object) (string) v1), ConditionTableEvaluator.eRRpn7bRjxf3Ndg7cZ7u((object) (string) v2));
label_15:
      return ConditionTableEvaluator.OSbbXJbR5HW1A7Ow1CQp((object) (string) v1, (object) (string) v2, StringComparison.CurrentCultureIgnoreCase);
label_17:
      return ConditionTableEvaluator.i14iXAbRg2utZk10UhBo((object) (string) v1, (object) (string) v2);
label_19:
      return ConditionTableEvaluator.tqWRQGbRUWe7TuWewwCw((object) (IComparable) v1, v2) > 0;
label_22:
      return ConditionTableEvaluator.tqWRQGbRUWe7TuWewwCw((object) (IComparable) v1, v2) <= 0;
label_25:
      return !v1.Equals(v2);
label_31:
      return !ConditionTableEvaluator.OSbbXJbR5HW1A7Ow1CQp((object) (string) v1, (object) (string) v2, StringComparison.CurrentCultureIgnoreCase);
label_34:
      return !ConditionTableEvaluator.OWe4rfbRrbUWLGKNjYkX((object) (string) v1, (object) (string) v2);
label_37:
      return ((string) v1).StartsWith((string) v2);
label_39:
      return ConditionTableEvaluator.BhOrf3bRY0rMq4Kk43X4((object) (string) v1, (object) (string) v2, StringComparison.CurrentCultureIgnoreCase);
label_41:
      return ConditionTableEvaluator.OWe4rfbRrbUWLGKNjYkX((object) (string) v1, (object) (string) v2);
label_43:
      return !ConditionTableEvaluator.OWe4rfbRrbUWLGKNjYkX(ConditionTableEvaluator.eRRpn7bRjxf3Ndg7cZ7u((object) (string) v1), ConditionTableEvaluator.eRRpn7bRjxf3Ndg7cZ7u((object) (string) v2));
label_46:
      return v1.Equals(v2);
label_49:
      return ConditionTableEvaluator.tqWRQGbRUWe7TuWewwCw((object) (IComparable) v1, v2) < 0;
label_55:
      return !ConditionTableEvaluator.LFJSvjbRlLWFAceXuO36((object) equalityTypeDescriptor, v1, v2);
label_67:
      return true;
    }

    internal static bool I0ASuebRiEHcSoj3A2ku() => ConditionTableEvaluator.UYVDKqbRSb71AeweDSEo == null;

    internal static ConditionTableEvaluator Vj3rDgbRRvJb9QBxp8Wo() => ConditionTableEvaluator.UYVDKqbRSb71AeweDSEo;

    internal static void AJuBo9bRqDgGetjYFClp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static int RuYJw0bRKlvWfxnpgYB1([In] object obj0) => ((List<ConditionTable.Item>) obj0).Count;

    internal static int vAacdsbRX1gy6i69WFmN([In] object obj0) => ((List<bool>) obj0).Count;

    internal static ConditionTable.OperandType b7l706bRTu863VCqnDYb([In] object obj0) => ((ConditionTable.Operand) obj0).Type;

    internal static void c7i5XcbRk871wIRLLlbb([In] object obj0, [In] object obj1) => ((ConditionTableEvaluator.OperandValue) obj0).PropertyMetadata = (PropertyMetadata) obj1;

    internal static object vOHVEGbRnU2L6nhx2iiC([In] object obj0) => ((ConditionTable.Operand) obj0).Value;

    internal static void ia885JbROV0sFVxamGpf([In] object obj0, [In] object obj1) => ((ConditionTableEvaluator.OperandValue) obj0).Value = obj1;

    internal static object oj5qaNbR2VpAkSK0NRmG() => (object) ComponentManager.Current;

    internal static object m9CvkbbReAKPF0pFdRFk([In] object obj0) => ((ConditionTableEvaluator.OperandValue) obj0).Value;

    internal static object JjuDn5bRPfA5iTMRKUkm([In] object obj0) => (object) ((ConditionTableEvaluator.OperandValue) obj0).PropertyMetadata;

    internal static Guid qPydErbR1cg1UituwUmY([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid NBsYfUbRN7EweqDOMqbX([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object zxoXXabR3kaXDSinGsi6([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool XVDimZbRp81dDcBVrB6p([In] object obj0) => ((ITypeDescriptor) obj0).CanBeNullable;

    internal static bool rAwZvjbRamPrS6fsnD6N([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool dWTLhCbRDHdHJvOgChW6([In] object obj0, [In] Type obj1) => ((TypeConverter) obj0).CanConvertTo(obj1);

    internal static object Ii4o5lbRtdefCVYG6LFs([In] object obj0, [In] object obj1, [In] Type obj2) => ((TypeConverter) obj0).ConvertTo(obj1, obj2);

    internal static object K1RB9FbRwKPlch7UGAs7([In] object obj0, [In] object obj1, [In] object obj2) => ((IConvertableTypeDescriptor) obj0).ConvertFrom(obj1, (PropertyMetadata) obj2);

    internal static object Me2nKDbR4674ucY55CfL(Type enumType, Guid uid) => ModelHelper.GetEnumValue(enumType, uid);

    internal static float ONub5rbR6sRWi3vt8txV([In] object obj0) => Convert.ToSingle(obj0);

    internal static byte X2A67xbRHQIBkNQYFAK7([In] object obj0) => Convert.ToByte(obj0);

    internal static short RrK94HbRALYod1D5yFMa([In] object obj0) => Convert.ToInt16(obj0);

    internal static DateTime B9hyy8bR7txlmHWoag2Q([In] double obj0) => DateTime.FromOADate(obj0);

    internal static DateTime pVMRRHbRxEvcrMiyrU8r([In] object obj0) => Convert.ToDateTime(obj0);

    internal static bool p3yJGabR0vrk2xiFZKgM([In] object obj0) => Convert.ToBoolean(obj0);

    internal static object STLG7BbRm0jviJOIkUlX() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static object NPuuBJbRypa1Ucusxunk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object EDHEXIbRMKbUOGr6L98f([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object vcPjv6bRJHvIUKBL7Br3([In] object obj0) => (object) ((ConditionTable.Item) obj0).Operand1;

    internal static object cGmPjtbR9XrshY5Ws2RH([In] object obj0) => (object) ((ConditionTable.Item) obj0).Operand2;

    internal static ConditionTable.Operation Ehr0iIbRdjTRr02nvGgK([In] object obj0) => ((ConditionTable.Item) obj0).Operation;

    internal static bool LFJSvjbRlLWFAceXuO36([In] object obj0, [In] object obj1, [In] object obj2) => ((IEqualityTypeDescriptor) obj0).IsValuesEquals(obj1, obj2);

    internal static bool OWe4rfbRrbUWLGKNjYkX([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static bool i14iXAbRg2utZk10UhBo([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static bool OSbbXJbR5HW1A7Ow1CQp([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object eRRpn7bRjxf3Ndg7cZ7u([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static bool BhOrf3bRY0rMq4Kk43X4([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).EndsWith((string) obj1, obj2);

    internal static bool BAsIYabRL6qZVgsiKLQ7([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).StartsWith((string) obj1, obj2);

    internal static int tqWRQGbRUWe7TuWewwCw([In] object obj0, [In] object obj1) => ((IComparable) obj0).CompareTo(obj1);

    public class OperandValue
    {
      internal static ConditionTableEvaluator.OperandValue jR28bdC1lKWbZN8l4Q32;

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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

      public PropertyMetadata PropertyMetadata
      {
        get => this.\u003CPropertyMetadata\u003Ek__BackingField;
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
                this.\u003CPropertyMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

      public OperandValue()
      {
        ConditionTableEvaluator.OperandValue.FYsedDC15DlPNEZWmsCo();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool Ckxp9aC1rptvgpvFXxJI() => ConditionTableEvaluator.OperandValue.jR28bdC1lKWbZN8l4Q32 == null;

      internal static ConditionTableEvaluator.OperandValue EqK9FZC1gWA0leLZVFbV() => ConditionTableEvaluator.OperandValue.jR28bdC1lKWbZN8l4Q32;

      internal static void FYsedDC15DlPNEZWmsCo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
