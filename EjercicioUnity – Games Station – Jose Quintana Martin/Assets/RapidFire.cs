using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RapidFire : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] float buttonHeldTime;
    [SerializeField] float fireRate;
    [SerializeField] UnityEvent onHoldButton;

    float heldTimer;
    float fireTimer;
    bool isButtonHeld;
    bool buttonClick;

    public void OnPointerDown(PointerEventData eventData)
    {
        onHoldButton.Invoke();
        buttonClick = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isButtonHeld)
        {
            Spawner.instance.DestroyAllSpheres();
        }

        isButtonHeld = false;
        heldTimer = 0;
        buttonClick = false;
    }

    private void Update()
    {
        if (buttonClick)
        {
            heldTimer += Time.deltaTime;

            if (heldTimer >= buttonHeldTime)
            {
                isButtonHeld = true;
            }

            if (isButtonHeld)
            {
                fireTimer += Time.deltaTime;

                if (fireTimer >= fireRate)
                {
                    onHoldButton.Invoke();
                    fireTimer = 0;
                }
            }
        }
    }
}
