using UnityEngine;
using Yarn.Unity;

namespace CustomDialogController
{
    public class NextOnEnter : MonoBehaviour
    {
        public LineView lineView;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
                lineView.OnContinueClicked();
        }
    }
}
