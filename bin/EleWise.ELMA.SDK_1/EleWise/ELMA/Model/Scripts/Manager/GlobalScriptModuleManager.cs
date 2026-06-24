// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Manager.GlobalScriptModuleManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Exceptions;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Scripts.Manager
{
  /// <summary>Менеджер глобальных модулей сценариев</summary>
  public class GlobalScriptModuleManager : 
    EntityManager<IGlobalScriptModule, long>,
    IGlobalScriptModuleManager,
    IEntityManager<IGlobalScriptModule, long>,
    IEntityManager<IGlobalScriptModule>,
    IEntityManager
  {
    private static GlobalScriptModuleManager fibMPhbOEqTqvlCA9RKh;

    /// <summary>Экземпляр менеджера</summary>
    public static GlobalScriptModuleManager Instance => Locator.GetServiceNotNull<GlobalScriptModuleManager>();

    /// <summary>Средя исполнения акторов</summary>
    public IActorModelRuntime ActorModelRuntime
    {
      get => this.\u003CActorModelRuntime\u003Ek__BackingField;
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
              this.\u003CActorModelRuntime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Сервис для ручной подписки на события</summary>
    public IEventHandlerSubscribeService EventHandlerSubscribeService
    {
      get => this.\u003CEventHandlerSubscribeService\u003Ek__BackingField;
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
              this.\u003CEventHandlerSubscribeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    /// <summary>Загрузить модуль сценариев для редактирования</summary>
    /// <param name="gsmId">Идентификатор глобального модуля</param>
    /// <returns>Модуль для редактирования</returns>
    [Transaction]
    public virtual ScriptModule LoadScriptModuleForEdit(long gsmId)
    {
      int num = 2;
      IGlobalScriptModule globalScriptModule;
      ScriptModuleDTO source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (GlobalScriptModuleManager.vHChTGbOChBqYsdFnrL1((object) globalScriptModule) != null)
            {
              num = 5;
              continue;
            }
            goto label_4;
          case 2:
            globalScriptModule = this.Load(gsmId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
            continue;
          case 3:
            source.Id = 0L;
            num = 8;
            continue;
          case 4:
            source = Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule) GlobalScriptModuleManager.vHChTGbOChBqYsdFnrL1((object) globalScriptModule), new ScriptModuleDTO());
            num = 3;
            continue;
          case 5:
            if (GlobalScriptModuleManager.fwohjDbOZFQYjqiTby8k(GlobalScriptModuleManager.vHChTGbOChBqYsdFnrL1((object) globalScriptModule)) == null)
            {
              num = 4;
              continue;
            }
            goto label_11;
          case 6:
            GlobalScriptModuleManager.NJQ8mtbOIyFrcTPaHRTy((object) globalScriptModule.ScriptModule.Draft);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_4;
          case 8:
            GlobalScriptModuleManager.usCacubOufJnMWgsD5iZ((object) globalScriptModule.ScriptModule, (object) Mapper.Map<ScriptModuleDTO, ScriptModule>(source, new ScriptModule()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 6 : 6;
            continue;
          default:
            goto label_11;
        }
      }
label_4:
      throw new InvalidOperationException((string) GlobalScriptModuleManager.EFfoiXbO85OWPEnDGX2A(GlobalScriptModuleManager.AAJhvQbOvuFr4gAm2KCw(-1598106783 - -968262081 ^ -629694966), (object) gsmId));
label_11:
      return ((ScriptModule) GlobalScriptModuleManager.vHChTGbOChBqYsdFnrL1((object) globalScriptModule)).Draft;
    }

    public virtual void Publish(IGlobalScriptModule gsm)
    {
      int num = 3;
      TaskAwaiter awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            awaiter.GetResult();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 3:
            awaiter = this.PublishAsync(gsm).GetAwaiter();
            num = 2;
            continue;
          default:
            GlobalScriptModuleManager.KDDiM2bOVVcCkBrRYEa6((object) gsm);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    public virtual void Validate(IGlobalScriptModule gsm)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            GlobalScriptModuleManager.viLn1gbOSj5v78ey7jWV((object) gsm, GlobalScriptModuleManager.AAJhvQbOvuFr4gAm2KCw(-441065788 ^ -2092910478 ^ 1727505650));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.GenerateAssembly(gsm);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    public virtual void DeleteDirectory(string directoryPath)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        string[] directories;
        string[] strArray;
        int index;
        string str;
        string path;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_26;
            case 2:
            case 3:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 4;
                continue;
              }
              goto case 14;
            case 4:
            case 12:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 6 : 13;
                continue;
              }
              goto case 8;
            case 5:
              goto label_3;
            case 6:
              goto label_7;
            case 7:
              goto label_6;
            case 8:
              str = strArray[index];
              num2 = 6;
              continue;
            case 9:
label_12:
              ++index;
              num2 = 2;
              continue;
            case 10:
              index = 0;
              num2 = 12;
              continue;
            case 11:
              ++index;
              num2 = 4;
              continue;
            case 13:
              Directory.Delete(directoryPath, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            case 14:
              path = strArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            case 15:
              object obj = GlobalScriptModuleManager.GHLOqybORjZEWVFbUbVF((object) directoryPath);
              directories = Directory.GetDirectories(directoryPath);
              strArray = (string[]) obj;
              num2 = 7;
              continue;
            case 16:
              goto label_10;
            default:
              try
              {
                GlobalScriptModuleManager.GsElgubOiCf6JuHWJU4q((object) path, FileAttributes.Normal);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      File.Delete(path);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_12;
                  }
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_12;
                }
              }
          }
        }
label_3:
        strArray = directories;
        num1 = 10;
        continue;
label_6:
        index = 0;
        num1 = 3;
        continue;
label_7:
        GlobalScriptModuleManager.cPbEHDbOqv8seK9EILZu((object) this, (object) str);
        num1 = 11;
        continue;
label_10:
        GlobalScriptModuleManager.GsElgubOiCf6JuHWJU4q((object) directoryPath, FileAttributes.Normal);
        num1 = 15;
      }
label_26:;
    }

    /// <inheritdoc />
    public virtual void GenerateGlobalScriptModuleAssembly(IGlobalScriptModule globalScriptModule)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        ScriptModule assembly;
        // ISSUE: variable of a compiler-generated type
        GlobalScriptModuleManager.\u003C\u003Ec__DisplayClass14_0 cDisplayClass140;
        AssemblyModelsMetadata assemblyModelsMetadata1;
        MemoryStream memoryStream1;
        MemoryStream memoryStream2;
        AssemblyModelsMetadata assemblyModelsMetadata2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              memoryStream2.Seek(0L, SeekOrigin.Begin);
              num2 = 16;
              continue;
            case 2:
              memoryStream2 = (MemoryStream) GlobalScriptModuleManager.U3CPtlbOtnUKBFWXZEdg(assembly.DebugRaw.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            case 3:
            case 4:
              if (GlobalScriptModuleManager.OGS10BbOHuW2Gs7Foam4((object) assembly) == null)
              {
                num2 = 12;
                continue;
              }
              goto case 2;
            case 5:
              if (GlobalScriptModuleManager.X81WVHbODDR44NBVUGmn((object) assembly) == null)
              {
                num2 = 3;
                continue;
              }
              goto case 10;
            case 6:
              goto label_20;
            case 7:
              // ISSUE: reference to a compiler-generated field
              assembly = this.GenerateAssembly(cDisplayClass140.globalScriptModule);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 9;
              continue;
            case 8:
            case 12:
              GlobalScriptModuleManager.z9CC9dbO7TD9RqiDAEfn((object) this.Session, (object) assemblyModelsMetadata1);
              num2 = 6;
              continue;
            case 9:
              goto label_9;
            case 10:
              memoryStream1 = (MemoryStream) GlobalScriptModuleManager.U3CPtlbOtnUKBFWXZEdg(GlobalScriptModuleManager.X81WVHbODDR44NBVUGmn((object) assembly).Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 8 : 19;
              continue;
            case 11:
              IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> queryOver = this.Session.QueryOver<AssemblyModelsMetadata>();
              ParameterExpression parameterExpression = (ParameterExpression) GlobalScriptModuleManager.igBAPXbOKccqlLK9pp70(typeof (AssemblyModelsMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886468603));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: type reference
              Expression<Func<AssemblyModelsMetadata, bool>> expression = Expression.Lambda<Func<AssemblyModelsMetadata, bool>>((Expression) GlobalScriptModuleManager.XsTRpEbO12eZ5O9WJCUm((object) Expression.Equal((Expression) GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy((object) parameterExpression, (object) (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (AssemblyModelsMetadata.get_Name))), (Expression) GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy(GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy(GlobalScriptModuleManager.m3BlxjbOOJYkuI20SkI5((object) Expression.Constant((object) cDisplayClass140, GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (GlobalScriptModuleManager.\u003C\u003Ec__DisplayClass14_0))), GlobalScriptModuleManager.eE7ADYbOnZu5cVri3fYh(__fieldref (GlobalScriptModuleManager.\u003C\u003Ec__DisplayClass14_0.globalScriptModule))), (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IGlobalScriptModule.get_Header))), (object) (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (IGlobalScriptModuleHeader.get_Namespace)))), GlobalScriptModuleManager.c38j6YbOPgVOQA5epev0(GlobalScriptModuleManager.FpCxnibO2bLlMhLGDBZV(GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy((object) parameterExpression, (object) (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (AssemblyModelsMetadata.get_Status))), GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (int))), GlobalScriptModuleManager.Mk7TMGbOeAYKjMxqvBnB((object) 4, GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (int))))), parameterExpression);
              assemblyModelsMetadata2 = queryOver.Where(expression).List().FirstOrDefault<AssemblyModelsMetadata>();
              if (assemblyModelsMetadata2 == null)
              {
                num2 = 18;
                continue;
              }
              goto label_26;
            case 13:
              GlobalScriptModuleManager.IcexdGbO6TuNSWV7eSPv((object) assemblyModelsMetadata1, (object) memoryStream1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 3 : 4;
              continue;
            case 14:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass140.globalScriptModule = globalScriptModule;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 7 : 3;
              continue;
            case 15:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass140 = new GlobalScriptModuleManager.\u003C\u003Ec__DisplayClass14_0();
              num2 = 14;
              continue;
            case 16:
              goto label_17;
            case 17:
              GlobalScriptModuleManager.rJZcxKbO4Vdd3kn502GV((object) memoryStream1, 0L, SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 12 : 13;
              continue;
            case 18:
              goto label_25;
            case 19:
              GlobalScriptModuleManager.kFHQKlbOwC06XPFVXIqF((object) memoryStream1, GlobalScriptModuleManager.X81WVHbODDR44NBVUGmn((object) assembly), 0, assembly.AssemblyRaw.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 17 : 5;
              continue;
            default:
              GlobalScriptModuleManager.kFHQKlbOwC06XPFVXIqF((object) memoryStream2, GlobalScriptModuleManager.OGS10BbOHuW2Gs7Foam4((object) assembly), 0, assembly.DebugRaw.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
              continue;
          }
        }
label_9:
        if (assembly != null)
        {
          num1 = 11;
          continue;
        }
        goto label_15;
label_17:
        GlobalScriptModuleManager.Thb36ybOA9Ldoe9grl6X((object) assemblyModelsMetadata1, (object) memoryStream2);
        num1 = 8;
        continue;
label_25:
        AssemblyModelsMetadata assemblyModelsMetadata3 = new AssemblyModelsMetadata();
        // ISSUE: reference to a compiler-generated field
        GlobalScriptModuleManager.HOXUE6bOpT45YxlGk0NY((object) assemblyModelsMetadata3, GlobalScriptModuleManager.ujbNVabO3sBelSgYlS07(GlobalScriptModuleManager.UIM6dfbON4WLPxAKLObO((object) cDisplayClass140.globalScriptModule)));
        GlobalScriptModuleManager.wUP5hrbOa8dihCK1Jn5d((object) assemblyModelsMetadata3, AssemblyModelsMetadataStatus.GlobalModule);
        assemblyModelsMetadata2 = assemblyModelsMetadata3;
label_26:
        assemblyModelsMetadata1 = assemblyModelsMetadata2;
        num1 = 5;
      }
label_20:
      return;
label_15:;
    }

    public override ExportRuleList ExportRules()
    {
      int num = 5;
      ExportRuleList exportRuleList1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExportRuleList exportRuleList2 = exportRuleList1;
            ExportRule exportRule1 = new ExportRule();
            exportRule1.ParentType = type;
            ExportRule exportRule2 = exportRule1;
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) GlobalScriptModuleManager.igBAPXbOKccqlLK9pp70(GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (IGlobalScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576189680));
            // ISSUE: method reference
            // ISSUE: type reference
            string str1 = LinqUtils.NameOf<IGlobalScriptModule>(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression) GlobalScriptModuleManager.FpCxnibO2bLlMhLGDBZV(GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy((object) parameterExpression1, (object) (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (IGlobalScriptModule.get_Uid))), GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (object))), parameterExpression1));
            exportRule2.PropertyName = str1;
            exportRule1.ExportRuleType = ExportRuleType.Export;
            ExportRule exportRule3 = exportRule1;
            exportRuleList2.Add(exportRule3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            ExportRuleList exportRuleList3 = exportRuleList1;
            ExportRule exportRule4 = new ExportRule();
            GlobalScriptModuleManager.ogBO1vbO09gkndOG3Db1((object) exportRule4, type);
            ExportRule exportRule5 = exportRule4;
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) GlobalScriptModuleManager.igBAPXbOKccqlLK9pp70(GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (IGlobalScriptModule)), GlobalScriptModuleManager.AAJhvQbOvuFr4gAm2KCw(~-122002947 ^ 121975478));
            // ISSUE: method reference
            string str2 = LinqUtils.NameOf<IGlobalScriptModule>(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression) GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy((object) parameterExpression2, (object) (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (IGlobalScriptModule.get_Items))), parameterExpression2));
            exportRule5.PropertyName = str2;
            GlobalScriptModuleManager.wfZ3BLbOyS1rTRYAQSiS((object) exportRule4, ExportRuleType.Export);
            ExportRule exportRule6 = exportRule4;
            exportRuleList3.Add(exportRule6);
            num = 6;
            continue;
          case 3:
            ExportRuleList exportRuleList4 = exportRuleList1;
            ExportRule exportRule7 = new ExportRule();
            GlobalScriptModuleManager.ogBO1vbO09gkndOG3Db1((object) exportRule7, type);
            ExportRule exportRule8 = exportRule7;
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) GlobalScriptModuleManager.igBAPXbOKccqlLK9pp70(GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (IGlobalScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154123873));
            // ISSUE: method reference
            string str3 = LinqUtils.NameOf<IGlobalScriptModule>(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (IGlobalScriptModule.get_Header))), parameterExpression3));
            GlobalScriptModuleManager.PM9ZRObOm6vp1fDxekqE((object) exportRule8, (object) str3);
            GlobalScriptModuleManager.wfZ3BLbOyS1rTRYAQSiS((object) exportRule7, ExportRuleType.Export);
            ExportRule exportRule9 = exportRule7;
            exportRuleList4.Add(exportRule9);
            num = 2;
            continue;
          case 4:
            exportRuleList1 = new ExportRuleList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 3;
            continue;
          case 5:
            type = GlobalScriptModuleManager.fWqTisbOxD6gVaM63tSL((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 4 : 1;
            continue;
          case 6:
            ExportRuleList exportRuleList5 = exportRuleList1;
            ExportRule exportRule10 = new ExportRule();
            exportRule10.ParentType = type;
            ExportRule exportRule11 = exportRule10;
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) GlobalScriptModuleManager.igBAPXbOKccqlLK9pp70(GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (IGlobalScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426117747));
            // ISSUE: method reference
            string str4 = LinqUtils.NameOf<IGlobalScriptModule>(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (IGlobalScriptModule.get_ProjectFile))), parameterExpression4));
            GlobalScriptModuleManager.PM9ZRObOm6vp1fDxekqE((object) exportRule11, (object) str4);
            GlobalScriptModuleManager.wfZ3BLbOyS1rTRYAQSiS((object) exportRule10, ExportRuleType.Export);
            ExportRule exportRule12 = exportRule10;
            exportRuleList5.Add(exportRule12);
            num = 7;
            continue;
          case 7:
            ExportRuleList exportRuleList6 = exportRuleList1;
            ExportRule exportRule13 = new ExportRule();
            GlobalScriptModuleManager.ogBO1vbO09gkndOG3Db1((object) exportRule13, type);
            ExportRule exportRule14 = exportRule13;
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) GlobalScriptModuleManager.igBAPXbOKccqlLK9pp70(GlobalScriptModuleManager.UHapWmbOk8vdYOKVIdl5(__typeref (IGlobalScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822930260));
            // ISSUE: method reference
            string str5 = LinqUtils.NameOf<IGlobalScriptModule>(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression) GlobalScriptModuleManager.dTg1C2bOTk4u9I5YU1xy((object) parameterExpression5, (object) (MethodInfo) GlobalScriptModuleManager.wKSwB0bOX4mfdLPRMltR(__methodref (IGlobalScriptModule.get_ScriptModule))), parameterExpression5));
            GlobalScriptModuleManager.PM9ZRObOm6vp1fDxekqE((object) exportRule14, (object) str5);
            GlobalScriptModuleManager.wfZ3BLbOyS1rTRYAQSiS((object) exportRule13, ExportRuleType.Export);
            ExportRule exportRule15 = exportRule13;
            exportRuleList6.Add(exportRule15);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return exportRuleList1;
    }

    protected ScriptModule GenerateAssembly(IGlobalScriptModule gsm)
    {
      int num1 = 5;
      ScriptModule module;
      ScriptCompileResult scriptCompileResult;
      while (true)
      {
        int num2 = num1;
        GlobalScriptModuleCompiler scriptModuleCompiler;
        byte[] numArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              scriptCompileResult = (ScriptCompileResult) GlobalScriptModuleManager.xjod79bOJ9NqRthVDoPY((object) scriptModuleCompiler);
              num2 = 9;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_14;
            case 4:
              if (module != null)
              {
                if (!(GlobalScriptModuleManager.K1QNWvbOMLVEemVZQkQb((object) gsm) is ProjectInfo))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 2;
                  continue;
                }
                goto case 11;
              }
              else
                goto label_18;
            case 5:
              module = (ScriptModule) GlobalScriptModuleManager.vHChTGbOChBqYsdFnrL1((object) gsm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 4;
              continue;
            case 6:
              goto label_4;
            case 7:
              GlobalScriptModuleManager.DvadwlbOg5k3fJKIiULJ((object) module, GlobalScriptModuleManager.WKRlOebOrBwnDriMoSAT((object) scriptModuleCompiler));
              num2 = 6;
              continue;
            case 8:
              goto label_7;
            case 9:
              if (GlobalScriptModuleManager.y0ghrobO9EQ68EIMh3Rt((object) scriptCompileResult))
              {
                num2 = 10;
                continue;
              }
              goto label_14;
            case 10:
              numArray = (byte[]) GlobalScriptModuleManager.kbGeKZbOdyjsgoo6IuQy((object) scriptModuleCompiler);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 11:
              scriptModuleCompiler = new GlobalScriptModuleCompiler(module, gsm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            default:
              GlobalScriptModuleManager.SXjVBXbOlKhLnMEU2Nm9((object) module, (object) numArray);
              num2 = 7;
              continue;
          }
        }
label_18:
        num1 = 8;
      }
label_4:
      return module;
label_5:
      return (ScriptModule) null;
label_7:
      return (ScriptModule) null;
label_14:
      throw new GlobalScriptModulePublishingException(gsm.Id, scriptCompileResult);
    }

    /// <summary>Опубликовать глобальный модуль сценариев</summary>
    /// <param name="globalScriptModule">Глобальный модуль сценариев</param>
    private Task PublishAsync(IGlobalScriptModule globalScriptModule)
    {
      int num1 = 1;
      // ISSUE: variable of a compiler-generated type
      GlobalScriptModuleManager.\u003CPublishAsync\u003Ed__17 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = GlobalScriptModuleManager.KkHgM6bO5lQlWwKFiXrm();
              num2 = 4;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_4;
            case 5:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 6 : 1;
              continue;
            case 6:
              tBuilder.Start<GlobalScriptModuleManager.\u003CPublishAsync\u003Ed__17>(ref stateMachine);
              num2 = 3;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.globalScriptModule = globalScriptModule;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E1__state = -1;
        num1 = 5;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    public GlobalScriptModuleManager()
    {
      GlobalScriptModuleManager.wCk8P5bOjcJpu5JDE6Lh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mGWV6cbOfm7C7xAtD4q0() => GlobalScriptModuleManager.fibMPhbOEqTqvlCA9RKh == null;

    internal static GlobalScriptModuleManager YkMpHPbOQaxXRUun8NBm() => GlobalScriptModuleManager.fibMPhbOEqTqvlCA9RKh;

    internal static object vHChTGbOChBqYsdFnrL1([In] object obj0) => (object) ((IGlobalScriptModule) obj0).ScriptModule;

    internal static object AAJhvQbOvuFr4gAm2KCw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object EFfoiXbO85OWPEnDGX2A([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object fwohjDbOZFQYjqiTby8k([In] object obj0) => (object) ((ScriptModule) obj0).Draft;

    internal static void usCacubOufJnMWgsD5iZ([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).Draft = (ScriptModule) obj1;

    internal static void NJQ8mtbOIyFrcTPaHRTy([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static void KDDiM2bOVVcCkBrRYEa6([In] object obj0) => ((IEntity) obj0).Refresh();

    internal static void viLn1gbOSj5v78ey7jWV([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void GsElgubOiCf6JuHWJU4q([In] object obj0, [In] FileAttributes obj1) => File.SetAttributes((string) obj0, obj1);

    internal static object GHLOqybORjZEWVFbUbVF([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static void cPbEHDbOqv8seK9EILZu([In] object obj0, [In] object obj1) => ((GlobalScriptModuleManager) obj0).DeleteDirectory((string) obj1);

    internal static object igBAPXbOKccqlLK9pp70([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object wKSwB0bOX4mfdLPRMltR([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object dTg1C2bOTk4u9I5YU1xy([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Type UHapWmbOk8vdYOKVIdl5([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object eE7ADYbOnZu5cVri3fYh([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object m3BlxjbOOJYkuI20SkI5([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object FpCxnibO2bLlMhLGDBZV([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object Mk7TMGbOeAYKjMxqvBnB([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object c38j6YbOPgVOQA5epev0([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object XsTRpEbO12eZ5O9WJCUm([In] object obj0, [In] object obj1) => (object) Expression.AndAlso((Expression) obj0, (Expression) obj1);

    internal static object UIM6dfbON4WLPxAKLObO([In] object obj0) => (object) ((IGlobalScriptModule) obj0).Header;

    internal static object ujbNVabO3sBelSgYlS07([In] object obj0) => (object) ((IGlobalScriptModuleHeader) obj0).Namespace;

    internal static void HOXUE6bOpT45YxlGk0NY([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).Name = (string) obj1;

    internal static void wUP5hrbOa8dihCK1Jn5d([In] object obj0, AssemblyModelsMetadataStatus value) => ((AssemblyModelsMetadata) obj0).Status = value;

    internal static object X81WVHbODDR44NBVUGmn([In] object obj0) => (object) ((ScriptModule) obj0).AssemblyRaw;

    internal static object U3CPtlbOtnUKBFWXZEdg(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static void kFHQKlbOwC06XPFVXIqF([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static long rJZcxKbO4Vdd3kn502GV([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void IcexdGbO6TuNSWV7eSPv([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).AssemblyRawStream = (MemoryStream) obj1;

    internal static object OGS10BbOHuW2Gs7Foam4([In] object obj0) => (object) ((ScriptModule) obj0).DebugRaw;

    internal static void Thb36ybOA9Ldoe9grl6X([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).DebugRawStream = (MemoryStream) obj1;

    internal static object z9CC9dbO7TD9RqiDAEfn([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static Type fWqTisbOxD6gVaM63tSL([In] object obj0) => ((EntityManager<IGlobalScriptModule, long>) obj0).ImplementationType;

    internal static void ogBO1vbO09gkndOG3Db1([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static void PM9ZRObOm6vp1fDxekqE([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void wfZ3BLbOyS1rTRYAQSiS([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static object K1QNWvbOMLVEemVZQkQb([In] object obj0) => ((IGlobalScriptModule) obj0).Items;

    internal static object xjod79bOJ9NqRthVDoPY([In] object obj0) => (object) ((ScriptCompiler) obj0).Compile();

    internal static bool y0ghrobO9EQ68EIMh3Rt([In] object obj0) => ((ScriptCompileResult) obj0).Success;

    internal static object kbGeKZbOdyjsgoo6IuQy([In] object obj0) => (object) ((AssemblyBuilder) obj0).AssemblyRaw;

    internal static void SXjVBXbOlKhLnMEU2Nm9([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyRaw = (byte[]) obj1;

    internal static object WKRlOebOrBwnDriMoSAT([In] object obj0) => (object) ((AssemblyBuilder) obj0).DebugRaw;

    internal static void DvadwlbOg5k3fJKIiULJ([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).DebugRaw = (byte[]) obj1;

    internal static AsyncTaskMethodBuilder KkHgM6bO5lQlWwKFiXrm() => AsyncTaskMethodBuilder.Create();

    internal static void wCk8P5bOjcJpu5JDE6Lh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Событие публикации глобального модуля</summary>
    private sealed class GlobalScriptModulePublicationEventHandler : 
      IGlobalScriptModulePublicationEventHandler,
      IEventHandler
    {
      private readonly object actor;
      private readonly long scriptModuleId;
      private readonly TaskCompletionSource<bool> taskCompletionSource;
      private static object uTWTT5C3JY7sDgsV3o5I;

      /// <summary>Ctor</summary>
      /// <param name="actor">Актор публикации глобального модуля</param>
      /// <param name="scriptModuleId">Идентификатор глобального модуля скриптов</param>
      public GlobalScriptModulePublicationEventHandler(
        IGlobalScriptModulePublicationActor actor,
        long scriptModuleId)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.scriptModuleId = scriptModuleId;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            case 2:
              this.actor = (object) actor;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      /// <inheritdoc />
      public Task Complete(long globalScriptModuleId)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.scriptModuleId != globalScriptModuleId)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
                continue;
              }
              this.taskCompletionSource.TrySetResult(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return (Task) GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler.zCn6PPC3rfyHU3iAuHOl(this.actor);
label_5:
        return (Task) GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler.SxLPOHC3lb2Vw1CnJRRf();
      }

      /// <inheritdoc />
      public Task Error(long globalScriptModuleId, Exception exception)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.scriptModuleId == globalScriptModuleId)
              {
                this.taskCompletionSource.TrySetException(exception);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (Task) GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler.zCn6PPC3rfyHU3iAuHOl(this.actor);
label_3:
        return Task.CompletedTask;
      }

      /// <summary>Задача ожидания окончания публикации</summary>
      public Task Wait => (Task) this.taskCompletionSource.Task;

      internal static bool RaevohC39oVKbdDQWEnu() => GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler.uTWTT5C3JY7sDgsV3o5I == null;

      internal static GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler X0pUUPC3d5ckhYpGVMQd() => (GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler) GlobalScriptModuleManager.GlobalScriptModulePublicationEventHandler.uTWTT5C3JY7sDgsV3o5I;

      internal static object SxLPOHC3lb2Vw1CnJRRf() => (object) Task.CompletedTask;

      internal static object zCn6PPC3rfyHU3iAuHOl([In] object obj0) => (object) ((IGlobalScriptModulePublicationActor) obj0).PublicationComplete();
    }
  }
}
