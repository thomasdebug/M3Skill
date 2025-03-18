using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;

    void Update()
    {
        
    }

    private void Bin2Dec()
    {
        value = 0;
        if (bits[0].state) { value += 1; }
        if (bits[1].state) { value += 2; }
        if (bits[2].state)  {value += 4; }
        if (bits[3].state) { value += 8; }
        if (bits[4].state) { value += 16; }
        if (bits[5].state) { value += 32; }
        if (bits[6].state) { value += 64; }
        if (bits[7].state) { value += 128; }
    }

    public void setValue(int myValue) 
    {
        if (myValue > 255) 
        {
            myValue = 255;
        }
        value = myValue;
        if (myValue >= 128) 
        {
            bits[7].state = true;
            myValue -= 128; 
        }
        else
        {
            bits[7].state = false;
        }
        if (myValue >= 64)
        {
            bits[6].state = true;
            myValue -= 64;
        }
        else
        {
            bits[6].state = false;
        }
        if(myValue >= 32) 
        {
            bits[5].state = true;
            myValue -= 32;
        }
        else
        {
            bits[5].state = false;
        }
        if (myValue >= 16)
        {
            bits[4].state = true;
            myValue -= 16;
        }
        else
        {
            bits[4].state = false;
        }
        if (myValue >= 8)
        {
            bits[3].state = true;
            myValue -= 8;
        }
        else
        {
            bits[3].state = false;
        }
        if (myValue >= 4)
        {
            bits[2].state = true;
            myValue -= 4;
        }
        else
        {
            bits[2].state = false;
        }
        if (myValue >= 2)
        {
            bits[1].state = true;
            myValue -= 2;
        }
        else
        {
            bits[1].state = false;
        }
        if (myValue >= 1)
        {
            bits[0].state = true;
            myValue -= 1;
        }
        else
        {
            bits[0].state = false;
        }
    }
}
