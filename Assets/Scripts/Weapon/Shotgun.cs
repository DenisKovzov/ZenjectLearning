using UnityEngine;

public class Shotgun : IWeapon
{
    private BulletFactory bulletFactory;

    public Shotgun(BulletFactory bulletFactory)
    {
        this.bulletFactory = bulletFactory;
        Debug.Log($"Shotgun with {bulletFactory.GetType()}");
    }
}
