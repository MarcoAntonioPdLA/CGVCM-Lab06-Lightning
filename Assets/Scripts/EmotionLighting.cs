using UnityEngine;
using UnityEngine.InputSystem;

public class EmotionLighting : MonoBehaviour {
    [SerializeField] private Light roomLight;

    private void Start() {
        SetComfort();
    }

    private void Update() {
        if (Keyboard.current.digit1Key.wasPressedThisFrame) {
            SetComfort();
        }
        if (Keyboard.current.digit2Key.wasPressedThisFrame) {
            SetSadness();
        }
        if (Keyboard.current.digit3Key.wasPressedThisFrame) {
            SetFear();
        }
    }

    private void SetComfort() {
        roomLight.color = new Color(1f, 0.75f, 0.4f);
        roomLight.intensity = 8f;
        RenderSettings.ambientLight = new Color(0.4f, 0.3f, 0.2f);
    }

    private void SetSadness() {
        roomLight.color = new Color(0.4f, 0.6f, 1f);
        roomLight.intensity = 5f;
        RenderSettings.ambientLight = new Color(0.1f, 0.15f, 0.25f);
    }

    private void SetFear() {
        roomLight.color = new Color(0.8f, 0.1f, 0.1f);
        roomLight.intensity = 3f;
        RenderSettings.ambientLight = new Color(0.03f, 0.03f, 0.03f);
    }
}