using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinControl : MonoBehaviour
{
    public GameObject im1, im2, im3, im4, im5, im6, im7, im8, im9, ph1, ph2, ph3, ph4, ph5, ph6, ph7, ph8, ph9;

    public static bool youWin;

    public int currentLevel;

    [SerializeField]
    private GameObject flowerImage;

    void Update()
    {

        CompleteLevel();
        

    }

    public void CompleteLevel()
    {
        if (im1.transform.position == ph1.transform.position && im2.transform.position == ph2.transform.position && im3.transform.position == ph3.transform.position &&
            im4.transform.position == ph4.transform.position && im5.transform.position == ph5.transform.position && im6.transform.position == ph6.transform.position &&
            im7.transform.position == ph7.transform.position &&
            im8.transform.position == ph8.transform.position &&
            im9.transform.position == ph9.transform.position)
        {

            youWin = true;
            flowerImage.SetActive(true);
            Debug.Log("Level Completed");
            PlayerPrefs.SetInt("Level1" + currentLevel, 1);
            PlayerPrefs.Save();
        }
    }

}
