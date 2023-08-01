using UnityEngine;
using Zenject;

public class Enemy : MonoBehaviour
{
    private IWeapon weapon;
    private Player player;

    [Inject]
    public void Construct(IWeapon weapon, Player player)
    {
        this.weapon = weapon;
        this.player = player;
        Debug.Log($"Enemy, weapon {weapon.GetType()}, player {player.name}");
    }
}
