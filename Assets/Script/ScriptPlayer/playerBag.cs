using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBag : MonoBehaviour
{
    public static playerBag instance;
    public List<ListSeed> flowerName;
    public List<ListFertilizer> fertilizerName;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            flowerName = new List<ListSeed>();
            fertilizerName = new List<ListFertilizer>();

            LoadSavedData();
        }
    }

    private void LoadSavedData()
    {
        LoadFlowerNameData();
        LoadFertilizerNameData();

        Debug.Log("Player bag data loaded!");
    }

    private void LoadFlowerNameData()
    {
        int count = PlayerPrefs.GetInt("FlowerNameCount", 0);
        flowerName.Clear();

        for (int i = 0; i < count; i++)
        {
            string key = $"FlowerName_{i}";
            string dataJson = PlayerPrefs.GetString(key, "");
            if (!string.IsNullOrEmpty(dataJson))
            {
                ListSeed seed = JsonUtility.FromJson<ListSeed>(dataJson);
                flowerName.Add(seed);
            }
        }
    }

    private void LoadFertilizerNameData()
    {
        int count = PlayerPrefs.GetInt("FertilizerNameCount", 0);
        fertilizerName.Clear();

        for (int i = 0; i < count; i++)
        {
            string key = $"FertilizerName_{i}";
            string dataJson = PlayerPrefs.GetString(key, "");
            if (!string.IsNullOrEmpty(dataJson))
            {
                ListFertilizer fertilizer = JsonUtility.FromJson<ListFertilizer>(dataJson);
                fertilizerName.Add(fertilizer);
            }
        }
    }

    public void SaveData()
    {
        SaveFlowerNameData();
        SaveFertilizerNameData();

        Debug.Log("Player bag data saved!");
    }

    private void SaveFlowerNameData()
    {
        PlayerPrefs.SetInt("FlowerNameCount", flowerName.Count);

        for (int i = 0; i < flowerName.Count; i++)
        {
            string key = $"FlowerName_{i}";
            string dataJson = JsonUtility.ToJson(flowerName[i]);
            PlayerPrefs.SetString(key, dataJson);
        }
    }

    private void SaveFertilizerNameData()
    {
        PlayerPrefs.SetInt("FertilizerNameCount", fertilizerName.Count);

        for (int i = 0; i < fertilizerName.Count; i++)
        {
            string key = $"FertilizerName_{i}";
            string dataJson = JsonUtility.ToJson(fertilizerName[i]);
            PlayerPrefs.SetString(key, dataJson);
        }
    }

    

   


    public void UseFertilizer(int index, int amount)
    {
        if (index >= 0 && index < fertilizerName.Count)
        {
            fertilizerName[index].number_fertilizer -= amount;
            GameManager.instance.UseFertilizer(index, amount); // Update GameManager with the change
            SaveData(); // Save player bag data
        }
    }

    public int GetRemainingSeeds(int index)
    {
        if (index >= 0 && index < flowerName.Count)
        {
            return flowerName[index].number_seed;
        }
        return 0;
    }

    public int GetRemainingFertilizer(int index)
    {
        if (index >= 0 && index < fertilizerName.Count)
        {
            return fertilizerName[index].number_fertilizer;
        }
        return 0;
    }

    private void OnApplicationQuit()
    {
        SaveData(); // Ensure data is saved when the application quits
    }
}
