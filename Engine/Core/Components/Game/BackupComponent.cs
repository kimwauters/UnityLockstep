﻿using Entitas;               

namespace Lockstep.Core.Components.Game
{
    [Game]
    //A GameEntity with BackupComponent refers to an entity in the past
    public class BackupComponent : IComponent
    {
        public uint localEntityId;

        public uint tick;
    }
}
