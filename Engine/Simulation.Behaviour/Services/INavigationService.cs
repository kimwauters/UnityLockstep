﻿using System.Collections.Generic;
using BEPUutilities;
using Lockstep.Core.Services;

namespace Simulation.Behaviour.Services
{
    public interface INavigationService : IService
    {
        void AddAgent(uint id, Vector2 position);

        void RemoveAgent(uint id);

        void SetAgentDestination(uint agentId, Vector2 newDestination);

        void SetAgentPositions(Dictionary<uint, Vector2> positions);

        void Tick();

        Dictionary<uint, Vector2> GetAgentVelocities();
    }
}