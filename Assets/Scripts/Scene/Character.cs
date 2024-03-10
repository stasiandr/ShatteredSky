using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Scene
{
    public class Character : MonoBehaviour
    {
        public enum Position
        {
            Left,
            Right
        }

        [SerializeField]
        private Position pos;
        
        private static Character Instance(Position pos) => FindObjectsOfType<Character>().First(c => c.pos == pos);
        
        public static void SetCharacter(string path, Position pos)
        {
            var instance = Instance(pos);
            instance.gameObject.GetComponent<Image>().sprite = string.IsNullOrEmpty(path) ? null : Resources.Load<Sprite>(path);
            instance.gameObject.GetComponent<Image>().color = string.IsNullOrEmpty(path) ? Color.clear : Color.white;
        }
    }
}