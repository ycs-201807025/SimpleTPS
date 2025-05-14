using DesignPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 10)]
    public float WalkSpeed { get; set; }

    [field: SerializeField]
    [field: Range(0, 10)]
    public float RunSpeed { get; set; }

    [field: SerializeField]
    [field: Range(0, 10)]
    public float RotateSpeed { get; set; }

    public ObserbableProperty<bool> IsAiming { get; private set; } = new ObserbableProperty<bool>();
    public ObserbableProperty<bool> IsMoving { get; private set; } = new ObserbableProperty<bool>();
    public ObserbableProperty<bool> IsAttacking { get; private set; } = new ObserbableProperty<bool>();
}
