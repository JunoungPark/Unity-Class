using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void SceneSetting(string name)
    {
        // 씬을 이동하는 함수입니다.
        // 매개 변수로 씬의 이름을 문자열로 설정합니다.
        SceneManager.LoadScene(name);
    }
}
