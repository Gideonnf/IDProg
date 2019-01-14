using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyCtrl : MonoBehaviour {

    public Text printOut;
    public Canvas canvas;

    [SerializeField]
    private Image ImgFG;
    [SerializeField]
    private Image ImgBG;

	// Use this for initialization
	void Start () {
        ImgBG = GetComponent<Image>();
        ImgFG = transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void Dragging()
    {
        Vector3 newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        ImgFG.rectTransform.position = newPos;

        // float gamePos = ImgBG.rectTransform.rect.position.x * canvas.scaleFactor;
        // newPos.x = Mathf.Clamp(newPos.x, gamePos - ImgBG.rectTransform.rect.width,
        //    gamePos + ImgBG.rectTransform.rect.width);
        //newPos.y = Mathf.Clamp(newPos.y, ImgBG.rectTransform.rect.position.y - ImgBG.rectTransform.rect.width,
        //  ImgBG.rectTransform.rect.position.y + ImgBG.rectTransform.rect.width);


        float xLimit = Mathf.Clamp(ImgFG.rectTransform.anchoredPosition.x, -50, 50);
        float yLimit = Mathf.Clamp(ImgFG.rectTransform.anchoredPosition.y, -50, 50);

        ImgFG.rectTransform.anchoredPosition = new Vector3(xLimit, yLimit, 1);


        Debug.Log("x: " + Input.mousePosition.x + "y: " + Input.mousePosition.y);
        //printOut.text = "x: " + Input.mousePosition.x + "y: " + Input.mousePosition.y;
    }

    public void ReturnOrigin()
    {
        ImgFG.rectTransform.anchoredPosition = new Vector3(0, 0, 1);
    }

}
