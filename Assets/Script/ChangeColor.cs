using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour, IPointerClickHandler
{
    MeshRenderer _renderer;

    [SerializeField]
    CountButton _countButton;

    [SerializeField]
    ChangeColor _child;

    [SerializeField]
    float _substractAlphaValue = 0.1f;

    void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        if (_child == this) _child = null;
        print(CountButton._count);
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        //SubtractAlpha(_substractAlphaValue);
        CountUp();
    }

    void CountUp()
    {
        if (_child != null)
        {
            _child.CountUp();
        }
        CountButton._count++;
        print(CountButton._count);
    }

    public void OnClick()
    {
        for (int i = 0; i < CountButton._count; i++)
        {
            print(i + "回実行された");
            SubtractAlpha(_substractAlphaValue);
        }
        print(CountButton._count);
        //SubtractAlpha(_substractAlphaValue);
    }


    void SubtractAlpha(float value)
    {
        var setColor = _renderer.material.color;
        setColor.b -= value;

        _renderer.material.color = setColor;

        if (_child != null)
        {
            _child.SubtractAlpha(value * 0.5f);
        }
        //print("ChangeColor");
    }
}
