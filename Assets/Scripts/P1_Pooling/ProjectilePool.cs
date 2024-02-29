using System.Collections.Generic;
using UnityEngine;

namespace P1_Pooling
{
    public class ProjectilePool  : MonoBehaviour
    {
        public GameObject projectile;
        public int poolSize;

        private List<GameObject> projectiles;
        
        private void Start()
        {
            projectiles = new List<GameObject>();
            SetUpPool();
        }

        private void SetUpPool()
        {
            for (int i = 0; i < poolSize; i++)
            {
                GameObject bullet = Instantiate(projectile);
                bullet.SetActive(false);
                projectiles.Add(bullet);
            }
        }

        public GameObject GetPooledProjectile()
        {
            foreach (GameObject obj in projectiles)
            {
                if (!obj.activeInHierarchy)
                {
                    obj.SetActive(true);
                    return obj;
                }
            }
            return null;
        }
    }
}