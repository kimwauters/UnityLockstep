﻿using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Lockstep.Core.Components.GameState
{
    [GameState, Unique]
    public sealed class HashCodeComponent : IComponent
    {
        public long value;
    }
}