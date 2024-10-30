using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_2 : GunBase
{
    [SerializeField] Transform[] bulletPoints;
    [SerializeField] BulletBase bulletBasePrefabs;

    public override void Shoot()
    {
        base.Shoot();

        for (int i = 0; i < bulletPoints.Length; i++)
        {
            //BulletBase b = Instantiate(bulletBasePrefabs, bulletPoints[i].position, bulletPoints[i].rotation);
            BulletBase b = SimplePool.Spawn<BulletBase>(PoolType.Bullet_2, bulletPoints[i].position, bulletPoints[i].rotation);
            b.OnInit(10);
        }
    }
}
