﻿using System.Linq;
using Entitas;
using FixMath.NET;
using Lockstep.Core.Interfaces;

namespace Lockstep.Core.Systems.Navigation
{
    public class NavigationTick : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly INavigationService _navigationService;

        public NavigationTick(Contexts contexts, INavigationService navigationService)
        {
            _contexts = contexts;
            _navigationService = navigationService;
        }

        public void Execute()
        {
            //All registered (navigable) entities have to be updated, because avoidance could move other entities aside
            //_navigationService.Tick();  

            foreach (var entity in _contexts.game.GetEntities(GameMatcher.AllOf(GameMatcher.Destination).NoneOf(GameMatcher.Backup)))
            {
                var velocity = entity.destination.value - entity.position.value;
                if (velocity.LengthSquared() > Fix64.One)
                {
                    velocity.Normalize();
                }

                if ((entity.destination.value - entity.position.value).LengthSquared() > 1)
                {
                    entity.ReplacePosition(entity.position.value + velocity);
                    //TODO: undo after debugging
                    //entity.ReplacePosition(entity.destination.value);
                }
            }
        }
    }
}
