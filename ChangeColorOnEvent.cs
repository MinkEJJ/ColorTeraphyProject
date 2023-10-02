
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO;

public class ChangeColorOnEvent : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[9];
    private Color[] colors = new Color[9];
    private SpriteRenderer spriteRenderer;

    public void analysis_script() // 사용자의 선택 색상 분석 시작 함수
    {
        //string path = "C:/Users/juj94/Desktop/colorrgb.txt";//메모장
        //string directory = Path.GetDirectoryName(path);
        //if (!Directory.Exists(directory))
        //{
        //    Directory.CreateDirectory(directory);
        //}
        for (int i = 0; i < gameObjects.Length; i++)//h1~h9까지의 포함되어 있는 spriterenderer의 color 매개변수의 값을 하나씩 가져옴.
        {
            SpriteRenderer spriteRenderer = gameObjects[i].GetComponent<SpriteRenderer>();

            if (spriteRenderer != null) 
            {
                colors[i] = spriteRenderer.color;
                //string content = $"{i}객체의 색상은 : {colors[i]}\n";
                //File.AppendAllText(path, content);


                if (spriteRenderer == null)
                {
                    Debug.Log("객체가 비어있어");
                }
            }
        }
    }

    void Start()
    {
        // GameObject에 attach된 SpriteRenderer 컴포넌트를 얻습니다.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 좌클릭을 감지
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            // 클릭한 곳에 GameObject가 있으면
            if (hit.collider != null)
            {
                // 해당 GameObject가 현재 GameObject인지 확인
                if (hit.collider.gameObject == this.gameObject)
                {
                    // 색상 변경
                    GetComponent<SpriteRenderer>().color = ColorManager.CurrentColor;
                }
            }
        }
    }
}
