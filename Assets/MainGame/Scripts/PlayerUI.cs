using UnityEngine;
using UnityEngine.UI;
using TMPro;


using System.Collections;


namespace Photon.Pun.Demo.PunBasics
{
    public class PlayerUI : MonoBehaviour
    {
        #region Private Fields

        float characterControllerHeight = 0f;
        Transform targetTransform;
        Renderer targetRenderer;
        CanvasGroup _canvasGroup;
        Vector3 targetPosition;

        private PlayerManager target;


        [Tooltip("UI Text to display Player's Name")]
        [SerializeField]
        private TMP_Text playerNameText;


        [Tooltip("UI Slider to display Player's Health")]
        [SerializeField]
        private Slider playerHealthSlider;


        #endregion


        #region MonoBehaviour Callbacks

        void LateUpdate()
        {
        // Do not show the UI if we are not visible to the camera, thus avoid potential bugs with seeing the UI, but not the player itself.
            if (targetRenderer!=null)
            {
                this._canvasGroup.alpha = targetRenderer.isVisible ? 1f : 0f;
            }


        // #Critical
        // Follow the Target GameObject on screen.
        if (targetTransform != null)
        {
            targetPosition = targetTransform.position;
            targetPosition.y += characterControllerHeight;
            this.transform.position = Camera.main.WorldToScreenPoint (targetPosition) + screenOffset;
        }
        }

        void Awake()
        {
            _canvasGroup = this.GetComponent<CanvasGroup>();



            this.transform.SetParent(GameObject.Find("Canvas").GetComponent<Transform>(), false);


        }

        void Update()
        {
            if (target == null)
            {
                Destroy(this.gameObject);
                return;
            }
            // Reflect the Player Health
            if (playerHealthSlider != null)
            {
                playerHealthSlider.value = target.Health;
            }
        }


        #endregion


        #region Public Methods

        [SerializeField]
        private Vector3 screenOffset = new Vector3(0f,30f,0f);

        public void SetTarget(PlayerManager _target)
        {
            if (_target == null)
            {
                Debug.LogError("<Color=Red><a>Missing</a></Color> PlayMakerManager target for PlayerUI.SetTarget.", this);
                return;
            }
            // Cache references for efficiency
            target = _target;
            if (playerNameText != null)
            {
                playerNameText.text = target.photonView.Owner.NickName;
            }


            targetTransform = this.target.GetComponent<Transform>();
            targetRenderer = this.target.GetComponent<Renderer>();
            CharacterController characterController = _target.GetComponent<CharacterController> ();
            // Get data from the Player that won't change during the lifetime of this Component
            if (characterController != null)
            {
            characterControllerHeight = characterController.height;
            }



        }


        #endregion


    }
}