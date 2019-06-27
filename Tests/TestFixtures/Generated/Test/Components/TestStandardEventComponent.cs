//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public StandardEventComponent standardEvent { get { return (StandardEventComponent)GetComponent(TestComponentsLookup.StandardEvent); } }
    public bool hasStandardEvent { get { return HasComponent(TestComponentsLookup.StandardEvent); } }

    public void AddStandardEvent(string newValue) {
        var index = TestComponentsLookup.StandardEvent;
        var component = (StandardEventComponent)CreateComponent(index, typeof(StandardEventComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStandardEvent(string newValue) {
        var index = TestComponentsLookup.StandardEvent;
        var component = (StandardEventComponent)CreateComponent(index, typeof(StandardEventComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStandardEvent() {
        RemoveComponent(TestComponentsLookup.StandardEvent);
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
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherStandardEvent;

    public static Entitas.IMatcher<TestEntity> StandardEvent {
        get {
            if (_matcherStandardEvent == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.StandardEvent);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherStandardEvent = matcher;
            }

            return _matcherStandardEvent;
        }
    }
}
