using System;
using System.Linq;

InventoryItem[] inventory = new InventoryItem[5];
inventory[0] = new InventoryItem("검", 3.5, 1500);
inventory[1] = new InventoryItem("방패", 5, 1200);
inventory[2] = new InventoryItem("포션", 0.3, 50);
inventory[3] = new InventoryItem("활", 1.8, 1300);
inventory[4] = new InventoryItem("투구", 2, 800);

double totalWeight = 0;
int totalPrice = 0;
int minWeightItemIdx = 0;
int maxPriceItemIdx = 0;

Console.WriteLine("=== 인벤토리 목록 ===");
for (int i = 0; i < inventory.Length; i++)
{
    Console.WriteLine($"{inventory[i].Name} - 무게: {inventory[i].Weight}, 가격: {inventory[i].Price}");

    totalWeight += inventory[i].Weight;
    totalPrice += inventory[i].Price;

    minWeightItemIdx = inventory[minWeightItemIdx].Weight > inventory[i].Weight ? i : minWeightItemIdx;
    maxPriceItemIdx = inventory[maxPriceItemIdx].Price < inventory[i].Price ? i : maxPriceItemIdx;
}

Console.WriteLine(@$"
=== 인벤토리 통계 ===
전체 무게: {totalWeight:f1}kg
전체 가격: {totalPrice:f0}골드
평균 가격: {totalPrice / inventory.Length:f0}골드
가장 비싼 아이템: {inventory[maxPriceItemIdx].Name}
가장 가벼운 아이템: {inventory[minWeightItemIdx].Name}");
