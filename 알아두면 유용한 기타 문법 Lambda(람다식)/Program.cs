using System;
using System.Collections.Generic;

namespace 알아두면_유용한_기타_문법_Lambda_람다식_
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate bool ItemSelector(Item item);
        
        
        
        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }
        // 위의 방식을 사용하더라도 selector 함수들은 작성해주어야함
        // ex. Findweapon FindRare ...
        // 이를 막기 위해 일회용 함수를 사용 

        // 아래 방식은 비효율적
        // Find에 관련된 모든 함수를 만드는 방식
        /*static Item FindWeapon()
        {
            foreach (Item item in _items)
            {
                if (item.ItemType == ItemType.Weapon)
                    return item;
            }
            return null;
        }

        static Item FindRareItem()
        {
            foreach (Item item in _items)
            {
                if (item.Rarity == Rarity.Rare)
                    return item;
            }
            return null;
        }*/

        //더 일반화도 가능
        delegate Return MyFunc<T, Return>(T item);
        delegate Return MyFunc<T1, T2, Return>(T1 item1, T2 item2);
        delegate Return MyFunc<Return>();

        static Item FindItems(Func<Item, bool> selector)
        {
            foreach(Item item in _items)
            {
                if (selector(item))
                {
                    return item;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            // Lambda : 일회용 함수를 만드는데 사용하는 문법

            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            

            //이것은 무명함수 / 익명함수 람다식x
            Item item = FindItem(delegate (Item item)
            {
                return item.ItemType == ItemType.Weapon;
            });

            //아래가 람다식
            Item item2 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });

            // delegate를 직접 선언하지 않아도 이미 선언된 것이 존재
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없을 경우 Action
        }
    }
}
