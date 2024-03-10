using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Scene
{
    public class Background : MonoBehaviour
    {
        private static Background Instance => FindObjectOfType<Background>();

        private void Start()
        {
            GetComponent<Image>().color = Color.clear;
        }

        public static IEnumerator SetBackground(string path)
        {
            var imageComponent = Instance.gameObject.GetComponent<Image>();

            if (imageComponent.sprite != null)
                yield return imageComponent.DOColor(new Color(1, 1, 1, 0), 0.5f);
            
            imageComponent.sprite = Resources.Load<Sprite>(path);
            
            if (imageComponent.sprite != null)
                yield return imageComponent.DOColor(Color.white, 0.5f);
        }
    }
}