//
//  main.swift
//  Task38_Swift
//
//  Created by Daniil Rassadin on 13/12/22.
//

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

import Foundation

var array = createArrayWithDoubles(count: 5, minValue: 1, maxValue: 5, digits: 2)
print(array)

if let diff = diffBetweenMaxAndMin(in: array) {
    print("Разница между максимальным и минимальным элементами: \(round(diff * 100) / 100)")
} else {
    print("Массив пустой.")
}


