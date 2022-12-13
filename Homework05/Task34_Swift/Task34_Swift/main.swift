//
//  main.swift
//  Task34_Swift
//
//  Created by Daniil Rassadin on 13/12/22.
//

import Foundation

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = createArray(with: 10, minValue: 100, maxValue: 999)
print(array)
print("В массиве \(countOfEvenNumber(in: array)) чётных чисел.")

