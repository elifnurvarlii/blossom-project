using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementManager : MonoBehaviour
{

    public GameObject achivementPrejab;

    private void Start()
    {
        CreateAchievement("Flower Category");
    }

    public void CreateAchievement(string category)
    {
        GameObject achivement = (GameObject)Instantiate(achivementPrejab);

        SetAchievementInfo(category, achivement);
    }
         
    public void SetAchievementInfo(string category, GameObject achivement)
    {

        achivement.transform.SetParent(GameObject.Find(category).transform);

    }



}
