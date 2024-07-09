using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private List<ListSeed> seedData;
    private List<ListFertilizer> fertilizerData;

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

            seedData = new List<ListSeed>();
            fertilizerData = new List<ListFertilizer>();

            LoadGameData();
        }
    }

    private void OnApplicationQuit()
    {
        SaveGameData();
    }

    private void LoadGameData()
    {
        LoadSeedData();
        LoadFertilizerData();

        Debug.Log("Game data loaded!");
    }

    private void LoadSeedData()
    {
        int count = PlayerPrefs.GetInt("SeedDataCount", 0);
        seedData.Clear();

        for (int i = 0; i < count; i++)
        {
            string key = $"SeedData_{i}";
            string dataJson = PlayerPrefs.GetString(key, "");
            if (!string.IsNullOrEmpty(dataJson))
            {
                ListSeed seed = JsonUtility.FromJson<ListSeed>(dataJson);
                seedData.Add(seed);
            }
        }
    }

    private void LoadFertilizerData()
    {
        int count = PlayerPrefs.GetInt("FertilizerDataCount", 0);
        fertilizerData.Clear();

        for (int i = 0; i < count; i++)
        {
            string key = $"FertilizerData_{i}";
            string dataJson = PlayerPrefs.GetString(key, "");
            if (!string.IsNullOrEmpty(dataJson))
            {
                ListFertilizer fertilizer = JsonUtility.FromJson<ListFertilizer>(dataJson);
                fertilizerData.Add(fertilizer);
            }
        }
    }

    private void SaveGameData()
    {
        SaveSeedData();
        SaveFertilizerData();

        Debug.Log("Game data saved!");
    }

    private void SaveSeedData()
    {
        PlayerPrefs.SetInt("SeedDataCount", seedData.Count);

        for (int i = 0; i < seedData.Count; i++)
        {
            string key = $"SeedData_{i}";
            string dataJson = JsonUtility.ToJson(seedData[i]);
            PlayerPrefs.SetString(key, dataJson);
        }
    }

    private void SaveFertilizerData()
    {
        PlayerPrefs.SetInt("FertilizerDataCount", fertilizerData.Count);

        for (int i = 0; i < fertilizerData.Count; i++)
        {
            string key = $"FertilizerData_{i}";
            string dataJson = JsonUtility.ToJson(fertilizerData[i]);
            PlayerPrefs.SetString(key, dataJson);
        }
    }

    public void UpdateGameData(List<ListSeed> newSeedData, List<ListFertilizer> newFertilizerData)
    {
        seedData = newSeedData;
        fertilizerData = newFertilizerData;

        SaveGameData();
    }

    public void UseSeed(int index, int amount)
    {
        if (index >= 0 && index < seedData.Count)
        {
            seedData[index].number_seed -= amount;
            Debug.Log("Used " + amount + " seeds of " + seedData[index].name_seed);
            SaveGameData();
        }
    }

    public void UseFertilizer(int index, int amount)
    {
        if (index >= 0 && index < fertilizerData.Count)
        {
            fertilizerData[index].number_fertilizer -= amount;
            Debug.Log("Used " + amount + " units of " + fertilizerData[index].name_fertilizer);
            SaveGameData();
        }
    }

    public int GetRemainingSeeds(int index)
    {
        if (index >= 0 && index < seedData.Count)
        {
            return seedData[index].number_seed;
        }
        return 0;
    }

    public int GetRemainingFertilizer(int index)
    {
        if (index >= 0 && index < fertilizerData.Count)
        {
            return fertilizerData[index].number_fertilizer;
        }
        return 0;
    }
}
