using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gledanje : MonoBehaviour
{
    [SerializeField]
    private Transform Igrac, Kamere;   //Koji igrac i kole kamere

    [SerializeField]
    private bool invert;   //Mogucnost zamene vrednosti na x osi

    [SerializeField]
    private float sensitivity = 5f;  //Osetljivost misa

    [SerializeField]
    private Vector2 look_limit = new Vector2(-70f, 80f);  //Koliko mozemo da pogledamo gore ili dole

    private Vector2 look_angles;   //Koliko treba kamera da se rotira da bi gledala u misa
    private Vector2 current_mouse_look;   //Gde trenutno mis pokazuje

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  //Mis je za vreme igre koncentrisan u sredini slike
       
    }


    void Update()
    {
        LockAndUnlockCursor();
        if (Cursor.lockState == CursorLockMode.Locked)   //Ako je mis koncentrisan onda mozemo da gledamo
        {
            LookAround();
        }
       
            sensitivity = 5f;
    }

    void LockAndUnlockCursor()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  //Ako pritisnemo Esc
        {
            if (Cursor.lockState == CursorLockMode.Locked)  //Ako je bio koncentrisan više ne treba da bude
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else  //Ako nije bio onda treba da bude kao i da bude nevidljiv
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    void LookAround()
    {
        current_mouse_look = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));   //Gde se mis nalazi
        look_angles.x += current_mouse_look.x * sensitivity * (invert ? 1f : -1f);  //Kako se rotira kamera po x osi da dodje do misa
        look_angles.y += current_mouse_look.y * sensitivity;  //Kako se rotira kamera po y osi da dodje do misa
        look_angles.x = Mathf.Clamp(look_angles.x, look_limit.x, look_limit.y);   //Koliko igrac sme da pogleda na gore ili dole
        Kamere.localRotation = Quaternion.Euler(look_angles.x, 0f, 0f);    //Kako da se rotiraju kamere
        Igrac.localRotation = Quaternion.Euler(0f, look_angles.y, 0f);    //Kako da se rotira igrac
    }

}
