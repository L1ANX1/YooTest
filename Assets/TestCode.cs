using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class TestCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaEnv luaenv = new LuaEnv();
        luaenv.DoString("print('hello world')");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
