using System.Collections.Generic;
using UnityEngine;

public class EnemyCatchChecker : MonoBehaviour
{
    [SerializeField] private GameObject _finalScreen;
    [SerializeField] private List<Enemy> _enemies;

    private void End()
    {
        _finalScreen.SetActive(true);
    }

    private void OnEnable()
    {
        foreach (Enemy elem in _enemies)
        {
            elem.Died += OnEmeyDying;
        }
    }

    private void OnEmeyDying(Enemy enemy)
    {
        enemy.Died -= OnEmeyDying;
        _enemies.Remove(enemy);

        if (_enemies.Count == 0)
            End();
    }
}
