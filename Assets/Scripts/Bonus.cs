using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField]
    private GameObject _bonusPanel;

    private Animation _animation;

    void Start()
    {
        _animation = GetComponent<Animation>();
    }

    private void OnMouseDown()
    {
        _animation.Stop();
        _animation.Play("BonusUp");

        _bonusPanel.SetActive(true);
    }
}
