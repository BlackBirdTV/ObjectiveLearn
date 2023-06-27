﻿using System;
using TankLite.Models;

namespace TankLite.Values;

public class TLFunc : TLValue
{
public override string Type { get; set; }
    public Func<TLFuncArgs, TLValue> Value { get; set; }

    public TLFunc(Func<TLFuncArgs, TLValue> func, string returnType)
    {
        Value = func;
        Type = $"func<{returnType}>";
    }
}
