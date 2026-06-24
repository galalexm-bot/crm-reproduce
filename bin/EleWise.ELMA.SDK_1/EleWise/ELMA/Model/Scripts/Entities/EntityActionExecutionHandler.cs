// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityActionExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Выполнение действия для сущностей</summary>
  internal sealed class EntityActionExecutionHandler : AbstractActionExecutionHandler
  {
    private static readonly Func<string, Type> getTypeFunc;
    private readonly IMetadataRuntimeService metadataRuntimeService;
    internal static EntityActionExecutionHandler JjgnDlb2NW2FUlXDk3mV;

    /// <summary>Ctor</summary>
    /// <param name="executionScopeFactory">Фабрика для создания контекста выполнения</param>
    /// <param name="metadataRuntimeService">Сервис управления метаданными в режиме Runtime</param>
    public EntityActionExecutionHandler(
      IExecutionScopeFactory executionScopeFactory,
      IMetadataRuntimeService metadataRuntimeService)
    {
      EntityActionExecutionHandler.QoNhwNb2ahlTWflbYtWK();
      // ISSUE: explicit constructor call
      base.\u002Ector(executionScopeFactory);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool Check(ActionExecutionParams parameters) => EntityActionExecutionHandler.u4hP9Zb2tYXvYNwxCJZt(EntityActionExecutionHandler.vEqYr1b2D7lRqCPJLtrX((object) parameters), EntityMetadata.UID);

    /// <inheritdoc />
    public override ActionExecutionResult Execute(ActionExecutionParams parameters)
    {
      int num1 = 5;
      ScriptMethodInfo scriptMethodInfo;
      string str1;
      ClassMetadata classMetadata;
      string str2;
      Guid instanceUid;
      Guid guid;
      Type executorType;
      while (true)
      {
        switch (num1)
        {
          case 1:
            scriptMethodInfo = (ScriptMethodInfo) EntityActionExecutionHandler.H9Nq7Db247CI7qUO2uk8((object) parameters.ScriptName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 7 : 2;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_10;
          case 4:
            if (!EntityActionExecutionHandler.u4hP9Zb2tYXvYNwxCJZt(instanceUid, Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 5:
            instanceUid = parameters.InstanceUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 4 : 2;
            continue;
          case 6:
            goto label_9;
          case 7:
            guid = EntityActionExecutionHandler.lkhEH5b26YgpQ3sa0nmO((object) scriptMethodInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 10 : 7;
            continue;
          case 8:
            if (!EntityActionExecutionHandler.MUxpx0b20slhZaFFd0V8(executorType, (Type) null))
            {
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 2;
            continue;
          case 9:
            goto label_2;
          case 10:
            Type typeByUid = this.metadataRuntimeService.GetTypeByUid(!EntityActionExecutionHandler.kkbP9qb2HHOP5MIm1lKk(guid, Guid.Empty) ? instanceUid : guid);
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(typeByUid);
            str1 = (string) EntityActionExecutionHandler.SEdXehb2AkMsRqFev4o5((object) scriptMethodInfo);
            executorType = EntityActionExecutionHandler.IJguT2b27FZnel27ePkf(typeByUid, (object) str1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          default:
            str2 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867331345), (object) str1, EntityActionExecutionHandler.vwy3Rdb2xSge3OF256dN((object) classMetadata));
            num1 = 8;
            continue;
        }
      }
label_2:
      throw new Exception(EleWise.ELMA.SR.T((string) EntityActionExecutionHandler.fu6UsKb2wijR0GmhmuwS(-542721635 ^ -542874109)));
label_6:
      throw new Exception((string) EntityActionExecutionHandler.jHQQYdb2yAIlVjcmLwNQ((object) str2, EntityActionExecutionHandler.k1VDBMb2mkbyiyk623Jf(EntityActionExecutionHandler.fu6UsKb2wijR0GmhmuwS(-630932142 - 1120244082 ^ -1751266336))));
label_9:
      ActionExecutionResult actionExecutionResult;
      return actionExecutionResult;
label_10:
      try
      {
        actionExecutionResult = this.Execute(executorType, parameters);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_9;
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              EntityActionExecutionHandler.WLhSnGb2MafdWpeLUybA((object) EleWise.ELMA.Logging.Logger.Log, (object) str2, (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_17;
          }
        }
label_17:
        throw;
      }
    }

    private static Type GetExecutorType(Type entityType, object scriptName)
    {
      int num1 = 6;
      ClassMetadata classMetadata;
      Type type;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              entityType = entityType.BaseType;
              num2 = 8;
              continue;
            case 2:
              type = EntityActionExecutionHandler.getTypeFunc((string) EntityActionExecutionHandler.yHthNMb2JcLoImS548kE((object) classMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 4:
              if (string.IsNullOrEmpty((string) EntityActionExecutionHandler.yHthNMb2JcLoImS548kE((object) classMetadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 3 : 3;
                continue;
              }
              goto case 2;
            case 5:
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityType);
              num2 = 4;
              continue;
            case 6:
            case 8:
              if (!EntityActionExecutionHandler.PVhrd3b2rMIpoTeAstja(entityType, (Type) null))
              {
                num2 = 11;
                continue;
              }
              goto case 5;
            case 7:
              goto label_16;
            case 9:
              goto label_3;
            case 10:
              if (!EntityActionExecutionHandler.kodXj7b2dmTZQEoSr5jH(EntityActionExecutionHandler.bEDuKKb29cntIqWO7I2i(type, scriptName), (object) null))
              {
                EntityActionExecutionHandler.tXxiD8b2lTisqXB3HjKM(type, scriptName);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                continue;
              }
              goto label_5;
            case 11:
              goto label_8;
            default:
              if (!EntityActionExecutionHandler.MUxpx0b20slhZaFFd0V8(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 10 : 9;
                continue;
              }
              goto label_3;
          }
        }
label_5:
        num1 = 7;
      }
label_3:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606744242), EntityActionExecutionHandler.yHthNMb2JcLoImS548kE((object) classMetadata)));
label_8:
      return (Type) null;
label_16:
      return type;
    }

    private static Type GetType(object scriptModuleTypeName)
    {
      int num1 = 3;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            if (num2 > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            num2 = EntityActionExecutionHandler.LeWh8Zb2gN7BBUBeCnJO(scriptModuleTypeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867211419), StringComparison.CurrentCulture);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ReflectionType.GetType((string) scriptModuleTypeName);
label_5:
      Type type;
      try
      {
        int num3;
        if (!((string) EntityActionExecutionHandler.XfHdVFb2jb4m96sZSLYT((object) new AssemblyName((string) EntityActionExecutionHandler.xaGrCHb25jkW8fOZbL6F(scriptModuleTypeName, num2 + 1))) == (string) EntityActionExecutionHandler.fu6UsKb2wijR0GmhmuwS(-675505729 ^ -675523783)))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
        else
          goto label_8;
label_7:
        switch (num3)
        {
          case 1:
            break;
          case 3:
            goto label_4;
          default:
            goto label_3;
        }
label_8:
        type = EntityActionExecutionHandler.wmHV9Wb2UrcvTrVgaagr(EntityActionExecutionHandler.olJyDib2Yafq4JCbwgpP(EntityActionExecutionHandler.fu6UsKb2wijR0GmhmuwS(964881585 - -1459193222 ^ -1870874447), false), EntityActionExecutionHandler.RNaPEFb2LiFeaw8ntthi(scriptModuleTypeName, num2));
        num3 = 3;
        goto label_7;
      }
      catch
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
            goto label_3;
        }
      }
label_4:
      return type;
    }

    static EntityActionExecutionHandler()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              // ISSUE: method reference
              EntityActionExecutionHandler.getTypeFunc = MetadataLoader.UseCachingForFunc<string, Type>(Expression.Lambda<Func<string, Type>>((Expression) EntityActionExecutionHandler.psLQcpbeFM8s31qvd0iP((object) null, (object) (MethodInfo) EntityActionExecutionHandler.dhk9oZb2zFABW9CpTFBE(__methodref (EntityActionExecutionHandler.GetType)), (object) new Expression[1]
              {
                (Expression) parameterExpression
              }), parameterExpression));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) EntityActionExecutionHandler.AuVff4b2c4j5Dq1T4OyO(EntityActionExecutionHandler.j8wGg0b2sklwQdiijqSG(__typeref (string)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867713494));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_7;
          }
        }
label_6:
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        num1 = 2;
      }
label_3:
      return;
label_7:;
    }

    internal static void QoNhwNb2ahlTWflbYtWK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TryB6Eb23WtXjYXV26lT() => EntityActionExecutionHandler.JjgnDlb2NW2FUlXDk3mV == null;

    internal static EntityActionExecutionHandler Jrk34Xb2pgn0shBIuE5E() => EntityActionExecutionHandler.JjgnDlb2NW2FUlXDk3mV;

    internal static Guid vEqYr1b2D7lRqCPJLtrX([In] object obj0) => ((ActionExecutionParams) obj0).TypeUid;

    internal static bool u4hP9Zb2tYXvYNwxCJZt([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object fu6UsKb2wijR0GmhmuwS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object H9Nq7Db247CI7qUO2uk8([In] object obj0) => (object) ScriptMethodInfoHelper.Deserialize((string) obj0);

    internal static Guid lkhEH5b26YgpQ3sa0nmO([In] object obj0) => ((ScriptMethodInfo) obj0).MetadataUid;

    internal static bool kkbP9qb2HHOP5MIm1lKk([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object SEdXehb2AkMsRqFev4o5([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static Type IJguT2b27FZnel27ePkf(Type entityType, [In] object obj1) => EntityActionExecutionHandler.GetExecutorType(entityType, obj1);

    internal static object vwy3Rdb2xSge3OF256dN([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool MUxpx0b20slhZaFFd0V8([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object k1VDBMb2mkbyiyk623Jf([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object jHQQYdb2yAIlVjcmLwNQ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void WLhSnGb2MafdWpeLUybA([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object yHthNMb2JcLoImS548kE([In] object obj0) => (object) ((ClassMetadata) obj0).ScriptModuleTypeName;

    internal static object bEDuKKb29cntIqWO7I2i(Type type, [In] object obj1) => (object) ScriptHelper.GetMethodInfo(type, (string) obj1);

    internal static bool kodXj7b2dmTZQEoSr5jH([In] object obj0, [In] object obj1) => (MethodInfo) obj0 != (MethodInfo) obj1;

    internal static void tXxiD8b2lTisqXB3HjKM(Type type, [In] object obj1) => ScriptExecutionService.MethodNotFound(type, (string) obj1);

    internal static bool PVhrd3b2rMIpoTeAstja([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static int LeWh8Zb2gN7BBUBeCnJO([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static object xaGrCHb25jkW8fOZbL6F([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object XfHdVFb2jb4m96sZSLYT([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static object olJyDib2Yafq4JCbwgpP([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object RNaPEFb2LiFeaw8ntthi([In] object obj0, [In] int obj1) => (object) ((string) obj0).Remove(obj1);

    internal static Type wmHV9Wb2UrcvTrVgaagr([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static Type j8wGg0b2sklwQdiijqSG([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object AuVff4b2c4j5Dq1T4OyO([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object dhk9oZb2zFABW9CpTFBE([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object psLQcpbeFM8s31qvd0iP([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);
  }
}
