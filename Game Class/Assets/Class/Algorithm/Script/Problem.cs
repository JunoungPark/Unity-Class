using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;
    public string input;
    public bool condition;
    public int [] array;

    // ���׼� �˰���
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
            value = "���׼�";
        }
        else
        {
            value = "���׼��� �ƴմϴ�.";
        }

        answer.text = value;
     */

    // ȸ�� �Ǻ� �˰���
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
            answer.text = "ȸ��";
        }
        else
        {
            answer.text = "ȸ���� �ƴմϴ�.";
        }

    */

    // ���α׷��ӽ� 1 �ܰ�
    // ������������ ----> �������    
    // �Ϻ��� ���ڿ� �Ǻ��ϱ�
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
            answer.text = "�Ϻ��� ���ڿ�";
        }
        else
        {
            answer.text = "�Ϻ��� ���ڿ��� �ƴմϴ�.";
        }

     
    */

    // �ߺ����� �ʴ� ���� ��
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
    */

    private void Start()
    {      
  

    }

   
}
