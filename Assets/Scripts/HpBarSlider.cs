using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarSlider : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            _slider.value -= 0.2f;
        if (Input.GetKeyDown(KeyCode.D))
            _slider.value += 0.2f;
    }
}
