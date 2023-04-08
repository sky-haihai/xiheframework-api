using UnityEngine;
using XiheFramework;

public class UsingExampleModule : MonoBehaviour {
    private void Start() {
        //Game.GetModule<ExampleGameModule>().HelloWorld();
        Game.Example.HelloWorld();
    }
}