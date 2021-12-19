using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPanel : MonoBehaviour
{
    private Animation _animation;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }

    void Start()
    {
        _animation.Play("ShowInfo");
        StartCoroutine(Hide());
    }

    private IEnumerator Hide()
    {
        yield return new WaitForSeconds(1.5f);
        _animation.Play("HideInfo");
    }
}
