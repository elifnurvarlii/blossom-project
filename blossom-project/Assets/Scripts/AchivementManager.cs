using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementManager : MonoBehaviour
{

    public GameObject achivementPrejab;

    public Sprite[] sprites;

    private void Start()
    {
        CreateAchievement("Flower Category", "Test" , 1);
    }


    public void CreateAchievement(string category, string title, int spriteIndex)
    {

        GameObject achivement = (GameObject)Instantiate(achivementPrejab);

        SetAchievementInfo(category, achivement, title, spriteIndex);
    }

    
    public void SetAchievementInfo(string category, GameObject achivement, string title, int spriteIndex)
    {

        achivement.transform.SetParent(GameObject.Find(category).transform);
        achivement.transform.localScale = new Vector3(1, 1, 1);
        achivement.transform.GetChild(0).GetComponent<Image>().sprite = sprites[spriteIndex];
        achivement.transform.GetChild(1).GetComponent<Text>().text = title;

    }



}
