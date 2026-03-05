using System;

Console.WriteLine(@$"
=== RGB 색상 밝기 계산 ===
빨강 - R: 255, G: 0, B: 0 → 밝기: {new ColorRGB(255, 0, 0).GetBrightness()}
흰색 - R: 255, G: 255, B: 255 → 밝기: {new ColorRGB(255, 255, 255).GetBrightness()}
커스텀 - R: 100, G: 150, B: 200 → 밝기: {new ColorRGB(100, 150, 200).GetBrightness()}");