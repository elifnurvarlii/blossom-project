using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementManager : MonoBehaviour
{

    public GameObject[] achievementIcons; // Her seviyeye karşılık gelen ikonlar

    void Start()
    {
        for (int i = 0; i < achievementIcons.Length; i++)
        {
            // Kaydedilen seviyeleri kontrol ediyoruz
            if (PlayerPrefs.GetInt("Level" + i, 0) == 1)
            {
                // Seviye tamamlandıysa ikonu aktif hale getiriyoruz
                achievementIcons[i].SetActive(true);
                Debug.Log("Level1 tamamlandı");
            }
            else
            {
                // Seviye tamamlanmadıysa ikonu gizli tutuyoruz
                achievementIcons[i].SetActive(false);
            }
        }
    }


}
