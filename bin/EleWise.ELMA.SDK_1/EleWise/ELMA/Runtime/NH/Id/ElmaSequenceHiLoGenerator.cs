// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Id.ElmaSequenceHiLoGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Mapping.ByCode;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.Id
{
  /// <summary>Sequence Hi Lo Generator</summary>
  public class ElmaSequenceHiLoGenerator : SequenceGenerator
  {
    private IIdentifierGenerator idGenerator;
    private int maxLo;
    private int lo;
    private long hi;
    private System.Type returnClass;
    private readonly AsyncLock asyncLock;
    /// <summary>
    /// Параметр для задания типа внутренней имплементации генератора
    /// </summary>
    public const string IdGeneratorTypeParam = "id_gen_type";
    /// <summary>Параметр для задания имени последовательности</summary>
    public new const string Sequence = "sequence";
    /// <summary>Параметр для максимального значения Lo части</summary>
    public const string MaxLo = "max_lo";
    private static IGeneratorDef generatorDef;
    private static ElmaSequenceHiLoGenerator ifgovHWyPhFmQdEFvvJT;

    /// <inheritdoc />
    public override async Task<object> GenerateAsync(
      ISessionImplementor session,
      object obj,
      CancellationToken cancellationToken)
    {
      int num1 = 2;
      object result1;
      int num2;
      ElmaSequenceHiLoGenerator sequenceHiLoGenerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            sequenceHiLoGenerator1 = this;
            num1 = 5;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_91;
          case 4:
label_92:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 9 : 4;
              else
                goto label_12;
label_7:
              IDisposable disposable;
              while (true)
              {
                ConfiguredTaskAwaitable<IDisposable>.ConfiguredTaskAwaiter configuredTaskAwaiter;
                ConfiguredTaskAwaitable<IDisposable>.ConfiguredTaskAwaiter awaiter;
                IDisposable result2;
                ConfiguredTaskAwaitable<IDisposable> configuredTaskAwaitable;
                switch (num3)
                {
                  case 1:
                    goto label_25;
                  case 2:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 8 : 8;
                    continue;
                  case 3:
                    configuredTaskAwaiter = new ConfiguredTaskAwaitable<IDisposable>.ConfiguredTaskAwaiter();
                    num3 = 11;
                    continue;
                  case 4:
                    goto label_88;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<IDisposable>.ConfiguredTaskAwaiter, ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                    num3 = 4;
                    continue;
                  case 6:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 14;
                      continue;
                    }
                    break;
                  case 7:
                    goto label_21;
                  case 8:
                    configuredTaskAwaitable = sequenceHiLoGenerator1.asyncLock.LockAsync().ConfigureAwait(false);
                    num3 = 10;
                    continue;
                  case 9:
                  case 17:
                    awaiter = configuredTaskAwaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 3;
                    continue;
                  case 10:
                    awaiter = configuredTaskAwaitable.GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 6;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 8 : 15;
                    continue;
                  case 12:
                    disposable = result2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 7;
                    continue;
                  case 13:
                    goto label_12;
                  case 14:
                  case 15:
                    result2 = awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 6 : 12;
                    continue;
                  case 16:
                    configuredTaskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 5;
                    continue;
                }
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num2 = 0;
                num3 = 16;
              }
label_88:
              return;
label_25:
              try
              {
                ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter configuredTaskAwaiter;
                ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter;
                int num4;
                switch (num2)
                {
                  case 1:
label_64:
                    awaiter = configuredTaskAwaiter;
                    num4 = 10;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                    {
                      num4 = 16;
                      break;
                    }
                    break;
                  case 2:
label_36:
                    awaiter = configuredTaskAwaiter;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 36 : 10;
                    break;
                  case 3:
label_49:
                    awaiter = configuredTaskAwaiter;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 31;
                    break;
                  default:
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 39 : 3;
                    break;
                }
                while (true)
                {
                  int num5;
                  long num6;
                  ConfiguredTaskAwaitable<object> configuredTaskAwaitable;
                  long num7;
                  switch (num4)
                  {
                    case 1:
                      sequenceHiLoGenerator1.lo = num7 == 0L ? 1 : 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 17 : 15;
                      continue;
                    case 2:
                      goto label_80;
                    case 3:
                    case 28:
                      // ISSUE: reference to a compiler-generated method
                      num6 = ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0.eayStZQLFZPc4OIUe2nH(awaiter.GetResult());
                      num4 = 11;
                      continue;
                    case 4:
                      goto label_75;
                    case 5:
                      configuredTaskAwaiter = awaiter;
                      num4 = 40;
                      continue;
                    case 6:
                      configuredTaskAwaitable = sequenceHiLoGenerator1.GenerateInternalAsync(session, obj, cancellationToken).ConfigureAwait(false);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 21 : 30;
                      continue;
                    case 7:
                      if (sequenceHiLoGenerator1.lo < sequenceHiLoGenerator1.maxLo)
                      {
                        num4 = 12;
                        continue;
                      }
                      goto case 15;
                    case 8:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 2;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 5;
                      continue;
                    case 9:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 26 : 2;
                        continue;
                      }
                      goto case 24;
                    case 10:
                    case 26:
                      // ISSUE: reference to a compiler-generated method
                      num7 = ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0.eayStZQLFZPc4OIUe2nH(awaiter.GetResult());
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
                      continue;
                    case 11:
                      if (num6 == 0L)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 37 : 24;
                        continue;
                      }
                      goto case 18;
                    case 12:
                    case 13:
                      long hi = sequenceHiLoGenerator1.hi;
                      ElmaSequenceHiLoGenerator sequenceHiLoGenerator2 = sequenceHiLoGenerator1;
                      int lo = sequenceHiLoGenerator1.lo;
                      int num8 = lo + 1;
                      sequenceHiLoGenerator2.lo = num8;
                      long num9 = (long) lo;
                      // ISSUE: reference to a compiler-generated method
                      result1 = ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0.qOenUGQLBhewW9qOD9R8(hi + num9, sequenceHiLoGenerator1.returnClass);
                      num4 = 14;
                      continue;
                    case 14:
                    case 38:
                      goto label_92;
                    case 15:
                      configuredTaskAwaitable = sequenceHiLoGenerator1.GenerateInternalAsync(session, obj, cancellationToken).ConfigureAwait(false);
                      num4 = 25;
                      continue;
                    case 16:
                      configuredTaskAwaiter = new ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter();
                      num4 = 33;
                      continue;
                    case 17:
                      sequenceHiLoGenerator1.hi = num7 * (long) sequenceHiLoGenerator1.maxLo;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 13 : 0;
                      continue;
                    case 18:
                      // ISSUE: reference to a compiler-generated method
                      result1 = ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0.qOenUGQLBhewW9qOD9R8(num6, sequenceHiLoGenerator1.returnClass);
                      num4 = 38;
                      continue;
                    case 19:
                    case 45:
                      // ISSUE: reference to a compiler-generated method
                      num6 = ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0.eayStZQLFZPc4OIUe2nH(awaiter.GetResult());
                      num5 = 18;
                      break;
                    case 20:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter, ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                      num4 = 4;
                      continue;
                    case 21:
                      configuredTaskAwaiter = awaiter;
                      num4 = 20;
                      continue;
                    case 22:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 10;
                      continue;
                    case 23:
                      awaiter = configuredTaskAwaitable.GetAwaiter();
                      num4 = 34;
                      continue;
                    case 24:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 3;
                      num4 = 21;
                      continue;
                    case 25:
                      awaiter = configuredTaskAwaitable.GetAwaiter();
                      num4 = 9;
                      continue;
                    case 27:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter, ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                      num4 = 2;
                      continue;
                    case 29:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                      continue;
                    case 30:
                      awaiter = configuredTaskAwaitable.GetAwaiter();
                      num4 = 42;
                      continue;
                    case 31:
                      configuredTaskAwaiter = new ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter();
                      num4 = 22;
                      continue;
                    case 32:
                      goto label_36;
                    case 33:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 28 : 11;
                      continue;
                    case 34:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 19 : 9;
                        continue;
                      }
                      goto case 8;
                    case 35:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 45;
                      continue;
                    case 36:
                      configuredTaskAwaiter = new ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 35 : 25;
                      continue;
                    case 37:
                      configuredTaskAwaitable = sequenceHiLoGenerator1.GenerateInternalAsync(session, obj, cancellationToken).ConfigureAwait(false);
                      num4 = 23;
                      continue;
                    case 39:
                      if (sequenceHiLoGenerator1.maxLo <= 1)
                      {
                        num4 = 6;
                        continue;
                      }
                      goto case 7;
                    case 40:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter, ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                      num5 = 43;
                      break;
                    case 41:
                      goto label_64;
                    case 42:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 3;
                        continue;
                      }
                      goto case 29;
                    case 43:
                      goto label_68;
                    case 44:
                      goto label_49;
                    default:
                      configuredTaskAwaiter = awaiter;
                      num4 = 27;
                      continue;
                  }
                  num4 = num5;
                }
label_80:
                return;
label_75:
                return;
label_68:
                return;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num10 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                    num10 = 1;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        if (disposable != null)
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_84;
                      case 2:
                        goto label_84;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        ElmaSequenceHiLoGenerator.\u003CGenerateAsync\u003Ed__0.HDkBMoQLW5LlnY2Utn9p((object) disposable);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 2;
                        continue;
                    }
                  }
                }
label_84:;
              }
label_12:
              if ((uint) (num2 - 1) > 2U)
              {
                num3 = 2;
                goto label_7;
              }
label_21:
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
              {
                num3 = 1;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num11 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                num11 = 0;
              while (true)
              {
                switch (num11)
                {
                  case 1:
                    goto label_52;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num11 = 2;
                    continue;
                }
              }
label_52:
              return;
            }
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 2;
            continue;
        }
      }
label_91:;
    }

    private Task<object> GenerateInternalAsync(
      ISessionImplementor session,
      object obj,
      CancellationToken cancellationToken)
    {
      return this.idGenerator != null ? this.idGenerator.GenerateAsync(session, obj, cancellationToken) : base.GenerateAsync(session, obj, cancellationToken);
    }

    /// <inheritdoc />
    public override void Configure(IType type, IDictionary<string, string> parms, NHibernate.Dialect.Dialect dialect)
    {
      base.Configure(type, parms, dialect);
      string typeName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173737579), parms, "");
      if (!string.IsNullOrEmpty(typeName))
      {
        this.idGenerator = (IIdentifierGenerator) Activator.CreateInstance(System.Type.GetType(typeName, true));
        if (this.idGenerator is IConfigurable)
          ((IConfigurable) this.idGenerator).Configure(type, parms, dialect);
      }
      this.maxLo = PropertiesHelper.GetInt32(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576025632), parms, 10);
      this.lo = this.maxLo + 1;
      this.returnClass = type.ReturnedClass;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.Synchronized)]
    public override object Generate(ISessionImplementor session, object obj)
    {
      int num = 8;
      long int64_1;
      long int64_2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            this.hi = int64_2 * (long) this.maxLo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
            continue;
          case 3:
            int64_2 = Convert.ToInt64(this.GenerateInternal(session, obj));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 6;
            continue;
          case 4:
            int64_1 = Convert.ToInt64(this.GenerateInternal(session, obj));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 5 : 3;
            continue;
          case 5:
            goto label_2;
          case 6:
            this.lo = int64_2 == 0L ? 1 : 0;
            num = 2;
            continue;
          case 7:
            int64_1 = Convert.ToInt64(this.GenerateInternal(session, obj));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 8:
            if (this.maxLo > 1)
            {
              if (this.lo >= this.maxLo)
              {
                num = 3;
                continue;
              }
              goto label_9;
            }
            else
            {
              num = 7;
              continue;
            }
          default:
            if (int64_1 == 0L)
            {
              num = 4;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return ElmaSequenceHiLoGenerator.KAWdmyWy3fdkN6Yey8Pn(int64_1, this.returnClass);
label_9:
      return IdentifierGeneratorFactory.CreateNumber(this.hi + (long) this.lo++, this.returnClass);
    }

    private object GenerateInternal(ISessionImplementor session, object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.idGenerator != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ElmaSequenceHiLoGenerator.U3NQU4Wypc0ecsUNeRKZ((object) this.idGenerator, (object) session, obj);
label_3:
      return ElmaSequenceHiLoGenerator.Ei8f5nWyaGpZG1GV8jJ3((object) this, (object) session, obj);
    }

    /// <summary>Определение генератора</summary>
    public static IGeneratorDef GeneratorDef
    {
      get
      {
        int num = 1;
        IGeneratorDef generatorDef;
        while (true)
        {
          switch (num)
          {
            case 1:
              generatorDef = ElmaSequenceHiLoGenerator.generatorDef;
              if (generatorDef == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return generatorDef;
label_5:
        return ElmaSequenceHiLoGenerator.generatorDef = (IGeneratorDef) new ElmaSequenceHiLoGenerator.GeneratorDefInternal();
      }
    }

    public ElmaSequenceHiLoGenerator()
    {
      ElmaSequenceHiLoGenerator.iFcXVcWyDWDIB8JIGZJ3();
      this.asyncLock = new AsyncLock();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object KAWdmyWy3fdkN6Yey8Pn([In] long obj0, [In] System.Type obj1) => IdentifierGeneratorFactory.CreateNumber(obj0, obj1);

    internal static bool C0m10GWy1WIBqpgtiQCm() => ElmaSequenceHiLoGenerator.ifgovHWyPhFmQdEFvvJT == null;

    internal static ElmaSequenceHiLoGenerator oLRjc3WyNqrd5D1OOcSy() => ElmaSequenceHiLoGenerator.ifgovHWyPhFmQdEFvvJT;

    internal static object U3NQU4Wypc0ecsUNeRKZ([In] object obj0, [In] object obj1, [In] object obj2) => ((IIdentifierGenerator) obj0).Generate((ISessionImplementor) obj1, obj2);

    internal static object Ei8f5nWyaGpZG1GV8jJ3([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SequenceGenerator) obj0).Generate((ISessionImplementor) obj1, obj2));

    internal static void iFcXVcWyDWDIB8JIGZJ3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class GeneratorDefInternal : IGeneratorDef
    {
      internal static object cqaWjyQY59Ao9jQacx5H;

      public string Class => ElmaSequenceHiLoGenerator.GeneratorDefInternal.LHUTJmQYLWKgQqWQdG66(__typeref (ElmaSequenceHiLoGenerator)).AssemblyQualifiedName;

      public object Params => (object) null;

      public System.Type DefaultReturnType => TypeOf<long>.Raw;

      public bool SupportedAsCollectionElementId => false;

      public GeneratorDefInternal()
      {
        ElmaSequenceHiLoGenerator.GeneratorDefInternal.ESbuNHQYUonMhfcOAc8u();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static System.Type LHUTJmQYLWKgQqWQdG66([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

      internal static bool MyPo4UQYjiR02kFmQNnD() => ElmaSequenceHiLoGenerator.GeneratorDefInternal.cqaWjyQY59Ao9jQacx5H == null;

      internal static ElmaSequenceHiLoGenerator.GeneratorDefInternal NmThOoQYYRajNXAFTHXW() => (ElmaSequenceHiLoGenerator.GeneratorDefInternal) ElmaSequenceHiLoGenerator.GeneratorDefInternal.cqaWjyQY59Ao9jQacx5H;

      internal static void ESbuNHQYUonMhfcOAc8u() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
