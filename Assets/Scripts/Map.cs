using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void LoadFarmStage()
    {

    }

    public void LoadHouseStage()
    {

    }

    public void LoadSchoolStage()
    {

    }

    public void LoadForestStage()
    {
        SceneManager.LoadScene("Forest001");
        AnimalNamesQuestionBank.LoadQuestionList();
    }

}
