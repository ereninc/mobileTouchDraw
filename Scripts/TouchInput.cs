using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour
{
    [SerializeField] private Text _touchInfo;
    private Touch _theTouch;
    private string _touchInfoString;

    [SerializeField] private Image image;
    private Vector2 imagePos;

    [SerializeField] private Transform parent;

    void Update()
    {
        Draw();
    }

    private void Draw() 
    {
        if (Input.touchCount > 0)
        {
            _theTouch = Input.GetTouch(0);
            imagePos.x = _theTouch.position.x;
            imagePos.y = _theTouch.position.y;
            Image myImage = Instantiate(image, imagePos, Quaternion.identity);
            myImage.transform.parent = parent.parent;
        }
        _touchInfo.text = _touchInfoString;
    }
}
