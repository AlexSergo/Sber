using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct Information
{
    public Information(string name, string shortInfo, Sprite image, string fullInfo = "", string answer = "",
        string[] variants = null)
    {
        Name = name;
        ShortInfo = shortInfo;
        FullInfo = fullInfo;
        Image = image;
        Answer = answer;
        Variants = variants;
    }

    public string Name;
    public string ShortInfo;
    public string FullInfo;
    public string Answer;
    public string[] Variants;
    public Sprite Image;
}

public class Cube : MonoBehaviour
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _shortInfo;
    [SerializeField]
    private string _fullInfo;
    [SerializeField]
    private Sprite _image;
    [SerializeField]
    private GameObject _informationPanel;
    [SerializeField]
    private string _question;
    [SerializeField]
    private string[] _variants;
    [SerializeField]
    private string _answer;
    [SerializeField]
    private GameObject _quizPanel;

    private Outline _outline;
    private InformationPanel _informationPanelScript;
    private QuizInformation _quizPanelScript;
    private Information _information;

    private void Awake()
    {
        _outline = GetComponent<Outline>();

        if (GameState.State == GameStates.Tourist)
        {
            _information = new Information(_name, _shortInfo, _image, _fullInfo);
            _informationPanelScript = _informationPanel.GetComponent<InformationPanel>();
        }
        else
        {
            _information = new Information(_name, _question, _image, answer: _answer, variants: _variants);
            _quizPanelScript = _quizPanel.GetComponent<QuizInformation>();
        }
    }

    private void OnMouseDown()
    {
        if (GameState.State == GameStates.Tourist)
        {
            _informationPanel.SetActive(true);
            _informationPanelScript.SetInfo(_information);
        }
        else
        {
            _quizPanel.SetActive(true);
            _quizPanelScript.SetInfo(_information);
        }
    }

    public void ShowInformation()
    {
        if (GameState.State == GameStates.Tourist)
        {
            _informationPanel.SetActive(true);
            _informationPanelScript.SetInfo(_information);
        }
        else
        {
            _quizPanel.SetActive(true);
            _quizPanelScript.SetInfo(_information);
        }
        _outline.OutlineWidth = 15;
    }

    internal void Hide()
    {
        _outline.OutlineWidth = 0;
    }
}
