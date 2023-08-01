using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private IWeapon weapon;
    private IInput input;

    [Inject]
    public void Construct(IWeapon weapon, IInput input)
    {
        this.weapon = weapon;
        this.input = input;
        Debug.Log($"Player, weapon {weapon.GetType()}, input {input.GetType()}");
    }
}
