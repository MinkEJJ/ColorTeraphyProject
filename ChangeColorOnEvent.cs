
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO;

public class ChangeColorOnEvent : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[9];
    private Color[] colors = new Color[9];
    private SpriteRenderer spriteRenderer;

    public Color red = new Color(1f, 0.604f, 0.635f, 1f); // 빨간색을 나타내는 Color 객체
    public Color orange = new Color(1f, 0.855f, 0.757f, 1f); // 주황색을 나타내는 Color 객체
    public Color yellow = new Color(1f, 1f, 0.847f, 1f); // 노랑색을 나타내는 Color 객체
    public Color green = new Color(0.710f, 0.918f, 0.843f, 1f); // 초록색을 나타내는 Color 객체
    public Color blue = new Color(0.745f, 0.918f, 0.980f, 1f); // 파랑색을 나타내는 Color 객체
    public Color navy = new Color(0.361f, 0.690f, 0.878f, 1f); // 남색을 나타내는 Color 객체
    public Color purple = new Color(0.780f, 0.808f, 0.918f, 1f); // 보라색을 나타내는 Color 객체
    public Color pink = new Color(1f, 0.718f, 0.698f, 1f); // 분홍색을 나타내는 Color 객체
    public Color white = new Color(1f, 1f, 1f, 1f); // 흰색을 나타내는 Color 객체

    public int redCount = 0; // 빨간색 카운트 변수
    public int orangeCount = 0; // 주황색 카운트 변수
    public int yellowCount = 0; // 노랑색 카운트 변수
    public int greenCount = 0; // 초록색 카운트 변수
    public int blueCount = 0; // 파랑색 카운트 변수
    public int navyCount = 0; // 남색 카운트 변수
    public int purpleCount = 0; // 보라색 카운트 변수
    public int pinkCount = 0; // 분홍색 카운트 변수
    public int whiteCount = 0; // 흰색 카운트 변수

    bool IsApproximatelyEqual(Color a, Color b, float tolerance = 0.01f)//IsApproximatelyEqual 함수는 두 Color 객체가 허용된 오차 범위 내에서 동일한지 확인합니다.tolerance 매개변수는 두 색상 값 사이의 최대 허용 차이를 지정합니다.이 값을 조절하여 비교의 정밀도를 변경할 수 있습니다.

    {
        return Mathf.Abs(a.r - b.r) < tolerance &&
               Mathf.Abs(a.g - b.g) < tolerance &&
               Mathf.Abs(a.b - b.b) < tolerance &&
               Mathf.Abs(a.a - b.a) < tolerance;
    }
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
                Debug.Log(colors[i]);
                //string content = $"{i}객체의 색상은 : {colors[i]}\n";
                //File.AppendAllText(path, content);
                if (IsApproximatelyEqual(colors[i], red)) // GameObject의 색상이 빨간색과 일치하면
                {
                    redCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i], orange)) // GameObject의 색상이 빨간색과 일치하면
                {
                    orangeCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i], yellow)) // GameObject의 색상이 빨간색과 일치하면
                {
                    yellowCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i], green))// GameObject의 색상이 빨간색과 일치하면
                { 
                    greenCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i], blue)) // GameObject의 색상이 빨간색과 일치하면
                {
                    blueCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i],navy)) // GameObject의 색상이 빨간색과 일치하면
                {
                    navyCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i], purple)) // GameObject의 색상이 빨간색과 일치하면
                {
                    purpleCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (IsApproximatelyEqual(colors[i], pink)) // GameObject의 색상이 빨간색과 일치하면
                {
                    pinkCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else if (colors[i] == white) // GameObject의 색상이 빨간색과 일치하면
                {
                    whiteCount++; // 빨간색 카운트를 증가시킵니다.
                }

                else
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
