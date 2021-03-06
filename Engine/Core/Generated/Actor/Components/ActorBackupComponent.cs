//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActorEntity {

    public Lockstep.Core.Components.Actor.BackupComponent backup { get { return (Lockstep.Core.Components.Actor.BackupComponent)GetComponent(ActorComponentsLookup.Backup); } }
    public bool hasBackup { get { return HasComponent(ActorComponentsLookup.Backup); } }

    public void AddBackup(byte newActorId, uint newTick) {
        var index = ActorComponentsLookup.Backup;
        var component = (Lockstep.Core.Components.Actor.BackupComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Actor.BackupComponent));
        component.actorId = newActorId;
        component.tick = newTick;
        AddComponent(index, component);
    }

    public void ReplaceBackup(byte newActorId, uint newTick) {
        var index = ActorComponentsLookup.Backup;
        var component = (Lockstep.Core.Components.Actor.BackupComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Actor.BackupComponent));
        component.actorId = newActorId;
        component.tick = newTick;
        ReplaceComponent(index, component);
    }

    public void RemoveBackup() {
        RemoveComponent(ActorComponentsLookup.Backup);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ActorMatcher {

    static Entitas.IMatcher<ActorEntity> _matcherBackup;

    public static Entitas.IMatcher<ActorEntity> Backup {
        get {
            if (_matcherBackup == null) {
                var matcher = (Entitas.Matcher<ActorEntity>)Entitas.Matcher<ActorEntity>.AllOf(ActorComponentsLookup.Backup);
                matcher.componentNames = ActorComponentsLookup.componentNames;
                _matcherBackup = matcher;
            }

            return _matcherBackup;
        }
    }
}
