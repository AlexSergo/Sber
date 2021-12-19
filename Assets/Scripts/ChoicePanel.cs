using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoicePanel : MonoBehaviour
{
    private Animation _animation;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }

    void Start()
    {
        _animation.Play("ShowChoice");
    }

    public void OnTouristButtonClick()
    {
        GameState.State = GameStates.Tourist;
        SceneManager.LoadScene(1);
    }

    public void OnCitizenButtonClick()
    {
        GameState.State = GameStates.Citizen;
        SceneManager.LoadScene(1);
    }
}
