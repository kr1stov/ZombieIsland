using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public  static GameManager Instance = null;

    private List<Zombie> _zombies;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        InitLists();
    }

    private void Update()
    {
        UpdateZombies();
    }

    private void InitLists()
    {
        _zombies = new List<Zombie>();
    }

    public void RegisterGameEntity(GameEntity entity)
    {
        if (entity is Zombie)
            _zombies.Add((Zombie)entity);
    }

    public void UnregisterGameEntity(GameEntity entity)
    {
        if (entity is Zombie)
            _zombies.Remove((Zombie)entity);
    }

    public void UpdateZombies()
    {
        foreach (var zombie in _zombies)
        {
            zombie.UpdateSelf();
        }
    }
}
