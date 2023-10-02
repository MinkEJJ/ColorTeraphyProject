using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect : MonoBehaviour
{
    public Text tx;
    private string m_text= "안녕하세요~!\n\n컬러링 프로그램에 온걸 환영해요!\n요즘 당신의 기분은 어떤가요?\n스케치북을 준비해두었으니 색칠로 표현해보세요.\n\n당신의 기분이 나아질 수 있도록 추천 색상도 알려줄게요.";
    bool check = false;
    private GameObject y_b;
    private GameObject d_b;
    private GameObject n_b;


    void Start()
    {
        StartCoroutine(_typing());
        y_b = GameObject.Find("yes");
        d_b = GameObject.Find("detail");
        n_b = GameObject.Find("no");

        y_b.SetActive(false);
        d_b.SetActive(false);
        n_b.SetActive(false);
    }
    void button_active() 
    {
        y_b.SetActive(true);
        d_b.SetActive(true);
        n_b.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//스페이스키를 누르면 바로 한번에 글자가 나오며 버튼도 생성됨.
        {
            check = true;
            button_active();
        }
    }

    IEnumerator _typing()//하나씩 글자가 나오는 타이핑 효과
    {
        
        for (int i = 0; i <= m_text.Length; i++)
        {
            if (check == false)
            {
                tx.text = m_text.Substring(0, i);
                yield return new WaitForSeconds(0.05f);
            }
            else 
            {
                if (check == true)
                {
                    tx.text = m_text;
                    check = false;
                    yield break;
                }
            }
        }
        button_active();//하나씩 출력되는 경우 버튼 나옴

    }
    
}
