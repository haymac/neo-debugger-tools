﻿using Neo.VM;
using System;

namespace Neo.Emulator
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class OpCodeAttribute : Attribute
    {
        public OpCode OpCode { get; }

        public OpCodeAttribute(OpCode opcode)
        {
            this.OpCode = opcode;
        }
    }
}
