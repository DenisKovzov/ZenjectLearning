using System;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Player playerPrefab;
    [SerializeField] private Transform playerStartPoint;

    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Transform enemyStartPoint;
    public override void InstallBindings()
    {
        BindWeapon();
        BindBulletFactory();
        BindPlayer();
        BindEnemy();
    }


    private void BindPlayer()
    {
        Player player = Container.InstantiatePrefabForComponent<Player>(playerPrefab, playerStartPoint.position, Quaternion.identity, null);

        Container.
            Bind<Player>().
            FromInstance(player).
            AsSingle();
    }
    private void BindEnemy()
    {
        Container.InstantiatePrefabForComponent<Enemy>(enemyPrefab, enemyStartPoint.position, Quaternion.identity, null);
    }

    private void BindWeapon()
    {
        Container.
            Bind<IWeapon>().
            To<Pistol>().
            AsSingle().
            WhenInjectedInto<Player>();
        Container.
            Bind<IWeapon>().
            To<Shotgun>().
            AsTransient().
            WhenInjectedInto<Enemy>();
    }
    private void BindBulletFactory()
    {
        Container.Bind<BulletFactory>().FromNew().AsSingle();
    }
}
