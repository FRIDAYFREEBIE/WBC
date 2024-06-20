using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutProjectile : Projectile
{
    public BasicProjectile basicProjectile;
    public int speed = 5;

    public override void Action()
    {
        target = basicProjectile.target;
        
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.transform.position) < 0.1f)
        {
            HitTarget();
        }
    }
}
