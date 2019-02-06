﻿using System;
using BEPUutilities;
using Lockstep.Game.Networking;
using Lockstep.Network.Utils;

namespace Lockstep.Game.Commands
{
    [Serializable]
    public class SpawnCommand  : ISerializableCommand
    {
        public ushort Tag => 2;

        public int EntityConfigId;

        public Vector2 Position;        

        public void Execute(InputEntity e)
        {                                    
            e.AddCoordinate(Position);
            e.AddEntityConfigId(EntityConfigId);     
        }  

        public void Serialize(Serializer writer)
        {
            writer.Put(EntityConfigId);
            writer.Put(Position.X.RawValue);
            writer.Put(Position.Y.RawValue);
        }

        public void Deserialize(Deserializer reader)
        {
            EntityConfigId = reader.GetInt();
            Position.X.RawValue = reader.GetLong();
            Position.Y.RawValue = reader.GetLong();
        }
    }
}