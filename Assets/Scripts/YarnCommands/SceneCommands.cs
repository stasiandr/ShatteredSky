using Scene;
using UnityEngine;
using Yarn.Unity;

namespace YarnCommands
{
    public static class SceneCommands
    {
        [YarnCommand(Name = "background")]
        public static void LoadBackground(string path)
        {
            Background.SetBackground(path);
        }
    }
}