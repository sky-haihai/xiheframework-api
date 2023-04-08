using XiheFramework.Modules.Base;

namespace XiheFramework {
    public static partial class Game {
        public static ExampleGameModule Example => GameManager.GetModule<ExampleGameModule>();
    }
}