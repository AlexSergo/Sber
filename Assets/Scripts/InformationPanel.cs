using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InformationPanel : MonoBehaviour
{
    [SerializeField]
    private Text _name;
    [SerializeField]
    private Text _shortInfo;
    [SerializeField]
    private Text _fullInfo;
    [SerializeField]
    private Image _image;

    [SerializeField]
    private InformationPanel _fullInformation;

    private Information _information;
    private Animation _animation;
    private bool _isShowed = false; 

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }

    private void Start()
    {
       // _animation.Play("ShowInfo");
    }

    public void SetInfo(Information information)
    {
        _name.text = information.Name;
        if (_shortInfo)
            _shortInfo.text = information.ShortInfo;

        if (_fullInfo)
            _fullInfo.text = information.FullInfo;

        if (_image)
            _image.sprite = information.Image;

        _information = information;

        if (!_isShowed)
        {
            _animation.Play("ShowInfo");
            _isShowed = true;
        }
    }

    public void OnFullInformationButtonClick()
    {
        _animation.Play("HideInfo");
        _isShowed = false;
        _fullInformation.SetInfo(_information);
    }

    public void OnOkButtonClick()
    {
        _animation.Play("HideInfo");
        _isShowed = false;
    }
}
