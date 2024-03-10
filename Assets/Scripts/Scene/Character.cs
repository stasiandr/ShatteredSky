using System;
using System.Collections;
using System.Linq;
using DG.Tweening;
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

        private void Start()
        {
            GetComponent<Image>().color = Color.clear;
        }

        private static Character Instance(Position pos) => FindObjectsOfType<Character>().First(c => c.pos == pos);
        
        public static IEnumerator SetCharacter(string path, Position pos)
        {
            var imageComponent = Instance(pos).gameObject.GetComponent<Image>();

            if (imageComponent.sprite != null)
                yield return imageComponent.DOColor(new Color(1, 1, 1, 0), 0.5f);
            
            imageComponent.sprite = string.IsNullOrEmpty(path) ? null : Resources.Load<Sprite>(path);
            
            if (imageComponent.sprite != null)
                yield return imageComponent.DOColor(Color.white, 0.5f);
        }
    }
}