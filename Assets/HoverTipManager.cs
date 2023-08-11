using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HoverTipManager : MonoBehaviour
{
    public TextMeshProUGUI tipText;
    public RectTransform tipWindow;
    public InventorySystem inventorySystem;

    public static Action<string, Vector3> OnMouseHover;
    public static Action OnMouseDrop;
    public static Action<SpriteRenderer, string> OnMouseClick;

    private void OnEnable()
    {
        OnMouseHover += ShowTip;
        OnMouseDrop += HideTip;
        OnMouseClick += AddToInventory;
    }

    private void OnDisable()
    {
        OnMouseHover -= ShowTip;
        OnMouseDrop -= HideTip;
        OnMouseClick -= AddToInventory;
    }

    void Start()
    {
        HideTip();
    }

    private void ShowTip(string tip, Vector3 mousePos)
    {
        tipText.text = tip;
        tipWindow.sizeDelta = new Vector2(tipText.preferredWidth > 100 ? 100 : tipText.preferredWidth, tipText.preferredHeight);
        tipWindow.gameObject.SetActive(true);
        tipWindow.position = new Vector2(mousePos.x, mousePos.y);
    }

    private void HideTip()
    {
        tipText.text = default;
        tipWindow.gameObject.SetActive(false);
    }

    private void AddToInventory(SpriteRenderer Sprite, string Position)
    {
        GameObject gear = new GameObject(Position);
        Image gearImage = gear.AddComponent<Image>();
        gearImage.sprite = Sprite.sprite;
        gearImage.transform.localScale = new Vector3(1, 1, 1);

        switch(Position)
        {
            case "helmet":
                inventorySystem.setHelmet(gearImage);
                break;
            case "chest":
                inventorySystem.setChest(gearImage);
                break;
            case "boots":
                inventorySystem.setBoots(gearImage);
                break;
            case "gloves":
                inventorySystem.setGloves(gearImage);
                break;
            case "ring":
                inventorySystem.setRing(gearImage);
                break;
            case "amulet":
                inventorySystem.setAmulet(gearImage);
                break;
            case "belt":
                inventorySystem.setBelt(gearImage);
                break;
            case "passive":
                inventorySystem.setPassive(gearImage);
                break;
            case "weapon":
                inventorySystem.setWeapon(gearImage);
                break;
        }
    }

}
