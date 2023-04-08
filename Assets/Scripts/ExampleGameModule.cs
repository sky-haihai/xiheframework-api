using UnityEngine;
using XiheFramework.Modules.Base;

public class ExampleGameModule : GameModule {

    public void HelloWorld() {
        Debug.Log("HelloWorld!");
    }

    internal override void Setup() {
        //TODO: Setup data, Setup() is called after all modules are ready
    }

    internal override void OnUpdate() {
        //TODO: treated as a regular Unity Update() function
    }

    internal override void OnFixedUpdate() { }

    internal override void OnLateUpdate() { }

    internal override void ShutDown(ShutDownType shutDownType) {
        //TODO: any logic before the framework is being shutdown or restarted
    }
}