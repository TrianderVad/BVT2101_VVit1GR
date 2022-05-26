using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VivodVUI : MonoBehaviour
{
    public Cart cart;
    public Text speed;
    public Text Help;
    private string curspeed;
    private bool kost = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Help.text = "Для появления подсказки нажмите кнопку 'H'";
    }

    // Update is called once per frame
    void Update()
    {
        curspeed = cart.current_speed.ToString();
        speed.text = curspeed;
        if (Input.GetKeyDown(KeyCode.H))
        {
            ChangeText();
        }
    }
    void ChangeText()
    {
        if (kost == false)
        {
            Help.text = "Для появления подсказки нажмите кнопку 'H'";
            kost = true;
            
        }
        else
        {
            Help.text = "1 - Вид Сверху (Указание Точки) \n2 - Вращение Камеры вокруг Авто\n'H' - Закрыть подсказку";
            kost = false;
            
        }
    }
}

