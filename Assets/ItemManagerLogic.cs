using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ItemManagerLogic : MonoBehaviour
{
    XmlNodeList itemList;
    int count;
    public GameObject prefab;
    private void Awake()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("ItemInventory");
        XmlDocument itemDataXml = new XmlDocument();
        itemDataXml.LoadXml(textAsset.text);
        itemList = itemDataXml.SelectNodes("/WeaponList/Weapon");
        count = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Weapon currentWeapon = new Weapon(itemList[count]);
            GameObject tempObject = Instantiate(prefab, transform.position, Quaternion.identity); ;
            tempObject.GetComponent<SpriteRenderer>().sprite = currentWeapon.itemImage;
            tempObject.GetComponent<SpriteRenderer>().sortingOrder = count;
            
            count++;
            if(count > 3)
            {
                count = 0;
            }
            Debug.Log("Made object");
        }
    }
    class Weapon
    {
        public string itemType { get; private set; }
        public string itemDesc { get; private set; }
        public string itemTitle { get; private set; }
        public Sprite itemImage { get; private set; }
        public Weapon(XmlNode node)
        {
            itemType = node.Attributes["Type"].Value;
            itemDesc = node["ItemDesc"].InnerText;
            itemTitle = node["ItemTitle"].InnerText;
            string imagePath = "InventoryIcons/" + node["Image"].InnerText;
            itemImage = Resources.Load<Sprite>(imagePath);
            Debug.Log("Weapon Title: " + itemTitle + " Type: " + itemType + " Description: " + itemDesc);
        }
    }
}
