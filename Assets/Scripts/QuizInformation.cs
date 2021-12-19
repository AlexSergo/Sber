using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizInformation : MonoBehaviour
{
    [SerializeField]
    private Text _name;
    [SerializeField]
    private Text _question;
    [SerializeField]
    private Image _image;

    private Button[] _buttons = new Button[4];
    private Animation _animation;
    private bool _isShowed = false;

    private void Awake()
    {
        for (int i = 0; i < 4; i++)
            _buttons[i] = transform.GetChild(3).GetChild(i).GetComponent<Button>();
        _animation = GetComponent<Animation>();
    }

    public void SetInfo(Information information)
    {
        _name.text = information.Name;

        if (_image)
            _image.sprite = information.Image;

        _question.text = information.ShortInfo;

        var answer = information.Answer;
        var variants = information.Variants;

        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].transform.GetChild(0).GetComponent<Text>().text = variants[i];
        }

        if (!_isShowed)
        {
            _animation.Play("ShowInfo");
            _isShowed = true;
        }
    }

    public void OnVariantButtonClick()
    {
        _animation.Play("HideInfo");
        _isShowed = false;
    }
}
