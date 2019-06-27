//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DictionaryComponent dictionary { get { return (DictionaryComponent)GetComponent(GameComponentsLookup.Dictionary); } }
    public bool hasDictionary { get { return HasComponent(GameComponentsLookup.Dictionary); } }

    public void AddDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
        var index = GameComponentsLookup.Dictionary;
        var component = (DictionaryComponent)CreateComponent(index, typeof(DictionaryComponent));
        component.dict = newDict;
        AddComponent(index, component);
    }

    public void ReplaceDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
        var index = GameComponentsLookup.Dictionary;
        var component = (DictionaryComponent)CreateComponent(index, typeof(DictionaryComponent));
        component.dict = newDict;
        ReplaceComponent(index, component);
    }

    public void RemoveDictionary() {
        RemoveComponent(GameComponentsLookup.Dictionary);
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

    static Entitas.IMatcher<GameEntity> _matcherDictionary;

    public static Entitas.IMatcher<GameEntity> Dictionary {
        get {
            if (_matcherDictionary == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Dictionary);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDictionary = matcher;
            }

            return _matcherDictionary;
        }
    }
}
