//
//  main.swift
//  Task36_Swift
//
//  Created by Daniil Rassadin on 13/12/22.
//

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

import Foundation

var array = createArray(with: 2, minValue: -10, maxValue: 10)
print(array)

if let int = sumOfOddIndexElement(in: array) {
    print("Сумма элементов массива с нечётными индексами: \(int).")
} else {
    print("В массиве нет нечётных индексов.")
}

//print("Сумма элементов массива с нечётными индексами: \(sumOfOddIndexElement(in: array)).")
