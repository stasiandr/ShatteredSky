using System;
using System.Collections;
using Scene;
using UnityEngine;
using Yarn.Unity;

namespace YarnCommands
{
    public static class SceneCommands
    {
        [YarnCommand(Name = "background")]
        public static IEnumerator LoadBackground(string path)
        {
            yield return Background.SetBackground(path);
        }
        
        [YarnCommand(Name = "character")]
        public static IEnumerator SetCharacter(int index, string path)
        {
            if (index is < 0 or >= 2) throw new AggregateException("Invalid character index");
            
            yield return Character.SetCharacter(path, index == 0 ? Character.Position.Left : Character.Position.Right);
        }
    }
}