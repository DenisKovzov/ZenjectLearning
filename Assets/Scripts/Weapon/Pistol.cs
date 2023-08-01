using UnityEngine;

public class Pistol : IWeapon
{
    private BulletFactory bulletFactory;

    public Pistol(BulletFactory bulletFactory)
    {
        this.bulletFactory = bulletFactory;
        Debug.Log($"Pistol with {bulletFactory.GetType()}");
    }
}
