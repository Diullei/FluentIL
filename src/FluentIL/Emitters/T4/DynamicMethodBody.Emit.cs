﻿using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Diagnostics;

// ReSharper disable CheckNamespace
namespace FluentIL.Emitters
// ReSharper restore CheckNamespace
{
	public partial class DynamicMethodBody
	{
		readonly Stack<Action> preEmitActions = new Stack<Action>();
		private void ExecutePreEmitActions()
		{
			while ( preEmitActions.Count > 0 ) 
                preEmitActions.Pop()();
		}

		#region Emit (basic)
        public DynamicMethodBody Emit(OpCode opcode)
        {
			ExecutePreEmitActions();
			#if DEBUG
			Console.WriteLine(string.Format("\t{0}", opcode));
			#endif
            _methodInfo.GetILEmitter()
                .Emit(opcode);

            return this;
        }
        #endregion


		public DynamicMethodBody Emit(OpCode opcode, string arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} \"{1}\"", opcode, arg);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

		public DynamicMethodBody Emit(OpCode opcode, int arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} {1}", opcode, arg);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

        public DynamicMethodBody Emit(OpCode opcode, float arg)
        {
            ExecutePreEmitActions();
#if DEBUG
            Console.WriteLine("\t{0} {1}", opcode, arg);
#endif

            _methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

        public DynamicMethodBody Emit(OpCode opcode, double arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} {1}", opcode, arg);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

		public DynamicMethodBody Emit(OpCode opcode, Label arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} IL_{1}", opcode, arg.GetHashCode());
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

		public DynamicMethodBody Emit(OpCode opcode, MethodInfo arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} {1}", opcode, arg);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

		public DynamicMethodBody Emit(OpCode opcode, ConstructorInfo arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} [{1}] {2}", opcode, arg.DeclaringType, arg);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

		public DynamicMethodBody Emit(OpCode opcode, FieldInfo arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} {1}", opcode, arg.Name);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

		public DynamicMethodBody Emit(OpCode opcode, Type arg)
        {
			ExecutePreEmitActions();
			#if DEBUG
						Console.WriteLine("\t{0} {1}", opcode, arg);
						#endif
			
			_methodInfo.GetILEmitter()
                .Emit(opcode, arg);

            return this;
        }

	}
}
