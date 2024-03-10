using System;
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
        
        [YarnCommand(Name = "character")]
        public static void SetCharacter(int index, string path)
        {
            if (index is < 0 or >= 2) throw new AggregateException("Invalid character index");
            
            Character.SetCharacter(path, index == 0 ? Character.Position.Left : Character.Position.Right);
        }
    }
}