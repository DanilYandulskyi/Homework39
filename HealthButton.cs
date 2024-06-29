using UnityEngine;
using System.Collections.Generic;

public class HealthButton : MonoBehaviour
{
    [SerializeField] private List<Health> _healthList;

    public void DecreaseHealth()
    {
        foreach (Health health in _healthList)
        {
            health.Decrease(1);
        }
    }

    public void IncreaseHealth()
    {
        foreach (Health health in _healthList)
        {
            health.Increase(1);
        }
    }
}
