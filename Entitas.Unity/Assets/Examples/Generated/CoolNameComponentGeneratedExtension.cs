//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;
using Entitas.CodeGenerator;

[Pool("VisualDebugging")]
public class CoolNameComponent : IComponent {
    public BadName value;
}

namespace Entitas {
    public partial class Entity {
        public CoolNameComponent coolName { get { return (CoolNameComponent)GetComponent(VisualDebuggingComponentIds.CoolName); } }

        public bool hasCoolName { get { return HasComponent(VisualDebuggingComponentIds.CoolName); } }

        public Entity AddCoolName(BadName newValue) {
            var component = CreateComponent<CoolNameComponent>(VisualDebuggingComponentIds.CoolName);
            component.value = newValue;
            return AddComponent(VisualDebuggingComponentIds.CoolName, component);
        }

        public Entity ReplaceCoolName(BadName newValue) {
            var component = CreateComponent<CoolNameComponent>(VisualDebuggingComponentIds.CoolName);
            component.value = newValue;
            ReplaceComponent(VisualDebuggingComponentIds.CoolName, component);
            return this;
        }

        public Entity RemoveCoolName() {
            return RemoveComponent(VisualDebuggingComponentIds.CoolName);
        }
    }
}

    public partial class VisualDebuggingMatcher {
        static IMatcher _matcherCoolName;

        public static IMatcher CoolName {
            get {
                if (_matcherCoolName == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.CoolName);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherCoolName = matcher;
                }

                return _matcherCoolName;
            }
        }
    }
