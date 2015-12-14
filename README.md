Instructions:

```
mono paket.bootstrapper.exe
mono paket.exe restore
fsharpi bootstrap.fsx
fsharpi Advent2015.fsx
```

...get a great big stack trace.

```



/Users/mavnn/Documents/Projects/Advent2015/Advent2015.fsx(44,9): warning FS0025: Incomplete pattern matches on this expression. For example, the value '5' may indicate a case not covered by the pattern(s).
Adding annotator tokenize
TokenizerAnnotator: No tokenizer type provided. Defaulting to PTBTokenizer.
Adding annotator ssplit
Adding annotator pos
Reading POS tagger model from edu/stanford/nlp/models/pos-tagger/english-left3words/english-left3words-distsim.tagger ... done [1.7 sec].
Adding annotator parse
Loading parser from serialized file edu/stanford/nlp/models/lexparser/englishPCFG.ser.gz ... Assertion failed: (0), function amd64_patch, file mini-amd64.c, line 482.
Stacktrace:

  at <unknown> <0xffffffff>
  at java.util.HashMap.putVal (int,object,object,bool,bool) <0x00209>
  at java.util.HashMap.put (object,object) <0x0004a>
  at edu.stanford.nlp.parser.lexparser.BinaryGrammar.readObject (java.io.ObjectInputStream) <0x00171>
  at (wrapper dynamic-method) edu.stanford.nlp.parser.lexparser.BinaryGrammar.__<Invoker> (object,object[],ikvm.internal.CallerID) <0x00177>
  at Java_sun_reflect_ReflectionFactory/FastMethodAccessorImpl.invoke (object,object[],ikvm.internal.CallerID) <0x0003d>
  at java.lang.reflect.Method.invoke (object,object[],ikvm.internal.CallerID) <0x000d4>
  at java.io.ObjectStreamClass.invokeReadObject (object,java.io.ObjectInputStream) <0x000e1>
  at java.io.ObjectInputStream.readSerialData (object,java.io.ObjectStreamClass) <0x00227>
  at java.io.ObjectInputStream.readOrdinaryObject (bool) <0x004b6>
  at java.io.ObjectInputStream.readObject0 (bool) <0x00647>
  at java.io.ObjectInputStream.defaultReadFields (object,java.io.ObjectStreamClass) <0x001fc>
  at java.io.ObjectInputStream.readSerialData (object,java.io.ObjectStreamClass) <0x0046e>
  at java.io.ObjectInputStream.readOrdinaryObject (bool) <0x004b6>
  at java.io.ObjectInputStream.readObject0 (bool) <0x00647>
  at java.io.ObjectInputStream.readObject () <0x00055>
  at edu.stanford.nlp.io.IOUtils.readObjectFromURLOrClasspathOrFileSystem (string) <0x0007d>
  at edu.stanford.nlp.parser.common.ParserGrammar.loadModel (string,string[]) <0x0014c>
  at edu.stanford.nlp.pipeline.ParserAnnotator.loadModel (string,bool,string[]) <0x0023d>
  at edu.stanford.nlp.pipeline.ParserAnnotator..ctor (string,java.util.Properties) <0x0024c>
  at edu.stanford.nlp.pipeline.AnnotatorImplementations.parse (java.util.Properties) <0x000bf>
  at edu.stanford.nlp.pipeline.AnnotatorFactories/11.create () <0x0001e>
  at edu.stanford.nlp.pipeline.AnnotatorPool.get (string) <0x000b1>
  at (wrapper synchronized) edu.stanford.nlp.pipeline.AnnotatorPool.get (string) <0xffffffff>
  at edu.stanford.nlp.pipeline.StanfordCoreNLP.construct (java.util.Properties,bool,edu.stanford.nlp.pipeline.AnnotatorImplementations) <0x0046b>
  at edu.stanford.nlp.pipeline.StanfordCoreNLP..ctor (java.util.Properties,bool) <0x0004b>
  at edu.stanford.nlp.pipeline.StanfordCoreNLP..ctor (java.util.Properties) <0x00067>
  at <StartupCode$FSI_0001>.$FSI_0001.main@ () <0x00183>
  at (wrapper runtime-invoke) object.runtime_invoke_void (object,intptr,intptr,intptr) <0xffffffff>
  at <unknown> <0xffffffff>
  at (wrapper managed-to-native) System.Reflection.MonoMethod.InternalInvoke (System.Reflection.MonoMethod,object,object[],System.Exception&) <0xffffffff>
  at System.Reflection.MonoMethod.Invoke (object,System.Reflection.BindingFlags,System.Reflection.Binder,object[],System.Globalization.CultureInfo) <0x000a3>
  at System.RuntimeType.InvokeMember (string,System.Reflection.BindingFlags,System.Reflection.Binder,object,object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,string[]) <0x00eb5>
  at System.Reflection.Emit.TypeBuilder.InvokeMember (string,System.Reflection.BindingFlags,System.Reflection.Binder,object,object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,string[]) <0x00069>
  at System.Type.InvokeMember (string,System.Reflection.BindingFlags,System.Reflection.Binder,object,object[],System.Globalization.CultureInfo) <0x0005e>
  at Microsoft.FSharp.Compiler.AbstractIL.ILRuntimeWriter/execEntryPtFun@1980-1.Invoke (Microsoft.FSharp.Core.Unit) <0x000a8>
  at Microsoft.FSharp.Compiler.Interactive.Shell/clo@889-37.Invoke (Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Core.Unit, Microsoft.FSharp.Core.FSharpOption`1<System.Exception>>) <0x00022>
  at Microsoft.FSharp.Primitives.Basics.List.iter<T_REF> (Microsoft.FSharp.Core.FSharpFunc`2<T_REF, Microsoft.FSharp.Core.Unit>,Microsoft.FSharp.Collections.FSharpList`1<T_REF>) <0x00047>
  at Microsoft.FSharp.Collections.ListModule.Iterate<T_REF> (Microsoft.FSharp.Core.FSharpFunc`2<T_REF, Microsoft.FSharp.Core.Unit>,Microsoft.FSharp.Collections.FSharpList`1<T_REF>) <0x0003c>
  at Microsoft.FSharp.Compiler.Interactive.Shell.arg10@888 (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompiler,Microsoft.FSharp.Collections.FSharpList`1<Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Core.Unit, Microsoft.FSharp.Core.FSharpOption`1<System.Exception>>>,Microsoft.FSharp.Core.Unit) <0x0007d>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompiler.ProcessInputs (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,Microsoft.FSharp.Collections.FSharpList`1<Microsoft.FSharp.Compiler.Ast/ParsedInput>,bool,bool,bool,Microsoft.FSharp.Collections.FSharpList`1<Microsoft.FSharp.Compiler.Ast/Ident>) <0x0086c>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompiler.EvalParsedDefinitions (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,bool,bool,Microsoft.FSharp.Collections.FSharpList`1<Microsoft.FSharp.Compiler.Ast/SynModuleDecl>) <0x00281>
  at Microsoft.FSharp.Compiler.Interactive.Shell/clo@1606-45.Invoke (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x01b5e>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.InteractiveCatch<T_REF> (Microsoft.FSharp.Core.FSharpFunc`2<T_REF, System.Tuple`2<T_REF, Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionStepStatus>>,T_REF) <0x00055>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.ExecInteraction (bool,Microsoft.FSharp.Compiler.CompileOps/TcConfig,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,Microsoft.FSharp.Compiler.Ast/ParsedFsiInteraction) <0x00088>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.ExecInteractions (bool,Microsoft.FSharp.Compiler.CompileOps/TcConfig,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,Microsoft.FSharp.Core.FSharpOption`1<Microsoft.FSharp.Compiler.Ast/ParsedFsiInteraction>) <0x00bd8>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.MainThreadProcessParsedInteraction (bool,Microsoft.FSharp.Core.FSharpOption`1<Microsoft.FSharp.Compiler.Ast/ParsedFsiInteraction>,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x001c6>
  at Microsoft.FSharp.Compiler.Interactive.Shell/res@1819.Invoke (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x00034>
  at Microsoft.FSharp.Compiler.Interactive.Shell/run@1836-1.Invoke (Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState, System.Tuple`2<Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState, Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionStepStatus>>,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x0001d>
  at Microsoft.FSharp.Core.OptimizedClosures/Invoke@3252<T1_REF, T2_REF, TResult_REF>.Invoke (T1_REF) <0x00029>
  at Microsoft.FSharp.Compiler.Interactive.Shell/ParseAndProcessAndEvalOneInteractionFromLexbuf@1808.Invoke (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x00214>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.InteractiveCatch<T_REF> (Microsoft.FSharp.Core.FSharpFunc`2<T_REF, System.Tuple`2<T_REF, Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionStepStatus>>,T_REF) <0x00055>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.ParseAndProcessAndEvalOneInteractionFromLexbuf (bool,Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState, System.Tuple`2<Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState, Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionStepStatus>>, Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState, System.Tuple`2<Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState, Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionStepStatus>>>,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,Microsoft.FSharp.Compiler.LexFilter/LexFilter) <0x001b5>
  at Microsoft.FSharp.Compiler.Interactive.Shell.run@1835 (Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor,bool,Microsoft.FSharp.Compiler.LexFilter/LexFilter,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x0007b>
  at Microsoft.FSharp.Compiler.Interactive.Shell/EvalIncludedScript@1831.Invoke (Microsoft.FSharp.Core.Unit) <0x00054>
  at Microsoft.FSharp.Compiler.Interactive.Shell.WithImplicitHome<T_REF> (Microsoft.FSharp.Compiler.CompileOps/TcConfigBuilder,string,Microsoft.FSharp.Core.FSharpFunc`2<Microsoft.FSharp.Core.Unit, T_REF>) <0x00057>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.EvalIncludedScript (bool,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,string,Microsoft.FSharp.Compiler.Range/range) <0x000ea>
  at Microsoft.FSharp.Compiler.Interactive.Shell/EvalIncludedScripts@1855.Invoke (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x00049>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.InteractiveCatch<T_REF> (Microsoft.FSharp.Core.FSharpFunc`2<T_REF, System.Tuple`2<T_REF, Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionStepStatus>>,T_REF) <0x00055>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.EvalIncludedScripts (Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,bool,Microsoft.FSharp.Collections.FSharpList`1<string>) <0x000aa>
  at Microsoft.FSharp.Compiler.Interactive.Shell.consume@1865 (Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor,bool,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState,Microsoft.FSharp.Collections.FSharpList`1<System.Tuple`2<string, bool>>) <0x0011d>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiInteractionProcessor.LoadInitialFiles (bool,Microsoft.FSharp.Compiler.Interactive.Shell/FsiDynamicCompilerState) <0x00037>
  at Microsoft.FSharp.Compiler.Interactive.Shell/FsiEvaluationSession.Run () <0x0103e>
  at Microsoft.FSharp.Compiler.Interactive.Shell.evaluateSession@2420 (string[],Microsoft.FSharp.Core.Unit) <0x000dd>
  at Microsoft.FSharp.Compiler.Interactive.Shell.MainMain (string[]) <0x0019a>
  at Microsoft.FSharp.Compiler.Interactive.Main.FsiMain (string[]) <0x00014>
  at (wrapper runtime-invoke) <Module>.runtime_invoke_int_object (object,intptr,intptr,intptr) <0xffffffff>

Native stacktrace:

	0   mono                                0x000000010da54ae4 mono_handle_native_sigsegv + 271
	1   libsystem_platform.dylib            0x00007fff8c3af52a _sigtramp + 26
	2   ???                                 0x0000000000000000 0x0 + 0
	3   libsystem_c.dylib                   0x00007fff9453037b abort + 129
	4   libsystem_c.dylib                   0x00007fff944f79c4 basename + 0
	5   mono                                0x000000010daa124e mono_arch_patch_code_new + 581
	6   mono                                0x000000010d9bfeee mono_codegen + 1459
	7   mono                                0x000000010d9c163b mini_method_compile + 5707
	8   mono                                0x000000010d9c2995 mono_jit_compile_method_inner + 703
	9   mono                                0x000000010d9c5377 mono_jit_compile_method_with_opt + 570
	10  mono                                0x000000010d9c50fc mono_jit_compile_method + 42
	11  mono                                0x000000010da5641e common_call_trampoline + 1290
	12  ???                                 0x000000010df7f189 0x0 + 4529320329
	13  ???                                 0x000000011e7624ca 0x0 + 4806026442

Debug info from gdb:

(lldb) command source -s 0 '/tmp/mono-gdb-commands.09gjfl'
Executing commands in '/tmp/mono-gdb-commands.09gjfl'.
(lldb) process attach --pid 88756
Process 88756 stopped
* thread #1: tid = 0x1077f0, 0x00007fff8a9d772a libsystem_kernel.dylib`__wait4 + 10, queue = 'com.apple.main-thread', stop reason = signal SIGSTOP
    frame #0: 0x00007fff8a9d772a libsystem_kernel.dylib`__wait4 + 10
libsystem_kernel.dylib`__wait4:
->  0x7fff8a9d772a <+10>: jae    0x7fff8a9d7734            ; <+20>
    0x7fff8a9d772c <+12>: movq   %rax, %rdi
    0x7fff8a9d772f <+15>: jmp    0x7fff8a9d2414            ; cerror
    0x7fff8a9d7734 <+20>: retq   

Executable module set to "/usr/local/Cellar/mono/4.2.1.102_1/bin/mono".
Architecture set to: x86_64h-apple-macosx.
(lldb) thread list
Process 88756 stopped
* thread #1: tid = 0x1077f0, 0x00007fff8a9d772a libsystem_kernel.dylib`__wait4 + 10, queue = 'com.apple.main-thread', stop reason = signal SIGSTOP
  thread #2: tid = 0x1077f2, 0x00007fff8a9d6f5e libsystem_kernel.dylib`__psynch_cvwait + 10
  thread #3: tid = 0x1077f4, 0x00007fff8a9d1cd2 libsystem_kernel.dylib`semaphore_wait_trap + 10
  thread #4: tid = 0x1077f5, 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
  thread #5: tid = 0x1077f6, 0x00007fff8a9d80a2 libsystem_kernel.dylib`kevent_qos + 10, queue = 'com.apple.libdispatch-manager'
  thread #6: tid = 0x1077f7, 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
  thread #7: tid = 0x1077fb, 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
(lldb) thread backtrace all
* thread #1: tid = 0x1077f0, 0x00007fff8a9d772a libsystem_kernel.dylib`__wait4 + 10, queue = 'com.apple.main-thread', stop reason = signal SIGSTOP
  * frame #0: 0x00007fff8a9d772a libsystem_kernel.dylib`__wait4 + 10
    frame #1: 0x000000010da54b7a mono`mono_handle_native_sigsegv + 421
    frame #2: 0x00007fff8c3af52a libsystem_platform.dylib`_sigtramp + 26
    frame #3: 0x00007fff8a9d70af libsystem_kernel.dylib`__pthread_kill + 11
    frame #4: 0x00007fff83ee8500 libsystem_pthread.dylib`pthread_kill + 90
    frame #5: 0x00007fff9453037b libsystem_c.dylib`abort + 129
    frame #6: 0x00007fff944f79c4 libsystem_c.dylib`__assert_rtn + 321
    frame #7: 0x000000010daa124e mono`mono_arch_patch_code_new + 581
    frame #8: 0x000000010d9bfeee mono`mono_codegen + 1459
    frame #9: 0x000000010d9c163b mono`mini_method_compile + 5707
    frame #10: 0x000000010d9c2995 mono`mono_jit_compile_method_inner + 703
    frame #11: 0x000000010d9c5377 mono`mono_jit_compile_method_with_opt + 570
    frame #12: 0x000000010d9c50fc mono`mono_jit_compile_method + 42
    frame #13: 0x000000010da5641e mono`common_call_trampoline + 1290
    frame #14: 0x000000010df7f189
    frame #15: 0x000000011e7624ca

  thread #2: tid = 0x1077f2, 0x00007fff8a9d6f5e libsystem_kernel.dylib`__psynch_cvwait + 10
    frame #0: 0x00007fff8a9d6f5e libsystem_kernel.dylib`__psynch_cvwait + 10
    frame #1: 0x00007fff83ee673d libsystem_pthread.dylib`_pthread_cond_wait + 767
    frame #2: 0x000000010db9699b mono`thread_func + 273
    frame #3: 0x00007fff83ee59b1 libsystem_pthread.dylib`_pthread_body + 131
    frame #4: 0x00007fff83ee592e libsystem_pthread.dylib`_pthread_start + 168
    frame #5: 0x00007fff83ee3385 libsystem_pthread.dylib`thread_start + 13

  thread #3: tid = 0x1077f4, 0x00007fff8a9d1cd2 libsystem_kernel.dylib`semaphore_wait_trap + 10
    frame #0: 0x00007fff8a9d1cd2 libsystem_kernel.dylib`semaphore_wait_trap + 10
    frame #1: 0x000000010dbb39a5 mono`mono_sem_wait + 20
    frame #2: 0x000000010db49925 mono`finalizer_thread + 124
    frame #3: 0x000000010db2b5e6 mono`start_wrapper + 380
    frame #4: 0x000000010dbba354 mono`inner_start_thread + 197
    frame #5: 0x00007fff83ee59b1 libsystem_pthread.dylib`_pthread_body + 131
    frame #6: 0x00007fff83ee592e libsystem_pthread.dylib`_pthread_start + 168
    frame #7: 0x00007fff83ee3385 libsystem_pthread.dylib`thread_start + 13

  thread #4: tid = 0x1077f5, 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
    frame #0: 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
    frame #1: 0x00007fff83ee558c libsystem_pthread.dylib`_pthread_wqthread + 1283
    frame #2: 0x00007fff83ee3375 libsystem_pthread.dylib`start_wqthread + 13

  thread #5: tid = 0x1077f6, 0x00007fff8a9d80a2 libsystem_kernel.dylib`kevent_qos + 10, queue = 'com.apple.libdispatch-manager'
    frame #0: 0x00007fff8a9d80a2 libsystem_kernel.dylib`kevent_qos + 10
    frame #1: 0x00007fff8fd0a11d libdispatch.dylib`_dispatch_mgr_invoke + 216
    frame #2: 0x00007fff8fd09d85 libdispatch.dylib`_dispatch_mgr_thread + 52

  thread #6: tid = 0x1077f7, 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
    frame #0: 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
    frame #1: 0x00007fff83ee558c libsystem_pthread.dylib`_pthread_wqthread + 1283
    frame #2: 0x00007fff83ee3375 libsystem_pthread.dylib`start_wqthread + 13

  thread #7: tid = 0x1077fb, 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
    frame #0: 0x00007fff8a9d778a libsystem_kernel.dylib`__workq_kernreturn + 10
    frame #1: 0x00007fff83ee558c libsystem_pthread.dylib`_pthread_wqthread + 1283
    frame #2: 0x00007fff83ee3375 libsystem_pthread.dylib`start_wqthread + 13
(lldb) detach

=================================================================
Got a SIGABRT while executing native code. This usually indicates
a fatal error in the mono runtime or one of the native libraries 
used by your application.
=================================================================

(lldb) quit
Process 88756 detached
```
