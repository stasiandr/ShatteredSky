using UnityEngine;
using UnityEngine.UI;

namespace Scene
{
    public class Background : MonoBehaviour
    {
        private static Background Instance => FindObjectOfType<Background>();
        
        public static void SetBackground(string path)
        {
            Resources.Load<Texture2D>(path);
            Instance.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
        }
    }
}