﻿using System.Collections.Generic;

namespace TankLite.Values;

public class TLObj : TLValue
{
    public override bool IsReadonly { get; set; } = true;

    public override string Type { get; set; } = "object";

    public Dictionary<string, TLValue> Value { get; set; }
}
