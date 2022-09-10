using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawerOpenClose : MonoBehaviour, IPointerClickHandler
{
    const float distanceZ = 1f;
    Vector3 distance;
    [SerializeField] MeshRenderer LightControllerText;
    void Start()
    {
        distance = new Vector3(0, 0, distanceZ);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        TextOnOff();
        transform.localPosition += distance;
        distance *= -1f;
    }

    //電気のリモコンの文字がオブジェクト貫通して表示される
    //なのでテキストを表示/非表示切り替えして今回は対処
    void TextOnOff()
    {
        if (LightControllerText != null)
        {
            LightControllerText.enabled = !LightControllerText.enabled;
        }
    }
}
