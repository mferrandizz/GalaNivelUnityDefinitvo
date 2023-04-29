using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public LogicaMovimiento logicaMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        logicaMovimiento.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        logicaMovimiento.puedoSaltar = false;
    }
}
