//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public Test2ContextComponent test2Context { get { return (Test2ContextComponent)GetComponent(TestComponentsLookup.Test2Context); } }
    public bool hasTest2Context { get { return HasComponent(TestComponentsLookup.Test2Context); } }

    public void AddTest2Context(string newValue) {
        var index = TestComponentsLookup.Test2Context;
        var component = (Test2ContextComponent)CreateComponent(index, typeof(Test2ContextComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTest2Context(string newValue) {
        var index = TestComponentsLookup.Test2Context;
        var component = (Test2ContextComponent)CreateComponent(index, typeof(Test2ContextComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTest2Context() {
        RemoveComponent(TestComponentsLookup.Test2Context);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity : ITest2ContextEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherTest2Context;

    public static Entitas.IMatcher<TestEntity> Test2Context {
        get {
            if (_matcherTest2Context == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.Test2Context);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherTest2Context = matcher;
            }

            return _matcherTest2Context;
        }
    }
}
