using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject _robot;
    [SerializeField] private GameObject _turret;
    [SerializeField] private GameObject _komar;

    private IRobotMove robotEnemy;
    private ITurret turretEnemy;
    private IRobotMove komarEnemy;

    private void Start()
    {
        turretEnemy = _turret.GetComponent<ITurret>();
        robotEnemy = _robot.GetComponent<IRobotMove>();
        komarEnemy = _komar.GetComponent<IRobotMove>();
    }
    private void FixedUpdate()
    {
        robotEnemy?.Move();
        
        komarEnemy?.Move();
    }

}
