using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;
    public string input;
    public bool condition;
    public int [] array=new int[5];
    int value;

    // 과잉수 알고리즘
    /*  
        for(int i = 1; i < variable; i++)
        {
            if(variable % i == 0)
            {
                result += i;
            }
        }

        if (result > variable)
        {
            value = "과잉수";
        }
        else
        {
            value = "과잉수가 아닙니다.";
        }

        answer.text = value;
     */

    // 회문 판별 알고리즘
    /*
      public string variable = "level";
      public int result = 0;
      
      for (int i = 0; i < variable.Length / 2; i++)
        {
            if (variable[i] == variable[variable.Length - 1 - i])
            {
                result++;
            }
        }

        if (result == variable.Length / 2)
        {
            answer.text = "회문";
        }
        else
        {
            answer.text = "회문이 아닙니다.";
        }

    */

    // 프로그래머스 1 단계
    // 포토폴리오만 ----> 기술면접    
    // 완벽한 문자열 판별하기
    /*
      for (int i = 0; i < input.Length; i++)
        {
            for (int j = 48; j < 58; j++)
            {
                if (input[i] == (char)j)
                {
                    condition = true;
                }
            }
        }

        if (condition == false)
        {
            answer.text = "완벽한 문자열";
        }
        else
        {
            answer.text = "완벽한 문자열이 아닙니다.";
        }

     
    */

    // 중복되지 않는 랜덤 값
    /*
      for(int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 6);

            for(int j = 0; j < i; j++)
            {   
                if(array[i] == array[j])
                {
                    i--;
                }
            }
        }

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    //나머지로 떨어진 수의 갯수 구하기
    */

    private void Update()
    {
        value = 0;
        for (int i = 0; i < 36; i++) {
            for (int j = 0; j<5; j++) {
                if (array[j] % 36 == i)
                {
                    value++;
                    break;
                }
            }
        }
        answer.text = value.ToString();
    }

   
}
