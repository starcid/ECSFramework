//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CharModel charModel { get { return (CharModel)GetComponent(GameComponentsLookup.CharModel); } }
    public bool hasCharModel { get { return HasComponent(GameComponentsLookup.CharModel); } }

    public void AddCharModel(UnityEngine.GameObject newGameObject) {
        var index = GameComponentsLookup.CharModel;
        var component = CreateComponent<CharModel>(index);
        component.gameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplaceCharModel(UnityEngine.GameObject newGameObject) {
        var index = GameComponentsLookup.CharModel;
        var component = CreateComponent<CharModel>(index);
        component.gameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemoveCharModel() {
        RemoveComponent(GameComponentsLookup.CharModel);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCharModel;

    public static Entitas.IMatcher<GameEntity> CharModel {
        get {
            if (_matcherCharModel == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CharModel);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharModel = matcher;
            }

            return _matcherCharModel;
        }
    }
}